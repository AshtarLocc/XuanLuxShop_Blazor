namespace XuanLuxShopWeb.Repository
{
    public interface IProduct
    {
        void Add(Models.Product model); //新增 不回傳(void) 傳入參數為 Product類別(Model) 的物件

        void Delete(int id); //刪除 不回傳(void) 傳入參數為 int類型的 id 意即使用資料列id來指定刪除特定資料

        void Update(Models.Product model); //更新 不回傳(void) 傳入參數為 Product類別(Model) 的物件

        List<Models.Product> GetAll(); //查詢 回傳Product類型(Model)的List

        Models.Product GetById(int id); //查詢 透過ID搜索
    }
}