using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A276477
{
public static readonly long[] Value={ 2L,2L,1L,4L,3L,5L,7L,8L,12L,15L,20L,27L,35L,47L,62L,82L,109L,144L,191L,253L,335L,444L,588L,779L,1032L,1367L,1811L,2399L,3178L,4210L,5577L,7388L,9787L,12965L,17175L,22752L,30140L,39927L,52892L,70067L,92819L,122959L,162886L,215778L,285845L,378664L,501623L,664509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276477Inst : IEnumerable<long>
{
public static readonly long[] Value=A276477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276477.Bytes);
public long this[int i]=>Value[i];

public static A276477Inst Instance=new A276477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276478
{
public static readonly long[] Value={ 1L,2L,5L,12L,19L,34L,45L,56L,77L,98L,127L,148L,169L,206L,239L,280L,311L,350L,393L,440L,495L,534L,593L,644L,697L,770L,827L,896L,957L,1026L,1105L,1168L,1255L,1330L,1417L,1512L,1579L,1678L,1759L,1868L,1969L,2050L,2159L,2256L,2377L,2490L,2585L,2704L,2811L,2942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276478Inst : IEnumerable<long>
{
public static readonly long[] Value=A276478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276478.Bytes);
public long this[int i]=>Value[i];

public static A276478Inst Instance=new A276478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276479
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,2L,0L,1L,1L,0L,0L,2L,0L,0L,1L,1L,0L,2L,0L,1L,0L,0L,1L,3L,0L,0L,0L,2L,0L,2L,0L,1L,2L,0L,0L,3L,1L,1L,1L,1L,0L,3L,1L,3L,1L,1L,0L,3L,0L,1L,2L,2L,1L,2L,0L,1L,1L,2L,0L,4L,0L,1L,2L,2L,1L,2L,0L,3L,2L,1L,0L,4L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276479Inst : IEnumerable<long>
{
public static readonly long[] Value=A276479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276479.Bytes);
public long this[int i]=>Value[i];

public static A276479Inst Instance=new A276479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276480
{
public static readonly long[] Value={ 1L,6L,18L,36L,72L,120L,168L,288L,420L,360L,792L,720L,1512L,1260L,1440L,3240L,4032L,2880L,2520L,3960L,5544L,6720L,5040L,10920L,7560L,14400L,10080L,13860L,15840L,15120L,18480L,20160L,37440L,25200L,46800L,30240L,36960L,32760L,27720L,71280L,50400L,69300L,60480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276480Inst : IEnumerable<long>
{
public static readonly long[] Value=A276480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276480.Bytes);
public long this[int i]=>Value[i];

public static A276480Inst Instance=new A276480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276481
{
public static readonly long[] Value={ 1L,2L,4L,13L,16L,17L,28L,34L,90L,100L,132L,331L,534L,7923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276481Inst : IEnumerable<long>
{
public static readonly long[] Value=A276481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276481.Bytes);
public long this[int i]=>Value[i];

public static A276481Inst Instance=new A276481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276482
{
public static readonly BigInteger[] Value={ 1L,1L,12L,396L,25344L,2661120L,415134720L,90084234240L,25944259461120L,9573431741153280L,4403778600930508800L,BigInteger.Parse("2470519795122015436800"),BigInteger.Parse("1660189302321994373529600"),BigInteger.Parse("1316530116741341538208972800"),BigInteger.Parse("1216473827868999581305090867200"),BigInteger.Parse("1295544626680484554089921773568000") };
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
public class A276482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276482.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276482Inst Instance=new A276482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276483
{
public static readonly long[] Value={ 1L,5L,7L,9L,7L,6L,8L,3L,7L,9L,5L,5L,4L,0L,2L,0L,7L,7L,5L,2L,4L,2L,9L,9L,7L,8L,5L,9L,1L,2L,3L,4L,4L,4L,8L,6L,0L,6L,2L,7L,8L,9L,5L,5L,3L,5L,7L,6L,6L,4L,9L,5L,0L,5L,5L,2L,0L,7L,1L,8L,1L,8L,5L,4L,0L,1L,6L,9L,2L,3L,7L,9L,2L,9L,8L,4L,0L,7L,3L,6L,3L,6L,7L,5L,8L,6L,0L,3L,4L,4L,4L,9L,6L,4L,2L,3L,6L,1L,3L,7L,1L,1L,4L,9L,7L,4L,5L,3L,9L,6L,1L,6L,7L,0L,3L,2L,1L,3L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276483Inst : IEnumerable<long>
{
public static readonly long[] Value=A276483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276483.Bytes);
public long this[int i]=>Value[i];

public static A276483Inst Instance=new A276483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276516
{
public static readonly long[] Value={ 1L,-1L,0L,0L,-1L,1L,0L,0L,0L,-1L,1L,0L,0L,1L,-1L,0L,-1L,1L,0L,0L,1L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,-1L,-1L,1L,-1L,1L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,-2L,1L,1L,1L,0L,0L,-1L,-1L,1L,1L,-1L,0L,0L,-1L,1L,-1L,2L,-1L,0L,1L,-2L,0L,1L,0L,1L,0L,-1L,0L,-2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276516Inst : IEnumerable<long>
{
public static readonly long[] Value=A276516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276516.Bytes);
public long this[int i]=>Value[i];

public static A276516Inst Instance=new A276516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276517
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,11L,12L,15L,18L,19L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,41L,43L,44L,45L,46L,47L,48L,53L,54L,60L,61L,67L,70L,72L,74L,76L,79L,82L,84L,87L,90L,92L,93L,96L,105L,106L,107L,108L,111L,112L,114L,117L,122L,128L,133L,135L,139L,141L,148L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276517Inst : IEnumerable<long>
{
public static readonly long[] Value=A276517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276517.Bytes);
public long this[int i]=>Value[i];

public static A276517Inst Instance=new A276517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276518
{
public static readonly long[] Value={ 1L,2L,72L,54535237632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276518Inst : IEnumerable<long>
{
public static readonly long[] Value=A276518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276518.Bytes);
public long this[int i]=>Value[i];

public static A276518Inst Instance=new A276518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276519
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,5L,4L,9L,10L,17L,19L,34L,37L,61L,75L,112L,138L,209L,256L,376L,478L,675L,866L,1222L,1566L,2175L,2830L,3873L,5055L,6900L,9011L,12213L,16045L,21599L,28429L,38191L,50290L,67341L,88884L,118669L,156751L,209018L,276200L,367734L,486376L,646688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276519Inst : IEnumerable<long>
{
public static readonly long[] Value=A276519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276519.Bytes);
public long this[int i]=>Value[i];

public static A276519Inst Instance=new A276519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276520
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,1L,2L,2L,1L,2L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,3L,2L,3L,2L,2L,0L,3L,3L,1L,2L,4L,1L,3L,2L,2L,2L,2L,2L,3L,1L,2L,2L,2L,1L,3L,0L,2L,2L,0L,1L,3L,1L,3L,2L,0L,2L,3L,3L,3L,3L,3L,2L,3L,2L,2L,2L,2L,2L,3L,3L,2L,2L,4L,1L,2L,2L,3L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276520Inst : IEnumerable<long>
{
public static readonly long[] Value=A276520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276520.Bytes);
public long this[int i]=>Value[i];

public static A276520Inst Instance=new A276520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276521
{
public static readonly long[] Value={ 3L,4L,9L,5L,6L,5L,1L,2L,0L,8L,2L,6L,1L,9L,3L,0L,1L,5L,8L,6L,4L,4L,5L,8L,9L,1L,9L,4L,0L,2L,4L,0L,6L,2L,9L,4L,0L,5L,5L,7L,3L,2L,2L,5L,0L,7L,9L,7L,1L,0L,8L,8L,5L,0L,8L,6L,2L,9L,8L,9L,5L,2L,9L,9L,9L,9L,3L,3L,0L,0L,1L,8L,6L,4L,5L,6L,5L,8L,0L,2L,0L,7L,0L,0L,8L,2L,5L,0L,9L,7L,0L,6L,9L,9L,2L,6L,1L,4L,6L,4L,7L,6L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276521Inst : IEnumerable<long>
{
public static readonly long[] Value=A276521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276521.Bytes);
public long this[int i]=>Value[i];

public static A276521Inst Instance=new A276521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276522
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,32L,52L,55L,61L,128L,194L,214L,244L,292L,334L,388L,782L,902L,992L,1414L,1571L,1712L,1916L,2551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276522Inst : IEnumerable<long>
{
public static readonly long[] Value=A276522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276522.Bytes);
public long this[int i]=>Value[i];

public static A276522Inst Instance=new A276522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276523
{
public static readonly long[] Value={ 2L,4L,4L,5L,5L,6L,6L,8L,6L,7L,8L,6L,8L,8L,8L,8L,8L,9L,9L,9L,8L,9L,10L,9L,10L,9L,9L,11L,11L,10L,12L,12L,11L,12L,11L,10L,11L,12L,13L,12L,12L,12L,13L,13L,12L,14L,12L,13L,14L,13L,14L,15L,14L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276523Inst : IEnumerable<long>
{
public static readonly long[] Value=A276523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276523.Bytes);
public long this[int i]=>Value[i];

public static A276523Inst Instance=new A276523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276524
{
public static readonly long[] Value={ 5L,2L,1L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276524Inst : IEnumerable<long>
{
public static readonly long[] Value=A276524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276524.Bytes);
public long this[int i]=>Value[i];

public static A276524Inst Instance=new A276524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276525
{
public static readonly long[] Value={ 14L,28L,34L,39L,46L,55L,56L,62L,68L,82L,92L,94L,95L,98L,111L,112L,117L,124L,136L,142L,145L,146L,155L,158L,164L,178L,183L,184L,188L,194L,196L,203L,205L,206L,219L,221L,224L,226L,248L,254L,259L,272L,274L,275L,284L,291L,292L,295L,299L,302L,305L,316L,323L,327L,328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276525Inst : IEnumerable<long>
{
public static readonly long[] Value=A276525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276525.Bytes);
public long this[int i]=>Value[i];

public static A276525Inst Instance=new A276525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276526
{
public static readonly long[] Value={ 1L,0L,1L,-1L,2L,-2L,3L,-4L,7L,-8L,11L,-15L,22L,-27L,37L,-51L,70L,-90L,121L,-162L,220L,-288L,381L,-512L,688L,-902L,1197L,-1598L,2127L,-2809L,3722L,-4949L,6581L,-8699L,11519L,-15301L,20305L,-26862L,35581L,-47208L,62591L,-82859L,109756L,-145506L,192856L,-255388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276526Inst : IEnumerable<long>
{
public static readonly long[] Value=A276526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276526.Bytes);
public long this[int i]=>Value[i];

public static A276526Inst Instance=new A276526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276527
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,5L,-8L,12L,-21L,37L,-59L,92L,-153L,256L,-409L,654L,-1073L,1754L,-2824L,4552L,-7394L,12010L,-19406L,31337L,-50782L,82306L,-133072L,215152L,-348346L,563939L,-912217L,1475604L,-2388075L,3864808L,-6252750L,10115987L,-16369340L,26488326L,-42857128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276527Inst : IEnumerable<long>
{
public static readonly long[] Value=A276527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276527.Bytes);
public long this[int i]=>Value[i];

public static A276527Inst Instance=new A276527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276528
{
public static readonly long[] Value={ 1L,2L,4L,2L,6L,12L,8L,6L,2L,12L,12L,12L,6L,24L,24L,2L,12L,6L,12L,30L,32L,36L,24L,60L,2L,30L,24L,24L,30L,72L,32L,12L,48L,24L,48L,6L,6L,60L,24L,60L,30L,96L,12L,60L,30L,72L,48L,12L,6L,6L,72L,12L,24L,120L,72L,120L,48L,60L,60L,120L,6L,96L,24L,2L,60L,144L,12L,60L,96L,144L,72L,30L,6L,30L,12L,60L,96L,120L,48L,30L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276528Inst : IEnumerable<long>
{
public static readonly long[] Value=A276528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276528.Bytes);
public long this[int i]=>Value[i];

public static A276528Inst Instance=new A276528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276529
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,5L,6L,13L,20L,27L,34L,41L,89L,137L,185L,233L,281L,610L,939L,1268L,1597L,1926L,4181L,6436L,8691L,10946L,13201L,28657L,44113L,59569L,75025L,90481L,196418L,302355L,408292L,514229L,620166L,1346269L,2072372L,2798475L,3524578L,4250681L,9227465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276529Inst : IEnumerable<long>
{
public static readonly long[] Value=A276529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276529.Bytes);
public long this[int i]=>Value[i];

public static A276529Inst Instance=new A276529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276530
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,4L,12L,39L,142L,1077L,21209L,779449L,106636837L,245010524697L,3336696488691229L,BigInteger.Parse("1125981890791313205482"),BigInteger.Parse("693480182652378523758257457499"),BigInteger.Parse("47660918720485535883730945247863294175948"),BigInteger.Parse("13387114027268508450553229985503810242341235794343085252") };
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
public class A276530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276530Inst Instance=new A276530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276531
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,5L,11L,41L,247L,1498L,39629L,3121233L,1344630757L,4527359876765L,673384475958949877L,BigInteger.Parse("12684198948982702826816701"),BigInteger.Parse("103442271685605704255863097581658042"),BigInteger.Parse("12389248756108266360505757651017660004796444483503"),BigInteger.Parse("657084395567781339286109602463271066924826185667810218784212689809097") };
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
public class A276531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276531Inst Instance=new A276531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276532
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,3L,5L,11L,41L,371L,7507L,429563L,419408854L,9811194604889L,BigInteger.Parse("45615501062085527113"),BigInteger.Parse("323645006689468299915979814409"),BigInteger.Parse("217332607887523478570092794860281557159140687"),BigInteger.Parse("8092345737591989154121803868154457767563221634145658745306515944569") };
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
public class A276532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276532Inst Instance=new A276532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276533
{
public static readonly long[] Value={ 5L,2L,19L,127L,17L,67L,163L,41L,89L,101L,131L,313L,257L,211L,227L,461L,241L,401L,613L,337L,433L,353L,577L,467L,863L,887L,617L,787L,601L,569L,761L,641L,823L,673L,857L,1217L,881L,1091L,1289L,977L,1427L,1097L,1801L,929L,1153L,953L,1321L,1049L,1747L,1409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276533Inst : IEnumerable<long>
{
public static readonly long[] Value=A276533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276533.Bytes);
public long this[int i]=>Value[i];

public static A276533Inst Instance=new A276533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276534
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,2L,4L,12L,108L,10584L,27454896L,94148851006224L,BigInteger.Parse("246222177535609206635748240"),BigInteger.Parse("62371770277951054762478578990896212287188931341600"),BigInteger.Parse("3750595553941161278345366267513070968239986992860645038477600300348697171928615364721752014400") };
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
public class A276534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276534Inst Instance=new A276534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276535
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,9L,63L,2331L,4114215L,16341764835375L,BigInteger.Parse("266584861903285121344257375"),BigInteger.Parse("7896333852271846954822982651737848156847060737115875"),BigInteger.Parse("2309336603704915706429640788623787983392652603516450553629239932054220008270731649775618317371336467375") };
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
public class A276535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276535Inst Instance=new A276535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276536
{
public static readonly BigInteger[] Value={ 1L,9L,233L,8673L,376329L,17800209L,890215361L,46294813497L,2478150328777L,135642353562321L,7556884938829233L,427106589765940137L,BigInteger.Parse("24429206859151618209"),BigInteger.Parse("1411391470651692285609"),BigInteger.Parse("82245902444586364980057"),BigInteger.Parse("4828398428680134702936273") };
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
public class A276536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276536Inst Instance=new A276536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276537
{
public static readonly BigInteger[] Value={ 1L,7L,201L,7375L,312265L,14365887L,697859169L,35226348087L,1829569294665L,97138289500735L,5248514415816721L,287657066913117447L,15953440327189548001UL,BigInteger.Parse("893653778439275931175"),BigInteger.Parse("50488236061157830951545"),BigInteger.Parse("2873526763346873838886815") };
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
public class A276537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276537Inst Instance=new A276537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276538
{
public static readonly long[] Value={ 9L,6L,3L,6L,7L,6L,0L,5L,1L,2L,0L,6L,6L,0L,3L,7L,4L,4L,5L,0L,5L,2L,7L,6L,3L,2L,7L,7L,0L,6L,8L,9L,7L,1L,1L,2L,8L,1L,4L,6L,6L,6L,1L,7L,0L,9L,1L,0L,8L,5L,1L,1L,0L,5L,4L,5L,9L,3L,6L,5L,4L,1L,1L,8L,7L,9L,0L,6L,7L,0L,9L,8L,3L,1L,7L,8L,9L,3L,9L,7L,1L,4L,8L,8L,7L,9L,1L,5L,3L,4L,5L,0L,9L,4L,3L,8L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276538Inst : IEnumerable<long>
{
public static readonly long[] Value=A276538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276538.Bytes);
public long this[int i]=>Value[i];

public static A276538Inst Instance=new A276538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276539
{
public static readonly long[] Value={ 1L,4L,9L,8L,9L,0L,4L,8L,4L,4L,1L,2L,0L,8L,4L,4L,3L,1L,5L,6L,7L,7L,3L,1L,3L,2L,5L,9L,5L,3L,8L,1L,8L,6L,4L,5L,6L,9L,7L,0L,6L,1L,5L,7L,5L,3L,7L,4L,9L,4L,3L,3L,5L,3L,5L,7L,2L,0L,5L,7L,6L,4L,1L,6L,7L,5L,5L,9L,7L,9L,6L,1L,7L,3L,9L,5L,5L,2L,0L,2L,4L,9L,7L,5L,8L,0L,3L,0L,3L,3L,3L,1L,6L,6L,7L,8L,6L,6L,5L,1L,2L,1L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276539Inst : IEnumerable<long>
{
public static readonly long[] Value=A276539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276539.Bytes);
public long this[int i]=>Value[i];

public static A276539Inst Instance=new A276539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276540
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1110L,11L,111100L,1111L,11111000L,1111L,1111111000L,1111L,111111111000L,1111L,11111111111000L,11111111L,1111111110011110L,11110011L,111111111110011110L,11110011L,11111111111110011100UL,1111111L,BigInteger.Parse("1111111111111110011000"),11111111L };
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
public class A276540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276540Inst Instance=new A276540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276541
{
public static readonly long[] Value={ 10L,15L,26L,30L,34L,35L,39L,40L,42L,51L,55L,58L,60L,65L,66L,70L,74L,78L,79L,82L,85L,87L,90L,91L,95L,102L,104L,105L,106L,110L,111L,114L,115L,119L,120L,122L,123L,130L,135L,136L,138L,140L,142L,143L,145L,146L,154L,155L,156L,159L,160L,165L,168L,170L,174L,178L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276541Inst : IEnumerable<long>
{
public static readonly long[] Value=A276541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276541.Bytes);
public long this[int i]=>Value[i];

public static A276541Inst Instance=new A276541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276542
{
public static readonly long[] Value={ 3L,4L,5L,11L,17L,28L,29L,33L,41L,42L,52L,55L,59L,66L,68L,71L,76L,85L,88L,91L,93L,101L,107L,114L,123L,137L,141L,143L,149L,150L,159L,170L,172L,179L,183L,185L,186L,188L,191L,196L,197L,201L,203L,208L,213L,215L,217L,219L,227L,232L,235L,236L,239L,243L,244L,247L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276542Inst : IEnumerable<long>
{
public static readonly long[] Value=A276542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276542.Bytes);
public long this[int i]=>Value[i];

public static A276542Inst Instance=new A276542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276543
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,3L,5L,2L,1L,0L,5L,13L,11L,3L,1L,0L,8L,31L,33L,16L,3L,1L,0L,14L,80L,136L,85L,27L,4L,1L,0L,21L,201L,478L,434L,171L,37L,4L,1L,0L,39L,533L,1849L,2270L,1249L,338L,54L,5L,1L,0L,62L,1401L,6845L,11530L,8389L,3056L,590L,70L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276543Inst : IEnumerable<long>
{
public static readonly long[] Value=A276543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276543.Bytes);
public long this[int i]=>Value[i];

public static A276543Inst Instance=new A276543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276544
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,0L,4L,4L,1L,0L,9L,15L,6L,1L,0L,16L,49L,37L,9L,1L,0L,35L,160L,183L,76L,12L,1L,0L,66L,498L,876L,542L,142L,16L,1L,0L,133L,1544L,3930L,3523L,1346L,242L,20L,1L,0L,261L,4715L,17179L,21392L,11511L,2980L,390L,25L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276544Inst : IEnumerable<long>
{
public static readonly long[] Value=A276544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276544.Bytes);
public long this[int i]=>Value[i];

public static A276544Inst Instance=new A276544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276545
{
public static readonly long[] Value={ 2L,5L,7L,8L,11L,13L,25L,26L,61L,82L,131L,289L,377L,547L,845L,929L,1786L,5887L,6562L,10546L,28033L,33493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276545Inst : IEnumerable<long>
{
public static readonly long[] Value=A276545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276545.Bytes);
public long this[int i]=>Value[i];

public static A276545Inst Instance=new A276545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276546
{
public static readonly long[] Value={ 1L,3L,6L,15L,19L,34L,37L,88L,141L,216L,239L,246L,288L,365L,429L,762L,1879L,2309L,9555L,19843L,28348L,45058L,62879L,86963L,90669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276546Inst : IEnumerable<long>
{
public static readonly long[] Value=A276546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276546.Bytes);
public long this[int i]=>Value[i];

public static A276546Inst Instance=new A276546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276547
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,39L,126L,537L,2358L,11690L,61689L,351725L,2126496L,13639244L,92197509L,655035225L,4874404107L,37893368072L,306986431846L,2586209738004L,22612848403442L,204850732418594L,1919652428481929L,18581619724011091L,185543613289200937L,1908894098864372104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276547Inst : IEnumerable<long>
{
public static readonly long[] Value=A276547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276547.Bytes);
public long this[int i]=>Value[i];

public static A276547Inst Instance=new A276547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276580
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,3L,0L,0L,0L,4L,3L,0L,0L,0L,0L,0L,1L,4L,8L,0L,0L,0L,4L,1L,8L,3L,16L,0L,0L,0L,0L,4L,5L,2L,0L,7L,0L,0L,0L,4L,2L,9L,3L,9L,18L,17L,0L,0L,0L,0L,2L,2L,0L,10L,12L,11L,2L,0L,0L,0L,4L,0L,2L,8L,2L,17L,7L,23L,31L,0L,0L,0L,0L,3L,6L,7L,3L,11L,24L,0L,6L,6L,0L,0L,0L,4L,3L,3L,4L,0L,22L,20L,23L,10L,30L,16L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276580Inst : IEnumerable<long>
{
public static readonly long[] Value=A276580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276580.Bytes);
public long this[int i]=>Value[i];

public static A276580Inst Instance=new A276580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276581
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,4L,4L,5L,5L,5L,6L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,17L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276581Inst : IEnumerable<long>
{
public static readonly long[] Value=A276581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276581.Bytes);
public long this[int i]=>Value[i];

public static A276581Inst Instance=new A276581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276582
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,8L,7L,6L,11L,10L,9L,14L,13L,12L,18L,17L,16L,15L,23L,22L,21L,20L,19L,28L,27L,26L,25L,24L,34L,33L,32L,31L,30L,29L,40L,39L,38L,37L,36L,35L,47L,46L,45L,44L,43L,42L,41L,54L,53L,52L,51L,50L,49L,48L,61L,60L,59L,58L,57L,56L,55L,69L,68L,67L,66L,65L,64L,63L,62L,77L,76L,75L,74L,73L,72L,71L,70L,86L,85L,84L,83L,82L,81L,80L,79L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276582Inst : IEnumerable<long>
{
public static readonly long[] Value=A276582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276582.Bytes);
public long this[int i]=>Value[i];

public static A276582Inst Instance=new A276582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276583
{
public static readonly long[] Value={ 0L,3L,6L,8L,11L,15L,18L,21L,24L,27L,32L,35L,38L,43L,48L,51L,56L,59L,63L,66L,71L,74L,78L,80L,83L,88L,91L,95L,99L,102L,107L,110L,114L,117L,120L,123L,128L,131L,135L,138L,143L,146L,151L,154L,158L,161L,164L,168L,171L,176L,179L,183L,186L,192L,195L,198L,203L,206L,210L,213L,219L,224L,227L,232L,235L,239L,242L,248L,251L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276583Inst : IEnumerable<long>
{
public static readonly long[] Value=A276583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276583.Bytes);
public long this[int i]=>Value[i];

public static A276583Inst Instance=new A276583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276584
{
public static readonly long[] Value={ 0L,3L,8L,6L,15L,11L,24L,21L,18L,35L,32L,27L,48L,43L,38L,63L,59L,56L,51L,80L,78L,74L,71L,66L,99L,95L,91L,88L,83L,120L,117L,114L,110L,107L,102L,143L,138L,135L,131L,128L,123L,168L,164L,161L,158L,154L,151L,146L,195L,192L,186L,183L,179L,176L,171L,224L,219L,213L,210L,206L,203L,198L,255L,251L,248L,242L,239L,235L,232L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276584Inst : IEnumerable<long>
{
public static readonly long[] Value=A276584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276584.Bytes);
public long this[int i]=>Value[i];

public static A276584Inst Instance=new A276584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276585
{
public static readonly long[] Value={ 0L,3L,3L,2L,3L,4L,3L,3L,3L,3L,5L,3L,3L,5L,5L,3L,5L,3L,4L,3L,5L,3L,4L,2L,3L,5L,3L,4L,4L,3L,5L,3L,4L,3L,3L,3L,5L,3L,4L,3L,5L,3L,5L,3L,4L,3L,3L,4L,3L,5L,3L,4L,3L,6L,3L,3L,5L,3L,4L,3L,6L,5L,3L,5L,3L,4L,3L,6L,3L,4L,3L,5L,3L,4L,3L,6L,3L,6L,3L,5L,3L,4L,3L,6L,3L,5L,3L,3L,5L,3L,4L,3L,6L,3L,5L,3L,2L,3L,5L,3L,4L,3L,6L,3L,5L,3L,4L,3L,5L,3L,4L,3L,6L,3L,5L,3L,3L,3L,3L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276585Inst : IEnumerable<long>
{
public static readonly long[] Value=A276585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276585.Bytes);
public long this[int i]=>Value[i];

public static A276585Inst Instance=new A276585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276586
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,11L,30L,36L,44L,55L,210L,240L,276L,320L,375L,2310L,2520L,2760L,3036L,3356L,3731L,30030L,32340L,34860L,37620L,40656L,44012L,47743L,510510L,540540L,572880L,607740L,645360L,686016L,730028L,777771L,9699690L,10210200L,10750740L,11323620L,11931360L,12576720L,13262736L,13992764L,14770535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276586Inst : IEnumerable<long>
{
public static readonly long[] Value=A276586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276586.Bytes);
public long this[int i]=>Value[i];

public static A276586Inst Instance=new A276586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276587
{
public static readonly long[] Value={ 1L,3L,2L,11L,8L,6L,55L,44L,36L,30L,375L,320L,276L,240L,210L,3731L,3356L,3036L,2760L,2520L,2310L,47743L,44012L,40656L,37620L,34860L,32340L,30030L,777771L,730028L,686016L,645360L,607740L,572880L,540540L,510510L,14770535L,13992764L,13262736L,12576720L,11931360L,11323620L,10750740L,10210200L,9699690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276587Inst : IEnumerable<long>
{
public static readonly long[] Value=A276587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276587.Bytes);
public long this[int i]=>Value[i];

public static A276587Inst Instance=new A276587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276588
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,11L,24L,30L,38L,49L,120L,144L,174L,212L,261L,720L,840L,984L,1158L,1370L,1631L,5040L,5760L,6600L,7584L,8742L,10112L,11743L,40320L,45360L,51120L,57720L,65304L,74046L,84158L,95901L,362880L,403200L,448560L,499680L,557400L,622704L,696750L,780908L,876809L,3628800L,3991680L,4394880L,4843440L,5343120L,5900520L,6523224L,7219974L,8000882L,8877691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276588Inst : IEnumerable<long>
{
public static readonly long[] Value=A276588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276588.Bytes);
public long this[int i]=>Value[i];

public static A276588Inst Instance=new A276588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276589
{
public static readonly long[] Value={ 1L,3L,2L,11L,8L,6L,49L,38L,30L,24L,261L,212L,174L,144L,120L,1631L,1370L,1158L,984L,840L,720L,11743L,10112L,8742L,7584L,6600L,5760L,5040L,95901L,84158L,74046L,65304L,57720L,51120L,45360L,40320L,876809L,780908L,696750L,622704L,557400L,499680L,448560L,403200L,362880L,8877691L,8000882L,7219974L,6523224L,5900520L,5343120L,4843440L,4394880L,3991680L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276589Inst : IEnumerable<long>
{
public static readonly long[] Value=A276589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276589.Bytes);
public long this[int i]=>Value[i];

public static A276589Inst Instance=new A276589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276590
{
public static readonly long[] Value={ 10234567889L,100223456789L,100234566789L,100234567889L,101234556789L,101234567789L,102234456789L,102234566789L,102334556789L,102334567899L,102344456789L,102344567889L,102345567789L,102345666789L,102345677789L,102345678899L,1000223456789L,1000234456789L,1000234566789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276590Inst : IEnumerable<long>
{
public static readonly long[] Value=A276590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276590.Bytes);
public long this[int i]=>Value[i];

public static A276590Inst Instance=new A276590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276591
{
public static readonly long[] Value={ 2L,5L,11L,19L,43L,151L,311L,439L,823L,2551L,6007L,12919L,23159L,35447L,92791L,203383L,535159L,731767L,1124983L,5253751L,6302327L,16919159L,32647799L,103426679L,160049783L,285878903L,386542199L,1066019447L,1468672631L,2676632183L,5092551287L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276591Inst : IEnumerable<long>
{
public static readonly long[] Value=A276591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276591.Bytes);
public long this[int i]=>Value[i];

public static A276591Inst Instance=new A276591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276592
{
public static readonly BigInteger[] Value={ 1L,1L,1L,17L,31L,691L,5461L,929569L,3202291L,221930581L,4722116521L,56963745931L,14717667114151L,2093660879252671L,86125672563201181L,BigInteger.Parse("129848163681107301953"),BigInteger.Parse("868320396104950823611"),BigInteger.Parse("209390615747646519456961"),BigInteger.Parse("14129659550745551130667441"),BigInteger.Parse("16103843159579478297227731") };
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
public class A276592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276592Inst Instance=new A276592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276593
{
public static readonly BigInteger[] Value={ 8L,96L,960L,161280L,2903040L,638668800L,49816166400L,83691159552000L,2845499424768000L,1946321606541312000L,BigInteger.Parse("408727537373675520000"),BigInteger.Parse("48662619743783485440000"),BigInteger.Parse("124089680346647887872000000"),BigInteger.Parse("174221911206693634572288000000"),BigInteger.Parse("70734095949917615636348928000000") };
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
public class A276593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276593Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276593.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276593.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276593Inst Instance=new A276593Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276594
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,691L,1L,3617L,43867L,174611L,77683L,236364091L,657931L,3392780147L,1723168255201L,7709321041217L,151628697551L,BigInteger.Parse("26315271553053477373"),154210205991661L,BigInteger.Parse("261082718496449122051"),BigInteger.Parse("1520097643918070802691"),BigInteger.Parse("2530297234481911294093") };
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
public class A276594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276594Inst Instance=new A276594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276595
{
public static readonly BigInteger[] Value={ 24L,1440L,60480L,2419200L,95800320L,2615348736000L,149448499200L,21341245685760000L,10218188434341888000UL,BigInteger.Parse("1605715325396582400000"),BigInteger.Parse("28202200078783610880000"),BigInteger.Parse("3387648273463487338905600000"),BigInteger.Parse("372269041039943663616000000"),BigInteger.Parse("75786531374911731038945280000000") };
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
public class A276595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276595.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276595Inst Instance=new A276595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276628
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,14L,16L,18L,20L,21L,22L,25L,26L,27L,32L,34L,38L,39L,42L,46L,49L,50L,52L,54L,55L,57L,58L,62L,64L,68L,74L,78L,81L,82L,86L,93L,94L,98L,100L,106L,110L,111L,114L,116L,118L,121L,122L,125L,128L,129L,134L,136L,142L,146L,147L,148L,155L,156L,158L,162L,164L,166L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276628Inst : IEnumerable<long>
{
public static readonly long[] Value=A276628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276628.Bytes);
public long this[int i]=>Value[i];

public static A276628Inst Instance=new A276628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276629
{
public static readonly long[] Value={ 2L,3L,5L,17L,101L,1601L,65537L,2365849601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276629Inst : IEnumerable<long>
{
public static readonly long[] Value=A276629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276629.Bytes);
public long this[int i]=>Value[i];

public static A276629Inst Instance=new A276629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276630
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,2L,2L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,2L,2L,2L,1L,1L,1L,2L,3L,2L,2L,0L,1L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276630Inst : IEnumerable<long>
{
public static readonly long[] Value=A276630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276630.Bytes);
public long this[int i]=>Value[i];

public static A276630Inst Instance=new A276630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276631
{
public static readonly long[] Value={ 0L,1L,2L,4L,1L,1L,1L,1L,3L,1L,1L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,8L,7L,1L,3L,1L,1L,1L,1L,1L,6L,2L,1L,5L,2L,2L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,1L,1L,6L,5L,3L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,1L,10L,3L,4L,4L,4L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276631Inst : IEnumerable<long>
{
public static readonly long[] Value=A276631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276631.Bytes);
public long this[int i]=>Value[i];

public static A276631Inst Instance=new A276631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276632
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,2L,7L,2L,3L,3L,11L,2L,13L,3L,3L,2L,17L,2L,19L,3L,4L,4L,23L,2L,5L,5L,3L,3L,29L,3L,31L,2L,5L,5L,5L,2L,37L,6L,6L,3L,41L,3L,43L,4L,3L,6L,47L,2L,7L,3L,7L,5L,53L,2L,7L,3L,7L,7L,59L,3L,61L,7L,4L,2L,8L,4L,67L,5L,8L,4L,71L,2L,73L,8L,3L,6L,8L,4L,79L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276632Inst : IEnumerable<long>
{
public static readonly long[] Value=A276632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276632.Bytes);
public long this[int i]=>Value[i];

public static A276632Inst Instance=new A276632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276633
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,22L,33L,11L,20L,34L,15L,26L,30L,14L,25L,36L,17L,24L,35L,16L,27L,38L,19L,40L,23L,18L,44L,29L,13L,45L,28L,31L,46L,50L,12L,37L,48L,21L,39L,47L,51L,32L,49L,55L,60L,41L,52L,63L,70L,42L,53L,61L,72L,43L,56L,71L,80L,54L,62L,73L,58L,64L,77L,59L,66L,74L,81L,65L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276633Inst : IEnumerable<long>
{
public static readonly long[] Value=A276633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276633.Bytes);
public long this[int i]=>Value[i];

public static A276633Inst Instance=new A276633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276634
{
public static readonly long[] Value={ 0L,1L,1L,9L,1L,36L,1L,73L,28L,134L,1L,316L,1L,352L,153L,585L,1L,981L,1L,1198L,371L,1340L,1L,2556L,126L,2206L,757L,3160L,1L,4752L,1L,4681L,1359L,4922L,469L,8605L,1L,6868L,2225L,9710L,1L,12600L,1L,12052L,4257L,12176L,1L,20476L,344L,16759L,4941L,19846L,1L,26496L,1457L,25624L,6887L,24398L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276634Inst : IEnumerable<long>
{
public static readonly long[] Value=A276634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276634.Bytes);
public long this[int i]=>Value[i];

public static A276634Inst Instance=new A276634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276635
{
public static readonly long[] Value={ 4L,4L,3L,0L,0L,1L,4L,5L,7L,4L,3L,8L,8L,3L,8L,0L,5L,6L,6L,7L,4L,4L,1L,9L,2L,6L,9L,9L,9L,2L,7L,1L,9L,0L,4L,6L,6L,9L,7L,5L,0L,2L,2L,6L,0L,5L,5L,5L,1L,9L,6L,4L,6L,2L,7L,9L,2L,0L,1L,2L,0L,9L,6L,6L,8L,6L,0L,6L,0L,3L,1L,3L,1L,0L,6L,4L,0L,4L,9L,1L,9L,9L,9L,9L,0L,0L,0L,4L,8L,4L,1L,0L,0L,6L,6L,8L,9L,8L,6L,8L,8L,2L,0L,7L,9L,5L,9L,0L,8L,1L,3L,6L,1L,6L,9L,4L,1L,7L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276635Inst : IEnumerable<long>
{
public static readonly long[] Value=A276635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276635.Bytes);
public long this[int i]=>Value[i];

public static A276635Inst Instance=new A276635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276636
{
public static readonly BigInteger[] Value={ 1L,0L,1L,12L,761L,87336L,18528505L,6376563600L,3338759427857L,2524750777586976L,2648982517454387281L,BigInteger.Parse("3733860677541032881728"),BigInteger.Parse("6885982148044369769847497"),BigInteger.Parse("16251753910337100552968630400") };
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
public class A276636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276636Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276636.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276636.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276636Inst Instance=new A276636Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276637
{
public static readonly BigInteger[] Value={ 1L,16L,936L,87336L,9929000L,1267945800L,174470351760L,25288627665840L,3812023555600680L,591698219294831040L,BigInteger.Parse("94094630284245419136"),BigInteger.Parse("15245574601442117896656"),BigInteger.Parse("2511237778001138580615056"),BigInteger.Parse("419023242828557373939828896"),BigInteger.Parse("70761397145460782667032755200") };
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
public class A276637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276637Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276637.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276637.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276637Inst Instance=new A276637Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276638
{
public static readonly long[] Value={ 0L,1L,2L,1L,4L,3L,4L,3L,6L,3L,6L,3L,8L,5L,8L,5L,6L,5L,6L,7L,8L,7L,10L,7L,8L,7L,12L,7L,12L,7L,12L,7L,12L,7L,14L,9L,14L,9L,14L,9L,14L,9L,14L,9L,14L,11L,16L,11L,14L,11L,16L,11L,18L,11L,16L,11L,16L,11L,16L,11L,20L,13L,16L,13L,18L,13L,16L,13L,18L,13L,18L,13L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276638Inst : IEnumerable<long>
{
public static readonly long[] Value=A276638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276638.Bytes);
public long this[int i]=>Value[i];

public static A276638Inst Instance=new A276638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276639
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,16L,15L,6L,1L,30L,135L,222L,205L,120L,45L,10L,1L,15L,330L,1581L,3760L,5715L,6165L,4945L,2997L,1365L,455L,105L,15L,1L,315L,4410L,23604L,73755L,159390L,259105L,331716L,343161L,290745L,202755L,116175L,54257L,20349L,5985L,1330L,210L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276639Inst : IEnumerable<long>
{
public static readonly long[] Value=A276639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276639.Bytes);
public long this[int i]=>Value[i];

public static A276639Inst Instance=new A276639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276640
{
public static readonly long[] Value={ 1L,3L,1L,16L,15L,6L,1L,125L,222L,205L,120L,45L,10L,1L,90L,1356L,3670L,5700L,6165L,4945L,2997L,1365L,455L,105L,15L,1L,1680L,18942L,69450L,156870L,258160L,331506L,343140L,290745L,202755L,116175L,54257L,20349L,5985L,1330L,210L,21L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276640Inst : IEnumerable<long>
{
public static readonly long[] Value=A276640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276640.Bytes);
public long this[int i]=>Value[i];

public static A276640Inst Instance=new A276640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276641
{
public static readonly long[] Value={ 1L,3L,10L,39L,2466L,39457L,157827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276641Inst : IEnumerable<long>
{
public static readonly long[] Value=A276641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276641.Bytes);
public long this[int i]=>Value[i];

public static A276641Inst Instance=new A276641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276642
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,8L,10L,14L,15L,62L,98L,184L,190L,389L,430L,815L,918L,1124L,1284L,9544L,10068L,16514L,24756L,39880L,86478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276642Inst : IEnumerable<long>
{
public static readonly long[] Value=A276642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276642.Bytes);
public long this[int i]=>Value[i];

public static A276642Inst Instance=new A276642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276643
{
public static readonly long[] Value={ 1L,4L,10L,20L,35L,56L,84L,120L,165L,220L,282L,348L,415L,480L,540L,592L,633L,660L,670L,660L,633L,592L,540L,480L,415L,348L,282L,220L,165L,120L,84L,56L,35L,20L,10L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276643Inst : IEnumerable<long>
{
public static readonly long[] Value=A276643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276643.Bytes);
public long this[int i]=>Value[i];

public static A276643Inst Instance=new A276643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276660
{
public static readonly long[] Value={ 2L,5L,11L,13L,19L,23L,37L,43L,47L,61L,67L,73L,79L,103L,151L,157L,163L,191L,193L,211L,223L,271L,277L,283L,313L,331L,367L,383L,397L,421L,457L,463L,487L,523L,541L,547L,607L,613L,631L,661L,673L,691L,733L,751L,757L,787L,823L,877L,907L,991L,997L,1051L,1087L,1093L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276660Inst : IEnumerable<long>
{
public static readonly long[] Value=A276660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276660.Bytes);
public long this[int i]=>Value[i];

public static A276660Inst Instance=new A276660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276661
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,13L,24L,44L,84L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276661Inst : IEnumerable<long>
{
public static readonly long[] Value=A276661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276661.Bytes);
public long this[int i]=>Value[i];

public static A276661Inst Instance=new A276661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276662
{
public static readonly long[] Value={ 311L,1129L,37L,773L,313L,311L,1129L,313L,3119014487L,31079L,317L,773L,1129L,3110647L,3103819425079L,310397L,5113L,31079L,3109L,3137L,310361L,31259L,331L,36389L,191176757654383L,31063L,337L,523L,324941L,31393L,127139L,33769L,31034567124791L,32369L,719L,5623L,347L,3371L,131777L,349L,31039L,34412909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276662Inst : IEnumerable<long>
{
public static readonly long[] Value=A276662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276662.Bytes);
public long this[int i]=>Value[i];

public static A276662Inst Instance=new A276662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276663
{
public static readonly BigInteger[] Value={ 5L,11L,39L,139L,8215L,131103L,524323L,2147483707L,2305843009213694071L,BigInteger.Parse("618970019642690137449562287"),BigInteger.Parse("162259276829213363391578010288339"),BigInteger.Parse("170141183460469231731687303715884105979") };
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
public class A276663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276663Inst Instance=new A276663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276664
{
public static readonly long[] Value={ 2L,1L,6L,9L,11L,11L,23L,15L,29L,23L,27L,35L,35L,33L,41L,59L,71L,59L,69L,59L,71L,87L,89L,95L,95L,95L,117L,101L,107L,119L,129L,131L,119L,135L,155L,171L,179L,153L,185L,179L,167L,191L,179L,167L,179L,207L,195L,213L,221L,215L,239L,215L,227L,251L,263L,245L,251L,291L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276664Inst : IEnumerable<long>
{
public static readonly long[] Value=A276664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276664.Bytes);
public long this[int i]=>Value[i];

public static A276664Inst Instance=new A276664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276665
{
public static readonly long[] Value={ 1L,2L,3L,7L,27L,703L,26623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276665Inst : IEnumerable<long>
{
public static readonly long[] Value=A276665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276665.Bytes);
public long this[int i]=>Value[i];

public static A276665Inst Instance=new A276665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276666
{
public static readonly long[] Value={ -1L,0L,2L,10L,42L,168L,660L,2574L,10010L,38896L,151164L,587860L,2288132L,8914800L,34767720L,135727830L,530365050L,2074316640L,8119857900L,31810737420L,124718287980L,489325340400L,1921133836440L,7547311500300L,29667795388452L,116686713634848L,459183826803800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276666Inst : IEnumerable<long>
{
public static readonly long[] Value=A276666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276666.Bytes);
public long this[int i]=>Value[i];

public static A276666Inst Instance=new A276666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276667
{
public static readonly BigInteger[] Value={ 1L,-1L,7L,-31L,381L,-268275L,190954395L,-8940271725L,336335206772565L,-174821527924918875L,BigInteger.Parse("54202314805255255275"),BigInteger.Parse("-5543854406384412644150625"),BigInteger.Parse("3114120189113602279924264875"),BigInteger.Parse("-14151357141482747539875264868125"),BigInteger.Parse("10216485085859695459247479126412709375") };
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
public class A276667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276667.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276667Inst Instance=new A276667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276668
{
public static readonly long[] Value={ 1L,12L,120L,56L,16L,88L,208L,16L,544L,152L,16L,368L,32L,16L,928L,992L,64L,8L,592L,16L,1312L,688L,32L,1504L,64L,16L,1696L,32L,64L,1888L,3904L,64L,128L,536L,16L,1136L,2336L,16L,32L,2528L,64L,1328L,32L,32L,5696L,32L,64L,64L,12416L,16L,3232L,3296L,64L,3424L,6976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276668Inst : IEnumerable<long>
{
public static readonly long[] Value=A276668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276668.Bytes);
public long this[int i]=>Value[i];

public static A276668Inst Instance=new A276668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276669
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,0L,3L,4L,2L,1L,3L,0L,4L,6L,5L,2L,3L,1L,4L,0L,5L,8L,6L,7L,3L,2L,4L,1L,5L,0L,6L,10L,7L,9L,8L,3L,4L,2L,5L,1L,6L,0L,7L,12L,8L,11L,9L,10L,4L,3L,5L,2L,6L,1L,7L,0L,8L,14L,9L,13L,10L,12L,11L,4L,5L,3L,6L,2L,7L,1L,8L,0L,9L,16L,10L,15L,11L,14L,12L,13L,5L,4L,6L,3L,7L,2L,8L,1L,9L,0L,10L,18L,11L,17L,12L,16L,13L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276669Inst : IEnumerable<long>
{
public static readonly long[] Value=A276669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276669.Bytes);
public long this[int i]=>Value[i];

public static A276669Inst Instance=new A276669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276670
{
public static readonly long[] Value={ 0L,0L,3L,6L,15L,30L,105L,84L,126L,180L,495L,330L,429L,546L,1365L,840L,1020L,1224L,2907L,1710L,1995L,2310L,5313L,3036L,3450L,3900L,8775L,4914L,5481L,6090L,13485L,7440L,8184L,8976L,19635L,10710L,11655L,12654L,27417L,14820L,15990L,17220L,37023L,19866L,21285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276670Inst : IEnumerable<long>
{
public static readonly long[] Value=A276670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276670.Bytes);
public long this[int i]=>Value[i];

public static A276670Inst Instance=new A276670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276671
{
public static readonly long[] Value={ 1L,2929L,9742277641L,23341869101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276671Inst : IEnumerable<long>
{
public static readonly long[] Value=A276671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276671.Bytes);
public long this[int i]=>Value[i];

public static A276671Inst Instance=new A276671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276672
{
public static readonly long[] Value={ 1L,3L,4L,9L,10L,12L,13L,16L,20L,37L,57L,66L,106L,116L,127L,355L,396L,547L,2289L,3777L,4500L,7821L,15663L,22746L,25978L,30434L,39682L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276672Inst : IEnumerable<long>
{
public static readonly long[] Value=A276672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276672.Bytes);
public long this[int i]=>Value[i];

public static A276672Inst Instance=new A276672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276673
{
public static readonly long[] Value={ 1L,2L,3L,4L,8L,19L,23L,25L,28L,65L,171L,183L,187L,295L,351L,471L,561L,634L,710L,1726L,3947L,4247L,6009L,11065L,13567L,94493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276673Inst : IEnumerable<long>
{
public static readonly long[] Value=A276673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276673.Bytes);
public long this[int i]=>Value[i];

public static A276673Inst Instance=new A276673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276674
{
public static readonly long[] Value={ 21L,28L,45L,46L,51L,64L,65L,77L,82L,85L,91L,106L,111L,126L,129L,133L,136L,148L,155L,166L,172L,175L,185L,189L,205L,208L,209L,217L,221L,225L,231L,232L,235L,237L,244L,247L,267L,273L,274L,276L,286L,291L,298L,305L,316L,319L,326L,333L,339L,341L,358L,362L,364L,365L,371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276674Inst : IEnumerable<long>
{
public static readonly long[] Value=A276674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276674.Bytes);
public long this[int i]=>Value[i];

public static A276674Inst Instance=new A276674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276675
{
public static readonly long[] Value={ 0L,1L,0L,0L,2L,0L,0L,0L,1L,1L,0L,1L,2L,0L,1L,3L,0L,0L,0L,0L,2L,1L,0L,0L,0L,3L,0L,0L,1L,0L,1L,0L,2L,0L,1L,0L,3L,0L,1L,0L,4L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,3L,1L,0L,0L,0L,1L,2L,0L,0L,0L,0L,4L,0L,0L,1L,0L,2L,1L,0L,1L,0L,0L,1L,0L,3L,1L,0L,1L,0L,1L,1L,0L,0L,0L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276675Inst : IEnumerable<long>
{
public static readonly long[] Value=A276675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276675.Bytes);
public long this[int i]=>Value[i];

public static A276675Inst Instance=new A276675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276692
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,11L,23L,46L,85L,341L,1471L,2942L,5461L,21845L,349525L,1398101L,6025215L,12050430L,22369621L,89478485L,1431655765L,5726623061L,91625968981L,366503875925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276692Inst : IEnumerable<long>
{
public static readonly long[] Value=A276692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276692.Bytes);
public long this[int i]=>Value[i];

public static A276692Inst Instance=new A276692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276693
{
public static readonly BigInteger[] Value={ 3L,5L,7L,8L,27L,29L,187L,596L,4827L,106625L,2770267L,511908608L,294867810267L,1417828655948069L,BigInteger.Parse("150943952469132130267"),BigInteger.Parse("418071880169258361764894156"),BigInteger.Parse("214012660834726939177944668730210267"),BigInteger.Parse("63105422008735225121538219609433904551328809385") };
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
public class A276693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276693Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A276693.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A276693.Bytes);
public BigInteger this[int i]=>Value[i];

public static A276693Inst Instance=new A276693Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276694
{
public static readonly long[] Value={ 0L,11L,13L,101L,107L,177L,357L,1001L,1011L,10759L,11487L,42189L,113183L,344253L,1851759L,4787769L,15848679L,139367847L,240889077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276694Inst : IEnumerable<long>
{
public static readonly long[] Value=A276694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276694.Bytes);
public long this[int i]=>Value[i];

public static A276694Inst Instance=new A276694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276695
{
public static readonly long[] Value={ 0L,2L,-1L,-2L,0L,2L,-6L,4L,-6L,6L,4L,2L,6L,10L,6L,-6L,-12L,2L,-2L,12L,2L,-8L,-6L,-6L,2L,6L,-14L,6L,2L,-6L,-2L,0L,18L,4L,-6L,-20L,-22L,10L,-18L,-6L,12L,-10L,12L,26L,18L,-8L,16L,10L,6L,14L,-6L,24L,14L,0L,-6L,18L,18L,-20L,26L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276695Inst : IEnumerable<long>
{
public static readonly long[] Value=A276695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276695.Bytes);
public long this[int i]=>Value[i];

public static A276695Inst Instance=new A276695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276696
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,4L,2L,1L,1L,3L,6L,5L,3L,1L,1L,3L,9L,8L,8L,3L,1L,1L,4L,12L,14L,16L,9L,4L,1L,1L,4L,16L,20L,30L,19L,13L,4L,1L,1L,5L,20L,30L,50L,39L,32L,14L,5L,1L,1L,5L,25L,40L,80L,69L,71L,36L,19L,5L,1L,1L,6L,30L,55L,120L,119L,140L,85L,55L,20L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276696Inst : IEnumerable<long>
{
public static readonly long[] Value=A276696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276696.Bytes);
public long this[int i]=>Value[i];

public static A276696Inst Instance=new A276696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276697
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1000L,1042L,2000L,3000L,4000L,5000L,6000L,7000L,8000L,9000L,321213L,642426L,1000000L,1042000L,2000000L,3000000L,4000000L,5000000L,6000000L,7000000L,8000000L,9000000L,10121026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276697Inst : IEnumerable<long>
{
public static readonly long[] Value=A276697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276697.Bytes);
public long this[int i]=>Value[i];

public static A276697Inst Instance=new A276697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276698
{
public static readonly long[] Value={ 1L,2L,7L,17L,24L,32L,66L,67L,74L,92L,104L,117L,188L,260L,279L,336L,348L,369L,547L,619L,860L,2735L,7932L,11874L,14867L,40153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276698Inst : IEnumerable<long>
{
public static readonly long[] Value=A276698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276698.Bytes);
public long this[int i]=>Value[i];

public static A276698Inst Instance=new A276698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276699
{
public static readonly long[] Value={ 14L,297L,869L,1241L,1349L,1541L,1769L,1829L,1961L,2021L,82091L,88931L,98171L,100739L,105779L,111899L,116651L,122411L,125771L,130139L,135419L,139499L,150971L,152771L,157979L,158819L,165251L,169739L,173939L,174611L,177851L,182051L,183731L,188339L,189731L,193091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276699Inst : IEnumerable<long>
{
public static readonly long[] Value=A276699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276699.Bytes);
public long this[int i]=>Value[i];

public static A276699Inst Instance=new A276699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276700
{
public static readonly long[] Value={ 1L,21L,25L,30L,32L,36L,392L,441L,525L,560L,625L,630L,672L,750L,756L,800L,900L,960L,979L,1024L,1080L,1152L,1215L,1296L,1411L,1458L,1463L,1547L,1742L,1947L,2059L,2090L,2210L,2318L,2405L,2419L,2444L,2491L,2508L,2552L,2652L,2703L,2871L,2886L,2924L,2945L,3116L,3128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276700Inst : IEnumerable<long>
{
public static readonly long[] Value=A276700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276700.Bytes);
public long this[int i]=>Value[i];

public static A276700Inst Instance=new A276700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276701
{
public static readonly long[] Value={ 1L,3L,6L,20259L,43912L,563103L,18895035L,119847148L,305478634710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276701Inst : IEnumerable<long>
{
public static readonly long[] Value=A276701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276701.Bytes);
public long this[int i]=>Value[i];

public static A276701Inst Instance=new A276701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276702
{
public static readonly long[] Value={ 28L,2056L,2865L,7157404L,10181420L,39593464L,92261602845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276702Inst : IEnumerable<long>
{
public static readonly long[] Value=A276702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276702.Bytes);
public long this[int i]=>Value[i];

public static A276702Inst Instance=new A276702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276703
{
public static readonly long[] Value={ 0L,4L,14L,14L,14L,70L,70L,70L,90L,90L,90L,90L,90L,90L,90L,90L,90L,121L,121L,121L,121L,121L,121L,126L,126L,126L,126L,126L,172L,172L,172L,172L,172L,172L,174L,174L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L,2260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276703Inst : IEnumerable<long>
{
public static readonly long[] Value=A276703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276703.Bytes);
public long this[int i]=>Value[i];

public static A276703Inst Instance=new A276703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A276704
{
public static readonly long[] Value={ 3L,5L,6L,21L,45L,77L,117L,165L,221L,285L,357L,437L,525L,621L,725L,837L,957L,1085L,1221L,1365L,1517L,1677L,1845L,2021L,2205L,2397L,2597L,2805L,3021L,3245L,3477L,3717L,3965L,4221L,4485L,4757L,5037L,5325L,5621L,5925L,6237L,6557L,6885L,7221L,7565L,7917L,8277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A276704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A276704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A276704Inst : IEnumerable<long>
{
public static readonly long[] Value=A276704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A276704.Bytes);
public long this[int i]=>Value[i];

public static A276704Inst Instance=new A276704Inst();

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