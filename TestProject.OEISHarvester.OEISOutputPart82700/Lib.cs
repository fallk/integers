using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A102341
{
public static readonly BigInteger[] Value={ 12L,120L,1848L,25080L,351780L,4890480L,68149872L,949077360L,13219419708L,184120982760L,2564481115560L,35718589344360L,497495864091732L,6929223155685600L,96511629630137568L,1344233586759971040L,BigInteger.Parse("18722758603319903340") };
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
public class A102341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102341Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102341.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102341Inst Instance=new A102341Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102342
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,9L,10L,12L,13L,15L,16L,19L,22L,25L,27L,30L,31L,33L,34L,36L,39L,45L,46L,48L,54L,55L,57L,58L,60L,61L,64L,67L,72L,75L,78L,79L,82L,85L,87L,88L,90L,93L,94L,96L,97L,99L,108L,109L,111L,118L,121L,123L,127L,129L,130L,132L,136L,142L,144L,148L,156L,159L,160L,162L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102342Inst : IEnumerable<long>
{
public static readonly long[] Value=A102342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102342.Bytes);
public long this[int i]=>Value[i];

public static A102342Inst Instance=new A102342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102343
{
public static readonly long[] Value={ 1L,2L,11L,19L,22L,26L,41L,43L,44L,47L,50L,53L,65L,67L,68L,71L,76L,79L,80L,83L,94L,97L,107L,110L,113L,115L,122L,124L,125L,131L,134L,136L,137L,145L,146L,152L,155L,158L,167L,169L,170L,173L,176L,181L,184L,199L,202L,211L,212L,226L,229L,232L,233L,250L,253L,254L,268L,272L,274L,281L,284L,286L,292L,295L,298L,299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102343Inst : IEnumerable<long>
{
public static readonly long[] Value=A102343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102343.Bytes);
public long this[int i]=>Value[i];

public static A102343Inst Instance=new A102343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102344
{
public static readonly BigInteger[] Value={ 2L,7L,97L,1351L,18817L,262087L,3650401L,50843527L,708158977L,9863382151L,137379191137L,1913445293767L,26650854921601L,371198523608647L,5170128475599457L,72010600134783751L,1002978273411373057L,13969685227624439047UL,BigInteger.Parse("194572614913330773601"),BigInteger.Parse("2710046923559006391367") };
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
public class A102344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102344Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102344.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102344Inst Instance=new A102344Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102345
{
public static readonly long[] Value={ 2L,2L,10L,26L,82L,242L,730L,2186L,6562L,19682L,59050L,177146L,531442L,1594322L,4782970L,14348906L,43046722L,129140162L,387420490L,1162261466L,3486784402L,10460353202L,31381059610L,94143178826L,282429536482L,847288609442L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102345Inst : IEnumerable<long>
{
public static readonly long[] Value=A102345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102345.Bytes);
public long this[int i]=>Value[i];

public static A102345Inst Instance=new A102345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102346
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,30L,46L,69L,101L,146L,208L,293L,408L,563L,769L,1042L,1401L,1871L,2482L,3273L,4291L,5596L,7261L,9378L,12057L,15437L,19684L,25005L,31648L,39919L,50184L,62890L,78573L,97883L,121597L,150653L,186169L,229487L,282204L,346230L,423831L,517706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102346Inst : IEnumerable<long>
{
public static readonly long[] Value=A102346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102346.Bytes);
public long this[int i]=>Value[i];

public static A102346Inst Instance=new A102346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102347
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,5L,3L,5L,3L,5L,3L,7L,4L,5L,6L,7L,3L,8L,2L,8L,7L,7L,2L,10L,6L,7L,5L,9L,6L,13L,4L,12L,6L,7L,8L,11L,4L,4L,6L,12L,5L,14L,5L,11L,9L,7L,3L,13L,5L,11L,8L,10L,5L,12L,9L,13L,6L,9L,3L,20L,8L,6L,13L,16L,8L,14L,4L,11L,6L,13L,3L,17L,4L,8L,12L,7L,9L,15L,7L,16L,10L,8L,4L,21L,8L,9L,10L,15L,6L,21L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102347Inst : IEnumerable<long>
{
public static readonly long[] Value=A102347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102347.Bytes);
public long this[int i]=>Value[i];

public static A102347Inst Instance=new A102347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102348
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,31L,37L,41L,43L,47L,53L,59L,61L,67L,73L,79L,83L,89L,97L,101L,103L,107L,109L,127L,131L,137L,139L,149L,151L,157L,163L,167L,179L,181L,191L,193L,197L,199L,211L,223L,227L,233L,239L,241L,251L,257L,263L,269L,271L,277L,283L,293L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102348Inst : IEnumerable<long>
{
public static readonly long[] Value=A102348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102348.Bytes);
public long this[int i]=>Value[i];

public static A102348Inst Instance=new A102348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102349
{
public static readonly long[] Value={ 0L,1L,4L,15L,55L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102349Inst : IEnumerable<long>
{
public static readonly long[] Value=A102349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102349.Bytes);
public long this[int i]=>Value[i];

public static A102349Inst Instance=new A102349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102350
{
public static readonly long[] Value={ 827L,1877L,3011L,4211L,5443L,6701L,8009L,9311L,10627L,12011L,13337L,14753L,16087L,17519L,19009L,20393L,21821L,23227L,24709L,26203L,27737L,29147L,30703L,32213L,33613L,35111L,36677L,38197L,39727L,41257L,42701L,44269L,45869L,47501L,49033L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102350Inst : IEnumerable<long>
{
public static readonly long[] Value=A102350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102350.Bytes);
public long this[int i]=>Value[i];

public static A102350Inst Instance=new A102350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102351
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,2L,3L,2L,3L,3L,3L,4L,4L,3L,5L,4L,5L,3L,3L,5L,6L,6L,4L,7L,6L,5L,6L,6L,6L,8L,6L,7L,9L,6L,8L,6L,8L,9L,6L,7L,8L,9L,8L,10L,10L,7L,8L,8L,7L,9L,11L,11L,11L,10L,10L,9L,10L,10L,13L,11L,11L,12L,11L,12L,12L,11L,9L,11L,11L,10L,12L,15L,13L,14L,13L,13L,12L,12L,16L,14L,14L,12L,14L,14L,15L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102351Inst : IEnumerable<long>
{
public static readonly long[] Value=A102351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102351.Bytes);
public long this[int i]=>Value[i];

public static A102351Inst Instance=new A102351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102352
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102352Inst : IEnumerable<long>
{
public static readonly long[] Value=A102352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102352.Bytes);
public long this[int i]=>Value[i];

public static A102352Inst Instance=new A102352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102353
{
public static readonly long[] Value={ 17L,119L,17L,17L,153L,17L,119L,17L,119L,17L,85L,51L,17L,119L,17L,17L,153L,17L,119L,17L,17L,153L,17L,119L,136L,85L,85L,17L,17L,119L,17L,17L,153L,17L,119L,17L,119L,17L,85L,51L,17L,119L,17L,17L,153L,17L,119L,17L,119L,17L,85L,51L,17L,119L,17L,17L,153L,17L,51L,102L,136L,85L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102353Inst : IEnumerable<long>
{
public static readonly long[] Value=A102353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102353.Bytes);
public long this[int i]=>Value[i];

public static A102353Inst Instance=new A102353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102354
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102354Inst : IEnumerable<long>
{
public static readonly long[] Value=A102354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102354.Bytes);
public long this[int i]=>Value[i];

public static A102354Inst Instance=new A102354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102355
{
public static readonly long[] Value={ 0L,1L,2L,120L,121L,201L,2120L,12120L,121201L,212012L,12012120L,12120121L,20121201L,212012120L,1212012120L,12120121201L,21201212012L,1201212012120L,1212012120121L,2012120121201L,21201212012120L,121201212012120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102355Inst : IEnumerable<long>
{
public static readonly long[] Value=A102355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102355.Bytes);
public long this[int i]=>Value[i];

public static A102355Inst Instance=new A102355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102356
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,15L,60L,210L,840L,3780L,12600L,69300L,415800L,2702700L,12612600L,94594500L,756756000L,4288284000L,38594556000L,244432188000L,1833241410000L,17110253160000L,141159588570000L,1298668214844000L,10389345718752000L,108222351237000000L,1125512452864800000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102356Inst : IEnumerable<long>
{
public static readonly long[] Value=A102356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102356.Bytes);
public long this[int i]=>Value[i];

public static A102356Inst Instance=new A102356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102357
{
public static readonly long[] Value={ 10L,12L,13L,14L,15L,16L,17L,18L,19L,20L,23L,24L,25L,26L,27L,28L,29L,30L,34L,35L,36L,37L,38L,39L,40L,45L,46L,47L,48L,49L,50L,56L,57L,58L,59L,60L,67L,68L,69L,70L,78L,79L,80L,89L,90L,102L,103L,104L,105L,106L,107L,108L,109L,112L,113L,114L,115L,116L,117L,118L,119L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102357Inst : IEnumerable<long>
{
public static readonly long[] Value=A102357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102357.Bytes);
public long this[int i]=>Value[i];

public static A102357Inst Instance=new A102357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102358
{
public static readonly long[] Value={ 0L,4L,8L,16L,52L,60L,96L,140L,184L,276L,368L,376L,384L,392L,428L,436L,472L,656L,660L,3412L,4144L,4152L,6168L,6764L,8048L,8052L,8056L,8060L,8068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102358Inst : IEnumerable<long>
{
public static readonly long[] Value=A102358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102358.Bytes);
public long this[int i]=>Value[i];

public static A102358Inst Instance=new A102358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102359
{
public static readonly long[] Value={ 1L,6L,32L,108L,384L,2688L,5632L,27864L,153920L,499968L,1477440L,11708928L,22380544L,115568640L,620101632L,1826150832L,5726797824L,54044390400L,91626668032L,555102471168L,2352412508160L,7458459886080L,23955459951744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102359Inst : IEnumerable<long>
{
public static readonly long[] Value=A102359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102359.Bytes);
public long this[int i]=>Value[i];

public static A102359Inst Instance=new A102359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102360
{
public static readonly long[] Value={ 1L,15L,80L,961L,2802L,52800L,142020L,2347506L,10512320L,96837120L,329849040L,8619170560L,16148168402L,221483030400L,1146781040640L,14442767744328L,38774519976900L,813898294809600L,1904350030969680L,35410174950039552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102360Inst : IEnumerable<long>
{
public static readonly long[] Value=A102360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102360.Bytes);
public long this[int i]=>Value[i];

public static A102360Inst Instance=new A102360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102361
{
public static readonly long[] Value={ 10L,14L,15L,16L,18L,19L,23L,27L,32L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102361Inst : IEnumerable<long>
{
public static readonly long[] Value=A102361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102361.Bytes);
public long this[int i]=>Value[i];

public static A102361Inst Instance=new A102361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102362
{
public static readonly long[] Value={ 10L,13L,14L,15L,16L,17L,18L,19L,22L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102362Inst : IEnumerable<long>
{
public static readonly long[] Value=A102362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102362.Bytes);
public long this[int i]=>Value[i];

public static A102362Inst Instance=new A102362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102363
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,12L,15L,16L,17L,21L,27L,31L,32L,33L,38L,48L,58L,63L,64L,65L,71L,86L,106L,121L,127L,128L,129L,136L,157L,192L,227L,248L,255L,256L,257L,265L,293L,349L,419L,475L,503L,511L,512L,513L,522L,558L,642L,768L,894L,978L,1014L,1023L,1024L,1025L,1035L,1080L,1200L,1410L,1662L,1872L,1992L,2037L,2047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102363Inst : IEnumerable<long>
{
public static readonly long[] Value=A102363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102363.Bytes);
public long this[int i]=>Value[i];

public static A102363Inst Instance=new A102363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102364
{
public static readonly long[] Value={ 0L,0L,1L,2L,1L,3L,2L,2L,4L,3L,3L,3L,2L,5L,4L,4L,4L,3L,4L,3L,3L,6L,5L,5L,5L,4L,5L,4L,4L,5L,4L,4L,4L,3L,7L,6L,6L,6L,5L,6L,5L,5L,6L,5L,5L,5L,4L,6L,5L,5L,5L,4L,5L,4L,4L,8L,7L,7L,7L,6L,7L,6L,6L,7L,6L,6L,6L,5L,7L,6L,6L,6L,5L,6L,5L,5L,7L,6L,6L,6L,5L,6L,5L,5L,6L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102364Inst : IEnumerable<long>
{
public static readonly long[] Value=A102364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102364.Bytes);
public long this[int i]=>Value[i];

public static A102364Inst Instance=new A102364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102365
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,5L,1L,0L,1L,18L,15L,1L,0L,1L,58L,129L,37L,1L,0L,1L,179L,877L,646L,83L,1L,0L,1L,543L,5280L,8030L,2685L,177L,1L,0L,1L,1636L,29658L,82610L,56285L,10002L,367L,1L,0L,1L,4916L,159742L,756218L,919615L,335162L,34777L,749L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102365Inst : IEnumerable<long>
{
public static readonly long[] Value=A102365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102365.Bytes);
public long this[int i]=>Value[i];

public static A102365Inst Instance=new A102365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102366
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,10L,15L,21L,28L,84L,120L,165L,220L,286L,364L,455L,1820L,2380L,3060L,3876L,4845L,5985L,7315L,8855L,10626L,53130L,65780L,80730L,98280L,118755L,142506L,169911L,201376L,237336L,278256L,324632L,1947792L,2324784L,2760681L,3262623L,3838380L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102366Inst : IEnumerable<long>
{
public static readonly long[] Value=A102366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102366.Bytes);
public long this[int i]=>Value[i];

public static A102366Inst Instance=new A102366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102367
{
public static readonly BigInteger[] Value={ 11L,52174L,573204L,122925461L,534483448L,3083975227L,2685575996367L,214112296674652L,BigInteger.Parse("131226315167691099699"),BigInteger.Parse("396325638628212603442"),BigInteger.Parse("5947531272548328355975"),BigInteger.Parse("118554299812338354516058") };
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
public class A102367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102367Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102367.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102367Inst Instance=new A102367Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102368
{
public static readonly long[] Value={ 3L,1L,3L,1L,3L,1L,1L,1L,3L,1L,2L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102368Inst : IEnumerable<long>
{
public static readonly long[] Value=A102368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102368.Bytes);
public long this[int i]=>Value[i];

public static A102368Inst Instance=new A102368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102369
{
public static readonly long[] Value={ 4L,4L,8L,36L,8L,36L,44L,44L,92L,92L,8L,8L,8L,8L,36L,8L,36L,184L,4L,2752L,732L,8L,2016L,596L,1284L,4L,4L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102369Inst : IEnumerable<long>
{
public static readonly long[] Value=A102369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102369.Bytes);
public long this[int i]=>Value[i];

public static A102369Inst Instance=new A102369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102370
{
public static readonly long[] Value={ 0L,3L,6L,5L,4L,15L,10L,9L,8L,11L,14L,13L,28L,23L,18L,17L,16L,19L,22L,21L,20L,31L,26L,25L,24L,27L,30L,61L,44L,39L,34L,33L,32L,35L,38L,37L,36L,47L,42L,41L,40L,43L,46L,45L,60L,55L,50L,49L,48L,51L,54L,53L,52L,63L,58L,57L,56L,59L,126L,93L,76L,71L,66L,65L,64L,67L,70L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102370Inst : IEnumerable<long>
{
public static readonly long[] Value=A102370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102370.Bytes);
public long this[int i]=>Value[i];

public static A102370Inst Instance=new A102370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102371
{
public static readonly long[] Value={ 1L,2L,7L,12L,29L,62L,123L,248L,505L,1018L,2047L,4084L,8181L,16374L,32755L,65520L,131057L,262130L,524279L,1048572L,2097133L,4194286L,8388587L,16777192L,33554409L,67108842L,134217711L,268435428L,536870885L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102371Inst : IEnumerable<long>
{
public static readonly long[] Value=A102371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102371.Bytes);
public long this[int i]=>Value[i];

public static A102371Inst Instance=new A102371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102372
{
public static readonly long[] Value={ 3L,5L,6L,9L,20L,24L,26L,39L,42L,48L,60L,65L,68L,83L,84L,93L,95L,108L,119L,126L,132L,146L,167L,179L,182L,189L,203L,206L,213L,224L,227L,230L,233L,234L,249L,258L,269L,270L,272L,291L,296L,305L,315L,324L,329L,336L,341L,345L,347L,348L,363L,368L,377L,384L,387L,392L,402L,422L,423L,438L,440L,450L,455L,458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102372Inst : IEnumerable<long>
{
public static readonly long[] Value=A102372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102372.Bytes);
public long this[int i]=>Value[i];

public static A102372Inst Instance=new A102372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102373
{
public static readonly long[] Value={ 7L,11L,26L,28L,32L,34L,37L,44L,49L,56L,62L,64L,70L,85L,95L,103L,106L,110L,119L,121L,125L,127L,130L,134L,140L,142L,154L,166L,167L,170L,176L,181L,209L,215L,217L,236L,259L,275L,277L,281L,293L,296L,307L,313L,319L,320L,323L,329L,337L,343L,347L,349L,370L,376L,379L,382L,392L,400L,407L,412L,415L,424L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102373Inst : IEnumerable<long>
{
public static readonly long[] Value=A102373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102373.Bytes);
public long this[int i]=>Value[i];

public static A102373Inst Instance=new A102373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102374
{
public static readonly long[] Value={ 24L,32L,39L,50L,54L,66L,74L,75L,78L,83L,90L,99L,101L,108L,110L,114L,135L,143L,152L,159L,167L,173L,186L,188L,204L,206L,207L,209L,219L,221L,230L,233L,236L,242L,248L,251L,255L,261L,263L,264L,276L,279L,284L,285L,321L,338L,341L,356L,362L,372L,374L,380L,393L,401L,404L,422L,426L,428L,431L,437L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102374Inst : IEnumerable<long>
{
public static readonly long[] Value=A102374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102374.Bytes);
public long this[int i]=>Value[i];

public static A102374Inst Instance=new A102374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102375
{
public static readonly long[] Value={ 1L,7L,9L,4L,1L,4L,7L,1L,8L,7L,5L,4L,1L,6L,8L,5L,4L,6L,3L,4L,9L,8L,4L,6L,4L,9L,8L,8L,0L,9L,3L,8L,0L,7L,7L,6L,3L,7L,0L,1L,3L,6L,4L,4L,1L,8L,2L,6L,5L,1L,3L,5L,5L,6L,4L,7L,1L,4L,1L,2L,9L,1L,4L,5L,8L,8L,1L,1L,0L,1L,1L,5L,3L,4L,1L,6L,7L,4L,3L,5L,8L,7L,9L,1L,1L,5L,2L,7L,5L,8L,7L,5L,7L,2L,8L,2L,5L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102375Inst : IEnumerable<long>
{
public static readonly long[] Value=A102375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102375.Bytes);
public long this[int i]=>Value[i];

public static A102375Inst Instance=new A102375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102376
{
public static readonly long[] Value={ 1L,4L,4L,16L,4L,16L,16L,64L,4L,16L,16L,64L,16L,64L,64L,256L,4L,16L,16L,64L,16L,64L,64L,256L,16L,64L,64L,256L,64L,256L,256L,1024L,4L,16L,16L,64L,16L,64L,64L,256L,16L,64L,64L,256L,64L,256L,256L,1024L,16L,64L,64L,256L,64L,256L,256L,1024L,64L,256L,256L,1024L,256L,1024L,1024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102376Inst : IEnumerable<long>
{
public static readonly long[] Value=A102376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102376.Bytes);
public long this[int i]=>Value[i];

public static A102376Inst Instance=new A102376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102377
{
public static readonly long[] Value={ 1L,10L,10L,100L,10L,100L,100L,1000L,10L,100L,100L,1000L,100L,1000L,1000L,10000L,10L,100L,100L,1000L,100L,1000L,1000L,10000L,100L,1000L,1000L,10000L,1000L,10000L,10000L,100000L,10L,100L,100L,1000L,100L,1000L,1000L,10000L,100L,1000L,1000L,10000L,1000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102377Inst : IEnumerable<long>
{
public static readonly long[] Value=A102377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102377.Bytes);
public long this[int i]=>Value[i];

public static A102377Inst Instance=new A102377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102378
{
public static readonly long[] Value={ 1L,3L,5L,9L,13L,19L,25L,35L,45L,59L,73L,93L,113L,139L,165L,201L,237L,283L,329L,389L,449L,523L,597L,691L,785L,899L,1013L,1153L,1293L,1459L,1625L,1827L,2029L,2267L,2505L,2789L,3073L,3403L,3733L,4123L,4513L,4963L,5413L,5937L,6461L,7059L,7657L,8349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102378Inst : IEnumerable<long>
{
public static readonly long[] Value=A102378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102378.Bytes);
public long this[int i]=>Value[i];

public static A102378Inst Instance=new A102378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102379
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,9L,12L,17L,22L,29L,36L,46L,56L,69L,82L,100L,118L,141L,164L,194L,224L,261L,298L,345L,392L,449L,506L,576L,646L,729L,812L,913L,1014L,1133L,1252L,1394L,1536L,1701L,1866L,2061L,2256L,2481L,2706L,2968L,3230L,3529L,3828L,4174L,4520L,4913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102379Inst : IEnumerable<long>
{
public static readonly long[] Value=A102379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102379.Bytes);
public long this[int i]=>Value[i];

public static A102379Inst Instance=new A102379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102380
{
public static readonly long[] Value={ 1L,11L,3L,37L,11L,101L,41L,271L,3L,7L,11L,13L,37L,239L,4649L,11L,73L,101L,137L,3L,3L,37L,333667L,11L,41L,271L,9091L,21649L,513239L,3L,7L,11L,13L,37L,101L,9901L,53L,79L,265371653L,11L,239L,4649L,909091L,3L,31L,37L,41L,271L,2906161L,11L,17L,73L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102380Inst : IEnumerable<long>
{
public static readonly long[] Value=A102380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102380.Bytes);
public long this[int i]=>Value[i];

public static A102380Inst Instance=new A102380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102381
{
public static readonly long[] Value={ 1L,2L,6L,8L,60L,24L,504L,576L,6480L,5760L,242352L,93312L,6200064L,5612544L,95294880L,136249344L,13687492608L,5022425088L,693149184000L,472559616000L,18501259714560L,23441203298304L,4435759798272000L,1568692666368000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102381Inst : IEnumerable<long>
{
public static readonly long[] Value=A102381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102381.Bytes);
public long this[int i]=>Value[i];

public static A102381Inst Instance=new A102381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102382
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,3L,2L,1L,4L,3L,4L,4L,4L,3L,1L,4L,4L,5L,2L,2L,2L,3L,3L,3L,2L,2L,3L,1L,3L,5L,4L,4L,3L,4L,4L,1L,4L,2L,4L,4L,3L,3L,3L,4L,2L,1L,3L,3L,4L,6L,5L,2L,4L,4L,4L,2L,3L,5L,5L,3L,1L,6L,4L,3L,4L,6L,3L,1L,4L,4L,4L,5L,4L,4L,3L,2L,2L,3L,3L,3L,6L,3L,4L,4L,3L,4L,4L,4L,3L,8L,3L,4L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102382Inst : IEnumerable<long>
{
public static readonly long[] Value=A102382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102382.Bytes);
public long this[int i]=>Value[i];

public static A102382Inst Instance=new A102382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102383
{
public static readonly long[] Value={ 0L,1L,2L,3L,1L,1L,2L,1L,3L,2L,1L,2L,4L,2L,2L,3L,3L,1L,4L,4L,4L,4L,4L,3L,1L,4L,7L,5L,2L,2L,2L,4L,4L,3L,2L,2L,3L,1L,3L,5L,4L,6L,3L,4L,4L,1L,4L,2L,4L,4L,3L,3L,3L,4L,2L,1L,3L,3L,4L,7L,6L,4L,5L,4L,4L,2L,3L,5L,7L,3L,1L,9L,4L,3L,4L,6L,4L,1L,4L,4L,4L,5L,6L,4L,3L,2L,2L,3L,3L,5L,6L,3L,4L,4L,3L,4L,4L,4L,3L,12L,3L,6L,5L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102383Inst : IEnumerable<long>
{
public static readonly long[] Value=A102383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102383.Bytes);
public long this[int i]=>Value[i];

public static A102383Inst Instance=new A102383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102384
{
public static readonly long[] Value={ 1L,2L,2L,2L,61L,23L,2L,821L,2L,5L,4201L,2L,2L,2L,137L,7L,2L,270131L,2L,5L,13L,2L,2L,2L,61277761L,17L,2L,7L,2L,5L,3373L,2L,2L,2L,113647L,53L,2L,274359834731L,2L,5L,109L,2L,2L,2L,19L,23888027348153L,7L,34613L,2L,5L,7L,2L,2L,1091L,919L,86936981079782063L,139L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102384Inst : IEnumerable<long>
{
public static readonly long[] Value=A102384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102384.Bytes);
public long this[int i]=>Value[i];

public static A102384Inst Instance=new A102384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102385
{
public static readonly BigInteger[] Value={ 2L,23L,61L,821L,4201L,270131L,61277761L,274359834731L,23888027348153L,86936981079782063L,BigInteger.Parse("4243031147170261950811"),BigInteger.Parse("272838646828154727511151"),BigInteger.Parse("821882010875193363312928672952261") };
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
public class A102385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102385Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A102385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102385.Bytes);
public BigInteger this[int i]=>Value[i];

public static A102385Inst Instance=new A102385Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102386
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,17L,25L,26L,29L,34L,47L,49L,55L,67L,77L,80L,98L,101L,110L,115L,118L,124L,133L,134L,136L,143L,158L,169L,181L,188L,193L,199L,209L,211L,220L,224L,227L,239L,241L,248L,250L,260L,265L,266L,277L,280L,293L,299L,301L,302L,311L,313L,320L,326L,337L,340L,343L,346L,364L,365L,370L,371L,382L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102386Inst : IEnumerable<long>
{
public static readonly long[] Value=A102386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102386.Bytes);
public long this[int i]=>Value[i];

public static A102386Inst Instance=new A102386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102387
{
public static readonly long[] Value={ 5L,17L,74L,144L,144L,2003L,2003L,37929L,82810L,161449L,712201L,2401519L,7339199L,33662541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102387Inst : IEnumerable<long>
{
public static readonly long[] Value=A102387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102387.Bytes);
public long this[int i]=>Value[i];

public static A102387Inst Instance=new A102387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102388
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,4L,44L,6L,78L,8L,16L,18L,234L,124L,468L,516L,882L,2092L,7068L,22794L,85456L,275732L,974048L,3698242L,14120996L,59531852L,252272512L,1163430462L,5229335374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102388Inst : IEnumerable<long>
{
public static readonly long[] Value=A102388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102388.Bytes);
public long this[int i]=>Value[i];

public static A102388Inst Instance=new A102388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102389
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,3L,4L,0L,0L,5L,6L,0L,7L,0L,0L,8L,0L,9L,10L,0L,11L,0L,0L,12L,13L,0L,0L,14L,0L,15L,16L,0L,0L,17L,18L,0L,19L,0L,0L,20L,21L,0L,0L,22L,0L,23L,24L,0L,25L,0L,0L,26L,0L,27L,28L,0L,0L,29L,30L,0L,31L,0L,0L,32L,0L,33L,34L,0L,35L,0L,0L,36L,37L,0L,0L,38L,0L,39L,40L,0L,41L,0L,0L,42L,0L,43L,44L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102389Inst : IEnumerable<long>
{
public static readonly long[] Value=A102389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102389.Bytes);
public long this[int i]=>Value[i];

public static A102389Inst Instance=new A102389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102390
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,0L,4L,5L,0L,0L,6L,0L,7L,8L,0L,9L,0L,0L,10L,0L,11L,12L,0L,0L,13L,14L,0L,15L,0L,0L,16L,17L,0L,0L,18L,0L,19L,20L,0L,0L,21L,22L,0L,23L,0L,0L,24L,0L,25L,26L,0L,27L,0L,0L,28L,29L,0L,0L,30L,0L,31L,32L,0L,33L,0L,0L,34L,0L,35L,36L,0L,0L,37L,38L,0L,39L,0L,0L,40L,0L,41L,42L,0L,43L,0L,0L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102390Inst : IEnumerable<long>
{
public static readonly long[] Value=A102390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102390.Bytes);
public long this[int i]=>Value[i];

public static A102390Inst Instance=new A102390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102391
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,5L,6L,0L,0L,9L,10L,0L,12L,0L,0L,15L,0L,17L,18L,0L,20L,0L,0L,23L,24L,0L,0L,27L,0L,29L,30L,0L,0L,33L,34L,0L,36L,0L,0L,39L,40L,0L,0L,43L,0L,45L,46L,0L,48L,0L,0L,51L,0L,53L,54L,0L,0L,57L,58L,0L,60L,0L,0L,63L,0L,65L,66L,0L,68L,0L,0L,71L,72L,0L,0L,75L,0L,77L,78L,0L,80L,0L,0L,83L,0L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102391Inst : IEnumerable<long>
{
public static readonly long[] Value=A102391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102391.Bytes);
public long this[int i]=>Value[i];

public static A102391Inst Instance=new A102391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102392
{
public static readonly long[] Value={ 0L,1L,2L,0L,4L,0L,0L,7L,8L,0L,0L,11L,0L,13L,14L,0L,16L,0L,0L,19L,0L,21L,22L,0L,0L,25L,26L,0L,28L,0L,0L,31L,32L,0L,0L,35L,0L,37L,38L,0L,0L,41L,42L,0L,44L,0L,0L,47L,0L,49L,50L,0L,52L,0L,0L,55L,56L,0L,0L,59L,0L,61L,62L,0L,64L,0L,0L,67L,0L,69L,70L,0L,0L,73L,74L,0L,76L,0L,0L,79L,0L,81L,82L,0L,84L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102392Inst : IEnumerable<long>
{
public static readonly long[] Value=A102392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102392.Bytes);
public long this[int i]=>Value[i];

public static A102392Inst Instance=new A102392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102393
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,6L,7L,0L,0L,10L,11L,0L,13L,0L,0L,16L,0L,18L,19L,0L,21L,0L,0L,24L,25L,0L,0L,28L,0L,30L,31L,0L,0L,34L,35L,0L,37L,0L,0L,40L,41L,0L,0L,44L,0L,46L,47L,0L,49L,0L,0L,52L,0L,54L,55L,0L,0L,58L,59L,0L,61L,0L,0L,64L,0L,66L,67L,0L,69L,0L,0L,72L,73L,0L,0L,76L,0L,78L,79L,0L,81L,0L,0L,84L,0L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102393Inst : IEnumerable<long>
{
public static readonly long[] Value=A102393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102393.Bytes);
public long this[int i]=>Value[i];

public static A102393Inst Instance=new A102393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102394
{
public static readonly long[] Value={ 0L,2L,3L,0L,5L,0L,0L,8L,9L,0L,0L,12L,0L,14L,15L,0L,17L,0L,0L,20L,0L,22L,23L,0L,0L,26L,27L,0L,29L,0L,0L,32L,33L,0L,0L,36L,0L,38L,39L,0L,0L,42L,43L,0L,45L,0L,0L,48L,0L,50L,51L,0L,53L,0L,0L,56L,57L,0L,0L,60L,0L,62L,63L,0L,65L,0L,0L,68L,0L,70L,71L,0L,0L,74L,75L,0L,77L,0L,0L,80L,0L,82L,83L,0L,85L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102394Inst : IEnumerable<long>
{
public static readonly long[] Value=A102394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102394.Bytes);
public long this[int i]=>Value[i];

public static A102394Inst Instance=new A102394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102395
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,2L,2L,2L,0L,2L,2L,2L,2L,2L,2L,6L,0L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,6L,2L,6L,6L,10L,0L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,6L,2L,6L,6L,10L,2L,2L,2L,6L,2L,6L,6L,10L,2L,6L,6L,10L,6L,10L,10L,22L,0L,2L,2L,2L,2L,2L,2L,6L,2L,2L,2L,6L,2L,6L,6L,10L,2L,2L,2L,6L,2L,6L,6L,10L,2L,6L,6L,10L,6L,10L,10L,22L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102395Inst : IEnumerable<long>
{
public static readonly long[] Value=A102395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102395.Bytes);
public long this[int i]=>Value[i];

public static A102395Inst Instance=new A102395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102396
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,3L,1L,3L,3L,5L,1L,1L,1L,3L,1L,3L,3L,5L,1L,3L,3L,5L,3L,5L,5L,11L,1L,1L,1L,3L,1L,3L,3L,5L,1L,3L,3L,5L,3L,5L,5L,11L,1L,3L,3L,5L,3L,5L,5L,11L,3L,5L,5L,11L,5L,11L,11L,21L,1L,1L,1L,3L,1L,3L,3L,5L,1L,3L,3L,5L,3L,5L,5L,11L,1L,3L,3L,5L,3L,5L,5L,11L,3L,5L,5L,11L,5L,11L,11L,21L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102396Inst : IEnumerable<long>
{
public static readonly long[] Value=A102396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102396.Bytes);
public long this[int i]=>Value[i];

public static A102396Inst Instance=new A102396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102397
{
public static readonly long[] Value={ 1L,10L,100L,1001L,10010L,100101L,1001011L,10010110L,100101100L,1001011001L,10010110011L,100101100110L,1001011001101L,10010110011010L,100101100110100L,1001011001101001L,10010110011010010L,100101100110100101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102397Inst : IEnumerable<long>
{
public static readonly long[] Value=A102397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102397.Bytes);
public long this[int i]=>Value[i];

public static A102397Inst Instance=new A102397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102398
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,8L,6L,12L,7L,13L,9L,18L,10L,22L,11L,20L,14L,28L,15L,32L,16L,36L,17L,29L,19L,34L,21L,44L,23L,48L,24L,52L,25L,56L,26L,43L,27L,62L,30L,53L,31L,68L,33L,54L,35L,74L,37L,78L,38L,82L,39L,86L,40L,90L,41L,67L,42L,77L,45L,98L,46L,102L,47L,76L,49L,108L,50L,89L,51L,114L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102398Inst : IEnumerable<long>
{
public static readonly long[] Value=A102398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102398.Bytes);
public long this[int i]=>Value[i];

public static A102398Inst Instance=new A102398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102399
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,9L,6L,11L,13L,15L,8L,10L,17L,19L,21L,23L,12L,25L,16L,27L,14L,29L,31L,33L,35L,37L,18L,24L,39L,41L,20L,43L,26L,45L,22L,47L,49L,51L,53L,55L,57L,36L,28L,59L,61L,63L,30L,65L,67L,69L,32L,40L,44L,71L,34L,73L,75L,77L,79L,81L,38L,83L,85L,87L,89L,56L,42L,91L,93L,95L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102399Inst : IEnumerable<long>
{
public static readonly long[] Value=A102399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102399.Bytes);
public long this[int i]=>Value[i];

public static A102399Inst Instance=new A102399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102400
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,7L,1L,31L,139L,139L,1L,127L,1567L,5711L,5711L,1L,511L,15379L,126579L,408354L,408354L,1L,2047L,143527L,2357431L,15333661L,45605881L,45605881L,1L,8191L,1312219L,40769819L,473433344L,2634441290L,7390305396L,7390305396L,1L,32767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102400Inst : IEnumerable<long>
{
public static readonly long[] Value=A102400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102400.Bytes);
public long this[int i]=>Value[i];

public static A102400Inst Instance=new A102400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102401
{
public static readonly long[] Value={ 0L,2L,14L,80L,512L,3776L,31376L,290456L,2970296L,33276536L,405440216L,5338909736L,75572075816L,1144441325096L,18464406889256L,316212570391976L,5729159765566376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102401Inst : IEnumerable<long>
{
public static readonly long[] Value=A102401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102401.Bytes);
public long this[int i]=>Value[i];

public static A102401Inst Instance=new A102401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102402
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,6L,6L,2L,17L,15L,10L,46L,51L,30L,5L,128L,175L,91L,35L,372L,568L,336L,140L,14L,1109L,1827L,1296L,504L,126L,3349L,5980L,4785L,2010L,630L,42L,10221L,19833L,17215L,8415L,2640L,462L,31527L,66078L,61908L,34210L,11385L,2772L,132L,98178L,220649L,223444L,134706L,50908L,13299L,1716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102402Inst : IEnumerable<long>
{
public static readonly long[] Value=A102402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102402.Bytes);
public long this[int i]=>Value[i];

public static A102402Inst Instance=new A102402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102403
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,17L,46L,128L,372L,1109L,3349L,10221L,31527L,98178L,308179L,973911L,3096044L,9894393L,31770247L,102444145L,331594081L,1077022622L,3509197080L,11466710630L,37567784437L,123380796192L,406120349756L,1339571374103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102403Inst : IEnumerable<long>
{
public static readonly long[] Value=A102403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102403.Bytes);
public long this[int i]=>Value[i];

public static A102403Inst Instance=new A102403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102404
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,5L,5L,3L,0L,1L,14L,14L,9L,4L,0L,1L,39L,46L,27L,14L,5L,0L,1L,114L,143L,101L,44L,20L,6L,0L,1L,339L,466L,341L,184L,65L,27L,7L,0L,1L,1028L,1524L,1212L,664L,300L,90L,35L,8L,0L,1L,3163L,5043L,4279L,2539L,1145L,454L,119L,44L,9L,0L,1L,9852L,16812L,15206L,9564L,4665L,1819L,651L,152L,54L,10L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102404Inst : IEnumerable<long>
{
public static readonly long[] Value=A102404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102404.Bytes);
public long this[int i]=>Value[i];

public static A102404Inst Instance=new A102404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102405
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,10L,3L,1L,26L,12L,3L,1L,72L,41L,15L,3L,1L,206L,143L,58L,18L,3L,1L,606L,492L,231L,76L,21L,3L,1L,1820L,1693L,891L,335L,95L,24L,3L,1L,5558L,5823L,3403L,1411L,455L,115L,27L,3L,1L,17206L,20040L,12870L,5848L,2061L,591L,136L,30L,3L,1L,53872L,69033L,48318L,23858L,9143L,2850L,743L,158L,33L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102405Inst : IEnumerable<long>
{
public static readonly long[] Value=A102405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102405.Bytes);
public long this[int i]=>Value[i];

public static A102405Inst Instance=new A102405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102406
{
public static readonly long[] Value={ 1L,0L,1L,2L,5L,14L,39L,114L,339L,1028L,3163L,9852L,31005L,98436L,314901L,1014070L,3284657L,10694314L,34979667L,114887846L,378750951L,1252865288L,4157150327L,13832926200L,46148704121L,154327715592L,517236429545L,1737102081962L,5845077156189L,19702791805126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102406Inst : IEnumerable<long>
{
public static readonly long[] Value=A102406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102406.Bytes);
public long this[int i]=>Value[i];

public static A102406Inst Instance=new A102406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102407
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,26L,72L,206L,606L,1820L,5558L,17206L,53872L,170298L,542778L,1742308L,5627698L,18277698L,59652952L,195541494L,643506310L,2125255036L,7041631854L,23400092142L,77971706848L,260458050034L,872040564850L,2925902656644L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102407Inst : IEnumerable<long>
{
public static readonly long[] Value=A102407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102407.Bytes);
public long this[int i]=>Value[i];

public static A102407Inst Instance=new A102407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102408
{
public static readonly long[] Value={ 1L,5L,6L,8L,9L,11L,10L,15L,15L,14L,17L,24L,24L,21L,13L,19L,27L,25L,29L,26L,44L,44L,29L,46L,39L,46L,27L,42L,47L,47L,54L,35L,41L,60L,51L,37L,48L,45L,49L,50L,49L,53L,77L,86L,86L,51L,96L,75L,70L,80L,99L,110L,81L,84L,102L,82L,96L,114L,53L,108L,115L,105L,116L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102408Inst : IEnumerable<long>
{
public static readonly long[] Value=A102408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102408.Bytes);
public long this[int i]=>Value[i];

public static A102408Inst Instance=new A102408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102409
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,-20L,8L,0L,0L,20280L,-6530L,-1275L,362L,3L,0L,-8749440L,21627600L,-4871940L,-66510L,48300L,390L,0L,-261763004160L,72965762016L,13117344800L,-3757930680L,72406040L,13101144L,90440L,0L,-974260634054400L,-1140185248443360L,353509119454680L,-8136128999880L,-3234018579750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102409Inst : IEnumerable<long>
{
public static readonly long[] Value=A102409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102409.Bytes);
public long this[int i]=>Value[i];

public static A102409Inst Instance=new A102409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102410
{
public static readonly long[] Value={ 1L,0L,0L,-6L,3L,1L,0L,2400L,-2024L,264L,32L,0L,2570400L,909720L,-666540L,55800L,3420L,0L,-19071521280L,12195884736L,-762499920L,-282106440L,22425480L,741384L,840L,-219303218534400L,-11953192930560L,27128332828800L,-2808016545600L,-125442525600L,14164990560L,280576800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102410Inst : IEnumerable<long>
{
public static readonly long[] Value=A102410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102410.Bytes);
public long this[int i]=>Value[i];

public static A102410Inst Instance=new A102410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102411
{
public static readonly long[] Value={ 0L,1L,0L,-16L,5L,1L,0L,5256L,-3068L,276L,32L,0L,2070720L,2367420L,-912150L,53220L,3510L,0L,-36031524480L,15327895296L,-40587120L,-387492840L,21414120L,758184L,840L,-212459319878400L,-75473246681280L,38182549456800L,-2562251680800L,-195611371200L,13639812480L,285616800L,453600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102411Inst : IEnumerable<long>
{
public static readonly long[] Value=A102411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102411.Bytes);
public long this[int i]=>Value[i];

public static A102411Inst Instance=new A102411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102412
{
public static readonly long[] Value={ 0L,1L,-4L,4L,0L,96L,-396L,108L,0L,1012320L,-192900L,-64890L,11460L,90L,-2038014720L,1977810240L,-304486560L,-12131280L,2792160L,21840L,-33190735737600L,4445760574080L,2334485260800L,-394554283200L,2330344800L,1198048320L,8215200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102412Inst : IEnumerable<long>
{
public static readonly long[] Value=A102412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102412.Bytes);
public long this[int i]=>Value[i];

public static A102412Inst Instance=new A102412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102413
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,6L,6L,1L,1L,8L,16L,8L,1L,1L,10L,30L,30L,10L,1L,1L,12L,48L,76L,48L,12L,1L,1L,14L,70L,154L,154L,70L,14L,1L,1L,16L,96L,272L,384L,272L,96L,16L,1L,1L,18L,126L,438L,810L,810L,438L,126L,18L,1L,1L,20L,160L,660L,1520L,2004L,1520L,660L,160L,20L,1L,1L,22L,198L,946L,2618L,4334L,4334L,2618L,946L,198L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102413Inst : IEnumerable<long>
{
public static readonly long[] Value=A102413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102413.Bytes);
public long this[int i]=>Value[i];

public static A102413Inst Instance=new A102413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102414
{
public static readonly long[] Value={ 4L,4L,6L,9L,14L,14L,21L,21L,25L,33L,33L,38L,46L,46L,49L,55L,62L,62L,69L,74L,74L,82L,85L,91L,106L,106L,106L,111L,111L,115L,129L,133L,141L,141L,155L,155L,158L,166L,169L,177L,183L,183L,194L,194L,201L,201L,213L,226L,235L,235L,235L,247L,247L,253L,259L,265L,274L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102414Inst : IEnumerable<long>
{
public static readonly long[] Value=A102414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102414.Bytes);
public long this[int i]=>Value[i];

public static A102414Inst Instance=new A102414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102415
{
public static readonly long[] Value={ 4L,6L,10L,10L,15L,15L,22L,26L,26L,35L,39L,39L,46L,51L,58L,58L,65L,69L,69L,77L,82L,87L,95L,95L,95L,106L,106L,111L,123L,129L,134L,134L,146L,146L,155L,161L,166L,169L,178L,178L,187L,187L,194L,194L,209L,221L,226L,226L,226L,237L,237L,249L,254L,262L,267L,267L,274L,278L,278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102415Inst : IEnumerable<long>
{
public static readonly long[] Value=A102415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102415.Bytes);
public long this[int i]=>Value[i];

public static A102415Inst Instance=new A102415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102416
{
public static readonly long[] Value={ 2L,2L,4L,2L,16L,4L,28L,6L,4L,56L,14L,8L,108L,30L,16L,6L,216L,60L,28L,12L,424L,124L,60L,24L,12L,848L,248L,128L,48L,24L,1684L,492L,244L,90L,48L,20L,3368L,984L,512L,186L,96L,40L,6712L,1960L,1000L,384L,192L,80L,40L,13424L,3920L,2032L,756L,372L,160L,80L,26808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102416Inst : IEnumerable<long>
{
public static readonly long[] Value=A102416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102416.Bytes);
public long this[int i]=>Value[i];

public static A102416Inst Instance=new A102416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102417
{
public static readonly long[] Value={ 0L,1L,3L,11L,41L,191L,1055L,6959L,53159L,462239L,4499999L,48454559L,571409999L,7321386239L,101249648639L,1502852279039L,23827244757119L,401839065331199L,7182224591270400L,135607710526041600L,2696935204633823744L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102417Inst : IEnumerable<long>
{
public static readonly long[] Value=A102417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102417.Bytes);
public long this[int i]=>Value[i];

public static A102417Inst Instance=new A102417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102418
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,2L,2L,1L,1L,3L,4L,4L,3L,1L,1L,3L,5L,7L,7L,5L,3L,1L,1L,3L,6L,10L,12L,12L,10L,6L,3L,1L,1L,3L,6L,11L,15L,18L,20L,18L,15L,11L,6L,3L,1L,1L,4L,9L,17L,26L,33L,38L,38L,33L,26L,17L,9L,4L,1L,1L,4L,10L,21L,35L,50L,64L,71L,71L,64L,50L,35L,21L,10L,4L,1L,1L,4L,11L,25L,45L,71L,99L,121L,135L,135L,121L,99L,71L,45L,25L,11L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102418Inst : IEnumerable<long>
{
public static readonly long[] Value=A102418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102418.Bytes);
public long this[int i]=>Value[i];

public static A102418Inst Instance=new A102418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102419
{
public static readonly long[] Value={ 0L,1L,6L,1L,3L,1L,11L,1L,3L,1L,8L,1L,3L,1L,11L,1L,3L,1L,6L,1L,3L,1L,8L,1L,3L,1L,96L,1L,3L,1L,91L,1L,3L,1L,6L,1L,3L,1L,13L,1L,3L,1L,8L,1L,3L,1L,88L,1L,3L,1L,6L,1L,3L,1L,8L,1L,3L,1L,11L,1L,3L,1L,88L,1L,3L,1L,6L,1L,3L,1L,83L,1L,3L,1L,8L,1L,3L,1L,13L,1L,3L,1L,6L,1L,3L,1L,8L,1L,3L,1L,73L,1L,3L,1L,13L,1L,3L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102419Inst : IEnumerable<long>
{
public static readonly long[] Value=A102419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102419.Bytes);
public long this[int i]=>Value[i];

public static A102419Inst Instance=new A102419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102420
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,2L,3L,5L,6L,8L,9L,11L,11L,12L,11L,11L,9L,8L,6L,5L,3L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102420Inst : IEnumerable<long>
{
public static readonly long[] Value=A102420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102420.Bytes);
public long this[int i]=>Value[i];

public static A102420Inst Instance=new A102420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102421
{
public static readonly long[] Value={ 1L,7L,1L,1L,5L,25L,7L,17L,19L,43L,1L,13L,7L,61L,1L,35L,37L,79L,5L,11L,23L,97L,25L,53L,55L,115L,7L,31L,1L,133L,17L,71L,73L,151L,19L,5L,41L,169L,43L,89L,91L,187L,1L,49L,25L,205L,13L,107L,109L,223L,7L,29L,59L,241L,61L,125L,127L,259L,1L,67L,17L,277L,35L,143L,145L,295L,37L,19L,77L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102421Inst : IEnumerable<long>
{
public static readonly long[] Value=A102421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102421.Bytes);
public long this[int i]=>Value[i];

public static A102421Inst Instance=new A102421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102422
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,9L,11L,14L,16L,18L,19L,20L,20L,19L,18L,16L,14L,11L,9L,7L,5L,3L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102422Inst : IEnumerable<long>
{
public static readonly long[] Value=A102422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102422.Bytes);
public long this[int i]=>Value[i];

public static A102422Inst Instance=new A102422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102423
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,17L,17L,17L,1L,1L,1L,17L,1L,1L,1L,1L,1L,1L,1L,17L,1L,1L,1L,1L,1L,1L,1L,1L,17L,1L,1L,1L,17L,1L,1L,17L,17L,1L,1L,1L,1L,1L,1L,1L,1L,17L,17L,1L,1L,1L,1L,17L,17L,1L,1L,1L,1L,1L,17L,17L,1L,1L,1L,1L,1L,17L,17L,1L,1L,1L,1L,1L,1L,1L,17L,1L,1L,1L,1L,1L,1L,1L,17L,17L,17L,1L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102423Inst : IEnumerable<long>
{
public static readonly long[] Value=A102423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102423.Bytes);
public long this[int i]=>Value[i];

public static A102423Inst Instance=new A102423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102424
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,9L,12L,16L,20L,25L,30L,36L,43L,50L,58L,66L,75L,84L,94L,104L,114L,124L,135L,145L,156L,165L,175L,184L,193L,201L,208L,214L,220L,224L,228L,230L,231L,231L,228L,224L,220L,214L,208L,201L,193L,184L,175L,165L,156L,145L,135L,124L,114L,104L,94L,84L,75L,66L,58L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102424Inst : IEnumerable<long>
{
public static readonly long[] Value=A102424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102424.Bytes);
public long this[int i]=>Value[i];

public static A102424Inst Instance=new A102424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102425
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,4L,6L,6L,12L,16L,20L,28L,40L,48L,69L,91L,111L,150L,197L,238L,319L,398L,493L,634L,792L,968L,1226L,1510L,1846L,2293L,2811L,3395L,4197L,5079L,6126L,7469L,8993L,10781L,13051L,15593L,18627L,22333L,26598L,31571L,37655L,44569L,52702L,62462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102425Inst : IEnumerable<long>
{
public static readonly long[] Value=A102425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102425.Bytes);
public long this[int i]=>Value[i];

public static A102425Inst Instance=new A102425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102426
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,1L,1L,3L,1L,3L,4L,1L,1L,6L,5L,1L,4L,10L,6L,1L,1L,10L,15L,7L,1L,5L,20L,21L,8L,1L,1L,15L,35L,28L,9L,1L,6L,35L,56L,36L,10L,1L,1L,21L,70L,84L,45L,11L,1L,7L,56L,126L,120L,55L,12L,1L,1L,28L,126L,210L,165L,66L,13L,1L,8L,84L,252L,330L,220L,78L,14L,1L,1L,36L,210L,462L,495L,286L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102426Inst : IEnumerable<long>
{
public static readonly long[] Value=A102426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102426.Bytes);
public long this[int i]=>Value[i];

public static A102426Inst Instance=new A102426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102427
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,5L,4L,1L,1L,7L,6L,6L,3L,1L,9L,8L,15L,10L,1L,1L,11L,10L,28L,21L,10L,4L,1L,13L,12L,45L,36L,35L,20L,1L,1L,15L,14L,66L,55L,84L,56L,15L,5L,1L,17L,16L,91L,78L,165L,120L,70L,35L,1L,1L,19L,18L,120L,105L,286L,220L,210L,126L,21L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102427Inst : IEnumerable<long>
{
public static readonly long[] Value=A102427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102427.Bytes);
public long this[int i]=>Value[i];

public static A102427Inst Instance=new A102427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102428
{
public static readonly long[] Value={ 1L,3L,6L,28L,55L,286L,560L,3060L,5985L,33649L,65780L,376740L,736281L,4272048L,8347680L,48903492L,95548245L,563921995L,1101716330L,6540715896L,12777711870L,76223753060L,148902215280L,891794789340L,1742058970275L,10468434365991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102428Inst : IEnumerable<long>
{
public static readonly long[] Value=A102428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102428.Bytes);
public long this[int i]=>Value[i];

public static A102428Inst Instance=new A102428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102429
{
public static readonly long[] Value={ 1L,2L,6L,11L,23L,44L,85L,163L,311L,594L,1132L,2158L,4112L,7835L,14928L,28441L,54186L,103234L,196679L,374707L,713880L,1360061L,2591143L,4936559L,9404966L,17918024L,34136814L,65036304L,123904967L,236059552L,449732673L,856815474L,1632375854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102429Inst : IEnumerable<long>
{
public static readonly long[] Value=A102429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102429.Bytes);
public long this[int i]=>Value[i];

public static A102429Inst Instance=new A102429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102430
{
public static readonly long[] Value={ 1L,3L,1L,10L,2L,1L,35L,2L,1L,1L,126L,4L,2L,1L,1L,462L,4L,2L,1L,1L,1L,1716L,6L,2L,2L,1L,1L,1L,6435L,6L,3L,2L,1L,1L,1L,1L,24310L,10L,3L,2L,2L,1L,1L,1L,1L,92378L,10L,3L,2L,2L,1L,1L,1L,1L,1L,352716L,14L,5L,3L,2L,2L,1L,1L,1L,1L,1L,1352078L,14L,5L,3L,2L,2L,1L,1L,1L,1L,1L,1L,5200300L,20L,5L,3L,2L,2L,2L,1L,1L,1L,1L,1L,1L,20058300L,20L,7L,3L,3L,2L,2L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102430Inst : IEnumerable<long>
{
public static readonly long[] Value=A102430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102430.Bytes);
public long this[int i]=>Value[i];

public static A102430Inst Instance=new A102430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102431
{
public static readonly long[] Value={ 2L,4L,8L,10L,15L,17L,24L,28L,35L,37L,49L,51L,60L,65L,80L,82L,99L,101L,121L,127L,144L,146L,176L,180L,203L,211L,243L,245L,283L,285L,328L,336L,375L,380L,443L,445L,494L,504L,574L,576L,650L,652L,733L,748L,825L,827L,942L,946L,1047L,1059L,1181L,1183L,1316L,1322L,1473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102431Inst : IEnumerable<long>
{
public static readonly long[] Value=A102431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102431.Bytes);
public long this[int i]=>Value[i];

public static A102431Inst Instance=new A102431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102432
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,11L,12L,18L,21L,27L,28L,39L,40L,48L,52L,66L,67L,83L,84L,103L,108L,124L,125L,154L,157L,179L,186L,217L,218L,255L,256L,298L,305L,343L,347L,409L,410L,458L,467L,536L,537L,610L,611L,691L,705L,781L,782L,896L,899L,999L,1010L,1131L,1132L,1264L,1269L,1419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102432Inst : IEnumerable<long>
{
public static readonly long[] Value=A102432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102432.Bytes);
public long this[int i]=>Value[i];

public static A102432Inst Instance=new A102432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102433
{
public static readonly long[] Value={ 1L,4L,12L,40L,132L,472L,1727L,6452L,24330L,92404L,352743L,1352116L,5200339L,20058347L,77558811L,300540260L,1166803176L,4537567732L,17672631983L,68923264512L,269128937327L,1052049481983L,4116715363924L,16123801841703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102433Inst : IEnumerable<long>
{
public static readonly long[] Value=A102433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102433.Bytes);
public long this[int i]=>Value[i];

public static A102433Inst Instance=new A102433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102434
{
public static readonly long[] Value={ 1L,5L,14L,43L,136L,477L,1733L,6459L,24338L,92413L,352753L,1352127L,5200351L,20058360L,77558825L,300540275L,1166803192L,4537567749L,17672632001L,68923264531L,269128937347L,1052049482004L,4116715363946L,16123801841726L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102434Inst : IEnumerable<long>
{
public static readonly long[] Value=A102434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102434.Bytes);
public long this[int i]=>Value[i];

public static A102434Inst Instance=new A102434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102435
{
public static readonly long[] Value={ 1L,1L,3L,1L,1L,8L,16L,8L,1L,1L,13L,54L,87L,54L,13L,1L,1L,18L,117L,348L,501L,348L,117L,18L,1L,1L,23L,205L,914L,2210L,2966L,2210L,914L,205L,23L,1L,1L,28L,318L,1910L,6658L,13980L,17895L,13980L,6658L,1910L,318L,28L,1L,1L,33L,456L,3461L,15945L,46648L,88425L,109391L,88425L,46648L,15945L,3461L,456L,33L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102435Inst : IEnumerable<long>
{
public static readonly long[] Value=A102435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102435.Bytes);
public long this[int i]=>Value[i];

public static A102435Inst Instance=new A102435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102436
{
public static readonly long[] Value={ 1L,5L,34L,223L,1469L,9672L,63685L,419329L,2761042L,18179883L,119704137L,788183312L,5189736537L,34171448333L,224999452834L,1481492773799L,9754783005797L,64229669677144L,422915657312253L,2784657839576297L,18335379997029650L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102436Inst : IEnumerable<long>
{
public static readonly long[] Value=A102436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102436.Bytes);
public long this[int i]=>Value[i];

public static A102436Inst Instance=new A102436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102437
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,3L,5L,9L,10L,14L,22L,28L,37L,53L,66L,85L,120L,147L,188L,252L,308L,394L,509L,621L,783L,990L,1210L,1500L,1872L,2272L,2793L,3447L,4152L,5064L,6184L,7414L,8984L,10856L,12964L,15592L,18711L,22250L,26576L,31690L,37520L,44565L,52856L,62292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102437Inst : IEnumerable<long>
{
public static readonly long[] Value=A102437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102437.Bytes);
public long this[int i]=>Value[i];

public static A102437Inst Instance=new A102437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102438
{
public static readonly long[] Value={ 44L,144L,244L,344L,444L,544L,644L,744L,844L,944L,1044L,1144L,1244L,1344L,1444L,1544L,1644L,1744L,1844L,1944L,2044L,2144L,2244L,2344L,2444L,2544L,2644L,2744L,2844L,2944L,3044L,3144L,3244L,3344L,3444L,3544L,3644L,3744L,3844L,3944L,4044L,4144L,4244L,4344L,4444L,4544L,4644L,4744L,4844L,4944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102438Inst : IEnumerable<long>
{
public static readonly long[] Value=A102438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102438.Bytes);
public long this[int i]=>Value[i];

public static A102438Inst Instance=new A102438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102439
{
public static readonly long[] Value={ 4L,104L,204L,304L,404L,504L,604L,704L,804L,904L,1004L,1104L,1204L,1304L,1404L,1504L,1604L,1704L,1804L,1904L,2004L,2104L,2204L,2304L,2404L,2504L,2604L,2704L,2804L,2904L,3004L,3104L,3204L,3304L,3404L,3504L,3604L,3704L,3804L,3904L,4004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102439Inst : IEnumerable<long>
{
public static readonly long[] Value=A102439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102439.Bytes);
public long this[int i]=>Value[i];

public static A102439Inst Instance=new A102439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A102440
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,6L,6L,8L,9L,8L,10L,12L,10L,12L,12L,16L,15L,18L,15L,16L,18L,20L,22L,24L,16L,20L,27L,24L,26L,24L,26L,32L,30L,30L,24L,36L,35L,30L,30L,32L,39L,36L,39L,40L,36L,44L,46L,48L,36L,32L,45L,40L,51L,54L,40L,48L,45L,52L,58L,48L,58L,52L,54L,64L,40L,60L,65L,60L,66L,48L,69L,72L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A102440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A102440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A102440Inst : IEnumerable<long>
{
public static readonly long[] Value=A102440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A102440.Bytes);
public long this[int i]=>Value[i];

public static A102440Inst Instance=new A102440Inst();

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