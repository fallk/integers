using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198505
{
public static readonly long[] Value={ 2L,4L,5L,0L,1L,2L,4L,0L,4L,2L,4L,6L,2L,6L,1L,5L,0L,1L,4L,0L,8L,2L,4L,5L,3L,0L,6L,8L,3L,6L,8L,1L,1L,1L,3L,4L,4L,4L,2L,8L,1L,5L,6L,5L,1L,3L,8L,6L,8L,0L,1L,2L,4L,2L,1L,1L,1L,7L,9L,6L,5L,5L,0L,9L,7L,9L,7L,6L,9L,6L,1L,0L,7L,0L,8L,2L,5L,0L,3L,5L,0L,0L,0L,3L,5L,8L,1L,9L,7L,3L,1L,8L,4L,6L,6L,4L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198505Inst : IEnumerable<long>
{
public static readonly long[] Value=A198505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198505.Bytes);
public long this[int i]=>Value[i];

public static A198505Inst Instance=new A198505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198506
{
public static readonly long[] Value={ 4L,7L,2L,4L,1L,2L,8L,9L,8L,9L,4L,8L,7L,9L,8L,3L,1L,8L,6L,3L,1L,2L,2L,3L,3L,0L,1L,8L,3L,4L,1L,4L,4L,5L,4L,7L,3L,0L,1L,4L,3L,6L,8L,6L,6L,2L,7L,4L,6L,8L,4L,8L,7L,8L,5L,3L,9L,2L,6L,5L,7L,8L,9L,5L,7L,0L,4L,4L,2L,7L,4L,8L,3L,7L,2L,8L,1L,4L,3L,9L,9L,8L,9L,2L,7L,6L,0L,9L,8L,2L,0L,8L,8L,8L,0L,1L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198506Inst : IEnumerable<long>
{
public static readonly long[] Value=A198506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198506.Bytes);
public long this[int i]=>Value[i];

public static A198506Inst Instance=new A198506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198507
{
public static readonly long[] Value={ 6L,7L,5L,6L,3L,6L,8L,7L,1L,4L,5L,7L,3L,4L,1L,3L,7L,5L,7L,8L,9L,6L,6L,0L,2L,1L,4L,1L,1L,9L,9L,9L,6L,1L,1L,7L,2L,9L,3L,5L,9L,9L,1L,6L,9L,5L,3L,8L,1L,6L,5L,8L,9L,0L,3L,9L,9L,9L,5L,4L,4L,6L,6L,0L,4L,1L,9L,9L,7L,8L,3L,5L,3L,8L,6L,5L,0L,5L,0L,7L,4L,6L,7L,2L,6L,3L,8L,2L,7L,1L,8L,9L,6L,6L,7L,5L,3L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198507Inst : IEnumerable<long>
{
public static readonly long[] Value=A198507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198507.Bytes);
public long this[int i]=>Value[i];

public static A198507Inst Instance=new A198507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198508
{
public static readonly BigInteger[] Value={ 4L,59L,1626L,52065L,1720080L,57202471L,1905005414L,63461666189L,2114248706396L,70438021997715L,2346711308830450L,78183030527210041L,2604746159812022824L,BigInteger.Parse("86779736758694997119"),BigInteger.Parse("2891154190334815424766"),BigInteger.Parse("96321709194421413316965") };
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
public class A198508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198508.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198508Inst Instance=new A198508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198509
{
public static readonly BigInteger[] Value={ 59L,4666L,308854L,23016128L,1768050096L,137433138206L,10767346425686L,846703466364788L,66715358024129644L,5262276771966640650L,BigInteger.Parse("415296502306889789762"),BigInteger.Parse("32784348340670740616160"),BigInteger.Parse("2588447317141729017555864") };
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
public class A198509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198509Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198509.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198509.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198509Inst Instance=new A198509Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198510
{
public static readonly BigInteger[] Value={ 1626L,308854L,59007820L,13127875861L,3023133941944L,714429326523241L,171400320611391344L,BigInteger.Parse("41515521989152410680"),BigInteger.Parse("10116919781533608842706"),BigInteger.Parse("2474972835936834280715447") };
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
public class A198510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198510.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198510Inst Instance=new A198510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198511
{
public static readonly long[] Value={ 4L,59L,59L,1626L,4666L,1626L,52065L,308854L,308854L,52065L,1720080L,23016128L,59007820L,23016128L,1720080L,57202471L,1768050096L,13127875861L,13127875861L,1768050096L,57202471L,1905005414L,137433138206L,3023133941944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198511Inst : IEnumerable<long>
{
public static readonly long[] Value=A198511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198511.Bytes);
public long this[int i]=>Value[i];

public static A198511Inst Instance=new A198511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198512
{
public static readonly long[] Value={ 1L,2L,4L,1L,5L,7L,3L,8L,4L,10L,2L,6L,13L,3L,14L,7L,17L,9L,5L,19L,20L,6L,22L,1L,12L,13L,25L,8L,28L,29L,16L,3L,32L,11L,18L,4L,34L,19L,12L,35L,2L,21L,38L,3L,40L,6L,15L,24L,43L,17L,47L,27L,5L,18L,28L,9L,1L,20L,31L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198512Inst : IEnumerable<long>
{
public static readonly long[] Value=A198512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198512.Bytes);
public long this[int i]=>Value[i];

public static A198512Inst Instance=new A198512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198513
{
public static readonly BigInteger[] Value={ 1L,1L,4L,28L,320L,5556L,129600L,3756936L,132872192L,5679982288L,286769980416L,16732506817280L,1115928688967680L,84383735744758464L,7163164003950936064L,BigInteger.Parse("676619301019539271040"),BigInteger.Parse("70674282825174467215360"),BigInteger.Parse("8117559039240651749888256") };
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
public class A198513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198513Inst Instance=new A198513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198514
{
public static readonly long[] Value={ 1L,3L,6L,9L,11L,22L,22L,23L,29L,29L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198514Inst : IEnumerable<long>
{
public static readonly long[] Value=A198514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198514.Bytes);
public long this[int i]=>Value[i];

public static A198514Inst Instance=new A198514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198515
{
public static readonly long[] Value={ 1L,3L,11L,16L,22L,31L,30L,35L,39L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198515Inst : IEnumerable<long>
{
public static readonly long[] Value=A198515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198515.Bytes);
public long this[int i]=>Value[i];

public static A198515Inst Instance=new A198515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198516
{
public static readonly long[] Value={ 1L,2L,3L,6L,6L,8L,9L,10L,14L,17L,17L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198516Inst : IEnumerable<long>
{
public static readonly long[] Value=A198516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198516.Bytes);
public long this[int i]=>Value[i];

public static A198516Inst Instance=new A198516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198517
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198517Inst : IEnumerable<long>
{
public static readonly long[] Value=A198517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198517.Bytes);
public long this[int i]=>Value[i];

public static A198517Inst Instance=new A198517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198518
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,9L,16L,29L,54L,102L,194L,375L,730L,1434L,2837L,5650L,11311L,22767L,46023L,93422L,190322L,389037L,797613L,1639878L,3380099L,6983484L,14459570L,29999618L,62357426L,129843590L,270807835L,565674584L,1183301266L,2478624060L,5198504694L,10916110768L,22948299899L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198518Inst : IEnumerable<long>
{
public static readonly long[] Value=A198518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198518.Bytes);
public long this[int i]=>Value[i];

public static A198518Inst Instance=new A198518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198519
{
public static readonly long[] Value={ 3L,5L,11L,19L,7L,37L,17L,61L,23L,101L,13L,137L,29L,179L,31L,239L,41L,311L,67L,419L,71L,557L,73L,701L,47L,821L,43L,911L,59L,1013L,79L,1151L,53L,1283L,97L,1433L,83L,1613L,127L,1823L,89L,2039L,109L,2237L,113L,2459L,139L,2711L,103L,2953L,107L,3163L,163L,3433L,131L,3727L,149L,4007L,181L,4337L,173L,4691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198519Inst : IEnumerable<long>
{
public static readonly long[] Value=A198519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198519.Bytes);
public long this[int i]=>Value[i];

public static A198519Inst Instance=new A198519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198520
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,22L,55L,141L,370L,986L,2662L,7264L,20006L,55534L,155219L,436456L,1233822L,3504482L,9996417L,28624038L,82248498L,237082689L,685375920L,1986604360L,5772399530L,16810591254L,49059068617L,143450142998L,420213814655L,1233034693847L,3623838769503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198520Inst : IEnumerable<long>
{
public static readonly long[] Value=A198520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198520.Bytes);
public long this[int i]=>Value[i];

public static A198520Inst Instance=new A198520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198521
{
public static readonly BigInteger[] Value={ 1L,15L,16714L,1084539825L,1814002928583853L,BigInteger.Parse("72341858272434900016248") };
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
public class A198521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198521Inst Instance=new A198521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198522
{
public static readonly BigInteger[] Value={ 2L,15L,193L,3660L,81844L,1948672L,47436498L,1163606279L,28617909415L,704465305625L,17346617064022L,427184684002131L,10520398796919219L,259092051772297458L,6380839372392481249L,BigInteger.Parse("157145577058895542027") };
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
public class A198522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198522Inst Instance=new A198522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198523
{
public static readonly BigInteger[] Value={ 5L,193L,16714L,1877316L,222590953L,26670041125L,3201911378187L,384557171168810L,46189600128813487L,5547962760669962158L,BigInteger.Parse("666383179391895903794"),BigInteger.Parse("80041410904141273707361"),BigInteger.Parse("9614030302463648373863365") };
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
public class A198523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198523Inst Instance=new A198523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198524
{
public static readonly BigInteger[] Value={ 15L,3660L,1877316L,1084539825L,634586561196L,371815743708461L,217885196778717007L,BigInteger.Parse("127683385189755792564"),BigInteger.Parse("74824145653256981522691"),BigInteger.Parse("43847942678019724723096730"),BigInteger.Parse("25695476991145191912238756667") };
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
public class A198524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198524Inst Instance=new A198524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198525
{
public static readonly BigInteger[] Value={ 52L,81844L,222590953L,634586561196L,1814002928583853L,5186266567454077293L,BigInteger.Parse("14827770532074166305565"),BigInteger.Parse("42393290191915767856385826"),BigInteger.Parse("121204405622972228787863169567"),BigInteger.Parse("346529082914494875185400399625818") };
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
public class A198525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198525Inst Instance=new A198525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198526
{
public static readonly BigInteger[] Value={ 202L,1948672L,26670041125L,371815743708461L,5186266567454077293L,BigInteger.Parse("72341858272434900016248"),BigInteger.Parse("1009078065869144136137180812"),BigInteger.Parse("14075371934477934686865356966591"),BigInteger.Parse("196333764385468923490801365319931630") };
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
public class A198526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198526Inst Instance=new A198526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198527
{
public static readonly BigInteger[] Value={ 855L,47436498L,3201911378187L,217885196778717007L,BigInteger.Parse("14827770532074166305565"),BigInteger.Parse("1009078065869144136137180812") };
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
public class A198527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198527Inst Instance=new A198527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198528
{
public static readonly long[] Value={ 1L,2L,2L,5L,15L,5L,15L,193L,193L,15L,52L,3660L,16714L,3660L,52L,202L,81844L,1877316L,1877316L,81844L,202L,855L,1948672L,222590953L,1084539825L,222590953L,1948672L,855L,3845L,47436498L,26670041125L,634586561196L,634586561196L,26670041125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198528Inst : IEnumerable<long>
{
public static readonly long[] Value=A198528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198528.Bytes);
public long this[int i]=>Value[i];

public static A198528Inst Instance=new A198528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198529
{
public static readonly BigInteger[] Value={ 12L,206L,3838L,74582L,1481214L,29737425L,600187403L,12144602583L,246046084954L,4987787543526L,101140166737445L,2051157938501522L,41600949234763960L,843764349062814286L,17113771581568185569UL,BigInteger.Parse("347115075675201580800") };
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
public class A198529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198529Inst Instance=new A198529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198530
{
public static readonly BigInteger[] Value={ 76L,3838L,213328L,12510524L,757941274L,46796529288L,2920541321626L,183371225099361L,11551938856624945L,729096061168837827L,BigInteger.Parse("46063831233179842268"),BigInteger.Parse("2911931787180884205541"),BigInteger.Parse("184135675347690092435300") };
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
public class A198530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198530Inst Instance=new A198530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198531
{
public static readonly BigInteger[] Value={ 492L,74582L,12510524L,2223874372L,411119156729L,77956630302044L,15021391650662681L,2923455266600557870L,BigInteger.Parse("572454626428774679082"),BigInteger.Parse("112514115501137650870546"),BigInteger.Parse("22164495447174669745358050") };
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
public class A198531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198531Inst Instance=new A198531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198532
{
public static readonly long[] Value={ 2L,12L,12L,76L,206L,76L,492L,3838L,3838L,492L,3212L,74582L,213328L,74582L,3212L,21036L,1481214L,12510524L,12510524L,1481214L,21036L,137932L,29737425L,757941274L,2223874372L,757941274L,29737425L,137932L,904812L,600187403L,46796529288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198532Inst : IEnumerable<long>
{
public static readonly long[] Value=A198532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198532.Bytes);
public long this[int i]=>Value[i];

public static A198532Inst Instance=new A198532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198533
{
public static readonly BigInteger[] Value={ 17L,7376L,5724014L,4685798318L,3879729611186L,3222491533589620L,2679021244608145508L,BigInteger.Parse("2227788819914832219768"),BigInteger.Parse("1852697804471510467351558"),BigInteger.Parse("1540794008599547700761105406"),BigInteger.Parse("1281407594160466806617993848394") };
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
public class A198533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198533Inst Instance=new A198533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198534
{
public static readonly long[] Value={ 2L,17L,17L,377L,7376L,377L,11473L,5724014L,5724014L,11473L,375273L,4685798318L,116594439780L,4685798318L,375273L,12456897L,3879729611186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198534Inst : IEnumerable<long>
{
public static readonly long[] Value=A198534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198534.Bytes);
public long this[int i]=>Value[i];

public static A198534Inst Instance=new A198534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198535
{
public static readonly BigInteger[] Value={ 5L,404L,67442L,11739910L,2048681430L,357559607382L,62405998006614L,10891920070833494L,1901001993638057302L,BigInteger.Parse("331788019307198829910"),BigInteger.Parse("57908034887329483937110"),BigInteger.Parse("10106876407223511717074262") };
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
public class A198535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198535Inst Instance=new A198535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198536
{
public static readonly BigInteger[] Value={ 404L,7937268L,163506788110L,3368739754955320L,BigInteger.Parse("69406373651979823710"),BigInteger.Parse("1429984226143212404754264"),BigInteger.Parse("29462062047551694076888833310"),BigInteger.Parse("607008863611669902737169765762040") };
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
public class A198536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198536Inst Instance=new A198536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198537
{
public static readonly BigInteger[] Value={ 67442L,163506788110L,397739142470871040L,BigInteger.Parse("967523967174230258261646"),BigInteger.Parse("2353559236762243709633958950262") };
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
public class A198537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198537Inst Instance=new A198537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198538
{
public static readonly BigInteger[] Value={ 5L,404L,404L,67442L,7937268L,67442L,11739910L,163506788110L,163506788110L,11739910L,2048681430L,3368739754955320L,397739142470871040L,3368739754955320L,2048681430L,357559607382L,BigInteger.Parse("69406373651979823710") };
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
public class A198538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198538Inst Instance=new A198538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198539
{
public static readonly long[] Value={ 2L,5L,2L,6L,5L,1L,2L,1L,7L,3L,6L,3L,0L,6L,7L,9L,6L,9L,8L,4L,9L,9L,4L,7L,8L,9L,1L,4L,6L,7L,0L,0L,1L,5L,8L,8L,9L,4L,0L,1L,1L,1L,8L,9L,2L,5L,4L,4L,2L,2L,4L,9L,7L,2L,1L,6L,2L,5L,7L,7L,4L,4L,6L,8L,3L,0L,5L,9L,7L,5L,5L,7L,0L,4L,8L,0L,1L,9L,1L,4L,6L,5L,2L,5L,6L,0L,8L,5L,7L,8L,4L,5L,2L,1L,2L,5L,6L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198539Inst : IEnumerable<long>
{
public static readonly long[] Value=A198539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198539.Bytes);
public long this[int i]=>Value[i];

public static A198539Inst Instance=new A198539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198540
{
public static readonly long[] Value={ 2L,4L,2L,6L,6L,1L,0L,9L,0L,1L,4L,0L,2L,2L,1L,3L,1L,2L,6L,3L,0L,2L,6L,4L,8L,3L,4L,9L,7L,4L,7L,3L,8L,4L,2L,1L,3L,1L,7L,8L,2L,5L,8L,1L,5L,0L,5L,0L,8L,6L,2L,5L,8L,9L,0L,5L,7L,5L,0L,7L,5L,2L,3L,6L,5L,1L,2L,7L,3L,8L,7L,3L,9L,0L,2L,9L,0L,7L,0L,3L,7L,9L,5L,4L,9L,6L,6L,9L,4L,5L,3L,7L,2L,1L,9L,3L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198540Inst : IEnumerable<long>
{
public static readonly long[] Value=A198540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198540.Bytes);
public long this[int i]=>Value[i];

public static A198540Inst Instance=new A198540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198541
{
public static readonly long[] Value={ 5L,1L,0L,7L,2L,7L,5L,7L,3L,3L,8L,5L,5L,1L,7L,3L,1L,2L,0L,7L,9L,4L,0L,8L,2L,9L,0L,2L,7L,2L,0L,5L,8L,5L,4L,4L,6L,0L,7L,9L,0L,7L,3L,1L,7L,7L,8L,9L,3L,9L,8L,9L,1L,1L,9L,3L,5L,6L,3L,5L,4L,7L,0L,3L,7L,3L,3L,4L,5L,5L,7L,6L,3L,8L,0L,4L,8L,5L,6L,5L,0L,9L,7L,9L,7L,1L,3L,9L,6L,4L,3L,5L,9L,8L,9L,0L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198541Inst : IEnumerable<long>
{
public static readonly long[] Value=A198541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198541.Bytes);
public long this[int i]=>Value[i];

public static A198541Inst Instance=new A198541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198542
{
public static readonly long[] Value={ 2L,5L,5L,4L,1L,8L,8L,5L,9L,9L,3L,7L,6L,0L,8L,1L,0L,1L,0L,0L,7L,6L,2L,2L,8L,1L,0L,9L,4L,9L,1L,6L,4L,2L,4L,3L,4L,9L,4L,9L,9L,6L,1L,1L,9L,0L,9L,1L,4L,9L,8L,4L,8L,7L,1L,4L,1L,5L,3L,5L,8L,0L,4L,3L,3L,0L,5L,9L,4L,3L,7L,1L,7L,6L,8L,9L,0L,9L,8L,1L,9L,3L,1L,6L,6L,8L,2L,1L,6L,8L,7L,2L,5L,7L,9L,8L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198542Inst : IEnumerable<long>
{
public static readonly long[] Value=A198542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198542.Bytes);
public long this[int i]=>Value[i];

public static A198542Inst Instance=new A198542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198543
{
public static readonly long[] Value={ 2L,4L,0L,3L,9L,6L,0L,8L,0L,1L,4L,4L,3L,6L,5L,3L,9L,5L,9L,1L,3L,2L,3L,7L,1L,7L,6L,6L,1L,7L,0L,7L,7L,6L,9L,9L,7L,1L,7L,6L,5L,5L,9L,0L,7L,4L,4L,3L,4L,4L,0L,7L,7L,2L,0L,4L,5L,0L,5L,7L,3L,9L,4L,9L,4L,8L,4L,9L,9L,5L,4L,7L,4L,4L,1L,7L,0L,5L,1L,4L,0L,3L,0L,0L,5L,6L,3L,4L,8L,2L,9L,2L,2L,9L,5L,0L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198543Inst : IEnumerable<long>
{
public static readonly long[] Value=A198543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198543.Bytes);
public long this[int i]=>Value[i];

public static A198543Inst Instance=new A198543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198544
{
public static readonly long[] Value={ 7L,7L,4L,2L,3L,8L,8L,9L,1L,7L,5L,6L,3L,9L,1L,3L,2L,0L,4L,2L,7L,4L,0L,3L,6L,1L,9L,7L,3L,8L,5L,0L,9L,3L,9L,9L,3L,2L,0L,8L,8L,6L,1L,1L,0L,9L,8L,1L,0L,8L,1L,4L,8L,9L,0L,6L,8L,0L,1L,2L,5L,5L,7L,6L,9L,8L,7L,1L,4L,3L,7L,7L,8L,1L,0L,5L,7L,8L,5L,6L,8L,6L,1L,0L,1L,0L,1L,1L,6L,4L,2L,2L,6L,5L,1L,8L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198544Inst : IEnumerable<long>
{
public static readonly long[] Value=A198544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198544.Bytes);
public long this[int i]=>Value[i];

public static A198544Inst Instance=new A198544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198545
{
public static readonly long[] Value={ 2L,5L,8L,3L,1L,2L,9L,1L,2L,3L,7L,7L,5L,2L,3L,9L,2L,6L,0L,3L,2L,7L,3L,4L,0L,7L,3L,9L,5L,1L,9L,8L,2L,5L,3L,0L,6L,5L,4L,9L,1L,5L,5L,2L,1L,6L,2L,4L,8L,6L,5L,0L,3L,6L,6L,7L,8L,8L,4L,2L,9L,8L,5L,8L,1L,7L,9L,4L,8L,9L,6L,1L,0L,4L,0L,1L,8L,2L,8L,7L,7L,0L,7L,5L,1L,6L,4L,6L,5L,0L,8L,1L,3L,3L,3L,0L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198545Inst : IEnumerable<long>
{
public static readonly long[] Value=A198545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198545.Bytes);
public long this[int i]=>Value[i];

public static A198545Inst Instance=new A198545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198546
{
public static readonly long[] Value={ 9L,3L,0L,8L,5L,6L,7L,5L,6L,0L,3L,9L,4L,5L,5L,9L,5L,5L,2L,7L,5L,4L,0L,5L,8L,2L,0L,7L,0L,0L,9L,8L,2L,8L,4L,5L,2L,2L,5L,9L,9L,7L,1L,0L,8L,2L,9L,6L,6L,4L,3L,8L,1L,8L,4L,2L,4L,9L,7L,2L,4L,5L,5L,8L,4L,4L,0L,1L,6L,0L,3L,9L,2L,0L,4L,8L,7L,8L,0L,8L,1L,1L,2L,7L,8L,1L,4L,6L,5L,0L,0L,1L,7L,9L,3L,4L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198546Inst : IEnumerable<long>
{
public static readonly long[] Value=A198546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198546.Bytes);
public long this[int i]=>Value[i];

public static A198546Inst Instance=new A198546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198547
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,7L,6L,8L,9L,5L,9L,6L,1L,2L,7L,1L,7L,3L,0L,4L,4L,1L,8L,9L,1L,1L,5L,1L,2L,6L,5L,6L,7L,1L,8L,6L,8L,6L,7L,1L,2L,7L,1L,7L,8L,6L,2L,1L,0L,4L,6L,3L,3L,2L,4L,6L,2L,1L,8L,6L,5L,9L,0L,3L,4L,3L,3L,6L,9L,4L,8L,7L,3L,8L,0L,3L,2L,5L,4L,8L,4L,3L,7L,5L,0L,7L,6L,0L,9L,2L,1L,3L,6L,9L,6L,0L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198547Inst : IEnumerable<long>
{
public static readonly long[] Value=A198547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198547.Bytes);
public long this[int i]=>Value[i];

public static A198547Inst Instance=new A198547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198548
{
public static readonly long[] Value={ 1L,4L,9L,8L,4L,2L,8L,5L,7L,0L,1L,4L,1L,0L,2L,6L,2L,8L,9L,1L,0L,5L,6L,5L,2L,1L,0L,1L,2L,4L,4L,0L,1L,9L,8L,3L,8L,5L,1L,8L,3L,8L,5L,4L,4L,1L,5L,8L,9L,3L,8L,6L,7L,8L,9L,8L,1L,8L,3L,7L,3L,4L,5L,2L,6L,9L,4L,7L,2L,8L,3L,1L,2L,2L,0L,3L,2L,7L,0L,7L,8L,5L,4L,9L,5L,7L,4L,3L,9L,6L,4L,7L,3L,4L,0L,2L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198548Inst : IEnumerable<long>
{
public static readonly long[] Value=A198548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198548.Bytes);
public long this[int i]=>Value[i];

public static A198548Inst Instance=new A198548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198549
{
public static readonly long[] Value={ 1L,6L,8L,1L,8L,4L,5L,2L,4L,4L,9L,4L,5L,0L,1L,2L,3L,1L,0L,9L,3L,2L,6L,2L,8L,6L,2L,0L,2L,1L,9L,4L,1L,9L,9L,4L,2L,3L,5L,6L,4L,0L,1L,7L,1L,5L,4L,1L,8L,8L,1L,7L,9L,6L,6L,6L,2L,1L,5L,7L,0L,1L,0L,1L,8L,4L,7L,2L,9L,6L,0L,4L,2L,7L,7L,1L,3L,7L,4L,0L,1L,8L,6L,7L,3L,8L,1L,8L,0L,6L,6L,2L,7L,3L,1L,3L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198549Inst : IEnumerable<long>
{
public static readonly long[] Value=A198549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198549.Bytes);
public long this[int i]=>Value[i];

public static A198549Inst Instance=new A198549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198550
{
public static readonly long[] Value={ 6L,4L,4L,0L,9L,2L,5L,3L,0L,1L,9L,3L,0L,7L,2L,5L,5L,8L,9L,9L,1L,2L,8L,9L,2L,1L,5L,2L,5L,1L,3L,0L,0L,8L,3L,6L,9L,5L,1L,1L,4L,0L,8L,1L,8L,5L,6L,8L,3L,5L,4L,0L,8L,9L,2L,3L,1L,0L,7L,0L,2L,1L,6L,4L,8L,9L,3L,8L,1L,4L,9L,6L,2L,6L,8L,7L,7L,2L,8L,8L,7L,1L,2L,1L,5L,7L,8L,7L,2L,4L,5L,7L,7L,4L,4L,6L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198550Inst : IEnumerable<long>
{
public static readonly long[] Value=A198550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198550.Bytes);
public long this[int i]=>Value[i];

public static A198550Inst Instance=new A198550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198551
{
public static readonly long[] Value={ 9L,1L,1L,4L,5L,3L,8L,1L,4L,9L,9L,7L,9L,0L,6L,8L,9L,3L,9L,3L,3L,7L,9L,2L,8L,3L,5L,1L,7L,0L,5L,1L,3L,2L,8L,0L,9L,3L,2L,4L,4L,2L,4L,1L,8L,4L,3L,8L,9L,3L,7L,4L,0L,2L,2L,0L,7L,2L,7L,3L,0L,6L,6L,9L,0L,4L,1L,5L,0L,7L,8L,6L,6L,7L,0L,1L,4L,7L,3L,6L,6L,8L,6L,8L,3L,0L,0L,1L,7L,1L,1L,5L,8L,7L,9L,5L,8L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198551Inst : IEnumerable<long>
{
public static readonly long[] Value=A198551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198551.Bytes);
public long this[int i]=>Value[i];

public static A198551Inst Instance=new A198551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198552
{
public static readonly long[] Value={ 1L,1L,3L,2L,7L,7L,8L,4L,1L,6L,6L,7L,8L,0L,4L,3L,5L,5L,1L,2L,9L,8L,3L,7L,2L,5L,4L,3L,7L,2L,4L,1L,0L,8L,3L,8L,5L,0L,6L,9L,7L,7L,3L,0L,0L,2L,2L,8L,8L,6L,6L,0L,9L,6L,0L,8L,8L,4L,8L,6L,9L,9L,0L,8L,5L,6L,8L,4L,3L,1L,9L,5L,1L,9L,1L,2L,9L,0L,9L,0L,8L,8L,7L,3L,4L,0L,7L,3L,2L,5L,1L,4L,8L,9L,5L,7L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198552Inst : IEnumerable<long>
{
public static readonly long[] Value=A198552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198552.Bytes);
public long this[int i]=>Value[i];

public static A198552Inst Instance=new A198552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198553
{
public static readonly long[] Value={ 1L,3L,1L,4L,5L,1L,8L,9L,3L,5L,6L,6L,2L,9L,1L,3L,3L,7L,8L,5L,6L,2L,0L,3L,2L,7L,2L,2L,8L,9L,9L,0L,1L,3L,0L,4L,7L,0L,8L,6L,4L,8L,6L,6L,8L,7L,6L,7L,2L,6L,3L,8L,2L,3L,5L,9L,7L,7L,7L,0L,5L,1L,9L,4L,0L,4L,4L,7L,9L,7L,0L,5L,4L,6L,6L,8L,5L,4L,2L,3L,9L,8L,3L,0L,2L,8L,9L,9L,7L,5L,3L,0L,6L,2L,5L,5L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198553Inst : IEnumerable<long>
{
public static readonly long[] Value=A198553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198553.Bytes);
public long this[int i]=>Value[i];

public static A198553Inst Instance=new A198553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198554
{
public static readonly long[] Value={ 4L,9L,0L,1L,1L,0L,8L,3L,0L,7L,3L,4L,8L,6L,7L,4L,3L,7L,3L,5L,5L,1L,4L,0L,7L,3L,7L,4L,1L,1L,1L,6L,7L,2L,0L,1L,4L,3L,4L,8L,1L,0L,1L,9L,5L,1L,7L,8L,7L,8L,7L,7L,4L,6L,4L,1L,5L,1L,7L,4L,1L,1L,2L,9L,7L,3L,7L,4L,0L,5L,7L,6L,8L,3L,7L,3L,0L,3L,7L,5L,8L,9L,9L,4L,5L,6L,8L,7L,1L,1L,0L,2L,7L,2L,0L,1L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198554Inst : IEnumerable<long>
{
public static readonly long[] Value=A198554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198554.Bytes);
public long this[int i]=>Value[i];

public static A198554Inst Instance=new A198554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198555
{
public static readonly long[] Value={ 7L,0L,9L,1L,3L,5L,0L,9L,3L,6L,6L,7L,6L,4L,5L,1L,3L,1L,2L,9L,5L,7L,2L,8L,3L,5L,8L,3L,3L,3L,5L,1L,4L,5L,4L,8L,6L,1L,4L,1L,2L,7L,2L,4L,2L,7L,4L,7L,2L,9L,7L,0L,9L,8L,5L,1L,7L,3L,2L,7L,6L,1L,5L,4L,1L,6L,6L,1L,7L,2L,8L,1L,2L,4L,3L,7L,6L,4L,6L,3L,9L,5L,0L,3L,0L,0L,4L,9L,1L,5L,7L,0L,7L,2L,9L,4L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198555Inst : IEnumerable<long>
{
public static readonly long[] Value=A198555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198555.Bytes);
public long this[int i]=>Value[i];

public static A198555Inst Instance=new A198555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198556
{
public static readonly long[] Value={ 9L,0L,2L,2L,9L,5L,9L,7L,5L,6L,8L,7L,3L,7L,0L,9L,8L,1L,6L,7L,1L,5L,2L,6L,9L,9L,7L,4L,7L,9L,8L,5L,2L,4L,4L,2L,1L,1L,1L,9L,1L,3L,6L,2L,0L,2L,8L,2L,1L,2L,8L,3L,4L,6L,4L,3L,8L,0L,5L,1L,4L,0L,2L,0L,6L,1L,1L,6L,1L,9L,2L,3L,1L,9L,8L,5L,8L,6L,3L,8L,9L,0L,2L,3L,1L,1L,9L,6L,0L,2L,0L,9L,4L,6L,0L,8L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198556Inst : IEnumerable<long>
{
public static readonly long[] Value=A198556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198556.Bytes);
public long this[int i]=>Value[i];

public static A198556Inst Instance=new A198556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198557
{
public static readonly long[] Value={ 1L,0L,6L,9L,8L,5L,8L,4L,8L,0L,7L,6L,7L,5L,6L,5L,4L,2L,5L,5L,4L,2L,3L,4L,5L,6L,2L,6L,8L,0L,4L,1L,1L,8L,0L,2L,1L,6L,2L,7L,2L,6L,3L,9L,7L,2L,4L,2L,9L,2L,4L,0L,6L,0L,1L,2L,4L,9L,1L,2L,7L,9L,0L,4L,9L,1L,6L,5L,2L,5L,4L,3L,6L,7L,0L,8L,2L,3L,1L,3L,2L,1L,4L,3L,4L,2L,2L,2L,6L,6L,7L,4L,6L,9L,8L,9L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198557Inst : IEnumerable<long>
{
public static readonly long[] Value=A198557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198557.Bytes);
public long this[int i]=>Value[i];

public static A198557Inst Instance=new A198557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198558
{
public static readonly long[] Value={ 1L,3L,5L,9L,5L,8L,6L,5L,2L,9L,9L,4L,5L,8L,2L,9L,4L,8L,7L,2L,4L,3L,6L,8L,4L,8L,5L,8L,7L,3L,0L,6L,9L,7L,1L,1L,8L,5L,8L,5L,4L,0L,9L,3L,6L,9L,5L,1L,1L,7L,3L,7L,6L,7L,7L,0L,3L,0L,3L,1L,8L,0L,1L,0L,6L,3L,1L,6L,4L,7L,0L,3L,8L,3L,5L,3L,6L,0L,3L,2L,3L,2L,3L,3L,5L,1L,3L,0L,5L,4L,9L,5L,2L,5L,2L,8L,6L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198558Inst : IEnumerable<long>
{
public static readonly long[] Value=A198558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198558.Bytes);
public long this[int i]=>Value[i];

public static A198558Inst Instance=new A198558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198559
{
public static readonly long[] Value={ 1L,8L,0L,7L,0L,3L,4L,0L,8L,1L,7L,3L,9L,4L,1L,0L,8L,8L,6L,1L,3L,7L,8L,3L,3L,4L,2L,0L,9L,6L,8L,5L,9L,8L,0L,6L,4L,8L,6L,7L,0L,2L,9L,9L,7L,9L,5L,6L,3L,2L,1L,2L,1L,6L,1L,5L,1L,0L,9L,6L,3L,5L,6L,8L,0L,2L,7L,3L,7L,0L,7L,7L,8L,6L,2L,5L,3L,7L,4L,7L,6L,0L,9L,0L,6L,5L,3L,9L,6L,7L,8L,6L,8L,8L,9L,4L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198559Inst : IEnumerable<long>
{
public static readonly long[] Value=A198559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198559.Bytes);
public long this[int i]=>Value[i];

public static A198559Inst Instance=new A198559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198560
{
public static readonly long[] Value={ 9L,5L,1L,8L,9L,3L,1L,0L,2L,9L,8L,1L,4L,0L,6L,3L,5L,6L,9L,5L,1L,1L,8L,5L,3L,9L,5L,7L,7L,4L,1L,9L,2L,4L,9L,5L,4L,0L,2L,1L,4L,5L,4L,6L,9L,8L,7L,8L,1L,1L,3L,4L,5L,8L,5L,4L,1L,2L,5L,7L,9L,7L,3L,1L,1L,1L,0L,8L,8L,7L,3L,2L,5L,2L,1L,6L,2L,4L,8L,8L,4L,2L,3L,7L,2L,5L,9L,6L,4L,0L,8L,7L,1L,9L,9L,5L,7L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198560Inst : IEnumerable<long>
{
public static readonly long[] Value=A198560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198560.Bytes);
public long this[int i]=>Value[i];

public static A198560Inst Instance=new A198560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198561
{
public static readonly long[] Value={ 1L,1L,8L,7L,3L,6L,4L,0L,6L,6L,1L,9L,5L,2L,4L,5L,8L,3L,4L,7L,2L,4L,9L,0L,3L,0L,1L,1L,2L,7L,1L,0L,0L,3L,9L,5L,6L,2L,4L,6L,6L,1L,5L,0L,3L,1L,6L,6L,7L,4L,8L,0L,0L,1L,7L,0L,9L,6L,6L,3L,5L,3L,7L,2L,9L,0L,5L,7L,3L,6L,2L,8L,6L,0L,2L,4L,5L,1L,3L,1L,7L,6L,1L,7L,7L,9L,9L,6L,3L,6L,4L,1L,4L,2L,4L,2L,4L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198561Inst : IEnumerable<long>
{
public static readonly long[] Value=A198561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198561.Bytes);
public long this[int i]=>Value[i];

public static A198561Inst Instance=new A198561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198562
{
public static readonly long[] Value={ 1L,3L,7L,8L,6L,6L,0L,9L,4L,8L,1L,9L,9L,5L,4L,9L,1L,9L,3L,0L,5L,2L,5L,5L,6L,8L,5L,4L,2L,7L,5L,9L,0L,4L,1L,2L,5L,6L,1L,8L,2L,4L,6L,7L,0L,3L,8L,6L,5L,0L,2L,2L,2L,9L,7L,1L,5L,6L,0L,5L,6L,4L,9L,2L,8L,3L,5L,7L,5L,6L,6L,6L,5L,6L,7L,2L,9L,6L,8L,7L,1L,9L,8L,0L,1L,4L,8L,5L,6L,8L,6L,0L,9L,8L,6L,6L,8L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198562Inst : IEnumerable<long>
{
public static readonly long[] Value=A198562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198562.Bytes);
public long this[int i]=>Value[i];

public static A198562Inst Instance=new A198562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198563
{
public static readonly long[] Value={ 1L,5L,3L,4L,8L,2L,4L,8L,6L,7L,5L,8L,2L,1L,6L,4L,9L,3L,3L,6L,2L,4L,8L,2L,8L,4L,7L,7L,8L,0L,5L,9L,3L,7L,8L,8L,8L,9L,1L,1L,1L,7L,0L,8L,5L,1L,9L,8L,6L,7L,4L,7L,6L,3L,5L,9L,7L,5L,0L,9L,1L,6L,5L,2L,2L,2L,2L,1L,1L,1L,7L,5L,0L,6L,9L,9L,1L,9L,0L,4L,8L,7L,5L,4L,7L,6L,9L,4L,7L,9L,8L,3L,4L,6L,5L,2L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198563Inst : IEnumerable<long>
{
public static readonly long[] Value=A198563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198563.Bytes);
public long this[int i]=>Value[i];

public static A198563Inst Instance=new A198563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198564
{
public static readonly long[] Value={ 7L,2L,8L,4L,6L,8L,2L,3L,9L,3L,5L,6L,9L,9L,0L,7L,6L,8L,3L,6L,1L,5L,3L,2L,2L,7L,8L,1L,4L,9L,9L,0L,7L,4L,7L,0L,5L,2L,5L,0L,9L,5L,3L,6L,5L,0L,7L,0L,5L,2L,8L,5L,5L,4L,9L,5L,9L,3L,8L,6L,9L,5L,3L,7L,9L,3L,9L,9L,9L,0L,4L,3L,2L,8L,0L,1L,7L,1L,5L,3L,8L,2L,4L,9L,5L,2L,2L,5L,1L,2L,2L,6L,1L,7L,5L,8L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198564Inst : IEnumerable<long>
{
public static readonly long[] Value=A198564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198564.Bytes);
public long this[int i]=>Value[i];

public static A198564Inst Instance=new A198564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198565
{
public static readonly long[] Value={ 1L,1L,0L,6L,1L,4L,4L,3L,7L,3L,0L,5L,1L,6L,3L,8L,9L,9L,9L,9L,2L,1L,4L,1L,0L,6L,2L,6L,1L,0L,6L,5L,0L,8L,6L,4L,3L,7L,2L,1L,5L,6L,5L,2L,7L,0L,0L,0L,3L,3L,2L,4L,5L,1L,5L,3L,5L,7L,5L,0L,2L,7L,3L,0L,0L,5L,5L,3L,5L,3L,4L,0L,4L,9L,6L,5L,4L,9L,2L,8L,7L,0L,6L,5L,4L,6L,5L,4L,7L,3L,6L,7L,9L,0L,8L,3L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198565Inst : IEnumerable<long>
{
public static readonly long[] Value=A198565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198565.Bytes);
public long this[int i]=>Value[i];

public static A198565Inst Instance=new A198565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198566
{
public static readonly long[] Value={ 1L,7L,7L,5L,6L,9L,0L,6L,2L,0L,3L,6L,4L,4L,8L,1L,1L,3L,9L,3L,2L,4L,8L,0L,1L,8L,5L,2L,3L,3L,7L,8L,6L,0L,9L,6L,0L,2L,7L,5L,1L,1L,5L,6L,4L,1L,9L,4L,2L,4L,1L,6L,1L,8L,8L,0L,4L,7L,9L,7L,5L,9L,8L,3L,2L,1L,3L,4L,0L,5L,4L,8L,4L,4L,9L,6L,4L,3L,2L,6L,2L,0L,1L,9L,5L,4L,6L,6L,8L,8L,0L,6L,4L,0L,7L,4L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198566Inst : IEnumerable<long>
{
public static readonly long[] Value=A198566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198566.Bytes);
public long this[int i]=>Value[i];

public static A198566Inst Instance=new A198566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198567
{
public static readonly long[] Value={ 1L,9L,6L,8L,3L,9L,7L,5L,0L,7L,8L,5L,8L,7L,3L,2L,8L,4L,1L,3L,8L,2L,8L,9L,9L,1L,8L,4L,6L,0L,1L,6L,9L,6L,2L,4L,0L,7L,8L,6L,7L,2L,2L,4L,1L,9L,7L,3L,7L,3L,7L,3L,7L,8L,8L,8L,9L,4L,2L,2L,1L,6L,4L,7L,1L,6L,3L,9L,2L,1L,6L,3L,5L,0L,9L,9L,5L,1L,6L,9L,3L,7L,2L,5L,0L,0L,6L,6L,2L,2L,3L,4L,3L,4L,3L,8L,2L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198567Inst : IEnumerable<long>
{
public static readonly long[] Value=A198567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198567.Bytes);
public long this[int i]=>Value[i];

public static A198567Inst Instance=new A198567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198568
{
public static readonly long[] Value={ 2L,1L,1L,0L,0L,2L,1L,9L,8L,8L,4L,5L,7L,5L,4L,0L,1L,0L,5L,8L,4L,4L,9L,9L,4L,5L,5L,5L,2L,8L,4L,5L,6L,3L,2L,6L,5L,1L,4L,7L,7L,3L,6L,6L,8L,1L,4L,4L,0L,4L,3L,8L,2L,5L,6L,4L,8L,6L,1L,4L,9L,9L,4L,1L,4L,6L,2L,5L,2L,8L,5L,8L,7L,4L,0L,3L,3L,2L,4L,3L,2L,0L,5L,2L,9L,6L,9L,3L,6L,2L,7L,8L,6L,0L,8L,4L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198568Inst : IEnumerable<long>
{
public static readonly long[] Value=A198568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198568.Bytes);
public long this[int i]=>Value[i];

public static A198568Inst Instance=new A198568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198569
{
public static readonly long[] Value={ 2L,2L,1L,8L,7L,2L,9L,3L,7L,4L,8L,7L,5L,6L,3L,8L,2L,6L,7L,3L,3L,6L,7L,8L,2L,5L,8L,6L,8L,3L,7L,6L,2L,5L,7L,1L,8L,9L,2L,0L,1L,6L,5L,0L,0L,6L,8L,2L,0L,5L,8L,6L,4L,3L,0L,3L,9L,0L,7L,6L,1L,4L,0L,5L,4L,5L,9L,4L,1L,9L,4L,9L,4L,4L,1L,4L,5L,2L,5L,3L,9L,5L,4L,4L,7L,7L,1L,5L,3L,9L,8L,5L,8L,2L,2L,8L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198569Inst : IEnumerable<long>
{
public static readonly long[] Value=A198569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198569.Bytes);
public long this[int i]=>Value[i];

public static A198569Inst Instance=new A198569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198570
{
public static readonly long[] Value={ 1L,2L,5L,2L,7L,3L,8L,2L,1L,9L,7L,7L,6L,4L,1L,5L,0L,9L,2L,9L,2L,2L,1L,8L,1L,0L,2L,8L,4L,8L,1L,8L,6L,9L,9L,4L,2L,4L,0L,1L,9L,2L,1L,0L,1L,4L,5L,7L,7L,4L,9L,3L,0L,6L,7L,8L,2L,5L,5L,4L,7L,2L,3L,3L,6L,9L,3L,6L,2L,2L,7L,3L,9L,8L,5L,3L,8L,2L,3L,7L,1L,2L,1L,0L,1L,8L,1L,8L,0L,2L,9L,4L,0L,9L,2L,0L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198570Inst : IEnumerable<long>
{
public static readonly long[] Value=A198570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198570.Bytes);
public long this[int i]=>Value[i];

public static A198570Inst Instance=new A198570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198571
{
public static readonly long[] Value={ 1L,4L,5L,5L,0L,9L,6L,5L,9L,1L,5L,6L,2L,8L,6L,6L,1L,5L,2L,4L,5L,9L,5L,4L,0L,8L,8L,7L,6L,0L,4L,6L,0L,6L,3L,5L,6L,6L,8L,1L,0L,9L,2L,2L,3L,1L,1L,2L,5L,7L,5L,3L,9L,2L,0L,4L,2L,1L,6L,0L,6L,5L,6L,9L,1L,3L,1L,4L,2L,8L,0L,5L,1L,4L,7L,3L,6L,1L,5L,0L,9L,9L,5L,9L,6L,8L,2L,2L,5L,5L,7L,5L,3L,8L,4L,9L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198571Inst : IEnumerable<long>
{
public static readonly long[] Value=A198571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198571.Bytes);
public long this[int i]=>Value[i];

public static A198571Inst Instance=new A198571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198572
{
public static readonly long[] Value={ 1L,7L,4L,9L,8L,1L,0L,4L,9L,6L,2L,9L,8L,1L,8L,3L,3L,9L,8L,7L,6L,1L,2L,9L,7L,0L,6L,4L,7L,5L,3L,4L,8L,6L,6L,5L,2L,0L,1L,0L,0L,6L,4L,3L,2L,3L,3L,5L,0L,0L,4L,2L,5L,7L,1L,8L,9L,1L,1L,7L,0L,7L,7L,1L,8L,8L,1L,7L,7L,2L,5L,8L,1L,9L,7L,0L,6L,4L,1L,1L,7L,9L,4L,4L,3L,0L,7L,7L,6L,9L,1L,0L,2L,2L,7L,5L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198572Inst : IEnumerable<long>
{
public static readonly long[] Value=A198572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198572.Bytes);
public long this[int i]=>Value[i];

public static A198572Inst Instance=new A198572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198573
{
public static readonly long[] Value={ 9L,6L,3L,1L,0L,4L,6L,2L,0L,6L,8L,8L,1L,9L,1L,7L,8L,6L,3L,7L,3L,7L,3L,9L,5L,4L,9L,1L,8L,5L,5L,0L,0L,1L,8L,1L,6L,3L,6L,1L,5L,9L,2L,0L,3L,6L,0L,3L,6L,9L,9L,9L,8L,6L,5L,6L,5L,0L,2L,3L,9L,9L,2L,5L,0L,1L,7L,0L,4L,7L,7L,3L,0L,4L,6L,6L,3L,6L,7L,0L,3L,1L,1L,4L,4L,6L,5L,1L,5L,7L,1L,7L,3L,2L,3L,9L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198573Inst : IEnumerable<long>
{
public static readonly long[] Value=A198573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198573.Bytes);
public long this[int i]=>Value[i];

public static A198573Inst Instance=new A198573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198574
{
public static readonly long[] Value={ 1L,1L,4L,7L,3L,0L,4L,8L,9L,8L,1L,3L,5L,2L,4L,9L,4L,2L,9L,1L,7L,5L,0L,4L,3L,0L,1L,1L,7L,0L,6L,4L,1L,7L,4L,1L,6L,3L,7L,4L,4L,6L,2L,8L,7L,2L,2L,1L,2L,2L,0L,6L,6L,2L,5L,4L,7L,2L,0L,8L,4L,3L,5L,6L,9L,5L,2L,4L,9L,8L,4L,8L,2L,5L,6L,4L,3L,6L,6L,9L,2L,0L,1L,1L,0L,4L,4L,8L,7L,2L,6L,6L,1L,4L,0L,3L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198574Inst : IEnumerable<long>
{
public static readonly long[] Value=A198574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198574.Bytes);
public long this[int i]=>Value[i];

public static A198574Inst Instance=new A198574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198575
{
public static readonly long[] Value={ 1L,3L,0L,4L,6L,3L,1L,7L,1L,0L,3L,9L,4L,7L,8L,7L,3L,7L,9L,5L,8L,7L,4L,6L,7L,0L,6L,5L,2L,3L,2L,9L,9L,3L,9L,6L,9L,3L,7L,6L,0L,7L,2L,9L,2L,1L,8L,0L,3L,6L,7L,2L,6L,1L,8L,0L,0L,6L,5L,1L,6L,2L,6L,1L,0L,6L,3L,9L,7L,0L,5L,3L,0L,3L,6L,7L,0L,5L,2L,7L,1L,3L,2L,3L,2L,6L,7L,2L,8L,3L,6L,5L,1L,8L,6L,1L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198575Inst : IEnumerable<long>
{
public static readonly long[] Value=A198575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198575.Bytes);
public long this[int i]=>Value[i];

public static A198575Inst Instance=new A198575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198576
{
public static readonly long[] Value={ 1L,4L,3L,8L,9L,2L,8L,0L,8L,7L,7L,2L,6L,5L,9L,7L,5L,5L,5L,0L,1L,0L,4L,7L,7L,7L,9L,9L,0L,0L,1L,5L,2L,7L,9L,9L,9L,5L,4L,8L,2L,0L,5L,2L,7L,9L,5L,3L,8L,2L,7L,1L,2L,6L,2L,9L,7L,9L,9L,0L,4L,4L,2L,8L,5L,9L,1L,6L,1L,0L,8L,7L,4L,5L,1L,1L,0L,3L,3L,4L,3L,9L,3L,1L,3L,0L,5L,8L,8L,7L,1L,2L,8L,7L,8L,8L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198576Inst : IEnumerable<long>
{
public static readonly long[] Value=A198576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198576.Bytes);
public long this[int i]=>Value[i];

public static A198576Inst Instance=new A198576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198577
{
public static readonly long[] Value={ 2L,1L,8L,6L,6L,5L,0L,7L,8L,3L,2L,6L,6L,9L,0L,6L,1L,7L,9L,5L,8L,5L,5L,4L,5L,2L,7L,5L,4L,8L,1L,7L,9L,4L,6L,4L,2L,1L,0L,4L,2L,1L,1L,2L,2L,2L,7L,3L,1L,3L,3L,9L,8L,1L,8L,5L,6L,6L,8L,7L,2L,1L,7L,5L,8L,6L,4L,9L,2L,6L,3L,6L,0L,0L,2L,0L,8L,3L,0L,9L,4L,5L,2L,3L,6L,7L,7L,3L,6L,1L,7L,4L,4L,5L,3L,9L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198577Inst : IEnumerable<long>
{
public static readonly long[] Value=A198577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198577.Bytes);
public long this[int i]=>Value[i];

public static A198577Inst Instance=new A198577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198578
{
public static readonly long[] Value={ 2L,4L,1L,3L,5L,4L,7L,7L,4L,2L,1L,1L,6L,9L,0L,9L,7L,6L,6L,0L,1L,4L,3L,0L,9L,2L,8L,4L,2L,1L,1L,6L,2L,3L,7L,3L,0L,0L,2L,6L,0L,3L,6L,5L,3L,7L,8L,7L,8L,5L,0L,7L,7L,7L,0L,3L,8L,2L,8L,3L,1L,1L,0L,5L,7L,6L,4L,0L,2L,8L,1L,5L,4L,2L,1L,7L,3L,2L,7L,1L,3L,9L,4L,3L,6L,4L,0L,2L,3L,3L,4L,1L,9L,6L,9L,5L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198578Inst : IEnumerable<long>
{
public static readonly long[] Value=A198578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198578.Bytes);
public long this[int i]=>Value[i];

public static A198578Inst Instance=new A198578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198579
{
public static readonly long[] Value={ 1L,5L,4L,8L,5L,3L,6L,9L,5L,2L,6L,1L,0L,6L,5L,6L,1L,2L,6L,2L,4L,3L,1L,2L,2L,5L,4L,1L,2L,4L,9L,3L,6L,9L,7L,5L,0L,3L,3L,9L,8L,3L,9L,3L,5L,1L,5L,4L,9L,5L,1L,1L,8L,0L,7L,3L,0L,4L,5L,8L,0L,8L,1L,5L,3L,3L,6L,7L,2L,6L,1L,6L,6L,3L,3L,6L,6L,1L,5L,2L,6L,9L,0L,0L,6L,0L,6L,0L,1L,7L,7L,9L,0L,8L,8L,4L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198579Inst : IEnumerable<long>
{
public static readonly long[] Value=A198579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198579.Bytes);
public long this[int i]=>Value[i];

public static A198579Inst Instance=new A198579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198580
{
public static readonly long[] Value={ 1L,7L,1L,7L,3L,6L,3L,2L,4L,5L,1L,5L,0L,8L,9L,5L,4L,2L,9L,4L,6L,3L,7L,2L,2L,9L,9L,5L,4L,5L,1L,4L,2L,4L,3L,0L,0L,2L,1L,2L,3L,3L,3L,5L,0L,7L,9L,9L,5L,0L,6L,1L,3L,5L,2L,6L,0L,8L,6L,6L,1L,2L,1L,0L,6L,8L,9L,6L,2L,0L,4L,8L,5L,3L,3L,0L,3L,9L,7L,0L,2L,1L,4L,7L,8L,9L,5L,6L,5L,6L,8L,6L,8L,2L,2L,8L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198580Inst : IEnumerable<long>
{
public static readonly long[] Value=A198580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198580.Bytes);
public long this[int i]=>Value[i];

public static A198580Inst Instance=new A198580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198581
{
public static readonly long[] Value={ 1L,8L,5L,2L,0L,5L,7L,1L,8L,2L,2L,3L,6L,2L,6L,4L,6L,5L,3L,6L,0L,7L,1L,9L,5L,4L,0L,2L,2L,6L,4L,9L,4L,1L,4L,1L,5L,6L,9L,4L,5L,8L,0L,0L,1L,2L,4L,2L,6L,3L,5L,2L,6L,5L,8L,1L,3L,0L,1L,4L,7L,9L,7L,9L,1L,3L,6L,7L,4L,4L,9L,9L,1L,4L,7L,8L,8L,2L,0L,6L,7L,8L,6L,9L,1L,3L,5L,3L,6L,8L,5L,9L,5L,2L,7L,4L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198581Inst : IEnumerable<long>
{
public static readonly long[] Value=A198581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198581.Bytes);
public long this[int i]=>Value[i];

public static A198581Inst Instance=new A198581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198582
{
public static readonly long[] Value={ 1L,9L,6L,1L,7L,2L,7L,9L,5L,1L,6L,4L,6L,5L,3L,9L,8L,4L,1L,6L,0L,9L,6L,2L,7L,4L,0L,1L,6L,7L,6L,7L,5L,3L,1L,7L,0L,0L,7L,7L,8L,3L,6L,6L,8L,4L,9L,9L,8L,3L,0L,8L,2L,9L,5L,0L,5L,7L,0L,5L,7L,6L,7L,3L,8L,9L,1L,0L,2L,8L,9L,7L,3L,8L,3L,4L,9L,5L,9L,4L,4L,0L,0L,0L,1L,3L,6L,6L,9L,6L,3L,9L,2L,1L,8L,5L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198582Inst : IEnumerable<long>
{
public static readonly long[] Value=A198582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198582.Bytes);
public long this[int i]=>Value[i];

public static A198582Inst Instance=new A198582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198583
{
public static readonly long[] Value={ 4L,8L,0L,9L,4L,5L,9L,5L,7L,7L,2L,8L,1L,2L,9L,6L,5L,7L,7L,6L,6L,2L,9L,7L,8L,5L,6L,5L,3L,7L,6L,5L,6L,3L,8L,3L,3L,8L,5L,4L,0L,7L,0L,8L,5L,9L,1L,3L,4L,6L,6L,3L,6L,7L,3L,2L,9L,2L,5L,6L,2L,6L,9L,9L,9L,6L,3L,9L,8L,8L,3L,9L,3L,6L,3L,9L,6L,1L,1L,1L,9L,9L,5L,1L,9L,4L,0L,8L,7L,2L,8L,1L,3L,9L,2L,8L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198583Inst : IEnumerable<long>
{
public static readonly long[] Value=A198583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198583.Bytes);
public long this[int i]=>Value[i];

public static A198583Inst Instance=new A198583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198584
{
public static readonly long[] Value={ 3L,13L,53L,113L,213L,227L,453L,853L,909L,1813L,3413L,3637L,7253L,7281L,13653L,14549L,14563L,29013L,29125L,54613L,58197L,58253L,116053L,116501L,218453L,232789L,233013L,464213L,466005L,466033L,873813L,931157L,932053L,932067L,1856853L,1864021L,1864133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198584Inst : IEnumerable<long>
{
public static readonly long[] Value=A198584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198584.Bytes);
public long this[int i]=>Value[i];

public static A198584Inst Instance=new A198584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198585
{
public static readonly long[] Value={ 5L,5L,5L,85L,5L,341L,85L,5L,341L,85L,5L,341L,85L,5461L,5L,341L,21845L,85L,5461L,5L,341L,21845L,85L,5461L,5L,341L,21845L,85L,5461L,349525L,5L,341L,21845L,1398101L,85L,5461L,349525L,5L,341L,21845L,1398101L,85L,5461L,349525L,5L,341L,21845L,1398101L,85L,5461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198585Inst : IEnumerable<long>
{
public static readonly long[] Value=A198585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198585.Bytes);
public long this[int i]=>Value[i];

public static A198585Inst Instance=new A198585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198586
{
public static readonly long[] Value={ 5L,85L,341L,5461L,21845L,349525L,1398101L,22369621L,89478485L,1431655765L,5726623061L,91625968981L,366503875925L,5864062014805L,23456248059221L,375299968947541L,1501199875790165L,24019198012642645L,96076792050570581L,1537228672809129301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198586Inst : IEnumerable<long>
{
public static readonly long[] Value=A198586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198586.Bytes);
public long this[int i]=>Value[i];

public static A198586Inst Instance=new A198586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198587
{
public static readonly long[] Value={ 17L,35L,69L,75L,141L,151L,277L,301L,565L,605L,1109L,1137L,1205L,2261L,2275L,2417L,2421L,4437L,4549L,4821L,4835L,4849L,9045L,9101L,9669L,9685L,9699L,17749L,18197L,19285L,19341L,19397L,19417L,36181L,36405L,38677L,38741L,38797L,38833L,38835L,70997L,72789L,72817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198587Inst : IEnumerable<long>
{
public static readonly long[] Value=A198587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198587.Bytes);
public long this[int i]=>Value[i];

public static A198587Inst Instance=new A198587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198588
{
public static readonly long[] Value={ 11L,23L,45L,93L,181L,201L,369L,373L,401L,403L,725L,739L,753L,803L,805L,1477L,1493L,1507L,1605L,1611L,1613L,2901L,2957L,3013L,3033L,3213L,3221L,3223L,5909L,5973L,6029L,6065L,6067L,6421L,6445L,6453L,6465L,11605L,11829L,12053L,12131L,12133L,12853L,12885L,12893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198588Inst : IEnumerable<long>
{
public static readonly long[] Value=A198588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198588.Bytes);
public long this[int i]=>Value[i];

public static A198588Inst Instance=new A198588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198589
{
public static readonly long[] Value={ 7L,15L,29L,61L,117L,241L,245L,267L,469L,483L,497L,535L,537L,965L,981L,985L,995L,1069L,1073L,1075L,1877L,1933L,1969L,1971L,1989L,2009L,2141L,2147L,2149L,3861L,3925L,3939L,3941L,3981L,4017L,4019L,4043L,4277L,4293L,4297L,4301L,7509L,7733L,7877L,7885L,7957L,8035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198589Inst : IEnumerable<long>
{
public static readonly long[] Value=A198589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198589.Bytes);
public long this[int i]=>Value[i];

public static A198589Inst Instance=new A198589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198590
{
public static readonly long[] Value={ 9L,19L,37L,77L,81L,149L,163L,309L,321L,325L,331L,597L,625L,643L,653L,663L,713L,715L,1237L,1251L,1285L,1301L,1313L,1325L,1339L,1425L,1427L,1431L,1433L,2389L,2501L,2573L,2577L,2613L,2625L,2627L,2653L,2679L,2695L,2851L,2853L,2861L,2865L,2867L,4949L,5005L,5141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198590Inst : IEnumerable<long>
{
public static readonly long[] Value=A198590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198590.Bytes);
public long this[int i]=>Value[i];

public static A198590Inst Instance=new A198590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198591
{
public static readonly long[] Value={ 25L,49L,51L,99L,101L,197L,205L,217L,397L,405L,433L,435L,441L,475L,789L,821L,833L,857L,867L,869L,875L,883L,951L,953L,955L,1589L,1621L,1649L,1667L,1713L,1715L,1733L,1741L,1751L,1765L,1785L,1901L,1907L,1911L,3157L,3185L,3285L,3299L,3333L,3427L,3429L,3469L,3477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198591Inst : IEnumerable<long>
{
public static readonly long[] Value=A198591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198591.Bytes);
public long this[int i]=>Value[i];

public static A198591Inst Instance=new A198591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198592
{
public static readonly long[] Value={ 33L,65L,67L,131L,133L,261L,269L,273L,289L,525L,529L,533L,547L,555L,571L,577L,579L,583L,633L,635L,1045L,1059L,1077L,1093L,1099L,1111L,1143L,1155L,1157L,1167L,1177L,1267L,1271L,1273L,2101L,2117L,2123L,2133L,2161L,2189L,2199L,2221L,2285L,2309L,2317L,2321L,2333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198592Inst : IEnumerable<long>
{
public static readonly long[] Value=A198592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198592.Bytes);
public long this[int i]=>Value[i];

public static A198592Inst Instance=new A198592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198593
{
public static readonly long[] Value={ 43L,87L,89L,173L,177L,179L,349L,355L,357L,385L,423L,693L,705L,709L,717L,729L,761L,769L,771L,777L,847L,1393L,1397L,1411L,1415L,1421L,1429L,1457L,1459L,1465L,1481L,1523L,1539L,1541L,1547L,1555L,1569L,1689L,1693L,1697L,2773L,2787L,2801L,2821L,2831L,2837L,2869L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198593Inst : IEnumerable<long>
{
public static readonly long[] Value=A198593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198593.Bytes);
public long this[int i]=>Value[i];

public static A198593Inst Instance=new A198593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198594
{
public static readonly BigInteger[] Value={ 17L,2684L,511661L,101749556L,20489929961L,4142124332044L,838329027803141L,169730671672463748L,BigInteger.Parse("34367910101781840193"),BigInteger.Parse("6959214284742747147804"),BigInteger.Parse("1409196791555539177862621"),BigInteger.Parse("285354290765682664063587924") };
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
public class A198594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198594.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198594Inst Instance=new A198594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198595
{
public static readonly long[] Value={ 272L,511661L,1208560656L,3082580273539L,8057520048724340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198595Inst : IEnumerable<long>
{
public static readonly long[] Value=A198595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198595.Bytes);
public long this[int i]=>Value[i];

public static A198595Inst Instance=new A198595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198596
{
public static readonly long[] Value={ 2L,17L,17L,272L,2684L,272L,4667L,511661L,511661L,4667L,80702L,101749556L,1208560656L,101749556L,80702L,1397477L,20489929961L,3082580273539L,3082580273539L,20489929961L,1397477L,24207692L,4142124332044L,8057520048724340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198596Inst : IEnumerable<long>
{
public static readonly long[] Value=A198596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198596.Bytes);
public long this[int i]=>Value[i];

public static A198596Inst Instance=new A198596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198597
{
public static readonly long[] Value={ 1L,5L,674L,844228L,8055413256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198597Inst : IEnumerable<long>
{
public static readonly long[] Value=A198597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198597.Bytes);
public long this[int i]=>Value[i];

public static A198597Inst Instance=new A198597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198598
{
public static readonly long[] Value={ 1L,5L,32L,251L,1985L,15761L,125168L,994127L,7895777L,62711837L,498086240L,3956031011L,31420628321L,249557171369L,1982098563440L,15742744249463L,125036161801025L,993095073749045L,7887620760000800L,62647135102634315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198598Inst : IEnumerable<long>
{
public static readonly long[] Value=A198598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198598.Bytes);
public long this[int i]=>Value[i];

public static A198598Inst Instance=new A198598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198599
{
public static readonly BigInteger[] Value={ 2L,32L,674L,14396L,309770L,6671450L,143724590L,3096625676L,66720604082L,1437592096184L,30975107870150L,667406503209962L,14380307969705594L,309846066281809304L,6676114885818492290L,BigInteger.Parse("143847269049688259540") };
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
public class A198599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198599.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198599Inst Instance=new A198599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198600
{
public static readonly BigInteger[] Value={ 5L,251L,14396L,844228L,49726877L,2934981667L,173328303620L,10237927785188L,604754378402213L,35723495136378379L,2110237768703448092L,BigInteger.Parse("124654981592741709892"),BigInteger.Parse("7363565234193825044093"),BigInteger.Parse("434977425639969487046579") };
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
public class A198600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198600.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198600Inst Instance=new A198600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198601
{
public static readonly BigInteger[] Value={ 14L,1985L,309770L,49726877L,8055413256L,1308245895665L,212660032469362L,34578446232234461L,5622954055105266638L,BigInteger.Parse("914399588312051428232"),BigInteger.Parse("148700162991801408836106"),BigInteger.Parse("24181772212240990503470021") };
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
public class A198601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198601.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198601Inst Instance=new A198601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198602
{
public static readonly long[] Value={ 41L,15761L,6671450L,2934981667L,1308245895665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198602Inst : IEnumerable<long>
{
public static readonly long[] Value=A198602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198602.Bytes);
public long this[int i]=>Value[i];

public static A198602Inst Instance=new A198602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198603
{
public static readonly long[] Value={ 122L,125168L,143724590L,173328303620L,212660032469362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198603Inst : IEnumerable<long>
{
public static readonly long[] Value=A198603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198603.Bytes);
public long this[int i]=>Value[i];

public static A198603Inst Instance=new A198603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198604
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,2L,5L,32L,32L,5L,14L,251L,674L,251L,14L,41L,1985L,14396L,14396L,1985L,41L,122L,15761L,309770L,844228L,309770L,15761L,122L,365L,125168L,6671450L,49726877L,49726877L,6671450L,125168L,365L,1094L,994127L,143724590L,2934981667L,8055413256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198604Inst : IEnumerable<long>
{
public static readonly long[] Value=A198604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198604.Bytes);
public long this[int i]=>Value[i];

public static A198604Inst Instance=new A198604Inst();

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