using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A024528
{
public static readonly BigInteger[] Value={ 1L,3L,11L,61L,457L,5237L,70391L,1226677L,23817373L,557499269L,16390571671L,514577415031L,19239924846277L,796257656832167L,34543329507310391L,1636619248175258407L,BigInteger.Parse("87355709935877186981"),BigInteger.Parse("5186576044693944076609") };
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
public class A024528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A024528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A024528Inst Instance=new A024528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024529
{
public static readonly BigInteger[] Value={ 1L,1L,5L,19L,163L,1583L,22889L,359083L,7333087L,158961311L,4832970889L,143352404329L,5504599450303L,218267839327613L,9689767354614569L,442336304335214713L,BigInteger.Parse("24058713912354871199"),BigInteger.Parse("1386874962351747356011") };
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
public class A024529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A024529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A024529Inst Instance=new A024529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024530
{
public static readonly BigInteger[] Value={ 1L,1L,11L,47L,727L,7141L,151427L,2366603L,64131559L,1636722341L,57208085801L,1916138684507L,85982424199597L,3392993977055461L,172553478253276697L,8530444564835173531L,BigInteger.Parse("535885387802465283059"),BigInteger.Parse("30766248305796169627529") };
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
public class A024530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A024530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A024530Inst Instance=new A024530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024531
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,16L,23L,32L,42L,55L,70L,87L,106L,126L,148L,173L,201L,230L,262L,296L,331L,369L,409L,452L,499L,548L,598L,650L,703L,758L,820L,883L,950L,1018L,1091L,1164L,1241L,1321L,1402L,1487L,1575L,1664L,1757L,1852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024531Inst : IEnumerable<long>
{
public static readonly long[] Value=A024531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024531.Bytes);
public long this[int i]=>Value[i];

public static A024531Inst Instance=new A024531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024532
{
public static readonly long[] Value={ 1L,5L,19L,56L,137L,297L,567L,1013L,1751L,2810L,4393L,6597L,9457L,13196L,18148L,24593L,32403L,42218L,54109L,68001L,84810L,104543L,127997L,156197L,188684L,225197L,266657L,312693L,364374L,426707L,496366L,574928L,660873L,759439L,866705L,985827L,1117711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024532Inst : IEnumerable<long>
{
public static readonly long[] Value=A024532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024532.Bytes);
public long this[int i]=>Value[i];

public static A024532Inst Instance=new A024532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024533
{
public static readonly long[] Value={ 2L,25L,147L,611L,2093L,5854L,14602L,34190L,71459L,142670L,267429L,467068L,781343L,1275325L,2032215L,3103197L,4653176L,6801969L,9651098L,13524668L,18613277L,25340193L,34304139L,45727138L,59855985L,77404844L,98634359L,124471595L,158146984L,198905326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024533Inst : IEnumerable<long>
{
public static readonly long[] Value=A024533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024533.Bytes);
public long this[int i]=>Value[i];

public static A024533Inst Instance=new A024533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024534
{
public static readonly long[] Value={ 1L,2L,5L,8L,12L,17L,23L,31L,40L,50L,62L,74L,88L,104L,122L,140L,160L,182L,204L,229L,255L,282L,312L,344L,376L,410L,444L,480L,520L,561L,604L,648L,696L,744L,794L,845L,899L,954L,1011L,1069L,1131L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024534Inst : IEnumerable<long>
{
public static readonly long[] Value=A024534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024534.Bytes);
public long this[int i]=>Value[i];

public static A024534Inst Instance=new A024534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024535
{
public static readonly long[] Value={ 0L,3L,13L,37L,87L,180L,341L,612L,1019L,1638L,2520L,3696L,5258L,7345L,10085L,13456L,17722L,22936L,29094L,36577L,45419L,55969L,68677L,83398L,100048L,119035L,140228L,164100L,192823L,225035L,261447L,301439L,347315L,397420L,453162L,514981L,582618L,657163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024535Inst : IEnumerable<long>
{
public static readonly long[] Value=A024535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024535.Bytes);
public long this[int i]=>Value[i];

public static A024535Inst Instance=new A024535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024536
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,10L,14L,19L,25L,32L,40L,49L,59L,70L,82L,95L,110L,125L,141L,159L,178L,197L,219L,242L,265L,290L,315L,341L,370L,400L,432L,464L,498L,534L,570L,608L,647L,688L,730L,773L,818L,863L,910L,957L,1007L,1060L,1114L,1168L,1224L,1281L,1338L,1398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024536Inst : IEnumerable<long>
{
public static readonly long[] Value=A024536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024536.Bytes);
public long this[int i]=>Value[i];

public static A024536Inst Instance=new A024536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024537
{
public static readonly long[] Value={ 1L,2L,4L,9L,21L,50L,120L,289L,697L,1682L,4060L,9801L,23661L,57122L,137904L,332929L,803761L,1940450L,4684660L,11309769L,27304197L,65918162L,159140520L,384199201L,927538921L,2239277042L,5406093004L,13051463049L,31509019101L,76069501250L,183648021600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024537Inst : IEnumerable<long>
{
public static readonly long[] Value=A024537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024537.Bytes);
public long this[int i]=>Value[i];

public static A024537Inst Instance=new A024537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024538
{
public static readonly long[] Value={ 2L,2L,12L,6L,70L,12L,7L,25L,12L,70L,19L,12L,33L,17L,70L,25L,408L,39L,21L,70L,30L,195L,43L,25L,70L,33L,146L,46L,2378L,70L,36L,125L,49L,408L,70L,39L,113L,51L,252L,70L,41L,105L,53L,195L,70L,854L,100L,54L,165L,70L,408L,96L,55L,146L,70L,285L,93L,2378L,134L,70L,228L,91L,660L,125L,70L,195L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024538Inst : IEnumerable<long>
{
public static readonly long[] Value=A024538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024538.Bytes);
public long this[int i]=>Value[i];

public static A024538Inst Instance=new A024538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024539
{
public static readonly long[] Value={ 2L,1L,4L,1L,14L,2L,1L,3L,1L,7L,1L,1L,2L,1L,4L,1L,24L,2L,1L,3L,1L,8L,1L,1L,2L,1L,5L,1L,82L,2L,1L,3L,1L,12L,2L,1L,3L,1L,6L,1L,1L,2L,1L,4L,1L,18L,2L,1L,3L,1L,8L,1L,1L,2L,1L,5L,1L,41L,2L,1L,3L,1L,10L,1L,1L,2L,1L,6L,1L,1L,2L,1L,4L,1L,15L,2L,1L,3L,1L,7L,1L,1L,2L,1L,4L,1L,27L,2L,1L,3L,1L,9L,1L,1L,2L,1L,5L,1L,140L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024539Inst : IEnumerable<long>
{
public static readonly long[] Value=A024539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024539.Bytes);
public long this[int i]=>Value[i];

public static A024539Inst Instance=new A024539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024540
{
public static readonly long[] Value={ 2L,3L,7L,8L,22L,24L,25L,28L,29L,36L,37L,38L,40L,41L,45L,46L,70L,72L,73L,76L,77L,85L,86L,87L,89L,90L,95L,96L,178L,180L,181L,184L,185L,197L,199L,200L,203L,204L,210L,211L,212L,214L,215L,219L,220L,238L,240L,241L,244L,245L,253L,254L,255L,257L,258L,263L,264L,305L,307L,308L,311L,312L,322L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024540Inst : IEnumerable<long>
{
public static readonly long[] Value=A024540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024540.Bytes);
public long this[int i]=>Value[i];

public static A024540Inst Instance=new A024540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024541
{
public static readonly long[] Value={ 2L,3L,7L,9L,23L,25L,26L,29L,31L,38L,39L,40L,43L,44L,49L,51L,75L,77L,78L,81L,83L,92L,94L,95L,98L,99L,104L,106L,188L,190L,191L,195L,197L,209L,211L,212L,215L,216L,223L,225L,226L,228L,229L,234L,235L,254L,256L,257L,261L,262L,270L,272L,273L,276L,277L,282L,284L,325L,327L,328L,332L,333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024541Inst : IEnumerable<long>
{
public static readonly long[] Value=A024541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024541.Bytes);
public long this[int i]=>Value[i];

public static A024541Inst Instance=new A024541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024542
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,4L,4L,4L,4L,5L,6L,6L,6L,6L,7L,7L,8L,8L,8L,9L,9L,10L,7L,7L,8L,8L,11L,11L,12L,12L,12L,12L,12L,12L,11L,12L,14L,14L,15L,15L,16L,16L,14L,14L,17L,18L,17L,17L,15L,15L,19L,20L,20L,20L,13L,13L,13L,14L,22L,22L,22L,22L,23L,23L,18L,18L,24L,24L,25L,25L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024542Inst : IEnumerable<long>
{
public static readonly long[] Value=A024542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024542.Bytes);
public long this[int i]=>Value[i];

public static A024542Inst Instance=new A024542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024543
{
public static readonly long[] Value={ 1L,4L,24L,4L,9L,24L,7L,12L,24L,140L,14L,24L,67L,15L,24L,51L,816L,24L,43L,140L,24L,39L,87L,24L,36L,67L,293L,35L,57L,140L,33L,51L,98L,816L,46L,78L,227L,43L,67L,140L,41L,60L,106L,390L,54L,87L,200L,51L,75L,140L,816L,67L,111L,293L,61L,93L,186L,4756L,82L,140L,456L,73L,115L,251L,67L,98L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024543Inst : IEnumerable<long>
{
public static readonly long[] Value=A024543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024543.Bytes);
public long this[int i]=>Value[i];

public static A024543Inst Instance=new A024543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024544
{
public static readonly long[] Value={ 1L,2L,8L,1L,1L,4L,1L,1L,2L,14L,1L,2L,5L,1L,1L,3L,48L,1L,2L,7L,1L,1L,3L,1L,1L,2L,10L,1L,1L,4L,1L,1L,2L,24L,1L,2L,6L,1L,1L,3L,1L,1L,2L,8L,1L,1L,4L,1L,1L,2L,16L,1L,2L,5L,1L,1L,3L,82L,1L,2L,7L,1L,1L,3L,1L,1L,2L,12L,1L,2L,4L,1L,1L,3L,30L,1L,2L,6L,1L,1L,3L,1L,1L,2L,9L,1L,1L,4L,1L,1L,2L,18L,1L,2L,5L,1L,1L,3L,280L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024544Inst : IEnumerable<long>
{
public static readonly long[] Value=A024544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024544.Bytes);
public long this[int i]=>Value[i];

public static A024544Inst Instance=new A024544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024545
{
public static readonly long[] Value={ 1L,3L,11L,12L,13L,17L,18L,19L,21L,35L,36L,38L,43L,44L,45L,48L,96L,97L,99L,106L,107L,108L,111L,112L,113L,115L,125L,126L,127L,131L,132L,133L,135L,159L,160L,162L,168L,169L,170L,173L,174L,175L,177L,185L,186L,187L,191L,192L,193L,195L,211L,212L,214L,219L,220L,221L,224L,306L,307L,309L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024545Inst : IEnumerable<long>
{
public static readonly long[] Value=A024545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024545.Bytes);
public long this[int i]=>Value[i];

public static A024545Inst Instance=new A024545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024546
{
public static readonly long[] Value={ 1L,3L,12L,13L,15L,19L,20L,21L,24L,38L,39L,42L,47L,48L,49L,53L,101L,102L,104L,111L,113L,114L,118L,119L,121L,123L,134L,135L,137L,142L,143L,145L,148L,172L,173L,175L,181L,183L,184L,188L,189L,190L,193L,202L,203L,205L,209L,210L,212L,214L,230L,232L,234L,239L,240L,242L,245L,327L,329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024546Inst : IEnumerable<long>
{
public static readonly long[] Value=A024546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024546.Bytes);
public long this[int i]=>Value[i];

public static A024546Inst Instance=new A024546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024547
{
public static readonly long[] Value={ 1L,4L,15L,4L,7L,15L,56L,9L,15L,31L,209L,15L,25L,56L,15L,22L,38L,101L,20L,31L,56L,209L,27L,42L,82L,780L,35L,56L,126L,31L,44L,75L,209L,38L,56L,101L,430L,46L,70L,141L,2911L,56L,89L,209L,47L,68L,115L,346L,56L,82L,152L,780L,66L,101L,209L,56L,78L,126L,308L,65L,93L,160L,528L,75L,111L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024547Inst : IEnumerable<long>
{
public static readonly long[] Value=A024547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024547.Bytes);
public long this[int i]=>Value[i];

public static A024547Inst Instance=new A024547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024548
{
public static readonly long[] Value={ 1L,2L,5L,1L,1L,2L,8L,1L,1L,3L,19L,1L,1L,4L,1L,1L,2L,5L,1L,1L,2L,9L,1L,1L,3L,30L,1L,2L,4L,1L,1L,2L,6L,1L,1L,2L,11L,1L,1L,3L,71L,1L,2L,4L,1L,1L,2L,7L,1L,1L,2L,15L,1L,1L,3L,1L,1L,2L,5L,1L,1L,2L,8L,1L,1L,3L,21L,1L,1L,4L,1L,1L,2L,5L,1L,1L,2L,10L,1L,1L,3L,35L,1L,2L,4L,1L,1L,2L,6L,1L,1L,2L,12L,1L,1L,3L,112L,1L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024548Inst : IEnumerable<long>
{
public static readonly long[] Value=A024548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024548.Bytes);
public long this[int i]=>Value[i];

public static A024548Inst Instance=new A024548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024549
{
public static readonly long[] Value={ 1L,3L,8L,9L,10L,12L,20L,21L,22L,25L,44L,45L,46L,50L,51L,52L,54L,59L,60L,61L,63L,72L,73L,74L,77L,107L,108L,110L,114L,115L,116L,118L,124L,125L,126L,128L,139L,140L,141L,144L,215L,216L,218L,222L,223L,224L,226L,233L,234L,235L,237L,252L,253L,254L,257L,258L,259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024549Inst : IEnumerable<long>
{
public static readonly long[] Value=A024549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024549.Bytes);
public long this[int i]=>Value[i];

public static A024549Inst Instance=new A024549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024550
{
public static readonly long[] Value={ 1L,3L,8L,9L,11L,13L,21L,22L,24L,27L,46L,48L,50L,54L,55L,56L,58L,64L,65L,67L,69L,79L,80L,82L,85L,115L,116L,118L,123L,124L,125L,128L,134L,135L,137L,139L,151L,152L,154L,158L,229L,230L,232L,237L,238L,239L,242L,249L,250L,252L,255L,270L,271L,273L,277L,278L,279L,281L,287L,288L,289L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024550Inst : IEnumerable<long>
{
public static readonly long[] Value=A024550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024550.Bytes);
public long this[int i]=>Value[i];

public static A024550Inst Instance=new A024550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024551
{
public static readonly long[] Value={ 1L,4L,16L,67L,283L,1198L,5074L,21493L,91045L,385672L,1633732L,6920599L,29316127L,124185106L,526056550L,2228411305L,9439701769L,39987218380L,169388575288L,717541519531L,3039554653411L,12875760133174L,54542595186106L,231046140877597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024551Inst : IEnumerable<long>
{
public static readonly long[] Value=A024551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024551.Bytes);
public long this[int i]=>Value[i];

public static A024551Inst Instance=new A024551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024552
{
public static readonly long[] Value={ 4L,4L,4L,4L,27L,14L,10L,9L,72L,27L,18L,14L,188L,45L,27L,20L,1292L,72L,39L,27L,21L,113L,53L,36L,27L,188L,72L,45L,34L,365L,97L,57L,41L,1292L,133L,72L,50L,39L,188L,90L,60L,45L,284L,113L,72L,53L,493L,144L,86L,62L,1292L,188L,103L,72L,55L,254L,125L,83L,63L,365L,152L,97L,72L,590L,188L,113L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024552Inst : IEnumerable<long>
{
public static readonly long[] Value=A024552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024552.Bytes);
public long this[int i]=>Value[i];

public static A024552Inst Instance=new A024552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024553
{
public static readonly long[] Value={ 4L,2L,1L,1L,5L,2L,1L,1L,8L,2L,1L,1L,14L,3L,1L,1L,76L,4L,2L,1L,1L,5L,2L,1L,1L,7L,2L,1L,1L,12L,3L,1L,1L,38L,3L,2L,1L,1L,4L,2L,1L,1L,6L,2L,1L,1L,10L,3L,1L,1L,25L,3L,1L,1L,1L,4L,2L,1L,1L,6L,2L,1L,1L,9L,2L,1L,1L,19L,3L,1L,1L,1L,4L,2L,1L,1L,5L,2L,1L,1L,8L,2L,1L,1L,15L,3L,1L,1L,99L,4L,2L,1L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024553Inst : IEnumerable<long>
{
public static readonly long[] Value=A024553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024553.Bytes);
public long this[int i]=>Value[i];

public static A024553Inst Instance=new A024553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024554
{
public static readonly long[] Value={ 4L,6L,7L,8L,13L,15L,16L,17L,25L,27L,28L,29L,43L,46L,47L,48L,124L,128L,130L,131L,132L,137L,139L,140L,141L,148L,150L,151L,152L,164L,167L,168L,169L,207L,210L,212L,213L,214L,218L,220L,221L,222L,228L,230L,231L,232L,242L,245L,246L,247L,272L,275L,276L,277L,278L,282L,284L,285L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024554Inst : IEnumerable<long>
{
public static readonly long[] Value=A024554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024554.Bytes);
public long this[int i]=>Value[i];

public static A024554Inst Instance=new A024554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024555
{
public static readonly long[] Value={ 4L,6L,7L,8L,14L,16L,18L,19L,27L,30L,31L,33L,47L,50L,52L,54L,130L,134L,136L,137L,138L,143L,146L,147L,148L,155L,158L,160L,161L,173L,176L,178L,179L,217L,221L,223L,225L,226L,230L,233L,234L,235L,242L,244L,246L,247L,258L,261L,262L,264L,289L,293L,295L,296L,297L,302L,304L,305L,306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024555Inst : IEnumerable<long>
{
public static readonly long[] Value=A024555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024555.Bytes);
public long this[int i]=>Value[i];

public static A024555Inst Instance=new A024555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024556
{
public static readonly long[] Value={ 15L,21L,33L,35L,39L,51L,55L,57L,65L,69L,77L,85L,87L,91L,93L,95L,105L,111L,115L,119L,123L,129L,133L,141L,143L,145L,155L,159L,161L,165L,177L,183L,185L,187L,195L,201L,203L,205L,209L,213L,215L,217L,219L,221L,231L,235L,237L,247L,249L,253L,255L,259L,265L,267L,273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024556Inst : IEnumerable<long>
{
public static readonly long[] Value=A024556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024556.Bytes);
public long this[int i]=>Value[i];

public static A024556Inst Instance=new A024556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024557
{
public static readonly long[] Value={ 1L,2L,4L,8L,17L,37L,82L,182L,404L,898L,1997L,4442L,9882L,21984L,48908L,108807L,242067L,538537L,1198107L,2665482L,5930017L,13192774L,29350556L,65297498L,145270273L,323189294L,719013724L,1599622094L,3558751049L,7917313144L,17614001812L,39186660195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024557Inst : IEnumerable<long>
{
public static readonly long[] Value=A024557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024557.Bytes);
public long this[int i]=>Value[i];

public static A024557Inst Instance=new A024557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024558
{
public static readonly long[] Value={ 2L,2L,8L,5L,20L,8L,47L,13L,198L,20L,11L,30L,15L,47L,20L,83L,26L,198L,35L,20L,47L,24L,67L,30L,105L,37L,198L,47L,823L,61L,33L,83L,39L,120L,47L,198L,58L,471L,73L,40L,95L,47L,131L,56L,198L,67L,372L,83L,1960L,105L,55L,139L,64L,198L,76L,326L,91L,823L,113L,61L,145L,71L,198L,83L,299L,99L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024558Inst : IEnumerable<long>
{
public static readonly long[] Value=A024558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024558.Bytes);
public long this[int i]=>Value[i];

public static A024558Inst Instance=new A024558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024559
{
public static readonly long[] Value={ 2L,1L,2L,1L,4L,1L,6L,1L,22L,2L,1L,2L,1L,3L,1L,5L,1L,11L,1L,1L,2L,1L,2L,1L,4L,1L,7L,1L,28L,2L,1L,2L,1L,3L,1L,5L,1L,12L,1L,1L,2L,1L,3L,1L,4L,1L,7L,1L,40L,2L,1L,2L,1L,3L,1L,5L,1L,14L,1L,1L,2L,1L,3L,1L,4L,1L,8L,1L,67L,2L,1L,2L,1L,3L,1L,6L,1L,16L,1L,1L,2L,1L,3L,1L,4L,1L,9L,1L,218L,2L,1L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024559Inst : IEnumerable<long>
{
public static readonly long[] Value=A024559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024559.Bytes);
public long this[int i]=>Value[i];

public static A024559Inst Instance=new A024559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024560
{
public static readonly long[] Value={ 2L,3L,5L,6L,10L,11L,17L,18L,40L,42L,43L,45L,46L,49L,50L,55L,56L,67L,68L,69L,71L,72L,74L,75L,79L,80L,87L,88L,116L,118L,119L,121L,122L,125L,126L,131L,132L,144L,145L,146L,148L,149L,152L,153L,157L,158L,165L,166L,206L,208L,209L,211L,212L,215L,216L,221L,222L,236L,237L,238L,240L,241L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024560Inst : IEnumerable<long>
{
public static readonly long[] Value=A024560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024560.Bytes);
public long this[int i]=>Value[i];

public static A024560Inst Instance=new A024560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024561
{
public static readonly long[] Value={ 2L,3L,6L,7L,11L,12L,19L,21L,43L,45L,46L,49L,50L,53L,55L,60L,61L,72L,74L,75L,77L,79L,82L,83L,87L,88L,96L,98L,126L,128L,129L,132L,133L,136L,138L,143L,145L,157L,159L,160L,163L,164L,167L,168L,172L,174L,182L,184L,224L,226L,227L,229L,231L,234L,236L,242L,243L,257L,259L,260L,263L,264L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024561Inst : IEnumerable<long>
{
public static readonly long[] Value=A024561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024561.Bytes);
public long this[int i]=>Value[i];

public static A024561Inst Instance=new A024561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024562
{
public static readonly long[] Value={ 1L,2L,4L,9L,20L,44L,98L,218L,485L,1079L,2400L,5339L,11878L,26426L,58791L,130795L,290986L,647370L,1440233L,3204151L,7128419L,15858914L,35282038L,78493533L,174628085L,388502937L,864319917L,1922891303L,4277942565L,9517330782L,21173632847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024562Inst : IEnumerable<long>
{
public static readonly long[] Value=A024562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024562.Bytes);
public long this[int i]=>Value[i];

public static A024562Inst Instance=new A024562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024563
{
public static readonly long[] Value={ 1L,6L,3L,6L,21L,6L,13L,48L,11L,21L,106L,16L,32L,345L,21L,48L,17L,28L,70L,21L,37L,106L,26L,48L,173L,32L,62L,345L,39L,80L,1694L,48L,106L,35L,58L,145L,41L,70L,211L,48L,86L,345L,56L,106L,765L,65L,134L,48L,76L,173L,54L,89L,235L,62L,106L,345L,70L,127L,593L,80L,156L,1694L,92L,195L,66L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024563Inst : IEnumerable<long>
{
public static readonly long[] Value=A024563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024563.Bytes);
public long this[int i]=>Value[i];

public static A024563Inst Instance=new A024563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024564
{
public static readonly long[] Value={ 1L,3L,1L,1L,4L,1L,1L,6L,1L,2L,9L,1L,2L,24L,1L,3L,1L,1L,3L,1L,1L,4L,1L,2L,6L,1L,2L,12L,1L,2L,54L,1L,3L,1L,1L,4L,1L,1L,5L,1L,2L,8L,1L,2L,17L,1L,2L,1L,1L,3L,1L,1L,4L,1L,1L,6L,1L,2L,10L,1L,2L,27L,1L,3L,1L,1L,3L,1L,1L,4L,1L,2L,7L,1L,2L,12L,1L,2L,69L,1L,3L,1L,1L,4L,1L,1L,5L,1L,2L,8L,1L,2L,18L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024564Inst : IEnumerable<long>
{
public static readonly long[] Value=A024564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024564.Bytes);
public long this[int i]=>Value[i];

public static A024564Inst Instance=new A024564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024565
{
public static readonly long[] Value={ 1L,4L,5L,6L,10L,11L,12L,18L,19L,21L,30L,31L,33L,57L,58L,61L,62L,63L,66L,67L,68L,72L,73L,75L,81L,82L,84L,96L,97L,99L,153L,154L,157L,158L,159L,163L,164L,165L,170L,171L,173L,181L,182L,184L,201L,202L,204L,205L,206L,209L,210L,211L,215L,216L,217L,223L,224L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024565Inst : IEnumerable<long>
{
public static readonly long[] Value=A024565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024565.Bytes);
public long this[int i]=>Value[i];

public static A024565Inst Instance=new A024565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024566
{
public static readonly long[] Value={ 1L,4L,6L,7L,12L,13L,15L,21L,22L,24L,34L,35L,38L,62L,64L,67L,68L,69L,73L,74L,76L,81L,82L,84L,91L,92L,95L,107L,108L,111L,166L,167L,170L,171L,173L,177L,178L,180L,186L,187L,189L,197L,198L,201L,218L,219L,222L,223L,225L,228L,229L,231L,235L,237L,238L,245L,246L,248L,258L,259L,262L,289L,291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024566Inst : IEnumerable<long>
{
public static readonly long[] Value=A024566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024566.Bytes);
public long this[int i]=>Value[i];

public static A024566Inst Instance=new A024566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024567
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,19L,29L,45L,70L,108L,167L,259L,401L,621L,962L,1490L,2307L,3573L,5533L,8568L,13268L,20547L,31819L,49274L,76305L,118165L,182988L,283372L,438825L,679557L,1052351L,1629654L,2523656L,3908093L,6052009L,9372043L,14513394L,22475206L,34804739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024567Inst : IEnumerable<long>
{
public static readonly long[] Value=A024567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024567.Bytes);
public long this[int i]=>Value[i];

public static A024567Inst Instance=new A024567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024568
{
public static readonly long[] Value={ 1L,8L,3L,8L,55L,8L,21L,8L,16L,55L,13L,28L,377L,21L,55L,18L,33L,144L,25L,55L,21L,36L,107L,28L,55L,377L,39L,91L,31L,55L,194L,41L,83L,2584L,55L,144L,42L,78L,377L,55L,120L,43L,74L,227L,55L,107L,987L,72L,172L,55L,98L,377L,70L,144L,55L,91L,250L,68L,127L,731L,87L,194L,67L,115L,377L,83L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024568Inst : IEnumerable<long>
{
public static readonly long[] Value=A024568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024568.Bytes);
public long this[int i]=>Value[i];

public static A024568Inst Instance=new A024568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024569
{
public static readonly long[] Value={ 1L,4L,1L,2L,11L,1L,3L,1L,1L,5L,1L,2L,29L,1L,3L,1L,1L,8L,1L,2L,1L,1L,4L,1L,2L,14L,1L,3L,1L,1L,6L,1L,2L,76L,1L,4L,1L,2L,9L,1L,2L,1L,1L,5L,1L,2L,21L,1L,3L,1L,1L,7L,1L,2L,1L,1L,4L,1L,2L,12L,1L,3L,1L,1L,5L,1L,2L,38L,1L,3L,1L,2L,8L,1L,2L,1L,1L,4L,1L,2L,16L,1L,3L,1L,1L,6L,1L,2L,199L,1L,4L,1L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024569Inst : IEnumerable<long>
{
public static readonly long[] Value=A024569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024569.Bytes);
public long this[int i]=>Value[i];

public static A024569Inst Instance=new A024569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024570
{
public static readonly long[] Value={ 1L,5L,6L,8L,19L,20L,23L,24L,25L,30L,31L,33L,62L,63L,66L,67L,68L,76L,77L,79L,80L,81L,85L,86L,88L,102L,103L,106L,107L,108L,114L,115L,117L,193L,194L,198L,199L,201L,210L,211L,213L,214L,215L,220L,221L,223L,244L,245L,248L,249L,250L,257L,258L,260L,261L,262L,266L,267L,269L,281L,282L,285L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024570Inst : IEnumerable<long>
{
public static readonly long[] Value=A024570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024570.Bytes);
public long this[int i]=>Value[i];

public static A024570Inst Instance=new A024570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024571
{
public static readonly long[] Value={ 1L,5L,7L,9L,20L,21L,24L,25L,27L,33L,34L,36L,65L,67L,71L,72L,74L,82L,83L,86L,87L,88L,93L,94L,97L,111L,112L,116L,117L,119L,125L,126L,129L,205L,206L,210L,212L,214L,223L,225L,228L,229L,230L,236L,237L,239L,260L,262L,265L,266L,268L,275L,277L,279L,280L,282L,287L,288L,290L,302L,303L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024571Inst : IEnumerable<long>
{
public static readonly long[] Value=A024571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024571.Bytes);
public long this[int i]=>Value[i];

public static A024571Inst Instance=new A024571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024572
{
public static readonly long[] Value={ 1L,4L,19L,4L,8L,19L,250L,10L,19L,54L,12L,19L,38L,250L,19L,32L,80L,19L,29L,54L,250L,27L,44L,100L,26L,38L,68L,250L,34L,54L,116L,32L,46L,80L,250L,41L,64L,128L,3002L,54L,91L,250L,48L,72L,139L,1122L,61L,100L,250L,54L,80L,148L,768L,68L,108L,250L,60L,87L,155L,619L,74L,116L,250L,65L,94L,162L,536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024572Inst : IEnumerable<long>
{
public static readonly long[] Value=A024572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024572.Bytes);
public long this[int i]=>Value[i];

public static A024572Inst Instance=new A024572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024573
{
public static readonly long[] Value={ 1L,2L,6L,1L,1L,3L,35L,1L,2L,5L,1L,1L,2L,17L,1L,2L,4L,1L,1L,2L,11L,1L,1L,4L,1L,1L,2L,8L,1L,1L,3L,1L,1L,2L,7L,1L,1L,3L,76L,1L,2L,5L,1L,1L,3L,24L,1L,2L,5L,1L,1L,2L,14L,1L,1L,4L,1L,1L,2L,10L,1L,1L,3L,1L,1L,2L,8L,1L,1L,3L,1L,1L,2L,6L,1L,1L,3L,38L,1L,2L,5L,1L,1L,2L,18L,1L,2L,4L,1L,1L,2L,12L,1L,1L,4L,1L,1L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024573Inst : IEnumerable<long>
{
public static readonly long[] Value=A024573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024573.Bytes);
public long this[int i]=>Value[i];

public static A024573Inst Instance=new A024573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024574
{
public static readonly long[] Value={ 1L,3L,9L,10L,11L,14L,49L,50L,52L,57L,58L,59L,61L,78L,79L,81L,85L,86L,87L,89L,100L,101L,102L,106L,107L,108L,110L,118L,119L,120L,123L,124L,125L,127L,134L,135L,136L,139L,215L,216L,218L,223L,224L,225L,228L,252L,253L,255L,260L,261L,262L,264L,278L,279L,280L,284L,285L,286L,288L,298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024574Inst : IEnumerable<long>
{
public static readonly long[] Value=A024574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024574.Bytes);
public long this[int i]=>Value[i];

public static A024574Inst Instance=new A024574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024575
{
public static readonly long[] Value={ 1L,3L,10L,11L,12L,16L,51L,53L,55L,60L,62L,63L,66L,84L,85L,87L,92L,93L,95L,97L,109L,111L,112L,117L,118L,119L,122L,131L,132L,134L,137L,138L,140L,142L,149L,151L,152L,156L,233L,234L,236L,242L,243L,245L,248L,273L,274L,276L,281L,282L,284L,287L,301L,302L,304L,309L,310L,311L,314L,324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024575Inst : IEnumerable<long>
{
public static readonly long[] Value=A024575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024575.Bytes);
public long this[int i]=>Value[i];

public static A024575Inst Instance=new A024575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024576
{
public static readonly long[] Value={ 1L,2L,5L,13L,35L,95L,258L,701L,1905L,5178L,14075L,38259L,103998L,282695L,768444L,2088847L,5678074L,15434605L,41955606L,114047161L,310012325L,842700869L,2290698459L,6226763995L,16926099417L,46009908471L,125067898125L,339969794796L,924133715418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024576Inst : IEnumerable<long>
{
public static readonly long[] Value=A024576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024576.Bytes);
public long this[int i]=>Value[i];

public static A024576Inst Instance=new A024576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024577
{
public static readonly long[] Value={ 2L,2L,28L,8L,5L,28L,12L,8L,28L,14L,235L,28L,16L,93L,28L,18L,66L,28L,19L,55L,28L,235L,49L,28L,126L,46L,28L,93L,43L,824L,76L,41L,235L,66L,39L,147L,60L,38L,112L,55L,493L,93L,52L,235L,81L,49L,161L,72L,1877L,126L,66L,400L,106L,62L,235L,93L,58L,172L,83L,824L,138L,76L,357L,117L,71L,235L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024577Inst : IEnumerable<long>
{
public static readonly long[] Value=A024577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024577.Bytes);
public long this[int i]=>Value[i];

public static A024577Inst Instance=new A024577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024578
{
public static readonly long[] Value={ 2L,1L,9L,2L,1L,4L,1L,1L,3L,1L,21L,2L,1L,6L,1L,1L,3L,1L,1L,2L,1L,10L,2L,1L,5L,1L,1L,3L,1L,27L,2L,1L,7L,1L,1L,4L,1L,1L,2L,1L,12L,2L,1L,5L,1L,1L,3L,1L,38L,2L,1L,7L,2L,1L,4L,1L,1L,2L,1L,13L,2L,1L,5L,1L,1L,3L,1L,63L,2L,1L,8L,2L,1L,4L,1L,1L,3L,1L,16L,2L,1L,6L,1L,1L,3L,1L,181L,2L,1L,9L,2L,1L,4L,1L,1L,3L,1L,19L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024578Inst : IEnumerable<long>
{
public static readonly long[] Value=A024578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024578.Bytes);
public long this[int i]=>Value[i];

public static A024578Inst Instance=new A024578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024579
{
public static readonly long[] Value={ 2L,3L,12L,14L,15L,19L,20L,21L,24L,25L,46L,48L,49L,55L,56L,57L,60L,61L,62L,64L,65L,75L,77L,78L,83L,84L,85L,88L,89L,116L,118L,119L,126L,127L,128L,132L,133L,134L,136L,137L,149L,151L,152L,157L,158L,159L,162L,163L,201L,203L,204L,211L,213L,214L,218L,219L,220L,222L,223L,236L,238L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024579Inst : IEnumerable<long>
{
public static readonly long[] Value=A024579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024579.Bytes);
public long this[int i]=>Value[i];

public static A024579Inst Instance=new A024579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024580
{
public static readonly long[] Value={ 2L,4L,13L,15L,17L,21L,23L,24L,27L,29L,50L,53L,54L,61L,63L,64L,68L,69L,70L,73L,74L,85L,87L,88L,94L,95L,96L,100L,101L,129L,131L,132L,140L,142L,143L,147L,148L,150L,152L,154L,166L,168L,169L,175L,176L,178L,181L,182L,221L,223L,225L,232L,234L,236L,240L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024580Inst : IEnumerable<long>
{
public static readonly long[] Value=A024580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024580.Bytes);
public long this[int i]=>Value[i];

public static A024580Inst Instance=new A024580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024581
{
public static readonly long[] Value={ 1L,3L,8L,22L,60L,163L,443L,1204L,3273L,8897L,24185L,65742L,178705L,485771L,1320462L,3589388L,9756968L,26522189L,72094784L,195973941L,532712403L,1448062445L,3936241831L,10699814642L,29085111709L,79061530637L,214911522061L,584190085145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024581Inst : IEnumerable<long>
{
public static readonly long[] Value=A024581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024581.Bytes);
public long this[int i]=>Value[i];

public static A024581Inst Instance=new A024581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024582
{
public static readonly long[] Value={ 1L,7L,49L,346L,2443L,17253L,121849L,860560L,6077716L,42923950L,303150968L,2141007745L,15120895687L,106791526987L,754216580306L,5326664633964L,37619639853603L,265689207030405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024582Inst : IEnumerable<long>
{
public static readonly long[] Value=A024582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024582.Bytes);
public long this[int i]=>Value[i];

public static A024582Inst Instance=new A024582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024583
{
public static readonly long[] Value={ 7L,7L,7L,7L,7L,7L,7L,60L,32L,24L,19L,17L,15L,14L,121L,60L,41L,32L,27L,24L,21L,191L,89L,60L,46L,38L,32L,29L,273L,121L,79L,60L,49L,41L,36L,369L,154L,99L,74L,60L,50L,44L,485L,191L,121L,89L,71L,60L,52L,627L,230L,143L,105L,83L,69L,60L,805L,273L,166L,121L,95L,79L,68L,1033L,319L,191L,137L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024583Inst : IEnumerable<long>
{
public static readonly long[] Value=A024583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024583.Bytes);
public long this[int i]=>Value[i];

public static A024583Inst Instance=new A024583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024584
{
public static readonly long[] Value={ 7L,3L,2L,1L,1L,1L,1L,7L,3L,2L,1L,1L,1L,1L,8L,3L,2L,1L,1L,1L,1L,8L,3L,2L,1L,1L,1L,1L,9L,4L,2L,1L,1L,1L,1L,10L,4L,2L,1L,1L,1L,1L,11L,4L,2L,1L,1L,1L,1L,12L,4L,2L,1L,1L,1L,1L,14L,4L,2L,2L,1L,1L,1L,16L,4L,2L,2L,1L,1L,1L,18L,5L,2L,2L,1L,1L,1L,22L,5L,3L,2L,1L,1L,1L,28L,5L,3L,2L,1L,1L,1L,37L,5L,3L,2L,1L,1L,1L,56L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024584Inst : IEnumerable<long>
{
public static readonly long[] Value=A024584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024584.Bytes);
public long this[int i]=>Value[i];

public static A024584Inst Instance=new A024584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024585
{
public static readonly long[] Value={ 7L,10L,12L,13L,14L,15L,16L,23L,26L,28L,29L,30L,31L,32L,40L,43L,45L,46L,47L,48L,49L,57L,60L,62L,63L,64L,65L,66L,75L,79L,81L,82L,83L,84L,85L,95L,99L,101L,102L,103L,104L,105L,116L,120L,122L,123L,124L,125L,126L,138L,142L,144L,145L,146L,147L,148L,162L,166L,168L,170L,171L,172L,173L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024585Inst : IEnumerable<long>
{
public static readonly long[] Value=A024585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024585.Bytes);
public long this[int i]=>Value[i];

public static A024585Inst Instance=new A024585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024586
{
public static readonly long[] Value={ 7L,10L,12L,14L,16L,17L,18L,25L,29L,31L,33L,35L,36L,37L,45L,49L,51L,53L,54L,56L,57L,65L,69L,72L,74L,75L,76L,77L,87L,91L,93L,95L,97L,98L,99L,109L,113L,116L,118L,119L,121L,122L,133L,137L,140L,142L,144L,145L,146L,158L,163L,166L,168L,169L,171L,172L,186L,190L,193L,195L,197L,198L,199L,215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024586Inst : IEnumerable<long>
{
public static readonly long[] Value=A024586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024586.Bytes);
public long this[int i]=>Value[i];

public static A024586Inst Instance=new A024586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024587
{
public static readonly long[] Value={ 1L,7L,49L,346L,2444L,17261L,121906L,860963L,6080563L,42944057L,303292974L,2142010664L,15127978816L,106841551680L,754569880366L,5329159820340L,37637262140584L,265813664666689L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024587Inst : IEnumerable<long>
{
public static readonly long[] Value=A024587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024587.Bytes);
public long this[int i]=>Value[i];

public static A024587Inst Instance=new A024587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024588
{
public static readonly long[] Value={ 16L,24L,68L,84L,158L,180L,289L,330L,474L,534L,735L,810L,1072L,1158L,1474L,1586L,1958L,2093L,2543L,2697L,3238L,3403L,4013L,4208L,4896L,5116L,5918L,6164L,7046L,7337L,8311L,8645L,9717L,10097L,11269L,11691L,12996L,13443L,14891L,15352L,16909L,17422L,19104L,19674L,21478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024588Inst : IEnumerable<long>
{
public static readonly long[] Value=A024588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024588.Bytes);
public long this[int i]=>Value[i];

public static A024588Inst Instance=new A024588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024589
{
public static readonly long[] Value={ 4L,8L,24L,38L,86L,140L,271L,438L,789L,1277L,2222L,3595L,6111L,9888L,16509L,26712L,44101L,71357L,117060L,189407L,309347L,500534L,814774L,1318332L,2141400L,3464858L,5620898L,9094804L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024589Inst : IEnumerable<long>
{
public static readonly long[] Value=A024589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024589.Bytes);
public long this[int i]=>Value[i];

public static A024589Inst Instance=new A024589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024590
{
public static readonly long[] Value={ 4L,12L,38L,58L,118L,154L,253L,307L,451L,525L,731L,829L,1109L,1235L,1586L,1742L,2170L,2358L,2888L,3112L,3756L,4020L,4767L,5073L,5929L,6279L,7277L,7675L,8798L,9246L,10500L,11000L,12391L,12945L,14479L,15089L,16809L,17479L,19397L,20131L,22218L,23018L,25280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024590Inst : IEnumerable<long>
{
public static readonly long[] Value=A024590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024590.Bytes);
public long this[int i]=>Value[i];

public static A024590Inst Instance=new A024590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024591
{
public static readonly long[] Value={ 1L,2L,7L,11L,27L,44L,96L,155L,315L,510L,994L,1608L,3043L,4924L,9123L,14761L,26909L,43540L,78370L,126805L,225911L,365532L,645732L,1044816L,1832677L,2965334L,5170111L,8365415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024591Inst : IEnumerable<long>
{
public static readonly long[] Value=A024591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024591.Bytes);
public long this[int i]=>Value[i];

public static A024591Inst Instance=new A024591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024592
{
public static readonly long[] Value={ 1L,3L,11L,17L,38L,50L,97L,119L,213L,251L,432L,496L,833L,939L,1555L,1729L,2838L,3122L,5097L,5559L,9045L,9795L,15904L,17120L,27761L,29731L,48171L,51361L,83174L,88338L,143009L,151367L,244997L,258523L,418384L,440272L,712465L,747883L,1210195L,1267505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024592Inst : IEnumerable<long>
{
public static readonly long[] Value=A024592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024592.Bytes);
public long this[int i]=>Value[i];

public static A024592Inst Instance=new A024592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024593
{
public static readonly long[] Value={ 1L,3L,10L,14L,32L,43L,83L,101L,180L,207L,356L,410L,689L,768L,1272L,1429L,2345L,2584L,4218L,4560L,7419L,8086L,13129L,14127L,22907L,24306L,39381L,42061L,68113L,71940L,116463L,123904L,200546L,211671L,342560L,358160L,579588L,609488L,986250L,1029113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024593Inst : IEnumerable<long>
{
public static readonly long[] Value=A024593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024593.Bytes);
public long this[int i]=>Value[i];

public static A024593Inst Instance=new A024593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024594
{
public static readonly long[] Value={ 2L,5L,17L,24L,54L,71L,137L,166L,296L,342L,588L,674L,1132L,1264L,2093L,2337L,3835L,4216L,6882L,7455L,12129L,13171L,21385L,22991L,37280L,39664L,64264L,68539L,110991L,117400L,190057L,201677L,326426L,344314L,557224L,583768L,944675L,992284L,1605675L,1677193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024594Inst : IEnumerable<long>
{
public static readonly long[] Value=A024594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024594.Bytes);
public long this[int i]=>Value[i];

public static A024594Inst Instance=new A024594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024595
{
public static readonly long[] Value={ 1L,0L,0L,1L,2L,3L,5L,0L,0L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,1L,2L,3L,5L,8L,13L,21L,34L,55L,89L,144L,233L,377L,610L,987L,1598L,2586L,4184L,6770L,10954L,13L,21L,34L,55L,89L,144L,233L,377L,610L,987L,1597L,2584L,4181L,6765L,10946L,17711L,28658L,46370L,75028L,121398L,196426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024595Inst : IEnumerable<long>
{
public static readonly long[] Value=A024595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024595.Bytes);
public long this[int i]=>Value[i];

public static A024595Inst Instance=new A024595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024596
{
public static readonly long[] Value={ 0L,1L,3L,2L,4L,3L,6L,11L,19L,18L,30L,29L,48L,45L,74L,66L,108L,87L,142L,230L,373L,372L,603L,600L,972L,964L,1561L,1540L,2493L,2438L,3946L,3802L,6153L,5776L,9346L,8358L,13525L,10939L,17701L,28642L,46345L,46332L,74968L,74934L,121247L,121158L,196039L,195806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024596Inst : IEnumerable<long>
{
public static readonly long[] Value=A024596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024596.Bytes);
public long this[int i]=>Value[i];

public static A024596Inst Instance=new A024596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024597
{
public static readonly long[] Value={ 2L,3L,11L,17L,40L,56L,111L,147L,265L,321L,558L,674L,1141L,1321L,2195L,2571L,4232L,4876L,7971L,8809L,14343L,16081L,26122L,28426L,46113L,49727L,80587L,88083L,142656L,155902L,252409L,271617L,439653L,464867L,752352L,804854L,1302473L,1374265L,2223813L,2340937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024597Inst : IEnumerable<long>
{
public static readonly long[] Value=A024597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024597.Bytes);
public long this[int i]=>Value[i];

public static A024597Inst Instance=new A024597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024598
{
public static readonly long[] Value={ 1L,3L,14L,22L,55L,73L,140L,172L,285L,335L,506L,578L,819L,917L,1240L,1368L,1785L,1947L,2470L,2670L,3311L,3553L,4324L,4612L,5525L,5863L,6930L,7322L,8555L,9005L,10416L,10928L,12529L,13107L,14910L,15558L,17575L,18297L,20540L,21340L,23821L,24703L,27434L,28402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024598Inst : IEnumerable<long>
{
public static readonly long[] Value=A024598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024598.Bytes);
public long this[int i]=>Value[i];

public static A024598Inst Instance=new A024598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024599
{
public static readonly long[] Value={ 1L,3L,13L,18L,46L,63L,120L,146L,240L,276L,417L,477L,676L,753L,1019L,1130L,1473L,1606L,2036L,2192L,2717L,2919L,3550L,3781L,4527L,4788L,5659L,5980L,6986L,7342L,8492L,8918L,10223L,10691L,12161L,12672L,14315L,14908L,16735L,17377L,19397L,20131L,22354L,23142L,25578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024599Inst : IEnumerable<long>
{
public static readonly long[] Value=A024599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024599.Bytes);
public long this[int i]=>Value[i];

public static A024599Inst Instance=new A024599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024600
{
public static readonly long[] Value={ 2L,5L,22L,31L,78L,104L,198L,240L,395L,456L,688L,784L,1110L,1236L,1671L,1846L,2406L,2620L,3321L,3577L,4433L,4756L,5784L,6159L,7374L,7804L,9222L,9739L,11376L,11957L,13828L,14510L,16632L,17389L,19778L,20613L,23283L,24237L,27205L,28247L,31528L,32703L,36313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024600Inst : IEnumerable<long>
{
public static readonly long[] Value=A024600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024600.Bytes);
public long this[int i]=>Value[i];

public static A024600Inst Instance=new A024600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024601
{
public static readonly long[] Value={ 1L,0L,0L,1L,3L,5L,7L,0L,0L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,1L,3L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,32L,36L,40L,44L,48L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,44L,48L,52L,56L,60L,64L,68L,72L,76L,80L,84L,88L,92L,96L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024601Inst : IEnumerable<long>
{
public static readonly long[] Value=A024601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024601.Bytes);
public long this[int i]=>Value[i];

public static A024601Inst Instance=new A024601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024602
{
public static readonly long[] Value={ 0L,1L,4L,3L,6L,4L,9L,16L,25L,24L,33L,31L,42L,40L,53L,51L,66L,64L,81L,99L,118L,116L,137L,135L,158L,156L,181L,179L,206L,204L,233L,231L,262L,260L,292L,288L,321L,317L,352L,389L,428L,426L,467L,465L,508L,506L,551L,549L,596L,594L,643L,641L,692L,690L,743L,740L,793L,789L,884L,840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024602Inst : IEnumerable<long>
{
public static readonly long[] Value=A024602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024602.Bytes);
public long this[int i]=>Value[i];

public static A024602Inst Instance=new A024602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024603
{
public static readonly long[] Value={ 2L,3L,14L,22L,57L,81L,160L,212L,355L,429L,662L,794L,1147L,1329L,1822L,2092L,2759L,3109L,3978L,4376L,5469L,6001L,7346L,7938L,9567L,10287L,12236L,13148L,15437L,16491L,19148L,20314L,23391L,24679L,28202L,29768L,33777L,35493L,40018L,41972L,47047L,49343L,55004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024603Inst : IEnumerable<long>
{
public static readonly long[] Value=A024603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024603.Bytes);
public long this[int i]=>Value[i];

public static A024603Inst Instance=new A024603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024604
{
public static readonly long[] Value={ 8L,12L,38L,58L,126L,174L,297L,381L,569L,689L,979L,1167L,1591L,1825L,2372L,2700L,3408L,3814L,4716L,5166L,6274L,6856L,8175L,8811L,10375L,11141L,12989L,13909L,16008L,17042L,19448L,20606L,23335L,24589L,27647L,29133L,32611L,34229L,38139L,39947L,44278L,46356L,51110L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024604Inst : IEnumerable<long>
{
public static readonly long[] Value=A024604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024604.Bytes);
public long this[int i]=>Value[i];

public static A024604Inst Instance=new A024604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024605
{
public static readonly long[] Value={ 1L,3L,4L,7L,7L,9L,12L,13L,13L,16L,19L,19L,21L,21L,25L,27L,28L,28L,31L,31L,36L,37L,37L,39L,39L,43L,43L,48L,49L,49L,49L,52L,52L,57L,57L,61L,61L,63L,63L,64L,67L,67L,73L,73L,75L,76L,76L,79L,79L,81L,84L,84L,91L,91L,91L,91L,93L,93L,97L,97L,100L,103L,103L,108L,109L,109L,111L,111L,112L,112L,117L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024605Inst : IEnumerable<long>
{
public static readonly long[] Value=A024605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024605.Bytes);
public long this[int i]=>Value[i];

public static A024605Inst Instance=new A024605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024606
{
public static readonly long[] Value={ 7L,13L,19L,21L,28L,31L,37L,39L,43L,49L,52L,57L,61L,63L,67L,73L,76L,79L,84L,91L,93L,97L,103L,109L,111L,112L,117L,124L,127L,129L,133L,139L,147L,148L,151L,156L,157L,163L,169L,171L,172L,175L,181L,183L,189L,193L,196L,199L,201L,208L,211L,217L,219L,223L,228L,229L,237L,241L,244L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024606Inst : IEnumerable<long>
{
public static readonly long[] Value=A024606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024606.Bytes);
public long this[int i]=>Value[i];

public static A024606Inst Instance=new A024606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024607
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,19L,59L,267L,1380L,9832L,90842L,1144061L,19425052L,445781050L,13743625184L,566756900370L,31125101479652L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024607Inst : IEnumerable<long>
{
public static readonly long[] Value=A024607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024607.Bytes);
public long this[int i]=>Value[i];

public static A024607Inst Instance=new A024607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024608
{
public static readonly long[] Value={ 1L,4L,7L,9L,14L,16L,20L,22L,26L,30L,33L,37L,39L,42L,45L,50L,52L,54L,59L,64L,66L,69L,75L,80L,82L,83L,85L,93L,94L,96L,100L,101L,106L,113L,115L,120L,123L,126L,130L,132L,135L,136L,140L,145L,148L,151L,154L,158L,164L,168L,171L,173L,177L,181L,183L,189L,195L,197L,199L,201L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024608Inst : IEnumerable<long>
{
public static readonly long[] Value=A024608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024608.Bytes);
public long this[int i]=>Value[i];

public static A024608Inst Instance=new A024608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024609
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,12L,13L,15L,17L,18L,19L,21L,23L,24L,25L,27L,28L,29L,31L,32L,34L,35L,36L,38L,40L,41L,43L,44L,46L,47L,48L,49L,51L,53L,55L,56L,57L,58L,60L,61L,62L,63L,65L,67L,68L,70L,71L,72L,73L,74L,76L,77L,78L,79L,81L,84L,86L,87L,88L,89L,90L,91L,92L,95L,97L,98L,99L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024609Inst : IEnumerable<long>
{
public static readonly long[] Value=A024609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024609.Bytes);
public long this[int i]=>Value[i];

public static A024609Inst Instance=new A024609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024610
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,21L,26L,32L,37L,44L,50L,57L,66L,74L,83L,91L,101L,111L,123L,134L,145L,157L,168L,182L,195L,209L,223L,237L,252L,266L,283L,300L,317L,332L,349L,367L,384L,403L,424L,444L,464L,484L,504L,526L,547L,570L,592L,614L,637L,660L,685L,711L,733L,758L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024610Inst : IEnumerable<long>
{
public static readonly long[] Value=A024610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024610.Bytes);
public long this[int i]=>Value[i];

public static A024610Inst Instance=new A024610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024611
{
public static readonly long[] Value={ 2L,3L,5L,8L,11L,15L,19L,23L,28L,34L,41L,48L,55L,62L,70L,78L,87L,97L,108L,118L,128L,139L,150L,163L,175L,188L,202L,216L,229L,245L,261L,276L,292L,309L,324L,341L,361L,377L,395L,413L,433L,452L,474L,496L,514L,537L,557L,580L,603L,626L,651L,674L,699L,722L,745L,773L,799L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024611Inst : IEnumerable<long>
{
public static readonly long[] Value=A024611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024611.Bytes);
public long this[int i]=>Value[i];

public static A024611Inst Instance=new A024611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024612
{
public static readonly long[] Value={ 3L,7L,7L,12L,13L,13L,19L,19L,21L,21L,27L,28L,28L,31L,31L,37L,37L,39L,39L,43L,43L,48L,49L,49L,52L,52L,57L,57L,61L,61L,63L,63L,67L,67L,73L,73L,75L,76L,76L,79L,79L,84L,84L,91L,91L,91L,91L,93L,93L,97L,97L,103L,103L,108L,109L,109L,111L,111L,112L,112L,117L,117L,124L,124L,127L,127L,129L,129L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024612Inst : IEnumerable<long>
{
public static readonly long[] Value=A024612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024612.Bytes);
public long this[int i]=>Value[i];

public static A024612Inst Instance=new A024612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024613
{
public static readonly long[] Value={ 7L,13L,19L,21L,28L,31L,37L,39L,43L,49L,52L,57L,61L,63L,67L,73L,76L,79L,84L,91L,93L,97L,103L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024613Inst : IEnumerable<long>
{
public static readonly long[] Value=A024613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024613.Bytes);
public long this[int i]=>Value[i];

public static A024613Inst Instance=new A024613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024614
{
public static readonly long[] Value={ 3L,7L,12L,13L,19L,21L,27L,28L,31L,37L,39L,43L,48L,49L,52L,57L,61L,63L,67L,73L,75L,76L,79L,84L,91L,93L,97L,103L,108L,109L,111L,112L,117L,124L,127L,129L,133L,139L,147L,148L,151L,156L,157L,163L,169L,171L,172L,175L,181L,183L,189L,192L,193L,196L,199L,201L,208L,211L,217L,219L,223L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024614Inst : IEnumerable<long>
{
public static readonly long[] Value=A024614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024614.Bytes);
public long this[int i]=>Value[i];

public static A024614Inst Instance=new A024614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024615
{
public static readonly long[] Value={ 3L,8L,13L,15L,22L,24L,29L,32L,34L,40L,42L,47L,52L,54L,57L,62L,67L,69L,71L,78L,79L,81L,85L,90L,97L,99L,104L,109L,113L,115L,118L,119L,123L,130L,133L,136L,139L,145L,151L,153L,157L,161L,162L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024615Inst : IEnumerable<long>
{
public static readonly long[] Value=A024615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024615.Bytes);
public long this[int i]=>Value[i];

public static A024615Inst Instance=new A024615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024616
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,30L,31L,33L,35L,36L,37L,38L,39L,41L,43L,44L,45L,46L,48L,49L,50L,51L,53L,55L,56L,58L,59L,60L,61L,63L,64L,65L,66L,68L,70L,72L,73L,74L,75L,76L,77L,80L,82L,83L,84L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024616Inst : IEnumerable<long>
{
public static readonly long[] Value=A024616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024616.Bytes);
public long this[int i]=>Value[i];

public static A024616Inst Instance=new A024616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024617
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,12L,16L,20L,25L,31L,37L,43L,50L,58L,65L,73L,82L,92L,102L,111L,122L,132L,144L,155L,167L,181L,194L,207L,222L,237L,252L,267L,283L,297L,314L,333L,349L,367L,385L,404L,422L,444L,466L,483L,505L,524L,546L,568L,591L,615L,637L,662L,684L,706L,733L,759L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024617Inst : IEnumerable<long>
{
public static readonly long[] Value=A024617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024617.Bytes);
public long this[int i]=>Value[i];

public static A024617Inst Instance=new A024617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024618
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,10L,12L,17L,19L,20L,23L,27L,28L,30L,35L,38L,41L,43L,44L,49L,53L,55L,58L,61L,63L,65L,72L,74L,76L,82L,84L,88L,91L,93L,98L,100L,101L,105L,108L,111L,114L,116L,121L,122L,128L,131L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024618Inst : IEnumerable<long>
{
public static readonly long[] Value=A024618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024618.Bytes);
public long this[int i]=>Value[i];

public static A024618Inst Instance=new A024618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024619
{
public static readonly long[] Value={ 6L,10L,12L,14L,15L,18L,20L,21L,22L,24L,26L,28L,30L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,111L,112L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024619Inst : IEnumerable<long>
{
public static readonly long[] Value=A024619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024619.Bytes);
public long this[int i]=>Value[i];

public static A024619Inst Instance=new A024619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024620
{
public static readonly long[] Value={ 2L,3L,5L,6L,9L,10L,12L,13L,14L,17L,18L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,34L,35L,36L,37L,38L,39L,40L,41L,44L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,70L,72L,73L,74L,75L,76L,77L,78L,80L,81L,82L,83L,84L,85L,86L,88L,89L,90L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024620Inst : IEnumerable<long>
{
public static readonly long[] Value=A024620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024620.Bytes);
public long this[int i]=>Value[i];

public static A024620Inst Instance=new A024620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024797
{
public static readonly long[] Value={ 1L,4L,7L,9L,15L,22L,24L,32L,36L,37L,41L,46L,54L,58L,64L,67L,72L,74L,76L,89L,94L,96L,104L,110L,114L,123L,128L,130L,139L,143L,154L,167L,169L,171L,177L,186L,189L,200L,207L,210L,212L,220L,232L,237L,240L,251L,256L,264L,265L,268L,285L,290L,298L,305L,307L,314L,322L,324L,334L,343L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024797Inst : IEnumerable<long>
{
public static readonly long[] Value=A024797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024797.Bytes);
public long this[int i]=>Value[i];

public static A024797Inst Instance=new A024797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024798
{
public static readonly long[] Value={ 2L,5L,6L,8L,11L,12L,13L,16L,18L,20L,21L,23L,25L,27L,28L,30L,33L,34L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,56L,57L,59L,62L,63L,65L,68L,69L,71L,73L,75L,77L,79L,81L,82L,84L,87L,90L,92L,93L,95L,97L,99L,100L,102L,105L,106L,108L,111L,113L,115L,117L,118L,120L,122L,124L,125L,127L,129L,131L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024798Inst : IEnumerable<long>
{
public static readonly long[] Value=A024798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024798.Bytes);
public long this[int i]=>Value[i];

public static A024798Inst Instance=new A024798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024799
{
public static readonly long[] Value={ 1L,3L,4L,7L,9L,10L,14L,15L,17L,19L,22L,24L,26L,29L,31L,32L,35L,36L,37L,39L,41L,43L,46L,48L,50L,52L,54L,58L,60L,61L,64L,66L,67L,70L,72L,74L,76L,78L,80L,83L,85L,86L,88L,89L,91L,94L,96L,98L,101L,103L,104L,107L,109L,110L,112L,114L,116L,119L,121L,123L,126L,128L,130L,133L,135L,136L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024799Inst : IEnumerable<long>
{
public static readonly long[] Value=A024799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024799.Bytes);
public long this[int i]=>Value[i];

public static A024799Inst Instance=new A024799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024800
{
public static readonly long[] Value={ 1L,5L,14L,28L,48L,73L,103L,138L,179L,226L,277L,333L,395L,461L,531L,608L,691L,777L,869L,966L,1068L,1175L,1287L,1403L,1526L,1653L,1783L,1921L,2063L,2209L,2362L,2518L,2682L,2849L,3022L,3197L,3378L,3567L,3759L,3956L,4160L,4366L,4578L,4795L,5018L,5245L,5476L,5713L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024800Inst : IEnumerable<long>
{
public static readonly long[] Value=A024800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024800.Bytes);
public long this[int i]=>Value[i];

public static A024800Inst Instance=new A024800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024801
{
public static readonly long[] Value={ 2L,3L,6L,10L,16L,22L,33L,43L,56L,70L,87L,104L,124L,146L,170L,193L,221L,249L,280L,311L,345L,380L,416L,455L,495L,536L,581L,627L,674L,722L,772L,823L,878L,933L,992L,1050L,1110L,1172L,1236L,1301L,1369L,1438L,1508L,1581L,1655L,1728L,1806L,1885L,1966L,2047L,2131L,2217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024801Inst : IEnumerable<long>
{
public static readonly long[] Value=A024801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024801.Bytes);
public long this[int i]=>Value[i];

public static A024801Inst Instance=new A024801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024802
{
public static readonly long[] Value={ 6L,15L,30L,50L,75L,104L,140L,181L,228L,279L,335L,396L,463L,533L,610L,693L,779L,870L,968L,1070L,1177L,1289L,1405L,1528L,1655L,1785L,1923L,2064L,2211L,2364L,2520L,2684L,2851L,3023L,3199L,3380L,3569L,3761L,3958L,4162L,4368L,4580L,4797L,5019L,5247L,5478L,5715L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024802Inst : IEnumerable<long>
{
public static readonly long[] Value=A024802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024802.Bytes);
public long this[int i]=>Value[i];

public static A024802Inst Instance=new A024802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A024803
{
public static readonly long[] Value={ 14L,21L,26L,29L,30L,35L,38L,41L,42L,45L,46L,49L,50L,53L,54L,56L,59L,61L,62L,62L,65L,66L,69L,69L,70L,74L,74L,75L,77L,77L,78L,81L,83L,84L,86L,86L,89L,89L,90L,90L,91L,93L,94L,94L,98L,98L,101L,101L,101L,104L,105L,105L,106L,107L,109L,110L,110L,110L,113L,114L,115L,116L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A024803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A024803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A024803Inst : IEnumerable<long>
{
public static readonly long[] Value=A024803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A024803.Bytes);
public long this[int i]=>Value[i];

public static A024803Inst Instance=new A024803Inst();

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