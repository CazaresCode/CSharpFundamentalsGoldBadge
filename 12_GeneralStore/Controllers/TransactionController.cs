using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class TransactionController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Post(Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                Product product = await _context.Products.FindAsync(transaction.ProductId);
                if (product == null)
                    return BadRequest("Invalid product ID.");

                Customer customer = await _context.Customers.FindAsync(transaction.CustomerId);
                if (product == null)
                    return BadRequest("Invalid product ID.");

                if (transaction.PurchaseQuantity > product.Quantity)
                    return BadRequest($"There is only {product.Quantity} left in stock.");

                product.Quantity -= transaction.PurchaseQuantity;

                transaction.DateOfTransaction = DateTime.Now;
                _context.Transactions.Add(transaction);
                await _context.SaveChangesAsync();
                return Ok();
            }

            return BadRequest(ModelState);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Transaction> transactions = await _context.Transactions.ToListAsync();
            return Ok(transactions);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Transaction transaction = await _context.Transactions.FindAsync(id);
            if (transaction == null)
            {
                return NotFound();
            }

            return Ok(transaction);
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateTransaction([FromUri] int id, [FromBody] Transaction newTransaction)
        {
            if (ModelState.IsValid)
            {
                // Sticky situation with the stock product calculations, hence the new up of Product and CUstomer object.
                Product product = await _context.Products.FindAsync(newTransaction.ProductId);
                if (product == null)
                    return BadRequest("Invalid Product ID.");

                Customer customer = await _context.Customers.FindAsync(newTransaction.CustomerId);
                if (customer == null)
                    return BadRequest("Invalid Product ID.");

                Transaction oldTransaction = await _context.Transactions.FindAsync(id);
                if (oldTransaction != null)
                {
                    int difference = oldTransaction.PurchaseQuantity - newTransaction.PurchaseQuantity;
                    if (difference > product.Quantity)
                        return BadRequest($"There are only {product.Quantity} left in stock.");
                    
                    product.Quantity += difference;

                    oldTransaction.ProductId = newTransaction.ProductId;
                    oldTransaction.CustomerId = newTransaction.CustomerId;
                    oldTransaction.PurchaseQuantity = newTransaction.PurchaseQuantity;

                    await _context.SaveChangesAsync();
                    return Ok(oldTransaction);
                }

                return NotFound();
            }

            return BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IHttpActionResult> DeleteTransaction([FromUri] int id)
        {
            Transaction transaction = await _context.Transactions.FindAsync(id);

            if (transaction == null)
            {
                return NotFound();
            }

            _context.Transactions.Remove(transaction);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
