using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A181805
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,6L,6L,7L,6L,7L,8L,8L,8L,10L,11L,14L,9L,9L,12L,14L,19L,15L,20L,21L,21L,20L,15L,22L,22L,22L,21L,23L,22L,17L,23L,23L,23L,24L,25L,24L,25L,23L,23L,25L,28L,25L,27L,27L,31L,22L,27L,26L,30L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181805Inst : IEnumerable<long>
{
public static readonly long[] Value=A181805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181805.Bytes);
public long this[int i]=>Value[i];

public static A181805Inst Instance=new A181805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181806
{
public static readonly long[] Value={ 1L,2L,4L,12L,24L,48L,120L,240L,360L,720L,5040L,10080L,15120L,30240L,60480L,151200L,166320L,332640L,665280L,1663200L,1995840L,3326400L,8648640L,17297280L,21621600L,43243200L,86486400L,129729600L,259459200L,735134400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181806Inst : IEnumerable<long>
{
public static readonly long[] Value=A181806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181806.Bytes);
public long this[int i]=>Value[i];

public static A181806Inst Instance=new A181806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181807
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,8L,10L,11L,14L,19L,20L,21L,22L,23L,24L,25L,28L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181807Inst : IEnumerable<long>
{
public static readonly long[] Value=A181807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181807.Bytes);
public long this[int i]=>Value[i];

public static A181807Inst Instance=new A181807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181808
{
public static readonly long[] Value={ 2L,4L,8L,12L,24L,48L,72L,96L,120L,240L,360L,480L,720L,1440L,1680L,2520L,3360L,5040L,10080L,15120L,20160L,30240L,40320L,50400L,55440L,90720L,100800L,110880L,166320L,221760L,332640L,443520L,554400L,665280L,997920L,1108800L,1330560L,1441440L,2162160L,2882880L,4324320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181808Inst : IEnumerable<long>
{
public static readonly long[] Value=A181808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181808.Bytes);
public long this[int i]=>Value[i];

public static A181808Inst Instance=new A181808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181809
{
public static readonly long[] Value={ 2L,4L,12L,24L,48L,120L,240L,360L,720L,1680L,2520L,5040L,10080L,15120L,20160L,50400L,55440L,110880L,166320L,221760L,332640L,554400L,665280L,1441440L,2162160L,2882880L,4324320L,7207200L,8648640L,14414400L,17297280L,21621600L,43243200L,73513440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181809Inst : IEnumerable<long>
{
public static readonly long[] Value=A181809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181809.Bytes);
public long this[int i]=>Value[i];

public static A181809Inst Instance=new A181809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181810
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,1L,2L,3L,4L,1L,1L,2L,3L,4L,1L,2L,3L,2L,1L,1L,1L,2L,2L,1L,2L,3L,2L,1L,4L,1L,2L,4L,1L,1L,2L,3L,2L,1L,4L,1L,2L,4L,1L,2L,2L,3L,1L,1L,6L,1L,2L,1L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181810Inst : IEnumerable<long>
{
public static readonly long[] Value=A181810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181810.Bytes);
public long this[int i]=>Value[i];

public static A181810Inst Instance=new A181810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181811
{
public static readonly long[] Value={ 1L,1L,2L,1L,6L,2L,30L,1L,4L,6L,210L,2L,2310L,30L,12L,1L,30030L,4L,510510L,6L,60L,210L,9699690L,2L,36L,2310L,8L,30L,223092870L,12L,6469693230L,1L,420L,30030L,180L,4L,200560490130L,510510L,4620L,6L,7420738134810L,60L,304250263527210L,210L,24L,9699690L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181811Inst : IEnumerable<long>
{
public static readonly long[] Value=A181811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181811.Bytes);
public long this[int i]=>Value[i];

public static A181811Inst Instance=new A181811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181812
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,4L,210L,2310L,12L,30030L,510510L,60L,9699690L,36L,8L,223092870L,6469693230L,420L,180L,200560490130L,4620L,7420738134810L,304250263527210L,24L,13082761331670030L,900L,60060L,614889782588491410L,1260L,1021020L,BigInteger.Parse("32589158477190044730") };
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
public class A181812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181812Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181812.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181812.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181812Inst Instance=new A181812Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181813
{
public static readonly long[] Value={ 1L,1L,2L,2L,12L,12L,360L,360L,720L,720L,151200L,151200L,349272000L,349272000L,349272000L,349272000L,10488638160000L,10488638160000L,5354554667061600000L,5354554667061600000L,5354554667061600000L,5354554667061600000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181813Inst : IEnumerable<long>
{
public static readonly long[] Value=A181813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181813.Bytes);
public long this[int i]=>Value[i];

public static A181813Inst Instance=new A181813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181814
{
public static readonly BigInteger[] Value={ 1L,2L,12L,24L,720L,720L,151200L,302400L,1814400L,1814400L,4191264000L,4191264000L,125863657920000L,125863657920000L,125863657920000L,251727315840000L,BigInteger.Parse("128509312009478400000"),BigInteger.Parse("128509312009478400000"),BigInteger.Parse("1246500488605217541696000000") };
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
public class A181814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181814Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181814.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181814.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181814Inst Instance=new A181814Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181815
{
public static readonly long[] Value={ 1L,2L,4L,3L,8L,6L,16L,12L,5L,32L,9L,24L,10L,64L,18L,48L,20L,128L,36L,15L,96L,7L,27L,40L,256L,72L,30L,192L,14L,54L,80L,512L,144L,60L,384L,28L,108L,25L,160L,1024L,45L,288L,21L,81L,120L,768L,56L,216L,50L,320L,2048L,90L,576L,11L,42L,162L,240L,1536L,112L,432L,100L,640L,4096L,180L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181815Inst : IEnumerable<long>
{
public static readonly long[] Value=A181815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181815.Bytes);
public long this[int i]=>Value[i];

public static A181815Inst Instance=new A181815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181816
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,12L,1L,4L,2L,12L,1L,4L,2L,12L,1L,4L,24L,2L,360L,8L,12L,1L,4L,24L,2L,360L,8L,12L,1L,4L,24L,2L,360L,8L,144L,12L,1L,48L,4L,720L,16L,24L,2L,360L,8L,144L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181816Inst : IEnumerable<long>
{
public static readonly long[] Value=A181816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181816.Bytes);
public long this[int i]=>Value[i];

public static A181816Inst Instance=new A181816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181817
{
public static readonly long[] Value={ 1L,2L,4L,12L,8L,24L,16L,48L,360L,32L,144L,96L,720L,64L,288L,192L,1440L,128L,576L,4320L,384L,75600L,1728L,2880L,256L,1152L,8640L,768L,151200L,3456L,5760L,512L,2304L,17280L,1536L,302400L,6912L,129600L,11520L,1024L,51840L,4608L,907200L,20736L,34560L,3072L,604800L,13824L,259200L,23040L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181817Inst : IEnumerable<long>
{
public static readonly long[] Value=A181817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181817.Bytes);
public long this[int i]=>Value[i];

public static A181817Inst Instance=new A181817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181818
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,24L,32L,48L,64L,96L,128L,144L,192L,256L,288L,360L,384L,512L,576L,720L,768L,1024L,1152L,1440L,1536L,1728L,2048L,2304L,2880L,3072L,3456L,4096L,4320L,4608L,5760L,6144L,6912L,8192L,8640L,9216L,11520L,12288L,13824L,16384L,17280L,18432L,20736L,23040L,24576L,27648L,32768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181818Inst : IEnumerable<long>
{
public static readonly long[] Value=A181818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181818.Bytes);
public long this[int i]=>Value[i];

public static A181818Inst Instance=new A181818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181819
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,5L,3L,4L,2L,6L,2L,4L,4L,7L,2L,6L,2L,6L,4L,4L,2L,10L,3L,4L,5L,6L,2L,8L,2L,11L,4L,4L,4L,9L,2L,4L,4L,10L,2L,8L,2L,6L,6L,4L,2L,14L,3L,6L,4L,6L,2L,10L,4L,10L,4L,4L,2L,12L,2L,4L,6L,13L,4L,8L,2L,6L,4L,8L,2L,15L,2L,4L,6L,6L,4L,8L,2L,14L,7L,4L,2L,12L,4L,4L,4L,10L,2L,12L,4L,6L,4L,4L,4L,22L,2L,6L,6L,9L,2L,8L,2L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181819Inst : IEnumerable<long>
{
public static readonly long[] Value=A181819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181819.Bytes);
public long this[int i]=>Value[i];

public static A181819Inst Instance=new A181819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181820
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,10L,8L,11L,9L,14L,12L,13L,15L,22L,20L,17L,21L,18L,26L,16L,25L,28L,19L,33L,30L,34L,24L,35L,44L,23L,39L,42L,38L,40L,55L,27L,52L,29L,50L,51L,36L,49L,66L,46L,56L,65L,45L,68L,31L,70L,57L,32L,60L,77L,78L,58L,88L,85L,63L,76L,37L,110L,69L,48L,84L,91L,75L,102L,62L,54L,98L,104L,95L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181820Inst : IEnumerable<long>
{
public static readonly long[] Value=A181820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181820.Bytes);
public long this[int i]=>Value[i];

public static A181820Inst Instance=new A181820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181821
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,16L,30L,36L,24L,32L,60L,64L,48L,72L,210L,128L,180L,256L,120L,144L,96L,512L,420L,216L,192L,900L,240L,1024L,360L,2048L,2310L,288L,384L,432L,1260L,4096L,768L,576L,840L,8192L,720L,16384L,480L,1800L,1536L,32768L,4620L,1296L,1080L,1152L,960L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181821Inst : IEnumerable<long>
{
public static readonly long[] Value=A181821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181821.Bytes);
public long this[int i]=>Value[i];

public static A181821Inst Instance=new A181821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181822
{
public static readonly long[] Value={ 1L,2L,6L,4L,30L,12L,210L,60L,8L,2310L,36L,420L,24L,30030L,180L,4620L,120L,510510L,1260L,72L,60060L,16L,900L,840L,9699690L,13860L,360L,1021020L,48L,6300L,9240L,223092870L,180180L,2520L,19399380L,240L,69300L,216L,120120L,6469693230L,1800L,3063060L,144L,44100L,27720L,446185740L,1680L,900900L,1080L,2042040L,200560490130L,12600L,58198140L,32L,720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181822Inst : IEnumerable<long>
{
public static readonly long[] Value=A181822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181822.Bytes);
public long this[int i]=>Value[i];

public static A181822Inst Instance=new A181822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181823
{
public static readonly long[] Value={ 4L,8L,16L,24L,32L,48L,64L,72L,96L,128L,144L,192L,216L,240L,256L,288L,384L,432L,480L,512L,576L,720L,768L,864L,960L,1024L,1080L,1152L,1296L,1440L,1536L,1728L,1920L,2048L,2160L,2304L,2592L,2880L,3072L,3360L,3456L,3600L,3840L,4096L,4320L,4608L,5184L,5760L,6144L,6480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181823Inst : IEnumerable<long>
{
public static readonly long[] Value=A181823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181823.Bytes);
public long this[int i]=>Value[i];

public static A181823Inst Instance=new A181823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181824
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,24L,32L,36L,48L,64L,72L,96L,120L,128L,144L,192L,216L,240L,256L,288L,360L,384L,432L,480L,512L,576L,720L,768L,864L,960L,1024L,1080L,1152L,1296L,1440L,1536L,1680L,1728L,1920L,2048L,2160L,2304L,2592L,2880L,3072L,3360L,3456L,3600L,3840L,4096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181824Inst : IEnumerable<long>
{
public static readonly long[] Value=A181824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181824.Bytes);
public long this[int i]=>Value[i];

public static A181824Inst Instance=new A181824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181825
{
public static readonly long[] Value={ 1L,2L,12L,36L,120L,360L,1680L,5040L,5400L,27000L,36960L,75600L,110880L,378000L,960960L,1587600L,1663200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181825Inst : IEnumerable<long>
{
public static readonly long[] Value=A181825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181825.Bytes);
public long this[int i]=>Value[i];

public static A181825Inst Instance=new A181825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181826
{
public static readonly long[] Value={ 1L,2L,6L,12L,30L,36L,60L,120L,180L,210L,360L,420L,840L,900L,1260L,1680L,1800L,2310L,2520L,4620L,5040L,5400L,6300L,7560L,9240L,12600L,13860L,18480L,25200L,27000L,27720L,30030L,36960L,37800L,44100L,55440L,60060L,69300L,75600L,83160L,88200L,110880L,120120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181826Inst : IEnumerable<long>
{
public static readonly long[] Value=A181826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181826.Bytes);
public long this[int i]=>Value[i];

public static A181826Inst Instance=new A181826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181827
{
public static readonly long[] Value={ 6L,30L,60L,180L,210L,420L,840L,900L,1260L,1800L,2310L,2520L,4620L,6300L,7560L,9240L,12600L,13860L,18480L,25200L,27720L,30030L,37800L,44100L,55440L,60060L,69300L,83160L,88200L,120120L,138600L,166320L,176400L,180180L,189000L,240240L,264600L,277200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181827Inst : IEnumerable<long>
{
public static readonly long[] Value=A181827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181827.Bytes);
public long this[int i]=>Value[i];

public static A181827Inst Instance=new A181827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181828
{
public static readonly long[] Value={ 1L,3L,7L,8L,8L,7L,4L,3L,1L,4L,8L,1L,2L,6L,7L,5L,6L,2L,0L,2L,4L,3L,7L,8L,4L,0L,5L,4L,1L,3L,2L,1L,7L,1L,5L,6L,1L,2L,8L,2L,7L,1L,7L,5L,3L,3L,6L,0L,1L,4L,2L,0L,0L,7L,7L,3L,6L,3L,4L,2L,2L,5L,0L,2L,3L,0L,8L,2L,7L,6L,0L,4L,0L,0L,5L,1L,5L,4L,4L,2L,8L,0L,6L,1L,0L,0L,1L,4L,4L,3L,1L,3L,0L,8L,1L,0L,9L,8L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181828Inst : IEnumerable<long>
{
public static readonly long[] Value=A181828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181828.Bytes);
public long this[int i]=>Value[i];

public static A181828Inst Instance=new A181828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181829
{
public static readonly long[] Value={ 0L,-12L,-4L,-12L,0L,20L,12L,84L,8L,180L,60L,308L,24L,468L,140L,660L,48L,884L,252L,1140L,80L,1428L,396L,1748L,120L,2100L,572L,2484L,168L,2900L,780L,3348L,224L,3828L,1020L,4340L,288L,4884L,1292L,5460L,360L,6068L,1596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181829Inst : IEnumerable<long>
{
public static readonly long[] Value=A181829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181829.Bytes);
public long this[int i]=>Value[i];

public static A181829Inst Instance=new A181829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181830
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,1L,0L,2L,2L,2L,1L,6L,2L,6L,4L,4L,4L,11L,4L,12L,6L,6L,6L,18L,6L,12L,9L,14L,8L,22L,6L,22L,14L,14L,12L,20L,8L,27L,16L,20L,12L,32L,10L,34L,18L,18L,16L,42L,14L,32L,17L,26L,20L,46L,16L,32L,20L,28L,24L,54L,14L,48L,28L,32L,26L,41L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181830Inst : IEnumerable<long>
{
public static readonly long[] Value=A181830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181830.Bytes);
public long this[int i]=>Value[i];

public static A181830Inst Instance=new A181830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181831
{
public static readonly long[] Value={ 1L,0L,0L,0L,3L,0L,9L,8L,12L,7L,37L,12L,50L,28L,36L,40L,105L,36L,132L,60L,84L,78L,217L,72L,190L,125L,201L,128L,350L,90L,393L,224L,267L,224L,366L,168L,575L,304L,408L,264L,730L,210L,807L,396L,456L,428L,1009L,336L,905L,443L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181831Inst : IEnumerable<long>
{
public static readonly long[] Value=A181831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181831.Bytes);
public long this[int i]=>Value[i];

public static A181831Inst Instance=new A181831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181832
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,20L,15L,35L,7L,36288L,35L,277200L,1485L,4576L,9009L,20432412000L,5005L,1097800704000L,459459L,5912192L,2834325L,2322315553259520000L,1616615L,124672148625024L,4865140665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181832Inst : IEnumerable<long>
{
public static readonly long[] Value=A181832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181832.Bytes);
public long this[int i]=>Value[i];

public static A181832Inst Instance=new A181832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181833
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,4L,6L,5L,6L,7L,9L,5L,10L,7L,10L,11L,12L,6L,14L,7L,14L,15L,16L,5L,18L,13L,17L,13L,20L,7L,24L,9L,18L,19L,22L,15L,28L,10L,22L,19L,28L,9L,32L,9L,26L,27L,30L,5L,34L,17L,33L,25L,32L,7L,38L,23L,36L,29L,34L,5L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181833Inst : IEnumerable<long>
{
public static readonly long[] Value=A181833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181833.Bytes);
public long this[int i]=>Value[i];

public static A181833Inst Instance=new A181833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181834
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,1L,2L,2L,1L,2L,2L,3L,3L,2L,3L,5L,4L,5L,5L,4L,4L,6L,6L,6L,6L,6L,6L,7L,6L,7L,9L,8L,7L,7L,7L,9L,9L,8L,8L,10L,9L,10L,11L,10L,10L,12L,12L,12L,12L,11L,11L,13L,13L,12L,12L,12L,12L,14L,13L,14L,15L,14L,15L,15L,13L,15L,16L,15L,14L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181834Inst : IEnumerable<long>
{
public static readonly long[] Value=A181834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181834.Bytes);
public long this[int i]=>Value[i];

public static A181834Inst Instance=new A181834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181835
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,3L,0L,5L,8L,12L,7L,10L,12L,23L,19L,24L,31L,39L,36L,53L,51L,60L,54L,64L,72L,90L,80L,82L,88L,91L,90L,119L,127L,144L,127L,129L,143L,155L,139L,160L,174L,190L,185L,226L,225L,260L,248L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181835Inst : IEnumerable<long>
{
public static readonly long[] Value=A181835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181835.Bytes);
public long this[int i]=>Value[i];

public static A181835Inst Instance=new A181835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181836
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,5L,15L,35L,7L,21L,35L,385L,165L,143L,1001L,15015L,5005L,85085L,51051L,46189L,20995L,440895L,1616615L,7436429L,1716099L,2860165L,5311735L,15935205L,7436429L,215656441L,3234846615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181836Inst : IEnumerable<long>
{
public static readonly long[] Value=A181836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181836.Bytes);
public long this[int i]=>Value[i];

public static A181836Inst Instance=new A181836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181837
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181837Inst : IEnumerable<long>
{
public static readonly long[] Value=A181837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181837.Bytes);
public long this[int i]=>Value[i];

public static A181837Inst Instance=new A181837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181838
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181838Inst : IEnumerable<long>
{
public static readonly long[] Value=A181838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181838.Bytes);
public long this[int i]=>Value[i];

public static A181838Inst Instance=new A181838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181839
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,3L,0L,4L,3L,5L,7L,3L,5L,5L,3L,4L,7L,3L,5L,4L,3L,8L,5L,3L,5L,7L,3L,4L,5L,3L,7L,4L,3L,5L,5L,3L,11L,5L,3L,4L,7L,3L,5L,4L,3L,7L,7L,3L,5L,5L,3L,4L,5L,3L,5L,4L,3L,5L,5L,3L,7L,7L,3L,4L,5L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181839Inst : IEnumerable<long>
{
public static readonly long[] Value=A181839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181839.Bytes);
public long this[int i]=>Value[i];

public static A181839Inst Instance=new A181839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181840
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,3L,0L,5L,5L,7L,7L,9L,7L,11L,11L,13L,13L,15L,13L,17L,17L,19L,19L,21L,19L,23L,23L,25L,25L,27L,23L,29L,29L,31L,31L,33L,31L,35L,35L,37L,37L,39L,37L,41L,41L,43L,43L,45L,43L,47L,47L,49L,49L,51L,49L,53L,53L,55L,55L,57L,53L,59L,59L,61L,61L,63L,61L,65L,65L,67L,67L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181840Inst : IEnumerable<long>
{
public static readonly long[] Value=A181840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181840.Bytes);
public long this[int i]=>Value[i];

public static A181840Inst Instance=new A181840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181841
{
public static readonly long[] Value={ 7L,11L,23L,59L,179L,383L,503L,719L,1319L,1439L,1823L,2579L,2903L,3119L,3779L,4283L,4679L,4703L,5099L,5639L,5939L,6719L,8783L,8819L,10079L,12659L,12983L,13523L,15299L,15683L,16223L,17483L,18743L,19079L,21059L,21383L,21563L,22643L,23099L,23603L,24659L,25343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181841Inst : IEnumerable<long>
{
public static readonly long[] Value=A181841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181841.Bytes);
public long this[int i]=>Value[i];

public static A181841Inst Instance=new A181841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181842
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,5L,4L,1L,2L,5L,10L,5L,1L,2L,5L,12L,12L,6L,1L,2L,5L,12L,18L,28L,7L,1L,2L,5L,12L,20L,38L,32L,8L,1L,2L,5L,12L,20L,44L,57L,48L,9L,1L,2L,5L,12L,20L,46L,67L,100L,55L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181842Inst : IEnumerable<long>
{
public static readonly long[] Value=A181842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181842.Bytes);
public long this[int i]=>Value[i];

public static A181842Inst Instance=new A181842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181843
{
public static readonly long[] Value={ 1L,1L,3L,1L,3L,6L,1L,3L,8L,12L,1L,3L,8L,18L,23L,1L,3L,8L,20L,32L,38L,1L,3L,8L,20L,38L,66L,73L,1L,3L,8L,20L,40L,78L,110L,118L,1L,3L,8L,20L,40L,84L,141L,189L,198L,1L,3L,8L,20L,40L,86L,153L,253L,308L,318L,1L,3L,8L,20L,40L,86L,159L,287L,409L,519L,530L,1L,3L,8L,20L,40L,86L,161L,299L,476L,728L,807L,819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181843Inst : IEnumerable<long>
{
public static readonly long[] Value=A181843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181843.Bytes);
public long this[int i]=>Value[i];

public static A181843Inst Instance=new A181843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181844
{
public static readonly long[] Value={ 1L,1L,3L,6L,12L,23L,38L,73L,118L,198L,318L,530L,819L,1298L,1974L,2975L,4516L,6698L,9980L,14550L,21186L,30304L,43503L,62030L,87908L,123292L,172543L,239720L,331688L,458198L,629376L,860332L,1168172L,1583176L,2138438L,2876283L,3859770L,5159886L,6863702L,9112356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181844Inst : IEnumerable<long>
{
public static readonly long[] Value=A181844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181844.Bytes);
public long this[int i]=>Value[i];

public static A181844Inst Instance=new A181844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181845
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,3L,4L,1L,2L,3L,6L,5L,1L,2L,3L,6L,5L,6L,1L,2L,3L,6L,6L,12L,7L,1L,2L,3L,6L,6L,12L,15L,8L,1L,2L,3L,6L,6L,12L,15L,20L,9L,1L,2L,3L,6L,6L,12L,15L,30L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181845Inst : IEnumerable<long>
{
public static readonly long[] Value=A181845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181845.Bytes);
public long this[int i]=>Value[i];

public static A181845Inst Instance=new A181845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181846
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,1L,3L,4L,1L,1L,2L,2L,5L,1L,1L,2L,4L,6L,6L,1L,1L,2L,3L,4L,3L,7L,1L,1L,2L,3L,6L,6L,8L,8L,1L,1L,2L,3L,5L,6L,9L,6L,9L,1L,1L,2L,3L,5L,8L,10L,10L,11L,10L,1L,1L,2L,3L,5L,7L,10L,11L,10L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181846Inst : IEnumerable<long>
{
public static readonly long[] Value=A181846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181846.Bytes);
public long this[int i]=>Value[i];

public static A181846Inst Instance=new A181846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181847
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,4L,3L,1L,5L,4L,6L,4L,1L,6L,9L,11L,10L,5L,1L,7L,6L,15L,20L,15L,6L,1L,8L,12L,24L,36L,35L,21L,7L,1L,9L,12L,30L,56L,70L,56L,28L,8L,1L,10L,17L,42L,88L,127L,126L,84L,36L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181847Inst : IEnumerable<long>
{
public static readonly long[] Value=A181847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181847.Bytes);
public long this[int i]=>Value[i];

public static A181847Inst Instance=new A181847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181848
{
public static readonly long[] Value={ 3L,5L,13L,59L,103L,113L,223L,241L,269L,337L,491L,773L,787L,823L,911L,919L,1571L,1637L,1723L,1879L,1949L,2089L,2423L,2521L,2753L,2953L,2971L,2999L,3011L,3137L,3361L,3571L,3739L,4231L,4363L,4663L,4909L,5791L,5903L,6221L,6359L,6793L,7043L,7507L,7873L,9323L,9403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181848Inst : IEnumerable<long>
{
public static readonly long[] Value=A181848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181848.Bytes);
public long this[int i]=>Value[i];

public static A181848Inst Instance=new A181848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181849
{
public static readonly long[] Value={ 1L,3L,8L,19L,49L,112L,273L,631L,1450L,3327L,7571L,17170L,38519L,85951L,190392L,419759L,921189L,2013874L,4385889L,9516273L,20577618L,44352499L,95324853L,204307052L,436768151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181849Inst : IEnumerable<long>
{
public static readonly long[] Value=A181849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181849.Bytes);
public long this[int i]=>Value[i];

public static A181849Inst Instance=new A181849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181850
{
public static readonly long[] Value={ 1L,2L,3L,3L,7L,8L,4L,12L,18L,19L,5L,25L,40L,48L,49L,6L,27L,77L,101L,111L,112L,7L,63L,129L,225L,260L,272L,273L,8L,68L,248L,408L,568L,616L,630L,631L,9L,105L,369L,801L,1126L,1370L,1433L,1449L,1450L,10L,115L,625L,1401L,2293L,2878L,3228L,3308L,3326L,3327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181850Inst : IEnumerable<long>
{
public static readonly long[] Value=A181850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181850.Bytes);
public long this[int i]=>Value[i];

public static A181850Inst Instance=new A181850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181851
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,1L,4L,8L,6L,1L,5L,20L,15L,8L,1L,6L,21L,50L,24L,10L,1L,7L,56L,66L,96L,35L,12L,1L,8L,60L,180L,160L,160L,48L,14L,1L,9L,96L,264L,432L,325L,244L,63L,16L,1L,10L,105L,510L,776L,892L,585L,350L,80L,18L,1L,11L,220L,567L,1704L,1835L,1668L,966L,480L,99L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181851Inst : IEnumerable<long>
{
public static readonly long[] Value=A181851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181851.Bytes);
public long this[int i]=>Value[i];

public static A181851Inst Instance=new A181851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181852
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,6L,9L,2L,14L,6L,23L,33L,34L,78L,114L,105L,227L,281L,207L,492L,1536L,1667L,3036L,5155L,6502L,5206L,7682L,15861L,15396L,9051L,21295L,22160L,36300L,58657L,71186L,81276L,91901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181852Inst : IEnumerable<long>
{
public static readonly long[] Value=A181852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181852.Bytes);
public long this[int i]=>Value[i];

public static A181852Inst Instance=new A181852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181853
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,11L,6L,1L,10L,31L,34L,12L,1L,15L,81L,189L,182L,60L,1L,21L,141L,393L,494L,282L,60L,1L,28L,288L,1380L,3245L,3740L,2034L,420L,1L,36L,456L,2716L,8293L,13268L,11338L,4908L,840L,1L,45L,726L,5578L,22207L,47351L,57598L,40602L,15564L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181853Inst : IEnumerable<long>
{
public static readonly long[] Value=A181853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181853.Bytes);
public long this[int i]=>Value[i];

public static A181853Inst Instance=new A181853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181854
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,1L,7L,18L,24L,1L,11L,42L,76L,88L,1L,16L,97L,286L,468L,528L,1L,22L,163L,556L,1050L,1332L,1392L,1L,29L,317L,1697L,4942L,8682L,10716L,11136L,1L,37L,493L,3209L,11502L,24770L,36108L,41016L,41856L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181854Inst : IEnumerable<long>
{
public static readonly long[] Value=A181854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181854.Bytes);
public long this[int i]=>Value[i];

public static A181854Inst Instance=new A181854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181855
{
public static readonly BigInteger[] Value={ 1L,1L,1L,239L,-46409L,9113897L,-695818219549L,5649766313929L,-1070083202835456443L,BigInteger.Parse("93856597276403726428217"),BigInteger.Parse("-4815785492460413153189484781"),BigInteger.Parse("674781102986061046417681986493"),BigInteger.Parse("-9845646538265462155478818981872958283") };
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
public class A181855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181855Inst Instance=new A181855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181856
{
public static readonly BigInteger[] Value={ 1L,12L,1440L,362880L,87091200L,11496038400L,376610217984000L,903864523161600L,BigInteger.Parse("36877672544993280000"),BigInteger.Parse("529710888436283473920000"),BigInteger.Parse("3496091863679470927872000000"),BigInteger.Parse("50785334440817577689088000000") };
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
public class A181856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181856Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181856.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181856.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181856Inst Instance=new A181856Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181857
{
public static readonly BigInteger[] Value={ 0L,1L,4L,18L,48L,600L,720L,35280L,40320L,362880L,3628800L,439084800L,479001600L,80951270400L,87178291200L,1307674368000L,20922789888000L,6046686277632000L,6402373705728000L,2311256907767808000L,2432902008176640000L,BigInteger.Parse("51090942171709440000"),BigInteger.Parse("1124000727777607680000") };
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
public class A181857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181857Inst Instance=new A181857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181858
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,4L,36L,18L,64L,576L,14400L,43200L,518400L,518400L,5080320L,12700800L,1625702400L,1625702400L,131681894400L,131681894400L,627056640000L,13168189440000L,1593350922240000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181858Inst : IEnumerable<long>
{
public static readonly long[] Value=A181858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181858.Bytes);
public long this[int i]=>Value[i];

public static A181858Inst Instance=new A181858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181859
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,9L,1L,32L,9L,25L,1L,12L,1L,49L,5L,128L,1L,81L,1L,100L,21L,121L,1L,144L,25L,169L,27L,98L,1L,5L,1L,512L,11L,289L,7L,108L,1L,361L,13L,80L,1L,147L,1L,242L,3L,529L,1L,64L,49L,625L,17L,338L,1L,729L,55L,56L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181859Inst : IEnumerable<long>
{
public static readonly long[] Value=A181859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181859.Bytes);
public long this[int i]=>Value[i];

public static A181859Inst Instance=new A181859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181860
{
public static readonly long[] Value={ 0L,1L,4L,18L,48L,150L,180L,980L,2240L,5670L,6300L,30492L,11088L,156156L,168168L,257400L,1647360L,3719430L,3938220L,17551820L,18475600L,81477396L,85357272L,373173528L,389398464L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181860Inst : IEnumerable<long>
{
public static readonly long[] Value=A181860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181860.Bytes);
public long this[int i]=>Value[i];

public static A181860Inst Instance=new A181860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181861
{
public static readonly long[] Value={ 1L,1L,2L,3L,2L,5L,4L,7L,2L,9L,4L,11L,12L,13L,4L,45L,2L,17L,4L,19L,4L,21L,4L,23L,4L,25L,4L,27L,8L,29L,180L,31L,2L,99L,4L,175L,12L,37L,4L,117L,20L,41L,12L,43L,8L,675L,4L,47L,36L,49L,4L,153L,8L,53L,4L,55L,56L,57L,4L,59L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181861Inst : IEnumerable<long>
{
public static readonly long[] Value=A181861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181861.Bytes);
public long this[int i]=>Value[i];

public static A181861Inst Instance=new A181861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181862
{
public static readonly long[] Value={ 1L,3L,9L,10L,11L,12L,18L,21L,27L,30L,33L,36L,41L,45L,54L,63L,72L,81L,90L,99L,100L,101L,102L,108L,110L,111L,117L,120L,123L,126L,132L,135L,144L,153L,162L,171L,180L,198L,201L,207L,210L,216L,225L,231L,234L,243L,252L,261L,270L,297L,300L,303L,306L,315L,324L,330L,333L,342L,351L,360L,396L,405L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181862Inst : IEnumerable<long>
{
public static readonly long[] Value=A181862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181862.Bytes);
public long this[int i]=>Value[i];

public static A181862Inst Instance=new A181862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181863
{
public static readonly long[] Value={ 3L,11L,41L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181863Inst : IEnumerable<long>
{
public static readonly long[] Value=A181863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181863.Bytes);
public long this[int i]=>Value[i];

public static A181863Inst Instance=new A181863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181864
{
public static readonly BigInteger[] Value={ 1L,2L,7L,207L,700207L,207000000700207L,BigInteger.Parse("70020700000000000000207000000700207"),BigInteger.Parse("2070000007002070000000000000000000000000000000000070020700000000000000207000000700207") };
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
public class A181864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181864Inst Instance=new A181864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181865
{
public static readonly BigInteger[] Value={ 1L,2L,9L,2081L,90004330561L,BigInteger.Parse("2081000000000008100779519733758574721") };
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
public class A181865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181865Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181865.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181865.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181865Inst Instance=new A181865Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181866
{
public static readonly BigInteger[] Value={ 1L,2L,58L,200195112L,BigInteger.Parse("580000000008023436288643185139644928") };
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
public class A181866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181866Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181866.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181866.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181866Inst Instance=new A181866Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181867
{
public static readonly BigInteger[] Value={ 2L,1L,12L,101L,10012L,10000101L,1000000010012L,BigInteger.Parse("100000000000010000101"),BigInteger.Parse("1000000000000000000001000000010012"),BigInteger.Parse("1000000000000000000000000000000000100000000000010000101") };
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
public class A181867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181867Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181867.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181867.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181867Inst Instance=new A181867Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181868
{
public static readonly BigInteger[] Value={ 10L,1L,110L,1001L,1000110L,10000001001L,100000000001000110L,BigInteger.Parse("10000000000000000010000001001"),BigInteger.Parse("10000000000000000000000000000100000000001000110"),BigInteger.Parse("1000000000000000000000000000000000000000000000010000000000000000010000001001") };
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
public class A181868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181868Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181868.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181868.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181868Inst Instance=new A181868Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181869
{
public static readonly BigInteger[] Value={ 2L,1L,14L,1401L,140100014L,BigInteger.Parse("140100014000000001401"),BigInteger.Parse("14010001400000000140100000000000000000000140100014") };
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
public class A181869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181869Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181869.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181869.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181869Inst Instance=new A181869Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181870
{
public static readonly BigInteger[] Value={ 2L,1L,18L,32401L,1049824801000018L,BigInteger.Parse("110213211279472739469283600032400000000000000032401") };
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
public class A181870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181870Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181870.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181870.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181870Inst Instance=new A181870Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181871
{
public static readonly long[] Value={ 0L,2L,0L,2L,-3L,0L,4L,-2L,2L,5L,0L,-20L,0L,16L,-3L,0L,4L,-7L,0L,56L,0L,-112L,0L,64L,-2L,0L,4L,-3L,0L,36L,0L,-96L,0L,64L,5L,0L,-20L,0L,16L,-11L,0L,220L,0L,-1232L,0L,2816L,0L,-2816L,0L,1024L,-1L,2L,13L,0L,-364L,0L,2912L,0L,-9984L,0L,16640L,0L,-13312L,0L,4096L,-7L,0L,56L,0L,-112L,0L,64L,1L,0L,-32L,0L,224L,0L,-448L,0L,256L,2L,0L,-16L,0L,16L,17L,0L,-816L,0L,11424L,0L,-71808L,0L,239360L,0L,-452608L,0L,487424L,0L,-278528L,0L,65536L,-3L,0L,36L,0L,-96L,0L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181871Inst : IEnumerable<long>
{
public static readonly long[] Value=A181871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181871.Bytes);
public long this[int i]=>Value[i];

public static A181871Inst Instance=new A181871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181872
{
public static readonly long[] Value={ 0L,1L,0L,1L,-3L,0L,1L,-1L,1L,5L,0L,-5L,0L,1L,-3L,0L,1L,-7L,0L,7L,0L,-7L,0L,1L,-1L,0L,1L,-3L,0L,9L,0L,-3L,0L,1L,5L,0L,-5L,0L,1L,-11L,0L,55L,0L,-77L,0L,11L,0L,-11L,0L,1L,-1L,1L,13L,0L,-91L,0L,91L,0L,-39L,0L,65L,0L,-13L,0L,1L,-7L,0L,7L,0L,-7L,0L,1L,1L,0L,-1L,0L,7L,0L,-7L,0L,1L,1L,0L,-1L,0L,1L,17L,0L,-51L,0L,357L,0L,-561L,0L,935L,0L,-221L,0L,119L,0L,-17L,0L,1L,-3L,0L,9L,0L,-3L,0L,1L,-19L,0L,285L,0L,-627L,0L,627L,0L,-2717L,0L,1729L,0L,-665L,0L,19L,0L,-19L,0L,1L,-1L,1L,1L,1L,0L,-1L,0L,15L,0L,-39L,0L,11L,0L,-11L,0L,1L,-11L,0L,55L,0L,-77L,0L,11L,0L,-11L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181872Inst : IEnumerable<long>
{
public static readonly long[] Value=A181872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181872.Bytes);
public long this[int i]=>Value[i];

public static A181872Inst Instance=new A181872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181873
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,1L,1L,16L,1L,4L,1L,1L,4L,1L,1L,64L,1L,8L,1L,4L,1L,1L,2L,1L,1L,64L,1L,16L,1L,2L,1L,1L,16L,1L,4L,1L,1L,1024L,1L,256L,1L,64L,1L,4L,1L,4L,1L,1L,2L,1L,4096L,1L,1024L,1L,128L,1L,16L,1L,16L,1L,4L,1L,1L,64L,1L,8L,1L,4L,1L,1L,256L,1L,8L,1L,8L,1L,4L,1L,1L,8L,1L,1L,1L,1L,65536L,1L,4096L,1L,2048L,1L,512L,1L,256L,1L,32L,1L,16L,1L,4L,1L,1L,64L,1L,16L,1L,2L,1L,1L,262144L,1L,65536L,1L,8192L,1L,1024L,1L,1024L,1L,256L,1L,64L,1L,2L,1L,4L,1L,1L,4L,2L,1L,4096L,1L,64L,1L,64L,1L,32L,1L,4L,1L,4L,1L,1L,1024L,1L,256L,1L,64L,1L,4L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181873Inst : IEnumerable<long>
{
public static readonly long[] Value=A181873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181873.Bytes);
public long this[int i]=>Value[i];

public static A181873Inst Instance=new A181873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181874
{
public static readonly long[] Value={ 0L,27L,55L,22L,49L,16L,44L,11L,38L,5L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181874Inst : IEnumerable<long>
{
public static readonly long[] Value=A181874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181874.Bytes);
public long this[int i]=>Value[i];

public static A181874Inst Instance=new A181874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181875
{
public static readonly long[] Value={ -1L,1L,1L,1L,1L,1L,0L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,0L,1L,1L,-3L,0L,1L,-1L,-1L,1L,1L,3L,-3L,-1L,1L,1L,-3L,0L,1L,-1L,3L,3L,-1L,-5L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,0L,-1L,0L,1L,1L,-1L,-5L,5L,15L,-3L,-7L,1L,1L,-1L,-3L,0L,1L,1L,5L,-5L,-5L,15L,21L,-7L,-2L,1L,1L,5L,0L,-5L,0L,1L,1L,-1L,1L,3L,-3L,-1L,1L,-1L,3L,3L,-1L,-1L,1L,-1L,-3L,15L,35L,-35L,-7L,7L,9L,-9L,-5L,1L,1L,1L,0L,-1L,0L,1L,-1L,5L,25L,-5L,-25L,1L,35L,0L,-5L,0L,1L,-1L,-3L,3L,1L,-5L,-1L,1L,1L,9L,0L,-15L,0L,27L,0L,-9L,0L,1L,-7L,0L,7L,0L,-7L,0L,1L,-1L,7L,7L,-7L,-63L,63L,105L,-15L,-165L,55L,33L,-3L,-13L,1L,1L,1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181875Inst : IEnumerable<long>
{
public static readonly long[] Value=A181875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181875.Bytes);
public long this[int i]=>Value[i];

public static A181875Inst Instance=new A181875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181876
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,4L,2L,1L,2L,1L,8L,2L,2L,1L,2L,1L,1L,8L,4L,1L,1L,4L,2L,1L,32L,16L,8L,1L,2L,1L,4L,1L,1L,64L,32L,8L,2L,4L,2L,1L,8L,2L,2L,1L,16L,2L,1L,2L,1L,8L,1L,1L,1L,1L,256L,32L,32L,16L,16L,4L,4L,2L,1L,8L,4L,1L,1L,512L,256L,64L,16L,32L,16L,8L,1L,2L,1L,16L,1L,4L,1L,1L,64L,4L,2L,4L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181876Inst : IEnumerable<long>
{
public static readonly long[] Value=A181876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181876.Bytes);
public long this[int i]=>Value[i];

public static A181876Inst Instance=new A181876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181877
{
public static readonly long[] Value={ -2L,2L,2L,2L,1L,2L,0L,2L,-1L,2L,4L,-1L,2L,-1L,-4L,4L,8L,-2L,0L,4L,1L,-6L,0L,8L,-1L,-2L,4L,1L,6L,-12L,-32L,16L,32L,-3L,0L,4L,-1L,6L,24L,-32L,-80L,32L,64L,1L,-4L,-4L,8L,1L,8L,-16L,-8L,16L,2L,0L,-16L,0L,16L,1L,-8L,-40L,80L,240L,-192L,-448L,128L,256L,-1L,-6L,0L,8L,1L,10L,-40L,-160L,240L,672L,-448L,-1024L,256L,512L,5L,0L,-20L,0L,16L,1L,-16L,32L,48L,-96L,-32L,64L,-1L,6L,12L,-32L,-16L,32L,-1L,-12L,60L,280L,-560L,-1792L,1792L,4608L,-2304L,-5120L,1024L,2048L,1L,0L,-16L,0L,16L,-1L,10L,100L,-40L,-800L,32L,2240L,0L,-2560L,0L,1024L,-1L,-6L,24L,32L,-80L,-32L,64L,1L,18L,0L,-240L,0L,864L,0L,-1152L,0L,512L,-7L,0L,56L,0L,-112L,0L,64L,-1L,14L,112L,-448L,-2016L,4032L,13440L,-15360L,-42240L,28160L,67584L,-24576L,-53248L,8192L,16384L,1L,-8L,-16L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181877Inst : IEnumerable<long>
{
public static readonly long[] Value=A181877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181877.Bytes);
public long this[int i]=>Value[i];

public static A181877Inst Instance=new A181877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181878
{
public static readonly long[] Value={ 1L,1L,1L,-2L,1L,4L,-4L,1L,1L,-6L,11L,-6L,1L,9L,-24L,22L,-8L,1L,1L,-12L,46L,-62L,37L,-10L,1L,16L,-80L,148L,-128L,56L,-12L,1L,1L,-20L,130L,-314L,367L,-230L,79L,-14L,1L,25L,-200L,610L,-920L,771L,-376L,106L,-16L,1L,1L,-30L,295L,-1106L,2083L,-2232L,1444L,-574L,137L,-18L,1L,36L,-420L,1897L,-4352L,5776L,-4744L,2486L,-832L,172L,-20L,1L,1L,-42L,581L,-3108L,8518L,-13672L,13820L,-9142L,4013L,-1158L,211L,-22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181878Inst : IEnumerable<long>
{
public static readonly long[] Value=A181878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181878.Bytes);
public long this[int i]=>Value[i];

public static A181878Inst Instance=new A181878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181879
{
public static readonly long[] Value={ 0L,1L,4L,16L,65L,263L,1065L,4312L,17459L,70690L,286218L,1158873L,4692181L,18998253L,76922356L,311452261L,1261044460L,5105864780L,20673224441L,83704176903L,338911293253L,1372223811812L,5556020785351L,22495868896554L,91083913642878L,368791237300201L,1493205235368669L,6045864568949689L,24479205885623944L,99114281168039257L,401305531615563236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181879Inst : IEnumerable<long>
{
public static readonly long[] Value=A181879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181879.Bytes);
public long this[int i]=>Value[i];

public static A181879Inst Instance=new A181879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181880
{
public static readonly BigInteger[] Value={ 1L,4L,19L,89L,417L,1954L,9156L,42903L,201034L,942001L,4414009L,20683073L,96916320L,454128508L,2127946065L,9971086104L,46722311119L,218930448853L,1025859814873L,4806952917170L,22524321562152L,105544004814991L,494555936863590L,2317380083461485L,10858732149251701L,50881624784254849L,238420075668235984L,1117183909174960184L,5234877488488803537L,BigInteger.Parse("24529481757148330684") };
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
public class A181880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181880.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181880Inst Instance=new A181880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181881
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,94L,37L,114L,67L,124L,189L,164L,209L,174L,553L,204L,583L,214L,705L,224L,10077L,424L,10177L,1134L,10277L,2144L,10577L,2244L,11087L,2744L,11187L,3154L,11587L,3864L,11687L,4374L,11987L,4574L,12087L,5384L,12587L,5594L,12887L,6504L,13387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181881Inst : IEnumerable<long>
{
public static readonly long[] Value=A181881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181881.Bytes);
public long this[int i]=>Value[i];

public static A181881Inst Instance=new A181881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181882
{
public static readonly long[] Value={ 2L,1L,4L,3L,8L,93L,38L,113L,68L,123L,190L,163L,210L,173L,554L,203L,584L,213L,706L,223L,10078L,423L,10178L,1133L,10278L,2143L,10578L,2243L,11088L,2743L,11188L,3153L,11588L,3863L,11688L,4373L,11988L,4573L,12088L,5383L,12588L,5593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181882Inst : IEnumerable<long>
{
public static readonly long[] Value=A181882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181882.Bytes);
public long this[int i]=>Value[i];

public static A181882Inst Instance=new A181882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181883
{
public static readonly long[] Value={ 0L,3L,2L,5L,6L,95L,36L,115L,66L,125L,188L,165L,208L,175L,552L,205L,582L,215L,704L,225L,10076L,425L,10176L,1135L,10276L,2145L,10576L,2245L,11086L,2745L,11186L,3155L,11586L,3865L,11686L,4375L,11986L,4575L,12086L,5385L,12586L,5595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181883Inst : IEnumerable<long>
{
public static readonly long[] Value=A181883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181883.Bytes);
public long this[int i]=>Value[i];

public static A181883Inst Instance=new A181883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181884
{
public static readonly long[] Value={ 3L,0L,5L,2L,9L,92L,39L,112L,69L,122L,191L,162L,211L,172L,555L,202L,585L,212L,707L,222L,10079L,422L,10179L,1132L,10279L,2142L,10579L,2242L,11089L,2742L,11189L,3152L,11589L,3862L,11689L,4372L,11989L,4572L,12089L,5382L,12589L,5592L,5596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181884Inst : IEnumerable<long>
{
public static readonly long[] Value=A181884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181884.Bytes);
public long this[int i]=>Value[i];

public static A181884Inst Instance=new A181884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181885
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,3L,4L,6L,8L,12L,18L,27L,40L,60L,91L,138L,210L,321L,492L,756L,1166L,1800L,2786L,4320L,6710L,10440L,16267L,25380L,39650L,62017L,97108L,152214L,238824L,375060L,589521L,927369L,1459960L,2300100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181885Inst : IEnumerable<long>
{
public static readonly long[] Value=A181885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181885.Bytes);
public long this[int i]=>Value[i];

public static A181885Inst Instance=new A181885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181886
{
public static readonly long[] Value={ 0L,1L,0L,5L,3L,0L,22L,15L,4L,0L,94L,66L,21L,6L,0L,399L,282L,92L,31L,8L,0L,1691L,1197L,393L,137L,41L,9L,0L,7164L,5073L,1668L,586L,181L,47L,11L,0L,30348L,21492L,7069L,2488L,773L,208L,57L,12L,0L,128557L,91044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181886Inst : IEnumerable<long>
{
public static readonly long[] Value=A181886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181886.Bytes);
public long this[int i]=>Value[i];

public static A181886Inst Instance=new A181886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181887
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,8L,9L,33L,43L,89L,124L,292L,290L,726L,839L,1318L,1904L,3616L,3653L,7446L,7620L,12175L,16474L,27907L,26490L,47651L,56922L,80410L,93525L,160402L,146944L,273510L,286942L,395776L,495852L,659747L,690842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181887Inst : IEnumerable<long>
{
public static readonly long[] Value=A181887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181887.Bytes);
public long this[int i]=>Value[i];

public static A181887Inst Instance=new A181887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181888
{
public static readonly long[] Value={ 0L,0L,9L,64L,259L,784L,1974L,4368L,8778L,16368L,28743L,48048L,77077L,119392L,179452L,262752L,375972L,527136L,725781L,983136L,1312311L,1728496L,2249170L,2894320L,3686670L,4651920L,5818995L,7220304L,8892009L,10874304L,13211704L,15953344L,19153288L,22870848L,27170913L,32124288L,37808043L,44305872L,51708462L,60113872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181888Inst : IEnumerable<long>
{
public static readonly long[] Value=A181888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181888.Bytes);
public long this[int i]=>Value[i];

public static A181888Inst Instance=new A181888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181889
{
public static readonly long[] Value={ 0L,64L,784L,4368L,16368L,48048L,119392L,262752L,527136L,983136L,1728496L,2894320L,4651920L,7220304L,10874304L,15953344L,22870848L,32124288L,44305872L,60113872L,80364592L,106004976L,138125856L,177975840L,226975840L,286734240L,359062704L,445992624L,549792208L,672984208L,818364288L,989020032L,1188350592L,1420086976L,1688312976L,1997486736L,2352462960L,2758515760L,3221362144L,3747186144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181889Inst : IEnumerable<long>
{
public static readonly long[] Value=A181889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181889.Bytes);
public long this[int i]=>Value[i];

public static A181889Inst Instance=new A181889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181890
{
public static readonly long[] Value={ 5L,27L,65L,119L,189L,275L,377L,495L,629L,779L,945L,1127L,1325L,1539L,1769L,2015L,2277L,2555L,2849L,3159L,3485L,3827L,4185L,4559L,4949L,5355L,5777L,6215L,6669L,7139L,7625L,8127L,8645L,9179L,9729L,10295L,10877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181890Inst : IEnumerable<long>
{
public static readonly long[] Value=A181890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181890.Bytes);
public long this[int i]=>Value[i];

public static A181890Inst Instance=new A181890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181891
{
public static readonly long[] Value={ 0L,1L,10L,11L,100L,101L,110L,111L,1000L,1001L,1100L,1101L,10000L,10001L,10100L,10101L,11000L,11001L,11100L,11101L,100000L,100001L,101100L,101101L,110000L,110001L,111100L,111101L,1000000L,1000001L,1010000L,1010001L,1100000L,1100001L,1110000L,1110001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181891Inst : IEnumerable<long>
{
public static readonly long[] Value=A181891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181891.Bytes);
public long this[int i]=>Value[i];

public static A181891Inst Instance=new A181891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181892
{
public static readonly BigInteger[] Value={ 25L,841L,32041L,1585081L,101586241L,8229936961L,823010025601L,99584412681601L,14340158060659201L,2423486749613529601L,BigInteger.Parse("475003403490910694401"),BigInteger.Parse("106875765794608626816001"),BigInteger.Parse("27360196043576729389056001"),BigInteger.Parse("7907096656596520292861952001"),BigInteger.Parse("2561899316737326995063771136001") };
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
public class A181892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A181892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A181892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A181892Inst Instance=new A181892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181893
{
public static readonly long[] Value={ 1L,1L,1L,3L,7L,16L,34L,70L,130L,235L,445L,769L,1417L,2497L,4177L,6529L,11233L,17713L,30673L,49033L,76233L,119433L,205833L,316713L,471945L,715881L,1026345L,1449705L,2296425L,3376425L,5536425L,8128425L,11814825L,17528745L,25242537L,34480425L,52956201L,81509673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181893Inst : IEnumerable<long>
{
public static readonly long[] Value=A181893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181893.Bytes);
public long this[int i]=>Value[i];

public static A181893Inst Instance=new A181893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181894
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,6L,9L,7L,11L,7L,13L,9L,8L,16L,17L,11L,19L,9L,10L,13L,23L,9L,25L,15L,12L,11L,29L,10L,31L,18L,14L,19L,12L,13L,37L,21L,16L,11L,41L,12L,43L,15L,14L,25L,47L,19L,49L,27L,20L,17L,53L,14L,16L,13L,22L,31L,59L,12L,61L,33L,16L,20L,18L,16L,67L,21L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181894Inst : IEnumerable<long>
{
public static readonly long[] Value=A181894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181894.Bytes);
public long this[int i]=>Value[i];

public static A181894Inst Instance=new A181894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181895
{
public static readonly long[] Value={ 4L,28L,176L,1258L,10070L,90692L,907184L,9979181L,119750111L,1556754911L,21794572379L,326918591535L,5230697470143L,88921857013919L,1600593426385151L,30411275101997759L,608225502043759679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181895Inst : IEnumerable<long>
{
public static readonly long[] Value=A181895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181895.Bytes);
public long this[int i]=>Value[i];

public static A181895Inst Instance=new A181895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181896
{
public static readonly long[] Value={ 5L,11L,27L,71L,201L,603L,1905L,6318L,21888L,78912L,295260L,1143536L,4574144L,18859680L,80014848L,348776640L,1559776320L,7147792848L,33526120320L,160785625902L,787685472000L,3938427360000L,20082117976800L,104349745817240L,552166953609600L,2973510046027938L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181896Inst : IEnumerable<long>
{
public static readonly long[] Value=A181896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181896.Bytes);
public long this[int i]=>Value[i];

public static A181896Inst Instance=new A181896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181897
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,8L,3L,6L,1L,10L,20L,15L,30L,20L,24L,1L,15L,40L,45L,90L,120L,144L,15L,90L,40L,120L,1L,21L,70L,105L,210L,420L,504L,105L,630L,280L,840L,210L,504L,420L,720L,1L,28L,112L,210L,420L,1120L,1344L,420L,2520L,1120L,3360L,1680L,4032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181897Inst : IEnumerable<long>
{
public static readonly long[] Value=A181897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181897.Bytes);
public long this[int i]=>Value[i];

public static A181897Inst Instance=new A181897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181898
{
public static readonly long[] Value={ 10L,19L,92L,417L,851L,4237L,14771L,73237L,298609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181898Inst : IEnumerable<long>
{
public static readonly long[] Value=A181898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181898.Bytes);
public long this[int i]=>Value[i];

public static A181898Inst Instance=new A181898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181899
{
public static readonly long[] Value={ 2L,5L,12L,35L,96L,288L,945L,3150L,10800L,39312L,147420L,571536L,2286144L,9424800L,39984000L,174283200L,779688000L,3573570000L,16761064320L,80379048750L,393826406400L,1969132032000L,10040487256800L,52174220175000L,276080056560000L,1486750296281250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181899Inst : IEnumerable<long>
{
public static readonly long[] Value=A181899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181899.Bytes);
public long this[int i]=>Value[i];

public static A181899Inst Instance=new A181899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181900
{
public static readonly long[] Value={ 0L,1L,8L,9L,32L,25L,72L,49L,128L,81L,200L,121L,288L,169L,392L,225L,512L,289L,648L,361L,800L,441L,968L,529L,1152L,625L,1352L,729L,1568L,841L,1800L,961L,2048L,1089L,2312L,1225L,2592L,1369L,2888L,1521L,3200L,1681L,3528L,1849L,3872L,2025L,4232L,2209L,4608L,2401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181900Inst : IEnumerable<long>
{
public static readonly long[] Value=A181900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181900.Bytes);
public long this[int i]=>Value[i];

public static A181900Inst Instance=new A181900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181901
{
public static readonly long[] Value={ 1L,4L,7L,9L,13L,17L,19L,23L,25L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181901Inst : IEnumerable<long>
{
public static readonly long[] Value=A181901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181901.Bytes);
public long this[int i]=>Value[i];

public static A181901Inst Instance=new A181901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181902
{
public static readonly long[] Value={ 2L,3L,5L,6L,9L,14L,15L,21L,24L,26L,30L,38L,39L,41L,48L,53L,54L,78L,80L,81L,87L,89L,92L,104L,116L,117L,119L,121L,122L,125L,126L,146L,149L,150L,153L,156L,158L,164L,165L,170L,171L,185L,186L,194L,206L,210L,218L,245L,248L,252L,255L,258L,270L,281L,285L,290L,296L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181902Inst : IEnumerable<long>
{
public static readonly long[] Value=A181902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181902.Bytes);
public long this[int i]=>Value[i];

public static A181902Inst Instance=new A181902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181903
{
public static readonly long[] Value={ 2L,212L,359L,377L,593L,649L,667L,813L,865L,1003L,1175L,1397L,1521L,1581L,1957L,2263L,2409L,2472L,2878L,2994L,3057L,3100L,3177L,3439L,3644L,4134L,4139L,4432L,4983L,5129L,5191L,5205L,5882L,5982L,6585L,7106L,7256L,7347L,7457L,7831L,7841L,8052L,8055L,8587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181903Inst : IEnumerable<long>
{
public static readonly long[] Value=A181903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181903.Bytes);
public long this[int i]=>Value[i];

public static A181903Inst Instance=new A181903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A181904
{
public static readonly long[] Value={ 3L,5L,63L,17L,1023L,195L,16383L,4369L,262143L,31775L,4194303L,12291L,67108863L,89478485L,1073741823L,16843009L,17179869183L,172229265L,274877906943L,6663706835L,4398046511103L,254959218035L,70368744177663L,206208774147L,1125899906842623L,1501199875790165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A181904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A181904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A181904Inst : IEnumerable<long>
{
public static readonly long[] Value=A181904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A181904.Bytes);
public long this[int i]=>Value[i];

public static A181904Inst Instance=new A181904Inst();

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