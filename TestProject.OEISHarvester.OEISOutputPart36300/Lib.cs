using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A008142
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,50L,71L,97L,129L,163L,200L,240L,287L,343L,401L,461L,523L,591L,665L,741L,822L,905L,990L,1080L,1178L,1285L,1394L,1505L,1621L,1744L,1872L,2001L,2135L,2275L,2420L,2566L,2712L,2861L,3013L,3171L,3332L,3494L,3659L,3832L,4019L,4212L,4407L,4606L };
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
public class A008142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008142Inst : IEnumerable<long>
{
public static readonly long[] Value=A008142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008142.Bytes);
public long this[int i]=>Value[i];

public static A008142Inst Instance=new A008142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008141
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,51L,71L,96L,126L,162L,202L,244L,290L,338L,390L,448L,511L,581L,656L,734L,815L,901L,994L,1090L,1188L,1286L,1389L,1504L,1625L,1750L,1873L,1994L,2122L,2254L,2392L,2540L,2698L,2865L,3028L,3182L,3337L,3500L,3674L,3855L,4032L,4206L,4390L,4584L };
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
public class A008141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008141Inst : IEnumerable<long>
{
public static readonly long[] Value=A008141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008141.Bytes);
public long this[int i]=>Value[i];

public static A008141Inst Instance=new A008141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008140
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,53L,76L,102L,132L,166L,205L,248L,294L,343L,395L,452L,514L,581L,654L,734L,821L,912L,1005L,1100L,1199L,1305L,1416L,1529L,1643L,1758L,1877L,2001L,2130L,2264L,2402L,2543L,2687L,2837L,2997L,3169L,3347L,3523L,3694L,3863L,4039L,4225L,4418L,4614L };
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
public class A008140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008140Inst : IEnumerable<long>
{
public static readonly long[] Value=A008140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008140.Bytes);
public long this[int i]=>Value[i];

public static A008140Inst Instance=new A008140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008139
{
public static readonly long[] Value={ 1L,4L,10L,21L,35L,49L,66L,89L,117L,150L,190L,237L,283L,321L,359L,406L,463L,530L,608L,693L,771L,834L,892L,960L,1045L,1148L,1264L,1383L,1492L,1583L,1666L,1758L,1871L,2006L,2154L,2304L,2443L,2565L,2680L,2804L,2945L,3104L,3277L,3455L,3625L,3781L,3934L,4094L,4263L };
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
public class A008139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008139Inst : IEnumerable<long>
{
public static readonly long[] Value=A008139.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008139.Bytes);
public long this[int i]=>Value[i];

public static A008139Inst Instance=new A008139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008138
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,46L,69L,98L,131L,162L,187L,211L,246L,300L,370L,445L,512L,563L,599L,635L,694L,789L,911L,1033L,1131L,1198L,1246L,1301L,1390L,1524L,1687L,1846L,1973L,2063L,2135L,2220L,2343L,2507L,2694L,2876L,3032L,3159L,3272L,3396L,3549L,3732L,3931L,4129L };
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
public class A008138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008138Inst : IEnumerable<long>
{
public static readonly long[] Value=A008138.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008138.Bytes);
public long this[int i]=>Value[i];

public static A008138Inst Instance=new A008138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008137
{
public static readonly long[] Value={ 1L,4L,9L,17L,28L,42L,60L,81L,105L,132L,162L,196L,233L,273L,316L,362L,412L,465L,521L,580L,642L,708L,777L,849L,924L,1002L,1084L,1169L,1257L,1348L,1442L,1540L,1641L,1745L,1852L,1962L,2076L,2193L,2313L,2436L,2562L,2692L,2825L,2961L,3100L,3242L,3388L,3537L,3689L };
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
public class A008137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008137Inst : IEnumerable<long>
{
public static readonly long[] Value=A008137.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008137.Bytes);
public long this[int i]=>Value[i];

public static A008137Inst Instance=new A008137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008136
{
public static readonly long[] Value={ 1L,4L,8L,20L,40L,54L,76L,116L,144L,200L,210L,264L,348L,376L,448L,502L,556L,672L,748L,812L,906L,976L,1096L,1240L,1292L,1382L,1528L,1640L,1808L,1932L,1966L,2200L,2308L,2484L,2684L,2654L,2936L,3140L,3260L,3496L,3534L,3784L,4068L,4176L,4412L,4526L,4728L,5048L };
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
public class A008136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008136Inst : IEnumerable<long>
{
public static readonly long[] Value=A008136.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008136.Bytes);
public long this[int i]=>Value[i];

public static A008136Inst Instance=new A008136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008135
{
public static readonly long[] Value={ 1L,4L,9L,19L,39L,55L,79L,113L,149L,177L,229L,270L,326L,391L,436L,504L,574L,653L,740L,815L,896L,995L,1093L,1205L,1302L,1410L,1510L,1644L,1793L,1889L,2042L,2143L,2333L,2476L,2591L,2791L,2896L,3101L,3283L,3414L,3635L,3772L,3987L,4229L,4335L,4592L,4758L,5004L };
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
public class A008135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008135Inst : IEnumerable<long>
{
public static readonly long[] Value=A008135.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008135.Bytes);
public long this[int i]=>Value[i];

public static A008135Inst Instance=new A008135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008134
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,58L,87L,111L,138L,187L,232L,279L,325L,370L,448L,520L,582L,654L,720L,812L,924L,1009L,1087L,1182L,1295L,1436L,1553L,1627L,1756L,1905L,2047L,2212L,2294L,2428L,2632L,2782L,2969L,3079L,3212L,3467L,3647L,3824L,3977L,4128L,4395L,4629L,4812L,4964L };
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
public class A008134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008134Inst : IEnumerable<long>
{
public static readonly long[] Value=A008134.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008134.Bytes);
public long this[int i]=>Value[i];

public static A008134Inst Instance=new A008134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008133
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,4L,6L,9L,9L,12L,16L,16L,20L,25L,25L,30L,36L,36L,42L,49L,49L,56L,64L,64L,72L,81L,81L,90L,100L,100L,110L,121L,121L,132L,144L,144L,156L,169L,169L,182L,196L,196L,210L,225L,225L,240L,256L,256L,272L,289L,289L,306L,324L,324L,342L,361L,361L,380L,400L,400L,420L,441L,441L,462L,484L,484L,506L };
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
public class A008133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008133Inst : IEnumerable<long>
{
public static readonly long[] Value=A008133.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008133.Bytes);
public long this[int i]=>Value[i];

public static A008133Inst Instance=new A008133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008132
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,52L,74L,102L,136L,172L,210L,252L,300L,354L,410L,468L,530L,600L,678L,756L,834L,916L,1006L,1104L,1202L,1300L,1402L,1514L,1636L,1756L,1874L,1996L,2128L,2270L,2410L,2548L,2690L,2844L,3010L,3172L,3330L,3492L,3666L,3852L,4034L,4212L,4394L,4590L };
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
public class A008132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008132Inst : IEnumerable<long>
{
public static readonly long[] Value=A008132.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008132.Bytes);
public long this[int i]=>Value[i];

public static A008132Inst Instance=new A008132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008131
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,52L,74L,102L,136L,172L,208L,248L,298L,356L,414L,470L,530L,600L,678L,756L,832L,912L,1004L,1106L,1206L,1300L,1398L,1512L,1638L,1760L,1874L,1992L,2126L,2272L,2414L,2548L,2686L,2842L,3012L,3176L,3328L,3484L,3662L,3856L,4042L,4214L,4390L,4588L };
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
public class A008131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008131Inst : IEnumerable<long>
{
public static readonly long[] Value=A008131.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008131.Bytes);
public long this[int i]=>Value[i];

public static A008131Inst Instance=new A008131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008130
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,2L,4L,6L,6L,9L,12L,12L,16L,20L,20L,25L,30L,30L,36L,42L,42L,49L,56L,56L,64L,72L,72L,81L,90L,90L,100L,110L,110L,121L,132L,132L,144L,156L,156L,169L,182L,182L,196L,210L,210L,225L,240L,240L,256L,272L,272L,289L };
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
public class A008130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008130Inst : IEnumerable<long>
{
public static readonly long[] Value=A008130.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008130.Bytes);
public long this[int i]=>Value[i];

public static A008130Inst Instance=new A008130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008129
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,53L,76L,103L,135L,170L,209L,252L,300L,354L,410L,470L,534L,602L,676L,752L,833L,918L,1007L,1103L,1200L,1301L,1406L,1516L,1634L,1752L,1874L,2000L,2130L,2268L,2406L,2549L,2696L,2847L,3007L,3166L,3329L,3496L,3668L,3850L,4030L,4214L,4402L,4594L };
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
public class A008129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008129Inst : IEnumerable<long>
{
public static readonly long[] Value=A008129.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008129.Bytes);
public long this[int i]=>Value[i];

public static A008129Inst Instance=new A008129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008128
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,46L,64L,90L,124L,156L,184L,214L,256L,312L,368L,418L,464L,518L,588L,662L,734L,804L,880L,966L,1050L,1134L,1224L,1326L,1438L,1540L,1634L,1734L,1854L,1992L,2118L,2230L,2344L,2478L,2634L,2780L,2912L,3044L,3196L,3372L,3536L,3684L,3832L,4002L,4198L };
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
public class A008128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008128Inst : IEnumerable<long>
{
public static readonly long[] Value=A008128.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008128.Bytes);
public long this[int i]=>Value[i];

public static A008128Inst Instance=new A008128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008127
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,49L,71L,92L,114L,143L,183L,229L,271L,308L,349L,404L,470L,535L,595L,655L,724L,802L,882L,963L,1048L,1141L,1236L,1326L,1418L,1522L,1641L,1761L,1869L,1973L,2089L,2226L,2369L,2499L,2621L,2753L,2907L,3068L,3216L,3356L,3506L,3679L,3860L,4027L,4184L };
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
public class A008127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008127Inst : IEnumerable<long>
{
public static readonly long[] Value=A008127.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008127.Bytes);
public long this[int i]=>Value[i];

public static A008127Inst Instance=new A008127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008126
{
public static readonly long[] Value={ 1L,4L,10L,19L,33L,53L,74L,96L,127L,166L,201L,236L,283L,340L,395L,443L,500L,574L,650L,715L,783L,871L,965L,1051L,1134L,1230L,1340L,1447L,1549L,1658L,1779L,1902L,2025L,2152L,2283L,2420L,2562L,2707L,2853L,3003L,3160L,3324L,3488L,3650L,3822L,4003L,4183L,4361L };
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
public class A008126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008126Inst : IEnumerable<long>
{
public static readonly long[] Value=A008126.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008126.Bytes);
public long this[int i]=>Value[i];

public static A008126Inst Instance=new A008126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008125
{
public static readonly long[] Value={ 1L,4L,10L,19L,32L,52L,74L,99L,126L,162L,203L,240L,282L,337L,394L,444L,503L,574L,646L,715L,787L,872L,962L,1048L,1135L,1235L,1340L,1442L,1549L,1661L,1780L,1901L,2023L,2151L,2286L,2422L,2558L,2706L,2856L,3004L,3159L,3322L,3488L,3652L,3822L,4001L,4184L,4363L };
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
public class A008125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008125Inst : IEnumerable<long>
{
public static readonly long[] Value=A008125.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008125.Bytes);
public long this[int i]=>Value[i];

public static A008125Inst Instance=new A008125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008124
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,51L,74L,99L,128L,161L,199L,243L,288L,333L,386L,449L,511L,571L,638L,715L,796L,874L,954L,1044L,1142L,1239L,1336L,1439L,1549L,1665L,1781L,1898L,2022L,2153L,2286L,2421L,2561L,2704L,2853L,3007L,3162L,3320L,3484L,3654L,3826L,4000L,4179L,4365L };
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
public class A008124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008124Inst : IEnumerable<long>
{
public static readonly long[] Value=A008124.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008124.Bytes);
public long this[int i]=>Value[i];

public static A008124Inst Instance=new A008124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008123
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,86L,112L,141L,173L,209L,249L,292L,338L,388L,441L,497L,557L,621L,688L,758L,832L,909L,989L,1073L,1161L,1252L,1346L,1444L,1545L,1649L,1757L,1869L,1984L,2102L,2224L,2349L,2477L,2609L,2745L,2884L,3026L,3172L,3321L,3473L,3629L,3789L,3952L };
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
public class A008123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008123Inst : IEnumerable<long>
{
public static readonly long[] Value=A008123.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008123.Bytes);
public long this[int i]=>Value[i];

public static A008123Inst Instance=new A008123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008122
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,56L,86L,118L,146L,176L,228L,286L,330L,376L,438L,518L,588L,650L,732L,818L,906L,998L,1100L,1206L,1292L,1402L,1542L,1668L,1770L,1874L,2036L,2204L,2322L,2442L,2598L,2788L,2948L,3084L,3260L,3440L,3618L,3800L,3996L,4196L,4356L,4556L,4806L,5026L };
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
public class A008122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008122Inst : IEnumerable<long>
{
public static readonly long[] Value=A008122.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008122.Bytes);
public long this[int i]=>Value[i];

public static A008122Inst Instance=new A008122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008121
{
public static readonly long[] Value={ 1L,4L,10L,21L,39L,61L,81L,107L,148L,192L,228L,266L,324L,393L,449L,503L,575L,659L,738L,814L,906L,1002L,1090L,1191L,1311L,1427L,1521L,1629L,1780L,1926L,2036L,2148L,2308L,2487L,2625L,2753L,2919L,3105L,3274L,3432L,3618L,3808L,3978L,4169L,4391L,4601L,4769L,4959L };
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
public class A008121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008121Inst : IEnumerable<long>
{
public static readonly long[] Value=A008121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008121.Bytes);
public long this[int i]=>Value[i];

public static A008121Inst Instance=new A008121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008120
{
public static readonly long[] Value={ 1L,4L,12L,18L,34L,62L,88L,110L,132L,196L,254L,278L,312L,382L,486L,540L,574L,652L,754L,868L,938L,1008L,1116L,1228L,1364L,1466L,1562L,1680L,1808L,1992L,2126L,2216L,2348L,2526L,2750L,2878L,2978L,3156L,3364L,3600L,3744L,3878L,4086L,4304L,4564L,4740L,4900L,5116L };
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
public class A008120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008120Inst : IEnumerable<long>
{
public static readonly long[] Value=A008120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008120.Bytes);
public long this[int i]=>Value[i];

public static A008120Inst Instance=new A008120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008119
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,61L,89L,111L,146L,194L,243L,281L,322L,398L,474L,531L,586L,662L,767L,854L,934L,1024L,1122L,1243L,1353L,1464L,1572L,1685L,1837L,1980L,2112L,2231L,2365L,2554L,2725L,2869L,3003L,3171L,3391L,3574L,3737L,3906L,4099L,4334L,4540L,4735L,4923L,5127L };
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
public class A008119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008119Inst : IEnumerable<long>
{
public static readonly long[] Value=A008119.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008119.Bytes);
public long this[int i]=>Value[i];

public static A008119Inst Instance=new A008119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008118
{
public static readonly long[] Value={ 1L,4L,10L,19L,37L,58L,84L,109L,149L,201L,236L,274L,328L,399L,474L,521L,585L,670L,767L,861L,923L,1011L,1130L,1248L,1363L,1448L,1563L,1697L,1836L,1989L,2097L,2221L,2381L,2555L,2732L,2844L,2996L,3194L,3391L,3583L,3715L,3893L,4116L,4336L,4556L,4707L,4909L,5153L };
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
public class A008118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008118Inst : IEnumerable<long>
{
public static readonly long[] Value=A008118.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008118.Bytes);
public long this[int i]=>Value[i];

public static A008118Inst Instance=new A008118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008117
{
public static readonly long[] Value={ 1L,4L,11L,23L,39L,55L,82L,127L,158L,178L,221L,291L,361L,393L,434L,519L,619L,698L,741L,821L,936L,1047L,1152L,1224L,1323L,1453L,1595L,1734L,1822L,1932L,2087L,2271L,2435L,2523L,2654L,2852L,3066L,3240L,3341L,3504L,3735L,3964L,4158L,4291L,4477L,4718L,4975L,5210L };
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
public class A008117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008117Inst : IEnumerable<long>
{
public static readonly long[] Value=A008117.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008117.Bytes);
public long this[int i]=>Value[i];

public static A008117Inst Instance=new A008117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008116
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,62L,85L,104L,148L,201L,241L,274L,323L,400L,471L,531L,582L,661L,774L,859L,928L,1011L,1120L,1254L,1358L,1460L,1564L,1682L,1841L,1985L,2112L,2221L,2361L,2567L,2725L,2859L,2996L,3173L,3404L,3577L,3730L,3892L,4094L,4351L,4545L,4728L,4909L,5127L };
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
public class A008116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008116Inst : IEnumerable<long>
{
public static readonly long[] Value=A008116.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008116.Bytes);
public long this[int i]=>Value[i];

public static A008116Inst Instance=new A008116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008115
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,52L,78L,110L,140L,176L,212L,258L,320L,366L,418L,488L,546L,618L,710L,772L,850L,964L,1038L,1132L,1262L,1332L,1440L,1596L,1676L,1792L,1964L,2050L,2184L,2384L,2468L,2610L,2838L,2926L,3080L,3324L,3410L,3582L,3860L,3948L,4124L,4424L,4514L,4712L };
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
public class A008115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008115Inst : IEnumerable<long>
{
public static readonly long[] Value=A008115.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008115.Bytes);
public long this[int i]=>Value[i];

public static A008115Inst Instance=new A008115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008114
{
public static readonly long[] Value={ 1L,4L,10L,20L,34L,58L,82L,102L,136L,176L,220L,266L,306L,362L,428L,484L,550L,626L,694L,778L,868L,942L,1042L,1146L,1230L,1350L,1468L,1554L,1684L,1822L,1926L,2072L,2214L,2322L,2494L,2654L,2764L,2950L,3126L,3246L,3450L,3638L,3762L,3984L,4188L,4322L,4566L,4778L };
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
public class A008114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008114Inst : IEnumerable<long>
{
public static readonly long[] Value=A008114.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008114.Bytes);
public long this[int i]=>Value[i];

public static A008114Inst Instance=new A008114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008113
{
public static readonly long[] Value={ 1L,4L,9L,19L,36L,56L,76L,106L,142L,172L,217L,265L,306L,367L,426L,480L,554L,626L,690L,779L,868L,940L,1046L,1146L,1227L,1352L,1462L,1554L,1695L,1818L,1918L,2075L,2215L,2321L,2497L,2650L,2762L,2958L,3121L,3242L,3457L,3632L,3760L,3993L,4184L,4317L,4570L,4774L };
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
public class A008113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008113Inst : IEnumerable<long>
{
public static readonly long[] Value=A008113.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008113.Bytes);
public long this[int i]=>Value[i];

public static A008113Inst Instance=new A008113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008112
{
public static readonly long[] Value={ 1L,4L,10L,20L,36L,55L,77L,108L,140L,174L,219L,263L,309L,368L,423L,480L,555L,623L,690L,782L,865L,942L,1050L,1144L,1230L,1355L,1459L,1554L,1696L,1813L,1918L,2078L,2210L,2323L,2502L,2647L,2766L,2963L,3117L,3243L,3460L,3626L,3759L,3996L,4178L,4318L,4575L,4770L };
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
public class A008112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008112Inst : IEnumerable<long>
{
public static readonly long[] Value=A008112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008112.Bytes);
public long this[int i]=>Value[i];

public static A008112Inst Instance=new A008112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008111
{
public static readonly long[] Value={ 1L,4L,9L,19L,36L,56L,80L,102L,132L,180L,220L,260L,310L,359L,423L,496L,548L,613L,707L,772L,853L,967L,1033L,1125L,1259L,1338L,1446L,1593L,1670L,1792L,1972L,2052L,2178L,2381L,2470L,2613L,2833L,2919L,3079L,3330L,3416L,3582L,3856L,3941L,4125L,4434L,4518L,4705L };
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
public class A008111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008111Inst : IEnumerable<long>
{
public static readonly long[] Value=A008111.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008111.Bytes);
public long this[int i]=>Value[i];

public static A008111Inst Instance=new A008111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008110
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,65L,89L,116L,144L,175L,213L,256L,300L,346L,397L,452L,509L,570L,636L,705L,777L,853L,932L,1013L,1098L,1189L,1284L,1381L,1480L,1582L,1689L,1801L,1916L,2033L,2154L,2280L,2408L,2538L,2673L,2813L,2956L,3102L,3252L,3404L,3558L,3718L,3884L,4052L };
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
public class A008110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008110Inst : IEnumerable<long>
{
public static readonly long[] Value=A008110.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008110.Bytes);
public long this[int i]=>Value[i];

public static A008110Inst Instance=new A008110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008093
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,50L,75L,98L,118L,144L,185L,238L,288L,326L,360L,408L,479L,560L,631L,687L,743L,817L,910L,1009L,1101L,1185L,1271L,1367L,1474L,1588L,1705L,1822L,1936L,2050L,2172L,2307L,2451L,2593L,2728L,2863L,3010L,3172L,3337L,3494L,3647L,3810L,3990L,4177L };
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
public class A008093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008093Inst : IEnumerable<long>
{
public static readonly long[] Value=A008093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008093.Bytes);
public long this[int i]=>Value[i];

public static A008093Inst Instance=new A008093Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008092
{
public static readonly long[] Value={ 1L,4L,12L,20L,39L,66L,90L,118L,164L,214L,245L,292L,373L,443L,487L,546L,660L,753L,803L,888L,1032L,1142L,1198L,1313L,1486L,1607L,1677L,1813L,2027L,2164L,2229L,2389L,2649L,2801L,2862L,3056L,3351L,3516L,3577L,3795L,4138L,4315L,4370L,4621L,5017L,5183L,5231L,5537L };
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
public class A008092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008092Inst : IEnumerable<long>
{
public static readonly long[] Value=A008092.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008092.Bytes);
public long this[int i]=>Value[i];

public static A008092Inst Instance=new A008092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008091
{
public static readonly long[] Value={ 1L,4L,12L,22L,37L,64L,94L,119L,161L,204L,252L,304L,366L,430L,488L,564L,657L,736L,805L,904L,1033L,1123L,1198L,1331L,1487L,1588L,1678L,1835L,2024L,2138L,2231L,2424L,2646L,2765L,2863L,3094L,3353L,3473L,3582L,3836L,4136L,4275L,4370L,4665L,5011L,5147L,5238L,5576L };
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
public class A008091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008091Inst : IEnumerable<long>
{
public static readonly long[] Value=A008091.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008091.Bytes);
public long this[int i]=>Value[i];

public static A008091Inst Instance=new A008091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008090
{
public static readonly long[] Value={ 1L,4L,11L,24L,42L,63L,93L,127L,160L,206L,262L,308L,356L,429L,510L,572L,634L,731L,846L,919L,983L,1117L,1263L,1340L,1424L,1589L,1753L,1846L,1944L,2129L,2334L,2442L,2535L,2758L,3001L,3105L,3206L,3468L,3748L,3867L,3959L,4244L,4583L,4701L,4778L,5127L,5510L,5599L };
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
public class A008090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008090Inst : IEnumerable<long>
{
public static readonly long[] Value=A008090.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008090.Bytes);
public long this[int i]=>Value[i];

public static A008090Inst Instance=new A008090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008089
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,120L,145L,174L,210L,251L,292L,331L,371L,418L,475L,539L,602L,659L,713L,772L,843L,925L,1011L,1093L,1168L,1241L,1321L,1415L,1520L,1625L,1722L,1813L,1908L,2015L,2133L,2254L,2371L,2486L,2606L,2732L,2860L,2988L,3120L,3261L,3410L };
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
public class A008089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008089Inst : IEnumerable<long>
{
public static readonly long[] Value=A008089.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008089.Bytes);
public long this[int i]=>Value[i];

public static A008089Inst Instance=new A008089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008088
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,97L,124L,152L,180L,210L,245L,287L,336L,388L,437L,481L,526L,581L,648L,722L,797L,866L,929L,993L,1066L,1153L,1249L,1347L,1439L,1522L,1604L,1695L,1802L,1920L,2039L,2152L,2257L,2361L,2472L,2596L,2732L,2873L,3013L,3146L,3271L,3396L };
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
public class A008088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008088Inst : IEnumerable<long>
{
public static readonly long[] Value=A008088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008088.Bytes);
public long this[int i]=>Value[i];

public static A008088Inst Instance=new A008088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008087
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,121L,148L,179L,214L,252L,294L,338L,382L,427L,477L,534L,595L,657L,718L,779L,846L,923L,1006L,1087L,1165L,1245L,1330L,1421L,1517L,1615L,1714L,1815L,1918L,2023L,2131L,2247L,2370L,2494L,2616L,2737L,2863L,2995L,3132L,3271L,3410L };
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
public class A008087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008087Inst : IEnumerable<long>
{
public static readonly long[] Value=A008087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008087.Bytes);
public long this[int i]=>Value[i];

public static A008087Inst Instance=new A008087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008086
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,121L,148L,178L,212L,250L,291L,335L,381L,428L,479L,534L,591L,651L,716L,784L,854L,928L,1003L,1078L,1158L,1244L,1335L,1430L,1523L,1613L,1706L,1806L,1914L,2029L,2145L,2256L,2366L,2480L,2600L,2731L,2870L,3008L,3139L,3266L,3399L };
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
public class A008086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008086Inst : IEnumerable<long>
{
public static readonly long[] Value=A008086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008086.Bytes);
public long this[int i]=>Value[i];

public static A008086Inst Instance=new A008086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008085
{
public static readonly long[] Value={ 1L,4L,8L,18L,32L,52L,74L,100L,128L,162L,204L,244L,286L,340L,396L,450L,512L,580L,650L,724L,800L,882L,972L,1060L,1150L,1252L,1356L,1458L,1568L,1684L,1802L,1924L,2048L,2178L,2316L,2452L,2590L,2740L,2892L,3042L,3200L,3364L,3530L,3700L,3872L,4050L,4236L,4420L };
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
public class A008085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008085Inst : IEnumerable<long>
{
public static readonly long[] Value=A008085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008085.Bytes);
public long this[int i]=>Value[i];

public static A008085Inst Instance=new A008085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008084
{
public static readonly long[] Value={ 1L,4L,9L,19L,35L,52L,72L,100L,131L,163L,201L,244L,290L,340L,393L,451L,515L,580L,648L,724L,803L,883L,969L,1060L,1154L,1252L,1353L,1459L,1571L,1684L,1800L,1924L,2051L,2179L,2313L,2452L,2594L,2740L,2889L,3043L,3203L,3364L,3528L,3700L,3875L,4051L,4233L,4420L };
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
public class A008084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008084Inst : IEnumerable<long>
{
public static readonly long[] Value=A008084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008084.Bytes);
public long this[int i]=>Value[i];

public static A008084Inst Instance=new A008084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008083
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,46L,66L,94L,128L,162L,192L,222L,262L,318L,382L,440L,488L,536L,598L,678L,766L,848L,920L,992L,1076L,1174L,1280L,1386L,1488L,1588L,1692L,1806L,1930L,2060L,2190L,2316L,2442L,2576L,2722L,2874L,3024L,3172L,3324L,3486L,3656L,3826L,3992L,4160L,4340L };
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
public class A008083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008083Inst : IEnumerable<long>
{
public static readonly long[] Value=A008083.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008083.Bytes);
public long this[int i]=>Value[i];

public static A008083Inst Instance=new A008083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008082
{
public static readonly long[] Value={ 1L,4L,9L,17L,30L,49L,71L,92L,115L,147L,190L,238L,283L,323L,363L,413L,479L,554L,624L,684L,745L,820L,910L,1006L,1099L,1187L,1274L,1367L,1471L,1585L,1703L,1819L,1933L,2050L,2175L,2309L,2449L,2590L,2728L,2866L,3012L,3169L,3330L,3488L,3647L,3815L,3993L,4174L };
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
public class A008082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008082Inst : IEnumerable<long>
{
public static readonly long[] Value=A008082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008082.Bytes);
public long this[int i]=>Value[i];

public static A008082Inst Instance=new A008082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008081
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,61L,101L,133L,156L,204L,256L,314L,391L,444L,492L,589L,686L,760L,843L,951L,1063L,1157L,1285L,1416L,1461L,1630L,1841L,1903L,2058L,2214L,2347L,2555L,2713L,2901L,3024L,3172L,3446L,3655L,3804L,4002L,4213L,4391L,4684L,4938L,5088L,5314L,5549L };
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
public class A008081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008081Inst : IEnumerable<long>
{
public static readonly long[] Value=A008081.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008081.Bytes);
public long this[int i]=>Value[i];

public static A008081Inst Instance=new A008081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008080
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,68L,90L,122L,167L,210L,268L,318L,374L,444L,507L,606L,694L,756L,847L,946L,1040L,1190L,1284L,1376L,1521L,1632L,1814L,1962L,2049L,2202L,2366L,2534L,2752L,2878L,3009L,3240L,3414L,3648L,3853L,3976L,4200L,4450L,4674L,4946L,5097L,5300L,5610L,5824L };
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
public class A008080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008080Inst : IEnumerable<long>
{
public static readonly long[] Value=A008080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008080.Bytes);
public long this[int i]=>Value[i];

public static A008080Inst Instance=new A008080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008079
{
public static readonly long[] Value={ 1L,4L,11L,24L,41L,63L,91L,128L,171L,214L,259L,313L,381L,449L,521L,594L,668L,762L,862L,960L,1058L,1156L,1271L,1414L,1536L,1646L,1777L,1905L,2075L,2245L,2383L,2534L,2681L,2873L,3089L,3266L,3429L,3592L,3790L,4032L,4264L,4452L,4639L,4856L,5109L,5400L,5632L,5828L };
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
public class A008079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008079Inst : IEnumerable<long>
{
public static readonly long[] Value=A008079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008079.Bytes);
public long this[int i]=>Value[i];

public static A008079Inst Instance=new A008079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008078
{
public static readonly long[] Value={ 1L,4L,12L,23L,41L,64L,92L,128L,167L,207L,259L,318L,378L,447L,514L,588L,681L,756L,855L,956L,1047L,1168L,1288L,1380L,1521L,1652L,1774L,1950L,2049L,2209L,2389L,2515L,2729L,2885L,3027L,3242L,3424L,3617L,3840L,3998L,4205L,4449L,4656L,4897L,5129L,5317L,5589L,5854L };
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
public class A008078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008078Inst : IEnumerable<long>
{
public static readonly long[] Value=A008078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008078.Bytes);
public long this[int i]=>Value[i];

public static A008078Inst Instance=new A008078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008029
{
public static readonly long[] Value={ 1L,4L,8L,14L,25L,39L,53L,71L,96L,124L,152L,179L,208L,247L,293L,336L,378L,424L,474L,530L,591L,652L,713L,776L,843L,918L,997L,1073L,1151L,1235L,1321L,1410L,1504L,1601L,1700L,1799L,1899L,2007L,2122L,2236L,2350L,2467L,2586L,2711L,2843L,2976L,3108L,3240L,3376L };
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
public class A008029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008029Inst : IEnumerable<long>
{
public static readonly long[] Value=A008029.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008029.Bytes);
public long this[int i]=>Value[i];

public static A008029Inst Instance=new A008029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008028
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,65L,88L,113L,141L,175L,216L,258L,297L,340L,394L,455L,514L,570L,631L,702L,780L,858L,932L,1008L,1095L,1192L,1289L,1380L,1472L,1576L,1692L,1809L,1918L,2025L,2145L,2280L,2416L,2543L,2668L,2805L,2956L,3110L,3257L,3399L,3550L,3718L,3892L,4057L };
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
public class A008028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008028Inst : IEnumerable<long>
{
public static readonly long[] Value=A008028.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008028.Bytes);
public long this[int i]=>Value[i];

public static A008028Inst Instance=new A008028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008027
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,86L,113L,144L,178L,215L,254L,297L,345L,397L,451L,507L,570L,638L,706L,776L,851L,932L,1015L,1099L,1188L,1281L,1378L,1479L,1583L,1691L,1801L,1914L,2032L,2154L,2279L,2405L,2536L,2675L,2816L,2956L,3099L,3250L,3406L,3561L,3718L,3881L,4049L };
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
public class A008027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008027Inst : IEnumerable<long>
{
public static readonly long[] Value=A008027.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008027.Bytes);
public long this[int i]=>Value[i];

public static A008027Inst Instance=new A008027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008026
{
public static readonly long[] Value={ 1L,4L,9L,17L,29L,45L,64L,85L,110L,140L,173L,208L,247L,294L,347L,399L,449L,504L,570L,641L,708L,774L,848L,932L,1018L,1101L,1186L,1278L,1377L,1479L,1581L,1684L,1791L,1907L,2032L,2158L,2279L,2400L,2533L,2678L,2821L,2956L,3094L,3247L,3409L,3566L,3718L,3876L,4046L };
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
public class A008026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008026Inst : IEnumerable<long>
{
public static readonly long[] Value=A008026.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008026.Bytes);
public long this[int i]=>Value[i];

public static A008026Inst Instance=new A008026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008025
{
public static readonly long[] Value={ 1L,4L,9L,18L,30L,43L,62L,85L,105L,135L,180L,217L,251L,295L,330L,366L,429L,505L,572L,628L,681L,744L,822L,898L,974L,1075L,1179L,1254L,1329L,1432L,1538L,1627L,1728L,1869L,2010L,2104L,2198L,2335L,2466L,2571L,2703L,2887L,3065L,3178L,3276L,3435L,3618L,3754L,3896L };
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
public class A008025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008025Inst : IEnumerable<long>
{
public static readonly long[] Value=A008025.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008025.Bytes);
public long this[int i]=>Value[i];

public static A008025Inst Instance=new A008025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008024
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,39L,61L,86L,109L,134L,163L,194L,236L,292L,344L,388L,438L,493L,547L,608L,682L,763L,840L,907L,974L,1054L,1142L,1231L,1331L,1444L,1550L,1643L,1744L,1860L,1970L,2073L,2200L,2352L,2490L,2604L,2722L,2855L,2991L,3130L,3291L,3475L,3644L,3777L,3915L };
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
public class A008024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008024Inst : IEnumerable<long>
{
public static readonly long[] Value=A008024.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008024.Bytes);
public long this[int i]=>Value[i];

public static A008024Inst Instance=new A008024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008023
{
public static readonly long[] Value={ 1L,4L,9L,17L,28L,42L,60L,83L,111L,138L,166L,207L,251L,286L,329L,386L,441L,493L,553L,622L,690L,751L,818L,903L,991L,1064L,1142L,1248L,1352L,1430L,1518L,1642L,1766L,1858L,1957L,2099L,2235L,2330L,2440L,2598L,2752L,2865L,2986L,3161L,3333L,3448L,3573L,3772L,3971L };
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
public class A008023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008023Inst : IEnumerable<long>
{
public static readonly long[] Value=A008023.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008023.Bytes);
public long this[int i]=>Value[i];

public static A008023Inst Instance=new A008023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008022
{
public static readonly long[] Value={ 1L,4L,10L,17L,28L,47L,65L,86L,117L,144L,169L,211L,259L,295L,338L,396L,448L,501L,566L,632L,698L,767L,841L,923L,1005L,1084L,1175L,1275L,1365L,1457L,1567L,1676L,1780L,1895L,2013L,2129L,2252L,2380L,2512L,2648L,2782L,2919L,3068L,3219L,3364L,3518L,3683L,3845L,4003L };
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
public class A008022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008022Inst : IEnumerable<long>
{
public static readonly long[] Value=A008022.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008022.Bytes);
public long this[int i]=>Value[i];

public static A008022Inst Instance=new A008022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008021
{
public static readonly long[] Value={ 1L,4L,9L,18L,29L,42L,66L,93L,112L,139L,177L,210L,249L,302L,347L,387L,443L,505L,566L,632L,698L,768L,844L,917L,998L,1093L,1182L,1267L,1364L,1463L,1560L,1670L,1788L,1900L,2009L,2124L,2251L,2384L,2513L,2645L,2784L,2923L,3065L,3213L,3366L,3524L,3680L,3837L,4008L };
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
public class A008021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008021Inst : IEnumerable<long>
{
public static readonly long[] Value=A008021.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008021.Bytes);
public long this[int i]=>Value[i];

public static A008021Inst Instance=new A008021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008020
{
public static readonly long[] Value={ 1L,4L,9L,18L,30L,43L,64L,90L,111L,140L,181L,215L,249L,296L,342L,389L,450L,511L,565L,624L,690L,766L,850L,927L,1003L,1088L,1172L,1262L,1368L,1471L,1566L,1669L,1779L,1892L,2011L,2132L,2256L,2384L,2510L,2642L,2784L,2925L,3067L,3214L,3364L,3521L,3680L,3838L,4007L };
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
public class A008020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008020Inst : IEnumerable<long>
{
public static readonly long[] Value=A008020.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008020.Bytes);
public long this[int i]=>Value[i];

public static A008020Inst Instance=new A008020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008019
{
public static readonly long[] Value={ 1L,4L,9L,16L,27L,43L,63L,88L,115L,141L,171L,210L,255L,300L,343L,388L,443L,505L,565L,627L,695L,768L,846L,923L,998L,1082L,1177L,1273L,1369L,1464L,1557L,1663L,1781L,1895L,2012L,2135L,2254L,2378L,2512L,2643L,2778L,2927L,3074L,3216L,3362L,3512L,3674L,3843L,4005L };
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
public class A008019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008019Inst : IEnumerable<long>
{
public static readonly long[] Value=A008019.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008019.Bytes);
public long this[int i]=>Value[i];

public static A008019Inst Instance=new A008019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008018
{
public static readonly long[] Value={ 1L,4L,12L,23L,37L,55L,82L,118L,155L,189L,232L,282L,334L,390L,456L,523L,587L,660L,750L,845L,933L,1015L,1112L,1224L,1334L,1446L,1572L,1691L,1801L,1925L,2074L,2234L,2379L,2513L,2668L,2834L,2994L,3158L,3340L,3519L,3683L,3864L,4078L,4295L,4489L,4667L,4872L,5102L };
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
public class A008018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008018Inst : IEnumerable<long>
{
public static readonly long[] Value=A008018.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008018.Bytes);
public long this[int i]=>Value[i];

public static A008018Inst Instance=new A008018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008017
{
public static readonly long[] Value={ 1L,4L,11L,21L,36L,56L,82L,115L,156L,195L,231L,274L,332L,396L,459L,519L,588L,665L,742L,830L,932L,1029L,1119L,1216L,1334L,1456L,1567L,1675L,1800L,1940L,2078L,2221L,2380L,2527L,2659L,2810L,2992L,3180L,3351L,3507L,3684L,3879L,4066L,4266L,4488L,4695L,4883L,5084L };
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
public class A008017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008017Inst : IEnumerable<long>
{
public static readonly long[] Value=A008017.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008017.Bytes);
public long this[int i]=>Value[i];

public static A008017Inst Instance=new A008017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008016
{
public static readonly long[] Value={ 1L,4L,11L,22L,41L,65L,88L,111L,145L,186L,231L,281L,336L,395L,455L,518L,597L,679L,752L,827L,921L,1024L,1123L,1222L,1330L,1442L,1555L,1678L,1821L,1965L,2088L,2207L,2357L,2518L,2671L,2829L,2996L,3167L,3335L,3506L,3705L,3903L,4072L,4247L,4461L,4688L,4899L,5104L };
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
public class A008016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008016Inst : IEnumerable<long>
{
public static readonly long[] Value=A008016.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008016.Bytes);
public long this[int i]=>Value[i];

public static A008016Inst Instance=new A008016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008015
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,58L,85L,115L,149L,190L,235L,280L,333L,391L,453L,522L,595L,668L,749L,834L,922L,1020L,1123L,1223L,1332L,1446L,1561L,1685L,1814L,1941L,2079L,2221L,2363L,2517L,2675L,2828L,2993L,3163L,3333L,3515L,3701L,3882L,4075L,4271L,4466L,4677L,4893L,5101L };
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
public class A008015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008015Inst : IEnumerable<long>
{
public static readonly long[] Value=A008015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008015.Bytes);
public long this[int i]=>Value[i];

public static A008015Inst Instance=new A008015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008014
{
public static readonly long[] Value={ 1L,4L,11L,21L,35L,53L,77L,105L,137L,172L,212L,256L,305L,357L,413L,473L,539L,609L,683L,760L,842L,928L,1019L,1113L,1211L,1313L,1421L,1533L,1649L,1768L,1892L,2020L,2153L,2289L,2429L,2573L,2723L,2877L,3035L,3196L,3362L,3532L,3707L,3885L,4067L,4253L,4445L,4641L };
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
public class A008014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008014Inst : IEnumerable<long>
{
public static readonly long[] Value=A008014.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A008014.Bytes);
public long this[int i]=>Value[i];

public static A008014Inst Instance=new A008014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007981
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,2L,4L,6L,10L,13L,19L,24L,32L,39L,50L,59L,73L,85L,102L,117L,138L,156L,181L,203L,232L,258L,292L,322L,361L,396L,440L,480L,530L,575L,631L,682L,744L,801L,870L,933L,1009L,1079L,1162L,1239L,1330L,1414L,1513L,1605L,1712L,1812L,1928L,2036L,2161L };
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
public class A007981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007981Inst : IEnumerable<long>
{
public static readonly long[] Value=A007981.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007981.Bytes);
public long this[int i]=>Value[i];

public static A007981Inst Instance=new A007981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007980
{
public static readonly long[] Value={ 1L,2L,4L,7L,10L,14L,19L,24L,30L,37L,44L,52L,61L,70L,80L,91L,102L,114L,127L,140L,154L,169L,184L,200L,217L,234L,252L,271L,290L,310L,331L,352L,374L,397L,420L,444L,469L,494L,520L,547L,574L,602L,631L,660L,690L,721L,752L,784L,817L,850L,884L,919L,954L,990L,1027L,1064L };
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
public class A007980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007980Inst : IEnumerable<long>
{
public static readonly long[] Value=A007980.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007980.Bytes);
public long this[int i]=>Value[i];

public static A007980Inst Instance=new A007980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007979
{
public static readonly long[] Value={ 1L,2L,5L,9L,16L,25L,39L,56L,79L,107L,142L,183L,233L,290L,357L,433L,520L,617L,727L,848L,983L,1131L,1294L,1471L,1665L,1874L,2101L,2345L,2608L,2889L,3191L,3512L,3855L,4219L,4606L,5015L,5449L,5906L };
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
public class A007979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007979Inst : IEnumerable<long>
{
public static readonly long[] Value=A007979.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007979.Bytes);
public long this[int i]=>Value[i];

public static A007979Inst Instance=new A007979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007978
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,4L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L };
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
public class A007978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007978Inst : IEnumerable<long>
{
public static readonly long[] Value=A007978.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007978.Bytes);
public long this[int i]=>Value[i];

public static A007978Inst Instance=new A007978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007977
{
public static readonly long[] Value={ 1L,4L,6L,13L,20L,39L,70L };
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
public class A007977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007977Inst : IEnumerable<long>
{
public static readonly long[] Value=A007977.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007977.Bytes);
public long this[int i]=>Value[i];

public static A007977Inst Instance=new A007977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007976
{
public static readonly long[] Value={ 1L,2L,5L,16L,61L,275L,1430L,8506L,57205L };
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
public class A007976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007976Inst : IEnumerable<long>
{
public static readonly long[] Value=A007976.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007976.Bytes);
public long this[int i]=>Value[i];

public static A007976Inst Instance=new A007976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007975
{
public static readonly long[] Value={ 2L,55L,389L,1563L,4642L };
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
public class A007975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007975Inst : IEnumerable<long>
{
public static readonly long[] Value=A007975.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007975.Bytes);
public long this[int i]=>Value[i];

public static A007975Inst Instance=new A007975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007974
{
public static readonly long[] Value={ 1L,6L,52L,389L,2539L,16604L };
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
public class A007974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007974Inst : IEnumerable<long>
{
public static readonly long[] Value=A007974.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007974.Bytes);
public long this[int i]=>Value[i];

public static A007974Inst Instance=new A007974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007973
{
public static readonly long[] Value={ 1L,3L,15L,55L,184L,648L,2111L };
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
public class A007973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007973Inst : IEnumerable<long>
{
public static readonly long[] Value=A007973.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007973.Bytes);
public long this[int i]=>Value[i];

public static A007973Inst Instance=new A007973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007972
{
public static readonly long[] Value={ 2L,15L,52L,129L,266L,487L,820L,1297L,1954L,2831L,3972L,5425L,7242L,9479L,12196L,15457L,19330L,23887L,29204L,35361L,42442L,50535L,59732L,70129L,81826L,94927L,109540L,125777L,143754L,163591L,185412L,209345L,235522L,264079L,295156L,328897L,365450L,404967L,447604L };
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
public class A007972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007972Inst : IEnumerable<long>
{
public static readonly long[] Value=A007972.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007972.Bytes);
public long this[int i]=>Value[i];

public static A007972Inst Instance=new A007972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007971
{
public static readonly long[] Value={ 0L,1L,2L,2L,4L,8L,18L,42L,102L,254L,646L,1670L,4376L,11596L,31022L,83670L,227268L,621144L,1706934L,4713558L,13072764L,36398568L,101704038L,285095118L,801526446L,2259520830L,6385455594L,18086805002L,51339636952L,146015545604L };
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
public class A007971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007971Inst : IEnumerable<long>
{
public static readonly long[] Value=A007971.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007971.Bytes);
public long this[int i]=>Value[i];

public static A007971Inst Instance=new A007971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007970
{
public static readonly long[] Value={ 3L,7L,8L,11L,15L,19L,23L,24L,27L,31L,32L,35L,40L,43L,47L,48L,51L,59L,63L,67L,71L,75L,79L,80L,83L,87L,88L,91L,96L,99L,103L,104L,107L,115L,119L,120L,123L,127L,128L,131L,135L,136L,139L,143L,151L,152L,159L,160L,163L,167L,168L,171L,175L,176L,179L };
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
public class A007970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007970Inst : IEnumerable<long>
{
public static readonly long[] Value=A007970.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007970.Bytes);
public long this[int i]=>Value[i];

public static A007970Inst Instance=new A007970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007969
{
public static readonly long[] Value={ 2L,5L,6L,10L,12L,13L,14L,17L,18L,20L,21L,22L,26L,28L,29L,30L,33L,34L,37L,38L,39L,41L,42L,44L,45L,46L,50L,52L,53L,54L,55L,56L,57L,58L,60L,61L,62L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,82L,84L,85L,86L,89L,90L,92L,93L,94L,95L,97L,98L,101L,102L,105L,106L,108L,109L };
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
public class A007969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007969Inst : IEnumerable<long>
{
public static readonly long[] Value=A007969.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007969.Bytes);
public long this[int i]=>Value[i];

public static A007969Inst Instance=new A007969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007968
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,1L,1L,2L,2L,0L,1L,2L,1L,1L,1L,2L,0L,1L,1L,2L,1L,1L,1L,2L,2L,0L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,0L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,2L,2L,0L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,0L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,2L,2L,0L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,0L,1L,1L,2L,2L };
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
public class A007968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007968Inst : IEnumerable<long>
{
public static readonly long[] Value=A007968.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007968.Bytes);
public long this[int i]=>Value[i];

public static A007968Inst Instance=new A007968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007967
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,3L,1L,4L,3L,10L,11L,4L,13L,2L,5L,4L,17L,9L,19L,5L,7L,11L,1L,6L,5L,26L,27L,4L,29L,6L,1L,2L,3L,2L,7L,6L,37L,19L,13L,20L,41L,7L,43L,4L,9L,2L,1L,8L,7L,50L,51L,13L,53L,27L,5L,8L,19L,58L,59L,4L,61L,2L,9L,8L,65L,33L,67L,17L,3L,14L,1L,9L,73L,74L,3L,4L,11L,3L,1L,10L,9L,82L,83L };
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
public class A007967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007967Inst : IEnumerable<long>
{
public static readonly long[] Value=A007967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007967.Bytes);
public long this[int i]=>Value[i];

public static A007967Inst Instance=new A007967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007966
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,7L,2L,3L,1L,1L,3L,1L,7L,3L,4L,1L,2L,1L,4L,3L,2L,23L,4L,5L,1L,1L,7L,1L,5L,31L,16L,11L,17L,5L,6L,1L,2L,3L,2L,1L,6L,1L,11L,5L,23L,47L,6L,7L,1L,1L,4L,1L,2L,11L,7L,3L,1L,1L,15L,1L,31L,7L,8L,1L,2L,1L,4L,23L,5L,71L,8L,1L,1L,25L,19L,7L,26L,79L,8L,9L,1L,1L,3L,1L,2L,3L,4L,1L,9L };
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
public class A007966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007966Inst : IEnumerable<long>
{
public static readonly long[] Value=A007966.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007966.Bytes);
public long this[int i]=>Value[i];

public static A007966Inst Instance=new A007966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007965
{
public static readonly BigInteger[] Value={ -1L,-1L,118L,13983L,48667074L,13055867207L,232630103648534L,144115171092292831L,BigInteger.Parse("8862938117851348434466"),BigInteger.Parse("99999999999999579292766699799"),BigInteger.Parse("191943424957750455095669944886980"),BigInteger.Parse("8505622499821102144569548732108989899311") };
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
public class A007965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A007965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A007965Inst Instance=new A007965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007964
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,62L,65L,67L,69L,71L,73L,74L,77L,79L,82L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,101L,103L,106L };
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
public class A007964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007964Inst : IEnumerable<long>
{
public static readonly long[] Value=A007964.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007964.Bytes);
public long this[int i]=>Value[i];

public static A007964Inst Instance=new A007964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007963
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,3L,3L,4L,4L,5L,6L,7L,6L,8L,7L,9L,10L,10L,10L,11L,12L,12L,14L,16L,14L,16L,16L,16L,18L,20L,20L,20L,21L,21L,21L,27L,24L,25L,28L,27L,28L,33L,29L,32L,35L,34L,30L,37L,36L,34L,42L,38L,36L,46L,42L,42L,50L,46L,47L,53L,50L,45L,56L,54L,46L,62L,53L,48L,64L,59L,55L,68L,61L,59L,68L };
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
public class A007963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007963Inst : IEnumerable<long>
{
public static readonly long[] Value=A007963.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007963.Bytes);
public long this[int i]=>Value[i];

public static A007963Inst Instance=new A007963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007962
{
public static readonly long[] Value={ 9L,15L,21L,29L,39L,47L,57L,65L,71L,93L,99L,115L,129L,137L,143L,149L,183L,189L,205L,219L,225L,241L,251L,269L,287L,309L,317L,327L,335L,357L,371L,377L,417L,419L,441L,459L,465L,493L,503L,509L,543L,545L,567L,587L,597L,609L,621L,653L,657L,695L,701L,723L,725L,743L,749L,755L,785L };
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
public class A007962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007962Inst : IEnumerable<long>
{
public static readonly long[] Value=A007962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007962.Bytes);
public long this[int i]=>Value[i];

public static A007962Inst Instance=new A007962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007961
{
public static readonly long[] Value={ 1L,2L,3L,10L,11L,12L,13L,20L,100L,101L,102L,103L,110L,111L,112L,1000L,1001L,1002L,1003L,1010L,1011L,1012L,1013L,1020L,10000L,10001L,10002L,10003L,10010L,10011L,10012L,10013L,10020L,10100L,10101L,100000L,100001L,100002L,100003L,100010L,100011L };
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
public class A007961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007961Inst : IEnumerable<long>
{
public static readonly long[] Value=A007961.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007961.Bytes);
public long this[int i]=>Value[i];

public static A007961Inst Instance=new A007961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007960
{
public static readonly long[] Value={ 1L,3L,6L,10L,12L,15L,19L,21L,28L,30L,36L,45L,51L,54L,55L,60L,63L,66L,78L,82L,87L,91L,100L,102L,105L,109L,117L,120L,123L,132L,135L,136L,147L,150L,153L,156L,163L,165L,168L,171L,174L,186L,190L,201L,208L,210L,213L,231L,235L,253L,258L,267L,276L,280L,285L,300L,306L,307L };
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
public class A007960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007960Inst : IEnumerable<long>
{
public static readonly long[] Value=A007960.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007960.Bytes);
public long this[int i]=>Value[i];

public static A007960Inst Instance=new A007960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007959
{
public static readonly long[] Value={ 10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L };
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
public class A007959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007959Inst : IEnumerable<long>
{
public static readonly long[] Value=A007959.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007959.Bytes);
public long this[int i]=>Value[i];

public static A007959Inst Instance=new A007959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007958
{
public static readonly long[] Value={ 10L,12L,14L,16L,18L,30L,32L,34L,36L,38L,50L,52L,54L,56L,58L,70L,72L,74L,76L,78L,90L,92L,94L,96L,98L,100L,102L,104L,106L,108L,110L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L,140L,142L,144L,146L,148L };
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
public class A007958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007958Inst : IEnumerable<long>
{
public static readonly long[] Value=A007958.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007958.Bytes);
public long this[int i]=>Value[i];

public static A007958Inst Instance=new A007958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007957
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,21L,23L,25L,27L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,41L,43L,45L,47L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,61L,63L,65L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,81L,83L,85L,87L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L };
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
public class A007957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007957Inst : IEnumerable<long>
{
public static readonly long[] Value=A007957.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007957.Bytes);
public long this[int i]=>Value[i];

public static A007957Inst Instance=new A007957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007956
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,6L,1L,8L,3L,10L,1L,144L,1L,14L,15L,64L,1L,324L,1L,400L,21L,22L,1L,13824L,5L,26L,27L,784L,1L,27000L,1L,1024L,33L,34L,35L,279936L,1L,38L,39L,64000L,1L,74088L,1L,1936L,2025L,46L,1L,5308416L,7L,2500L,51L,2704L,1L,157464L,55L,175616L,57L,58L,1L,777600000L,1L,62L,3969L,32768L,65L };
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
public class A007956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007956Inst : IEnumerable<long>
{
public static readonly long[] Value=A007956.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007956.Bytes);
public long this[int i]=>Value[i];

public static A007956Inst Instance=new A007956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007955
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,36L,7L,64L,27L,100L,11L,1728L,13L,196L,225L,1024L,17L,5832L,19L,8000L,441L,484L,23L,331776L,125L,676L,729L,21952L,29L,810000L,31L,32768L,1089L,1156L,1225L,10077696L,37L,1444L,1521L,2560000L,41L,3111696L,43L,85184L,91125L,2116L,47L };
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
public class A007955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007955Inst : IEnumerable<long>
{
public static readonly long[] Value=A007955.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007955.Bytes);
public long this[int i]=>Value[i];

public static A007955Inst Instance=new A007955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007954
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L,12L,15L,18L,21L,24L,27L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,7L,14L,21L,28L,35L,42L,49L,56L,63L,0L,8L,16L,24L,32L,40L,48L,56L,64L,72L,0L,9L,18L,27L,36L,45L,54L,63L,72L,81L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A007954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007954Inst : IEnumerable<long>
{
public static readonly long[] Value=A007954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007954.Bytes);
public long this[int i]=>Value[i];

public static A007954Inst Instance=new A007954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007953
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,8L,9L,10L,11L,12L,13L,14L,15L };
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
public class A007953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007953Inst : IEnumerable<long>
{
public static readonly long[] Value=A007953.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007953.Bytes);
public long this[int i]=>Value[i];

public static A007953Inst Instance=new A007953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007952
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,11L,17L,21L,29L,33L,41L,47L,57L,59L,77L,81L,101L,107L,117L,131L,149L,153L,173L,191L,209L,213L,239L,257L,273L,281L,321L,329L,359L,371L,401L,417L,441L,453L,497L,509L,539L,569L,611L,621L,647L,671L,717L,731L,779L,801L,839L,869L,917L,929L,989L,1001L,1053L,1067L };
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
public class A007952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007952Inst : IEnumerable<long>
{
public static readonly long[] Value=A007952.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007952.Bytes);
public long this[int i]=>Value[i];

public static A007952Inst Instance=new A007952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007951
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,11L,14L,16L,17L,19L,20L,22L,23L,25L,28L,29L,31L,32L,34L,35L,37L,38L,41L,43L,46L,47L,49L,50L,52L,55L,56L,58L,59L,61L,62L,64L,65L,68L,70L,71L,73L,74L,76L,77L,79L,82L,83L,85L,86L,88L,91L,92L,95L,97L,98L,100L,101L,103L,104L,106L,109L,110L,112L,113L,115L,116L,118L };
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
public class A007951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007951Inst : IEnumerable<long>
{
public static readonly long[] Value=A007951.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007951.Bytes);
public long this[int i]=>Value[i];

public static A007951Inst Instance=new A007951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007950
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,13L,17L,21L,25L,27L,29L,33L,35L,37L,43L,49L,51L,53L,57L,59L,65L,67L,69L,73L,75L,77L,81L,85L,89L,91L,97L,101L,107L,109L,113L,115L,117L,121L,123L,129L,131L,133L,137L,139L,145L,149L,153L,155L,157L,161L,163L,165L,171L,173L,177L,179L,181L,185L,187L,195L,197L };
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
public class A007950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007950Inst : IEnumerable<long>
{
public static readonly long[] Value=A007950.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007950.Bytes);
public long this[int i]=>Value[i];

public static A007950Inst Instance=new A007950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007917
{
public static readonly long[] Value={ 2L,3L,3L,5L,5L,7L,7L,7L,7L,11L,11L,13L,13L,13L,13L,17L,17L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,29L,29L,31L,31L,31L,31L,31L,31L,37L,37L,37L,37L,41L,41L,43L,43L,43L,43L,47L,47L,47L,47L,47L,47L,53L,53L,53L,53L,53L,53L,59L,59L,61L,61L,61L,61L,61L,61L,67L,67L,67L,67L,71L,71L,73L,73L,73L,73L };
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
public class A007917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007917Inst : IEnumerable<long>
{
public static readonly long[] Value=A007917.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007917.Bytes);
public long this[int i]=>Value[i];

public static A007917Inst Instance=new A007917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007916
{
public static readonly long[] Value={ 2L,3L,5L,6L,7L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,24L,26L,28L,29L,30L,31L,33L,34L,35L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L };
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
public class A007916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007916Inst : IEnumerable<long>
{
public static readonly long[] Value=A007916.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007916.Bytes);
public long this[int i]=>Value[i];

public static A007916Inst Instance=new A007916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A007915
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,28L,29L,30L,31L,33L };
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
public class A007915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A007915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A007915Inst : IEnumerable<long>
{
public static readonly long[] Value=A007915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A007915.Bytes);
public long this[int i]=>Value[i];

public static A007915Inst Instance=new A007915Inst();

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