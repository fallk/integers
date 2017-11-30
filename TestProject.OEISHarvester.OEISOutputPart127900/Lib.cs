using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A157205
{
public static readonly BigInteger[] Value={ 1L,-1L,-182L,1093L,165802L,-829921L,-368637542L,10333472621L,1525403827402L,-13744138142311L,-10140848072256902L,223350690307957903L,BigInteger.Parse("98873095718971557802"),BigInteger.Parse("-1286802351507842360101"),BigInteger.Parse("-1329160852440528698289062"),BigInteger.Parse("159679495285007357373157357"),BigInteger.Parse("23562240946717778651076005002") };
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
public class A157205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157205.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157205Inst Instance=new A157205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157206
{
public static readonly BigInteger[] Value={ 1L,-13L,-27L,5447L,21897L,-8550373L,-51521427L,28491956207L,228898201617L,-162934942038973L,-1636222143855627L,1423695084746914967L,17156395293052656537UL,BigInteger.Parse("-17642381532358409441173"),BigInteger.Parse("-248035037340684934103427"),BigInteger.Parse("294301682652158427497809727") };
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
public class A157206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157206.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157206Inst Instance=new A157206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157207
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,14L,14L,1L,1L,33L,94L,33L,1L,1L,72L,442L,442L,72L,1L,1L,151L,1752L,3818L,1752L,151L,1L,1L,310L,6306L,25358L,25358L,6306L,310L,1L,1L,629L,21390L,144524L,268852L,144524L,21390L,629L,1L,1L,1268L,69822L,746744L,2312836L,2312836L,746744L,69822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157207Inst : IEnumerable<long>
{
public static readonly long[] Value=A157207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157207.Bytes);
public long this[int i]=>Value[i];

public static A157207Inst Instance=new A157207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157208
{
public static readonly long[] Value={ 1L,1L,1L,1L,8L,1L,1L,31L,31L,1L,1L,102L,342L,102L,1L,1L,317L,2548L,2548L,317L,1L,1L,964L,16001L,37724L,16001L,964L,1L,1L,2907L,91877L,423365L,423365L,91877L,2907L,1L,1L,8738L,501032L,4070208L,7922362L,4070208L,501032L,8738L,1L,1L,26233L,2647858L,35556134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157208Inst : IEnumerable<long>
{
public static readonly long[] Value=A157208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157208.Bytes);
public long this[int i]=>Value[i];

public static A157208Inst Instance=new A157208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157209
{
public static readonly long[] Value={ 1L,1L,1L,1L,11L,1L,1L,54L,54L,1L,1L,229L,822L,229L,1L,1L,932L,8368L,8368L,932L,1L,1L,3747L,72066L,174758L,72066L,3747L,1L,1L,15010L,570006L,2759750L,2759750L,570006L,15010L,1L,1L,60065L,4297714L,37366190L,73850596L,37366190L,4297714L,60065L,1L,1L,240288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157209Inst : IEnumerable<long>
{
public static readonly long[] Value=A157209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157209.Bytes);
public long this[int i]=>Value[i];

public static A157209Inst Instance=new A157209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157210
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,8L,1L,1L,19L,42L,19L,1L,1L,42L,186L,186L,42L,1L,1L,89L,730L,1362L,730L,89L,1L,1L,184L,2640L,8540L,8540L,2640L,184L,1L,1L,375L,9030L,47810L,79952L,47810L,9030L,375L,1L,1L,758L,29722L,246530L,652460L,652460L,246530L,29722L,758L,1L,1L,1525L,95238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157210Inst : IEnumerable<long>
{
public static readonly long[] Value=A157210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157210.Bytes);
public long this[int i]=>Value[i];

public static A157210Inst Instance=new A157210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157211
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,15L,15L,1L,1L,50L,134L,50L,1L,1L,157L,960L,960L,157L,1L,1L,480L,6013L,12636L,6013L,480L,1L,1L,1451L,34717L,136809L,136809L,34717L,1451L,1L,1L,4366L,190528L,1303472L,2361474L,1303472L,190528L,4366L,1L,1L,13113L,1012326L,11392866L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157211Inst : IEnumerable<long>
{
public static readonly long[] Value=A157211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157211.Bytes);
public long this[int i]=>Value[i];

public static A157211Inst Instance=new A157211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157212
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,24L,24L,1L,1L,103L,306L,103L,1L,1L,422L,3028L,3028L,422L,1L,1L,1701L,26064L,57806L,26064L,1701L,1L,1L,6820L,207132L,889640L,889640L,207132L,6820L,1L,1L,27299L,1569298L,11975936L,22436968L,11975936L,1569298L,27299L,1L,1L,109218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157212Inst : IEnumerable<long>
{
public static readonly long[] Value=A157212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157212.Bytes);
public long this[int i]=>Value[i];

public static A157212Inst Instance=new A157212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157213
{
public static readonly long[] Value={ 97L,137L,277L,305L,685L,1565L,1733L,3973L,9113L,10093L,23153L,53113L,58825L,134945L,309565L,342857L,786517L,1804277L,1998317L,4584157L,10516097L,11647045L,26718425L,61292305L,67883953L,155726393L,357237733L,395656673L,907639933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157213Inst : IEnumerable<long>
{
public static readonly long[] Value=A157213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157213.Bytes);
public long this[int i]=>Value[i];

public static A157213Inst Instance=new A157213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157214
{
public static readonly long[] Value={ 2L,5L,0L,7L,1L,0L,6L,7L,8L,1L,1L,8L,6L,5L,4L,7L,5L,2L,4L,4L,0L,0L,8L,4L,4L,3L,6L,2L,1L,0L,4L,8L,4L,9L,0L,3L,9L,2L,8L,4L,8L,3L,5L,9L,3L,7L,6L,8L,8L,4L,7L,4L,0L,3L,6L,5L,8L,8L,3L,3L,9L,8L,6L,8L,9L,9L,5L,3L,6L,6L,2L,3L,9L,2L,3L,1L,0L,5L,3L,5L,1L,9L,4L,2L,5L,1L,9L,3L,7L,6L,7L,1L,6L,3L,8L,2L,0L,7L,8L,6L,3L,6L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157214Inst : IEnumerable<long>
{
public static readonly long[] Value=A157214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157214.Bytes);
public long this[int i]=>Value[i];

public static A157214Inst Instance=new A157214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157215
{
public static readonly long[] Value={ 1L,0L,9L,2L,8L,9L,3L,2L,1L,8L,8L,1L,3L,4L,5L,2L,4L,7L,5L,5L,9L,9L,1L,5L,5L,6L,3L,7L,8L,9L,5L,1L,5L,0L,9L,6L,0L,7L,1L,5L,1L,6L,4L,0L,6L,2L,3L,1L,1L,5L,2L,5L,9L,6L,3L,4L,1L,1L,6L,6L,0L,1L,3L,1L,0L,0L,4L,6L,3L,3L,7L,6L,0L,7L,6L,8L,9L,4L,6L,4L,8L,0L,5L,7L,4L,8L,0L,6L,2L,3L,2L,8L,3L,6L,1L,7L,9L,2L,1L,3L,6L,3L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157215Inst : IEnumerable<long>
{
public static readonly long[] Value=A157215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157215.Bytes);
public long this[int i]=>Value[i];

public static A157215Inst Instance=new A157215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157216
{
public static readonly long[] Value={ 2L,2L,9L,4L,0L,0L,8L,9L,0L,9L,5L,8L,8L,1L,6L,4L,6L,3L,0L,5L,9L,9L,6L,4L,9L,5L,2L,6L,8L,5L,3L,0L,8L,6L,3L,2L,8L,9L,8L,7L,3L,7L,5L,6L,8L,4L,5L,5L,4L,1L,9L,9L,4L,6L,4L,1L,3L,0L,6L,6L,5L,5L,2L,1L,3L,0L,7L,7L,8L,0L,4L,6L,0L,3L,0L,3L,5L,7L,3L,9L,6L,7L,1L,2L,7L,9L,9L,1L,8L,1L,0L,8L,7L,2L,1L,7L,3L,2L,9L,5L,9L,5L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157216Inst : IEnumerable<long>
{
public static readonly long[] Value=A157216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157216.Bytes);
public long this[int i]=>Value[i];

public static A157216Inst Instance=new A157216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157217
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,19L,28L,47L,51L,98L,122L,220L,221L,441L,444L,885L,886L,1771L,1780L,3551L,3555L,7106L,7173L,14279L,14280L,28559L,28562L,57121L,57122L,114243L,114252L,228495L,228499L,456994L,457018L,914012L,914013L,1828025L,1828028L,3656053L,3656054L,7312107L,7312116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157217Inst : IEnumerable<long>
{
public static readonly long[] Value=A157217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157217.Bytes);
public long this[int i]=>Value[i];

public static A157217Inst Instance=new A157217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157218
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,2L,3L,1L,1L,3L,1L,1L,4L,2L,3L,2L,1L,3L,3L,2L,3L,5L,1L,2L,5L,2L,4L,5L,1L,4L,3L,1L,4L,7L,1L,5L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157218Inst : IEnumerable<long>
{
public static readonly long[] Value=A157218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157218.Bytes);
public long this[int i]=>Value[i];

public static A157218Inst Instance=new A157218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157219
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,4L,28L,4L,1L,1L,5L,45L,45L,5L,1L,1L,6L,66L,816L,66L,6L,1L,1L,7L,91L,1330L,1330L,91L,7L,1L,1L,8L,120L,2024L,35960L,2024L,120L,8L,1L,1L,9L,153L,2925L,58905L,58905L,2925L,153L,9L,1L,1L,10L,190L,4060L,91390L,2118760L,91390L,4060L,190L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157219Inst : IEnumerable<long>
{
public static readonly long[] Value=A157219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157219.Bytes);
public long this[int i]=>Value[i];

public static A157219Inst Instance=new A157219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157220
{
public static readonly long[] Value={ 3L,2L,4L,2L,6L,2L,4L,2L,6L,2L,8L,2L,6L,4L,4L,2L,6L,2L,8L,4L,6L,2L,6L,2L,6L,2L,4L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157220Inst : IEnumerable<long>
{
public static readonly long[] Value=A157220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157220.Bytes);
public long this[int i]=>Value[i];

public static A157220Inst Instance=new A157220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157221
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,26L,14608L,26L,1L,1L,57L,152637L,152637L,57L,1L,1L,120L,1479726L,251732291184L,1479726L,120L,1L,1L,247L,13824739L,16871482830550L,16871482830550L,13824739L,247L,1L,1L,502L,126781020L,1103881308184906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157221Inst : IEnumerable<long>
{
public static readonly long[] Value=A157221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157221.Bytes);
public long this[int i]=>Value[i];

public static A157221Inst Instance=new A157221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157222
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,3L,4L,5L,6L,5L,8L,6L,9L,10L,10L,8L,15L,9L,14L,14L,15L,11L,21L,14L,18L,17L,22L,14L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157222Inst : IEnumerable<long>
{
public static readonly long[] Value=A157222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157222.Bytes);
public long this[int i]=>Value[i];

public static A157222Inst Instance=new A157222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157223
{
public static readonly long[] Value={ 1L,1L,2L,2L,5L,3L,4L,5L,8L,5L,10L,6L,11L,10L,10L,8L,17L,9L,16L,14L,17L,11L,20L,14L,20L,17L,22L,14L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157223Inst : IEnumerable<long>
{
public static readonly long[] Value=A157223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157223.Bytes);
public long this[int i]=>Value[i];

public static A157223Inst Instance=new A157223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157224
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,4L,6L,6L,8L,6L,12L,6L,12L,12L,12L,8L,18L,10L,18L,16L,18L,12L,24L,14L,20L,18L,24L,14L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157224Inst : IEnumerable<long>
{
public static readonly long[] Value=A157224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157224.Bytes);
public long this[int i]=>Value[i];

public static A157224Inst Instance=new A157224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157225
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,2L,3L,1L,2L,4L,1L,2L,4L,2L,2L,3L,2L,2L,4L,2L,4L,4L,1L,5L,5L,2L,5L,7L,1L,3L,7L,2L,4L,8L,2L,4L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157225Inst : IEnumerable<long>
{
public static readonly long[] Value=A157225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157225.Bytes);
public long this[int i]=>Value[i];

public static A157225Inst Instance=new A157225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157226
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,3L,1L,4L,1L,3L,2L,2L,1L,3L,1L,4L,2L,3L,1L,4L,1L,3L,1L,4L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157226Inst : IEnumerable<long>
{
public static readonly long[] Value=A157226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157226.Bytes);
public long this[int i]=>Value[i];

public static A157226Inst Instance=new A157226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157227
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,4L,4L,6L,4L,8L,4L,8L,8L,8L,6L,12L,6L,12L,10L,12L,8L,16L,10L,14L,12L,16L,10L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157227Inst : IEnumerable<long>
{
public static readonly long[] Value=A157227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157227.Bytes);
public long this[int i]=>Value[i];

public static A157227Inst Instance=new A157227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157228
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157228Inst : IEnumerable<long>
{
public static readonly long[] Value=A157228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157228.Bytes);
public long this[int i]=>Value[i];

public static A157228Inst Instance=new A157228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157229
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,1L,2L,1L,3L,17L,11L,10L,4L,4L,1L,3L,2L,8L,1L,7L,2L,1L,35L,5L,12L,2L,6L,108L,1L,18L,64L,4L,11L,103L,6L,16L,8L,36L,6L,10L,2L,237L,28L,1L,97L,30L,10L,165L,12L,42L,302L,32L,338L,120L,3L,1L,1983L,6L,6L,20L,3255L,9L,696L,882L,648L,6L,313L,13945L,360L,54L,288L,1419L,392L,94766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157229Inst : IEnumerable<long>
{
public static readonly long[] Value=A157229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157229.Bytes);
public long this[int i]=>Value[i];

public static A157229Inst Instance=new A157229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157230
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157230Inst : IEnumerable<long>
{
public static readonly long[] Value=A157230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157230.Bytes);
public long this[int i]=>Value[i];

public static A157230Inst Instance=new A157230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157231
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,2L,4L,4L,4L,3L,7L,4L,6L,6L,7L,5L,8L,6L,8L,8L,9L,6L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157231Inst : IEnumerable<long>
{
public static readonly long[] Value=A157231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157231.Bytes);
public long this[int i]=>Value[i];

public static A157231Inst Instance=new A157231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157232
{
public static readonly BigInteger[] Value={ 1L,-11L,-75L,5137L,64425L,-8116691L,-151949475L,27061582537L,675202758225L,-154763675249051L,-4826608715002875L,1352304080132324737L,BigInteger.Parse("50608880246719532025"),BigInteger.Parse("-16757717498380017159011"),BigInteger.Parse("-731667579810789300424275"),BigInteger.Parse("279544164877458293190983737"),BigInteger.Parse("13948943072618103594908145825") };
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
public class A157232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157232Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157232.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157232.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157232Inst Instance=new A157232Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157233
{
public static readonly BigInteger[] Value={ 1L,-9L,-115L,4563L,103385L,-7273809L,-244682395L,24273348363L,1087614676145L,-138831344004249L,-7774941663643075L,1213102349164829763L,BigInteger.Parse("81523593055504608905"),BigInteger.Parse("-15032750772611708561889"),BigInteger.Parse("-1178611204087999571493355"),BigInteger.Parse("250769133987648650402960763"),BigInteger.Parse("22469741388306099177659661665") };
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
public class A157233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157233Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157233.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157233.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157233Inst Instance=new A157233Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157234
{
public static readonly BigInteger[] Value={ 1L,-5L,-171L,2815L,163305L,-4560125L,-389093571L,15247993735L,1730774795985L,-87230967310325L,-12373627121809371L,762240242336496655L,BigInteger.Parse("129743913678787540665"),BigInteger.Parse("-9445699930131209919725"),BigInteger.Parse("-1875748758904668008579571"),BigInteger.Parse("157568683906141461793511575"),BigInteger.Parse("35760388081788065845786749345") };
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
public class A157234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157234.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157234Inst Instance=new A157234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157235
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,2L,1L,2L,1L,3L,2L,2L,2L,5L,2L,4L,3L,5L,3L,4L,4L,6L,5L,6L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157235Inst : IEnumerable<long>
{
public static readonly long[] Value=A157235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157235.Bytes);
public long this[int i]=>Value[i];

public static A157235Inst Instance=new A157235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157236
{
public static readonly BigInteger[] Value={ 1L,-3L,-187L,1737L,181577L,-2828523L,-433608307L,9464818017L,1929308914577L,-54151301196243L,-13793410821936427L,473188884804949497L,BigInteger.Parse("144631586163051804377"),BigInteger.Parse("-5863775132075093720763"),BigInteger.Parse("-2090985354124427263262947"),BigInteger.Parse("97816726792847265070764177"),BigInteger.Parse("39863788048903869672547506977") };
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
public class A157236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157236.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157236Inst Instance=new A157236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157237
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,2L,2L,0L,1L,1L,1L,2L,2L,2L,4L,1L,2L,5L,2L,1L,3L,1L,1L,2L,1L,3L,3L,1L,3L,5L,2L,2L,5L,4L,0L,5L,4L,2L,4L,3L,3L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157237Inst : IEnumerable<long>
{
public static readonly long[] Value=A157237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157237.Bytes);
public long this[int i]=>Value[i];

public static A157237Inst Instance=new A157237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157238
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157238Inst : IEnumerable<long>
{
public static readonly long[] Value=A157238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157238.Bytes);
public long this[int i]=>Value[i];

public static A157238Inst Instance=new A157238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157239
{
public static readonly BigInteger[] Value={ 1L,-1L,-195L,587L,190905L,-958441L,-456423435L,3208393187L,2031120835185L,-18357153435601L,-14521552284155475L,160410736104452987L,BigInteger.Parse("152266846748812455465"),BigInteger.Parse("-1987817374606532447161"),BigInteger.Parse("-2201371244223771530940315"),BigInteger.Parse("33159832798775207321651987"),BigInteger.Parse("41968251293767181816904683745") };
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
public class A157239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157239Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157239.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157239.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157239Inst Instance=new A157239Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157240
{
public static readonly long[] Value={ 2L,-1L,-7L,-7L,17L,65L,65L,-127L,-511L,-511L,1025L,4097L,4097L,-8191L,-32767L,-32767L,65537L,262145L,262145L,-524287L,-2097151L,-2097151L,4194305L,16777217L,16777217L,-33554431L,-134217727L,-134217727L,268435457L,1073741825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157240Inst : IEnumerable<long>
{
public static readonly long[] Value=A157240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157240.Bytes);
public long this[int i]=>Value[i];

public static A157240Inst Instance=new A157240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157241
{
public static readonly long[] Value={ 0L,1L,3L,3L,-5L,-21L,-21L,43L,171L,171L,-341L,-1365L,-1365L,2731L,10923L,10923L,-21845L,-87381L,-87381L,174763L,699051L,699051L,-1398101L,-5592405L,-5592405L,11184811L,44739243L,44739243L,-89478485L,-357913941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157241Inst : IEnumerable<long>
{
public static readonly long[] Value=A157241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157241.Bytes);
public long this[int i]=>Value[i];

public static A157241Inst Instance=new A157241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157242
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,2L,2L,0L,2L,2L,1L,3L,2L,2L,3L,1L,2L,4L,2L,2L,5L,1L,2L,5L,2L,2L,4L,2L,2L,3L,2L,3L,4L,4L,3L,6L,2L,3L,6L,5L,1L,7L,4L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157242Inst : IEnumerable<long>
{
public static readonly long[] Value=A157242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157242.Bytes);
public long this[int i]=>Value[i];

public static A157242Inst Instance=new A157242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157243
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,6L,1L,1L,10L,336L,10L,1L,1L,15L,825L,825L,15L,1L,1L,21L,1716L,197676L,1716L,21L,1L,1L,28L,3185L,512050L,512050L,3185L,28L,1L,1L,36L,5440L,1163800L,294296640L,1163800L,5440L,36L,1L,1L,45L,8721L,2395575L,778076145L,778076145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157243Inst : IEnumerable<long>
{
public static readonly long[] Value=A157243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157243.Bytes);
public long this[int i]=>Value[i];

public static A157243Inst Instance=new A157243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157244
{
public static readonly long[] Value={ 8L,0L,0L,3L,1L,9L,4L,8L,3L,8L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157244Inst : IEnumerable<long>
{
public static readonly long[] Value=A157244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157244.Bytes);
public long this[int i]=>Value[i];

public static A157244Inst Instance=new A157244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157245
{
public static readonly long[] Value={ 1L,9L,9L,6L,8L,0L,5L,1L,6L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157245Inst : IEnumerable<long>
{
public static readonly long[] Value=A157245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157245.Bytes);
public long this[int i]=>Value[i];

public static A157245Inst Instance=new A157245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157246
{
public static readonly long[] Value={ 245L,265L,287L,343L,427L,493L,637L,833L,1097L,1295L,1715L,2275L,2693L,3577L,4753L,6317L,7483L,9947L,13223L,15665L,20825L,27685L,36805L,43603L,57967L,77063L,91297L,121373L,161357L,214513L,254135L,337855L,449155L,532117L,707413L,940457L,1250273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157246Inst : IEnumerable<long>
{
public static readonly long[] Value=A157246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157246.Bytes);
public long this[int i]=>Value[i];

public static A157246Inst Instance=new A157246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157247
{
public static readonly long[] Value={ 1715L,1781L,1855L,2009L,2401L,2989L,3451L,3821L,4459L,5831L,6865L,7679L,9065L,12005L,15925L,18851L,21145L,25039L,33271L,39409L,44219L,52381L,69629L,92561L,109655L,123049L,145775L,193795L,229589L,257635L,305221L,405769L,539441L,639079L,717149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157247Inst : IEnumerable<long>
{
public static readonly long[] Value=A157247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157247.Bytes);
public long this[int i]=>Value[i];

public static A157247Inst Instance=new A157247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157248
{
public static readonly BigInteger[] Value={ 1L,2L,3L,6L,4L,5L,7L,8L,9L,10L,15L,230L,57960L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,1544L,8242614L,92401258430373L,BigInteger.Parse("36895712779713620978746324067") };
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
public class A157248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157248Inst Instance=new A157248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157249
{
public static readonly BigInteger[] Value={ 2L,1L,1L,1L,5L,1L,103L,13L,249L,19L,329891L,32L,36846277L,1379L,59793L,126689L,1230752346353L,4727L,336967037143579L,436486L,2252263619L,56815333L,BigInteger.Parse("48869596859895986087"),1549256L,1654529071288638505L };
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
public class A157249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157249Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157249.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157249.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157249Inst Instance=new A157249Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157250
{
public static readonly long[] Value={ 1L,5L,13L,563L,5971L,558771L,1964215L,8121909L,12326713L,23025711L,26921605L,341569806L,399292158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157250Inst : IEnumerable<long>
{
public static readonly long[] Value=A157250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157250.Bytes);
public long this[int i]=>Value[i];

public static A157250Inst Instance=new A157250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157251
{
public static readonly BigInteger[] Value={ 1L,-27L,-28L,24219L,24332L,-20389347L,-61411588L,291526667163L,292673926412L,-447084877557357L,-2244211491474148L,8381131247279783169L,BigInteger.Parse("25242216399951224492"),BigInteger.Parse("-55704823288904521744767"),BigInteger.Parse("-391466323601155096355908"),BigInteger.Parse("7974404401271062871811603051"),BigInteger.Parse("8005746236354753076591210572") };
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
public class A157251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157251Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157251.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157251.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157251Inst Instance=new A157251Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157252
{
public static readonly BigInteger[] Value={ 1L,58L,841L,97556L,707281L,41022298L,594823321L,137999010472L,500246412961L,29014291951738L,420707233300201L,48802039062823316L,353814783205469041L,BigInteger.Parse("20521257425917204378"),BigInteger.Parse("297558232675799463481"),BigInteger.Parse("138067019961570951055184") };
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
public class A157252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157252Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157252.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157252.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157252Inst Instance=new A157252Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157253
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,6L,8L,26L,41L,145L,253L,978L,1858L,7726L,15796L,69878L,152219L,711243L,1638323L,8039510L,99862594L,252998224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157253Inst : IEnumerable<long>
{
public static readonly long[] Value=A157253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157253.Bytes);
public long this[int i]=>Value[i];

public static A157253Inst Instance=new A157253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157254
{
public static readonly long[] Value={ 1L,2L,4L,9L,15L,25L,41L,64L,96L,142L,207L,295L,416L,578L,795L,1081L,1458L,1948L,2583L,3400L,4445L,5774L,7457L,9576L,12234L,15554L,19683L,24798L,31113L,38882L,48409L,60055L,74248L,91494L,112395L,137656L,168110L,204735L,248677L,301278L,364107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157254Inst : IEnumerable<long>
{
public static readonly long[] Value=A157254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157254.Bytes);
public long this[int i]=>Value[i];

public static A157254Inst Instance=new A157254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157255
{
public static readonly long[] Value={ 1L,17L,7625597484988L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157255Inst : IEnumerable<long>
{
public static readonly long[] Value=A157255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157255.Bytes);
public long this[int i]=>Value[i];

public static A157255Inst Instance=new A157255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157256
{
public static readonly long[] Value={ 1087L,3253L,4993L,9277L,11807L,14717L,15073L,17033L,20627L,24197L,26953L,29753L,31883L,33023L,33637L,36473L,38113L,40387L,40897L,41843L,43403L,52057L,58153L,62473L,66587L,67967L,70537L,83983L,99173L,99713L,102023L,108287L,117673L,124247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157256Inst : IEnumerable<long>
{
public static readonly long[] Value=A157256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157256.Bytes);
public long this[int i]=>Value[i];

public static A157256Inst Instance=new A157256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157257
{
public static readonly long[] Value={ 29L,41L,85L,89L,205L,481L,505L,1189L,2801L,2941L,6929L,16325L,17141L,40385L,95149L,99905L,235381L,554569L,582289L,1371901L,3232265L,3393829L,7996025L,18839021L,19780685L,46604249L,109801861L,115290281L,271629469L,639972145L,671961001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157257Inst : IEnumerable<long>
{
public static readonly long[] Value=A157257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157257.Bytes);
public long this[int i]=>Value[i];

public static A157257Inst Instance=new A157257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157258
{
public static readonly long[] Value={ 9L,8L,2L,8L,4L,2L,7L,1L,2L,4L,7L,4L,6L,1L,9L,0L,0L,9L,7L,6L,0L,3L,3L,7L,7L,4L,4L,8L,4L,1L,9L,3L,9L,6L,1L,5L,7L,1L,3L,9L,3L,4L,3L,7L,5L,0L,7L,5L,3L,8L,9L,6L,1L,4L,6L,3L,5L,3L,3L,5L,9L,4L,7L,5L,9L,8L,1L,4L,6L,4L,9L,5L,6L,9L,2L,4L,2L,1L,4L,0L,7L,7L,7L,0L,0L,7L,7L,5L,0L,6L,8L,6L,5L,5L,2L,8L,3L,1L,4L,5L,4L,7L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157258Inst : IEnumerable<long>
{
public static readonly long[] Value=A157258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157258.Bytes);
public long this[int i]=>Value[i];

public static A157258Inst Instance=new A157258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157259
{
public static readonly long[] Value={ 4L,1L,7L,1L,5L,7L,2L,8L,7L,5L,2L,5L,3L,8L,0L,9L,9L,0L,2L,3L,9L,6L,6L,2L,2L,5L,5L,1L,5L,8L,0L,6L,0L,3L,8L,4L,2L,8L,6L,0L,6L,5L,6L,2L,4L,9L,2L,4L,6L,1L,0L,3L,8L,5L,3L,6L,4L,6L,6L,4L,0L,5L,2L,4L,0L,1L,8L,5L,3L,5L,0L,4L,3L,0L,7L,5L,7L,8L,5L,9L,2L,2L,2L,9L,9L,2L,2L,4L,9L,3L,1L,3L,4L,4L,7L,1L,6L,8L,5L,4L,5L,2L,9L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157259Inst : IEnumerable<long>
{
public static readonly long[] Value=A157259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157259.Bytes);
public long this[int i]=>Value[i];

public static A157259Inst Instance=new A157259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157260
{
public static readonly long[] Value={ 2L,3L,5L,6L,0L,4L,8L,2L,8L,6L,4L,9L,8L,6L,9L,9L,0L,5L,7L,7L,1L,8L,2L,2L,6L,4L,4L,5L,8L,0L,1L,7L,4L,5L,0L,2L,9L,2L,6L,7L,0L,9L,2L,9L,8L,8L,0L,6L,2L,3L,0L,6L,0L,0L,1L,1L,9L,3L,8L,3L,0L,0L,6L,4L,9L,6L,9L,2L,8L,0L,7L,1L,6L,9L,9L,8L,5L,1L,2L,1L,2L,4L,0L,9L,2L,9L,4L,7L,5L,8L,4L,4L,1L,8L,8L,7L,7L,1L,7L,1L,6L,2L,3L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157260Inst : IEnumerable<long>
{
public static readonly long[] Value=A157260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157260.Bytes);
public long this[int i]=>Value[i];

public static A157260Inst Instance=new A157260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157261
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,10L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L,1L,1L,1L,9L,1L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157261Inst : IEnumerable<long>
{
public static readonly long[] Value=A157261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157261.Bytes);
public long this[int i]=>Value[i];

public static A157261Inst Instance=new A157261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157262
{
public static readonly long[] Value={ 2L,55L,180L,377L,646L,987L,1400L,1885L,2442L,3071L,3772L,4545L,5390L,6307L,7296L,8357L,9490L,10695L,11972L,13321L,14742L,16235L,17800L,19437L,21146L,22927L,24780L,26705L,28702L,30771L,32912L,35125L,37410L,39767L,42196L,44697L,47270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157262Inst : IEnumerable<long>
{
public static readonly long[] Value=A157262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157262.Bytes);
public long this[int i]=>Value[i];

public static A157262Inst Instance=new A157262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157263
{
public static readonly long[] Value={ 408L,2136L,3864L,5592L,7320L,9048L,10776L,12504L,14232L,15960L,17688L,19416L,21144L,22872L,24600L,26328L,28056L,29784L,31512L,33240L,34968L,36696L,38424L,40152L,41880L,43608L,45336L,47064L,48792L,50520L,52248L,53976L,55704L,57432L,59160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157263Inst : IEnumerable<long>
{
public static readonly long[] Value=A157263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157263.Bytes);
public long this[int i]=>Value[i];

public static A157263Inst Instance=new A157263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157264
{
public static readonly long[] Value={ 577L,15841L,51841L,108577L,186049L,284257L,403201L,542881L,703297L,884449L,1086337L,1308961L,1552321L,1816417L,2101249L,2406817L,2733121L,3080161L,3447937L,3836449L,4245697L,4675681L,5126401L,5597857L,6090049L,6602977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157264Inst : IEnumerable<long>
{
public static readonly long[] Value=A157264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157264.Bytes);
public long this[int i]=>Value[i];

public static A157264Inst Instance=new A157264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157265
{
public static readonly long[] Value={ 21L,112L,275L,510L,817L,1196L,1647L,2170L,2765L,3432L,4171L,4982L,5865L,6820L,7847L,8946L,10117L,11360L,12675L,14062L,15521L,17052L,18655L,20330L,22077L,23896L,25787L,27750L,29785L,31892L,34071L,36322L,38645L,41040L,43507L,46046L,48657L,51340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157265Inst : IEnumerable<long>
{
public static readonly long[] Value=A157265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157265.Bytes);
public long this[int i]=>Value[i];

public static A157265Inst Instance=new A157265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157266
{
public static readonly long[] Value={ 1320L,3048L,4776L,6504L,8232L,9960L,11688L,13416L,15144L,16872L,18600L,20328L,22056L,23784L,25512L,27240L,28968L,30696L,32424L,34152L,35880L,37608L,39336L,41064L,42792L,44520L,46248L,47976L,49704L,51432L,53160L,54888L,56616L,58344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157266Inst : IEnumerable<long>
{
public static readonly long[] Value=A157266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157266.Bytes);
public long this[int i]=>Value[i];

public static A157266Inst Instance=new A157266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157267
{
public static readonly long[] Value={ 6049L,32257L,79201L,146881L,235297L,344449L,474337L,624961L,796321L,988417L,1201249L,1434817L,1689121L,1964161L,2259937L,2576449L,2913697L,3271681L,3650401L,4049857L,4470049L,4910977L,5372641L,5855041L,6358177L,6882049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157267Inst : IEnumerable<long>
{
public static readonly long[] Value=A157267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157267.Bytes);
public long this[int i]=>Value[i];

public static A157267Inst Instance=new A157267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157268
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,17L,17L,1L,1L,40L,126L,40L,1L,1L,87L,606L,606L,87L,1L,1L,182L,2413L,5856L,2413L,182L,1L,1L,373L,8679L,40337L,40337L,8679L,373L,1L,1L,756L,29376L,232726L,497066L,232726L,29376L,756L,1L,1L,1523L,95668L,1205968L,4527078L,4527078L,1205968L,95668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157268Inst : IEnumerable<long>
{
public static readonly long[] Value=A157268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157268.Bytes);
public long this[int i]=>Value[i];

public static A157268Inst Instance=new A157268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157269
{
public static readonly BigInteger[] Value={ 1L,-25L,-54L,23725L,48330L,-20025625L,-122094054L,286383415925L,581912208810L,-439205885935375L,-4462108112221254L,8233447739522861575L,BigInteger.Parse("50188486516750479690"),BigInteger.Parse("-54723264020351795696125"),BigInteger.Parse("-778343054971494188358054"),BigInteger.Parse("7833889830658835651776115125"),BigInteger.Parse("15917632400777165948450612970") };
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
public class A157269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157269.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157269Inst Instance=new A157269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157270
{
public static readonly BigInteger[] Value={ 1L,-23L,-78L,22931L,71682L,-19424903L,-181328238L,277879179787L,864319987362L,-426177037291793L,-6627683893384398L,7989233406387885881L,BigInteger.Parse("74546334230241279042"),BigInteger.Parse("-53100123646867742341283"),BigInteger.Parse("-1156094411441993834035758"),BigInteger.Parse("7601530050577496205935738699"),BigInteger.Parse("23642898846647194126486858722") };
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
public class A157270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157270.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157270Inst Instance=new A157270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157271
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,3L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,10L,11L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,32L,32L,33L,33L,33L,34L,34L,35L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157271Inst : IEnumerable<long>
{
public static readonly long[] Value=A157271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157271.Bytes);
public long this[int i]=>Value[i];

public static A157271Inst Instance=new A157271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157272
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,20L,20L,1L,1L,47L,155L,47L,1L,1L,102L,753L,753L,102L,1L,1L,213L,3004L,7109L,3004L,213L,1L,1L,436L,10800L,48727L,48727L,10800L,436L,1L,1L,883L,36517L,280736L,551251L,280736L,36517L,883L,1L,1L,1778L,118795L,1454163L,4879214L,4879214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157272Inst : IEnumerable<long>
{
public static readonly long[] Value=A157272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157272.Bytes);
public long this[int i]=>Value[i];

public static A157272Inst Instance=new A157272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157273
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,47L,47L,1L,1L,154L,590L,154L,1L,1L,477L,4498L,4498L,477L,1L,1L,1448L,28323L,71232L,28323L,1448L,1L,1L,4363L,162313L,816503L,816503L,162313L,4363L,1L,1L,13110L,882764L,7897486L,15979230L,7897486L,882764L,13110L,1L,1L,39353L,4654100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157273Inst : IEnumerable<long>
{
public static readonly long[] Value=A157273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157273.Bytes);
public long this[int i]=>Value[i];

public static A157273Inst Instance=new A157273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157274
{
public static readonly long[] Value={ 1L,1L,1L,1L,17L,1L,1L,84L,84L,1L,1L,355L,1431L,355L,1L,1L,1442L,14827L,14827L,1442L,1L,1L,5793L,127860L,326591L,127860L,5793L,1L,1L,23200L,1009338L,5239457L,5239457L,1009338L,23200L,1L,1L,92831L,7593061L,71229038L,145043839L,71229038L,7593061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157274Inst : IEnumerable<long>
{
public static readonly long[] Value=A157274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157274.Bytes);
public long this[int i]=>Value[i];

public static A157274Inst Instance=new A157274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157275
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,17L,17L,1L,1L,40L,126L,40L,1L,1L,87L,606L,606L,87L,1L,1L,182L,2413L,5604L,2413L,182L,1L,1L,373L,8679L,38117L,38117L,8679L,373L,1L,1L,756L,29376L,219020L,426002L,219020L,29376L,756L,1L,1L,1523L,95668L,1133786L,3749066L,3749066L,1133786L,95668L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157275Inst : IEnumerable<long>
{
public static readonly long[] Value=A157275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157275.Bytes);
public long this[int i]=>Value[i];

public static A157275Inst Instance=new A157275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157276
{
public static readonly long[] Value={ 0L,0L,1L,1L,5L,5L,6L,6L,11L,11L,12L,12L,16L,16L,17L,17L,31L,31L,32L,32L,36L,36L,37L,37L,42L,42L,43L,43L,47L,47L,48L,48L,66L,66L,67L,67L,71L,71L,72L,72L,77L,77L,78L,78L,82L,82L,83L,83L,97L,97L,98L,98L,102L,102L,103L,103L,108L,108L,109L,109L,113L,113L,114L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157276Inst : IEnumerable<long>
{
public static readonly long[] Value=A157276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157276.Bytes);
public long this[int i]=>Value[i];

public static A157276Inst Instance=new A157276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157277
{
public static readonly long[] Value={ 1L,1L,1L,1L,10L,1L,1L,39L,39L,1L,1L,128L,470L,128L,1L,1L,397L,3558L,3558L,397L,1L,1L,1206L,22387L,55452L,22387L,1206L,1L,1L,3635L,128377L,632343L,632343L,128377L,3635L,1L,1L,10924L,698788L,6107192L,12269406L,6107192L,698788L,10924L,1L,1L,32793L,3686880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157277Inst : IEnumerable<long>
{
public static readonly long[] Value=A157277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157277.Bytes);
public long this[int i]=>Value[i];

public static A157277Inst Instance=new A157277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157278
{
public static readonly long[] Value={ 1L,1L,1L,1L,14L,1L,1L,69L,69L,1L,1L,292L,1134L,292L,1L,1L,1187L,11686L,11686L,1187L,1L,1L,4770L,100737L,254132L,100737L,4770L,1L,1L,19105L,795723L,4061249L,4061249L,795723L,19105L,1L,1L,76448L,5990296L,55157324L,111691642L,55157324L,5990296L,76448L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157278Inst : IEnumerable<long>
{
public static readonly long[] Value=A157278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157278.Bytes);
public long this[int i]=>Value[i];

public static A157278Inst Instance=new A157278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157279
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,2L,6L,6L,6L,6L,6L,6L,6L,8L,7L,6L,5L,4L,3L,2L,1L,0L,20L,16L,12L,8L,4L,0L,27L,24L,21L,18L,15L,0L,17L,36L,18L,0L,23L,6L,32L,16L,0L,30L,15L,0L,42L,40L,42L,48L,5L,18L,35L,0L,24L,52L,25L,0L,38L,18L,0L,0L,20L,60L,53L,64L,24L,0L,63L,0L,24L,64L,45L,40L,49L,72L,30L,0L,0L,30L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157279Inst : IEnumerable<long>
{
public static readonly long[] Value=A157279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157279.Bytes);
public long this[int i]=>Value[i];

public static A157279Inst Instance=new A157279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157280
{
public static readonly BigInteger[] Value={ 1L,52L,43833L,149670844L,1346634725665L,25571928251231076L,BigInteger.Parse("893591647147188285577"),BigInteger.Parse("52327970757667659912764908"),BigInteger.Parse("4796836032234830356783078467969") };
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
public class A157280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157280.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157280Inst Instance=new A157280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157281
{
public static readonly BigInteger[] Value={ 5L,735L,388495L,481590401L,1137296646141L,4516854024385855L,BigInteger.Parse("27752662708200238775"),BigInteger.Parse("248444078372890409312385"),BigInteger.Parse("3097105045238321286477572341"),BigInteger.Parse("51894055293560470969321661603231") };
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
public class A157281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157281.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157281Inst Instance=new A157281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157282
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,12L,12L,13L,14L,14L,15L,16L,16L,17L,18L,19L,20L,21L,21L,22L,23L,24L,25L,26L,26L,27L,28L,29L,30L,31L,31L,32L,33L,34L,35L,36L,36L,37L,38L,39L,40L,41L,41L,42L,43L,43L,44L,45L,45L,46L,47L,48L,49L,50L,50L,51L,52L,53L,54L,55L,55L,56L,57L,58L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157282Inst : IEnumerable<long>
{
public static readonly long[] Value=A157282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157282.Bytes);
public long this[int i]=>Value[i];

public static A157282Inst Instance=new A157282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157283
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,-3L,1L,1L,4L,6L,0L,1L,1L,5L,-10L,-10L,-5L,1L,1L,6L,15L,-20L,15L,-6L,1L,1L,7L,-21L,0L,0L,-21L,-7L,1L,1L,8L,28L,56L,0L,0L,0L,0L,1L,1L,9L,-36L,84L,126L,126L,0L,0L,0L,1L,1L,10L,45L,0L,-210L,252L,-210L,0L,0L,-10L,1L,1L,11L,-55L,-165L,330L,0L,0L,330L,165L,-55L,-11L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157283Inst : IEnumerable<long>
{
public static readonly long[] Value=A157283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157283.Bytes);
public long this[int i]=>Value[i];

public static A157283Inst Instance=new A157283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157284
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,2L,4L,1L,3L,15L,105L,1L,4L,36L,744L,29016L,1L,5L,70L,3010L,389795L,121226245L,1L,6L,120L,9120L,2736000L,3065414400L,10017774259200L,1L,7L,189L,22995L,13452075L,37781497845L,471626437599135L,BigInteger.Parse("20185139902805378865"),1L,8L,280L,50960L };
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
public class A157284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157284.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157284Inst Instance=new A157284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157285
{
public static readonly long[] Value={ 1L,2L,2L,6L,12L,18L,28L,84L,336L,1456L,210L,840L,6300L,88200L,1874250L,2604L,13020L,156240L,4843440L,377788320L,59010535584L,54684L,328104L,5741820L,329197680L,63946649340L,39774815889480L,61856467844122980L,1984248L,13889736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157285Inst : IEnumerable<long>
{
public static readonly long[] Value=A157285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157285.Bytes);
public long this[int i]=>Value[i];

public static A157285Inst Instance=new A157285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157286
{
public static readonly long[] Value={ 35L,142L,321L,572L,895L,1290L,1757L,2296L,2907L,3590L,4345L,5172L,6071L,7042L,8085L,9200L,10387L,11646L,12977L,14380L,15855L,17402L,19021L,20712L,22475L,24310L,26217L,28196L,30247L,32370L,34565L,36832L,39171L,41582L,44065L,46620L,49247L,51946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157286Inst : IEnumerable<long>
{
public static readonly long[] Value=A157286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157286.Bytes);
public long this[int i]=>Value[i];

public static A157286Inst Instance=new A157286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157287
{
public static readonly long[] Value={ 1704L,3432L,5160L,6888L,8616L,10344L,12072L,13800L,15528L,17256L,18984L,20712L,22440L,24168L,25896L,27624L,29352L,31080L,32808L,34536L,36264L,37992L,39720L,41448L,43176L,44904L,46632L,48360L,50088L,51816L,53544L,55272L,57000L,58728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157287Inst : IEnumerable<long>
{
public static readonly long[] Value=A157287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157287.Bytes);
public long this[int i]=>Value[i];

public static A157287Inst Instance=new A157287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157288
{
public static readonly long[] Value={ 10081L,40897L,92449L,164737L,257761L,371521L,506017L,661249L,837217L,1033921L,1251361L,1489537L,1748449L,2028097L,2328481L,2649601L,2991457L,3354049L,3737377L,4141441L,4566241L,5011777L,5478049L,5965057L,6472801L,7001281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157288Inst : IEnumerable<long>
{
public static readonly long[] Value=A157288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157288.Bytes);
public long this[int i]=>Value[i];

public static A157288Inst Instance=new A157288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157289
{
public static readonly long[] Value={ 1L,1L,8L,1L,5L,6L,4L,9L,4L,9L,0L,1L,0L,2L,5L,6L,9L,1L,2L,5L,6L,9L,3L,9L,9L,7L,3L,4L,1L,6L,0L,4L,5L,4L,2L,6L,0L,5L,4L,7L,0L,2L,3L,2L,6L,0L,7L,6L,8L,6L,8L,2L,6L,1L,0L,2L,8L,3L,0L,4L,3L,1L,4L,8L,8L,7L,7L,2L,0L,5L,4L,2L,1L,1L,1L,0L,3L,1L,8L,8L,3L,9L,9L,0L,0L,2L,9L,9L,4L,8L,7L,1L,1L,8L,4L,4L,4L,9L,2L,7L,0L,1L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157289Inst : IEnumerable<long>
{
public static readonly long[] Value=A157289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157289.Bytes);
public long this[int i]=>Value[i];

public static A157289Inst Instance=new A157289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157290
{
public static readonly long[] Value={ 1L,0L,7L,7L,9L,2L,8L,1L,3L,6L,7L,4L,1L,8L,5L,5L,1L,9L,4L,8L,6L,1L,0L,4L,2L,2L,4L,3L,0L,4L,7L,4L,6L,2L,8L,8L,4L,8L,9L,1L,9L,1L,9L,1L,9L,4L,6L,3L,2L,0L,1L,7L,5L,8L,5L,4L,0L,7L,6L,4L,3L,7L,2L,4L,5L,5L,7L,2L,3L,4L,5L,8L,0L,9L,3L,2L,9L,5L,1L,6L,2L,6L,1L,5L,2L,6L,0L,0L,1L,0L,2L,6L,0L,0L,5L,5L,0L,1L,5L,0L,9L,0L,8L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157290Inst : IEnumerable<long>
{
public static readonly long[] Value=A157290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157290.Bytes);
public long this[int i]=>Value[i];

public static A157290Inst Instance=new A157290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157291
{
public static readonly long[] Value={ 1L,0L,3L,5L,8L,9L,7L,4L,7L,7L,2L,7L,7L,5L,0L,0L,2L,2L,4L,3L,9L,4L,4L,9L,8L,5L,8L,7L,4L,5L,6L,0L,9L,5L,6L,8L,4L,2L,4L,7L,8L,8L,4L,2L,5L,6L,0L,7L,6L,8L,9L,4L,8L,0L,8L,2L,2L,4L,6L,6L,5L,4L,2L,3L,7L,4L,4L,6L,6L,9L,2L,5L,6L,1L,2L,4L,0L,3L,3L,7L,4L,1L,8L,9L,3L,2L,1L,5L,9L,8L,8L,3L,9L,3L,9L,0L,6L,8L,0L,1L,1L,4L,6L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157291Inst : IEnumerable<long>
{
public static readonly long[] Value=A157291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157291.Bytes);
public long this[int i]=>Value[i];

public static A157291Inst Instance=new A157291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157292
{
public static readonly long[] Value={ 1L,6L,1L,6L,8L,9L,2L,2L,0L,5L,1L,1L,2L,7L,8L,2L,7L,9L,2L,2L,9L,1L,5L,6L,3L,3L,6L,4L,5L,7L,1L,1L,9L,4L,3L,2L,7L,3L,3L,7L,8L,7L,8L,7L,9L,1L,9L,4L,8L,0L,2L,6L,3L,7L,8L,1L,1L,1L,4L,6L,5L,5L,8L,6L,8L,3L,5L,8L,5L,1L,8L,7L,1L,3L,9L,9L,4L,2L,7L,4L,3L,9L,2L,2L,8L,9L,0L,0L,1L,5L,3L,9L,0L,0L,8L,2L,5L,2L,2L,6L,3L,6L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157292Inst : IEnumerable<long>
{
public static readonly long[] Value=A157292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157292.Bytes);
public long this[int i]=>Value[i];

public static A157292Inst Instance=new A157292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157293
{
public static readonly long[] Value={ 1L,1L,9L,9L,6L,4L,7L,5L,3L,9L,6L,4L,7L,1L,3L,9L,7L,9L,0L,9L,4L,8L,0L,7L,8L,3L,0L,4L,8L,1L,0L,4L,0L,2L,3L,3L,0L,9L,9L,9L,8L,6L,5L,8L,5L,0L,2L,6L,2L,4L,3L,0L,8L,5L,3L,4L,7L,6L,0L,2L,7L,8L,1L,5L,5L,2L,4L,1L,9L,8L,3L,8L,0L,7L,7L,0L,9L,8L,1L,0L,0L,3L,6L,8L,4L,2L,0L,2L,4L,5L,8L,0L,1L,0L,9L,7L,8L,4L,7L,3L,1L,2L,3L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157293Inst : IEnumerable<long>
{
public static readonly long[] Value=A157293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157293.Bytes);
public long this[int i]=>Value[i];

public static A157293Inst Instance=new A157293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157294
{
public static readonly long[] Value={ 1L,6L,3L,8L,2L,5L,4L,3L,2L,0L,4L,4L,0L,9L,6L,7L,3L,6L,6L,3L,4L,1L,4L,9L,4L,2L,7L,4L,9L,8L,9L,8L,7L,3L,5L,5L,4L,9L,1L,8L,7L,0L,2L,5L,2L,6L,6L,4L,4L,3L,4L,4L,7L,1L,8L,0L,7L,2L,9L,0L,0L,6L,7L,4L,8L,9L,2L,5L,0L,4L,2L,3L,5L,5L,7L,4L,4L,7L,9L,0L,4L,1L,3L,4L,8L,3L,1L,5L,9L,2L,4L,6L,3L,0L,4L,9L,2L,3L,6L,9L,2L,5L,6L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157294Inst : IEnumerable<long>
{
public static readonly long[] Value=A157294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157294.Bytes);
public long this[int i]=>Value[i];

public static A157294Inst Instance=new A157294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157295
{
public static readonly long[] Value={ 6L,5L,5L,3L,0L,1L,7L,2L,8L,1L,7L,6L,3L,8L,6L,9L,4L,6L,5L,3L,6L,5L,9L,7L,7L,0L,9L,9L,9L,5L,9L,4L,9L,4L,2L,1L,9L,6L,7L,4L,8L,1L,0L,1L,0L,6L,5L,7L,7L,3L,7L,8L,8L,7L,2L,2L,9L,1L,6L,0L,2L,6L,9L,9L,5L,7L,0L,0L,1L,6L,9L,4L,2L,2L,9L,7L,9L,1L,6L,1L,6L,5L,3L,9L,3L,2L,6L,3L,6L,9L,8L,5L,2L,1L,9L,6L,9L,4L,7L,7L,0L,2L,7L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157295Inst : IEnumerable<long>
{
public static readonly long[] Value=A157295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157295.Bytes);
public long this[int i]=>Value[i];

public static A157295Inst Instance=new A157295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157296
{
public static readonly long[] Value={ 1L,6L,4L,3L,2L,9L,9L,6L,8L,1L,8L,5L,7L,0L,9L,9L,9L,9L,2L,2L,7L,7L,4L,8L,0L,1L,8L,0L,1L,2L,9L,1L,4L,9L,7L,8L,4L,6L,0L,8L,2L,8L,7L,5L,8L,4L,4L,5L,7L,2L,3L,5L,0L,9L,8L,5L,9L,5L,8L,3L,4L,5L,0L,5L,1L,6L,4L,3L,2L,8L,6L,4L,8L,1L,2L,4L,5L,5L,1L,7L,4L,9L,5L,3L,7L,5L,1L,3L,7L,4L,2L,3L,7L,6L,5L,4L,9L,2L,9L,5L,6L,5L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157296Inst : IEnumerable<long>
{
public static readonly long[] Value=A157296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157296.Bytes);
public long this[int i]=>Value[i];

public static A157296Inst Instance=new A157296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157297
{
public static readonly long[] Value={ 185L,233L,317L,793L,1165L,1717L,4573L,6757L,9985L,26645L,39377L,58193L,155297L,229505L,339173L,905137L,1337653L,1976845L,5275525L,7796413L,11521897L,30748013L,45440825L,67154537L,179212553L,264848537L,391405325L,1044527305L,1543650397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157297Inst : IEnumerable<long>
{
public static readonly long[] Value=A157297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157297.Bytes);
public long this[int i]=>Value[i];

public static A157297Inst Instance=new A157297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157298
{
public static readonly long[] Value={ 1L,4L,7L,7L,8L,4L,5L,9L,0L,1L,7L,8L,8L,0L,8L,7L,0L,0L,9L,5L,3L,1L,8L,0L,8L,8L,2L,3L,1L,6L,6L,6L,9L,5L,5L,9L,3L,0L,7L,1L,2L,3L,7L,5L,2L,6L,9L,3L,0L,8L,0L,9L,3L,2L,5L,4L,4L,9L,1L,8L,8L,2L,5L,1L,9L,6L,3L,0L,4L,0L,1L,0L,1L,1L,9L,5L,2L,7L,4L,9L,5L,5L,2L,1L,0L,8L,3L,9L,3L,8L,7L,4L,0L,6L,1L,1L,3L,0L,6L,3L,5L,2L,1L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157298Inst : IEnumerable<long>
{
public static readonly long[] Value=A157298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157298.Bytes);
public long this[int i]=>Value[i];

public static A157298Inst Instance=new A157298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157299
{
public static readonly long[] Value={ 2L,6L,6L,8L,6L,5L,8L,9L,0L,2L,3L,7L,9L,6L,2L,3L,4L,0L,4L,3L,4L,9L,6L,5L,3L,7L,8L,8L,5L,5L,6L,6L,6L,9L,0L,5L,6L,3L,3L,5L,9L,5L,4L,8L,4L,6L,7L,0L,6L,4L,6L,0L,3L,0L,8L,0L,1L,7L,6L,3L,1L,7L,2L,7L,6L,7L,4L,7L,0L,2L,9L,9L,7L,4L,1L,5L,4L,3L,5L,4L,0L,9L,0L,2L,5L,4L,4L,8L,3L,0L,6L,9L,5L,8L,0L,5L,8L,8L,7L,8L,3L,6L,4L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157299Inst : IEnumerable<long>
{
public static readonly long[] Value=A157299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157299.Bytes);
public long this[int i]=>Value[i];

public static A157299Inst Instance=new A157299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157300
{
public static readonly long[] Value={ 1L,0L,4L,9L,9L,8L,4L,7L,6L,3L,0L,0L,8L,7L,0L,8L,8L,1L,1L,9L,1L,5L,8L,2L,2L,6L,9L,2L,4L,4L,7L,4L,4L,9L,4L,2L,8L,0L,5L,2L,9L,6L,9L,0L,4L,7L,4L,5L,5L,0L,0L,4L,7L,5L,2L,0L,7L,8L,6L,7L,1L,8L,7L,6L,7L,4L,2L,0L,9L,5L,4L,6L,9L,2L,1L,5L,2L,3L,0L,3L,4L,3L,9L,9L,3L,6L,4L,8L,1L,1L,2L,4L,2L,7L,7L,2L,3L,5L,0L,4L,5L,9L,1L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157300Inst : IEnumerable<long>
{
public static readonly long[] Value=A157300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157300.Bytes);
public long this[int i]=>Value[i];

public static A157300Inst Instance=new A157300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157301
{
public static readonly long[] Value={ 2L,2L,3L,11L,18L,31L,54L,97L,172L,309L,188L,257L,475L,878L,3271L,12251L,23000L,4339L,16405L,155611L,295947L,564163L,1077871L,2063689L,3957809L,7603553L,14630843L,28192750L,27200014L,105097565L,203280221L,393615806L,762939111L,493402093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157301Inst : IEnumerable<long>
{
public static readonly long[] Value=A157301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157301.Bytes);
public long this[int i]=>Value[i];

public static A157301Inst Instance=new A157301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157302
{
public static readonly BigInteger[] Value={ 1L,1L,0L,-5L,0L,183L,0L,-14352L,0L,1857199L,0L,-355082433L,0L,94134281460L,0L,-33120720127500L,0L,14959943533260783L,0L,-8447188671812872887L,0L,BigInteger.Parse("5834800994047642310223"),0L,BigInteger.Parse("-4842259038722174600622240"),0L };
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
public class A157302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157302.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157302Inst Instance=new A157302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157303
{
public static readonly long[] Value={ 1L,1L,1L,-4L,-19L,134L,1074L,-10158L,-110067L,1302086L,17451662L,-248857456L,-3948994550L,66104803660L,1210719480268L,-23304935437410L,-484165206834051L,10541640152174406L,245149591293286518L,-5958110923842801192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A157303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157303Inst : IEnumerable<long>
{
public static readonly long[] Value=A157303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A157303.Bytes);
public long this[int i]=>Value[i];

public static A157303Inst Instance=new A157303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A157304
{
public static readonly BigInteger[] Value={ 1L,1L,2L,0L,-26L,0L,1378L,0L,-141202L,0L,22716418L,0L,-5218302090L,0L,1619288968386L,0L,-653379470919714L,0L,333014944014777730L,0L,BigInteger.Parse("-209463165121436380282"),0L,BigInteger.Parse("159492000935562428176162"),0L,BigInteger.Parse("-144654795258284936534929586"),0L };
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
public class A157304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A157304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A157304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A157304.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A157304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A157304Inst Instance=new A157304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}