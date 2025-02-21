using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TestAPI.Model;

public class TbOrder
{
    [Key]
    public Guid Id { get; set; }

    public string Description { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal Total { get; set; }

    public Guid? CreateBy { get; set; }
    public DateTime DeliveryDate { get; set; }
    public DateTime CreateDate { get; set; }
    public Guid? UpdateBy { get; set; }
    public DateTime? UpdateDate { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal? Discount { get; set; }

    public bool? Status { get; set; }
    public int PaymentMethod { get; set; }
    public string ReceiverName { get; set; }
    public string ReceiverPhone { get; set; }

    [Column(TypeName = "decimal(18,2)")]
    public decimal SubTotal { get; set; }

    public string Code { get; set; }

    public Guid CustomerId { get; set; }
    [ForeignKey("CustomerId")]
    public virtual TbCustomer Customer { get; set; }

    public Guid? VoucherId { get; set; }  // Có thể NULL
    [ForeignKey("VoucherId")]
    public virtual TbVoucher Voucher { get; set; }

    public Guid? EmployeeId { get; set; }  // Có thể NULL
    [ForeignKey("EmployeeId")]
    public virtual TbEmployee Employee { get; set; }
}
