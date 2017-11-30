using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A268903
{
public static readonly BigInteger[] Value={ 576L,34344L,1585800L,66210264L,2611960344L,99308573208L,3679171151832L,133712637011640L,4788143315276472L,169455769674019992L,5940079034652505944L,BigInteger.Parse("206577531186380751096"),BigInteger.Parse("7136252899974195705720"),BigInteger.Parse("245118805391945325271896") };
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
public class A268903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268903Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268903.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268903.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268903Inst Instance=new A268903Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268902
{
public static readonly BigInteger[] Value={ 240L,9720L,299088L,8250912L,214142760L,5344944120L,129834259704L,3091414865040L,72488795124312L,1679265104747616L,38520989302343760L,876481043382776664L,BigInteger.Parse("19806871824479466648"),BigInteger.Parse("444994736265664134120"),BigInteger.Parse("9947337685046673808176") };
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
public class A268902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268902Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268902.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268902.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268902Inst Instance=new A268902Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268901
{
public static readonly ulong[] Value={ 96L,2664L,54936L,1004184L,17194680L,282550680L,4513169016L,70609114584L,1087342615224L,16536864398616L,248976164499192L,3717450986032728L,55118358414612792L,812385229848253848L,11912420604393611640UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268901Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A268901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268901.Bytes);
public ulong this[int i]=>Value[i];

public static A268901Inst Instance=new A268901Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268900
{
public static readonly long[] Value={ 36L,696L,9720L,118584L,1347192L,14644152L,154472184L,1594323000L,16185567096L,162200044728L,1608569870328L,15816054042936L,154394813276280L,1498006261495224L,14458132831535352L,138907883786523192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268900Inst : IEnumerable<long>
{
public static readonly long[] Value=A268900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268900.Bytes);
public long this[int i]=>Value[i];

public static A268900Inst Instance=new A268900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268835
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,3L,2L,3L,4L,5L,2L,1L,4L,3L,2L,3L,4L,5L,4L,3L,6L,5L,2L,3L,2L,1L,4L,5L,4L,3L,2L,3L,4L,5L,4L,3L,6L,5L,4L,5L,4L,3L,6L,7L,6L,5L,2L,3L,4L,3L,2L,3L,2L,3L,4L,5L,6L,5L,4L,3L,4L,3L,2L,3L,4L,5L,4L,3L,6L,5L,4L,5L,4L,3L,6L,7L,6L,5L,4L,5L,6L,5L,4L,5L,4L,5L,6L,7L,8L,7L,6L,5L,6L,5L,2L,3L,4L,3L,4L,5L,4L,5L,2L,3L,4L,5L,2L,1L,4L,3L,4L,5L,6L,5L,6L,5L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268835Inst : IEnumerable<long>
{
public static readonly long[] Value=A268835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268835.Bytes);
public long this[int i]=>Value[i];

public static A268835Inst Instance=new A268835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268834
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,1L,2L,1L,0L,2L,3L,2L,1L,0L,3L,2L,3L,2L,1L,0L,2L,1L,2L,1L,2L,1L,0L,1L,2L,3L,2L,3L,2L,1L,0L,2L,3L,4L,3L,2L,1L,2L,1L,0L,3L,2L,3L,4L,3L,2L,1L,2L,1L,0L,4L,3L,2L,3L,4L,3L,2L,3L,2L,1L,0L,3L,4L,1L,2L,3L,4L,3L,2L,3L,2L,1L,0L,2L,3L,2L,3L,2L,3L,2L,1L,2L,1L,2L,1L,0L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L,1L,2L,1L,0L,2L,1L,2L,1L,4L,3L,2L,3L,4L,3L,2L,3L,2L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268834Inst : IEnumerable<long>
{
public static readonly long[] Value=A268834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268834.Bytes);
public long this[int i]=>Value[i];

public static A268834Inst Instance=new A268834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268833
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,1L,2L,1L,0L,1L,2L,3L,2L,0L,1L,2L,3L,2L,3L,0L,1L,2L,1L,2L,1L,2L,0L,1L,2L,3L,2L,3L,2L,1L,0L,1L,2L,1L,2L,3L,4L,3L,2L,0L,1L,2L,1L,2L,3L,4L,3L,2L,3L,0L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,0L,1L,2L,3L,2L,3L,4L,3L,2L,1L,4L,3L,0L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,0L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,0L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268833Inst : IEnumerable<long>
{
public static readonly long[] Value=A268833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268833.Bytes);
public long this[int i]=>Value[i];

public static A268833Inst Instance=new A268833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268832
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,4L,5L,19L,18L,11L,10L,9L,8L,13L,12L,27L,26L,35L,34L,33L,32L,37L,36L,21L,20L,17L,16L,31L,30L,15L,14L,43L,42L,51L,50L,49L,48L,53L,52L,69L,68L,65L,64L,47L,46L,63L,62L,29L,28L,25L,24L,55L,54L,23L,22L,67L,66L,59L,58L,57L,56L,61L,60L,75L,74L,83L,82L,81L,80L,85L,84L,101L,100L,97L,96L,79L,78L,95L,94L,125L,124L,121L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268832Inst : IEnumerable<long>
{
public static readonly long[] Value=A268832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268832.Bytes);
public long this[int i]=>Value[i];

public static A268832Inst Instance=new A268832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268831
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,4L,13L,12L,11L,10L,15L,14L,31L,30L,27L,26L,9L,8L,25L,24L,55L,54L,51L,50L,17L,16L,49L,48L,29L,28L,21L,20L,19L,18L,23L,22L,103L,102L,99L,98L,33L,32L,97L,96L,45L,44L,37L,36L,35L,34L,39L,38L,53L,52L,61L,60L,59L,58L,63L,62L,47L,46L,43L,42L,57L,56L,41L,40L,199L,198L,195L,194L,65L,64L,193L,192L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268831Inst : IEnumerable<long>
{
public static readonly long[] Value=A268831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268831.Bytes);
public long this[int i]=>Value[i];

public static A268831Inst Instance=new A268831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268830
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,4L,1L,0L,4L,2L,3L,1L,0L,5L,6L,2L,3L,1L,0L,6L,8L,9L,2L,3L,1L,0L,7L,3L,8L,9L,2L,3L,1L,0L,8L,7L,5L,5L,6L,2L,3L,1L,0L,9L,10L,4L,4L,7L,8L,2L,3L,1L,0L,10L,12L,13L,6L,4L,6L,7L,2L,3L,1L,0L,11L,15L,12L,13L,5L,4L,6L,7L,2L,3L,1L,0L,12L,11L,17L,17L,18L,5L,4L,6L,7L,2L,3L,1L,0L,13L,5L,16L,16L,19L,20L,5L,4L,6L,7L,2L,3L,1L,0L,14L,13L,7L,18L,16L,18L,19L,5L,4L,6L,7L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268830Inst : IEnumerable<long>
{
public static readonly long[] Value=A268830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268830.Bytes);
public long this[int i]=>Value[i];

public static A268830Inst Instance=new A268830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268829
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,3L,1L,15L,0L,1L,1L,9L,7L,1L,3L,1L,27L,7L,1L,5L,1L,1L,29L,0L,1L,0L,0L,3L,1L,23L,3L,1L,5L,9L,1L,3L,1L,17L,3L,1L,3L,15L,15L,5L,3L,1L,51L,0L,1L,3L,0L,0L,15L,0L,1L,1L,53L,7L,1L,13L,31L,11L,9L,1L,1L,3L,1L,63L,7L,1L,0L,21L,7L,27L,9L,0L,5L,3L,1L,57L,0L,1L,13L,0L,5L,29L,0L,13L,1L,0L,3L,1L,43L,3L,1L,3L,53L,15L,23L,9L,25L,1L,7L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268829Inst : IEnumerable<long>
{
public static readonly long[] Value=A268829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268829.Bytes);
public long this[int i]=>Value[i];

public static A268829Inst Instance=new A268829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268828
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,6L,4L,5L,20L,18L,9L,17L,7L,11L,10L,12L,28L,26L,33L,25L,31L,35L,34L,36L,19L,15L,14L,16L,32L,30L,13L,29L,44L,42L,49L,41L,47L,51L,50L,52L,67L,63L,62L,64L,48L,46L,61L,45L,27L,23L,22L,24L,56L,54L,21L,53L,68L,66L,57L,65L,55L,59L,58L,60L,76L,74L,81L,73L,79L,83L,82L,84L,99L,95L,94L,96L,80L,78L,93L,77L,123L,119L,118L,120L,88L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268828Inst : IEnumerable<long>
{
public static readonly long[] Value=A268828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268828.Bytes);
public long this[int i]=>Value[i];

public static A268828Inst Instance=new A268828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268827
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,5L,12L,4L,10L,14L,13L,15L,30L,26L,25L,27L,11L,9L,24L,8L,54L,50L,49L,51L,19L,17L,48L,16L,31L,29L,20L,28L,18L,22L,21L,23L,102L,98L,97L,99L,35L,33L,96L,32L,47L,45L,36L,44L,34L,38L,37L,39L,55L,53L,60L,52L,58L,62L,61L,63L,46L,42L,41L,43L,59L,57L,40L,56L,198L,194L,193L,195L,67L,65L,192L,64L,79L,77L,68L,76L,66L,70L,69L,71L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268827Inst : IEnumerable<long>
{
public static readonly long[] Value=A268827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268827.Bytes);
public long this[int i]=>Value[i];

public static A268827Inst Instance=new A268827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268826
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,4L,5L,18L,19L,16L,17L,10L,11L,8L,9L,26L,27L,24L,25L,34L,35L,32L,33L,14L,15L,12L,13L,30L,31L,28L,29L,42L,43L,40L,41L,50L,51L,48L,49L,62L,63L,60L,61L,46L,47L,44L,45L,22L,23L,20L,21L,54L,55L,52L,53L,66L,67L,64L,65L,58L,59L,56L,57L,74L,75L,72L,73L,82L,83L,80L,81L,94L,95L,92L,93L,78L,79L,76L,77L,118L,119L,116L,117L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268826Inst : IEnumerable<long>
{
public static readonly long[] Value=A268826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268826.Bytes);
public long this[int i]=>Value[i];

public static A268826Inst Instance=new A268826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268825
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,4L,5L,14L,15L,12L,13L,26L,27L,24L,25L,10L,11L,8L,9L,50L,51L,48L,49L,18L,19L,16L,17L,30L,31L,28L,29L,22L,23L,20L,21L,98L,99L,96L,97L,34L,35L,32L,33L,46L,47L,44L,45L,38L,39L,36L,37L,54L,55L,52L,53L,62L,63L,60L,61L,42L,43L,40L,41L,58L,59L,56L,57L,194L,195L,192L,193L,66L,67L,64L,65L,78L,79L,76L,77L,70L,71L,68L,69L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268825Inst : IEnumerable<long>
{
public static readonly long[] Value=A268825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268825.Bytes);
public long this[int i]=>Value[i];

public static A268825Inst Instance=new A268825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268824
{
public static readonly long[] Value={ 0L,1L,3L,2L,9L,5L,4L,6L,13L,17L,16L,18L,10L,8L,15L,7L,21L,25L,24L,26L,34L,32L,23L,31L,14L,12L,27L,11L,33L,29L,28L,30L,37L,41L,40L,42L,50L,48L,39L,47L,62L,60L,43L,59L,49L,45L,44L,46L,22L,20L,51L,19L,57L,53L,52L,54L,61L,65L,64L,66L,58L,56L,63L,55L,69L,73L,72L,74L,82L,80L,71L,79L,94L,92L,75L,91L,81L,77L,76L,78L,118L,116L,83L,115L,89L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268824Inst : IEnumerable<long>
{
public static readonly long[] Value=A268824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268824.Bytes);
public long this[int i]=>Value[i];

public static A268824Inst Instance=new A268824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268823
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,5L,7L,15L,13L,4L,12L,27L,25L,8L,24L,14L,10L,9L,11L,51L,49L,16L,48L,22L,18L,17L,19L,26L,30L,29L,31L,23L,21L,28L,20L,99L,97L,32L,96L,38L,34L,33L,35L,42L,46L,45L,47L,39L,37L,44L,36L,50L,54L,53L,55L,63L,61L,52L,60L,43L,41L,56L,40L,62L,58L,57L,59L,195L,193L,64L,192L,70L,66L,65L,67L,74L,78L,77L,79L,71L,69L,76L,68L,82L,86L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268823Inst : IEnumerable<long>
{
public static readonly long[] Value=A268823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268823.Bytes);
public long this[int i]=>Value[i];

public static A268823Inst Instance=new A268823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268822
{
public static readonly long[] Value={ 0L,1L,3L,2L,9L,8L,5L,4L,13L,12L,17L,16L,7L,6L,15L,14L,21L,20L,25L,24L,31L,30L,23L,22L,11L,10L,27L,26L,33L,32L,29L,28L,37L,36L,41L,40L,47L,46L,39L,38L,59L,58L,43L,42L,49L,48L,45L,44L,19L,18L,51L,50L,57L,56L,53L,52L,61L,60L,65L,64L,55L,54L,63L,62L,69L,68L,73L,72L,79L,78L,71L,70L,91L,90L,75L,74L,81L,80L,77L,76L,115L,114L,83L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268822Inst : IEnumerable<long>
{
public static readonly long[] Value=A268822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268822.Bytes);
public long this[int i]=>Value[i];

public static A268822Inst Instance=new A268822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268821
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,13L,12L,5L,4L,25L,24L,9L,8L,15L,14L,11L,10L,49L,48L,17L,16L,23L,22L,19L,18L,27L,26L,31L,30L,21L,20L,29L,28L,97L,96L,33L,32L,39L,38L,35L,34L,43L,42L,47L,46L,37L,36L,45L,44L,51L,50L,55L,54L,61L,60L,53L,52L,41L,40L,57L,56L,63L,62L,59L,58L,193L,192L,65L,64L,71L,70L,67L,66L,75L,74L,79L,78L,69L,68L,77L,76L,83L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268821Inst : IEnumerable<long>
{
public static readonly long[] Value=A268821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268821.Bytes);
public long this[int i]=>Value[i];

public static A268821Inst Instance=new A268821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268820
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,0L,3L,3L,1L,0L,4L,6L,3L,1L,0L,5L,2L,2L,3L,1L,0L,6L,12L,7L,2L,3L,1L,0L,7L,4L,6L,6L,2L,3L,1L,0L,8L,7L,13L,5L,6L,2L,3L,1L,0L,9L,5L,12L,7L,7L,6L,2L,3L,1L,0L,10L,24L,5L,15L,4L,7L,6L,2L,3L,1L,0L,11L,8L,4L,13L,5L,5L,7L,6L,2L,3L,1L,0L,12L,11L,25L,4L,14L,12L,5L,7L,6L,2L,3L,1L,0L,13L,9L,24L,12L,15L,4L,4L,5L,7L,6L,2L,3L,1L,0L,14L,13L,9L,27L,12L,10L,13L,4L,5L,7L,6L,2L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268820Inst : IEnumerable<long>
{
public static readonly long[] Value=A268820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268820.Bytes);
public long this[int i]=>Value[i];

public static A268820Inst Instance=new A268820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268771
{
public static readonly long[] Value={ 96L,248L,1524L,10340L,64112L,387146L,2258084L,12951796L,73011192L,406925194L,2244513800L,12281806624L,66734787464L,360505595710L,1937557458852L,10367717536488L,55261185262316L,293537189567482L,1554428843176696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268771Inst : IEnumerable<long>
{
public static readonly long[] Value=A268771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268771.Bytes);
public long this[int i]=>Value[i];

public static A268771Inst Instance=new A268771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268770
{
public static readonly long[] Value={ 36L,100L,446L,2296L,10340L,46312L,198114L,837848L,3472210L,14245712L,57796288L,232692368L,930069146L,3696103032L,14612457534L,57516087912L,225502135332L,881077245816L,3431904293122L,13330760323672L,51652205043266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268770Inst : IEnumerable<long>
{
public static readonly long[] Value=A268770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268770.Bytes);
public long this[int i]=>Value[i];

public static A268770Inst Instance=new A268770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268769
{
public static readonly long[] Value={ 12L,32L,112L,446L,1524L,5214L,17000L,54822L,173244L,541910L,1676448L,5146030L,15683076L,47518926L,143238872L,429867830L,1285009740L,3828046534L,11368576272L,33669165246L,99465517716L,293175780030L,862355454792L,2531766659654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268769Inst : IEnumerable<long>
{
public static readonly long[] Value=A268769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268769.Bytes);
public long this[int i]=>Value[i];

public static A268769Inst Instance=new A268769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268768
{
public static readonly long[] Value={ 3L,12L,32L,100L,248L,620L,1456L,3380L,7656L,17148L,37920L,83140L,180824L,390796L,839824L,1796180L,3825352L,8116764L,17165568L,36195300L,76118840L,159694252L,334301552L,698429300L,1456510888L,3032326460L,6303262176L,13083742980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268768Inst : IEnumerable<long>
{
public static readonly long[] Value=A268768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268768.Bytes);
public long this[int i]=>Value[i];

public static A268768Inst Instance=new A268768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268767
{
public static readonly BigInteger[] Value={ 0L,12L,112L,2296L,64112L,3104544L,255353744L,36091542548L,8990276037592L,3911658481295924L,3022669494445395808L,BigInteger.Parse("4128305052223833006600"),BigInteger.Parse("10045914708457218016317000"),BigInteger.Parse("43496963453603913793217952196") };
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
public class A268767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268767Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268767.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268767.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268767Inst Instance=new A268767Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268766
{
public static readonly long[] Value={ 0L,1L,1L,2L,6L,2L,5L,15L,15L,5L,10L,44L,56L,44L,10L,20L,105L,223L,223L,105L,20L,38L,258L,762L,1148L,762L,258L,38L,71L,595L,2607L,5170L,5170L,2607L,595L,71L,130L,1368L,8500L,23156L,32056L,23156L,8500L,1368L,130L,235L,3069L,27411L,99057L,193573L,193573L,99057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268766Inst : IEnumerable<long>
{
public static readonly long[] Value=A268766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268766.Bytes);
public long this[int i]=>Value[i];

public static A268766Inst Instance=new A268766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268765
{
public static readonly long[] Value={ 38L,595L,8500L,99057L,1129042L,12111209L,127676872L,1312123185L,13311824510L,133228716170L,1321110678618L,12988699400546L,126844585914726L,1231361200765123L,11893679949360102L,114371480492930683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268765Inst : IEnumerable<long>
{
public static readonly long[] Value=A268765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268765.Bytes);
public long this[int i]=>Value[i];

public static A268765Inst Instance=new A268765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268764
{
public static readonly long[] Value={ 20L,258L,2607L,23156L,193573L,1552272L,12111209L,92571436L,696659613L,5178525870L,38112289517L,278191828634L,2016589831189L,14532118028260L,104191269908219L,743719988895596L,5288057396240333L,37470071363668612L,264689231027772351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268764Inst : IEnumerable<long>
{
public static readonly long[] Value=A268764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268764.Bytes);
public long this[int i]=>Value[i];

public static A268764Inst Instance=new A268764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268763
{
public static readonly long[] Value={ 10L,105L,762L,5170L,32056L,193573L,1129042L,6475898L,36505596L,203462597L,1122256900L,6140903312L,33367393732L,180252797855L,968778729426L,5183858768244L,27630592631158L,146768594783741L,777214421588348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268763Inst : IEnumerable<long>
{
public static readonly long[] Value=A268763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268763.Bytes);
public long this[int i]=>Value[i];

public static A268763Inst Instance=new A268763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268762
{
public static readonly long[] Value={ 5L,44L,223L,1148L,5170L,23156L,99057L,418924L,1736105L,7122856L,28898144L,116346184L,465034573L,1848051516L,7306228767L,28758043956L,112751067666L,440538622908L,1715952146561L,6665380161836L,25826102521633L,99840968906384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268762Inst : IEnumerable<long>
{
public static readonly long[] Value=A268762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268762.Bytes);
public long this[int i]=>Value[i];

public static A268762Inst Instance=new A268762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268761
{
public static readonly long[] Value={ 2L,15L,56L,223L,762L,2607L,8500L,27411L,86622L,270955L,838224L,2573015L,7841538L,23759463L,71619436L,214933915L,642504870L,1914023267L,5684288136L,16834582623L,49732758858L,146587890015L,431177727396L,1265883329827L,3710027613934L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268761Inst : IEnumerable<long>
{
public static readonly long[] Value=A268761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268761.Bytes);
public long this[int i]=>Value[i];

public static A268761Inst Instance=new A268761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268760
{
public static readonly BigInteger[] Value={ 0L,6L,56L,1148L,32056L,1552272L,127676872L,18045771274L,4495138018796L,1955829240647962L,1511334747222697904L,BigInteger.Parse("2064152526111916503300"),BigInteger.Parse("5022957354228609008158500"),BigInteger.Parse("21748481726801956896608976098") };
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
public class A268760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268760.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268760Inst Instance=new A268760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268759
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,3L,3L,0L,0L,6L,9L,6L,0L,0L,10L,18L,18L,10L,0L,0L,15L,30L,36L,30L,15L,0L,0L,21L,45L,60L,60L,45L,21L,0L,0L,28L,63L,90L,100L,90L,63L,28L,0L,0L,36L,84L,126L,150L,150L,126L,84L,36L,0L,0L,45L,108L,168L,210L,225L,210L,168L,108L,45L,0L,0L,55L,135L,216L,280L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268759Inst : IEnumerable<long>
{
public static readonly long[] Value=A268759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268759.Bytes);
public long this[int i]=>Value[i];

public static A268759Inst Instance=new A268759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268758
{
public static readonly long[] Value={ 1L,3L,17L,163L,2753L,84731L,4879497L,535376723L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268758Inst : IEnumerable<long>
{
public static readonly long[] Value=A268758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268758.Bytes);
public long this[int i]=>Value[i];

public static A268758Inst Instance=new A268758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268757
{
public static readonly long[] Value={ 16L,4104L,119824488L,74213505639000L,6123582409620312000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268757Inst : IEnumerable<long>
{
public static readonly long[] Value=A268757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268757.Bytes);
public long this[int i]=>Value[i];

public static A268757Inst Instance=new A268757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268756
{
public static readonly long[] Value={ 1L,5L,9L,17L,21L,35L,39L,53L,61L,75L,79L,107L,111L,125L,139L,160L,164L,192L,196L,224L,238L,252L,256L,304L,312L,326L,340L,368L,372L,418L,422L,452L,466L,480L,494L,550L,554L,568L,582L,630L,634L,680L,684L,712L,740L,754L,758L,830L,838L,866L,880L,908L,912L,960L,974L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268756Inst : IEnumerable<long>
{
public static readonly long[] Value=A268756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268756.Bytes);
public long this[int i]=>Value[i];

public static A268756Inst Instance=new A268756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268691
{
public static readonly long[] Value={ 1L,2L,2L,4L,8L,12L,24L,48L,96L,180L,360L,720L,1440L,2820L,5640L,11280L,22560L,44760L,89520L,179040L,358080L,713760L,1427520L,2855040L,5710080L,11403060L,22806120L,45612240L,91224480L,182321460L,364642920L,729285840L,1458571680L,2916160800L,5832321600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268691Inst : IEnumerable<long>
{
public static readonly long[] Value=A268691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268691.Bytes);
public long this[int i]=>Value[i];

public static A268691Inst Instance=new A268691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268690
{
public static readonly long[] Value={ 1L,5L,3L,2L,10L,50L,25L,13L,7L,4L,20L,100L,500L,250L,125L,63L,32L,16L,8L,40L,200L,1000L,5000L,2500L,1250L,625L,313L,157L,79L,395L,198L,99L,495L,248L,124L,62L,31L,155L,78L,39L,195L,98L,49L,245L,123L,615L,308L,154L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268690Inst : IEnumerable<long>
{
public static readonly long[] Value=A268690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268690.Bytes);
public long this[int i]=>Value[i];

public static A268690Inst Instance=new A268690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268689
{
public static readonly long[] Value={ 0L,0L,0L,0L,4L,14L,94L,510L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268689Inst : IEnumerable<long>
{
public static readonly long[] Value=A268689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268689.Bytes);
public long this[int i]=>Value[i];

public static A268689Inst Instance=new A268689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268688
{
public static readonly long[] Value={ 0L,0L,1L,2L,10L,30L,190L,1022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268688Inst : IEnumerable<long>
{
public static readonly long[] Value=A268688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268688.Bytes);
public long this[int i]=>Value[i];

public static A268688Inst Instance=new A268688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268687
{
public static readonly long[] Value={ 0L,1L,2L,3L,11L,31L,191L,1023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268687Inst : IEnumerable<long>
{
public static readonly long[] Value=A268687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268687.Bytes);
public long this[int i]=>Value[i];

public static A268687Inst Instance=new A268687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268686
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,1L,2L,2L,2L,2L,0L,2L,3L,1L,3L,3L,1L,2L,4L,2L,4L,4L,4L,2L,3L,4L,3L,3L,5L,5L,5L,4L,5L,4L,5L,3L,5L,5L,6L,4L,4L,7L,3L,6L,7L,6L,7L,5L,4L,5L,4L,6L,8L,7L,7L,7L,7L,3L,8L,9L,8L,5L,9L,5L,7L,8L,4L,8L,8L,10L,8L,6L,6L,10L,9L,9L,6L,7L,6L,9L,9L,9L,8L,8L,12L,13L,8L,10L,12L,11L,12L,10L,11L,8L,12L,12L,12L,10L,9L,13L,8L,10L,13L,8L,9L,10L,10L,11L,12L,13L,8L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268686Inst : IEnumerable<long>
{
public static readonly long[] Value=A268686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268686.Bytes);
public long this[int i]=>Value[i];

public static A268686Inst Instance=new A268686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268685
{
public static readonly long[] Value={ 6L,126L,630L,1950L,4680L,9576L,17556L,29700L,47250L,71610L,104346L,147186L,202020L,270900L,356040L,459816L,584766L,733590L,909150L,1114470L,1352736L,1627296L,1941660L,2299500L,2704650L,3161106L,3673026L,4244730L,4880700L,5585580L,6364176L,7221456L,8162550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268685Inst : IEnumerable<long>
{
public static readonly long[] Value=A268685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268685.Bytes);
public long this[int i]=>Value[i];

public static A268685Inst Instance=new A268685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268684
{
public static readonly long[] Value={ 0L,2L,14L,44L,100L,190L,322L,504L,744L,1050L,1430L,1892L,2444L,3094L,3850L,4720L,5712L,6834L,8094L,9500L,11060L,12782L,14674L,16744L,19000L,21450L,24102L,26964L,30044L,33350L,36890L,40672L,44704L,48994L,53550L,58380L,63492L,68894L,74594L,80600L,86920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268684Inst : IEnumerable<long>
{
public static readonly long[] Value=A268684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268684.Bytes);
public long this[int i]=>Value[i];

public static A268684Inst Instance=new A268684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268683
{
public static readonly long[] Value={ 2L,0L,7L,1L,0L,6L,7L,8L,1L,1L,8L,6L,5L,4L,7L,5L,2L,4L,4L,0L,0L,8L,4L,4L,3L,6L,2L,1L,0L,4L,8L,4L,9L,0L,3L,9L,2L,8L,4L,8L,3L,5L,9L,3L,7L,6L,8L,8L,4L,7L,4L,0L,3L,6L,5L,8L,8L,3L,3L,9L,8L,6L,8L,9L,9L,5L,3L,6L,6L,2L,3L,9L,2L,3L,1L,0L,5L,3L,5L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268683Inst : IEnumerable<long>
{
public static readonly long[] Value=A268683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268683.Bytes);
public long this[int i]=>Value[i];

public static A268683Inst Instance=new A268683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268682
{
public static readonly long[] Value={ 2L,9L,2L,8L,9L,3L,2L,1L,8L,8L,1L,3L,4L,5L,2L,4L,7L,5L,5L,9L,9L,1L,5L,5L,6L,3L,7L,8L,9L,5L,1L,5L,0L,9L,6L,0L,7L,1L,5L,1L,6L,4L,0L,6L,2L,3L,1L,1L,5L,2L,5L,9L,6L,3L,4L,1L,1L,6L,6L,0L,1L,3L,1L,0L,0L,4L,6L,3L,3L,7L,6L,0L,7L,6L,8L,9L,4L,6L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268682Inst : IEnumerable<long>
{
public static readonly long[] Value=A268682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268682.Bytes);
public long this[int i]=>Value[i];

public static A268682Inst Instance=new A268682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268681
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,27L,42L,105L,175L,175L,385L,1408L,1474L,2566L,8677L,15607L,15607L,39934L,39934L,133300L,264305L,559565L,1288392L,5482695L,5493321L,5546451L,11088442L,11088442L,24211552L,88854292L,88854757L,133243378L,133243378L,133243411L,2337205436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268681Inst : IEnumerable<long>
{
public static readonly long[] Value=A268681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268681.Bytes);
public long this[int i]=>Value[i];

public static A268681Inst Instance=new A268681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268680
{
public static readonly long[] Value={ 0L,1L,1L,2L,3L,4L,4L,5L,6L,6L,6L,7L,7L,7L,7L,8L,9L,9L,10L,11L,12L,12L,13L,14L,14L,14L,15L,16L,16L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,21L,22L,23L,24L,24L,24L,24L,24L,25L,26L,26L,27L,27L,28L,29L,29L,29L,30L,31L,31L,32L,33L,33L,33L,33L,34L,35L,36L,36L,36L,37L,38L,38L,39L,39L,40L,41L,41L,41L,41L,41L,41L,42L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268680Inst : IEnumerable<long>
{
public static readonly long[] Value=A268680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268680.Bytes);
public long this[int i]=>Value[i];

public static A268680Inst Instance=new A268680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268679
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,1L,3L,4L,1L,2L,1L,1L,2L,1L,3L,1L,4L,1L,2L,2L,1L,3L,1L,1L,5L,1L,2L,2L,1L,3L,1L,2L,1L,4L,1L,1L,3L,1L,2L,2L,1L,6L,1L,1L,3L,1L,2L,1L,2L,1L,5L,3L,1L,2L,1L,1L,2L,1L,4L,3L,1L,2L,1L,1L,2L,1L,3L,4L,1L,2L,1L,1L,2L,1L,3L,5L,1L,2L,1L,2L,1L,3L,1L,1L,6L,1L,2L,2L,1L,3L,1L,1L,4L,1L,2L,1L,3L,1L,2L,2L,1L,5L,1L,1L,3L,1L,2L,2L,1L,4L,1L,3L,1L,2L,1L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268679Inst : IEnumerable<long>
{
public static readonly long[] Value=A268679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268679.Bytes);
public long this[int i]=>Value[i];

public static A268679Inst Instance=new A268679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268678
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,7L,8L,11L,15L,16L,18L,19L,20L,22L,23L,26L,27L,31L,32L,34L,36L,37L,40L,41L,42L,47L,48L,50L,52L,53L,56L,57L,59L,60L,64L,65L,66L,69L,70L,72L,74L,75L,81L,82L,83L,86L,87L,89L,90L,92L,93L,98L,101L,102L,104L,105L,106L,108L,109L,113L,116L,117L,119L,120L,121L,123L,124L,127L,131L,132L,134L,135L,136L,138L,139L,142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268678Inst : IEnumerable<long>
{
public static readonly long[] Value=A268678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268678.Bytes);
public long this[int i]=>Value[i];

public static A268678Inst Instance=new A268678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268677
{
public static readonly long[] Value={ 2L,6L,9L,10L,12L,13L,14L,17L,21L,24L,25L,28L,29L,30L,33L,35L,38L,39L,43L,44L,45L,46L,49L,51L,54L,55L,58L,61L,62L,63L,67L,68L,71L,73L,76L,77L,78L,79L,80L,84L,85L,88L,91L,94L,95L,96L,97L,99L,100L,103L,107L,110L,111L,112L,114L,115L,118L,122L,125L,126L,128L,129L,130L,133L,137L,140L,141L,143L,144L,145L,146L,149L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268677Inst : IEnumerable<long>
{
public static readonly long[] Value=A268677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268677.Bytes);
public long this[int i]=>Value[i];

public static A268677Inst Instance=new A268677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268676
{
public static readonly long[] Value={ 1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,1L,3L,1L,3L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268676Inst : IEnumerable<long>
{
public static readonly long[] Value=A268676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268676.Bytes);
public long this[int i]=>Value[i];

public static A268676Inst Instance=new A268676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268659
{
public static readonly long[] Value={ 209L,44685L,157169L,303093L,362765L,916773L,2145353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268659Inst : IEnumerable<long>
{
public static readonly long[] Value=A268659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268659.Bytes);
public long this[int i]=>Value[i];

public static A268659Inst Instance=new A268659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268658
{
public static readonly long[] Value={ 2L,8L,18L,66L,189L,209L,408L,2208L,2816L,3168L,3912L,20909L,54792L,59973L,157169L,303093L,709968L,801978L,1832496L,2145353L,2291610L,5082306L,10829346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268658Inst : IEnumerable<long>
{
public static readonly long[] Value=A268658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268658.Bytes);
public long this[int i]=>Value[i];

public static A268658Inst Instance=new A268658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268657
{
public static readonly long[] Value={ 6L,12L,18L,30L,36L,41L,66L,189L,201L,209L,276L,408L,438L,534L,2208L,3168L,3189L,3912L,34350L,42294L,44685L,48150L,54792L,55182L,59973L,80190L,157169L,213321L,303093L,382449L,709968L,801978L,916773L,1832496L,2145353L,2291610L,2478785L,5082306L,7033641L,10829346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268657Inst : IEnumerable<long>
{
public static readonly long[] Value=A268657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268657.Bytes);
public long this[int i]=>Value[i];

public static A268657Inst Instance=new A268657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268656
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,0L,6L,6L,11L,16L,38L,58L,103L,152L,267L,486L,861L,1392L,2276L,3812L,6562L,11224L,18906L,31446L,52392L,87776L,147423L,246698L,411358L,685988L,1145964L,1913208L,3184968L,5288788L,8779115L,14587396L,24250424L,40280516L,66808605L,110689870L,183321646L,303558816L,502460050L,831201108L,1374306023L,2271447536L,3753011555L,6198348494L,10232046899L,16883378468L,27848975062L,45923355280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268656Inst : IEnumerable<long>
{
public static readonly long[] Value=A268656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268656.Bytes);
public long this[int i]=>Value[i];

public static A268656Inst Instance=new A268656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268655
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,17L,45L,123L,356L,1061L,3193L,9691L,29741L,92228L,288331L,907316L,2871818L,9138352L,29217870L,93813839L,302367222L,977913351L,3172727729L,10323213290L,33677758165L,110135406578L,360982631871L,1185632194394L,3901702645568L,12862978506084L,42477650804971L,140496123308659L,465383254510707L,1543693890316144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268655Inst : IEnumerable<long>
{
public static readonly long[] Value=A268655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268655.Bytes);
public long this[int i]=>Value[i];

public static A268655Inst Instance=new A268655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268654
{
public static readonly BigInteger[] Value={ 1L,1L,9L,133L,2729L,71721L,2300485L,87194689L,3815719969L,189440927857L,10525328121221L,647265172064985L,43660242639018241L,3205987437435132793L,BigInteger.Parse("254635755560090281525"),BigInteger.Parse("21755037223870035810001"),BigInteger.Parse("1989746853200670755116865"),BigInteger.Parse("194000891136578173746676449"),BigInteger.Parse("20089033883934411591428091013"),BigInteger.Parse("2202022786357483714102765694185") };
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
public class A268654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268654Inst Instance=new A268654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268653
{
public static readonly BigInteger[] Value={ 1L,1L,7L,82L,1345L,28396L,734149L,22485898L,796769201L,32084546824L,1447917011461L,72411962077126L,3976481464087609L,237939307837951708L,15412492927027232261UL,BigInteger.Parse("1074675869343994244266"),BigInteger.Parse("80270802348342665849569"),BigInteger.Parse("6395153963612453962942096"),BigInteger.Parse("541390375948749181692141061"),BigInteger.Parse("48536543026953818449535683054"),BigInteger.Parse("4594206854845500504888845269481"),BigInteger.Parse("457878082780635055560866092165156"),BigInteger.Parse("47930551834845432770784732668907205") };
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
public class A268653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268653Inst Instance=new A268653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268652
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,2L,0L,9L,14L,5L,0L,64L,124L,74L,14L,0L,624L,1388L,1074L,352L,42L,0L,7736L,18964L,17292L,7520L,1588L,132L,0L,116416L,307088L,314356L,163728L,46561L,6946L,429L,0L,2060808L,5760704L,6434394L,3807910L,1311172L,266116L,29786L,1430L,0L,41952600L,122980872L,147159406L,95921164L,37846790L,9373620L,1438006L,126008L,4862L,0L,965497440L,2945806672L,3729264888L,2623904244L,1147995184L,327833296L,61731036L,7455440L,527900L,16796L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268652Inst : IEnumerable<long>
{
public static readonly long[] Value=A268652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268652.Bytes);
public long this[int i]=>Value[i];

public static A268652Inst Instance=new A268652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268651
{
public static readonly long[] Value={ 1L,1L,2L,5L,9L,22L,52L,146L,377L,1036L,2810L,8014L,22790L,66100L,191541L,562926L,1660975L,4944766L,14767136L,44357952L,133698623L,404810569L,1229434572L,3746595869L,11447723074L,35075829156L,107724187826L,331605018200L,1022842337041L,3161156987190L,9787096605716L,30352665554591L,94279407445012L,293277650593792L,913565090912339L,2849489942324466L,8898714901181309L,27822251614174021L,87083081436755770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268651Inst : IEnumerable<long>
{
public static readonly long[] Value=A268651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268651.Bytes);
public long this[int i]=>Value[i];

public static A268651Inst Instance=new A268651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268650
{
public static readonly BigInteger[] Value={ 1L,1L,3L,12L,50L,228L,1093L,5439L,27816L,145310L,772109L,4159998L,22674120L,124800022L,692686326L,3872659052L,21788990982L,123280580325L,700988359296L,4003661444545L,22958337467658L,132127737109116L,762912391705495L,4418326909800903L,25658693934333564L,149385658937180542L,871758439355580702L,5098248338356022913L,BigInteger.Parse("29875567243598952092"),BigInteger.Parse("175396705518901173813"),BigInteger.Parse("1031531740231929729207") };
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
public class A268650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268650Inst Instance=new A268650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268649
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,9L,17L,36L,71L,143L,284L,573L,1140L,2287L,4568L,9138L,18272L,36559L,73098L,146216L,292413L,584836L,1169657L,2339353L,4678655L,9357356L,18714673L,37429377L,74858706L,149717506L,299434883L,598869895L,1197739689L,2395479446L,4790958784L,9581917760L,19163835261L,38327670814L,76655341388L,153310682944L,306621365618L,613242731721L,1226485462828L,2452970926285L,4905941852039L,9811883704440L,19623767408346L,39247534817726L,78495069634129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268649Inst : IEnumerable<long>
{
public static readonly long[] Value=A268649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268649.Bytes);
public long this[int i]=>Value[i];

public static A268649Inst Instance=new A268649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268648
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,15L,46L,149L,495L,1682L,5806L,20322L,71919L,256936L,925298L,3355509L,12242471L,44906105L,165503745L,612575796L,2276024836L,8485972958L,31739314999L,119054638380L,447759005393L,1688108544222L,6378722610280L,24153083898505L,91633201241544L,348270745289976L,1325907389447937L,5055855150302197L,19307179347881167L,73832434701139921L,282712142418209398L,1083873025643898568L,4160250292584533013L,15986022831150313756UL,BigInteger.Parse("61491665982535018897") };
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
public class A268648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268648Inst Instance=new A268648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268647
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,1L,48L,124L,120L,55L,12L,1L,2160L,6012L,6636L,3829L,1260L,238L,24L,1L,161280L,478656L,582080L,387260L,157080L,40593L,6720L,690L,40L,1L,18144000L,56772000L,74396520L,54801076L,25494150L,7927205L,1690920L,248523L,24750L,1595L,60L,1L,2874009600L,9397658880L,13075800192L,10415648880L,5357255904L,1893627736L,476011536L,86550035L,11423412L,1084083L,72072L,3185L,84L,1L,610248038400L,2071437822720L,3028563232128L,2569081620624L,1429040500160L,556365173000L,157528627256L,33179499353L,5260335080L,629597540L,56560504L,3753022L,178360L,5740L,112L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268647Inst : IEnumerable<long>
{
public static readonly long[] Value=A268647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268647.Bytes);
public long this[int i]=>Value[i];

public static A268647Inst Instance=new A268647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268646
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,277L,11081L,1383243L,569441699L,791393701997L,3770885471695081L,BigInteger.Parse("62402464265309818563"),BigInteger.Parse("3626978195203590614565619"),BigInteger.Parse("747715555141652980441024051237"),BigInteger.Parse("551447343768097359581617325419468841"),BigInteger.Parse("1465935896222119146302554598601016693710363") };
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
public class A268646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268646Inst Instance=new A268646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268645
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,15L,24L,48L,105L,120L,384L,720L,945L,3840L,5040L,10395L,40320L,46080L,135135L,362880L,645120L,2027025L,3628800L,10321920L,34459425L,39916800L,185794560L,479001600L,654729075L,3715891200L,6227020800L,13749310575L,81749606400L,87178291200L,316234143225L,1307674368000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268645Inst : IEnumerable<long>
{
public static readonly long[] Value=A268645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268645.Bytes);
public long this[int i]=>Value[i];

public static A268645Inst Instance=new A268645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268644
{
public static readonly long[] Value={ -1L,-2L,15L,74L,199L,414L,743L,1210L,1839L,2654L,3679L,4938L,6455L,8254L,10359L,12794L,15583L,18750L,22319L,26314L,30759L,35678L,41095L,47034L,53519L,60574L,68223L,76490L,85399L,94974L,105239L,116218L,127935L,140414L,153679L,167754L,182663L,198430L,215079L,232634L,251119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268644Inst : IEnumerable<long>
{
public static readonly long[] Value=A268644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268644.Bytes);
public long this[int i]=>Value[i];

public static A268644Inst Instance=new A268644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268627
{
public static readonly BigInteger[] Value={ 768L,29646L,982086L,30553014L,915847266L,26758514760L,767057092212L,21665715966234L,604770363515718L,16719464029955466L,458539471622171262L,12491032205839395768UL,BigInteger.Parse("338309651358216576312"),BigInteger.Parse("9117289065936178169226") };
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
public class A268627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268627.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268627Inst Instance=new A268627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268626
{
public static readonly BigInteger[] Value={ 336L,8586L,187224L,3819654L,74914554L,1430057208L,26758514760L,493042858032L,8974328440044L,161737670836314L,2891047134413940L,51321708535136676L,905714517532142694L,15902932976899644264UL,BigInteger.Parse("277998507169027800234") };
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
public class A268626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268626Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268626.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268626.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268626Inst Instance=new A268626Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268625
{
public static readonly long[] Value={ 144L,2430L,34890L,467190L,6000978L,74914554L,915847266L,11018667294L,130903914954L,1539375100362L,17950677440298L,207850445630478L,2392281464029314L,27392205838123482L,312238767991217778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268625Inst : IEnumerable<long>
{
public static readonly long[] Value=A268625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268625.Bytes);
public long this[int i]=>Value[i];

public static A268625Inst Instance=new A268625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268624
{
public static readonly long[] Value={ 60L,666L,6300L,55452L,467190L,3819654L,30553014L,240364746L,1866503592L,14342680944L,109265781870L,826421076378L,6212333663082L,46453421706210L,345772280726172L,2563402622459652L,18936504080614278L,139446644995253358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268624Inst : IEnumerable<long>
{
public static readonly long[] Value=A268624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268624.Bytes);
public long this[int i]=>Value[i];

public static A268624Inst Instance=new A268624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268623
{
public static readonly long[] Value={ 24L,174L,1086L,6300L,34890L,187224L,982086L,5063964L,25764066L,129678528L,646978302L,3204131172L,15769455258L,77195600520L,376136512950L,1825265294892L,8825528262738L,42536536932432L,204425809550958L,979908028544244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268623Inst : IEnumerable<long>
{
public static readonly long[] Value=A268623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268623.Bytes);
public long this[int i]=>Value[i];

public static A268623Inst Instance=new A268623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268622
{
public static readonly long[] Value={ 9L,42L,174L,666L,2430L,8586L,29646L,100602L,336798L,1115370L,3661038L,11927898L,38618046L,124357194L,398580750L,1272269754L,4046391774L,12827922858L,40550011182L,127848761370L,402142467582L,1262215953162L,3954013510734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268622Inst : IEnumerable<long>
{
public static readonly long[] Value=A268622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268622.Bytes);
public long this[int i]=>Value[i];

public static A268622Inst Instance=new A268622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268621
{
public static readonly BigInteger[] Value={ 3L,42L,1086L,55452L,6000978L,1430057208L,767057092212L,938662461734076L,2643885168776274078L,BigInteger.Parse("17245474696462104041796"),BigInteger.Parse("261641272761781630830646332"),BigInteger.Parse("9262823664147270920479995625968"),BigInteger.Parse("767111588793900754143144516979246884") };
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
public class A268621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268621Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A268621.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A268621.Bytes);
public BigInteger this[int i]=>Value[i];

public static A268621Inst Instance=new A268621Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268620
{
public static readonly long[] Value={ 0L,4L,8L,13L,17L,22L,26L,31L,35L,39L,40L,44L,48L,53L,57L,62L,66L,71L,75L,79L,80L,84L,88L,93L,97L,103L,107L,112L,116L,121L,125L,129L,130L,134L,138L,143L,147L,152L,156L,161L,165L,169L,170L,174L,178L,183L,187L,192L,196L,202L,206L,211L,215L,219L,220L,224L,228L,233L,237L,242L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268620Inst : IEnumerable<long>
{
public static readonly long[] Value=A268620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268620.Bytes);
public long this[int i]=>Value[i];

public static A268620Inst Instance=new A268620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268619
{
public static readonly long[] Value={ 2L,1L,2L,4L,10L,25L,70L,200L,600L,1845L,5830L,18772L,61542L,204659L,689410L,2347920L,8074762L,28009524L,97909318L,344615860L,1220539390L,4347310451L,15564141262L,55985418344L,202256970300L,733607281875L,2670698800548L,9755982857964L,35751803209918L,131405090455065L,484316704740126L,1789672012052256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268619Inst : IEnumerable<long>
{
public static readonly long[] Value=A268619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268619.Bytes);
public long this[int i]=>Value[i];

public static A268619Inst Instance=new A268619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268618
{
public static readonly long[] Value={ 6L,3L,6L,15L,48L,171L,678L,2871L,12858L,60084L,290814L,1448679L,7394106L,38527779L,204365880L,1101000087L,6013054788L,33239486925L,185736687366L,1047961118940L,5964676687668L,34219227608607L,197737647050742L,1150211467134927L,6731334034067058L,39614408616493581L,234342269725331130L,1392933275876114127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268618Inst : IEnumerable<long>
{
public static readonly long[] Value=A268618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268618.Bytes);
public long this[int i]=>Value[i];

public static A268618Inst Instance=new A268618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268617
{
public static readonly long[] Value={ 3L,3L,9L,30L,120L,513L,2373L,11484L,57861L,300420L,1599477L,8692074L,48061689L,269694453L,1532744100L,8808000696L,51110965698L,299155382325L,1764498529977L,10479611189400L,62629105220514L,376411503694677L,2273982941083533L,13802537605619124L,84141675425838225L,514987312014416553L,3163620641291970255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268617Inst : IEnumerable<long>
{
public static readonly long[] Value=A268617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268617.Bytes);
public long this[int i]=>Value[i];

public static A268617Inst Instance=new A268617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268616
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,2L,3L,2L,5L,2L,3L,2L,6L,3L,5L,2L,2L,2L,2L,7L,5L,3L,2L,3L,5L,2L,5L,2L,6L,3L,3L,2L,3L,2L,2L,6L,5L,2L,5L,2L,2L,2L,19L,5L,2L,3L,2L,3L,2L,6L,3L,7L,7L,6L,3L,5L,2L,6L,5L,3L,3L,2L,5L,17L,10L,2L,3L,10L,2L,2L,3L,7L,6L,2L,2L,5L,2L,5L,3L,21L,2L,2L,7L,5L,15L,2L,3L,13L,2L,3L,2L,13L,3L,2L,7L,5L,2L,3L,2L,2L,2L,2L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268616Inst : IEnumerable<long>
{
public static readonly long[] Value=A268616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268616.Bytes);
public long this[int i]=>Value[i];

public static A268616Inst Instance=new A268616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268615
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L,18L,29L,7L,36L,3L,39L,2L,1L,3L,4L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268615Inst : IEnumerable<long>
{
public static readonly long[] Value=A268615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268615.Bytes);
public long this[int i]=>Value[i];

public static A268615Inst Instance=new A268615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268614
{
public static readonly long[] Value={ 5L,13L,29L,37L,41L,101L,109L,113L,137L,157L,181L,193L,229L,257L,281L,317L,353L,389L,397L,401L,409L,433L,461L,509L,541L,569L,613L,617L,641L,653L,661L,677L,757L,761L,769L,797L,821L,829L,857L,877L,937L,941L,977L,1009L,1021L,1093L,1109L,1117L,1129L,1153L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268614Inst : IEnumerable<long>
{
public static readonly long[] Value=A268614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268614.Bytes);
public long this[int i]=>Value[i];

public static A268614Inst Instance=new A268614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268613
{
public static readonly long[] Value={ 2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L,18L,9L,7L,16L,3L,19L,2L,1L,3L,4L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268613Inst : IEnumerable<long>
{
public static readonly long[] Value=A268613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268613.Bytes);
public long this[int i]=>Value[i];

public static A268613Inst Instance=new A268613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268612
{
public static readonly long[] Value={ 29L,83L,101L,191L,227L,389L,443L,479L,587L,641L,659L,677L,983L,1091L,1109L,1289L,1307L,1451L,1487L,2027L,2081L,2153L,2243L,2333L,2351L,2441L,2459L,2477L,2549L,2657L,2729L,2837L,2909L,2927L,2999L,3089L,3251L,3359L,3449L,3557L,3593L,4007L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268612Inst : IEnumerable<long>
{
public static readonly long[] Value=A268612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268612.Bytes);
public long this[int i]=>Value[i];

public static A268612Inst Instance=new A268612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268467
{
public static readonly long[] Value={ 2L,43L,23L,0L,1109L,1187L,929L,0L,4973L,1291L,11197L,0L,26099L,15583L,4423L,0L,42139L,10729L,21283L,0L,36899L,27179L,21563L,0L,24359L,33863L,27361L,0L,223423L,51239L,293467L,42043L,67699L,56503L,118361L,0L,80449L,94693L,136739L,0L,127837L,136991L,387913L,0L,304259L,192013L,321721L,0L,339517L,357683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268467Inst : IEnumerable<long>
{
public static readonly long[] Value=A268467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268467.Bytes);
public long this[int i]=>Value[i];

public static A268467Inst Instance=new A268467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268466
{
public static readonly long[] Value={ 2L,3L,2L,5L,4L,7L,6L,9L,8L,11L,5L,13L,3L,9L,4L,17L,4L,19L,9L,21L,8L,5L,22L,25L,24L,3L,26L,9L,7L,31L,6L,33L,10L,35L,6L,37L,9L,9L,8L,41L,10L,43L,6L,5L,8L,47L,46L,49L,18L,51L,4L,9L,13L,55L,12L,9L,20L,7L,29L,61L,15L,35L,8L,65L,8L,25L,22L,69L,22L,51L,5L,73L,18L,9L,26L,9L,12L,79L,24L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268466Inst : IEnumerable<long>
{
public static readonly long[] Value=A268466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268466.Bytes);
public long this[int i]=>Value[i];

public static A268466Inst Instance=new A268466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268465
{
public static readonly long[] Value={ 23L,349L,1579L,4691L,5783L,7187L,9547L,11519L,15377L,45779L,52289L,353359L,361787L,384277L,510227L,678413L,710599L,1007861L,1218709L,1301617L,1484449L,1567567L,1839469L,2073989L,2264959L,2409163L,2438377L,252077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268465Inst : IEnumerable<long>
{
public static readonly long[] Value=A268465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268465.Bytes);
public long this[int i]=>Value[i];

public static A268465Inst Instance=new A268465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268464
{
public static readonly long[] Value={ 3L,0L,2L,1L,4L,1L,7L,2L,4L,7L,1L,4L,7L,3L,7L,3L,7L,7L,2L,6L,1L,2L,1L,2L,2L,9L,4L,2L,1L,2L,8L,4L,6L,4L,2L,3L,7L,7L,3L,4L,2L,9L,1L,0L,3L,5L,5L,8L,5L,0L,2L,1L,3L,1L,6L,6L,0L,2L,6L,6L,6L,4L,4L,3L,4L,6L,9L,4L,2L,5L,1L,9L,1L,9L,1L,3L,3L,4L,3L,5L,8L,1L,7L,0L,1L,3L,8L,4L,5L,6L,0L,0L,3L,2L,0L,6L,1L,6L,4L,2L,8L,6L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268464Inst : IEnumerable<long>
{
public static readonly long[] Value=A268464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268464.Bytes);
public long this[int i]=>Value[i];

public static A268464Inst Instance=new A268464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268463
{
public static readonly long[] Value={ 1L,15L,35L,47L,81L,7087L,7399L,19865L,19913L,24087L,24279L,408257L,409303L,2042205L,5262017L,5262089L,6189393L,6435851L,6435983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268463Inst : IEnumerable<long>
{
public static readonly long[] Value=A268463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268463.Bytes);
public long this[int i]=>Value[i];

public static A268463Inst Instance=new A268463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268462
{
public static readonly long[] Value={ 0L,0L,0L,0L,10L,56L,224L,768L,2400L,7040L,19712L,53248L,139776L,358400L,901120L,2228224L,5431296L,13074432L,31129600L,73400320L,171573248L,397934592L,916455424L,2097152000L,4771020800L,10796138496L,24310185984L,54492397568L,121634816000L,270448721920L,599147937792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268462Inst : IEnumerable<long>
{
public static readonly long[] Value=A268462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268462.Bytes);
public long this[int i]=>Value[i];

public static A268462Inst Instance=new A268462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268461
{
public static readonly long[] Value={ 29L,1169L,11536L,62535L,240170L,736525L,1926444L,4474451L,9476950L,18644745L,34530920L,60809119L,102607266L,166901765L,262977220L,402956715L,602407694L,881028481L,1263420480L,1779951095L,2467712410L,3371580669L,4545381596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268461Inst : IEnumerable<long>
{
public static readonly long[] Value=A268461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268461.Bytes);
public long this[int i]=>Value[i];

public static A268461Inst Instance=new A268461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268460
{
public static readonly long[] Value={ 22L,456L,3146L,13204L,41526L,108032L,245626L,504876L,959414L,1712056L,2901642L,4710596L,7373206L,11184624L,16510586L,23797852L,33585366L,46516136L,63349834L,84976116L,112428662L,146899936L,189756666L,242556044L,307062646L,385266072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268460Inst : IEnumerable<long>
{
public static readonly long[] Value=A268460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268460.Bytes);
public long this[int i]=>Value[i];

public static A268460Inst Instance=new A268460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268459
{
public static readonly long[] Value={ 16L,176L,852L,2776L,7160L,15816L,31276L,56912L,97056L,157120L,243716L,364776L,529672L,749336L,1036380L,1405216L,1872176L,2455632L,3176116L,4056440L,5121816L,6399976L,7921292L,9718896L,11828800L,14290016L,17144676L,20438152L,24219176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268459Inst : IEnumerable<long>
{
public static readonly long[] Value=A268459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268459.Bytes);
public long this[int i]=>Value[i];

public static A268459Inst Instance=new A268459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268458
{
public static readonly long[] Value={ 11L,67L,229L,581L,1231L,2311L,3977L,6409L,9811L,14411L,20461L,28237L,38039L,50191L,65041L,82961L,104347L,129619L,159221L,193621L,233311L,278807L,330649L,389401L,455651L,530011L,613117L,705629L,808231L,921631L,1046561L,1183777L,1334059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268458Inst : IEnumerable<long>
{
public static readonly long[] Value=A268458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268458.Bytes);
public long this[int i]=>Value[i];

public static A268458Inst Instance=new A268458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268457
{
public static readonly long[] Value={ 2L,3L,4L,4L,9L,7L,5L,16L,25L,11L,6L,25L,61L,67L,16L,7L,36L,121L,229L,176L,22L,8L,49L,211L,581L,852L,456L,29L,9L,64L,337L,1231L,2776L,3146L,1169L,37L,10L,81L,505L,2311L,7160L,13204L,11536L,2971L,46L,11L,100L,721L,3977L,15816L,41526L,62535L,42032L,7496L,56L,12L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268457Inst : IEnumerable<long>
{
public static readonly long[] Value=A268457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268457.Bytes);
public long this[int i]=>Value[i];

public static A268457Inst Instance=new A268457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268456
{
public static readonly long[] Value={ 8L,64L,505L,3977L,31276L,245626L,1926444L,15089356L,118040270L,922247248L,7196716310L,56092274904L,436681564144L,3395712755366L,26376195676360L,204653424502050L,1586213921445534L,12281469122143732L,94993604706706795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268456Inst : IEnumerable<long>
{
public static readonly long[] Value=A268456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268456.Bytes);
public long this[int i]=>Value[i];

public static A268456Inst Instance=new A268456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268455
{
public static readonly long[] Value={ 7L,49L,337L,2311L,15816L,108032L,736525L,5012171L,34047931L,230889543L,1563104184L,10564826628L,71293105297L,480355314513L,3231663192859L,21709801573961L,145636117720769L,975623832619371L,6526972402359763L,43608650962250889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268455Inst : IEnumerable<long>
{
public static readonly long[] Value=A268455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268455.Bytes);
public long this[int i]=>Value[i];

public static A268455Inst Instance=new A268455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268454
{
public static readonly long[] Value={ 6L,36L,211L,1231L,7160L,41526L,240170L,1385338L,7970326L,45742764L,261899866L,1496074920L,8527336280L,48500972230L,275294704851L,1559507239653L,8817578095886L,49763675574292L,280352403988287L,1576707102660739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268454Inst : IEnumerable<long>
{
public static readonly long[] Value=A268454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268454.Bytes);
public long this[int i]=>Value[i];

public static A268454Inst Instance=new A268454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268453
{
public static readonly long[] Value={ 5L,25L,121L,581L,2776L,13204L,62535L,294967L,1385969L,6488635L,30273074L,140779986L,652648100L,3016745162L,13905372533L,63924885355L,293126854872L,1340883359460L,6119617278729L,27867658231717L,126637380509476L,574312506857594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268453Inst : IEnumerable<long>
{
public static readonly long[] Value=A268453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268453.Bytes);
public long this[int i]=>Value[i];

public static A268453Inst Instance=new A268453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A268452
{
public static readonly long[] Value={ 4L,16L,61L,229L,852L,3146L,11536L,42032L,152254L,548568L,1966757L,7019311L,24946486L,88313632L,311507619L,1095064315L,3837407016L,13407618832L,46715533678L,162345449332L,562801287366L,1946559269050L,6717910370343L,23136984979001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A268452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A268452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A268452Inst : IEnumerable<long>
{
public static readonly long[] Value=A268452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A268452.Bytes);
public long this[int i]=>Value[i];

public static A268452Inst Instance=new A268452Inst();

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