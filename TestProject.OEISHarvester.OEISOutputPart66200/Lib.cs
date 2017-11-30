using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A094753
{
public static readonly long[] Value={ 1L,3L,1L,0L,9L,1L,0L,15L,1L,0L,21L,0L,5L,3L,1L,0L,33L,1L,0L,39L,1L,0L,45L,0L,0L,1L,0L,11L,57L,1L,0L,7L,1L,0L,1L,1L,0L,25L,7L,0L,81L,0L,17L,3L,0L,0L,0L,1L,0L,99L,1L,0L,105L,1L,0L,111L,0L,23L,117L,0L,0L,123L,1L,0L,1L,0L,0L,15L,1L,0L,0L,13L,5L,147L,1L,0L,3L,1L,0L,53L,1L,0L,15L,0L,0L,171L,0L,5L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094753Inst : IEnumerable<long>
{
public static readonly long[] Value=A094753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094753.Bytes);
public long this[int i]=>Value[i];

public static A094753Inst Instance=new A094753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094754
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,-1L,1L,0L,1L,1L,1L,-1L,1L,-1L,-1L,0L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,0L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A094754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094754Inst : IEnumerable<long>
{
public static readonly long[] Value=A094754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A094754.Bytes);
public long this[int i]=>Value[i];

public static A094754Inst Instance=new A094754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A094755
{
public static readonly BigInteger[] Value={ 1L,3L,3L,167L,11L,489L,43L,282407L,171L,110865L,683L,3710553451913L,2731L,27323481L,10923L,1293248801687L,43691L,6910715937L,174763L,2983746256027727L,699051L,1762357129833L,2796203L,BigInteger.Parse("734630194457006903941170593"),11184811L };
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
public class A094755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A094755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A094755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A094755.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A094755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A094755Inst Instance=new A094755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095012
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,4L,6L,12L,17L,36L,62L,118L,222L,395L,773L,1412L,2699L,5100L,9690L,18384L,35074L,67076L,128446L,246483L,473737L,911126L,1757021L,3390639L,6551367L,12675525L,24545392L,47584301L,92330675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095012Inst : IEnumerable<long>
{
public static readonly long[] Value=A095012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095012.Bytes);
public long this[int i]=>Value[i];

public static A095012Inst Instance=new A095012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095013
{
public static readonly long[] Value={ 0L,1L,0L,3L,2L,8L,10L,22L,35L,67L,126L,233L,438L,793L,1525L,2825L,5391L,10192L,19332L,36739L,70163L,133983L,256877L,492962L,946938L,1822776L,3513544L,6780795L,13102754L,25349101L,49090527L,95168113L,184659769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095013Inst : IEnumerable<long>
{
public static readonly long[] Value=A095013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095013.Bytes);
public long this[int i]=>Value[i];

public static A095013Inst Instance=new A095013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095014
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,5L,13L,21L,40L,70L,129L,231L,434L,819L,1505L,2884L,5358L,10198L,19303L,36847L,70173L,134233L,256831L,492856L,947182L,1822968L,3513746L,6781112L,13104524L,25348436L,49092129L,95167472L,184663536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095014Inst : IEnumerable<long>
{
public static readonly long[] Value=A095014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095014.Bytes);
public long this[int i]=>Value[i];

public static A095014Inst Instance=new A095014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095015
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,7L,11L,20L,37L,69L,126L,228L,434L,806L,1514L,2845L,5361L,10212L,19308L,36747L,70135L,134065L,256824L,492871L,946880L,1822913L,3513737L,6780428L,13103565L,25348226L,49090715L,95167496L,184660541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095015Inst : IEnumerable<long>
{
public static readonly long[] Value=A095015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095015.Bytes);
public long this[int i]=>Value[i];

public static A095015Inst Instance=new A095015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095016
{
public static readonly long[] Value={ 0L,1L,1L,3L,4L,6L,12L,23L,38L,68L,129L,236L,438L,806L,1516L,2864L,5388L,10178L,19327L,36839L,70201L,134151L,256884L,492947L,947240L,1822831L,3513553L,6781479L,13103713L,25349311L,49091941L,95168089L,184662764L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095016Inst : IEnumerable<long>
{
public static readonly long[] Value=A095016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095016.Bytes);
public long this[int i]=>Value[i];

public static A095016Inst Instance=new A095016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095017
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,7L,7L,12L,26L,45L,70L,113L,215L,355L,666L,1153L,2071L,3785L,6965L,12495L,22643L,41608L,76371L,140944L,261752L,484968L,904799L,1689477L,3160113L,5928904L,11139071L,20970782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095017Inst : IEnumerable<long>
{
public static readonly long[] Value=A095017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095017.Bytes);
public long this[int i]=>Value[i];

public static A095017Inst Instance=new A095017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095018
{
public static readonly long[] Value={ 1L,0L,2L,4L,17L,28L,189L,531L,1990L,5747L,23902L,76658L,291478L,982793L,3677580L,13214719L,49161612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095018Inst : IEnumerable<long>
{
public static readonly long[] Value=A095018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095018.Bytes);
public long this[int i]=>Value[i];

public static A095018Inst Instance=new A095018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095019
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,3L,3L,11L,10L,40L,52L,130L,154L,482L,649L,1756L,2483L,6479L,9640L,24022L,34812L,89306L,136739L,335115L,510833L,1265350L,1982321L,4781514L,7508064L,18079040L,28833595L,68709969L,110272081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095019Inst : IEnumerable<long>
{
public static readonly long[] Value=A095019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095019.Bytes);
public long this[int i]=>Value[i];

public static A095019Inst Instance=new A095019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095020
{
public static readonly long[] Value={ 1L,2L,2L,4L,5L,10L,16L,32L,48L,97L,175L,334L,529L,1130L,1850L,3953L,6276L,13911L,23248L,49564L,81622L,178910L,300311L,650703L,1091809L,2380394L,4062176L,8780393L,15021634L,32618497L,56134342L,121625616L,209889612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095020Inst : IEnumerable<long>
{
public static readonly long[] Value=A095020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095020.Bytes);
public long this[int i]=>Value[i];

public static A095020Inst Instance=new A095020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095021
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,7L,9L,19L,33L,64L,115L,216L,402L,754L,1434L,2669L,5116L,9651L,18382L,35064L,67056L,128394L,246349L,473469L,911468L,1757069L,3389718L,6551877L,12674065L,24546590L,47581820L,92330910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095021Inst : IEnumerable<long>
{
public static readonly long[] Value=A095021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095021.Bytes);
public long this[int i]=>Value[i];

public static A095021Inst Instance=new A095021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095022
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,4L,5L,11L,22L,33L,65L,117L,220L,404L,762L,1422L,2693L,5123L,9634L,18409L,35112L,67061L,128302L,246706L,473477L,911557L,1756669L,3390509L,6552186L,12674857L,24545491L,47584387L,92331524L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095022Inst : IEnumerable<long>
{
public static readonly long[] Value=A095022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095022.Bytes);
public long this[int i]=>Value[i];

public static A095022Inst Instance=new A095022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095023
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,4L,5L,11L,18L,36L,63L,117L,220L,407L,760L,1435L,2682L,5074L,9683L,18392L,35113L,67054L,128503L,246433L,473717L,911310L,1756933L,3390711L,6551833L,12673497L,24546404L,47584981L,92331321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095023Inst : IEnumerable<long>
{
public static readonly long[] Value=A095023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095023.Bytes);
public long this[int i]=>Value[i];

public static A095023Inst Instance=new A095023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095024
{
public static readonly long[] Value={ 0L,0L,0L,2L,1L,3L,6L,12L,16L,35L,63L,115L,216L,399L,754L,1418L,2705L,5077L,9667L,18403L,35047L,67045L,128509L,246330L,473457L,911409L,1756619L,3390969L,6551382L,12675118L,24544171L,47584397L,92329550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095024Inst : IEnumerable<long>
{
public static readonly long[] Value=A095024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095024.Bytes);
public long this[int i]=>Value[i];

public static A095024Inst Instance=new A095024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095025
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,1L,1L,2L,0L,2L,1L,0L,1L,2L,0L,1L,1L,1L,1L,0L,2L,1L,1L,3L,1L,3L,0L,1L,0L,0L,1L,1L,4L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,6L,0L,2L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095025Inst : IEnumerable<long>
{
public static readonly long[] Value=A095025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095025.Bytes);
public long this[int i]=>Value[i];

public static A095025Inst Instance=new A095025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095026
{
public static readonly long[] Value={ 1L,3L,1L,5L,2L,2L,8L,2L,4L,2L,9L,4L,4L,4L,4L,15L,2L,6L,5L,6L,2L,13L,6L,6L,6L,6L,6L,6L,20L,4L,8L,4L,12L,4L,8L,4L,21L,6L,6L,12L,6L,6L,12L,6L,6L,27L,4L,12L,4L,12L,9L,12L,4L,12L,4L,21L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,40L,4L,8L,10L,16L,4L,20L,4L,16L,10L,8L,4L,25L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095026Inst : IEnumerable<long>
{
public static readonly long[] Value=A095026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095026.Bytes);
public long this[int i]=>Value[i];

public static A095026Inst Instance=new A095026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095027
{
public static readonly BigInteger[] Value={ 65L,2059L,19171L,1586131L,1161737179L,94134790219L,450283768452043891L,BigInteger.Parse("7509466514977363620705281135650699"),BigInteger.Parse("2909321189362570189660446183802104997118371"),BigInteger.Parse("19088056323407826916968161259086927505582748291") };
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
public class A095027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095027Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095027.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095027.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095027Inst Instance=new A095027Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095060
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,9L,16L,25L,50L,83L,150L,286L,540L,975L,1865L,3515L,6588L,12620L,23835L,45486L,86811L,165822L,317770L,608517L,1170182L,2254124L,4342530L,8383468L,16197159L,31335332L,60680818L,117633364L,228260489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095060Inst : IEnumerable<long>
{
public static readonly long[] Value=A095060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095060.Bytes);
public long this[int i]=>Value[i];

public static A095060Inst Instance=new A095060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095061
{
public static readonly long[] Value={ 0L,0L,0L,2L,4L,4L,7L,18L,25L,54L,105L,178L,332L,637L,1165L,2194L,4161L,7770L,14800L,28100L,53525L,102394L,195938L,377301L,723938L,1391620L,2684760L,5178439L,10010119L,19362205L,37501838L,72702221L,141062816L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095061Inst : IEnumerable<long>
{
public static readonly long[] Value=A095061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095061.Bytes);
public long this[int i]=>Value[i];

public static A095061Inst Instance=new A095061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095062
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,7L,12L,14L,27L,50L,91L,178L,335L,611L,1156L,2147L,4042L,7831L,14724L,28227L,53736L,102482L,196303L,376121L,723408L,1393572L,2683465L,5180304L,10009707L,19366479L,37509260L,72706948L,141074303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095062Inst : IEnumerable<long>
{
public static readonly long[] Value=A095062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095062.Bytes);
public long this[int i]=>Value[i];

public static A095062Inst Instance=new A095062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095063
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,7L,14L,22L,41L,70L,133L,261L,433L,800L,1468L,2883L,5445L,10033L,19388L,36902L,70168L,134005L,256771L,493088L,947153L,1822376L,3514806L,6780667L,13103439L,25351723L,49085715L,95166843L,184656849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095063Inst : IEnumerable<long>
{
public static readonly long[] Value=A095063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095063.Bytes);
public long this[int i]=>Value[i];

public static A095063Inst Instance=new A095063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095064
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,6L,9L,21L,34L,67L,122L,203L,439L,812L,1562L,2826L,5304L,10357L,19247L,36684L,70168L,134211L,256937L,492730L,946967L,1823368L,3512484L,6781240L,13103839L,25345814L,49096941L,95168742L,184666456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095064Inst : IEnumerable<long>
{
public static readonly long[] Value=A095064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095064.Bytes);
public long this[int i]=>Value[i];

public static A095064Inst Instance=new A095064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095065
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,4L,9L,6L,19L,28L,54L,109L,210L,373L,707L,1316L,2497L,4827L,9127L,17467L,33212L,63161L,121404L,232455L,446846L,860466L,1658020L,3200462L,6184814L,11971998L,23184215L,44934259L,87179855L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095065Inst : IEnumerable<long>
{
public static readonly long[] Value=A095065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095065.Bytes);
public long this[int i]=>Value[i];

public static A095065Inst Instance=new A095065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095066
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,1L,6L,9L,15L,34L,63L,114L,206L,386L,725L,1366L,2601L,4803L,9144L,17331L,33106L,63067L,121112L,233785L,447721L,860033L,1659656L,3200843L,6188292L,11966122L,23175696L,44928209L,87187514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095066Inst : IEnumerable<long>
{
public static readonly long[] Value=A095066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095066.Bytes);
public long this[int i]=>Value[i];

public static A095066Inst Instance=new A095066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095067
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,2L,4L,11L,23L,33L,59L,108L,205L,364L,709L,1368L,2546L,4789L,9111L,17259L,33075L,63340L,121467L,232396L,446774L,860552L,1659065L,3203164L,6187452L,11968853L,23171558L,44926416L,87186186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095067Inst : IEnumerable<long>
{
public static readonly long[] Value=A095067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095067.Bytes);
public long this[int i]=>Value[i];

public static A095067Inst Instance=new A095067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095068
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,3L,3L,8L,8L,22L,37L,69L,125L,238L,449L,831L,1545L,3004L,5597L,10760L,20524L,39321L,74899L,143666L,276562L,533106L,1025445L,1979842L,3824893L,7394481L,14325045L,27772689L,53894448L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095068Inst : IEnumerable<long>
{
public static readonly long[] Value=A095068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095068.Bytes);
public long this[int i]=>Value[i];

public static A095068Inst Instance=new A095068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095069
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,3L,1L,9L,10L,20L,42L,64L,126L,251L,440L,828L,1560L,2967L,5656L,10769L,20419L,39327L,74826L,143516L,276217L,531587L,1025104L,1977596L,3821827L,7396083L,14326142L,27774012L,53875302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095069Inst : IEnumerable<long>
{
public static readonly long[] Value=A095069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095069.Bytes);
public long this[int i]=>Value[i];

public static A095069Inst Instance=new A095069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095070
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,23L,29L,31L,43L,47L,53L,59L,61L,71L,79L,83L,89L,101L,103L,107L,109L,113L,127L,151L,157L,167L,173L,179L,181L,191L,199L,211L,223L,227L,229L,233L,239L,241L,251L,271L,283L,307L,311L,313L,317L,331L,347L,349L,359L,367L,373L,379L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095070Inst : IEnumerable<long>
{
public static readonly long[] Value=A095070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095070.Bytes);
public long this[int i]=>Value[i];

public static A095070Inst Instance=new A095070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095071
{
public static readonly long[] Value={ 17L,67L,73L,97L,131L,137L,193L,257L,263L,269L,277L,281L,293L,337L,353L,389L,401L,449L,521L,523L,547L,577L,593L,641L,643L,673L,769L,773L,1031L,1033L,1039L,1049L,1051L,1061L,1063L,1069L,1091L,1093L,1097L,1109L,1123L,1129L,1153L,1163L,1171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095071Inst : IEnumerable<long>
{
public static readonly long[] Value=A095071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095071.Bytes);
public long this[int i]=>Value[i];

public static A095071Inst Instance=new A095071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095072
{
public static readonly long[] Value={ 17L,67L,73L,97L,263L,269L,277L,281L,293L,337L,353L,389L,401L,449L,1039L,1051L,1063L,1069L,1109L,1123L,1129L,1163L,1171L,1187L,1193L,1201L,1249L,1291L,1301L,1321L,1361L,1543L,1549L,1571L,1609L,1667L,1669L,1697L,1801L,4127L,4157L,4211L,4217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095072Inst : IEnumerable<long>
{
public static readonly long[] Value=A095072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095072.Bytes);
public long this[int i]=>Value[i];

public static A095072Inst Instance=new A095072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095073
{
public static readonly long[] Value={ 5L,19L,71L,83L,89L,101L,113L,271L,283L,307L,313L,331L,397L,409L,419L,421L,433L,457L,1103L,1117L,1181L,1223L,1229L,1237L,1303L,1307L,1319L,1381L,1427L,1429L,1433L,1481L,1489L,1559L,1579L,1607L,1613L,1619L,1621L,1637L,1699L,1733L,1811L,1861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095073Inst : IEnumerable<long>
{
public static readonly long[] Value=A095073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095073.Bytes);
public long this[int i]=>Value[i];

public static A095073Inst Instance=new A095073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095074
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,71L,79L,83L,89L,101L,103L,107L,109L,113L,127L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,271L,283L,307L,311L,313L,317L,331L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095074Inst : IEnumerable<long>
{
public static readonly long[] Value=A095074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095074.Bytes);
public long this[int i]=>Value[i];

public static A095074Inst Instance=new A095074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095075
{
public static readonly long[] Value={ 2L,17L,37L,41L,67L,73L,97L,131L,137L,139L,149L,163L,193L,197L,257L,263L,269L,277L,281L,293L,337L,353L,389L,401L,449L,521L,523L,541L,547L,557L,563L,569L,577L,587L,593L,601L,613L,617L,641L,643L,647L,653L,659L,661L,673L,677L,709L,769L,773L,787L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095075Inst : IEnumerable<long>
{
public static readonly long[] Value=A095075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095075.Bytes);
public long this[int i]=>Value[i];

public static A095075Inst Instance=new A095075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095252
{
public static readonly long[] Value={ 1L,4L,17L,65L,233L,808L,2766L,9362L,31426L,104822L,1054033L,11005043L,114547418L,1188747707L,12305003905L,127088210000L,1310019623181L,13480213329659L,138498072735374L,1420979139942389L,14560878466498901L,149036972532711329L,1523880579042109897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095252Inst : IEnumerable<long>
{
public static readonly long[] Value=A095252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095252.Bytes);
public long this[int i]=>Value[i];

public static A095252Inst Instance=new A095252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095253
{
public static readonly long[] Value={ 1L,4L,6L,8L,8L,9L,9L,9L,9L,10L,12L,14L,17L,19L,22L,24L,26L,28L,30L,32L,34L,36L,38L,39L,41L,42L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,59L,60L,61L,61L,62L,63L,63L,64L,65L,65L,66L,66L,67L,67L,68L,68L,69L,69L,70L,70L,71L,71L,71L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095253Inst : IEnumerable<long>
{
public static readonly long[] Value=A095253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095253.Bytes);
public long this[int i]=>Value[i];

public static A095253Inst Instance=new A095253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095254
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,7L,7L,7L,10L,12L,14L,17L,19L,21L,24L,26L,28L,30L,31L,33L,35L,37L,38L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,52L,53L,53L,54L,55L,56L,57L,58L,58L,59L,60L,60L,61L,62L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095254Inst : IEnumerable<long>
{
public static readonly long[] Value=A095254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095254.Bytes);
public long this[int i]=>Value[i];

public static A095254Inst Instance=new A095254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095255
{
public static readonly long[] Value={ 0L,69L,1098L,13862L,160943L,1791759L,19459101L,207944154L,2197224577L,23025850929L,239789527279L,2484906649788L,25649493574615L,263905732961525L,2708050201102210L,27725887222397812L,283321334405621608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095255Inst : IEnumerable<long>
{
public static readonly long[] Value=A095255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095255.Bytes);
public long this[int i]=>Value[i];

public static A095255Inst Instance=new A095255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095256
{
public static readonly BigInteger[] Value={ 23L,473L,7053L,93643L,1166714L,13969985L,162725300L,1857511487L,20877697534L,231802823099L,2548286736153L,27785452448917L,300880375389561L,3239062263180829L,34693207724723990L,369957928177109127L,3929837791070240044L,BigInteger.Parse("41600963003695964039"),BigInteger.Parse("439035480966899467108") };
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
public class A095256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095256Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095256.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095256.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095256Inst Instance=new A095256Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095257
{
public static readonly long[] Value={ 833L,2737L,3703L,11431L,30889L,32759L,82943L,109871L,175441L,204631L,221753L,284257L,342391L,351679L,454631L,606487L,734761L,827407L,905849L,965209L,970921L,998809L,1088017L,1166081L,1228687L,1345057L,1609097L,1642039L,1823647L,2107609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095257Inst : IEnumerable<long>
{
public static readonly long[] Value=A095257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095257.Bytes);
public long this[int i]=>Value[i];

public static A095257Inst Instance=new A095257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095258
{
public static readonly long[] Value={ 1L,3L,2L,4L,6L,9L,27L,18L,8L,5L,17L,34L,68L,12L,24L,10L,25L,11L,13L,23L,7L,47L,94L,235L,15L,16L,32L,48L,51L,289L,578L,102L,36L,26L,73L,219L,30L,20L,14L,46L,50L,470L,60L,40L,146L,21L,49L,28L,113L,29L,19L,35L,42L,54L,64L,22L,77L,329L,84L,56L,292L,365L,65L,37L,131L,38L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095258Inst : IEnumerable<long>
{
public static readonly long[] Value=A095258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095258.Bytes);
public long this[int i]=>Value[i];

public static A095258Inst Instance=new A095258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095259
{
public static readonly long[] Value={ 1L,3L,2L,4L,10L,5L,21L,9L,6L,16L,18L,14L,19L,39L,25L,26L,11L,8L,51L,38L,46L,56L,20L,15L,17L,34L,7L,48L,50L,37L,78L,27L,67L,12L,52L,33L,64L,66L,69L,44L,169L,53L,134L,93L,95L,40L,22L,28L,47L,41L,29L,89L,91L,54L,96L,60L,70L,99L,312L,43L,202L,80L,157L,55L,63L,92L,130L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095259Inst : IEnumerable<long>
{
public static readonly long[] Value=A095259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095259.Bytes);
public long this[int i]=>Value[i];

public static A095259Inst Instance=new A095259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095260
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,8L,32L,11L,18L,6L,25L,26L,99L,34L,235L,5L,15L,17L,68L,94L,27L,49L,241L,243L,24L,10L,102L,28L,19L,10519L,505L,74L,219L,16L,119L,506L,289L,23L,12L,21L,29L,925L,56L,46L,116L,7L,113L,48L,193L,51L,13L,73L,470L,54L,37L,47L,72L,174L,85L,22L,471L,479L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095260Inst : IEnumerable<long>
{
public static readonly long[] Value=A095260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095260.Bytes);
public long this[int i]=>Value[i];

public static A095260Inst Instance=new A095260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095261
{
public static readonly long[] Value={ 1L,2L,3L,4L,16L,10L,46L,6L,5L,26L,8L,39L,51L,69L,17L,34L,18L,9L,29L,66L,40L,60L,38L,25L,11L,12L,21L,28L,41L,64L,112L,7L,130L,14L,89L,67L,55L,92L,71L,93L,448L,91L,189L,107L,85L,44L,56L,48L,22L,169L,50L,273L,158L,54L,76L,43L,133L,68L,417L,134L,239L,100L,288L,96L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095261Inst : IEnumerable<long>
{
public static readonly long[] Value=A095261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095261.Bytes);
public long this[int i]=>Value[i];

public static A095261Inst Instance=new A095261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095262
{
public static readonly long[] Value={ 2L,21L,137L,735L,3557L,16191L,70877L,302295L,1266437L,5239311L,21481517L,87506055L,354778517L,1433405631L,5776554557L,23235129015L,93327477797L,374471255151L,1501369969997L,6015936563175L,24095119972277L,96474608387871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095262Inst : IEnumerable<long>
{
public static readonly long[] Value=A095262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095262.Bytes);
public long this[int i]=>Value[i];

public static A095262Inst Instance=new A095262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095263
{
public static readonly long[] Value={ 1L,3L,7L,16L,37L,86L,200L,465L,1081L,2513L,5842L,13581L,31572L,73396L,170625L,396655L,922111L,2143648L,4983377L,11584946L,26931732L,62608681L,145547525L,338356945L,786584466L,1828587033L,4250949112L,9882257736L,22973462017L,53406819691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095263Inst : IEnumerable<long>
{
public static readonly long[] Value=A095263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095263.Bytes);
public long this[int i]=>Value[i];

public static A095263Inst Instance=new A095263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095264
{
public static readonly long[] Value={ 1L,6L,19L,48L,109L,234L,487L,996L,2017L,4062L,8155L,16344L,32725L,65490L,131023L,262092L,524233L,1048518L,2097091L,4194240L,8388541L,16777146L,33554359L,67108788L,134217649L,268435374L,536870827L,1073741736L,2147483557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095264Inst : IEnumerable<long>
{
public static readonly long[] Value=A095264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095264.Bytes);
public long this[int i]=>Value[i];

public static A095264Inst Instance=new A095264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095265
{
public static readonly long[] Value={ 1L,22L,103L,284L,605L,1106L,1827L,2808L,4089L,5710L,7711L,10132L,13013L,16394L,20315L,24816L,29937L,35718L,42199L,49420L,57421L,66242L,75923L,86504L,98025L,110526L,124047L,138628L,154309L,171130L,189131L,208352L,228833L,250614L,273735L,298236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095265Inst : IEnumerable<long>
{
public static readonly long[] Value=A095265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095265.Bytes);
public long this[int i]=>Value[i];

public static A095265Inst Instance=new A095265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095266
{
public static readonly long[] Value={ 1L,42L,303L,1144L,3105L,6906L,13447L,23808L,39249L,61210L,91311L,131352L,183313L,249354L,331815L,433216L,556257L,703818L,878959L,1084920L,1325121L,1603162L,1922823L,2288064L,2703025L,3172026L,3699567L,4290328L,4949169L,5681130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095266Inst : IEnumerable<long>
{
public static readonly long[] Value=A095266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095266.Bytes);
public long this[int i]=>Value[i];

public static A095266Inst Instance=new A095266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095267
{
public static readonly BigInteger[] Value={ 12L,84L,1092L,20748L,643188L,23797956L,1023312108L,62422038588L,4182276585396L,305306190733908L,24119189067978732L,2339561339593937004L,BigInteger.Parse("240974817978175511412"),BigInteger.Parse("26266255159621130743908") };
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
public class A095267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095267Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095267.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095267.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095267Inst Instance=new A095267Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095268
{
public static readonly long[] Value={ 1L,2L,7L,20L,71L,240L,871L,3148L,11655L,43332L,162769L,614198L,2330537L,8875768L,33924859L,130038230L,499753855L,1924912894L,7429160296L,28723877732L,111236423288L,431403470222L,1675316535350L,6513837679610L,25354842100894L,98794053269694L,385312558571890L,1504105116253904L,5876236938019298L,22974847399695092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095268Inst : IEnumerable<long>
{
public static readonly long[] Value=A095268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095268.Bytes);
public long this[int i]=>Value[i];

public static A095268Inst Instance=new A095268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095269
{
public static readonly long[] Value={ 0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,3L,0L,10L,0L,0L,0L,3L,0L,0L,0L,0L,0L,3L,0L,10L,0L,7L,0L,3L,0L,7L,7L,0L,0L,3L,0L,8L,0L,8L,0L,3L,0L,0L,0L,11L,0L,3L,0L,34L,0L,8L,19L,3L,0L,10L,13L,61L,0L,3L,0L,0L,7L,0L,0L,3L,0L,7L,0L,8L,0L,3L,0L,10L,0L,0L,0L,3L,0L,32L,0L,7L,0L,3L,0L,58L,0L,7L,0L,3L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095269Inst : IEnumerable<long>
{
public static readonly long[] Value=A095269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095269.Bytes);
public long this[int i]=>Value[i];

public static A095269Inst Instance=new A095269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095270
{
public static readonly long[] Value={ 2L,6L,10L,14L,2L,22L,26L,30L,34L,38L,2L,46L,9L,54L,58L,62L,2L,70L,74L,78L,82L,86L,2L,94L,9L,102L,6L,110L,2L,118L,6L,6L,130L,134L,2L,142L,7L,150L,7L,158L,2L,166L,170L,174L,10L,182L,2L,190L,33L,198L,7L,18L,2L,214L,9L,12L,60L,230L,2L,238L,242L,6L,250L,254L,2L,262L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095270Inst : IEnumerable<long>
{
public static readonly long[] Value=A095270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095270.Bytes);
public long this[int i]=>Value[i];

public static A095270Inst Instance=new A095270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095271
{
public static readonly long[] Value={ 3L,3L,10L,3L,3L,10L,7L,3L,7L,7L,3L,8L,8L,3L,11L,3L,34L,8L,19L,3L,10L,13L,61L,3L,7L,3L,7L,8L,3L,10L,3L,32L,7L,3L,58L,7L,3L,45L,3L,7L,3L,13L,31L,3L,8L,7L,3L,10L,7L,35L,3L,8L,7L,35L,3L,14L,8L,3L,13L,22L,3L,8L,3L,103L,7L,15L,3L,7L,40L,3L,7L,15L,55L,3L,113L,31L,3L,7L,13L,3L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095271Inst : IEnumerable<long>
{
public static readonly long[] Value=A095271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095271.Bytes);
public long this[int i]=>Value[i];

public static A095271Inst Instance=new A095271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095272
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,11L,14L,17L,19L,20L,25L,32L,37L,41L,47L,49L,59L,62L,65L,67L,77L,89L,95L,104L,107L,109L,119L,125L,140L,149L,151L,161L,164L,179L,185L,187L,209L,215L,221L,227L,229L,242L,245L,247L,257L,259L,265L,272L,275L,287L,305L,307L,319L,329L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095272Inst : IEnumerable<long>
{
public static readonly long[] Value=A095272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095272.Bytes);
public long this[int i]=>Value[i];

public static A095272Inst Instance=new A095272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095273
{
public static readonly long[] Value={ 4L,10L,16L,26L,31L,34L,40L,44L,52L,55L,56L,70L,76L,82L,86L,91L,94L,110L,115L,116L,121L,122L,124L,130L,136L,142L,146L,154L,157L,160L,170L,172L,181L,184L,196L,202L,205L,206L,214L,220L,226L,236L,241L,254L,262L,271L,280L,290L,292L,296L,314L,320L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095273Inst : IEnumerable<long>
{
public static readonly long[] Value=A095273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095273.Bytes);
public long this[int i]=>Value[i];

public static A095273Inst Instance=new A095273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095274
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,7L,8L,9L,11L,13L,14L,15L,17L,18L,19L,20L,21L,23L,25L,27L,29L,32L,33L,35L,37L,39L,41L,42L,43L,45L,47L,49L,53L,57L,59L,60L,62L,63L,65L,67L,69L,71L,73L,74L,75L,77L,79L,81L,83L,85L,87L,89L,90L,92L,93L,95L,97L,98L,99L,101L,103L,104L,107L,109L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095274Inst : IEnumerable<long>
{
public static readonly long[] Value=A095274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095274.Bytes);
public long this[int i]=>Value[i];

public static A095274Inst Instance=new A095274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095275
{
public static readonly long[] Value={ 4L,10L,12L,16L,22L,24L,26L,28L,30L,31L,34L,36L,38L,40L,44L,46L,48L,50L,51L,52L,54L,55L,56L,58L,61L,64L,66L,68L,70L,72L,76L,78L,80L,82L,84L,86L,88L,91L,94L,96L,100L,102L,105L,106L,108L,110L,112L,114L,115L,116L,118L,120L,121L,122L,124L,126L,128L,130L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095275Inst : IEnumerable<long>
{
public static readonly long[] Value=A095275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095275.Bytes);
public long this[int i]=>Value[i];

public static A095275Inst Instance=new A095275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095276
{
public static readonly long[] Value={ 1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,2L,1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,3L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,3L,3L,1L,1L,2L,1L,3L,2L,3L,1L,1L,3L,3L,1L,1L,2L,1L,3L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095276Inst : IEnumerable<long>
{
public static readonly long[] Value=A095276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095276.Bytes);
public long this[int i]=>Value[i];

public static A095276Inst Instance=new A095276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095277
{
public static readonly long[] Value={ 3L,6L,8L,9L,12L,13L,15L,18L,21L,22L,23L,24L,27L,28L,29L,30L,33L,35L,36L,38L,39L,42L,43L,45L,46L,48L,50L,51L,53L,54L,57L,58L,60L,61L,63L,64L,66L,68L,69L,71L,72L,73L,74L,75L,78L,79L,80L,81L,83L,84L,85L,87L,88L,90L,92L,93L,96L,97L,98L,99L,100L,101L,102L,103L,105L,106L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095277Inst : IEnumerable<long>
{
public static readonly long[] Value=A095277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095277.Bytes);
public long this[int i]=>Value[i];

public static A095277Inst Instance=new A095277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095278
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,10L,11L,14L,16L,17L,19L,20L,25L,26L,31L,32L,34L,37L,40L,41L,44L,47L,49L,52L,55L,56L,59L,62L,65L,67L,70L,76L,77L,82L,86L,89L,91L,94L,95L,104L,107L,109L,110L,115L,116L,119L,121L,122L,124L,125L,130L,136L,140L,142L,146L,149L,151L,154L,157L,160L,161L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095278Inst : IEnumerable<long>
{
public static readonly long[] Value=A095278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095278.Bytes);
public long this[int i]=>Value[i];

public static A095278Inst Instance=new A095278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095279
{
public static readonly long[] Value={ 1L,4L,5L,6L,8L,9L,12L,14L,17L,18L,19L,22L,25L,26L,27L,29L,30L,33L,34L,35L,38L,39L,40L,42L,43L,46L,48L,51L,52L,53L,55L,56L,59L,60L,61L,63L,64L,67L,69L,72L,73L,74L,77L,80L,81L,82L,84L,85L,88L,90L,93L,94L,95L,97L,98L,101L,103L,106L,107L,108L,111L,114L,115L,116L,118L,119L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095279Inst : IEnumerable<long>
{
public static readonly long[] Value=A095279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095279.Bytes);
public long this[int i]=>Value[i];

public static A095279Inst Instance=new A095279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095280
{
public static readonly long[] Value={ 3L,11L,17L,19L,29L,37L,43L,53L,59L,61L,67L,71L,79L,97L,101L,103L,113L,127L,131L,137L,139L,163L,173L,179L,181L,197L,199L,211L,223L,229L,239L,241L,257L,263L,271L,281L,283L,307L,313L,317L,331L,347L,349L,359L,367L,373L,383L,389L,401L,409L,419L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095280Inst : IEnumerable<long>
{
public static readonly long[] Value=A095280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095280.Bytes);
public long this[int i]=>Value[i];

public static A095280Inst Instance=new A095280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095281
{
public static readonly long[] Value={ 2L,5L,7L,13L,23L,31L,41L,47L,73L,83L,89L,107L,109L,149L,151L,157L,167L,191L,193L,227L,233L,251L,269L,277L,293L,311L,337L,353L,379L,397L,421L,431L,439L,463L,479L,523L,541L,547L,557L,599L,607L,617L,641L,659L,683L,691L,701L,709L,719L,727L,733L,743L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095281Inst : IEnumerable<long>
{
public static readonly long[] Value=A095281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095281.Bytes);
public long this[int i]=>Value[i];

public static A095281Inst Instance=new A095281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095282
{
public static readonly long[] Value={ 2L,3L,11L,19L,43L,47L,59L,67L,79L,83L,107L,131L,139L,163L,179L,191L,211L,227L,239L,251L,271L,283L,307L,331L,347L,367L,379L,419L,431L,443L,463L,467L,491L,499L,523L,547L,563L,571L,587L,619L,643L,659L,683L,691L,719L,739L,751L,787L,811L,827L,859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095282Inst : IEnumerable<long>
{
public static readonly long[] Value=A095282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095282.Bytes);
public long this[int i]=>Value[i];

public static A095282Inst Instance=new A095282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095283
{
public static readonly long[] Value={ 5L,7L,13L,17L,23L,29L,31L,37L,41L,53L,61L,71L,73L,89L,97L,101L,103L,109L,113L,127L,137L,149L,151L,157L,167L,173L,181L,193L,197L,199L,223L,229L,233L,241L,257L,263L,269L,277L,281L,293L,311L,313L,317L,337L,349L,353L,359L,373L,383L,389L,397L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095283Inst : IEnumerable<long>
{
public static readonly long[] Value=A095283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095283.Bytes);
public long this[int i]=>Value[i];

public static A095283Inst Instance=new A095283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095300
{
public static readonly long[] Value={ 2L,6L,10L,12L,14L,18L,22L,24L,26L,30L,34L,38L,42L,46L,50L,54L,58L,60L,62L,66L,70L,74L,78L,82L,84L,86L,90L,94L,96L,98L,102L,106L,110L,114L,118L,120L,122L,126L,130L,132L,134L,138L,142L,146L,150L,154L,156L,158L,162L,166L,168L,170L,174L,178L,182L,186L,190L,194L,198L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095300Inst : IEnumerable<long>
{
public static readonly long[] Value=A095300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095300.Bytes);
public long this[int i]=>Value[i];

public static A095300Inst Instance=new A095300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095301
{
public static readonly long[] Value={ 28L,140L,200L,224L,234L,270L,308L,364L,476L,496L,532L,600L,644L,672L,700L,812L,819L,868L,936L,1036L,1148L,1170L,1204L,1316L,1400L,1484L,1488L,1540L,1638L,1652L,1708L,1800L,1820L,1876L,1988L,2016L,2044L,2200L,2212L,2324L,2380L,2464L,2480L,2492L,2574L,2600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095301Inst : IEnumerable<long>
{
public static readonly long[] Value=A095301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095301.Bytes);
public long this[int i]=>Value[i];

public static A095301Inst Instance=new A095301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095302
{
public static readonly BigInteger[] Value={ 3L,5L,11L,29L,83L,59051L,3518743763L,4782971L,6563L,2357947693L,59051L,8649755859377L,282429536483L,2541865828331L,4782971L,14348909L,6568408355712890627L,762939453127L,150094635296999123L,BigInteger.Parse("15398217140735709790332844752065729"),BigInteger.Parse("332525673007965087890627") };
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
public class A095302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095302Inst Instance=new A095302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095303
{
public static readonly long[] Value={ 4L,2L,9L,3L,3L,3L,7L,7L,3L,21L,9L,7L,19L,5L,7L,39L,15L,61L,15L,19L,21L,3L,19L,17L,21L,5L,21L,7L,85L,17L,7L,21L,511L,27L,27L,59L,3L,19L,91L,45L,3L,29L,321L,65L,9L,379L,69L,125L,49L,5L,9L,45L,289L,341L,61L,89L,171L,171L,139L,21L,139L,75L,25L,49L,15L,51L,57L,175L,31L,137L,147L,25L,441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095303Inst : IEnumerable<long>
{
public static readonly long[] Value=A095303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095303.Bytes);
public long this[int i]=>Value[i];

public static A095303Inst Instance=new A095303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095304
{
public static readonly BigInteger[] Value={ 2L,2L,727L,79L,241L,727L,823541L,5764799L,19681L,16679880978199L,31381059607L,13841287199L,42052983462257057L,6103515623L,4747561509941L,BigInteger.Parse("28644003124274380508351359"),BigInteger.Parse("98526125335693359373"),BigInteger.Parse("136753052840548005895349735207879"),BigInteger.Parse("22168378200531005859373") };
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
public class A095304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095304Inst Instance=new A095304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095305
{
public static readonly long[] Value={ 4L,6L,10L,14L,16L,22L,24L,26L,34L,36L,38L,40L,46L,56L,58L,60L,62L,74L,82L,84L,86L,88L,94L,96L,100L,104L,106L,118L,122L,132L,134L,136L,140L,142L,144L,146L,152L,156L,158L,166L,178L,184L,194L,196L,202L,204L,206L,214L,216L,218L,220L,226L,228L,232L,240L,248L,254L,260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095305Inst : IEnumerable<long>
{
public static readonly long[] Value=A095305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095305.Bytes);
public long this[int i]=>Value[i];

public static A095305Inst Instance=new A095305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095306
{
public static readonly long[] Value={ 1L,2L,5L,12L,19L,107L,117L,159L,217L,517L,868L,1412L,1636L,4051L,5965L,9128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095306Inst : IEnumerable<long>
{
public static readonly long[] Value=A095306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095306.Bytes);
public long this[int i]=>Value[i];

public static A095306Inst Instance=new A095306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095307
{
public static readonly long[] Value={ 1L,0L,4L,1L,15L,7L,56L,37L,210L,176L,793L,793L,3017L,3458L,11561L,14756L,44592L,62017L,172995L,257775L,674520L,1062601L,2641366L,4352660L,10381281L,17742621L,40927033L,72048354L,161766061L,291693136L,640758252L,1178135905L,2542557383L,4749439975L,10103745288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095307Inst : IEnumerable<long>
{
public static readonly long[] Value=A095307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095307.Bytes);
public long this[int i]=>Value[i];

public static A095307Inst Instance=new A095307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095308
{
public static readonly long[] Value={ 1L,1L,5L,6L,21L,28L,84L,121L,331L,507L,1300L,2093L,5110L,8568L,20129L,34885L,79477L,141494L,314489L,572264L,1246784L,2309385L,4950751L,9303411L,19684692L,37427313L,78354346L,150402700L,312168761L,603861897L,1244620149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095308Inst : IEnumerable<long>
{
public static readonly long[] Value=A095308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095308.Bytes);
public long this[int i]=>Value[i];

public static A095308Inst Instance=new A095308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095309
{
public static readonly long[] Value={ 1L,3L,9L,27L,33L,51L,127L,1755L,2805L,10437L,71377L,547233L,1007727L,2924109L,3358515L,3460299L,59768775L,977921175L,1022225871L,1769996491L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095309Inst : IEnumerable<long>
{
public static readonly long[] Value=A095309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095309.Bytes);
public long this[int i]=>Value[i];

public static A095309Inst Instance=new A095309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095310
{
public static readonly long[] Value={ 1L,5L,12L,38L,107L,316L,915L,2671L,7771L,22640L,65922L,191993L,559112L,1628281L,4741905L,13809541L,40216516L,117119750L,341079507L,993301748L,2892722267L,8424270271L,24533405595L,71446899736L,208069745986L,605946785585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095310Inst : IEnumerable<long>
{
public static readonly long[] Value=A095310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095310.Bytes);
public long this[int i]=>Value[i];

public static A095310Inst Instance=new A095310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095311
{
public static readonly long[] Value={ 1L,47L,138L,274L,455L,681L,952L,1268L,1629L,2035L,2486L,2982L,3523L,4109L,4740L,5416L,6137L,6903L,7714L,8570L,9471L,10417L,11408L,12444L,13525L,14651L,15822L,17038L,18299L,19605L,20956L,22352L,23793L,25279L,26810L,28386L,30007L,31673L,33384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095311Inst : IEnumerable<long>
{
public static readonly long[] Value=A095311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095311.Bytes);
public long this[int i]=>Value[i];

public static A095311Inst Instance=new A095311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095312
{
public static readonly long[] Value={ 127L,383L,479L,503L,509L,991L,1019L,1021L,1279L,1471L,1531L,1663L,1759L,1783L,1787L,1789L,1951L,1979L,1999L,2011L,2027L,2029L,2039L,3067L,3581L,3583L,3823L,3967L,4027L,4079L,4091L,4093L,5087L,5119L,5503L,5623L,5879L,6007L,6011L,6047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095312Inst : IEnumerable<long>
{
public static readonly long[] Value=A095312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095312.Bytes);
public long this[int i]=>Value[i];

public static A095312Inst Instance=new A095312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095313
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095313Inst : IEnumerable<long>
{
public static readonly long[] Value=A095313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095313.Bytes);
public long this[int i]=>Value[i];

public static A095313Inst Instance=new A095313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095314
{
public static readonly long[] Value={ 7L,23L,29L,31L,47L,59L,61L,79L,103L,107L,109L,127L,191L,223L,239L,251L,311L,317L,347L,349L,359L,367L,373L,379L,383L,431L,439L,443L,461L,463L,467L,479L,487L,491L,499L,503L,509L,607L,631L,701L,719L,727L,733L,743L,751L,757L,761L,823L,827L,829L,859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095314Inst : IEnumerable<long>
{
public static readonly long[] Value=A095314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095314.Bytes);
public long this[int i]=>Value[i];

public static A095314Inst Instance=new A095314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095315
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,19L,37L,41L,43L,53L,67L,71L,73L,83L,89L,97L,101L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,193L,197L,199L,211L,227L,229L,233L,241L,257L,263L,269L,271L,277L,281L,283L,293L,307L,313L,331L,337L,353L,389L,397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095315Inst : IEnumerable<long>
{
public static readonly long[] Value=A095315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095315.Bytes);
public long this[int i]=>Value[i];

public static A095315Inst Instance=new A095315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095332
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,4L,3L,15L,9L,47L,73L,236L,251L,863L,1180L,3298L,4284L,12933L,18598L,51300L,73371L,199410L,292156L,769127L,1131645L,2978179L,4533090L,11590386L,17623347L,44867556L,69537472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095332Inst : IEnumerable<long>
{
public static readonly long[] Value=A095332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095332.Bytes);
public long this[int i]=>Value[i];

public static A095332Inst Instance=new A095332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095333
{
public static readonly long[] Value={ 1L,2L,2L,5L,7L,12L,23L,39L,72L,122L,246L,417L,799L,1376L,2779L,4846L,9569L,17092L,34351L,60653L,121738L,216916L,440337L,786408L,1601964L,2876617L,5895645L,10583728L,21674188L,39107151L,80559309L,145468029L,299785833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095333Inst : IEnumerable<long>
{
public static readonly long[] Value=A095333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095333.Bytes);
public long this[int i]=>Value[i];

public static A095333Inst Instance=new A095333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095334
{
public static readonly long[] Value={ 0L,1L,0L,3L,3L,5L,4L,21L,32L,69L,96L,229L,335L,768L,1116L,2860L,4371L,10252L,15490L,36563L,58041L,133739L,209875L,491193L,795599L,1816561L,2951789L,6772098L,11144763L,25284670L,41781268L,94895078L,158643268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095334Inst : IEnumerable<long>
{
public static readonly long[] Value=A095334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095334.Bytes);
public long this[int i]=>Value[i];

public static A095334Inst Instance=new A095334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095335
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,8L,19L,22L,43L,68L,159L,235L,537L,844L,1914L,2849L,6378L,10138L,23145L,37023L,82295L,134477L,303833L,494625L,1098521L,1829183L,4075501L,6789809L,15062515L,25412867L,56401388L,95440507L,210680037L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095335Inst : IEnumerable<long>
{
public static readonly long[] Value=A095335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095335.Bytes);
public long this[int i]=>Value[i];

public static A095335Inst Instance=new A095335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095336
{
public static readonly long[] Value={ 1L,3L,3L,13L,20L,41L,76L,176L,325L,638L,1353L,2533L,5223L,10186L,20504L,40775L,80661L,163765L,318602L,649948L,1268922L,2571531L,5082895L,10217300L,20327307L,40399966L,82164918L,160343669L,324931245L,640501167L,1290990369L,2567150515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095336Inst : IEnumerable<long>
{
public static readonly long[] Value=A095336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095336.Bytes);
public long this[int i]=>Value[i];

public static A095336Inst Instance=new A095336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095337
{
public static readonly long[] Value={ 0L,2L,4L,10L,26L,67L,180L,482L,1319L,3627L,10082L,28150L,79142L,223309L,632805L,1798614L,5127257L,14650352L,41952791L,120358095L,345878470L,995441814L,2868762513L,8277505162L,23910288016L,69136464102L,200092471111L,579592538321L,1680177087348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095337Inst : IEnumerable<long>
{
public static readonly long[] Value=A095337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095337.Bytes);
public long this[int i]=>Value[i];

public static A095337Inst Instance=new A095337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095338
{
public static readonly BigInteger[] Value={ 0L,2L,12L,96L,1280L,30720L,1376256L,117440512L,19327352832L,6184752906240L,3870280929771520L,4755801206503243776L,BigInteger.Parse("11510768301994760208384"),BigInteger.Parse("55006124792465627449131008"),BigInteger.Parse("519934816499859715457632174080"),BigInteger.Parse("9735556609752801803494680617287680"),BigInteger.Parse("361550014853497117429835520396253724672") };
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
public class A095338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095338Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095338.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095338.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095338Inst Instance=new A095338Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095339
{
public static readonly long[] Value={ 0L,2L,2L,5L,12L,31L,78L,208L,549L,1490L,4060L,11205L,31074L,86862L,243796L,687643L,1946184L,5526723L,15736664L,44920308L,128495647L,368274074L,1057275163L,3039990187L,8752947291L,25233737677L,72828925967L,210416568930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095339Inst : IEnumerable<long>
{
public static readonly long[] Value=A095339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095339.Bytes);
public long this[int i]=>Value[i];

public static A095339Inst Instance=new A095339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095340
{
public static readonly BigInteger[] Value={ 1L,4L,24L,256L,5120L,196608L,14680064L,2147483648L,618475290624L,351843720888320L,396316767208603648L,BigInteger.Parse("885443715538058477568"),BigInteger.Parse("3929008913747544817795072"),BigInteger.Parse("34662321099990647697175478272"),BigInteger.Parse("608472288109550112718417538580480"),BigInteger.Parse("21267647932558653966460912964485513216") };
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
public class A095340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095340Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A095340.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A095340.Bytes);
public BigInteger this[int i]=>Value[i];

public static A095340Inst Instance=new A095340Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095341
{
public static readonly long[] Value={ 0L,2L,3L,8L,20L,54L,140L,384L,1035L,2860L,7909L,22104L,61958L,174804L,494595L,1404976L,4001477L,11427246L,32702021L,93773520L,269350788L,774880304L,2232269163L,6438788520L,18593124600L,53746540770L,155510185770L,450344561212L,1305204921801L,3785596629240L,10987232275507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095341Inst : IEnumerable<long>
{
public static readonly long[] Value=A095341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095341.Bytes);
public long this[int i]=>Value[i];

public static A095341Inst Instance=new A095341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095342
{
public static readonly long[] Value={ 1L,1L,5L,5L,17L,25L,61L,109L,233L,449L,917L,1813L,3649L,7273L,14573L,29117L,58265L,116497L,233029L,466021L,932081L,1864121L,3728285L,7456525L,14913097L,29826145L,59652341L,119304629L,238609313L,477218569L,954437197L,1908874333L,3817748729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095342Inst : IEnumerable<long>
{
public static readonly long[] Value=A095342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095342.Bytes);
public long this[int i]=>Value[i];

public static A095342Inst Instance=new A095342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095343
{
public static readonly long[] Value={ 1L,1L,7L,7L,31L,49L,145L,289L,727L,1591L,3775L,8545L,19873L,45505L,105127L,241639L,557023L,1281937L,2953009L,6798817L,15657847L,36054295L,83027839L,191190721L,440274241L,1013846401L,2334669127L,5376208327L,12380215711L,28508840689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095343Inst : IEnumerable<long>
{
public static readonly long[] Value=A095343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095343.Bytes);
public long this[int i]=>Value[i];

public static A095343Inst Instance=new A095343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095344
{
public static readonly long[] Value={ 1L,1L,9L,9L,49L,81L,281L,601L,1729L,4129L,11049L,27561L,71761L,182001L,469049L,1197049L,3073249L,7861441L,20154441L,51600201L,132217969L,338618769L,867490649L,2221965721L,5691928321L,14579791201L,37347504489L,95666669289L,245056687249L,627723364401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095344Inst : IEnumerable<long>
{
public static readonly long[] Value=A095344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095344.Bytes);
public long this[int i]=>Value[i];

public static A095344Inst Instance=new A095344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095345
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095345Inst : IEnumerable<long>
{
public static readonly long[] Value=A095345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095345.Bytes);
public long this[int i]=>Value[i];

public static A095345Inst Instance=new A095345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095346
{
public static readonly long[] Value={ 3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095346Inst : IEnumerable<long>
{
public static readonly long[] Value=A095346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095346.Bytes);
public long this[int i]=>Value[i];

public static A095346Inst Instance=new A095346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095347
{
public static readonly long[] Value={ 2L,5L,9L,10L,16L,18L,34L,36L,66L,162L,924L,71820L,127005777360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095347Inst : IEnumerable<long>
{
public static readonly long[] Value=A095347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095347.Bytes);
public long this[int i]=>Value[i];

public static A095347Inst Instance=new A095347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A095380
{
public static readonly long[] Value={ 1L,1L,2L,6L,15L,34L,75L,162L,337L,706L,1466L,2995L,6119L,12450L,25248L,51158L,103450L,209010L,421681L,850322L,1712673L,3447970L,6937759L,13952296L,28049834L,56369395L,113241087L,227428919L,456641954L,916642515L,1839651364L,3691364919L,7405635242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A095380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A095380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A095380Inst : IEnumerable<long>
{
public static readonly long[] Value=A095380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A095380.Bytes);
public long this[int i]=>Value[i];

public static A095380Inst Instance=new A095380Inst();

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