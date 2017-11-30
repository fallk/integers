using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A131982
{
public static readonly long[] Value={ 576L,584L,588L,592L,600L,1650L,1654L,3430L,3440L,3448L,3452L,3458L,3462L,3466L,3474L,3520L,3600L,3608L,3610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131982Inst : IEnumerable<long>
{
public static readonly long[] Value=A131982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131982.Bytes);
public long this[int i]=>Value[i];

public static A131982Inst Instance=new A131982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131983
{
public static readonly BigInteger[] Value={ 0L,2L,23L,24L,25L,2346L,2369L,24510L,2346812L,23561015L,234691218L,23468121624L,234561012152030L,234671214212842L,235691015183045L,BigInteger.Parse("2345681012152024304060"),BigInteger.Parse("2346781214212428425684"),BigInteger.Parse("23456910121518203036456090") };
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
public class A131983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131983Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131983.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131983Inst Instance=new A131983Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131984
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,18L,20L,24L,30L,36L,48L,60L,84L,90L,120L,168L,180L,240L,336L,360L,420L,480L,540L,600L,660L,720L,840L,1080L,1260L,1440L,1680L,2160L,2520L,3360L,3780L,4200L,4620L,5040L,7560L,9240L,10080L,12600L,13860L,15120L,18480L,20160L,25200L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131984Inst : IEnumerable<long>
{
public static readonly long[] Value=A131984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131984.Bytes);
public long this[int i]=>Value[i];

public static A131984Inst Instance=new A131984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131985
{
public static readonly long[] Value={ 1L,6L,27L,86L,243L,594L,1370L,2916L,5967L,11586L,21870L,39852L,71052L,123444L,210654L,352480L,581013L,942786L,1510254L,2388204L,3734964L,5777788L,8852004L,13434984L,20218395L,30177684L,44704413L,65743348L,96033357L,139368816L,201032186L,288281592L,411119766L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131985Inst : IEnumerable<long>
{
public static readonly long[] Value=A131985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131985.Bytes);
public long this[int i]=>Value[i];

public static A131985Inst Instance=new A131985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131986
{
public static readonly long[] Value={ 1L,-3L,0L,5L,0L,0L,-7L,0L,0L,3L,0L,0L,15L,0L,0L,-32L,0L,0L,9L,0L,0L,58L,0L,0L,-96L,0L,0L,22L,0L,0L,149L,0L,0L,-253L,0L,0L,68L,0L,0L,372L,0L,0L,-599L,0L,0L,140L,0L,0L,826L,0L,0L,-1317L,0L,0L,317L,0L,0L,1768L,0L,0L,-2735L,0L,0L,632L,0L,0L,3526L,0L,0L,-5434L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131986Inst : IEnumerable<long>
{
public static readonly long[] Value=A131986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131986.Bytes);
public long this[int i]=>Value[i];

public static A131986Inst Instance=new A131986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131987
{
public static readonly long[] Value={ 1L,2L,1L,3L,4L,2L,5L,1L,6L,3L,7L,8L,4L,9L,2L,10L,5L,11L,1L,12L,6L,13L,3L,14L,7L,15L,16L,8L,17L,4L,18L,9L,19L,2L,20L,10L,21L,5L,22L,11L,23L,1L,24L,12L,25L,6L,26L,13L,27L,3L,28L,14L,29L,7L,30L,15L,31L,32L,16L,33L,8L,34L,17L,35L,4L,36L,18L,37L,9L,38L,19L,39L,2L,40L,20L,41L,10L,42L,21L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131987Inst : IEnumerable<long>
{
public static readonly long[] Value=A131987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131987.Bytes);
public long this[int i]=>Value[i];

public static A131987Inst Instance=new A131987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131988
{
public static readonly long[] Value={ 2L,3L,9L,9L,9L,6L,3L,2L,2L,9L,7L,2L,8L,6L,5L,3L,3L,2L,2L,2L,3L,1L,5L,5L,5L,5L,0L,6L,6L,3L,3L,6L,1L,3L,8L,5L,3L,1L,2L,4L,9L,9L,9L,0L,1L,1L,0L,5L,8L,1L,1L,5L,0L,4L,2L,9L,3L,5L,1L,1L,2L,7L,5L,0L,7L,3L,1L,3L,0L,7L,3L,3L,8L,2L,3L,9L,4L,3L,8L,7L,9L,0L,7L,7L,9L,9L,6L,2L,0L,6L,0L,6L,6L,0L,5L,8L,3L,9L,6L,3L,7L,3L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131988Inst : IEnumerable<long>
{
public static readonly long[] Value=A131988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131988.Bytes);
public long this[int i]=>Value[i];

public static A131988Inst Instance=new A131988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131989
{
public static readonly long[] Value={ 2L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,1L,2L,3L,1L,2L,3L,3L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131989Inst : IEnumerable<long>
{
public static readonly long[] Value=A131989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131989.Bytes);
public long this[int i]=>Value[i];

public static A131989Inst Instance=new A131989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131990
{
public static readonly long[] Value={ 3L,2L,3L,6L,5L,2L,4L,5L,7L,9L,4L,8L,6L,2L,3L,8L,8L,14L,6L,10L,5L,4L,4L,7L,6L,5L,15L,11L,15L,2L,4L,8L,10L,12L,4L,11L,8L,15L,4L,7L,6L,18L,6L,5L,11L,10L,4L,10L,8L,11L,5L,10L,4L,5L,6L,11L,23L,25L,5L,14L,8L,2L,6L,14L,12L,30L,10L,8L,14L,12L,4L,9L,10L,19L,22L,17L,14L,12L,6L,6L,27L,7L,14L,10L,4L,11L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131990Inst : IEnumerable<long>
{
public static readonly long[] Value=A131990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131990.Bytes);
public long this[int i]=>Value[i];

public static A131990Inst Instance=new A131990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131991
{
public static readonly long[] Value={ 15L,40L,156L,400L,1464L,2380L,5220L,7240L,12720L,25260L,30784L,52060L,70644L,81400L,106080L,151740L,208920L,230764L,305320L,363024L,394420L,499360L,578760L,712980L,922180L,1040604L,1103440L,1236600L,1307020L,1455780L,2064640L,2265384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131991Inst : IEnumerable<long>
{
public static readonly long[] Value=A131991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131991.Bytes);
public long this[int i]=>Value[i];

public static A131991Inst Instance=new A131991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131992
{
public static readonly long[] Value={ 31L,121L,781L,2801L,16105L,30941L,88741L,137561L,292561L,732541L,954305L,1926221L,2896405L,3500201L,4985761L,8042221L,12326281L,14076605L,20456441L,25774705L,28792661L,39449441L,48037081L,63455221L,89451461L,105101005L,113654321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131992Inst : IEnumerable<long>
{
public static readonly long[] Value=A131992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131992.Bytes);
public long this[int i]=>Value[i];

public static A131992Inst Instance=new A131992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131993
{
public static readonly long[] Value={ 63L,364L,3906L,19608L,177156L,402234L,1508598L,2613660L,6728904L,21243690L,29583456L,71270178L,118752606L,150508644L,234330768L,426237714L,727250580L,858672906L,1370581548L,1830004056L,2101864254L,3116505840L,3987077724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131993Inst : IEnumerable<long>
{
public static readonly long[] Value=A131993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131993.Bytes);
public long this[int i]=>Value[i];

public static A131993Inst Instance=new A131993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131994
{
public static readonly long[] Value={ 45L,0L,1301L,19316L,240559L,548834L,25679675L,137949578L,2066327172L,4679307774L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131994Inst : IEnumerable<long>
{
public static readonly long[] Value=A131994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131994.Bytes);
public long this[int i]=>Value[i];

public static A131994Inst Instance=new A131994Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131995
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,9L,11L,16L,20L,26L,32L,42L,50L,62L,74L,92L,108L,131L,153L,184L,213L,251L,288L,339L,387L,448L,511L,589L,666L,761L,857L,976L,1095L,1237L,1384L,1561L,1737L,1946L,2161L,2415L,2672L,2971L,3281L,3640L,4007L,4425L,4860L,5359L,5869L,6446L,7049L,7729L,8428L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131995Inst : IEnumerable<long>
{
public static readonly long[] Value=A131995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131995.Bytes);
public long this[int i]=>Value[i];

public static A131995Inst Instance=new A131995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131996
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,6L,6L,6L,6L,6L,6L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131996Inst : IEnumerable<long>
{
public static readonly long[] Value=A131996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131996.Bytes);
public long this[int i]=>Value[i];

public static A131996Inst Instance=new A131996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131997
{
public static readonly long[] Value={ 1L,3L,9L,27L,15L,81L,243L,45L,729L,2187L,135L,105L,6561L,225L,19683L,405L,59049L,177147L,1215L,315L,675L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131997Inst : IEnumerable<long>
{
public static readonly long[] Value=A131997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131997.Bytes);
public long this[int i]=>Value[i];

public static A131997Inst Instance=new A131997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131998
{
public static readonly long[] Value={ 5L,7L,10L,24L,33L,40L,44L,70L,78L,84L,90L,99L,105L,126L,132L,168L,176L,189L,190L,198L,208L,210L,231L,252L,306L,315L,340L,360L,368L,384L,391L,408L,420L,441L,462L,480L,520L,546L,575L,580L,598L,600L,608L,612L,638L,682L,693L,700L,702L,736L,740L,760L,770L,792L,814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131998Inst : IEnumerable<long>
{
public static readonly long[] Value=A131998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131998.Bytes);
public long this[int i]=>Value[i];

public static A131998Inst Instance=new A131998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131999
{
public static readonly long[] Value={ 1L,-2L,-2L,4L,-2L,8L,4L,-16L,-2L,-14L,8L,20L,4L,24L,-16L,-16L,-2L,-36L,-14L,36L,8L,32L,20L,-48L,4L,-42L,24L,40L,-16L,56L,-16L,-64L,-2L,-40L,-36L,64L,-14L,72L,36L,-48L,8L,-84L,32L,84L,20L,56L,-48L,-96L,4L,-114L,-42L,72L,24L,104L,40L,-80L,-16L,-72L,56L,116L,-16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131999Inst : IEnumerable<long>
{
public static readonly long[] Value=A131999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131999.Bytes);
public long this[int i]=>Value[i];

public static A131999Inst Instance=new A131999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132000
{
public static readonly long[] Value={ 1L,-1L,-5L,-1L,11L,24L,-5L,-50L,-53L,-1L,120L,120L,11L,-170L,-250L,24L,203L,288L,-5L,-362L,-264L,-50L,600L,528L,-53L,-601L,-850L,-1L,550L,840L,120L,-962L,-821L,120L,1440L,1200L,11L,-1370L,-1810L,-170L,1272L,1680L,-250L,-1850L,-1320L,24L,2640L,2208L,203L,-2451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132000Inst : IEnumerable<long>
{
public static readonly long[] Value=A132000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132000.Bytes);
public long this[int i]=>Value[i];

public static A132000Inst Instance=new A132000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132001
{
public static readonly long[] Value={ 1L,5L,1L,-11L,-24L,5L,50L,53L,1L,-120L,-120L,-11L,170L,250L,-24L,-203L,-288L,5L,362L,264L,50L,-600L,-528L,53L,601L,850L,1L,-550L,-840L,-120L,962L,821L,-120L,-1440L,-1200L,-11L,1370L,1810L,170L,-1272L,-1680L,250L,1850L,1320L,-24L,-2640L,-2208L,-203L,2451L,3005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132001Inst : IEnumerable<long>
{
public static readonly long[] Value=A132001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132001.Bytes);
public long this[int i]=>Value[i];

public static A132001Inst Instance=new A132001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132002
{
public static readonly long[] Value={ 1L,-2L,4L,-6L,10L,-16L,24L,-36L,52L,-74L,104L,-144L,198L,-268L,360L,-480L,634L,-832L,1084L,-1404L,1808L,-2316L,2952L,-3744L,4728L,-5946L,7448L,-9294L,11556L,-14320L,17688L,-21780L,26740L,-32736L,39968L,-48672L,59122L,-71644L,86616L,-104484L,125768L,-151072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132002Inst : IEnumerable<long>
{
public static readonly long[] Value=A132002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132002.Bytes);
public long this[int i]=>Value[i];

public static A132002Inst Instance=new A132002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132003
{
public static readonly long[] Value={ 1L,-2L,2L,-2L,2L,-4L,2L,0L,2L,-2L,4L,0L,2L,-4L,0L,-4L,2L,-4L,2L,0L,4L,0L,0L,0L,2L,-6L,4L,-2L,0L,-4L,4L,0L,2L,0L,4L,0L,2L,-4L,0L,-4L,4L,-4L,0L,0L,0L,-4L,0L,0L,2L,-2L,6L,-4L,4L,-4L,2L,0L,0L,0L,4L,0L,4L,-4L,0L,0L,2L,-8L,0L,0L,4L,0L,0L,0L,2L,-4L,4L,-6L,0L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132003Inst : IEnumerable<long>
{
public static readonly long[] Value=A132003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132003.Bytes);
public long this[int i]=>Value[i];

public static A132003Inst Instance=new A132003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132004
{
public static readonly long[] Value={ 1L,-1L,1L,-1L,2L,-1L,0L,-1L,1L,-2L,0L,-1L,2L,0L,2L,-1L,2L,-1L,0L,-2L,0L,0L,0L,-1L,3L,-2L,1L,0L,2L,-2L,0L,-1L,0L,-2L,0L,-1L,2L,0L,2L,-2L,2L,0L,0L,0L,2L,0L,0L,-1L,1L,-3L,2L,-2L,2L,-1L,0L,0L,0L,-2L,0L,-2L,2L,0L,0L,-1L,4L,0L,0L,-2L,0L,0L,0L,-1L,2L,-2L,3L,0L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132004Inst : IEnumerable<long>
{
public static readonly long[] Value=A132004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132004.Bytes);
public long this[int i]=>Value[i];

public static A132004Inst Instance=new A132004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132005
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,3L,3L,7L,11L,11L,12L,15L,31L,51L,51L,55L,71L,87L,170L,286L,286L,306L,381L,481L,593L,1107L,1886L,1886L,2002L,2428L,2973L,3748L,4632L,8342L,14309L,14309L,15088L,17902L,21426L,26212L,32957L,40804L,71368L,122814L,122814L,128781L,150101L,176206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132005Inst : IEnumerable<long>
{
public static readonly long[] Value=A132005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132005.Bytes);
public long this[int i]=>Value[i];

public static A132005Inst Instance=new A132005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132006
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,51L,286L,1886L,14309L,122814L,1176694L,12450056L,144181969L,1814053266L,24640186003L,359363840295L,5601100988553L,92910896970409L,1634289749459611L,30384383699244134L,595344239332647506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132006Inst : IEnumerable<long>
{
public static readonly long[] Value=A132006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132006.Bytes);
public long this[int i]=>Value[i];

public static A132006Inst Instance=new A132006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132007
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,8L,8L,14L,26L,50L,50L,82L,138L,242L,442L,442L,692L,1102L,1792L,3002L,5212L,5212L,7864L,12016L,18628L,29380L,47392L,78664L,78664L,115148L,170196L,254308L,384704L,590364L,922108L,1472756L,1472756L,2102068L,3023252L,4384820L,6419284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132007Inst : IEnumerable<long>
{
public static readonly long[] Value=A132007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132007.Bytes);
public long this[int i]=>Value[i];

public static A132007Inst Instance=new A132007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132184
{
public static readonly long[] Value={ 6L,21L,27L,321L,1266L,1527L,1821L,2526L,2576L,2721L,2950L,3126L,3246L,3426L,4206L,4236L,4821L,4926L,5286L,5721L,5946L,5950L,6100L,6351L,7018L,7138L,7172L,7386L,7806L,7931L,8037L,8790L,8796L,8826L,9021L,9048L,9426L,9478L,9726L,9921L,10221L,10326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132184Inst : IEnumerable<long>
{
public static readonly long[] Value=A132184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132184.Bytes);
public long this[int i]=>Value[i];

public static A132184Inst Instance=new A132184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132185
{
public static readonly BigInteger[] Value={ BigInteger.Parse("144408645048225636603816"),BigInteger.Parse("1725676121534561296189"),BigInteger.Parse("188276429246387492222"),BigInteger.Parse("19838179232721317143537"),BigInteger.Parse("12764828245698443284086"),BigInteger.Parse("176903816597810123057"),BigInteger.Parse("18626438463030625206604"),BigInteger.Parse("19352559475935751347112"),BigInteger.Parse("16128296082816884008108") };
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
public class A132185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132185Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132185.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132185Inst Instance=new A132185Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132186
{
public static readonly BigInteger[] Value={ 1L,2L,8L,58L,802L,20834L,1051586L,102233986L,19614424834L,7355623374338L,5494866505497602L,8087844439442585602L,BigInteger.Parse("23834930674299549249538"),BigInteger.Parse("138978138716920276085366786"),BigInteger.Parse("1626809921636911219317749563394"),BigInteger.Parse("37757678575184051755732304668884994") };
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
public class A132186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132186Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132186.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132186Inst Instance=new A132186Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132187
{
public static readonly long[] Value={ 294L,268L,284L,260L,264L,281L,261L,286L,267L,244L,292L,265L,286L,300L,260L,293L,297L,281L,274L,262L,240L,259L,277L,296L,306L,266L,280L,259L,263L,284L,265L,293L,287L,259L,287L,273L,270L,298L,245L,257L,286L,257L,292L,272L,264L,286L,287L,310L,294L,268L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132187Inst : IEnumerable<long>
{
public static readonly long[] Value=A132187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132187.Bytes);
public long this[int i]=>Value[i];

public static A132187Inst Instance=new A132187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132188
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,9L,12L,17L,18L,19L,22L,23L,24L,25L,32L,33L,38L,39L,42L,43L,44L,45L,48L,57L,58L,63L,66L,67L,68L,69L,76L,77L,78L,79L,90L,91L,92L,93L,96L,97L,98L,99L,102L,107L,108L,109L,116L,129L,138L,139L,142L,143L,148L,149L,152L,153L,154L,155L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132188Inst : IEnumerable<long>
{
public static readonly long[] Value=A132188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132188.Bytes);
public long this[int i]=>Value[i];

public static A132188Inst Instance=new A132188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132189
{
public static readonly long[] Value={ 0L,0L,0L,2L,2L,2L,2L,4L,8L,8L,8L,10L,10L,10L,10L,16L,16L,20L,20L,22L,22L,22L,22L,24L,32L,32L,36L,38L,38L,38L,38L,44L,44L,44L,44L,54L,54L,54L,54L,56L,56L,56L,56L,58L,62L,62L,62L,68L,80L,88L,88L,90L,90L,94L,94L,96L,96L,96L,96L,98L,98L,98L,102L,116L,116L,116L,116L,118L,118L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132189Inst : IEnumerable<long>
{
public static readonly long[] Value=A132189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132189.Bytes);
public long this[int i]=>Value[i];

public static A132189Inst Instance=new A132189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132190
{
public static readonly long[] Value={ 2L,4L,8L,10L,12L,14L,18L,20L,22L,26L,30L,34L,44L,46L,58L,66L,68L,70L,74L,76L,78L,84L,90L,96L,100L,106L,108L,110L,120L,128L,134L,140L,146L,152L,154L,156L,158L,162L,164L,168L,174L,184L,186L,188L,196L,200L,202L,210L,216L,228L,232L,238L,250L,252L,260L,262L,264L,268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132190Inst : IEnumerable<long>
{
public static readonly long[] Value=A132190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132190.Bytes);
public long this[int i]=>Value[i];

public static A132190Inst Instance=new A132190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132191
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,1L,6L,9L,4L,1L,12L,18L,16L,5L,1L,12L,54L,40L,25L,6L,1L,40L,72L,160L,75L,36L,7L,1L,28L,405L,280L,375L,126L,49L,8L,1L,96L,390L,2176L,825L,756L,196L,64L,9L,1L,104L,1944L,2800L,8125L,2016L,1372L,288L,81L,10L,1L,280L,3411L,17920L,13175L,23976L,4312L,2304L,405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132191Inst : IEnumerable<long>
{
public static readonly long[] Value=A132191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132191.Bytes);
public long this[int i]=>Value[i];

public static A132191Inst Instance=new A132191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132192
{
public static readonly long[] Value={ 1L,1L,4L,3L,10L,7L,16L,36L,45L,3L,136L,45L,564L,19L,350L,1201L,197L,3547L,2020L,870L,2322L,4488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132192Inst : IEnumerable<long>
{
public static readonly long[] Value=A132192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132192.Bytes);
public long this[int i]=>Value[i];

public static A132192Inst Instance=new A132192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132193
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,9L,4L,6L,8L,10L,16L,5L,7L,9L,11L,13L,17L,25L,6L,8L,10L,12L,14L,18L,20L,26L,36L,7L,9L,11L,13L,15L,17L,19L,21L,25L,27L,29L,37L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132193Inst : IEnumerable<long>
{
public static readonly long[] Value=A132193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132193.Bytes);
public long this[int i]=>Value[i];

public static A132193Inst Instance=new A132193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132194
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132194Inst : IEnumerable<long>
{
public static readonly long[] Value=A132194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132194.Bytes);
public long this[int i]=>Value[i];

public static A132194Inst Instance=new A132194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132195
{
public static readonly long[] Value={ 1L,7L,12L,23L,47L,84L,172L,335L,590L,1000L,1858L,3284L,6083L,10816L,19539L,35586L,65309L,120625L,224763L,420658L,790885L,1494738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132195Inst : IEnumerable<long>
{
public static readonly long[] Value=A132195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132195.Bytes);
public long this[int i]=>Value[i];

public static A132195Inst Instance=new A132195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132196
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,6L,7L,11L,8L,12L,9L,13L,10L,14L,15L,23L,16L,24L,17L,25L,18L,26L,19L,27L,20L,28L,21L,29L,22L,30L,31L,47L,32L,48L,33L,49L,34L,50L,35L,51L,36L,52L,37L,53L,38L,54L,39L,55L,40L,56L,41L,57L,42L,58L,43L,59L,44L,60L,45L,61L,46L,62L,63L,95L,64L,96L,65L,97L,66L,98L,67L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132196Inst : IEnumerable<long>
{
public static readonly long[] Value=A132196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132196.Bytes);
public long this[int i]=>Value[i];

public static A132196Inst Instance=new A132196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132197
{
public static readonly long[] Value={ 1L,3L,3L,3L,7L,7L,7L,7L,7L,7L,7L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,31L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132197Inst : IEnumerable<long>
{
public static readonly long[] Value=A132197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132197.Bytes);
public long this[int i]=>Value[i];

public static A132197Inst Instance=new A132197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132198
{
public static readonly BigInteger[] Value={ 2L,5L,17L,257L,65537L,4294967311L,BigInteger.Parse("18446744073709551629"),BigInteger.Parse("340282366920938463463374607431768211507"),BigInteger.Parse("115792089237316195423570985008687907853269984665640564039457584007913129640233") };
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
public class A132198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132198Inst Instance=new A132198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132199
{
public static readonly long[] Value={ 1L,1L,1L,5L,3L,1L,1L,1L,1L,11L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,23L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,47L,3L,1L,5L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,101L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132199Inst : IEnumerable<long>
{
public static readonly long[] Value=A132199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132199.Bytes);
public long this[int i]=>Value[i];

public static A132199Inst Instance=new A132199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132216
{
public static readonly BigInteger[] Value={ 815730977L,124097929967680577L,6115597639891380737L,BigInteger.Parse("144086718355753024097"),BigInteger.Parse("524320466699664691937"),BigInteger.Parse("3377940044732998170977"),BigInteger.Parse("10094089678769799935777"),BigInteger.Parse("30706777728209453204417"),BigInteger.Parse("58310148000746221725857") };
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
public class A132216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132216Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132216.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132216Inst Instance=new A132216Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132217
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,4L,6L,8L,11L,15L,19L,25L,33L,42L,53L,68L,86L,107L,134L,166L,205L,253L,309L,377L,460L,557L,672L,811L,974L,1166L,1394L,1661L,1975L,2344L,2773L,3275L,3863L,4543L,5333L,6253L,7316L,8544L,9964L,11600L,13484L,15653L,18140L,20994L,24269L,28011L,32288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132217Inst : IEnumerable<long>
{
public static readonly long[] Value=A132217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132217.Bytes);
public long this[int i]=>Value[i];

public static A132217Inst Instance=new A132217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132218
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,20L,32L,50L,76L,113L,166L,240L,342L,482L,672L,928L,1270L,1724L,2323L,3108L,4132L,5460L,7174L,9376L,12192L,15780L,20332L,26086L,33334L,42432L,53817L,68018L,85680L,107584L,134674L,168092L,209210L,259680L,321484L,396996L,489056L,601052L,737024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132218Inst : IEnumerable<long>
{
public static readonly long[] Value=A132218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132218.Bytes);
public long this[int i]=>Value[i];

public static A132218Inst Instance=new A132218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132219
{
public static readonly BigInteger[] Value={ 1L,2L,8L,66L,774L,11885L,230858L,5512821L,157926273L,5323010347L,207833183972L,9280406921629L,468879370270319L,26561064972285450L,1673867356632729422L,BigInteger.Parse("116555375609273658636"),BigInteger.Parse("8914259769349445083676"),BigInteger.Parse("744876885721366948399627") };
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
public class A132219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132219Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132219.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132219Inst Instance=new A132219Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132220
{
public static readonly long[] Value={ 1L,2L,4L,10L,24L,63L,166L,471L,1408L,4436L,14719L,51468L,188754L,725010L,2907576L,12141462L,52654529L,236584104L,1098926868L,5266708497L,25997964452L,131975740172L,688019138485L,3678898458587L,20153878941460L,113000861804642L,647866385202660L,3794917399892511L,22693153274994534L,138436809489370914L,860962282687080614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132220Inst : IEnumerable<long>
{
public static readonly long[] Value=A132220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132220.Bytes);
public long this[int i]=>Value[i];

public static A132220Inst Instance=new A132220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132221
{
public static readonly long[] Value={ 0L,0L,0L,3L,0L,12L,0L,43L,23L,36L,0L,295L,0L,59L,98L,1932L,0L,979L,0L,1113L,155L,55L,0L,24995L,183L,89L,2377L,1840L,0L,5708L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132221Inst : IEnumerable<long>
{
public static readonly long[] Value=A132221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132221.Bytes);
public long this[int i]=>Value[i];

public static A132221Inst Instance=new A132221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132222
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,15L,19L,21L,25L,29L,31L,35L,37L,41L,43L,47L,51L,53L,57L,59L,63L,65L,69L,73L,75L,79L,81L,85L,87L,91L,95L,97L,101L,103L,107L,109L,113L,117L,119L,123L,125L,129L,131L,135L,139L,141L,145L,147L,151L,153L,157L,161L,163L,167L,169L,173L,175L,179L,183L,185L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132222Inst : IEnumerable<long>
{
public static readonly long[] Value=A132222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132222.Bytes);
public long this[int i]=>Value[i];

public static A132222Inst Instance=new A132222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132223
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,3L,1L,8L,4L,7L,2L,6L,3L,5L,1L,16L,8L,15L,4L,14L,7L,13L,2L,12L,6L,11L,3L,10L,5L,9L,1L,32L,16L,31L,8L,30L,15L,29L,4L,28L,14L,27L,7L,26L,13L,25L,2L,24L,12L,23L,6L,22L,11L,21L,3L,20L,10L,19L,5L,18L,9L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132223Inst : IEnumerable<long>
{
public static readonly long[] Value=A132223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132223.Bytes);
public long this[int i]=>Value[i];

public static A132223Inst Instance=new A132223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132224
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,4L,2L,3L,1L,4L,2L,3L,5L,1L,4L,2L,6L,3L,5L,1L,4L,7L,2L,6L,3L,5L,1L,8L,4L,7L,2L,6L,3L,5L,1L,8L,4L,7L,2L,6L,3L,5L,9L,1L,8L,4L,7L,2L,6L,3L,5L,10L,9L,1L,8L,4L,7L,2L,6L,11L,3L,5L,10L,9L,1L,8L,4L,7L,2L,12L,6L,11L,3L,5L,10L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132224Inst : IEnumerable<long>
{
public static readonly long[] Value=A132224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132224.Bytes);
public long this[int i]=>Value[i];

public static A132224Inst Instance=new A132224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132225
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-2L,2L,-2L,1L,2L,-3L,4L,-4L,1L,2L,-5L,8L,-7L,3L,2L,-10L,14L,-12L,6L,6L,-17L,22L,-20L,8L,10L,-26L,35L,-31L,12L,14L,-39L,54L,-47L,20L,20L,-61L,82L,-72L,31L,32L,-93L,122L,-107L,44L,50L,-133L,176L,-154L,61L,68L,-189L,254L,-220L,90L,94L,-272L,362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132225Inst : IEnumerable<long>
{
public static readonly long[] Value=A132225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132225.Bytes);
public long this[int i]=>Value[i];

public static A132225Inst Instance=new A132225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132226
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,4L,3L,2L,9L,8L,7L,6L,5L,4L,3L,2L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,65L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132226Inst : IEnumerable<long>
{
public static readonly long[] Value=A132226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132226.Bytes);
public long this[int i]=>Value[i];

public static A132226Inst Instance=new A132226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132227
{
public static readonly long[] Value={ 1L,4L,10L,16L,28L,34L,46L,52L,64L,82L,88L,106L,118L,124L,136L,154L,172L,178L,196L,208L,214L,232L,244L,262L,286L,298L,304L,316L,322L,334L,376L,388L,406L,412L,442L,448L,466L,484L,496L,514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132227Inst : IEnumerable<long>
{
public static readonly long[] Value=A132227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132227.Bytes);
public long this[int i]=>Value[i];

public static A132227Inst Instance=new A132227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132228
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,52L,504L,6808L,122304L,2820048L,81183200L,2853990496L,120321094656L,5991955466560L,347996920977664L,23312947041336960L,1784445116557881344L,BigInteger.Parse("154767015393810489600"),BigInteger.Parse("15098457734490931766784") };
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
public class A132228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132228Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132228.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132228Inst Instance=new A132228Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132229
{
public static readonly long[] Value={ 2L,5L,6L,8L,13L,14L,15L,16L,18L,19L,20L,21L,22L,27L,28L,31L,35L,36L,39L,40L,45L,46L,49L,53L,54L,59L,60L,63L,64L,65L,66L,67L,68L,69L,70L,72L,79L,80L,83L,84L,85L,86L,89L,90L,97L,101L,102L,107L,108L,113L,114L,117L,118L,119L,120L,127L,137L,138L,149L,150L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132229Inst : IEnumerable<long>
{
public static readonly long[] Value=A132229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132229.Bytes);
public long this[int i]=>Value[i];

public static A132229Inst Instance=new A132229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132230
{
public static readonly long[] Value={ 31L,61L,151L,181L,211L,241L,271L,331L,421L,541L,571L,601L,631L,661L,691L,751L,811L,991L,1021L,1051L,1171L,1201L,1231L,1291L,1321L,1381L,1471L,1531L,1621L,1741L,1801L,1831L,1861L,1951L,2011L,2131L,2161L,2221L,2251L,2281L,2311L,2341L,2371L,2521L,2551L,2671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132230Inst : IEnumerable<long>
{
public static readonly long[] Value=A132230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132230.Bytes);
public long this[int i]=>Value[i];

public static A132230Inst Instance=new A132230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132231
{
public static readonly long[] Value={ 7L,37L,67L,97L,127L,157L,277L,307L,337L,367L,397L,457L,487L,547L,577L,607L,727L,757L,787L,877L,907L,937L,967L,997L,1087L,1117L,1237L,1297L,1327L,1447L,1567L,1597L,1627L,1657L,1747L,1777L,1867L,1987L,2017L,2137L,2287L,2347L,2377L,2437L,2467L,2557L,2617L,2647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132231Inst : IEnumerable<long>
{
public static readonly long[] Value=A132231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132231.Bytes);
public long this[int i]=>Value[i];

public static A132231Inst Instance=new A132231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132296
{
public static readonly long[] Value={ 0L,2L,5L,9L,14L,20L,27L,27L,36L,46L,57L,69L,82L,96L,111L,127L,144L,162L,181L,201L,222L,244L,267L,291L,316L,342L,342L,370L,399L,429L,460L,492L,525L,559L,594L,630L,667L,705L,744L,784L,825L,867L,910L,954L,999L,1045L,1092L,1140L,1189L,1239L,1290L,1342L,1395L,1449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132296Inst : IEnumerable<long>
{
public static readonly long[] Value=A132296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132296.Bytes);
public long this[int i]=>Value[i];

public static A132296Inst Instance=new A132296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132297
{
public static readonly long[] Value={ 4L,7L,12L,18L,26L,35L,46L,58L,72L,87L,104L,122L,142L,163L,186L,210L,236L,263L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132297Inst : IEnumerable<long>
{
public static readonly long[] Value=A132297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132297.Bytes);
public long this[int i]=>Value[i];

public static A132297Inst Instance=new A132297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132298
{
public static readonly long[] Value={ 8L,15L,28L,52L,92L,151L,240L,363L,532L,757L,1048L,1416L,1880L,2449L,3140L,3971L,4960L,6123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132298Inst : IEnumerable<long>
{
public static readonly long[] Value=A132298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132298.Bytes);
public long this[int i]=>Value[i];

public static A132298Inst Instance=new A132298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132299
{
public static readonly long[] Value={ 16L,31L,60L,118L,230L,436L,810L,1450L,2520L,4256L,6990L,11176L,17486L,26731L,40080L,58985L,85376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132299Inst : IEnumerable<long>
{
public static readonly long[] Value=A132299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132299.Bytes);
public long this[int i]=>Value[i];

public static A132299Inst Instance=new A132299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132300
{
public static readonly long[] Value={ 32L,63L,124L,246L,488L,966L,1900L,3686L,7086L,13400L,24982L,45847L,82906L,147605L,258652L,446184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132300Inst : IEnumerable<long>
{
public static readonly long[] Value=A132300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132300.Bytes);
public long this[int i]=>Value[i];

public static A132300Inst Instance=new A132300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132301
{
public static readonly long[] Value={ 1L,-3L,1L,3L,-1L,0L,1L,-6L,0L,6L,-3L,3L,4L,-12L,1L,12L,-6L,3L,5L,-24L,1L,24L,-10L,6L,11L,-42L,4L,42L,-19L,12L,17L,-72L,4L,69L,-31L,18L,31L,-120L,9L,114L,-50L,30L,46L,-189L,11L,180L,-79L,48L,77L,-294L,21L,276L,-122L,72L,112L,-450L,28L,420L,-183L,108L,173L,-672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132301Inst : IEnumerable<long>
{
public static readonly long[] Value=A132301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132301.Bytes);
public long this[int i]=>Value[i];

public static A132301Inst Instance=new A132301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132302
{
public static readonly long[] Value={ 1L,1L,3L,5L,10L,15L,26L,39L,63L,92L,140L,201L,295L,415L,591L,818L,1140L,1554L,2126L,2861L,3855L,5126L,6816L,8970L,11793L,15372L,20007L,25857L,33356L,42771L,54734L,69683L,88530L,111968L,141312L,177642L,222842L,278557L,347484L,432095L,536230L,663549L,819504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132302Inst : IEnumerable<long>
{
public static readonly long[] Value=A132302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132302.Bytes);
public long this[int i]=>Value[i];

public static A132302Inst Instance=new A132302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132303
{
public static readonly BigInteger[] Value={ 1L,3L,45L,831L,17181L,375903L,8530929L,198643455L,4714491357L,113550338127L,2767105469745L,68077260387315L,1688160321677025L,42142679453321307L,1058050429855640217L,BigInteger.Parse("26695057057648257231"),BigInteger.Parse("676431705046728704733") };
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
public class A132303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132303Inst Instance=new A132303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132304
{
public static readonly BigInteger[] Value={ 1L,3L,115L,5157L,281907L,16688953L,1043460469L,67769148555L,4527813298227L,309207348577017L,21487099512128265L,1514508365575327455L,BigInteger.Parse("108015601963868232885"),BigInteger.Parse("7780760215720406500095"),BigInteger.Parse("565264860408377433558523") };
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
public class A132304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132304Inst Instance=new A132304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132305
{
public static readonly BigInteger[] Value={ 1L,3L,309L,32847L,4775301L,764206503L,131689759209L,23857704965727L,4487745064421061L,869024373004460823L,BigInteger.Parse("172218243516497425809"),BigInteger.Parse("34778752398142969125627"),BigInteger.Parse("7134304921516864247956281") };
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
public class A132305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132305Inst Instance=new A132305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132306
{
public static readonly long[] Value={ 1L,2L,18L,179L,1874L,20202L,221943L,2470827L,27777618L,314642708L,3585365618L,41054041602L,471980219543L,5444542749674L,62987391100239L,730515277512729L,8490829425196626L,98878672140171984L,1153433769999190212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132306Inst : IEnumerable<long>
{
public static readonly long[] Value=A132306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132306.Bytes);
public long this[int i]=>Value[i];

public static A132306Inst Instance=new A132306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132307
{
public static readonly long[] Value={ 1L,3L,1L,7L,7L,1L,15L,23L,11L,1L,31L,63L,47L,15L,1L,63L,159L,159L,79L,19L,1L,127L,383L,479L,319L,119L,23L,1L,255L,895L,1343L,1119L,559L,167L,27L,1L,511L,2047L,3583L,3583L,2239L,895L,223L,31L,1L,1023L,4607L,9215L,10751L,8063L,4031L,1343L,287L,35L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132307Inst : IEnumerable<long>
{
public static readonly long[] Value=A132307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132307.Bytes);
public long this[int i]=>Value[i];

public static A132307Inst Instance=new A132307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132308
{
public static readonly long[] Value={ 1L,4L,15L,50L,157L,480L,1451L,4366L,13113L,39356L,118087L,354282L,1062869L,3188632L,9565923L,28697798L,86093425L,258280308L,774840959L,2324522914L,6973568781L,20920706384L,62762119195L,188286357630L,564859072937L,1694577218860L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132308Inst : IEnumerable<long>
{
public static readonly long[] Value=A132308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132308.Bytes);
public long this[int i]=>Value[i];

public static A132308Inst Instance=new A132308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132309
{
public static readonly long[] Value={ 1L,2L,1L,2L,5L,1L,2L,5L,8L,1L,2L,9L,9L,11L,1L,2L,9L,24L,14L,14L,1L,2L,13L,25L,50L,20L,17L,1L,2L,13L,48L,55L,90L,27L,20L,1L,2L,17L,49L,133L,105L,147L,35L,23L,1L,2L,17L,80L,140L,308L,182L,224L,44L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132309Inst : IEnumerable<long>
{
public static readonly long[] Value=A132309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132309.Bytes);
public long this[int i]=>Value[i];

public static A132309Inst Instance=new A132309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132310
{
public static readonly long[] Value={ 1L,5L,21L,83L,319L,1209L,4551L,17085L,64125L,240995L,907741L,3428655L,12990121L,49370963L,188229489L,719805987L,2760498351L,10615101273L,40920439119L,158106581157L,612166272291L,2374756691313L,9228369037659L,35918537840577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132310Inst : IEnumerable<long>
{
public static readonly long[] Value=A132310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132310.Bytes);
public long this[int i]=>Value[i];

public static A132310Inst Instance=new A132310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132311
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,4L,7L,4L,1L,1L,6L,28L,28L,6L,1L,1L,11L,117L,318L,117L,11L,1L,1L,14L,388L,3344L,3344L,388L,14L,1L,1L,21L,1757L,71277L,290521L,71277L,1757L,21L,1L,1L,29L,8270L,2031198L,53679222L,53679222L,2031198L,8270L,29L,1L,1L,42L,40243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132311Inst : IEnumerable<long>
{
public static readonly long[] Value=A132311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132311.Bytes);
public long this[int i]=>Value[i];

public static A132311Inst Instance=new A132311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132360
{
public static readonly long[] Value={ 37L,96L,163L,264L,367L,498L,647L,804L,1037L,1294L,1557L,1828L,2111L,2404L,2711L,3022L,3369L,3722L,4101L,4490L,4891L,5300L,5721L,6154L,6615L,7078L,7545L,8036L,8559L,9100L,9647L,10204L,10781L,11368L,11961L,12568L,13181L,13798L,14417L,15048L,15695L,16348L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132360Inst : IEnumerable<long>
{
public static readonly long[] Value=A132360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132360.Bytes);
public long this[int i]=>Value[i];

public static A132360Inst Instance=new A132360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132361
{
public static readonly long[] Value={ 11L,7L,3L,2L,12L,8L,4L,3L,3L,4L,12L,8L,8L,3L,4L,12L,12L,9L,5L,1L,9L,1L,5L,12L,3L,4L,12L,8L,1L,5L,12L,9L,1L,5L,12L,9L,12L,9L,5L,1L,9L,1L,5L,12L,3L,4L,12L,8L,3L,4L,12L,8L,1L,5L,12L,9L,9L,1L,5L,12L,12L,9L,5L,1L,2L,11L,7L,3L,2L,2L,3L,11L,7L,7L,2L,3L,11L,7L,2L,3L,11L,2L,11L,7L,3L,2L,2L,3L,11L,7L,2L,3L,11L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132361Inst : IEnumerable<long>
{
public static readonly long[] Value=A132361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132361.Bytes);
public long this[int i]=>Value[i];

public static A132361Inst Instance=new A132361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132362
{
public static readonly long[] Value={ 0L,406L,120L,528L,105L,136L,1L,300L,435L,378L,171L,10L,66L,276L,496L,15L,91L,351L,595L,78L,153L,28L,210L,231L,3L,190L,55L,21L,465L,561L,630L,45L,36L,325L,253L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132362Inst : IEnumerable<long>
{
public static readonly long[] Value=A132362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132362.Bytes);
public long this[int i]=>Value[i];

public static A132362Inst Instance=new A132362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132363
{
public static readonly long[] Value={ 1L,0L,3L,11L,15L,13L,17L,21L,24L,23L,73L,3000L,101L,104L,103L,111L,115L,113L,117L,121L,124L,123L,173L,323L,373L,1101L,1104L,1103L,1111L,1115L,1113L,1117L,1121L,1124L,1123L,1173L,1323L,1373L,3323L,3373L,11373L,13323L,13373L,17373L,21373L,23323L,23373L,73373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132363Inst : IEnumerable<long>
{
public static readonly long[] Value=A132363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132363.Bytes);
public long this[int i]=>Value[i];

public static A132363Inst Instance=new A132363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132364
{
public static readonly long[] Value={ 1L,0L,1L,1L,3L,7L,20L,59L,184L,593L,1964L,6642L,22845L,79667L,281037L,1001092L,3595865L,13009673L,47366251L,173415176L,638044203L,2357941142L,8748646386L,32576869203L,121701491701L,456012458965L,1713339737086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132364Inst : IEnumerable<long>
{
public static readonly long[] Value=A132364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132364.Bytes);
public long this[int i]=>Value[i];

public static A132364Inst Instance=new A132364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132365
{
public static readonly long[] Value={ 1L,0L,2L,3L,13L,9L,4L,6L,7L,24L,5L,10L,15L,26L,20L,25L,49L,6L,11L,16L,13L,12L,10L,21L,45L,40L,20L,36L,7L,31L,50L,12L,35L,19L,17L,15L,41L,36L,22L,23L,39L,39L,14L,21L,41L,60L,8L,32L,19L,56L,20L,13L,45L,37L,51L,44L,17L,56L,42L,22L,25L,62L,35L,15L,71L,47L,25L,24L,43L,32L,17L,45L,49L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132365Inst : IEnumerable<long>
{
public static readonly long[] Value=A132365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132365.Bytes);
public long this[int i]=>Value[i];

public static A132365Inst Instance=new A132365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132366
{
public static readonly long[] Value={ 1L,6L,21L,56L,125L,246L,441L,736L,1161L,1750L,2541L,3576L,4901L,6566L,8625L,11136L,14161L,17766L,22021L,27000L,32781L,39446L,47081L,55776L,65625L,76726L,89181L,103096L,118581L,135750L,154721L,175616L,198561L,223686L,251125L,281016L,313501L,348726L,386841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132366Inst : IEnumerable<long>
{
public static readonly long[] Value=A132366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132366.Bytes);
public long this[int i]=>Value[i];

public static A132366Inst Instance=new A132366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132367
{
public static readonly long[] Value={ 1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L,1L,1L,2L,-1L,-1L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132367Inst : IEnumerable<long>
{
public static readonly long[] Value=A132367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132367.Bytes);
public long this[int i]=>Value[i];

public static A132367Inst Instance=new A132367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132368
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,4L,5L,7L,8L,9L,10L,11L,14L,12L,13L,15L,16L,17L,18L,19L,22L,20L,21L,23L,24L,25L,26L,27L,30L,28L,29L,31L,32L,33L,34L,35L,38L,36L,37L,39L,40L,41L,42L,43L,46L,44L,45L,47L,48L,49L,50L,51L,54L,52L,53L,55L,56L,57L,58L,59L,62L,60L,61L,63L,64L,65L,66L,67L,70L,68L,69L,71L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132368Inst : IEnumerable<long>
{
public static readonly long[] Value=A132368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132368.Bytes);
public long this[int i]=>Value[i];

public static A132368Inst Instance=new A132368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132369
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,24L,24L,24L,24L,120L,120L,720L,720L,720L,720L,5040L,5040L,40320L,40320L,40320L,40320L,362880L,362880L,362880L,362880L,362880L,362880L,3628800L,3628800L,39916800L,39916800L,39916800L,39916800L,39916800L,39916800L,479001600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132369Inst : IEnumerable<long>
{
public static readonly long[] Value=A132369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132369.Bytes);
public long this[int i]=>Value[i];

public static A132369Inst Instance=new A132369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132370
{
public static readonly long[] Value={ 16L,34L,34L,58L,68L,58L,88L,112L,112L,88L,124L,166L,180L,166L,124L,166L,230L,262L,262L,230L,166L,214L,304L,358L,376L,358L,304L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132370Inst : IEnumerable<long>
{
public static readonly long[] Value=A132370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132370.Bytes);
public long this[int i]=>Value[i];

public static A132370Inst Instance=new A132370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132371
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,87L,567L,4167L,34407L,316647L,3219687L,35878887L,435046887L,5704064487L,80428314087L,1213746099687L,19521187251687L,333363035571687L,6024361885107687L,114864714882483687L,2304476522241459687L,BigInteger.Parse("48529614677597619687"),BigInteger.Parse("1070348458111786419687") };
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
public class A132371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A132371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A132371Inst Instance=new A132371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132372
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,6L,10L,5L,1L,22L,38L,22L,7L,1L,90L,158L,98L,38L,9L,1L,394L,698L,450L,194L,58L,11L,1L,1806L,3218L,2126L,978L,334L,82L,13L,1L,8558L,15310L,10286L,4942L,1838L,526L,110L,15L,1L,41586L,74614L,50746L,25150L,9922L,3142L,778L,142L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132372Inst : IEnumerable<long>
{
public static readonly long[] Value=A132372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132372.Bytes);
public long this[int i]=>Value[i];

public static A132372Inst Instance=new A132372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132373
{
public static readonly long[] Value={ 1L,1L,7L,13L,91L,205L,1435L,3565L,24955L,65821L,460747L,1265677L,8859739L,25066621L,175466347L,507709165L,3553964155L,10466643805L,73266506635L,218878998733L,1532152991131L,4631531585341L,32420721097387L,98980721277613L,692865048943291L,2133274258946845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132373Inst : IEnumerable<long>
{
public static readonly long[] Value=A132373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132373.Bytes);
public long this[int i]=>Value[i];

public static A132373Inst Instance=new A132373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132374
{
public static readonly long[] Value={ 1L,1L,8L,15L,120L,274L,2192L,5531L,44248L,118686L,949488L,2654646L,21237168L,61189668L,489517344L,1443039123L,11544312984L,34648845862L,277190766896L,844131474530L,6753051796240L,20813234394492L,166505875155936L,518373091849502L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132374Inst : IEnumerable<long>
{
public static readonly long[] Value=A132374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132374.Bytes);
public long this[int i]=>Value[i];

public static A132374Inst Instance=new A132374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132375
{
public static readonly long[] Value={ 1L,1L,9L,17L,153L,353L,3177L,8113L,73017L,198401L,1785609L,5060433L,45543897L,133071009L,1197639081L,3581326065L,32231934585L,98156060225L,883404542025L,2730108129937L,24570973169433L,76862217117665L,691759954058985L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132375Inst : IEnumerable<long>
{
public static readonly long[] Value=A132375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132375.Bytes);
public long this[int i]=>Value[i];

public static A132375Inst Instance=new A132375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132408
{
public static readonly long[] Value={ 3L,2L,3L,4L,6L,12L,23L,47L,101L,221L,495L,1131L,2618L,6136L,14529L,34712L,83582L,202655L,494411L,1212913L,2990512L,7406845L,18421179L,45988060L,115207839L,289540843L,729832978L,1844715644L,4674594884L,11873860647L,30227731182L,77112265804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132408Inst : IEnumerable<long>
{
public static readonly long[] Value=A132408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132408.Bytes);
public long this[int i]=>Value[i];

public static A132408Inst Instance=new A132408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132409
{
public static readonly long[] Value={ 3L,1L,1L,1L,2L,2L,4L,6L,12L,23L,45L,95L,202L,439L,969L,2170L,4917L,11259L,26022L,60646L,142406L,336675L,800921L,1916170L,4608314L,11136187L,27030852L,65882702L,161192928L,395795355L,975088103L,2409758307L,5972774016L,14844843847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132409Inst : IEnumerable<long>
{
public static readonly long[] Value=A132409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132409.Bytes);
public long this[int i]=>Value[i];

public static A132409Inst Instance=new A132409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132410
{
public static readonly long[] Value={ 1141L,1645L,1757L,2009L,2023L,2471L,3073L,3773L,3983L,4445L,4543L,4781L,4837L,4865L,4879L,4963L,5075L,5089L,5159L,5173L,5327L,5327L,5411L,5537L,5537L,5551L,5761L,5789L,5887L,6013L,6041L,6041L,6083L,6097L,6293L,6377L,6419L,6629L,6713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132410Inst : IEnumerable<long>
{
public static readonly long[] Value=A132410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132410.Bytes);
public long this[int i]=>Value[i];

public static A132410Inst Instance=new A132410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132411
{
public static readonly long[] Value={ 0L,1L,3L,8L,15L,24L,35L,48L,63L,80L,99L,120L,143L,168L,195L,224L,255L,288L,323L,360L,399L,440L,483L,528L,575L,624L,675L,728L,783L,840L,899L,960L,1023L,1088L,1155L,1224L,1295L,1368L,1443L,1520L,1599L,1680L,1763L,1848L,1935L,2024L,2115L,2208L,2303L,2400L,2499L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132411Inst : IEnumerable<long>
{
public static readonly long[] Value=A132411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132411.Bytes);
public long this[int i]=>Value[i];

public static A132411Inst Instance=new A132411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132412
{
public static readonly long[] Value={ 2L,29L,180L,873L,3710L,14523L,53735L,190781L,656349L,2202646L,7244771L,23436689L,74767863L,235710439L,735528908L,2274844293L,6980781345L,21273830000L,64432110647L,194066078163L,581597738907L,1735097817527L,5155001023065L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132412Inst : IEnumerable<long>
{
public static readonly long[] Value=A132412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132412.Bytes);
public long this[int i]=>Value[i];

public static A132412Inst Instance=new A132412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132413
{
public static readonly long[] Value={ 3L,30L,181L,874L,3711L,14524L,53736L,190782L,656350L,2202647L,7244772L,23436690L,74767864L,235710440L,735528909L,2274844294L,6980781346L,21273830001L,64432110648L,194066078164L,581597738908L,1735097817528L,5155001023066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132413Inst : IEnumerable<long>
{
public static readonly long[] Value=A132413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132413.Bytes);
public long this[int i]=>Value[i];

public static A132413Inst Instance=new A132413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132414
{
public static readonly long[] Value={ -1L,0L,3L,4L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132414Inst : IEnumerable<long>
{
public static readonly long[] Value=A132414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132414.Bytes);
public long this[int i]=>Value[i];

public static A132414Inst Instance=new A132414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132415
{
public static readonly long[] Value={ 25L,26L,29L,30L,41L,45L,46L,49L,50L,53L,54L,61L,62L,66L,69L,70L,75L,77L,79L,81L,82L,84L,85L,86L,87L,89L,91L,93L,94L,95L,98L,99L,100L,102L,103L,104L,107L,109L,110L,113L,116L,118L,119L,123L,125L,129L,131L,133L,136L,137L,140L,142L,143L,144L,145L,148L,149L,151L,152L,154L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132415Inst : IEnumerable<long>
{
public static readonly long[] Value=A132415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132415.Bytes);
public long this[int i]=>Value[i];

public static A132415Inst Instance=new A132415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132416
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,25L,32L,36L,64L,125L,216L,243L,512L,625L,729L,1024L,1296L,3125L,7776L,8192L,15625L,16384L,16807L,19683L,32768L,46656L,59049L,78125L,131072L,262144L,279936L,390625L,1594323L,1679616L,1953125L,2097152L,4194304L,4782969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132416Inst : IEnumerable<long>
{
public static readonly long[] Value=A132416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132416.Bytes);
public long this[int i]=>Value[i];

public static A132416Inst Instance=new A132416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A132417
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,254L,258L,262L,266L,270L,274L,278L,282L,286L,290L,294L,298L,302L,306L,310L,314L,382L,386L,390L,394L,398L,402L,406L,410L,414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A132417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A132417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A132417Inst : IEnumerable<long>
{
public static readonly long[] Value=A132417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A132417.Bytes);
public long this[int i]=>Value[i];

public static A132417Inst Instance=new A132417Inst();

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