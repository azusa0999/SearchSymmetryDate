
TimeSpan span = DateTime.MaxValue.Subtract(DateTime.MinValue);

DateTime dt = DateTime.MinValue;

for(int i = 0; i < span.Days; i++)
{
    string year = dt.ToString("yyyy");
    string month = dt.ToString("MM");
    string day = dt.ToString("dd");
    string revStr = Reverse(string.Format("{0}{1}",month, day));

    if(year == revStr)
    {
        Console.WriteLine("{0}-{1}-{2}", year, month, day);
    }
    dt = dt.AddDays(1);
}

string Reverse(string text)
{
    var charArray = text.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}