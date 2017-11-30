using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A165405
{
public static readonly long[] Value={ 1L,3L,3L,15L,3L,87L,-69L,591L,-1005L,4551L,-10581L,37887L,-101373L,328695L,-936933L,2909103L,-8530701L,25985319L,-77169525L,233081439L,-696098589L,2094587223L,-6271178757L,18838702095L,-56465774637L,169497987207L,-508292635029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165405Inst : IEnumerable<long>
{
public static readonly long[] Value=A165405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165405.Bytes);
public long this[int i]=>Value[i];

public static A165405Inst Instance=new A165405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165406
{
public static readonly long[] Value={ 0L,1L,100L,110L,111L,10000L,10010L,10011L,11000L,11001L,11100L,11110L,11111L,1000000L,1000010L,1000011L,1001000L,1001001L,1001100L,1001110L,1001111L,1100000L,1100001L,1100100L,1100110L,1100111L,1110000L,1110010L,1110011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165406Inst : IEnumerable<long>
{
public static readonly long[] Value=A165406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165406.Bytes);
public long this[int i]=>Value[i];

public static A165406Inst Instance=new A165406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165407
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,7L,11L,16L,27L,43L,65L,108L,173L,267L,440L,707L,1105L,1812L,2917L,4597L,7514L,12111L,19196L,31307L,50503L,80380L,130883L,211263L,337284L,548547L,885831L,1417582L,2303413L,3720995L,5965622L,9686617L,15652239L,25130844L,40783083L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165407Inst : IEnumerable<long>
{
public static readonly long[] Value=A165407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165407.Bytes);
public long this[int i]=>Value[i];

public static A165407Inst Instance=new A165407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165408
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,2L,0L,1L,0L,0L,0L,3L,0L,1L,0L,0L,2L,0L,4L,0L,1L,0L,0L,0L,5L,0L,5L,0L,1L,0L,0L,0L,0L,9L,0L,6L,0L,1L,0L,0L,0L,5L,0L,14L,0L,7L,0L,1L,0L,0L,0L,0L,14L,0L,20L,0L,8L,0L,1L,0L,0L,0L,0L,0L,28L,0L,27L,0L,9L,0L,1L,0L,0L,0L,0L,14L,0L,48L,0L,35L,0L,10L,0L,1L,0L,0L,0L,0L,0L,42L,0L,75L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165408Inst : IEnumerable<long>
{
public static readonly long[] Value=A165408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165408.Bytes);
public long this[int i]=>Value[i];

public static A165408Inst Instance=new A165408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165409
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,56L,136L,328L,784L,1896L,4576L,11008L,26592L,64192L,154752L,373696L,902144L,2176640L,5255424L,12687488L,30621952L,73931392L,178484736L,430845952L,1040176640L,2511199232L,6062209024L,14635617280L,35333443584L,85300015104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165409Inst : IEnumerable<long>
{
public static readonly long[] Value=A165409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165409.Bytes);
public long this[int i]=>Value[i];

public static A165409Inst Instance=new A165409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165410
{
public static readonly BigInteger[] Value={ 1L,0L,-4L,-16L,0L,1024L,16384L,0L,-16777216L,-1073741824L,0L,17592186044416L,4503599627370496L,0L,BigInteger.Parse("-1180591620717411303424"),BigInteger.Parse("-1208925819614629174706176"),0L,BigInteger.Parse("5070602400912917605986812821504"),BigInteger.Parse("20769187434139310514121985316880384") };
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
public class A165410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165410Inst Instance=new A165410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165411
{
public static readonly BigInteger[] Value={ 223331L,122555554444333L,224444333555551L,224444555553331L,225555544441333L,333555554444221L,555552233344441L,555552244441333L,555554444221333L,BigInteger.Parse("122444455555666666333"),BigInteger.Parse("122555554444666666333"),BigInteger.Parse("144446666662255555333") };
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
public class A165411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165411Inst Instance=new A165411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165412
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,14L,15L,18L,20L,21L,24L,28L,30L,35L,36L,40L,42L,45L,56L,60L,63L,70L,72L,84L,90L,105L,120L,126L,140L,168L,180L,210L,252L,280L,315L,360L,420L,504L,630L,840L,1260L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165412Inst : IEnumerable<long>
{
public static readonly long[] Value=A165412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165412.Bytes);
public long this[int i]=>Value[i];

public static A165412Inst Instance=new A165412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165413
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,1L,2L,2L,2L,2L,2L,2L,3L,2L,1L,2L,2L,2L,3L,1L,3L,2L,3L,2L,2L,2L,1L,2L,2L,2L,3L,3L,2L,3L,2L,3L,2L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,1L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,2L,3L,3L,2L,2L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165413Inst : IEnumerable<long>
{
public static readonly long[] Value=A165413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165413.Bytes);
public long this[int i]=>Value[i];

public static A165413Inst Instance=new A165413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165414
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,2L,1L,2L,1L,0L,1L,0L,1L,2L,1L,2L,1L,1L,1L,1L,0L,1L,1L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,3L,0L,1L,0L,3L,1L,1L,0L,1L,0L,1L,1L,1L,2L,3L,0L,0L,0L,1L,0L,3L,0L,3L,1L,3L,2L,1L,2L,1L,2L,1L,1L,3L,2L,1L,2L,1L,2L,0L,1L,0L,1L,0L,2L,3L,1L,1L,1L,0L,1L,0L,1L,1L,2L,0L,1L,0L,2L,1L,1L,1L,2L,3L,2L,1L,1L,0L,1L,1L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165414Inst : IEnumerable<long>
{
public static readonly long[] Value=A165414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165414.Bytes);
public long this[int i]=>Value[i];

public static A165414Inst Instance=new A165414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165415
{
public static readonly long[] Value={ 7L,4L,10L,8L,8L,8L,18L,16L,16L,16L,16L,16L,16L,16L,34L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,32L,66L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,64L,130L,128L,128L,128L,128L,128L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165415Inst : IEnumerable<long>
{
public static readonly long[] Value=A165415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165415.Bytes);
public long this[int i]=>Value[i];

public static A165415Inst Instance=new A165415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165416
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,4L,1L,2L,5L,1L,2L,3L,6L,1L,3L,7L,1L,2L,4L,8L,1L,2L,4L,9L,1L,2L,5L,10L,1L,2L,3L,5L,11L,1L,2L,3L,4L,6L,12L,1L,2L,3L,5L,6L,13L,1L,2L,3L,6L,7L,14L,1L,3L,7L,15L,1L,2L,4L,8L,16L,1L,2L,4L,8L,17L,1L,2L,4L,9L,18L,1L,2L,3L,4L,9L,19L,1L,2L,4L,5L,10L,20L,1L,2L,5L,10L,21L,1L,2L,3L,5L,6L,11L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165416Inst : IEnumerable<long>
{
public static readonly long[] Value=A165416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165416.Bytes);
public long this[int i]=>Value[i];

public static A165416Inst Instance=new A165416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165417
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,4L,5L,2L,8L,8L,8L,9L,14L,14L,12L,4L,16L,16L,16L,17L,20L,16L,23L,20L,36L,36L,36L,37L,42L,42L,28L,8L,32L,32L,32L,33L,32L,36L,39L,36L,48L,48L,32L,42L,64L,60L,57L,44L,88L,88L,88L,89L,96L,88L,97L,96L,128L,128L,128L,130L,116L,116L,64L,16L,64L,64L,64L,65L,64L,68L,71L,68L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165417Inst : IEnumerable<long>
{
public static readonly long[] Value=A165417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165417.Bytes);
public long this[int i]=>Value[i];

public static A165417Inst Instance=new A165417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165418
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,2L,4L,4L,4L,5L,8L,8L,8L,4L,8L,8L,8L,9L,10L,8L,13L,12L,20L,20L,20L,21L,26L,26L,20L,8L,16L,16L,16L,17L,16L,18L,21L,20L,24L,24L,16L,22L,36L,34L,35L,28L,48L,48L,48L,49L,52L,48L,55L,56L,76L,76L,76L,78L,76L,76L,48L,16L,32L,32L,32L,33L,32L,34L,37L,36L,36L,32L,40L,42L,50L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165418Inst : IEnumerable<long>
{
public static readonly long[] Value=A165418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165418.Bytes);
public long this[int i]=>Value[i];

public static A165418Inst Instance=new A165418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165419
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,3L,2L,4L,4L,5L,5L,4L,4L,4L,4L,8L,8L,9L,9L,8L,8L,11L,9L,8L,8L,8L,8L,10L,8L,8L,8L,16L,16L,17L,17L,16L,18L,16L,17L,16L,16L,16L,21L,16L,16L,19L,17L,16L,16L,16L,16L,18L,16L,16L,18L,16L,16L,16L,16L,16L,16L,16L,16L,32L,32L,33L,33L,32L,34L,32L,33L,32L,32L,37L,32L,32L,34L,32L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165419Inst : IEnumerable<long>
{
public static readonly long[] Value=A165419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165419.Bytes);
public long this[int i]=>Value[i];

public static A165419Inst Instance=new A165419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165420
{
public static readonly BigInteger[] Value={ 1L,2L,2L,4L,16L,256L,65536L,4294967296L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("340282366920938463463374607431768211456"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639936") };
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
public class A165420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165420Inst Instance=new A165420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165421
{
public static readonly BigInteger[] Value={ 1L,3L,3L,9L,81L,6561L,43046721L,1853020188851841L,BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("11790184577738583171520872861412518665678211592275841109096961") };
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
public class A165421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165421Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165421.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165421Inst Instance=new A165421Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165422
{
public static readonly BigInteger[] Value={ 1L,4L,4L,16L,256L,65536L,4294967296L,BigInteger.Parse("18446744073709551616"),BigInteger.Parse("340282366920938463463374607431768211456"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129639936") };
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
public class A165422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165422Inst Instance=new A165422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165423
{
public static readonly BigInteger[] Value={ 1L,5L,5L,25L,625L,390625L,152587890625L,BigInteger.Parse("23283064365386962890625"),BigInteger.Parse("542101086242752217003726400434970855712890625") };
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
public class A165423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165423Inst Instance=new A165423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165424
{
public static readonly BigInteger[] Value={ 1L,6L,6L,36L,1296L,1679616L,2821109907456L,BigInteger.Parse("7958661109946400884391936"),BigInteger.Parse("63340286662973277706162286946811886609896461828096") };
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
public class A165424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165424Inst Instance=new A165424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165425
{
public static readonly BigInteger[] Value={ 1L,7L,7L,49L,2401L,5764801L,33232930569601L,BigInteger.Parse("1104427674243920646305299201"),BigInteger.Parse("1219760487635835700138573862562971820755615294131238401"),BigInteger.Parse("1487815647197611695910312681741273570332356717154798949898498305086387315423300999654757561928633305897036801") };
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
public class A165425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165425Inst Instance=new A165425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165426
{
public static readonly BigInteger[] Value={ 1L,8L,8L,64L,4096L,16777216L,281474976710656L,BigInteger.Parse("79228162514264337593543950336"),BigInteger.Parse("6277101735386680763835789423207666416102355444464034512896") };
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
public class A165426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165426Inst Instance=new A165426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165427
{
public static readonly BigInteger[] Value={ 1L,9L,9L,81L,6561L,43046721L,1853020188851841L,BigInteger.Parse("3433683820292512484657849089281"),BigInteger.Parse("11790184577738583171520872861412518665678211592275841109096961") };
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
public class A165427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165427Inst Instance=new A165427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165428
{
public static readonly BigInteger[] Value={ 1L,10L,10L,100L,10000L,100000000L,10000000000000000L,BigInteger.Parse("100000000000000000000000000000000"),BigInteger.Parse("10000000000000000000000000000000000000000000000000000000000000000") };
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
public class A165428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165428Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165428.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165428Inst Instance=new A165428Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165429
{
public static readonly BigInteger[] Value={ 1L,1L,8L,10000L,BigInteger.Parse("100501001000500100000") };
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
public class A165429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165429Inst Instance=new A165429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165430
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,1L,1L,4L,1L,1L,1L,1L,5L,1L,2L,3L,1L,1L,6L,1L,1L,1L,1L,1L,1L,7L,1L,1L,1L,1L,1L,1L,1L,8L,1L,1L,1L,1L,1L,1L,1L,1L,9L,1L,2L,1L,1L,5L,2L,1L,1L,1L,10L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,11L,1L,1L,3L,4L,1L,3L,1L,1L,1L,1L,1L,12L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,13L,1L,2L,1L,1L,1L,2L,7L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165430Inst : IEnumerable<long>
{
public static readonly long[] Value=A165430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165430.Bytes);
public long this[int i]=>Value[i];

public static A165430Inst Instance=new A165430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165431
{
public static readonly long[] Value={ 1L,2L,6L,16L,46L,132L,388L,1152L,3462L,10492L,32036L,98400L,303756L,941576L,2928936L,9138176L,28584006L,89609196L,281466916L,885620576L,2790812196L,8806560056L,27823745016L,88005102336L,278637450396L,883024243032L,2800748951208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165431Inst : IEnumerable<long>
{
public static readonly long[] Value=A165431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165431.Bytes);
public long this[int i]=>Value[i];

public static A165431Inst Instance=new A165431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165432
{
public static readonly long[] Value={ 23L,51L,61L,113L,137L,179L,183L,203L,217L,229L,271L,273L,299L,307L,317L,331L,361L,399L,449L,467L,481L,633L,699L,701L,713L,797L,819L,833L,947L,993L,1021L,1039L,1073L,1117L,1187L,1193L,1269L,1371L,1407L,1413L,1427L,1437L,1451L,1453L,1467L,1469L,1511L,1521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165432Inst : IEnumerable<long>
{
public static readonly long[] Value=A165432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165432.Bytes);
public long this[int i]=>Value[i];

public static A165432Inst Instance=new A165432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165433
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,14L,39L,97L,308L,897L,3139L,10304L,38997L,140893L,570002L,2230599L,9567979L,40091222L,181203603L,805962157L,3819522284L,17912075229L,88646095447L,435959031488L,2245454002137L,11530035000169L,61627679281154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165433Inst : IEnumerable<long>
{
public static readonly long[] Value=A165433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165433.Bytes);
public long this[int i]=>Value[i];

public static A165433Inst Instance=new A165433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165434
{
public static readonly BigInteger[] Value={ 1L,1L,4L,39L,862L,35775L,2406208L,238773109L,32867762616L,6009498859909L,1412846181645855L,416415343791239162L,BigInteger.Parse("150747204270574506888"),BigInteger.Parse("65905473934553360340713"),BigInteger.Parse("34305461329980340135062217"),BigInteger.Parse("21003556204331356488142290707"),BigInteger.Parse("14967168378184553824642693791437") };
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
public class A165434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165434Inst Instance=new A165434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165435
{
public static readonly BigInteger[] Value={ 1L,1L,5L,81L,4079L,507549L,127126912L,55643064708L,38715666455777L,40095856807088486L,BigInteger.Parse("58901884724160709571"),BigInteger.Parse("118283825763578012358080"),BigInteger.Parse("315297447553856723754810322"),BigInteger.Parse("1089117884184737631305395668913"),BigInteger.Parse("4778248300569771278502378511288513") };
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
public class A165435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165435Inst Instance=new A165435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165436
{
public static readonly BigInteger[] Value={ 1L,1L,6L,150L,15791L,5442547L,4762077620L,8738543204786L,29476338150380267L,BigInteger.Parse("166824392081434701613"),BigInteger.Parse("1483193888081012069795493"),BigInteger.Parse("19709785177023094680286421698"),BigInteger.Parse("376477754511485610186131980496220"),BigInteger.Parse("10014420201202866850432679446597128835") };
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
public class A165436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165436Inst Instance=new A165436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165437
{
public static readonly BigInteger[] Value={ 1L,1L,7L,256L,52450L,46757209L,135029200594L,992649275638900L,15637211080656145509UL,BigInteger.Parse("468371757818481922636261"),BigInteger.Parse("24491541042280069722306974244") };
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
public class A165437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165437Inst Instance=new A165437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165438
{
public static readonly long[] Value={ 1L,3L,4L,8L,15L,34L,69L,152L,332L,751L,1698L,3905L,9020L,21051L,49356L,116505L,276217L,658091L,1573835L,3778152L,9098915L,21980209L,53241777L,129294912L,314714273L,767700735L,1876437054L,4595005570L,11271747564L,27695048780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165438Inst : IEnumerable<long>
{
public static readonly long[] Value=A165438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165438.Bytes);
public long this[int i]=>Value[i];

public static A165438Inst Instance=new A165438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165439
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,17L,19L,23L,31L,37L,41L,43L,53L,59L,61L,67L,71L,73L,89L,101L,103L,107L,109L,113L,127L,131L,139L,149L,151L,157L,163L,167L,179L,181L,193L,197L,199L,211L,223L,229L,233L,239L,241L,251L,257L,269L,271L,283L,293L,307L,311L,313L,331L,337L,347L,359L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165439Inst : IEnumerable<long>
{
public static readonly long[] Value=A165439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165439.Bytes);
public long this[int i]=>Value[i];

public static A165439Inst Instance=new A165439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165440
{
public static readonly long[] Value={ 3L,29L,47L,79L,83L,97L,137L,173L,191L,227L,263L,277L,281L,317L,349L,353L,367L,439L,443L,457L,461L,547L,599L,619L,641L,673L,691L,709L,727L,797L,821L,853L,887L,907L,911L,977L,1019L,1069L,1087L,1091L,1109L,1163L,1181L,1217L,1249L,1307L,1361L,1429L,1433L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165440Inst : IEnumerable<long>
{
public static readonly long[] Value=A165440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165440.Bytes);
public long this[int i]=>Value[i];

public static A165440Inst Instance=new A165440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165441
{
public static readonly long[] Value={ 1L,4L,4L,9L,1L,9L,16L,36L,36L,16L,25L,16L,1L,16L,25L,36L,100L,144L,144L,100L,36L,49L,9L,225L,1L,225L,9L,49L,64L,196L,12L,400L,400L,12L,196L,64L,81L,64L,441L,144L,1L,144L,441L,64L,81L,100L,324L,576L,784L,900L,900L,784L,576L,324L,100L,121L,25L,81L,64L,1225L,1L,1225L,64L,81L,25L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165441Inst : IEnumerable<long>
{
public static readonly long[] Value=A165441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165441.Bytes);
public long this[int i]=>Value[i];

public static A165441Inst Instance=new A165441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165442
{
public static readonly long[] Value={ 20L,38L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165442Inst : IEnumerable<long>
{
public static readonly long[] Value=A165442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165442.Bytes);
public long this[int i]=>Value[i];

public static A165442Inst Instance=new A165442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165443
{
public static readonly BigInteger[] Value={ 1L,5521L,35957041L,235845988561L,1547368082644081L,10152277523461827601UL,BigInteger.Parse("66609091687940958003121"),BigInteger.Parse("437022250271846649679394641"),BigInteger.Parse("2867302983958645970747063186161"),BigInteger.Parse("18812374877733491600234823630721681") };
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
public class A165443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165443Inst Instance=new A165443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165444
{
public static readonly long[] Value={ 43L,47L,419L,431L,443L,461L,467L,479L,4127L,4139L,4157L,4211L,4229L,4241L,4271L,4283L,4337L,4349L,4373L,4397L,4409L,4421L,4457L,4463L,4523L,4547L,4643L,4673L,4691L,4733L,4751L,4787L,4877L,4919L,4937L,4967L,41039L,41051L,41117L,41201L,41213L,41231L,41381L,41399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165444Inst : IEnumerable<long>
{
public static readonly long[] Value=A165444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165444.Bytes);
public long this[int i]=>Value[i];

public static A165444Inst Instance=new A165444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165445
{
public static readonly BigInteger[] Value={ 1L,27L,702L,18252L,474552L,12338352L,320797152L,8340725952L,216858874752L,5638330743201L,146596599314100L,3811511581929675L,99099301124011500L,2576581829064137700L,BigInteger.Parse("66991127551503386400"),BigInteger.Parse("1741769316230819007600") };
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
public class A165445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165445Inst Instance=new A165445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165446
{
public static readonly long[] Value={ 3L,5L,11L,17L,53L,59L,71L,101L,113L,137L,173L,191L,503L,509L,521L,557L,563L,569L,587L,593L,599L,701L,719L,743L,773L,941L,947L,971L,1019L,1031L,1049L,1109L,1163L,1277L,1283L,1301L,1319L,1373L,1409L,1427L,1433L,1439L,1451L,1493L,1511L,1523L,1571L,1583L,1601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165446Inst : IEnumerable<long>
{
public static readonly long[] Value=A165446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165446.Bytes);
public long this[int i]=>Value[i];

public static A165446Inst Instance=new A165446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165447
{
public static readonly long[] Value={ 9L,64L,25L,225L,144L,49L,576L,441L,256L,81L,1225L,1024L,729L,400L,121L,2304L,2025L,1600L,1089L,576L,169L,3969L,3600L,3025L,2304L,1521L,784L,225L,6400L,5929L,5184L,4225L,3136L,2025L,1024L,289L,9801L,9216L,8281L,7056L,5625L,4096L,2601L,1296L,361L,14400L,13689L,12544L,11025L,9216L,7225L,5184L,3249L,1600L,441L,20449L,19600L,18225L,16384L,14161L,11664L,9025L,6400L,3969L,1936L,529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165447Inst : IEnumerable<long>
{
public static readonly long[] Value=A165447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165447.Bytes);
public long this[int i]=>Value[i];

public static A165447Inst Instance=new A165447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165448
{
public static readonly BigInteger[] Value={ 2L,3L,35L,143L,6678671L,584803025179L,BigInteger.Parse("34227405074603836560875299"),BigInteger.Parse("16008643688606125328574585946049488062084747136988251"),BigInteger.Parse("497369008478585535856296246658391242478488212329477774761792556414828431057586895468763959997722781406315137061") };
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
public class A165448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165448Inst Instance=new A165448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165449
{
public static readonly long[] Value={ 5L,1L,2L,21L,3L,31L,4L,41L,12L,47L,5L,62L,7L,22L,77L,32L,9L,95L,11L,589L,110L,113L,1L,128L,131L,137L,63L,149L,15L,158L,8L,14L,123L,24L,2L,188L,19L,42L,72L,206L,21L,215L,23L,227L,233L,236L,25L,248L,75L,257L,78L,263L,27L,269L,275L,278L,3L,290L,29L,299L,31L,829L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165449Inst : IEnumerable<long>
{
public static readonly long[] Value=A165449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165449.Bytes);
public long this[int i]=>Value[i];

public static A165449Inst Instance=new A165449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165450
{
public static readonly long[] Value={ 23L,31L,71L,113L,131L,137L,167L,173L,271L,293L,311L,313L,317L,331L,347L,359L,373L,379L,389L,491L,571L,593L,631L,673L,677L,719L,733L,761L,773L,811L,877L,911L,941L,971L,977L,983L,997L,1031L,1091L,1103L,1109L,1171L,1193L,1223L,1231L,1277L,1283L,1291L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165450Inst : IEnumerable<long>
{
public static readonly long[] Value=A165450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165450.Bytes);
public long this[int i]=>Value[i];

public static A165450Inst Instance=new A165450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165451
{
public static readonly long[] Value={ 2L,10L,11L,12L,13L,20L,21L,30L,31L,100L,101L,110L,111L,122L,133L,134L,135L,136L,143L,153L,155L,163L,178L,187L,202L,212L,220L,221L,303L,304L,305L,306L,313L,314L,315L,316L,330L,331L,340L,341L,350L,351L,360L,361L,403L,413L,430L,431L,503L,505L,513L,515L,530L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165451Inst : IEnumerable<long>
{
public static readonly long[] Value=A165451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165451.Bytes);
public long this[int i]=>Value[i];

public static A165451Inst Instance=new A165451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165452
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,17L,45L,184L,748L,4143L,26532L,221032L,2326853L,32202266L,589436301L,14459238676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165452Inst : IEnumerable<long>
{
public static readonly long[] Value=A165452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165452.Bytes);
public long this[int i]=>Value[i];

public static A165452Inst Instance=new A165452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165453
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,10L,13L,16L,19L,22L,25L,28L,32L,36L,40L,44L,48L,52L,56L,60L,65L,70L,75L,80L,85L,90L,95L,100L,105L,110L,116L,122L,128L,134L,140L,146L,152L,158L,164L,170L,176L,182L,189L,196L,203L,210L,217L,224L,231L,238L,245L,252L,259L,266L,273L,280L,288L,296L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165453Inst : IEnumerable<long>
{
public static readonly long[] Value=A165453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165453.Bytes);
public long this[int i]=>Value[i];

public static A165453Inst Instance=new A165453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165454
{
public static readonly long[] Value={ 6L,15L,27L,48L,53L,59L,71L,78L,84L,87L,90L,96L,98L,116L,120L,121L,125L,134L,153L,162L,163L,167L,180L,188L,204L,213L,216L,224L,225L,226L,230L,240L,242L,244L,251L,253L,255L,262L,264L,280L,287L,288L,303L,314L,324L,330L,342L,350L,356L,363L,368L,372L,381L,384L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165454Inst : IEnumerable<long>
{
public static readonly long[] Value=A165454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165454.Bytes);
public long this[int i]=>Value[i];

public static A165454Inst Instance=new A165454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165455
{
public static readonly long[] Value={ 53L,59L,71L,163L,167L,251L,523L,577L,613L,643L,773L,787L,811L,827L,863L,881L,883L,919L,937L,1097L,1117L,1301L,1567L,1607L,1709L,1777L,1867L,1873L,1877L,1889L,1931L,2161L,2237L,2309L,2447L,2521L,2591L,2647L,2687L,2719L,2843L,2897L,2969L,3011L,3079L,3163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165455Inst : IEnumerable<long>
{
public static readonly long[] Value=A165455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165455.Bytes);
public long this[int i]=>Value[i];

public static A165455Inst Instance=new A165455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165456
{
public static readonly BigInteger[] Value={ 1L,28L,756L,20412L,551124L,14880348L,401769396L,10847773692L,292889889684L,7908027021090L,213516729559224L,5764951697823864L,155653695833814360L,4202649787312378584L,BigInteger.Parse("113471544252017775096"),BigInteger.Parse("3063731694658235867448") };
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
public class A165456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165456Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165456.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165456Inst Instance=new A165456Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165457
{
public static readonly BigInteger[] Value={ 1L,10L,280L,15120L,1330560L,172972800L,31135104000L,7410154752000L,2252687044608000L,851515702861824000L,BigInteger.Parse("391697223316439040000"),BigInteger.Parse("215433472824041472000000"),BigInteger.Parse("139600890389978873856000000") };
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
public class A165457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165457Inst Instance=new A165457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165458
{
public static readonly long[] Value={ 1L,4L,8L,40L,56L,424L,248L,4840L,-1864L,59944L,-82312L,801640L,-1789384L,11409064L,-32881672L,169790440L,-564370504L,2601855784L,-9374301832L,40596571240L,-153088193224L,640247048104L,-2477305366792L,10160269944040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165458Inst : IEnumerable<long>
{
public static readonly long[] Value=A165458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165458.Bytes);
public long this[int i]=>Value[i];

public static A165458Inst Instance=new A165458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165459
{
public static readonly long[] Value={ 13L,23L,31L,41L,59L,103L,131L,139L,211L,229L,239L,347L,401L,491L,499L,571L,751L,1021L,1201L,1229L,1453L,1489L,1499L,1741L,2003L,2011L,3001L,3821L,4001L,4639L,4649L,5701L,7079L,8951L,10111L,10247L,10301L,10499L,14251L,14639L,16249L,17321L,19751L,20011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165459Inst : IEnumerable<long>
{
public static readonly long[] Value=A165459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165459.Bytes);
public long this[int i]=>Value[i];

public static A165459Inst Instance=new A165459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165460
{
public static readonly long[] Value={ 2L,2L,6L,2L,8L,2L,10L,4L,10L,4L,10L,6L,14L,2L,4L,4L,18L,6L,14L,4L,12L,8L,22L,6L,16L,6L,20L,6L,2L,8L,18L,6L,28L,4L,20L,4L,30L,12L,14L,0L,14L,6L,28L,10L,28L,6L,32L,10L,16L,8L,26L,10L,26L,6L,24L,8L,36L,10L,28L,8L,26L,10L,30L,8L,0L,10L,32L,14L,18L,12L,0L,14L,44L,6L,32L,6L,38L,0L,32L,8L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165460Inst : IEnumerable<long>
{
public static readonly long[] Value=A165460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165460.Bytes);
public long this[int i]=>Value[i];

public static A165460Inst Instance=new A165460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165461
{
public static readonly long[] Value={ 39L,64L,70L,77L,126L,164L,189L,191L,224L,289L,308L,314L,414L,420L,433L,439L,457L,469L,490L,539L,564L,567L,605L,664L,689L,763L,774L,789L,796L,798L,812L,814L,837L,910L,914L,932L,939L,989L,1035L,1039L,1064L,1078L,1106L,1112L,1155L,1164L,1189L,1253L,1280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165461Inst : IEnumerable<long>
{
public static readonly long[] Value=A165461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165461.Bytes);
public long this[int i]=>Value[i];

public static A165461Inst Instance=new A165461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165462
{
public static readonly long[] Value={ 118L,193L,211L,232L,379L,493L,568L,574L,673L,868L,925L,943L,1243L,1261L,1300L,1318L,1372L,1408L,1471L,1618L,1693L,1702L,1816L,1993L,2068L,2290L,2323L,2368L,2389L,2395L,2437L,2443L,2512L,2731L,2743L,2797L,2818L,2968L,3106L,3118L,3193L,3235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165462Inst : IEnumerable<long>
{
public static readonly long[] Value=A165462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165462.Bytes);
public long this[int i]=>Value[i];

public static A165462Inst Instance=new A165462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165463
{
public static readonly long[] Value={ 475L,775L,847L,931L,1519L,1975L,2275L,2299L,2695L,3475L,3703L,3775L,4975L,5047L,5203L,5275L,5491L,5635L,5887L,6475L,6775L,6811L,7267L,7975L,8275L,9163L,9295L,9475L,9559L,9583L,9751L,9775L,10051L,10927L,10975L,11191L,11275L,11875L,12427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165463Inst : IEnumerable<long>
{
public static readonly long[] Value=A165463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165463.Bytes);
public long this[int i]=>Value[i];

public static A165463Inst Instance=new A165463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165464
{
public static readonly long[] Value={ 0L,0L,2L,4L,2L,4L,2L,0L,0L,2L,2L,4L,4L,4L,2L,0L,0L,2L,2L,4L,4L,2L,0L,0L,0L,0L,2L,4L,4L,2L,8L,10L,16L,16L,4L,2L,2L,10L,16L,10L,8L,8L,20L,20L,20L,18L,18L,32L,18L,10L,4L,2L,4L,10L,8L,2L,2L,10L,10L,4L,4L,4L,2L,10L,16L,26L,20L,10L,2L,4L,10L,18L,32L,32L,50L,52L,52L,34L,40L,58L,80L,80L,106L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165464Inst : IEnumerable<long>
{
public static readonly long[] Value=A165464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165464.Bytes);
public long this[int i]=>Value[i];

public static A165464Inst Instance=new A165464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165465
{
public static readonly long[] Value={ 0L,1L,7L,8L,15L,16L,22L,23L,24L,25L,1702855L,1702856L,1702857L,1702872L,1702873L,2220150L,3327583L,3329174L,3329270L,3329271L,3329279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165465Inst : IEnumerable<long>
{
public static readonly long[] Value=A165465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165465.Bytes);
public long this[int i]=>Value[i];

public static A165465Inst Instance=new A165465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165466
{
public static readonly long[] Value={ 0L,2L,2L,2L,2L,10L,10L,2L,0L,0L,2L,10L,20L,10L,10L,18L,32L,32L,50L,74L,100L,100L,72L,50L,32L,50L,50L,34L,20L,20L,16L,16L,16L,10L,4L,4L,2L,4L,8L,8L,8L,10L,20L,18L,20L,20L,26L,50L,50L,40L,20L,20L,20L,20L,32L,32L,34L,40L,58L,74L,100L,74L,74L,80L,80L,80L,52L,52L,50L,34L,34L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165466Inst : IEnumerable<long>
{
public static readonly long[] Value=A165466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165466.Bytes);
public long this[int i]=>Value[i];

public static A165466Inst Instance=new A165466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165467
{
public static readonly long[] Value={ 0L,8L,9L,105L,1126L,6643718L,6643719L,6643727L,6643728L,6643729L,6643735L,6643736L,6643743L,6643744L,6643745L,6643752L,7746856L,7746857L,7746886L,7746887L,7746888L,7746889L,7747606L,7747718L,7747719L,7747720L,7747737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165467Inst : IEnumerable<long>
{
public static readonly long[] Value=A165467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165467.Bytes);
public long this[int i]=>Value[i];

public static A165467Inst Instance=new A165467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165468
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,9L,11L,13L,17L,19L,21L,23L,27L,29L,35L,37L,39L,41L,45L,47L,49L,53L,57L,59L,63L,65L,67L,71L,75L,77L,81L,83L,89L,95L,97L,99L,101L,107L,109L,111L,113L,117L,119L,125L,127L,129L,131L,133L,137L,139L,147L,149L,153L,155L,161L,165L,167L,169L,173L,179L,185L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165468Inst : IEnumerable<long>
{
public static readonly long[] Value=A165468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165468.Bytes);
public long this[int i]=>Value[i];

public static A165468Inst Instance=new A165468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165469
{
public static readonly long[] Value={ 3L,7L,15L,23L,31L,39L,47L,55L,71L,79L,87L,95L,111L,119L,143L,151L,159L,167L,183L,191L,199L,215L,231L,239L,255L,263L,271L,287L,303L,311L,327L,335L,359L,383L,391L,399L,407L,431L,439L,447L,455L,471L,479L,503L,511L,519L,527L,535L,551L,559L,591L,599L,615L,623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165469Inst : IEnumerable<long>
{
public static readonly long[] Value=A165469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165469.Bytes);
public long this[int i]=>Value[i];

public static A165469Inst Instance=new A165469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165470
{
public static readonly long[] Value={ 1L,5L,15L,85L,215L,1485L,2815L,26885L,29415L,508285L,80015L,10085685L,-8485385L,210199085L,-379906785L,4583888485L,-12182024185L,103859793885L,-347500277585L,2424696155285L,-9374701706985L,57868624812685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165470Inst : IEnumerable<long>
{
public static readonly long[] Value=A165470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165470.Bytes);
public long this[int i]=>Value[i];

public static A165470Inst Instance=new A165470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165471
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165471Inst : IEnumerable<long>
{
public static readonly long[] Value=A165471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165471.Bytes);
public long this[int i]=>Value[i];

public static A165471Inst Instance=new A165471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165472
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,1L,0L,-1L,0L,1L,0L,-1L,-2L,-1L,-2L,-1L,0L,1L,2L,3L,2L,3L,2L,1L,0L,1L,2L,1L,0L,-1L,0L,-1L,0L,1L,2L,3L,4L,5L,6L,5L,4L,3L,4L,3L,2L,1L,0L,-1L,-2L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,-2L,-3L,-2L,-3L,-4L,-5L,-4L,-5L,-4L,-5L,-4L,-3L,-2L,-1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165472Inst : IEnumerable<long>
{
public static readonly long[] Value=A165472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165472.Bytes);
public long this[int i]=>Value[i];

public static A165472Inst Instance=new A165472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165473
{
public static readonly long[] Value={ 0L,6L,8L,10L,16L,24L,28L,30L,32L,46L,50L,52L,54L,56L,72L,74L,76L,78L,80L,82L,84L,288L,292L,294L,300L,302L,360L,364L,370L,372L,374L,376L,378L,382L,394L,400L,402L,416L,418L,420L,422L,424L,426L,808L,810L,818L,820L,1252L,1318L,1320L,1334L,1340L,1342L,1434L,1840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165473Inst : IEnumerable<long>
{
public static readonly long[] Value=A165473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165473.Bytes);
public long this[int i]=>Value[i];

public static A165473Inst Instance=new A165473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165474
{
public static readonly long[] Value={ 2L,7L,9L,12L,19L,26L,29L,31L,38L,48L,51L,53L,55L,63L,73L,75L,77L,79L,81L,83L,188L,290L,293L,297L,301L,325L,362L,367L,371L,373L,375L,377L,380L,385L,397L,401L,409L,417L,419L,421L,423L,425L,650L,809L,813L,819L,964L,1271L,1319L,1324L,1337L,1341L,1371L,1604L,1842L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165474Inst : IEnumerable<long>
{
public static readonly long[] Value=A165474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165474.Bytes);
public long this[int i]=>Value[i];

public static A165474Inst Instance=new A165474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165475
{
public static readonly long[] Value={ 2L,-1L,1L,-2L,3L,2L,-1L,-1L,6L,-2L,-1L,1L,1L,-5L,-1L,-1L,1L,1L,1L,-1L,-16L,2L,1L,3L,1L,9L,2L,3L,-1L,1L,1L,-1L,-2L,-3L,-3L,-1L,-5L,1L,1L,1L,-1L,1L,16L,1L,3L,-1L,22L,11L,1L,-4L,-3L,-1L,7L,-26L,-2L,-2L,-2L,1L,-4L,21L,1L,-1L,1L,6L,-1L,-3L,-12L,2L,-4L,4L,-2L,-1L,2L,-1L,5L,-7L,1L,-2L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165475Inst : IEnumerable<long>
{
public static readonly long[] Value=A165475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165475.Bytes);
public long this[int i]=>Value[i];

public static A165475Inst Instance=new A165475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165476
{
public static readonly long[] Value={ 0L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,1L,1L,-1L,1L,1L,-1L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165476Inst : IEnumerable<long>
{
public static readonly long[] Value=A165476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165476.Bytes);
public long this[int i]=>Value[i];

public static A165476Inst Instance=new A165476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165477
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,3L,4L,5L,6L,7L,6L,5L,6L,5L,6L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,7L,8L,9L,8L,9L,10L,9L,10L,11L,12L,11L,10L,11L,12L,11L,10L,11L,12L,13L,14L,15L,14L,15L,16L,15L,14L,13L,12L,13L,14L,15L,16L,17L,16L,15L,16L,17L,18L,17L,16L,15L,16L,15L,16L,15L,16L,17L,16L,15L,14L,15L,16L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165477Inst : IEnumerable<long>
{
public static readonly long[] Value=A165477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165477.Bytes);
public long this[int i]=>Value[i];

public static A165477Inst Instance=new A165477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165478
{
public static readonly long[] Value={ 0L,131070L,131071L,262141L,262142L,393212L,393213L,524283L,524284L,655354L,655355L,786425L,786426L,917496L,917497L,1048567L,1048568L,1179638L,1179639L,1310709L,1310710L,1441780L,1441781L,1572851L,1572852L,1703922L,1703923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165478Inst : IEnumerable<long>
{
public static readonly long[] Value=A165478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165478.Bytes);
public long this[int i]=>Value[i];

public static A165478Inst Instance=new A165478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165479
{
public static readonly long[] Value={ 43690L,131070L,174761L,262141L,305832L,393212L,436903L,524283L,567974L,655354L,699045L,786425L,830116L,917496L,961187L,1048567L,1092258L,1179638L,1223329L,1310709L,1354400L,1441780L,1485471L,1572851L,1616542L,1703922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165479Inst : IEnumerable<long>
{
public static readonly long[] Value=A165479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165479.Bytes);
public long this[int i]=>Value[i];

public static A165479Inst Instance=new A165479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165480
{
public static readonly long[] Value={ 0L,1L,7L,8L,9L,15L,16L,22L,23L,24L,25L,53L,67L,78L,81L,91L,105L,156L,497L,1126L,1472L,3560L,3620L,23381L,30206L,30688L,30776L,30982L,51700L,52831L,52986L,161086L,269894L,482784L,790601L,1702855L,1702856L,1702857L,1702872L,1702873L,2220150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165480Inst : IEnumerable<long>
{
public static readonly long[] Value=A165480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165480.Bytes);
public long this[int i]=>Value[i];

public static A165480Inst Instance=new A165480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165481
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,-1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,-1L,1L,1L,-1L,-1L,1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,1L,-1L,1L,1L,-1L,1L,1L,1L,-1L,-1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165481Inst : IEnumerable<long>
{
public static readonly long[] Value=A165481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165481.Bytes);
public long this[int i]=>Value[i];

public static A165481Inst Instance=new A165481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165482
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,3L,4L,3L,4L,5L,4L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,-2L,-1L,0L,-1L,0L,-1L,-2L,-1L,-2L,-3L,-4L,-5L,-6L,-5L,-4L,-3L,-2L,-3L,-4L,-3L,-2L,-1L,-2L,-1L,0L,-1L,-2L,-1L,-2L,-3L,-2L,-1L,-2L,-3L,-4L,-5L,-4L,-5L,-4L,-3L,-4L,-3L,-2L,-1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165482Inst : IEnumerable<long>
{
public static readonly long[] Value=A165482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165482.Bytes);
public long this[int i]=>Value[i];

public static A165482Inst Instance=new A165482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165483
{
public static readonly long[] Value={ 0L,22L,24L,26L,28L,30L,32L,36L,38L,58L,170L,172L,174L,182L,184L,186L,190L,192L,194L,204L,206L,212L,216L,218L,224L,226L,228L,230L,236L,238L,240L,242L,248L,256L,260L,266L,268L,270L,300L,306L,308L,320L,322L,324L,326L,328L,330L,332L,334L,336L,350L,356L,8702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165483Inst : IEnumerable<long>
{
public static readonly long[] Value=A165483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165483.Bytes);
public long this[int i]=>Value[i];

public static A165483Inst Instance=new A165483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165484
{
public static readonly long[] Value={ 9L,23L,25L,27L,29L,31L,34L,37L,46L,139L,171L,173L,177L,183L,185L,188L,191L,193L,200L,205L,209L,214L,217L,221L,225L,227L,229L,233L,237L,239L,241L,244L,252L,258L,263L,267L,269L,279L,302L,307L,311L,321L,323L,325L,327L,329L,331L,333L,335L,342L,352L,3615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165484Inst : IEnumerable<long>
{
public static readonly long[] Value=A165484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165484.Bytes);
public long this[int i]=>Value[i];

public static A165484Inst Instance=new A165484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165485
{
public static readonly long[] Value={ 5L,-1L,1L,1L,1L,-1L,-2L,-1L,-6L,-11L,1L,-1L,-3L,1L,1L,2L,-1L,1L,4L,-1L,-3L,-2L,1L,3L,1L,-1L,-1L,3L,-1L,1L,-1L,2L,-4L,-2L,3L,1L,1L,-7L,2L,-1L,3L,-1L,-1L,-1L,-1L,-1L,1L,-1L,1L,4L,-2L,107L,-12L,-15L,-1L,1L,1L,-2L,2L,-1L,-1L,-5L,4L,4L,1L,1L,2L,78L,-3L,2L,-2L,1L,2L,-1L,1L,-2L,-9L,1L,-1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165485Inst : IEnumerable<long>
{
public static readonly long[] Value=A165485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165485.Bytes);
public long this[int i]=>Value[i];

public static A165485Inst Instance=new A165485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165486
{
public static readonly long[] Value={ 0L,1L,4L,1L,4L,1L,0L,-1L,0L,1L,0L,-1L,-4L,-1L,-4L,-1L,0L,1L,4L,9L,4L,9L,4L,1L,0L,1L,4L,1L,0L,-1L,0L,-1L,0L,1L,4L,9L,16L,25L,36L,25L,16L,9L,16L,9L,4L,1L,0L,-1L,-4L,-1L,0L,-1L,0L,1L,0L,1L,0L,-1L,-4L,-9L,-4L,-9L,-16L,-25L,-16L,-25L,-16L,-25L,-16L,-9L,-4L,-1L,0L,-1L,0L,-1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165486Inst : IEnumerable<long>
{
public static readonly long[] Value=A165486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165486.Bytes);
public long this[int i]=>Value[i];

public static A165486Inst Instance=new A165486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165487
{
public static readonly long[] Value={ 0L,1L,4L,1L,4L,9L,4L,9L,16L,25L,36L,49L,36L,25L,36L,25L,36L,49L,64L,49L,64L,49L,64L,81L,64L,81L,64L,49L,64L,81L,64L,81L,100L,81L,100L,121L,144L,121L,100L,121L,144L,121L,100L,121L,144L,169L,196L,225L,196L,225L,256L,225L,196L,169L,144L,169L,196L,225L,256L,289L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165487Inst : IEnumerable<long>
{
public static readonly long[] Value=A165487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165487.Bytes);
public long this[int i]=>Value[i];

public static A165487Inst Instance=new A165487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165488
{
public static readonly long[] Value={ 0L,1L,4L,9L,16L,9L,16L,9L,16L,25L,16L,9L,16L,9L,4L,1L,4L,1L,4L,9L,4L,1L,0L,-1L,0L,1L,0L,1L,0L,1L,0L,-1L,0L,-1L,-4L,-1L,0L,-1L,0L,-1L,-4L,-1L,-4L,-9L,-16L,-25L,-36L,-25L,-16L,-9L,-4L,-9L,-16L,-9L,-4L,-1L,-4L,-1L,0L,-1L,-4L,-1L,-4L,-9L,-4L,-1L,-4L,-9L,-16L,-25L,-16L,-25L,-16L,-9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165488Inst : IEnumerable<long>
{
public static readonly long[] Value=A165488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165488.Bytes);
public long this[int i]=>Value[i];

public static A165488Inst Instance=new A165488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165489
{
public static readonly long[] Value={ 1L,1L,2L,6L,23L,105L,550L,3236L,21127L,152084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165489Inst : IEnumerable<long>
{
public static readonly long[] Value=A165489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165489.Bytes);
public long this[int i]=>Value[i];

public static A165489Inst Instance=new A165489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165490
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,2L,0L,6L,5L,6L,6L,0L,24L,16L,18L,24L,23L,0L,120L,64L,62L,84L,115L,105L,0L,720L,312L,252L,312L,460L,630L,550L,0L,5040L,1812L,1212L,1302L,1840L,2835L,3850L,3236L,0L,40320L,12288L,6856L,6240L,7935L,12180L,19250L,25888L,21127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165490Inst : IEnumerable<long>
{
public static readonly long[] Value=A165490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165490.Bytes);
public long this[int i]=>Value[i];

public static A165490Inst Instance=new A165490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165491
{
public static readonly long[] Value={ 1L,6L,24L,156L,564L,4116L,12804L,110676L,273444L,3046836L,5156484L,86248596L,68445924L,2519011956L,-465634236L,76035992916L,-90005019996L,2371084807476L,-5071235407356L,76203779631636L,-228340841852316L,2514454230801396L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165491Inst : IEnumerable<long>
{
public static readonly long[] Value=A165491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165491.Bytes);
public long this[int i]=>Value[i];

public static A165491Inst Instance=new A165491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165492
{
public static readonly long[] Value={ 7L,29L,47L,61L,79L,151L,349L,389L,461L,601L,1051L,1249L,1429L,1451L,1789L,2239L,3499L,4799L,5011L,5101L,5501L,5749L,10501L,11149L,14249L,50101L,51001L,55001L,100501L,100649L,101149L,150001L,318751L,448999L,501001L,1009951L,5000011L,5000101L,5001001L,50000101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165492Inst : IEnumerable<long>
{
public static readonly long[] Value=A165492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165492.Bytes);
public long this[int i]=>Value[i];

public static A165492Inst Instance=new A165492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165493
{
public static readonly long[] Value={ 17L,37L,53L,73L,89L,107L,109L,127L,181L,199L,269L,271L,379L,503L,521L,557L,701L,739L,1009L,1061L,1097L,1151L,1171L,1439L,1511L,1601L,1619L,1747L,1801L,1871L,2251L,3169L,3259L,3329L,3347L,3511L,3761L,3851L,3889L,4051L,4139L,4519L,4751L,4951L,5003L,5021L,5849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165493Inst : IEnumerable<long>
{
public static readonly long[] Value=A165493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165493.Bytes);
public long this[int i]=>Value[i];

public static A165493Inst Instance=new A165493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165494
{
public static readonly long[] Value={ 2L,3L,3L,3L,2L,3L,7L,2L,3L,6L,2L,9L,3L,2L,10L,3L,2L,2L,5L,7L,3L,4L,7L,10L,5L,5L,10L,8L,2L,7L,3L,8L,7L,4L,9L,36L,13L,9L,2L,6L,7L,5L,2L,2L,9L,4L,30L,2L,16L,4L,6L,6L,4L,11L,24L,16L,11L,9L,3L,11L,15L,2L,9L,10L,2L,26L,2L,10L,3L,3L,4L,13L,11L,5L,12L,3L,7L,17L,21L,17L,17L,12L,5L,4L,3L,8L,19L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165494Inst : IEnumerable<long>
{
public static readonly long[] Value=A165494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165494.Bytes);
public long this[int i]=>Value[i];

public static A165494Inst Instance=new A165494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165495
{
public static readonly long[] Value={ 7L,38L,71L,122L,178L,265L,415L,486L,602L,799L,927L,1230L,1321L,1486L,1810L,1951L,2214L,2474L,2830L,3194L,3386L,3738L,4206L,4639L,4874L,5358L,5838L,6222L,6534L,7101L,7482L,8145L,8570L,9010L,9722L,10922L,10922L,11434L,11882L,12571L,13274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165495Inst : IEnumerable<long>
{
public static readonly long[] Value=A165495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165495.Bytes);
public long this[int i]=>Value[i];

public static A165495Inst Instance=new A165495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165496
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,11L,13L,16L,24L,30L,32L,40L,55L,61L,62L,91L,115L,129L,139L,190L,218L,325L,330L,344L,359L,412L,499L,709L,762L,779L,791L,1392L,2230L,2440L,2947L,3355L,6008L,6124L,6718L,6899L,7563L,7872L,8070L,12529L,15204L,17582L,19313L,20706L,28825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165496Inst : IEnumerable<long>
{
public static readonly long[] Value=A165496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165496.Bytes);
public long this[int i]=>Value[i];

public static A165496Inst Instance=new A165496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165497
{
public static readonly long[] Value={ 1L,3L,3L,60L,60L,201L,481L,5989L,3122037L,4434429L,13576837L,183894465L,187925171L,209072257L,1498642520L,12239200420L,20220712468L,20220712468L,875023683404L,992997544772L,2721798771116L,9770941874212L,9770941874212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165497Inst : IEnumerable<long>
{
public static readonly long[] Value=A165497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165497.Bytes);
public long this[int i]=>Value[i];

public static A165497Inst Instance=new A165497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165498
{
public static readonly long[] Value={ 1L,3L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165498Inst : IEnumerable<long>
{
public static readonly long[] Value=A165498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165498.Bytes);
public long this[int i]=>Value[i];

public static A165498Inst Instance=new A165498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165499
{
public static readonly long[] Value={ 1L,3L,4L,5989L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165499Inst : IEnumerable<long>
{
public static readonly long[] Value=A165499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165499.Bytes);
public long this[int i]=>Value[i];

public static A165499Inst Instance=new A165499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165500
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,3L,7L,4L,2L,5L,11L,3L,13L,7L,6L,2L,17L,3L,19L,5L,7L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165500Inst : IEnumerable<long>
{
public static readonly long[] Value=A165500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165500.Bytes);
public long this[int i]=>Value[i];

public static A165500Inst Instance=new A165500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165501
{
public static readonly BigInteger[] Value={ 1L,2L,5L,6L,2L,150L,19L,16L,12L,1536160080L,8L,9918821194590L,300L,188L,65L,BigInteger.Parse("341976204789992332560"),157L,BigInteger.Parse("2166703103992332274919550"),24L,450L,3072320160L };
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
public class A165501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165501Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A165501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165501.Bytes);
public BigInteger this[int i]=>Value[i];

public static A165501Inst Instance=new A165501Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165502
{
public static readonly long[] Value={ 83L,137L,173L,223L,263L,277L,281L,367L,443L,457L,547L,587L,673L,677L,691L,727L,853L,857L,907L,911L,997L,1033L,1087L,1109L,1163L,1181L,1213L,1217L,1307L,1433L,1447L,1523L,1613L,1627L,1699L,1721L,1811L,2027L,2153L,2203L,2221L,2297L,2347L,2459L,2473L,2477L,2531L,2549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165502Inst : IEnumerable<long>
{
public static readonly long[] Value=A165502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165502.Bytes);
public long this[int i]=>Value[i];

public static A165502Inst Instance=new A165502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165503
{
public static readonly long[] Value={ 433L,613L,683L,773L,827L,863L,1063L,1117L,1187L,1223L,1567L,1583L,1657L,1693L,1783L,1907L,1997L,2017L,2087L,2141L,2143L,2161L,2267L,2357L,2393L,2467L,2557L,2593L,2609L,2663L,2719L,2753L,2789L,2843L,2879L,2897L,2969L,2971L,3023L,3041L,3061L,3167L,3187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165503Inst : IEnumerable<long>
{
public static readonly long[] Value=A165503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165503.Bytes);
public long this[int i]=>Value[i];

public static A165503Inst Instance=new A165503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A165504
{
public static readonly long[] Value={ 887L,1697L,1723L,1867L,1913L,2083L,2137L,2417L,2543L,2633L,2687L,2767L,2803L,2957L,3083L,3109L,3137L,3433L,3793L,3847L,3947L,4073L,4217L,4423L,4567L,4657L,4783L,4793L,4937L,5099L,5233L,5279L,5333L,5387L,5431L,5647L,5683L,5827L,6043L,6053L,6133L,6143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A165504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A165504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A165504Inst : IEnumerable<long>
{
public static readonly long[] Value=A165504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A165504.Bytes);
public long this[int i]=>Value[i];

public static A165504Inst Instance=new A165504Inst();

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