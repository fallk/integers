using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A133797
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,3L,12L,7L,7L,12L,15L,15L,15L,28L,15L,72L,31L,31L,60L,31L,72L,91L,63L,63L,124L,63L,168L,91L,312L,127L,127L,252L,127L,360L,195L,312L,255L,255L,255L,508L,255L,744L,403L,728L,255L,1240L,511L,511L,1020L,511L,1512L,819L,1560L,511L,1240L,1860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133797Inst : IEnumerable<long>
{
public static readonly long[] Value=A133797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133797.Bytes);
public long this[int i]=>Value[i];

public static A133797Inst Instance=new A133797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133798
{
public static readonly long[] Value={ 0L,0L,3L,14L,75L,454L,3185L,25486L,229383L,2293838L,25232229L,302786758L,3936227867L,55107190150L,826607852265L,13225725636254L,224837335816335L,4047072044694046L,76894368849186893L,1537887376983737878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133798Inst : IEnumerable<long>
{
public static readonly long[] Value=A133798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133798.Bytes);
public long this[int i]=>Value[i];

public static A133798Inst Instance=new A133798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133799
{
public static readonly BigInteger[] Value={ 1L,3L,6L,30L,180L,1260L,10080L,90720L,907200L,9979200L,119750400L,1556755200L,21794572800L,326918592000L,5230697472000L,88921857024000L,1600593426432000L,30411275102208000L,608225502044160000L,12772735542927360000UL,BigInteger.Parse("281000181944401920000") };
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
public class A133799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133799Inst Instance=new A133799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133832
{
public static readonly long[] Value={ 2L,3L,5L,13L,6L,7L,9L,9L,18L,19L,14L,13L,15L,17L,17L,81L,20L,19L,30L,33L,26L,27L,38L,81L,27L,35L,31L,33L,35L,31L,42L,458465L,36L,45L,47L,37L,67L,53L,41L,57L,42L,45L,46L,69L,54L,57L,53L,1009L,100L,119L,55L,73L,83L,67L,57L,1265L,74L,69L,66L,113L,75L,101L,66L,2241L,68L,67L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133832Inst : IEnumerable<long>
{
public static readonly long[] Value=A133832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133832.Bytes);
public long this[int i]=>Value[i];

public static A133832Inst Instance=new A133832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133833
{
public static readonly long[] Value={ 11L,97L,101L,997L,10007L,99991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133833Inst : IEnumerable<long>
{
public static readonly long[] Value=A133833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133833.Bytes);
public long this[int i]=>Value[i];

public static A133833Inst Instance=new A133833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133834
{
public static readonly long[] Value={ 1L,2L,4L,23L,76L,339L,1282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133834Inst : IEnumerable<long>
{
public static readonly long[] Value=A133834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133834.Bytes);
public long this[int i]=>Value[i];

public static A133834Inst Instance=new A133834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133835
{
public static readonly long[] Value={ 11L,101L,103L,107L,109L,139L,149L,179L,191L,193L,197L,199L,419L,421L,431L,433L,439L,443L,449L,479L,487L,547L,557L,571L,577L,587L,751L,757L,773L,787L,797L,877L,887L,1087L,1091L,1093L,1097L,1103L,1109L,1117L,1123L,1129L,1151L,1153L,1163L,1171L,1181L,1187L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133835Inst : IEnumerable<long>
{
public static readonly long[] Value=A133835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133835.Bytes);
public long this[int i]=>Value[i];

public static A133835Inst Instance=new A133835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133836
{
public static readonly BigInteger[] Value={ 97L,997L,99991L,9999991L,99999999977L,9999999999971L,99999999999999997L,9999999999999999961UL,BigInteger.Parse("99999999999999999999977"),BigInteger.Parse("99999999999999999999999999973"),BigInteger.Parse("9999999999999999999999999999973") };
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
public class A133836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133836.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133836Inst Instance=new A133836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133837
{
public static readonly long[] Value={ 6L,4L,26L,9L,10L,65L,33L,57L,21L,22L,377L,111L,39L,123L,87L,91L,95L,49L,206L,339L,121L,62L,393L,69L,141L,145L,74L,1141L,362L,93L,94L,95L,291L,505L,209L,106L,215L,219L,111L,339L,115L,1205L,253L,917L,685L,566L,289L,146L,295L,299L,303L,933L,159L,321L,489L,835L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133837Inst : IEnumerable<long>
{
public static readonly long[] Value=A133837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133837.Bytes);
public long this[int i]=>Value[i];

public static A133837Inst Instance=new A133837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133838
{
public static readonly long[] Value={ 2L,0L,1L,4L,0L,5L,2L,3L,5L,2L,7L,2L,6L,4L,2L,1L,8L,0L,6L,1L,5L,6L,6L,2L,6L,4L,3L,6L,5L,9L,0L,2L,7L,9L,9L,6L,0L,2L,8L,9L,3L,5L,7L,3L,7L,9L,5L,9L,3L,5L,1L,1L,4L,3L,9L,5L,7L,4L,1L,4L,6L,5L,8L,3L,2L,1L,9L,0L,2L,9L,4L,7L,6L,9L,7L,4L,9L,5L,1L,7L,7L,6L,0L,4L,6L,0L,6L,3L,2L,8L,4L,8L,1L,5L,6L,7L,7L,1L,8L,4L,7L,1L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133838Inst : IEnumerable<long>
{
public static readonly long[] Value=A133838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133838.Bytes);
public long this[int i]=>Value[i];

public static A133838Inst Instance=new A133838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133839
{
public static readonly long[] Value={ 1L,1L,8L,4L,1L,9L,7L,2L,3L,7L,6L,6L,7L,2L,9L,7L,1L,5L,3L,9L,5L,4L,7L,3L,4L,9L,5L,7L,3L,7L,1L,1L,0L,6L,0L,2L,6L,3L,2L,5L,5L,9L,8L,0L,5L,1L,7L,3L,5L,7L,6L,1L,7L,2L,6L,5L,6L,4L,1L,5L,9L,4L,4L,8L,2L,0L,3L,0L,7L,0L,1L,0L,4L,3L,2L,7L,5L,3L,1L,6L,7L,2L,0L,9L,5L,3L,8L,5L,8L,7L,7L,1L,5L,5L,7L,5L,3L,9L,1L,0L,4L,0L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133839Inst : IEnumerable<long>
{
public static readonly long[] Value=A133839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133839.Bytes);
public long this[int i]=>Value[i];

public static A133839Inst Instance=new A133839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133840
{
public static readonly long[] Value={ 2L,8L,3L,7L,5L,7L,2L,9L,6L,3L,8L,0L,0L,7L,5L,5L,2L,5L,6L,3L,8L,2L,3L,4L,9L,5L,1L,5L,7L,4L,7L,6L,7L,6L,9L,7L,8L,4L,6L,2L,5L,2L,8L,4L,5L,4L,2L,3L,4L,5L,1L,5L,4L,0L,4L,5L,6L,4L,5L,4L,1L,0L,1L,2L,1L,3L,6L,2L,5L,4L,3L,7L,4L,2L,5L,4L,2L,6L,9L,1L,6L,8L,8L,8L,7L,6L,2L,2L,3L,2L,5L,8L,6L,7L,6L,1L,2L,1L,6L,5L,4L,8L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133840Inst : IEnumerable<long>
{
public static readonly long[] Value=A133840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133840.Bytes);
public long this[int i]=>Value[i];

public static A133840Inst Instance=new A133840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133841
{
public static readonly long[] Value={ 9L,2L,4L,1L,3L,8L,8L,7L,3L,0L,0L,4L,5L,9L,1L,7L,6L,7L,0L,1L,2L,8L,2L,3L,2L,7L,1L,5L,0L,4L,3L,4L,5L,9L,7L,5L,6L,9L,6L,2L,9L,1L,5L,5L,9L,9L,3L,5L,1L,6L,3L,9L,1L,7L,5L,9L,7L,8L,1L,0L,5L,2L,9L,8L,4L,9L,7L,5L,9L,5L,4L,0L,1L,6L,2L,1L,9L,3L,8L,8L,1L,6L,8L,5L,6L,2L,7L,7L,7L,1L,2L,1L,4L,5L,8L,4L,7L,3L,8L,5L,5L,6L,9L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133841Inst : IEnumerable<long>
{
public static readonly long[] Value=A133841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133841.Bytes);
public long this[int i]=>Value[i];

public static A133841Inst Instance=new A133841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133842
{
public static readonly long[] Value={ 5L,4L,1L,0L,4L,4L,2L,2L,4L,6L,3L,5L,1L,8L,1L,6L,9L,8L,4L,7L,2L,7L,5L,9L,3L,3L,0L,2L,4L,1L,4L,7L,7L,1L,8L,6L,3L,9L,0L,6L,0L,4L,6L,7L,6L,8L,2L,6L,8L,2L,5L,8L,8L,7L,4L,5L,6L,3L,5L,4L,2L,1L,6L,9L,0L,8L,4L,2L,0L,5L,5L,8L,7L,9L,8L,1L,4L,6L,9L,7L,5L,3L,1L,4L,3L,9L,1L,9L,1L,0L,2L,1L,3L,2L,2L,7L,7L,7L,1L,0L,2L,4L,4L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133842Inst : IEnumerable<long>
{
public static readonly long[] Value=A133842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133842.Bytes);
public long this[int i]=>Value[i];

public static A133842Inst Instance=new A133842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133843
{
public static readonly long[] Value={ 1L,5L,0L,1L,9L,7L,5L,2L,6L,8L,2L,6L,8L,6L,1L,1L,4L,9L,8L,8L,6L,0L,3L,4L,8L,7L,0L,8L,0L,2L,9L,1L,2L,2L,5L,9L,9L,7L,3L,3L,8L,6L,1L,9L,0L,2L,1L,4L,4L,6L,5L,5L,1L,7L,0L,6L,5L,6L,8L,3L,4L,7L,3L,1L,0L,5L,2L,9L,7L,9L,1L,0L,4L,7L,3L,9L,8L,5L,9L,5L,3L,4L,2L,9L,2L,2L,8L,8L,0L,0L,6L,2L,7L,7L,8L,1L,1L,0L,4L,5L,2L,5L,2L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133843Inst : IEnumerable<long>
{
public static readonly long[] Value=A133843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133843.Bytes);
public long this[int i]=>Value[i];

public static A133843Inst Instance=new A133843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133844
{
public static readonly long[] Value={ 1L,4L,0L,9L,3L,5L,6L,2L,7L,0L,3L,5L,4L,6L,1L,9L,7L,0L,3L,6L,1L,1L,3L,6L,2L,9L,0L,8L,7L,4L,2L,3L,5L,9L,1L,0L,8L,1L,7L,1L,2L,1L,4L,5L,5L,0L,6L,4L,1L,4L,8L,6L,7L,9L,7L,5L,3L,8L,2L,7L,2L,3L,9L,5L,8L,9L,1L,8L,0L,0L,8L,1L,5L,5L,2L,0L,9L,7L,7L,5L,8L,7L,3L,5L,5L,9L,8L,5L,4L,9L,8L,6L,5L,8L,7L,2L,3L,9L,7L,8L,0L,9L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133844Inst : IEnumerable<long>
{
public static readonly long[] Value=A133844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133844.Bytes);
public long this[int i]=>Value[i];

public static A133844Inst Instance=new A133844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133845
{
public static readonly long[] Value={ 4L,4L,0L,0L,5L,3L,4L,6L,7L,0L,5L,2L,4L,9L,2L,3L,0L,2L,3L,9L,1L,3L,3L,4L,5L,2L,6L,5L,1L,8L,6L,1L,7L,4L,9L,9L,1L,6L,8L,2L,8L,1L,3L,7L,6L,8L,0L,2L,6L,6L,9L,8L,8L,1L,8L,9L,4L,2L,7L,2L,4L,6L,9L,3L,0L,7L,5L,2L,2L,0L,2L,1L,8L,7L,0L,0L,0L,3L,7L,1L,9L,6L,4L,6L,2L,7L,6L,9L,7L,5L,8L,9L,2L,3L,0L,7L,5L,8L,6L,3L,4L,8L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133845Inst : IEnumerable<long>
{
public static readonly long[] Value=A133845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133845.Bytes);
public long this[int i]=>Value[i];

public static A133845Inst Instance=new A133845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133846
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,5L,7L,11L,19L,31L,111L,195L,283L,465L,831L,1381L,4969L,8741L,12697L,20885L,37353L,62101L,223471L,393121L,571051L,939331L,1680031L,2793151L,10051203L,17681675L,25684567L,42248981L,75564019L,125629681L,452080641L,795282225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133846Inst : IEnumerable<long>
{
public static readonly long[] Value=A133846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133846.Bytes);
public long this[int i]=>Value[i];

public static A133846Inst Instance=new A133846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133847
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,5L,7L,9L,13L,21L,33L,49L,169L,293L,421L,553L,823L,1365L,2179L,3265L,11289L,19585L,28153L,36993L,55081L,91393L,145929L,218689L,756163L,1311861L,1885783L,2477929L,3689557L,6121925L,9775033L,14648881L,50651601L,87875061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133847Inst : IEnumerable<long>
{
public static readonly long[] Value=A133847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133847.Bytes);
public long this[int i]=>Value[i];

public static A133847Inst Instance=new A133847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133912
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-2L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,-1L,1L,1L,-2L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,1L,1L,1L,-4L,1L,-1L,1L,1L,-2L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,-1L,1L,1L,-2L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,1L,1L,1L,-4L,1L,-1L,1L,1L,-2L,1L,-1L,1L,1L,-2L,1L,1L,1L,-3L,1L,-1L,1L,1L,-2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133912Inst : IEnumerable<long>
{
public static readonly long[] Value=A133912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133912.Bytes);
public long this[int i]=>Value[i];

public static A133912Inst Instance=new A133912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133913
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,1L,4L,4L,2L,1L,5L,8L,6L,3L,1L,6L,13L,14L,9L,1L,1L,7L,19L,27L,23L,10L,2L,1L,8L,26L,46L,50L,33L,12L,1L,1L,9L,34L,72L,96L,83L,45L,13L,2L,1L,10L,43L,106L,168L,179L,128L,58L,15L,3L,1L,11L,53L,149L,274L,347L,307L,186L,73L,18L,1L,1L,12L,64L,202L,423L,621L,654L,493L,259L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133913Inst : IEnumerable<long>
{
public static readonly long[] Value=A133913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133913.Bytes);
public long this[int i]=>Value[i];

public static A133913Inst Instance=new A133913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133914
{
public static readonly long[] Value={ 1L,3L,5L,11L,23L,44L,89L,177L,355L,711L,1420L,2841L,5683L,11367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133914Inst : IEnumerable<long>
{
public static readonly long[] Value=A133914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133914.Bytes);
public long this[int i]=>Value[i];

public static A133914Inst Instance=new A133914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133915
{
public static readonly long[] Value={ 1L,2L,8L,30L,116L,452L,1772L,6974L,27524L,108852L,431168L,1709996L,6788536L,26971856L,107235668L,426594110L,1697855876L,6760326116L,26927208368L,107288242820L,427596003416L,1704598377176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133915Inst : IEnumerable<long>
{
public static readonly long[] Value=A133915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133915.Bytes);
public long this[int i]=>Value[i];

public static A133915Inst Instance=new A133915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133916
{
public static readonly long[] Value={ 1L,3L,1L,3L,2L,8L,3L,7L,1L,8L,3L,5L,3L,4L,8L,3L,5L,9L,4L,4L,4L,3L,6L,3L,0L,9L,4L,7L,3L,9L,7L,5L,4L,9L,1L,2L,0L,0L,7L,0L,3L,5L,7L,4L,2L,9L,1L,8L,9L,6L,5L,7L,2L,6L,3L,4L,5L,1L,7L,9L,3L,2L,3L,9L,7L,3L,3L,8L,5L,7L,0L,2L,8L,5L,4L,5L,5L,3L,8L,3L,9L,5L,9L,8L,9L,6L,2L,4L,2L,8L,9L,8L,0L,7L,2L,9L,3L,5L,7L,8L,5L,7L,3L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133916Inst : IEnumerable<long>
{
public static readonly long[] Value=A133916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133916.Bytes);
public long this[int i]=>Value[i];

public static A133916Inst Instance=new A133916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133917
{
public static readonly long[] Value={ 2L,6L,3L,9L,2L,4L,9L,5L,1L,3L,8L,9L,8L,5L,5L,3L,1L,9L,0L,8L,0L,8L,9L,9L,4L,9L,8L,3L,5L,3L,6L,6L,2L,9L,6L,0L,7L,8L,4L,2L,0L,9L,6L,8L,4L,5L,1L,7L,5L,5L,5L,6L,4L,0L,9L,7L,5L,6L,2L,9L,1L,2L,7L,4L,6L,4L,4L,9L,3L,5L,1L,1L,0L,8L,0L,3L,8L,3L,9L,9L,4L,1L,7L,7L,7L,4L,1L,0L,8L,8L,2L,4L,9L,9L,9L,7L,4L,7L,4L,3L,4L,4L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133917Inst : IEnumerable<long>
{
public static readonly long[] Value=A133917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133917.Bytes);
public long this[int i]=>Value[i];

public static A133917Inst Instance=new A133917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133918
{
public static readonly long[] Value={ 8L,2L,2L,4L,2L,9L,2L,7L,7L,2L,6L,9L,1L,2L,1L,8L,9L,1L,3L,4L,9L,9L,9L,8L,7L,2L,4L,2L,5L,6L,6L,5L,9L,0L,9L,3L,2L,9L,1L,5L,4L,7L,9L,4L,6L,2L,0L,8L,7L,6L,5L,8L,7L,3L,9L,5L,3L,1L,1L,5L,9L,0L,6L,6L,9L,7L,8L,3L,5L,4L,1L,8L,6L,3L,8L,7L,0L,9L,8L,5L,6L,8L,8L,4L,5L,4L,9L,3L,8L,2L,6L,0L,2L,6L,0L,7L,9L,7L,6L,4L,2L,3L,9L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133918Inst : IEnumerable<long>
{
public static readonly long[] Value=A133918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133918.Bytes);
public long this[int i]=>Value[i];

public static A133918Inst Instance=new A133918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133919
{
public static readonly long[] Value={ 9L,1L,9L,9L,3L,7L,6L,6L,7L,7L,1L,6L,1L,9L,9L,4L,2L,2L,3L,3L,2L,1L,6L,8L,2L,2L,3L,2L,8L,6L,7L,7L,1L,1L,3L,1L,7L,0L,7L,4L,1L,3L,3L,0L,7L,8L,0L,7L,3L,6L,5L,5L,4L,6L,8L,3L,9L,8L,2L,3L,6L,7L,2L,6L,3L,9L,0L,6L,6L,6L,5L,5L,5L,7L,9L,7L,0L,2L,4L,5L,1L,6L,1L,4L,3L,4L,6L,9L,8L,9L,0L,4L,3L,8L,2L,4L,9L,0L,8L,5L,3L,4L,4L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133919Inst : IEnumerable<long>
{
public static readonly long[] Value=A133919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133919.Bytes);
public long this[int i]=>Value[i];

public static A133919Inst Instance=new A133919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133920
{
public static readonly long[] Value={ 2L,2L,9L,9L,9L,1L,0L,3L,3L,0L,2L,2L,8L,4L,1L,0L,9L,1L,4L,9L,5L,8L,1L,1L,0L,6L,9L,1L,0L,5L,0L,6L,2L,5L,4L,4L,7L,2L,6L,5L,6L,7L,3L,2L,9L,0L,3L,6L,5L,8L,0L,5L,6L,1L,1L,2L,7L,4L,9L,9L,5L,5L,1L,6L,1L,6L,8L,6L,9L,1L,6L,3L,7L,5L,0L,5L,3L,5L,7L,5L,9L,3L,8L,7L,0L,9L,1L,9L,4L,9L,8L,9L,6L,3L,9L,6L,8L,2L,6L,0L,6L,9L,4L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133920Inst : IEnumerable<long>
{
public static readonly long[] Value=A133920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133920.Bytes);
public long this[int i]=>Value[i];

public static A133920Inst Instance=new A133920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133921
{
public static readonly long[] Value={ 4L,8L,5L,4L,1L,7L,0L,2L,3L,7L,3L,0L,8L,8L,2L,3L,3L,9L,7L,0L,6L,8L,1L,4L,3L,7L,8L,6L,8L,1L,8L,4L,4L,6L,3L,4L,0L,5L,3L,6L,3L,1L,0L,2L,9L,6L,8L,4L,2L,8L,4L,4L,2L,9L,8L,8L,6L,1L,4L,6L,0L,2L,7L,5L,4L,6L,3L,5L,3L,6L,4L,5L,1L,6L,2L,0L,1L,9L,5L,7L,6L,0L,2L,7L,5L,4L,2L,6L,8L,9L,6L,6L,6L,3L,2L,1L,6L,6L,6L,2L,6L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133921Inst : IEnumerable<long>
{
public static readonly long[] Value=A133921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133921.Bytes);
public long this[int i]=>Value[i];

public static A133921Inst Instance=new A133921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133922
{
public static readonly BigInteger[] Value={ 1L,2L,2L,16L,16L,192L,192L,6912L,4608L,230400L,230400L,11612160L,11612160L,1199923200L,588349440L,98594979840L,98594979840L,11076328488960L,11076328488960L,2102897147904000L,1076597725593600L,331238941183180800L,331238941183180800L,BigInteger.Parse("66325953940291584000"),BigInteger.Parse("56326771107377971200") };
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
public class A133922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133922Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A133922.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A133922.Bytes);
public BigInteger this[int i]=>Value[i];

public static A133922Inst Instance=new A133922Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133923
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,1L,4L,2L,1L,2L,1L,2L,1L,4L,2L,1L,6L,3L,12L,6L,3L,4L,2L,1L,4L,2L,1L,2L,1L,2L,1L,4L,2L,1L,9L,6L,3L,6L,3L,4L,2L,1L,6L,3L,8L,4L,2L,1L,6L,3L,12L,6L,3L,8L,4L,2L,1L,2L,1L,2L,1L,6L,3L,8L,4L,2L,1L,4L,2L,1L,12L,6L,3L,9L,18L,9L,16L,8L,4L,2L,1L,2L,1L,4L,2L,1L,8L,4L,2L,1L,6L,3L,8L,4L,2L,1L,6L,3L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133923Inst : IEnumerable<long>
{
public static readonly long[] Value=A133923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133923.Bytes);
public long this[int i]=>Value[i];

public static A133923Inst Instance=new A133923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133924
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,3L,2L,2L,2L,4L,3L,3L,3L,2L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,4L,4L,4L,4L,4L,4L,4L,6L,5L,5L,5L,5L,5L,4L,4L,4L,4L,4L,6L,6L,6L,6L,6L,6L,6L,5L,5L,5L,5L,7L,7L,7L,6L,6L,6L,6L,6L,6L,6L,4L,6L,6L,8L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,9L,9L,8L,8L,8L,8L,8L,8L,7L,7L,7L,7L,7L,7L,7L,7L,7L,9L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133924Inst : IEnumerable<long>
{
public static readonly long[] Value=A133924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133924.Bytes);
public long this[int i]=>Value[i];

public static A133924Inst Instance=new A133924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133925
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,0L,3L,1L,2L,3L,1L,5L,1L,5L,4L,3L,8L,2L,10L,5L,8L,12L,5L,18L,7L,18L,17L,13L,30L,12L,36L,24L,31L,47L,25L,66L,36L,67L,71L,56L,113L,61L,133L,107L,123L,184L,117L,246L,168L,256L,291L,240L,430L,285L,502L,459L,496L,721L,525L,932L,744L,998L,1180L,1021L,1653L,1269L,1930L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133925Inst : IEnumerable<long>
{
public static readonly long[] Value=A133925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133925.Bytes);
public long this[int i]=>Value[i];

public static A133925Inst Instance=new A133925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133926
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,2L,1L,3L,2L,3L,4L,3L,6L,4L,7L,7L,7L,11L,8L,14L,12L,15L,19L,16L,26L,21L,30L,32L,32L,46L,38L,57L,54L,63L,79L,71L,104L,93L,121L,134L,135L,184L,165L,226L,228L,257L,319L,301L,411L,394L,484L,548L,559L,731L,696L,896L,943L,1044L,1280L,1256L,1628L,1640L,1941L,2224L,2301L,2909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133926Inst : IEnumerable<long>
{
public static readonly long[] Value=A133926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133926.Bytes);
public long this[int i]=>Value[i];

public static A133926Inst Instance=new A133926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A133927
{
public static readonly long[] Value={ 1L,30L,494L,6331L,36851L,95450L,122614L,940745L,5126032L,7519204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A133927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A133927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A133927Inst : IEnumerable<long>
{
public static readonly long[] Value=A133927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A133927.Bytes);
public long this[int i]=>Value[i];

public static A133927Inst Instance=new A133927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134024
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,3L,3L,4L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,3L,3L,4L,1L,1L,2L,1L,1L,2L,2L,2L,3L,1L,1L,2L,1L,1L,2L,2L,2L,3L,2L,2L,3L,2L,2L,3L,3L,3L,4L,2L,2L,3L,2L,2L,3L,3L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134024Inst : IEnumerable<long>
{
public static readonly long[] Value=A134024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134024.Bytes);
public long this[int i]=>Value[i];

public static A134024Inst Instance=new A134024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134025
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,10L,11L,12L,13L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134025Inst : IEnumerable<long>
{
public static readonly long[] Value=A134025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134025.Bytes);
public long this[int i]=>Value[i];

public static A134025Inst Instance=new A134025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134026
{
public static readonly long[] Value={ 2L,5L,6L,7L,8L,14L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,122L,123L,124L,125L,126L,127L,128L,129L,130L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134026Inst : IEnumerable<long>
{
public static readonly long[] Value=A134026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134026.Bytes);
public long this[int i]=>Value[i];

public static A134026Inst Instance=new A134026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134027
{
public static readonly long[] Value={ 0L,1L,4L,7L,10L,13L,16L,28L,40L,43L,52L,61L,73L,82L,91L,103L,112L,121L,124L,160L,196L,208L,244L,280L,292L,328L,364L,367L,394L,421L,457L,484L,511L,547L,574L,601L,613L,640L,667L,703L,730L,757L,793L,820L,847L,859L,886L,913L,949L,976L,1003L,1039L,1066L,1093L,1096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134027Inst : IEnumerable<long>
{
public static readonly long[] Value=A134027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134027.Bytes);
public long this[int i]=>Value[i];

public static A134027Inst Instance=new A134027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134028
{
public static readonly long[] Value={ 0L,1L,-2L,1L,4L,-11L,-2L,7L,-8L,1L,10L,-5L,4L,13L,-38L,-11L,16L,-29L,-2L,25L,-20L,7L,34L,-35L,-8L,19L,-26L,1L,28L,-17L,10L,37L,-32L,-5L,22L,-23L,4L,31L,-14L,13L,40L,-119L,-38L,43L,-92L,-11L,70L,-65L,16L,97L,-110L,-29L,52L,-83L,-2L,79L,-56L,25L,106L,-101L,-20L,61L,-74L,7L,88L,-47L,34L,115L,-116L,-35L,46L,-89L,-8L,73L,-62L,19L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134028Inst : IEnumerable<long>
{
public static readonly long[] Value=A134028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134028.Bytes);
public long this[int i]=>Value[i];

public static A134028Inst Instance=new A134028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134029
{
public static readonly long[] Value={ 3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L,3L,2L,4L,1L,5L,1L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134029Inst : IEnumerable<long>
{
public static readonly long[] Value=A134029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134029.Bytes);
public long this[int i]=>Value[i];

public static A134029Inst Instance=new A134029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134030
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,11L,13L,15L,18L,20L,23L,26L,28L,32L,35L,38L,42L,46L,49L,54L,58L,62L,67L,71L,76L,81L,86L,92L,97L,103L,109L,115L,121L,127L,134L,140L,147L,154L,161L,168L,176L,183L,191L,199L,207L,215L,223L,232L,240L,249L,258L,267L,277L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134030Inst : IEnumerable<long>
{
public static readonly long[] Value=A134030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134030.Bytes);
public long this[int i]=>Value[i];

public static A134030Inst Instance=new A134030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134031
{
public static readonly long[] Value={ 1L,3L,6L,9L,14L,19L,24L,30L,37L,44L,52L,60L,68L,77L,86L,96L,106L,117L,128L,139L,151L,163L,175L,188L,201L,215L,229L,243L,257L,272L,287L,303L,318L,334L,351L,368L,385L,402L,419L,437L,456L,474L,493L,512L,531L,551L,571L,591L,611L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134031Inst : IEnumerable<long>
{
public static readonly long[] Value=A134031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134031.Bytes);
public long this[int i]=>Value[i];

public static A134031Inst Instance=new A134031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134032
{
public static readonly long[] Value={ 1L,2L,1L,5L,2L,1L,13L,4L,2L,1L,34L,5L,3L,2L,1L,89L,10L,4L,3L,2L,1L,233L,13L,5L,4L,3L,2L,1L,610L,26L,7L,5L,4L,3L,2L,1L,1597L,34L,10L,7L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134032Inst : IEnumerable<long>
{
public static readonly long[] Value=A134032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134032.Bytes);
public long this[int i]=>Value[i];

public static A134032Inst Instance=new A134032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134033
{
public static readonly long[] Value={ 1L,3L,1L,5L,2L,1L,17L,3L,2L,1L,29L,5L,3L,2L,1L,99L,10L,4L,3L,2L,1L,169L,17L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134033Inst : IEnumerable<long>
{
public static readonly long[] Value=A134033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134033.Bytes);
public long this[int i]=>Value[i];

public static A134033Inst Instance=new A134033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134034
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,1L,3L,3L,1L,3L,1L,2L,3L,2L,4L,1L,2L,4L,1L,4L,3L,1L,4L,1L,3L,2L,4L,3L,1L,4L,3L,4L,3L,3L,2L,2L,3L,3L,4L,3L,4L,3L,4L,2L,3L,4L,3L,2L,5L,2L,4L,4L,3L,3L,4L,3L,5L,3L,5L,4L,4L,1L,4L,4L,4L,3L,4L,6L,3L,2L,2L,3L,7L,3L,6L,2L,5L,4L,7L,2L,3L,5L,5L,3L,4L,3L,5L,4L,3L,3L,6L,5L,3L,5L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134034Inst : IEnumerable<long>
{
public static readonly long[] Value=A134034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134034.Bytes);
public long this[int i]=>Value[i];

public static A134034Inst Instance=new A134034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134035
{
public static readonly long[] Value={ 2L,4L,8L,13L,21L,39L,64L,138L,236L,551L,963L,2315L,4078L,9892L,17468L,42481L,75069L,182691L,322900L,785970L,1389248L,3381731L,5977491L,14550695L,25719658L,62608228L,110665760L,269388997L,476169765L,1159120239L,2048851480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134035Inst : IEnumerable<long>
{
public static readonly long[] Value=A134035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134035.Bytes);
public long this[int i]=>Value[i];

public static A134035Inst Instance=new A134035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134036
{
public static readonly long[] Value={ 11L,11L,12L,13L,21L,21L,23L,23L,25L,29L,29L,31L,32L,31L,32L,35L,38L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134036Inst : IEnumerable<long>
{
public static readonly long[] Value=A134036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134036.Bytes);
public long this[int i]=>Value[i];

public static A134036Inst Instance=new A134036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134037
{
public static readonly long[] Value={ 33L,77L,13L,71L,18L,11L,75L,72L,12L,16L,71L,71L,16L,75L,71L,71L,14L,12L,11L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134037Inst : IEnumerable<long>
{
public static readonly long[] Value=A134037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134037.Bytes);
public long this[int i]=>Value[i];

public static A134037Inst Instance=new A134037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134038
{
public static readonly long[] Value={ 4L,6L,11L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134038Inst : IEnumerable<long>
{
public static readonly long[] Value=A134038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134038.Bytes);
public long this[int i]=>Value[i];

public static A134038Inst Instance=new A134038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134039
{
public static readonly long[] Value={ 7L,13L,47L,683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134039Inst : IEnumerable<long>
{
public static readonly long[] Value=A134039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134039.Bytes);
public long this[int i]=>Value[i];

public static A134039Inst Instance=new A134039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134040
{
public static readonly BigInteger[] Value={ 1L,2L,4L,14L,140L,4964L,808870L,726210606L,4161522164020L,170403742275382924L,BigInteger.Parse("54674613696351170731038"),BigInteger.Parse("148019646825727958873435181692"),BigInteger.Parse("3596203368022579371689526442266893534") };
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
public class A134040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134040Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134040.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134040.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134040Inst Instance=new A134040Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134041
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,6L,14L,36L,114L,450L,2268L,14442L,118686L,1264678L,17519842L,318273566L,7607402556L,240151303078L,10055927801538L,559859566727028L,41582482495661986L,4129785050606801246L,BigInteger.Parse("549628445573614296188"),BigInteger.Parse("98256218721544814784486"),BigInteger.Parse("23631541930531250077261282") };
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
public class A134041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134041Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134041.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134041.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134041Inst Instance=new A134041Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134042
{
public static readonly long[] Value={ -4L,2L,8L,11L,26L,422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134042Inst : IEnumerable<long>
{
public static readonly long[] Value=A134042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134042.Bytes);
public long this[int i]=>Value[i];

public static A134042Inst Instance=new A134042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134043
{
public static readonly long[] Value={ 7L,11L,25L,38L,133L,8669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134043Inst : IEnumerable<long>
{
public static readonly long[] Value=A134043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134043.Bytes);
public long this[int i]=>Value[i];

public static A134043Inst Instance=new A134043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134044
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,15L,30L,58L,113L,220L,429L,835L,1627L,3169L,6172L,12023L,23419L,45616L,88853L,173073L,337118L,656656L,1279065L,2491423L,4852911L,9452731L,18412473L,35864686L,69858930L,136074521L,265052378L,516281541L,1005637564L,1958828336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134044Inst : IEnumerable<long>
{
public static readonly long[] Value=A134044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134044.Bytes);
public long this[int i]=>Value[i];

public static A134044Inst Instance=new A134044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134045
{
public static readonly long[] Value={ 1L,3L,7L,18L,61L,258L,1177L,5358L,23821L,103338L,439297L,1838598L,7605781L,31191618L,127100617L,515462238L,2083142941L,8396683098L,33779525137L,135697396278L,544529307301L,2183340065778L,8749036112857L,35043186680718L,140313902770861L,561679137947658L,2247987249823777L,8995761328275558L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134045Inst : IEnumerable<long>
{
public static readonly long[] Value=A134045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134045.Bytes);
public long this[int i]=>Value[i];

public static A134045Inst Instance=new A134045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134046
{
public static readonly BigInteger[] Value={ 1L,2L,-2L,-20L,-394L,-72756L,-38636660L,-62621451464L,-320115036508314L,-5370757579794299764L,BigInteger.Parse("-307243789286348665328060"),BigInteger.Parse("-61750332256061511777753774808"),BigInteger.Parse("-44549932891827456895274618101297860"),BigInteger.Parse("-117151486172958209318246658698308578710856") };
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
public class A134046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134046Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134046.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134046.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134046Inst Instance=new A134046Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134047
{
public static readonly BigInteger[] Value={ 1L,2L,6L,50L,1586L,182274L,70856770L,91955753218L,404598404260610L,6173936430806583298L,BigInteger.Parse("333433524033498566071298"),BigInteger.Parse("64757369178015130100982820866"),BigInteger.Parse("45786845522362297626576735328694274") };
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
public class A134047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134047Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134047.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134047.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134047Inst Instance=new A134047Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134048
{
public static readonly BigInteger[] Value={ 1L,4L,28L,548L,35108L,7507972L,5383397764L,13122109416964L,110735166982705668L,BigInteger.Parse("3291956693540520243204"),BigInteger.Parse("349880644048154072353961988"),BigInteger.Parse("134569675810924626719483447943172") };
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
public class A134048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134048.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134048Inst Instance=new A134048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134049
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,23L,40L,16L,1L,512L,1072L,576L,64L,1L,34939L,84736L,56064L,8704L,256L,1L,7637688L,20930240L,16261120L,3190784L,135168L,1024L,1L,5539372954L,16855075840L,14918594560L,3501457408L,191561728L,2129920L,4096L,1L,13703105571256L,45696508860928L,45120522420224L,12230958252032L,813938245632L,11856248832L,33816576L,16384L,1L,118149647382446899L,427467706869837824L,463647865862488064L,141682892446105600L,11040640699727872L,197960679817216L,745898246144L,538968064L,65536L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134049Inst : IEnumerable<long>
{
public static readonly long[] Value=A134049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134049.Bytes);
public long this[int i]=>Value[i];

public static A134049Inst Instance=new A134049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134050
{
public static readonly BigInteger[] Value={ 1L,1L,3L,23L,512L,34939L,7637688L,5539372954L,13703105571256L,118149647382446899L,BigInteger.Parse("3611029954044991125872"),BigInteger.Parse("396437704741571722701763726"),BigInteger.Parse("158000007601023255711816905096600"),BigInteger.Parse("230573407734730856178976755626889887934"),BigInteger.Parse("1240859469782266733203067689710529642528338320"),BigInteger.Parse("24774501349228223607795736923546381007921447933762900"),BigInteger.Parse("1844552309599593759846481462075800633418691335116469275638832"),BigInteger.Parse("514424614172853969912935745275645969935778834184491996786063734076739") };
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
public class A134050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134050Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134050.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134050.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134050Inst Instance=new A134050Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134051
{
public static readonly BigInteger[] Value={ 1L,2L,10L,134L,5296L,654070L,263360560L,357003975476L,1669795729960304L,BigInteger.Parse("27463303283181254246"),BigInteger.Parse("1611997717693371814854368"),BigInteger.Parse("341658984940005114542280763676"),BigInteger.Parse("263970944698309599873282861747395376"),BigInteger.Parse("749286382285580603530480750573407791776124"),BigInteger.Parse("7865298802379026632132665433693770690173266977568"),BigInteger.Parse("307033171145749412684239046186235780900756052952468535976"),BigInteger.Parse("44787318088048191911792372704769709799574702261206913048329680992") };
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
public class A134051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134051Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134051.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134051.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134051Inst Instance=new A134051Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134052
{
public static readonly BigInteger[] Value={ 1L,4L,36L,876L,63520L,14568940L,11015752544L,28298819937896L,252647456547947232L,BigInteger.Parse("7975964313047992544460"),BigInteger.Parse("902538504812752048885181888"),BigInteger.Parse("370060584941821136890734642254392"),BigInteger.Parse("554686213433000991860635347227024504416"),BigInteger.Parse("3061850209996287672654225041045426728192508664"),BigInteger.Parse("62630012990169232252394969915444571881064532934837824"),BigInteger.Parse("4772629734773204290203117007836601388039453077250181639664976"),BigInteger.Parse("1361188462171480354335535757250707673963106696295682082795368090890432") };
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
public class A134052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134052Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134052.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134052.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134052Inst Instance=new A134052Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134053
{
public static readonly BigInteger[] Value={ 1L,8L,136L,6232L,854848L,373259224L,540477342400L,2672052251004112L,BigInteger.Parse("46088422295844824512"),BigInteger.Parse("2819594595499446574537112"),BigInteger.Parse("619804662273405542773923781504"),BigInteger.Parse("494669890490702036481614523776214128"),BigInteger.Parse("1445689562032160359098054773761542867676352"),BigInteger.Parse("15582205179106128515694061249394708070061006521840"),BigInteger.Parse("623164384826393004269624677225320058520632702496162024576"),BigInteger.Parse("92950754406669433360560292231532867334028809841256765779355298464"),BigInteger.Parse("51944751631411703759398930923077536382840396924192243346470672357124333952") };
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
public class A134053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134053Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134053.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134053.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134053Inst Instance=new A134053Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134054
{
public static readonly BigInteger[] Value={ 1L,2L,8L,80L,2225L,184700L,48156025L,41008196507L,117576923431865L,1162187460377703220L,BigInteger.Parse("40342092016795699709297"),BigInteger.Parse("4989979910857539524339725455"),BigInteger.Parse("2225169577804416081963640015838617"),BigInteger.Parse("3611404965468239375529128539282974032063"),BigInteger.Parse("21500912257369373138838006883103647202061119889"),BigInteger.Parse("472700949365256437455861341996789835116478103190166869"),BigInteger.Parse("38594839432514958712997836406329517947410813633064955364162609"),BigInteger.Parse("11760334792404044930820367474465749383281197807007630470152427553813828") };
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
public class A134054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134054Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134054.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134054.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134054Inst Instance=new A134054Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134055
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,41L,252L,1782L,14121L,123244L,1169832L,11960978L,130742196L,1518514076L,18645970943L,241030821566L,3268214127548L,46338504902485L,685145875623056L,10538790233183702L,168282662416550040L,2784205185437851772L,BigInteger.Parse("47646587512911994120") };
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
public class A134055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134055Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134055.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134055.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134055Inst Instance=new A134055Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134056
{
public static readonly long[] Value={ 1L,1L,7L,131L,131L,2897L,21997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134056Inst : IEnumerable<long>
{
public static readonly long[] Value=A134056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134056.Bytes);
public long this[int i]=>Value[i];

public static A134056Inst Instance=new A134056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134057
{
public static readonly long[] Value={ 0L,0L,3L,21L,105L,465L,1953L,8001L,32385L,130305L,522753L,2094081L,8382465L,33542145L,134193153L,536821761L,2147385345L,8589737985L,34359345153L,137438167041L,549754241025L,2199020109825L,8796086730753L,35184359505921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134057Inst : IEnumerable<long>
{
public static readonly long[] Value=A134057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134057.Bytes);
public long this[int i]=>Value[i];

public static A134057Inst Instance=new A134057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134058
{
public static readonly long[] Value={ 1L,2L,2L,2L,4L,2L,2L,6L,6L,2L,2L,8L,12L,8L,2L,2L,10L,20L,20L,10L,2L,2L,12L,30L,40L,30L,12L,2L,2L,14L,42L,70L,70L,42L,14L,2L,2L,16L,56L,112L,140L,112L,56L,16L,2L,2L,18L,72L,168L,252L,252L,168L,72L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134058Inst : IEnumerable<long>
{
public static readonly long[] Value=A134058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134058.Bytes);
public long this[int i]=>Value[i];

public static A134058Inst Instance=new A134058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134059
{
public static readonly long[] Value={ 1L,3L,3L,3L,6L,3L,3L,9L,9L,3L,3L,12L,18L,12L,3L,3L,15L,30L,30L,15L,3L,3L,18L,45L,60L,45L,18L,3L,3L,21L,63L,105L,105L,63L,21L,3L,3L,24L,84L,168L,210L,168L,84L,24L,3L,3L,27L,108L,252L,378L,378L,252L,108L,27L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134059Inst : IEnumerable<long>
{
public static readonly long[] Value=A134059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134059.Bytes);
public long this[int i]=>Value[i];

public static A134059Inst Instance=new A134059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134060
{
public static readonly long[] Value={ 1L,2L,3L,2L,6L,3L,2L,9L,9L,3L,2L,12L,18L,12L,3L,2L,15L,30L,30L,15L,3L,2L,18L,45L,60L,45L,18L,3L,2L,21L,63L,105L,105L,63L,21L,3L,2L,24L,84L,168L,210L,168L,84L,24L,3L,2L,27L,108L,252L,378L,378L,252L,108L,27L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134060Inst : IEnumerable<long>
{
public static readonly long[] Value=A134060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134060.Bytes);
public long this[int i]=>Value[i];

public static A134060Inst Instance=new A134060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134061
{
public static readonly long[] Value={ 1L,3L,5L,3L,10L,5L,3L,15L,15L,5L,3L,20L,30L,20L,5L,3L,25L,50L,50L,25L,5L,3L,30L,75L,100L,75L,30L,5L,3L,35L,105L,175L,175L,105L,35L,5L,3L,40L,140L,280L,350L,280L,140L,40L,5L,3L,45L,180L,420L,630L,630L,420L,180L,45L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134061Inst : IEnumerable<long>
{
public static readonly long[] Value=A134061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134061.Bytes);
public long this[int i]=>Value[i];

public static A134061Inst Instance=new A134061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134062
{
public static readonly long[] Value={ 1L,8L,18L,38L,78L,158L,318L,638L,1278L,2558L,5118L,10238L,20478L,40958L,81918L,163838L,327678L,655358L,1310718L,2621438L,5242878L,10485758L,20971518L,41943038L,83886078L,167772158L,335544318L,671088638L,1342177278L,2684354558L,5368709118L,10737418238L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134062Inst : IEnumerable<long>
{
public static readonly long[] Value=A134062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134062.Bytes);
public long this[int i]=>Value[i];

public static A134062Inst Instance=new A134062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134063
{
public static readonly long[] Value={ 1L,1L,2L,7L,26L,91L,302L,967L,3026L,9331L,28502L,86527L,261626L,788971L,2375102L,7141687L,21457826L,64439011L,193448102L,580606447L,1742343626L,5228079451L,15686335502L,47063200807L,141197991026L,423610750291L,1270865805302L,3812664524767L,11438127792026L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134063Inst : IEnumerable<long>
{
public static readonly long[] Value=A134063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134063.Bytes);
public long this[int i]=>Value[i];

public static A134063Inst Instance=new A134063Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134064
{
public static readonly long[] Value={ 1L,2L,6L,23L,96L,407L,1716L,7163L,29616L,121487L,495276L,2009603L,8124936L,32761367L,131834436L,529712843L,2125993056L,8525430047L,34166159196L,136858084883L,548012945976L,2193794127527L,8780404589556L,35137304693723L,140596281975696L,562526325893807L,2250528914325516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134064Inst : IEnumerable<long>
{
public static readonly long[] Value=A134064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134064.Bytes);
public long this[int i]=>Value[i];

public static A134064Inst Instance=new A134064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134065
{
public static readonly long[] Value={ 1L,3L,4L,3L,8L,4L,3L,12L,12L,4L,3L,16L,24L,16L,4L,20L,40L,40L,20L,4L,3L,24L,60L,80L,60L,24L,4L,3L,28L,84L,140L,140L,84L,28L,4L,3L,32L,112L,224L,280L,224L,112L,32L,3L,36L,144L,336L,504L,504L,336L,144L,36L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134065Inst : IEnumerable<long>
{
public static readonly long[] Value=A134065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134065.Bytes);
public long this[int i]=>Value[i];

public static A134065Inst Instance=new A134065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134066
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,2L,12L,12L,4L,2L,16L,24L,16L,4L,2L,20L,40L,40L,20L,4L,2L,24L,60L,80L,60L,24L,4L,2L,28L,84L,140L,140L,84L,28L,4L,2L,32L,112L,224L,280L,224L,112L,32L,42L,36L,144L,336L,504L,504L,336L,144L,36L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134066Inst : IEnumerable<long>
{
public static readonly long[] Value=A134066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134066.Bytes);
public long this[int i]=>Value[i];

public static A134066Inst Instance=new A134066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134067
{
public static readonly long[] Value={ 1L,6L,14L,30L,62L,126L,254L,510L,1022L,2046L,4094L,8190L,16382L,32766L,65534L,131070L,262142L,524286L,1048574L,2097150L,4194302L,8388606L,16777214L,33554430L,67108862L,134217726L,268435454L,536870910L,1073741822L,2147483646L,4294967294L,8589934590L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134067Inst : IEnumerable<long>
{
public static readonly long[] Value=A134067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134067.Bytes);
public long this[int i]=>Value[i];

public static A134067Inst Instance=new A134067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134068
{
public static readonly long[] Value={ 0L,3L,3L,6L,18L,24L,60L,120L,216L,480L,912L,1824L,1248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134068Inst : IEnumerable<long>
{
public static readonly long[] Value=A134068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134068.Bytes);
public long this[int i]=>Value[i];

public static A134068Inst Instance=new A134068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134069
{
public static readonly long[] Value={ 11L,211L,853211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134069Inst : IEnumerable<long>
{
public static readonly long[] Value=A134069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134069.Bytes);
public long this[int i]=>Value[i];

public static A134069Inst Instance=new A134069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134070
{
public static readonly BigInteger[] Value={ 13L,13471118294776123L,BigInteger.Parse("134711182947761231993225218431364220735715778934915127244763960364079103682167761271443439204710647114985118604983010349") };
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
public class A134070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134070Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134070.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134070.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134070Inst Instance=new A134070Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134071
{
public static readonly BigInteger[] Value={ 31L,431L,117431L,BigInteger.Parse("19912376472918117431") };
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
public class A134071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134071.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134071Inst Instance=new A134071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134072
{
public static readonly BigInteger[] Value={ 1L,31L,431L,7431L,117431L,18117431L,2918117431L,472918117431L,76472918117431L,12376472918117431L,BigInteger.Parse("19912376472918117431"),BigInteger.Parse("32219912376472918117431"),BigInteger.Parse("52132219912376472918117431"),BigInteger.Parse("84352132219912376472918117431") };
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
public class A134072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134072.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134072Inst Instance=new A134072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134073
{
public static readonly long[] Value={ 3L,9L,10L,17L,611L,6717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134073Inst : IEnumerable<long>
{
public static readonly long[] Value=A134073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134073.Bytes);
public long this[int i]=>Value[i];

public static A134073Inst Instance=new A134073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134074
{
public static readonly long[] Value={ -4L,2L,3L,6L,72L,356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134074Inst : IEnumerable<long>
{
public static readonly long[] Value=A134074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134074.Bytes);
public long this[int i]=>Value[i];

public static A134074Inst Instance=new A134074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134075
{
public static readonly long[] Value={ 907L,3019L,5281L,11689L,16741L,33329L,241051L,248063L,382649L,556819L,852757L,1104737L,1372627L,3122771L,3590089L,5482207L,5870659L,6505361L,7059161L,7753579L,8751097L,17452957L,18080497L,18261829L,26184449L,28633609L,30561919L,37544699L,37762223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134075Inst : IEnumerable<long>
{
public static readonly long[] Value=A134075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134075.Bytes);
public long this[int i]=>Value[i];

public static A134075Inst Instance=new A134075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134076
{
public static readonly long[] Value={ 17L,31L,41L,61L,73L,103L,277L,281L,349L,421L,521L,593L,661L,997L,1069L,1321L,1367L,1439L,1499L,1571L,1669L,2357L,2399L,2411L,2887L,3019L,3119L,3457L,3467L,3917L,4049L,4091L,4211L,4241L,4297L,4337L,4441L,4691L,4721L,5077L,5231L,5261L,5393L,5591L,5813L,6101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134076Inst : IEnumerable<long>
{
public static readonly long[] Value=A134076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134076.Bytes);
public long this[int i]=>Value[i];

public static A134076Inst Instance=new A134076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134077
{
public static readonly long[] Value={ 1L,-5L,6L,8L,-23L,12L,14L,-30L,18L,20L,-40L,24L,31L,-77L,30L,32L,-60L,48L,38L,-70L,42L,44L,-138L,48L,57L,-90L,54L,72L,-100L,60L,62L,-184L,84L,68L,-120L,72L,74L,-155L,96L,80L,-239L,84L,108L,-150L,90L,112L,-160L,120L,98L,-276L,102L,104L,-240L,108L,110L,-190L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134077Inst : IEnumerable<long>
{
public static readonly long[] Value=A134077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134077.Bytes);
public long this[int i]=>Value[i];

public static A134077Inst Instance=new A134077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134078
{
public static readonly long[] Value={ 1L,-6L,18L,-34L,42L,-36L,30L,-48L,90L,-118L,108L,-72L,54L,-84L,144L,-204L,186L,-108L,66L,-120L,252L,-272L,216L,-144L,102L,-186L,252L,-370L,336L,-180L,180L,-192L,378L,-408L,324L,-288L,90L,-228L,360L,-476L,540L,-252L,240L,-264L,504L,-708L,432L,-288L,198L,-342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134078Inst : IEnumerable<long>
{
public static readonly long[] Value=A134078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134078.Bytes);
public long this[int i]=>Value[i];

public static A134078Inst Instance=new A134078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134079
{
public static readonly long[] Value={ 1L,-2L,5L,-4L,8L,-6L,14L,-8L,14L,-10L,21L,-16L,20L,-14L,28L,-16L,31L,-18L,40L,-20L,32L,-28L,42L,-24L,38L,-32L,62L,-28L,44L,-30L,56L,-40L,57L,-34L,70L,-36L,72L,-38L,70L,-48L,62L,-52L,85L,-44L,68L,-46L,112L,-56L,74L,-50L,100L,-64L,80L,-64L,98L,-56L,108L,-58L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134079Inst : IEnumerable<long>
{
public static readonly long[] Value=A134079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134079.Bytes);
public long this[int i]=>Value[i];

public static A134079Inst Instance=new A134079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134080
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,12L,12L,10L,16L,20L,12L,22L,25L,20L,30L,32L,24L,30L,36L,24L,42L,42L,35L,46L,43L,32L,52L,60L,40L,60L,62L,42L,60L,66L,44L,72L,72L,50L,72L,80L,61L,82L,80L,60L,90L,72L,64L,100L,96L,84L,102L,102L,60L,106L,110L,72L,112L,110L,84L,96L,133L,84L,125L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134080Inst : IEnumerable<long>
{
public static readonly long[] Value=A134080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134080.Bytes);
public long this[int i]=>Value[i];

public static A134080Inst Instance=new A134080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134081
{
public static readonly long[] Value={ 1L,2L,1L,3L,5L,1L,4L,12L,8L,1L,5L,22L,26L,11L,1L,6L,35L,60L,45L,14L,1L,7L,51L,115L,125L,69L,17L,1L,8L,70L,196L,280L,224L,98L,20L,1L,9L,92L,308L,546L,574L,364L,132L,23L,1L,10L,117L,456L,966L,1260L,1050L,552L,171L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134081Inst : IEnumerable<long>
{
public static readonly long[] Value=A134081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134081.Bytes);
public long this[int i]=>Value[i];

public static A134081Inst Instance=new A134081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134082
{
public static readonly long[] Value={ 1L,2L,1L,0L,4L,1L,0L,0L,6L,1L,0L,0L,0L,8L,1L,0L,0L,0L,0L,10L,1L,0L,0L,0L,0L,0L,12L,1L,0L,0L,0L,0L,0L,0L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134082Inst : IEnumerable<long>
{
public static readonly long[] Value=A134082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134082.Bytes);
public long this[int i]=>Value[i];

public static A134082Inst Instance=new A134082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134083
{
public static readonly long[] Value={ 1L,3L,1L,5L,6L,1L,7L,15L,9L,1L,9L,28L,30L,12L,1L,11L,45L,70L,50L,15L,1L,13L,66L,135L,140L,75L,18L,1L,15L,91L,231L,315L,245L,105L,21L,1L,17L,120L,364L,616L,630L,392L,140L,24L,1L,19L,153L,540L,1092L,1386L,1134L,588L,180L,27L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A134083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134083Inst : IEnumerable<long>
{
public static readonly long[] Value=A134083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A134083.Bytes);
public long this[int i]=>Value[i];

public static A134083Inst Instance=new A134083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134084
{
public static readonly BigInteger[] Value={ 1L,2L,2L,-4L,-106L,-6948L,-1623788L,-1213437064L,-2912047916698L,-23264250235542100L,BigInteger.Parse("-641982248042094828676"),BigInteger.Parse("-62929856484660987275500088"),BigInteger.Parse("-22331407793040258023249030997892"),BigInteger.Parse("-29057717949243934527799656871001480808") };
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
public class A134084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134084Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134084.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134084.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134084Inst Instance=new A134084Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134085
{
public static readonly BigInteger[] Value={ 1L,2L,2L,0L,-14L,-448L,-51184L,-19010908L,-22769359414L,-90898737308664L,-1253962465550022928L,BigInteger.Parse("-61456191890306429529460"),BigInteger.Parse("-10904069167010301985293186456"),BigInteger.Parse("-7094180325240570739957963715038868"),BigInteger.Parse("-17078681470682524119645862432516881125820") };
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
public class A134085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134085Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134085.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134085.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134085Inst Instance=new A134085Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134086
{
public static readonly BigInteger[] Value={ 1L,2L,8L,80L,2464L,255808L,90320512L,108630646016L,451779274750464L,6626041977171637248L,BigInteger.Parse("348460175972420307970048"),BigInteger.Parse("66523219303893985885632450560"),BigInteger.Parse("46531358180797100870477866170818560") };
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
public class A134086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134086Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134086.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134086.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134086Inst Instance=new A134086Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134087
{
public static readonly BigInteger[] Value={ 1L,4L,32L,672L,42816L,8822400L,6065609984L,14256471226880L,117000916309144576L,BigInteger.Parse("3410202131850138806272"),BigInteger.Parse("357670541003601468527333376"),BigInteger.Parse("136391046228660672398602237353984") };
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
public class A134087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134087Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134087.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134087.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134087Inst Instance=new A134087Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A134088
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,154L,7994L,1411258L,848676922L,1764762791994L,12941488236663354L,BigInteger.Parse("340293140598066707002"),BigInteger.Parse("32482040675729485295718970"),BigInteger.Parse("11360194868358667204706510295610") };
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
public class A134088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A134088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A134088Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A134088.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A134088.Bytes);
public BigInteger this[int i]=>Value[i];

public static A134088Inst Instance=new A134088Inst();

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