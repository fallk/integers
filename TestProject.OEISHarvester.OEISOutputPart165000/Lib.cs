using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A195457
{
public static readonly long[] Value={ 6L,3L,3L,0L,1L,2L,2L,8L,1L,0L,0L,0L,5L,8L,0L,7L,6L,6L,0L,0L,5L,5L,6L,0L,8L,8L,7L,9L,4L,6L,0L,6L,8L,1L,5L,1L,7L,2L,5L,3L,4L,0L,2L,4L,6L,5L,2L,9L,0L,7L,5L,0L,4L,5L,1L,5L,4L,9L,5L,2L,8L,3L,3L,1L,1L,6L,7L,6L,6L,2L,4L,7L,2L,9L,7L,3L,8L,1L,6L,8L,8L,9L,2L,9L,3L,3L,2L,0L,4L,4L,9L,1L,9L,5L,7L,6L,0L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195457Inst : IEnumerable<long>
{
public static readonly long[] Value=A195457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195457.Bytes);
public long this[int i]=>Value[i];

public static A195457Inst Instance=new A195457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195458
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,16L,32L,96L,288L,864L,2592L,7776L,23328L,69984L,279936L,1119744L,4478976L,17915904L,71663616L,286654464L,1146617856L,4586471424L,18345885696L,91729428480L,458647142400L,2293235712000L,11466178560000L,57330892800000L,286654464000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195458Inst : IEnumerable<long>
{
public static readonly long[] Value=A195458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195458.Bytes);
public long this[int i]=>Value[i];

public static A195458Inst Instance=new A195458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195459
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,3L,6L,4L,9L,4L,10L,6L,12L,6L,12L,8L,16L,9L,18L,8L,18L,10L,22L,12L,20L,12L,27L,12L,28L,12L,30L,16L,30L,16L,24L,18L,36L,18L,36L,16L,40L,18L,42L,20L,36L,22L,46L,24L,42L,20L,48L,24L,52L,27L,40L,24L,54L,28L,58L,24L,60L,30L,54L,32L,48L,30L,66L,32L,66L,24L,70L,36L,72L,36L,60L,36L,60L,36L,78L,32L,81L,40L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195459Inst : IEnumerable<long>
{
public static readonly long[] Value=A195459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195459.Bytes);
public long this[int i]=>Value[i];

public static A195459Inst Instance=new A195459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195460
{
public static readonly long[] Value={ 1L,19L,103L,463L,1951L,7999L,32383L,130303L,522751L,2094079L,8382463L,33542143L,134193151L,536821759L,2147385343L,8589737983L,34359345151L,137438167039L,549754241023L,2199020109823L,8796086730751L,35184359505919L,140737463189503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195460Inst : IEnumerable<long>
{
public static readonly long[] Value=A195460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195460.Bytes);
public long this[int i]=>Value[i];

public static A195460Inst Instance=new A195460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195461
{
public static readonly BigInteger[] Value={ 19L,103L,463L,1951L,130303L,8589737983L,36028796616310783L,144115187270549503L,BigInteger.Parse("147573952563906609151"),BigInteger.Parse("9444732965533131997183"),BigInteger.Parse("158456325028527830762157768703"),BigInteger.Parse("10889035741470030830606626508932068147199"),BigInteger.Parse("3064991081731777716716694050586798249381337419669831679") };
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
public class A195461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195461Inst Instance=new A195461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195462
{
public static readonly BigInteger[] Value={ 1L,3L,22L,600L,78912L,60963840L,325173657600L,13743074967552000L,BigInteger.Parse("5190968541142056960000"),BigInteger.Parse("19502847300506769948672000000"),BigInteger.Parse("802654006697267902579055001600000000"),BigInteger.Parse("395082050396018659026474786525020160000000000") };
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
public class A195462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195462Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195462.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195462Inst Instance=new A195462Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195463
{
public static readonly long[] Value={ 11L,23L,71L,263L,1031L,4103L,16391L,65543L,262151L,1048583L,4194311L,16777223L,67108871L,268435463L,1073741831L,4294967303L,17179869191L,68719476743L,274877906951L,1099511627783L,4398046511111L,17592186044423L,70368744177671L,281474976710663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195463Inst : IEnumerable<long>
{
public static readonly long[] Value=A195463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195463.Bytes);
public long this[int i]=>Value[i];

public static A195463Inst Instance=new A195463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195464
{
public static readonly BigInteger[] Value={ 13L,139L,2083L,32899L,524803L,8390659L,134225923L,2147516419L,34359869443L,549756338179L,8796095119363L,140737496743939L,2251799847239683L,36028797153181699L,576460752840294403L,9223372039002259459UL,BigInteger.Parse("147573952598266347523"),BigInteger.Parse("2361183241469182345219") };
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
public class A195464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195464Inst Instance=new A195464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195465
{
public static readonly long[] Value={ 0L,5L,5L,17L,5L,6L,14L,6L,24L,75L,2L,4L,27L,11L,48L,50L,46L,9L,21L,7L,16L,137L,4L,55L,85L,14L,111L,24L,102L,291L,67L,89L,155L,180L,137L,330L,127L,413L,250L,241L,332L,619L,139L,234L,453L,929L,94L,160L,169L,22L,131L,434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195465Inst : IEnumerable<long>
{
public static readonly long[] Value=A195465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195465.Bytes);
public long this[int i]=>Value[i];

public static A195465Inst Instance=new A195465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195466
{
public static readonly BigInteger[] Value={ 45L,945L,14175L,467775L,638512875L,1915538625L,488462349375L,7795859096025L,32157918771103125L,316985199315159375L,BigInteger.Parse("3028793579456347828125"),BigInteger.Parse("478230565177318078125"),BigInteger.Parse("3952575621190533915703125"),BigInteger.Parse("28304394023345413370350078125"),BigInteger.Parse("7217620475953080409439269921875"),BigInteger.Parse("21652861427859241228317809765625") };
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
public class A195466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195466Inst Instance=new A195466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195467
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,3L,0L,1L,3L,2L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,3L,2L,6L,7L,5L,4L,12L,13L,15L,14L,10L,11L,9L,8L,0L,1L,2L,3L,5L,4L,7L,6L,10L,11L,8L,9L,15L,14L,13L,12L,0L,1L,3L,2L,7L,6L,4L,5L,15L,14L,12L,13L,8L,9L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195467Inst : IEnumerable<long>
{
public static readonly long[] Value=A195467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195467.Bytes);
public long this[int i]=>Value[i];

public static A195467Inst Instance=new A195467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195468
{
public static readonly long[] Value={ 85487L,104651L,253241L,280601L,458987L,580337L,1082399L,1207361L,1251947L,1678541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195468Inst : IEnumerable<long>
{
public static readonly long[] Value=A195468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195468.Bytes);
public long this[int i]=>Value[i];

public static A195468Inst Instance=new A195468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195469
{
public static readonly long[] Value={ 101L,103L,106L,183L,255L,266L,271L,272L,278L,312L,300L,323L,374L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195469Inst : IEnumerable<long>
{
public static readonly long[] Value=A195469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195469.Bytes);
public long this[int i]=>Value[i];

public static A195469Inst Instance=new A195469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195470
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,3L,0L,0L,0L,1L,0L,0L,0L,2L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,3L,0L,1L,0L,1L,0L,0L,0L,5L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195470Inst : IEnumerable<long>
{
public static readonly long[] Value=A195470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195470.Bytes);
public long this[int i]=>Value[i];

public static A195470Inst Instance=new A195470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195471
{
public static readonly long[] Value={ 6L,3L,5L,0L,7L,4L,3L,6L,8L,6L,2L,0L,6L,6L,8L,1L,3L,7L,5L,6L,2L,1L,5L,7L,6L,6L,1L,6L,4L,5L,4L,6L,4L,6L,0L,8L,6L,9L,7L,6L,8L,0L,5L,0L,0L,0L,7L,5L,5L,5L,1L,9L,3L,1L,3L,2L,1L,8L,6L,7L,4L,2L,2L,9L,2L,7L,5L,7L,4L,9L,4L,0L,4L,3L,3L,5L,5L,5L,9L,7L,7L,8L,3L,2L,0L,1L,1L,3L,4L,1L,5L,5L,5L,7L,0L,6L,3L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195471Inst : IEnumerable<long>
{
public static readonly long[] Value=A195471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195471.Bytes);
public long this[int i]=>Value[i];

public static A195471Inst Instance=new A195471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195472
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,4L,8L,9L,8L,3L,6L,7L,2L,5L,6L,4L,4L,8L,0L,4L,2L,5L,9L,7L,1L,2L,5L,1L,8L,3L,3L,8L,0L,3L,5L,9L,6L,8L,2L,9L,8L,2L,7L,8L,2L,9L,1L,7L,5L,7L,2L,5L,8L,7L,9L,4L,6L,3L,3L,8L,7L,3L,8L,2L,7L,8L,3L,1L,4L,6L,7L,6L,3L,1L,5L,0L,5L,5L,9L,5L,0L,5L,5L,3L,6L,6L,3L,7L,1L,0L,8L,6L,8L,9L,0L,6L,1L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195472Inst : IEnumerable<long>
{
public static readonly long[] Value=A195472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195472.Bytes);
public long this[int i]=>Value[i];

public static A195472Inst Instance=new A195472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195473
{
public static readonly long[] Value={ 8L,3L,1L,9L,7L,7L,5L,6L,0L,2L,8L,9L,1L,6L,3L,2L,0L,4L,5L,9L,3L,0L,2L,3L,8L,1L,1L,4L,8L,1L,9L,6L,7L,8L,2L,7L,4L,4L,1L,2L,5L,0L,3L,0L,4L,9L,9L,1L,9L,8L,6L,7L,8L,3L,5L,4L,9L,3L,4L,1L,1L,3L,7L,0L,4L,5L,9L,1L,4L,2L,8L,7L,4L,9L,7L,7L,6L,9L,9L,2L,5L,9L,7L,0L,5L,8L,3L,3L,2L,4L,3L,6L,9L,8L,7L,6L,3L,7L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195473Inst : IEnumerable<long>
{
public static readonly long[] Value=A195473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195473.Bytes);
public long this[int i]=>Value[i];

public static A195473Inst Instance=new A195473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195474
{
public static readonly long[] Value={ 6L,2L,6L,9L,5L,0L,1L,1L,2L,3L,5L,3L,4L,9L,0L,9L,2L,5L,3L,9L,3L,5L,2L,7L,5L,2L,4L,8L,8L,7L,7L,1L,5L,8L,9L,1L,9L,9L,9L,2L,6L,8L,6L,2L,7L,2L,9L,9L,8L,6L,9L,2L,3L,1L,1L,3L,4L,7L,5L,9L,8L,0L,7L,8L,6L,2L,3L,7L,0L,1L,9L,8L,1L,6L,3L,6L,7L,0L,3L,1L,8L,5L,3L,1L,4L,0L,2L,9L,7L,1L,5L,8L,4L,8L,9L,9L,1L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195474Inst : IEnumerable<long>
{
public static readonly long[] Value=A195474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195474.Bytes);
public long this[int i]=>Value[i];

public static A195474Inst Instance=new A195474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195475
{
public static readonly long[] Value={ 6L,4L,3L,8L,4L,6L,3L,1L,3L,2L,9L,8L,7L,4L,3L,5L,3L,1L,5L,6L,9L,3L,7L,2L,1L,0L,7L,2L,1L,1L,8L,0L,9L,7L,2L,0L,6L,7L,5L,1L,9L,8L,1L,6L,0L,8L,2L,1L,8L,5L,8L,7L,2L,8L,7L,9L,9L,8L,8L,4L,7L,9L,2L,4L,7L,7L,6L,0L,4L,9L,3L,3L,7L,6L,7L,7L,9L,9L,8L,3L,9L,1L,9L,0L,0L,8L,7L,9L,2L,8L,3L,1L,3L,7L,8L,0L,4L,6L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195475Inst : IEnumerable<long>
{
public static readonly long[] Value=A195475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195475.Bytes);
public long this[int i]=>Value[i];

public static A195475Inst Instance=new A195475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195476
{
public static readonly long[] Value={ 1L,2L,7L,2L,2L,2L,4L,6L,5L,6L,0L,9L,0L,3L,5L,2L,3L,3L,6L,6L,0L,8L,1L,4L,1L,9L,8L,1L,3L,6L,9L,2L,1L,8L,6L,0L,9L,5L,4L,9L,2L,0L,7L,5L,8L,8L,9L,4L,2L,5L,6L,3L,3L,0L,6L,9L,5L,6L,9L,4L,3L,5L,5L,8L,7L,1L,3L,6L,7L,4L,5L,3L,7L,4L,5L,2L,9L,4L,1L,8L,2L,3L,6L,0L,9L,7L,8L,6L,3L,3L,3L,5L,0L,1L,1L,8L,1L,8L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195476Inst : IEnumerable<long>
{
public static readonly long[] Value=A195476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195476.Bytes);
public long this[int i]=>Value[i];

public static A195476Inst Instance=new A195476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195477
{
public static readonly long[] Value={ 9L,8L,8L,6L,5L,9L,2L,6L,2L,9L,8L,1L,9L,3L,8L,8L,4L,1L,7L,1L,3L,0L,9L,5L,8L,6L,3L,8L,8L,3L,8L,2L,5L,2L,4L,0L,3L,0L,6L,3L,3L,4L,0L,6L,3L,5L,4L,4L,3L,7L,8L,5L,1L,8L,2L,0L,8L,1L,0L,0L,4L,8L,2L,6L,1L,1L,8L,6L,8L,8L,8L,2L,0L,4L,0L,6L,8L,1L,2L,5L,5L,6L,8L,6L,4L,5L,6L,7L,3L,2L,1L,8L,6L,2L,9L,0L,6L,8L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195477Inst : IEnumerable<long>
{
public static readonly long[] Value=A195477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195477.Bytes);
public long this[int i]=>Value[i];

public static A195477Inst Instance=new A195477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195478
{
public static readonly long[] Value={ 6L,1L,3L,8L,4L,1L,7L,2L,5L,3L,9L,4L,1L,8L,6L,8L,1L,0L,6L,6L,0L,3L,6L,7L,2L,4L,6L,0L,0L,1L,3L,9L,4L,0L,2L,6L,6L,0L,7L,4L,8L,2L,7L,9L,6L,4L,8L,4L,2L,3L,9L,2L,9L,9L,9L,3L,8L,3L,0L,9L,0L,1L,7L,7L,7L,0L,9L,5L,7L,8L,7L,7L,1L,4L,1L,7L,5L,6L,4L,4L,4L,3L,6L,8L,4L,1L,2L,8L,9L,0L,4L,7L,2L,2L,2L,1L,4L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195478Inst : IEnumerable<long>
{
public static readonly long[] Value=A195478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195478.Bytes);
public long this[int i]=>Value[i];

public static A195478Inst Instance=new A195478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195479
{
public static readonly long[] Value={ 1L,2L,4L,4L,0L,6L,2L,1L,5L,6L,7L,5L,4L,7L,3L,6L,9L,8L,9L,2L,5L,4L,6L,9L,2L,9L,7L,6L,1L,3L,4L,4L,1L,4L,4L,0L,6L,9L,0L,1L,1L,4L,2L,6L,7L,9L,8L,3L,5L,1L,2L,6L,3L,8L,8L,2L,6L,0L,1L,5L,8L,3L,0L,3L,1L,7L,0L,7L,6L,7L,2L,1L,2L,4L,1L,2L,7L,3L,4L,6L,1L,2L,0L,3L,4L,7L,1L,6L,2L,2L,1L,5L,0L,0L,5L,1L,5L,8L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195479Inst : IEnumerable<long>
{
public static readonly long[] Value=A195479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195479.Bytes);
public long this[int i]=>Value[i];

public static A195479Inst Instance=new A195479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195480
{
public static readonly long[] Value={ 1L,9L,9L,5L,8L,6L,7L,2L,4L,7L,8L,9L,6L,3L,9L,1L,3L,9L,0L,9L,8L,1L,6L,3L,6L,0L,0L,6L,7L,8L,2L,6L,5L,0L,4L,1L,5L,8L,1L,1L,5L,7L,4L,4L,8L,7L,2L,2L,1L,5L,9L,4L,7L,8L,1L,0L,0L,0L,3L,0L,2L,0L,0L,2L,1L,7L,3L,1L,6L,3L,9L,8L,4L,2L,4L,8L,7L,8L,1L,9L,7L,8L,8L,4L,2L,1L,1L,1L,5L,7L,8L,0L,4L,1L,3L,3L,4L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195480Inst : IEnumerable<long>
{
public static readonly long[] Value=A195480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195480.Bytes);
public long this[int i]=>Value[i];

public static A195480Inst Instance=new A195480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195481
{
public static readonly long[] Value={ 1L,3L,5L,6L,9L,1L,7L,4L,0L,3L,9L,3L,7L,7L,6L,0L,3L,6L,5L,7L,9L,2L,8L,0L,7L,7L,5L,9L,7L,6L,7L,0L,7L,8L,5L,4L,9L,7L,6L,1L,1L,2L,8L,6L,4L,0L,3L,9L,0L,3L,9L,1L,2L,0L,2L,3L,9L,6L,2L,7L,2L,4L,9L,7L,5L,2L,9L,7L,0L,0L,4L,2L,7L,4L,9L,4L,9L,7L,9L,5L,3L,7L,5L,0L,6L,9L,6L,2L,0L,8L,5L,1L,9L,0L,4L,8L,6L,4L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195481Inst : IEnumerable<long>
{
public static readonly long[] Value=A195481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195481.Bytes);
public long this[int i]=>Value[i];

public static A195481Inst Instance=new A195481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195482
{
public static readonly long[] Value={ 6L,3L,5L,2L,6L,8L,6L,0L,4L,8L,3L,9L,3L,3L,6L,2L,1L,8L,8L,1L,1L,5L,0L,6L,2L,7L,8L,2L,7L,6L,4L,4L,5L,8L,5L,2L,0L,1L,9L,8L,1L,8L,7L,6L,3L,7L,9L,6L,2L,3L,1L,6L,4L,1L,6L,6L,5L,4L,9L,0L,3L,9L,5L,0L,9L,2L,3L,2L,4L,9L,7L,4L,7L,8L,4L,8L,9L,0L,1L,9L,2L,5L,2L,7L,0L,1L,9L,9L,5L,0L,1L,6L,9L,5L,6L,6L,2L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195482Inst : IEnumerable<long>
{
public static readonly long[] Value=A195482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195482.Bytes);
public long this[int i]=>Value[i];

public static A195482Inst Instance=new A195482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195483
{
public static readonly long[] Value={ 9L,0L,5L,3L,4L,7L,0L,9L,3L,0L,8L,3L,6L,4L,7L,2L,1L,7L,2L,3L,6L,0L,7L,6L,5L,7L,6L,7L,8L,5L,6L,8L,4L,5L,4L,6L,1L,7L,8L,0L,0L,6L,3L,3L,9L,6L,0L,4L,8L,0L,3L,3L,7L,3L,8L,2L,0L,9L,5L,3L,7L,3L,3L,6L,5L,1L,5L,7L,8L,5L,9L,6L,6L,5L,7L,7L,8L,9L,2L,5L,8L,5L,0L,0L,9L,0L,3L,9L,2L,4L,7L,4L,0L,7L,0L,6L,2L,6L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195483Inst : IEnumerable<long>
{
public static readonly long[] Value=A195483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195483.Bytes);
public long this[int i]=>Value[i];

public static A195483Inst Instance=new A195483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195484
{
public static readonly long[] Value={ 1L,7L,0L,6L,0L,4L,6L,3L,5L,0L,3L,4L,4L,2L,3L,2L,4L,4L,2L,2L,8L,5L,4L,1L,9L,9L,0L,4L,0L,9L,8L,4L,7L,0L,6L,0L,7L,6L,2L,3L,6L,8L,0L,2L,8L,8L,7L,3L,0L,0L,1L,5L,3L,3L,5L,0L,3L,6L,2L,4L,1L,9L,6L,8L,3L,9L,0L,7L,0L,1L,0L,6L,1L,2L,2L,0L,0L,2L,7L,4L,7L,9L,4L,9L,7L,7L,8L,4L,3L,2L,5L,8L,8L,0L,1L,6L,8L,6L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195484Inst : IEnumerable<long>
{
public static readonly long[] Value=A195484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195484.Bytes);
public long this[int i]=>Value[i];

public static A195484Inst Instance=new A195484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195485
{
public static readonly long[] Value={ 1L,2L,9L,4L,2L,3L,8L,9L,2L,3L,6L,9L,2L,2L,7L,3L,8L,7L,4L,3L,3L,4L,5L,6L,7L,8L,9L,9L,6L,5L,6L,5L,5L,0L,5L,9L,4L,6L,4L,0L,8L,1L,9L,5L,8L,2L,9L,5L,1L,9L,7L,0L,1L,8L,3L,0L,3L,2L,9L,5L,3L,4L,0L,2L,4L,7L,2L,2L,1L,7L,9L,1L,1L,7L,9L,0L,2L,0L,9L,5L,3L,6L,0L,0L,2L,8L,4L,7L,7L,3L,2L,3L,6L,3L,9L,2L,3L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195485Inst : IEnumerable<long>
{
public static readonly long[] Value=A195485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195485.Bytes);
public long this[int i]=>Value[i];

public static A195485Inst Instance=new A195485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195486
{
public static readonly long[] Value={ 6L,2L,0L,3L,3L,2L,2L,7L,2L,6L,5L,3L,0L,2L,5L,8L,3L,8L,0L,5L,5L,6L,8L,6L,8L,3L,7L,2L,0L,6L,0L,7L,6L,8L,8L,6L,4L,8L,3L,6L,1L,3L,4L,8L,2L,5L,4L,2L,4L,8L,1L,9L,1L,4L,6L,1L,8L,9L,3L,2L,4L,2L,5L,0L,2L,3L,7L,3L,1L,4L,7L,9L,0L,4L,8L,7L,0L,3L,3L,4L,1L,5L,9L,1L,5L,2L,4L,7L,6L,8L,7L,4L,2L,0L,1L,3L,7L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195486Inst : IEnumerable<long>
{
public static readonly long[] Value=A195486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195486.Bytes);
public long this[int i]=>Value[i];

public static A195486Inst Instance=new A195486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195487
{
public static readonly long[] Value={ 1L,6L,4L,8L,0L,4L,0L,7L,3L,4L,5L,9L,5L,5L,1L,8L,8L,1L,2L,3L,3L,0L,7L,4L,0L,7L,0L,0L,9L,4L,8L,4L,8L,8L,9L,2L,2L,2L,3L,4L,2L,5L,1L,2L,5L,1L,9L,9L,2L,0L,3L,5L,7L,8L,6L,0L,3L,5L,7L,3L,9L,0L,9L,3L,4L,3L,2L,9L,9L,6L,6L,9L,6L,6L,4L,8L,2L,3L,6L,9L,4L,9L,7L,1L,6L,9L,3L,2L,4L,3L,7L,6L,2L,1L,9L,6L,0L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195487Inst : IEnumerable<long>
{
public static readonly long[] Value=A195487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195487.Bytes);
public long this[int i]=>Value[i];

public static A195487Inst Instance=new A195487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195488
{
public static readonly long[] Value={ 2L,6L,5L,9L,6L,8L,4L,7L,2L,2L,7L,6L,3L,0L,1L,5L,7L,8L,2L,8L,6L,9L,3L,1L,5L,8L,7L,6L,5L,0L,6L,1L,2L,3L,1L,9L,7L,2L,2L,0L,9L,7L,7L,0L,3L,4L,5L,3L,4L,2L,9L,3L,4L,0L,4L,1L,2L,1L,6L,6L,2L,3L,1L,6L,8L,7L,6L,3L,1L,8L,7L,1L,6L,8L,8L,0L,8L,1L,7L,7L,1L,2L,0L,1L,7L,2L,9L,6L,9L,9L,7L,2L,9L,4L,0L,2L,1L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195488Inst : IEnumerable<long>
{
public static readonly long[] Value=A195488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195488.Bytes);
public long this[int i]=>Value[i];

public static A195488Inst Instance=new A195488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195489
{
public static readonly long[] Value={ 1L,8L,1L,7L,3L,6L,3L,6L,0L,0L,5L,7L,5L,5L,1L,7L,6L,2L,3L,7L,6L,2L,6L,3L,8L,9L,1L,1L,6L,4L,7L,5L,9L,5L,6L,6L,8L,5L,4L,1L,3L,7L,5L,2L,6L,2L,5L,3L,1L,7L,7L,8L,7L,3L,9L,7L,1L,8L,3L,3L,8L,4L,8L,0L,5L,1L,0L,8L,2L,7L,7L,5L,8L,9L,2L,3L,7L,3L,9L,2L,9L,8L,2L,4L,3L,6L,3L,5L,9L,0L,1L,2L,3L,5L,2L,5L,2L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195489Inst : IEnumerable<long>
{
public static readonly long[] Value=A195489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195489.Bytes);
public long this[int i]=>Value[i];

public static A195489Inst Instance=new A195489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195490
{
public static readonly long[] Value={ 6L,3L,5L,0L,0L,3L,8L,3L,3L,3L,3L,6L,2L,3L,7L,3L,5L,2L,4L,7L,0L,2L,1L,2L,1L,9L,0L,3L,6L,9L,3L,5L,0L,3L,5L,9L,3L,1L,9L,3L,7L,8L,2L,0L,9L,4L,7L,3L,1L,4L,8L,3L,5L,1L,7L,0L,6L,8L,1L,4L,0L,6L,5L,2L,9L,7L,0L,2L,5L,4L,4L,1L,6L,5L,9L,8L,5L,1L,3L,1L,3L,7L,7L,1L,4L,9L,2L,3L,0L,8L,8L,2L,4L,9L,0L,9L,4L,6L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195490Inst : IEnumerable<long>
{
public static readonly long[] Value=A195490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195490.Bytes);
public long this[int i]=>Value[i];

public static A195490Inst Instance=new A195490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195491
{
public static readonly long[] Value={ 6L,2L,9L,5L,8L,1L,0L,6L,1L,3L,8L,7L,7L,1L,6L,0L,4L,4L,0L,4L,5L,4L,9L,5L,8L,7L,5L,6L,8L,8L,5L,4L,0L,6L,9L,2L,2L,3L,1L,6L,8L,4L,9L,0L,8L,3L,8L,6L,6L,0L,7L,0L,2L,9L,6L,5L,1L,1L,2L,3L,1L,3L,4L,9L,6L,2L,5L,2L,6L,6L,6L,5L,0L,5L,1L,3L,5L,9L,2L,3L,4L,6L,8L,8L,9L,9L,4L,9L,2L,9L,6L,9L,8L,9L,0L,2L,8L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195491Inst : IEnumerable<long>
{
public static readonly long[] Value=A195491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195491.Bytes);
public long this[int i]=>Value[i];

public static A195491Inst Instance=new A195491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195492
{
public static readonly long[] Value={ 1L,0L,6L,8L,4L,7L,3L,0L,1L,7L,1L,9L,8L,6L,1L,0L,0L,3L,5L,7L,5L,3L,9L,8L,2L,0L,2L,5L,9L,9L,5L,6L,9L,6L,7L,6L,0L,9L,5L,0L,5L,7L,8L,8L,0L,8L,5L,2L,8L,7L,9L,5L,2L,7L,3L,0L,6L,8L,4L,1L,0L,7L,5L,1L,9L,4L,3L,6L,2L,1L,9L,6L,3L,2L,3L,0L,8L,7L,8L,6L,8L,7L,7L,9L,0L,6L,8L,1L,0L,2L,4L,5L,0L,6L,6L,9L,5L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195492Inst : IEnumerable<long>
{
public static readonly long[] Value=A195492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195492.Bytes);
public long this[int i]=>Value[i];

public static A195492Inst Instance=new A195492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195493
{
public static readonly long[] Value={ 7L,5L,9L,3L,1L,0L,7L,7L,8L,3L,7L,3L,7L,3L,4L,9L,5L,6L,8L,1L,1L,8L,4L,2L,6L,9L,0L,4L,9L,7L,7L,6L,7L,3L,6L,8L,7L,0L,2L,8L,5L,5L,3L,5L,3L,7L,4L,8L,7L,0L,3L,2L,3L,0L,0L,0L,4L,2L,2L,3L,8L,7L,9L,7L,5L,8L,9L,9L,1L,7L,4L,6L,7L,7L,7L,2L,2L,6L,0L,4L,6L,7L,1L,3L,9L,8L,3L,0L,8L,0L,4L,2L,3L,1L,3L,3L,2L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195493Inst : IEnumerable<long>
{
public static readonly long[] Value=A195493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195493.Bytes);
public long this[int i]=>Value[i];

public static A195493Inst Instance=new A195493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195494
{
public static readonly long[] Value={ 6L,3L,1L,7L,0L,4L,6L,2L,0L,4L,1L,6L,6L,7L,9L,6L,8L,2L,9L,8L,0L,6L,1L,4L,4L,4L,6L,4L,1L,6L,4L,7L,6L,0L,8L,3L,3L,4L,2L,8L,5L,0L,2L,9L,6L,8L,3L,1L,0L,3L,5L,0L,6L,6L,4L,3L,3L,8L,3L,1L,3L,0L,2L,6L,2L,7L,8L,1L,5L,8L,1L,7L,4L,0L,4L,4L,1L,6L,7L,8L,8L,4L,7L,9L,7L,0L,1L,9L,2L,0L,0L,2L,5L,2L,0L,4L,3L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195494Inst : IEnumerable<long>
{
public static readonly long[] Value=A195494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195494.Bytes);
public long this[int i]=>Value[i];

public static A195494Inst Instance=new A195494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195495
{
public static readonly long[] Value={ 4L,0L,5L,1L,7L,7L,8L,2L,9L,7L,2L,0L,5L,7L,1L,7L,7L,7L,8L,8L,0L,3L,0L,7L,3L,9L,4L,9L,8L,0L,5L,1L,4L,5L,8L,4L,6L,8L,8L,3L,2L,3L,9L,3L,7L,4L,0L,8L,9L,2L,3L,7L,6L,9L,9L,0L,7L,8L,5L,6L,5L,8L,0L,7L,3L,8L,9L,5L,8L,9L,0L,4L,6L,6L,4L,6L,2L,1L,3L,2L,6L,2L,2L,8L,4L,4L,7L,6L,8L,9L,3L,7L,6L,0L,2L,9L,7L,1L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195495Inst : IEnumerable<long>
{
public static readonly long[] Value=A195495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195495.Bytes);
public long this[int i]=>Value[i];

public static A195495Inst Instance=new A195495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195496
{
public static readonly long[] Value={ 1L,0L,1L,7L,1L,5L,3L,4L,4L,6L,7L,5L,4L,8L,0L,4L,4L,6L,6L,2L,5L,6L,7L,9L,8L,1L,8L,7L,8L,1L,6L,6L,0L,6L,3L,3L,6L,9L,7L,4L,3L,6L,7L,9L,8L,2L,5L,5L,3L,7L,4L,6L,3L,9L,5L,6L,4L,0L,3L,4L,9L,5L,5L,6L,1L,7L,5L,7L,7L,6L,1L,4L,7L,5L,2L,9L,8L,5L,3L,2L,8L,9L,2L,4L,2L,4L,6L,6L,6L,3L,7L,8L,4L,1L,8L,4L,8L,3L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195496Inst : IEnumerable<long>
{
public static readonly long[] Value=A195496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195496.Bytes);
public long this[int i]=>Value[i];

public static A195496Inst Instance=new A195496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195497
{
public static readonly long[] Value={ 8L,6L,2L,9L,6L,8L,7L,9L,2L,1L,4L,1L,0L,3L,7L,4L,3L,4L,1L,3L,6L,0L,1L,0L,4L,3L,3L,0L,1L,6L,1L,7L,3L,1L,2L,5L,4L,9L,8L,3L,6L,2L,2L,2L,5L,5L,0L,0L,4L,9L,0L,7L,6L,8L,0L,7L,3L,5L,7L,1L,1L,5L,5L,4L,5L,8L,2L,8L,9L,7L,8L,6L,0L,7L,8L,9L,7L,7L,8L,0L,1L,6L,6L,5L,7L,3L,0L,5L,7L,8L,9L,6L,9L,2L,3L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195497Inst : IEnumerable<long>
{
public static readonly long[] Value=A195497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195497.Bytes);
public long this[int i]=>Value[i];

public static A195497Inst Instance=new A195497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195498
{
public static readonly long[] Value={ 5L,7L,5L,9L,1L,5L,2L,3L,6L,5L,1L,3L,4L,8L,2L,3L,7L,3L,6L,1L,8L,7L,8L,7L,3L,6L,9L,1L,8L,7L,4L,1L,9L,9L,1L,8L,7L,6L,7L,2L,7L,0L,2L,3L,9L,6L,1L,3L,6L,8L,7L,5L,2L,7L,5L,5L,1L,8L,3L,3L,7L,7L,6L,9L,9L,0L,3L,4L,1L,9L,4L,4L,8L,1L,4L,5L,3L,5L,3L,8L,0L,7L,2L,2L,4L,9L,3L,7L,8L,8L,2L,0L,7L,2L,7L,0L,5L,4L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195498Inst : IEnumerable<long>
{
public static readonly long[] Value=A195498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195498.Bytes);
public long this[int i]=>Value[i];

public static A195498Inst Instance=new A195498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195499
{
public static readonly long[] Value={ 3L,8L,33L,120L,451L,1680L,6273L,23408L,87363L,326040L,1216801L,4541160L,16947843L,63250208L,236052993L,880961760L,3287794051L,12270214440L,45793063713L,170902040408L,637815097923L,2380358351280L,8883618307201L,33154114877520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195499Inst : IEnumerable<long>
{
public static readonly long[] Value=A195499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195499.Bytes);
public long this[int i]=>Value[i];

public static A195499Inst Instance=new A195499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195500
{
public static readonly long[] Value={ 3L,228L,308L,5289L,543900L,706180L,1244791L,51146940L,76205040L,114835995824L,106293119818725L,222582887719576L,3520995103197240L,17847666535865852L,18611596834765355L,106620725307595884L,269840171418387336L,357849299891217865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195500Inst : IEnumerable<long>
{
public static readonly long[] Value=A195500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195500.Bytes);
public long this[int i]=>Value[i];

public static A195500Inst Instance=new A195500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195501
{
public static readonly long[] Value={ 4L,325L,435L,7480L,769189L,998691L,1760400L,72332699L,107770201L,162402622743L,150321171634588L,314779738565193L,4979439027990791L,25240412071733925L,26320772661145332L,150784475760058387L,381611630092964177L,506075333191877232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195501Inst : IEnumerable<long>
{
public static readonly long[] Value=A195501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195501.Bytes);
public long this[int i]=>Value[i];

public static A195501Inst Instance=new A195501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195502
{
public static readonly long[] Value={ 5L,397L,533L,9161L,942061L,1223141L,2156041L,88589101L,131991001L,198901779305L,184105084021037L,385524870425705L,6098542411938841L,30913065236666477L,32236231327801693L,184672513372600885L,467376886819742065L,619813168864541257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195502Inst : IEnumerable<long>
{
public static readonly long[] Value=A195502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195502.Bytes);
public long this[int i]=>Value[i];

public static A195502Inst Instance=new A195502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195503
{
public static readonly long[] Value={ 4L,15L,56L,209L,780L,2911L,10864L,40545L,151316L,564719L,2107560L,7865521L,29354524L,109552575L,408855776L,1525870529L,5694626340L,21252634831L,79315912984L,296011017105L,1104728155436L,4122901604639L,15386878263120L,57424611447841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195503Inst : IEnumerable<long>
{
public static readonly long[] Value=A195503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195503.Bytes);
public long this[int i]=>Value[i];

public static A195503Inst Instance=new A195503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195504
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,6L,6L,6L,6L,60L,60L,720L,720L,10080L,10080L,10080L,10080L,181440L,181440L,3628800L,3628800L,79833600L,79833600L,79833600L,79833600L,2075673600L,2075673600L,58118860800L,58118860800L,1743565824000L,1743565824000L,1743565824000L,1743565824000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195504Inst : IEnumerable<long>
{
public static readonly long[] Value=A195504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195504.Bytes);
public long this[int i]=>Value[i];

public static A195504Inst Instance=new A195504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195505
{
public static readonly BigInteger[] Value={ 1L,11L,341L,2953L,388853L,403553L,142339079L,1163882707L,31983746689L,32452469713L,43725835522403L,44184852180503L,97954699428176291L,98731028315167091L,99421162547987123L,800313205356878959L,BigInteger.Parse("3953829021224881128767"),BigInteger.Parse("3973669953994085875967") };
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
public class A195505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195505Inst Instance=new A195505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195506
{
public static readonly BigInteger[] Value={ 1L,8L,216L,1728L,216000L,216000L,74088000L,592704000L,16003008000L,16003008000L,21300003648000L,21300003648000L,46796108014656000L,46796108014656000L,46796108014656000L,374368864117248000L,BigInteger.Parse("1839274229408039424000"),BigInteger.Parse("1839274229408039424000") };
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
public class A195506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195506Inst Instance=new A195506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195507
{
public static readonly long[] Value={ 2L,3L,5L,10L,17L,66L,67L,428L,849L,2530L,2531L,27732L,27733L,360374L,360375L,360376L,720737L,12252258L,12252259L,232792580L,232792581L,232792582L,232792583L,5354228904L,5354228905L,26771144426L,26771144427L,80313433228L,80313433229L,2329089562830L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195507Inst : IEnumerable<long>
{
public static readonly long[] Value=A195507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195507.Bytes);
public long this[int i]=>Value[i];

public static A195507Inst Instance=new A195507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195508
{
public static readonly long[] Value={ 1L,2L,3L,1L,5L,6L,1L,8L,9L,1L,11L,2L,1L,14L,15L,1L,2L,18L,1L,20L,21L,1L,23L,3L,1L,26L,2L,1L,29L,30L,1L,2L,33L,1L,35L,36L,1L,3L,39L,1L,41L,2L,1L,44L,3L,1L,2L,48L,1L,50L,51L,1L,53L,54L,1L,56L,2L,1L,3L,5L,1L,2L,63L,1L,65L,3L,1L,68L,69L,1L,5L,2L,1L,74L,75L,1L,2L,78L,1L,3L,81L,1L,83L,6L,1L,86L,2L,1L,89L,90L,1L,2L,5L,1L,95L,96L,1L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195508Inst : IEnumerable<long>
{
public static readonly long[] Value=A195508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195508.Bytes);
public long this[int i]=>Value[i];

public static A195508Inst Instance=new A195508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195509
{
public static readonly long[] Value={ 1L,1L,1L,4L,25L,96L,481L,3368L,20721L,141760L,1146721L,9098112L,77652169L,726208640L,6891125697L,69344336896L,738718169569L,8076031881216L,92647353941569L,1106883171037184L,13616813607795321L,174298975125127168L,2304515271134124577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195509Inst : IEnumerable<long>
{
public static readonly long[] Value=A195509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195509.Bytes);
public long this[int i]=>Value[i];

public static A195509Inst Instance=new A195509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195510
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,25L,156L,1561L,15968L,205521L,2996416L,48245521L,891169632L,17701061929L,390008578688L,9273243108585L,237666643184896L,6557636429111329L,192526245072832512L,6029011794295629217L,BigInteger.Parse("199832740470058237952"),BigInteger.Parse("7000664928137597341881") };
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
public class A195510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195510Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195510.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195510Inst Instance=new A195510Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195511
{
public static readonly BigInteger[] Value={ 1L,1L,3L,19L,197L,2801L,50407L,1098371L,28122761L,827684785L,27534518411L,1021777860995L,41847737874637L,1875044409274817L,91239372967844207L,4791502346638758931L,BigInteger.Parse("270114113377777911569"),BigInteger.Parse("16269795487513345957025"),BigInteger.Parse("1042794341136010753491475") };
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
public class A195511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195511Inst Instance=new A195511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195512
{
public static readonly BigInteger[] Value={ 1L,1L,3L,22L,269L,4426L,91567L,2289918L,67241113L,2268437842L,86469399731L,3675752021206L,172416288958597L,8846409344413434L,492872054023465495L,BigInteger.Parse("29633162309495166526"),BigInteger.Parse("1912378764997833270065"),BigInteger.Parse("131856366022646024614306"),BigInteger.Parse("9673570273675513393639387") };
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
public class A195512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195512Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195512.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195512Inst Instance=new A195512Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195513
{
public static readonly BigInteger[] Value={ 1L,1L,5L,55L,969L,23471L,722893L,27024719L,1188673041L,60146184799L,3441880575621L,219796618046831L,15495685980169849L,1195427487905706095L,BigInteger.Parse("100171535560697901693"),BigInteger.Parse("9060375019110233758111"),BigInteger.Parse("879801446255000326901025"),BigInteger.Parse("91290178606709678636278463") };
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
public class A195513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195513Inst Instance=new A195513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195514
{
public static readonly BigInteger[] Value={ 1L,1L,1L,7L,49L,431L,5281L,69735L,1163681L,21106783L,443495041L,10238783303L,261253326577L,7289538431631L,220029116061665L,7180115829246391L,250782957484550977L,9365723147426913215UL,BigInteger.Parse("371694221511705312769"),BigInteger.Parse("15638233703457023744679") };
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
public class A195514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195514Inst Instance=new A195514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195515
{
public static readonly BigInteger[] Value={ 1L,1L,3L,15L,199L,6247L,505623L,105997283L,58923059879L,87882127554983L,355824020816195749L,BigInteger.Parse("3945677945542866439849") };
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
public class A195515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195515Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195515.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195515Inst Instance=new A195515Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195516
{
public static readonly BigInteger[] Value={ 1L,1L,5L,65L,3753L,860017L,839301197L,3535646416019L,65638445025610187L,BigInteger.Parse("5443595184898837903553") };
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
public class A195516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195516Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195516.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195516Inst Instance=new A195516Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195517
{
public static readonly BigInteger[] Value={ 1L,1L,7L,175L,27267L,23663523L,122092290831L,3806404472713603L,BigInteger.Parse("731708552185212577507") };
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
public class A195517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195517Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195517.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195517Inst Instance=new A195517Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195518
{
public static readonly BigInteger[] Value={ 1L,1L,9L,369L,121367L,286168923L,5151383545261L,720374496860187931L,BigInteger.Parse("798423610752730381095001") };
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
public class A195518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195518Inst Instance=new A195518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195519
{
public static readonly BigInteger[] Value={ 1L,1L,11L,671L,401565L,2106810049L,103074513713971L,BigInteger.Parse("47878816111749257161") };
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
public class A195519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195519Inst Instance=new A195519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195520
{
public static readonly BigInteger[] Value={ 1L,1L,13L,1105L,1089411L,11131321791L,1252997799222737L,BigInteger.Parse("1582560262323178069903") };
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
public class A195520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195520Inst Instance=new A195520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195521
{
public static readonly BigInteger[] Value={ 1L,1L,15L,1695L,2563933L,46387885537L,10665939121760907L,BigInteger.Parse("31749804821289929290261") };
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
public class A195521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195521Inst Instance=new A195521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195522
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,5L,15L,1L,1L,7L,65L,199L,1L,1L,9L,175L,3753L,6247L,1L,1L,11L,369L,27267L,860017L,505623L,1L,1L,13L,671L,121367L,23663523L,839301197L,105997283L,1L,1L,15L,1105L,401565L,286168923L,122092290831L,3535646416019L,58923059879L,1L,1L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195522Inst : IEnumerable<long>
{
public static readonly long[] Value=A195522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195522.Bytes);
public long this[int i]=>Value[i];

public static A195522Inst Instance=new A195522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195523
{
public static readonly long[] Value={ 199L,3753L,27267L,121367L,401565L,1089411L,2563933L,5423365L,10557163L,19228309L,33165903L,54668043L,86714993L,133092639L,198526233L,288824425L,411033583L,573602401L,786556795L,1061685087L,1412733477L,1855611803L,2408609589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195523Inst : IEnumerable<long>
{
public static readonly long[] Value=A195523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195523.Bytes);
public long this[int i]=>Value[i];

public static A195523Inst Instance=new A195523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195524
{
public static readonly long[] Value={ 6247L,860017L,23663523L,286168923L,2106810049L,11131321791L,46387885537L,161770028369L,491117662815L,1334411256817L,3311007744155L,7616624997827L,16434220066785L,33565300493927L,65367853464305L,122110269851089L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195524Inst : IEnumerable<long>
{
public static readonly long[] Value=A195524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195524.Bytes);
public long this[int i]=>Value[i];

public static A195524Inst Instance=new A195524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195525
{
public static readonly BigInteger[] Value={ 505623L,839301197L,122092290831L,5151383545261L,103074513713971L,1252997799222737L,10665939121760907L,69488770600802237L,367679036207885407L,1647079991451268941L,6438544930173240123L,BigInteger.Parse("22466897655527435065") };
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
public class A195525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195525Inst Instance=new A195525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195526
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,15L,20L,40L,51L,55L,60L,90L,101L,105L,110L,150L,200L,400L,501L,505L,510L,550L,600L,900L,1001L,1005L,1010L,1050L,1100L,1500L,2000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195526Inst : IEnumerable<long>
{
public static readonly long[] Value=A195526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195526.Bytes);
public long this[int i]=>Value[i];

public static A195526Inst Instance=new A195526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195527
{
public static readonly long[] Value={ 15L,21L,28L,51L,55L,64L,70L,75L,78L,91L,96L,100L,111L,112L,117L,126L,135L,136L,141L,144L,145L,148L,154L,156L,165L,175L,176L,186L,189L,195L,201L,204L,216L,232L,235L,238L,246L,255L,256L,285L,286L,288L,291L,297L,300L,306L,315L,316L,321L,322L,324L,330L,333L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195527Inst : IEnumerable<long>
{
public static readonly long[] Value=A195527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195527.Bytes);
public long this[int i]=>Value[i];

public static A195527Inst Instance=new A195527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195528
{
public static readonly long[] Value={ 36L,45L,66L,81L,105L,120L,153L,171L,190L,196L,210L,261L,280L,351L,378L,396L,400L,405L,406L,456L,465L,477L,484L,496L,532L,576L,585L,606L,621L,630L,645L,666L,715L,726L,729L,736L,741L,742L,765L,780L,784L,801L,855L,876L,891L,910L,945L,960L,981L,1015L,1045L,1056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195528Inst : IEnumerable<long>
{
public static readonly long[] Value=A195528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195528.Bytes);
public long this[int i]=>Value[i];

public static A195528Inst Instance=new A195528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195529
{
public static readonly BigInteger[] Value={ 1L,256L,BigInteger.Parse("1333735776850284124449081472843776") };
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
public class A195529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195529Inst Instance=new A195529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195530
{
public static readonly BigInteger[] Value={ 2L,3L,7L,17L,179L,751L,6121L,12263L,49123L,393181L,50331599L,201326539L,13194139533227L,BigInteger.Parse("56668397794435742564203"),BigInteger.Parse("1856910058928070412348686157"),BigInteger.Parse("8769009823985417509222108996297698117935595257533"),BigInteger.Parse("4597486622597666575075041081450927550856217366550806167") };
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
public class A195530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195530Inst Instance=new A195530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195531
{
public static readonly long[] Value={ 5L,17L,65L,241L,901L,3361L,12545L,46817L,174725L,652081L,2433601L,9082321L,33895685L,126500417L,472105985L,1761923521L,6575588101L,24540428881L,91586127425L,341804080817L,1275630195845L,4760716702561L,17767236614401L,66308229755041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195531Inst : IEnumerable<long>
{
public static readonly long[] Value=A195531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195531.Bytes);
public long this[int i]=>Value[i];

public static A195531Inst Instance=new A195531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195532
{
public static readonly long[] Value={ 8L,5L,84L,2400L,1691L,11480L,118455L,352692L,1401961L,1663145124L,1802526192L,15798984680L,297278169720L,1479041362764L,1551248530483L,42254295673488L,1445285680561323L,28154300465964144L,49087267967218280L,373205366478956820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195532Inst : IEnumerable<long>
{
public static readonly long[] Value=A195532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195532.Bytes);
public long this[int i]=>Value[i];

public static A195532Inst Instance=new A195532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195533
{
public static readonly long[] Value={ 15L,12L,187L,5369L,3780L,25671L,264872L,788645L,3134880L,3718905557L,4030571095L,35327603721L,664734195719L,3307237028677L,3468697164156L,94483477467295L,3231757028642164L,62954929700849833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195533Inst : IEnumerable<long>
{
public static readonly long[] Value=A195533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195533.Bytes);
public long this[int i]=>Value[i];

public static A195533Inst Instance=new A195533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195534
{
public static readonly long[] Value={ 17L,13L,205L,5881L,4141L,28121L,290153L,863917L,3434089L,4073856925L,4415269417L,38699450921L,728179827481L,3622896647245L,3799767363925L,103501463840737L,3540212449926365L,68963670206614825L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195534Inst : IEnumerable<long>
{
public static readonly long[] Value=A195534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195534.Bytes);
public long this[int i]=>Value[i];

public static A195534Inst Instance=new A195534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195535
{
public static readonly long[] Value={ 5L,1020L,2247L,2633277900L,2640162496L,638843546289L,1396487515808L,6103353023795L,21860678072520L,82495605773137L,29466852345019792L,34041728665663572L,292320946605948260L,262936589866701605L,3964118460886936896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195535Inst : IEnumerable<long>
{
public static readonly long[] Value=A195535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195535.Bytes);
public long this[int i]=>Value[i];

public static A195535Inst Instance=new A195535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195536
{
public static readonly ulong[] Value={ 12L,2501L,5504L,6450187211L,6467050953L,1564840713880L,3420681845895L,14950100628372L,53547506708921L,202072140165984L,72178752571232415L,83384865193151005L,716037160311939339L,644060479880872908L,9710067509119990903UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195536Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A195536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195536.Bytes);
public ulong this[int i]=>Value[i];

public static A195536Inst Instance=new A195536Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195537
{
public static readonly ulong[] Value={ 13L,2701L,5945L,6966998461L,6985213385L,1690221150161L,3694758675833L,16147954264597L,57837917671129L,218262857131345L,77961963224782817L,90065948248084453L,773408527734329789L,695664827366678317L,10488071615106960265UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195537Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A195537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195537.Bytes);
public ulong this[int i]=>Value[i];

public static A195537Inst Instance=new A195537Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195538
{
public static readonly long[] Value={ 5L,12L,145L,420L,4901L,14280L,166465L,485112L,5654885L,16479540L,192099601L,559819260L,6525731525L,19017375312L,221682772225L,646030941360L,7530688524101L,21946034630940L,255821727047185L,745519146510612L,8690408031080165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195538Inst : IEnumerable<long>
{
public static readonly long[] Value=A195538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195538.Bytes);
public long this[int i]=>Value[i];

public static A195538Inst Instance=new A195538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195539
{
public static readonly long[] Value={ 12L,35L,408L,1189L,13860L,40391L,470832L,1372105L,15994428L,46611179L,543339720L,1583407981L,18457556052L,53789260175L,627013566048L,1827251437969L,21300003689580L,62072759630771L,723573111879672L,2108646576008245L,24580185800219268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195539Inst : IEnumerable<long>
{
public static readonly long[] Value=A195539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195539.Bytes);
public long this[int i]=>Value[i];

public static A195539Inst Instance=new A195539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195540
{
public static readonly long[] Value={ 13L,37L,433L,1261L,14701L,42841L,499393L,1455337L,16964653L,49438621L,576298801L,1679457781L,19577194573L,57052125937L,665048316673L,1938092824081L,22592065572301L,65838103892821L,767465181141553L,2236557439531837L,26071224093240493L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195540Inst : IEnumerable<long>
{
public static readonly long[] Value=A195540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195540.Bytes);
public long this[int i]=>Value[i];

public static A195540Inst Instance=new A195540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195541
{
public static readonly BigInteger[] Value={ 5L,12L,44L,51L,280L,949L,103488L,133416L,4142957L,81015132L,141119360L,2339121011L,22104171804L,658972588452L,461228244281L,3140753982224L,7467448353120L,49702513350325L,3912991025369532L,130254818350668557L,BigInteger.Parse("177768662787348689760") };
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
public class A195541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195541Inst Instance=new A195541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195542
{
public static readonly long[] Value={ 12L,35L,117L,140L,759L,2580L,281305L,362663L,11261724L,220221965L,383602191L,6358390140L,60085368547L,1791273212645L,1253748355200L,8537454477543L,20298629163241L,135105438868932L,10636612399185325L,354069305791856124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195542Inst : IEnumerable<long>
{
public static readonly long[] Value=A195542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195542.Bytes);
public long this[int i]=>Value[i];

public static A195542Inst Instance=new A195542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195543
{
public static readonly long[] Value={ 13L,37L,125L,149L,809L,2749L,299737L,386425L,11999605L,234651157L,408736241L,6774999061L,64022229925L,1908639461677L,1335895366969L,9096838161305L,21628618328809L,143957700194557L,11333535286711093L,377268327596543125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195543Inst : IEnumerable<long>
{
public static readonly long[] Value=A195543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195543.Bytes);
public long this[int i]=>Value[i];

public static A195543Inst Instance=new A195543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195544
{
public static readonly BigInteger[] Value={ 12L,52L,315L,1044L,3296L,20919L,217620L,450296L,125510644L,138980066871L,289898680472L,3593636117787L,34812833117460L,1934468176818608L,1244148342635075L,86081645453428848L,BigInteger.Parse("8659539839551787053788"),BigInteger.Parse("138771143651019468539176") };
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
public class A195544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195544Inst Instance=new A195544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195545
{
public static readonly BigInteger[] Value={ 35L,165L,988L,3283L,10353L,65720L,683669L,1414647L,394303317L,436618757080L,910743564855L,11289740827316L,109367740772459L,6077311012896585L,3908607293198268L,270433464965413295L,BigInteger.Parse("27204746743404031066765"),BigInteger.Parse("435962405424296640541743") };
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
public class A195545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195545Inst Instance=new A195545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195546
{
public static readonly BigInteger[] Value={ 37L,173L,1037L,3445L,10865L,68969L,717469L,1484585L,413797085L,458204537321L,955769368553L,11847888777965L,114774718781341L,6377764206569417L,4101843009053893L,283803292188743377L,BigInteger.Parse("28549708853253421989013"),BigInteger.Parse("457515736618480341666545") };
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
public class A195546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195546Inst Instance=new A195546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195547
{
public static readonly long[] Value={ 1L,4L,12L,15L,80L,208L,273L,1428L,3740L,4895L,25632L,67104L,87841L,459940L,1204140L,1576239L,8253296L,21607408L,28284465L,148099380L,387729212L,507544127L,2657535552L,6957518400L,9107509825L,47687540548L,124847601996L,163427632719L,855718194320L,2240299317520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195547Inst : IEnumerable<long>
{
public static readonly long[] Value=A195547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195547.Bytes);
public long this[int i]=>Value[i];

public static A195547Inst Instance=new A195547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195548
{
public static readonly long[] Value={ 0L,3L,5L,8L,39L,105L,136L,715L,1869L,2448L,12815L,33553L,43920L,229971L,602069L,788120L,4126647L,10803705L,14142232L,74049691L,193864605L,253772064L,1328767775L,3478759201L,4553754912L,23843770275L,62423800997L,81713816360L,427859097159L,1120149658761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195548Inst : IEnumerable<long>
{
public static readonly long[] Value=A195548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195548.Bytes);
public long this[int i]=>Value[i];

public static A195548Inst Instance=new A195548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195549
{
public static readonly long[] Value={ 1L,5L,13L,17L,89L,233L,305L,1597L,4181L,5473L,28657L,75025L,98209L,514229L,1346269L,1762289L,9227465L,24157817L,31622993L,165580141L,433494437L,567451585L,2971215073L,7778742049L,10182505537L,53316291173L,139583862445L,182717648081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195549Inst : IEnumerable<long>
{
public static readonly long[] Value=A195549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195549.Bytes);
public long this[int i]=>Value[i];

public static A195549Inst Instance=new A195549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195550
{
public static readonly long[] Value={ 3L,60L,660L,3597L,78480L,856080L,4669203L,101866380L,1111191780L,6060621597L,132222483360L,1442326073760L,7866682164003L,171624681534300L,1872138132549300L,10210947388253997L,222768704409038640L,2430033853722917040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195550Inst : IEnumerable<long>
{
public static readonly long[] Value=A195550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195550.Bytes);
public long this[int i]=>Value[i];

public static A195550Inst Instance=new A195550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195551
{
public static readonly long[] Value={ 4L,91L,989L,5396L,117719L,1284121L,7003804L,152799571L,1666787669L,9090932396L,198333725039L,2163489110641L,11800023246004L,257437022301451L,2808207198823949L,15316421082380996L,334153056613557959L,3645050780584375561L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195551Inst : IEnumerable<long>
{
public static readonly long[] Value=A195551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195551.Bytes);
public long this[int i]=>Value[i];

public static A195551Inst Instance=new A195551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195552
{
public static readonly long[] Value={ 5L,109L,1189L,6485L,141481L,1543321L,8417525L,183642229L,2003229469L,10925940965L,238367471761L,2600190307441L,14181862955045L,309400794703549L,3375045015828949L,18408047189707445L,401601993157734841L,4380805830355668361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195552Inst : IEnumerable<long>
{
public static readonly long[] Value=A195552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195552.Bytes);
public long this[int i]=>Value[i];

public static A195552Inst Instance=new A195552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195553
{
public static readonly BigInteger[] Value={ 5L,260L,7020L,94635L,5103280L,137599280L,1855038645L,100034487540L,2697221086300L,36362467421275L,1960876019662560L,52870927596046560L,712777084536797285L,BigInteger.Parse("38437091637391006820"),BigInteger.Parse("1036375920040483589580"),BigInteger.Parse("13971856374727832955915") };
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
public class A195553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195553Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195553.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195553Inst Instance=new A195553Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195554
{
public static readonly BigInteger[] Value={ 12L,651L,17549L,236588L,12758199L,343998201L,4637596612L,250086218851L,6743052715749L,90906168553188L,4902190049156399L,132177318990116401L,1781942711341993212L,BigInteger.Parse("96092729093477517051"),BigInteger.Parse("2590939800101208973949"),BigInteger.Parse("34929640936819582389788") };
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
public class A195554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195554Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195554.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195554Inst Instance=new A195554Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195555
{
public static readonly BigInteger[] Value={ 13L,701L,18901L,254813L,13741001L,370497401L,4994844413L,269351100901L,7262490035501L,97908939928813L,5279820266120401L,142359329305393201L,1919211035489748013L,BigInteger.Parse("103495036587140999501"),BigInteger.Parse("2790527565781827490501"),BigInteger.Parse("37620374619761100622013") };
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
public class A195555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A195555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A195555Inst Instance=new A195555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A195556
{
public static readonly long[] Value={ 1L,12L,24L,35L,468L,900L,1333L,17760L,34188L,50615L,674424L,1298232L,1922041L,25610340L,49298640L,72986939L,972518508L,1872050076L,2771581645L,36930092952L,71088604260L,105247115567L,1402371013680L,2699494911792L,3996618809905L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A195556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A195556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A195556Inst : IEnumerable<long>
{
public static readonly long[] Value=A195556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A195556.Bytes);
public long this[int i]=>Value[i];

public static A195556Inst Instance=new A195556Inst();

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