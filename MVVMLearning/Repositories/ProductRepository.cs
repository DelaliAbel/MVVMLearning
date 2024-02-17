using MVVMLearning.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLearning.Repositories
{
    public class ProductRepository : BaseRepository
    {
        public ProductRepository()
        {
            base.Items = LoadClientData();
        }

        public ObservableCollection<BaseModel> LoadClientData()
        {
            ObservableCollection<BaseModel> products = new ObservableCollection<BaseModel>(){
                new ProductModel() { Id="1", Name="Ordinateur ASUS 754", Description="9e génération et pc robuste", ProductPrice ="1 200 000fca", ProductQuantity=70, ProductSupplier="SystLaptop@Core.com", ProductDateExp="Garantie d'un ans" },
                new ProductModel() { Id="2", Name="Ordinateur DELL 121", Description="9e génération et pc robuste", ProductPrice ="1 200 000fca", ProductQuantity=70, ProductSupplier="SystLaptop@Core.com", ProductDateExp="Garantie d'un ans" },
                new ProductModel() { Id="3", Name="Ordinateur Lenevo H45", Description="9e génération et pc robuste", ProductPrice ="1 200 000fca", ProductQuantity=70, ProductSupplier="SystLaptop@Core.com", ProductDateExp="Garantie d'un ans" },
                new ProductModel() { Id="4", Name="Ordinateur HP", Description="9e génération et pc robuste", ProductPrice ="1 200 000fca", ProductQuantity=70, ProductSupplier="SystLaptop@Core.com", ProductDateExp="Garantie d'un ans" },
                new ProductModel() { Id="5", Name="Ordinateur Maximus", Description="9e génération et pc robuste", ProductPrice ="1 200 000fca", ProductQuantity=70, ProductSupplier="SystLaptop@Core.com", ProductDateExp="Garantie d'un ans" },
                new ProductModel() { Id="6", Name="Ordinateur MacOs", Description="9e génération et pc robuste", ProductPrice ="1 200 000fca", ProductQuantity=70, ProductSupplier="SystLaptop@Core.com", ProductDateExp="Garantie d'un ans" },
            };

            return products;
        }

    }
}
