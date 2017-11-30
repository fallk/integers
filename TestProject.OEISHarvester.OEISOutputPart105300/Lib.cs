using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A126749
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,1L,2L,6L,1L,1L,3L,17L,30L,5L,1L,4L,34L,189L,232L,8L,1L,5L,59L,627L,3627L,2762L,42L,1L,6L,92L,1631L,23262L,118114L,50814L,146L,1L,7L,135L,3643L,101409L,1686975L,6530233L,1420183L,956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126749Inst : IEnumerable<long>
{
public static readonly long[] Value=A126749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126749.Bytes);
public long this[int i]=>Value[i];

public static A126749Inst Instance=new A126749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126750
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,1L,5L,8L,42L,146L,956L,6643L,65921L,818448L,13442572L,287665498L,8099980771L,300760170216L,14791653463768L,967055338887805L,84368806391412395L,9855854129239183783UL,BigInteger.Parse("1546801291978378704267") };
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
public class A126750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126750.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A126750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126750Inst Instance=new A126750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126751
{
public static readonly long[] Value={ 0L,0L,1L,1L,6L,30L,232L,2762L,50814L,1420183L,58836784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126751Inst : IEnumerable<long>
{
public static readonly long[] Value=A126751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126751.Bytes);
public long this[int i]=>Value[i];

public static A126751Inst Instance=new A126751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126752
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,17L,189L,3627L,118114L,6530233L,596566067L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126752Inst : IEnumerable<long>
{
public static readonly long[] Value=A126752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126752.Bytes);
public long this[int i]=>Value[i];

public static A126752Inst Instance=new A126752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126753
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,3L,34L,627L,23262L,1686975L,231563309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126753Inst : IEnumerable<long>
{
public static readonly long[] Value=A126753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126753.Bytes);
public long this[int i]=>Value[i];

public static A126753Inst Instance=new A126753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126754
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,4L,59L,1631L,101409L,13626123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126754Inst : IEnumerable<long>
{
public static readonly long[] Value=A126754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126754.Bytes);
public long this[int i]=>Value[i];

public static A126754Inst Instance=new A126754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126755
{
public static readonly long[] Value={ 1L,2L,3L,7L,11L,22L,33L,46L,59L,64L,77L,80L,95L,111L,121L,131L,161L,171L,212L,222L,232L,262L,272L,313L,323L,333L,373L,416L,426L,436L,476L,519L,529L,539L,579L,614L,624L,634L,674L,717L,727L,737L,777L,810L,820L,830L,870L,915L,925L,935L,975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126755Inst : IEnumerable<long>
{
public static readonly long[] Value=A126755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126755.Bytes);
public long this[int i]=>Value[i];

public static A126755Inst Instance=new A126755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126756
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,8L,36L,269L,2418L,29216L,458445L,9373692L,249530113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126756Inst : IEnumerable<long>
{
public static readonly long[] Value=A126756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126756.Bytes);
public long this[int i]=>Value[i];

public static A126756Inst Instance=new A126756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126757
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,18L,47L,137L,464L,1793L,8167L,43645L,275480L,2045279L,17772647L,179593823L,2098423758L,28215583324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126757Inst : IEnumerable<long>
{
public static readonly long[] Value=A126757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126757.Bytes);
public long this[int i]=>Value[i];

public static A126757Inst Instance=new A126757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126758
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,11L,39L,139L,603L,2925L,16709L,112054L,888615L,8321364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126758Inst : IEnumerable<long>
{
public static readonly long[] Value=A126758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126758.Bytes);
public long this[int i]=>Value[i];

public static A126758Inst Instance=new A126758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126759
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,2L,4L,2L,2L,3L,5L,2L,6L,4L,3L,2L,7L,2L,8L,3L,4L,5L,9L,2L,10L,6L,2L,4L,11L,3L,12L,2L,5L,7L,13L,2L,14L,8L,6L,3L,15L,4L,16L,5L,3L,9L,17L,2L,18L,10L,7L,6L,19L,2L,20L,4L,8L,11L,21L,3L,22L,12L,4L,2L,23L,5L,24L,7L,9L,13L,25L,2L,26L,14L,10L,8L,27L,6L,28L,3L,2L,15L,29L,4L,30L,16L,11L,5L,31L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126759Inst : IEnumerable<long>
{
public static readonly long[] Value=A126759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126759.Bytes);
public long this[int i]=>Value[i];

public static A126759Inst Instance=new A126759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126808
{
public static readonly long[] Value={ 13L,17L,31L,71L,211L,419L,617L,1013L,1021L,1031L,1051L,1151L,1181L,1193L,1201L,1213L,1217L,1231L,1237L,1279L,1291L,1297L,1301L,1303L,1307L,1321L,1327L,1439L,1451L,1493L,1511L,1531L,1543L,1549L,1571L,1579L,1597L,1657L,1709L,1721L,1733L,1811L,1871L,1877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126808Inst : IEnumerable<long>
{
public static readonly long[] Value=A126808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126808.Bytes);
public long this[int i]=>Value[i];

public static A126808Inst Instance=new A126808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126809
{
public static readonly ulong[] Value={ 3L,19L,119L,1688L,10794L,136121L,1530012L,18660270L,156001209L,1695509436L,11136696006L,102111268282L,1260654956982L,10725187563686L,147895359776637L,1313133218365935L,16250291773636035L,118166387818704586L,1860961545617561679L,15963377896404315146UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126809Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A126809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126809.Bytes);
public ulong this[int i]=>Value[i];

public static A126809Inst Instance=new A126809Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126810
{
public static readonly long[] Value={ 3L,20L,12L,10L,1L,16L,17L,8L,5L,23L,22L,11L,14L,6L,4L,19L,25L,9L,7L,2L,13L,21L,15L,24L,18L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126810Inst : IEnumerable<long>
{
public static readonly long[] Value=A126810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126810.Bytes);
public long this[int i]=>Value[i];

public static A126810Inst Instance=new A126810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126811
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126811Inst : IEnumerable<long>
{
public static readonly long[] Value=A126811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126811.Bytes);
public long this[int i]=>Value[i];

public static A126811Inst Instance=new A126811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126812
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126812Inst : IEnumerable<long>
{
public static readonly long[] Value=A126812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126812.Bytes);
public long this[int i]=>Value[i];

public static A126812Inst Instance=new A126812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126813
{
public static readonly long[] Value={ 1L,0L,4L,0L,6L,0L,0L,0L,5L,0L,4L,0L,6L,0L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,7L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,6L,0L,0L,0L,2L,0L,4L,0L,6L,0L,0L,0L,1L,0L,0L,0L,6L,0L,0L,0L,0L,0L,4L,0L,6L,0L,0L,0L,4L,0L,4L,0L,0L,0L,0L,0L,2L,0L,4L,0L,0L,0L,0L,0L,1L,0L,4L,0L,4L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,4L,0L,6L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126813Inst : IEnumerable<long>
{
public static readonly long[] Value=A126813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126813.Bytes);
public long this[int i]=>Value[i];

public static A126813Inst Instance=new A126813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126814
{
public static readonly long[] Value={ 1L,8L,12L,0L,14L,0L,8L,0L,5L,0L,4L,0L,6L,0L,8L,0L,2L,8L,12L,0L,0L,0L,8L,0L,7L,0L,8L,0L,6L,0L,0L,0L,0L,0L,0L,0L,14L,0L,8L,0L,10L,0L,4L,0L,6L,0L,0L,0L,9L,8L,8L,0L,14L,0L,8L,0L,0L,0L,4L,0L,6L,0L,8L,0L,4L,0L,12L,0L,0L,0L,8L,0L,10L,0L,4L,0L,0L,0L,0L,0L,9L,0L,12L,0L,12L,0L,8L,0L,10L,0L,0L,0L,0L,0L,8L,0L,2L,8L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126814Inst : IEnumerable<long>
{
public static readonly long[] Value=A126814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126814.Bytes);
public long this[int i]=>Value[i];

public static A126814Inst Instance=new A126814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126815
{
public static readonly long[] Value={ 1L,8L,28L,0L,30L,0L,24L,0L,21L,16L,20L,0L,22L,0L,8L,0L,18L,8L,12L,0L,0L,0L,8L,0L,7L,16L,24L,0L,6L,0L,0L,0L,16L,16L,16L,0L,30L,0L,8L,0L,26L,0L,20L,0L,22L,0L,16L,0L,9L,24L,24L,0L,14L,0L,24L,0L,16L,16L,4L,0L,6L,0L,24L,0L,20L,0L,28L,0L,0L,0L,24L,0L,26L,16L,4L,0L,0L,0L,16L,0L,9L,16L,12L,0L,28L,0L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126815Inst : IEnumerable<long>
{
public static readonly long[] Value=A126815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126815.Bytes);
public long this[int i]=>Value[i];

public static A126815Inst Instance=new A126815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126816
{
public static readonly long[] Value={ 1L,40L,60L,0L,30L,32L,24L,0L,21L,48L,20L,0L,54L,0L,8L,0L,50L,8L,44L,0L,32L,32L,8L,0L,39L,48L,24L,0L,38L,0L,32L,0L,48L,16L,16L,0L,62L,32L,40L,0L,58L,0L,52L,0L,54L,0L,16L,0L,41L,24L,56L,0L,46L,0L,24L,0L,16L,48L,36L,0L,6L,0L,56L,0L,20L,0L,60L,0L,32L,0L,24L,0L,26L,48L,36L,0L,32L,0L,48L,0L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126816Inst : IEnumerable<long>
{
public static readonly long[] Value=A126816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126816.Bytes);
public long this[int i]=>Value[i];

public static A126816Inst Instance=new A126816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126817
{
public static readonly long[] Value={ 1L,104L,124L,64L,94L,96L,24L,0L,21L,48L,84L,0L,54L,64L,8L,0L,50L,8L,44L,0L,32L,32L,72L,0L,39L,112L,24L,0L,102L,64L,96L,0L,48L,80L,80L,64L,62L,96L,40L,0L,122L,0L,52L,0L,54L,64L,16L,0L,41L,88L,56L,0L,110L,64L,88L,0L,80L,112L,100L,0L,70L,0L,120L,0L,84L,0L,60L,0L,96L,0L,88L,0L,90L,48L,100L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126817Inst : IEnumerable<long>
{
public static readonly long[] Value=A126817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126817.Bytes);
public long this[int i]=>Value[i];

public static A126817Inst Instance=new A126817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126818
{
public static readonly long[] Value={ 1L,232L,252L,64L,222L,96L,152L,0L,21L,48L,84L,0L,54L,192L,136L,0L,178L,8L,44L,128L,160L,32L,72L,0L,167L,240L,152L,0L,102L,64L,96L,0L,176L,80L,208L,64L,62L,224L,40L,0L,122L,0L,180L,0L,54L,64L,16L,0L,169L,88L,56L,128L,110L,192L,216L,0L,80L,112L,228L,0L,198L,0L,120L,0L,212L,128L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126818Inst : IEnumerable<long>
{
public static readonly long[] Value=A126818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126818.Bytes);
public long this[int i]=>Value[i];

public static A126818Inst Instance=new A126818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126819
{
public static readonly long[] Value={ 1L,488L,252L,64L,222L,96L,152L,0L,21L,304L,84L,256L,310L,448L,136L,0L,434L,8L,44L,384L,416L,32L,328L,0L,423L,240L,408L,0L,102L,320L,352L,0L,176L,336L,464L,320L,318L,480L,296L,0L,378L,256L,180L,256L,54L,320L,272L,0L,425L,88L,312L,384L,366L,448L,216L,0L,336L,112L,228L,0L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126819Inst : IEnumerable<long>
{
public static readonly long[] Value=A126819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126819.Bytes);
public long this[int i]=>Value[i];

public static A126819Inst Instance=new A126819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126820
{
public static readonly long[] Value={ 1L,1000L,252L,576L,734L,96L,664L,512L,21L,816L,84L,768L,822L,448L,648L,0L,946L,520L,556L,896L,416L,32L,328L,0L,423L,752L,408L,512L,102L,832L,352L,0L,688L,848L,976L,832L,318L,992L,296L,0L,890L,256L,692L,256L,54L,320L,784L,0L,425L,88L,824L,384L,878L,448L,216L,0L,848L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126820Inst : IEnumerable<long>
{
public static readonly long[] Value=A126820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126820.Bytes);
public long this[int i]=>Value[i];

public static A126820Inst Instance=new A126820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126821
{
public static readonly long[] Value={ 1L,2024L,252L,576L,734L,96L,1688L,512L,1045L,816L,84L,1792L,1846L,448L,648L,0L,1970L,1544L,1580L,896L,1440L,32L,328L,0L,423L,752L,408L,1536L,1126L,832L,1376L,0L,688L,1872L,2000L,1856L,1342L,992L,296L,1024L,890L,256L,1716L,1280L,1078L,320L,1808L,0L,1449L,88L,824L,384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126821Inst : IEnumerable<long>
{
public static readonly long[] Value=A126821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126821.Bytes);
public long this[int i]=>Value[i];

public static A126821Inst Instance=new A126821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126822
{
public static readonly long[] Value={ 1L,4072L,252L,2624L,734L,2144L,3736L,2560L,1045L,2864L,2132L,1792L,3894L,448L,648L,0L,4018L,3592L,3628L,896L,3488L,2080L,2376L,2048L,2471L,752L,2456L,1536L,1126L,832L,3424L,0L,688L,1872L,2000L,1856L,1342L,3040L,2344L,3072L,2938L,2304L,3764L,3328L,1078L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126822Inst : IEnumerable<long>
{
public static readonly long[] Value=A126822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126822.Bytes);
public long this[int i]=>Value[i];

public static A126822Inst Instance=new A126822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126823
{
public static readonly long[] Value={ 1L,8168L,252L,6720L,4830L,2144L,7832L,2560L,1045L,6960L,2132L,5888L,3894L,448L,4744L,4096L,8114L,7688L,3628L,896L,7584L,6176L,6472L,6144L,2471L,4848L,6552L,5632L,5222L,832L,3424L,0L,4784L,1872L,6096L,1856L,1342L,3040L,6440L,3072L,2938L,6400L,3764L,7424L,1078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126823Inst : IEnumerable<long>
{
public static readonly long[] Value=A126823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126823.Bytes);
public long this[int i]=>Value[i];

public static A126823Inst Instance=new A126823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126856
{
public static readonly long[] Value={ 109L,461L,1061L,50777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126856Inst : IEnumerable<long>
{
public static readonly long[] Value=A126856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126856.Bytes);
public long this[int i]=>Value[i];

public static A126856Inst Instance=new A126856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126857
{
public static readonly long[] Value={ 6L,12L,30L,42L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126857Inst : IEnumerable<long>
{
public static readonly long[] Value=A126857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126857.Bytes);
public long this[int i]=>Value[i];

public static A126857Inst Instance=new A126857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126858
{
public static readonly long[] Value={ 0L,0L,1L,8L,30L,80L,180L,336L,620L,960L,1590L,2200L,3416L,4368L,6440L,7920L,11160L,13056L,18333L,20520L,27860L,31360L,41052L,44528L,59760L,62400L,80990L,87120L,109872L,113680L,147960L,148800L,188976L,196416L,240210L,243040L,311910L,303696L,376580L,385840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126858Inst : IEnumerable<long>
{
public static readonly long[] Value=A126858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126858.Bytes);
public long this[int i]=>Value[i];

public static A126858Inst Instance=new A126858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126859
{
public static readonly long[] Value={ 0L,0L,1L,20L,102L,2288L,3773L,14232L,133616L,119904L,584517L,1927900L,4013432L,2569296L,14394518L,8365192L,14426496L,23381600L,151885575L,58125708L,269849564L,395149888L,195967551L,828880856L,398774464L,544543680L,4586626939L,1018905048L,1396485648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126859Inst : IEnumerable<long>
{
public static readonly long[] Value=A126859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126859.Bytes);
public long this[int i]=>Value[i];

public static A126859Inst Instance=new A126859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126860
{
public static readonly long[] Value={ 1L,1L,12L,3L,1L,3L,1L,1L,3L,1L,2L,3L,3L,1L,3L,1L,1L,1L,4L,1L,3L,3L,1L,3L,1L,1L,6L,1L,1L,3L,1L,1L,1L,1L,2L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,1L,3L,3L,1L,12L,1L,1L,1L,1L,1L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126860Inst : IEnumerable<long>
{
public static readonly long[] Value=A126860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126860.Bytes);
public long this[int i]=>Value[i];

public static A126860Inst Instance=new A126860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126861
{
public static readonly long[] Value={ 0L,0L,1L,80L,1224L,9152L,45276L,170784L,534464L,1438848L,3507102L,7711600L,16053728L,30831552L,57578072L,100382304L,173117952L,280579200L,455656725L,697508496L,1079398256L,1580599552L,2351610612L,3315523424L,4785293568L,6534524160L,9173253878L,12226860576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126861Inst : IEnumerable<long>
{
public static readonly long[] Value=A126861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126861.Bytes);
public long this[int i]=>Value[i];

public static A126861Inst Instance=new A126861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126862
{
public static readonly long[] Value={ 3L,6L,8L,12L,14L,17L,22L,24L,27L,31L,37L,39L,42L,46L,51L,58L,60L,63L,67L,72L,78L,86L,88L,91L,95L,100L,106L,113L,122L,124L,127L,131L,136L,142L,149L,157L,167L,169L,172L,176L,181L,187L,194L,202L,211L,222L,224L,227L,231L,236L,242L,249L,257L,266L,276L,288L,290L,293L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126862Inst : IEnumerable<long>
{
public static readonly long[] Value=A126862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126862.Bytes);
public long this[int i]=>Value[i];

public static A126862Inst Instance=new A126862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126863
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,4L,5L,4L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,4L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,4L,5L,6L,5L,4L,3L,2L,1L,1L,1L,2L,1L,1L,1L,2L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126863Inst : IEnumerable<long>
{
public static readonly long[] Value=A126863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126863.Bytes);
public long this[int i]=>Value[i];

public static A126863Inst Instance=new A126863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126864
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,4L,3L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,3L,4L,1L,6L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,5L,2L,3L,2L,1L,4L,1L,2L,3L,1L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,1L,2L,1L,6L,1L,4L,1L,2L,1L,12L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126864Inst : IEnumerable<long>
{
public static readonly long[] Value=A126864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126864.Bytes);
public long this[int i]=>Value[i];

public static A126864Inst Instance=new A126864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126865
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,2L,2L,1L,4L,2L,2L,2L,2L,6L,8L,1L,2L,4L,2L,2L,4L,2L,2L,2L,4L,6L,8L,6L,2L,8L,2L,1L,4L,2L,24L,4L,2L,6L,8L,2L,2L,12L,2L,2L,16L,2L,2L,2L,4L,4L,8L,6L,2L,8L,8L,6L,4L,2L,2L,8L,2L,6L,8L,1L,12L,4L,2L,2L,4L,24L,2L,4L,2L,6L,16L,18L,12L,24L,2L,2L,16L,2L,2L,12L,4L,6L,8L,2L,2L,16L,8L,2L,4L,2L,24L,2L,2L,12L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126865Inst : IEnumerable<long>
{
public static readonly long[] Value=A126865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126865.Bytes);
public long this[int i]=>Value[i];

public static A126865Inst Instance=new A126865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126866
{
public static readonly BigInteger[] Value={ 1L,14L,181L,2339L,30226L,390599L,5047561L,65227694L,842912461L,10892634299L,140761333426L,1819004700239L,23506299769681L,303762892305614L,3925411300203301L,50726584010337299L,655520180834181586L,8471035766834023319L,BigInteger.Parse("109467944788008121561") };
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
public class A126866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A126866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126866Inst Instance=new A126866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126867
{
public static readonly long[] Value={ 4L,6L,14L,22L,34L,46L,62L,74L,94L,118L,142L,166L,194L,218L,254L,278L,314L,358L,398L,422L,482L,526L,566L,622L,674L,718L,778L,838L,898L,958L,1018L,1082L,1154L,1214L,1294L,1366L,1438L,1514L,1594L,1678L,1762L,1838L,1934L,2018L,2102L,2206L,2302L,2386L,2498L,2594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126867Inst : IEnumerable<long>
{
public static readonly long[] Value=A126867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126867.Bytes);
public long this[int i]=>Value[i];

public static A126867Inst Instance=new A126867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126868
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,3L,6L,1L,6L,5L,1L,3L,8L,7L,0L,1L,13L,9L,1L,15L,0L,11L,1L,9L,0L,13L,0L,7L,17L,15L,1L,1L,0L,17L,0L,27L,6L,19L,0L,25L,9L,21L,1L,11L,0L,23L,46L,33L,0L,25L,0L,39L,30L,27L,0L,49L,0L,29L,58L,15L,50L,31L,0L,1L,0L,33L,1L,51L,0L,35L,1L,9L,27L,37L,0L,19L,0L,39L,78L,65L,0L,41L,82L,63L,0L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126868Inst : IEnumerable<long>
{
public static readonly long[] Value=A126868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126868.Bytes);
public long this[int i]=>Value[i];

public static A126868Inst Instance=new A126868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126869
{
public static readonly long[] Value={ 1L,0L,2L,0L,6L,0L,20L,0L,70L,0L,252L,0L,924L,0L,3432L,0L,12870L,0L,48620L,0L,184756L,0L,705432L,0L,2704156L,0L,10400600L,0L,40116600L,0L,155117520L,0L,601080390L,0L,2333606220L,0L,9075135300L,0L,35345263800L,0L,137846528820L,0L,538257874440L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126869Inst : IEnumerable<long>
{
public static readonly long[] Value=A126869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126869.Bytes);
public long this[int i]=>Value[i];

public static A126869Inst Instance=new A126869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126870
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,6L,3L,6L,9L,10L,9L,12L,7L,7L,8L,16L,15L,18L,17L,8L,21L,22L,20L,20L,12L,16L,17L,28L,10L,30L,12L,9L,33L,7L,28L,36L,17L,16L,33L,40L,9L,42L,43L,19L,37L,46L,39L,41L,42L,21L,24L,52L,45L,25L,32L,24L,57L,58L,23L,60L,34L,24L,28L,15L,29L,66L,65L,29L,27L,70L,57L,72L,39L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126870Inst : IEnumerable<long>
{
public static readonly long[] Value=A126870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126870.Bytes);
public long this[int i]=>Value[i];

public static A126870Inst Instance=new A126870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126871
{
public static readonly long[] Value={ 0L,1L,2L,7L,9L,32L,42L,130L,161L,507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126871Inst : IEnumerable<long>
{
public static readonly long[] Value=A126871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126871.Bytes);
public long this[int i]=>Value[i];

public static A126871Inst Instance=new A126871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126952
{
public static readonly long[] Value={ 1L,1L,5L,21L,93L,421L,1937L,9017L,42349L,200277L,952425L,1519953L,21818841L,104966889L,506372277L,2448641061L,11865563853L,57604036309L,280110716777L,1364092539041L,6651682319233L,32474171399649L,162005212864557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126952Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126952.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126952Inst : IEnumerable<long>
{
public static readonly long[] Value=A126952.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126952.Bytes);
public long this[int i]=>Value[i];

public static A126952Inst Instance=new A126952Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126953
{
public static readonly long[] Value={ 1L,3L,1L,10L,3L,1L,33L,11L,3L,1L,110L,36L,12L,3L,1L,366L,122L,39L,13L,3L,1L,1220L,405L,135L,42L,14L,3L,1L,4065L,1355L,447L,149L,45L,15L,3L,1L,13550L,4512L,1504L,492L,164L,48L,16L,3L,1L,45162L,15054L,5004L,1668L,540L,180L,51L,17L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126953Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126953.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126953Inst : IEnumerable<long>
{
public static readonly long[] Value=A126953.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126953.Bytes);
public long this[int i]=>Value[i];

public static A126953Inst Instance=new A126953Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126954
{
public static readonly long[] Value={ 1L,3L,1L,10L,4L,1L,34L,15L,5L,1L,117L,54L,21L,6L,1L,405L,192L,81L,28L,7L,1L,1407L,678L,301L,116L,36L,8L,1L,4899L,2386L,1095L,453L,160L,45L,9L,1L,17083L,8380L,3934L,1708L,658L,214L,55L,10L,1L,59629L,29397L,14022L,6300L,2580L,927L,279L,66L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126954Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126954.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126954Inst : IEnumerable<long>
{
public static readonly long[] Value=A126954.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126954.Bytes);
public long this[int i]=>Value[i];

public static A126954Inst Instance=new A126954Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126955
{
public static readonly long[] Value={ 1L,5L,65L,89L,119L,215L,455L,755L,779L,965L,1175L,1349L,1409L,1469L,1679L,1745L,1769L,1889L,1955L,2009L,2105L,2435L,2519L,2525L,2585L,2639L,4685L,5045L,5165L,5735L,5915L,5969L,6725L,7415L,7469L,7895L,8045L,9065L,9365L,9449L,9659L,9779L,9959L,10379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126955Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126955.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126955Inst : IEnumerable<long>
{
public static readonly long[] Value=A126955.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126955.Bytes);
public long this[int i]=>Value[i];

public static A126955Inst Instance=new A126955Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126956
{
public static readonly long[] Value={ 5L,17L,77L,89L,119L,185L,257L,287L,395L,665L,755L,797L,929L,1175L,1259L,1337L,1379L,1445L,1469L,1769L,2057L,2105L,3125L,3419L,3437L,3629L,3815L,3989L,4079L,4157L,4175L,4217L,4367L,4445L,4847L,5045L,5375L,6089L,6137L,6167L,6359L,6419L,6485L,6725L,6887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126956Inst : IEnumerable<long>
{
public static readonly long[] Value=A126956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126956.Bytes);
public long this[int i]=>Value[i];

public static A126956Inst Instance=new A126956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126957
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,24L,36L,384L,432L,624L,672L,735L,3276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126957Inst : IEnumerable<long>
{
public static readonly long[] Value=A126957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126957.Bytes);
public long this[int i]=>Value[i];

public static A126957Inst Instance=new A126957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126958
{
public static readonly long[] Value={ 36L,24L,-60L,-216L,-420L,-624L,-756L,-720L,-396L,360L,1716L,3864L,7020L,11424L,17340L,25056L,34884L,47160L,62244L,80520L,102396L,128304L,158700L,194064L,234900L,281736L,335124L,395640L,463884L,540480L,626076L,721344L,826980L,943704L,1072260L,1213416L,1367964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126958Inst : IEnumerable<long>
{
public static readonly long[] Value=A126958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126958.Bytes);
public long this[int i]=>Value[i];

public static A126958Inst Instance=new A126958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126959
{
public static readonly long[] Value={ 1L,3L,12L,58L,352L,2376L,19296L,168912L,1670976L,18000000L,219916800L,2781561600L,39605760000L,584889984000L,9253091635200L,154909552896000L,2834240274432000L,52918877491200000L,1074184895250432000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126959Inst : IEnumerable<long>
{
public static readonly long[] Value=A126959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126959.Bytes);
public long this[int i]=>Value[i];

public static A126959Inst Instance=new A126959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126960
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,37L,41L,73L,79L,83L,101L,103L,107L,139L,149L,151L,167L,191L,227L,233L,251L,269L,311L,337L,443L,457L,479L,499L,503L,521L,541L,601L,613L,647L,673L,761L,811L,829L,863L,877L,883L,887L,907L,919L,941L,983L,997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126960Inst : IEnumerable<long>
{
public static readonly long[] Value=A126960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126960.Bytes);
public long this[int i]=>Value[i];

public static A126960Inst Instance=new A126960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126961
{
public static readonly long[] Value={ 2L,17L,23L,29L,31L,43L,47L,53L,59L,61L,67L,71L,89L,97L,109L,113L,127L,131L,137L,157L,163L,173L,179L,181L,193L,197L,199L,211L,223L,229L,239L,241L,257L,263L,271L,277L,281L,283L,293L,307L,313L,317L,331L,347L,349L,353L,359L,367L,373L,379L,383L,389L,397L,401L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126961Inst : IEnumerable<long>
{
public static readonly long[] Value=A126961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126961.Bytes);
public long this[int i]=>Value[i];

public static A126961Inst Instance=new A126961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126962
{
public static readonly BigInteger[] Value={ 1L,1L,-2L,-12L,24L,420L,-720L,-30240L,40320L,3764880L,-3628800L,-728481600L,479001600L,203545742400L,-87178291200L,-77806624896000L,20922789888000L,39045031657632000L,-6402373705728000L,BigInteger.Parse("-24904933604014464000"),2432902008176640000L,BigInteger.Parse("19678195269815322240000"),BigInteger.Parse("-1124000727777607680000") };
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
public class A126962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126962Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126962.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A126962.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126962Inst Instance=new A126962Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126963
{
public static readonly long[] Value={ 1L,5L,43L,177L,2867L,11531L,92479L,370345L,11857475L,47442055L,379582629L,1518418695L,24295375159L,97182800711L,777467420263L,3109879375897L,199032580597603L,796130905791967L,6369049515119561L,25476202478636219L,407619274119811709L,1630477163761481141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126963Inst : IEnumerable<long>
{
public static readonly long[] Value=A126963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126963.Bytes);
public long this[int i]=>Value[i];

public static A126963Inst Instance=new A126963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126964
{
public static readonly long[] Value={ 0L,10L,44L,102L,184L,290L,420L,574L,752L,954L,1180L,1430L,1704L,2002L,2324L,2670L,3040L,3434L,3852L,4294L,4760L,5250L,5764L,6302L,6864L,7450L,8060L,8694L,9352L,10034L,10740L,11470L,12224L,13002L,13804L,14630L,15480L,16354L,17252L,18174L,19120L,20090L,21084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126964Inst : IEnumerable<long>
{
public static readonly long[] Value=A126964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126964.Bytes);
public long this[int i]=>Value[i];

public static A126964Inst Instance=new A126964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126965
{
public static readonly BigInteger[] Value={ -1L,1L,9L,75L,735L,8505L,114345L,1756755L,30405375L,585810225L,12439852425L,288735522075L,7273385294175L,197646339515625L,5763367260275625L,179518217255251875L,5948862302837829375L,BigInteger.Parse("208977775735174070625"),BigInteger.Parse("7757508341684492015625"),BigInteger.Parse("303429397707601987696875") };
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
public class A126965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126965Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126965.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A126965.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126965Inst Instance=new A126965Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126966
{
public static readonly long[] Value={ 1L,0L,-2L,-8L,-26L,-80L,-244L,-752L,-2362L,-7584L,-24892L,-83376L,-284324L,-984672L,-3455144L,-12259168L,-43908026L,-158531392L,-576352364L,-2107982128L,-7750490636L,-28629222112L,-106190978264L,-395347083808L,-1476813394916L,-5533435084480L,-20790762971864L,-78316232088032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126966Inst : IEnumerable<long>
{
public static readonly long[] Value=A126966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126966.Bytes);
public long this[int i]=>Value[i];

public static A126966Inst Instance=new A126966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126967
{
public static readonly BigInteger[] Value={ 1L,0L,-4L,48L,-624L,9600L,-175680L,3790080L,-95235840L,2752081920L,-90328089600L,3328103116800L,-136191650918400L,6131573025177600L,-301213549769932800L,16030999766605824000UL,BigInteger.Parse("-918678402394841088000"),BigInteger.Parse("56387623092958789632000"),BigInteger.Parse("-3690023220507773140992000") };
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
public class A126967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126967Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A126967.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A126967.Bytes);
public BigInteger this[int i]=>Value[i];

public static A126967Inst Instance=new A126967Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126984
{
public static readonly long[] Value={ 1L,-2L,2L,-4L,2L,-12L,-12L,-72L,-190L,-700L,-2308L,-8120L,-28364L,-100856L,-360792L,-1301904L,-4727358L,-17268636L,-63405012L,-233885784L,-866327748L,-3220976616L,-12016209192L,-44966763504L,-168750724428L,-634935132312L,-2394717424552L,-9051945482032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126984Inst : IEnumerable<long>
{
public static readonly long[] Value=A126984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126984.Bytes);
public long this[int i]=>Value[i];

public static A126984Inst Instance=new A126984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126985
{
public static readonly long[] Value={ 1L,-8L,56L,-400L,2840L,-20208L,143664L,-1021728L,7265240L,-51665200L,367392656L,-2612584928L,18578329456L,-132112749920L,939467783520L,-6680662171200L,47506922377560L,-337827035002800L,2402325467002320L,-17083203745473120L,121480558396908240L,-863861754435010080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126985Inst : IEnumerable<long>
{
public static readonly long[] Value=A126985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126985.Bytes);
public long this[int i]=>Value[i];

public static A126985Inst Instance=new A126985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126986
{
public static readonly long[] Value={ 1L,-4L,12L,-40L,124L,-408L,1272L,-4176L,13020L,-42808L,133096L,-439344L,1358872L,-4514800L,13853040L,-46469280L,140945820L,-479312760L,1430085000L,-4958382960L,14453014920L,-51500944080L,145230007440L,-537922074720L,1446902948184L,-5662012752048L,14228883685392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126986Inst : IEnumerable<long>
{
public static readonly long[] Value=A126986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126986.Bytes);
public long this[int i]=>Value[i];

public static A126986Inst Instance=new A126986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126987
{
public static readonly long[] Value={ 1L,-5L,20L,-85L,350L,-1470L,6090L,-25485L,105830L,-442150L,1838240L,-7673330L,31923220L,-133186760L,554325750L,-2311919325L,9624918150L,-40133290350L,167114005800L,-696706389750L,2901470571300L,-12094930814100L,50375156502900L,-209972720898450L,874600454065500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126987Inst : IEnumerable<long>
{
public static readonly long[] Value=A126987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126987.Bytes);
public long this[int i]=>Value[i];

public static A126987Inst Instance=new A126987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126988
{
public static readonly long[] Value={ 1L,2L,1L,3L,0L,1L,4L,2L,0L,1L,5L,0L,0L,0L,1L,6L,3L,2L,0L,0L,1L,7L,0L,0L,0L,0L,0L,1L,8L,4L,0L,2L,0L,0L,0L,1L,9L,0L,3L,0L,0L,0L,0L,0L,1L,10L,5L,0L,0L,2L,0L,0L,0L,0L,1L,11L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,12L,6L,4L,3L,0L,2L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126988Inst : IEnumerable<long>
{
public static readonly long[] Value=A126988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126988.Bytes);
public long this[int i]=>Value[i];

public static A126988Inst Instance=new A126988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126989
{
public static readonly long[] Value={ 0L,1L,2L,6L,30L,30L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126989Inst : IEnumerable<long>
{
public static readonly long[] Value=A126989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126989.Bytes);
public long this[int i]=>Value[i];

public static A126989Inst Instance=new A126989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126990
{
public static readonly long[] Value={ 3L,3L,7L,7L,13L,13L,19L,23L,23L,31L,31L,37L,43L,47L,47L,53L,61L,61L,67L,73L,73L,83L,89L,89L,97L,103L,103L,109L,113L,113L,131L,131L,139L,139L,151L,151L,157L,167L,167L,173L,181L,181L,193L,193L,199L,199L,211L,223L,229L,233L,233L,241L,241L,251L,257L,263L,271L,271L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126990Inst : IEnumerable<long>
{
public static readonly long[] Value=A126990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126990.Bytes);
public long this[int i]=>Value[i];

public static A126990Inst Instance=new A126990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126991
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,19L,23L,29L,31L,37L,43L,47L,47L,53L,61L,61L,67L,73L,79L,83L,89L,89L,97L,101L,103L,113L,113L,113L,113L,137L,139L,139L,149L,157L,157L,167L,167L,173L,181L,181L,181L,199L,199L,211L,211L,211L,229L,233L,239L,241L,241L,251L,257L,263L,271L,271L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126991Inst : IEnumerable<long>
{
public static readonly long[] Value=A126991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126991.Bytes);
public long this[int i]=>Value[i];

public static A126991Inst Instance=new A126991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126992
{
public static readonly long[] Value={ 5L,7L,7L,13L,17L,19L,23L,23L,31L,37L,41L,47L,47L,53L,53L,61L,67L,73L,79L,83L,83L,89L,89L,97L,109L,113L,113L,113L,127L,127L,139L,139L,151L,151L,163L,163L,173L,173L,181L,181L,193L,199L,199L,199L,211L,211L,223L,233L,241L,241L,241L,251L,257L,263L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126992Inst : IEnumerable<long>
{
public static readonly long[] Value=A126992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126992.Bytes);
public long this[int i]=>Value[i];

public static A126992Inst Instance=new A126992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126993
{
public static readonly long[] Value={ 21L,165L,1287L,19448L,75582L,1144066L,51895935L,141120525L,6107086800L,7898654920L,15338678264L,5178066751L,266783135710L,109712808959985L,22512762077400L,97862516286480L,12802736917880L,18385569737808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126993Inst : IEnumerable<long>
{
public static readonly long[] Value=A126993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126993.Bytes);
public long this[int i]=>Value[i];

public static A126993Inst Instance=new A126993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126994
{
public static readonly long[] Value={ 78L,680L,11628L,245157L,34597290L,206253075L,15905368710L,244662670200L,960566918220L,4568648125690L,462525733568080L,8964377427999630L,6236646703759395L,972963730453314600L,5300174441392685400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126994Inst : IEnumerable<long>
{
public static readonly long[] Value=A126994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126994.Bytes);
public long this[int i]=>Value[i];

public static A126994Inst Instance=new A126994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126995
{
public static readonly long[] Value={ 10L,35L,165L,286L,680L,969L,1771L,3654L,4495L,7770L,10660L,12341L,16215L,23426L,32509L,35990L,47905L,57155L,62196L,79079L,91881L,113564L,147440L,166650L,176851L,198485L,209934L,234136L,333375L,366145L,419220L,437989L,540274L,562475L,632710L,708561L,762355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126995Inst : IEnumerable<long>
{
public static readonly long[] Value=A126995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126995.Bytes);
public long this[int i]=>Value[i];

public static A126995Inst Instance=new A126995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126996
{
public static readonly long[] Value={ 21L,462L,1287L,6188L,11628L,33649L,118755L,169911L,435897L,749398L,962598L,1533939L,2869685L,5006386L,5949147L,9657648L,13019909L,15020334L,22537515L,29034396L,41507642L,64446024L,79208745L,87541245L,106308566L,116828271L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126996Inst : IEnumerable<long>
{
public static readonly long[] Value=A126996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126996.Bytes);
public long this[int i]=>Value[i];

public static A126996Inst Instance=new A126996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126997
{
public static readonly long[] Value={ 330L,1716L,19448L,50388L,245157L,1560780L,2629575L,10295472L,22481940L,32224114L,62891499L,154143080L,341149446L,436270780L,869648208L,1329890705L,1629348612L,2898753715L,4151918628L,6890268572L,12846240784L,17199613200L,19813501785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126997Inst : IEnumerable<long>
{
public static readonly long[] Value=A126997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126997.Bytes);
public long this[int i]=>Value[i];

public static A126997Inst Instance=new A126997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126998
{
public static readonly long[] Value={ 78L,12376L,75582L,1352078L,34597290L,84672315L,854992152L,3159461968L,5752004349L,17417133617L,76223753060L,279871768995L,418094152866L,1285063345176L,2560547383576L,3558497368608L,9036996468045L,16141841823510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126998Inst : IEnumerable<long>
{
public static readonly long[] Value=A126998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126998.Bytes);
public long this[int i]=>Value[i];

public static A126998Inst Instance=new A126998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A126999
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A126999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A126999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A126999Inst : IEnumerable<long>
{
public static readonly long[] Value=A126999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A126999.Bytes);
public long this[int i]=>Value[i];

public static A126999Inst Instance=new A126999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127016
{
public static readonly long[] Value={ 1L,-7L,42L,-259L,1582L,-9702L,59388L,-363867L,2228310L,-13649650L,83599852L,-512063790L,3136339276L,-19210260076L,117662192928L,-720683271819L,4414176556902L,-27036862348986L,165600668448348L,-1014304512179994L,6212613590747172L,-38052263986931796L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127016Inst : IEnumerable<long>
{
public static readonly long[] Value=A127016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127016.Bytes);
public long this[int i]=>Value[i];

public static A127016Inst Instance=new A127016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127017
{
public static readonly long[] Value={ 1L,-6L,30L,-156L,798L,-4116L,21132L,-108792L,559134L,-2876772L,14790660L,-76080648L,391221516L,-2012174664L,10347690072L,-53218984176L,273689323038L,-1407575396484L,7238848057812L,-37228770844776L,191460735261828L,-984660836306904L,5063949044206632L,-26043244926688656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127017Inst : IEnumerable<long>
{
public static readonly long[] Value=A127017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127017.Bytes);
public long this[int i]=>Value[i];

public static A127017Inst Instance=new A127017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127018
{
public static readonly long[] Value={ 4L,6L,4L,6L,4L,9L,21L,6L,4L,6L,4L,9L,9L,6L,4L,6L,4L,10L,39L,6L,4L,14L,9L,9L,15L,6L,4L,6L,4L,9L,15L,10L,21L,6L,4L,10L,21L,6L,4L,6L,4L,9L,9L,6L,4L,14L,21L,10L,21L,6L,4L,14L,9L,10L,9L,6L,4L,6L,4L,9L,21L,9L,15L,6L,4L,9L,9L,6L,4L,6L,4L,14L,9L,10L,9L,6L,4L,10L,25L,6L,4L,14L,21L,9L,15L,6L,4L,9L,9L,14L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127018Inst : IEnumerable<long>
{
public static readonly long[] Value=A127018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127018.Bytes);
public long this[int i]=>Value[i];

public static A127018Inst Instance=new A127018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127019
{
public static readonly long[] Value={ 6L,10L,10L,14L,14L,21L,35L,22L,22L,26L,26L,33L,35L,34L,34L,38L,38L,46L,77L,46L,46L,58L,55L,57L,65L,58L,58L,62L,62L,69L,77L,74L,87L,74L,74L,82L,95L,82L,82L,86L,86L,93L,95L,94L,94L,106L,115L,106L,119L,106L,106L,118L,115L,118L,119L,118L,118L,122L,122L,129L,143L,133L,141L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127019Inst : IEnumerable<long>
{
public static readonly long[] Value=A127019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127019.Bytes);
public long this[int i]=>Value[i];

public static A127019Inst Instance=new A127019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127020
{
public static readonly long[] Value={ 6L,7L,13L,17L,18L,22L,25L,27L,28L,31L,37L,43L,58L,59L,67L,74L,84L,88L,94L,125L,127L,129L,136L,149L,162L,163L,174L,177L,183L,213L,217L,232L,240L,247L,267L,273L,279L,282L,295L,301L,304L,307L,321L,322L,326L,333L,337L,352L,355L,357L,365L,385L,386L,388L,389L,396L,439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127020Inst : IEnumerable<long>
{
public static readonly long[] Value=A127020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127020.Bytes);
public long this[int i]=>Value[i];

public static A127020Inst Instance=new A127020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127021
{
public static readonly long[] Value={ 1L,11L,80L,491L,2777L,15120L,81371L,440947L,2441334L,13976885L,83547881L,525082654L,3483272777L,24413200487L,180517606216L,1404147099951L,11449330342717L,97521479081952L,864955731435983L,7966538662094103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127021Inst : IEnumerable<long>
{
public static readonly long[] Value=A127021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127021.Bytes);
public long this[int i]=>Value[i];

public static A127021Inst Instance=new A127021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127022
{
public static readonly long[] Value={ 25L,37L,43L,58L,67L,74L,163L,232L,522L,719L,1169L,1245L,1467L,1850L,1872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127022Inst : IEnumerable<long>
{
public static readonly long[] Value=A127022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127022.Bytes);
public long this[int i]=>Value[i];

public static A127022Inst Instance=new A127022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127023
{
public static readonly long[] Value={ 37L,58L,67L,163L,232L,719L,1169L,1467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127023Inst : IEnumerable<long>
{
public static readonly long[] Value=A127023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127023.Bytes);
public long this[int i]=>Value[i];

public static A127023Inst Instance=new A127023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127024
{
public static readonly long[] Value={ 58L,67L,163L,232L,1467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127024Inst : IEnumerable<long>
{
public static readonly long[] Value=A127024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127024.Bytes);
public long this[int i]=>Value[i];

public static A127024Inst Instance=new A127024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127025
{
public static readonly long[] Value={ 58L,163L,1467L,478233L,881967L,1053883L,1341615L,1844122L,3498092L,6069493L,6396611L,8707530L,10414308L,13340780L,16039620L,17013933L,17226343L,18577932L,19390220L,21991290L,24529596L,26202225L,26634713L,26651262L,26848308L,27497372L,32149837L,35437319L,35892748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127025Inst : IEnumerable<long>
{
public static readonly long[] Value=A127025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127025.Bytes);
public long this[int i]=>Value[i];

public static A127025Inst Instance=new A127025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127026
{
public static readonly long[] Value={ 2L,30L,33L,42L,56L,96L,100L,103L,140L,148L,164L,171L,172L,182L,187L,188L,205L,211L,223L,226L,239L,241L,243L,253L,268L,300L,318L,328L,359L,361L,364L,379L,387L,394L,408L,410L,421L,423L,425L,426L,436L,455L,465L,467L,490L,492L,509L,529L,536L,546L,579L,583L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127026Inst : IEnumerable<long>
{
public static readonly long[] Value=A127026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127026.Bytes);
public long this[int i]=>Value[i];

public static A127026Inst Instance=new A127026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127027
{
public static readonly long[] Value={ 103L,148L,164L,205L,223L,226L,268L,359L,630L,652L,940L,1005L,1194L,1213L,1332L,1353L,1441L,1481L,1519L,1750L,1823L,1825L,1835L,1930L,1951L,1961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127027Inst : IEnumerable<long>
{
public static readonly long[] Value=A127027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127027.Bytes);
public long this[int i]=>Value[i];

public static A127027Inst Instance=new A127027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127028
{
public static readonly long[] Value={ 148L,268L,652L,1194L,1332L,1519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127028Inst : IEnumerable<long>
{
public static readonly long[] Value=A127028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127028.Bytes);
public long this[int i]=>Value[i];

public static A127028Inst Instance=new A127028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127029
{
public static readonly long[] Value={ 652L,2608L,5868L,14370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127029Inst : IEnumerable<long>
{
public static readonly long[] Value=A127029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127029.Bytes);
public long this[int i]=>Value[i];

public static A127029Inst Instance=new A127029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127030
{
public static readonly long[] Value={ 652L,2608L,22905L,54295L,95041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127030Inst : IEnumerable<long>
{
public static readonly long[] Value=A127030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127030.Bytes);
public long this[int i]=>Value[i];

public static A127030Inst Instance=new A127030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127031
{
public static readonly long[] Value={ 652L,2608L,880111L,2720885L,4089051L,4619054L,5046630L,5409046L,5433402L,5603556L,5645558L,7278138L,7466589L,10037029L,10730786L,10823358L,11540978L,11860073L,12898258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127031Inst : IEnumerable<long>
{
public static readonly long[] Value=A127031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127031.Bytes);
public long this[int i]=>Value[i];

public static A127031Inst Instance=new A127031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127048
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,37L,41L,53L,83L,127L,131L,137L,139L,149L,151L,389L,397L,401L,409L,419L,421L,431L,433L,439L,443L,733L,739L,743L,751L,757L,761L,769L,773L,787L,797L,809L,811L,853L,857L,859L,863L,877L,881L,883L,887L,929L,967L,1091L,1093L,1097L,1103L,1109L,1151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127048Inst : IEnumerable<long>
{
public static readonly long[] Value=A127048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127048.Bytes);
public long this[int i]=>Value[i];

public static A127048Inst Instance=new A127048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127049
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,19L,41L,43L,47L,97L,127L,191L,193L,197L,199L,211L,223L,227L,229L,739L,743L,751L,757L,761L,769L,773L,787L,797L,809L,811L,991L,997L,1009L,1013L,1187L,1193L,1201L,3167L,3169L,3181L,3187L,3191L,3203L,3209L,3217L,3221L,3229L,3613L,3617L,3623L,3631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127049Inst : IEnumerable<long>
{
public static readonly long[] Value=A127049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127049.Bytes);
public long this[int i]=>Value[i];

public static A127049Inst Instance=new A127049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127050
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,1L,1L,0L,1L,3L,0L,1L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127050Inst : IEnumerable<long>
{
public static readonly long[] Value=A127050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127050.Bytes);
public long this[int i]=>Value[i];

public static A127050Inst Instance=new A127050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127051
{
public static readonly long[] Value={ 2L,3L,5L,11L,13L,17L,29L,31L,37L,41L,83L,131L,251L,257L,263L,269L,271L,293L,419L,421L,479L,1163L,1171L,1181L,2411L,2417L,2423L,2437L,2441L,2447L,2459L,2467L,2473L,2477L,3137L,3163L,3167L,3169L,3533L,3539L,3541L,3547L,3557L,3559L,3571L,3581L,3583L,3593L,3607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127051Inst : IEnumerable<long>
{
public static readonly long[] Value=A127051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127051.Bytes);
public long this[int i]=>Value[i];

public static A127051Inst Instance=new A127051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127052
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,29L,31L,37L,41L,53L,67L,71L,73L,97L,101L,127L,131L,197L,199L,211L,251L,367L,373L,379L,773L,787L,797L,809L,811L,1373L,1433L,1439L,2027L,2707L,2711L,2713L,2719L,2729L,2731L,2741L,2749L,2753L,3181L,3187L,3191L,3203L,3209L,3217L,3221L,3229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127052Inst : IEnumerable<long>
{
public static readonly long[] Value=A127052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127052.Bytes);
public long this[int i]=>Value[i];

public static A127052Inst Instance=new A127052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127053
{
public static readonly long[] Value={ 1L,-9L,72L,-585L,4734L,-38358L,310662L,-2516481L,20383110L,-165104478L,1337341896L,-10832484474L,87743071332L,-710719065000L,5756823757890L,-46630274845905L,377705217526470L,-3059412293786310L,24781239462988800L,-200728040080084110L,1625897123058144420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127053Inst : IEnumerable<long>
{
public static readonly long[] Value=A127053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127053.Bytes);
public long this[int i]=>Value[i];

public static A127053Inst Instance=new A127053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127054
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,10L,9L,4L,1L,1L,34L,33L,15L,5L,1L,1L,154L,153L,65L,23L,6L,1L,1L,874L,873L,339L,119L,32L,7L,1L,1L,5914L,5913L,2103L,719L,186L,42L,8L,1L,1L,46234L,46233L,15171L,5039L,1230L,267L,54L,9L,1L,1L,409114L,409113L,124755L,40319L,9258L,1891L,380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127054Inst : IEnumerable<long>
{
public static readonly long[] Value=A127054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127054.Bytes);
public long this[int i]=>Value[i];

public static A127054Inst Instance=new A127054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127055
{
public static readonly long[] Value={ 1L,2L,4L,9L,25L,89L,403L,2246L,14887L,114239L,994909L,9687123L,104223700L,1227484193L,15703071262L,216798771109L,3212441188268L,50845473960657L,856063393693256L,15276025334127835L,287977916632275512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A127055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127055Inst : IEnumerable<long>
{
public static readonly long[] Value=A127055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A127055.Bytes);
public long this[int i]=>Value[i];

public static A127055Inst Instance=new A127055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A127056
{
public static readonly BigInteger[] Value={ 1L,2L,9L,65L,719L,9258L,133147L,2477468L,48452299L,1000726573L,21842234124L,581937143077L,15852410442671L,445324580169954L,12948991063890911L,390296042740795497L,13861395944764722457UL,BigInteger.Parse("498320813544545374474") };
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
public class A127056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A127056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A127056Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A127056.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A127056.Bytes);
public BigInteger this[int i]=>Value[i];

public static A127056Inst Instance=new A127056Inst();

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