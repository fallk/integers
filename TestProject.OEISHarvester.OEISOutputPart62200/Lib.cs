using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A077409
{
public static readonly BigInteger[] Value={ 7L,59L,583L,5771L,57127L,565499L,5597863L,55413131L,548533447L,5429921339L,53750679943L,532076878091L,5267018100967L,52138104131579L,516114023214823L,5109002128016651L,50573907256951687L,500630070441500219L,4955726797158050503L,BigInteger.Parse("49056637901139004811") };
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
public class A077409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077409Inst Instance=new A077409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077410
{
public static readonly long[] Value={ 1L,2L,12L,21L,119L,208L,1178L,2059L,11661L,20382L,115432L,201761L,1142659L,1997228L,11311158L,19770519L,111968921L,195707962L,1108378052L,1937309101L,10971811599L,19177383048L,108609737938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077410Inst : IEnumerable<long>
{
public static readonly long[] Value=A077410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077410.Bytes);
public long this[int i]=>Value[i];

public static A077410Inst Instance=new A077410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077411
{
public static readonly long[] Value={ 7L,11L,59L,103L,583L,1019L,5771L,10087L,57127L,99851L,565499L,988423L,5597863L,9784379L,55413131L,96855367L,548533447L,958769291L,5429921339L,9490837543L,53750679943L,93949606139L,532076878091L,930005223847L,5267018100967L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077411Inst : IEnumerable<long>
{
public static readonly long[] Value=A077411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077411.Bytes);
public long this[int i]=>Value[i];

public static A077411Inst Instance=new A077411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077492
{
public static readonly long[] Value={ 2L,4L,6L,8L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,39L,59L,79L,99L,119L,139L,159L,179L,199L,399L,599L,799L,999L,1199L,1399L,1599L,1799L,1999L,3999L,5999L,7999L,9999L,11999L,13999L,15999L,17999L,19999L,39999L,59999L,79999L,99999L,119999L,139999L,159999L,179999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077492Inst : IEnumerable<long>
{
public static readonly long[] Value=A077492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077492.Bytes);
public long this[int i]=>Value[i];

public static A077492Inst Instance=new A077492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077493
{
public static readonly long[] Value={ 1001L,21L,112L,14L,42L,7L,35L,63L,28L,56L,84L,49L,77L,168L,196L,98L,189L,469L,497L,399L,679L,896L,798L,889L,1799L,2898L,2989L,3899L,4998L,6979L,5999L,8799L,9898L,9989L,29799L,19999L,39998L,58989L,59899L,68999L,79989L,99799L,89999L,199899L,389998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077493Inst : IEnumerable<long>
{
public static readonly long[] Value=A077493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077493.Bytes);
public long this[int i]=>Value[i];

public static A077493Inst Instance=new A077493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077494
{
public static readonly long[] Value={ 143L,3L,16L,2L,6L,1L,5L,9L,4L,8L,12L,7L,11L,24L,28L,14L,27L,67L,71L,57L,97L,128L,114L,127L,257L,414L,427L,557L,714L,997L,857L,1257L,1414L,1427L,4257L,2857L,5714L,8427L,8557L,9857L,11427L,14257L,12857L,28557L,55714L,42857L,71427L,85714L,99857L,112857L,128557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077494Inst : IEnumerable<long>
{
public static readonly long[] Value=A077494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077494.Bytes);
public long this[int i]=>Value[i];

public static A077494Inst Instance=new A077494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077495
{
public static readonly long[] Value={ 0L,125L,25L,15L,5L,4L,3L,2L,1L,9L,8L,7L,6L,23L,22L,12L,11L,37L,36L,62L,61L,87L,86L,112L,111L,236L,361L,486L,611L,736L,861L,986L,1111L,1236L,2486L,3736L,4986L,6236L,7486L,8736L,9986L,11236L,12486L,24986L,37486L,49986L,62486L,74986L,87486L,99986L,112486L,124986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077495Inst : IEnumerable<long>
{
public static readonly long[] Value=A077495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077495.Bytes);
public long this[int i]=>Value[i];

public static A077495Inst Instance=new A077495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077496
{
public static readonly long[] Value={ 1L,5L,0L,2L,8L,3L,6L,8L,0L,1L,0L,4L,9L,7L,5L,6L,4L,9L,9L,7L,5L,2L,9L,3L,6L,4L,2L,3L,7L,3L,2L,1L,6L,9L,4L,0L,8L,7L,3L,8L,8L,7L,1L,7L,4L,3L,9L,6L,3L,5L,7L,9L,3L,0L,6L,9L,9L,0L,6L,7L,1L,4L,2L,4L,3L,0L,8L,4L,7L,1L,9L,7L,8L,7L,1L,7L,5L,7L,6L,6L,0L,1L,9L,4L,5L,6L,6L,3L,3L,3L,9L,1L,7L,8L,6L,3L,0L,6L,1L,9L,8L,7L,2L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077496Inst : IEnumerable<long>
{
public static readonly long[] Value=A077496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077496.Bytes);
public long this[int i]=>Value[i];

public static A077496Inst Instance=new A077496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077497
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,41L,101L,251L,257L,401L,641L,1601L,4001L,16001L,25601L,40961L,62501L,65537L,160001L,163841L,16384001L,26214401L,40960001L,62500001L,104857601L,167772161L,256000001L,409600001L,655360001L,2441406251L,2500000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077497Inst : IEnumerable<long>
{
public static readonly long[] Value=A077497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077497.Bytes);
public long this[int i]=>Value[i];

public static A077497Inst Instance=new A077497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077498
{
public static readonly long[] Value={ 2L,3L,5L,17L,29L,113L,197L,257L,449L,1373L,3137L,50177L,65537L,114689L,268913L,470597L,614657L,1075649L,3294173L,7340033L,9834497L,210827009L,275365889L,359661569L,469762049L,1129900997L,1438646273L,1927561217L,7909306973L,52613349377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077498Inst : IEnumerable<long>
{
public static readonly long[] Value=A077498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077498.Bytes);
public long this[int i]=>Value[i];

public static A077498Inst Instance=new A077498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077499
{
public static readonly long[] Value={ 2L,3L,5L,17L,23L,89L,257L,353L,1409L,2663L,30977L,65537L,170369L,495617L,5767169L,23068673L,59969537L,82458113L,453519617L,3429742097L,4715895383L,15352201217L,39909726209L,1857616347137L,45732811767809L,96757023244289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077499Inst : IEnumerable<long>
{
public static readonly long[] Value=A077499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077499.Bytes);
public long this[int i]=>Value[i];

public static A077499Inst Instance=new A077499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077500
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,37L,41L,47L,53L,59L,73L,83L,89L,97L,101L,107L,109L,113L,137L,149L,163L,167L,173L,179L,193L,197L,227L,233L,251L,257L,263L,269L,293L,317L,347L,353L,359L,383L,389L,401L,433L,449L,467L,479L,487L,503L,509L,557L,563L,569L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077500Inst : IEnumerable<long>
{
public static readonly long[] Value=A077500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077500.Bytes);
public long this[int i]=>Value[i];

public static A077500Inst Instance=new A077500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077501
{
public static readonly long[] Value={ 11L,23L,31L,41L,53L,61L,71L,83L,97L,101L,113L,127L,131L,149L,151L,163L,173L,181L,191L,2003L,2111L,2203L,2309L,2411L,2503L,2609L,2707L,2801L,2903L,3001L,3109L,3203L,3301L,3407L,3511L,3607L,3701L,3803L,3907L,4001L,4111L,4201L,4327L,4409L,4507L,4603L,4703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077501Inst : IEnumerable<long>
{
public static readonly long[] Value=A077501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077501.Bytes);
public long this[int i]=>Value[i];

public static A077501Inst Instance=new A077501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077502
{
public static readonly long[] Value={ 0L,1L,25L,36L,49L,529L,625L,729L,841L,900L,1024L,1156L,1225L,1369L,1444L,1521L,1600L,1764L,1849L,1936L,2025L,2116L,2209L,2304L,2401L,2500L,2601L,2704L,2809L,2916L,3025L,3136L,3249L,3364L,3481L,35344L,36100L,37249L,38025L,39204L,40000L,41209L,42025L,43264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077502Inst : IEnumerable<long>
{
public static readonly long[] Value=A077502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077502.Bytes);
public long this[int i]=>Value[i];

public static A077502Inst Instance=new A077502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077503
{
public static readonly long[] Value={ 1L,25L,324L,4096L,50176L,600625L,7001316L,80013025L,900000000L,1000014129L,11000024161L,120000580921L,1300001310976L,14000004588964L,150000007007601L,1600000000000000L,17000000233634401L,180000000244436761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077503Inst : IEnumerable<long>
{
public static readonly long[] Value=A077503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077503.Bytes);
public long this[int i]=>Value[i];

public static A077503Inst Instance=new A077503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077504
{
public static readonly long[] Value={ 23L,307L,4001L,50021L,600011L,7000003L,80000023L,900000011L,1000000007L,11000000021L,120000000007L,1300000000021L,14000000000003L,150000000000007L,1600000000000007L,17000000000000009L,180000000000000029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077504Inst : IEnumerable<long>
{
public static readonly long[] Value=A077504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077504.Bytes);
public long this[int i]=>Value[i];

public static A077504Inst Instance=new A077504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077505
{
public static readonly long[] Value={ 3L,7L,1L,21L,11L,3L,23L,11L,7L,21L,7L,21L,3L,7L,7L,9L,29L,9L,11L,59L,97L,3L,11L,163L,147L,91L,87L,23L,7L,291L,167L,337L,73L,93L,133L,3L,177L,257L,7L,149L,103L,3L,27L,13L,39L,137L,19L,31L,351L,209L,151L,489L,101L,153L,281L,139L,81L,47L,367L,189L,47L,29L,199L,3L,1L,63L,29L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077505Inst : IEnumerable<long>
{
public static readonly long[] Value=A077505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077505.Bytes);
public long this[int i]=>Value[i];

public static A077505Inst Instance=new A077505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077506
{
public static readonly long[] Value={ 1L,21L,300L,4005L,50086L,600060L,7003153L,80004925L,900003951L,1000006281L,11000078650L,120000270151L,1300001532378L,14000004645256L,150000007349286L,1600000000287153L,17000000065300605L,180000000300000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077506Inst : IEnumerable<long>
{
public static readonly long[] Value=A077506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077506.Bytes);
public long this[int i]=>Value[i];

public static A077506Inst Instance=new A077506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077507
{
public static readonly long[] Value={ 1L,28L,378L,4950L,59685L,699153L,7998000L,89987820L,999961560L,1099969156L,11999870821L,129999769851L,1399999074540L,14999999588925L,159999994275696L,1699999973850921L,17999999979109470L,189999999508759300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077507Inst : IEnumerable<long>
{
public static readonly long[] Value=A077507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077507.Bytes);
public long this[int i]=>Value[i];

public static A077507Inst Instance=new A077507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077524
{
public static readonly long[] Value={ 2L,3L,7L,757L,9927299L,359243616342953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077524Inst : IEnumerable<long>
{
public static readonly long[] Value=A077524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077524.Bytes);
public long this[int i]=>Value[i];

public static A077524Inst Instance=new A077524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077525
{
public static readonly long[] Value={ 1L,22L,303L,414L,525L,636L,747L,858L,969L,10701L,11711L,12921L,130031L,141141L,152251L,163361L,174471L,185581L,196691L,207702L,218812L,228822L,2300032L,2401042L,2502052L,2603062L,2704072L,2805082L,2906092L,3007003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077525Inst : IEnumerable<long>
{
public static readonly long[] Value=A077525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077525.Bytes);
public long this[int i]=>Value[i];

public static A077525Inst Instance=new A077525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077526
{
public static readonly long[] Value={ 1L,2L,22L,3L,33L,303L,4L,44L,404L,414L,5L,55L,505L,515L,525L,6L,66L,606L,616L,626L,636L,7L,77L,707L,717L,727L,737L,747L,8L,88L,808L,818L,828L,838L,848L,858L,9L,99L,909L,919L,929L,939L,949L,959L,969L,101L,1001L,10001L,10101L,10201L,10301L,10401L,10501L,10601L,10701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077526Inst : IEnumerable<long>
{
public static readonly long[] Value=A077526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077526.Bytes);
public long this[int i]=>Value[i];

public static A077526Inst Instance=new A077526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077527
{
public static readonly long[] Value={ 1L,24L,339L,866L,1605L,2556L,3719L,5094L,6681L,83910L,92121L,126052L,266303L,427674L,610165L,813776L,1038507L,1284358L,1551329L,1837540L,2146652L,2246984L,4887236L,7498608L,10311000L,13324412L,16538844L,19954296L,23570768L,27385390L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077527Inst : IEnumerable<long>
{
public static readonly long[] Value=A077527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077527.Bytes);
public long this[int i]=>Value[i];

public static A077527Inst Instance=new A077527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077528
{
public static readonly long[] Value={ 3L,4L,5L,6L,7L,8L,9L,55L,11L,111L,121L,66L,99L,121L,33L,171L,55L,77L,101L,22L,111L,323L,121L,101L,131L,55L,141L,88L,121L,373L,33L,232L,171L,141L,181L,1111L,77L,313L,121L,575L,505L,44L,353L,181L,323L,424L,1441L,99L,101L,868L,313L,10601L,55L,111L,393L,343L,929L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077528Inst : IEnumerable<long>
{
public static readonly long[] Value=A077528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077528.Bytes);
public long this[int i]=>Value[i];

public static A077528Inst Instance=new A077528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077529
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,4L,8L,44L,88L,5L,55L,505L,515L,525L,6L,66L,222L,252L,282L,414L,7L,77L,161L,252L,343L,434L,525L,8L,88L,232L,272L,424L,464L,616L,656L,9L,99L,171L,252L,333L,414L,585L,666L,747L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,11L,22L,33L,44L,55L,66L,77L,88L,99L,121L,242L,252L,444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077529Inst : IEnumerable<long>
{
public static readonly long[] Value=A077529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077529.Bytes);
public long this[int i]=>Value[i];

public static A077529Inst Instance=new A077529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077530
{
public static readonly long[] Value={ 1L,4L,9L,88L,525L,414L,525L,656L,747L,0L,242L,6996L,7007L,20202L,52425L,25952L,20502L,28782L,28082L,0L,32823L,4334L,40204L,61416L,520025L,64246L,73737L,69496L,76067L,0L,95759L,276672L,9339L,272272L,5046405L,468864L,36963L,611116L,333333L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077530Inst : IEnumerable<long>
{
public static readonly long[] Value=A077530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077530.Bytes);
public long this[int i]=>Value[i];

public static A077530Inst Instance=new A077530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077531
{
public static readonly long[] Value={ 1L,6L,18L,144L,1605L,1242L,1799L,2760L,3276L,0L,858L,31068L,32357L,66178L,479925L,192896L,141457L,271890L,220495L,0L,298578L,44066L,407491L,663480L,1632125L,820820L,1273968L,931756L,1020539L,0L,1405416L,2283104L,149754L,2553672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077531Inst : IEnumerable<long>
{
public static readonly long[] Value=A077531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077531.Bytes);
public long this[int i]=>Value[i];

public static A077531Inst Instance=new A077531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077532
{
public static readonly long[] Value={ 1L,3L,6L,36L,321L,207L,257L,345L,364L,0L,78L,2589L,2489L,4727L,31995L,12056L,8321L,15105L,11605L,0L,14218L,2003L,17717L,27645L,65285L,31570L,47184L,33277L,35191L,0L,45336L,71347L,4538L,75108L,1326525L,124749L,15573L,147206L,84857L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077532Inst : IEnumerable<long>
{
public static readonly long[] Value=A077532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077532.Bytes);
public long this[int i]=>Value[i];

public static A077532Inst Instance=new A077532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077533
{
public static readonly long[] Value={ 3L,27L,33L,57L,72L,75L,222L,225L,237L,252L,255L,273L,327L,333L,357L,372L,375L,522L,525L,537L,552L,555L,573L,723L,732L,735L,753L,777L,2223L,2232L,2235L,2253L,2277L,2322L,2325L,2337L,2352L,2355L,2373L,2523L,2532L,2535L,2553L,2577L,2727L,2733L,2757L,2772L,2775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077533Inst : IEnumerable<long>
{
public static readonly long[] Value=A077533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077533.Bytes);
public long this[int i]=>Value[i];

public static A077533Inst Instance=new A077533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077534
{
public static readonly long[] Value={ 32L,52L,72L,232L,252L,272L,332L,352L,372L,532L,552L,572L,732L,752L,772L,2232L,2252L,2272L,2332L,2352L,2372L,2532L,2552L,2572L,2732L,2752L,2772L,3232L,3252L,3272L,3332L,3352L,3372L,3532L,3552L,3572L,3732L,3752L,3772L,5232L,5252L,5272L,5332L,5352L,5372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077534Inst : IEnumerable<long>
{
public static readonly long[] Value=A077534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077534.Bytes);
public long this[int i]=>Value[i];

public static A077534Inst Instance=new A077534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077535
{
public static readonly long[] Value={ 72L,222L,252L,372L,522L,552L,732L,2232L,2322L,2352L,2532L,2772L,3222L,3252L,3372L,3522L,3552L,3732L,5232L,5322L,5352L,5532L,5772L,7272L,7332L,7572L,7722L,7752L,22272L,22332L,22572L,22722L,22752L,23232L,23322L,23352L,23532L,23772L,25272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077535Inst : IEnumerable<long>
{
public static readonly long[] Value=A077535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077535.Bytes);
public long this[int i]=>Value[i];

public static A077535Inst Instance=new A077535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077536
{
public static readonly long[] Value={ 7L,35L,77L,252L,273L,322L,357L,525L,532L,553L,735L,777L,2233L,2275L,2352L,2373L,2527L,2555L,2723L,2737L,2772L,3227L,3255L,3325L,3332L,3353L,3535L,3577L,3752L,3773L,5222L,5257L,5327L,5355L,5523L,5537L,5572L,5733L,5775L,7252L,7273L,7322L,7357L,7525L,7532L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077536Inst : IEnumerable<long>
{
public static readonly long[] Value=A077536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077536.Bytes);
public long this[int i]=>Value[i];

public static A077536Inst Instance=new A077536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077537
{
public static readonly BigInteger[] Value={ 0L,1L,1L,5L,26L,343L,17334L,9209754L,225842206252L,2880066968519382403L,BigInteger.Parse("898923707005599922079920034025"),BigInteger.Parse("3577855662560905980740035806138759999587547050967"),BigInteger.Parse("4444705723234237498833973519979330664270869912654770206838250657106420149314752") };
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
public class A077537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077537Inst Instance=new A077537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077538
{
public static readonly long[] Value={ 1L,14L,90L,360L,1075L,2646L,5684L,11040L,19845L,33550L,53966L,83304L,124215L,179830L,253800L,350336L,474249L,630990L,826690L,1068200L,1363131L,1719894L,2147740L,2656800L,3258125L,3963726L,4786614L,5740840L,6841535L,8104950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077538Inst : IEnumerable<long>
{
public static readonly long[] Value=A077538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077538.Bytes);
public long this[int i]=>Value[i];

public static A077538Inst Instance=new A077538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077539
{
public static readonly long[] Value={ 6L,20L,42L,71L,108L,152L,204L,263L,330L,403L,485L,573L,669L,773L,884L,1002L,1128L,1261L,1401L,1549L,1704L,1866L,2036L,2214L,2398L,2591L,2790L,2997L,3211L,3433L,3662L,3898L,4142L,4394L,4652L,4918L,5192L,5472L,5761L,6056L,6359L,6669L,6987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077539Inst : IEnumerable<long>
{
public static readonly long[] Value=A077539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077539.Bytes);
public long this[int i]=>Value[i];

public static A077539Inst Instance=new A077539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077556
{
public static readonly long[] Value={ 0L,1L,2L,5L,12L,31L,81L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077556Inst : IEnumerable<long>
{
public static readonly long[] Value=A077556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077556.Bytes);
public long this[int i]=>Value[i];

public static A077556Inst Instance=new A077556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077557
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,32L,33L,34L,35L,36L,37L,38L,39L,43L,44L,45L,46L,47L,48L,49L,54L,55L,56L,57L,58L,59L,65L,66L,67L,68L,69L,76L,77L,78L,79L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,199L,219L,221L,222L,223L,224L,225L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077557Inst : IEnumerable<long>
{
public static readonly long[] Value=A077557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077557.Bytes);
public long this[int i]=>Value[i];

public static A077557Inst Instance=new A077557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077558
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,7L,4L,9L,25L,49L,5L,7L,11L,13L,17L,6L,10L,14L,15L,21L,22L,7L,11L,13L,17L,19L,23L,29L,8L,27L,125L,343L,1331L,2197L,4913L,6859L,9L,25L,49L,121L,169L,289L,361L,529L,841L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,12L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077558Inst : IEnumerable<long>
{
public static readonly long[] Value=A077558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077558.Bytes);
public long this[int i]=>Value[i];

public static A077558Inst Instance=new A077558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077559
{
public static readonly long[] Value={ 1L,3L,7L,49L,17L,22L,29L,6859L,841L,38L,47L,76L,61L,57L,62L,7890481L,83L,147L,101L,164L,86L,91L,127L,472L,10609L,111L,1225043L,244L,163L,285L,179L,38579489651L,134L,142L,145L,14884L,223L,159L,166L,872L,241L,399L,263L,388L,412L,202L,283L,2512L,57121L,475L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077559Inst : IEnumerable<long>
{
public static readonly long[] Value=A077559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077559.Bytes);
public long this[int i]=>Value[i];

public static A077559Inst Instance=new A077559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077560
{
public static readonly long[] Value={ 3L,9L,10L,27L,18L,81L,40L,42L,243L,100L,80L,84L,729L,108L,160L,168L,2187L,324L,252L,320L,330L,1000L,336L,6561L,800L,504L,640L,630L,648L,672L,19683L,1600L,1008L,1280L,1320L,1944L,1764L,1344L,59049L,1512L,3200L,1980L,10000L,2016L,2560L,2640L,5832L,2700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077560Inst : IEnumerable<long>
{
public static readonly long[] Value=A077560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077560.Bytes);
public long this[int i]=>Value[i];

public static A077560Inst Instance=new A077560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077561
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,16L,20L,24L,32L,45L,48L,66L,84L,90L,96L,108L,120L,140L,144L,150L,154L,162L,168L,175L,180L,192L,198L,200L,216L,220L,224L,240L,252L,264L,280L,288L,300L,315L,324L,336L,360L,375L,390L,396L,432L,486L,504L,525L,570L,576L,594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077561Inst : IEnumerable<long>
{
public static readonly long[] Value=A077561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077561.Bytes);
public long this[int i]=>Value[i];

public static A077561Inst Instance=new A077561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077562
{
public static readonly long[] Value={ 1L,2L,12L,24L,48L,96L,180L,240L,512L,1440L,1728L,4620L,10080L,12960L,15360L,25920L,34560L,60060L,64800L,75600L,83160L,103680L,120120L,138600L,161280L,196608L,221760L,230400L,311040L,332640L,362880L,480480L,554400L,720720L,907200L,995328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077562Inst : IEnumerable<long>
{
public static readonly long[] Value=A077562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077562.Bytes);
public long this[int i]=>Value[i];

public static A077562Inst Instance=new A077562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077563
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,5L,4L,4L,5L,6L,4L,8L,6L,8L,6L,8L,8L,11L,7L,10L,10L,12L,10L,12L,10L,13L,10L,15L,12L,15L,10L,17L,16L,17L,13L,18L,16L,18L,16L,19L,18L,21L,13L,20L,19L,25L,20L,23L,19L,24L,20L,25L,24L,27L,19L,24L,26L,28L,21L,28L,25L,30L,26L,31L,26L,32L,19L,30L,30L,33L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077563Inst : IEnumerable<long>
{
public static readonly long[] Value=A077563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077563.Bytes);
public long this[int i]=>Value[i];

public static A077563Inst Instance=new A077563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077564
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,3L,4L,4L,5L,6L,8L,10L,10L,11L,14L,14L,19L,22L,22L,25L,30L,34L,38L,40L,46L,54L,60L,63L,74L,81L,85L,91L,108L,118L,126L,134L,153L,173L,180L,186L,214L,236L,245L,262L,301L,326L,338L,355L,395L,437L,461L,476L,540L,592L,610L,649L,717L,768L,811L,853L,943L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077564Inst : IEnumerable<long>
{
public static readonly long[] Value=A077564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077564.Bytes);
public long this[int i]=>Value[i];

public static A077564Inst Instance=new A077564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077565
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,3L,1L,3L,1L,1L,1L,4L,1L,1L,2L,3L,1L,4L,1L,3L,1L,1L,1L,3L,1L,1L,1L,4L,1L,4L,1L,3L,3L,1L,1L,6L,1L,3L,1L,3L,1L,4L,1L,4L,1L,1L,1L,5L,1L,1L,3L,4L,1L,4L,1L,3L,1L,4L,1L,7L,1L,1L,3L,3L,1L,4L,1L,6L,2L,1L,1L,5L,1L,1L,1L,4L,1L,5L,1L,3L,1L,1L,1L,9L,1L,3L,3L,3L,1L,4L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077565Inst : IEnumerable<long>
{
public static readonly long[] Value=A077565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077565.Bytes);
public long this[int i]=>Value[i];

public static A077565Inst Instance=new A077565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077566
{
public static readonly long[] Value={ 1L,8L,12L,24L,60L,48L,72L,512L,96L,1024L,120L,144L,0L,0L,420L,2310L,240L,8192L,432L,0L,0L,768L,360L,0L,576L,480L,32768L,0L,0L,1536L,0L,864L,0L,0L,720L,1152L,0L,3072L,1080L,960L,0L,0L,1800L,0L,0L,262144L,0L,1728L,0L,6144L,2304L,1680L,0L,524288L,0L,0L,1920L,0L,4620L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077566Inst : IEnumerable<long>
{
public static readonly long[] Value=A077566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077566.Bytes);
public long this[int i]=>Value[i];

public static A077566Inst Instance=new A077566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077567
{
public static readonly long[] Value={ 2L,3L,3L,4L,3L,3L,3L,5L,4L,3L,3L,5L,3L,3L,3L,6L,3L,7L,3L,5L,3L,3L,3L,3L,4L,3L,5L,7L,3L,3L,3L,7L,3L,3L,3L,4L,3L,3L,3L,5L,3L,3L,3L,5L,3L,3L,3L,11L,4L,7L,3L,7L,3L,5L,3L,3L,3L,3L,3L,5L,3L,3L,7L,8L,3L,3L,3L,5L,3L,3L,3L,13L,3L,3L,7L,5L,3L,3L,3L,5L,6L,3L,3L,5L,3L,3L,3L,5L,3L,3L,3L,5L,3L,3L,3L,7L,3L,4L,7L,4L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077567Inst : IEnumerable<long>
{
public static readonly long[] Value=A077567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077567.Bytes);
public long this[int i]=>Value[i];

public static A077567Inst Instance=new A077567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077568
{
public static readonly long[] Value={ 1L,-1L,11L,-39L,633L,-4065L,86355L,-818055L,21370545L,-270059265L,8348125275L,-132575387175L,4724044288425L,-90632895177825L,3652562288650275L,-82321915303002375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077568Inst : IEnumerable<long>
{
public static readonly long[] Value=A077568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077568.Bytes);
public long this[int i]=>Value[i];

public static A077568Inst Instance=new A077568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077569
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,16L,12L,32L,64L,24L,30L,128L,36L,256L,48L,512L,1024L,60L,72L,96L,2048L,4096L,192L,8192L,144L,16384L,120L,210L,216L,384L,32768L,65536L,180L,288L,768L,131072L,262144L,240L,432L,1536L,524288L,576L,1048576L,3072L,2097152L,4194304L,360L,420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077569Inst : IEnumerable<long>
{
public static readonly long[] Value=A077569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077569.Bytes);
public long this[int i]=>Value[i];

public static A077569Inst Instance=new A077569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077570
{
public static readonly long[] Value={ 1L,2L,4L,14L,16L,44L,64L,182L,292L,560L,1024L,2276L,4096L,8384L,16528L,33698L,65536L,132308L,262144L,526496L,1049152L,2100224L,4194304L,8398028L,16778512L,33566720L,67112068L,134244992L,268435456L,536927984L,1073741824L,2147591558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077570Inst : IEnumerable<long>
{
public static readonly long[] Value=A077570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077570.Bytes);
public long this[int i]=>Value[i];

public static A077570Inst Instance=new A077570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077571
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,11L,22L,33L,55L,66L,77L,111L,222L,555L,777L,1111L,2222L,3333L,5555L,6666L,7777L,11111L,22222L,33333L,55555L,66666L,77777L,111111L,222222L,555555L,1111111L,2222222L,3333333L,5555555L,6666666L,7777777L,11111111L,22222222L,33333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077571Inst : IEnumerable<long>
{
public static readonly long[] Value=A077571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077571.Bytes);
public long this[int i]=>Value[i];

public static A077571Inst Instance=new A077571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078020
{
public static readonly long[] Value={ 1L,0L,-2L,-2L,2L,6L,2L,-10L,-14L,6L,34L,22L,-46L,-90L,2L,182L,178L,-186L,-542L,-170L,914L,1254L,-574L,-3082L,-1934L,4230L,8098L,-362L,-16558L,-15834L,17282L,48950L,14386L,-83514L,-112286L,54742L,279314L,169830L,-388798L,-728458L,49138L,1506054L,1407778L,-1604330L,-4419886L,-1211226L,7628546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078020Inst : IEnumerable<long>
{
public static readonly long[] Value=A078020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078020.Bytes);
public long this[int i]=>Value[i];

public static A078020Inst Instance=new A078020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078021
{
public static readonly long[] Value={ 1L,0L,-2L,-3L,1L,9L,10L,-9L,-38L,-30L,55L,153L,73L,-288L,-587L,-84L,1378L,2133L,-539L,-6183L,-7238L,5667L,26326L,22230L,-36089L,-106875L,-56927L,192912L,413641L,84744L,-935450L,-1518579L,267577L,4240185L,5223610L,-3524337L,-18211742L,-16386678L,23561143L,74546241L,43810633L,-128842992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078021Inst : IEnumerable<long>
{
public static readonly long[] Value=A078021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078021.Bytes);
public long this[int i]=>Value[i];

public static A078021Inst Instance=new A078021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078022
{
public static readonly long[] Value={ 1L,0L,-2L,-4L,0L,12L,20L,-4L,-68L,-100L,44L,380L,492L,-356L,-2100L,-2372L,2540L,11484L,11148L,-16900L,-62164L,-50660L,107468L,333116L,219500L,-661668L,-1766900L,-882564L,3974572L,9273500L,3089484L,-23406660L,-48132628L,-7498276L,135580300L,246842108L,-9321940L,-774166756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078022Inst : IEnumerable<long>
{
public static readonly long[] Value=A078022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078022.Bytes);
public long this[int i]=>Value[i];

public static A078022Inst Instance=new A078022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078023
{
public static readonly long[] Value={ 1L,-1L,2L,0L,2L,4L,4L,12L,16L,32L,56L,96L,176L,304L,544L,960L,1696L,3008L,5312L,9408L,16640L,29440L,52096L,92160L,163072L,288512L,510464L,903168L,1597952L,2827264L,5002240L,8850432L,15659008L,27705344L,49018880L,86728704L,153448448L,271495168L,480354304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078023Inst : IEnumerable<long>
{
public static readonly long[] Value=A078023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078023.Bytes);
public long this[int i]=>Value[i];

public static A078023Inst Instance=new A078023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078024
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,3L,0L,5L,3L,10L,11L,23L,32L,57L,87L,146L,231L,379L,608L,989L,1595L,2586L,4179L,6767L,10944L,17713L,28655L,46370L,75023L,121395L,196416L,317813L,514227L,832042L,1346267L,2178311L,3524576L,5702889L,9227463L,14930354L,24157815L,39088171L,63245984L,102334157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078024Inst : IEnumerable<long>
{
public static readonly long[] Value=A078024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078024.Bytes);
public long this[int i]=>Value[i];

public static A078024Inst Instance=new A078024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078025
{
public static readonly long[] Value={ 1L,-1L,2L,-4L,6L,-12L,20L,-36L,64L,-112L,200L,-352L,624L,-1104L,1952L,-3456L,6112L,-10816L,19136L,-33856L,59904L,-105984L,187520L,-331776L,587008L,-1038592L,1837568L,-3251200L,5752320L,-10177536L,18007040L,-31859712L,56369152L,-99733504L,176457728L,-312205312L,552382464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078025Inst : IEnumerable<long>
{
public static readonly long[] Value=A078025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078025.Bytes);
public long this[int i]=>Value[i];

public static A078025Inst Instance=new A078025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078026
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,3L,1L,1L,7L,3L,9L,17L,15L,35L,49L,65L,119L,163L,249L,401L,575L,899L,1377L,2049L,3175L,4803L,7273L,11153L,16879L,25699L,39185L,59457L,90583L,137827L,209497L,318993L,485151L,737987L,1123137L,1708289L,2599111L,3954563L,6015689L,9152785L,13924815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078026Inst : IEnumerable<long>
{
public static readonly long[] Value=A078026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078026.Bytes);
public long this[int i]=>Value[i];

public static A078026Inst Instance=new A078026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078027
{
public static readonly long[] Value={ 1L,-1L,1L,0L,0L,1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,7L,9L,12L,16L,21L,28L,37L,49L,65L,86L,114L,151L,200L,265L,351L,465L,616L,816L,1081L,1432L,1897L,2513L,3329L,4410L,5842L,7739L,10252L,13581L,17991L,23833L,31572L,41824L,55405L,73396L,97229L,128801L,170625L,226030L,299426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078027Inst : IEnumerable<long>
{
public static readonly long[] Value=A078027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078027.Bytes);
public long this[int i]=>Value[i];

public static A078027Inst Instance=new A078027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078028
{
public static readonly long[] Value={ 1L,-1L,1L,-3L,3L,-5L,9L,-11L,19L,-29L,41L,-67L,99L,-149L,233L,-347L,531L,-813L,1225L,-1875L,2851L,-4325L,6601L,-10027L,15251L,-23229L,35305L,-53731L,81763L,-124341L,189225L,-287867L,437907L,-666317L,1013641L,-1542131L,2346275L,-3569413L,5430537L,-8261963L,12569363L,-19123037L,29093289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078028Inst : IEnumerable<long>
{
public static readonly long[] Value=A078028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078028.Bytes);
public long this[int i]=>Value[i];

public static A078028Inst Instance=new A078028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078029
{
public static readonly long[] Value={ 1L,-1L,0L,2L,-2L,0L,4L,-4L,0L,8L,-8L,0L,16L,-16L,0L,32L,-32L,0L,64L,-64L,0L,128L,-128L,0L,256L,-256L,0L,512L,-512L,0L,1024L,-1024L,0L,2048L,-2048L,0L,4096L,-4096L,0L,8192L,-8192L,0L,16384L,-16384L,0L,32768L,-32768L,0L,65536L,-65536L,0L,131072L,-131072L,0L,262144L,-262144L,0L,524288L,-524288L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078029Inst : IEnumerable<long>
{
public static readonly long[] Value=A078029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078029.Bytes);
public long this[int i]=>Value[i];

public static A078029Inst Instance=new A078029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078030
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,2L,0L,4L,-4L,0L,-8L,8L,0L,16L,-16L,0L,-32L,32L,0L,64L,-64L,0L,-128L,128L,0L,256L,-256L,0L,-512L,512L,0L,1024L,-1024L,0L,-2048L,2048L,0L,4096L,-4096L,0L,-8192L,8192L,0L,16384L,-16384L,0L,-32768L,32768L,0L,65536L,-65536L,0L,-131072L,131072L,0L,262144L,-262144L,0L,-524288L,524288L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078030Inst : IEnumerable<long>
{
public static readonly long[] Value=A078030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078030.Bytes);
public long this[int i]=>Value[i];

public static A078030Inst Instance=new A078030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078031
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,0L,-3L,2L,3L,-5L,-1L,8L,-4L,-9L,12L,5L,-21L,7L,26L,-28L,-19L,54L,-9L,-73L,63L,64L,-136L,-1L,200L,-135L,-201L,335L,66L,-536L,269L,602L,-805L,-333L,1407L,-472L,-1740L,1879L,1268L,-3619L,611L,4887L,-4230L,-4276L,9117L,46L,-13393L,9071L,13439L,-22464L,-4368L,35903L,-18096L,-40271L,53999L,22175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078031Inst : IEnumerable<long>
{
public static readonly long[] Value=A078031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078031.Bytes);
public long this[int i]=>Value[i];

public static A078031Inst Instance=new A078031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078032
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,2L,1L,-2L,-3L,1L,5L,2L,-6L,-7L,4L,13L,3L,-17L,-16L,14L,33L,2L,-47L,-35L,45L,82L,-10L,-127L,-72L,137L,199L,-65L,-336L,-134L,401L,470L,-267L,-871L,-203L,1138L,1074L,-935L,-2212L,-139L,3147L,2351L,-3008L,-5498L,657L,8506L,4841L,-9163L,-13347L,4322L,22510L,9025L,-26832L,-31535L,17807L,58367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078032Inst : IEnumerable<long>
{
public static readonly long[] Value=A078032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078032.Bytes);
public long this[int i]=>Value[i];

public static A078032Inst Instance=new A078032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078033
{
public static readonly long[] Value={ 1L,-1L,-1L,-1L,3L,3L,-1L,-9L,-5L,11L,23L,-1L,-45L,-45L,47L,135L,43L,-229L,-313L,143L,771L,483L,-1057L,-2025L,91L,4139L,3959L,-4321L,-12237L,-3597L,20879L,28071L,-13685L,-69829L,-42457L,97199L,182115L,-12285L,-376513L,-351945L,401083L,1104971L,302807L,-1907137L,-2512749L,1301523L,6327023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078033Inst : IEnumerable<long>
{
public static readonly long[] Value=A078033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078033.Bytes);
public long this[int i]=>Value[i];

public static A078033Inst Instance=new A078033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078034
{
public static readonly long[] Value={ 1L,-1L,-2L,4L,2L,-12L,4L,28L,-32L,-48L,120L,32L,-336L,176L,736L,-1024L,-1120L,3520L,192L,-9280L,6656L,18944L,-31872L,-24576L,101632L,-14592L,-252416L,232448L,475648L,-969728L,-486400L,2890752L,-966656L,-6754304L,7714816L,11575296L,-28938240L,-7720960L,81027072L,-42434560L,-177496064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078034Inst : IEnumerable<long>
{
public static readonly long[] Value=A078034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078034.Bytes);
public long this[int i]=>Value[i];

public static A078034Inst Instance=new A078034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078035
{
public static readonly long[] Value={ 1L,-1L,-2L,3L,3L,-8L,-3L,19L,-2L,-41L,23L,80L,-87L,-137L,254L,187L,-645L,-120L,1477L,-405L,-3074L,2287L,5743L,-7648L,-9199L,21039L,10750L,-51277L,-461L,113304L,-50355L,-227069L,214014L,403783L,-655097L,-593552L,1713977L,532007L,-4021506L,649963L,8575019L,-5321432L,-16500075L,19217883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078035Inst : IEnumerable<long>
{
public static readonly long[] Value=A078035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078035.Bytes);
public long this[int i]=>Value[i];

public static A078035Inst Instance=new A078035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078052
{
public static readonly long[] Value={ 1L,-2L,0L,2L,2L,-6L,-2L,10L,6L,-22L,-10L,42L,22L,-86L,-42L,170L,86L,-342L,-170L,682L,342L,-1366L,-682L,2730L,1366L,-5462L,-2730L,10922L,5462L,-21846L,-10922L,43690L,21846L,-87382L,-43690L,174762L,87382L,-349526L,-174762L,699050L,349526L,-1398102L,-699050L,2796202L,1398102L,-5592406L,-2796202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078052Inst : IEnumerable<long>
{
public static readonly long[] Value=A078052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078052.Bytes);
public long this[int i]=>Value[i];

public static A078052Inst Instance=new A078052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078053
{
public static readonly long[] Value={ 1L,-3L,8L,-20L,50L,-124L,308L,-764L,1896L,-4704L,11672L,-28960L,71856L,-178288L,442368L,-1097600L,2723360L,-6757184L,16765888L,-41599424L,103216256L,-256099584L,635432832L,-1576632320L,3911931136L,-9706261248L,24083120128L,-59754900480L,148263518720L,-367870598144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078053Inst : IEnumerable<long>
{
public static readonly long[] Value=A078053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078053.Bytes);
public long this[int i]=>Value[i];

public static A078053Inst Instance=new A078053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078054
{
public static readonly long[] Value={ 1L,-3L,8L,-23L,65L,-184L,521L,-1475L,4176L,-11823L,33473L,-94768L,268305L,-759619L,2150616L,-6088775L,17238401L,-48804968L,138175513L,-391199363L,1107554720L,-3135683679L,8877676161L,-25134274400L,71159584801L,-201465394563L,570384233128L,-1614858840183L,4571951541185L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078054Inst : IEnumerable<long>
{
public static readonly long[] Value=A078054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078054.Bytes);
public long this[int i]=>Value[i];

public static A078054Inst Instance=new A078054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078055
{
public static readonly long[] Value={ 1L,-3L,8L,-24L,70L,-204L,596L,-1740L,5080L,-14832L,43304L,-126432L,369136L,-1077744L,3146624L,-9187008L,26822752L,-78312768L,228645056L,-667561152L,1949037952L,-5690488320L,16614174848L,-48507402240L,141624130816L,-413491415808L,1207245897728L,-3524722888704L,10290920404480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078055Inst : IEnumerable<long>
{
public static readonly long[] Value=A078055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078055.Bytes);
public long this[int i]=>Value[i];

public static A078055Inst Instance=new A078055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078056
{
public static readonly long[] Value={ 1L,-3L,7L,-16L,36L,-81L,182L,-409L,919L,-2065L,4640L,-10426L,23427L,-52640L,118281L,-265775L,597191L,-1341876L,3015168L,-6775021L,15223334L,-34206521L,76861355L,-172705897L,388066628L,-871977798L,1959316327L,-4402543824L,9892426177L,-22228079851L,49946042055L,-112227737784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078056Inst : IEnumerable<long>
{
public static readonly long[] Value=A078056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078056.Bytes);
public long this[int i]=>Value[i];

public static A078056Inst Instance=new A078056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078057
{
public static readonly long[] Value={ 1L,3L,7L,17L,41L,99L,239L,577L,1393L,3363L,8119L,19601L,47321L,114243L,275807L,665857L,1607521L,3880899L,9369319L,22619537L,54608393L,131836323L,318281039L,768398401L,1855077841L,4478554083L,10812186007L,26102926097L,63018038201L,152139002499L,367296043199L,886731088897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078057Inst : IEnumerable<long>
{
public static readonly long[] Value=A078057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078057.Bytes);
public long this[int i]=>Value[i];

public static A078057Inst Instance=new A078057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078058
{
public static readonly long[] Value={ 1L,-3L,7L,-18L,46L,-117L,298L,-759L,1933L,-4923L,12538L,-31932L,81325L,-207120L,527497L,-1343439L,3421495L,-8713926L,22192786L,-56520993L,143948698L,-366611175L,933692041L,-2377943955L,6056191126L,-15424018248L,39282171577L,-100044552528L,254795294881L,-648917313867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078058Inst : IEnumerable<long>
{
public static readonly long[] Value=A078058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078058.Bytes);
public long this[int i]=>Value[i];

public static A078058Inst Instance=new A078058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078059
{
public static readonly long[] Value={ 1L,-3L,7L,-19L,51L,-135L,359L,-955L,2539L,-6751L,17951L,-47731L,126915L,-337463L,897303L,-2385899L,6344027L,-16868559L,44852943L,-119262499L,317115059L,-843198503L,2242037063L,-5961502747L,15851439563L,-42148455999L,112071357055L,-297994049235L,792356367523L,-2106849498391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078059Inst : IEnumerable<long>
{
public static readonly long[] Value=A078059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078059.Bytes);
public long this[int i]=>Value[i];

public static A078059Inst Instance=new A078059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078060
{
public static readonly long[] Value={ 1L,-3L,6L,-10L,14L,-16L,12L,4L,-40L,104L,-200L,320L,-432L,464L,-288L,-288L,1504L,-3584L,6592L,-10176L,13184L,-13184L,6016L,14336L,-55040L,122112L,-215552L,321024L,-397824L,364544L,-87040L,-621568L,1972224L,-4118528L,6993920L,-10043392L,11849728L,-9711616L,-663552L,25026560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078060Inst : IEnumerable<long>
{
public static readonly long[] Value=A078060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078060.Bytes);
public long this[int i]=>Value[i];

public static A078060Inst Instance=new A078060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078061
{
public static readonly long[] Value={ 1L,-3L,6L,-13L,29L,-64L,141L,-311L,686L,-1513L,3337L,-7360L,16233L,-35803L,78966L,-174165L,384133L,-847232L,1868629L,-4121391L,9090014L,-20048657L,44218705L,-97527424L,215103505L,-474425715L,1046378854L,-2307861213L,5090148141L,-11226675136L,24761211485L,-54612571111L,120451817358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078061Inst : IEnumerable<long>
{
public static readonly long[] Value=A078061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078061.Bytes);
public long this[int i]=>Value[i];

public static A078061Inst Instance=new A078061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078062
{
public static readonly long[] Value={ 1L,-3L,6L,-14L,34L,-80L,188L,-444L,1048L,-2472L,5832L,-13760L,32464L,-76592L,180704L,-426336L,1005856L,-2373120L,5598912L,-13209536L,31165312L,-73528448L,173475968L,-409282560L,965622016L,-2278195968L,5374957056L,-12681158144L,29918708224L,-70587330560L,166536977408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078062Inst : IEnumerable<long>
{
public static readonly long[] Value=A078062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078062.Bytes);
public long this[int i]=>Value[i];

public static A078062Inst Instance=new A078062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078063
{
public static readonly long[] Value={ 1L,-3L,5L,-5L,-1L,17L,-43L,67L,-57L,-39L,269L,-613L,879L,-607L,-891L,4147L,-8617L,11305L,-5699L,-17141L,62591L,-119439L,142005L,-39389L,-302105L,927609L,-1631891L,1731963L,23183L,-5042111L,13524965L,-21961453L,20313719L,8383945L,-81004515L,194252523L,-290732641L,225203729L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078063Inst : IEnumerable<long>
{
public static readonly long[] Value=A078063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078063.Bytes);
public long this[int i]=>Value[i];

public static A078063Inst Instance=new A078063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078064
{
public static readonly long[] Value={ 1L,-3L,5L,-6L,4L,3L,-16L,33L,-47L,45L,-10L,-72L,199L,-336L,401L,-267L,-203L,1074L,-2212L,3147L,-3008L,657L,4841L,-13347L,22510L,-26832L,17807L,13728L,-72095L,148269L,-210715L,201066L,-43148L,-325485L,895184L,-1508031L,1795393L,-1187571L,-928282L,4839528L,-9938345L,14108880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078064Inst : IEnumerable<long>
{
public static readonly long[] Value=A078064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078064.Bytes);
public long this[int i]=>Value[i];

public static A078064Inst Instance=new A078064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078065
{
public static readonly long[] Value={ 1L,-3L,5L,-8L,14L,-25L,44L,-77L,135L,-237L,416L,-730L,1281L,-2248L,3945L,-6923L,12149L,-21320L,37414L,-65657L,115220L,-202197L,354831L,-622685L,1092736L,-1917618L,3365185L,-5905488L,10363409L,-18186515L,31915109L,-56007112L,98285630L,-172479257L,302679996L,-531166365L,932131991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078065Inst : IEnumerable<long>
{
public static readonly long[] Value=A078065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078065.Bytes);
public long this[int i]=>Value[i];

public static A078065Inst Instance=new A078065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078066
{
public static readonly long[] Value={ 1L,-3L,5L,-9L,19L,-39L,77L,-153L,307L,-615L,1229L,-2457L,4915L,-9831L,19661L,-39321L,78643L,-157287L,314573L,-629145L,1258291L,-2516583L,5033165L,-10066329L,20132659L,-40265319L,80530637L,-161061273L,322122547L,-644245095L,1288490189L,-2576980377L,5153960755L,-10307921511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078066Inst : IEnumerable<long>
{
public static readonly long[] Value=A078066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078066.Bytes);
public long this[int i]=>Value[i];

public static A078066Inst Instance=new A078066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078067
{
public static readonly long[] Value={ 1L,-3L,4L,0L,-14L,36L,-44L,-12L,184L,-432L,472L,288L,-2384L,5136L,-4928L,-5184L,30496L,-60480L,49600L,82752L,-385664L,705024L,-473216L,-1234944L,4826368L,-8129280L,4135936L,17639424L,-59809280L,92611584L,-30325760L,-244190208L,734255104L,-1040781312L,124672000L,3300728832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078067Inst : IEnumerable<long>
{
public static readonly long[] Value=A078067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078067.Bytes);
public long this[int i]=>Value[i];

public static A078067Inst Instance=new A078067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078212
{
public static readonly long[] Value={ 0L,222L,0L,434L,55L,676L,7157L,8018L,989L,101210L,11811L,121212L,130913L,141814L,152515L,162816L,174817L,185318L,191419L,200220L,210021L,222622L,23323L,241724L,254625L,2626L,279027L,289328L,292229L,306230L,311531L,323832L,330033L,348334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078212Inst : IEnumerable<long>
{
public static readonly long[] Value=A078212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078212.Bytes);
public long this[int i]=>Value[i];

public static A078212Inst Instance=new A078212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078213
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10810L,119911L,12612L,1310413L,1411214L,15315L,162016L,1745917L,1818L,1968419L,207920L,2116821L,227722L,2318423L,244824L,252925L,269126L,272727L,283528L,2923229L,3069930L,31275931L,3268832L,3375933L,3457834L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078213Inst : IEnumerable<long>
{
public static readonly long[] Value=A078213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078213.Bytes);
public long this[int i]=>Value[i];

public static A078213Inst Instance=new A078213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078214
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1081L,10901L,1051L,100801L,100801L,1021L,10126L,102701L,101L,103601L,10396L,100801L,10351L,100801L,10201L,10117L,10351L,10101L,10126L,100801L,102331L,1008901L,102151L,102301L,101701L,101341L,10276L,100801L,101251L,10201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078214Inst : IEnumerable<long>
{
public static readonly long[] Value=A078214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078214.Bytes);
public long this[int i]=>Value[i];

public static A078214Inst Instance=new A078214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078215
{
public static readonly BigInteger[] Value={ 1L,25L,3025L,48400L,5856400L,6377619600L,771691971600L,840372557072400L,915165714651843600L,BigInteger.Parse("1057931566137531201600"),BigInteger.Parse("1152087475523771478542400"),BigInteger.Parse("1254623260845387140132673600"),BigInteger.Parse("1366284731060626595604481550400") };
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
public class A078215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078215Inst Instance=new A078215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078216
{
public static readonly BigInteger[] Value={ 1L,5L,55L,220L,2420L,79860L,878460L,28989180L,956642940L,32525859960L,1073353378680L,35420661496440L,1168881829382520L,38573100369623160L,1234339211827941120L,BigInteger.Parse("40733193990322056960"),BigInteger.Parse("4154785787012849809920") };
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
public class A078216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078216Inst Instance=new A078216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078217
{
public static readonly BigInteger[] Value={ 1L,10L,12L,132L,12340L,150L,1234562L,13576L,124578L,13790L,123456789104L,157116L,12345678910111209L,135911132L,124781113140L,135791113152L,BigInteger.Parse("123456789101112131415167"),1571113170L,BigInteger.Parse("1234567891011121314151617186") };
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
public class A078217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078217Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078217.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078217Inst Instance=new A078217Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078218
{
public static readonly long[] Value={ 1L,12L,132L,124L,15L,1236L,175L,1248L,1395L,12510L,1111L,12346128L,1131L,127148L,13515L,124816L,1173L,12369186L,1197L,12451020L,137214L,12112210L,12305L,1234681224L,1525L,1213264L,1392714L,1247142820L,12905L,12356101530L,13113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078218Inst : IEnumerable<long>
{
public static readonly long[] Value=A078218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078218.Bytes);
public long this[int i]=>Value[i];

public static A078218Inst Instance=new A078218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078219
{
public static readonly long[] Value={ 4L,1L,12L,15L,2L,23L,26L,3L,34L,4L,41L,45L,5L,52L,56L,6L,63L,67L,7L,74L,8L,81L,85L,9L,92L,96L,10L,103L,11L,111L,115L,12L,122L,126L,13L,133L,137L,14L,144L,15L,151L,155L,16L,162L,166L,17L,173L,18L,181L,184L,19L,192L,195L,20L,203L,207L,21L,214L,22L,221L,225L,23L,232L,236L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078219Inst : IEnumerable<long>
{
public static readonly long[] Value=A078219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078219.Bytes);
public long this[int i]=>Value[i];

public static A078219Inst Instance=new A078219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078220
{
public static readonly long[] Value={ 4L,7L,1L,13L,16L,2L,23L,26L,3L,32L,36L,4L,42L,45L,5L,51L,55L,6L,61L,64L,7L,71L,74L,77L,8L,83L,86L,9L,93L,96L,10L,102L,106L,11L,112L,115L,12L,121L,125L,13L,131L,134L,14L,141L,144L,147L,15L,153L,156L,16L,163L,166L,17L,172L,176L,18L,182L,185L,19L,191L,195L,20L,201L,204L,21L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078220Inst : IEnumerable<long>
{
public static readonly long[] Value=A078220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078220.Bytes);
public long this[int i]=>Value[i];

public static A078220Inst Instance=new A078220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078221
{
public static readonly BigInteger[] Value={ 1L,3L,9L,99L,9999L,99999999L,9999999999999999L,BigInteger.Parse("99999999999999999999999999999999"),BigInteger.Parse("9999999999999999999999999999999999999999999999999999999999999999") };
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
public class A078221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078221Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078221.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078221Inst Instance=new A078221Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078222
{
public static readonly long[] Value={ 2L,4L,8L,24L,48L,240L,480L,2400L,4800L,24000L,48000L,240000L,480000L,2400000L,4800000L,24000000L,48000000L,240000000L,480000000L,2400000000L,4800000000L,24000000000L,48000000000L,240000000000L,480000000000L,2400000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078222Inst : IEnumerable<long>
{
public static readonly long[] Value=A078222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078222.Bytes);
public long this[int i]=>Value[i];

public static A078222Inst Instance=new A078222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078223
{
public static readonly BigInteger[] Value={ 2L,4L,8L,24L,48L,288L,864L,6048L,260064L,26266464L,40082624064L,866826828008064L,BigInteger.Parse("26444286042042008448"),BigInteger.Parse("20286626620462624006244884224") };
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
public class A078223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078223Inst Instance=new A078223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078224
{
public static readonly long[] Value={ 2L,2L,3L,2L,6L,3L,7L,43L,101L,1526L,21626L,30507L,767145938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078224Inst : IEnumerable<long>
{
public static readonly long[] Value=A078224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078224.Bytes);
public long this[int i]=>Value[i];

public static A078224Inst Instance=new A078224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078225
{
public static readonly BigInteger[] Value={ 3L,3L,11L,101L,10001L,100000001L,10000000000000001L,BigInteger.Parse("100000000000000000000000000000001"),BigInteger.Parse("10000000000000000000000000000000000000000000000000000000000000001") };
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
public class A078225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078225Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078225.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078225Inst Instance=new A078225Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078226
{
public static readonly BigInteger[] Value={ 1L,3L,9L,27L,81L,567L,8505L,76545L,9874305L,6763898925L,41672381276925L,BigInteger.Parse("25432529276163496725"),BigInteger.Parse("6947294789656341278149816125"),BigInteger.Parse("2341412581496361870123890149638785410125") };
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
public class A078226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078226Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078226.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078226Inst Instance=new A078226Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078227
{
public static readonly BigInteger[] Value={ 2L,4L,8L,16L,32L,96L,672L,45696L,2787456L,270383232L,507238943232L,27274745216527872L,BigInteger.Parse("141232121898569036783616"),BigInteger.Parse("216567470725252501672125832323072") };
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
public class A078227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078227Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078227.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078227Inst Instance=new A078227Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078388
{
public static readonly long[] Value={ 1L,1L,6L,7L,16L,1L,44L,15L,32L,1L,14L,60L,1L,1L,48L,45L,56L,22L,51L,18L,72L,156L,1L,80L,176L,43L,1L,20L,140L,1L,216L,1L,63L,165L,1L,448L,46L,69L,50L,34L,152L,185L,236L,30L,168L,129L,123L,151L,62L,42L,216L,252L,1L,284L,105L,432L,38L,284L,1L,240L,115L,356L,1L,1L,211L,456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078388Inst : IEnumerable<long>
{
public static readonly long[] Value=A078388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078388.Bytes);
public long this[int i]=>Value[i];

public static A078388Inst Instance=new A078388Inst();

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