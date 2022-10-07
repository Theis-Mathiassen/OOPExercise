namespace _04
{
    interface IMenuItem
    {
        public bool Selected { get; set; }
        public bool Clicked { get; set; }

        public void Print();
        public void Select();
        public void DeSelect();
        public void Click();
    }
}
