using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A160264
{
public static readonly long[] Value={ 11L,1481L,1861L,5641L,88801L,165701L,266671L,284731L,326141L,402751L,626611L,661091L,855721L,959461L,1022501L,1068241L,1068701L,1118851L,1146781L,1155601L,1246361L,1461401L,1573921L,1830331L,1917731L,2674531L,2683771L,3058871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160264Inst : IEnumerable<long>
{
public static readonly long[] Value=A160264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160264.Bytes);
public long this[int i]=>Value[i];

public static A160264Inst Instance=new A160264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160265
{
public static readonly long[] Value={ 1L,11L,12L,1121L,1321L,123121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160265Inst : IEnumerable<long>
{
public static readonly long[] Value=A160265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160265.Bytes);
public long this[int i]=>Value[i];

public static A160265Inst Instance=new A160265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160266
{
public static readonly long[] Value={ 2L,1L,1L,2L,4L,2L,1L,1L,6L,1L,2L,1L,1L,5L,1L,1L,1L,6L,1L,4L,3L,1L,2L,1L,1L,2L,1L,1L,10L,5L,1L,1L,8L,1L,1L,1L,1L,1L,2L,1L,40L,1L,1L,1L,1L,1L,6L,3L,1L,7L,17L,1L,36L,1L,1L,2L,1L,1L,1L,20L,1L,1L,1L,1L,8L,1L,1L,18L,13L,1L,5L,1L,2L,6L,1L,1L,1L,1L,1L,1L,6L,1L,9L,11L,2L,9L,1L,2L,9L,4L,6L,1L,1L,1L,9L,7L,1L,7L,29L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160266Inst : IEnumerable<long>
{
public static readonly long[] Value=A160266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160266.Bytes);
public long this[int i]=>Value[i];

public static A160266Inst Instance=new A160266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160267
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,2L,1L,1L,1L,1L,1L,4L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,5L,1L,1L,1L,17L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L,1L,4L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,1L,9L,1L,2L,1L,1L,1L,2L,1L,3L,1L,1L,1L,8L,1L,1L,1L,5L,1L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160267Inst : IEnumerable<long>
{
public static readonly long[] Value=A160267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160267.Bytes);
public long this[int i]=>Value[i];

public static A160267Inst Instance=new A160267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160268
{
public static readonly long[] Value={ 11L,23L,37L,41L,43L,59L,61L,79L,83L,97L,103L,107L,113L,121L,139L,143L,147L,149L,163L,167L,169L,171L,173L,177L,181L,183L,191L,193L,199L,201L,203L,227L,237L,243L,249L,251L,263L,271L,283L,287L,289L,293L,303L,313L,317L,321L,323L,347L,351L,353L,355L,359L,363L,367L,373L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160268Inst : IEnumerable<long>
{
public static readonly long[] Value=A160268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160268.Bytes);
public long this[int i]=>Value[i];

public static A160268Inst Instance=new A160268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160269
{
public static readonly BigInteger[] Value={ 1L,30L,-782L,-124380L,214572L,843265800L,23493423480L,-7805435749200L,-510774640529520L,89706704225349600L,10423307635096361760UL,BigInteger.Parse("-1196167536017489419200"),BigInteger.Parse("-228737063945077567859520"),BigInteger.Parse("17281333628624679401347200"),BigInteger.Parse("5520004649081806480856680320") };
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
public class A160269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160269Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160269.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160269Inst Instance=new A160269Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160270
{
public static readonly BigInteger[] Value={ 1L,32L,-658L,-128704L,-798260L,840376192L,33605404744L,-7405703577856L,-632652549947248L,79406265745318400L,12118094804951629024UL,BigInteger.Parse("-947834356077803359232"),BigInteger.Parse("-254539689475704747697472"),BigInteger.Parse("10985818579851831076419584"),BigInteger.Parse("5917311044631018607598349440") };
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
public class A160270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160270Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160270.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160270Inst Instance=new A160270Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160271
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,1L,2L,0L,2L,1L,4L,1L,3L,2L,2L,3L,0L,3L,3L,4L,3L,5L,1L,4L,4L,6L,6L,5L,4L,0L,4L,4L,7L,9L,10L,8L,6L,1L,5L,5L,8L,11L,15L,16L,13L,3L,0L,5L,5L,9L,12L,18L,24L,26L,21L,5L,2L,6L,6L,10L,14L,20L,29L,39L,42L,34L,7L,1L,5L,6L,11L,15L,23L,32L,47L,63L,68L,55L,4L,0L,6L,7L,12L,17L,25L,37L,52L,76L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160271Inst : IEnumerable<long>
{
public static readonly long[] Value=A160271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160271.Bytes);
public long this[int i]=>Value[i];

public static A160271Inst Instance=new A160271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160272
{
public static readonly long[] Value={ 0L,11L,22L,27L,16L,5L,6L,17L,28L,21L,10L,1L,12L,23L,26L,15L,4L,7L,18L,29L,20L,9L,2L,13L,24L,25L,14L,3L,8L,19L,30L,19L,8L,3L,14L,25L,24L,13L,2L,9L,20L,29L,18L,7L,4L,15L,26L,23L,12L,1L,10L,21L,28L,17L,6L,5L,16L,27L,22L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160272Inst : IEnumerable<long>
{
public static readonly long[] Value=A160272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160272.Bytes);
public long this[int i]=>Value[i];

public static A160272Inst Instance=new A160272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160273
{
public static readonly long[] Value={ 1L,1L,2L,2L,3L,2L,5L,1L,5L,2L,5L,2L,1L,5L,2L,5L,2L,5L,6L,12L,2L,5L,10L,8L,5L,3L,4L,3L,25L,2L,1L,5L,4L,23L,2L,3L,2L,5L,10L,13L,8L,2L,2L,3L,18L,4L,5L,1L,20L,2L,8L,5L,4L,11L,14L,1L,9L,3L,8L,5L,9L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160273Inst : IEnumerable<long>
{
public static readonly long[] Value=A160273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160273.Bytes);
public long this[int i]=>Value[i];

public static A160273Inst Instance=new A160273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160274
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,360L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160274Inst : IEnumerable<long>
{
public static readonly long[] Value=A160274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160274.Bytes);
public long this[int i]=>Value[i];

public static A160274Inst Instance=new A160274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160275
{
public static readonly BigInteger[] Value={ 1L,5L,15L,15L,30L,210L,1050L,6300L,1045800L,13756453200L,67826316310678800L,BigInteger.Parse("8622353329220210792550912000"),BigInteger.Parse("92206830102396929163916671718833533307592704000") };
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
public class A160275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160275Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160275.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160275Inst Instance=new A160275Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160276
{
public static readonly BigInteger[] Value={ 5L,3L,1L,2L,7L,5L,6L,166L,13154L,4930509L,127124010240L,10693928511363374992UL,BigInteger.Parse("137968261463122599313575510368212"),BigInteger.Parse("39152821738115568671532031705958771665111819590244323355597268791") };
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
public class A160276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160276Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160276.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160276Inst Instance=new A160276Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160277
{
public static readonly BigInteger[] Value={ 1L,3L,6L,8L,11L,23L,51L,123L,1451L,165876L,368310548L,131319102413076L,BigInteger.Parse("429434116256258636749076"),BigInteger.Parse("5044128476605888967010031050325156534548"),BigInteger.Parse("998085332225053172931293515663565518940387354129475684145085443611977451") };
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
public class A160277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160277Inst Instance=new A160277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160278
{
public static readonly long[] Value={ 0L,66L,132L,162L,96L,30L,36L,102L,168L,126L,60L,6L,72L,138L,156L,90L,24L,42L,108L,174L,120L,54L,12L,78L,144L,150L,84L,18L,48L,114L,180L,114L,48L,18L,84L,150L,144L,78L,12L,54L,120L,174L,108L,42L,24L,90L,156L,138L,72L,6L,60L,126L,168L,102L,36L,30L,96L,162L,132L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160278Inst : IEnumerable<long>
{
public static readonly long[] Value=A160278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160278.Bytes);
public long this[int i]=>Value[i];

public static A160278Inst Instance=new A160278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160279
{
public static readonly BigInteger[] Value={ 1L,34L,-526L,-132260L,-1842644L,827195384L,43621279096L,-6864932326064L,-747004639162480L,66976371647992864L,13585352863673379616UL,BigInteger.Parse("-664640573754345065536"),BigInteger.Parse("-273953978191332601883456"),BigInteger.Parse("4100670082152392338741120"),BigInteger.Parse("6129700469924860012300846976") };
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
public class A160279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160279Inst Instance=new A160279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160280
{
public static readonly BigInteger[] Value={ 1L,36L,-386L,-135000L,-2912244L,803439216L,53415783816L,-6185340350496L,-851589691267440L,52572710870646336L,14783982337749774816UL,BigInteger.Parse("-352049632685279478144"),BigInteger.Parse("-286207027989716394858816"),BigInteger.Parse("-3197683221510109228058880"),BigInteger.Parse("6143086278048774757772750976") };
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
public class A160280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160280Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160280.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160280Inst Instance=new A160280Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160281
{
public static readonly BigInteger[] Value={ 1L,38L,-238L,-136876L,-4000340L,768888808L,62860634104L,-5370921754384L,-944216132607088L,36390910087921760L,15676398398747125024UL,BigInteger.Parse("-16391968526453252288"),BigInteger.Parse("-290667617977624530780992"),BigInteger.Parse("-10714513990411799725496704"),BigInteger.Parse("5948586603063089600488296320") };
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
public class A160281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160281Inst Instance=new A160281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160282
{
public static readonly BigInteger[] Value={ 1L,40L,-82L,-137840L,-5099828L,723394400L,71825329480L,-4427483105600L,-1022770753521520L,18665382528092800L,16229318967932481760UL,BigInteger.Parse("335221024594778374400"),BigInteger.Parse("-286866018560895642547520"),BigInteger.Parse("-18240741902856832410790400"),BigInteger.Parse("5542982685738270823512456320") };
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
public class A160282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160282Inst Instance=new A160282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160283
{
public static readonly BigInteger[] Value={ 1L,42L,82L,-137844L,-6203220L,666879192L,80178006264L,-3362668542576L,-1085247924540528L,-332344921799520L,16414524594978933024UL,BigInteger.Parse("695000074573783113408"),BigInteger.Parse("-274511530924201328046912"),BigInteger.Parse("-25557365804013694138997376"),BigInteger.Parse("4929059771420011085235888000") };
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
public class A160283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160283Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160283.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160283Inst Instance=new A160283Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160284
{
public static readonly BigInteger[] Value={ 1L,44L,254L,-136840L,-7302644L,599343184L,87786336136L,-2185972622944L,-1129779117074800L,-20295833536956736L,16209579598652226016UL,BigInteger.Parse("1054597422432310244224"),BigInteger.Parse("-253507355147241835002176"),BigInteger.Parse("-32440318000852390709512960"),BigInteger.Parse("4115817835612084772939010176") };
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
public class A160284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160284Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160284.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160284Inst Instance=new A160284Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160285
{
public static readonly BigInteger[] Value={ 1L,46L,434L,-134780L,-8389844L,520867016L,94518470776L,-908740269776L,-1154662527326320L,-40886467186904864L,15598503848068208416UL,BigInteger.Parse("1405241555094877399616"),BigInteger.Parse("-223962406662593631730496"),BigInteger.Parse("-38665666254514312493452160"),BigInteger.Parse("3118541336376613976720226176") };
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
public class A160285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160285Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160285.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160285Inst Instance=new A160285Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160286
{
public static readonly BigInteger[] Value={ 1L,48L,622L,-131616L,-9456180L,431615808L,100244032584L,455846829696L,-1158392591818608L,-61736719347682560L,14572384526261325024UL,BigInteger.Parse("1737886076688564260352"),BigInteger.Parse("-186199726823835951097152"),BigInteger.Parse("-44015079459426106683608064"),BigInteger.Parse("1958719412677543785877138560") };
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
public class A160286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160286Inst Instance=new A160286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160287
{
public static readonly BigInteger[] Value={ 1L,50L,818L,-127300L,-10492628L,331843000L,104835151480L,1892798018000L,-1139689172625520L,-82453948761484000L,13129917257130921760UL,BigInteger.Parse("2043371281024706968000"),BigInteger.Parse("-140761165040200966003520"),BigInteger.Parse("-48281464188212733742288000"),BigInteger.Parse("663810425358397635518568320") };
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
public class A160287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160287Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160287.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160287Inst Instance=new A160287Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160288
{
public static readonly BigInteger[] Value={ 1L,52L,1022L,-121784L,-11489780L,221894192L,108167547784L,3385356299104L,-1097526180055408L,-102624715723624640L,11277866096050285024UL,BigInteger.Parse("2312596755465981266048"),BigInteger.Parse("-88408047224891347679552"),BigInteger.Parse("-51274671368019715953249536"),BigInteger.Parse("-733152550517551021207891840") };
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
public class A160288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160288Inst Instance=new A160288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160289
{
public static readonly BigInteger[] Value={ 1L,54L,1234L,-115020L,-12437844L,102210984L,110121661176L,4915056452976L,-1031159390225520L,-121819606703423136L,9031432087249072416L,BigInteger.Parse("2536703117463027057984"),BigInteger.Parse("-30117588135278876709696"),BigInteger.Parse("-52827165482178797480672640"),BigInteger.Parse("-2194115753871647145822109824") };
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
public class A160289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160289Inst Instance=new A160289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160290
{
public static readonly BigInteger[] Value={ 1L,56L,1454L,-106960L,-13326644L,-26665184L,110583825736L,6461799278144L,-940153204639600L,-139598550546523264L,6414520381228962016L,BigInteger.Parse("2707260761541343173376"),BigInteger.Parse("32925146552816962489024"),BigInteger.Parse("-52799543003992720712035840"),BigInteger.Parse("-3676715662747488061659005824") };
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
public class A160290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160290Inst Instance=new A160290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160291
{
public static readonly BigInteger[] Value={ 1L,1L,-449L,-1349L,604801L,3033001L,-1357769249L,-9546871949L,4267426262401L,38636165278801L,-17244440197445249L,-191107183952049749L,BigInteger.Parse("85168871793401932801"),BigInteger.Parse("1117147665134470577401"),BigInteger.Parse("-497120752326266836308449"),BigInteger.Parse("-7535151042673431473934749"),BigInteger.Parse("3348029927159627713608096001") };
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
public class A160291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160291Inst Instance=new A160291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160292
{
public static readonly BigInteger[] Value={ 1L,7L,-401L,-9107L,477601L,19735807L,-936451601L,-59841840107L,2530929662401L,233147132022007L,-8618235208570001L,-1109489740559021507L,BigInteger.Parse("34893836098508354401"),BigInteger.Parse("6235501451708274618607"),BigInteger.Parse("-160480431014315950915601"),BigInteger.Parse("-40407022162862341753633307"),BigInteger.Parse("800393754206596276404873601") };
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
public class A160292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160292Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160292.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160292Inst Instance=new A160292Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160293
{
public static readonly BigInteger[] Value={ 1L,11L,-329L,-13519L,295441L,27584051L,-361317689L,-78451432279L,275184965281L,285452190822491L,2025474989659351L,-1262254633814956639L,BigInteger.Parse("-23910902170778310479"),BigInteger.Parse("6553155098722204435331"),BigInteger.Parse("211963483784997365090791"),BigInteger.Parse("-38953278800314916926586599"),BigInteger.Parse("-1859239582352196300555291839") };
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
public class A160293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160293Inst Instance=new A160293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160294
{
public static readonly BigInteger[] Value={ 1L,13L,-281L,-15353L,179761L,29972293L,-14822441L,-81117882833L,-1007841787679L,278922434958973L,7707750894566599L,-1154950195686012713L,BigInteger.Parse("-53167719472022830319"),BigInteger.Parse("5545550703568171856053"),BigInteger.Parse("383123318057719791494839"),BigInteger.Parse("-29956366297729125403700993") };
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
public class A160294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160294Inst Instance=new A160294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160295
{
public static readonly BigInteger[] Value={ 1L,17L,-161L,-18037L,-89279L,30948857L,727008319L,-71202772477L,-3500523336959L,196821084188897L,17523077945895199L,-587802553769818117L,BigInteger.Parse("-96731879246268143039"),BigInteger.Parse("1529691843170459400137"),BigInteger.Parse("591886254924566446580479"),BigInteger.Parse("425007721743735371005043") };
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
public class A160295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160295Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160295.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160295Inst Instance=new A160295Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160296
{
public static readonly BigInteger[] Value={ 1L,19L,-89L,-18791L,-236879L,29323099L,1090116631L,-58460151311L,-4544610262559L,124108949730979L,20763741608252551L,-163979183232607031L,BigInteger.Parse("-105896125442269661039"),BigInteger.Parse("-1126538793947045592341"),BigInteger.Parse("598088096752283650823671"),BigInteger.Parse("18460868240159776597398049") };
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
public class A160296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160296Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160296.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160296Inst Instance=new A160296Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160297
{
public static readonly BigInteger[] Value={ 1L,23L,79L,-18883L,-540959L,21547343L,1712746639L,-18784653403L,-5827198941119L,-66400823394937L,22072936773448399L,806481251066529677L,BigInteger.Parse("-90711968254039392479"),BigInteger.Parse("-6441374025602166282817"),BigInteger.Parse("382513411697280621497359"),BigInteger.Parse("49378464830331101876186357") };
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
public class A160297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160297Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160297.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160297Inst Instance=new A160297Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160298
{
public static readonly BigInteger[] Value={ 1L,29L,391L,-14761L,-955919L,-1151851L,2117414071L,64515005759L,-4798919156639L,-371422676274931L,8664364972414951L,1922668627437223079L,12868783582225461841UL,BigInteger.Parse("-10009215864276466233211"),BigInteger.Parse("-365549644020036472532969"),BigInteger.Parse("52457120268360679565773199") };
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
public class A160298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160298Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160298.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160298Inst Instance=new A160298Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160299
{
public static readonly BigInteger[] Value={ 1L,2L,-1918L,-11524L,11036140L,110668792L,-105835967816L,-1487904444976L,1420941302106512L,25719901350164000L,BigInteger.Parse("-24528002841138116576"),BigInteger.Parse("-543392509632428313152"),BigInteger.Parse("517484251048077204023488"),BigInteger.Parse("13567773344258481022584704"),BigInteger.Parse("-12902725949998740057685701760") };
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
public class A160299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160299Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160299.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160299Inst Instance=new A160299Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160300
{
public static readonly BigInteger[] Value={ 1L,4L,-1906L,-23000L,10897996L,220415984L,-103848077624L,-2957229437984L,1385343118601360L,51011732312847424L,BigInteger.Parse("-23759618336314935584"),BigInteger.Parse("-1075483968398187231616"),BigInteger.Parse("498023914992777619190464"),BigInteger.Parse("26797057907106900786753280"),BigInteger.Parse("-12336437308381113989945920384") };
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
public class A160300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160300Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160300.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160300Inst Instance=new A160300Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160301
{
public static readonly BigInteger[] Value={ 1L,6L,-1886L,-34380L,10668396L,328323816L,-100553342664L,-4389550302096L,1326507370388880L,75452769667361376L,BigInteger.Parse("-22493207874982677984"),BigInteger.Parse("-1585161480256581714624"),BigInteger.Parse("466040432011344287649984"),BigInteger.Parse("39356406972705866391987840"),BigInteger.Parse("-11408347792399213172870573184") };
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
public class A160301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160301Inst Instance=new A160301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160302
{
public static readonly BigInteger[] Value={ 1L,8L,-1858L,-45616L,10348300L,433482208L,-95979305336L,-5766751265344L,1245171563867792L,98630939966871680L,BigInteger.Parse("-20749930192050092576"),BigInteger.Parse("-2061686107699674430208"),BigInteger.Parse("422201535258725661800128"),BigInteger.Parse("50928340670055096352718336"),BigInteger.Parse("-10141700834614078614916251520") };
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
public class A160302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160302Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160302.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160302Inst Instance=new A160302Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160303
{
public static readonly BigInteger[] Value={ 1L,10L,-1822L,-56660L,9939052L,534992600L,-90164363720L,-7071178300400L,1142359566484880L,120150033211799200L,BigInteger.Parse("-18559035448937462240"),BigInteger.Parse("-2494873992820155246400"),BigInteger.Parse("367426387533234274214080"),BigInteger.Parse("61216037645736403345110400"),BigInteger.Parse("-8568355342448027542061898880") };
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
public class A160303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160303Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160303.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160303Inst Instance=new A160303Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160304
{
public static readonly BigInteger[] Value={ 1L,12L,-1778L,-67464L,9442380L,631971792L,-83157610296L,-8285790028896L,1019373008575632L,139634783587212480L,BigInteger.Parse("-15957496899294732576"),BigInteger.Parse("-2875270503337760656512"),BigInteger.Parse("302870153404836108243648"),BigInteger.Parse("69949680729840145080716544"),BigInteger.Parse("-6728117484215153259607190400") };
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
public class A160304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160304Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160304.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160304Inst Instance=new A160304Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160305
{
public static readonly BigInteger[] Value={ 1L,14L,-1726L,-77980L,8860396L,723555784L,-75018624584L,-9394306045264L,877780290519440L,156735773819251424L,BigInteger.Parse("-12989542631935753184"),BigInteger.Parse("-3194315169653112913856"),BigInteger.Parse("229904497949242113022144"),BigInteger.Parse("76892348044168785827484800"),BigInteger.Parse("-4667900913141400434386502784") };
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
public class A160305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160305Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160305.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160305Inst Instance=new A160305Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160306
{
public static readonly BigInteger[] Value={ 1L,16L,-1666L,-88160L,8195596L,808903616L,-65817219704L,-10381352014976L,719403241658000L,171134120448798976L,BigInteger.Parse("-9706091347019300384"),BigInteger.Parse("-3444495256578225124864"),BigInteger.Parse("150094259153430446720704"),BigInteger.Parse("81845346744175071427394560"),BigInteger.Parse("-2440729611300811998925197184") };
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
public class A160306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160306Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160306.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160306Inst Instance=new A160306Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160307
{
public static readonly BigInteger[] Value={ 1L,18L,-1598L,-97956L,7450860L,887201208L,-55633142856L,-11232600902064L,546301487747472L,182545898249590560L,-6164096966563140576L,BigInteger.Parse("-3619485909755267093568"),BigInteger.Parse("65170591691483110373568"),BigInteger.Parse("84652893673042176232776576"),BigInteger.Parse("-104600317888637823603991680") };
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
public class A160307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160307Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160307.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160307Inst Instance=new A160307Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160308
{
public static readonly BigInteger[] Value={ 1L,20L,-1522L,-107320L,6629452L,957665200L,-44555729720L,-11934909680800L,360754594036880L,190726263132718400L,-2425807704995582240L,BigInteger.Parse("-3714274931510759292800"),BigInteger.Parse("-22999072131198586137920"),BigInteger.Parse("85206055577740180606380800"),BigInteger.Parse("2278775927824931485369685120") };
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
public class A160308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160308Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160308.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160308Inst Instance=new A160308Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160309
{
public static readonly BigInteger[] Value={ 1L,22L,-1438L,-116204L,5735020L,1019546792L,-32683512776L,-12476450886416L,165242061387152L,195473234180049760L,1442053974086139424L,BigInteger.Parse("-3725270373510661319872"),BigInteger.Parse("-112443853337363708739392"),BigInteger.Parse("83445871121227891089261184"),BigInteger.Parse("4645331284154383230526194560") };
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
public class A160309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160309Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160309.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160309Inst Instance=new A160309Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160310
{
public static readonly BigInteger[] Value={ 1L,24L,-1346L,-124560L,4771596L,1072135584L,-20123783544L,-12846838359744L,-37578736832880L,196631096935434624L,5369183316185589216L,BigInteger.Parse("-3650389283510599332096"),BigInteger.Parse("-201124616475050111174976"),BigInteger.Parse("79365587639487260327262720"),BigInteger.Parse("6930073770593296325672255616") };
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
public class A160310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160310Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160310.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160310Inst Instance=new A160310Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160311
{
public static readonly BigInteger[] Value={ 1L,26L,-1246L,-132340L,3743596L,1114763416L,-6992108744L,-13037246540656L,-244896579015280L,194093391754729376L,9282649209429277216UL,BigInteger.Parse("-3489126110080737399104"),BigInteger.Parse("-286971048447852951277376"),BigInteger.Parse("73011957343257950639722880"),BigInteger.Parse("9068569507442760557249311616") };
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
public class A160311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160311Inst Instance=new A160311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160312
{
public static readonly BigInteger[] Value={ 1L,28L,-1138L,-139496L,2655820L,1146808208L,6588199624L,-13040522665184L,-453772272366448L,187805452873608640L,13107905447855859424UL,BigInteger.Parse("-3242599451690793996928"),BigInteger.Parse("-367920121625910811856192"),BigInteger.Parse("64485550348270970013174016"),BigInteger.Parse("10998447568696594705407685760") };
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
public class A160312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160312Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160312.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160312Inst Instance=new A160312Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160313
{
public static readonly BigInteger[] Value={ 1L,30L,-1022L,-145980L,1513452L,1167697800L,20486660280L,-12851291221200L,-661166264043120L,177766465895877600L,16769848012294217760UL,BigInteger.Parse("-2913576034149940939200"),BigInteger.Parse("-441955407700422580057920"),BigInteger.Parse("53940055420621560419971200"),BigInteger.Parse("12660899479421405397926325120") };
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
public class A160313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160313Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160313.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160313Inst Instance=new A160313Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160314
{
public static readonly BigInteger[] Value={ 1L,32L,-898L,-151744L,322060L,1176913792L,34566244744L,-12466050017536L,-863967857346928L,164031013634531840L,BigInteger.Parse("20193908432692179424"),BigInteger.Parse("-2506471012209552223232"),BigInteger.Parse("-507146684474683728525632"),BigInteger.Parse("41580553522411233163802624"),BigInteger.Parse("14002144771001607102183125120") };
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
public class A160314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160314Inst Instance=new A160314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160315
{
public static readonly BigInteger[] Value={ 1L,34L,-766L,-156740L,-912404L,1173995384L,48684045496L,-11883257221424L,-1059025893631600L,146710082653141024L,BigInteger.Parse("23307172718246211616"),BigInteger.Parse("-2027323916172999286336"),BigInteger.Parse("-561689258759043381720896"),BigInteger.Parse("27660764004806580561543040"),BigInteger.Parse("14974833795516881674770770816") };
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
public class A160315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160315Inst Instance=new A160315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160316
{
public static readonly BigInteger[] Value={ 1L,36L,-626L,-160920L,-2183604L,1158543216L,62691990216L,-11103408719136L,-1243180750254960L,125971505456256576L,BigInteger.Parse("26039514814335534816"),BigInteger.Parse("-1483749801553172137344"),BigInteger.Parse("-603942415060596074024256"),BigInteger.Parse("12479278480840903510828800"),BigInteger.Parse("15539359208014326031959897216") };
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
public class A160316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160316Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160316.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160316Inst Instance=new A160316Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160317
{
public static readonly BigInteger[] Value={ 1L,38L,-478L,-164236L,-3484820L,1130223208L,76437602104L,-10129105154704L,-1413297494585968L,102039816064461920L,BigInteger.Parse("28324733071797627424"),BigInteger.Parse("-884865408030648260288"),BigInteger.Parse("-632466392109110072889152"),BigInteger.Parse("-3625187129327311294505344"),BigInteger.Parse("15665048162323786452017148800") };
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
public class A160317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160317Inst Instance=new A160317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160318
{
public static readonly BigInteger[] Value={ 1L,40320L,545007960L,1579060246400L,1455918295922650L,569304690994400256L,BigInteger.Parse("114601242382721619224"),BigInteger.Parse("13590707419428422843904"),BigInteger.Parse("1046591482728407939338275"),BigInteger.Parse("56272722406349235035916800"),BigInteger.Parse("2233160342369825596702148720"),BigInteger.Parse("68316292103293669997188919040") };
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
public class A160318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160318Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160318.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160318Inst Instance=new A160318Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160319
{
public static readonly BigInteger[] Value={ 1L,362880L,41514583320L,772200774683520L,3680232136895819610L,BigInteger.Parse("6274236760589024662176"),BigInteger.Parse("4801114002903931560293544"),BigInteger.Parse("1933216160887575268614599040"),BigInteger.Parse("459761347800901006933211075259"),BigInteger.Parse("70417932475495769964322670258947"),BigInteger.Parse("7424168163091445250817494013145952") };
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
public class A160319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160319Inst Instance=new A160319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160320
{
public static readonly long[] Value={ 3L,12L,234L,1080L,6048L,6552L,435708L,4713984L,18506880L,36197280L,275890944L,299980800L,4138364160L,13286744064L,17827568640L,30600708096L,459010621440L,2198278051200L,2567400675840L,3321402084000L,4959751305600L,295185198672000L,1217745604232064L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160320Inst : IEnumerable<long>
{
public static readonly long[] Value=A160320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160320.Bytes);
public long this[int i]=>Value[i];

public static A160320Inst Instance=new A160320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160321
{
public static readonly long[] Value={ 84L,270L,1488L,1638L,24384L,35640L,199584L,2142720L,12999168L,100651008L,208565280L,240589440L,470564640L,3899750400L,6039429120L,25769607168L,36639203328L,53798734080L,231758392320L,314039721600L,412316073984L,5566503720960L,5967138078720L,302512616524800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160321Inst : IEnumerable<long>
{
public static readonly long[] Value=A160321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160321.Bytes);
public long this[int i]=>Value[i];

public static A160321Inst Instance=new A160321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160322
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160322Inst : IEnumerable<long>
{
public static readonly long[] Value=A160322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160322.Bytes);
public long this[int i]=>Value[i];

public static A160322Inst Instance=new A160322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160323
{
public static readonly long[] Value={ 2L,1L,4L,8L,1L,27L,1L,19L,1L,25L,3L,6L,4L,1L,37L,1L,1L,7L,1L,75L,1L,13L,1L,2L,6L,1L,16L,1L,6L,2L,1L,1L,3L,1L,5L,3L,36L,1L,4L,17L,1L,2L,1L,1L,1L,12L,1L,1L,7L,1L,3L,1L,10L,13L,3L,7L,3L,1L,9L,206L,1L,1L,1L,3L,34L,1L,10L,1L,1L,7L,1L,705L,1L,4L,4L,1L,1L,2L,1L,4L,2L,2L,1L,3L,8L,1L,19L,2L,1L,11L,3L,1L,725L,1L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160323Inst : IEnumerable<long>
{
public static readonly long[] Value=A160323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160323.Bytes);
public long this[int i]=>Value[i];

public static A160323Inst Instance=new A160323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160324
{
public static readonly long[] Value={ 1L,3L,3L,1L,1L,3L,4L,3L,1L,2L,4L,3L,2L,2L,2L,4L,5L,4L,2L,2L,3L,3L,5L,3L,3L,2L,3L,5L,4L,5L,2L,5L,5L,2L,2L,1L,6L,8L,5L,2L,3L,5L,4L,3L,4L,5L,3L,3L,2L,5L,7L,7L,5L,4L,7L,4L,4L,3L,4L,4L,3L,6L,3L,2L,5L,5L,9L,7L,3L,3L,6L,9L,5L,3L,1L,8L,7L,6L,2L,5L,6L,3L,10L,4L,3L,3L,8L,7L,5L,4L,1L,4L,10L,7L,5L,4L,8L,6L,2L,8L,6L,10L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160324Inst : IEnumerable<long>
{
public static readonly long[] Value=A160324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160324.Bytes);
public long this[int i]=>Value[i];

public static A160324Inst Instance=new A160324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160325
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,3L,3L,2L,2L,1L,3L,3L,2L,1L,1L,5L,3L,3L,2L,4L,3L,2L,6L,2L,2L,2L,5L,4L,3L,3L,1L,4L,4L,3L,1L,1L,5L,7L,5L,3L,4L,6L,4L,3L,4L,5L,2L,3L,3L,5L,4L,5L,5L,2L,6L,2L,5L,5L,5L,3L,3L,6L,3L,2L,5L,4L,6L,6L,3L,3L,6L,9L,6L,5L,4L,5L,5L,6L,2L,7L,4L,3L,6L,6L,4L,2L,7L,7L,3L,3L,4L,5L,8L,5L,5L,5L,8L,4L,2L,4L,6L,6L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160325Inst : IEnumerable<long>
{
public static readonly long[] Value=A160325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160325.Bytes);
public long this[int i]=>Value[i];

public static A160325Inst Instance=new A160325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160326
{
public static readonly long[] Value={ 1L,3L,3L,1L,2L,5L,4L,1L,1L,5L,6L,2L,1L,5L,5L,2L,4L,6L,5L,1L,3L,6L,5L,3L,1L,8L,8L,4L,2L,4L,8L,4L,5L,1L,4L,5L,4L,10L,6L,6L,5L,8L,6L,1L,3L,6L,6L,4L,6L,4L,7L,8L,8L,8L,5L,7L,4L,4L,6L,5L,6L,8L,7L,4L,8L,8L,6L,5L,4L,7L,7L,8L,7L,7L,8L,8L,8L,7L,3L,4L,12L,4L,4L,7L,3L,13L,12L,12L,5L,2L,12L,4L,5L,6L,6L,8L,10L,8L,3L,5L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160326Inst : IEnumerable<long>
{
public static readonly long[] Value=A160326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160326.Bytes);
public long this[int i]=>Value[i];

public static A160326Inst Instance=new A160326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160327
{
public static readonly long[] Value={ 4L,6L,2L,1L,1L,7L,1L,5L,7L,2L,6L,0L,0L,0L,9L,7L,5L,8L,5L,0L,2L,3L,1L,8L,4L,8L,3L,6L,4L,3L,6L,7L,2L,5L,4L,8L,7L,3L,0L,2L,8L,9L,2L,8L,0L,3L,3L,0L,1L,1L,3L,0L,3L,8L,5L,5L,2L,7L,3L,1L,8L,1L,5L,8L,3L,8L,0L,8L,0L,9L,0L,6L,1L,4L,0L,4L,0L,9L,2L,7L,8L,7L,7L,4L,9L,4L,9L,0L,6L,4L,1L,5L,1L,9L,6L,2L,4L,9L,0L,5L,8L,4L,3L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160327Inst : IEnumerable<long>
{
public static readonly long[] Value=A160327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160327.Bytes);
public long this[int i]=>Value[i];

public static A160327Inst Instance=new A160327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160328
{
public static readonly BigInteger[] Value={ 1L,40L,-322L,-166640L,-4808948L,1088770400L,89764806280L,-8965108001600L,-1566300023755120L,75195499682396800L,BigInteger.Parse("30101677798211937760"),BigInteger.Parse("-241190391967188985600"),BigInteger.Parse("-646057287688484347545920"),BigInteger.Parse("-20279476307208127137958400"),BigInteger.Parse("15331208337896144822264021120") };
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
public class A160328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160328Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160328.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160328Inst Instance=new A160328Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160329
{
public static readonly BigInteger[] Value={ 1L,42L,-158L,-168084L,-6148500L,1033992792L,102514782264L,-7618384022256L,-1699206009514608L,45773620326594720L,BigInteger.Parse("31315357606300667424"),BigInteger.Parse("435476036787477513408"),BigInteger.Parse("-643779296967334655115072"),BigInteger.Parse("-37082549785094436884075136"),BigInteger.Parse("14528002423051857343574033280") };
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
public class A160329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160329Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160329.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160329Inst Instance=new A160329Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160330
{
public static readonly BigInteger[] Value={ 1L,44L,14L,-168520L,-7495604L,965775184L,114526862536L,-6098137470304L,-1809162457252720L,14161813624274624L,BigInteger.Parse("31918011985025634016"),BigInteger.Parse("1132202469482569623424"),BigInteger.Parse("-624993700730178890935616"),BigInteger.Parse("-53612840588273856995818240"),BigInteger.Parse("13257127620560200061101298816") };
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
public class A160330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160330Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160330.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160330Inst Instance=new A160330Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160331
{
public static readonly long[] Value={ 2L,9L,9L,1L,9L,7L,1L,8L,5L,7L,4L,6L,3L,7L,5L,0L,4L,5L,8L,2L,9L,4L,6L,5L,6L,9L,4L,8L,7L,8L,4L,1L,0L,0L,7L,1L,7L,5L,1L,3L,0L,5L,6L,7L,1L,8L,5L,1L,1L,8L,8L,8L,6L,0L,8L,1L,3L,7L,7L,8L,2L,0L,9L,1L,6L,0L,7L,2L,3L,2L,6L,9L,3L,4L,2L,2L,7L,5L,9L,5L,2L,0L,8L,1L,0L,5L,4L,2L,7L,4L,9L,1L,9L,3L,5L,0L,3L,6L,6L,9L,8L,2L,9L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160331Inst : IEnumerable<long>
{
public static readonly long[] Value=A160331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160331.Bytes);
public long this[int i]=>Value[i];

public static A160331Inst Instance=new A160331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160332
{
public static readonly long[] Value={ 3L,3L,1L,8L,6L,2L,8L,2L,1L,7L,7L,5L,0L,1L,8L,5L,6L,5L,9L,1L,0L,9L,6L,8L,0L,1L,5L,3L,3L,1L,8L,0L,2L,2L,4L,6L,7L,7L,2L,1L,9L,1L,9L,8L,0L,8L,8L,3L,6L,9L,0L,0L,2L,6L,0L,2L,2L,8L,0L,9L,1L,9L,9L,5L,8L,4L,0L,1L,9L,5L,8L,9L,7L,4L,5L,7L,3L,2L,1L,8L,7L,4L,3L,6L,6L,5L,3L,4L,5L,9L,1L,0L,7L,4L,8L,7L,1L,5L,4L,0L,0L,4L,5L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160332Inst : IEnumerable<long>
{
public static readonly long[] Value=A160332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160332.Bytes);
public long this[int i]=>Value[i];

public static A160332Inst Instance=new A160332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160333
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,3L,4L,5L,7L,10L,13L,17L,23L,32L,44L,59L,79L,107L,146L,198L,267L,361L,490L,665L,900L,1217L,1648L,2234L,3027L,4098L,5548L,7515L,10181L,13789L,18672L,25287L,34251L,46392L,62830L,85090L,115243L,156087L,211402L,286311L,387765L,525180L,711295L,963355L,1304728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160333Inst : IEnumerable<long>
{
public static readonly long[] Value=A160333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160333.Bytes);
public long this[int i]=>Value[i];

public static A160333Inst Instance=new A160333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160334
{
public static readonly BigInteger[] Value={ 1L,46L,194L,-167900L,-8842004L,884083016L,125639477176L,-4415829390416L,-1893481677885040L,-19202364475675424L,BigInteger.Parse("31870137298174352416"),BigInteger.Parse("1835095760938501860416"),BigInteger.Parse("-589384037754831073199936"),BigInteger.Parse("-69436314367007836275831680"),BigInteger.Parse("11532279106459848726285343616") };
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
public class A160334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160334Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160334.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160334Inst Instance=new A160334Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160335
{
public static readonly BigInteger[] Value={ 1L,48L,382L,-166176L,-10179060L,788966208L,135691144584L,-2585183370624L,-1949677461023088L,-53834738622393600L,BigInteger.Parse("31141453266902483424"),BigInteger.Parse("2529493433133724196352"),BigInteger.Parse("-536976920178433543125312"),BigInteger.Parse("-84115128710361024934677504"),BigInteger.Parse("9379379149481011311664525440") };
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
public class A160335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160335Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160335.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160335Inst Instance=new A160335Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160336
{
public static readonly BigInteger[] Value={ 1L,50L,578L,-163300L,-11497748L,680563000L,144521508280L,-622177102000L,-1975501227499120L,-89208466254604000L,BigInteger.Parse("29711796920549577760"),BigInteger.Parse("3200176567440967768000"),BigInteger.Parse("-468157982122210784601920"),BigInteger.Parse("-97216771457569019831248000"),BigInteger.Parse("6836556768427107672501173120") };
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
public class A160336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160336Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160336.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160336Inst Instance=new A160336Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160337
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,11L,13L,17L,23L,31L,37L,53L,71L,73L,101L,103L,107L,113L,127L,131L,137L,151L,157L,173L,211L,223L,227L,233L,251L,257L,271L,277L,307L,311L,313L,317L,331L,337L,353L,373L,503L,521L,523L,557L,571L,577L,701L,727L,733L,751L,757L,773L,1013L,1021L,1031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160337Inst : IEnumerable<long>
{
public static readonly long[] Value=A160337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160337.Bytes);
public long this[int i]=>Value[i];

public static A160337Inst Instance=new A160337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160338
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160338Inst : IEnumerable<long>
{
public static readonly long[] Value=A160338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160338.Bytes);
public long this[int i]=>Value[i];

public static A160338Inst Instance=new A160338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160339
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,14L,23L,25L,27L,59L,359L,397L,434L,532L,1182L,31010L,35111L,44125L,59815L,14102773L,14703509L,56938657L,74989473L,1376877780831L,1475674234751L,1666495909761L,2201904353336L,2286541988726L,2699208408726L,862550638890874931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160339Inst : IEnumerable<long>
{
public static readonly long[] Value=A160339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160339.Bytes);
public long this[int i]=>Value[i];

public static A160339Inst Instance=new A160339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160340
{
public static readonly long[] Value={ 1L,105L,385L,1365L,1785L,2805L,3135L,6545L,10465L,11305L,17255L,20615L,26565L,40755L,106743L,171717L,255255L,279565L,327845L,707455L,886445L,983535L,1181895L,1752465L,3949491L,8070699L,10163195L,13441645L,15069565L,30489585L,37495115L,40324935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160340Inst : IEnumerable<long>
{
public static readonly long[] Value=A160340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160340.Bytes);
public long this[int i]=>Value[i];

public static A160340Inst Instance=new A160340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160341
{
public static readonly long[] Value={ 1L,1L,2L,3L,23L,532L,669606L,8161018310L,2888582082500892851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160341Inst : IEnumerable<long>
{
public static readonly long[] Value=A160341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160341.Bytes);
public long this[int i]=>Value[i];

public static A160341Inst Instance=new A160341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160342
{
public static readonly long[] Value={ 199L,223L,2333L,44449L,555557L,0L,77767777L,888888883L,9199999999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160342Inst : IEnumerable<long>
{
public static readonly long[] Value=A160342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160342.Bytes);
public long this[int i]=>Value[i];

public static A160342Inst Instance=new A160342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160343
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,89L,394L,605L,894L,3944L,6055L,8944L,15111L,84888L,89444L,894444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160343Inst : IEnumerable<long>
{
public static readonly long[] Value=A160343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160343.Bytes);
public long this[int i]=>Value[i];

public static A160343Inst Instance=new A160343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160344
{
public static readonly BigInteger[] Value={ 1L,52L,782L,-159224L,-12788660L,559103792L,151972419784L,1454980899424L,-1968977929003888L,-124758638617745600L,BigInteger.Parse("27571931007786483424"),BigInteger.Parse("3831601446637967570048"),BigInteger.Parse("-383682490141447518907712"),BigInteger.Parse("-108323545252613355018788096"),BigInteger.Parse("3953866345538313246451111040") };
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
public class A160344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160344Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160344.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160344Inst Instance=new A160344Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160345
{
public static readonly BigInteger[] Value={ 1L,54L,994L,-153900L,-14042004L,424914984L,157889067576L,3625890053616L,-1928441452272240L,-159887523887100576L,BigInteger.Parse("24724253951501776416"),BigInteger.Parse("4408147922491168997184"),BigInteger.Parse("-284680189228127431139136"),BigInteger.Parse("-117042253902655203032565120"),BigInteger.Parse("792737497310611030683935616") };
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
public class A160345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160345Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160345.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160345Inst Instance=new A160345Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160346
{
public static readonly BigInteger[] Value={ 1L,56L,1214L,-147280L,-15247604L,278422816L,162121152136L,5868012605504L,-1852569274929520L,-193970441218282624L,BigInteger.Parse("21183398609507010016"),BigInteger.Parse("4914382202347784594176"),BigInteger.Parse("-172654010070721268484416"),BigInteger.Parse("-123013935678909694915202560"),BigInteger.Parse("-2574847302391901300899725184") };
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
public class A160346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160346Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160346.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160346Inst Instance=new A160346Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160347
{
public static readonly BigInteger[] Value={ 1L,58L,1442L,-139316L,-16394900L,120157208L,164524107064L,8156745287056L,-1740416109789808L,-226362249901581920L,16976707372852347424UL,BigInteger.Parse("5335331470733840652992"),BigInteger.Parse("-49472321974281571364672"),BigInteger.Parse("-125923479715513631959758464"),BigInteger.Parse("-6067446386650391311548296320") };
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
public class A160347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160347Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160347.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160347Inst Instance=new A160347Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160348
{
public static readonly long[] Value={ 0L,2L,1L,6L,7L,5L,3L,11L,4L,13L,14L,10L,15L,52L,12L,50L,53L,9L,54L,59L,51L,62L,63L,49L,60L,65L,8L,68L,69L,58L,16L,75L,61L,56L,76L,48L,77L,80L,64L,84L,85L,67L,78L,88L,57L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160348Inst : IEnumerable<long>
{
public static readonly long[] Value=A160348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160348.Bytes);
public long this[int i]=>Value[i];

public static A160348Inst Instance=new A160348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160349
{
public static readonly BigInteger[] Value={ 1L,60L,1678L,-129960L,-17472948L,-49244400L,164960366280L,10465508397600L,-1591446264075120L,-256404432966004800L,12144571498011137760UL,BigInteger.Parse("5656767491487280521600"),BigInteger.Parse("82645518878285356774080"),BigInteger.Parse("-125508954290965516543737600"),BigInteger.Parse("-9595518192150768916981418880") };
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
public class A160349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160349Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160349.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160349Inst Instance=new A160349Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160350
{
public static readonly long[] Value={ 30L,42L,66L,70L,78L,102L,110L,114L,130L,138L,154L,170L,174L,182L,186L,190L,222L,230L,231L,238L,246L,258L,266L,282L,286L,290L,310L,318L,322L,354L,366L,370L,374L,399L,402L,406L,410L,418L,426L,430L,434L,435L,438L,442L,465L,470L,474L,483L,494L,498L,506L,518L,530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160350Inst : IEnumerable<long>
{
public static readonly long[] Value=A160350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160350.Bytes);
public long this[int i]=>Value[i];

public static A160350Inst Instance=new A160350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160351
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160351Inst : IEnumerable<long>
{
public static readonly long[] Value=A160351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160351.Bytes);
public long this[int i]=>Value[i];

public static A160351Inst Instance=new A160351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160352
{
public static readonly long[] Value={ 30L,42L,66L,78L,102L,110L,114L,138L,174L,182L,186L,190L,222L,246L,258L,282L,290L,310L,318L,354L,366L,402L,406L,410L,426L,435L,438L,465L,474L,498L,506L,534L,574L,582L,590L,602L,606L,610L,618L,642L,654L,678L,710L,762L,786L,790L,822L,834L,861L,885L,890L,894L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160352Inst : IEnumerable<long>
{
public static readonly long[] Value=A160352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160352.Bytes);
public long this[int i]=>Value[i];

public static A160352Inst Instance=new A160352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160353
{
public static readonly long[] Value={ 435L,465L,861L,885L,903L,915L,1335L,1743L,2211L,2235L,2265L,2485L,2667L,2685L,2715L,3081L,3165L,3507L,3585L,3615L,4035L,4065L,4323L,4431L,4865L,4965L,5151L,5253L,5271L,5385L,5835L,5995L,6123L,6153L,6285L,6315L,6441L,6501L,6567L,6735L,7077L,7185L,7385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160353Inst : IEnumerable<long>
{
public static readonly long[] Value=A160353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160353.Bytes);
public long this[int i]=>Value[i];

public static A160353Inst Instance=new A160353Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160354
{
public static readonly long[] Value={ 70L,130L,154L,170L,230L,231L,238L,266L,286L,322L,370L,374L,399L,418L,430L,434L,442L,470L,483L,494L,518L,530L,598L,638L,646L,651L,658L,663L,670L,682L,730L,741L,742L,754L,782L,806L,814L,826L,830L,854L,874L,902L,938L,962L,970L,986L,1022L,1030L,1034L,1054L,1066L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160354Inst : IEnumerable<long>
{
public static readonly long[] Value=A160354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160354.Bytes);
public long this[int i]=>Value[i];

public static A160354Inst Instance=new A160354Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160355
{
public static readonly long[] Value={ 231L,399L,483L,651L,663L,741L,1113L,1173L,1209L,1281L,1311L,1353L,1443L,1479L,1533L,1581L,1599L,1653L,1833L,1947L,2163L,2247L,2301L,2337L,2379L,2409L,2829L,2877L,2915L,3129L,3297L,3363L,3441L,3531L,3621L,3723L,3759L,3783L,3813L,4011L,4029L,4071L,4161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160355Inst : IEnumerable<long>
{
public static readonly long[] Value=A160355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160355.Bytes);
public long this[int i]=>Value[i];

public static A160355Inst Instance=new A160355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160356
{
public static readonly long[] Value={ 1L,2L,3L,-4L,5L,6L,7L,-8L,9L,-10L,11L,-12L,13L,-14L,15L,-16L,17L,18L,19L,-20L,21L,-22L,-23L,24L,-25L,26L,-27L,28L,-29L,30L,-31L,32L,33L,34L,-35L,36L,-37L,-38L,39L,-40L,41L,-42L,43L,-44L,45L,-46L,47L,-48L,49L,-50L,51L,-52L,53L,-54L,55L,-56L,57L,-58L,59L,-60L,61L,-62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160356Inst : IEnumerable<long>
{
public static readonly long[] Value=A160356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160356.Bytes);
public long this[int i]=>Value[i];

public static A160356Inst Instance=new A160356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160357
{
public static readonly long[] Value={ 1L,1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160357Inst : IEnumerable<long>
{
public static readonly long[] Value=A160357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160357.Bytes);
public long this[int i]=>Value[i];

public static A160357Inst Instance=new A160357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160358
{
public static readonly long[] Value={ 3L,5L,9L,11L,23L,29L,63L,65L,71L,95L,141L,159L,161L,173L,179L,183L,209L,219L,255L,299L,323L,341L,365L,371L,389L,393L,453L,485L,521L,567L,579L,605L,623L,633L,635L,639L,677L,701L,711L,723L,725L,747L,785L,827L,867L,945L,981L,993L,999L,1001L,1013L,1035L,1037L,1041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160358Inst : IEnumerable<long>
{
public static readonly long[] Value=A160358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160358.Bytes);
public long this[int i]=>Value[i];

public static A160358Inst Instance=new A160358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160359
{
public static readonly long[] Value={ 83L,373L,2393L,4723L,56383L,122701L,1789391L,1987849L,2706679L,7287991L,27833021L,41765519L,43570537L,55600477L,62283451L,67053359L,104720809L,122353547L,204330311L,347756707L,450504547L,540649093L,677774533L,715849843L,839886301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160359Inst : IEnumerable<long>
{
public static readonly long[] Value=A160359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160359.Bytes);
public long this[int i]=>Value[i];

public static A160359Inst Instance=new A160359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160360
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,93L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A160360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160360Inst : IEnumerable<long>
{
public static readonly long[] Value=A160360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160360.Bytes);
public long this[int i]=>Value[i];

public static A160360Inst Instance=new A160360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160361
{
public static readonly BigInteger[] Value={ 1L,1L,-511L,-1535L,783361L,3927041L,-2001477119L,-14065347071L,7159228647425L,64770890250241L,-32924954717084159L,-364551912798318079L,BigInteger.Parse("185068793053819665409"),BigInteger.Parse("2424875745286685942785"),BigInteger.Parse("-1229393010820937007019519"),BigInteger.Parse("-18610902353035901844902399"),BigInteger.Parse("9423127420751760312065003521") };
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
public class A160361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160361Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160361.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160361Inst Instance=new A160361Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160362
{
public static readonly BigInteger[] Value={ 1L,3L,-503L,-4581L,758865L,11658483L,-1907718951L,-41538016629L,6712650670497L,190277668123875L,-30361061285278551L,-1065304844650075653L,BigInteger.Parse("167797582624738572273"),BigInteger.Parse("7048625713404280528851"),BigInteger.Parse("-1095714832810047095462535"),BigInteger.Parse("-53811693612112024117191573"),BigInteger.Parse("8253654835144825620800694081") };
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
public class A160362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160362Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160362.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160362Inst Instance=new A160362Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A160363
{
public static readonly BigInteger[] Value={ 1L,5L,-487L,-7555L,710257L,19023925L,-1723138295L,-67057189075L,5840441703905L,303868454970725L,-25393413096740615L,-1682773554933815075L,BigInteger.Parse("134601834786174068305"),BigInteger.Parse("11011969895444230162325"),BigInteger.Parse("-840849962859553447826455"),BigInteger.Parse("-83138050024842009042677875"),BigInteger.Parse("6042037464637160434093785025") };
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
public class A160363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A160363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A160363Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A160363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A160363.Bytes);
public BigInteger this[int i]=>Value[i];

public static A160363Inst Instance=new A160363Inst();

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