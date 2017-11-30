using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A238565
{
public static readonly BigInteger[] Value={ 0L,1L,33L,22102L,478968264L,400686586344699L,BigInteger.Parse("14330879421541116923943"),BigInteger.Parse("23444113544017670689348160755868"),BigInteger.Parse("1841159754991692001851990839259642586671980"),BigInteger.Parse("7197738918090981779157236361118960948634130123398244711") };
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
public class A238565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238565.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238565Inst Instance=new A238565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238566
{
public static readonly BigInteger[] Value={ 0L,1L,41L,44652L,1965803130L,4223556692359571L,BigInteger.Parse("490686876939553950148311"),BigInteger.Parse("3299362171812031624458362654344896"),BigInteger.Parse("1347816410652573760215295879527613786555869189"),BigInteger.Parse("34687845413783594101366282545316028561007822069601179170488") };
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
public class A238566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238566.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238566Inst Instance=new A238566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238567
{
public static readonly BigInteger[] Value={ 0L,1L,51L,83834L,6954866112L,34732639965323612L,BigInteger.Parse("11574681724845786651679939"),BigInteger.Parse("275575507062293332528670070330578043"),BigInteger.Parse("492095606182604983628979092635386202795929807572"),BigInteger.Parse("68346538155515186680097859376764556127526656338966443473179293") };
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
public class A238567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238567Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238567.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238567.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238567Inst Instance=new A238567Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238568
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,2L,2L,1L,2L,1L,3L,2L,4L,3L,4L,2L,2L,5L,5L,3L,4L,4L,8L,1L,3L,3L,4L,3L,4L,3L,6L,3L,4L,4L,3L,4L,6L,3L,5L,2L,1L,8L,3L,10L,6L,5L,5L,9L,7L,6L,3L,8L,7L,9L,2L,5L,5L,2L,2L,9L,7L,3L,5L,8L,7L,6L,8L,7L,9L,9L,6L,3L,7L,8L,14L,5L,9L,10L,8L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238568Inst : IEnumerable<long>
{
public static readonly long[] Value=A238568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238568.Bytes);
public long this[int i]=>Value[i];

public static A238568Inst Instance=new A238568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238569
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,11L,19L,28L,53L,83L,140L,201L,332L,486L,775L,1207L,1716L,2498L,3870L,5623L,8020L,11276L,17168L,23323L,34746L,46141L,64879L,90467L,127971L,176201L,242869L,333508L,456683L,606403L,844818L,1125922L,1496466L,2005446L,2737912L,3543506L,4824442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238569Inst : IEnumerable<long>
{
public static readonly long[] Value=A238569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238569.Bytes);
public long this[int i]=>Value[i];

public static A238569Inst Instance=new A238569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238570
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,4L,2L,1L,2L,3L,1L,1L,3L,3L,1L,1L,3L,2L,2L,2L,4L,5L,2L,5L,3L,6L,4L,5L,4L,1L,2L,2L,6L,4L,2L,1L,3L,1L,1L,5L,5L,1L,6L,3L,3L,7L,4L,6L,1L,4L,5L,3L,4L,4L,7L,6L,4L,7L,6L,6L,1L,3L,3L,5L,6L,6L,3L,4L,9L,6L,4L,2L,5L,3L,8L,3L,3L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238570Inst : IEnumerable<long>
{
public static readonly long[] Value=A238570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238570.Bytes);
public long this[int i]=>Value[i];

public static A238570Inst Instance=new A238570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238571
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,6L,8L,12L,12L,19L,23L,27L,34L,43L,49L,62L,74L,88L,104L,127L,145L,176L,199L,239L,272L,324L,378L,430L,490L,583L,654L,750L,876L,988L,1112L,1291L,1441L,1642L,1877L,2121L,2358L,2682L,2977L,3365L,3830L,4237L,4734L,5357L,5868L,6590L,7398L,8182L,9049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238571Inst : IEnumerable<long>
{
public static readonly long[] Value=A238571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238571.Bytes);
public long this[int i]=>Value[i];

public static A238571Inst Instance=new A238571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238572
{
public static readonly long[] Value={ 17L,29L,37L,41L,53L,59L,67L,71L,79L,89L,97L,101L,103L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,173L,179L,181L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L,331L,337L,347L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238572Inst : IEnumerable<long>
{
public static readonly long[] Value=A238572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238572.Bytes);
public long this[int i]=>Value[i];

public static A238572Inst Instance=new A238572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238573
{
public static readonly long[] Value={ 0L,1L,1L,0L,3L,0L,4L,1L,2L,3L,1L,3L,4L,4L,4L,4L,1L,3L,6L,5L,3L,3L,4L,6L,3L,8L,5L,6L,3L,4L,2L,10L,6L,5L,7L,8L,6L,8L,7L,5L,7L,5L,11L,7L,7L,8L,8L,11L,6L,5L,7L,11L,11L,7L,4L,9L,7L,3L,5L,7L,7L,11L,8L,13L,9L,8L,7L,7L,12L,10L,8L,11L,8L,15L,8L,9L,9L,15L,13L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238573Inst : IEnumerable<long>
{
public static readonly long[] Value=A238573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238573.Bytes);
public long this[int i]=>Value[i];

public static A238573Inst Instance=new A238573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238574
{
public static readonly long[] Value={ 15L,51L,85L,91L,133L,247L,255L,259L,435L,451L,481L,511L,561L,595L,679L,703L,763L,771L,949L,1105L,1111L,1141L,1261L,1285L,1351L,1387L,1417L,1615L,1695L,1729L,1843L,1891L,2047L,2071L,2091L,2119L,2431L,2465L,2509L,2701L,2761L,2821L,2955L,3031L,3097L,3145L,3277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238574Inst : IEnumerable<long>
{
public static readonly long[] Value=A238574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238574.Bytes);
public long this[int i]=>Value[i];

public static A238574Inst Instance=new A238574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238575
{
public static readonly long[] Value={ 15L,51L,85L,91L,133L,247L,259L,451L,481L,511L,679L,703L,763L,771L,949L,1111L,1141L,1261L,1285L,1351L,1387L,1417L,1843L,1891L,2047L,2071L,2119L,2509L,2701L,2761L,3031L,3097L,3277L,3409L,3589L,3667L,4033L,4039L,4141L,4369L,4411L,4681L,5383L,5461L,5611L,5629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238575Inst : IEnumerable<long>
{
public static readonly long[] Value=A238575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238575.Bytes);
public long this[int i]=>Value[i];

public static A238575Inst Instance=new A238575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238624
{
public static readonly long[] Value={ 0L,2L,2L,5L,4L,11L,9L,22L,20L,42L,40L,77L,77L,135L,141L,231L,247L,385L,420L,627L,696L,1002L,1124L,1575L,1782L,2436L,2776L,3718L,4256L,5604L,6437L,8349L,9617L,12310L,14203L,17977L,20764L,26015L,30070L,37338L,43166L,53174L,61469L,75175L,86879L,105558L,121926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238624Inst : IEnumerable<long>
{
public static readonly long[] Value=A238624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238624.Bytes);
public long this[int i]=>Value[i];

public static A238624Inst Instance=new A238624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238625
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,4L,5L,6L,9L,11L,14L,19L,24L,31L,41L,51L,65L,84L,105L,132L,167L,207L,257L,321L,395L,486L,599L,731L,892L,1089L,1319L,1597L,1933L,2327L,2798L,3361L,4021L,4805L,5736L,6825L,8109L,9625L,11393L,13469L,15905L,18738L,22049L,25915L,30401L,35620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238625Inst : IEnumerable<long>
{
public static readonly long[] Value=A238625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238625.Bytes);
public long this[int i]=>Value[i];

public static A238625Inst Instance=new A238625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238626
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,4L,6L,8L,12L,17L,24L,31L,42L,54L,73L,92L,118L,149L,192L,236L,298L,366L,459L,558L,692L,838L,1029L,1238L,1510L,1810L,2196L,2618L,3151L,3747L,4490L,5315L,6337L,7481L,8880L,10447L,12351L,14485L,17065L,19964L,23429L,27339L,31992L,37227L,43428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238626Inst : IEnumerable<long>
{
public static readonly long[] Value=A238626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238626.Bytes);
public long this[int i]=>Value[i];

public static A238626Inst Instance=new A238626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238627
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,4L,6L,10L,13L,20L,27L,39L,50L,70L,87L,120L,147L,198L,240L,315L,381L,491L,594L,752L,900L,1130L,1348L,1676L,1992L,2449L,2902L,3540L,4184L,5065L,5969L,7181L,8438L,10095L,11829L,14078L,16460L,19495L,22740L,26818L,31205L,36662L,42571L,49836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238627Inst : IEnumerable<long>
{
public static readonly long[] Value=A238627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238627.Bytes);
public long this[int i]=>Value[i];

public static A238627Inst Instance=new A238627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238628
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,5L,3L,8L,4L,11L,5L,16L,6L,21L,7L,29L,8L,38L,9L,51L,10L,66L,11L,88L,12L,113L,13L,148L,14L,190L,15L,246L,16L,313L,17L,402L,18L,508L,19L,646L,20L,812L,21L,1023L,22L,1277L,23L,1598L,24L,1982L,25L,2461L,26L,3036L,27L,3745L,28L,4593L,29L,5633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238628Inst : IEnumerable<long>
{
public static readonly long[] Value=A238628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238628.Bytes);
public long this[int i]=>Value[i];

public static A238628Inst Instance=new A238628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238629
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,4L,4L,9L,9L,18L,18L,31L,31L,51L,51L,79L,79L,119L,119L,173L,173L,248L,248L,347L,347L,480L,480L,654L,654L,883L,883L,1178L,1178L,1561L,1561L,2049L,2049L,2674L,2674L,3464L,3464L,4464L,4464L,5717L,5717L,7290L,7290L,9246L,9246L,11680L,11680L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238629Inst : IEnumerable<long>
{
public static readonly long[] Value=A238629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238629.Bytes);
public long this[int i]=>Value[i];

public static A238629Inst Instance=new A238629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238630
{
public static readonly long[] Value={ 1L,3L,12L,75L,588L,5043L,44652L,399675L,3590508L,32294883L,290594892L,2615176875L,23536060428L,211822949523L,1906401762732L,17157601515675L,154418370594348L,1389765206208963L,12507886468460172L,112570977053880075L,1013138789998136268L,9118249099522873203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238630Inst : IEnumerable<long>
{
public static readonly long[] Value=A238630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238630.Bytes);
public long this[int i]=>Value[i];

public static A238630Inst Instance=new A238630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238631
{
public static readonly BigInteger[] Value={ 1L,5L,64L,2280L,123464L,7566280L,478968264L,30569959880L,1955134763464L,125107148059080L,8006513870533064L,512411390124519880L,BigInteger.Parse("32794241006913221064"),BigInteger.Parse("2098830017067059278280"),BigInteger.Parse("134325098574291643691464"),BigInteger.Parse("8596805948466686953550280"),BigInteger.Parse("550195574937260409780728264") };
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
public class A238631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238631Inst Instance=new A238631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238632
{
public static readonly BigInteger[] Value={ 1L,7L,377L,106852L,55567352L,33432635477L,20735819929227L,12940003469288602L,8085018247233663602L,BigInteger.Parse("5052825953808096554227"),BigInteger.Parse("3157977415776418319210477"),BigInteger.Parse("1973731034215692844676632352"),BigInteger.Parse("1233581290054852867292137569852"),BigInteger.Parse("770988230493054044846859764522977") };
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
public class A238632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238632Inst Instance=new A238632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238633
{
public static readonly BigInteger[] Value={ 1L,11L,2432L,6889527L,44056912182L,331281477244572L,2561606354507677872L,BigInteger.Parse("19900384510848921094632"),BigInteger.Parse("154721208025657067873668152"),BigInteger.Parse("1203080775953722005263023646232"),BigInteger.Parse("9355115500676554620340590943203672"),BigInteger.Parse("72745325498731282220397926627254957272") };
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
public class A238633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238633Inst Instance=new A238633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238634
{
public static readonly BigInteger[] Value={ 1L,15L,16475L,569704489L,54667189410224L,6242342067484101895L,BigInteger.Parse("731267824140098782358035"),BigInteger.Parse("85980297709044488588773397089"),BigInteger.Parse("10114611726199237476675435354424104"),BigInteger.Parse("1189959092808570377265545326042454670975"),BigInteger.Parse("139997247522791157386395916200494707946968395") };
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
public class A238634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238634.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238634Inst Instance=new A238634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238635
{
public static readonly BigInteger[] Value={ 1L,22L,116263L,57733506640L,98149884074667116L,BigInteger.Parse("200386212932492140762672"),BigInteger.Parse("418829370245413954052212657987"),BigInteger.Parse("877979540384895591800176962368065072"),BigInteger.Parse("1841159754991692001851990839259642586671980"),BigInteger.Parse("3861166489120966379893685013624485791901912419888") };
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
public class A238635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238635Inst Instance=new A238635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238636
{
public static readonly BigInteger[] Value={ 1L,30L,845105L,6944433285769L,BigInteger.Parse("241192889005578902877"),BigInteger.Parse("10133053906998476170548376403"),BigInteger.Parse("435014756168760380909523387186194290"),BigInteger.Parse("18720322073127387624828552135278902045913865"),BigInteger.Parse("805821524592736878546553406787954567208757510893718") };
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
public class A238636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238636Inst Instance=new A238636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238637
{
public static readonly BigInteger[] Value={ 1L,42L,6292069L,968356321790171L,BigInteger.Parse("778400276435728381405745"),BigInteger.Parse("761287353202857218355451068558296"),BigInteger.Parse("759593815557626617904440619008375351308296"),BigInteger.Parse("759424638305250205001161810310150848799911916053194"),BigInteger.Parse("759407722344103064122231022019913967203947808354408941053194") };
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
public class A238637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238637Inst Instance=new A238637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238638
{
public static readonly BigInteger[] Value={ 1L,2L,4L,14L,109L,3366L,380480L,592178710L,12245355432908L,BigInteger.Parse("42590813279958575804"),BigInteger.Parse("35428820136077436448479258280"),BigInteger.Parse("643572551892460566707053818908283349242945"),BigInteger.Parse("1088540944742787295982636155758383327725184898133092177544054") };
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
public class A238638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238638.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238638Inst Instance=new A238638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238639
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,103L,498L,2493L,12741L,66224L,348963L,1859009L,9994196L,54155387L,295477841L,1621962199L,8951635343L,49644856801L,276540258555L,1546630084062L,8681889729354L,48900895532763L,276302483274825L,1565747892473958L,8896975706929141L,50683901455201860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238639Inst : IEnumerable<long>
{
public static readonly long[] Value=A238639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238639.Bytes);
public long this[int i]=>Value[i];

public static A238639Inst Instance=new A238639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238688
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,8L,1L,1L,12L,32L,12L,1L,1L,24L,96L,96L,24L,1L,1L,24L,192L,288L,192L,24L,1L,1L,48L,384L,1152L,1152L,384L,48L,1L,1L,48L,768L,2304L,4608L,2304L,768L,48L,1L,1L,72L,1152L,6912L,13824L,13824L,6912L,1152L,72L,1L,1L,72L,1728L,10368L,41472L,41472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238688Inst : IEnumerable<long>
{
public static readonly long[] Value=A238688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238688.Bytes);
public long this[int i]=>Value[i];

public static A238688Inst Instance=new A238688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238689
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,5L,3L,2L,7L,2L,2L,2L,3L,3L,5L,2L,11L,3L,2L,2L,13L,7L,2L,5L,3L,2L,2L,2L,2L,17L,3L,3L,2L,19L,5L,2L,2L,7L,3L,11L,2L,23L,3L,2L,2L,2L,5L,5L,13L,2L,3L,3L,3L,7L,2L,2L,29L,5L,3L,2L,31L,2L,2L,2L,2L,2L,11L,3L,17L,2L,7L,5L,3L,3L,2L,2L,37L,19L,2L,13L,3L,5L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238689Inst : IEnumerable<long>
{
public static readonly long[] Value=A238689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238689.Bytes);
public long this[int i]=>Value[i];

public static A238689Inst Instance=new A238689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238690
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,5L,4L,6L,7L,6L,7L,7L,9L,9L,5L,8L,9L,9L,10L,12L,11L,10L,9L,10L,13L,10L,13L,11L,14L,12L,6L,15L,15L,14L,12L,13L,17L,18L,13L,14L,19L,15L,16L,16L,19L,16L,11L,15L,16L,21L,19L,17L,14L,18L,17L,24L,21L,18L,19L,19L,23L,22L,7L,22L,24L,20L,22L,27L,23L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238690Inst : IEnumerable<long>
{
public static readonly long[] Value=A238690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238690.Bytes);
public long this[int i]=>Value[i];

public static A238690Inst Instance=new A238690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238691
{
public static readonly long[] Value={ 1L,2L,3L,15L,15L,21L,1155L,165L,2145L,51051L,255255L,440895L,440895L,969L,111435L,248834355L,248834355L,2927463L,5898837945L,44352165L,1641030105L,8563193457L,42815967285L,80047243185L,1360803134145L,32898537309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238691Inst : IEnumerable<long>
{
public static readonly long[] Value=A238691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238691.Bytes);
public long this[int i]=>Value[i];

public static A238691Inst Instance=new A238691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238692
{
public static readonly BigInteger[] Value={ 0L,1L,7L,139L,365641L,39916801L,1317933016441L,355688356705921L,BigInteger.Parse("53128667010491295649"),BigInteger.Parse("10888872347627347035630931201"),BigInteger.Parse("8841761993746245283777145088001"),BigInteger.Parse("10333147966386144929666651337523200000001") };
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
public class A238692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238692Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238692.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238692.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238692Inst Instance=new A238692Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238693
{
public static readonly BigInteger[] Value={ 0L,1L,93L,571L,16143L,79333L,1755225L,160251339L,705725473L,57691858003L,1057609507815L,4500326662525L,80662044522801L,5995948088798691L,437230824840308493L,1820340203482736875L,BigInteger.Parse("130228506669621162901"),BigInteger.Parse("2230237339841166071433"),BigInteger.Parse("9214275012380069727751") };
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
public class A238693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238693Inst Instance=new A238693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238694
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,3L,1L,5L,25L,5L,31L,5L,1L,15L,49L,17L,1L,5L,1L,17L,9L,33L,69L,89L,61L,111L,199L,309L,75L,297L,1L,5L,49L,131L,31L,17L,31L,131L,165L,437L,55L,33L,309L,495L,361L,437L,999L,89L,139L,195L,129L,183L,685L,315L,915L,189L,585L,1035L,931L,93L,1L,57L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238694Inst : IEnumerable<long>
{
public static readonly long[] Value=A238694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238694.Bytes);
public long this[int i]=>Value[i];

public static A238694Inst Instance=new A238694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238695
{
public static readonly long[] Value={ 7L,3L,6L,4L,3L,0L,8L,2L,7L,2L,3L,6L,7L,2L,5L,7L,2L,5L,6L,3L,7L,2L,7L,7L,2L,5L,0L,9L,6L,3L,1L,0L,5L,3L,0L,9L,5L,6L,5L,4L,2L,5L,6L,8L,3L,6L,0L,6L,8L,9L,0L,7L,6L,6L,0L,7L,9L,2L,5L,5L,4L,9L,5L,3L,6L,9L,6L,2L,3L,8L,1L,6L,4L,4L,0L,7L,6L,2L,3L,9L,8L,1L,9L,8L,1L,4L,0L,5L,0L,5L,6L,3L,7L,1L,4L,8L,1L,7L,9L,0L,3L,2L,7L,2L,4L,9L,3L,9L,5L,7L,4L,5L,6L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238695Inst : IEnumerable<long>
{
public static readonly long[] Value=A238695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238695.Bytes);
public long this[int i]=>Value[i];

public static A238695Inst Instance=new A238695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238696
{
public static readonly BigInteger[] Value={ 1L,1L,2L,21L,497L,18508L,3297933L,2348121769L,2319121509374L,4535739243360613L,BigInteger.Parse("58887253765506968848"),BigInteger.Parse("1694438232474931034462251"),BigInteger.Parse("64598311562133275526222276162"),BigInteger.Parse("8312693334404799592869803398802772"),BigInteger.Parse("5827069387752679429926992257426553147833") };
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
public class A238696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238696Inst Instance=new A238696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238697
{
public static readonly BigInteger[] Value={ 0L,19L,197L,10481L,64027L,1980327L,259179061L,1257208799L,131286703021L,2756321451033L,12473384091267L,250290955437775L,21588599628845597L,1792050990708087027L,7763319803561678613L,BigInteger.Parse("620323392829436218475"),BigInteger.Parse("11365013042482773469559"),BigInteger.Parse("48487140450183407727097") };
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
public class A238697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238697.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238697Inst Instance=new A238697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238698
{
public static readonly BigInteger[] Value={ 1L,27L,3599L,29157L,1362009L,271400395L,1469088801L,201573262419L,4910195172327L,23758960017789L,538608637491505L,54480012827209187L,5189654331623024397L,BigInteger.Parse("23446625614115858667"),BigInteger.Parse("2104894813684998321045"),BigInteger.Parse("41392675008326544152201"),BigInteger.Parse("182632116049323564469767") };
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
public class A238698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238698.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238698Inst Instance=new A238698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238699
{
public static readonly long[] Value={ 2L,5L,7L,17L,19L,47L,67L,89L,157L,227L,229L,307L,349L,439L,467L,487L,509L,599L,647L,797L,929L,1039L,1187L,1217L,1237L,1259L,1307L,1427L,1447L,1567L,1789L,2027L,2309L,2467L,2539L,2707L,2789L,2819L,3167L,3457L,3499L,3659L,3877L,3919L,4057L,4079L,4157L,4289L,4297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238699Inst : IEnumerable<long>
{
public static readonly long[] Value=A238699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238699.Bytes);
public long this[int i]=>Value[i];

public static A238699Inst Instance=new A238699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238700
{
public static readonly BigInteger[] Value={ 1L,625L,7451L,587687L,192856629L,1183808479L,220742818733L,6334029208601L,32973262995075L,853235644319439L,102411500363403805L,11294927679436544243UL,BigInteger.Parse("53352132931526366997"),BigInteger.Parse("5415828333647578287211"),BigInteger.Parse("114722120087477391174007"),BigInteger.Parse("524320903831521291661817") };
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
public class A238700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238700Inst Instance=new A238700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238701
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,2L,3L,3L,4L,4L,4L,3L,3L,3L,3L,4L,4L,4L,6L,5L,5L,5L,3L,4L,6L,6L,7L,6L,4L,4L,4L,4L,5L,5L,5L,5L,4L,4L,4L,4L,3L,3L,4L,4L,6L,6L,4L,5L,5L,5L,7L,6L,6L,6L,5L,5L,4L,4L,5L,5L,5L,5L,5L,5L,6L,6L,5L,5L,5L,5L,3L,4L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238701Inst : IEnumerable<long>
{
public static readonly long[] Value=A238701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238701.Bytes);
public long this[int i]=>Value[i];

public static A238701Inst Instance=new A238701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238702
{
public static readonly long[] Value={ 1L,6L,21L,55L,119L,227L,396L,645L,996L,1474L,2106L,2922L,3955L,5240L,6815L,8721L,11001L,13701L,16870L,20559L,24822L,29716L,35300L,41636L,48789L,56826L,65817L,75835L,86955L,99255L,112816L,127721L,144056L,161910L,181374L,202542L,225511L,250380L,277251L,306229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238702Inst : IEnumerable<long>
{
public static readonly long[] Value=A238702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238702.Bytes);
public long this[int i]=>Value[i];

public static A238702Inst Instance=new A238702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238703
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,3L,3L,1L,3L,4L,0L,4L,2L,1L,3L,5L,0L,4L,4L,1L,4L,5L,0L,3L,4L,0L,3L,6L,0L,5L,4L,1L,6L,6L,0L,7L,4L,1L,5L,4L,0L,7L,6L,0L,8L,5L,0L,8L,7L,1L,6L,7L,0L,9L,9L,1L,9L,8L,0L,6L,7L,0L,7L,12L,0L,9L,7L,1L,11L,10L,0L,6L,8L,0L,7L,9L,0L,7L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238703Inst : IEnumerable<long>
{
public static readonly long[] Value=A238703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238703.Bytes);
public long this[int i]=>Value[i];

public static A238703Inst Instance=new A238703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238880
{
public static readonly long[] Value={ 0L,10L,1L,11L,2L,12L,3L,13L,4L,14L,5L,15L,6L,16L,7L,17L,8L,18L,9L,19L,20L,102L,21L,112L,22L,122L,23L,32L,24L,42L,25L,52L,26L,62L,27L,72L,28L,82L,29L,92L,30L,103L,31L,113L,33L,133L,34L,43L,35L,53L,36L,63L,37L,73L,38L,83L,39L,93L,40L,104L,41L,114L,44L,144L,45L,54L,46L,64L,47L,74L,48L,84L,49L,94L,50L,105L,51L,115L,55L,155L,56L,65L,57L,75L,58L,85L,59L,95L,60L,106L,61L,116L,66L,166L,67L,76L,68L,86L,69L,96L,70L,107L,71L,117L,77L,177L,78L,87L,79L,97L,80L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238880Inst : IEnumerable<long>
{
public static readonly long[] Value=A238880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238880.Bytes);
public long this[int i]=>Value[i];

public static A238880Inst Instance=new A238880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238881
{
public static readonly long[] Value={ 0L,1L,1L,0L,0L,2L,1L,3L,1L,2L,2L,5L,2L,3L,2L,4L,3L,5L,2L,3L,2L,4L,1L,8L,4L,4L,4L,3L,2L,5L,2L,4L,4L,4L,4L,8L,2L,4L,2L,5L,4L,6L,3L,2L,6L,6L,3L,11L,6L,10L,4L,8L,2L,11L,4L,7L,4L,7L,2L,12L,4L,6L,2L,6L,3L,8L,3L,5L,8L,12L,6L,12L,4L,15L,8L,11L,5L,12L,2L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238881Inst : IEnumerable<long>
{
public static readonly long[] Value=A238881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238881.Bytes);
public long this[int i]=>Value[i];

public static A238881Inst Instance=new A238881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238882
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-2L,2L,-1L,3L,1L,2L,1L,-1L,-4L,1L,-4L,-4L,-10L,-2L,-8L,-4L,-5L,-4L,-1L,1L,2L,5L,6L,13L,12L,16L,18L,21L,25L,23L,30L,22L,23L,21L,21L,18L,14L,8L,-1L,-9L,-20L,-36L,-36L,-51L,-61L,-75L,-80L,-96L,-103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238882Inst : IEnumerable<long>
{
public static readonly long[] Value=A238882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238882.Bytes);
public long this[int i]=>Value[i];

public static A238882Inst Instance=new A238882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238883
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,4L,3L,8L,1L,2L,10L,3L,2L,14L,5L,2L,1L,20L,3L,4L,2L,1L,30L,3L,2L,1L,6L,36L,13L,2L,3L,2L,52L,10L,4L,6L,3L,2L,70L,9L,9L,4L,6L,3L,94L,16L,6L,5L,10L,2L,2L,122L,24L,4L,8L,1L,12L,2L,2L,1L,160L,33L,4L,12L,6L,4L,9L,2L,1L,206L,37L,18L,14L,6L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238883Inst : IEnumerable<long>
{
public static readonly long[] Value=A238883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238883.Bytes);
public long this[int i]=>Value[i];

public static A238883Inst Instance=new A238883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238884
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,3L,4L,5L,5L,5L,6L,6L,7L,9L,9L,8L,10L,10L,12L,12L,13L,14L,14L,15L,15L,18L,20L,19L,20L,20L,21L,23L,23L,26L,27L,25L,26L,28L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238884Inst : IEnumerable<long>
{
public static readonly long[] Value=A238884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238884.Bytes);
public long this[int i]=>Value[i];

public static A238884Inst Instance=new A238884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238885
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,2L,2L,3L,2L,2L,6L,1L,2L,2L,6L,1L,4L,2L,2L,8L,2L,4L,4L,2L,2L,8L,2L,6L,1L,8L,1L,2L,2L,10L,2L,6L,2L,12L,4L,2L,2L,2L,10L,2L,8L,2L,12L,1L,12L,4L,1L,2L,2L,12L,2L,8L,2L,16L,2L,12L,6L,9L,4L,2L,2L,12L,2L,10L,2L,16L,2L,16L,8L,1L,18L,6L,4L,2L,2L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238885Inst : IEnumerable<long>
{
public static readonly long[] Value=A238885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238885.Bytes);
public long this[int i]=>Value[i];

public static A238885Inst Instance=new A238885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238886
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,11L,12L,14L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,38L,40L,43L,45L,48L,50L,53L,55L,58L,60L,63L,66L,69L,72L,75L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238886Inst : IEnumerable<long>
{
public static readonly long[] Value=A238886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238886.Bytes);
public long this[int i]=>Value[i];

public static A238886Inst Instance=new A238886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238887
{
public static readonly BigInteger[] Value={ 0L,1L,3L,12L,63L,418L,3460L,35309L,434879L,6296319L,104601742L,1956519181L,40622160668L,926192254412L,22993939511337L,617288387438399L,17815464892300869L,550018928405927892L,18086444341575141093UL,BigInteger.Parse("631071177229005331170"),BigInteger.Parse("23286118567945953909224") };
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
public class A238887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238887Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A238887.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A238887.Bytes);
public BigInteger this[int i]=>Value[i];

public static A238887Inst Instance=new A238887Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238888
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,3L,1L,1L,1L,2L,4L,5L,1L,1L,1L,2L,4L,8L,8L,1L,1L,1L,2L,4L,10L,15L,13L,1L,1L,1L,2L,4L,10L,22L,29L,21L,1L,1L,1L,2L,4L,10L,26L,48L,56L,34L,1L,1L,1L,2L,4L,10L,26L,66L,103L,108L,55L,1L,1L,1L,2L,4L,10L,26L,76L,158L,225L,208L,89L,1L,1L,1L,2L,4L,10L,26L,76L,206L,376L,492L,401L,144L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238888Inst : IEnumerable<long>
{
public static readonly long[] Value=A238888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238888.Bytes);
public long this[int i]=>Value[i];

public static A238888Inst Instance=new A238888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238889
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,4L,3L,2L,0L,1L,7L,7L,7L,4L,0L,1L,12L,16L,19L,18L,10L,0L,1L,20L,35L,47L,55L,48L,26L,0L,1L,33L,74L,117L,151L,170L,142L,76L,0L,1L,54L,153L,284L,399L,515L,544L,438L,232L,0L,1L,88L,312L,675L,1061L,1471L,1826L,1846L,1452L,764L,0L,1L,143L,629L,1575L,2792L,4119L,5651L,6664L,6494L,5008L,2620L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238889Inst : IEnumerable<long>
{
public static readonly long[] Value=A238889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238889.Bytes);
public long this[int i]=>Value[i];

public static A238889Inst Instance=new A238889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238890
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,1L,2L,2L,2L,2L,4L,1L,2L,2L,3L,6L,1L,1L,4L,4L,1L,5L,3L,5L,5L,4L,5L,1L,2L,5L,7L,6L,5L,2L,2L,4L,4L,4L,10L,6L,5L,5L,4L,6L,8L,7L,5L,8L,5L,8L,5L,3L,5L,9L,6L,7L,2L,2L,4L,6L,7L,8L,11L,8L,8L,10L,6L,8L,10L,2L,5L,11L,7L,5L,10L,10L,8L,7L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238890Inst : IEnumerable<long>
{
public static readonly long[] Value=A238890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238890.Bytes);
public long this[int i]=>Value[i];

public static A238890Inst Instance=new A238890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238891
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,15L,35L,70L,1L,210L,462L,66L,715L,3003L,5005L,1L,24310L,1L,92378L,125970L,293930L,646646L,1352078L,10626L,53130L,5311735L,1L,13123110L,34597290L,435L,44352165L,1L,33L,2203961430L,6545L,1L,66045L,33578000610L,62359143990L,91390L,350343565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238891Inst : IEnumerable<long>
{
public static readonly long[] Value=A238891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238891.Bytes);
public long this[int i]=>Value[i];

public static A238891Inst Instance=new A238891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238892
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,2L,3L,4L,0L,4L,5L,2L,4L,6L,6L,0L,8L,0L,9L,8L,9L,10L,11L,4L,5L,10L,0L,10L,11L,2L,10L,0L,1L,16L,3L,0L,4L,18L,18L,4L,9L,10L,18L,20L,12L,18L,20L,0L,0L,0L,1L,16L,21L,18L,10L,0L,21L,22L,23L,28L,29L,30L,9L,0L,1L,2L,3L,32L,33L,6L,35L,0L,9L,32L,10L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238892Inst : IEnumerable<long>
{
public static readonly long[] Value=A238892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238892.Bytes);
public long this[int i]=>Value[i];

public static A238892Inst Instance=new A238892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238893
{
public static readonly long[] Value={ 179L,238L,135L,268L,359L,137L,137L,258L,136L,268L,237L,578L,268L,567L,589L,137L,257L,367L,269L,138L,136L,138L,489L,679L,678L,137L,268L,137L,268L,178L,179L,289L,135L,258L,147L,137L,137L,137L,128L,268L,137L,137L,268L,137L,137L,137L,137L,248L,139L,259L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238893Inst : IEnumerable<long>
{
public static readonly long[] Value=A238893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238893.Bytes);
public long this[int i]=>Value[i];

public static A238893Inst Instance=new A238893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238894
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,2L,2L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238894Inst : IEnumerable<long>
{
public static readonly long[] Value=A238894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238894.Bytes);
public long this[int i]=>Value[i];

public static A238894Inst Instance=new A238894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A238895
{
public static readonly long[] Value={ 2L,3L,6L,21L,31L,49L,73L,91L,115L,121L,169L,211L,301L,331L,361L,391L,421L,511L,631L,721L,781L,841L,1051L,1261L,1471L,1561L,1681L,1891L,2101L,2311L,2521L,2731L,3151L,3361L,3571L,3991L,4201L,4411L,4621L,5251L,5461L,6091L,6511L,6721L,6931L,7771L,7981L,8191L,9031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A238895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A238895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A238895Inst : IEnumerable<long>
{
public static readonly long[] Value=A238895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A238895.Bytes);
public long this[int i]=>Value[i];

public static A238895Inst Instance=new A238895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239168
{
public static readonly BigInteger[] Value={ 0L,1L,40L,43923L,1956835062L,4219267293723828L,BigInteger.Parse("490589938553810921101750"),BigInteger.Parse("3299246284983094033572923631218500"),BigInteger.Parse("1347808520417651710823757078029174789058075682"),BigInteger.Parse("34687813181057391872792859998288408847592250236051615502024") };
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
public class A239168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239168Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239168.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239168.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239168Inst Instance=new A239168Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239169
{
public static readonly BigInteger[] Value={ 0L,1L,49L,82834L,6934032777L,34711806631898612L,BigInteger.Parse("11573466447067793596124382"),BigInteger.Parse("275570877432663678053361428346732364"),BigInteger.Parse("492094366103239904094628894222685729680850442491"),BigInteger.Parse("68346513550765879549763426703232180189170804739067223698078512") };
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
public class A239169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239169Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239169.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239169.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239169Inst Instance=new A239169Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239170
{
public static readonly long[] Value={ 6L,82L,9604L,4140964L,9704723126L,108383467365104L,5817146886160257060L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239170Inst : IEnumerable<long>
{
public static readonly long[] Value=A239170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239170.Bytes);
public long this[int i]=>Value[i];

public static A239170Inst Instance=new A239170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239171
{
public static readonly long[] Value={ 6L,12L,36L,96L,264L,720L,1968L,5376L,14688L,40128L,109632L,299520L,818304L,2235648L,6107904L,16687104L,45590016L,124554240L,340288512L,929685504L,2539948032L,6939267072L,18958430208L,51795394560L,141507649536L,386606088192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239171Inst : IEnumerable<long>
{
public static readonly long[] Value=A239171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239171.Bytes);
public long this[int i]=>Value[i];

public static A239171Inst Instance=new A239171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239172
{
public static readonly long[] Value={ 26L,82L,676L,4338L,29380L,196698L,1321986L,8867938L,59528520L,399598612L,2681935810L,18001714474L,120831198520L,811019710990L,5443667518288L,36538530014326L,245249725777154L,1646142454877826L,11049078946194810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239172Inst : IEnumerable<long>
{
public static readonly long[] Value=A239172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239172.Bytes);
public long this[int i]=>Value[i];

public static A239172Inst Instance=new A239172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239173
{
public static readonly ulong[] Value={ 98L,514L,9604L,130890L,1876940L,26726740L,381984614L,5442841504L,77654661978L,1107987680604L,15802237635146L,225425167338190L,3215775310811444L,45870835552152286L,654345984389717822L,9334191267457643510UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239173Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A239173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239173.Bytes);
public ulong this[int i]=>Value[i];

public static A239173Inst Instance=new A239173Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239174
{
public static readonly BigInteger[] Value={ 378L,3358L,142884L,4140964L,127574544L,3901908720L,119751372066L,3664449484670L,112283408888432L,3440153090631050L,105372547404353366L,3228095751643325026L,BigInteger.Parse("98891535699178971328"),BigInteger.Parse("3029394603374423030318"),BigInteger.Parse("92803263177905303702730") };
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
public class A239174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239174Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239174.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239174.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239174Inst Instance=new A239174Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239175
{
public static readonly BigInteger[] Value={ 1512L,22396L,2286144L,141857204L,9704723126L,652274371446L,44086966064930L,2970697967221324L,200428450914081716L,13520459601210069022UL,BigInteger.Parse("911906098613739953606"),BigInteger.Parse("61511666178571555267010"),BigInteger.Parse("4149152576186582625779538") };
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
public class A239175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239175Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239175.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239175.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239175Inst Instance=new A239175Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239176
{
public static readonly BigInteger[] Value={ 6018L,148820L,36216324L,4845741276L,733415243746L,108383467365104L,16126266923705212L,2391741572658733884L,BigInteger.Parse("355190496243814649808"),BigInteger.Parse("52737580742371581757500"),BigInteger.Parse("7829215010328481095814762") };
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
public class A239176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239176Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239176.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239176.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239176Inst Instance=new A239176Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239177
{
public static readonly BigInteger[] Value={ 23890L,990458L,570732100L,164832769586L,54936152600716L,17806026561159264L,5817146886160257060L,BigInteger.Parse("1893435601399869774904"),BigInteger.Parse("617232814599555452658136"),BigInteger.Parse("201158485132165102089917104"),BigInteger.Parse("65548343766827942844713057136") };
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
public class A239177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239177Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239177.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239177.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239177Inst Instance=new A239177Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239178
{
public static readonly long[] Value={ 6L,26L,12L,98L,82L,36L,378L,514L,676L,96L,1512L,3358L,9604L,4338L,264L,6018L,22396L,142884L,130890L,29380L,720L,23890L,148820L,2286144L,4140964L,1876940L,196698L,1968L,94846L,990458L,36216324L,141857204L,127574544L,26726740L,1321986L,5376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239178Inst : IEnumerable<long>
{
public static readonly long[] Value=A239178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239178.Bytes);
public long this[int i]=>Value[i];

public static A239178Inst Instance=new A239178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239179
{
public static readonly long[] Value={ 6L,26L,98L,378L,1512L,6018L,23890L,94846L,376670L,1495888L,5940530L,23591238L,93686602L,372052590L,1477512180L,5867563418L,23301534646L,92536114306L,367483625614L,1459367686212L,5795507324598L,23015382256774L,91399732715398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239179Inst : IEnumerable<long>
{
public static readonly long[] Value=A239179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239179.Bytes);
public long this[int i]=>Value[i];

public static A239179Inst Instance=new A239179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239180
{
public static readonly long[] Value={ 12L,82L,514L,3358L,22396L,148820L,990458L,6592268L,43855688L,291663494L,1939766486L,12902228032L,85822416192L,570863549026L,3797126473142L,25256582287082L,167994557738914L,1117422617194994L,7432590319039134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239180Inst : IEnumerable<long>
{
public static readonly long[] Value=A239180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239180.Bytes);
public long this[int i]=>Value[i];

public static A239180Inst Instance=new A239180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239181
{
public static readonly BigInteger[] Value={ 36L,676L,9604L,142884L,2286144L,36216324L,570732100L,8995763716L,141880288900L,2237680908544L,35289896680900L,556546510372644L,8777179394306404L,138423129725708100L,2183042242048352400L,BigInteger.Parse("34428300464251842724") };
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
public class A239181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239181Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239181.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239181.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239181Inst Instance=new A239181Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239182
{
public static readonly BigInteger[] Value={ 96L,4338L,130890L,4140964L,141857204L,4845741276L,164832769586L,5599418921698L,190195696304560L,6461159416603066L,219523090735636884L,7458704803405213070L,BigInteger.Parse("253417930428586993926"),BigInteger.Parse("8610020171945074510358"),BigInteger.Parse("292529883372379893547602") };
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
public class A239182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239182Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239182.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239182.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239182Inst Instance=new A239182Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239183
{
public static readonly BigInteger[] Value={ 264L,29380L,1876940L,127574544L,9704723126L,733415243746L,54936152600716L,4111287727512886L,307924773739171154L,BigInteger.Parse("23065243594034127466"),BigInteger.Parse("1727630571037935858864"),BigInteger.Parse("129403091862274483062610") };
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
public class A239183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239183.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239183Inst Instance=new A239183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239232
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,3L,3L,2L,1L,1L,1L,1L,2L,4L,4L,4L,4L,4L,3L,4L,4L,4L,4L,4L,4L,3L,2L,2L,2L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,3L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,3L,4L,5L,5L,4L,4L,4L,4L,4L,4L,5L,5L,6L,6L,7L,6L,6L,6L,6L,7L,8L,8L,9L,9L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239232Inst : IEnumerable<long>
{
public static readonly long[] Value=A239232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239232.Bytes);
public long this[int i]=>Value[i];

public static A239232Inst Instance=new A239232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239233
{
public static readonly long[] Value={ 0L,0L,3L,0L,5L,0L,7L,9L,9L,0L,11L,0L,13L,15L,15L,0L,17L,21L,19L,21L,21L,0L,23L,0L,25L,27L,27L,33L,29L,0L,31L,33L,33L,0L,35L,0L,37L,39L,39L,0L,41L,0L,43L,45L,45L,49L,47L,57L,49L,51L,51L,0L,53L,0L,55L,57L,57L,69L,59L,63L,61L,63L,63L,0L,65L,0L,67L,69L,69L,0L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239233Inst : IEnumerable<long>
{
public static readonly long[] Value=A239233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239233.Bytes);
public long this[int i]=>Value[i];

public static A239233Inst Instance=new A239233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239234
{
public static readonly long[] Value={ 0L,2L,6L,17L,36L,99L,249L,651L,1774L,5018L,13587L,39170L,115968L,323061L,953827L,2870277L,8165537L,24569821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239234Inst : IEnumerable<long>
{
public static readonly long[] Value=A239234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239234.Bytes);
public long this[int i]=>Value[i];

public static A239234Inst Instance=new A239234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239235
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,1L,14L,15L,16L,17L,18L,19L,20L,21L,22L,101L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,102L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,103L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,104L,56L,57L,58L,59L,60L,61L,62L,63L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239235Inst : IEnumerable<long>
{
public static readonly long[] Value=A239235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239235.Bytes);
public long this[int i]=>Value[i];

public static A239235Inst Instance=new A239235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239236
{
public static readonly long[] Value={ 11L,101L,110L,111L,353L,1001L,1010L,1011L,1100L,1101L,1110L,10001L,10010L,10011L,10100L,10101L,10110L,11000L,11001L,11010L,11100L,11111L,62315L,100001L,100010L,100011L,100100L,100101L,100110L,101000L,101001L,101010L,101100L,101111L,110000L,110001L,110010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239236Inst : IEnumerable<long>
{
public static readonly long[] Value=A239236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239236.Bytes);
public long this[int i]=>Value[i];

public static A239236Inst Instance=new A239236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239237
{
public static readonly long[] Value={ 10L,20L,203L,230L,308L,309L,330L,350L,503L,603L,650L,960L,1068L,1110L,1206L,1350L,1404L,1480L,1730L,1802L,1860L,1910L,2032L,2038L,2044L,2054L,2250L,2320L,2502L,3044L,3082L,3402L,3970L,4032L,4046L,4072L,4120L,4340L,4450L,4540L,4650L,4908L,5204L,5310L,5402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239237Inst : IEnumerable<long>
{
public static readonly long[] Value=A239237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239237.Bytes);
public long this[int i]=>Value[i];

public static A239237Inst Instance=new A239237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239238
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,1L,4L,5L,2L,4L,5L,4L,4L,4L,2L,4L,3L,6L,3L,1L,3L,5L,5L,5L,2L,9L,8L,7L,5L,3L,3L,4L,3L,7L,4L,8L,6L,2L,6L,6L,5L,2L,5L,5L,3L,3L,4L,4L,7L,7L,8L,5L,5L,4L,8L,6L,3L,4L,3L,5L,11L,2L,2L,4L,6L,6L,5L,5L,4L,4L,5L,6L,6L,8L,4L,9L,4L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239238Inst : IEnumerable<long>
{
public static readonly long[] Value=A239238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239238.Bytes);
public long this[int i]=>Value[i];

public static A239238Inst Instance=new A239238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239239
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,0L,2L,1L,2L,2L,3L,4L,4L,7L,5L,11L,7L,16L,10L,23L,15L,32L,21L,43L,32L,57L,45L,74L,66L,96L,92L,123L,129L,157L,175L,199L,239L,253L,316L,320L,419L,406L,544L,514L,704L,652L,898L,825L,1142L,1045L,1435L,1321L,1798L,1669L,2234L,2103L,2766L,2646L,3404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239239Inst : IEnumerable<long>
{
public static readonly long[] Value=A239239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239239.Bytes);
public long this[int i]=>Value[i];

public static A239239Inst Instance=new A239239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239240
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,2L,4L,2L,6L,4L,9L,6L,13L,10L,18L,15L,24L,24L,32L,35L,43L,51L,56L,72L,74L,100L,97L,136L,128L,183L,168L,241L,222L,315L,290L,408L,381L,522L,497L,664L,647L,839L,837L,1054L,1081L,1317L,1384L,1641L,1767L,2035L,2242L,2519L,2831L,3108L,3555L,3828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239240Inst : IEnumerable<long>
{
public static readonly long[] Value=A239240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239240.Bytes);
public long this[int i]=>Value[i];

public static A239240Inst Instance=new A239240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239241
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,2L,0L,3L,0L,4L,1L,5L,2L,6L,5L,7L,8L,8L,14L,9L,20L,11L,30L,13L,40L,17L,55L,23L,70L,32L,91L,45L,112L,65L,140L,91L,169L,128L,206L,177L,245L,241L,295L,323L,350L,429L,419L,559L,499L,722L,600L,921L,721L,1162L,874L,1452L,1062L,1800L,1299L,2210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239241Inst : IEnumerable<long>
{
public static readonly long[] Value=A239241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239241.Bytes);
public long this[int i]=>Value[i];

public static A239241Inst Instance=new A239241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239242
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,2L,1L,4L,2L,6L,3L,9L,5L,12L,9L,17L,14L,22L,22L,29L,33L,38L,48L,50L,68L,65L,95L,86L,128L,113L,172L,149L,226L,197L,295L,260L,379L,342L,485L,449L,613L,587L,773L,762L,967L,987L,1206L,1269L,1497L,1623L,1855L,2063L,2289L,2610L,2823L,3280L,3471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239242Inst : IEnumerable<long>
{
public static readonly long[] Value=A239242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239242.Bytes);
public long this[int i]=>Value[i];

public static A239242Inst Instance=new A239242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239243
{
public static readonly long[] Value={ 1L,1L,0L,2L,1L,3L,2L,4L,4L,6L,7L,8L,11L,11L,17L,16L,25L,22L,36L,31L,49L,44L,68L,61L,90L,85L,120L,118L,156L,160L,204L,217L,261L,291L,337L,386L,429L,507L,548L,662L,694L,854L,882L,1096L,1112L,1396L,1406L,1765L,1768L,2219L,2223L,2776L,2784L,3451L,3484L,4275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239243Inst : IEnumerable<long>
{
public static readonly long[] Value=A239243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239243.Bytes);
public long this[int i]=>Value[i];

public static A239243Inst Instance=new A239243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239244
{
public static readonly long[] Value={ 3L,4L,6L,80L,920L,37568L,56352L,7148453888L,7169453056L,7286124544L,7325797376L,7595232256L,8935567360L,9107655680L,13403351040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239244Inst : IEnumerable<long>
{
public static readonly long[] Value=A239244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239244.Bytes);
public long this[int i]=>Value[i];

public static A239244Inst Instance=new A239244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239245
{
public static readonly long[] Value={ 240L,5625L,40625L,1640625L,4140625L,39495680L,47265625L,56640625L,3574214656L,66247700480L,115760971776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239245Inst : IEnumerable<long>
{
public static readonly long[] Value=A239245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239245.Bytes);
public long this[int i]=>Value[i];

public static A239245Inst Instance=new A239245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239246
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,2L,0L,2L,0L,3L,0L,0L,2L,2L,0L,0L,1L,3L,2L,0L,1L,2L,3L,0L,0L,0L,0L,2L,1L,5L,0L,4L,3L,4L,1L,0L,2L,1L,0L,0L,2L,0L,2L,4L,6L,4L,0L,2L,2L,0L,2L,0L,1L,3L,0L,1L,0L,8L,2L,0L,5L,1L,2L,0L,0L,6L,2L,7L,0L,3L,0L,0L,3L,0L,2L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239246Inst : IEnumerable<long>
{
public static readonly long[] Value=A239246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239246.Bytes);
public long this[int i]=>Value[i];

public static A239246Inst Instance=new A239246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239247
{
public static readonly long[] Value={ 15L,30L,35L,45L,55L,60L,65L,70L,75L,85L,89L,90L,95L,105L,110L,115L,120L,125L,130L,135L,140L,145L,150L,155L,165L,170L,175L,178L,180L,185L,190L,195L,205L,210L,215L,220L,225L,230L,233L,235L,240L,245L,250L,255L,260L,265L,267L,270L,275L,280L,285L,290L,295L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239247Inst : IEnumerable<long>
{
public static readonly long[] Value=A239247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239247.Bytes);
public long this[int i]=>Value[i];

public static A239247Inst Instance=new A239247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239296
{
public static readonly BigInteger[] Value={ 1L,1L,4L,24L,186L,1745L,19090L,237594L,3305610L,50736447L,850285888L,15430858102L,301188960996L,6286897888336L,139661748755464L,3288136274970026L,81747690289414282L,2139280904017185007L,BigInteger.Parse("58762203796595526676"),BigInteger.Parse("1689933802493155288876"),BigInteger.Parse("50768897450201657287066") };
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
public class A239296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239296.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239296Inst Instance=new A239296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239297
{
public static readonly long[] Value={ 3L,28L,282L,2827L,28274L,282743L,2827433L,28274333L,282743338L,2827433388L,28274333882L,282743338823L,2827433388230L,28274333882308L,282743338823081L,2827433388230813L,28274333882308139L,282743338823081391L,2827433388230813914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239297Inst : IEnumerable<long>
{
public static readonly long[] Value=A239297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239297.Bytes);
public long this[int i]=>Value[i];

public static A239297Inst Instance=new A239297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239298
{
public static readonly long[] Value={ 1L,1L,4L,27L,255L,3028L,41972L,647034L,10760307L,189317370L,3478597980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239298Inst : IEnumerable<long>
{
public static readonly long[] Value=A239298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239298.Bytes);
public long this[int i]=>Value[i];

public static A239298Inst Instance=new A239298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239299
{
public static readonly BigInteger[] Value={ 1L,1L,4L,27L,255L,3028L,41979L,647790L,10803237L,191122140L,3542732908L,68213661464L,1355643940248L,27673150807344L,578051855658450L,12318499151821116L,267156147212406393L,5884501351433388108L,BigInteger.Parse("131418738987996420708"),BigInteger.Parse("2971588663914996425000") };
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
public class A239299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239299.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239299Inst Instance=new A239299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239300
{
public static readonly long[] Value={ 1L,1L,4L,27L,255L,3028L,41979L,647826L,10807287L,191374095L,3554481788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239300Inst : IEnumerable<long>
{
public static readonly long[] Value=A239300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239300.Bytes);
public long this[int i]=>Value[i];

public static A239300Inst Instance=new A239300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239301
{
public static readonly BigInteger[] Value={ 1L,6L,67L,1090L,23265L,614302L,19323163L,705288522L,29296813825L,1364468928022L,70414831288275L,3987980655931570L,245910243177940897L,16399345182278307822UL,BigInteger.Parse("1176033825828643912747"),BigInteger.Parse("90242683036826223141370"),BigInteger.Parse("7377887848681408224106497"),BigInteger.Parse("640225878087732419052020134") };
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
public class A239301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A239301.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A239301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A239301Inst Instance=new A239301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239302
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,2L,1L,1L,1L,1L,0L,1L,2L,2L,1L,1L,1L,1L,0L,1L,2L,2L,2L,1L,1L,1L,1L,0L,1L,3L,2L,2L,2L,1L,1L,1L,1L,0L,1L,3L,3L,2L,2L,2L,1L,1L,1L,1L,0L,1L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,0L,1L,5L,4L,3L,3L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239302Inst : IEnumerable<long>
{
public static readonly long[] Value=A239302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239302.Bytes);
public long this[int i]=>Value[i];

public static A239302Inst Instance=new A239302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239303
{
public static readonly long[] Value={ 1L,3L,1L,6L,1L,5L,6L,9L,1L,10L,12L,18L,1L,17L,10L,12L,18L,33L,1L,34L,20L,24L,36L,66L,1L,65L,34L,20L,24L,36L,66L,129L,1L,130L,68L,40L,48L,72L,132L,258L,1L,257L,130L,68L,40L,48L,72L,132L,258L,513L,1L,514L,260L,136L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239303Inst : IEnumerable<long>
{
public static readonly long[] Value=A239303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239303.Bytes);
public long this[int i]=>Value[i];

public static A239303Inst Instance=new A239303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A239304
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,4L,2L,1L,3L,2L,5L,4L,1L,3L,2L,5L,6L,3L,1L,4L,6L,2L,3L,7L,5L,1L,4L,7L,3L,2L,6L,8L,4L,1L,5L,3L,8L,7L,2L,4L,9L,6L,1L,5L,3L,8L,9L,4L,2L,7L,10L,5L,1L,6L,9L,3L,4L,10L,8L,2L,5L,11L,7L,1L,6L,10L,4L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A239304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A239304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A239304Inst : IEnumerable<long>
{
public static readonly long[] Value=A239304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A239304.Bytes);
public long this[int i]=>Value[i];

public static A239304Inst Instance=new A239304Inst();

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