using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A008173
{
public static readonly long[] Value={ 1L,4L,12L,23L,39L,62L,93L,127L,165L,210L,260L,318L,370L,434L,506L,588L,668L,750L,842L,938L,1044L,1150L,1250L,1369L,1490L,1633L,1762L,1893L,2035L,2179L,2353L,2503L,2649L,2822L,2993L,3206L,3371L,3548L,3749L,3946L,4189L,4369L,4565L,4792L,5015L,5304L,5502L,5729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008173Inst : IEnumerable<long>
{
public static readonly long[] Value=A008173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008173.Bytes);
public long this[int i]=>Value[i];

public static A008173Inst Instance=new A008173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008206
{
public static readonly long[] Value={ 1L,4L,12L,22L,38L,57L,86L,118L,152L,196L,245L,297L,346L,409L,485L,556L,630L,703L,789L,886L,994L,1078L,1170L,1298L,1428L,1537L,1654L,1783L,1914L,2079L,2211L,2349L,2513L,2674L,2843L,3001L,3176L,3364L,3548L,3724L,3917L,4138L,4342L,4535L,4744L,4959L,5200L,5448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008206Inst : IEnumerable<long>
{
public static readonly long[] Value=A008206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008206.Bytes);
public long this[int i]=>Value[i];

public static A008206Inst Instance=new A008206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008207
{
public static readonly long[] Value={ 1L,4L,12L,20L,34L,57L,88L,125L,158L,192L,224L,292L,371L,421L,471L,537L,621L,714L,811L,883L,951L,1081L,1223L,1307L,1393L,1519L,1644L,1804L,1943L,2052L,2187L,2357L,2529L,2676L,2836L,2998L,3176L,3364L,3534L,3745L,3935L,4106L,4330L,4546L,4746L,4984L,5184L,5395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008207Inst : IEnumerable<long>
{
public static readonly long[] Value=A008207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008207.Bytes);
public long this[int i]=>Value[i];

public static A008207Inst Instance=new A008207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008208
{
public static readonly long[] Value={ 1L,4L,12L,20L,31L,57L,84L,118L,150L,187L,237L,287L,364L,409L,459L,568L,620L,693L,810L,884L,960L,1084L,1183L,1277L,1433L,1545L,1627L,1789L,1942L,2045L,2203L,2348L,2504L,2691L,2843L,2996L,3153L,3362L,3561L,3711L,3913L,4118L,4348L,4550L,4724L,4969L,5196L,5415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008208Inst : IEnumerable<long>
{
public static readonly long[] Value=A008208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008208.Bytes);
public long this[int i]=>Value[i];

public static A008208Inst Instance=new A008208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008209
{
public static readonly long[] Value={ 1L,4L,11L,24L,40L,63L,86L,114L,158L,208L,255L,299L,336L,402L,492L,570L,633L,693L,789L,910L,991L,1061L,1172L,1303L,1434L,1557L,1648L,1764L,1939L,2080L,2194L,2354L,2519L,2682L,2842L,2995L,3184L,3384L,3550L,3712L,3915L,4147L,4352L,4532L,4722L,4972L,5243L,5437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008209Inst : IEnumerable<long>
{
public static readonly long[] Value=A008209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008209.Bytes);
public long this[int i]=>Value[i];

public static A008209Inst Instance=new A008209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008210
{
public static readonly long[] Value={ 1L,4L,12L,22L,35L,55L,83L,119L,151L,184L,237L,303L,364L,417L,468L,534L,631L,731L,802L,877L,966L,1080L,1188L,1301L,1407L,1525L,1670L,1802L,1932L,2053L,2197L,2353L,2517L,2686L,2841L,2999L,3171L,3353L,3555L,3746L,3917L,4123L,4322L,4545L,4770L,4960L,5189L,5429L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008210Inst : IEnumerable<long>
{
public static readonly long[] Value=A008210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008210.Bytes);
public long this[int i]=>Value[i];

public static A008210Inst Instance=new A008210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008211
{
public static readonly long[] Value={ 1L,4L,12L,24L,32L,50L,88L,120L,152L,180L,226L,304L,374L,422L,460L,524L,628L,738L,812L,876L,954L,1072L,1208L,1282L,1404L,1540L,1662L,1804L,1932L,2054L,2184L,2362L,2512L,2678L,2856L,3006L,3158L,3338L,3556L,3764L,3930L,4084L,4326L,4560L,4764L,4982L,5160L,5410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008211Inst : IEnumerable<long>
{
public static readonly long[] Value=A008211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008211.Bytes);
public long this[int i]=>Value[i];

public static A008211Inst Instance=new A008211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008212
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,67L,95L,133L,174L,219L,273L,331L,388L,462L,545L,615L,691L,797L,884L,991L,1096L,1203L,1327L,1451L,1592L,1703L,1844L,2009L,2133L,2325L,2459L,2612L,2825L,2978L,3193L,3355L,3526L,3773L,3955L,4198L,4364L,4586L,4861L,5047L,5355L,5535L,5765L,6107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008212Inst : IEnumerable<long>
{
public static readonly long[] Value=A008212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008212.Bytes);
public long this[int i]=>Value[i];

public static A008212Inst Instance=new A008212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008213
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,64L,99L,130L,174L,217L,262L,321L,403L,464L,517L,621L,710L,779L,889L,972L,1079L,1218L,1345L,1428L,1555L,1718L,1862L,1990L,2149L,2271L,2464L,2658L,2802L,2961L,3140L,3352L,3602L,3754L,3921L,4134L,4407L,4620L,4834L,5044L,5242L,5576L,5876L,6031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008213Inst : IEnumerable<long>
{
public static readonly long[] Value=A008213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008213.Bytes);
public long this[int i]=>Value[i];

public static A008213Inst Instance=new A008213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008214
{
public static readonly long[] Value={ 1L,4L,11L,23L,44L,72L,95L,124L,170L,229L,279L,325L,386L,467L,542L,612L,693L,788L,910L,1004L,1081L,1187L,1320L,1466L,1581L,1726L,1836L,1961L,2191L,2329L,2466L,2615L,2770L,3028L,3189L,3348L,3512L,3730L,4037L,4171L,4378L,4574L,4799L,5182L,5312L,5527L,5759L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008214Inst : IEnumerable<long>
{
public static readonly long[] Value=A008214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008214.Bytes);
public long this[int i]=>Value[i];

public static A008214Inst Instance=new A008214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008215
{
public static readonly long[] Value={ 1L,4L,12L,24L,41L,65L,97L,133L,173L,212L,267L,337L,390L,463L,533L,610L,702L,795L,882L,972L,1097L,1221L,1328L,1454L,1565L,1699L,1873L,2001L,2123L,2288L,2479L,2651L,2806L,2967L,3143L,3374L,3586L,3763L,3940L,4134L,4399L,4641L,4828L,5036L,5267L,5577L,5853L,6075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008215Inst : IEnumerable<long>
{
public static readonly long[] Value=A008215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008215.Bytes);
public long this[int i]=>Value[i];

public static A008215Inst Instance=new A008215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008216
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,62L,92L,142L,166L,214L,262L,324L,400L,460L,514L,604L,702L,794L,868L,986L,1062L,1216L,1340L,1442L,1540L,1704L,1846L,2000L,2144L,2262L,2418L,2688L,2792L,2970L,3112L,3322L,3604L,3770L,3928L,4118L,4326L,4682L,4806L,5052L,5210L,5500L,5914L,6040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008216Inst : IEnumerable<long>
{
public static readonly long[] Value=A008216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008216.Bytes);
public long this[int i]=>Value[i];

public static A008216Inst Instance=new A008216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008217
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,4L,4L,4L,6L,9L,9L,9L,12L,16L,16L,16L,20L,25L,25L,25L,30L,36L,36L,36L,42L,49L,49L,49L,56L,64L,64L,64L,72L,81L,81L,81L,90L,100L,100L,100L,110L,121L,121L,121L,132L,144L,144L,144L,156L,169L,169L,169L,182L,196L,196L,196L,210L,225L,225L,225L,240L,256L,256L,256L,272L,289L,289L,289L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008217Inst : IEnumerable<long>
{
public static readonly long[] Value=A008217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008217.Bytes);
public long this[int i]=>Value[i];

public static A008217Inst Instance=new A008217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008218
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,4L,8L,8L,12L,18L,27L,27L,36L,48L,64L,64L,80L,100L,125L,125L,150L,180L,216L,216L,252L,294L,343L,343L,392L,448L,512L,512L,576L,648L,729L,729L,810L,900L,1000L,1000L,1100L,1210L,1331L,1331L,1452L,1584L,1728L,1728L,1872L,2028L,2197L,2197L,2366L,2548L,2744L,2744L,2940L,3150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008218Inst : IEnumerable<long>
{
public static readonly long[] Value=A008218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008218.Bytes);
public long this[int i]=>Value[i];

public static A008218Inst Instance=new A008218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008219
{
public static readonly long[] Value={ 1L,4L,9L,18L,31L,47L,68L,91L,117L,151L,188L,225L,268L,317L,368L,425L,485L,542L,602L,676L,758L,829L,899L,987L,1081L,1169L,1266L,1372L,1470L,1568L,1683L,1806L,1918L,2032L,2163L,2295L,2422L,2562L,2710L,2846L,2985L,3147L,3312L,3459L,3612L,3788L,3961L,4128L,4313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008219Inst : IEnumerable<long>
{
public static readonly long[] Value=A008219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008219.Bytes);
public long this[int i]=>Value[i];

public static A008219Inst Instance=new A008219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008220
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,70L,95L,122L,154L,191L,230L,272L,318L,369L,424L,482L,544L,608L,675L,749L,827L,907L,992L,1080L,1170L,1265L,1365L,1469L,1576L,1686L,1801L,1919L,2039L,2164L,2293L,2426L,2564L,2705L,2848L,2993L,3143L,3300L,3460L,3623L,3791L,3960L,4131L,4309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008220Inst : IEnumerable<long>
{
public static readonly long[] Value=A008220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008220.Bytes);
public long this[int i]=>Value[i];

public static A008220Inst Instance=new A008220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008221
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,69L,94L,123L,153L,186L,225L,270L,318L,365L,417L,479L,543L,607L,676L,748L,823L,906L,995L,1083L,1170L,1265L,1368L,1469L,1573L,1686L,1800L,1915L,2038L,2167L,2295L,2421L,2555L,2701L,2847L,2993L,3146L,3300L,3455L,3620L,3793L,3963L,4132L,4311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008221Inst : IEnumerable<long>
{
public static readonly long[] Value=A008221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008221.Bytes);
public long this[int i]=>Value[i];

public static A008221Inst Instance=new A008221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008222
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,48L,67L,92L,121L,152L,185L,223L,267L,314L,366L,422L,477L,538L,608L,676L,746L,826L,909L,992L,1078L,1172L,1270L,1363L,1463L,1576L,1687L,1797L,1916L,2038L,2159L,2287L,2425L,2563L,2697L,2842L,2996L,3143L,3295L,3461L,3626L,3788L,3958L,4136L,4313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008222Inst : IEnumerable<long>
{
public static readonly long[] Value=A008222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008222.Bytes);
public long this[int i]=>Value[i];

public static A008222Inst Instance=new A008222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008223
{
public static readonly long[] Value={ 1L,4L,9L,18L,31L,47L,68L,92L,119L,152L,188L,226L,269L,315L,365L,422L,481L,542L,607L,675L,748L,826L,908L,993L,1080L,1170L,1264L,1362L,1466L,1574L,1684L,1799L,1916L,2035L,2160L,2289L,2423L,2563L,2704L,2846L,2992L,3142L,3298L,3460L,3625L,3792L,3960L,4131L,4307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008223Inst : IEnumerable<long>
{
public static readonly long[] Value=A008223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008223.Bytes);
public long this[int i]=>Value[i];

public static A008223Inst Instance=new A008223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008224
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,65L,89L,117L,149L,185L,225L,268L,314L,364L,418L,476L,538L,605L,676L,750L,827L,907L,991L,1078L,1169L,1264L,1362L,1464L,1570L,1680L,1794L,1913L,2036L,2161L,2289L,2421L,2557L,2697L,2842L,2992L,3145L,3301L,3460L,3622L,3788L,3958L,4132L,4309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008224Inst : IEnumerable<long>
{
public static readonly long[] Value=A008224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008224.Bytes);
public long this[int i]=>Value[i];

public static A008224Inst Instance=new A008224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008225
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,47L,66L,88L,113L,144L,183L,227L,272L,316L,364L,419L,481L,548L,615L,677L,742L,821L,907L,992L,1076L,1166L,1263L,1365L,1474L,1583L,1685L,1790L,1911L,2039L,2164L,2290L,2422L,2559L,2701L,2852L,3003L,3145L,3292L,3455L,3623L,3788L,3956L,4130L,4307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008225Inst : IEnumerable<long>
{
public static readonly long[] Value=A008225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008225.Bytes);
public long this[int i]=>Value[i];

public static A008225Inst Instance=new A008225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008226
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,69L,95L,123L,152L,188L,229L,272L,316L,370L,429L,480L,537L,609L,681L,749L,828L,911L,988L,1072L,1174L,1275L,1364L,1465L,1579L,1685L,1793L,1920L,2047L,2164L,2288L,2430L,2569L,2696L,2841L,3001L,3149L,3297L,3464L,3627L,3780L,3952L,4142L,4319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008226Inst : IEnumerable<long>
{
public static readonly long[] Value=A008226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008226.Bytes);
public long this[int i]=>Value[i];

public static A008226Inst Instance=new A008226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008227
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,50L,71L,94L,122L,157L,195L,232L,273L,324L,378L,431L,488L,551L,620L,692L,765L,841L,923L,1011L,1101L,1194L,1290L,1389L,1496L,1608L,1720L,1832L,1950L,2079L,2210L,2338L,2469L,2609L,2757L,2905L,3053L,3204L,3362L,3529L,3696L,3863L,4034L,4210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008227Inst : IEnumerable<long>
{
public static readonly long[] Value=A008227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008227.Bytes);
public long this[int i]=>Value[i];

public static A008227Inst Instance=new A008227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008228
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,48L,68L,96L,126L,155L,191L,234L,277L,322L,373L,429L,490L,555L,620L,688L,765L,845L,923L,1007L,1099L,1192L,1289L,1395L,1500L,1602L,1716L,1838L,1954L,2073L,2203L,2336L,2473L,2617L,2757L,2897L,3053L,3212L,3362L,3521L,3692L,3861L,4035L,4220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008228Inst : IEnumerable<long>
{
public static readonly long[] Value=A008228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008228.Bytes);
public long this[int i]=>Value[i];

public static A008228Inst Instance=new A008228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008229
{
public static readonly long[] Value={ 1L,4L,11L,22L,37L,62L,89L,120L,155L,202L,257L,316L,363L,408L,497L,597L,648L,719L,833L,934L,1030L,1142L,1231L,1349L,1505L,1607L,1729L,1904L,2015L,2155L,2345L,2472L,2626L,2825L,2968L,3163L,3387L,3504L,3700L,3986L,4119L,4305L,4598L,4757L,4980L,5286L,5434L,5680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008229Inst : IEnumerable<long>
{
public static readonly long[] Value=A008229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008229.Bytes);
public long this[int i]=>Value[i];

public static A008229Inst Instance=new A008229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008230
{
public static readonly long[] Value={ 1L,4L,11L,21L,37L,63L,86L,121L,152L,196L,258L,304L,360L,421L,488L,584L,649L,727L,802L,930L,1044L,1117L,1234L,1353L,1473L,1622L,1734L,1868L,2002L,2173L,2315L,2466L,2639L,2784L,2982L,3186L,3305L,3540L,3717L,3890L,4145L,4340L,4514L,4785L,4999L,5211L,5469L,5704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008230Inst : IEnumerable<long>
{
public static readonly long[] Value=A008230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008230.Bytes);
public long this[int i]=>Value[i];

public static A008230Inst Instance=new A008230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008231
{
public static readonly long[] Value={ 1L,4L,11L,23L,38L,62L,92L,113L,159L,210L,244L,306L,367L,421L,500L,572L,652L,725L,835L,912L,1022L,1152L,1220L,1346L,1494L,1596L,1744L,1868L,2014L,2162L,2326L,2462L,2612L,2836L,2968L,3122L,3398L,3492L,3702L,3958L,4080L,4332L,4596L,4714L,4990L,5280L,5430L,5646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008231Inst : IEnumerable<long>
{
public static readonly long[] Value=A008231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008231.Bytes);
public long this[int i]=>Value[i];

public static A008231Inst Instance=new A008231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008232
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,61L,87L,128L,168L,205L,250L,300L,375L,446L,495L,563L,653L,757L,842L,916L,1026L,1132L,1256L,1378L,1466L,1614L,1753L,1868L,2044L,2169L,2302L,2495L,2648L,2811L,2992L,3153L,3338L,3554L,3746L,3906L,4134L,4359L,4541L,4794L,5013L,5197L,5485L,5738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008232Inst : IEnumerable<long>
{
public static readonly long[] Value=A008232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008232.Bytes);
public long this[int i]=>Value[i];

public static A008232Inst Instance=new A008232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008233
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,4L,8L,16L,24L,36L,54L,81L,108L,144L,192L,256L,320L,400L,500L,625L,750L,900L,1080L,1296L,1512L,1764L,2058L,2401L,2744L,3136L,3584L,4096L,4608L,5184L,5832L,6561L,7290L,8100L,9000L,10000L,11000L,12100L,13310L,14641L,15972L,17424L,19008L,20736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008233Inst : IEnumerable<long>
{
public static readonly long[] Value=A008233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008233.Bytes);
public long this[int i]=>Value[i];

public static A008233Inst Instance=new A008233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008234
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,57L,82L,103L,138L,181L,220L,261L,306L,369L,434L,487L,549L,619L,707L,793L,860L,949L,1046L,1146L,1255L,1351L,1458L,1570L,1695L,1836L,1947L,2066L,2207L,2357L,2518L,2650L,2786L,2951L,3130L,3309L,3454L,3617L,3811L,4002L,4201L,4380L,4559L,4763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008234Inst : IEnumerable<long>
{
public static readonly long[] Value=A008234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008234.Bytes);
public long this[int i]=>Value[i];

public static A008234Inst Instance=new A008234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008235
{
public static readonly long[] Value={ 1L,4L,11L,20L,36L,57L,78L,109L,140L,176L,222L,260L,310L,369L,426L,491L,550L,626L,707L,778L,870L,952L,1043L,1152L,1244L,1355L,1462L,1571L,1702L,1816L,1950L,2080L,2204L,2363L,2504L,2647L,2800L,2954L,3129L,3290L,3460L,3634L,3805L,4004L,4190L,4375L,4572L,4773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008235Inst : IEnumerable<long>
{
public static readonly long[] Value=A008235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008235.Bytes);
public long this[int i]=>Value[i];

public static A008235Inst Instance=new A008235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008236
{
public static readonly long[] Value={ 1L,4L,9L,17L,35L,57L,77L,103L,138L,188L,225L,245L,299L,375L,446L,494L,525L,610L,722L,804L,867L,923L,1031L,1166L,1268L,1359L,1432L,1548L,1718L,1853L,1954L,2037L,2178L,2388L,2546L,2651L,2750L,2920L,3163L,3341L,3455L,3580L,3778L,4034L,4237L,4382L,4518L,4729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008236Inst : IEnumerable<long>
{
public static readonly long[] Value=A008236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008236.Bytes);
public long this[int i]=>Value[i];

public static A008236Inst Instance=new A008236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008237
{
public static readonly long[] Value={ 1L,4L,12L,18L,34L,58L,82L,112L,130L,172L,228L,264L,312L,362L,424L,498L,546L,630L,702L,772L,878L,952L,1048L,1148L,1232L,1362L,1464L,1578L,1698L,1802L,1962L,2084L,2202L,2360L,2492L,2656L,2804L,2958L,3128L,3274L,3466L,3642L,3806L,4004L,4174L,4380L,4584L,4776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008237Inst : IEnumerable<long>
{
public static readonly long[] Value=A008237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008237.Bytes);
public long this[int i]=>Value[i];

public static A008237Inst Instance=new A008237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008238
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,2L,4L,6L,6L,6L,9L,12L,12L,12L,16L,20L,20L,20L,25L,30L,30L,30L,36L,42L,42L,42L,49L,56L,56L,56L,64L,72L,72L,72L,81L,90L,90L,90L,100L,110L,110L,110L,121L,132L,132L,132L,144L,156L,156L,156L,169L,182L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008238Inst : IEnumerable<long>
{
public static readonly long[] Value=A008238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008238.Bytes);
public long this[int i]=>Value[i];

public static A008238Inst Instance=new A008238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008239
{
public static readonly long[] Value={ 1L,4L,9L,19L,33L,50L,74L,100L,129L,165L,201L,242L,290L,338L,393L,453L,513L,580L,650L,722L,801L,883L,969L,1060L,1154L,1252L,1353L,1459L,1569L,1682L,1802L,1924L,2049L,2181L,2313L,2450L,2594L,2738L,2889L,3045L,3201L,3364L,3530L,3698L,3873L,4051L,4233L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008239Inst : IEnumerable<long>
{
public static readonly long[] Value=A008239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008239.Bytes);
public long this[int i]=>Value[i];

public static A008239Inst Instance=new A008239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008240
{
public static readonly long[] Value={ 1L,4L,8L,18L,34L,50L,68L,100L,130L,160L,204L,246L,286L,338L,392L,448L,514L,580L,648L,726L,802L,878L,968L,1060L,1150L,1252L,1356L,1458L,1570L,1682L,1796L,1924L,2050L,2176L,2316L,2454L,2590L,2738L,2888L,3040L,3202L,3364L,3528L,3702L,3874L,4046L,4232L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008240Inst : IEnumerable<long>
{
public static readonly long[] Value=A008240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008240.Bytes);
public long this[int i]=>Value[i];

public static A008240Inst Instance=new A008240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008241
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,61L,96L,133L,163L,204L,262L,326L,375L,427L,504L,595L,678L,744L,834L,944L,1042L,1152L,1258L,1372L,1494L,1619L,1776L,1907L,2023L,2170L,2350L,2540L,2651L,2789L,3008L,3217L,3402L,3530L,3722L,3978L,4182L,4390L,4566L,4786L,5038L,5269L,5552L,5745L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008241Inst : IEnumerable<long>
{
public static readonly long[] Value=A008241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008241.Bytes);
public long this[int i]=>Value[i];

public static A008241Inst Instance=new A008241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008242
{
public static readonly long[] Value={ 1L,4L,12L,23L,43L,66L,91L,128L,169L,214L,258L,306L,381L,450L,509L,574L,659L,771L,848L,924L,1038L,1148L,1274L,1373L,1491L,1636L,1743L,1902L,2051L,2188L,2340L,2466L,2689L,2864L,2991L,3170L,3343L,3611L,3776L,3910L,4166L,4362L,4626L,4813L,5007L,5296L,5461L,5768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008242Inst : IEnumerable<long>
{
public static readonly long[] Value=A008242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008242.Bytes);
public long this[int i]=>Value[i];

public static A008242Inst Instance=new A008242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008243
{
public static readonly long[] Value={ 1L,4L,12L,22L,41L,68L,97L,118L,166L,224L,258L,302L,371L,458L,521L,560L,660L,764L,860L,932L,1009L,1168L,1273L,1366L,1500L,1618L,1776L,1870L,2039L,2238L,2311L,2470L,2658L,2888L,3044L,3092L,3365L,3602L,3797L,3952L,4064L,4418L,4628L,4802L,5045L,5216L,5545L,5710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008243Inst : IEnumerable<long>
{
public static readonly long[] Value=A008243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008243.Bytes);
public long this[int i]=>Value[i];

public static A008243Inst Instance=new A008243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008244
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,66L,95L,130L,158L,208L,270L,320L,375L,428L,491L,612L,678L,742L,828L,918L,1077L,1176L,1233L,1354L,1466L,1668L,1806L,1862L,2007L,2174L,2387L,2552L,2610L,2774L,3002L,3256L,3439L,3508L,3657L,3966L,4256L,4426L,4536L,4686L,5035L,5418L,5555L,5678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008244Inst : IEnumerable<long>
{
public static readonly long[] Value=A008244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008244.Bytes);
public long this[int i]=>Value[i];

public static A008244Inst Instance=new A008244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008245
{
public static readonly long[] Value={ 1L,4L,11L,20L,31L,44L,61L,82L,108L,139L,174L,209L,246L,287L,333L,382L,436L,493L,552L,611L,674L,743L,817L,895L,977L,1060L,1145L,1232L,1324L,1421L,1523L,1627L,1733L,1840L,1951L,2066L,2186L,2312L,2442L,2572L,2704L,2839L,2979L,3122L,3270L,3422L,3576L,3730L,3888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008245Inst : IEnumerable<long>
{
public static readonly long[] Value=A008245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008245.Bytes);
public long this[int i]=>Value[i];

public static A008245Inst Instance=new A008245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008246
{
public static readonly long[] Value={ 1L,4L,10L,18L,30L,44L,60L,80L,106L,135L,168L,207L,248L,286L,330L,382L,436L,489L,548L,612L,676L,741L,816L,896L,974L,1055L,1142L,1231L,1324L,1420L,1522L,1626L,1730L,1837L,1948L,2064L,2188L,2313L,2440L,2572L,2704L,2835L,2974L,3121L,3272L,3420L,3572L,3730L,3886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008246Inst : IEnumerable<long>
{
public static readonly long[] Value=A008246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008246.Bytes);
public long this[int i]=>Value[i];

public static A008246Inst Instance=new A008246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008247
{
public static readonly long[] Value={ 1L,4L,11L,22L,39L,61L,88L,120L,155L,192L,241L,295L,344L,404L,473L,539L,613L,696L,776L,863L,961L,1057L,1159L,1270L,1378L,1495L,1624L,1746L,1875L,2017L,2154L,2301L,2457L,2605L,2765L,2939L,3103L,3274L,3463L,3641L,3826L,4031L,4224L,4423L,4639L,4847L,5064L,5295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008247Inst : IEnumerable<long>
{
public static readonly long[] Value=A008247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008247.Bytes);
public long this[int i]=>Value[i];

public static A008247Inst Instance=new A008247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008248
{
public static readonly long[] Value={ 1L,4L,10L,22L,39L,61L,89L,118L,153L,198L,241L,287L,349L,409L,465L,541L,619L,688L,777L,871L,954L,1056L,1165L,1264L,1380L,1501L,1615L,1748L,1882L,2008L,2158L,2307L,2444L,2611L,2776L,2923L,3105L,3288L,3448L,3642L,3841L,4016L,4223L,4437L,4627L,4848L,5075L,5280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008248Inst : IEnumerable<long>
{
public static readonly long[] Value=A008248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008248.Bytes);
public long this[int i]=>Value[i];

public static A008248Inst Instance=new A008248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008249
{
public static readonly long[] Value={ 1L,4L,11L,22L,42L,67L,97L,133L,176L,223L,277L,335L,400L,471L,547L,627L,716L,809L,907L,1011L,1122L,1237L,1359L,1485L,1618L,1757L,1901L,2049L,2206L,2367L,2533L,2705L,2884L,3067L,3257L,3451L,3652L,3859L,4071L,4287L,4512L,4741L,4975L,5215L,5462L,5713L,5971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008249Inst : IEnumerable<long>
{
public static readonly long[] Value=A008249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008249.Bytes);
public long this[int i]=>Value[i];

public static A008249Inst Instance=new A008249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008250
{
public static readonly long[] Value={ 1L,4L,11L,24L,42L,65L,97L,135L,176L,221L,277L,337L,400L,469L,547L,629L,716L,807L,907L,1013L,1122L,1235L,1359L,1487L,1618L,1755L,1901L,2051L,2206L,2365L,2533L,2707L,2884L,3065L,3257L,3453L,3652L,3857L,4071L,4289L,4512L,4739L,4975L,5217L,5462L,5711L,5971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008250Inst : IEnumerable<long>
{
public static readonly long[] Value=A008250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008250.Bytes);
public long this[int i]=>Value[i];

public static A008250Inst Instance=new A008250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008251
{
public static readonly long[] Value={ 1L,4L,10L,24L,42L,58L,106L,136L,170L,216L,262L,356L,394L,448L,550L,606L,726L,788L,872L,1036L,1068L,1240L,1346L,1452L,1606L,1686L,1884L,2084L,2114L,2352L,2448L,2720L,2850L,2976L,3192L,3438L,3578L,3844L,3942L,4284L,4380L,4700L,4872L,5204L,5318L,5626L,5866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008251Inst : IEnumerable<long>
{
public static readonly long[] Value=A008251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008251.Bytes);
public long this[int i]=>Value[i];

public static A008251Inst Instance=new A008251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008252
{
public static readonly long[] Value={ 1L,4L,11L,23L,46L,70L,100L,131L,177L,230L,280L,332L,395L,471L,554L,620L,714L,797L,909L,998L,1120L,1226L,1353L,1453L,1618L,1736L,1906L,1995L,2195L,2336L,2540L,2646L,2861L,3011L,3268L,3374L,3642L,3771L,4071L,4194L,4502L,4648L,4961L,5083L,5456L,5600L,5976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008252Inst : IEnumerable<long>
{
public static readonly long[] Value=A008252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008252.Bytes);
public long this[int i]=>Value[i];

public static A008252Inst Instance=new A008252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008253
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,64L,92L,124L,162L,204L,252L,304L,362L,424L,492L,564L,642L,724L,812L,904L,1002L,1104L,1212L,1324L,1442L,1564L,1692L,1824L,1962L,2104L,2252L,2404L,2562L,2724L,2892L,3064L,3242L,3424L,3612L,3804L,4002L,4204L,4412L,4624L,4842L,5064L,5292L,5524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008253Inst : IEnumerable<long>
{
public static readonly long[] Value=A008253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008253.Bytes);
public long this[int i]=>Value[i];

public static A008253Inst Instance=new A008253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008270
{
public static readonly BigInteger[] Value={ 1L,20L,507L,19552L,1113485L,88725876L,9452410135L,1299140690912L,223938108997497L,47323772172058420L,12033854264863090451UL,BigInteger.Parse("3625294706255832787200"),BigInteger.Parse("1276951433895343148472517") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008270Inst Instance=new A008270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008271
{
public static readonly BigInteger[] Value={ 0L,2L,114L,5844L,380900L,32817990L,3679720422L,524366318504L,92857556215944L,20037507147592650L,5180981746936701530L,BigInteger.Parse("1582222025035216228092"),BigInteger.Parse("563668692910591272692844"),BigInteger.Parse("231745357332413891454727694") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008271Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008271.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008271Inst Instance=new A008271Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008272
{
public static readonly BigInteger[] Value={ 0L,10L,732L,47868L,3848320L,395925990L,51677715180L,8406604850392L,1673689684372128L,401132372917509090L,BigInteger.Parse("114061334769253037980"),BigInteger.Parse("37993391290097065722900"),BigInteger.Parse("14661377074205783294317152") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008272Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008272.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008272Inst Instance=new A008272Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008273
{
public static readonly BigInteger[] Value={ 0L,2L,78L,2724L,125660L,8194710L,735861882L,87393619208L,13265357282424L,2504688304672170L,575664637463471270L,BigInteger.Parse("158222202489198948012"),BigInteger.Parse("51242608446214266856788"),BigInteger.Parse("19312113111031410277418174") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008273Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008273.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008273Inst Instance=new A008273Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008274
{
public static readonly BigInteger[] Value={ 0L,8L,408L,18768L,1106960L,88667160L,9451834728L,1299134553248L,223938037975968L,47323771284289320L,12033854252927528120UL,BigInteger.Parse("3625294706083960689648"),BigInteger.Parse("1276951433892702568064688") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008274Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008274.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008274Inst Instance=new A008274Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008275
{
public static readonly long[] Value={ 1L,-1L,1L,2L,-3L,1L,-6L,11L,-6L,1L,24L,-50L,35L,-10L,1L,-120L,274L,-225L,85L,-15L,1L,720L,-1764L,1624L,-735L,175L,-21L,1L,-5040L,13068L,-13132L,6769L,-1960L,322L,-28L,1L,40320L,-109584L,118124L,-67284L,22449L,-4536L,546L,-36L,1L,-362880L,1026576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008275Inst : IEnumerable<long>
{
public static readonly long[] Value=A008275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008275.Bytes);
public long this[int i]=>Value[i];

public static A008275Inst Instance=new A008275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008276
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,2L,1L,-6L,11L,-6L,1L,-10L,35L,-50L,24L,1L,-15L,85L,-225L,274L,-120L,1L,-21L,175L,-735L,1624L,-1764L,720L,1L,-28L,322L,-1960L,6769L,-13132L,13068L,-5040L,1L,-36L,546L,-4536L,22449L,-67284L,118124L,-109584L,40320L,1L,-45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008276Inst : IEnumerable<long>
{
public static readonly long[] Value=A008276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008276.Bytes);
public long this[int i]=>Value[i];

public static A008276Inst Instance=new A008276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008277
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,7L,6L,1L,1L,15L,25L,10L,1L,1L,31L,90L,65L,15L,1L,1L,63L,301L,350L,140L,21L,1L,1L,127L,966L,1701L,1050L,266L,28L,1L,1L,255L,3025L,7770L,6951L,2646L,462L,36L,1L,1L,511L,9330L,34105L,42525L,22827L,5880L,750L,45L,1L,1L,1023L,28501L,145750L,246730L,179487L,63987L,11880L,1155L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008277Inst : IEnumerable<long>
{
public static readonly long[] Value=A008277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008277.Bytes);
public long this[int i]=>Value[i];

public static A008277Inst Instance=new A008277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008278
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,7L,1L,1L,10L,25L,15L,1L,1L,15L,65L,90L,31L,1L,1L,21L,140L,350L,301L,63L,1L,1L,28L,266L,1050L,1701L,966L,127L,1L,1L,36L,462L,2646L,6951L,7770L,3025L,255L,1L,1L,45L,750L,5880L,22827L,42525L,34105L,9330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008278Inst : IEnumerable<long>
{
public static readonly long[] Value=A008278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008278.Bytes);
public long this[int i]=>Value[i];

public static A008278Inst Instance=new A008278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008279
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,3L,6L,6L,1L,4L,12L,24L,24L,1L,5L,20L,60L,120L,120L,1L,6L,30L,120L,360L,720L,720L,1L,7L,42L,210L,840L,2520L,5040L,5040L,1L,8L,56L,336L,1680L,6720L,20160L,40320L,40320L,1L,9L,72L,504L,3024L,15120L,60480L,181440L,362880L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008279Inst : IEnumerable<long>
{
public static readonly long[] Value=A008279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008279.Bytes);
public long this[int i]=>Value[i];

public static A008279Inst Instance=new A008279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008280
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,1L,2L,2L,5L,5L,4L,2L,0L,0L,5L,10L,14L,16L,16L,61L,61L,56L,46L,32L,16L,0L,0L,61L,122L,178L,224L,256L,272L,272L,1385L,1385L,1324L,1202L,1024L,800L,544L,272L,0L,0L,1385L,2770L,4094L,5296L,6320L,7120L,7664L,7936L,7936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008280Inst : IEnumerable<long>
{
public static readonly long[] Value=A008280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008280.Bytes);
public long this[int i]=>Value[i];

public static A008280Inst Instance=new A008280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008281
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,2L,0L,2L,4L,5L,5L,0L,5L,10L,14L,16L,16L,0L,16L,32L,46L,56L,61L,61L,0L,61L,122L,178L,224L,256L,272L,272L,0L,272L,544L,800L,1024L,1202L,1324L,1385L,1385L,0L,1385L,2770L,4094L,5296L,6320L,7120L,7664L,7936L,7936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008281Inst : IEnumerable<long>
{
public static readonly long[] Value=A008281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008281.Bytes);
public long this[int i]=>Value[i];

public static A008281Inst Instance=new A008281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008282
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,2L,4L,5L,5L,5L,10L,14L,16L,16L,16L,32L,46L,56L,61L,61L,61L,122L,178L,224L,256L,272L,272L,272L,544L,800L,1024L,1202L,1324L,1385L,1385L,1385L,2770L,4094L,5296L,6320L,7120L,7664L,7936L,7936L,7936L,15872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008282Inst : IEnumerable<long>
{
public static readonly long[] Value=A008282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008282.Bytes);
public long this[int i]=>Value[i];

public static A008282Inst Instance=new A008282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008283
{
public static readonly long[] Value={ 1L,2L,4L,5L,10L,14L,16L,32L,46L,56L,61L,122L,178L,224L,256L,272L,544L,800L,1024L,1202L,1324L,1385L,2770L,4094L,5296L,6320L,7120L,7664L,7936L,15872L,23536L,30656L,36976L,42272L,46366L,49136L,50521L,101042L,150178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008283Inst : IEnumerable<long>
{
public static readonly long[] Value=A008283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008283.Bytes);
public long this[int i]=>Value[i];

public static A008283Inst Instance=new A008283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008284
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,3L,3L,2L,1L,1L,1L,3L,4L,3L,2L,1L,1L,1L,4L,5L,5L,3L,2L,1L,1L,1L,4L,7L,6L,5L,3L,2L,1L,1L,1L,5L,8L,9L,7L,5L,3L,2L,1L,1L,1L,5L,10L,11L,10L,7L,5L,3L,2L,1L,1L,1L,6L,12L,15L,13L,11L,7L,5L,3L,2L,1L,1L,1L,6L,14L,18L,18L,14L,11L,7L,5L,3L,2L,1L,1L,1L,7L,16L,23L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008284Inst : IEnumerable<long>
{
public static readonly long[] Value=A008284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008284.Bytes);
public long this[int i]=>Value[i];

public static A008284Inst Instance=new A008284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008285
{
public static readonly long[] Value={ 1L,1L,2L,1L,12L,6L,1L,86L,108L,24L,1L,840L,2310L,960L,120L,1L,11642L,65700L,42960L,9000L,720L,1L,227892L,2583126L,2510760L,712320L,90720L,5040L,1L,6285806L,142259628L,199424904L,71243760L,11481120L,987840L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008285Inst : IEnumerable<long>
{
public static readonly long[] Value=A008285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008285.Bytes);
public long this[int i]=>Value[i];

public static A008285Inst Instance=new A008285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008318
{
public static readonly long[] Value={ 1L,2L,5L,26L,29L,677L,680L,701L,842L,845L,866L,1517L,458330L,458333L,458354L,459005L,459170L,462401L,462404L,462425L,463076L,463241L,491402L,491405L,491426L,492077L,492242L,708965L,708968L,708989L,709640L,709805L,714026L,714029L,714050L,714701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008318Inst : IEnumerable<long>
{
public static readonly long[] Value=A008318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008318.Bytes);
public long this[int i]=>Value[i];

public static A008318Inst Instance=new A008318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008319
{
public static readonly long[] Value={ 1L,1L,2L,4L,5L,6L,16L,17L,18L,20L,21L,22L,25L,26L,27L,29L,30L,31L,36L,37L,38L,40L,41L,42L,43L,45L,46L,47L,52L,53L,54L,56L,57L,58L,61L,62L,63L,65L,66L,67L,77L,78L,79L,81L,82L,83L,256L,257L,258L,260L,261L,262L,272L,273L,274L,276L,277L,278L,281L,282L,283L,285L,286L,287L,289L,290L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008319Inst : IEnumerable<long>
{
public static readonly long[] Value=A008319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008319.Bytes);
public long this[int i]=>Value[i];

public static A008319Inst Instance=new A008319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008320
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,24L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,78L,79L,81L,83L,84L,86L,87L,88L,89L,91L,92L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008320Inst : IEnumerable<long>
{
public static readonly long[] Value=A008320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008320.Bytes);
public long this[int i]=>Value[i];

public static A008320Inst Instance=new A008320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008321
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,38L,39L,42L,43L,44L,47L,48L,51L,52L,55L,56L,57L,60L,61L,66L,67L,70L,71L,72L,75L,76L,79L,80L,81L,82L,83L,84L,87L,88L,91L,92L,93L,96L,97L,102L,103L,106L,107L,108L,111L,112L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008321Inst : IEnumerable<long>
{
public static readonly long[] Value=A008321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008321.Bytes);
public long this[int i]=>Value[i];

public static A008321Inst Instance=new A008321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008322
{
public static readonly BigInteger[] Value={ 1L,2L,9L,730L,737L,389017001L,389017008L,389017729L,400315554L,400315561L,400316282L,789332553L,BigInteger.Parse("58871587162270593034051002"),BigInteger.Parse("58871587162270593034051009"),BigInteger.Parse("58871587162270593034051730") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008322Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008322.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008322Inst Instance=new A008322Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008323
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,12L,34L,218L,4278L,431163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008323Inst : IEnumerable<long>
{
public static readonly long[] Value=A008323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008323.Bytes);
public long this[int i]=>Value[i];

public static A008323Inst Instance=new A008323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008324
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,18L,40L,230L,4296L,431206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008324Inst : IEnumerable<long>
{
public static readonly long[] Value=A008324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008324.Bytes);
public long this[int i]=>Value[i];

public static A008324Inst Instance=new A008324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008325
{
public static readonly long[] Value={ 1L,1L,2L,6L,14L,41L,157L,725L,4196L,29816L,246644L,2297075L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008325Inst : IEnumerable<long>
{
public static readonly long[] Value=A008325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008325.Bytes);
public long this[int i]=>Value[i];

public static A008325Inst Instance=new A008325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008326
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,5L,4L,1L,1L,1L,13L,14L,4L,1L,1L,1L,38L,129L,41L,7L,1L,1L,1L,149L,1980L,1981L,157L,8L,1L,1L,1L,703L,62611L,304495L,62616L,725L,12L,1L,1L,1L,4132L,2806490L,78322915L,78322916L,2806508L,4196L,14L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008326Inst : IEnumerable<long>
{
public static readonly long[] Value=A008326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008326.Bytes);
public long this[int i]=>Value[i];

public static A008326Inst Instance=new A008326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008327
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,4L,6L,4L,1L,1L,1L,1L,4L,14L,14L,4L,1L,1L,1L,1L,7L,41L,130L,41L,7L,1L,1L,1L,1L,8L,157L,1981L,1981L,157L,8L,1L,1L,1L,1L,12L,725L,62616L,304496L,62616L,725L,12L,1L,1L,1L,1L,14L,4196L,2806508L,78322916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008327Inst : IEnumerable<long>
{
public static readonly long[] Value=A008327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008327.Bytes);
public long this[int i]=>Value[i];

public static A008327Inst Instance=new A008327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008328
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,5L,6L,4L,6L,8L,9L,8L,8L,4L,6L,4L,12L,8L,8L,12L,8L,4L,8L,12L,9L,8L,4L,12L,10L,12L,8L,8L,8L,6L,12L,12L,10L,4L,6L,4L,18L,8L,14L,9L,12L,16L,8L,4L,12L,8L,8L,20L,8L,9L,4L,6L,16L,12L,16L,8L,6L,12L,8L,16L,6L,16L,20L,4L,12L,12L,4L,8L,12L,16L,4L,6L,18L,15L,16L,8L,24L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008328Inst : IEnumerable<long>
{
public static readonly long[] Value=A008328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008328.Bytes);
public long this[int i]=>Value[i];

public static A008328Inst Instance=new A008328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008329
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,4L,6L,6L,8L,8L,6L,4L,8L,6L,10L,8L,12L,4L,6L,12L,4L,10L,12L,12L,6L,8L,8L,12L,8L,8L,8L,12L,8L,12L,12L,8L,4L,6L,16L,8L,18L,8L,14L,4L,12L,12L,6L,12L,12L,8L,12L,20L,6L,18L,8L,16L,16L,10L,4L,8L,6L,12L,12L,16L,4L,8L,6L,6L,12L,12L,8L,24L,10L,8L,12L,16L,16L,4L,8L,8L,24L,4L,20L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008329Inst : IEnumerable<long>
{
public static readonly long[] Value=A008329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008329.Bytes);
public long this[int i]=>Value[i];

public static A008329Inst Instance=new A008329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008330
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,4L,8L,6L,10L,12L,8L,12L,16L,12L,22L,24L,28L,16L,20L,24L,24L,24L,40L,40L,32L,40L,32L,52L,36L,48L,36L,48L,64L,44L,72L,40L,48L,54L,82L,84L,88L,48L,72L,64L,84L,60L,48L,72L,112L,72L,112L,96L,64L,100L,128L,130L,132L,72L,88L,96L,92L,144L,96L,120L,96L,156L,80L,96L,172L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008330Inst : IEnumerable<long>
{
public static readonly long[] Value=A008330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008330.Bytes);
public long this[int i]=>Value[i];

public static A008330Inst Instance=new A008330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008331
{
public static readonly long[] Value={ 2L,2L,2L,4L,4L,6L,6L,8L,8L,8L,16L,18L,12L,20L,16L,18L,16L,30L,32L,24L,36L,32L,24L,24L,42L,32L,48L,36L,40L,36L,64L,40L,44L,48L,40L,72L,78L,80L,48L,56L,48L,72L,64L,96L,60L,80L,104L,96L,72L,88L,72L,64L,110L,72L,84L,80L,72L,128L,138L,92L,140L,84L,120L,96L,156L,104L,164L,156L,112L,120L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008331Inst : IEnumerable<long>
{
public static readonly long[] Value=A008331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008331.Bytes);
public long this[int i]=>Value[i];

public static A008331Inst Instance=new A008331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008332
{
public static readonly long[] Value={ 1L,3L,7L,12L,18L,28L,31L,39L,36L,56L,72L,91L,90L,96L,72L,98L,90L,168L,144L,144L,195L,168L,126L,180L,252L,217L,216L,162L,280L,248L,312L,252L,270L,288L,266L,372L,392L,363L,252L,308L,270L,546L,360L,508L,399L,468L,576L,456L,342L,560L,450L,432L,744L,468L,511L,396L,476L,720L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008332Inst : IEnumerable<long>
{
public static readonly long[] Value=A008332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008332.Bytes);
public long this[int i]=>Value[i];

public static A008332Inst Instance=new A008332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008333
{
public static readonly long[] Value={ 4L,7L,12L,15L,28L,24L,39L,42L,60L,72L,63L,60L,96L,84L,124L,120L,168L,96L,126L,195L,114L,186L,224L,234L,171L,216L,210L,280L,216L,240L,255L,336L,288L,336L,372L,300L,240L,294L,480L,360L,546L,336L,508L,294L,468L,465L,378L,504L,560L,432L,546L,744L,399L,728L,528L,720L,720L,558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008333Inst : IEnumerable<long>
{
public static readonly long[] Value=A008333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008333.Bytes);
public long this[int i]=>Value[i];

public static A008333Inst Instance=new A008333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008350
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,4L,3L,3L,4L,3L,3L,4L,4L,3L,5L,4L,5L,6L,5L,3L,6L,6L,5L,6L,6L,6L,8L,6L,6L,7L,7L,6L,10L,8L,7L,8L,9L,7L,10L,9L,9L,11L,11L,8L,11L,10L,10L,12L,12L,9L,13L,11L,13L,14L,13L,10L,17L,14L,12L,13L,15L,13L,17L,15L,15L,17L,18L,13L,19L,16L,16L,18L,21L,15L,20L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008350Inst : IEnumerable<long>
{
public static readonly long[] Value=A008350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008350.Bytes);
public long this[int i]=>Value[i];

public static A008350Inst Instance=new A008350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008351
{
public static readonly BigInteger[] Value={ 1L,2L,21L,212L,21221L,21221212L,2122121221221L,BigInteger.Parse("212212122122121221212"),BigInteger.Parse("2122121221221212212122122121221221"),BigInteger.Parse("2122121221221212212122122121221221212212122122121221212") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008351Inst Instance=new A008351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008352
{
public static readonly BigInteger[] Value={ 1L,2L,12L,212L,12212L,21212212L,1221221212212L,BigInteger.Parse("212122121221221212212"),BigInteger.Parse("1221221212212212122121221221212212"),BigInteger.Parse("2121221212212212122121221221212212212122121221221212212") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A008352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A008352Inst Instance=new A008352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008353
{
public static readonly long[] Value={ 1L,4L,20L,96L,432L,1856L,7744L,31744L,128768L,519168L,2085888L,8364032L,33501184L,134103040L,536625152L,2146959360L,8588820480L,34357379072L,137433972736L,549745328128L,2199001235456L,8796046884864L,35184275619840L,140737287028736L,562949533990912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008353Inst : IEnumerable<long>
{
public static readonly long[] Value=A008353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008353.Bytes);
public long this[int i]=>Value[i];

public static A008353Inst Instance=new A008353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008354
{
public static readonly long[] Value={ 0L,1L,14L,69L,216L,525L,1086L,2009L,3424L,5481L,8350L,12221L,17304L,23829L,32046L,42225L,54656L,69649L,87534L,108661L,133400L,162141L,195294L,233289L,276576L,325625L,380926L,442989L,512344L,589541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008354Inst : IEnumerable<long>
{
public static readonly long[] Value=A008354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008354.Bytes);
public long this[int i]=>Value[i];

public static A008354Inst Instance=new A008354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008355
{
public static readonly long[] Value={ 1L,40L,370L,1640L,4930L,11752L,24050L,44200L,75010L,119720L,182002L,265960L,376130L,517480L,695410L,915752L,1184770L,1509160L,1896050L,2353000L,2888002L,3509480L,4226290L,5047720L,5983490L,7043752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008355Inst : IEnumerable<long>
{
public static readonly long[] Value=A008355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008355.Bytes);
public long this[int i]=>Value[i];

public static A008355Inst Instance=new A008355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008356
{
public static readonly long[] Value={ 1L,41L,411L,2051L,6981L,18733L,42783L,86983L,161993L,281713L,463715L,729675L,1105805L,1623285L,2318695L,3234447L,4419217L,5928377L,7824427L,10177427L,13065429L,16574909L,20801199L,25848919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008356Inst : IEnumerable<long>
{
public static readonly long[] Value=A008356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008356.Bytes);
public long this[int i]=>Value[i];

public static A008356Inst Instance=new A008356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008357
{
public static readonly long[] Value={ 1L,60L,792L,4724L,18096L,52716L,127816L,271908L,524640L,938652L,1581432L,2537172L,3908624L,5818956L,8413608L,11862148L,16360128L,22130940L,29427672L,38534964L,49770864L,63488684L,80078856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008357Inst : IEnumerable<long>
{
public static readonly long[] Value=A008357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008357.Bytes);
public long this[int i]=>Value[i];

public static A008357Inst Instance=new A008357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008358
{
public static readonly long[] Value={ 1L,61L,853L,5577L,23673L,76389L,204205L,476113L,1000753L,1939405L,3520837L,6058009L,9966633L,15785589L,24199197L,36061345L,52421473L,74552413L,103980085L,142515049L,192285913L,255774597L,335853453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008358Inst : IEnumerable<long>
{
public static readonly long[] Value=A008358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008358.Bytes);
public long this[int i]=>Value[i];

public static A008358Inst Instance=new A008358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008359
{
public static readonly long[] Value={ 1L,84L,1498L,11620L,55650L,195972L,559258L,1371316L,2999682L,6003956L,11193882L,19695172L,33023074L,53163684L,82663002L,124723732L,183309826L,263258772L,370401626L,511690788L,695335522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008359Inst : IEnumerable<long>
{
public static readonly long[] Value=A008359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008359.Bytes);
public long this[int i]=>Value[i];

public static A008359Inst Instance=new A008359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008360
{
public static readonly long[] Value={ 1L,85L,1583L,13203L,68853L,264825L,824083L,2195399L,5195081L,11199037L,22392919L,42088091L,75111165L,128274849L,210937851L,335661583L,518971409L,782230181L,1152631807L,1664322595L,2359658117L,3290603337L,4520283747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008360Inst : IEnumerable<long>
{
public static readonly long[] Value=A008360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008360.Bytes);
public long this[int i]=>Value[i];

public static A008360Inst Instance=new A008360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008361
{
public static readonly long[] Value={ 1L,112L,2592L,25424L,149568L,629808L,2100832L,5910288L,14610560L,32641008L,67232416L,129565392L,236214464L,410909616L,686647008L,1108180624L,1734926592L,2644311920L,3935599392L,5734220368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008361Inst : IEnumerable<long>
{
public static readonly long[] Value=A008361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008361.Bytes);
public long this[int i]=>Value[i];

public static A008361Inst Instance=new A008361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008362
{
public static readonly long[] Value={ 1L,113L,2705L,28129L,177697L,807505L,2908337L,8818625L,23429185L,56070193L,123302609L,252868001L,489082465L,899992081L,1586639089L,2694819713L,4429746305L,7074058225L,11009657617L,16743877985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008362Inst : IEnumerable<long>
{
public static readonly long[] Value=A008362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008362.Bytes);
public long this[int i]=>Value[i];

public static A008362Inst Instance=new A008362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008363
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,4L,6L,6L,6L,6L,9L,12L,12L,12L,12L,16L,20L,20L,20L,20L,25L,30L,30L,30L,30L,36L,42L,42L,42L,42L,49L,56L,56L,56L,56L,64L,72L,72L,72L,72L,81L,90L,90L,90L,90L,100L,110L,110L,110L,110L,121L,132L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008363Inst : IEnumerable<long>
{
public static readonly long[] Value=A008363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008363.Bytes);
public long this[int i]=>Value[i];

public static A008363Inst Instance=new A008363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008364
{
public static readonly long[] Value={ 1L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,143L,149L,151L,157L,163L,167L,169L,173L,179L,181L,187L,191L,193L,197L,199L,209L,211L,221L,223L,227L,229L,233L,239L,241L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008364Inst : IEnumerable<long>
{
public static readonly long[] Value=A008364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008364.Bytes);
public long this[int i]=>Value[i];

public static A008364Inst Instance=new A008364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008365
{
public static readonly long[] Value={ 1L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,221L,223L,227L,229L,233L,239L,241L,247L,251L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008365Inst : IEnumerable<long>
{
public static readonly long[] Value=A008365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008365.Bytes);
public long this[int i]=>Value[i];

public static A008365Inst Instance=new A008365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008382
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,2L,4L,8L,16L,32L,48L,72L,108L,162L,243L,324L,432L,576L,768L,1024L,1280L,1600L,2000L,2500L,3125L,3750L,4500L,5400L,6480L,7776L,9072L,10584L,12348L,14406L,16807L,19208L,21952L,25088L,28672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008382Inst : IEnumerable<long>
{
public static readonly long[] Value=A008382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008382.Bytes);
public long this[int i]=>Value[i];

public static A008382Inst Instance=new A008382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008383
{
public static readonly long[] Value={ 1L,20L,110L,340L,780L,1500L,2570L,4060L,6040L,8580L,11750L,15620L,20260L,25740L,32130L,39500L,47920L,57460L,68190L,80180L,93500L,108220L,124410L,142140L,161480L,182500L,205270L,229860L,256340L,284780L,315250L,347820L,382560L,419540L,458830L,500500L,544620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008383Inst : IEnumerable<long>
{
public static readonly long[] Value=A008383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008383.Bytes);
public long this[int i]=>Value[i];

public static A008383Inst Instance=new A008383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008384
{
public static readonly long[] Value={ 1L,21L,131L,471L,1251L,2751L,5321L,9381L,15421L,24001L,35751L,51371L,71631L,97371L,129501L,169001L,216921L,274381L,342571L,422751L,516251L,624471L,748881L,891021L,1052501L,1235001L,1440271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A008384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008384Inst : IEnumerable<long>
{
public static readonly long[] Value=A008384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008384.Bytes);
public long this[int i]=>Value[i];

public static A008384Inst Instance=new A008384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}