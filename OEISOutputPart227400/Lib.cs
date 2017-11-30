using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278062
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,3L,11L,12L,5L,13L,6L,7L,14L,16L,10L,8L,16L,20L,12L,17L,14L,22L,11L,21L,25L,16L,13L,17L,15L,24L,19L,26L,27L,23L,19L,30L,31L,23L,20L,33L,26L,13L,40L,28L,26L,37L,27L,20L,37L,38L,30L,38L,21L,35L,40L,22L,35L,41L,41L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278062Inst : IEnumerable<long>
{
public static readonly long[] Value=A278062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278062.Bytes);
public long this[int i]=>Value[i];

public static A278062Inst Instance=new A278062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278063
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,12L,13L,5L,14L,6L,7L,15L,17L,10L,8L,17L,21L,12L,18L,14L,23L,11L,22L,26L,16L,13L,17L,15L,25L,11L,26L,35L,18L,23L,36L,24L,25L,27L,25L,25L,34L,26L,35L,26L,24L,25L,33L,30L,35L,22L,42L,17L,31L,47L,31L,30L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278063Inst : IEnumerable<long>
{
public static readonly long[] Value=A278063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278063.Bytes);
public long this[int i]=>Value[i];

public static A278063Inst Instance=new A278063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278064
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,3L,13L,14L,5L,15L,6L,7L,16L,18L,10L,8L,18L,22L,12L,19L,14L,24L,11L,23L,27L,16L,13L,17L,15L,26L,20L,10L,27L,36L,20L,15L,42L,14L,31L,21L,34L,28L,15L,23L,50L,14L,31L,54L,24L,19L,23L,42L,32L,31L,34L,51L,14L,36L,61L,29L,17L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278064Inst : IEnumerable<long>
{
public static readonly long[] Value=A278064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278064.Bytes);
public long this[int i]=>Value[i];

public static A278064Inst Instance=new A278064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278065
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,3L,14L,15L,5L,16L,6L,7L,17L,19L,10L,8L,19L,23L,12L,20L,14L,25L,11L,24L,28L,16L,13L,17L,15L,27L,20L,20L,34L,27L,24L,12L,45L,17L,27L,28L,36L,22L,28L,33L,26L,37L,30L,29L,32L,37L,31L,24L,40L,46L,15L,52L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278065Inst : IEnumerable<long>
{
public static readonly long[] Value=A278065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278065.Bytes);
public long this[int i]=>Value[i];

public static A278065Inst Instance=new A278065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278066
{
public static readonly long[] Value={ 5L,2L,5L,2L,5L,7L,2L,12L,2L,12L,2L,12L,7L,4L,14L,14L,10L,14L,7L,14L,6L,26L,10L,4L,20L,33L,2L,33L,2L,33L,2L,33L,2L,38L,2L,38L,2L,38L,7L,4L,40L,40L,10L,40L,7L,14L,6L,78L,10L,4L,46L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L,85L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278066Inst : IEnumerable<long>
{
public static readonly long[] Value=A278066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278066.Bytes);
public long this[int i]=>Value[i];

public static A278066Inst Instance=new A278066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278067
{
public static readonly long[] Value={ 37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,2L,37L,39L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,2L,76L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278067Inst : IEnumerable<long>
{
public static readonly long[] Value=A278067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278067.Bytes);
public long this[int i]=>Value[i];

public static A278067Inst Instance=new A278067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278068
{
public static readonly long[] Value={ 57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,2L,57L,59L,2L,116L,2L,116L,2L,116L,2L,116L,2L,116L,2L,116L,2L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278068Inst : IEnumerable<long>
{
public static readonly long[] Value=A278068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278068.Bytes);
public long this[int i]=>Value[i];

public static A278068Inst Instance=new A278068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278069
{
public static readonly BigInteger[] Value={ 1L,0L,3L,-32L,465L,-8544L,190435L,-4996032L,150869313L,-5155334720L,196677847971L,-8286870547680L,382200680031313L,-19152276311294112L,1036167879649219395L,BigInteger.Parse("-60195061159370501504"),BigInteger.Parse("3737352803142621672705"),BigInteger.Parse("-246970483156591884266112"),BigInteger.Parse("17306865588065164490357443") };
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
public class A278069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278069Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278069.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278069.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278069Inst Instance=new A278069Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278070
{
public static readonly BigInteger[] Value={ 1L,2L,11L,106L,1457L,25946L,566827L,14665106L,438351041L,14862109042L,563501581931L,23624177026682L,1085079390005041L,54185293223976266L,2922842896378005707L,BigInteger.Parse("169366580127359119906"),BigInteger.Parse("10492171932362920604417"),BigInteger.Parse("691986726674000405367266"),BigInteger.Parse("48408260338825019327539531") };
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
public class A278070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278070Inst Instance=new A278070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278071
{
public static readonly long[] Value={ 1L,1L,-1L,6L,-4L,1L,60L,-36L,9L,-1L,840L,-480L,120L,-16L,1L,15120L,-8400L,2100L,-300L,25L,-1L,332640L,-181440L,45360L,-6720L,630L,-36L,1L,8648640L,-4656960L,1164240L,-176400L,17640L,-1176L,49L,-1L,259459200L,-138378240L,34594560L,-5322240L,554400L,-40320L,2016L,-64L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278071Inst : IEnumerable<long>
{
public static readonly long[] Value=A278071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278071.Bytes);
public long this[int i]=>Value[i];

public static A278071Inst Instance=new A278071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278072
{
public static readonly long[] Value={ 1L,-1L,1L,1L,1L,1L,-1L,4L,3L,1L,1L,10L,11L,5L,1L,-1L,32L,37L,22L,7L,1L,1L,100L,128L,88L,37L,9L,1L,-1L,329L,444L,341L,171L,56L,11L,1L,1L,1101L,1558L,1297L,739L,294L,79L,13L,1L,-1L,3761L,5514L,4891L,3069L,1406L,465L,106L,15L,1L,1L,13035L,19680L,18365L,12435L,6346L,2442L,692L,137L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278072Inst : IEnumerable<long>
{
public static readonly long[] Value=A278072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278072.Bytes);
public long this[int i]=>Value[i];

public static A278072Inst Instance=new A278072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278073
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,20L,0L,1L,168L,1680L,0L,1L,1364L,55440L,369600L,0L,1L,10920L,1561560L,33633600L,168168000L,0L,1L,87380L,42771456L,2385102720L,34306272000L,137225088000L,0L,1L,699048L,1160164320L,158411809920L,5105916816000L,54752810112000L,182509367040000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278073Inst : IEnumerable<long>
{
public static readonly long[] Value=A278073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278073.Bytes);
public long this[int i]=>Value[i];

public static A278073Inst Instance=new A278073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278074
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,70L,0L,1L,990L,34650L,0L,1L,16510L,2702700L,63063000L,0L,1L,261630L,213519150L,17459442000L,305540235000L,0L,1L,4196350L,17651304000L,4350310965000L,231905038365000L,3246670537110000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278074Inst : IEnumerable<long>
{
public static readonly long[] Value=A278074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278074.Bytes);
public long this[int i]=>Value[i];

public static A278074Inst Instance=new A278074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278075
{
public static readonly long[] Value={ 1L,0L,1L,0L,-1L,2L,0L,1L,-6L,6L,0L,-1L,14L,-36L,24L,0L,1L,-30L,150L,-240L,120L,0L,-1L,62L,-540L,1560L,-1800L,720L,0L,1L,-126L,1806L,-8400L,16800L,-15120L,5040L,0L,-1L,254L,-5796L,40824L,-126000L,191520L,-141120L,40320L,0L,1L,-510L,18150L,-186480L,834120L,-1905120L,2328480L,-1451520L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278075Inst : IEnumerable<long>
{
public static readonly long[] Value=A278075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278075.Bytes);
public long this[int i]=>Value[i];

public static A278075Inst Instance=new A278075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278076
{
public static readonly long[] Value={ 0L,1L,8L,9L,24L,25L,32L,33L,48L,49L,56L,57L,86L,87L,94L,95L,110L,111L,118L,119L,134L,135L,142L,143L,1260L,1261L,1268L,1269L,1284L,1285L,1292L,1293L,1308L,1309L,1316L,1317L,1346L,1347L,1354L,1355L,1370L,1371L,1378L,1379L,1394L,1395L,1402L,1403L,1890L,1891L,1898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278076Inst : IEnumerable<long>
{
public static readonly long[] Value=A278076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278076.Bytes);
public long this[int i]=>Value[i];

public static A278076Inst Instance=new A278076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278077
{
public static readonly long[] Value={ 0L,1L,-1L,2L,-5L,15L,-48L,161L,-558L,1985L,-7205L,26577L,-99333L,375366L,-1431740L,5504906L,-21313444L,83023692L,-325152548L,1279534265L,-5056843296L,20062512404L,-79875018700L,319021150220L,-1277884425750L,5132427441726L,-20664323290494L,83388318193363L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278077Inst : IEnumerable<long>
{
public static readonly long[] Value=A278077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278077.Bytes);
public long this[int i]=>Value[i];

public static A278077Inst Instance=new A278077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278078
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,2L,2L,3L,3L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,14L,14L,14L,14L,14L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,16L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278078Inst : IEnumerable<long>
{
public static readonly long[] Value=A278078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278078.Bytes);
public long this[int i]=>Value[i];

public static A278078Inst Instance=new A278078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278079
{
public static readonly BigInteger[] Value={ 0L,1L,0L,56L,1280L,59136L,3727360L,317295616L,34977546240L,4848147562496L,825249675345920L,169237314418507776L,BigInteger.Parse("41153580031698534400"),BigInteger.Parse("11708600267324004499456"),BigInteger.Parse("3853197364634932928839680"),BigInteger.Parse("1452327126187528216207425536"),BigInteger.Parse("621567950620088261848869109760") };
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
public class A278079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278079Inst Instance=new A278079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278080
{
public static readonly BigInteger[] Value={ 0L,0L,1L,-5L,126L,1490L,118151L,8256885L,808428076L,100199284180L,15432169163901L,2889536106161375L,646438926423519626L,BigInteger.Parse("170294687860735726470"),BigInteger.Parse("52177485058722877649251"),BigInteger.Parse("18397662218707151323777465"),BigInteger.Parse("7396641315814156362154666776") };
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
public class A278080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278080Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278080.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278080.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278080Inst Instance=new A278080Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278081
{
public static readonly long[] Value={ 1L,2L,6L,8L,6L,10L,14L,12L,16L,18L,16L,24L,30L,18L,30L,32L,20L,48L,38L,28L,40L,42L,36L,48L,56L,32L,54L,60L,36L,58L,62L,48L,84L,66L,48L,72L,72L,60L,80L,80L,54L,82L,96L,60L,88L,112L,64L,108L,96L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278081Inst : IEnumerable<long>
{
public static readonly long[] Value=A278081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278081.Bytes);
public long this[int i]=>Value[i];

public static A278081Inst Instance=new A278081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278082
{
public static readonly long[] Value={ 1L,1L,2L,0L,4L,2L,8L,0L,6L,4L,11L,0L,14L,8L,8L,0L,18L,6L,20L,0L,16L,11L,22L,0L,20L,14L,18L,0L,30L,8L,30L,0L,22L,18L,32L,0L,36L,20L,28L,0L,42L,16L,44L,0L,24L,22L,46L,0L,56L,20L,36L,0L,52L,18L,44L,0L,40L,30L,58L,0L,62L,30L,48L,0L,56L,22L,66L,0L,44L,32L,70L,0L,74L,36L,40L,0L,88L,28L,80L,0L,54L,42L,84L,0L,72L,44L,60L,0L,88L,24L,112L,0L,60L,46L,80L,0L,96L,56L,66L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278082Inst : IEnumerable<long>
{
public static readonly long[] Value=A278082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278082.Bytes);
public long this[int i]=>Value[i];

public static A278082Inst Instance=new A278082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278083
{
public static readonly long[] Value={ 1L,4L,4L,8L,12L,12L,12L,16L,16L,20L,32L,24L,20L,36L,28L,32L,48L,32L,36L,48L,40L,44L,48L,48L,56L,64L,52L,48L,80L,60L,60L,96L,48L,68L,96L,72L,72L,80L,96L,80L,108L,84L,64L,112L,88L,96L,128L,80L,96L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278083Inst : IEnumerable<long>
{
public static readonly long[] Value=A278083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278083.Bytes);
public long this[int i]=>Value[i];

public static A278083Inst Instance=new A278083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278084
{
public static readonly long[] Value={ 1L,2L,5L,6L,6L,12L,14L,10L,18L,20L,12L,22L,25L,18L,28L,32L,24L,30L,38L,28L,40L,42L,30L,46L,42L,36L,54L,60L,40L,60L,60L,36L,70L,66L,44L,72L,74L,50L,72L,80L,54L,82L,90L,56L,88L,84L,64L,100L,98L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278084Inst : IEnumerable<long>
{
public static readonly long[] Value=A278084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278084.Bytes);
public long this[int i]=>Value[i];

public static A278084Inst Instance=new A278084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278085
{
public static readonly long[] Value={ 1L,1L,3L,0L,6L,3L,6L,0L,9L,6L,12L,0L,12L,6L,18L,0L,18L,9L,18L,0L,18L,12L,24L,0L,30L,12L,27L,0L,30L,18L,30L,0L,36L,18L,36L,0L,36L,18L,36L,0L,42L,18L,42L,0L,54L,24L,48L,0L,42L,30L,54L,0L,54L,27L,72L,0L,54L,30L,60L,0L,60L,30L,54L,0L,72L,36L,66L,0L,72L,36L,72L,0L,72L,36L,90L,0L,72L,36L,78L,0L,81L,42L,84L,0L,108L,42L,90L,0L,90L,54L,72L,0L,90L,48L,108L,0L,96L,42L,108L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278085Inst : IEnumerable<long>
{
public static readonly long[] Value=A278085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278085.Bytes);
public long this[int i]=>Value[i];

public static A278085Inst Instance=new A278085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278086
{
public static readonly long[] Value={ 1L,1L,4L,0L,4L,4L,6L,0L,12L,4L,10L,0L,14L,6L,16L,0L,16L,12L,19L,0L,24L,10L,22L,0L,20L,14L,36L,0L,30L,16L,32L,0L,40L,16L,24L,0L,38L,19L,56L,0L,42L,24L,42L,0L,48L,22L,46L,0L,42L,20L,64L,0L,54L,36L,40L,0L,76L,30L,60L,0L,60L,32L,72L,0L,56L,40L,68L,0L,88L,24L,72L,0L,72L,38L,80L,0L,60L,56L,80L,0L,108L,42L,82L,0L,64L,42L,120L,0L,90L,48L,84L,0L,128L,46L,76L,0L,98L,42L,120L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278086Inst : IEnumerable<long>
{
public static readonly long[] Value=A278086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278086.Bytes);
public long this[int i]=>Value[i];

public static A278086Inst Instance=new A278086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278087
{
public static readonly BigInteger[] Value={ 0L,2L,16L,670L,114028L,70793904L,156188151088L,1222379234009310L,BigInteger.Parse("33967142249927729484"),BigInteger.Parse("3349734116327298689764644"),BigInteger.Parse("1172563716878509020533994874732") };
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
public class A278087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278087Inst Instance=new A278087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278088
{
public static readonly long[] Value={ 0L,2L,3L,10L,27L,76L,214L,599L,1683L,4721L,13250L,37183L,104346L,292828L,821761L,2306111L,6471639L,18161366L,50966255L,143026636L,401375754L,1126381063L,3160963987L,8870615501L,24893614638L,69858968603L,196045273658L,550161991984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278088Inst : IEnumerable<long>
{
public static readonly long[] Value=A278088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278088.Bytes);
public long this[int i]=>Value[i];

public static A278088Inst Instance=new A278088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278089
{
public static readonly long[] Value={ 0L,3L,16L,66L,351L,1758L,9033L,46159L,236245L,1208622L,6183942L,31638994L,161877345L,828222749L,4237494527L,21680576851L,110925816281L,567537279930L,2903729582172L,14856548980595L,76011571374458L,388903168793624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278089Inst : IEnumerable<long>
{
public static readonly long[] Value=A278089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278089.Bytes);
public long this[int i]=>Value[i];

public static A278089Inst Instance=new A278089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278090
{
public static readonly long[] Value={ 0L,10L,66L,670L,6285L,61123L,588464L,5678912L,54772100L,528291059L,5095556995L,49147698150L,474042768177L,4572257358586L,44100568184205L,425360912028239L,4102711750257189L,39571674020829499L,381678627996456181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278090Inst : IEnumerable<long>
{
public static readonly long[] Value=A278090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278090.Bytes);
public long this[int i]=>Value[i];

public static A278090Inst Instance=new A278090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278091
{
public static readonly long[] Value={ 0L,27L,351L,6285L,114028L,2066549L,37564017L,682015651L,12386272982L,224933023893L,4084803341700L,74180250866019L,1347117071827258L,24463718780065218L,444262411397312418L,8067828888156669904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278091Inst : IEnumerable<long>
{
public static readonly long[] Value=A278091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278091.Bytes);
public long this[int i]=>Value[i];

public static A278091Inst Instance=new A278091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278092
{
public static readonly BigInteger[] Value={ 0L,76L,1758L,61123L,2066549L,70793904L,2422349439L,82874815951L,2835664463158L,97019475542749L,3319494247111980L,113574742220392231L,3885907205045957510L,BigInteger.Parse("132954445247657663120"),BigInteger.Parse("4548972877595971502424"),BigInteger.Parse("155640932005103851366049") };
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
public class A278092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278092Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278092.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278092.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278092Inst Instance=new A278092Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278093
{
public static readonly BigInteger[] Value={ 0L,214L,9033L,588464L,37564017L,2422349439L,156188151088L,10066675051315L,648924377800150L,41828515552220496L,2696243081009380241L,BigInteger.Parse("173797341847907079579"),BigInteger.Parse("11202831237960968770998"),BigInteger.Parse("722124901221654629931597") };
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
public class A278093Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278093.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278093Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278093.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278093.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278093Inst Instance=new A278093Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278094
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,3L,3L,0L,0L,10L,16L,10L,0L,0L,27L,66L,66L,27L,0L,0L,76L,351L,670L,351L,76L,0L,0L,214L,1758L,6285L,6285L,1758L,214L,0L,0L,599L,9033L,61123L,114028L,61123L,9033L,599L,0L,0L,1683L,46159L,588464L,2066549L,2066549L,588464L,46159L,1683L,0L,0L,4721L,236245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278094Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278094.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278094Inst : IEnumerable<long>
{
public static readonly long[] Value=A278094.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278094.Bytes);
public long this[int i]=>Value[i];

public static A278094Inst Instance=new A278094Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278095
{
public static readonly long[] Value={ 0L,2L,10L,58L,334L,1910L,10910L,62314L,355898L,2032630L,11608866L,66301138L,378662314L,2162634690L,12351344662L,70541601526L,402880631914L,2300951495750L,13141306298158L,75053268849534L,428647886076278L,2448114693124250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278095Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278095.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278095Inst : IEnumerable<long>
{
public static readonly long[] Value=A278095.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278095.Bytes);
public long this[int i]=>Value[i];

public static A278095Inst Instance=new A278095Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278096
{
public static readonly BigInteger[] Value={ 0L,10L,164L,2996L,52310L,911096L,15854438L,275796494L,4797380865L,83447002829L,1451495171060L,25247589290771L,439161350548621L,7638855131006650L,132871680245748523L,2311194939381781674L,BigInteger.Parse("40201358414591770819") };
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
public class A278096Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278096.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278096Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278096.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278096.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278096Inst Instance=new A278096Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278097
{
public static readonly BigInteger[] Value={ 0L,58L,2996L,165408L,8817738L,469476315L,24968293789L,1327640457829L,70590643428412L,3753257087015148L,199557480575235203L,10610292692535605424UL,BigInteger.Parse("564139654771938009044"),BigInteger.Parse("29994793111068876818904"),BigInteger.Parse("1594795889617184754313078") };
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
public class A278097Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278097.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278097Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278097.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278097.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278097Inst Instance=new A278097Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278098
{
public static readonly BigInteger[] Value={ 0L,334L,52310L,8817738L,1432970150L,232444783982L,37664268929810L,6101731863309598L,988447879835137557L,BigInteger.Parse("160121210059950237652"),BigInteger.Parse("25938362944887864528659"),BigInteger.Parse("4201805289495732016649124") };
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
public class A278098Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278098.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278098Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278098.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278098.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278098Inst Instance=new A278098Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278099
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,10L,10L,0L,0L,58L,164L,58L,0L,0L,334L,2996L,2996L,334L,0L,0L,1910L,52310L,165408L,52310L,1910L,0L,0L,10910L,911096L,8817738L,8817738L,911096L,10910L,0L,0L,62314L,15854438L,469476315L,1432970150L,469476315L,15854438L,62314L,0L,0L,355898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278099Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278099.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278099Inst : IEnumerable<long>
{
public static readonly long[] Value=A278099.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278099.Bytes);
public long this[int i]=>Value[i];

public static A278099Inst Instance=new A278099Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278100
{
public static readonly long[] Value={ 0L,3L,6L,11L,16L,23L,31L,39L,50L,61L,75L,89L,103L,120L,139L,157L,177L,199L,219L,243L,269L,297L,323L,351L,381L,412L,444L,477L,513L,547L,584L,624L,660L,703L,745L,789L,835L,882L,928L,977L,1025L,1073L,1124L,1174L,1230L,1285L,1342L,1400L,1460L,1523L,1582L,1645L,1708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278100Inst : IEnumerable<long>
{
public static readonly long[] Value=A278100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278100.Bytes);
public long this[int i]=>Value[i];

public static A278100Inst Instance=new A278100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278101
{
public static readonly long[] Value={ 1L,4L,2L,3L,9L,8L,3L,5L,6L,7L,16L,8L,12L,5L,6L,7L,10L,11L,13L,14L,15L,25L,18L,12L,20L,24L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,36L,32L,27L,20L,24L,28L,10L,11L,13L,14L,15L,17L,19L,21L,22L,23L,26L,29L,30L,31L,33L,34L,35L,49L,32L,48L,45L,24L,28L,40L,44L,13L,14L,15L,17L,19L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278101Inst : IEnumerable<long>
{
public static readonly long[] Value=A278101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278101.Bytes);
public long this[int i]=>Value[i];

public static A278101Inst Instance=new A278101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278102
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,2L,4L,2L,3L,2L,3L,4L,2L,4L,2L,3L,2L,3L,4L,2L,5L,6L,5L,2L,2L,3L,2L,4L,4L,4L,2L,2L,3L,2L,3L,4L,4L,5L,2L,2L,2L,3L,5L,3L,5L,2L,2L,2L,3L,5L,2L,4L,4L,4L,2L,3L,4L,2L,4L,5L,4L,2L,3L,2L,2L,4L,5L,4L,3L,3L,2L,2L,3L,5L,4L,5L,2L,2L,2L,3L,2L,3L,4L,2L,2L,2L,3L,2L,3L,4L,6L,5L,2L,3L,2L,2L,4L,6L,6L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278102Inst : IEnumerable<long>
{
public static readonly long[] Value=A278102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278102.Bytes);
public long this[int i]=>Value[i];

public static A278102Inst Instance=new A278102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278103
{
public static readonly long[] Value={ 1L,4L,2L,9L,8L,3L,16L,8L,25L,18L,12L,36L,32L,27L,20L,49L,32L,64L,50L,48L,45L,81L,72L,100L,98L,75L,121L,98L,144L,128L,108L,169L,162L,147L,125L,196L,162L,225L,200L,192L,180L,256L,242L,289L,288L,243L,324L,288L,361L,338L,300L,400L,392L,363L,320L,441L,392L,484L,450L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278103Inst : IEnumerable<long>
{
public static readonly long[] Value=A278103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278103.Bytes);
public long this[int i]=>Value[i];

public static A278103Inst Instance=new A278103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278104
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,2L,5L,3L,2L,6L,4L,3L,2L,7L,4L,8L,5L,4L,3L,9L,6L,10L,7L,5L,11L,7L,12L,8L,6L,13L,9L,7L,5L,14L,9L,15L,10L,8L,6L,16L,11L,17L,12L,9L,18L,12L,19L,13L,10L,20L,14L,11L,8L,21L,14L,22L,15L,12L,9L,8L,23L,16L,13L,10L,9L,8L,24L,16L,13L,10L,9L,25L,17L,26L,18L,27L,19L,15L,28L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278104Inst : IEnumerable<long>
{
public static readonly long[] Value=A278104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278104.Bytes);
public long this[int i]=>Value[i];

public static A278104Inst Instance=new A278104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278105
{
public static readonly long[] Value={ 3L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278105Inst : IEnumerable<long>
{
public static readonly long[] Value=A278105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278105.Bytes);
public long this[int i]=>Value[i];

public static A278105Inst Instance=new A278105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278106
{
public static readonly long[] Value={ 1L,2L,3L,6L,22L,23L,177L,129L,4954L,58976L,288436L,238773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278106Inst : IEnumerable<long>
{
public static readonly long[] Value=A278106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278106.Bytes);
public long this[int i]=>Value[i];

public static A278106Inst Instance=new A278106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278107
{
public static readonly long[] Value={ 1L,49L,5L,21L,10L,174L,27L,223L,1656L,3901L,1286L,1847L,5095L,3117L,5678L,1727L,14844L,23678L,10986L,33868L,41241L,42794L,50451L,35301L,39546L,206241L,10561L,89600L,50075L,87273L,75922L,142760L,3493L,236213L,277242L,805287L,619149L,333339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278107Inst : IEnumerable<long>
{
public static readonly long[] Value=A278107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278107.Bytes);
public long this[int i]=>Value[i];

public static A278107Inst Instance=new A278107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278108
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,5L,1L,6L,1L,7L,1L,8L,2L,9L,2L,1L,10L,2L,1L,11L,2L,1L,12L,3L,1L,13L,3L,1L,14L,3L,1L,15L,3L,1L,16L,4L,1L,1L,17L,4L,1L,1L,18L,4L,2L,1L,19L,4L,2L,1L,20L,5L,2L,1L,21L,5L,2L,1L,22L,5L,2L,1L,23L,5L,2L,1L,24L,6L,2L,1L,25L,6L,2L,1L,1L,26L,6L,2L,1L,1L,27L,6L,3L,1L,1L,28L,7L,3L,1L,1L,29L,7L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278108Inst : IEnumerable<long>
{
public static readonly long[] Value=A278108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278108.Bytes);
public long this[int i]=>Value[i];

public static A278108Inst Instance=new A278108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278109
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,3L,1L,3L,1L,4L,1L,4L,1L,4L,2L,4L,2L,5L,2L,5L,2L,5L,2L,5L,2L,6L,2L,6L,2L,1L,6L,2L,1L,6L,3L,1L,7L,3L,1L,7L,3L,1L,7L,3L,1L,7L,3L,1L,8L,3L,1L,8L,3L,1L,8L,3L,1L,8L,3L,1L,9L,4L,1L,9L,4L,1L,9L,4L,1L,9L,4L,1L,10L,4L,1L,10L,4L,1L,10L,4L,1L,10L,4L,1L,11L,4L,1L,11L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278109Inst : IEnumerable<long>
{
public static readonly long[] Value=A278109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278109.Bytes);
public long this[int i]=>Value[i];

public static A278109Inst Instance=new A278109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278110
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,4L,12L,12L,12L,24L,24L,24L,24L,48L,48L,144L,144L,288L,288L,288L,288L,576L,2880L,2880L,8640L,17280L,17280L,17280L,17280L,34560L,34560L,34560L,34560L,207360L,207360L,207360L,207360L,414720L,414720L,414720L,414720L,829440L,2488320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278110Inst : IEnumerable<long>
{
public static readonly long[] Value=A278110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278110.Bytes);
public long this[int i]=>Value[i];

public static A278110Inst Instance=new A278110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278111
{
public static readonly long[] Value={ 2L,1L,8L,4L,2L,2L,1L,1L,1L,1L,18L,9L,6L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,32L,16L,10L,8L,6L,5L,4L,4L,3L,3L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,50L,25L,16L,12L,10L,8L,7L,6L,5L,5L,4L,4L,3L,3L,3L,3L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278111Inst : IEnumerable<long>
{
public static readonly long[] Value=A278111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278111.Bytes);
public long this[int i]=>Value[i];

public static A278111Inst Instance=new A278111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278112
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,5L,4L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,5L,4L,3L,3L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278112Inst : IEnumerable<long>
{
public static readonly long[] Value=A278112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278112.Bytes);
public long this[int i]=>Value[i];

public static A278112Inst Instance=new A278112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278113
{
public static readonly long[] Value={ 1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,5L,4L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,6L,4L,3L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,5L,4L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,8L,6L,5L,4L,3L,3L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278113Inst : IEnumerable<long>
{
public static readonly long[] Value=A278113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278113.Bytes);
public long this[int i]=>Value[i];

public static A278113Inst Instance=new A278113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278114
{
public static readonly long[] Value={ 1L,4L,7L,11L,15L,20L,25L,31L,37L,46L,53L,61L,68L,77L,87L,97L,106L,118L,128L,139L,152L,163L,177L,190L,204L,217L,231L,247L,263L,278L,293L,309L,326L,344L,363L,377L,399L,418L,436L,452L,474L,492L,516L,536L,558L,580L,600L,623L,647L,669L,692L,713L,738L,765L,789L,816L,842L,867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278114Inst : IEnumerable<long>
{
public static readonly long[] Value=A278114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278114.Bytes);
public long this[int i]=>Value[i];

public static A278114Inst Instance=new A278114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278115
{
public static readonly long[] Value={ 2L,8L,3L,5L,7L,18L,12L,5L,7L,11L,13L,17L,32L,27L,20L,28L,11L,13L,17L,19L,23L,29L,31L,50L,48L,45L,28L,44L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,72L,48L,45L,63L,44L,52L,68L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,98L,75L,80L,63L,44L,52L,68L,76L,92L,29L,31L,37L,41L,43L,47L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278115Inst : IEnumerable<long>
{
public static readonly long[] Value=A278115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278115.Bytes);
public long this[int i]=>Value[i];

public static A278115Inst Instance=new A278115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278116
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,3L,2L,2L,5L,4L,4L,2L,2L,3L,3L,5L,3L,2L,2L,4L,3L,3L,2L,2L,3L,4L,6L,6L,2L,3L,4L,3L,3L,2L,2L,3L,5L,4L,4L,2L,4L,3L,4L,3L,2L,2L,3L,4L,3L,2L,2L,4L,3L,4L,3L,2L,2L,3L,4L,3L,2L,2L,3L,3L,5L,3L,2L,2L,4L,5L,4L,2L,2L,3L,3L,4L,3L,2L,3L,4L,7L,5L,2L,2L,3L,4L,2L,2L,2L,3L,5L,5L,5L,2L,2L,3L,4L,3L,2L,2L,4L,5L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278116Inst : IEnumerable<long>
{
public static readonly long[] Value=A278116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278116.Bytes);
public long this[int i]=>Value[i];

public static A278116Inst Instance=new A278116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278117
{
public static readonly long[] Value={ 2L,8L,3L,18L,12L,5L,32L,27L,20L,50L,48L,45L,28L,72L,48L,45L,98L,75L,128L,108L,162L,147L,125L,112L,99L,200L,192L,180L,175L,242L,192L,180L,175L,288L,243L,338L,300L,392L,363L,320L,450L,432L,405L,512L,507L,500L,448L,396L,578L,507L,500L,648L,588L,722L,675L,800L,768L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278117Inst : IEnumerable<long>
{
public static readonly long[] Value=A278117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278117.Bytes);
public long this[int i]=>Value[i];

public static A278117Inst Instance=new A278117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278118
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,2L,5L,4L,3L,2L,6L,4L,3L,7L,5L,8L,6L,9L,7L,5L,4L,3L,10L,8L,6L,5L,11L,8L,6L,5L,12L,9L,13L,10L,14L,11L,8L,15L,12L,9L,16L,13L,10L,8L,6L,17L,13L,10L,18L,14L,19L,15L,20L,16L,12L,10L,21L,17L,13L,22L,17L,13L,23L,18L,24L,19L,25L,20L,15L,26L,21L,16L,13L,27L,22L,17L,14L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278118Inst : IEnumerable<long>
{
public static readonly long[] Value=A278118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278118.Bytes);
public long this[int i]=>Value[i];

public static A278118Inst Instance=new A278118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278119
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,27L,81L,163L,3451L,7372L,82177L,3716L,2769544L,25899347L,357567610L,4229297109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278119Inst : IEnumerable<long>
{
public static readonly long[] Value=A278119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278119.Bytes);
public long this[int i]=>Value[i];

public static A278119Inst Instance=new A278119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278120
{
public static readonly BigInteger[] Value={ -1L,1L,5L,25L,1033L,15745L,1599895L,12116675L,1519810267L,5730215335L,2762191322225L,155865304045375L,275016025098532093L,129172331662700995L,BigInteger.Parse("358829725148742321475"),BigInteger.Parse("524011363178245785875"),BigInteger.Parse("10072731258491333905209253"),BigInteger.Parse("1181576300858987307102335"),BigInteger.Parse("68622390512340213600239902775") };
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
public class A278120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278120Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278120.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278120.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278120Inst Instance=new A278120Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278121
{
public static readonly BigInteger[] Value={ 1L,12L,144L,864L,27648L,248832L,11943936L,35831808L,1528823808L,1719926784L,220150628352L,2972033482752L,1141260857376768L,106993205379072L,54780521154084864L,13695130288521216L,BigInteger.Parse("42071440246337175552"),739537035580145664L,BigInteger.Parse("6058287395472553279488") };
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
public class A278121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278121Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278121.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278121.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278121Inst Instance=new A278121Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278122
{
public static readonly long[] Value={ 160L,568L,1384L,3016L,6280L,12808L,25864L,51976L,104200L,208648L,417544L,835336L,1670920L,3342088L,6684424L,13369096L,26738440L,53477128L,106954504L,213909256L,427818760L,855637768L,1711275784L,3422551816L,6845103880L,13690208008L,27380416264L,54760832776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278122Inst : IEnumerable<long>
{
public static readonly long[] Value=A278122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278122.Bytes);
public long this[int i]=>Value[i];

public static A278122Inst Instance=new A278122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278123
{
public static readonly long[] Value={ 194L,688L,1676L,3652L,7604L,15508L,31316L,62932L,126164L,252628L,505556L,1011412L,2023124L,4046548L,8093396L,16187092L,32374484L,64749268L,129498836L,258997972L,517996244L,1035992788L,2071985876L,4143972052L,8287944404L,16575889108L,33151778516L,66303557332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278123Inst : IEnumerable<long>
{
public static readonly long[] Value=A278123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278123.Bytes);
public long this[int i]=>Value[i];

public static A278123Inst Instance=new A278123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278124
{
public static readonly long[] Value={ -4L,168L,512L,1200L,2576L,5328L,10832L,21840L,43856L,87888L,175952L,352080L,704336L,1408848L,2817872L,5635920L,11272016L,22544208L,45088592L,90177360L,180354896L,360709968L,721420112L,1442840400L,2885680976L,5771362128L,11542724432L,23085449040L,46170898256L,92341796688L,184683593552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278124Inst : IEnumerable<long>
{
public static readonly long[] Value=A278124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278124.Bytes);
public long this[int i]=>Value[i];

public static A278124Inst Instance=new A278124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278125
{
public static readonly long[] Value={ -10L,215L,665L,1565L,3365L,6965L,14165L,28565L,57365L,114965L,230165L,460565L,921365L,1842965L,3686165L,7372565L,14745365L,29490965L,58982165L,117964565L,235929365L,471858965L,943718165L,1887436565L,3774873365L,7549746965L,15099494165L,30198988565L,60397977365L,120795954965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278125Inst : IEnumerable<long>
{
public static readonly long[] Value=A278125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278125.Bytes);
public long this[int i]=>Value[i];

public static A278125Inst Instance=new A278125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278126
{
public static readonly long[] Value={ 66L,144L,222L,300L,378L,456L,534L,612L,690L,768L,846L,924L,1002L,1080L,1158L,1236L,1314L,1392L,1470L,1548L,1626L,1704L,1782L,1860L,1938L,2016L,2094L,2172L,2250L,2328L,2406L,2484L,2562L,2640L,2718L,2796L,2874L,2952L,3030L,3108L,3186L,3264L,3342L,3420L,3498L,3576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278126Inst : IEnumerable<long>
{
public static readonly long[] Value=A278126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278126.Bytes);
public long this[int i]=>Value[i];

public static A278126Inst Instance=new A278126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278127
{
public static readonly long[] Value={ 71L,170L,269L,368L,467L,566L,665L,764L,863L,962L,1061L,1160L,1259L,1358L,1457L,1556L,1655L,1754L,1853L,1952L,2051L,2150L,2249L,2348L,2447L,2546L,2645L,2744L,2843L,2942L,3041L,3140L,3239L,3338L,3437L,3536L,3635L,3734L,3833L,3932L,4031L,4130L,4229L,4328L,4427L,4526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278127Inst : IEnumerable<long>
{
public static readonly long[] Value=A278127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278127.Bytes);
public long this[int i]=>Value[i];

public static A278127Inst Instance=new A278127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278128
{
public static readonly long[] Value={ 132L,420L,996L,2148L,4452L,9060L,18276L,36708L,73572L,147300L,294756L,589668L,1179492L,2359140L,4718436L,9437028L,18874212L,37748580L,75497316L,150994788L,301989732L,603979620L,1207959396L,2415918948L,4831838052L,9663676260L,19327352676L,38654705508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278128Inst : IEnumerable<long>
{
public static readonly long[] Value=A278128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278128.Bytes);
public long this[int i]=>Value[i];

public static A278128Inst Instance=new A278128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278129
{
public static readonly long[] Value={ 160L,508L,1204L,2596L,5380L,10948L,22084L,44356L,88900L,177988L,356164L,712516L,1425220L,2850628L,5701444L,11403076L,22806340L,45612868L,91225924L,182452036L,364904260L,729808708L,1459617604L,2919235396L,5838470980L,11676942148L,23353884484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278129Inst : IEnumerable<long>
{
public static readonly long[] Value=A278129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278129.Bytes);
public long this[int i]=>Value[i];

public static A278129Inst Instance=new A278129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278130
{
public static readonly long[] Value={ 270L,762L,1746L,3714L,7650L,15522L,31266L,62754L,125730L,251682L,503586L,1007394L,2015010L,4030242L,8060706L,16121634L,32243490L,64487202L,128974626L,257949474L,515899170L,1031798562L,2063597346L,4127194914L,8254390050L,16508780322L,33017560866L,66035121954L,132070244130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278130Inst : IEnumerable<long>
{
public static readonly long[] Value=A278130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278130.Bytes);
public long this[int i]=>Value[i];

public static A278130Inst Instance=new A278130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278131
{
public static readonly long[] Value={ 318L,909L,2091L,4455L,9183L,18639L,37551L,75375L,151023L,302319L,604911L,1210095L,2420463L,4841199L,9682671L,19365615L,38731503L,77463279L,154926831L,309853935L,619708143L,1239416559L,2478833391L,4957667055L,9915334383L,19830669039L,39661338351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278131Inst : IEnumerable<long>
{
public static readonly long[] Value=A278131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278131.Bytes);
public long this[int i]=>Value[i];

public static A278131Inst Instance=new A278131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278132
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,6L,5L,1L,1L,11L,15L,7L,1L,1L,20L,38L,28L,9L,1L,1L,36L,92L,89L,45L,11L,1L,1L,64L,219L,258L,172L,66L,13L,1L,1L,113L,513L,721L,577L,295L,91L,15L,1L,1L,199L,1184L,1975L,1817L,1125L,466L,120L,17L,1L,1L,350L,2702L,5326L,5534L,3932L,1994L,693L,153L,19L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278132Inst : IEnumerable<long>
{
public static readonly long[] Value=A278132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278132.Bytes);
public long this[int i]=>Value[i];

public static A278132Inst Instance=new A278132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278133
{
public static readonly long[] Value={ 1L,3L,10L,32L,101L,318L,1003L,3173L,10071L,32071L,102453L,328260L,1054620L,3396757L,10965653L,35475159L,114989969L,373400210L,1214529314L,3956450250L,12906762704L,42159475998L,137877383739L,451403471067L,1479329370617L,4852295325254L,15928202158814L,52321416289743L,171966242037941L,565480887258368L,1860228812665716L,6121446895971437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278133Inst : IEnumerable<long>
{
public static readonly long[] Value=A278133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278133.Bytes);
public long this[int i]=>Value[i];

public static A278133Inst Instance=new A278133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278134
{
public static readonly long[] Value={ 1L,2L,5L,13L,34L,1L,89L,7L,1L,233L,34L,7L,1L,610L,141L,35L,7L,1L,1597L,534L,152L,36L,7L,1L,4181L,1905L,611L,163L,37L,7L,1L,10946L,6512L,2338L,689L,174L,38L,7L,1L,28657L,21557L,8641L,2787L,768L,185L,39L,7L,1L,75025L,69593L,31104L,10921L,3252L,848L,196L,40L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278134Inst : IEnumerable<long>
{
public static readonly long[] Value=A278134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278134.Bytes);
public long this[int i]=>Value[i];

public static A278134Inst Instance=new A278134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278135
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,9L,51L,236L,979L,3805L,14190L,51488L,183333L,644121L,2241127L,7741378L,26593899L,90971184L,310159487L,1054693058L,3578948942L,12124108632L,41015411703L,138597840864L,467913141789L,1578497031981L,5321685955902L,17931990439148L,60397664457791L,203355625940891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278135Inst : IEnumerable<long>
{
public static readonly long[] Value=A278135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278135.Bytes);
public long this[int i]=>Value[i];

public static A278135Inst Instance=new A278135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278136
{
public static readonly long[] Value={ 1L,2L,1L,3L,1L,5L,2L,1L,8L,4L,1L,13L,6L,2L,1L,21L,10L,5L,1L,34L,17L,7L,2L,1L,55L,27L,12L,6L,1L,89L,44L,22L,8L,2L,1L,144L,72L,34L,14L,7L,1L,233L,116L,56L,28L,9L,2L,1L,377L,188L,94L,42L,16L,8L,1L,610L,305L,150L,70L,35L,10L,2L,1L,987L,493L,244L,122L,51L,18L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278136Inst : IEnumerable<long>
{
public static readonly long[] Value=A278136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278136.Bytes);
public long this[int i]=>Value[i];

public static A278136Inst Instance=new A278136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278137
{
public static readonly long[] Value={ 1L,3L,4L,8L,13L,22L,37L,61L,101L,166L,272L,445L,726L,1183L,1925L,3129L,5082L,8248L,13379L,21692L,35157L,56963L,92271L,149434L,241970L,391755L,634190L,1026561L,1661567L,2689209L,4352208L,7043314L,11398035L,18444678L,29847123L,48297643L,78152505L,126460400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278137Inst : IEnumerable<long>
{
public static readonly long[] Value=A278137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278137.Bytes);
public long this[int i]=>Value[i];

public static A278137Inst Instance=new A278137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278138
{
public static readonly long[] Value={ 3L,5L,17L,197L,1427L,1667L,2087L,4157L,4217L,8387L,8597L,10037L,11117L,11717L,15287L,17417L,20147L,25847L,29207L,33347L,33827L,34847L,35897L,36527L,47657L,56237L,57527L,60257L,63197L,63587L,69497L,75167L,77477L,89657L,93887L,96797L,99347L,99527L,100547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278138Inst : IEnumerable<long>
{
public static readonly long[] Value=A278138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278138.Bytes);
public long this[int i]=>Value[i];

public static A278138Inst Instance=new A278138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278139
{
public static readonly long[] Value={ 2L,3L,13L,41L,107L,227L,503L,881L,1409L,2039L,2819L,3947L,5273L,6869L,8699L,11549L,15377L,19937L,24593L,30809L,38069L,47939L,58379L,69257L,82787L,98897L,115733L,133499L,152027L,172127L,192833L,218711L,247391L,279269L,315047L,355517L,399473L,444623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278139Inst : IEnumerable<long>
{
public static readonly long[] Value=A278139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278139.Bytes);
public long this[int i]=>Value[i];

public static A278139Inst Instance=new A278139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278140
{
public static readonly BigInteger[] Value={ 1L,27L,29835L,914095L,30845936835L,966228811317L,1005862016542383L,31766194302634935L,BigInteger.Parse("33673399154070922824435"),BigInteger.Parse("1067731823813513897297545"),BigInteger.Parse("1101976780048026596318593989"),BigInteger.Parse("35023352480137647877041347193"),BigInteger.Parse("1154564397329013014999165944225975") };
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
public class A278140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278140Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278140.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278140.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278140Inst Instance=new A278140Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278141
{
public static readonly BigInteger[] Value={ 1L,265L,1096065L,281858265L,18519577975665L,4748934018906441L,BigInteger.Parse("19474365987782658225"),BigInteger.Parse("4989739877102195271225"),BigInteger.Parse("5235591401647346852339166225"),BigInteger.Parse("1341015791319444602368386319225"),BigInteger.Parse("5495144390631448939048252704196225"),BigInteger.Parse("1407253983507773608409169421000239225"),BigInteger.Parse("92253220393640211712365553562313715740225") };
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
public class A278141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278141Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278141.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278141.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278141Inst Instance=new A278141Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278142
{
public static readonly BigInteger[] Value={ 1L,256L,1048576L,268435456L,17592186044416L,4503599627370496L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("4722366482869645213696"),BigInteger.Parse("4951760157141521099596496896"),BigInteger.Parse("1267650600228229401496703205376"),BigInteger.Parse("5192296858534827628530496329220096"),BigInteger.Parse("1329227995784915872903807060280344576"),BigInteger.Parse("87112285931760246646623899502532662132736") };
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
public class A278142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278142Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278142.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278142.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278142Inst Instance=new A278142Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278143
{
public static readonly BigInteger[] Value={ 1L,7L,475L,3675L,1924475L,15145753L,981654583L,7774283075L,32109931838075L,255083626080725L,16423892777415669L,130705503226766013L,BigInteger.Parse("67230186897380845975"),BigInteger.Parse("535644114907108845925"),BigInteger.Parse("34407319668610517498575"),BigInteger.Parse("274347338677567001587475") };
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
public class A278143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278143Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278143.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278143.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278143Inst Instance=new A278143Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278144
{
public static readonly long[] Value={ 9L,0L,9L,1L,7L,2L,7L,9L,4L,5L,4L,6L,9L,2L,9L,7L,0L,0L,7L,3L,9L,7L,7L,8L,8L,5L,4L,2L,8L,2L,6L,5L,1L,2L,2L,5L,7L,2L,0L,5L,2L,7L,2L,9L,9L,5L,9L,2L,2L,0L,5L,2L,2L,8L,3L,8L,6L,4L,1L,4L,0L,2L,1L,8L,3L,7L,2L,2L,3L,6L,4L,8L,1L,1L,1L,2L,7L,1L,8L,9L,9L,3L,2L,3L,2L,5L,6L,7L,4L,0L,5L,7L,0L,5L,1L,3L,7L,9L,5L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278144Inst : IEnumerable<long>
{
public static readonly long[] Value=A278144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278144.Bytes);
public long this[int i]=>Value[i];

public static A278144Inst Instance=new A278144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278145
{
public static readonly BigInteger[] Value={ 1L,8L,64L,1024L,16384L,131072L,1048576L,33554432L,1073741824L,8589934592L,68719476736L,1099511627776L,17592186044416L,140737488355328L,1125899906842624L,72057594037927936L,4611686018427387904L,BigInteger.Parse("36893488147419103232"),BigInteger.Parse("295147905179352825856"),BigInteger.Parse("4722366482869645213696") };
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
public class A278145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278145Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278145.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278145.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278145Inst Instance=new A278145Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278146
{
public static readonly long[] Value={ 1L,0L,6L,2L,6L,7L,9L,8L,9L,9L,9L,1L,6L,8L,4L,3L,6L,5L,1L,1L,8L,2L,4L,9L,0L,1L,9L,5L,1L,0L,4L,5L,1L,2L,0L,9L,1L,0L,6L,2L,5L,4L,9L,9L,1L,8L,3L,2L,6L,0L,2L,0L,6L,9L,4L,2L,4L,1L,0L,5L,4L,8L,7L,4L,0L,7L,3L,3L,9L,6L,1L,1L,1L,2L,7L,1L,8L,2L,2L,8L,3L,6L,7L,4L,0L,2L,9L,9L,0L,9L,3L,7L,2L,0L,4L,0L,6L,3L,7L,4L,5L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278146Inst : IEnumerable<long>
{
public static readonly long[] Value=A278146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278146.Bytes);
public long this[int i]=>Value[i];

public static A278146Inst Instance=new A278146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278147
{
public static readonly long[] Value={ 8L,0L,18L,19L,0L,32L,0L,33L,0L,50L,34L,0L,0L,0L,72L,0L,52L,0L,73L,0L,98L,53L,0L,74L,0L,99L,0L,128L,0L,75L,0L,100L,0L,0L,0L,162L,76L,0L,101L,0L,0L,0L,163L,0L,200L,0L,102L,0L,131L,0L,164L,0L,201L,0L,242L,103L,0L,0L,0L,165L,0L,202L,0L,0L,0L,288L,0L,133L,0L,166L,0L,203L,0L,244L,0L,289L,0L,338L,134L,0L,167L,0L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278147Inst : IEnumerable<long>
{
public static readonly long[] Value=A278147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278147.Bytes);
public long this[int i]=>Value[i];

public static A278147Inst Instance=new A278147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278148
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,3L,1L,2L,2L,3L,5L,4L,1L,2L,2L,3L,3L,4L,5L,5L,7L,5L,1L,2L,2L,2L,3L,3L,4L,5L,5L,7L,9L,6L,1L,2L,2L,2L,3L,3L,3L,5L,4L,5L,7L,5L,7L,8L,7L,9L,11L,7L,1L,2L,2L,2L,2L,3L,3L,4L,5L,5L,4L,5L,7L,8L,7L,7L,8L,7L,9L,11L,13L,8L,1L,2L,2L,2L,2L,3L,3L,3L,3L,4L,5L,5L,7L,5L,6L,9L,7L,8L,7L,7L,8L,10L,11L,9L,11L,13L,15L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278148Inst : IEnumerable<long>
{
public static readonly long[] Value=A278148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278148.Bytes);
public long this[int i]=>Value[i];

public static A278148Inst Instance=new A278148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278149
{
public static readonly long[] Value={ 2L,3L,3L,4L,5L,5L,4L,5L,7L,5L,5L,7L,5L,6L,9L,7L,8L,7L,7L,8L,7L,9L,6L,7L,11L,9L,7L,8L,7L,7L,8L,7L,9L,11L,7L,8L,13L,11L,9L,11L,10L,8L,12L,9L,9L,12L,8L,10L,11L,9L,11L,13L,8L,9L,15L,13L,11L,9L,11L,10L,11L,13L,12L,9L,9L,12L,13L,11L,10L,11L,9L,11L,13L,15L,9L,10L,17L,15L,13L,11L,14L,13L,11L,10L,11L,13L,12L,16L,11L,11L,16L,12L,13L,11L,10L,11L,13L,14L,11L,13L,15L,17L,10L,11L,19L,17L,15L,13L,11L,14L,13L,11L,17L,13L,11L,13L,12L,16L,11L,11L,16L,12L,13L,11L,13L,17L,11L,13L,14L,11L,13L,15L,17L,19L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278149Inst : IEnumerable<long>
{
public static readonly long[] Value=A278149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278149.Bytes);
public long this[int i]=>Value[i];

public static A278149Inst Instance=new A278149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278150
{
public static readonly BigInteger[] Value={ 0L,2L,42L,3382L,1118946L,1459438050L,7332741364328L,143431562727241070L,BigInteger.Parse("10922269761078538034876"),BigInteger.Parse("3236762187328159003256067178"),BigInteger.Parse("3732763619664688373840578545273092") };
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
public class A278150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278150Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278150.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278150.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278150Inst Instance=new A278150Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278151
{
public static readonly long[] Value={ 0L,2L,7L,22L,75L,254L,859L,2906L,9831L,33258L,112511L,380622L,1287635L,4356038L,14736371L,49852786L,168650767L,570541458L,1930127927L,6529576006L,22089397403L,74727896142L,252802661835L,855225279050L,2893206395127L,9787647126266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278151Inst : IEnumerable<long>
{
public static readonly long[] Value=A278151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278151.Bytes);
public long this[int i]=>Value[i];

public static A278151Inst Instance=new A278151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278152
{
public static readonly long[] Value={ 0L,7L,42L,268L,1759L,11675L,77102L,509336L,3365082L,22232537L,146885095L,970436014L,6411449580L,42358984701L,279856142429L,1848945655959L,12215561936959L,80705429566515L,533202352449825L,3522746241343707L,23273980363926953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278152Inst : IEnumerable<long>
{
public static readonly long[] Value=A278152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278152.Bytes);
public long this[int i]=>Value[i];

public static A278152Inst Instance=new A278152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278153
{
public static readonly long[] Value={ 0L,22L,268L,3382L,43876L,571214L,7404889L,96014730L,1245182813L,16148180576L,209415726220L,2715786209858L,35219410286723L,456739471814363L,5923180934385869L,76814190061408485L,996157278817145623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278153Inst : IEnumerable<long>
{
public static readonly long[] Value=A278153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278153.Bytes);
public long this[int i]=>Value[i];

public static A278153Inst Instance=new A278153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278154
{
public static readonly BigInteger[] Value={ 0L,75L,1759L,43876L,1118946L,28772962L,736017223L,18830978857L,481877272697L,12331031245847L,315541549100809L,8074473377302998L,206619882344006745L,5287251693347146722L,BigInteger.Parse("135296899872399464823"),BigInteger.Parse("3462148631985469379478") };
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
public class A278154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278154Inst Instance=new A278154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278155
{
public static readonly BigInteger[] Value={ 0L,254L,11675L,571214L,28772962L,1459438050L,73654449669L,3717851037151L,187699707259842L,9476189368415446L,478407914745643442L,BigInteger.Parse("24152577356822109201"),BigInteger.Parse("1219351305393469653908"),BigInteger.Parse("61559372518202872739319") };
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
public class A278155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278155Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278155.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278155.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278155Inst Instance=new A278155Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278156
{
public static readonly BigInteger[] Value={ 0L,859L,77102L,7404889L,736017223L,73654449669L,7332741364328L,730168696119876L,72720692813101842L,7242547316810715720L,BigInteger.Parse("721305315619197154090"),BigInteger.Parse("71836875811771995363258"),BigInteger.Parse("7154445488017757277489605") };
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
public class A278156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278156Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278156.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278156.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278156Inst Instance=new A278156Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278157
{
public static readonly long[] Value={ 0L,0L,0L,0L,2L,0L,0L,7L,7L,0L,0L,22L,42L,22L,0L,0L,75L,268L,268L,75L,0L,0L,254L,1759L,3382L,1759L,254L,0L,0L,859L,11675L,43876L,43876L,11675L,859L,0L,0L,2906L,77102L,571214L,1118946L,571214L,77102L,2906L,0L,0L,9831L,509336L,7404889L,28772962L,28772962L,7404889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278157Inst : IEnumerable<long>
{
public static readonly long[] Value=A278157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278157.Bytes);
public long this[int i]=>Value[i];

public static A278157Inst Instance=new A278157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278158
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,0L,12L,2L,6L,1L,6L,2L,24L,4L,2L,6L,60L,6L,60L,6L,6L,6L,6L,12L,6L,24L,210L,24L,30L,4L,420L,30L,30L,30L,20160L,24L,9240L,420L,12L,30L,60060L,30L,420L,30L,240L,30L,420L,210L,27720L,30L,60L,720L,420L,420L,6L,720L,2310L,30L,210L,30L,2042040L,4620L,24L,210L,7680L,60L,60060L,210L,6L,30240L,510510L,2160L,6486480L,840L,2310L,9240L,9240L,420L,60060L,210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278158Inst : IEnumerable<long>
{
public static readonly long[] Value=A278158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278158.Bytes);
public long this[int i]=>Value[i];

public static A278158Inst Instance=new A278158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278159
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,4L,6L,30L,2L,4L,4L,12L,6L,12L,30L,210L,2L,4L,4L,12L,4L,8L,12L,60L,6L,12L,12L,36L,30L,60L,210L,2310L,2L,4L,4L,12L,4L,8L,12L,60L,4L,8L,8L,24L,12L,24L,60L,420L,6L,12L,12L,36L,12L,24L,36L,180L,30L,60L,60L,180L,210L,420L,2310L,30030L,2L,4L,4L,12L,4L,8L,12L,60L,4L,8L,8L,24L,12L,24L,60L,420L,4L,8L,8L,24L,8L,16L,24L,120L,12L,24L,24L,72L,60L,120L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278159Inst : IEnumerable<long>
{
public static readonly long[] Value=A278159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278159.Bytes);
public long this[int i]=>Value[i];

public static A278159Inst Instance=new A278159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278160
{
public static readonly long[] Value={ 2L,8L,6L,24L,6L,48L,12L,48L,12L,120L,6L,120L,30L,96L,30L,288L,6L,360L,30L,120L,30L,240L,12L,240L,72L,120L,24L,840L,6L,960L,30L,192L,210L,360L,30L,360L,30L,240L,30L,1680L,6L,840L,60L,120L,60L,480L,12L,1440L,60L,360L,30L,1080L,30L,2160L,210L,240L,30L,840L,6L,840L,60L,384L,420L,1920L,30L,840L,30L,840L,30L,5040L,6L,720L,60L,120L,420L,840L,30L,3360L,48L,480L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278160Inst : IEnumerable<long>
{
public static readonly long[] Value=A278160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278160.Bytes);
public long this[int i]=>Value[i];

public static A278160Inst Instance=new A278160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278161
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,4L,2L,2L,3L,3L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,2L,2L,2L,4L,2L,2L,4L,4L,2L,2L,2L,4L,3L,3L,3L,4L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,2L,2L,3L,1L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,4L,2L,2L,3L,3L,2L,2L,2L,4L,2L,2L,4L,4L,2L,2L,2L,4L,4L,4L,4L,6L,2L,2L,2L,4L,2L,2L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278161Inst : IEnumerable<long>
{
public static readonly long[] Value=A278161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278161.Bytes);
public long this[int i]=>Value[i];

public static A278161Inst Instance=new A278161Inst();

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