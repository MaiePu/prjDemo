using prjDemo.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace prjDemo.ViewModels
{
    public class CProductViewModel
    {
        private TProduct _product;
        public CProductViewModel()
        {
            _product = new TProduct();
        }
        public TProduct Product
        {
            get { return _product; }
            set { _product = value; }
        }
        public int FId 
        {
            get { return _product.FId; }
            set { _product.FId = value; } 
        }
        [DisplayName("產品名稱")]
        public string? FName
        {
            get { return _product.FName; }
            set { _product.FName = value; }
        }
        [DisplayName("庫存量")]
        public int? FQty
        {
            get { return _product.FQty; }
            set { _product.FQty = value; }
        }
        [DisplayName("進貨價格")]
        public decimal? FCost
        {
            get { return _product.FCost; }
            set { _product.FCost = value; }
        }
        [DisplayName("產品售價")]
        public decimal? FPrice
        {
            get { return _product.FPrice; }
            set { _product.FPrice = value; }
        }
        [DisplayName("照片名稱")]
        public string? FPhotoPath
        {
            get { return _product.FPhotoPath; }
            set { _product.FPhotoPath = value; }
        }
        public IFormFile photo { get; set; }
    }
}
