using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A259882
{
public static readonly long[] Value={ 0L,2L,2L,6L,4L,22L,14L,102L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259882Inst : IEnumerable<long>
{
public static readonly long[] Value=A259882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259882.Bytes);
public long this[int i]=>Value[i];

public static A259882Inst Instance=new A259882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259883
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,10L,100L,1001L,100110L,100110100L,1001101001001L,1001101001001100110L,BigInteger.Parse("1001101001001100110100110100"),BigInteger.Parse("10011010010011001101001101001001101001001"),BigInteger.Parse("100110100100110011010011010010011010010011001101001001100110") };
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
public class A259883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259883Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259883.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259883.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259883Inst Instance=new A259883Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259884
{
public static readonly long[] Value={ 1L,3L,4L,4L,4L,7L,8L,4L,5L,8L,12L,8L,4L,12L,8L,8L,9L,12L,16L,4L,12L,15L,8L,8L,8L,20L,20L,8L,8L,12L,16L,16L,8L,15L,20L,12L,12L,16L,16L,12L,13L,24L,20L,8L,8L,24L,24L,8L,16L,12L,28L,16L,12L,28L,8L,20L,13L,20L,28L,16L,20L,24L,16L,8L,8L,27L,36L,12L,16L,28L,24L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259884Inst : IEnumerable<long>
{
public static readonly long[] Value=A259884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259884.Bytes);
public long this[int i]=>Value[i];

public static A259884Inst Instance=new A259884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259885
{
public static readonly long[] Value={ 1L,1L,3L,7L,18L,57L,169L,484L,1684L,5661L,18579L,59917L,214058L,760487L,2665884L,9246276L,31945379L,117939506L,431530926L,1567159901L,5655480303L,20299352107L,74300429926L,278279597781L,1037075511926L,3848154018734L,14224439297732L,52402156308977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259885Inst : IEnumerable<long>
{
public static readonly long[] Value=A259885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259885.Bytes);
public long this[int i]=>Value[i];

public static A259885Inst Instance=new A259885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259886
{
public static readonly BigInteger[] Value={ 34L,174L,3511L,58800L,863502L,36899517L,2374588015L,164942896153L,19599999649066L,4057158204209362L,1127811895283780994L,BigInteger.Parse("456911158873144313537"),BigInteger.Parse("303382458821148235424263") };
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
public class A259886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259886Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259886.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259886.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259886Inst Instance=new A259886Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259887
{
public static readonly long[] Value={ 34L,67L,215L,499L,936L,2212L,5352L,11529L,25397L,58793L,132494L,294066L,664222L,1503071L,3370883L,7574191L,17082212L,38445840L,86429444L,194563077L,438038913L,985523653L,2217627370L,4991511166L,11233246170L,25277953979L,56888391919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259887Inst : IEnumerable<long>
{
public static readonly long[] Value=A259887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259887.Bytes);
public long this[int i]=>Value[i];

public static A259887Inst Instance=new A259887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259888
{
public static readonly long[] Value={ 67L,174L,653L,1853L,4662L,13704L,40955L,114098L,320200L,925820L,2650721L,7507059L,21402747L,61226147L,174506650L,497034443L,1418169080L,4046094873L,11534896627L,32891041296L,93814175452L,267543153907L,762917347904L,2175699989264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259888Inst : IEnumerable<long>
{
public static readonly long[] Value=A259888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259888.Bytes);
public long this[int i]=>Value[i];

public static A259888Inst Instance=new A259888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259889
{
public static readonly long[] Value={ 215L,653L,3511L,13373L,40435L,151483L,595513L,2101769L,7434765L,27615849L,101238339L,364229615L,1323891453L,4841497755L,17598175493L,63882224753L,232605289739L,846849589145L,3078975889701L,11198709862663L,40752724559215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259889Inst : IEnumerable<long>
{
public static readonly long[] Value=A259889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259889.Bytes);
public long this[int i]=>Value[i];

public static A259889Inst Instance=new A259889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259890
{
public static readonly long[] Value={ 499L,1853L,13373L,58800L,202632L,954624L,4585294L,18966448L,80737802L,366501170L,1610438050L,6928342996L,30446045528L,134338881490L,586149763228L,2560529857154L,11241312446298L,49255090317994L,215425770352536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259890Inst : IEnumerable<long>
{
public static readonly long[] Value=A259890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259890.Bytes);
public long this[int i]=>Value[i];

public static A259890Inst Instance=new A259890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259891
{
public static readonly long[] Value={ 936L,4662L,40435L,202632L,863502L,5055255L,28982771L,144514845L,753909576L,4156538339L,22079571360L,115439403732L,616985118609L,3302552685297L,17486869963737L,92800385304502L,494726612194783L,2631317292421710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259891Inst : IEnumerable<long>
{
public static readonly long[] Value=A259891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259891.Bytes);
public long this[int i]=>Value[i];

public static A259891Inst Instance=new A259891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259892
{
public static readonly long[] Value={ 2212L,13704L,151483L,954624L,5055255L,36899517L,265544204L,1657505754L,10777787104L,74223540333L,493525981009L,3224220550323L,21513589812308L,143942550183867L,952854630337292L,6317108715977706L,42075784020262790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259892Inst : IEnumerable<long>
{
public static readonly long[] Value=A259892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259892.Bytes);
public long this[int i]=>Value[i];

public static A259892Inst Instance=new A259892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259893
{
public static readonly long[] Value={ 5352L,40955L,595513L,4585294L,28982771L,265544204L,2374588015L,18039882288L,144461629861L,1233632487918L,10083224404333L,80918630458268L,666460883164444L,5497242097282752L,44766260097986518L,365582700356432207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259893Inst : IEnumerable<long>
{
public static readonly long[] Value=A259893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259893.Bytes);
public long this[int i]=>Value[i];

public static A259893Inst Instance=new A259893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259894
{
public static readonly long[] Value={ 34L,67L,67L,215L,174L,215L,499L,653L,653L,499L,936L,1853L,3511L,1853L,936L,2212L,4662L,13373L,13373L,4662L,2212L,5352L,13704L,40435L,58800L,40435L,13704L,5352L,11529L,40955L,151483L,202632L,202632L,151483L,40955L,11529L,25397L,114098L,595513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259894Inst : IEnumerable<long>
{
public static readonly long[] Value=A259894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259894.Bytes);
public long this[int i]=>Value[i];

public static A259894Inst Instance=new A259894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259895
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,0L,0L,2L,0L,1L,1L,0L,0L,2L,0L,0L,1L,0L,2L,1L,0L,1L,1L,0L,0L,0L,0L,1L,3L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,2L,0L,0L,2L,0L,1L,1L,0L,1L,2L,0L,0L,0L,0L,1L,1L,0L,1L,2L,0L,0L,1L,0L,3L,0L,0L,0L,1L,0L,0L,2L,0L,1L,3L,0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259895Inst : IEnumerable<long>
{
public static readonly long[] Value=A259895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259895.Bytes);
public long this[int i]=>Value[i];

public static A259895Inst Instance=new A259895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259896
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,2L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,3L,0L,0L,1L,0L,0L,1L,2L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,2L,0L,0L,2L,0L,0L,1L,2L,0L,0L,0L,0L,2L,0L,0L,1L,1L,0L,1L,0L,0L,1L,2L,0L,2L,1L,0L,2L,0L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259896Inst : IEnumerable<long>
{
public static readonly long[] Value=A259896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259896.Bytes);
public long this[int i]=>Value[i];

public static A259896Inst Instance=new A259896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259897
{
public static readonly long[] Value={ 0L,0L,1L,3L,3L,3L,4L,6L,6L,10L,9L,11L,10L,11L,11L,14L,12L,10L,11L,13L,14L,17L,17L,17L,16L,16L,18L,20L,22L,23L,21L,23L,20L,24L,21L,21L,20L,22L,24L,23L,22L,21L,22L,26L,26L,30L,31L,32L,30L,35L,34L,33L,31L,33L,34L,34L,33L,37L,38L,40L,42L,42L,44L,46L,42L,42L,43L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259897Inst : IEnumerable<long>
{
public static readonly long[] Value=A259897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259897.Bytes);
public long this[int i]=>Value[i];

public static A259897Inst Instance=new A259897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259898
{
public static readonly long[] Value={ 4L,16L,64L,250L,976L,3760L,14500L,55438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259898Inst : IEnumerable<long>
{
public static readonly long[] Value=A259898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259898.Bytes);
public long this[int i]=>Value[i];

public static A259898Inst Instance=new A259898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259899
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259899Inst : IEnumerable<long>
{
public static readonly long[] Value=A259899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259899.Bytes);
public long this[int i]=>Value[i];

public static A259899Inst Instance=new A259899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259900
{
public static readonly BigInteger[] Value={ 0L,1L,7L,56L,532L,5978L,78190L,1171016L,19795048L,373150316L,7765117444L,176867001920L,4377593349808L,117008560148984L,3359391916968808L,103116666783684512L,3370015324850779360L,BigInteger.Parse("116837927866976317904"),BigInteger.Parse("4283225196844255657072"),BigInteger.Parse("165548433805933065663104") };
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
public class A259900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259900.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259900Inst Instance=new A259900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259901
{
public static readonly BigInteger[] Value={ 1L,0L,2L,16L,152L,1708L,22340L,334576L,5655728L,106614376L,2218604984L,50533429120L,1250740957088L,33431017185424L,959826261991088L,29461904795338432L,962861521385936960L,BigInteger.Parse("33382265104850376544"),BigInteger.Parse("1223778627669787330592"),BigInteger.Parse("47299552515980875903744") };
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
public class A259901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259901Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259901.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259901.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259901Inst Instance=new A259901Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259902
{
public static readonly BigInteger[] Value={ 0L,1L,4L,26L,220L,2300L,28648L,414212L,6818728L,125907560L,2577034480L,57906103064L,1417086592336L,37515931327184L,1068289141830880L,32558309340991280L,1057440044863257952L,BigInteger.Parse("36460006715962829408"),BigInteger.Parse("1330080906206563365952"),BigInteger.Parse("51183492956063789966240") };
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
public class A259902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259902Inst Instance=new A259902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259903
{
public static readonly BigInteger[] Value={ 1L,3L,14L,91L,770L,8050L,100268L,1449742L,23865548L,440676460L,9019620680L,202671360724L,4959803073176L,131305759645144L,3739011996408080L,113954082693469480L,3701040157021402832L,BigInteger.Parse("127610023505869902928"),BigInteger.Parse("4655283171722971780832"),BigInteger.Parse("179142225346223264881840") };
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
public class A259903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259903Inst Instance=new A259903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259904
{
public static readonly BigInteger[] Value={ 0L,1L,3L,18L,142L,1407L,16773L,233668L,3724476L,66837885L,1333469575L,29276505366L,701429322378L,18210426152443L,509246515680777L,15260531890180872L,487862847976502008L,16573059718335854073UL,BigInteger.Parse("596171824656869639691"),BigInteger.Parse("22638902465293908063130") };
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
public class A259904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259904Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259904.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259904.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259904Inst Instance=new A259904Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259905
{
public static readonly BigInteger[] Value={ 1L,2L,8L,47L,371L,3676L,43822L,610493L,9730757L,174624086L,3483890996L,76489299307L,1832590219063L,47577493251632L,1330483562569946L,39870448222541561L,1274615495706568457L,BigInteger.Parse("43299625736778117418"),BigInteger.Parse("1557589082593773410272"),BigInteger.Parse("59147557572252556858151") };
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
public class A259905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259905Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259905.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259905.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259905Inst Instance=new A259905Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259906
{
public static readonly BigInteger[] Value={ 0L,1L,5L,34L,290L,3015L,37131L,529540L,8590724L,156302605L,3152964305L,69852444006L,1686248475750L,44058654556819L,1238847414761495L,37301117245210120L,1197443930238816776L,BigInteger.Parse("40827566310832732185"),BigInteger.Parse("1473461890546162560669"),BigInteger.Parse("56116506599112620887210") };
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
public class A259906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259906Inst Instance=new A259906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259907
{
public static readonly long[] Value={ 1L,123L,1557L,6719L,16800L,31920L,52080L,77280L,107520L,142800L,183120L,228480L,278880L,334320L,394800L,460320L,530880L,606480L,687120L,772800L,863520L,959280L,1060080L,1165920L,1276800L,1392720L,1513680L,1639680L,1770720L,1906800L,2047920L,2194080L,2345280L,2501520L,2662800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259907Inst : IEnumerable<long>
{
public static readonly long[] Value=A259907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259907.Bytes);
public long this[int i]=>Value[i];

public static A259907Inst Instance=new A259907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259908
{
public static readonly long[] Value={ 1L,3L,5L,17L,70L,61L,155L,1143L,2317L,1385L,38227L,623753L,3243270L,7258090L,7293671L,2702765L,929569L,20454498L,147624355L,484343420L,796220487L,639139202L,199360981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259908Inst : IEnumerable<long>
{
public static readonly long[] Value=A259908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259908.Bytes);
public long this[int i]=>Value[i];

public static A259908Inst Instance=new A259908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259909
{
public static readonly long[] Value={ 1093L,1006003L,40487L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259909Inst : IEnumerable<long>
{
public static readonly long[] Value=A259909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259909.Bytes);
public long this[int i]=>Value[i];

public static A259909Inst Instance=new A259909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259910
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,3L,4L,3L,3L,4L,6L,6L,7L,8L,8L,9L,11L,12L,13L,14L,17L,19L,21L,21L,25L,27L,30L,31L,35L,39L,43L,47L,51L,55L,60L,65L,71L,77L,83L,88L,98L,105L,115L,122L,132L,142L,155L,164L,178L,191L,206L,220L,236L,252L,272L,290L,311L,332L,356L,378L,407L,434L,464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259910Inst : IEnumerable<long>
{
public static readonly long[] Value=A259910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259910.Bytes);
public long this[int i]=>Value[i];

public static A259910Inst Instance=new A259910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259911
{
public static readonly long[] Value={ 5L,12L,12L,21L,8L,21L,8L,60L,60L,8L,5L,24L,13L,24L,5L,60L,140L,12L,12L,140L,60L,77L,12L,285L,5L,285L,12L,77L,24L,28L,44L,120L,120L,44L,28L,24L,13L,5L,21L,168L,29L,168L,21L,5L,13L,140L,44L,168L,56L,1020L,1020L,56L,168L,44L,140L,165L,120L,93L,8L,1365L,40L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259911Inst : IEnumerable<long>
{
public static readonly long[] Value=A259911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259911.Bytes);
public long this[int i]=>Value[i];

public static A259911Inst Instance=new A259911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259912
{
public static readonly long[] Value={ 5L,8L,13L,5L,29L,40L,53L,17L,85L,104L,5L,37L,173L,8L,229L,65L,293L,328L,365L,101L,445L,488L,533L,145L,629L,680L,733L,197L,5L,904L,965L,257L,1093L,1160L,1229L,13L,1373L,1448L,61L,401L,1685L,1768L,1853L,485L,2029L,2120L,2213L,577L,2405L,2504L,2605L,677L,2813L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259912Inst : IEnumerable<long>
{
public static readonly long[] Value=A259912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259912.Bytes);
public long this[int i]=>Value[i];

public static A259912Inst Instance=new A259912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259913
{
public static readonly long[] Value={ 5L,12L,21L,8L,5L,60L,77L,24L,13L,140L,165L,12L,221L,28L,285L,5L,357L,44L,437L,120L,21L,572L,69L,168L,29L,780L,93L,56L,957L,1020L,1085L,8L,1221L,1292L,1365L,40L,1517L,1596L,1677L,440L,205L,1932L,2021L,33L,5L,92L,2397L,156L,53L,12L,2805L,728L,3021L,348L,3245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259913Inst : IEnumerable<long>
{
public static readonly long[] Value=A259913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259913.Bytes);
public long this[int i]=>Value[i];

public static A259913Inst Instance=new A259913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259914
{
public static readonly long[] Value={ 1L,9L,10L,46L,57L,203L,272L,846L,1200L,3432L,5082L,13728L,21021L,54483L,85696L,215254L,346086L,848198L,1388900L,3337236L,5549786L,13119614L,22108704L,51557260L,87885070L,202588830L,348817770L,796117860L,1382941125L,3129153795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259914Inst : IEnumerable<long>
{
public static readonly long[] Value=A259914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259914.Bytes);
public long this[int i]=>Value[i];

public static A259914Inst Instance=new A259914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259915
{
public static readonly long[] Value={ 1L,85L,1L,273L,34L,85L,10L,364L,250L,17L,2L,2223L,204L,5L,34L,546L,10L,60L,680L,60L,10L,1L,5L,364L,48L,34L,40L,451L,136L,17L,10L,273L,2L,5L,2L,5089L,10570L,1020L,451L,10L,60L,5L,1970L,114L,114L,17L,2L,4446L,185L,8L,10L,17L,5L,546L,17L,285L,63L,204L,8L,540L,816L,5L,57L,147744L,2761L,1L,505L,451L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259915Inst : IEnumerable<long>
{
public static readonly long[] Value=A259915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259915.Bytes);
public long this[int i]=>Value[i];

public static A259915Inst Instance=new A259915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259916
{
public static readonly long[] Value={ 1L,1L,210L,3L,1L,170L,81L,1L,70L,1L,400L,1L,210L,81L,357L,3L,1L,119L,3L,3L,3L,651L,1990L,170L,66L,70L,210L,884L,3810L,357L,1066L,1L,217L,1L,81L,3L,1L,3L,70L,1L,22L,3L,1624L,217L,119L,3383L,11510L,1L,364L,22L,210L,81L,8743L,170L,510L,81L,1L,1270L,2902L,1L,385L,1155L,1L,3L,357L,217L,966L,3L,4179L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259916Inst : IEnumerable<long>
{
public static readonly long[] Value=A259916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259916.Bytes);
public long this[int i]=>Value[i];

public static A259916Inst Instance=new A259916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259917
{
public static readonly long[] Value={ 6L,28L,30L,140L,80L,200L,40L,224L,12L,234L,84L,270L,66L,308L,78L,364L,102L,476L,496L,114L,532L,240L,600L,138L,644L,120L,672L,150L,700L,174L,812L,135L,819L,186L,868L,864L,936L,222L,1036L,246L,1148L,60L,1170L,258L,1204L,282L,1316L,560L,1400L,318L,1484L,1488L,330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259917Inst : IEnumerable<long>
{
public static readonly long[] Value=A259917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259917.Bytes);
public long this[int i]=>Value[i];

public static A259917Inst Instance=new A259917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259918
{
public static readonly long[] Value={ 6L,30L,80L,40L,12L,84L,66L,78L,102L,114L,240L,138L,120L,150L,174L,135L,186L,864L,222L,246L,60L,258L,282L,560L,318L,330L,354L,366L,720L,390L,402L,426L,360L,438L,880L,474L,498L,510L,440L,534L,132L,1040L,570L,582L,606L,618L,520L,924L,642L,654L,678L,690L,540L,726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259918Inst : IEnumerable<long>
{
public static readonly long[] Value=A259918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259918.Bytes);
public long this[int i]=>Value[i];

public static A259918Inst Instance=new A259918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259919
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,351L,11275L,689146L,76718466L,15016410213L,5018597151979L,2793390337774000L,2534303740130716491L,BigInteger.Parse("3677548139455638020060"),BigInteger.Parse("8393668597786379602398164"),BigInteger.Parse("29683833854927200499142474520"),BigInteger.Parse("160463839044675821511377573062150"),BigInteger.Parse("1309702228155431081923017737636343876") };
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
public class A259919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259919Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259919.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259919.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259919Inst Instance=new A259919Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259920
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,0L,1L,1L,2L,1L,2L,1L,3L,2L,2L,2L,3L,1L,3L,2L,5L,3L,5L,2L,6L,3L,6L,3L,7L,4L,7L,5L,9L,5L,9L,5L,11L,6L,11L,7L,14L,7L,15L,9L,17L,9L,17L,9L,21L,11L,21L,12L,25L,13L,25L,15L,29L,16L,31L,17L,35L,19L,37L,21L,42L,22L,44L,25L,49L,27L,52L,29L,58L,32L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259920Inst : IEnumerable<long>
{
public static readonly long[] Value=A259920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259920.Bytes);
public long this[int i]=>Value[i];

public static A259920Inst Instance=new A259920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259921
{
public static readonly long[] Value={ 1L,3L,5L,15L,30L,40L,50L,103L,105L,115L,130L,140L,150L,204L,214L,240L,250L,316L,317L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259921Inst : IEnumerable<long>
{
public static readonly long[] Value=A259921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259921.Bytes);
public long this[int i]=>Value[i];

public static A259921Inst Instance=new A259921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259922
{
public static readonly long[] Value={ 0L,-1L,-1L,-2L,2L,1L,1L,1L,-3L,-4L,-2L,-3L,1L,1L,-1L,-2L,6L,6L,6L,6L,3L,2L,4L,3L,3L,3L,1L,1L,5L,4L,4L,4L,4L,3L,3L,2L,3L,3L,3L,2L,8L,7L,9L,9L,6L,6L,8L,8L,3L,3L,1L,0L,4L,3L,1L,1L,-3L,-3L,-1L,-1L,3L,3L,3L,2L,2L,1L,3L,3L,0L,-1L,1L,1L,7L,7L,5L,4L,4L,4L,4L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259922Inst : IEnumerable<long>
{
public static readonly long[] Value=A259922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259922.Bytes);
public long this[int i]=>Value[i];

public static A259922Inst Instance=new A259922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259923
{
public static readonly long[] Value={ 1L,3L,25L,49L,1331L,2197L,83521L,130321L,279841L,707281L,28629151L,69343957L,4750104241L,6321363049L,10779215329L,22164361129L,2488651484819L,3142742836021L,406067677556641L,645753531245761L,806460091894081L,1517108809906561L,186940255267540403L,350356403707485209L,760231058654565217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259923Inst : IEnumerable<long>
{
public static readonly long[] Value=A259923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259923.Bytes);
public long this[int i]=>Value[i];

public static A259923Inst Instance=new A259923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259924
{
public static readonly long[] Value={ 1L,780L,1064L,1289560L,1428228L,18107748L,186000889725L,680691912588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259924Inst : IEnumerable<long>
{
public static readonly long[] Value=A259924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259924.Bytes);
public long this[int i]=>Value[i];

public static A259924Inst Instance=new A259924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259925
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,125L,14641L,2476099L,594823321L,194754273881L,83733937890625L,45848500718449031L,BigInteger.Parse("31181719929966183601"),BigInteger.Parse("25804264053054077850709"),BigInteger.Parse("25542038069936263923006961"),BigInteger.Parse("29806575070123343006591796875"),BigInteger.Parse("40504199006061377874300161158921") };
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
public class A259925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259925Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259925.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259925.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259925Inst Instance=new A259925Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259926
{
public static readonly BigInteger[] Value={ 0L,8L,486L,49152L,7812500L,1813985280L,581334062442L,246290604621824L,133417453597332552L,BigInteger.Parse("90000000000000000000"),BigInteger.Parse("74002499442581601012110"),BigInteger.Parse("72872109936441607122321408"),BigInteger.Parse("84676920178401799992368876316"),BigInteger.Parse("114656931713301654695784797437952"),BigInteger.Parse("178967655284025147557258605957031250") };
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
public class A259926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259926Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259926.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259926.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259926Inst Instance=new A259926Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259927
{
public static readonly long[] Value={ 4L,2L,7L,5L,9L,7L,7L,3L,6L,4L,4L,9L,1L,8L,5L,0L,9L,4L,1L,9L,9L,1L,6L,7L,1L,4L,9L,0L,1L,6L,0L,6L,7L,2L,9L,9L,2L,8L,1L,9L,1L,7L,9L,1L,5L,7L,3L,1L,0L,3L,5L,1L,1L,2L,2L,8L,9L,0L,2L,5L,4L,9L,7L,8L,9L,4L,2L,5L,1L,6L,7L,3L,2L,2L,9L,3L,9L,6L,2L,0L,4L,0L,8L,3L,4L,1L,9L,1L,2L,0L,5L,7L,9L,9L,8L,2L,3L,1L,0L,1L,2L,9L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259927Inst : IEnumerable<long>
{
public static readonly long[] Value=A259927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259927.Bytes);
public long this[int i]=>Value[i];

public static A259927Inst Instance=new A259927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259928
{
public static readonly long[] Value={ 1L,6L,9L,5L,5L,7L,1L,7L,6L,9L,9L,7L,4L,0L,8L,1L,8L,9L,9L,5L,2L,4L,1L,9L,6L,5L,4L,9L,6L,5L,1L,5L,3L,4L,2L,1L,3L,1L,6L,9L,6L,9L,5L,8L,1L,6L,7L,2L,1L,4L,2L,2L,6L,0L,3L,0L,7L,0L,6L,8L,1L,1L,0L,6L,6L,7L,3L,8L,8L,6L,9L,7L,1L,5L,0L,3L,2L,6L,3L,1L,6L,3L,1L,3L,7L,9L,5L,6L,6L,2L,9L,8L,9L,7L,5L,5L,8L,6L,1L,7L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259928Inst : IEnumerable<long>
{
public static readonly long[] Value=A259928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259928.Bytes);
public long this[int i]=>Value[i];

public static A259928Inst Instance=new A259928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259929
{
public static readonly long[] Value={ 1L,0L,1L,6L,7L,9L,7L,7L,3L,8L,2L,7L,6L,8L,8L,8L,1L,7L,7L,0L,4L,4L,6L,3L,7L,4L,7L,3L,1L,6L,2L,4L,5L,5L,4L,3L,5L,5L,6L,6L,8L,8L,2L,7L,7L,5L,1L,2L,3L,4L,7L,3L,8L,7L,2L,6L,3L,1L,9L,3L,0L,6L,2L,0L,8L,3L,1L,7L,5L,5L,0L,9L,8L,4L,4L,0L,6L,3L,9L,0L,4L,0L,9L,9L,8L,6L,0L,8L,0L,6L,8L,8L,3L,3L,9L,9L,8L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259929Inst : IEnumerable<long>
{
public static readonly long[] Value=A259929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259929.Bytes);
public long this[int i]=>Value[i];

public static A259929Inst Instance=new A259929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259930
{
public static readonly long[] Value={ 1L,4L,1L,8L,6L,8L,1L,3L,1L,8L,7L,8L,3L,7L,3L,8L,1L,8L,3L,5L,6L,9L,7L,5L,7L,3L,9L,7L,7L,2L,7L,1L,5L,3L,3L,3L,3L,5L,9L,7L,8L,5L,4L,8L,5L,6L,7L,2L,3L,7L,8L,0L,1L,0L,0L,1L,9L,1L,6L,8L,2L,2L,1L,9L,3L,2L,3L,3L,5L,3L,3L,8L,9L,8L,9L,2L,7L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259930Inst : IEnumerable<long>
{
public static readonly long[] Value=A259930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259930.Bytes);
public long this[int i]=>Value[i];

public static A259930Inst Instance=new A259930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259931
{
public static readonly long[] Value={ 0L,6L,2L,8L,7L,2L,2L,9L,4L,0L,9L,4L,1L,9L,7L,0L,1L,4L,8L,9L,9L,7L,6L,9L,1L,8L,9L,3L,0L,8L,7L,5L,0L,6L,2L,6L,6L,1L,6L,0L,3L,2L,7L,8L,9L,3L,1L,9L,9L,4L,8L,0L,4L,3L,8L,2L,1L,3L,1L,0L,5L,0L,8L,6L,5L,9L,6L,8L,8L,8L,4L,7L,1L,2L,3L,5L,8L,5L,7L,2L,1L,4L,9L,7L,5L,5L,2L,9L,5L,0L,0L,7L,7L,1L,0L,4L,3L,0L,7L,7L,8L,4L,1L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259931Inst : IEnumerable<long>
{
public static readonly long[] Value=A259931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259931.Bytes);
public long this[int i]=>Value[i];

public static A259931Inst Instance=new A259931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259932
{
public static readonly long[] Value={ 3L,5L,13L,41L,113L,761L,1201L,1741L,1861L,2113L,9661L,9941L,12641L,13613L,15313L,21841L,23981L,30013L,34061L,47741L,49613L,60901L,70313L,83641L,101701L,237361L,241513L,252761L,303421L,335381L,377581L,413141L,489061L,491041L,525313L,529421L,637321L,695021L,718801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259932Inst : IEnumerable<long>
{
public static readonly long[] Value=A259932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259932.Bytes);
public long this[int i]=>Value[i];

public static A259932Inst Instance=new A259932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259933
{
public static readonly long[] Value={ 220L,284L,1184L,1210L,2620L,2924L,5020L,5564L,6232L,6368L,10744L,10856L,12285L,14595L,17296L,18416L,66928L,66992L,67095L,71145L,63020L,76084L,69615L,87633L,79750L,88730L,100485L,124155L,122368L,123152L,122265L,139815L,141664L,153176L,142310L,168730L,171856L,176336L,176272L,180848L,185368L,203432L,196724L,202444L,280540L,365084L,308620L,389924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259933Inst : IEnumerable<long>
{
public static readonly long[] Value=A259933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259933.Bytes);
public long this[int i]=>Value[i];

public static A259933Inst Instance=new A259933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259934
{
public static readonly long[] Value={ 0L,2L,6L,12L,18L,22L,30L,34L,42L,46L,54L,58L,62L,70L,78L,90L,94L,102L,106L,114L,118L,121L,125L,129L,144L,152L,162L,166L,174L,182L,190L,194L,210L,214L,222L,230L,236L,242L,250L,254L,270L,274L,282L,294L,298L,302L,310L,314L,330L,342L,346L,354L,358L,366L,374L,390L,394L,402L,410L,418L,426L,434L,442L,446L,462L,466L,474L,486L,494L,510L,522L,530L,546L,558L,562L,566L,574L,582L,590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259934Inst : IEnumerable<long>
{
public static readonly long[] Value=A259934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259934.Bytes);
public long this[int i]=>Value[i];

public static A259934Inst Instance=new A259934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259935
{
public static readonly long[] Value={ 2L,4L,6L,6L,4L,8L,4L,8L,4L,8L,4L,4L,8L,8L,12L,4L,8L,4L,8L,4L,3L,4L,4L,15L,8L,10L,4L,8L,8L,8L,4L,16L,4L,8L,8L,6L,6L,8L,4L,16L,4L,8L,12L,4L,4L,8L,4L,16L,12L,4L,8L,4L,8L,8L,16L,4L,8L,8L,8L,8L,8L,8L,4L,16L,4L,8L,12L,8L,16L,12L,8L,16L,12L,4L,4L,8L,8L,8L,8L,8L,24L,8L,12L,8L,4L,8L,8L,8L,16L,8L,6L,6L,8L,4L,8L,4L,8L,8L,12L,8L,18L,8L,32L,24L,18L,4L,8L,16L,4L,16L,4L,8L,12L,8L,8L,8L,8L,8L,8L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259935Inst : IEnumerable<long>
{
public static readonly long[] Value=A259935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259935.Bytes);
public long this[int i]=>Value[i];

public static A259935Inst Instance=new A259935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259936
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,2L,1L,2L,1L,5L,1L,1L,2L,2L,2L,2L,1L,2L,2L,2L,1L,5L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,5L,1L,2L,2L,1L,2L,5L,1L,2L,2L,5L,1L,2L,1L,2L,2L,2L,2L,5L,1L,2L,1L,2L,1L,5L,2L,2L,2L,2L,1L,5L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,5L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259936Inst : IEnumerable<long>
{
public static readonly long[] Value=A259936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259936.Bytes);
public long this[int i]=>Value[i];

public static A259936Inst Instance=new A259936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259937
{
public static readonly BigInteger[] Value={ 11L,1221L,123321L,12344321L,1234554321L,123456654321L,12345677654321L,1234567887654321L,123456789987654321L,BigInteger.Parse("1234567891010987654321"),BigInteger.Parse("12345678910111110987654321"),BigInteger.Parse("123456789101112121110987654321") };
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
public class A259937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259937Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259937.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259937.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259937Inst Instance=new A259937Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259938
{
public static readonly long[] Value={ 0L,1L,0L,0L,-1L,0L,0L,4L,0L,-1L,-22L,0L,13L,140L,0L,-136L,-970L,9L,1330L,7104L,-231L,-12650L,-54096L,3900L,118780L,423890L,-54810L,-1108380L,-3393696L,695640L,10311840L,27615648L,-8282604L,-95810606L,-227480848L,94449456L,889817328L,1890685212L,-1044402840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259938Inst : IEnumerable<long>
{
public static readonly long[] Value=A259938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259938.Bytes);
public long this[int i]=>Value[i];

public static A259938Inst Instance=new A259938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259939
{
public static readonly long[] Value={ 1L,2L,4L,6L,16L,18L,64L,42L,100L,162L,1024L,234L,4096L,1088L,1936L,798L,65536L,2300L,262144L,4698L,18496L,31744L,4194304L,8658L,234256L,167936L,52900L,46784L,268435456L,90992L,1073741824L,42294L,984064L,3866624L,5345344L,140300L,68719476736L,17563648L,6885376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259939Inst : IEnumerable<long>
{
public static readonly long[] Value=A259939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259939.Bytes);
public long this[int i]=>Value[i];

public static A259939Inst Instance=new A259939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259940
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,3L,2L,3L,2L,4L,1L,3L,2L,1L,1L,4L,4L,5L,2L,5L,3L,5L,8L,5L,5L,8L,6L,7L,7L,6L,7L,6L,6L,5L,8L,7L,8L,7L,11L,12L,6L,12L,8L,11L,12L,8L,11L,9L,8L,10L,13L,11L,6L,10L,8L,12L,11L,13L,12L,10L,17L,9L,8L,10L,13L,11L,15L,11L,9L,8L,14L,13L,12L,8L,8L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259940Inst : IEnumerable<long>
{
public static readonly long[] Value=A259940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259940.Bytes);
public long this[int i]=>Value[i];

public static A259940Inst Instance=new A259940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259941
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,18L,30L,42L,84L,126L,198L,234L,390L,510L,714L,798L,1596L,1932L,2898L,3654L,5382L,6138L,7254L,8658L,14430L,15990L,20910L,21930L,30702L,33558L,37506L,42294L,84588L,94164L,113988L,117852L,176778L,194166L,244818L,259434L,382122L,392886L,448074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259941Inst : IEnumerable<long>
{
public static readonly long[] Value=A259941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259941.Bytes);
public long this[int i]=>Value[i];

public static A259941Inst Instance=new A259941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259942
{
public static readonly long[] Value={ 1L,64L,96L,108L,128L,144L,162L,192L,216L,240L,243L,256L,270L,288L,300L,320L,324L,360L,384L,400L,405L,432L,448L,450L,480L,486L,500L,504L,512L,540L,560L,567L,576L,600L,625L,630L,640L,648L,672L,675L,700L,720L,729L,750L,756L,768L,784L,800L,810L,840L,864L,875L,882L,896L,900L,945L,960L,972L,980L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259942Inst : IEnumerable<long>
{
public static readonly long[] Value=A259942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259942.Bytes);
public long this[int i]=>Value[i];

public static A259942Inst Instance=new A259942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259943
{
public static readonly long[] Value={ 1L,2L,3L,9L,31L,169L,53281L,10984777L,12245367L,19806045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259943Inst : IEnumerable<long>
{
public static readonly long[] Value=A259943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259943.Bytes);
public long this[int i]=>Value[i];

public static A259943Inst Instance=new A259943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259944
{
public static readonly BigInteger[] Value={ 34L,170L,2438L,35765L,631626L,23837974L,1328499316L,84928425026L,8289133572645L,1383570023331554L,315562185885124651L,BigInteger.Parse("97230004567350401711"),BigInteger.Parse("46436802280752701742859"),BigInteger.Parse("33623534290696312179717952") };
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
public class A259944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259944Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259944.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259944.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259944Inst Instance=new A259944Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259945
{
public static readonly long[] Value={ 34L,60L,156L,365L,801L,1825L,4272L,9840L,22444L,51509L,118673L,272721L,625828L,1437556L,3303988L,7590621L,17435081L,40053457L,92021928L,211404824L,485651892L,1115697125L,2563141785L,5888362641L,13527406476L,31076799084L,71393512556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259945Inst : IEnumerable<long>
{
public static readonly long[] Value=A259945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259945.Bytes);
public long this[int i]=>Value[i];

public static A259945Inst Instance=new A259945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259946
{
public static readonly long[] Value={ 60L,170L,549L,1507L,4128L,11933L,34337L,97374L,277073L,791655L,2258776L,6438153L,18360749L,52375446L,149376869L,426006811L,1215002568L,3465304429L,9883190601L,28187259534L,80391677785L,229281523567L,653922541496L,1865020964353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259946Inst : IEnumerable<long>
{
public static readonly long[] Value=A259946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259946.Bytes);
public long this[int i]=>Value[i];

public static A259946Inst Instance=new A259946Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259947
{
public static readonly long[] Value={ 156L,549L,2438L,8699L,30351L,115410L,438353L,1615572L,5983278L,22387088L,83497726L,310419235L,1155916673L,4308316980L,16046423584L,59751346761L,222558385418L,829007147866L,3087623758483L,11499815151619L,42832625165165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259947Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259947.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259947Inst : IEnumerable<long>
{
public static readonly long[] Value=A259947.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259947.Bytes);
public long this[int i]=>Value[i];

public static A259947Inst Instance=new A259947Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259948
{
public static readonly long[] Value={ 365L,1507L,8699L,35765L,141619L,642779L,2922457L,12595119L,54554391L,241207419L,1062079283L,4640861117L,20328211369L,89287996191L,391693962409L,1716670831027L,7528074602903L,33022954863143L,144821506333677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259948Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259948.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259948Inst : IEnumerable<long>
{
public static readonly long[] Value=A259948.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259948.Bytes);
public long this[int i]=>Value[i];

public static A259948Inst Instance=new A259948Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259949
{
public static readonly long[] Value={ 801L,4128L,30351L,141619L,631626L,3451108L,18564547L,92159926L,465579244L,2426793925L,12493718508L,63615992133L,326137871580L,1677931148622L,8603497730864L,44072130840744L,226114843492646L,1160274814296495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259949Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259949.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259949Inst : IEnumerable<long>
{
public static readonly long[] Value=A259949.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259949.Bytes);
public long this[int i]=>Value[i];

public static A259949Inst Instance=new A259949Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259950
{
public static readonly long[] Value={ 1825L,11933L,115410L,642779L,3451108L,23837974L,159480543L,966996539L,6037654361L,39151910960L,248955579353L,1563130986904L,9919615680532L,63174059976509L,400236775086261L,2534156948462237L,16083216111856324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259950Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259950.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259950Inst : IEnumerable<long>
{
public static readonly long[] Value=A259950.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259950.Bytes);
public long this[int i]=>Value[i];

public static A259950Inst Instance=new A259950Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259951
{
public static readonly long[] Value={ 4272L,34337L,438353L,2922457L,18564547L,159480543L,1328499316L,9776128436L,74163783119L,592385188191L,4627839825704L,35461188831863L,275231652348618L,2150568911134569L,16689842413232772L,129272181984273768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259951Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259951.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259951Inst : IEnumerable<long>
{
public static readonly long[] Value=A259951.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259951.Bytes);
public long this[int i]=>Value[i];

public static A259951Inst Instance=new A259951Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259952
{
public static readonly long[] Value={ 34L,60L,60L,156L,170L,156L,365L,549L,549L,365L,801L,1507L,2438L,1507L,801L,1825L,4128L,8699L,8699L,4128L,1825L,4272L,11933L,30351L,35765L,30351L,11933L,4272L,9840L,34337L,115410L,141619L,141619L,115410L,34337L,9840L,22444L,97374L,438353L,642779L,631626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259952Inst : IEnumerable<long>
{
public static readonly long[] Value=A259952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259952.Bytes);
public long this[int i]=>Value[i];

public static A259952Inst Instance=new A259952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259953
{
public static readonly long[] Value={ 504L,2394L,5544L,10584L,12600L,21600L,26880L,35712L,133920L,138240L,139104L,157248L,168480L,224640L,245520L,262080L,294840L,311040L,348192L,357120L,388800L,399168L,645624L,698544L,749952L,756000L,892800L,955206L,1017792L,1048320L,1270080L,1296000L,1296000L,1315440L,1347840L,1451520L,1522800L,1666560L,1781136L,1879200L,2041200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259953Inst : IEnumerable<long>
{
public static readonly long[] Value=A259953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259953.Bytes);
public long this[int i]=>Value[i];

public static A259953Inst Instance=new A259953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259954
{
public static readonly BigInteger[] Value={ 34L,146L,1603L,22622L,501606L,17818241L,949570630L,77682624194L,9896025788402L,1940408456200141L,584639553275100018L,BigInteger.Parse("271649247842334658120"),BigInteger.Parse("194639319999547441935265"),BigInteger.Parse("214876443861835390451767918") };
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
public class A259954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259954Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259954.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259954.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259954Inst Instance=new A259954Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259955
{
public static readonly long[] Value={ 34L,67L,155L,353L,808L,1884L,4340L,9925L,22799L,52515L,120848L,277830L,638728L,1468871L,3378335L,7769445L,17866796L,41087200L,94488464L,217296769L,499716771L,1149192279L,2642787772L,6077609506L,13976655996L,32142038875L,73916854091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259955Inst : IEnumerable<long>
{
public static readonly long[] Value=A259955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259955.Bytes);
public long this[int i]=>Value[i];

public static A259955Inst Instance=new A259955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259956
{
public static readonly long[] Value={ 67L,146L,439L,1187L,3227L,8964L,24719L,67952L,187266L,516133L,1421669L,3916441L,10790266L,29726787L,81895288L,225619582L,621575781L,1712418521L,4717655719L,12996990098L,35806276733L,98645103102L,271764008258L,748700872883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259956Inst : IEnumerable<long>
{
public static readonly long[] Value=A259956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259956.Bytes);
public long this[int i]=>Value[i];

public static A259956Inst Instance=new A259956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259957
{
public static readonly long[] Value={ 155L,439L,1603L,5449L,18681L,64891L,222813L,764865L,2637815L,9090487L,31281933L,107674395L,370788133L,1276814309L,4396089911L,15135449051L,52112945503L,179433951141L,617811988681L,2127175449173L,7324071255063L,25217614284475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259957Inst : IEnumerable<long>
{
public static readonly long[] Value=A259957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259957.Bytes);
public long this[int i]=>Value[i];

public static A259957Inst Instance=new A259957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259958
{
public static readonly long[] Value={ 353L,1187L,5449L,22622L,95505L,410928L,1749180L,7428045L,31652938L,134864351L,574177723L,2444862662L,10411688737L,44337641182L,188806035352L,804008747575L,3423786528448L,14579849166047L,62086786721703L,264389995026138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259958Inst : IEnumerable<long>
{
public static readonly long[] Value=A259958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259958.Bytes);
public long this[int i]=>Value[i];

public static A259958Inst Instance=new A259958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259959
{
public static readonly long[] Value={ 808L,3227L,18681L,95505L,501606L,2680028L,14134043L,74413321L,393674107L,2081832486L,10993767973L,58065668063L,306806287833L,1621097081522L,8564539558608L,45246470436052L,239045296359362L,1262950320065087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259959Inst : IEnumerable<long>
{
public static readonly long[] Value=A259959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259959.Bytes);
public long this[int i]=>Value[i];

public static A259959Inst Instance=new A259959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259960
{
public static readonly long[] Value={ 1884L,8964L,64891L,410928L,2680028L,17818241L,116786951L,764080109L,5022583984L,33001259193L,216587128266L,1421771125112L,9335402267913L,61293735086483L,402419214454459L,2642049905522258L,17346319866667679L,113887504201096832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259960Inst : IEnumerable<long>
{
public static readonly long[] Value=A259960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259960.Bytes);
public long this[int i]=>Value[i];

public static A259960Inst Instance=new A259960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259961
{
public static readonly long[] Value={ 4340L,24719L,222813L,1749180L,14134043L,116786951L,949570630L,7710610630L,62925603555L,513205618429L,4180135367174L,34056790238843L,277562650126608L,2262047716475526L,18433280706881961L,150209059442436392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259961Inst : IEnumerable<long>
{
public static readonly long[] Value=A259961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259961.Bytes);
public long this[int i]=>Value[i];

public static A259961Inst Instance=new A259961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259962
{
public static readonly long[] Value={ 34L,67L,67L,155L,146L,155L,353L,439L,439L,353L,808L,1187L,1603L,1187L,808L,1884L,3227L,5449L,5449L,3227L,1884L,4340L,8964L,18681L,22622L,18681L,8964L,4340L,9925L,24719L,64891L,95505L,95505L,64891L,24719L,9925L,22799L,67952L,222813L,410928L,501606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259962Inst : IEnumerable<long>
{
public static readonly long[] Value=A259962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259962.Bytes);
public long this[int i]=>Value[i];

public static A259962Inst Instance=new A259962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259963
{
public static readonly long[] Value={ 11L,44L,52L,71L,84L,92L,136L,208L,252L,284L,291L,296L,436L,444L,468L,491L,601L,704L,832L,918L,933L,976L,1164L,1169L,1184L,1276L,1291L,1558L,1684L,1699L,1708L,1724L,1837L,1856L,2028L,2080L,2123L,2389L,2412L,2536L,2619L,2624L,2664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259963Inst : IEnumerable<long>
{
public static readonly long[] Value=A259963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259963.Bytes);
public long this[int i]=>Value[i];

public static A259963Inst Instance=new A259963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259964
{
public static readonly long[] Value={ 1L,2L,4L,8L,13L,21L,31L,45L,66L,81L,97L,123L,148L,182L,229L,257L,290L,312L,381L,419L,467L,507L,621L,721L,770L,864L,927L,1050L,1178L,1289L,1457L,1561L,1615L,1774L,1907L,2090L,2164L,2263L,2309L,2539L,2800L,2938L,3035L,3310L,3380L,3738L,4043L,4239L,4439L,4726L,4851L,5016L,5169L,5289L,5490L,5760L,6646L,6843L,7015L,7442L,7674L,7986L,8284L,8506L,8772L,9240L,9778L,9996L,10344L,10431L,11614L,12263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259964Inst : IEnumerable<long>
{
public static readonly long[] Value=A259964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259964.Bytes);
public long this[int i]=>Value[i];

public static A259964Inst Instance=new A259964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259965
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,2L,0L,1L,0L,2L,1L,2L,0L,1L,2L,1L,3L,2L,2L,0L,1L,0L,4L,3L,4L,2L,2L,0L,1L,3L,3L,7L,4L,5L,2L,2L,0L,1L,1L,8L,6L,10L,5L,5L,2L,2L,0L,1L,5L,7L,14L,10L,11L,6L,5L,2L,2L,0L,1L,2L,15L,15L,19L,13L,12L,6L,5L,2L,2L,0L,1L,10L,15L,26L,23L,24L,14L,13L,6L,5L,2L,2L,0L,1L,5L,28L,31L,38L,29L,27L,15L,13L,6L,5L,2L,2L,0L,1L,16L,30L,51L,47L,48L,34L,28L,16L,13L,6L,5L,2L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259965Inst : IEnumerable<long>
{
public static readonly long[] Value=A259965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259965.Bytes);
public long this[int i]=>Value[i];

public static A259965Inst Instance=new A259965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259966
{
public static readonly long[] Value={ 0L,0L,2L,7L,16L,34L,72L,149L,300L,593L,1158L,2239L,4292L,8168L,15450L,29072L,54456L,101597L,188878L,350038L,646880L,1192415L,2192956L,4024583L,7371884L,13479421L,24607048L,44853552L,81645236L,148424000L,269497614L,488784787L,885571340L,1602879242L,2898512344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259966Inst : IEnumerable<long>
{
public static readonly long[] Value=A259966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259966.Bytes);
public long this[int i]=>Value[i];

public static A259966Inst Instance=new A259966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259967
{
public static readonly long[] Value={ 3L,2L,2L,5L,10L,17L,29L,51L,90L,158L,277L,486L,853L,1497L,2627L,4610L,8090L,14197L,24914L,43721L,76725L,134643L,236282L,414646L,727653L,1276942L,2240877L,3932465L,6900995L,12110402L,21252274L,37295141L,65448410L,114853953L,201554637L,353703731L,620706778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259967Inst : IEnumerable<long>
{
public static readonly long[] Value=A259967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259967.Bytes);
public long this[int i]=>Value[i];

public static A259967Inst Instance=new A259967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259968
{
public static readonly long[] Value={ 1L,1L,3L,6L,10L,17L,30L,53L,93L,163L,286L,502L,881L,1546L,2713L,4761L,8355L,14662L,25730L,45153L,79238L,139053L,244021L,428227L,751486L,1318766L,2314273L,4061266L,7127025L,12507057L,21948355L,38516678L,67592058L,118615793L,208156206L,365288677L,641036941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259968Inst : IEnumerable<long>
{
public static readonly long[] Value=A259968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259968.Bytes);
public long this[int i]=>Value[i];

public static A259968Inst Instance=new A259968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259969
{
public static readonly long[] Value={ 0L,1L,2L,9L,24L,50L,102L,210L,424L,837L,1630L,3146L,6024L,11453L,21644L,40695L,76176L,142035L,263916L,488870L,903060L,1663998L,3059166L,5612483L,10277448L,18787150L,34287916L,62485371L,113715448L,206683725L,375211710L,680399005L,1232533696L,2230537914L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259969Inst : IEnumerable<long>
{
public static readonly long[] Value=A259969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259969.Bytes);
public long this[int i]=>Value[i];

public static A259969Inst Instance=new A259969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259970
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,3L,6L,28L,42L,21L,91L,510L,1050L,945L,315L,2820L,18631L,48360L,61845L,39060L,9765L,177661L,1351413L,4220433L,6942915L,6357015L,3075975L,615195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259970Inst : IEnumerable<long>
{
public static readonly long[] Value=A259970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259970.Bytes);
public long this[int i]=>Value[i];

public static A259970Inst Instance=new A259970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259971
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,3L,10L,40L,51L,21L,122L,644L,1236L,1029L,315L,3346L,21496L,54060L,66780L,40635L,9765L,196082L,1471460L,4527228L,7328580L,6596100L,3134565L,615195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259971Inst : IEnumerable<long>
{
public static readonly long[] Value=A259971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259971.Bytes);
public long this[int i]=>Value[i];

public static A259971Inst Instance=new A259971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259972
{
public static readonly long[] Value={ 1L,2L,1L,5L,7L,3L,20L,58L,60L,21L,179L,838L,1458L,1113L,315L,4082L,25171L,60780L,72135L,42210L,9765L,218225L,1610977L,4871193L,7745115L,6844635L,3193155L,615195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259972Inst : IEnumerable<long>
{
public static readonly long[] Value=A259972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259972.Bytes);
public long this[int i]=>Value[i];

public static A259972Inst Instance=new A259972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259973
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,11L,23L,27L,29L,32L,41L,50L,53L,57L,83L,85L,89L,111L,113L,128L,131L,161L,173L,179L,191L,215L,233L,237L,239L,245L,251L,265L,275L,281L,293L,319L,355L,359L,365L,391L,413L,419L,431L,437L,443L,453L,481L,485L,491L,493L,505L,509L,511L,535L,589L,593L,603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259973Inst : IEnumerable<long>
{
public static readonly long[] Value=A259973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259973.Bytes);
public long this[int i]=>Value[i];

public static A259973Inst Instance=new A259973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259974
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,2L,3L,8L,3L,3L,14L,7L,7L,14L,42L,14L,11L,14L,81L,36L,28L,36L,81L,262L,81L,57L,57L,81L,538L,221L,155L,155L,221L,538L,1828L,538L,353L,316L,353L,538L,3926L,1530L,1003L,902L,1003L,1530L,3926L,13820L,3926L,2458L,2053L,2053L,2458L,3926L,30694L,11510L,7214L,6059L,6059L,7214L,11510L,30694L,110954L,30694L,18575L,14810L,13827L,14810L,18575L,30694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259974Inst : IEnumerable<long>
{
public static readonly long[] Value=A259974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259974.Bytes);
public long this[int i]=>Value[i];

public static A259974Inst Instance=new A259974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259975
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,1L,1L,6L,4L,1L,7L,9L,1L,8L,16L,1L,9L,25L,15L,1L,1L,10L,35L,40L,8L,1L,11L,46L,76L,31L,1L,12L,58L,124L,85L,1L,13L,71L,185L,190L,35L,1L,1L,14L,85L,260L,360L,154L,13L,1L,15L,100L,350L,610L,424L,76L,1L,16L,116L,456L,956L,930L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259975Inst : IEnumerable<long>
{
public static readonly long[] Value=A259975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259975.Bytes);
public long this[int i]=>Value[i];

public static A259975Inst Instance=new A259975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259976
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,0L,1L,2L,2L,0L,1L,0L,1L,3L,4L,6L,6L,3L,1L,0L,1L,3L,5L,11L,20L,24L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259976Inst : IEnumerable<long>
{
public static readonly long[] Value=A259976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259976.Bytes);
public long this[int i]=>Value[i];

public static A259976Inst Instance=new A259976Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259977
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,1L,2L,2L,4L,2L,2L,2L,7L,2L,6L,4L,2L,1L,4L,2L,4L,2L,6L,2L,2L,4L,5L,2L,6L,2L,6L,4L,4L,2L,6L,3L,2L,2L,2L,2L,6L,2L,4L,2L,2L,2L,10L,4L,7L,6L,2L,2L,8L,2L,4L,4L,2L,2L,14L,1L,2L,2L,4L,2L,10L,2L,6L,2L,2L,6L,6L,2L,2L,2L,13L,2L,2L,4L,4L,4L,6L,2L,10L,2L,10L,2L,8L,6L,2L,1L,6L,4L,4L,4L,8L,2L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259977Inst : IEnumerable<long>
{
public static readonly long[] Value=A259977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259977.Bytes);
public long this[int i]=>Value[i];

public static A259977Inst Instance=new A259977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259978
{
public static readonly long[] Value={ 35L,95L,119L,143L,203L,215L,275L,299L,335L,395L,455L,515L,527L,539L,623L,635L,695L,707L,767L,779L,803L,899L,923L,935L,959L,1007L,1043L,1115L,1127L,1139L,1175L,1199L,1235L,1295L,1355L,1403L,1547L,1595L,1643L,1655L,1679L,1715L,1727L,1763L,1775L,1859L,1883L,1895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259978Inst : IEnumerable<long>
{
public static readonly long[] Value=A259978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259978.Bytes);
public long this[int i]=>Value[i];

public static A259978Inst Instance=new A259978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259979
{
public static readonly long[] Value={ 10L,26L,122L,362L,842L,3482L,3722L,5042L,6242L,10202L,17162L,19322L,32762L,39602L,73442L,121802L,143642L,167282L,201602L,212522L,271442L,323762L,326042L,398162L,410882L,436922L,546122L,564002L,674042L,776162L,863042L,982082L,1062962L,1079522L,1104602L,1142762L,1190282L,1274642L,1324802L,1371242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259979Inst : IEnumerable<long>
{
public static readonly long[] Value=A259979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259979.Bytes);
public long this[int i]=>Value[i];

public static A259979Inst Instance=new A259979Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259980
{
public static readonly long[] Value={ 12L,18L,20L,32L,44L,68L,98L,164L,212L,242L,284L,332L,338L,524L,548L,578L,692L,788L,908L,1052L,1124L,1172L,1532L,1724L,1868L,2012L,2084L,2252L,2348L,2372L,2468L,2708L,2732L,2804L,2972L,3188L,3308L,3362L,3548L,3644L,3698L,3908L,3932L,4052L,4244L,4364L,4604L,4652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259980Inst : IEnumerable<long>
{
public static readonly long[] Value=A259980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259980.Bytes);
public long this[int i]=>Value[i];

public static A259980Inst Instance=new A259980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259981
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,4L,2L,6L,7L,4L,4L,10L,6L,6L,6L,4L,6L,10L,6L,4L,8L,6L,6L,21L,2L,6L,18L,6L,4L,18L,10L,8L,10L,10L,12L,12L,6L,16L,22L,14L,6L,10L,2L,12L,21L,12L,20L,4L,10L,22L,10L,2L,12L,20L,14L,24L,8L,24L,8L,10L,28L,6L,6L,18L,10L,28L,16L,10L,6L,6L,30L,4L,24L,37L,6L,6L,46L,14L,10L,6L,18L,24L,6L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259981Inst : IEnumerable<long>
{
public static readonly long[] Value=A259981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259981.Bytes);
public long this[int i]=>Value[i];

public static A259981Inst Instance=new A259981Inst();

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