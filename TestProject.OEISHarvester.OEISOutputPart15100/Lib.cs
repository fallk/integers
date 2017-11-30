using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A085468
{
public static readonly long[] Value={ 1L,43L,45L,47L,49L,53L,97L,99L,121L,123L,169L,237L,273L,319L,329L,343L,367L,369L,375L,499L,533L,573L,581L,611L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085468Inst : IEnumerable<long>
{
public static readonly long[] Value=A085468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085468.Bytes);
public long this[int i]=>Value[i];

public static A085468Inst Instance=new A085468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085467
{
public static readonly long[] Value={ 0L,1L,-7L,1L,-4L,-25L,1L,-6L,3L,-98L,3L,-24L,36L,-8L,-1167L,3L,-30L,75L,-40L,-10L,-4650L,5L,-60L,210L,-220L,35L,-56L,-30930L,45L,-630L,2835L,-4620L,2205L,-378L,-1589L,-1111860L,315L,-5040L,27720L,-62160L,52500L,-13104L,-4424L,-36304L,-31100895L,35L,-630L,4095L,-11760L,14700L,-6888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085467Inst : IEnumerable<long>
{
public static readonly long[] Value=A085467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085467.Bytes);
public long this[int i]=>Value[i];

public static A085467Inst Instance=new A085467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085466
{
public static readonly BigInteger[] Value={ 2L,8L,32L,384L,1536L,10240L,368640L,10321920L,4587520L,297271296L,29727129600L,435997900800L,15695924428800L,116598295756800L,1523551064555520L,1371195958099968000L,5484783832399872000L,BigInteger.Parse("41440588955910144000") };
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
public class A085466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085466Inst Instance=new A085466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085465
{
public static readonly long[] Value={ 1L,15L,102L,442L,1443L,3885L,9100L,19188L,37269L,67771L,116754L,192270L,304759L,467481L,696984L,1013608L,1442025L,2011815L,2758078L,3722082L,4951947L,6503365L,8440356L,10836060L,13773565L,17346771L,21661290L,26835382L,33000927L,40304433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085465Inst : IEnumerable<long>
{
public static readonly long[] Value=A085465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085465.Bytes);
public long this[int i]=>Value[i];

public static A085465Inst Instance=new A085465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085464
{
public static readonly long[] Value={ 1L,19L,134L,586L,1919L,5173L,12124L,25572L,49677L,90343L,155650L,256334L,406315L,623273L,929272L,1351432L,1922649L,2682363L,3677374L,4962706L,6602519L,8671069L,11253716L,14447980L,18364645L,23128911L,28881594L,35780374L,44001091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085464Inst : IEnumerable<long>
{
public static readonly long[] Value=A085464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085464.Bytes);
public long this[int i]=>Value[i];

public static A085464Inst Instance=new A085464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085463
{
public static readonly long[] Value={ 1L,12L,63L,219L,594L,1365L,2786L,5202L,9063L,14938L,23529L,35685L,52416L,74907L,104532L,142868L,191709L,253080L,329251L,422751L,536382L,673233L,836694L,1030470L,1258595L,1525446L,1835757L,2194633L,2607564L,3080439L,3619560L,4231656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085463Inst : IEnumerable<long>
{
public static readonly long[] Value=A085463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085463.Bytes);
public long this[int i]=>Value[i];

public static A085463Inst Instance=new A085463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085462
{
public static readonly long[] Value={ 1L,14L,77L,273L,748L,1729L,3542L,6630L,11571L,19096L,30107L,45695L,67158L,96019L,134044L,183260L,245973L,324786L,422617L,542717L,688688L,864501L,1074514L,1323490L,1616615L,1959516L,2358279L,2819467L,3350138L,3957863L,4650744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085462Inst : IEnumerable<long>
{
public static readonly long[] Value=A085462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085462.Bytes);
public long this[int i]=>Value[i];

public static A085462Inst Instance=new A085462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085461
{
public static readonly long[] Value={ 1L,13L,70L,246L,671L,1547L,3164L,5916L,10317L,17017L,26818L,40690L,59787L,85463L,119288L,163064L,218841L,288933L,375934L,482734L,612535L,768867L,955604L,1176980L,1437605L,1742481L,2097018L,2507050L,2978851L,3519151L,4135152L,4834544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085461Inst : IEnumerable<long>
{
public static readonly long[] Value=A085461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085461.Bytes);
public long this[int i]=>Value[i];

public static A085461Inst Instance=new A085461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085460
{
public static readonly long[] Value={ 2L,43L,47L,53L,97L,367L,499L,617L,653L,661L,719L,757L,787L,971L,1093L,1109L,1163L,1249L,1283L,1447L,1579L,1657L,1663L,1733L,1993L,2099L,2141L,2251L,2287L,2311L,2333L,2557L,2591L,2593L,2621L,2879L,2917L,2957L,2963L,2971L,3253L,3301L,3499L,3719L,3733L,3767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085460Inst : IEnumerable<long>
{
public static readonly long[] Value=A085460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085460.Bytes);
public long this[int i]=>Value[i];

public static A085460Inst Instance=new A085460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085427
{
public static readonly long[] Value={ 3L,2L,1L,1L,2L,1L,2L,1L,5L,7L,5L,3L,2L,1L,5L,4L,2L,1L,2L,1L,14L,7L,26L,13L,39L,22L,11L,16L,8L,4L,2L,1L,5L,6L,3L,24L,12L,6L,3L,25L,24L,12L,6L,3L,14L,7L,20L,10L,5L,19L,11L,21L,20L,10L,5L,3L,32L,16L,8L,4L,2L,1L,12L,6L,3L,67L,63L,43L,63L,40L,20L,10L,5L,15L,12L,6L,3L,55L,47L,30L,15L,30L,15L,64L,32L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085427Inst : IEnumerable<long>
{
public static readonly long[] Value=A085427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085427.Bytes);
public long this[int i]=>Value[i];

public static A085427Inst Instance=new A085427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085426
{
public static readonly long[] Value={ 144L,169L,196L,256L,441L,625L,961L,1024L,1089L,1296L,1369L,1764L,1936L,2401L,2916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085426Inst : IEnumerable<long>
{
public static readonly long[] Value=A085426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085426.Bytes);
public long this[int i]=>Value[i];

public static A085426Inst Instance=new A085426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085425
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,3L,2L,2L,2L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,2L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,3L,3L,2L,2L,2L,3L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085425Inst : IEnumerable<long>
{
public static readonly long[] Value=A085425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085425.Bytes);
public long this[int i]=>Value[i];

public static A085425Inst Instance=new A085425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085424
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,2L,3L,3L,2L,2L,3L,2L,2L,2L,3L,3L,3L,3L,4L,1L,1L,1L,2L,2L,1L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085424Inst : IEnumerable<long>
{
public static readonly long[] Value=A085424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085424.Bytes);
public long this[int i]=>Value[i];

public static A085424Inst Instance=new A085424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085423
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085423Inst : IEnumerable<long>
{
public static readonly long[] Value=A085423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085423.Bytes);
public long this[int i]=>Value[i];

public static A085423Inst Instance=new A085423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085422
{
public static readonly long[] Value={ -1L,2L,4L,13L,40L,125L,392L,1231L,3867L,12148L,38164L,119895L,376661L,1183315L,3717493L,11678848L,36690183L,115265609L,362117590L,1137625960L,3573957358L,11227918180L,35273545269L,110815110683L,348135937628L,1093701304102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085422Inst : IEnumerable<long>
{
public static readonly long[] Value=A085422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085422.Bytes);
public long this[int i]=>Value[i];

public static A085422Inst Instance=new A085422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085421
{
public static readonly long[] Value={ 2L,1L,4L,10L,27L,73L,198L,538L,1462L,3974L,10802L,29363L,79816L,216962L,589764L,1603144L,4357797L,11845720L,32200005L,87528688L,237927642L,646754385L,1758060692L,4778904432L,12990409077L,35311592938L,95986861417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085421Inst : IEnumerable<long>
{
public static readonly long[] Value=A085421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085421.Bytes);
public long this[int i]=>Value[i];

public static A085421Inst Instance=new A085421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085420
{
public static readonly long[] Value={ 3L,7L,7L,19L,11L,29L,23L,43L,19L,71L,23L,103L,53L,43L,43L,103L,53L,191L,59L,97L,79L,233L,73L,269L,103L,173L,83L,317L,79L,577L,151L,227L,193L,239L,157L,439L,191L,233L,157L,587L,107L,467L,257L,389L,307L,967L,191L,613L,269L,421L,601L,659L,199L,353L,233L,433L,317L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085420Inst : IEnumerable<long>
{
public static readonly long[] Value=A085420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085420.Bytes);
public long this[int i]=>Value[i];

public static A085420Inst Instance=new A085420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085419
{
public static readonly long[] Value={ 101L,11L,2L,3L,11411L,5L,10601L,7L,181L,191L,101L,11L,12421L,131L,11411L,151L,16061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085419Inst : IEnumerable<long>
{
public static readonly long[] Value=A085419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085419.Bytes);
public long this[int i]=>Value[i];

public static A085419Inst Instance=new A085419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085418
{
public static readonly long[] Value={ 3L,5L,17L,11L,29L,19L,41L,127L,53L,89L,67L,107L,83L,277L,113L,233L,113L,79L,127L,157L,139L,101L,181L,113L,293L,127L,313L,257L,199L,239L,223L,163L,239L,173L,257L,467L,271L,541L,461L,383L,349L,223L,563L,787L,383L,389L,1021L,271L,647L,1489L,389L,509L,1789L,773L,983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085418Inst : IEnumerable<long>
{
public static readonly long[] Value=A085418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085418.Bytes);
public long this[int i]=>Value[i];

public static A085418Inst Instance=new A085418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085417
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,1L,3L,9L,3L,5L,3L,5L,3L,12L,4L,9L,3L,1L,3L,4L,3L,1L,4L,1L,7L,1L,7L,5L,3L,4L,3L,1L,3L,1L,3L,8L,3L,9L,7L,5L,4L,1L,8L,12L,4L,4L,15L,1L,8L,21L,3L,5L,24L,9L,12L,8L,3L,4L,3L,9L,11L,4L,3L,5L,48L,1L,7L,33L,3L,1L,3L,1L,15L,12L,3L,5L,8L,5L,3L,36L,19L,1L,3L,5L,11L,5L,12L,5L,4L,4L,3L,1L,3L,5L,3L,1L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085417Inst : IEnumerable<long>
{
public static readonly long[] Value=A085417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085417.Bytes);
public long this[int i]=>Value[i];

public static A085417Inst Instance=new A085417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085416
{
public static readonly long[] Value={ 3L,13L,11L,13L,17L,19L,23L,29L,29L,107L,37L,43L,47L,53L,53L,59L,137L,67L,73L,107L,79L,89L,89L,167L,103L,107L,109L,113L,137L,149L,137L,137L,173L,149L,227L,157L,163L,173L,173L,179L,257L,191L,197L,199L,233L,227L,239L,229L,233L,239L,239L,317L,251L,257L,263L,269L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085416Inst : IEnumerable<long>
{
public static readonly long[] Value=A085416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085416.Bytes);
public long this[int i]=>Value[i];

public static A085416Inst Instance=new A085416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085415
{
public static readonly long[] Value={ 1L,4L,3L,3L,3L,3L,3L,4L,3L,12L,3L,3L,3L,4L,3L,3L,12L,3L,3L,8L,3L,4L,3L,12L,3L,3L,3L,3L,7L,8L,4L,3L,8L,4L,12L,3L,3L,4L,3L,3L,12L,4L,3L,3L,8L,7L,7L,3L,3L,4L,3L,12L,4L,3L,3L,3L,12L,3L,3L,8L,4L,11L,3L,3L,8L,8L,3L,4L,3L,4L,3L,15L,3L,3L,4L,3L,12L,8L,11L,4L,24L,4L,8L,3L,4L,3L,15L,3L,3L,7L,8L,12L,8L,11L,4L,3L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085415Inst : IEnumerable<long>
{
public static readonly long[] Value=A085415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085415.Bytes);
public long this[int i]=>Value[i];

public static A085415Inst Instance=new A085415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085414
{
public static readonly long[] Value={ 131L,191L,313L,373L,797L,1031L,1091L,1511L,1571L,1811L,1931L,3313L,3373L,3533L,3593L,3673L,3733L,3793L,3833L,7517L,7577L,7877L,9199L,9419L,9479L,9539L,9679L,9719L,9839L,10091L,10211L,10331L,10391L,10631L,10691L,11171L,12011L,12491L,12791L,12911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085414Inst : IEnumerable<long>
{
public static readonly long[] Value=A085414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085414.Bytes);
public long this[int i]=>Value[i];

public static A085414Inst Instance=new A085414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085413
{
public static readonly long[] Value={ 13L,19L,31L,37L,79L,103L,109L,151L,157L,181L,193L,331L,337L,353L,359L,367L,373L,379L,383L,751L,757L,787L,919L,941L,947L,953L,967L,971L,983L,1009L,1021L,1033L,1039L,1063L,1069L,1117L,1201L,1249L,1279L,1291L,1459L,1483L,1489L,1567L,1579L,1597L,1609L,1663L,1669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085413Inst : IEnumerable<long>
{
public static readonly long[] Value=A085413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085413.Bytes);
public long this[int i]=>Value[i];

public static A085413Inst Instance=new A085413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085412
{
public static readonly long[] Value={ 6L,8L,11L,12L,22L,27L,29L,36L,37L,42L,44L,67L,68L,71L,72L,73L,74L,75L,76L,133L,134L,138L,157L,160L,161L,162L,163L,164L,166L,169L,172L,174L,175L,179L,180L,187L,197L,204L,207L,210L,232L,235L,237L,247L,249L,251L,254L,261L,263L,264L,269L,272L,278L,282L,285L,287L,303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085412Inst : IEnumerable<long>
{
public static readonly long[] Value=A085412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085412.Bytes);
public long this[int i]=>Value[i];

public static A085412Inst Instance=new A085412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085411
{
public static readonly long[] Value={ 1L,2L,7L,17L,47L,102L,255L,556L,1272L,2766L,6143L,13183L,28671L,61182L,131017L,277952L,589823L,1243800L,2621439L,5502191L,11534073L,24111102L,50331647L,104843732L,218103760L,452956158L,939522816L,1946095599L,4026531839L,8321365194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085411Inst : IEnumerable<long>
{
public static readonly long[] Value=A085411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085411.Bytes);
public long this[int i]=>Value[i];

public static A085411Inst Instance=new A085411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085410
{
public static readonly long[] Value={ 1L,2L,5L,9L,19L,27L,53L,74L,122L,170L,274L,355L,555L,724L,1043L,1377L,1964L,2487L,3497L,4429L,5993L,7622L,10205L,12701L,16831L,20964L,27166L,33756L,43452L,53296L,68134L,83464L,105086L,128495L,160803L,195006L,242811L,293701L,362026L,436842L,536103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085410Inst : IEnumerable<long>
{
public static readonly long[] Value=A085410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085410.Bytes);
public long this[int i]=>Value[i];

public static A085410Inst Instance=new A085410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085409
{
public static readonly long[] Value={ 0L,12L,84L,270L,624L,1200L,2052L,3234L,4800L,6804L,9300L,12342L,15984L,20280L,25284L,31050L,37632L,45084L,53460L,62814L,73200L,84672L,97284L,111090L,126144L,142500L,160212L,179334L,199920L,222024L,245700L,271002L,297984L,326700L,357204L,389550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085409Inst : IEnumerable<long>
{
public static readonly long[] Value=A085409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085409.Bytes);
public long this[int i]=>Value[i];

public static A085409Inst Instance=new A085409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085408
{
public static readonly long[] Value={ 0L,1L,28L,14704L,51109385408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085408Inst : IEnumerable<long>
{
public static readonly long[] Value=A085408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085408.Bytes);
public long this[int i]=>Value[i];

public static A085408Inst Instance=new A085408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085407
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,1L,1L,11L,1L,1L,3L,1L,21L,1L,1L,3L,1L,5L,1L,1L,43L,1L,1L,3L,1L,5L,1L,1L,11L,1L,1L,3L,1L,85L,1L,1L,3L,1L,5L,1L,1L,11L,1L,1L,3L,1L,21L,1L,1L,3L,1L,5L,1L,1L,171L,1L,1L,3L,1L,5L,1L,1L,11L,1L,1L,3L,1L,21L,1L,1L,3L,1L,5L,1L,1L,43L,1L,1L,3L,1L,5L,1L,1L,11L,1L,1L,3L,1L,341L,1L,1L,3L,1L,5L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085407Inst : IEnumerable<long>
{
public static readonly long[] Value=A085407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085407.Bytes);
public long this[int i]=>Value[i];

public static A085407Inst Instance=new A085407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085406
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,16L,18L,20L,32L,34L,36L,40L,42L,64L,66L,68L,72L,74L,80L,82L,84L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085406Inst : IEnumerable<long>
{
public static readonly long[] Value=A085406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085406.Bytes);
public long this[int i]=>Value[i];

public static A085406Inst Instance=new A085406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085405
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085405Inst : IEnumerable<long>
{
public static readonly long[] Value=A085405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085405.Bytes);
public long this[int i]=>Value[i];

public static A085405Inst Instance=new A085405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085404
{
public static readonly BigInteger[] Value={ 1L,75L,79380L,1310904000L,344319762124800L,BigInteger.Parse("1444887697908695040000"),BigInteger.Parse("96976611786040182520676352000"),BigInteger.Parse("104131021972308383324202529613414400000"),BigInteger.Parse("1788970984376098024967914354100894418012733440000") };
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
public class A085404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085404Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085404.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085404Inst Instance=new A085404Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085403
{
public static readonly long[] Value={ 1L,-2L,-2L,-6L,-22L,-90L,-394L,-1806L,-8558L,-41586L,-206098L,-1037718L,-5293446L,-27297738L,-142078746L,-745387038L,-3937603038L,-20927156706L,-111818026018L,-600318853926L,-3236724317174L,-17518619320890L,-95149655201962L,-518431875418926L,-2832923350929742L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085403Inst : IEnumerable<long>
{
public static readonly long[] Value=A085403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085403.Bytes);
public long this[int i]=>Value[i];

public static A085403Inst Instance=new A085403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085402
{
public static readonly long[] Value={ 2L,3L,13L,5L,7L,11L,19L,17L,23L,29L,37L,31L,41L,43L,47L,59L,53L,61L,67L,71L,73L,79L,83L,89L,107L,97L,101L,103L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,199L,191L,193L,197L,211L,223L,227L,233L,229L,239L,251L,241L,257L,269L,263L,271L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085402Inst : IEnumerable<long>
{
public static readonly long[] Value=A085402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085402.Bytes);
public long this[int i]=>Value[i];

public static A085402Inst Instance=new A085402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085401
{
public static readonly long[] Value={ 1L,3L,6L,19L,14L,7L,18L,37L,20L,43L,14L,51L,82L,41L,84L,37L,96L,149L,88L,155L,226L,299L,220L,137L,48L,155L,58L,159L,56L,165L,52L,179L,310L,173L,34L,183L,32L,189L,26L,193L,20L,199L,18L,217L,26L,219L,416L,205L,428L,201L,434L,205L,444L,193L,434L,177L,446L,183L,454L,731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085401Inst : IEnumerable<long>
{
public static readonly long[] Value=A085401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085401.Bytes);
public long this[int i]=>Value[i];

public static A085401Inst Instance=new A085401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085400
{
public static readonly long[] Value={ 2L,3L,13L,5L,7L,17L,19L,11L,23L,29L,31L,41L,37L,43L,47L,53L,59L,61L,67L,71L,83L,73L,79L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,157L,151L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085400Inst : IEnumerable<long>
{
public static readonly long[] Value=A085400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085400.Bytes);
public long this[int i]=>Value[i];

public static A085400Inst Instance=new A085400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085399
{
public static readonly BigInteger[] Value={ 2L,3L,7L,5L,31L,3L,127L,17L,73L,11L,12207031L,13L,8191L,43L,151L,257L,131071L,46441L,524287L,61681L,368089L,683L,BigInteger.Parse("11111111111111111111111"),241L,BigInteger.Parse("705429635566498619547944801"),2731L,262657L,15790321L };
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
public class A085399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085399Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085399.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085399Inst Instance=new A085399Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085398
{
public static readonly long[] Value={ 3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,5L,2L,2L,2L,2L,2L,2L,6L,2L,4L,3L,2L,10L,2L,22L,2L,2L,4L,6L,2L,2L,2L,2L,2L,14L,3L,61L,2L,10L,2L,14L,2L,15L,25L,11L,2L,5L,5L,2L,6L,30L,11L,24L,7L,7L,2L,5L,7L,19L,3L,2L,2L,3L,30L,2L,9L,46L,85L,2L,3L,3L,3L,11L,16L,59L,7L,2L,2L,22L,2L,21L,61L,41L,7L,2L,2L,8L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085398Inst : IEnumerable<long>
{
public static readonly long[] Value=A085398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085398.Bytes);
public long this[int i]=>Value[i];

public static A085398Inst Instance=new A085398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085397
{
public static readonly long[] Value={ 2L,3L,6L,7L,10L,11L,12L,14L,15L,18L,19L,22L,23L,24L,26L,28L,30L,31L,34L,35L,38L,39L,40L,42L,43L,44L,46L,47L,48L,50L,51L,54L,55L,56L,58L,59L,60L,62L,63L,66L,67L,70L,71L,72L,74L,75L,76L,78L,79L,82L,83L,86L,87L,88L,90L,91L,92L,94L,95L,96L,98L,99L,102L,103L,104L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085397Inst : IEnumerable<long>
{
public static readonly long[] Value=A085397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085397.Bytes);
public long this[int i]=>Value[i];

public static A085397Inst Instance=new A085397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085396
{
public static readonly long[] Value={ 1L,3L,7L,17L,24L,113L,363L,1928L,4219L,6147L,28807L,63761L,92568L,526601L,23263012L,23789613L,118421464L,142211077L,402843618L,1753585549L,2156429167L,3910014716L,6066443883L,34242234131L,485457721717L,519699955848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085396Inst : IEnumerable<long>
{
public static readonly long[] Value=A085396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085396.Bytes);
public long this[int i]=>Value[i];

public static A085396Inst Instance=new A085396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085379
{
public static readonly long[] Value={ 3L,3L,7L,5L,11L,7L,13L,13L,17L,11L,23L,13L,23L,23L,31L,17L,37L,19L,41L,31L,23L,23L,59L,31L,41L,37L,53L,29L,71L,31L,61L,47L,53L,47L,89L,37L,59L,53L,89L,41L,89L,43L,83L,73L,71L,47L,113L,7L,83L,71L,97L,53L,113L,71L,113L,79L,89L,59L,167L,61L,31L,103L,127L,83L,139L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085379Inst : IEnumerable<long>
{
public static readonly long[] Value=A085379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085379.Bytes);
public long this[int i]=>Value[i];

public static A085379Inst Instance=new A085379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085378
{
public static readonly long[] Value={ 3L,4L,6L,10L,15L,16L,12L,22L,26L,34L,36L,36L,24L,40L,30L,56L,56L,64L,70L,66L,42L,78L,94L,96L,86L,54L,106L,106L,120L,118L,120L,116L,112L,146L,144L,160L,84L,130L,90L,176L,172L,190L,190L,188L,204L,186L,114L,210L,204L,222L,236L,246L,255L,132L,202L,266L,254L,274L,236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085378Inst : IEnumerable<long>
{
public static readonly long[] Value=A085378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085378.Bytes);
public long this[int i]=>Value[i];

public static A085378Inst Instance=new A085378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085377
{
public static readonly long[] Value={ 0L,28L,164L,486L,1072L,2000L,3348L,5194L,7616L,10692L,14500L,19118L,24624L,31096L,38612L,47250L,57088L,68204L,80676L,94582L,110000L,127008L,145684L,166106L,188352L,212500L,238628L,266814L,297136L,329672L,364500L,401698L,441344L,483516L,528292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085377Inst : IEnumerable<long>
{
public static readonly long[] Value=A085377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085377.Bytes);
public long this[int i]=>Value[i];

public static A085377Inst Instance=new A085377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085376
{
public static readonly long[] Value={ 1L,3L,11L,30L,109L,297L,1079L,2940L,10681L,29103L,105731L,288090L,1046629L,2851797L,10360559L,28229880L,102558961L,279447003L,1015229051L,2766240150L,10049731549L,27382954497L,99482086439L,271063304820L,984771132841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085376Inst : IEnumerable<long>
{
public static readonly long[] Value=A085376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085376.Bytes);
public long this[int i]=>Value[i];

public static A085376Inst Instance=new A085376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085375
{
public static readonly long[] Value={ 1L,15L,150L,1225L,8820L,58212L,360360L,2123550L,12033450L,66050270L,353068716L,1845586470L,9464546000L,47738754000L,237329805600L,1164893795820L,5653161067950L,27157342385250L,129275302348500L,610315506350550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085375Inst : IEnumerable<long>
{
public static readonly long[] Value=A085375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085375.Bytes);
public long this[int i]=>Value[i];

public static A085375Inst Instance=new A085375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085374
{
public static readonly long[] Value={ 1L,12L,100L,700L,4410L,25872L,144144L,772200L,4011150L,20323160L,100876776L,492156392L,2366136500L,11232648000L,52739956800L,245240799120L,1130632213590L,5172827121000L,23504600427000L,106141827191400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085374Inst : IEnumerable<long>
{
public static readonly long[] Value=A085374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085374.Bytes);
public long this[int i]=>Value[i];

public static A085374Inst Instance=new A085374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085373
{
public static readonly long[] Value={ 1L,9L,60L,350L,1890L,9702L,48048L,231660L,1093950L,5080790L,23279256L,105462084L,473227300L,2106121500L,9307051200L,40873466520L,178520875830L,775924068150L,3357800061000L,14473885526100L,62168784497820L,266168518910580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085373Inst : IEnumerable<long>
{
public static readonly long[] Value=A085373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085373.Bytes);
public long this[int i]=>Value[i];

public static A085373Inst Instance=new A085373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085372
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,2L,14L,102L,828L,7522L,75706L,836622L,10073824L,131300266L,1841921270L,27673138086L,443343106468L,7544813993618L,135925854199186L,2584491212811038L,51722014716352136L,1086739983701035418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085372Inst : IEnumerable<long>
{
public static readonly long[] Value=A085372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085372.Bytes);
public long this[int i]=>Value[i];

public static A085372Inst Instance=new A085372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085371
{
public static readonly long[] Value={ 15L,33L,39L,51L,57L,66L,69L,75L,78L,87L,93L,96L,99L,105L,123L,129L,138L,141L,147L,159L,165L,168L,174L,177L,183L,186L,189L,213L,219L,231L,237L,246L,249L,255L,258L,267L,273L,276L,279L,282L,291L,294L,297L,303L,309L,318L,321L,327L,339L,345L,348L,354L,357L,363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085371Inst : IEnumerable<long>
{
public static readonly long[] Value=A085371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085371.Bytes);
public long this[int i]=>Value[i];

public static A085371Inst Instance=new A085371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085370
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,10L,20L,40L,50L,70L,80L,100L,110L,112L,133L,140L,152L,190L,200L,209L,220L,224L,230L,247L,266L,280L,308L,320L,322L,364L,370L,392L,400L,407L,410L,440L,448L,460L,476L,481L,500L,506L,511L,512L,518L,550L,592L,605L,629L,640L,644L,700L,704L,715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085370Inst : IEnumerable<long>
{
public static readonly long[] Value=A085370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085370.Bytes);
public long this[int i]=>Value[i];

public static A085370Inst Instance=new A085370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085369
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085369Inst : IEnumerable<long>
{
public static readonly long[] Value=A085369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085369.Bytes);
public long this[int i]=>Value[i];

public static A085369Inst Instance=new A085369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085368
{
public static readonly long[] Value={ 3L,4L,11L,15L,26L,119L,145L,264L,1729L,1993L,3722L,31769L,35491L,67260L,708091L,775351L,1483442L,18576655L,20060097L,38636752L,560974625L,599611377L,1160586002L,19168987409L,20329573411L,39498560820L,731303668171L,770802228991L,1502105897162L,30812920172231L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085368Inst : IEnumerable<long>
{
public static readonly long[] Value=A085368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085368.Bytes);
public long this[int i]=>Value[i];

public static A085368Inst Instance=new A085368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085367
{
public static readonly long[] Value={ 9L,26L,35L,65L,91L,133L,169L,215L,217L,218L,335L,341L,386L,407L,469L,485L,511L,559L,721L,737L,793L,817L,866L,973L,1027L,1115L,1141L,1241L,1261L,1267L,1339L,1343L,1385L,1387L,1538L,1603L,1685L,1727L,1843L,1853L,1981L,2071L,2189L,2402L,2413L,2611L,2743L,2771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085367Inst : IEnumerable<long>
{
public static readonly long[] Value=A085367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085367.Bytes);
public long this[int i]=>Value[i];

public static A085367Inst Instance=new A085367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085366
{
public static readonly long[] Value={ 9L,35L,65L,91L,133L,217L,341L,407L,559L,737L,793L,1027L,1241L,1339L,1343L,1843L,1853L,2071L,2413L,2771L,2869L,3197L,3383L,3439L,3473L,4097L,4439L,5129L,5833L,6119L,6641L,7471L,7859L,8027L,8587L,9773L,10261L,10649L,10991L,11377L,12679L,12913L,14023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085366Inst : IEnumerable<long>
{
public static readonly long[] Value=A085366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085366.Bytes);
public long this[int i]=>Value[i];

public static A085366Inst Instance=new A085366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085365
{
public static readonly long[] Value={ 1L,1L,4L,9L,4L,2L,0L,4L,4L,8L,5L,3L,2L,9L,6L,2L,0L,0L,7L,0L,1L,0L,4L,0L,1L,5L,7L,4L,6L,9L,5L,9L,8L,7L,4L,2L,8L,3L,0L,7L,9L,5L,3L,3L,7L,2L,0L,0L,8L,6L,3L,5L,1L,6L,8L,4L,4L,0L,2L,3L,3L,9L,6L,5L,1L,8L,9L,6L,6L,0L,1L,2L,8L,2L,5L,3L,5L,3L,0L,5L,1L,1L,7L,7L,9L,4L,0L,7L,7L,2L,4L,8L,4L,9L,8L,5L,8L,3L,6L,9L,9L,3L,7L,6L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085365Inst : IEnumerable<long>
{
public static readonly long[] Value=A085365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085365.Bytes);
public long this[int i]=>Value[i];

public static A085365Inst Instance=new A085365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085364
{
public static readonly long[] Value={ 1L,6L,60L,654L,7458L,87378L,1042152L,12587730L,153479508L,1885010946L,23285957604L,289018502682L,3601315495050L,45023019250398L,564465885846216L,7094214579174558L,89351097367355826L,1127492973620753010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085364Inst : IEnumerable<long>
{
public static readonly long[] Value=A085364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085364.Bytes);
public long this[int i]=>Value[i];

public static A085364Inst Instance=new A085364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085347
{
public static readonly long[] Value={ 0L,2L,5L,4L,6L,8L,10L,19L,12L,29L,16L,18L,20L,43L,33L,28L,24L,32L,67L,30L,45L,57L,44L,36L,52L,101L,63L,85L,91L,48L,64L,86L,137L,66L,149L,99L,106L,163L,60L,129L,88L,80L,105L,72L,197L,104L,100L,84L,147L,229L,90L,114L,112L,96L,171L,148L,136L,201L,108L,281L,138L,152L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085347Inst : IEnumerable<long>
{
public static readonly long[] Value=A085347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085347.Bytes);
public long this[int i]=>Value[i];

public static A085347Inst Instance=new A085347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085346
{
public static readonly long[] Value={ 3L,2L,4L,6L,10L,14L,12L,26L,18L,34L,28L,32L,24L,62L,44L,30L,123L,40L,36L,64L,56L,106L,54L,48L,70L,66L,146L,105L,88L,78L,80L,135L,60L,178L,72L,102L,202L,112L,84L,164L,114L,90L,96L,154L,695L,231L,138L,108L,184L,1141L,176L,140L,126L,244L,132L,160L,326L,232L,186L,208L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085346Inst : IEnumerable<long>
{
public static readonly long[] Value=A085346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085346.Bytes);
public long this[int i]=>Value[i];

public static A085346Inst Instance=new A085346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085345
{
public static readonly long[] Value={ 2L,6L,12L,18L,24L,30L,50L,42L,48L,66L,60L,78L,96L,84L,90L,130L,108L,176L,114L,132L,156L,182L,150L,168L,186L,180L,216L,198L,228L,429L,210L,258L,308L,240L,276L,282L,270L,306L,294L,300L,354L,366L,336L,330L,384L,378L,396L,360L,432L,438L,622L,444L,390L,490L,474L,498L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085345Inst : IEnumerable<long>
{
public static readonly long[] Value=A085345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085345.Bytes);
public long this[int i]=>Value[i];

public static A085345Inst Instance=new A085345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085344
{
public static readonly long[] Value={ 2L,4L,10L,12L,16L,46L,28L,24L,44L,30L,42L,40L,36L,54L,48L,66L,178L,78L,104L,80L,102L,60L,128L,72L,84L,152L,90L,138L,255L,96L,108L,174L,140L,126L,132L,266L,160L,150L,248L,222L,156L,120L,246L,200L,144L,198L,634L,224L,220L,204L,370L,260L,168L,376L,555L,430L,354L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085344Inst : IEnumerable<long>
{
public static readonly long[] Value=A085344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085344.Bytes);
public long this[int i]=>Value[i];

public static A085344Inst Instance=new A085344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085343
{
public static readonly long[] Value={ 0L,2L,1L,3L,1L,4L,1L,4L,3L,5L,1L,7L,1L,6L,5L,7L,1L,9L,1L,9L,6L,7L,1L,13L,3L,8L,5L,11L,1L,16L,1L,12L,7L,10L,6L,19L,1L,10L,7L,18L,1L,19L,1L,15L,12L,12L,1L,24L,3L,16L,9L,16L,1L,23L,8L,21L,11L,15L,1L,33L,1L,14L,16L,20L,8L,26L,1L,19L,10L,25L,1L,35L,1L,19L,18L,23L,7L,30L,1L,31L,14L,18L,1L,39L,10L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085343Inst : IEnumerable<long>
{
public static readonly long[] Value=A085343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085343.Bytes);
public long this[int i]=>Value[i];

public static A085343Inst Instance=new A085343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085342
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,2L,2L,1L,4L,1L,4L,3L,4L,1L,5L,1L,4L,2L,4L,1L,6L,1L,5L,3L,5L,2L,6L,1L,5L,3L,6L,1L,8L,1L,6L,5L,6L,1L,9L,2L,7L,4L,6L,1L,9L,4L,7L,5L,7L,1L,11L,1L,8L,7L,7L,3L,10L,1L,8L,5L,10L,1L,11L,1L,10L,9L,10L,4L,12L,1L,11L,6L,10L,1L,14L,5L,10L,7L,11L,1L,15L,4L,10L,7L,10L,4L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085342Inst : IEnumerable<long>
{
public static readonly long[] Value=A085342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085342.Bytes);
public long this[int i]=>Value[i];

public static A085342Inst Instance=new A085342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085341
{
public static readonly long[] Value={ 0L,1L,0L,2L,0L,2L,0L,2L,2L,3L,0L,4L,0L,3L,3L,5L,0L,5L,0L,5L,3L,3L,0L,8L,2L,4L,3L,7L,0L,10L,0L,7L,4L,5L,4L,13L,0L,5L,4L,12L,0L,11L,0L,9L,7L,6L,0L,15L,1L,9L,5L,10L,0L,14L,4L,14L,6L,8L,0L,22L,0L,6L,9L,13L,5L,16L,0L,11L,5L,15L,0L,24L,0L,9L,9L,13L,3L,18L,0L,20L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085341Inst : IEnumerable<long>
{
public static readonly long[] Value=A085341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085341.Bytes);
public long this[int i]=>Value[i];

public static A085341Inst Instance=new A085341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085340
{
public static readonly BigInteger[] Value={ -1L,1L,4L,41L,528L,8177L,148160L,3077713L,72147712L,1884629825L,54294967296L,1710428956601L,58496602689536L,2158563109641265L,85487558566199296L,3616912482448035233L,BigInteger.Parse("162819625954342010880"),BigInteger.Parse("7770488166051562690817"),BigInteger.Parse("391896604540625999888384") };
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
public class A085340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085340Inst Instance=new A085340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085339
{
public static readonly long[] Value={ 0L,1L,64L,1L,1L,64L,64L,77L,64L,1L,1L,64L,1L,78L,14L,64L,1L,1L,64L,64L,64L,77L,1L,1L,64L,1L,78L,1L,77L,1L,1L,64L,64L,64L,64L,14L,1L,64L,1L,78L,1L,64L,14L,1L,64L,64L,64L,64L,1L,14L,64L,1L,78L,1L,64L,1L,14L,64L,64L,64L,64L,1L,1L,77L,1L,78L,1L,64L,1L,1L,77L,64L,64L,64L,1L,1L,64L,14L,78L,1L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085339Inst : IEnumerable<long>
{
public static readonly long[] Value=A085339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085339.Bytes);
public long this[int i]=>Value[i];

public static A085339Inst Instance=new A085339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085338
{
public static readonly long[] Value={ 1072L,3402L,5256L,6867L,6984L,8576L,9288L,9728L,10261L,10656L,10745L,10773L,10989L,13392L,14167L,14364L,15093L,16480L,17603L,17920L,18305L,18369L,18648L,20026L,20320L,20538L,22016L,23085L,23408L,23625L,24416L,27133L,27216L,27792L,28000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085338Inst : IEnumerable<long>
{
public static readonly long[] Value=A085338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085338.Bytes);
public long this[int i]=>Value[i];

public static A085338Inst Instance=new A085338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085337
{
public static readonly long[] Value={ 1072L,3402L,5256L,6244L,6867L,6984L,8576L,9288L,9728L,10261L,10656L,10745L,10773L,10989L,13392L,14167L,14364L,15093L,16480L,17603L,17920L,18305L,18369L,18648L,20026L,20320L,20538L,22016L,23085L,23408L,23625L,24416L,27133L,27216L,27792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085337Inst : IEnumerable<long>
{
public static readonly long[] Value=A085337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085337.Bytes);
public long this[int i]=>Value[i];

public static A085337Inst Instance=new A085337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085336
{
public static readonly long[] Value={ 344L,855L,1072L,1674L,2752L,3402L,3500L,3744L,4439L,4941L,5256L,6244L,6840L,6867L,6984L,8576L,9288L,9604L,9728L,10261L,10656L,10745L,10773L,10989L,13357L,13392L,14167L,14364L,15093L,16480L,17080L,17603L,17920L,18305L,18369L,18648L,20026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085336Inst : IEnumerable<long>
{
public static readonly long[] Value=A085336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085336.Bytes);
public long this[int i]=>Value[i];

public static A085336Inst Instance=new A085336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085335
{
public static readonly long[] Value={ 7L,14L,15L,21L,22L,23L,42L,47L,49L,50L,61L,77L,85L,87L,103L,106L,111L,112L,113L,114L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085335Inst : IEnumerable<long>
{
public static readonly long[] Value=A085335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085335.Bytes);
public long this[int i]=>Value[i];

public static A085335Inst Instance=new A085335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085334
{
public static readonly long[] Value={ 1L,7L,8L,14L,15L,21L,22L,23L,42L,47L,49L,50L,61L,77L,85L,87L,103L,106L,111L,112L,113L,114L,122L,125L,140L,148L,159L,166L,167L,174L,175L,178L,185L,186L,204L,211L,212L,223L,229L,230L,231L,237L,238L,239L,276L,292L,295L,300L,302L,303L,311L,327L,329L,337L,340L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085334Inst : IEnumerable<long>
{
public static readonly long[] Value=A085334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085334.Bytes);
public long this[int i]=>Value[i];

public static A085334Inst Instance=new A085334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085333
{
public static readonly long[] Value={ 2L,9L,0L,16L,243L,0L,128L,6561L,0L,1024L,177147L,0L,8192L,4782969L,0L,65536L,129140163L,0L,524288L,3486784401L,0L,4194304L,94143178827L,0L,33554432L,2541865828329L,0L,268435456L,68630377364883L,0L,2147483648L,1853020188851841L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085333Inst : IEnumerable<long>
{
public static readonly long[] Value=A085333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085333.Bytes);
public long this[int i]=>Value[i];

public static A085333Inst Instance=new A085333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085332
{
public static readonly long[] Value={ 2L,9L,16L,128L,243L,1024L,6561L,8192L,65536L,177147L,524288L,4194304L,4782969L,33554432L,129140163L,268435456L,2147483648L,3486784401L,17179869184L,94143178827L,137438953472L,1099511627776L,2541865828329L,8796093022208L,68630377364883L,70368744177664L,562949953421312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085332Inst : IEnumerable<long>
{
public static readonly long[] Value=A085332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085332.Bytes);
public long this[int i]=>Value[i];

public static A085332Inst Instance=new A085332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085299
{
public static readonly long[] Value={ 1L,8L,47L,18L,14L,89L,10L,9L,48L,16L,23L,17L,168L,268L,15L,661L,50L,380L,84L,116L,360L,245L,29L,144L,345L,227L,785L,261L,148L,235L,691L,658L,638L,40L,1023L,674L,1529L,210L,19L,81L,181L,428L,170L,1130L,2322L,406L,600L,373L,958L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085299Inst : IEnumerable<long>
{
public static readonly long[] Value=A085299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085299.Bytes);
public long this[int i]=>Value[i];

public static A085299Inst Instance=new A085299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085298
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,8L,7L,1L,1L,2L,5L,15L,10L,12L,4L,39L,1L,1L,1L,11L,2L,1L,1L,10L,1L,23L,1L,5L,1L,243L,2L,1L,1L,1L,23L,1L,34L,1L,1L,1L,2L,58L,1L,3L,9L,166L,17L,68L,8L,8L,3L,7L,5L,5L,2L,2L,2L,61L,11L,97L,1L,1L,10L,2L,1L,1L,41L,1L,1L,66L,1L,5L,1L,1L,2L,2L,8L,40L,2L,8L,19L,2L,2L,723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085298Inst : IEnumerable<long>
{
public static readonly long[] Value=A085298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085298.Bytes);
public long this[int i]=>Value[i];

public static A085298Inst Instance=new A085298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085297
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085297Inst : IEnumerable<long>
{
public static readonly long[] Value=A085297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085297.Bytes);
public long this[int i]=>Value[i];

public static A085297Inst Instance=new A085297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085296
{
public static readonly long[] Value={ 3L,12L,3L,39L,3L,12L,3L,120L,3L,12L,3L,39L,3L,12L,3L,363L,3L,12L,3L,39L,3L,12L,3L,120L,3L,12L,3L,39L,3L,12L,3L,1092L,3L,12L,3L,39L,3L,12L,3L,120L,3L,12L,3L,39L,3L,12L,3L,363L,3L,12L,3L,39L,3L,12L,3L,120L,3L,12L,3L,39L,3L,12L,3L,3279L,3L,12L,3L,39L,3L,12L,3L,120L,3L,12L,3L,39L,3L,12L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085296Inst : IEnumerable<long>
{
public static readonly long[] Value=A085296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085296.Bytes);
public long this[int i]=>Value[i];

public static A085296Inst Instance=new A085296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085295
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,169L,1881L,25051L,403243L,7660689L,166148209L,4069854451L,111107009091L,3344729082553L,110080145959369L,3932437848451659L,151548546279803611L,6267252988546789921L,BigInteger.Parse("276842139798867249633") };
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
public class A085295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A085295.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A085295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A085295Inst Instance=new A085295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085294
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,35L,81L,190L,458L,1122L,2784L,6983L,17678L,45108L,115892L,299542L,778330L,2031974L,5327304L,14020083L,37024711L,98083557L,260583547L,694130905L,1853484434L,4960318790L,13302462676L,35743133528L,96213085461L,259420983385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085294Inst : IEnumerable<long>
{
public static readonly long[] Value=A085294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085294.Bytes);
public long this[int i]=>Value[i];

public static A085294Inst Instance=new A085294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085293
{
public static readonly long[] Value={ 2L,18L,56L,238L,902L,3564L,13862L,54238L,211736L,827298L,3231362L,12623044L,49308482L,192613698L,752401496L,2939092798L,11480914982L,44847668844L,175187526662L,684331472398L,2673190054136L,10442227799538L,40790261396162L,159338166024964L,622419427368002L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085293Inst : IEnumerable<long>
{
public static readonly long[] Value=A085293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085293.Bytes);
public long this[int i]=>Value[i];

public static A085293Inst Instance=new A085293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085292
{
public static readonly long[] Value={ 1L,9L,28L,119L,451L,1782L,6931L,27119L,105868L,413649L,1615681L,6311522L,24654241L,96306849L,376200748L,1469546399L,5740457491L,22423834422L,87593763331L,342165736199L,1336595027068L,5221113899769L,20395130698081L,79669083012482L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085292Inst : IEnumerable<long>
{
public static readonly long[] Value=A085292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085292.Bytes);
public long this[int i]=>Value[i];

public static A085292Inst Instance=new A085292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085291
{
public static readonly long[] Value={ 8L,0L,9L,3L,9L,4L,0L,2L,0L,5L,4L,0L,6L,3L,9L,1L,3L,0L,7L,1L,7L,9L,3L,1L,8L,8L,0L,5L,9L,4L,0L,9L,1L,3L,1L,7L,2L,1L,5L,9L,5L,3L,9L,9L,2L,4L,2L,5L,0L,0L,0L,3L,0L,4L,2L,4L,2L,0L,2L,8L,7L,1L,5L,0L,4L,2L,9L,9L,9L,0L,1L,2L,5L,1L,6L,5L,4L,7L,3L,2L,2L,3L,1L,1L,5L,1L,8L,4L,0L,7L,8L,1L,9L,7L,2L,3L,6L,1L,6L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085291Inst : IEnumerable<long>
{
public static readonly long[] Value=A085291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085291.Bytes);
public long this[int i]=>Value[i];

public static A085291Inst Instance=new A085291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085290
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085290Inst : IEnumerable<long>
{
public static readonly long[] Value=A085290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085290.Bytes);
public long this[int i]=>Value[i];

public static A085290Inst Instance=new A085290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085289
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,5L,12L,31L,31L,78L,78L,191L,418L,1220L,1220L,3015L,3015L,7889L,15413L,37012L,37012L,100559L,211426L,501520L,1157544L,2880550L,2880550L,6307387L,6307387L,17134912L,32298263L,75200323L,148928952L,359182792L,359182792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085289Inst : IEnumerable<long>
{
public static readonly long[] Value=A085289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085289.Bytes);
public long this[int i]=>Value[i];

public static A085289Inst Instance=new A085289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085288
{
public static readonly long[] Value={ 1L,1L,3L,3L,10L,10L,30L,75L,220L,220L,588L,588L,1568L,3696L,11616L,11616L,30492L,30492L,84700L,173250L,441000L,441000L,1262520L,2777544L,6957720L,16731660L,43506760L,43506760L,98658000L,98658000L,277101000L,541886400L,1322481600L,2715495552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085288Inst : IEnumerable<long>
{
public static readonly long[] Value=A085288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085288.Bytes);
public long this[int i]=>Value[i];

public static A085288Inst Instance=new A085288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085287
{
public static readonly long[] Value={ 1L,7L,22L,70L,211L,637L,1912L,5740L,17221L,51667L,155002L,465010L,1395031L,4185097L,12555292L,37665880L,112997641L,338992927L,1016978782L,3050936350L,9152809051L,27458427157L,82375281472L,247125844420L,741377533261L,2224132599787L,6672397799362L,20017193398090L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085287Inst : IEnumerable<long>
{
public static readonly long[] Value=A085287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085287.Bytes);
public long this[int i]=>Value[i];

public static A085287Inst Instance=new A085287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085286
{
public static readonly long[] Value={ 0L,2L,6L,22L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085286Inst : IEnumerable<long>
{
public static readonly long[] Value=A085286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085286.Bytes);
public long this[int i]=>Value[i];

public static A085286Inst Instance=new A085286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085285
{
public static readonly long[] Value={ 3L,4L,5L,28L,1783L,7148L,273223L,398314L,1180939L,1751431L,10970993L,17545207L,20110862L,190270082L,10261454491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085285Inst : IEnumerable<long>
{
public static readonly long[] Value=A085285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085285.Bytes);
public long this[int i]=>Value[i];

public static A085285Inst Instance=new A085285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085284
{
public static readonly long[] Value={ 0L,1L,20L,135L,560L,1750L,4536L,10290L,21120L,40095L,71500L,121121L,196560L,307580L,466480L,688500L,992256L,1400205L,1939140L,2640715L,3542000L,4686066L,6122600L,7908550L,10108800L,12796875L,16055676L,19978245L,24668560L,30242360L,36828000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085284Inst : IEnumerable<long>
{
public static readonly long[] Value=A085284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085284.Bytes);
public long this[int i]=>Value[i];

public static A085284Inst Instance=new A085284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085171
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,11L,14L,16L,19L,17L,20L,12L,10L,15L,21L,18L,13L,22L,23L,25L,28L,30L,33L,37L,39L,42L,44L,53L,51L,56L,47L,60L,45L,48L,54L,57L,61L,31L,34L,26L,24L,29L,40L,38L,43L,52L,58L,62L,49L,46L,55L,35L,32L,27L,41L,63L,59L,50L,36L,64L,65L,67L,70L,72L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085171Inst : IEnumerable<long>
{
public static readonly long[] Value=A085171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085171.Bytes);
public long this[int i]=>Value[i];

public static A085171Inst Instance=new A085171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085170
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,21L,20L,16L,22L,18L,17L,23L,24L,25L,27L,26L,28L,29L,33L,35L,34L,30L,36L,32L,31L,37L,38L,39L,41L,40L,51L,52L,56L,58L,57L,53L,59L,55L,54L,42L,43L,60L,62L,61L,47L,64L,49L,48L,44L,63L,50L,46L,45L,65L,66L,67L,69L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085170Inst : IEnumerable<long>
{
public static readonly long[] Value=A085170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085170.Bytes);
public long this[int i]=>Value[i];

public static A085170Inst Instance=new A085170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085169
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,7L,9L,10L,11L,13L,12L,14L,15L,19L,22L,21L,16L,18L,17L,20L,23L,24L,25L,27L,26L,28L,29L,33L,36L,35L,30L,32L,31L,34L,37L,38L,39L,41L,40L,51L,52L,60L,64L,63L,56L,59L,58L,62L,42L,43L,47L,50L,49L,44L,46L,45L,48L,53L,55L,54L,61L,57L,65L,66L,67L,69L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085169Inst : IEnumerable<long>
{
public static readonly long[] Value=A085169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085169.Bytes);
public long this[int i]=>Value[i];

public static A085169Inst Instance=new A085169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085168
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,4L,8L,6L,5L,17L,9L,18L,14L,10L,20L,11L,21L,16L,12L,22L,19L,15L,13L,45L,23L,46L,37L,24L,48L,25L,49L,42L,26L,50L,51L,38L,27L,54L,28L,55L,39L,29L,57L,30L,58L,44L,31L,59L,47L,40L,32L,61L,33L,62L,53L,34L,63L,56L,43L,35L,64L,60L,52L,41L,36L,129L,65L,130L,107L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085168Inst : IEnumerable<long>
{
public static readonly long[] Value=A085168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085168.Bytes);
public long this[int i]=>Value[i];

public static A085168Inst Instance=new A085168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085167
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,8L,7L,4L,6L,10L,13L,15L,18L,22L,12L,21L,17L,9L,11L,20L,14L,16L,19L,24L,27L,29L,32L,36L,38L,41L,43L,46L,50L,52L,55L,59L,64L,26L,35L,40L,49L,63L,31L,58L,45L,23L,25L,48L,28L,30L,33L,34L,62L,54L,37L,39L,57L,42L,44L,47L,61L,51L,53L,56L,60L,66L,69L,71L,74L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085167Inst : IEnumerable<long>
{
public static readonly long[] Value=A085167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085167.Bytes);
public long this[int i]=>Value[i];

public static A085167Inst Instance=new A085167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085166
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,14L,16L,10L,19L,17L,18L,11L,12L,15L,20L,21L,13L,22L,23L,37L,42L,24L,51L,44L,47L,25L,26L,38L,53L,56L,27L,60L,45L,46L,48L,49L,50L,28L,29L,30L,31L,40L,39L,43L,32L,52L,54L,55L,57L,58L,59L,33L,34L,35L,41L,61L,62L,63L,36L,64L,65L,107L,121L,66L,149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085166Inst : IEnumerable<long>
{
public static readonly long[] Value=A085166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085166.Bytes);
public long this[int i]=>Value[i];

public static A085166Inst Instance=new A085166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085165
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,12L,16L,17L,21L,10L,18L,11L,14L,15L,13L,19L,20L,22L,23L,26L,30L,31L,35L,42L,43L,44L,45L,49L,56L,57L,58L,63L,24L,32L,47L,46L,59L,25L,48L,28L,37L,38L,29L,39L,40L,41L,27L,50L,33L,51L,52L,34L,53L,54L,55L,36L,60L,61L,62L,64L,65L,68L,72L,73L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085165Inst : IEnumerable<long>
{
public static readonly long[] Value=A085165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085165.Bytes);
public long this[int i]=>Value[i];

public static A085165Inst Instance=new A085165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085164
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,5L,6L,8L,9L,17L,10L,16L,21L,11L,20L,12L,14L,18L,13L,15L,19L,22L,23L,45L,24L,44L,58L,25L,54L,26L,42L,49L,27L,43L,56L,63L,28L,48L,29L,53L,62L,30L,57L,31L,37L,46L,35L,38L,47L,59L,33L,61L,34L,39L,55L,32L,40L,51L,50L,36L,41L,52L,60L,64L,65L,129L,66L,128L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085164Inst : IEnumerable<long>
{
public static readonly long[] Value=A085164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085164.Bytes);
public long this[int i]=>Value[i];

public static A085164Inst Instance=new A085164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085163
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,5L,8L,9L,11L,14L,16L,19L,17L,20L,12L,10L,18L,21L,15L,13L,22L,23L,25L,28L,30L,33L,37L,39L,42L,44L,56L,51L,53L,47L,60L,45L,48L,54L,57L,61L,31L,34L,26L,24L,46L,49L,38L,32L,59L,58L,62L,40L,29L,55L,35L,43L,27L,50L,63L,52L,41L,36L,64L,65L,67L,70L,72L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085163Inst : IEnumerable<long>
{
public static readonly long[] Value=A085163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085163.Bytes);
public long this[int i]=>Value[i];

public static A085163Inst Instance=new A085163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085162
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,17L,16L,12L,21L,14L,15L,11L,10L,18L,20L,19L,13L,22L,23L,45L,44L,31L,58L,42L,43L,30L,26L,49L,57L,56L,35L,63L,37L,40L,39L,38L,41L,28L,29L,25L,24L,46L,48L,47L,32L,59L,54L,55L,53L,51L,52L,34L,33L,27L,50L,62L,61L,60L,36L,64L,65L,129L,128L,87L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085162Inst : IEnumerable<long>
{
public static readonly long[] Value=A085162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085162.Bytes);
public long this[int i]=>Value[i];

public static A085162Inst Instance=new A085162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A085161
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,6L,5L,8L,9L,17L,14L,12L,21L,11L,20L,16L,10L,18L,19L,15L,13L,22L,23L,45L,37L,31L,58L,28L,54L,42L,26L,49L,51L,40L,35L,63L,25L,48L,39L,34L,62L,30L,57L,44L,24L,46L,56L,38L,32L,59L,33L,61L,53L,29L,55L,47L,43L,27L,50L,60L,52L,41L,36L,64L,65L,129L,107L,87L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A085161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A085161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A085161Inst : IEnumerable<long>
{
public static readonly long[] Value=A085161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A085161.Bytes);
public long this[int i]=>Value[i];

public static A085161Inst Instance=new A085161Inst();

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