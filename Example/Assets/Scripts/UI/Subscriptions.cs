
namespace Demo.Commons
{
    public static class Subscriptions
    {
        public delegate void DELEGATE_ON_SELECTED_UI_ITEM<T>(T _args);
        public static DELEGATE_ON_SELECTED_UI_ITEM<bool> ON_ITEM_SELECTED;
        public static DELEGATE_ON_SELECTED_UI_ITEM<int> ON_ITEM_CLICKED;
    }
}