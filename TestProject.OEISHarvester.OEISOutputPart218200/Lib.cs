using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256582
{
public static readonly long[] Value={ 1L,11L,46L,146L,416L,1136L,2776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256582Inst : IEnumerable<long>
{
public static readonly long[] Value=A256582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256582.Bytes);
public long this[int i]=>Value[i];

public static A256582Inst Instance=new A256582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256583
{
public static readonly long[] Value={ 1L,11L,66L,336L,1666L,8186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256583Inst : IEnumerable<long>
{
public static readonly long[] Value=A256583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256583.Bytes);
public long this[int i]=>Value[i];

public static A256583Inst Instance=new A256583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256584
{
public static readonly long[] Value={ 6L,12L,54L,96L,108L,126L,144L,180L,192L,216L,234L,240L,264L,270L,336L,360L,378L,408L,480L,486L,504L,522L,540L,594L,600L,744L,750L,756L,864L,900L,972L,990L,1008L,1026L,1116L,1134L,1224L,1296L,1350L,1386L,1404L,1494L,1500L,1536L,1584L,1620L,1656L,1728L,1800L,1872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256584Inst : IEnumerable<long>
{
public static readonly long[] Value=A256584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256584.Bytes);
public long this[int i]=>Value[i];

public static A256584Inst Instance=new A256584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256585
{
public static readonly long[] Value={ 37L,79L,127L,181L,241L,307L,379L,457L,541L,631L,727L,829L,937L,1051L,1171L,1297L,1429L,1567L,1861L,2017L,2179L,2347L,2521L,2887L,3079L,3691L,3907L,4129L,4357L,4591L,4831L,5077L,5851L,6121L,6397L,6679L,6967L,7561L,7867L,8179L,8821L,9151L,9829L,10177L,10531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256585Inst : IEnumerable<long>
{
public static readonly long[] Value=A256585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256585.Bytes);
public long this[int i]=>Value[i];

public static A256585Inst Instance=new A256585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256586
{
public static readonly long[] Value={ 1L,330L,51651L,4947912L,317141342L,14054473232L,428862722294L,8621633953202L,101600180118726L,528107928328516L,613251601892918L,31893880879492L,39248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256586Inst : IEnumerable<long>
{
public static readonly long[] Value=A256586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256586.Bytes);
public long this[int i]=>Value[i];

public static A256586Inst Instance=new A256586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256587
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,3L,2L,4L,2L,4L,2L,5L,3L,4L,3L,3L,5L,3L,4L,2L,6L,2L,4L,1L,6L,2L,4L,1L,4L,2L,3L,3L,2L,3L,1L,3L,2L,4L,1L,3L,1L,3L,2L,4L,1L,3L,1L,3L,1L,4L,2L,4L,1L,3L,2L,3L,3L,3L,3L,2L,3L,2L,5L,4L,3L,3L,4L,3L,5L,5L,4L,3L,5L,3L,6L,6L,5L,4L,7L,3L,6L,4L,7L,4L,8L,3L,7L,5L,6L,7L,6L,5L,6L,6L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256587Inst : IEnumerable<long>
{
public static readonly long[] Value=A256587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256587.Bytes);
public long this[int i]=>Value[i];

public static A256587Inst Instance=new A256587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256588
{
public static readonly long[] Value={ 3L,7L,13L,21L,29L,40L,52L,65L,80L,97L,115L,135L,157L,180L,204L,230L,258L,287L,318L,350L,384L,420L,457L,496L,536L,578L,621L,666L,713L,761L,810L,862L,915L,969L,1025L,1082L,1142L,1202L,1264L,1328L,1394L,1461L,1529L,1599L,1671L,1744L,1819L,1895L,1973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256588Inst : IEnumerable<long>
{
public static readonly long[] Value=A256588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256588.Bytes);
public long this[int i]=>Value[i];

public static A256588Inst Instance=new A256588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256589
{
public static readonly long[] Value={ 1L,3L,1L,11L,2L,1L,50L,8L,2L,1L,274L,36L,6L,2L,1L,1764L,200L,30L,6L,2L,1L,13068L,1300L,168L,24L,6L,2L,1L,109584L,9720L,1080L,144L,24L,6L,2L,1L,1026576L,82180L,8100L,960L,120L,24L,6L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256589Inst : IEnumerable<long>
{
public static readonly long[] Value=A256589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256589.Bytes);
public long this[int i]=>Value[i];

public static A256589Inst Instance=new A256589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256590
{
public static readonly BigInteger[] Value={ 0L,1L,81L,625L,7776L,16807L,46656L,59049L,1679616L,1475789056L,6975757441L,137858491849L,576650390625L,41426511213649L,2384185791015625L,150094635296999121L,10260628712958602189UL,BigInteger.Parse("32768000000000000000"),BigInteger.Parse("243569224216081305397"),BigInteger.Parse("655360000000000000000") };
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
public class A256590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256590Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256590.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256590Inst Instance=new A256590Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256591
{
public static readonly long[] Value={ 0L,2L,2L,9L,7L,1L,9L,4L,4L,3L,1L,5L,1L,4L,5L,4L,3L,7L,5L,3L,5L,2L,4L,9L,8L,7L,6L,4L,9L,7L,6L,3L,2L,1L,7L,0L,2L,6L,4L,5L,9L,3L,0L,1L,3L,8L,3L,7L,5L,8L,9L,0L,6L,3L,4L,9L,9L,1L,4L,4L,6L,2L,2L,1L,6L,5L,1L,8L,3L,6L,3L,1L,8L,5L,8L,8L,9L,2L,5L,5L,3L,8L,0L,9L,6L,7L,0L,2L,2L,7L,6L,7L,1L,2L,1L,4L,1L,7L,8L,0L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256591Inst : IEnumerable<long>
{
public static readonly long[] Value=A256591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256591.Bytes);
public long this[int i]=>Value[i];

public static A256591Inst Instance=new A256591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256592
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,3L,8L,7L,13L,15L,13L,11L,13L,22L,18L,25L,36L,31L,34L,53L,42L,38L,38L,40L,55L,47L,41L,37L,77L,59L,62L,67L,66L,63L,55L,84L,74L,78L,90L,74L,90L,92L,85L,108L,100L,117L,98L,104L,136L,114L,118L,118L,141L,112L,118L,115L,122L,138L,132L,129L,115L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256592Inst : IEnumerable<long>
{
public static readonly long[] Value=A256592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256592.Bytes);
public long this[int i]=>Value[i];

public static A256592Inst Instance=new A256592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256593
{
public static readonly long[] Value={ 5L,9L,5L,2L,7L,7L,7L,7L,8L,5L,4L,1L,1L,2L,6L,0L,0L,5L,3L,3L,3L,8L,0L,2L,0L,3L,3L,0L,9L,7L,6L,4L,2L,3L,4L,6L,5L,2L,6L,1L,1L,3L,0L,2L,3L,5L,5L,5L,2L,9L,9L,7L,9L,9L,2L,2L,5L,6L,3L,6L,9L,1L,8L,4L,9L,4L,2L,6L,6L,3L,3L,8L,9L,0L,2L,8L,3L,2L,8L,6L,5L,6L,0L,6L,3L,0L,0L,2L,9L,9L,7L,6L,7L,9L,3L,4L,9L,5L,4L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256593Inst : IEnumerable<long>
{
public static readonly long[] Value=A256593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256593.Bytes);
public long this[int i]=>Value[i];

public static A256593Inst Instance=new A256593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256594
{
public static readonly long[] Value={ 0L,1L,259L,16708L,18655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256594Inst : IEnumerable<long>
{
public static readonly long[] Value=A256594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256594.Bytes);
public long this[int i]=>Value[i];

public static A256594Inst Instance=new A256594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256595
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,3L,1L,0L,6L,4L,1L,0L,10L,10L,5L,1L,0L,15L,20L,15L,6L,1L,0L,21L,35L,35L,21L,7L,1L,0L,28L,56L,70L,56L,28L,8L,1L,0L,36L,84L,126L,126L,84L,36L,9L,1L,0L,45L,120L,210L,252L,210L,120L,45L,10L,1L,0L,55L,165L,330L,462L,462L,330L,165L,55L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256595Inst : IEnumerable<long>
{
public static readonly long[] Value=A256595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256595.Bytes);
public long this[int i]=>Value[i];

public static A256595Inst Instance=new A256595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256596
{
public static readonly long[] Value={ 0L,6L,5L,4L,2L,1L,3L,2L,3L,1L,1L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,4L,1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,3L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,2L,2L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256596Inst : IEnumerable<long>
{
public static readonly long[] Value=A256596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256596.Bytes);
public long this[int i]=>Value[i];

public static A256596Inst Instance=new A256596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256597
{
public static readonly long[] Value={ 1L,11L,76L,436L,2441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256597Inst : IEnumerable<long>
{
public static readonly long[] Value=A256597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256597.Bytes);
public long this[int i]=>Value[i];

public static A256597Inst Instance=new A256597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256598
{
public static readonly long[] Value={ 1L,3L,5L,1L,5L,1L,7L,11L,17L,13L,5L,1L,9L,7L,11L,17L,13L,5L,1L,11L,17L,13L,5L,1L,13L,5L,1L,15L,23L,35L,53L,5L,1L,17L,13L,5L,1L,19L,29L,11L,17L,13L,5L,1L,21L,1L,23L,35L,53L,5L,1L,25L,19L,29L,11L,17L,13L,5L,1L,27L,41L,31L,47L,71L,107L,161L,121L,91L,137L,103L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256598Inst : IEnumerable<long>
{
public static readonly long[] Value=A256598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256598.Bytes);
public long this[int i]=>Value[i];

public static A256598Inst Instance=new A256598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256599
{
public static readonly BigInteger[] Value={ 1L,1L,2L,6L,28L,220L,3120L,83664L,4357344L,447134112L,91076016768L,36961806703872L,29943818376782336L,BigInteger.Parse("48470579116735833088"),BigInteger.Parse("156845720249107280302080"),BigInteger.Parse("1014831255949728967492085760"),BigInteger.Parse("13130865085565056931098800492544"),BigInteger.Parse("339779374103012848597500716186767360") };
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
public class A256599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256599Inst Instance=new A256599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256600
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,3L,4L,6L,1L,3L,4L,6L,1L,4L,8L,14L,15L,18L,22L,28L,1L,4L,8L,14L,15L,18L,22L,28L,1L,5L,13L,27L,42L,60L,82L,110L,111L,115L,123L,137L,152L,170L,192L,220L,1L,5L,13L,27L,42L,60L,82L,110L,111L,115L,123L,137L,152L,170L,192L,220L,1L,6L,19L,46L,88L,148L,230L,340L,451L,566L,689L,826L,978L,1148L,1340L,1560L,1561L,1566L,1579L,1606L,1648L,1708L,1790L,1900L,2011L,2126L,2249L,2386L,2538L,2708L,2900L,3120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256600Inst : IEnumerable<long>
{
public static readonly long[] Value=A256600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256600.Bytes);
public long this[int i]=>Value[i];

public static A256600Inst Instance=new A256600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256601
{
public static readonly long[] Value={ 139L,219L,519L,591L,719L,891L,911L,961L,971L,981L,1139L,1193L,1219L,1292L,1293L,1296L,1319L,1339L,1389L,1391L,1392L,1394L,1396L,1469L,1579L,1589L,1691L,1719L,1729L,1769L,1793L,1839L,1869L,1896L,1911L,1927L,1937L,1939L,1944L,1946L,1969L,1978L,1979L,1981L,1986L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256601Inst : IEnumerable<long>
{
public static readonly long[] Value=A256601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256601.Bytes);
public long this[int i]=>Value[i];

public static A256601Inst Instance=new A256601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256602
{
public static readonly long[] Value={ 37L,97L,157L,277L,337L,373L,397L,409L,457L,541L,577L,613L,673L,709L,733L,757L,769L,853L,877L,937L,997L,1009L,1069L,1117L,1129L,1201L,1213L,1237L,1249L,1297L,1381L,1549L,1597L,1657L,1693L,1741L,1753L,1777L,1801L,1861L,1993L,2017L,2053L,2137L,2161L,2221L,2281L,2293L,2377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256602Inst : IEnumerable<long>
{
public static readonly long[] Value=A256602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256602.Bytes);
public long this[int i]=>Value[i];

public static A256602Inst Instance=new A256602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256603
{
public static readonly long[] Value={ 305L,525L,1206L,1257L,1395L,2048L,2213L,3072L,4348L,6400L,16385L,16640L,16704L,20631L,22872L,23256L,30968L,31407L,32769L,62943L,74515L,77713L,77824L,79776L,82565L,84775L,90432L,98739L,117600L,121250L,133696L,163525L,165628L,171576L,198400L,199872L,243225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256603Inst : IEnumerable<long>
{
public static readonly long[] Value=A256603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256603.Bytes);
public long this[int i]=>Value[i];

public static A256603Inst Instance=new A256603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256604
{
public static readonly long[] Value={ 5L,9L,12L,17L,19L,21L,23L,25L,28L,33L,35L,37L,38L,39L,42L,45L,46L,47L,51L,53L,55L,57L,59L,60L,61L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,77L,80L,81L,82L,84L,87L,88L,89L,91L,93L,95L,97L,98L,99L,100L,103L,105L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,121L,123L,124L,127L,128L,129L,131L,132L,133L,134L,135L,136L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256604Inst : IEnumerable<long>
{
public static readonly long[] Value=A256604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256604.Bytes);
public long this[int i]=>Value[i];

public static A256604Inst Instance=new A256604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256605
{
public static readonly long[] Value={ 3L,4L,20L,12L,84L,120L,360L,360L,3960L,2520L,32760L,27720L,27720L,55440L,942480L,720720L,13693680L,12252240L,12252240L,12252240L,281801520L,232792560L,1163962800L,1163962800L,3491888400L,3491888400L,101264763600L,80313433200L,2489716429200L,4658179125600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256605Inst : IEnumerable<long>
{
public static readonly long[] Value=A256605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256605.Bytes);
public long this[int i]=>Value[i];

public static A256605Inst Instance=new A256605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256606
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,8L,33L,38L,157L,252L,359L,365L,567L,876L,3108L,5780L,12987L,14984L,22287L,31574L,37473L,40984L,49806L,51364L,62451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256606Inst : IEnumerable<long>
{
public static readonly long[] Value=A256606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256606.Bytes);
public long this[int i]=>Value[i];

public static A256606Inst Instance=new A256606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256607
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,2L,2L,1L,1L,1L,2L,6L,1L,2L,4L,10L,1L,4L,2L,6L,2L,3L,1L,4L,1L,4L,1L,2L,2L,6L,6L,2L,1L,4L,2L,3L,4L,2L,10L,11L,1L,6L,4L,1L,2L,12L,6L,4L,2L,6L,3L,28L,1L,4L,4L,2L,1L,2L,4L,10L,1L,10L,2L,12L,2L,6L,6L,4L,6L,4L,2L,12L,1L,18L,4L,20L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256607Inst : IEnumerable<long>
{
public static readonly long[] Value=A256607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256607.Bytes);
public long this[int i]=>Value[i];

public static A256607Inst Instance=new A256607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256608
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,1L,2L,2L,1L,1L,1L,2L,6L,1L,2L,4L,10L,1L,4L,2L,6L,2L,3L,1L,4L,1L,4L,1L,2L,2L,6L,6L,2L,1L,4L,2L,6L,4L,2L,10L,11L,1L,6L,4L,1L,2L,12L,6L,4L,2L,6L,3L,28L,1L,4L,4L,2L,1L,2L,4L,10L,1L,10L,2L,12L,2L,6L,6L,4L,6L,4L,2L,12L,1L,18L,4L,20L,2L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256608Inst : IEnumerable<long>
{
public static readonly long[] Value=A256608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256608.Bytes);
public long this[int i]=>Value[i];

public static A256608Inst Instance=new A256608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256609
{
public static readonly long[] Value={ 1L,8L,7L,9L,1L,6L,9L,2L,7L,1L,5L,9L,5L,8L,3L,5L,8L,3L,6L,4L,5L,5L,9L,5L,6L,4L,0L,9L,3L,4L,5L,0L,7L,1L,0L,5L,4L,3L,9L,9L,5L,4L,2L,6L,2L,1L,7L,2L,0L,3L,3L,4L,4L,5L,1L,4L,4L,1L,8L,2L,5L,3L,4L,4L,3L,5L,1L,8L,0L,0L,1L,1L,5L,9L,6L,0L,4L,9L,7L,1L,4L,5L,9L,3L,5L,2L,6L,0L,4L,6L,0L,7L,9L,3L,4L,6L,4L,9L,7L,0L,9L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256609Inst : IEnumerable<long>
{
public static readonly long[] Value=A256609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256609.Bytes);
public long this[int i]=>Value[i];

public static A256609Inst Instance=new A256609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256610
{
public static readonly long[] Value={ 2L,1L,4L,2L,7L,3L,1L,8L,0L,0L,3L,7L,6L,6L,9L,3L,1L,0L,4L,8L,8L,0L,4L,0L,7L,8L,8L,4L,8L,9L,6L,4L,5L,2L,6L,3L,8L,3L,8L,6L,5L,0L,9L,2L,9L,4L,1L,2L,1L,5L,1L,8L,0L,3L,2L,5L,2L,6L,2L,9L,3L,8L,2L,7L,5L,0L,5L,3L,3L,3L,7L,3L,2L,5L,4L,6L,2L,6L,3L,6L,9L,0L,8L,7L,3L,8L,1L,0L,7L,2L,7L,6L,4L,8L,0L,8L,7L,7L,7L,9L,0L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256610Inst : IEnumerable<long>
{
public static readonly long[] Value=A256610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256610.Bytes);
public long this[int i]=>Value[i];

public static A256610Inst Instance=new A256610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256611
{
public static readonly long[] Value={ 2L,3L,5L,1L,9L,3L,4L,6L,1L,0L,7L,9L,8L,7L,9L,2L,7L,6L,0L,4L,6L,3L,6L,8L,0L,9L,5L,7L,6L,4L,9L,3L,8L,6L,9L,6L,3L,3L,6L,5L,6L,9L,3L,0L,1L,8L,6L,0L,2L,5L,8L,1L,2L,2L,1L,0L,7L,0L,2L,3L,1L,4L,0L,7L,9L,7L,8L,3L,8L,3L,5L,0L,0L,7L,7L,9L,1L,9L,6L,1L,7L,6L,7L,4L,7L,7L,7L,4L,8L,3L,0L,7L,4L,5L,2L,1L,0L,8L,8L,3L,6L,2L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256611Inst : IEnumerable<long>
{
public static readonly long[] Value=A256611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256611.Bytes);
public long this[int i]=>Value[i];

public static A256611Inst Instance=new A256611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256612
{
public static readonly long[] Value={ 2L,2L,5L,2L,7L,1L,2L,6L,5L,1L,7L,3L,4L,2L,0L,5L,9L,5L,9L,8L,6L,9L,7L,0L,1L,6L,4L,6L,3L,6L,8L,4L,9L,5L,1L,1L,8L,6L,1L,5L,6L,2L,7L,2L,2L,2L,2L,9L,4L,9L,5L,3L,7L,6L,5L,0L,4L,1L,7L,3L,9L,8L,3L,0L,0L,7L,8L,8L,7L,0L,2L,9L,8L,2L,8L,9L,4L,6L,1L,8L,7L,0L,2L,9L,8L,4L,0L,5L,4L,3L,2L,2L,7L,6L,3L,7L,7L,5L,1L,8L,9L,6L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256612Inst : IEnumerable<long>
{
public static readonly long[] Value=A256612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256612.Bytes);
public long this[int i]=>Value[i];

public static A256612Inst Instance=new A256612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256613
{
public static readonly long[] Value={ 7L,9L,17L,55L,72L,96L,459L,616L,1536L,4125L,9504L,11875L,19551L,36864L,64881L,67392L,77824L,108000L,171699L,262656L,388869L,559776L,786375L,1052672L,1081344L,1160000L,1413872L,1459161L,1850202L,1936224L,2530971L,3264000L,4158189L,5187500L,5238816L,6533679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256613Inst : IEnumerable<long>
{
public static readonly long[] Value=A256613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256613.Bytes);
public long this[int i]=>Value[i];

public static A256613Inst Instance=new A256613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256614
{
public static readonly long[] Value={ 2L,7L,3L,9L,6L,3L,1L,6L,2L,1L,9L,4L,6L,2L,0L,3L,4L,1L,8L,5L,8L,5L,7L,2L,9L,6L,5L,0L,0L,8L,2L,2L,3L,2L,0L,8L,9L,1L,4L,4L,9L,4L,4L,4L,0L,7L,2L,7L,3L,5L,3L,7L,3L,7L,8L,8L,7L,8L,6L,8L,2L,1L,0L,2L,5L,5L,7L,8L,0L,0L,8L,8L,6L,2L,6L,7L,9L,0L,8L,7L,9L,6L,5L,6L,2L,1L,5L,5L,5L,3L,0L,2L,6L,7L,1L,8L,4L,7L,4L,9L,5L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256614Inst : IEnumerable<long>
{
public static readonly long[] Value=A256614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256614.Bytes);
public long this[int i]=>Value[i];

public static A256614Inst Instance=new A256614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256615
{
public static readonly long[] Value={ 3L,1L,5L,5L,4L,0L,2L,8L,7L,7L,3L,8L,1L,1L,4L,4L,7L,2L,2L,7L,7L,4L,6L,6L,4L,4L,5L,5L,7L,3L,9L,8L,0L,5L,6L,9L,0L,4L,5L,8L,3L,5L,1L,5L,8L,8L,8L,4L,4L,0L,2L,4L,8L,1L,9L,5L,7L,7L,7L,7L,1L,4L,5L,4L,3L,5L,3L,2L,0L,3L,7L,0L,6L,5L,2L,8L,9L,7L,5L,4L,9L,2L,4L,4L,8L,2L,5L,4L,9L,2L,4L,1L,1L,3L,8L,1L,7L,2L,7L,1L,7L,5L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256615Inst : IEnumerable<long>
{
public static readonly long[] Value=A256615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256615.Bytes);
public long this[int i]=>Value[i];

public static A256615Inst Instance=new A256615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256616
{
public static readonly long[] Value={ 3L,8L,5L,9L,5L,2L,9L,0L,8L,5L,1L,6L,8L,5L,2L,8L,6L,7L,8L,7L,7L,2L,6L,6L,9L,4L,9L,3L,1L,7L,3L,1L,2L,5L,0L,3L,8L,0L,5L,8L,7L,0L,1L,5L,2L,7L,3L,1L,6L,4L,9L,9L,4L,3L,8L,9L,1L,6L,3L,4L,3L,8L,3L,2L,4L,5L,8L,3L,9L,5L,9L,1L,9L,2L,5L,4L,4L,9L,4L,9L,0L,5L,9L,2L,0L,5L,4L,4L,3L,2L,4L,6L,8L,3L,6L,4L,5L,9L,7L,6L,6L,4L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256616Inst : IEnumerable<long>
{
public static readonly long[] Value=A256616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256616.Bytes);
public long this[int i]=>Value[i];

public static A256616Inst Instance=new A256616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256617
{
public static readonly long[] Value={ 6L,12L,15L,18L,24L,35L,36L,45L,48L,54L,72L,75L,77L,96L,108L,135L,143L,144L,162L,175L,192L,216L,221L,225L,245L,288L,323L,324L,375L,384L,405L,432L,437L,486L,539L,576L,648L,667L,675L,768L,847L,864L,875L,899L,972L,1125L,1147L,1152L,1215L,1225L,1296L,1458L,1517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256617Inst : IEnumerable<long>
{
public static readonly long[] Value=A256617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256617.Bytes);
public long this[int i]=>Value[i];

public static A256617Inst Instance=new A256617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256618
{
public static readonly long[] Value={ 1L,2L,3L,4L,10L,5L,13L,6L,7L,8L,21L,9L,26L,11L,12L,16L,34L,14L,35L,18L,15L,19L,47L,17L,20L,24L,25L,29L,54L,22L,61L,31L,23L,32L,40L,27L,68L,33L,28L,41L,77L,30L,82L,43L,38L,45L,91L,39L,42L,46L,36L,48L,100L,50L,53L,44L,37L,52L,109L,51L,118L,59L,58L,62L,55L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256618Inst : IEnumerable<long>
{
public static readonly long[] Value=A256618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256618.Bytes);
public long this[int i]=>Value[i];

public static A256618Inst Instance=new A256618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256619
{
public static readonly long[] Value={ 1L,26L,29L,38L,47L,97L,114L,127L,216L,276L,433L,1094L,1284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256619Inst : IEnumerable<long>
{
public static readonly long[] Value=A256619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256619.Bytes);
public long this[int i]=>Value[i];

public static A256619Inst Instance=new A256619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256620
{
public static readonly long[] Value={ 12L,30L,42L,312L,600L,858L,1032L,1290L,1698L,2112L,2688L,3768L,4218L,4230L,4260L,5850L,6132L,6552L,6702L,7212L,7308L,8292L,9420L,9930L,11970L,12042L,12378L,15972L,17190L,17598L,17922L,19470L,19890L,21600L,24180L,26862L,30012L,30852L,32118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256620Inst : IEnumerable<long>
{
public static readonly long[] Value=A256620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256620.Bytes);
public long this[int i]=>Value[i];

public static A256620Inst Instance=new A256620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256621
{
public static readonly long[] Value={ 3893257L,9023533L,11005327L,11659009L,18747809L,21855233L,25183007L,34074379L,54298687L,58562951L,60496981L,89891273L,94277683L,96602887L,102276859L,115555927L,117578429L,122191543L,125115709L,132837283L,138169991L,139442753L,168852077L,183879649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256621Inst : IEnumerable<long>
{
public static readonly long[] Value=A256621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256621.Bytes);
public long this[int i]=>Value[i];

public static A256621Inst Instance=new A256621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256622
{
public static readonly long[] Value={ 9632552297L,23971039429L,32460766253L,55325366053L,75883883641L,87824771197L,91754975491L,91989527023L,97696323983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256622Inst : IEnumerable<long>
{
public static readonly long[] Value=A256622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256622.Bytes);
public long this[int i]=>Value[i];

public static A256622Inst Instance=new A256622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256623
{
public static readonly long[] Value={ 4L,5L,29L,102L,796L,4769L,35905L,267789L,2101184L,16809690L,137487157L,1147385627L,9745119882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256623Inst : IEnumerable<long>
{
public static readonly long[] Value=A256623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256623.Bytes);
public long this[int i]=>Value[i];

public static A256623Inst Instance=new A256623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256624
{
public static readonly long[] Value={ 1L,-2L,-4L,-8L,-10L,-8L,-8L,-16L,-20L,-10L,-8L,-24L,-24L,-8L,-16L,-32L,-26L,-16L,-12L,-24L,-40L,-16L,-8L,-48L,-40L,-10L,-24L,-32L,-32L,-24L,-16L,-48L,-52L,-16L,-16L,-48L,-50L,-8L,-24L,-64L,-40L,-32L,-16L,-24L,-72L,-24L,-16L,-80L,-56L,-18L,-28L,-48L,-40L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256624Inst : IEnumerable<long>
{
public static readonly long[] Value=A256624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256624.Bytes);
public long this[int i]=>Value[i];

public static A256624Inst Instance=new A256624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256625
{
public static readonly BigInteger[] Value={ 1L,3L,21L,189L,2457L,36855L,773955L,19348875L,599815125L,19793899125L,732374267625L,31492093507875L,1543112581885875L,78698741676179625L,4958020725599316375L,BigInteger.Parse("332187388615154197125"),BigInteger.Parse("22920929814445639601625"),BigInteger.Parse("1673227876454531690918625"),BigInteger.Parse("125492090734089876818896875"),BigInteger.Parse("9913875167993100268692853125") };
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
public class A256625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256625Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256625.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256625Inst Instance=new A256625Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256626
{
public static readonly long[] Value={ 1L,1L,0L,0L,-1L,0L,1L,1L,0L,-2L,-1L,0L,2L,2L,0L,-2L,-3L,0L,3L,3L,0L,-4L,-4L,0L,5L,6L,0L,-6L,-7L,0L,7L,8L,0L,-10L,-10L,0L,13L,13L,0L,-14L,-16L,0L,17L,18L,0L,-22L,-22L,0L,26L,28L,0L,-30L,-33L,0L,36L,38L,0L,-44L,-45L,0L,52L,55L,0L,-60L,-65L,0L,70L,74L,0L,-84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256626Inst : IEnumerable<long>
{
public static readonly long[] Value=A256626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256626.Bytes);
public long this[int i]=>Value[i];

public static A256626Inst Instance=new A256626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256627
{
public static readonly long[] Value={ 1378L,171L,496L,1653L,630L,15L,36L,1081L,105L,820L,703L,6L,325L,2016L,1275L,210L,861L,120L,3L,666L,1953L,300L,231L,1326L,190L,1431L,1596L,465L,10L,595L,1128L,45L,0L,741L,946L,91L,276L,1225L,1830L,351L,1711L,406L,153L,1540L,1035L,66L,21L,528L,435L,1770L,1485L,136L,55L,990L,561L,28L,780L,1L,78L,903L,1176L,253L,378L,1891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256627Inst : IEnumerable<long>
{
public static readonly long[] Value=A256627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256627.Bytes);
public long this[int i]=>Value[i];

public static A256627Inst Instance=new A256627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256628
{
public static readonly long[] Value={ 1L,2L,5L,3L,9L,4L,12L,6L,7L,8L,19L,10L,22L,11L,15L,13L,31L,14L,33L,16L,17L,18L,41L,20L,25L,21L,26L,23L,50L,24L,57L,29L,27L,30L,35L,28L,65L,32L,37L,34L,72L,36L,76L,38L,39L,40L,85L,42L,48L,43L,44L,45L,95L,46L,52L,47L,53L,49L,104L,51L,108L,56L,54L,58L,61L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256628Inst : IEnumerable<long>
{
public static readonly long[] Value=A256628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256628.Bytes);
public long this[int i]=>Value[i];

public static A256628Inst Instance=new A256628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256629
{
public static readonly long[] Value={ 24L,120L,240L,720L,840L,1320L,2520L,3360L,3960L,5280L,6240L,6840L,9360L,10920L,14280L,15600L,16320L,17160L,18480L,22440L,24360L,26520L,31920L,35880L,38760L,42840L,43680L,46200L,50160L,55200L,57960L,59280L,70200L,73920L,93840L,100800L,107640L,118320L,122400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256629Inst : IEnumerable<long>
{
public static readonly long[] Value=A256629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256629.Bytes);
public long this[int i]=>Value[i];

public static A256629Inst Instance=new A256629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256630
{
public static readonly long[] Value={ 142201L,1422010L,11141110L,11411110L,11412021L,14220100L,20323421L,21024111L,101203421L,110141011L,110142201L,111411100L,114111100L,114120210L,120013421L,141433102L,142201000L,203234210L,210241110L,1012034210L,1101410011L,1101410110L,1101422010L,1114111000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256630Inst : IEnumerable<long>
{
public static readonly long[] Value=A256630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256630.Bytes);
public long this[int i]=>Value[i];

public static A256630Inst Instance=new A256630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256631
{
public static readonly long[] Value={ 50L,105L,150L,205L,350L,450L,500L,501L,502L,505L,550L,1005L,1015L,1050L,1055L,1105L,1150L,1205L,1450L,1500L,1501L,1550L,2005L,2050L,2055L,2105L,2305L,2350L,3350L,3500L,4500L,5000L,5001L,5002L,5005L,5010L,5011L,5012L,5015L,5020L,5021L,5032L,5045L,5050L,5055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256631Inst : IEnumerable<long>
{
public static readonly long[] Value=A256631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256631.Bytes);
public long this[int i]=>Value[i];

public static A256631Inst Instance=new A256631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256632
{
public static readonly long[] Value={ 1L,6L,2L,3L,8L,5L,4L,7L,18L,104L,256L,6L,9L,13L,8L,102L,100L,10L,288L,19L,81L,146L,512L,14L,2928200L,68L,64L,12L,1089L,29L,16L,21L,121L,90L,6272L,22L,1600L,37L,18L,27L,441L,20L,722L,43L,1352L,180L,324L,33L,338L,149L,576L,96L,529L,34L,128L,28L,49L,157L,1058L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256632Inst : IEnumerable<long>
{
public static readonly long[] Value=A256632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256632.Bytes);
public long this[int i]=>Value[i];

public static A256632Inst Instance=new A256632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256633
{
public static readonly long[] Value={ 60L,160L,460L,506L,560L,600L,601L,602L,605L,660L,1006L,1016L,1060L,1160L,1460L,1560L,1600L,1601L,1602L,1620L,2006L,2016L,2060L,2160L,2460L,2560L,3606L,4506L,4600L,4605L,4650L,5006L,5016L,5060L,5160L,5506L,5600L,5605L,5660L,6000L,6001L,6002L,6005L,6010L,6020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256633Inst : IEnumerable<long>
{
public static readonly long[] Value=A256633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256633.Bytes);
public long this[int i]=>Value[i];

public static A256633Inst Instance=new A256633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256634
{
public static readonly long[] Value={ 740L,760L,1071L,1740L,2074L,2705L,2710L,2740L,2750L,2760L,3705L,3710L,3760L,4071L,4705L,4740L,4760L,5071L,5705L,5760L,6740L,7074L,7240L,7260L,7400L,7550L,7560L,7600L,7601L,7760L,10076L,10174L,10274L,10275L,10371L,10375L,10376L,10571L,10710L,10724L,10726L,10740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256634Inst : IEnumerable<long>
{
public static readonly long[] Value=A256634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256634.Bytes);
public long this[int i]=>Value[i];

public static A256634Inst Instance=new A256634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256635
{
public static readonly long[] Value={ 1L,19L,2L,3L,13L,5L,4L,7L,10L,12L,28L,18L,192L,67L,42L,273L,52L,138L,324L,336L,196L,300L,372L,438L,2716L,997L,1590L,3468L,2512L,3260L,5817L,5692L,4112L,17472L,10852L,15840L,18496L,27252L,22860L,24300L,31572L,35172L,61488L,165652L,138438L,265252L,285652L,292860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256635Inst : IEnumerable<long>
{
public static readonly long[] Value=A256635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256635.Bytes);
public long this[int i]=>Value[i];

public static A256635Inst Instance=new A256635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256636
{
public static readonly long[] Value={ 1L,0L,1L,-2L,2L,-2L,3L,-4L,5L,-6L,7L,-10L,13L,-14L,17L,-22L,26L,-30L,36L,-44L,52L,-60L,70L,-84L,99L,-112L,131L,-156L,179L,-204L,236L,-274L,315L,-358L,409L,-472L,539L,-608L,692L,-792L,897L,-1010L,1144L,-1298L,1464L,-1644L,1849L,-2088L,2347L,-2622L,2940L,-3304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256636Inst : IEnumerable<long>
{
public static readonly long[] Value=A256636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256636.Bytes);
public long this[int i]=>Value[i];

public static A256636Inst Instance=new A256636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256637
{
public static readonly long[] Value={ 1L,-1L,0L,-2L,1L,0L,0L,2L,0L,2L,0L,0L,0L,-4L,0L,-4L,-1L,0L,0L,6L,0L,8L,0L,0L,1L,-10L,0L,-12L,1L,0L,0L,16L,0L,18L,0L,0L,-2L,-24L,0L,-28L,-1L,0L,0L,36L,0L,40L,0L,0L,2L,-52L,0L,-58L,2L,0L,0L,74L,0L,84L,0L,0L,-2L,-104L,0L,-116L,-3L,0L,0L,144L,0L,160L,0L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256637Inst : IEnumerable<long>
{
public static readonly long[] Value=A256637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256637.Bytes);
public long this[int i]=>Value[i];

public static A256637Inst Instance=new A256637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256638
{
public static readonly long[] Value={ 273L,357L,429L,546L,561L,609L,627L,714L,759L,777L,819L,858L,897L,957L,969L,987L,1001L,1023L,1071L,1092L,1122L,1131L,1218L,1221L,1239L,1254L,1287L,1309L,1407L,1419L,1428L,1463L,1491L,1518L,1547L,1551L,1554L,1638L,1659L,1677L,1683L,1716L,1729L,1749L,1767L,1771L,1794L,1827L,1869L,1881L,1887L,1911L,1914L,1938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256638Inst : IEnumerable<long>
{
public static readonly long[] Value=A256638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256638.Bytes);
public long this[int i]=>Value[i];

public static A256638Inst Instance=new A256638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256639
{
public static readonly long[] Value={ -1L,19L,199L,219L,399L,419L,599L,619L,799L,819L,999L,19019L,21199L,39219L,41399L,59419L,61599L,79619L,81799L,99819L,1901999L,2118019L,3922199L,4138219L,5942399L,6158419L,7962599L,8178619L,9982799L,190198819L,211802999L,392217019L,413823199L,594237219L,615843399L,796257419L,817863599L,998277619L,19019883799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256639Inst : IEnumerable<long>
{
public static readonly long[] Value=A256639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256639.Bytes);
public long this[int i]=>Value[i];

public static A256639Inst Instance=new A256639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256640
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,3L,5L,15L,19L,10L,14L,56L,99L,90L,36L,42L,210L,476L,603L,427L,137L,132L,792L,2190L,3536L,3507L,2032L,543L,429L,3003L,9801L,19185L,24251L,19800L,9702L,2219L,1430L,11440L,43043L,98890L,151295L,157716L,109520L,46472L,9285L,4862L,43758L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256640Inst : IEnumerable<long>
{
public static readonly long[] Value=A256640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256640.Bytes);
public long this[int i]=>Value[i];

public static A256640Inst Instance=new A256640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256641
{
public static readonly long[] Value={ 5L,10L,10L,20L,40L,40L,20L,20L,40L,60L,70L,70L,100L,100L,40L,20L,40L,60L,80L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256641Inst : IEnumerable<long>
{
public static readonly long[] Value=A256641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256641.Bytes);
public long this[int i]=>Value[i];

public static A256641Inst Instance=new A256641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256642
{
public static readonly long[] Value={ 19L,1L,6L,2L,3L,8L,5L,4L,7L,36L,111L,0L,61L,0L,30L,5041L,12L,0L,22L,0L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256642Inst : IEnumerable<long>
{
public static readonly long[] Value=A256642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256642.Bytes);
public long this[int i]=>Value[i];

public static A256642Inst Instance=new A256642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256643
{
public static readonly long[] Value={ 166L,332L,333L,499L,335L,336L,502L,668L,669L,505L,176L,177L,343L,509L,180L,346L,512L,513L,679L,515L,516L,187L,353L,354L,190L,356L,357L,523L,689L,360L,526L,692L,198L,364L,200L,201L,367L,533L,534L,370L,536L,537L,703L,374L,45L,211L,377L,378L,544L,380L,381L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256643Inst : IEnumerable<long>
{
public static readonly long[] Value=A256643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256643.Bytes);
public long this[int i]=>Value[i];

public static A256643Inst Instance=new A256643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256644
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,6L,9L,12L,21L,30L,58L,86L,176L,266L,563L,860L,1861L,2862L,6294L,9726L,21660L,33594L,75584L,117574L,266800L,416026L,950914L,1485802L,3417342L,5348882L,12369287L,19389692L,45052517L,70715342L,165002462L,259289582L,607283492L,955277402L,2244901892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256644Inst : IEnumerable<long>
{
public static readonly long[] Value=A256644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256644.Bytes);
public long this[int i]=>Value[i];

public static A256644Inst Instance=new A256644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256645
{
public static readonly long[] Value={ 0L,1L,26L,98L,240L,475L,826L,1316L,1968L,2805L,3850L,5126L,6656L,8463L,10570L,13000L,15776L,18921L,22458L,26410L,30800L,35651L,40986L,46828L,53200L,60125L,67626L,75726L,84448L,93815L,103850L,114576L,126016L,138193L,151130L,164850L,179376L,194731L,210938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256645Inst : IEnumerable<long>
{
public static readonly long[] Value=A256645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256645.Bytes);
public long this[int i]=>Value[i];

public static A256645Inst Instance=new A256645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256646
{
public static readonly long[] Value={ 0L,1L,27L,102L,250L,495L,861L,1372L,2052L,2925L,4015L,5346L,6942L,8827L,11025L,13560L,16456L,19737L,23427L,27550L,32130L,37191L,42757L,48852L,55500L,62725L,70551L,79002L,88102L,97875L,108345L,119536L,131472L,144177L,157675L,171990L,187146L,203167L,220077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256646Inst : IEnumerable<long>
{
public static readonly long[] Value=A256646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256646.Bytes);
public long this[int i]=>Value[i];

public static A256646Inst Instance=new A256646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256647
{
public static readonly long[] Value={ 0L,1L,28L,106L,260L,515L,896L,1428L,2136L,3045L,4180L,5566L,7228L,9191L,11480L,14120L,17136L,20553L,24396L,28690L,33460L,38731L,44528L,50876L,57800L,65325L,73476L,82278L,91756L,101935L,112840L,124496L,136928L,150161L,164220L,179130L,194916L,211603L,229216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256647Inst : IEnumerable<long>
{
public static readonly long[] Value=A256647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256647.Bytes);
public long this[int i]=>Value[i];

public static A256647Inst Instance=new A256647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256648
{
public static readonly long[] Value={ 0L,1L,29L,110L,270L,535L,931L,1484L,2220L,3165L,4345L,5786L,7514L,9555L,11935L,14680L,17816L,21369L,25365L,29830L,34790L,40271L,46299L,52900L,60100L,67925L,76401L,85554L,95410L,105995L,117335L,129456L,142384L,156145L,170765L,186270L,202686L,220039L,238355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256648Inst : IEnumerable<long>
{
public static readonly long[] Value=A256648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256648.Bytes);
public long this[int i]=>Value[i];

public static A256648Inst Instance=new A256648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256649
{
public static readonly long[] Value={ 0L,1L,30L,114L,280L,555L,966L,1540L,2304L,3285L,4510L,6006L,7800L,9919L,12390L,15240L,18496L,22185L,26334L,30970L,36120L,41811L,48070L,54924L,62400L,70525L,79326L,88830L,99064L,110055L,121830L,134416L,147840L,162129L,177310L,193410L,210456L,228475L,247494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256649Inst : IEnumerable<long>
{
public static readonly long[] Value=A256649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256649.Bytes);
public long this[int i]=>Value[i];

public static A256649Inst Instance=new A256649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256650
{
public static readonly long[] Value={ 0L,1L,31L,118L,290L,575L,1001L,1596L,2388L,3405L,4675L,6226L,8086L,10283L,12845L,15800L,19176L,23001L,27303L,32110L,37450L,43351L,49841L,56948L,64700L,73125L,82251L,92106L,102718L,114115L,126325L,139376L,153296L,168113L,183855L,200550L,218226L,236911L,256633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256650Inst : IEnumerable<long>
{
public static readonly long[] Value=A256650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256650.Bytes);
public long this[int i]=>Value[i];

public static A256650Inst Instance=new A256650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256651
{
public static readonly long[] Value={ 7L,8L,10L,11L,14L,20L,22L,24L,27L,28L,30L,39L,45L,46L,47L,48L,59L,60L,66L,81L,94L,96L,107L,118L,124L,147L,166L,167L,172L,179L,189L,192L,200L,203L,210L,214L,225L,227L,231L,247L,259L,277L,285L,296L,304L,309L,315L,323L,324L,325L,327L,334L,358L,360L,407L,412L,436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256651Inst : IEnumerable<long>
{
public static readonly long[] Value=A256651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256651.Bytes);
public long this[int i]=>Value[i];

public static A256651Inst Instance=new A256651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256652
{
public static readonly long[] Value={ 1257L,32769L,262176L,262208L,1081344L,4198400L,16777217L,16809984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256652Inst : IEnumerable<long>
{
public static readonly long[] Value=A256652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256652.Bytes);
public long this[int i]=>Value[i];

public static A256652Inst Instance=new A256652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256653
{
public static readonly long[] Value={ 19879L,39758L,43277L,60749L,79516L,86554L,121498L,136199L,159032L,173069L,173108L,183929L,242996L,252941L,272398L,318064L,346138L,346216L,362861L,367757L,367858L,453281L,456017L,485992L,505882L,544796L,561727L,579193L,603167L,636128L,637969L,692276L,692432L,725722L,735514L,735709L,735716L,772193L,906562L,912034L,931297L,963649L,971984L,1011764L,1051727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256653Inst : IEnumerable<long>
{
public static readonly long[] Value=A256653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256653.Bytes);
public long this[int i]=>Value[i];

public static A256653Inst Instance=new A256653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256654
{
public static readonly long[] Value={ 1L,2L,3L,5L,5L,8L,8L,8L,13L,13L,13L,13L,13L,21L,21L,21L,21L,21L,21L,21L,21L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,34L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,55L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256654Inst : IEnumerable<long>
{
public static readonly long[] Value=A256654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256654.Bytes);
public long this[int i]=>Value[i];

public static A256654Inst Instance=new A256654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256655
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,-1L,5L,8L,-2L,8L,-1L,8L,13L,-5L,1L,13L,-3L,13L,-2L,13L,-1L,13L,21L,-8L,1L,21L,-8L,2L,21L,-5L,21L,-5L,1L,21L,-3L,21L,-2L,21L,-1L,21L,34L,-13L,1L,34L,-13L,2L,34L,-13L,3L,34L,-13L,5L,-1L,34L,-8L,34L,-8L,1L,34L,-8L,2L,34L,-5L,34L,-5L,1L,34L,-3L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256655Inst : IEnumerable<long>
{
public static readonly long[] Value=A256655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256655.Bytes);
public long this[int i]=>Value[i];

public static A256655Inst Instance=new A256655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256656
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,9L,13L,14L,15L,17L,21L,22L,23L,24L,27L,28L,30L,34L,35L,36L,37L,39L,43L,44L,45L,48L,49L,51L,55L,56L,57L,58L,60L,63L,64L,69L,70L,71L,73L,77L,78L,79L,82L,83L,85L,89L,90L,91L,92L,94L,97L,98L,102L,103L,104L,106L,111L,112L,113L,115L,118L,119L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256656Inst : IEnumerable<long>
{
public static readonly long[] Value=A256656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256656.Bytes);
public long this[int i]=>Value[i];

public static A256656Inst Instance=new A256656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256657
{
public static readonly long[] Value={ 4L,6L,7L,10L,11L,12L,16L,18L,19L,20L,25L,26L,29L,31L,32L,33L,38L,40L,41L,42L,46L,47L,50L,52L,53L,54L,59L,61L,62L,65L,66L,67L,68L,72L,74L,75L,76L,80L,81L,84L,86L,87L,88L,93L,95L,96L,99L,100L,101L,105L,107L,108L,109L,110L,114L,116L,117L,120L,121L,122L,123L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256657Inst : IEnumerable<long>
{
public static readonly long[] Value=A256657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256657.Bytes);
public long this[int i]=>Value[i];

public static A256657Inst Instance=new A256657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256658
{
public static readonly long[] Value={ 1L,9L,2L,14L,15L,3L,17L,23L,24L,5L,22L,28L,37L,39L,8L,27L,36L,45L,60L,63L,13L,30L,44L,58L,73L,97L,102L,21L,35L,49L,71L,94L,118L,157L,165L,34L,43L,57L,79L,115L,152L,191L,254L,267L,55L,48L,70L,92L,128L,186L,246L,309L,411L,432L,89L,51L,78L,113L,149L,207L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256658Inst : IEnumerable<long>
{
public static readonly long[] Value=A256658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256658.Bytes);
public long this[int i]=>Value[i];

public static A256658Inst Instance=new A256658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256659
{
public static readonly long[] Value={ 4L,7L,6L,12L,11L,10L,20L,19L,18L,16L,25L,32L,31L,29L,26L,33L,40L,52L,50L,47L,42L,38L,53L,65L,84L,81L,76L,68L,41L,61L,86L,105L,136L,131L,123L,110L,46L,66L,99L,139L,170L,220L,212L,199L,178L,54L,74L,107L,160L,225L,275L,356L,343L,322L,288L,59L,87L,120L,173L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256659Inst : IEnumerable<long>
{
public static readonly long[] Value=A256659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256659.Bytes);
public long this[int i]=>Value[i];

public static A256659Inst Instance=new A256659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256660
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,2L,2L,1L,3L,3L,2L,3L,2L,2L,2L,1L,3L,3L,3L,4L,2L,3L,3L,2L,3L,2L,2L,2L,1L,3L,3L,3L,4L,3L,4L,4L,2L,3L,3L,3L,4L,2L,3L,3L,2L,3L,2L,2L,2L,1L,3L,3L,3L,4L,3L,4L,4L,3L,5L,4L,4L,4L,2L,3L,3L,3L,4L,3L,4L,4L,2L,3L,3L,3L,4L,2L,3L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256660Inst : IEnumerable<long>
{
public static readonly long[] Value=A256660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256660.Bytes);
public long this[int i]=>Value[i];

public static A256660Inst Instance=new A256660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256661
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,5L,7L,14L,25L,8L,10L,15L,38L,64L,13L,11L,17L,40L,98L,169L,21L,12L,22L,41L,103L,258L,441L,34L,16L,23L,46L,104L,271L,674L,1156L,55L,18L,24L,59L,106L,273L,708L,1766L,3025L,89L,19L,27L,61L,119L,274L,713L,1855L,4622L,7921L,144L,20L,28L,62L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256661Inst : IEnumerable<long>
{
public static readonly long[] Value=A256661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256661.Bytes);
public long this[int i]=>Value[i];

public static A256661Inst Instance=new A256661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256662
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,10L,9L,8L,19L,16L,15L,14L,13L,30L,31L,26L,27L,24L,23L,22L,21L,48L,49L,50L,53L,42L,43L,44L,39L,40L,37L,36L,35L,34L,77L,78L,79L,82L,81L,86L,85L,68L,69L,70L,71L,74L,63L,64L,65L,60L,61L,58L,57L,56L,55L,124L,125L,126L,129L,128L,133L,132L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256662Inst : IEnumerable<long>
{
public static readonly long[] Value=A256662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256662.Bytes);
public long this[int i]=>Value[i];

public static A256662Inst Instance=new A256662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256663
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,5L,8L,8L,8L,14L,13L,13L,13L,13L,22L,23L,21L,22L,21L,21L,21L,21L,35L,36L,37L,39L,34L,35L,36L,34L,35L,34L,34L,34L,34L,56L,57L,58L,60L,60L,63L,63L,55L,56L,57L,58L,60L,55L,56L,57L,55L,56L,55L,55L,55L,55L,90L,91L,92L,94L,94L,97L,97L,97L,103L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256663Inst : IEnumerable<long>
{
public static readonly long[] Value=A256663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256663.Bytes);
public long this[int i]=>Value[i];

public static A256663Inst Instance=new A256663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256664
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,2L,1L,0L,5L,3L,2L,1L,0L,8L,8L,5L,5L,3L,2L,1L,0L,13L,13L,13L,14L,8L,8L,8L,5L,5L,3L,2L,1L,0L,21L,21L,21L,22L,21L,23L,22L,13L,13L,13L,13L,14L,8L,8L,8L,5L,5L,3L,2L,1L,0L,34L,34L,34L,35L,34L,36L,35L,34L,39L,37L,36L,35L,21L,21L,21L,21L,22L,21L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256664Inst : IEnumerable<long>
{
public static readonly long[] Value=A256664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256664.Bytes);
public long this[int i]=>Value[i];

public static A256664Inst Instance=new A256664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256665
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,2L,11L,11L,10L,8L,0L,11L,22L,32L,40L,361L,361L,350L,328L,296L,256L,0L,361L,722L,1072L,1400L,1696L,1952L,24611L,24611L,24250L,23528L,22456L,21056L,19360L,17408L,0L,24611L,49222L,73472L,97000L,119456L,140512L,159872L,177280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256665Inst : IEnumerable<long>
{
public static readonly long[] Value=A256665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256665.Bytes);
public long this[int i]=>Value[i];

public static A256665Inst Instance=new A256665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256666
{
public static readonly long[] Value={ 0L,5L,14L,29L,51L,82L,123L,176L,242L,323L,420L,535L,669L,824L,1001L,1202L,1428L,1681L,1962L,2273L,2615L,2990L,3399L,3844L,4326L,4847L,5408L,6011L,6657L,7348L,8085L,8870L,9704L,10589L,11526L,12517L,13563L,14666L,15827L,17048L,18330L,19675L,21084L,22559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256666Inst : IEnumerable<long>
{
public static readonly long[] Value=A256666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256666.Bytes);
public long this[int i]=>Value[i];

public static A256666Inst Instance=new A256666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256667
{
public static readonly long[] Value={ 1L,9L,1L,0L,0L,9L,8L,8L,9L,4L,5L,1L,3L,8L,5L,6L,0L,0L,8L,9L,5L,2L,3L,8L,1L,0L,4L,1L,0L,8L,5L,7L,2L,1L,6L,4L,5L,9L,5L,4L,9L,8L,3L,8L,0L,7L,3L,2L,3L,6L,3L,7L,3L,6L,0L,5L,4L,0L,2L,4L,8L,3L,2L,8L,3L,7L,3L,5L,9L,7L,9L,0L,0L,6L,0L,7L,1L,6L,4L,9L,6L,0L,5L,3L,3L,0L,9L,0L,5L,4L,4L,7L,2L,5L,6L,1L,1L,2L,4L,1L,4L,1L,1L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256667Inst : IEnumerable<long>
{
public static readonly long[] Value=A256667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256667.Bytes);
public long this[int i]=>Value[i];

public static A256667Inst Instance=new A256667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256668
{
public static readonly long[] Value={ 1310L,2620L,3930L,5240L,6550L,7860L,5243L,6553L,7863L,9173L,3938L,5248L,6558L,3941L,5251L,6561L,5253L,6563L,7873L,9183L,6566L,1331L,2641L,3951L,5261L,6571L,7881L,5264L,6574L,7884L,9194L,10504L,5269L,3961L,1344L,2654L,3964L,5274L,6584L,7894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256668Inst : IEnumerable<long>
{
public static readonly long[] Value=A256668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256668.Bytes);
public long this[int i]=>Value[i];

public static A256668Inst Instance=new A256668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256669
{
public static readonly BigInteger[] Value={ 0L,-1L,-2L,711L,BigInteger.Parse("620448401733239439359972") };
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
public class A256669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256669Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256669.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256669Inst Instance=new A256669Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256670
{
public static readonly long[] Value={ 7L,8L,1L,1L,9L,7L,0L,3L,1L,1L,0L,8L,6L,5L,5L,9L,1L,5L,1L,0L,7L,4L,3L,2L,8L,1L,4L,3L,4L,8L,2L,9L,9L,5L,0L,5L,7L,7L,6L,6L,9L,7L,3L,9L,0L,9L,6L,2L,1L,7L,8L,6L,0L,3L,9L,8L,0L,9L,2L,6L,0L,2L,6L,8L,4L,3L,2L,4L,2L,3L,4L,0L,8L,2L,2L,1L,7L,0L,4L,5L,9L,3L,2L,9L,0L,2L,4L,2L,9L,3L,5L,3L,9L,1L,5L,8L,7L,3L,3L,7L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256670Inst : IEnumerable<long>
{
public static readonly long[] Value=A256670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256670.Bytes);
public long this[int i]=>Value[i];

public static A256670Inst Instance=new A256670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256671
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,-1L,1L,-1L,-1L,7L,5L,-2663L,-691L,1247L,7L,-1511L,-3617L,1623817L,43867L,-10405289L,-174611L,21491081L,854513L,-2523785339L,-236364091L,1827648887L,8553103L,-11254630547L,-23749461029L,596303510772251L,8615841276005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256671Inst : IEnumerable<long>
{
public static readonly long[] Value=A256671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256671.Bytes);
public long this[int i]=>Value[i];

public static A256671Inst Instance=new A256671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256672
{
public static readonly long[] Value={ 1L,2L,7L,31L,153L,834L,4839L,29612L,188695L,1243746L,8428597L,58476481L,413893789L,2980489256L,21787216989L,161374041945L,1209258743839L,9155914963702L,69969663242487L,539189056700627L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256672Inst : IEnumerable<long>
{
public static readonly long[] Value=A256672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256672.Bytes);
public long this[int i]=>Value[i];

public static A256672Inst Instance=new A256672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256673
{
public static readonly long[] Value={ 105L,165L,231L,255L,273L,285L,345L,357L,385L,399L,455L,465L,483L,555L,561L,595L,609L,645L,651L,663L,665L,715L,795L,805L,861L,885L,915L,957L,969L,987L,1001L,1015L,1023L,1045L,1095L,1131L,1185L,1281L,1295L,1309L,1311L,1335L,1353L,1407L,1443L,1463L,1479L,1495L,1515L,1533L,1545L,1547L,1551L,1615L,1635L,1645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256673Inst : IEnumerable<long>
{
public static readonly long[] Value=A256673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256673.Bytes);
public long this[int i]=>Value[i];

public static A256673Inst Instance=new A256673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256674
{
public static readonly long[] Value={ 3L,6L,23L,24L,36L,54L,57L,62L,63L,78L,113L,123L,134L,138L,140L,149L,158L,167L,173L,174L,189L,194L,198L,200L,204L,228L,240L,255L,260L,267L,297L,329L,341L,353L,375L,396L,399L,413L,425L,435L,444L,473L,480L,482L,491L,495L,503L,515L,516L,519L,534L,546L,548L,554L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256674Inst : IEnumerable<long>
{
public static readonly long[] Value=A256674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256674.Bytes);
public long this[int i]=>Value[i];

public static A256674Inst Instance=new A256674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256675
{
public static readonly long[] Value={ 6L,6L,15L,15L,105L,21L,105L,15L,165L,33L,15015L,1365L,1365L,3L,255L,255L,33915L,399L,21945L,165L,3795L,69L,31395L,1365L,1365L,3L,435L,435L,1038345L,7161L,608685L,255L,255L,3L,959595L,959595L,959595L,3L,6765L,6765L,2036265L,903L,103845L,345L,16215L,141L,1090635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256675Inst : IEnumerable<long>
{
public static readonly long[] Value=A256675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256675.Bytes);
public long this[int i]=>Value[i];

public static A256675Inst Instance=new A256675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256676
{
public static readonly long[] Value={ 1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L,4L,7L,3L,1L,1L,3L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256676Inst : IEnumerable<long>
{
public static readonly long[] Value=A256676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256676.Bytes);
public long this[int i]=>Value[i];

public static A256676Inst Instance=new A256676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256677
{
public static readonly long[] Value={ 1291L,37813L,48091L,76091L,100829L,120091L,167911L,193549L,271639L,281291L,436621L,847727L,847741L,1188529L,1705549L,2933083L,3126173L,5451643L,7703653L,9623533L,9755149L,10468261L,11971373L,17424301L,20892871L,20967883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256677Inst : IEnumerable<long>
{
public static readonly long[] Value=A256677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256677.Bytes);
public long this[int i]=>Value[i];

public static A256677Inst Instance=new A256677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256678
{
public static readonly long[] Value={ 1L,1L,-2L,1L,0L,-2L,-4L,1L,1L,0L,6L,-2L,2L,-4L,0L,1L,-1L,1L,-4L,0L,8L,6L,0L,-2L,-5L,2L,4L,-4L,0L,0L,-4L,1L,-12L,-1L,0L,1L,-4L,-4L,-4L,0L,6L,8L,8L,6L,0L,0L,0L,-2L,9L,-5L,2L,2L,-6L,4L,0L,-4L,8L,0L,0L,0L,-4L,-4L,-4L,1L,0L,-12L,8L,-1L,0L,0L,0L,1L,2L,-4L,10L,-4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256678Inst : IEnumerable<long>
{
public static readonly long[] Value=A256678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256678.Bytes);
public long this[int i]=>Value[i];

public static A256678Inst Instance=new A256678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256679
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-3L,-3L,-8L,-6L,-3L,0L,40L,48L,54L,57L,57L,256L,216L,168L,114L,57L,0L,-1952L,-2208L,-2424L,-2592L,-2706L,-2763L,-2763L,-17408L,-15456L,-13248L,-10824L,-8232L,-5526L,-2763L,0L,177280L,194688L,210144L,223392L,234216L,242448L,247974L,250737L,250737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256679Inst : IEnumerable<long>
{
public static readonly long[] Value=A256679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256679.Bytes);
public long this[int i]=>Value[i];

public static A256679Inst Instance=new A256679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256680
{
public static readonly long[] Value={ 0L,1L,5L,7L,10L,12L,15L,17L,20L,22L,25L,27L,30L,32L,35L,37L,40L,42L,45L,47L,50L,52L,55L,57L,60L,62L,65L,67L,70L,72L,75L,77L,80L,82L,85L,87L,90L,92L,95L,97L,100L,102L,105L,107L,110L,112L,115L,117L,120L,122L,125L,127L,130L,132L,135L,137L,140L,142L,145L,147L,150L,152L,155L,157L,160L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256680Inst : IEnumerable<long>
{
public static readonly long[] Value=A256680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256680.Bytes);
public long this[int i]=>Value[i];

public static A256680Inst Instance=new A256680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256681
{
public static readonly long[] Value={ 3L,6L,3L,5L,2L,9L,3L,3L,6L,6L,4L,3L,6L,9L,0L,1L,0L,9L,7L,8L,3L,9L,1L,8L,1L,5L,6L,6L,9L,4L,6L,0L,1L,7L,7L,1L,3L,9L,4L,8L,4L,2L,3L,8L,6L,1L,1L,9L,3L,5L,3L,0L,7L,0L,8L,7L,4L,8L,4L,7L,9L,0L,0L,6L,7L,5L,5L,8L,9L,5L,9L,7L,8L,3L,8L,4L,9L,8L,8L,9L,6L,6L,4L,8L,4L,0L,5L,5L,8L,3L,9L,9L,8L,4L,6L,0L,0L,8L,0L,3L,6L,8L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256681Inst : IEnumerable<long>
{
public static readonly long[] Value=A256681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256681.Bytes);
public long this[int i]=>Value[i];

public static A256681Inst Instance=new A256681Inst();

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