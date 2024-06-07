using XuanLuxShopWeb.Models;

namespace XuanLuxShopWeb.Repository.Implement
{
    public class ProductRepository : IProduct //實做接口 (:IProduct寫完後 前方提示按鈕按下 實作接口 可以快速填入初始模板)
    {
        public List<Models.Product> prolist { get; set; } //暫不串接資料庫 先使用測試資料

        public ProductRepository()
        {
            prolist = new List<Models.Product>() //測試資料
            {
                new Product()
                {
                    ProductID = 1,
                    ProductName = "精美手工編織✨福祿安康 平安扣手鍊(紅/黑)",
                    ThumbnaiImage="01.jpg"
                },
                 new Product()
                {
                    ProductID = 2,
                    ProductName = "韓國製造 Rolly olly 寡肽緊緻 亮白微整霜",
                    ThumbnaiImage="02.jpg"
                },  new Product()
                {
                    ProductID = 3,
                    ProductName = "🔥質量嚴選 艾草電加熱頸椎枕🍃",
                    ThumbnaiImage="03.jpg"
                }
            };
        }

        public void Add(Product model)
        {
            prolist.Add(model); //新增 直接把傳入的model加入prolist
        }

        public void Delete(int id)
        {
            Models.Product p = GetById(id); //使用GetById方法查詢出要刪除的資料
            if (p != null) //若有找到匹配的資料
            {
                prolist.Remove(p); //就刪除此項資料
            }
        }

        public List<Product> GetAll()
        {
            return prolist; //查詢 直接回傳prolist測試資料
        }

        public void Update(Product model)
        {
            Models.Product p = GetById((int)model.ProductID);
            if (p != null)
            {
                p.ProductName = model.ProductName;
                p.ThumbnaiImage = model.ThumbnaiImage;
            }
        }

        public Product GetById(int id)
        {
            return prolist.SingleOrDefault(a => a.ProductID == id); //透過id搜索prolist中第一筆匹配的資料
        }
    }
}