using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A008030
{
public static readonly long[] Value={ 1L,4L,9L,16L,23L,34L,57L,82L,98L,115L,141L,178L,224L,259L,282L,322L,377L,430L,486L,535L,578L,643L,717L,781L,851L,919L,984L,1072L,1160L,1231L,1320L,1417L,1502L,1600L,1698L,1789L,1907L,2023L,2115L,2227L,2348L,2461L,2598L,2728L,2831L,2962L,3108L,3241L,3392L };
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
public class A008030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008030Inst : IEnumerable<long>
{
public static readonly long[] Value=A008030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008030.Bytes);
public long this[int i]=>Value[i];

public static A008030Inst Instance=new A008030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008031
{
public static readonly long[] Value={ 1L,4L,10L,22L,39L,60L,87L,118L,154L,196L,242L,292L,345L,406L,471L,540L,616L,694L,780L,868L,959L,1060L,1161L,1270L,1384L,1500L,1626L,1750L,1881L,2020L,2159L,2308L,2458L,2614L,2778L,2940L,3111L,3286L,3465L,3652L,3840L,4036L,4236L,4438L,4647L,4860L,5079L,5302L };
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
public class A008031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008031Inst : IEnumerable<long>
{
public static readonly long[] Value=A008031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008031.Bytes);
public long this[int i]=>Value[i];

public static A008031Inst Instance=new A008031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008032
{
public static readonly long[] Value={ 1L,4L,9L,19L,35L,53L,75L,102L,132L,168L,208L,250L,298L,351L,407L,469L,534L,601L,675L,752L,832L,919L,1009L,1103L,1203L,1305L,1410L,1520L,1634L,1753L,1878L,2007L,2138L,2274L,2414L,2556L,2704L,2856L,3012L,3176L,3343L,3511L,3684L,3860L,4040L,4227L,4417L,4611L };
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
public class A008032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008032Inst : IEnumerable<long>
{
public static readonly long[] Value=A008032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008032.Bytes);
public long this[int i]=>Value[i];

public static A008032Inst Instance=new A008032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008033
{
public static readonly long[] Value={ 1L,4L,10L,20L,35L,54L,76L,104L,136L,171L,211L,254L,302L,355L,411L,471L,536L,606L,679L,756L,837L,922L,1013L,1107L,1204L,1307L,1414L,1525L,1640L,1758L,1881L,2009L,2141L,2276L,2416L,2561L,2709L,2862L,3018L,3178L,3344L,3513L,3686L,3864L,4046L,4232L,4422L,4616L };
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
public class A008033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008033Inst : IEnumerable<long>
{
public static readonly long[] Value=A008033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008033.Bytes);
public long this[int i]=>Value[i];

public static A008033Inst Instance=new A008033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008034
{
public static readonly long[] Value={ 1L,4L,10L,21L,37L,57L,82L,112L,145L,184L,228L,275L,328L,385L,446L,512L,583L,658L,738L,823L,911L,1004L,1102L,1203L,1310L,1424L,1539L,1661L,1788L,1914L,2049L,2188L,2329L,2480L,2633L,2789L,2953L,3117L,3287L,3464L,3642L,3828L,4018L,4210L,4409L,4610L,4817L,5030L };
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
public class A008034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008034Inst : IEnumerable<long>
{
public static readonly long[] Value=A008034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008034.Bytes);
public long this[int i]=>Value[i];

public static A008034Inst Instance=new A008034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008035
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,59L,83L,113L,147L,186L,230L,278L,330L,386L,448L,513L,585L,660L,739L,824L,912L,1006L,1104L,1207L,1313L,1425L,1541L,1661L,1787L,1916L,2051L,2190L,2334L,2482L,2634L,2791L,2952L,3119L,3290L,3465L,3645L,3829L,4018L,4212L,4411L,4613L,4820L,5032L };
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
public class A008035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008035Inst : IEnumerable<long>
{
public static readonly long[] Value=A008035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008035.Bytes);
public long this[int i]=>Value[i];

public static A008035Inst Instance=new A008035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008036
{
public static readonly long[] Value={ 1L,4L,9L,19L,34L,48L,66L,96L,127L,151L,183L,232L,281L,316L,357L,427L,499L,540L,588L,684L,778L,823L,879L,1000L,1118L,1168L,1227L,1375L,1522L,1572L,1632L,1812L,1987L,2035L,2097L,2308L,2513L,2560L,2619L,2863L,3103L,3144L,3198L,3480L,3754L,3787L,3837L,4156L };
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
public class A008036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008036Inst : IEnumerable<long>
{
public static readonly long[] Value=A008036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008036.Bytes);
public long this[int i]=>Value[i];

public static A008036Inst Instance=new A008036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008037
{
public static readonly long[] Value={ 1L,4L,12L,18L,28L,52L,78L,88L,112L,162L,204L,220L,254L,328L,396L,414L,448L,556L,654L,664L,700L,846L,972L,976L,1010L,1192L,1356L,1350L,1372L,1600L,1806L,1780L,1792L,2070L,2316L,2272L,2270L,2596L,2892L,2826L,2800L,3184L,3534L,3436L,3388L,3834L,4236L,4108L,4034L };
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
public class A008037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008037Inst : IEnumerable<long>
{
public static readonly long[] Value=A008037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008037.Bytes);
public long this[int i]=>Value[i];

public static A008037Inst Instance=new A008037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008038
{
public static readonly long[] Value={ 1L,4L,10L,19L,30L,46L,67L,93L,124L,154L,189L,232L,277L,325L,374L,428L,490L,557L,625L,690L,763L,844L,930L,1021L,1105L,1194L,1294L,1399L,1510L,1616L,1724L,1840L,1964L,2095L,2220L,2350L,2485L,2625L,2776L,2920L,3069L,3226L,3385L,3553L,3716L,3884L,4060L,4241L };
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
public class A008038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008038Inst : IEnumerable<long>
{
public static readonly long[] Value=A008038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008038.Bytes);
public long this[int i]=>Value[i];

public static A008038Inst Instance=new A008038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008039
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,49L,73L,97L,124L,157L,193L,236L,281L,325L,376L,434L,496L,559L,623L,692L,769L,853L,934L,1015L,1105L,1201L,1304L,1406L,1504L,1612L,1730L,1852L,1972L,2090L,2216L,2353L,2497L,2635L,2770L,2917L,3073L,3236L,3395L,3547L,3712L,3890L,4072L,4249L };
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
public class A008039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008039Inst : IEnumerable<long>
{
public static readonly long[] Value=A008039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008039.Bytes);
public long this[int i]=>Value[i];

public static A008039Inst Instance=new A008039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008040
{
public static readonly long[] Value={ 1L,4L,10L,19L,32L,51L,72L,96L,124L,155L,196L,238L,278L,324L,374L,436L,500L,558L,620L,688L,772L,857L,934L,1014L,1098L,1203L,1310L,1405L,1504L,1606L,1730L,1858L,1972L,2089L,2210L,2355L,2502L,2634L,2770L,2909L,3076L,3244L,3392L,3546L,3704L,3892L,4082L,4248L };
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
public class A008040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008040Inst : IEnumerable<long>
{
public static readonly long[] Value=A008040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008040.Bytes);
public long this[int i]=>Value[i];

public static A008040Inst Instance=new A008040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008041
{
public static readonly long[] Value={ 1L,4L,9L,18L,33L,52L,73L,96L,123L,158L,199L,239L,280L,329L,383L,438L,498L,564L,633L,704L,778L,857L,941L,1029L,1122L,1219L,1316L,1415L,1522L,1636L,1753L,1871L,1990L,2115L,2248L,2383L,2519L,2661L,2808L,2957L,3110L,3268L,3429L,3593L,3762L,3937L,4115L,4293L };
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
public class A008041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008041Inst : IEnumerable<long>
{
public static readonly long[] Value=A008041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008041.Bytes);
public long this[int i]=>Value[i];

public static A008041Inst Instance=new A008041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008042
{
public static readonly long[] Value={ 1L,4L,10L,21L,34L,48L,70L,100L,130L,159L,194L,236L,282L,332L,384L,439L,500L,564L,630L,702L,780L,861L,944L,1030L,1120L,1214L,1314L,1421L,1530L,1636L,1746L,1868L,1994L,2119L,2248L,2382L,2520L,2662L,2808L,2957L,3110L,3268L,3430L,3596L,3764L,3935L,4112L,4294L };
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
public class A008042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008042Inst : IEnumerable<long>
{
public static readonly long[] Value=A008042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008042.Bytes);
public long this[int i]=>Value[i];

public static A008042Inst Instance=new A008042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008043
{
public static readonly long[] Value={ 1L,4L,11L,22L,40L,64L,92L,121L,157L,200L,248L,297L,351L,414L,484L,555L,630L,709L,795L,885L,980L,1081L,1187L,1297L,1414L,1535L,1660L,1786L,1919L,2061L,2208L,2356L,2509L,2669L,2836L,3004L,3176L,3354L,3539L,3728L,3922L,4120L,4323L,4530L,4744L,4964L,5188L,5413L };
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
public class A008043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008043Inst : IEnumerable<long>
{
public static readonly long[] Value=A008043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008043.Bytes);
public long this[int i]=>Value[i];

public static A008043Inst Instance=new A008043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008044
{
public static readonly long[] Value={ 1L,4L,12L,25L,42L,61L,88L,122L,160L,200L,246L,299L,358L,417L,480L,550L,628L,710L,796L,887L,984L,1083L,1188L,1298L,1412L,1530L,1656L,1789L,1926L,2063L,2206L,2356L,2512L,2670L,2832L,3001L,3178L,3357L,3540L,3728L,3922L,4120L,4324L,4533L,4746L,4961L,5184L,5414L };
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
public class A008044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008044Inst : IEnumerable<long>
{
public static readonly long[] Value=A008044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008044.Bytes);
public long this[int i]=>Value[i];

public static A008044Inst Instance=new A008044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008045
{
public static readonly long[] Value={ 1L,4L,10L,20L,33L,50L,72L,98L,128L,162L,200L,241L,285L,333L,386L,444L,506L,572L,641L,713L,789L,869L,953L,1042L,1136L,1233L,1333L,1437L,1545L,1657L,1773L,1893L,2017L,2145L,2277L,2413L,2553L,2697L,2845L,2996L,3150L,3309L,3473L,3641L,3813L,3989L,4168L,4350L };
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
public class A008045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008045Inst : IEnumerable<long>
{
public static readonly long[] Value=A008045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008045.Bytes);
public long this[int i]=>Value[i];

public static A008045Inst Instance=new A008045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008094
{
public static readonly long[] Value={ 1L,4L,10L,20L,32L,46L,64L,90L,126L,164L,196L,222L,258L,316L,384L,444L,488L,532L,594L,676L,768L,850L,920L,990L,1074L,1176L,1282L,1386L,1486L,1586L,1692L,1804L,1928L,2060L,2192L,2318L,2440L,2574L,2722L,2876L,3026L,3170L,3320L,3482L,3656L,3830L,3994L,4158L,4336L };
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
public class A008094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008094Inst : IEnumerable<long>
{
public static readonly long[] Value=A008094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008094.Bytes);
public long this[int i]=>Value[i];

public static A008094Inst Instance=new A008094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008095
{
public static readonly long[] Value={ 1L,4L,11L,21L,36L,59L,92L,129L,167L,197L,246L,306L,367L,433L,491L,565L,660L,761L,839L,918L,1023L,1151L,1269L,1377L,1476L,1605L,1780L,1912L,2017L,2171L,2339L,2524L,2677L,2812L,2979L,3177L,3405L,3587L,3753L,3937L,4158L,4424L,4636L,4832L,5020L,5244L,5561L,5824L };
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
public class A008095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008095Inst : IEnumerable<long>
{
public static readonly long[] Value=A008095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008095.Bytes);
public long this[int i]=>Value[i];

public static A008095Inst Instance=new A008095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008096
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,68L,92L,118L,156L,213L,268L,307L,347L,432L,522L,586L,651L,723L,840L,969L,1045L,1118L,1251L,1400L,1526L,1614L,1741L,1880L,2063L,2210L,2338L,2496L,2646L,2849L,3038L,3187L,3355L,3554L,3772L,4014L,4223L,4359L,4530L,4845L,5135L,5300L,5501L,5696L };
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
public class A008096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008096Inst : IEnumerable<long>
{
public static readonly long[] Value=A008096.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008096.Bytes);
public long this[int i]=>Value[i];

public static A008096Inst Instance=new A008096Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008097
{
public static readonly long[] Value={ 1L,4L,12L,25L,41L,64L,88L,122L,160L,202L,256L,310L,369L,437L,511L,576L,649L,748L,834L,940L,1040L,1128L,1255L,1381L,1516L,1623L,1748L,1905L,2041L,2201L,2343L,2484L,2659L,2837L,3021L,3194L,3362L,3562L,3776L,3979L,4174L,4368L,4582L,4818L,5074L,5280L,5477L,5767L };
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
public class A008097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008097Inst : IEnumerable<long>
{
public static readonly long[] Value=A008097.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008097.Bytes);
public long this[int i]=>Value[i];

public static A008097Inst Instance=new A008097Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008098
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,60L,89L,124L,159L,194L,248L,317L,373L,435L,493L,570L,663L,755L,824L,913L,1037L,1157L,1255L,1366L,1483L,1622L,1788L,1905L,2024L,2163L,2320L,2519L,2677L,2819L,2987L,3181L,3402L,3592L,3752L,3921L,4143L,4424L,4625L,4799L,5003L,5262L,5562L,5804L };
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
public class A008098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008098Inst : IEnumerable<long>
{
public static readonly long[] Value=A008098.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008098.Bytes);
public long this[int i]=>Value[i];

public static A008098Inst Instance=new A008098Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008099
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,59L,91L,124L,160L,206L,257L,309L,358L,422L,513L,580L,654L,739L,837L,942L,1045L,1138L,1242L,1382L,1511L,1622L,1741L,1900L,2041L,2192L,2341L,2487L,2669L,2841L,3021L,3194L,3352L,3559L,3779L,3983L,4183L,4369L,4592L,4820L,5084L,5306L,5473L,5773L };
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
public class A008099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008099Inst : IEnumerable<long>
{
public static readonly long[] Value=A008099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008099.Bytes);
public long this[int i]=>Value[i];

public static A008099Inst Instance=new A008099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008100
{
public static readonly long[] Value={ 1L,4L,12L,20L,31L,61L,88L,120L,159L,197L,248L,299L,368L,427L,482L,589L,642L,725L,840L,939L,1005L,1126L,1271L,1367L,1465L,1624L,1732L,1876L,2067L,2148L,2297L,2502L,2674L,2838L,2972L,3157L,3374L,3561L,3764L,3936L,4143L,4362L,4624L,4826L,4962L,5286L,5508L,5733L };
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
public class A008100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008100Inst : IEnumerable<long>
{
public static readonly long[] Value=A008100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008100.Bytes);
public long this[int i]=>Value[i];

public static A008100Inst Instance=new A008100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008101
{
public static readonly long[] Value={ 1L,4L,12L,20L,34L,57L,92L,131L,164L,202L,236L,298L,379L,436L,485L,555L,653L,757L,846L,919L,997L,1133L,1289L,1373L,1461L,1594L,1756L,1933L,2034L,2142L,2314L,2521L,2685L,2814L,2965L,3144L,3379L,3613L,3756L,3918L,4118L,4376L,4665L,4869L,4992L,5196L,5524L,5840L };
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
public class A008101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008101Inst : IEnumerable<long>
{
public static readonly long[] Value=A008101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008101.Bytes);
public long this[int i]=>Value[i];

public static A008101Inst Instance=new A008101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008102
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,60L,91L,126L,161L,195L,243L,309L,387L,441L,481L,585L,660L,741L,832L,921L,1029L,1154L,1271L,1344L,1481L,1628L,1780L,1908L,2035L,2154L,2325L,2535L,2680L,2817L,2973L,3164L,3424L,3604L,3732L,3913L,4166L,4421L,4613L,4803L,4960L,5281L,5574L,5765L };
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
public class A008102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008102Inst : IEnumerable<long>
{
public static readonly long[] Value=A008102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008102.Bytes);
public long this[int i]=>Value[i];

public static A008102Inst Instance=new A008102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008103
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,56L,90L,127L,157L,197L,236L,306L,395L,431L,482L,559L,670L,741L,833L,911L,1006L,1163L,1277L,1349L,1453L,1620L,1772L,1912L,2035L,2158L,2293L,2496L,2703L,2829L,2955L,3155L,3379L,3621L,3761L,3898L,4105L,4367L,4688L,4813L,4960L,5220L,5565L,5798L };
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
public class A008103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008103Inst : IEnumerable<long>
{
public static readonly long[] Value=A008103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008103.Bytes);
public long this[int i]=>Value[i];

public static A008103Inst Instance=new A008103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008104
{
public static readonly long[] Value={ 1L,4L,11L,23L,45L,67L,88L,115L,162L,218L,261L,303L,356L,434L,522L,589L,646L,716L,859L,966L,1021L,1123L,1255L,1410L,1510L,1628L,1733L,1871L,2083L,2231L,2328L,2477L,2648L,2844L,3047L,3197L,3334L,3528L,3790L,4035L,4190L,4326L,4553L,4860L,5103L,5287L,5485L,5704L };
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
public class A008104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008104Inst : IEnumerable<long>
{
public static readonly long[] Value=A008104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008104.Bytes);
public long this[int i]=>Value[i];

public static A008104Inst Instance=new A008104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008105
{
public static readonly long[] Value={ 1L,4L,9L,16L,25L,37L,53L,73L,96L,120L,145L,173L,206L,244L,285L,327L,369L,413L,462L,517L,576L,636L,696L,757L,822L,893L,969L,1047L,1125L,1204L,1286L,1373L,1465L,1560L,1656L,1753L,1853L,1957L,2065L,2176L,2289L,2404L,2522L,2644L,2769L,2896L,3025L,3157L,3293L };
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
public class A008105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008105Inst : IEnumerable<long>
{
public static readonly long[] Value=A008105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008105.Bytes);
public long this[int i]=>Value[i];

public static A008105Inst Instance=new A008105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008106
{
public static readonly long[] Value={ 1L,4L,12L,21L,39L,66L,95L,126L,169L,221L,265L,311L,380L,459L,524L,587L,675L,783L,870L,943L,1058L,1176L,1296L,1401L,1525L,1681L,1788L,1929L,2094L,2246L,2403L,2517L,2733L,2933L,3063L,3245L,3423L,3687L,3865L,3995L,4269L,4469L,4716L,4914L,5122L,5444L,5594L,5871L };
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
public class A008106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008106Inst : IEnumerable<long>
{
public static readonly long[] Value=A008106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008106.Bytes);
public long this[int i]=>Value[i];

public static A008106Inst Instance=new A008106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008107
{
public static readonly long[] Value={ 1L,4L,12L,27L,43L,62L,97L,139L,172L,206L,264L,336L,387L,439L,519L,609L,690L,758L,855L,971L,1065L,1172L,1292L,1418L,1529L,1640L,1813L,1964L,2080L,2214L,2387L,2601L,2730L,2862L,3076L,3280L,3474L,3616L,3826L,4077L,4251L,4476L,4695L,4936L,5157L,5343L,5666L,5913L };
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
public class A008107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008107Inst : IEnumerable<long>
{
public static readonly long[] Value=A008107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008107.Bytes);
public long this[int i]=>Value[i];

public static A008107Inst Instance=new A008107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008108
{
public static readonly long[] Value={ 1L,4L,12L,20L,35L,67L,104L,121L,157L,223L,276L,308L,365L,460L,539L,582L,664L,783L,873L,951L,1036L,1197L,1291L,1382L,1530L,1686L,1814L,1898L,2059L,2305L,2388L,2523L,2687L,2943L,3124L,3190L,3429L,3686L,3855L,4050L,4176L,4545L,4701L,4865L,5172L,5401L,5675L };
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
public class A008108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008108Inst : IEnumerable<long>
{
public static readonly long[] Value=A008108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008108.Bytes);
public long this[int i]=>Value[i];

public static A008108Inst Instance=new A008108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008109
{
public static readonly long[] Value={ 1L,4L,12L,23L,40L,66L,96L,131L,164L,214L,272L,317L,384L,450L,516L,611L,670L,766L,860L,955L,1078L,1172L,1282L,1409L,1520L,1676L,1800L,1933L,2082L,2236L,2406L,2563L,2704L,2896L,3078L,3281L,3450L,3630L,3824L,4051L,4282L,4470L,4690L,4909L,5140L,5444L,5606L,5875L };
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
public class A008109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008109Inst : IEnumerable<long>
{
public static readonly long[] Value=A008109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008109.Bytes);
public long this[int i]=>Value[i];

public static A008109Inst Instance=new A008109Inst();

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

public static class A008158
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,67L,95L,133L,177L,219L,277L,338L,397L,471L,570L,640L,725L,823L,903L,1023L,1156L,1238L,1357L,1506L,1653L,1771L,1913L,2086L,2223L,2394L,2584L,2717L,2917L,3135L,3270L,3469L,3725L,3886L,4101L,4362L,4561L,4790L,5044L,5280L,5517L,5773L,6062L };
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
public class A008158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008158Inst : IEnumerable<long>
{
public static readonly long[] Value=A008158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008158.Bytes);
public long this[int i]=>Value[i];

public static A008158Inst Instance=new A008158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008159
{
public static readonly long[] Value={ 1L,4L,12L,26L,44L,64L,98L,144L,172L,222L,272L,340L,438L,476L,528L,642L,744L,840L,922L,1012L,1144L,1282L,1380L,1484L,1642L,1796L,1944L,2070L,2228L,2444L,2554L,2760L,2928L,3066L,3360L,3500L,3682L,3936L,4112L,4362L,4564L,4824L,5046L,5276L,5576L,5778L,6056L };
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
public class A008159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008159Inst : IEnumerable<long>
{
public static readonly long[] Value=A008159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008159.Bytes);
public long this[int i]=>Value[i];

public static A008159Inst Instance=new A008159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008160
{
public static readonly long[] Value={ 1L,4L,9L,18L,32L,49L,69L,93L,121L,153L,189L,228L,270L,317L,368L,422L,480L,541L,606L,676L,749L,825L,905L,989L,1077L,1169L,1264L,1362L,1465L,1572L,1682L,1796L,1913L,2034L,2160L,2289L,2421L,2557L,2697L,2841L,2989L,3140L,3294L,3453L,3616L,3782L,3952L,4125L,4302L };
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
public class A008160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008160Inst : IEnumerable<long>
{
public static readonly long[] Value=A008160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008160.Bytes);
public long this[int i]=>Value[i];

public static A008160Inst Instance=new A008160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008161
{
public static readonly long[] Value={ 1L,4L,12L,22L,41L,61L,88L,125L,159L,198L,250L,297L,363L,415L,486L,558L,626L,729L,800L,885L,1002L,1082L,1213L,1308L,1414L,1557L,1662L,1833L,1931L,2070L,2250L,2363L,2557L,2686L,2855L,3051L,3187L,3418L,3560L,3759L,3986L,4130L,4402L,4561L,4797L,5036L,5208L,5503L };
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
public class A008161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008161Inst : IEnumerable<long>
{
public static readonly long[] Value=A008161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008161.Bytes);
public long this[int i]=>Value[i];

public static A008161Inst Instance=new A008161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008162
{
public static readonly long[] Value={ 1L,4L,11L,22L,36L,61L,93L,120L,154L,200L,255L,305L,353L,417L,480L,554L,640L,715L,807L,893L,986L,1103L,1201L,1310L,1414L,1536L,1694L,1814L,1945L,2069L,2214L,2407L,2551L,2689L,2836L,3020L,3245L,3409L,3559L,3734L,3961L,4214L,4389L,4551L,4761L,5023L,5279L,5468L };
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
public class A008162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008162Inst : IEnumerable<long>
{
public static readonly long[] Value=A008162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008162.Bytes);
public long this[int i]=>Value[i];

public static A008162Inst Instance=new A008162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008163
{
public static readonly long[] Value={ 1L,4L,12L,22L,38L,59L,92L,125L,159L,202L,250L,299L,364L,413L,480L,562L,633L,724L,800L,888L,993L,1100L,1215L,1305L,1403L,1549L,1681L,1828L,1940L,2066L,2224L,2393L,2568L,2684L,2834L,3025L,3223L,3427L,3571L,3740L,3958L,4178L,4414L,4560L,4773L,5009L,5243L,5507L };
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
public class A008163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008163Inst : IEnumerable<long>
{
public static readonly long[] Value=A008163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008163.Bytes);
public long this[int i]=>Value[i];

public static A008163Inst Instance=new A008163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008164
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,59L,89L,126L,161L,196L,246L,306L,363L,419L,474L,545L,643L,733L,805L,874L,979L,1116L,1214L,1301L,1404L,1542L,1706L,1814L,1926L,2061L,2235L,2409L,2533L,2691L,2847L,3035L,3230L,3383L,3583L,3760L,3957L,4178L,4366L,4595L,4776L,4995L,5265L,5476L };
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
public class A008164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008164Inst : IEnumerable<long>
{
public static readonly long[] Value=A008164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008164.Bytes);
public long this[int i]=>Value[i];

public static A008164Inst Instance=new A008164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008165
{
public static readonly long[] Value={ 1L,4L,12L,22L,39L,64L,91L,117L,158L,209L,247L,294L,353L,429L,493L,551L,635L,708L,812L,903L,975L,1098L,1190L,1316L,1437L,1545L,1684L,1788L,1947L,2100L,2223L,2385L,2508L,2713L,2894L,3015L,3218L,3355L,3609L,3784L,3936L,4180L,4321L,4620L,4817L,4994L,5257L,5425L };
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
public class A008165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008165Inst : IEnumerable<long>
{
public static readonly long[] Value=A008165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008165.Bytes);
public long this[int i]=>Value[i];

public static A008165Inst Instance=new A008165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008166
{
public static readonly long[] Value={ 1L,4L,12L,23L,37L,62L,91L,120L,157L,206L,250L,294L,356L,421L,488L,555L,627L,725L,806L,894L,985L,1081L,1208L,1306L,1430L,1558L,1669L,1802L,1934L,2087L,2242L,2359L,2532L,2698L,2884L,3050L,3168L,3399L,3571L,3790L,3966L,4120L,4387L,4571L,4824L,5014L,5197L,5503L };
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
public class A008166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008166Inst : IEnumerable<long>
{
public static readonly long[] Value=A008166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008166.Bytes);
public long this[int i]=>Value[i];

public static A008166Inst Instance=new A008166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008167
{
public static readonly long[] Value={ 1L,4L,12L,21L,36L,61L,90L,122L,159L,196L,251L,305L,360L,413L,469L,561L,643L,720L,803L,875L,992L,1111L,1202L,1294L,1405L,1550L,1700L,1823L,1920L,2061L,2223L,2400L,2563L,2673L,2847L,3021L,3219L,3428L,3560L,3743L,3947L,4163L,4427L,4571L,4763L,4987L,5231L,5536L };
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
public class A008167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008167Inst : IEnumerable<long>
{
public static readonly long[] Value=A008167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008167.Bytes);
public long this[int i]=>Value[i];

public static A008167Inst Instance=new A008167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008168
{
public static readonly long[] Value={ 1L,4L,12L,24L,38L,63L,93L,123L,157L,206L,247L,304L,351L,420L,493L,556L,638L,711L,806L,902L,982L,1103L,1200L,1307L,1431L,1540L,1693L,1792L,1952L,2088L,2214L,2402L,2519L,2713L,2870L,3015L,3226L,3372L,3605L,3778L,3925L,4190L,4353L,4612L,4794L,4989L,5267L,5444L };
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
public class A008168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008168Inst : IEnumerable<long>
{
public static readonly long[] Value=A008168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008168.Bytes);
public long this[int i]=>Value[i];

public static A008168Inst Instance=new A008168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008169
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,61L,88L,124L,156L,197L,253L,296L,353L,420L,493L,562L,621L,718L,808L,891L,999L,1076L,1195L,1317L,1432L,1561L,1649L,1814L,1936L,2090L,2244L,2344L,2542L,2699L,2878L,3047L,3173L,3399L,3571L,3775L,3989L,4116L,4375L,4577L,4810L,5043L,5202L,5478L };
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
public class A008169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008169Inst : IEnumerable<long>
{
public static readonly long[] Value=A008169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008169.Bytes);
public long this[int i]=>Value[i];

public static A008169Inst Instance=new A008169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008170
{
public static readonly long[] Value={ 1L,4L,12L,24L,38L,56L,90L,132L,164L,193L,241L,312L,372L,414L,466L,552L,657L,730L,788L,875L,996L,1116L,1208L,1299L,1407L,1542L,1695L,1821L,1940L,2062L,2225L,2410L,2552L,2689L,2827L,3020L,3249L,3412L,3571L,3737L,3955L,4200L,4387L,4587L,4761L,4987L,5265L,5498L };
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
public class A008170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008170Inst : IEnumerable<long>
{
public static readonly long[] Value=A008170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008170.Bytes);
public long this[int i]=>Value[i];

public static A008170Inst Instance=new A008170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008171
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,63L,90L,121L,155L,201L,253L,301L,359L,413L,482L,566L,632L,710L,805L,898L,997L,1081L,1196L,1314L,1427L,1551L,1668L,1812L,1955L,2076L,2216L,2380L,2561L,2702L,2843L,3021L,3207L,3425L,3578L,3746L,3951L,4170L,4403L,4568L,4776L,5015L,5240L,5499L };
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
public class A008171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008171Inst : IEnumerable<long>
{
public static readonly long[] Value=A008171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008171.Bytes);
public long this[int i]=>Value[i];

public static A008171Inst Instance=new A008171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008172
{
public static readonly long[] Value={ 1L,4L,11L,23L,39L,62L,93L,119L,153L,204L,254L,301L,350L,418L,497L,559L,624L,705L,816L,919L,986L,1067L,1187L,1332L,1450L,1538L,1653L,1803L,1968L,2100L,2208L,2366L,2538L,2715L,2875L,3019L,3213L,3385L,3574L,3772L,3967L,4189L,4354L,4551L,4802L,5052L,5266L,5429L };
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
public class A008172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008172Inst : IEnumerable<long>
{
public static readonly long[] Value=A008172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008172.Bytes);
public long this[int i]=>Value[i];

public static A008172Inst Instance=new A008172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

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

public static class A008174
{
public static readonly long[] Value={ 1L,4L,11L,20L,39L,66L,92L,124L,163L,215L,257L,304L,373L,447L,514L,571L,657L,763L,852L,924L,1031L,1150L,1262L,1364L,1493L,1642L,1748L,1882L,2044L,2196L,2341L,2458L,2668L,2863L,2999L,3164L,3344L,3594L,3770L,3910L,4162L,4372L,4601L,4792L,5006L,5306L,5471L,5726L };
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
public class A008174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008174Inst : IEnumerable<long>
{
public static readonly long[] Value=A008174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008174.Bytes);
public long this[int i]=>Value[i];

public static A008174Inst Instance=new A008174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008175
{
public static readonly long[] Value={ 1L,4L,12L,24L,42L,64L,90L,131L,168L,206L,259L,313L,383L,441L,506L,583L,656L,766L,841L,933L,1034L,1139L,1279L,1376L,1496L,1617L,1744L,1911L,2041L,2179L,2329L,2494L,2686L,2837L,2988L,3178L,3352L,3588L,3768L,3926L,4152L,4344L,4630L,4822L,5010L,5262L,5458L,5795L };
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
public class A008175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008175Inst : IEnumerable<long>
{
public static readonly long[] Value=A008175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008175.Bytes);
public long this[int i]=>Value[i];

public static A008175Inst Instance=new A008175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008176
{
public static readonly long[] Value={ 1L,4L,12L,26L,40L,60L,94L,136L,168L,200L,259L,332L,379L,421L,506L,598L,678L,745L,829L,952L,1040L,1148L,1263L,1369L,1502L,1604L,1780L,1919L,2011L,2174L,2331L,2558L,2662L,2762L,3020L,3202L,3414L,3526L,3708L,4004L,4146L,4398L,4568L,4776L,5064L,5220L,5568L,5754L };
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
public class A008176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008176Inst : IEnumerable<long>
{
public static readonly long[] Value=A008176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008176.Bytes);
public long this[int i]=>Value[i];

public static A008176Inst Instance=new A008176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008177
{
public static readonly long[] Value={ 1L,4L,12L,19L,35L,64L,96L,123L,155L,207L,272L,311L,367L,439L,501L,580L,666L,747L,853L,924L,1048L,1172L,1225L,1352L,1482L,1650L,1812L,1829L,2021L,2212L,2346L,2527L,2599L,2817L,3034L,3167L,3419L,3527L,3701L,3970L,4180L,4437L,4547L,4684L,5052L,5350L,5551L,5664L };
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
public class A008177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008177Inst : IEnumerable<long>
{
public static readonly long[] Value=A008177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008177.Bytes);
public long this[int i]=>Value[i];

public static A008177Inst Instance=new A008177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008178
{
public static readonly long[] Value={ 1L,4L,10L,22L,36L,64L,98L,124L,158L,213L,260L,306L,368L,453L,508L,571L,664L,753L,856L,929L,1018L,1168L,1246L,1373L,1490L,1616L,1800L,1856L,2030L,2218L,2310L,2510L,2620L,2865L,3042L,3104L,3400L,3563L,3758L,3963L,4084L,4433L,4590L,4769L,5044L,5232L,5556L,5705L };
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
public class A008178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008178Inst : IEnumerable<long>
{
public static readonly long[] Value=A008178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008178.Bytes);
public long this[int i]=>Value[i];

public static A008178Inst Instance=new A008178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008179
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,62L,92L,138L,160L,196L,262L,332L,386L,420L,486L,606L,680L,744L,818L,936L,1084L,1136L,1250L,1362L,1460L,1662L,1782L,1910L,1998L,2132L,2400L,2534L,2656L,2756L,2960L,3302L,3408L,3504L,3662L,3942L,4300L,4372L,4534L,4750L,4980L,5382L,5536L,5738L };
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
public class A008179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008179Inst : IEnumerable<long>
{
public static readonly long[] Value=A008179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008179.Bytes);
public long this[int i]=>Value[i];

public static A008179Inst Instance=new A008179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008180
{
public static readonly long[] Value={ 1L,4L,12L,24L,38L,66L,100L,118L,162L,220L,262L,300L,376L,456L,516L,566L,648L,774L,848L,936L,1024L,1126L,1300L,1366L,1500L,1628L,1726L,1916L,2016L,2218L,2348L,2428L,2694L,2874L,3020L,3120L,3322L,3624L,3804L,3924L,4088L,4372L,4624L,4852L,5016L,5214L,5506L };
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
public class A008180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008180Inst : IEnumerable<long>
{
public static readonly long[] Value=A008180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008180.Bytes);
public long this[int i]=>Value[i];

public static A008180Inst Instance=new A008180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008181
{
public static readonly long[] Value={ 1L,4L,11L,23L,44L,67L,95L,134L,168L,215L,271L,320L,380L,454L,520L,599L,682L,764L,866L,965L,1052L,1175L,1297L,1399L,1529L,1667L,1792L,1943L,2084L,2225L,2405L,2560L,2700L,2903L,3087L,3242L,3446L,3644L,3828L,4055L,4250L,4450L,4712L,4919L,5112L,5399L,5641L,5849L };
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
public class A008181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008181Inst : IEnumerable<long>
{
public static readonly long[] Value=A008181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008181.Bytes);
public long this[int i]=>Value[i];

public static A008181Inst Instance=new A008181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008182
{
public static readonly long[] Value={ 1L,4L,12L,22L,38L,60L,88L,115L,155L,204L,242L,286L,347L,416L,475L,531L,618L,703L,773L,862L,969L,1077L,1166L,1256L,1383L,1515L,1632L,1753L,1886L,2037L,2165L,2287L,2461L,2640L,2794L,2930L,3112L,3323L,3480L,3638L,3853L,4061L,4242L,4428L,4655L,4902L,5094L,5296L };
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
public class A008182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008182Inst : IEnumerable<long>
{
public static readonly long[] Value=A008182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008182.Bytes);
public long this[int i]=>Value[i];

public static A008182Inst Instance=new A008182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008183
{
public static readonly long[] Value={ 1L,4L,12L,20L,37L,64L,87L,114L,154L,198L,241L,289L,342L,410L,471L,537L,613L,707L,778L,855L,957L,1071L,1169L,1264L,1377L,1516L,1624L,1727L,1887L,2045L,2166L,2294L,2459L,2630L,2783L,2929L,3113L,3303L,3474L,3638L,3840L,4067L,4249L,4431L,4644L,4884L,5089L,5298L };
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
public class A008183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008183Inst : IEnumerable<long>
{
public static readonly long[] Value=A008183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008183.Bytes);
public long this[int i]=>Value[i];

public static A008183Inst Instance=new A008183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008184
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,54L,86L,126L,156L,195L,242L,289L,342L,407L,486L,557L,605L,672L,776L,883L,978L,1061L,1162L,1271L,1369L,1494L,1648L,1797L,1892L,1979L,2139L,2324L,2478L,2626L,2797L,2962L,3100L,3256L,3484L,3708L,3863L,4023L,4221L,4450L,4664L,4867L,5105L,5338L };
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
public class A008184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008184Inst : IEnumerable<long>
{
public static readonly long[] Value=A008184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008184.Bytes);
public long this[int i]=>Value[i];

public static A008184Inst Instance=new A008184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008185
{
public static readonly long[] Value={ 1L,4L,11L,24L,39L,60L,92L,122L,148L,195L,250L,293L,342L,403L,472L,551L,621L,690L,786L,879L,954L,1047L,1168L,1293L,1397L,1484L,1622L,1773L,1880L,2007L,2181L,2336L,2456L,2606L,2783L,2966L,3122L,3278L,3468L,3672L,3855L,4037L,4253L,4466L,4664L,4853L,5081L,5338L };
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
public class A008185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008185Inst : IEnumerable<long>
{
public static readonly long[] Value=A008185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008185.Bytes);
public long this[int i]=>Value[i];

public static A008185Inst Instance=new A008185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008186
{
public static readonly long[] Value={ 1L,4L,12L,25L,43L,68L,95L,133L,177L,223L,274L,334L,398L,471L,546L,627L,709L,797L,899L,1002L,1105L,1226L,1344L,1469L,1601L,1736L,1874L,2021L,2181L,2338L,2490L,2668L,2849L,3028L,3212L,3401L,3591L,3804L,4022L,4228L,4439L,4663L,4904L,5145L,5378L,5631L,5866L };
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
public class A008186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008186Inst : IEnumerable<long>
{
public static readonly long[] Value=A008186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008186.Bytes);
public long this[int i]=>Value[i];

public static A008186Inst Instance=new A008186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008187
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,66L,103L,130L,168L,216L,274L,334L,405L,459L,528L,631L,719L,784L,891L,999L,1098L,1228L,1357L,1449L,1566L,1741L,1909L,1998L,2157L,2334L,2467L,2699L,2869L,2961L,3186L,3417L,3643L,3781L,3954L,4233L,4411L,4702L,4950L,5040L,5352L,5653L,5921L };
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
public class A008187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008187Inst : IEnumerable<long>
{
public static readonly long[] Value=A008187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008187.Bytes);
public long this[int i]=>Value[i];

public static A008187Inst Instance=new A008187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008188
{
public static readonly long[] Value={ 1L,4L,12L,24L,36L,64L,112L,132L,156L,222L,264L,340L,424L,456L,492L,640L,740L,778L,876L,1020L,1084L,1216L,1440L,1416L,1464L,1818L,1924L,1972L,2172L,2316L,2464L,2696L,2956L,2946L,3024L,3544L,3664L,3708L,4044L,4140L,4380L,4786L,5008L,5052L,5148L,5752L,6032L };
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
public class A008188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008188Inst : IEnumerable<long>
{
public static readonly long[] Value=A008188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008188.Bytes);
public long this[int i]=>Value[i];

public static A008188Inst Instance=new A008188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008189
{
public static readonly long[] Value={ 1L,4L,12L,23L,43L,66L,92L,130L,170L,213L,261L,316L,387L,442L,514L,607L,675L,755L,857L,948L,1064L,1171L,1281L,1386L,1502L,1691L,1807L,1907L,2050L,2225L,2414L,2525L,2701L,2879L,3034L,3280L,3470L,3586L,3770L,4031L,4315L,4442L,4592L,4894L,5127L,5409L,5638L,5806L };
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
public class A008189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008189Inst : IEnumerable<long>
{
public static readonly long[] Value=A008189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008189.Bytes);
public long this[int i]=>Value[i];

public static A008189Inst Instance=new A008189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008190
{
public static readonly long[] Value={ 1L,4L,12L,24L,40L,64L,96L,136L,167L,207L,258L,331L,389L,444L,500L,598L,689L,786L,843L,929L,1065L,1199L,1288L,1369L,1492L,1673L,1849L,1923L,2025L,2205L,2424L,2595L,2691L,2811L,3056L,3340L,3429L,3592L,3767L,4028L,4336L,4467L,4596L,4855L,5143L,5442L,5637L,5758L };
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
public class A008190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008190Inst : IEnumerable<long>
{
public static readonly long[] Value=A008190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008190.Bytes);
public long this[int i]=>Value[i];

public static A008190Inst Instance=new A008190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008191
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,67L,97L,124L,165L,219L,265L,318L,367L,449L,530L,597L,674L,742L,843L,1002L,1057L,1142L,1254L,1411L,1577L,1623L,1766L,1921L,2101L,2258L,2347L,2518L,2693L,2936L,3093L,3159L,3389L,3681L,3854L,4052L,4135L,4459L,4739L,4877L,5158L,5281L,5589L };
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
public class A008191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008191Inst : IEnumerable<long>
{
public static readonly long[] Value=A008191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008191.Bytes);
public long this[int i]=>Value[i];

public static A008191Inst Instance=new A008191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008192
{
public static readonly long[] Value={ 1L,4L,12L,22L,40L,65L,98L,132L,159L,206L,278L,318L,379L,440L,510L,603L,683L,766L,844L,945L,1088L,1156L,1266L,1392L,1521L,1680L,1773L,1931L,2080L,2190L,2419L,2566L,2674L,2873L,3047L,3267L,3456L,3580L,3827L,3982L,4272L,4513L,4649L,4824L,5078L,5478L,5651L,5791L };
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
public class A008192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008192Inst : IEnumerable<long>
{
public static readonly long[] Value=A008192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008192.Bytes);
public long this[int i]=>Value[i];

public static A008192Inst Instance=new A008192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008193
{
public static readonly long[] Value={ 1L,4L,12L,24L,41L,62L,97L,129L,170L,212L,262L,322L,386L,446L,516L,575L,695L,772L,862L,944L,1041L,1186L,1286L,1403L,1525L,1629L,1785L,1963L,2062L,2225L,2370L,2562L,2735L,2849L,3088L,3212L,3453L,3630L,3818L,4032L,4176L,4494L,4707L,4875L,5138L,5330L,5614L,5873L };
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
public class A008193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008193Inst : IEnumerable<long>
{
public static readonly long[] Value=A008193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008193.Bytes);
public long this[int i]=>Value[i];

public static A008193Inst Instance=new A008193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008194
{
public static readonly long[] Value={ 1L,4L,12L,22L,42L,66L,94L,126L,164L,220L,270L,312L,370L,450L,544L,600L,652L,734L,888L,986L,1056L,1110L,1258L,1470L,1560L,1620L,1712L,1958L,2148L,2262L,2310L,2458L,2788L,2950L,3068L,3138L,3342L,3740L,3950L,3950L,4136L,4436L,4786L,4994L,5018L,5268L,5608L,5954L };
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
public class A008194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008194Inst : IEnumerable<long>
{
public static readonly long[] Value=A008194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008194.Bytes);
public long this[int i]=>Value[i];

public static A008194Inst Instance=new A008194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008195
{
public static readonly long[] Value={ 1L,4L,12L,24L,44L,66L,88L,132L,174L,214L,258L,318L,394L,448L,510L,608L,650L,776L,878L,958L,1038L,1138L,1328L,1428L,1500L,1644L,1770L,1908L,2136L,2236L,2354L,2486L,2748L,3006L,2970L,3202L,3438L,3678L,3854L,3980L,4240L,4370L,4720L,5056L,5056L,5236L,5576L,5968L };
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
public class A008195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008195Inst : IEnumerable<long>
{
public static readonly long[] Value=A008195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008195.Bytes);
public long this[int i]=>Value[i];

public static A008195Inst Instance=new A008195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008196
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,60L,88L,113L,147L,190L,243L,290L,328L,382L,458L,540L,603L,681L,742L,831L,935L,1021L,1154L,1259L,1316L,1415L,1569L,1733L,1887L,1963L,2011L,2195L,2433L,2585L,2731L,2823L,2943L,3189L,3396L,3566L,3750L,3933L,4044L,4255L,4524L,4748L,5033L,5162L };
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
public class A008196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008196Inst : IEnumerable<long>
{
public static readonly long[] Value=A008196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008196.Bytes);
public long this[int i]=>Value[i];

public static A008196Inst Instance=new A008196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008197
{
public static readonly long[] Value={ 1L,4L,11L,22L,38L,60L,86L,115L,147L,191L,238L,289L,339L,383L,447L,530L,621L,679L,753L,811L,908L,1070L,1159L,1230L,1324L,1405L,1568L,1773L,1859L,1929L,2061L,2184L,2397L,2642L,2703L,2802L,2995L,3143L,3387L,3622L,3738L,3868L,4100L,4245L,4491L,4848L,4954L,5090L };
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
public class A008197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008197Inst : IEnumerable<long>
{
public static readonly long[] Value=A008197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008197.Bytes);
public long this[int i]=>Value[i];

public static A008197Inst Instance=new A008197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008198
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,62L,84L,119L,147L,188L,239L,286L,326L,391L,477L,524L,595L,657L,753L,869L,946L,998L,1106L,1259L,1352L,1466L,1556L,1672L,1855L,1987L,2067L,2229L,2404L,2529L,2700L,2844L,2999L,3216L,3390L,3491L,3726L,3953L,4101L,4316L,4476L,4683L,4981L,5195L };
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
public class A008198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008198Inst : IEnumerable<long>
{
public static readonly long[] Value=A008198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008198.Bytes);
public long this[int i]=>Value[i];

public static A008198Inst Instance=new A008198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008199
{
public static readonly long[] Value={ 1L,4L,12L,23L,37L,59L,85L,120L,154L,184L,231L,288L,343L,400L,444L,514L,611L,694L,746L,822L,930L,1045L,1154L,1218L,1312L,1464L,1598L,1703L,1814L,1952L,2090L,2254L,2397L,2518L,2704L,2863L,2994L,3191L,3378L,3545L,3732L,3898L,4068L,4348L,4562L,4672L,4903L,5140L };
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
public class A008199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008199Inst : IEnumerable<long>
{
public static readonly long[] Value=A008199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008199.Bytes);
public long this[int i]=>Value[i];

public static A008199Inst Instance=new A008199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008200
{
public static readonly long[] Value={ 1L,4L,12L,21L,37L,58L,87L,119L,154L,182L,227L,287L,346L,404L,450L,519L,585L,679L,767L,846L,927L,1029L,1120L,1226L,1367L,1455L,1579L,1695L,1788L,1943L,2142L,2274L,2381L,2528L,2619L,2848L,3090L,3220L,3354L,3517L,3651L,3889L,4227L,4357L,4484L,4658L,4815L,5151L };
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
public class A008200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008200Inst : IEnumerable<long>
{
public static readonly long[] Value=A008200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008200.Bytes);
public long this[int i]=>Value[i];

public static A008200Inst Instance=new A008200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008201
{
public static readonly long[] Value={ 1L,4L,12L,24L,39L,55L,85L,122L,156L,188L,225L,280L,347L,404L,463L,512L,585L,675L,763L,858L,946L,1008L,1109L,1235L,1349L,1493L,1594L,1650L,1790L,1963L,2131L,2300L,2379L,2460L,2669L,2883L,3053L,3230L,3361L,3472L,3694L,3924L,4144L,4384L,4527L,4609L,4852L,5184L };
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
public class A008201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008201Inst : IEnumerable<long>
{
public static readonly long[] Value=A008201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008201.Bytes);
public long this[int i]=>Value[i];

public static A008201Inst Instance=new A008201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008202
{
public static readonly long[] Value={ 1L,4L,12L,23L,38L,59L,83L,115L,155L,192L,233L,271L,328L,409L,475L,529L,572L,647L,772L,881L,941L,1006L,1085L,1220L,1397L,1485L,1553L,1676L,1796L,1961L,2152L,2251L,2374L,2525L,2635L,2833L,3094L,3236L,3338L,3505L,3660L,3931L,4214L,4319L,4448L,4702L,4886L,5116L };
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
public class A008202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008202Inst : IEnumerable<long>
{
public static readonly long[] Value=A008202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008202.Bytes);
public long this[int i]=>Value[i];

public static A008202Inst Instance=new A008202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008203
{
public static readonly long[] Value={ 1L,4L,9L,19L,35L,52L,78L,106L,139L,179L,213L,266L,318L,366L,439L,501L,553L,648L,718L,790L,895L,977L,1063L,1184L,1272L,1378L,1511L,1617L,1727L,1876L,1998L,2122L,2281L,2421L,2551L,2732L,2878L,3022L,3223L,3381L,3529L,3752L,3918L,4086L,4319L,4497L,4679L,4928L };
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
public class A008203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008203Inst : IEnumerable<long>
{
public static readonly long[] Value=A008203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008203.Bytes);
public long this[int i]=>Value[i];

public static A008203Inst Instance=new A008203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008204
{
public static readonly long[] Value={ 1L,4L,8L,18L,36L,56L,66L,116L,140L,154L,232L,264L,294L,392L,432L,478L,588L,620L,718L,816L,868L,962L,1112L,1140L,1278L,1396L,1500L,1594L,1772L,1832L,2010L,2140L,2268L,2382L,2628L,2672L,2878L,3056L,3208L,3334L,3620L,3668L,3942L,4120L,4284L,4458L,4784L,4828L };
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
public class A008204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008204Inst : IEnumerable<long>
{
public static readonly long[] Value=A008204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008204.Bytes);
public long this[int i]=>Value[i];

public static A008204Inst Instance=new A008204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A008205
{
public static readonly long[] Value={ 1L,4L,11L,21L,36L,58L,89L,123L,157L,187L,237L,298L,355L,418L,476L,539L,627L,718L,793L,878L,975L,1086L,1200L,1310L,1405L,1511L,1656L,1794L,1935L,2063L,2196L,2354L,2517L,2685L,2836L,2996L,3176L,3359L,3553L,3731L,3916L,4132L,4331L,4538L,4759L,4955L,5190L,5433L };
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
public class A008205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A008205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A008205Inst : IEnumerable<long>
{
public static readonly long[] Value=A008205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A008205.Bytes);
public long this[int i]=>Value[i];

public static A008205Inst Instance=new A008205Inst();

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

}