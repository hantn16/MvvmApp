using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMExpenses.DataModels
{
    public class Account
    {
        [Key,Display(AutoGenerateField = false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required, StringLength(30, MinimumLength = 4)]
        [Display(Name = "ACCOUNT")]
        public string Name { get; set; }
        //[DataType(DataType.Currency)]
        [Display(Name = "AMOUNT")]
        public decimal Amount { get; set; }
        public override string ToString()
        {
            return Name + " (" + Amount.ToString("C") + ")";
        }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
