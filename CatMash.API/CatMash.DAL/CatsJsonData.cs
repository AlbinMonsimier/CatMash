using System;
using System.Collections.Generic;
using System.Text;

namespace CatMash.DAL
{
public class Image
{
    public string url { get; set; }
    public string id { get; set; }
}

public class CatJsonData
{
    public List<Image> images { get; set; }
}
}
