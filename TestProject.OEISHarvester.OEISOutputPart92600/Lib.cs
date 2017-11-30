using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A112241
{
public static readonly BigInteger[] Value={ 1L,1L,5L,49L,601L,9281L,170941L,3662065L,89368049L,2446433281L,74212220341L,2470200090161L,89490288001225L,3504680581915969L,147513939627740141L,6639918363792119281L,BigInteger.Parse("318237954786998696161"),BigInteger.Parse("16178761263710217424385") };
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
public class A112241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112241Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112241.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112241Inst Instance=new A112241Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112242
{
public static readonly BigInteger[] Value={ 1L,1L,5L,25L,169L,1361L,12781L,136585L,1633745L,21594529L,312239701L,4898379641L,82810239865L,1500015354865L,28970936174909L,594083320767721L,12886811207794081L,294742414455540545L,7087332775240107685L,BigInteger.Parse("178707496551303048409"),BigInteger.Parse("4714241296084031285321"),BigInteger.Parse("129830157857411005318801") };
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
public class A112242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112242Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112242.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112242Inst Instance=new A112242Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112243
{
public static readonly BigInteger[] Value={ 1L,1L,7L,55L,577L,7441L,113671L,2003527L,39971905L,889608097L,21834577351L,585555975511L,17027451783937L,533460597334705L,17908302027585607L,641152804988733031L,BigInteger.Parse("24380543011087797121"),BigInteger.Parse("981149507717921468737") };
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
public class A112243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112243Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112243.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112243Inst Instance=new A112243Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112244
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,5L,2L,3L,2L,8L,0L,4L,3L,9L,0L,7L,6L,6L,5L,4L,2L,8L,4L,2L,6L,4L,3L,4L,2L,1L,2L,5L,7L,3L,8L,0L,1L,4L,7L,8L,9L,1L,1L,8L,0L,4L,2L,2L,1L,4L,4L,5L,5L,6L,4L,7L,1L,4L,0L,3L,3L,7L,8L,3L,0L,3L,6L,9L,9L,8L,4L,9L,1L,1L,5L,1L,0L,4L,9L,0L,5L,5L,5L,3L,1L,3L,9L,1L,9L,4L,7L,4L,1L,2L,7L,1L,5L,8L,9L,5L,4L,3L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112244Inst : IEnumerable<long>
{
public static readonly long[] Value=A112244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112244.Bytes);
public long this[int i]=>Value[i];

public static A112244Inst Instance=new A112244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112245
{
public static readonly long[] Value={ 287L,1695L,81359L,512895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112245Inst : IEnumerable<long>
{
public static readonly long[] Value=A112245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112245.Bytes);
public long this[int i]=>Value[i];

public static A112245Inst Instance=new A112245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112246
{
public static readonly long[] Value={ 1L,0L,0L,0L,6L,0L,9L,4L,5L,1L,4L,1L,2L,7L,6L,7L,3L,4L,2L,4L,8L,9L,7L,2L,5L,9L,7L,6L,6L,9L,2L,3L,2L,0L,1L,9L,7L,6L,9L,4L,5L,0L,2L,8L,9L,1L,5L,8L,4L,1L,6L,1L,1L,9L,0L,2L,1L,3L,6L,3L,6L,8L,0L,6L,4L,0L,2L,0L,9L,5L,3L,7L,2L,1L,6L,1L,4L,1L,3L,5L,9L,4L,7L,5L,5L,7L,9L,4L,0L,0L,2L,6L,3L,8L,7L,5L,7L,5L,9L,1L,0L,8L,7L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112246Inst : IEnumerable<long>
{
public static readonly long[] Value=A112246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112246.Bytes);
public long this[int i]=>Value[i];

public static A112246Inst Instance=new A112246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112247
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,5L,7L,0L,5L,3L,7L,4L,6L,7L,5L,6L,4L,7L,2L,9L,7L,8L,2L,8L,8L,3L,1L,3L,8L,1L,8L,4L,0L,0L,4L,5L,8L,9L,1L,6L,9L,9L,8L,3L,5L,5L,6L,2L,1L,3L,0L,2L,6L,3L,3L,4L,2L,0L,0L,9L,2L,6L,0L,6L,4L,8L,3L,8L,1L,6L,0L,9L,1L,9L,4L,0L,1L,7L,2L,0L,7L,8L,3L,8L,2L,2L,2L,0L,2L,8L,8L,2L,4L,8L,4L,8L,7L,4L,7L,1L,3L,9L,5L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112247Inst : IEnumerable<long>
{
public static readonly long[] Value=A112247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112247.Bytes);
public long this[int i]=>Value[i];

public static A112247Inst Instance=new A112247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112248
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,1L,2L,0L,1L,2L,0L,1L,2L,0L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,0L,1L,2L,3L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L,5L,0L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112248Inst : IEnumerable<long>
{
public static readonly long[] Value=A112248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112248.Bytes);
public long this[int i]=>Value[i];

public static A112248Inst Instance=new A112248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112249
{
public static readonly long[] Value={ 2L,3L,4L,6L,9L,12L,15L,16L,20L,24L,28L,35L,40L,45L,50L,55L,60L,66L,72L,78L,84L,90L,96L,102L,108L,114L,120L,126L,133L,140L,147L,154L,161L,168L,175L,182L,189L,196L,203L,210L,217L,224L,231L,238L,245L,252L,256L,264L,272L,280L,288L,296L,304L,312L,320L,328L,336L,344L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112249Inst : IEnumerable<long>
{
public static readonly long[] Value=A112249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112249.Bytes);
public long this[int i]=>Value[i];

public static A112249Inst Instance=new A112249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112250
{
public static readonly long[] Value={ 5L,7L,8L,10L,11L,13L,14L,17L,18L,19L,21L,22L,23L,25L,26L,27L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,91L,92L,93L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112250Inst : IEnumerable<long>
{
public static readonly long[] Value=A112250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112250.Bytes);
public long this[int i]=>Value[i];

public static A112250Inst Instance=new A112250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112251
{
public static readonly long[] Value={ 5L,7L,10L,13L,17L,21L,25L,29L,36L,41L,46L,51L,56L,61L,67L,73L,79L,85L,91L,97L,103L,109L,115L,121L,127L,134L,141L,148L,155L,162L,169L,176L,183L,190L,197L,204L,211L,218L,225L,232L,239L,246L,253L,257L,265L,273L,281L,289L,297L,305L,313L,321L,329L,337L,345L,353L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112251Inst : IEnumerable<long>
{
public static readonly long[] Value=A112251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112251.Bytes);
public long this[int i]=>Value[i];

public static A112251Inst Instance=new A112251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112252
{
public static readonly long[] Value={ 1L,0L,0L,0L,7L,6L,1L,8L,7L,2L,2L,9L,3L,2L,1L,6L,5L,7L,1L,5L,3L,0L,6L,2L,5L,8L,5L,6L,1L,7L,6L,0L,4L,8L,4L,6L,9L,0L,6L,9L,0L,5L,1L,9L,3L,6L,5L,8L,4L,0L,2L,1L,4L,2L,1L,0L,7L,3L,3L,2L,3L,4L,7L,7L,1L,4L,9L,1L,5L,8L,8L,9L,1L,8L,7L,4L,5L,3L,7L,1L,4L,9L,7L,1L,0L,8L,7L,2L,2L,4L,0L,5L,7L,6L,4L,3L,6L,9L,4L,7L,7L,2L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112252Inst : IEnumerable<long>
{
public static readonly long[] Value=A112252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112252.Bytes);
public long this[int i]=>Value[i];

public static A112252Inst Instance=new A112252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112253
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,7L,6L,1L,6L,1L,1L,2L,1L,6L,9L,5L,6L,0L,3L,7L,4L,7L,9L,3L,1L,2L,6L,0L,9L,2L,7L,7L,3L,6L,6L,3L,2L,8L,0L,8L,9L,1L,2L,7L,0L,8L,0L,1L,8L,6L,2L,0L,1L,3L,1L,2L,9L,7L,2L,3L,3L,1L,9L,9L,9L,6L,8L,4L,1L,2L,1L,6L,2L,9L,2L,6L,1L,3L,9L,4L,3L,0L,6L,8L,0L,3L,7L,7L,0L,6L,1L,1L,2L,5L,1L,9L,6L,6L,3L,1L,8L,1L,0L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112253Inst : IEnumerable<long>
{
public static readonly long[] Value=A112253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112253.Bytes);
public long this[int i]=>Value[i];

public static A112253Inst Instance=new A112253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112254
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,5L,0L,7L,7L,3L,4L,3L,6L,6L,5L,0L,3L,8L,8L,8L,6L,2L,3L,6L,1L,5L,5L,3L,8L,7L,0L,2L,3L,0L,1L,4L,3L,8L,6L,4L,3L,8L,2L,9L,0L,3L,9L,7L,7L,2L,1L,8L,4L,4L,6L,2L,0L,6L,3L,5L,4L,9L,6L,1L,8L,9L,3L,0L,5L,7L,9L,1L,9L,8L,4L,3L,4L,2L,7L,4L,0L,1L,5L,1L,1L,4L,1L,4L,8L,8L,5L,6L,4L,1L,7L,2L,4L,0L,8L,8L,2L,0L,2L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112254Inst : IEnumerable<long>
{
public static readonly long[] Value=A112254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112254.Bytes);
public long this[int i]=>Value[i];

public static A112254Inst Instance=new A112254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112255
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,8L,0L,7L,9L,8L,3L,5L,8L,1L,0L,8L,5L,4L,1L,8L,3L,1L,5L,9L,2L,9L,7L,9L,5L,5L,7L,7L,0L,2L,7L,1L,3L,6L,9L,0L,6L,6L,4L,2L,2L,3L,7L,4L,3L,9L,5L,9L,9L,9L,4L,0L,1L,6L,8L,0L,9L,1L,6L,0L,9L,7L,6L,5L,0L,7L,0L,6L,3L,5L,4L,8L,3L,6L,4L,0L,8L,1L,7L,0L,1L,2L,2L,6L,4L,7L,3L,7L,7L,2L,8L,2L,2L,0L,3L,3L,6L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112255Inst : IEnumerable<long>
{
public static readonly long[] Value=A112255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112255.Bytes);
public long this[int i]=>Value[i];

public static A112255Inst Instance=new A112255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112256
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,0L,4L,6L,3L,7L,5L,2L,6L,4L,4L,5L,3L,8L,6L,7L,3L,4L,1L,8L,7L,4L,6L,9L,4L,4L,6L,1L,5L,0L,7L,8L,0L,8L,0L,5L,2L,1L,7L,1L,0L,2L,3L,1L,9L,4L,7L,6L,1L,5L,7L,2L,8L,6L,2L,5L,5L,9L,5L,7L,9L,4L,3L,2L,0L,1L,1L,6L,1L,6L,3L,3L,3L,3L,8L,6L,3L,8L,4L,8L,8L,2L,5L,0L,1L,4L,7L,7L,5L,3L,6L,9L,6L,1L,3L,0L,5L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112256Inst : IEnumerable<long>
{
public static readonly long[] Value=A112256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112256.Bytes);
public long this[int i]=>Value[i];

public static A112256Inst Instance=new A112256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112257
{
public static readonly long[] Value={ 2L,7L,1L,8L,6L,9L,5L,9L,3L,0L,5L,5L,1L,6L,4L,4L,2L,9L,6L,0L,6L,1L,5L,0L,6L,9L,1L,4L,1L,6L,0L,7L,4L,8L,7L,5L,5L,9L,7L,3L,8L,6L,1L,0L,7L,6L,0L,4L,6L,7L,7L,0L,2L,2L,4L,0L,4L,9L,0L,8L,3L,0L,7L,5L,4L,3L,8L,8L,7L,9L,2L,6L,7L,3L,6L,7L,0L,3L,0L,5L,5L,6L,1L,1L,4L,4L,1L,2L,8L,6L,9L,9L,8L,7L,7L,6L,0L,1L,0L,6L,3L,0L,2L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112257Inst : IEnumerable<long>
{
public static readonly long[] Value=A112257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112257.Bytes);
public long this[int i]=>Value[i];

public static A112257Inst Instance=new A112257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112258
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,12L,13L,14L,17L,23L,29L,39L,61L,81L,95L,119L,164L,242L,5193L,9004L,23432L,246968L,8876708L,32886598L,2141194665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112258Inst : IEnumerable<long>
{
public static readonly long[] Value=A112258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112258.Bytes);
public long this[int i]=>Value[i];

public static A112258Inst Instance=new A112258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112259
{
public static readonly long[] Value={ 1L,5L,9L,605L,961L,16245L,284089L,29645L,15046641L,101025125L,73222249L,9908816445L,23755748641L,204034140245L,5031349566489L,1965713970605L,219320727489361L,1965265930868805L,374345220088009L,158335559155140125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112259Inst : IEnumerable<long>
{
public static readonly long[] Value=A112259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112259.Bytes);
public long this[int i]=>Value[i];

public static A112259Inst Instance=new A112259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112260
{
public static readonly long[] Value={ 1L,-1L,-1L,11L,31L,19L,-41L,11L,431L,899L,199L,-1349L,1951L,15539L,24119L,-5269L,-36209L,115939L,522919L,583451L,-459649L,-696301L,5336599L,16510411L,11941231L,-20545981L,-1202041L,215199611L,488443231L,164515699L,-715515401L,773905451L,7930934351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112260Inst : IEnumerable<long>
{
public static readonly long[] Value=A112260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112260.Bytes);
public long this[int i]=>Value[i];

public static A112260Inst Instance=new A112260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112261
{
public static readonly long[] Value={ -2L,0L,12L,20L,-12L,-60L,52L,420L,468L,-700L,-1548L,3300L,13588L,8580L,-29388L,-30940L,152148L,406980L,60532L,-1043100L,-236652L,6032900L,11173812L,-4569180L,-32487212L,19343940L,216401652L,273243620L,-323927532L,-880031100L,1489420852L,7157028900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112261Inst : IEnumerable<long>
{
public static readonly long[] Value=A112261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112261.Bytes);
public long this[int i]=>Value[i];

public static A112261Inst Instance=new A112261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112262
{
public static readonly long[] Value={ 1L,4L,9L,24L,58L,171L,340L,1097L,2673L,5467L,13353L,35957L,128823L,451488L,494198L,499871L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112262Inst : IEnumerable<long>
{
public static readonly long[] Value=A112262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112262.Bytes);
public long this[int i]=>Value[i];

public static A112262Inst Instance=new A112262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112263
{
public static readonly long[] Value={ 1L,4L,13L,23L,61L,177L,444L,1325L,3716L,8186L,18168L,62025L,275360L,461299L,498201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112263Inst : IEnumerable<long>
{
public static readonly long[] Value=A112263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112263.Bytes);
public long this[int i]=>Value[i];

public static A112263Inst Instance=new A112263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112264
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,5L,7L,6L,6L,7L,1L,7L,1L,9L,8L,8L,1L,8L,1L,9L,10L,3L,2L,9L,10L,3L,9L,11L,2L,10L,3L,10L,4L,3L,12L,10L,3L,3L,4L,11L,4L,12L,4L,5L,11L,4L,4L,11L,14L,12L,4L,5L,5L,11L,6L,13L,4L,4L,5L,12L,6L,5L,13L,12L,6L,6L,6L,5L,5L,14L,7L,12L,7L,5L,13L,5L,8L,6L,7L,13L,12L,6L,8L,14L,6L,6L,5L,7L,8L,13L,8L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112264Inst : IEnumerable<long>
{
public static readonly long[] Value=A112264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112264.Bytes);
public long this[int i]=>Value[i];

public static A112264Inst Instance=new A112264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112265
{
public static readonly long[] Value={ 0L,2L,5L,9L,14L,19L,26L,32L,38L,45L,46L,53L,54L,63L,71L,79L,80L,88L,89L,98L,108L,111L,113L,122L,132L,135L,144L,155L,157L,167L,170L,180L,184L,187L,199L,209L,212L,215L,219L,230L,234L,246L,250L,255L,266L,270L,274L,285L,299L,311L,315L,320L,325L,336L,342L,355L,359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112265Inst : IEnumerable<long>
{
public static readonly long[] Value=A112265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112265.Bytes);
public long this[int i]=>Value[i];

public static A112265Inst Instance=new A112265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112266
{
public static readonly long[] Value={ 2L,5L,19L,53L,71L,79L,89L,113L,157L,167L,199L,311L,359L,439L,521L,541L,587L,593L,613L,769L,947L,977L,1009L,1097L,1171L,1223L,1249L,1289L,1427L,1447L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112266Inst : IEnumerable<long>
{
public static readonly long[] Value=A112266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112266.Bytes);
public long this[int i]=>Value[i];

public static A112266Inst Instance=new A112266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112267
{
public static readonly long[] Value={ 3L,6L,7L,8L,2L,3L,4L,0L,7L,0L,8L,3L,6L,6L,4L,6L,7L,2L,8L,3L,6L,1L,3L,6L,8L,1L,1L,2L,7L,1L,6L,5L,6L,2L,1L,5L,1L,3L,3L,4L,9L,0L,7L,7L,0L,1L,4L,7L,2L,7L,5L,2L,6L,1L,3L,8L,7L,9L,2L,9L,6L,3L,4L,7L,7L,4L,4L,7L,3L,1L,2L,4L,3L,3L,4L,5L,8L,4L,1L,3L,0L,9L,7L,2L,1L,8L,7L,2L,2L,9L,8L,2L,9L,1L,9L,4L,7L,6L,5L,7L,8L,2L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112267Inst : IEnumerable<long>
{
public static readonly long[] Value=A112267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112267.Bytes);
public long this[int i]=>Value[i];

public static A112267Inst Instance=new A112267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112268
{
public static readonly long[] Value={ 1L,0L,1L,8L,0L,10L,25L,20L,25L,30L,209L,88L,209L,494L,1729L,494L,1984L,744L,2500L,2450L,2500L,2550L,1984L,5288L,1729L,6048L,14336L,3008L,17284L,4938L,17284L,60494L,14336L,68320L,122449L,20408L,126201L,21948L,148761L,33058L,152100L,35010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112268Inst : IEnumerable<long>
{
public static readonly long[] Value=A112268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112268.Bytes);
public long this[int i]=>Value[i];

public static A112268Inst Instance=new A112268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112269
{
public static readonly long[] Value={ 5L,8L,15L,13L,9L,19L,29L,19L,30L,78L,15L,20L,36L,83L,30L,34L,65L,69L,101L,133L,32L,19L,271L,110L,20L,187L,14L,185L,106L,173L,587L,80L,12L,35L,46L,224L,72L,38L,42L,315L,101L,26L,73L,172L,383L,27L,84L,362L,35L,250L,37L,29L,507L,305L,55L,38L,178L,332L,62L,537L,778L,459L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112269Inst : IEnumerable<long>
{
public static readonly long[] Value=A112269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112269.Bytes);
public long this[int i]=>Value[i];

public static A112269Inst Instance=new A112269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112270
{
public static readonly long[] Value={ 43L,127L,167L,213L,321L,387L,457L,531L,617L,709L,809L,1029L,1149L,1277L,1409L,1863L,2027L,2290L,3397L,3629L,4113L,4367L,4629L,4899L,5179L,5467L,5761L,6063L,6371L,7516L,7864L,8600L,8980L,9368L,10168L,10578L,11856L,12296L,12746L,13204L,13674L,14156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112270Inst : IEnumerable<long>
{
public static readonly long[] Value=A112270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112270.Bytes);
public long this[int i]=>Value[i];

public static A112270Inst Instance=new A112270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112271
{
public static readonly long[] Value={ 1L,2L,20L,32L,88L,212L,296L,344L,1070L,1166L,1374L,1655L,2248L,2698L,3368L,3730L,3916L,4936L,5160L,5388L,6725L,6983L,8788L,11338L,12382L,12923L,13480L,15026L,16244L,17717L,19033L,19481L,19937L,21108L,24584L,29191L,30345L,33008L,33921L,34850L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112271Inst : IEnumerable<long>
{
public static readonly long[] Value=A112271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112271.Bytes);
public long this[int i]=>Value[i];

public static A112271Inst Instance=new A112271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112272
{
public static readonly long[] Value={ 4L,11L,34L,113L,284L,441L,634L,731L,943L,1226L,1657L,2343L,2469L,3767L,3931L,4271L,4712L,5759L,5963L,7154L,8221L,8467L,8971L,9362L,9763L,12655L,13279L,13595L,13915L,15941L,17560L,19641L,21261L,21675L,22091L,22937L,23363L,23793L,24671L,26702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112272Inst : IEnumerable<long>
{
public static readonly long[] Value=A112272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112272.Bytes);
public long this[int i]=>Value[i];

public static A112272Inst Instance=new A112272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112273
{
public static readonly long[] Value={ 5L,15L,365L,945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112273Inst : IEnumerable<long>
{
public static readonly long[] Value=A112273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112273.Bytes);
public long this[int i]=>Value[i];

public static A112273Inst Instance=new A112273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112274
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,0L,-2L,2L,1L,-4L,1L,4L,-4L,-1L,6L,-3L,-6L,7L,3L,-10L,4L,10L,-12L,-6L,18L,-5L,-18L,20L,8L,-30L,10L,29L,-31L,-12L,46L,-17L,-44L,47L,20L,-68L,23L,66L,-72L,-31L,104L,-33L,-98L,107L,44L,-156L,51L,144L,-154L,-61L,220L,-75L,-206L,220L,90L,-310L,104L,290L,-312L,-131L,442L,-143L,-408L,437L,178L,-618L,202L,567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112274Inst : IEnumerable<long>
{
public static readonly long[] Value=A112274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112274.Bytes);
public long this[int i]=>Value[i];

public static A112274Inst Instance=new A112274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112275
{
public static readonly long[] Value={ 2L,3L,4L,6L,6L,8L,8L,10L,10L,12L,12L,18L,14L,15L,16L,18L,18L,20L,20L,24L,22L,24L,24L,30L,26L,27L,28L,30L,30L,36L,32L,36L,34L,35L,36L,48L,38L,39L,40L,42L,42L,48L,44L,45L,48L,48L,48L,60L,50L,52L,52L,54L,54L,56L,56L,60L,58L,60L,60L,72L,62L,63L,64L,66L,66L,70L,68L,70L,70L,72L,72L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112275Inst : IEnumerable<long>
{
public static readonly long[] Value=A112275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112275.Bytes);
public long this[int i]=>Value[i];

public static A112275Inst Instance=new A112275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112276
{
public static readonly long[] Value={ 1L,3L,5L,5L,7L,7L,11L,9L,11L,11L,13L,13L,17L,15L,17L,17L,19L,19L,23L,21L,22L,23L,29L,25L,29L,27L,29L,29L,31L,31L,37L,33L,34L,35L,37L,37L,41L,39L,41L,41L,43L,43L,47L,45L,46L,47L,53L,49L,53L,51L,53L,53L,59L,55L,57L,57L,58L,59L,61L,61L,67L,65L,65L,65L,67L,67L,71L,69L,71L,71L,73L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112276Inst : IEnumerable<long>
{
public static readonly long[] Value=A112276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112276.Bytes);
public long this[int i]=>Value[i];

public static A112276Inst Instance=new A112276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112277
{
public static readonly long[] Value={ 8L,14L,20L,21L,24L,26L,32L,33L,34L,38L,44L,45L,48L,50L,54L,55L,56L,57L,62L,63L,64L,68L,74L,75L,76L,80L,81L,84L,85L,86L,90L,91L,92L,93L,94L,98L,104L,105L,110L,114L,115L,116L,117L,118L,119L,120L,122L,123L,124L,128L,132L,133L,135L,140L,141L,142L,143L,144L,145L,147L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112277Inst : IEnumerable<long>
{
public static readonly long[] Value=A112277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112277.Bytes);
public long this[int i]=>Value[i];

public static A112277Inst Instance=new A112277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112278
{
public static readonly long[] Value={ 1L,2L,4L,8L,20L,72L,360L,282L,422L,80L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L,410L,30L,114L,44L,194L,492L,480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112278Inst : IEnumerable<long>
{
public static readonly long[] Value=A112278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112278.Bytes);
public long this[int i]=>Value[i];

public static A112278Inst Instance=new A112278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112279
{
public static readonly long[] Value={ 1L,2L,3L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L,103L,5L,11L,31L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112279Inst : IEnumerable<long>
{
public static readonly long[] Value=A112279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112279.Bytes);
public long this[int i]=>Value[i];

public static A112279Inst Instance=new A112279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112280
{
public static readonly long[] Value={ 1L,6L,0L,5L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112280Inst : IEnumerable<long>
{
public static readonly long[] Value=A112280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112280.Bytes);
public long this[int i]=>Value[i];

public static A112280Inst Instance=new A112280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112281
{
public static readonly long[] Value={ 1L,2L,-4L,15L,-60L,268L,-1275L,6322L,-32280L,168525L,-895272L,4823088L,-26284036L,144623580L,-802297080L,4482108215L,-25193038332L,142365182220L,-808318895340L,4608847319040L,-26378042959008L,151485697164867L,-872650786462376L,5041141102888080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112281Inst : IEnumerable<long>
{
public static readonly long[] Value=A112281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112281.Bytes);
public long this[int i]=>Value[i];

public static A112281Inst Instance=new A112281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112282
{
public static readonly long[] Value={ 1L,6L,5L,2L,0L,7L,4L,3L,8L,8L,3L,4L,7L,0L,2L,5L,6L,1L,1L,6L,5L,2L,0L,7L,4L,3L,8L,8L,3L,4L,7L,0L,2L,5L,6L,1L,1L,6L,5L,2L,0L,7L,4L,3L,8L,8L,3L,4L,7L,0L,2L,5L,6L,1L,1L,6L,5L,2L,0L,7L,4L,3L,8L,8L,3L,4L,7L,0L,2L,5L,6L,1L,1L,6L,5L,2L,0L,7L,4L,3L,8L,8L,3L,4L,7L,0L,2L,5L,6L,1L,1L,6L,5L,2L,0L,7L,4L,3L,8L,8L,3L,4L,7L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112282Inst : IEnumerable<long>
{
public static readonly long[] Value=A112282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112282.Bytes);
public long this[int i]=>Value[i];

public static A112282Inst Instance=new A112282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112283
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,72L,7L,24L,9L,130L,11L,264L,13L,168L,210L,304L,17L,162L,19L,540L,378L,682L,23L,456L,25L,1274L,27L,336L,29L,1770L,31L,544L,2013L,918L,525L,504L,37L,3724L,234L,280L,41L,504L,43L,4180L,2025L,414L,47L,816L,49L,1300L,3723L,1196L,53L,972L,550L,1960L,3933L,986L,59L,6480L,61L,1798L,4095L,1792L,3055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112283Inst : IEnumerable<long>
{
public static readonly long[] Value=A112283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112283.Bytes);
public long this[int i]=>Value[i];

public static A112283Inst Instance=new A112283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112284
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,12L,1L,3L,1L,13L,1L,22L,1L,12L,14L,19L,1L,9L,1L,27L,18L,31L,1L,19L,1L,49L,1L,12L,1L,59L,1L,17L,61L,27L,15L,14L,1L,98L,6L,7L,1L,12L,1L,95L,45L,9L,1L,17L,1L,26L,73L,23L,1L,18L,10L,35L,69L,17L,1L,108L,1L,29L,65L,28L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112284Inst : IEnumerable<long>
{
public static readonly long[] Value=A112284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112284.Bytes);
public long this[int i]=>Value[i];

public static A112284Inst Instance=new A112284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112285
{
public static readonly long[] Value={ 2L,4L,8L,27L,22L,340L,44L,156L,62L,1065L,112L,2467L,158L,1914L,2551L,4234L,274L,2161L,344L,8643L,6611L,12696L,508L,8410L,522L,28171L,566L,7500L,814L,39433L,932L,15000L,57160L,26980L,15681L,13590L,1334L,121327L,7786L,8908L,1642L,15896L,1808L,150069L,74267L,16105L,2164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112285Inst : IEnumerable<long>
{
public static readonly long[] Value=A112285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112285.Bytes);
public long this[int i]=>Value[i];

public static A112285Inst Instance=new A112285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112286
{
public static readonly long[] Value={ 1L,3L,11L,7L,71L,7L,17L,152L,2699L,701L,691L,248L,133L,137L,61933L,809L,20705L,64896L,3587L,17449L,445L,61897L,208L,20663L,1163L,982L,27281L,1871L,2466139L,44339L,21293609L,13417971L,6229L,54238033L,99737L,3585191L,33583L,40756259L,5956441L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112286Inst : IEnumerable<long>
{
public static readonly long[] Value=A112286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112286.Bytes);
public long this[int i]=>Value[i];

public static A112286Inst Instance=new A112286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112287
{
public static readonly long[] Value={ 1L,2L,5L,12L,24L,4L,5L,35L,420L,156L,300L,45L,15L,39L,15351L,72L,1848L,10675L,300L,2142L,36L,5460L,15L,1870L,90L,63L,2040L,120L,138600L,3960L,1750320L,1324895L,440L,3945480L,5220L,158340L,1680L,3341100L,498960L,48048L,1260L,69264L,1510L,1168200L,568260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112287Inst : IEnumerable<long>
{
public static readonly long[] Value=A112287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112287.Bytes);
public long this[int i]=>Value[i];

public static A112287Inst Instance=new A112287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112288
{
public static readonly BigInteger[] Value={ 1L,2L,11L,47L,4999L,4589867L,1802849L,80995354865L,10388318700333839827UL,BigInteger.Parse("129530631982136545940863"),BigInteger.Parse("460116344514106299899953231"),BigInteger.Parse("1272711183040784735474188752842879054737") };
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
public class A112288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112288Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112288.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112288Inst Instance=new A112288Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112289
{
public static readonly BigInteger[] Value={ 1L,1L,6L,33L,4200L,4192200L,1705200L,77892963984L,10086416728304192640UL,BigInteger.Parse("126556188275836361347200"),BigInteger.Parse("451535899566923284351392000"),BigInteger.Parse("1253032399528279799996000622278320876800") };
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
public class A112289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112289Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112289.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112289Inst Instance=new A112289Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112290
{
public static readonly BigInteger[] Value={ 1L,2L,7L,97L,331L,77089L,562609L,19352053463L,6781959158383L,4060488497950626661L,BigInteger.Parse("2877117441205884350399"),BigInteger.Parse("7936150834464388482084637351"),BigInteger.Parse("21924183158935156780838459") };
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
public class A112290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112290Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112290.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112290Inst Instance=new A112290Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112291
{
public static readonly BigInteger[] Value={ 1L,1L,3L,42L,150L,36270L,270900L,9440379900L,3332912051700L,2004302168707167000L,BigInteger.Parse("1424191116445997823000"),BigInteger.Parse("3936008766237071969447818200"),BigInteger.Parse("10888542544398564939894000"),BigInteger.Parse("3606055788316324023953497288103040") };
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
public class A112291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112291Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112291.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112291Inst Instance=new A112291Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112292
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,1L,15L,15L,5L,1L,105L,105L,35L,7L,1L,945L,945L,315L,63L,9L,1L,10395L,10395L,3465L,693L,99L,11L,1L,135135L,135135L,45045L,9009L,1287L,143L,13L,1L,2027025L,2027025L,675675L,135135L,19305L,2145L,195L,15L,1L,34459425L,34459425L,11486475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112292Inst : IEnumerable<long>
{
public static readonly long[] Value=A112292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112292.Bytes);
public long this[int i]=>Value[i];

public static A112292Inst Instance=new A112292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112293
{
public static readonly BigInteger[] Value={ 1L,2L,7L,36L,253L,2278L,25059L,325768L,4886521L,83070858L,1578346303L,33145272364L,762341264373L,19058531609326L,514580353451803L,14922830250102288L,462607737753170929L,15266055345854640658UL,BigInteger.Parse("534311937104912423031") };
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
public class A112293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112293Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112293.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112293Inst Instance=new A112293Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112294
{
public static readonly BigInteger[] Value={ 1L,1L,4L,18L,121L,1055L,11376L,145852L,2165689L,36532197L,689873284L,14415662558L,330204013569L,8226714806323L,221470234531456L,6406397898751320L,198160750081637521L,6526636388676159977L,BigInteger.Parse("228040136335670652324") };
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
public class A112294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112294Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112294.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112294Inst Instance=new A112294Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112295
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-3L,1L,0L,0L,-5L,1L,0L,0L,0L,-7L,1L,0L,0L,0L,0L,-9L,1L,0L,0L,0L,0L,0L,-11L,1L,0L,0L,0L,0L,0L,0L,-13L,1L,0L,0L,0L,0L,0L,0L,0L,-15L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-17L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-19L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-21L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-23L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112295Inst : IEnumerable<long>
{
public static readonly long[] Value=A112295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112295.Bytes);
public long this[int i]=>Value[i];

public static A112295Inst Instance=new A112295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112296
{
public static readonly long[] Value={ 9L,9L,81L,99L,891L,9801L,9801L,19602L,39204L,79497L,499851L,548856L,1077021L,2274822L,4459554L,8909109L,70282971L,87111288L,664223571L,730645938L,5791910751L,6272012637L,36351143631L,49985258994L,88971507999L,789520249881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112296Inst : IEnumerable<long>
{
public static readonly long[] Value=A112296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112296.Bytes);
public long this[int i]=>Value[i];

public static A112296Inst Instance=new A112296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112297
{
public static readonly long[] Value={ 470L,384L,294L,150L,153L,520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112297Inst : IEnumerable<long>
{
public static readonly long[] Value=A112297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112297.Bytes);
public long this[int i]=>Value[i];

public static A112297Inst Instance=new A112297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112298
{
public static readonly long[] Value={ 1L,-3L,1L,3L,0L,-3L,2L,-3L,1L,0L,0L,3L,2L,-6L,0L,3L,0L,-3L,2L,0L,2L,0L,0L,-3L,1L,-6L,1L,6L,0L,0L,2L,-3L,0L,0L,0L,3L,2L,-6L,2L,0L,0L,-6L,2L,0L,0L,0L,0L,3L,3L,-3L,0L,6L,0L,-3L,0L,-6L,2L,0L,0L,0L,2L,-6L,2L,3L,0L,0L,2L,0L,0L,0L,0L,-3L,2L,-6L,1L,6L,0L,-6L,2L,0L,1L,0L,0L,6L,0L,-6L,0L,0L,0L,0L,4L,0L,2L,0L,0L,-3L,2L,-9L,0L,3L,0L,0L,2L,-6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112298Inst : IEnumerable<long>
{
public static readonly long[] Value=A112298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112298.Bytes);
public long this[int i]=>Value[i];

public static A112298Inst Instance=new A112298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112299
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,1L,1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112299Inst : IEnumerable<long>
{
public static readonly long[] Value=A112299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112299.Bytes);
public long this[int i]=>Value[i];

public static A112299Inst Instance=new A112299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112300
{
public static readonly long[] Value={ 1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L,2L,-1L,0L,1L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112300Inst : IEnumerable<long>
{
public static readonly long[] Value=A112300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112300.Bytes);
public long this[int i]=>Value[i];

public static A112300Inst Instance=new A112300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112301
{
public static readonly long[] Value={ 1L,-2L,0L,0L,2L,0L,0L,0L,1L,-4L,0L,0L,2L,0L,0L,0L,2L,-2L,0L,0L,0L,0L,0L,0L,3L,-4L,0L,0L,2L,0L,0L,0L,0L,-4L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L,1L,-6L,0L,0L,2L,0L,0L,0L,0L,-4L,0L,0L,2L,0L,0L,0L,4L,0L,0L,0L,0L,0L,0L,0L,2L,-4L,0L,0L,0L,0L,0L,0L,1L,-4L,0L,0L,4L,0L,0L,0L,2L,-4L,0L,0L,0L,0L,0L,0L,2L,-2L,0L,0L,2L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112301Inst : IEnumerable<long>
{
public static readonly long[] Value=A112301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112301.Bytes);
public long this[int i]=>Value[i];

public static A112301Inst Instance=new A112301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112302
{
public static readonly long[] Value={ 1L,6L,6L,1L,6L,8L,7L,9L,4L,9L,6L,3L,3L,5L,9L,4L,1L,2L,1L,2L,9L,5L,8L,1L,8L,9L,2L,2L,7L,4L,9L,9L,5L,0L,7L,4L,9L,9L,6L,4L,4L,1L,8L,6L,3L,5L,0L,2L,5L,0L,6L,8L,2L,0L,8L,1L,8L,9L,7L,1L,1L,1L,6L,8L,0L,2L,5L,6L,0L,9L,0L,2L,9L,8L,2L,6L,3L,8L,3L,7L,2L,7L,9L,0L,8L,3L,6L,9L,1L,7L,6L,4L,1L,1L,4L,6L,1L,1L,6L,7L,1L,5L,5L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112302Inst : IEnumerable<long>
{
public static readonly long[] Value=A112302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112302.Bytes);
public long this[int i]=>Value[i];

public static A112302Inst Instance=new A112302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112303
{
public static readonly long[] Value={ 2L,7L,3L,17L,11L,5L,29L,19L,13L,41L,31L,23L,53L,43L,37L,67L,59L,47L,79L,71L,61L,97L,83L,73L,107L,101L,89L,127L,109L,103L,139L,139L,131L,113L,157L,149L,137L,173L,163L,151L,191L,179L,167L,193L,181L,227L,211L,197L,239L,229L,223L,257L,263L,251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112303Inst : IEnumerable<long>
{
public static readonly long[] Value=A112303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112303.Bytes);
public long this[int i]=>Value[i];

public static A112303Inst Instance=new A112303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112304
{
public static readonly long[] Value={ 2L,7L,19L,46L,214L,394L,1114L,3994L,3826L,13666L,83554L,22234L,189814L,644869L,1387786L,1427911L,4355311L,5715319L,12807391L,43030381L,64320754L,133826599L,452980999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112304Inst : IEnumerable<long>
{
public static readonly long[] Value=A112304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112304.Bytes);
public long this[int i]=>Value[i];

public static A112304Inst Instance=new A112304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112305
{
public static readonly long[] Value={ 1L,3L,7L,4L,14L,7L,5L,7L,9L,19L,8L,7L,6L,12L,52L,15L,28L,12L,18L,31L,12L,8L,29L,7L,30L,39L,9L,12L,77L,52L,14L,15L,35L,28L,21L,12L,19L,28L,39L,31L,35L,12L,82L,8L,52L,55L,29L,64L,15L,52L,124L,39L,33L,35L,14L,12L,103L,123L,64L,52L,68L,60L,12L,15L,52L,35L,100L,28L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112305Inst : IEnumerable<long>
{
public static readonly long[] Value=A112305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112305.Bytes);
public long this[int i]=>Value[i];

public static A112305Inst Instance=new A112305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112306
{
public static readonly long[] Value={ 1L,3L,6L,13L,27L,54L,109L,218L,437L,874L,1749L,3499L,6998L,13997L,27994L,55989L,111978L,223957L,447915L,895830L,1791661L,3583322L,7166645L,14333290L,28666581L,57333163L,114666326L,229332653L,458665307L,917330614L,1834661229L,3669322459L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112306Inst : IEnumerable<long>
{
public static readonly long[] Value=A112306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112306.Bytes);
public long this[int i]=>Value[i];

public static A112306Inst Instance=new A112306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112307
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,4L,6L,3L,1L,9L,16L,12L,4L,1L,23L,44L,39L,20L,5L,1L,65L,128L,123L,76L,30L,6L,1L,197L,392L,393L,268L,130L,42L,7L,1L,626L,1250L,1284L,928L,505L,204L,56L,8L,1L,2056L,4110L,4287L,3216L,1880L,864L,301L,72L,9L,1L,6918L,13834L,14583L,11224L,6885L,3438L,1379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112307Inst : IEnumerable<long>
{
public static readonly long[] Value=A112307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112307.Bytes);
public long this[int i]=>Value[i];

public static A112307Inst Instance=new A112307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112308
{
public static readonly long[] Value={ 1L,6L,25L,93L,333L,1180L,4183L,14895L,53349L,192239L,696765L,2539157L,9299547L,34215102L,126411177L,468822297L,1744799967L,6514363557L,24393558687L,91591471287L,344764147407L,1300756937445L,4918188617379L,18633066901747L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112308Inst : IEnumerable<long>
{
public static readonly long[] Value=A112308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112308.Bytes);
public long this[int i]=>Value[i];

public static A112308Inst Instance=new A112308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112309
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,3L,2L,3L,1L,2L,3L,2L,5L,1L,2L,5L,1L,3L,5L,2L,3L,5L,1L,2L,3L,5L,1L,3L,8L,2L,3L,8L,1L,2L,3L,8L,2L,5L,8L,1L,2L,5L,8L,1L,3L,5L,8L,2L,3L,5L,8L,1L,2L,3L,5L,8L,2L,5L,13L,1L,2L,5L,13L,1L,3L,5L,13L,2L,3L,5L,13L,1L,2L,3L,5L,13L,1L,3L,8L,13L,2L,3L,8L,13L,1L,2L,3L,8L,13L,2L,5L,8L,13L,1L,2L,5L,8L,13L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112309Inst : IEnumerable<long>
{
public static readonly long[] Value=A112309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112309.Bytes);
public long this[int i]=>Value[i];

public static A112309Inst Instance=new A112309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112310
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,3L,2L,3L,3L,3L,4L,3L,3L,4L,3L,4L,4L,4L,5L,3L,4L,4L,4L,5L,4L,4L,5L,4L,5L,5L,5L,6L,4L,4L,5L,4L,5L,5L,5L,6L,4L,5L,5L,5L,6L,5L,5L,6L,5L,6L,6L,6L,7L,4L,5L,5L,5L,6L,5L,5L,6L,5L,6L,6L,6L,7L,5L,5L,6L,5L,6L,6L,6L,7L,5L,6L,6L,6L,7L,6L,6L,7L,6L,7L,7L,7L,8L,5L,5L,6L,5L,6L,6L,6L,7L,5L,6L,6L,6L,7L,6L,6L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112310Inst : IEnumerable<long>
{
public static readonly long[] Value=A112310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112310.Bytes);
public long this[int i]=>Value[i];

public static A112310Inst Instance=new A112310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112311
{
public static readonly BigInteger[] Value={ 1L,2L,9L,216L,174960L,146932807680L,BigInteger.Parse("125937291507579224064000"),BigInteger.Parse("108755666689817047890109782510255885778944000000"),BigInteger.Parse("93143885917529328515023382841413836868525118214478405334515136630707122998865821696000000000000") };
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
public class A112311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112311Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112311.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112311Inst Instance=new A112311Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112312
{
public static readonly long[] Value={ 4L,8L,15L,6L,9L,7L,29L,19L,30L,78L,15L,20L,36L,83L,30L,34L,65L,69L,101L,133L,32L,19L,271L,110L,20L,187L,14L,185L,106L,173L,587L,80L,12L,35L,11L,224L,72L,38L,42L,315L,101L,26L,73L,172L,383L,27L,84L,362L,35L,250L,37L,29L,507L,305L,55L,38L,178L,332L,62L,537L,778L,459L,31L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112312Inst : IEnumerable<long>
{
public static readonly long[] Value=A112312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112312.Bytes);
public long this[int i]=>Value[i];

public static A112312Inst Instance=new A112312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112313
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,0L,2L,0L,0L,0L,2L,0L,1L,1L,3L,0L,2L,0L,3L,0L,1L,1L,5L,0L,3L,1L,5L,0L,4L,1L,7L,2L,4L,2L,9L,0L,7L,2L,10L,2L,9L,3L,13L,3L,10L,3L,17L,2L,14L,7L,18L,5L,18L,5L,25L,6L,22L,9L,31L,7L,27L,13L,34L,10L,36L,12L,45L,15L,40L,19L,54L,15L,52L,24L,63L,22L,67L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112313Inst : IEnumerable<long>
{
public static readonly long[] Value=A112313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112313.Bytes);
public long this[int i]=>Value[i];

public static A112313Inst Instance=new A112313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112314
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,1L,0L,3L,0L,0L,0L,2L,0L,0L,0L,3L,0L,0L,0L,1L,0L,1L,0L,5L,0L,0L,0L,3L,0L,1L,0L,5L,1L,0L,0L,4L,0L,1L,0L,7L,0L,2L,0L,4L,0L,2L,0L,9L,1L,0L,0L,7L,0L,2L,0L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112314Inst : IEnumerable<long>
{
public static readonly long[] Value=A112314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112314.Bytes);
public long this[int i]=>Value[i];

public static A112314Inst Instance=new A112314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112315
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112315Inst : IEnumerable<long>
{
public static readonly long[] Value=A112315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112315.Bytes);
public long this[int i]=>Value[i];

public static A112315Inst Instance=new A112315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112316
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112316Inst : IEnumerable<long>
{
public static readonly long[] Value=A112316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112316.Bytes);
public long this[int i]=>Value[i];

public static A112316Inst Instance=new A112316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112317
{
public static readonly BigInteger[] Value={ 1L,2L,6L,30L,220L,2170L,27076L,409836L,7303164L,149837028L,3479498880L,90230486346L,2584679465160L,81056989408928L,2762187020749144L,101633218030586364L,4015771398425994048L,BigInteger.Parse("169588657820702174728") };
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
public class A112317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112317Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112317.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112317Inst Instance=new A112317Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112318
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,7L,8L,9L,9L,10L,10L,11L,12L,12L,13L,14L,14L,15L,15L,16L,17L,17L,18L,18L,19L,20L,20L,21L,21L,22L,23L,23L,24L,24L,25L,26L,26L,27L,28L,28L,29L,29L,30L,31L,31L,32L,32L,33L,34L,34L,35L,35L,36L,37L,37L,38L,39L,39L,40L,40L,41L,42L,42L,43L,43L,44L,45L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112318Inst : IEnumerable<long>
{
public static readonly long[] Value=A112318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112318.Bytes);
public long this[int i]=>Value[i];

public static A112318Inst Instance=new A112318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112319
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,64L,630L,7916L,121023L,2179556L,45179508L,1059312264L,27715541568L,800423573676L,25289923553700L,867723362137464L,32128443862364255L,1276818947065793736L,BigInteger.Parse("54208515369076658640"),BigInteger.Parse("2448636361058495090816"),BigInteger.Parse("117254071399557173396416") };
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
public class A112319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112319Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112319.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112319Inst Instance=new A112319Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112320
{
public static readonly BigInteger[] Value={ 1L,3L,12L,70L,560L,5810L,74760L,1153740L,20817588L,430604724L,10052947476L,261595087182L,7509722346204L,235808741944100L,8040824716606176L,295914258931377276L,11690732617035570008UL,BigInteger.Parse("493527339623630078552") };
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
public class A112320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112320Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112320.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112320Inst Instance=new A112320Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112321
{
public static readonly long[] Value={ 2L,17L,157L,1547L,15094L,203879L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112321Inst : IEnumerable<long>
{
public static readonly long[] Value=A112321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112321.Bytes);
public long this[int i]=>Value[i];

public static A112321Inst Instance=new A112321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112322
{
public static readonly long[] Value={ 4L,289L,24649L,2393209L,227828836L,41566646641L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112322Inst : IEnumerable<long>
{
public static readonly long[] Value=A112322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112322.Bytes);
public long this[int i]=>Value[i];

public static A112322Inst Instance=new A112322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112323
{
public static readonly long[] Value={ 3L,5L,2L,10L,17L,19L,13L,31L,38L,11L,41L,49L,31L,73L,82L,93L,89L,19L,115L,107L,5L,136L,148L,107L,31L,38L,178L,161L,139L,67L,220L,236L,103L,256L,56L,181L,47L,283L,302L,313L,269L,52L,287L,61L,74L,65L,69L,388L,341L,289L,423L,359L,137L,456L,467L,478L,101L,107L,349L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112323Inst : IEnumerable<long>
{
public static readonly long[] Value=A112323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112323.Bytes);
public long this[int i]=>Value[i];

public static A112323Inst Instance=new A112323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112324
{
public static readonly long[] Value={ 2L,2L,1L,3L,10L,12L,8L,12L,15L,7L,30L,36L,20L,30L,35L,40L,58L,15L,48L,70L,4L,57L,65L,88L,24L,25L,75L,106L,108L,56L,93L,105L,68L,117L,37L,150L,39L,120L,135L,140L,178L,45L,190L,48L,49L,16L,17L,165L,226L,228L,190L,238L,120L,205L,210L,215L,67L,90L,276L,140L,84L,260L,228L,310L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112324Inst : IEnumerable<long>
{
public static readonly long[] Value=A112324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112324.Bytes);
public long this[int i]=>Value[i];

public static A112324Inst Instance=new A112324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112325
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,4L,5L,5L,6L,6L,7L,7L,8L,8L,9L,9L,9L,9L,9L,10L,11L,11L,11L,12L,12L,13L,13L,14L,14L,14L,14L,15L,15L,16L,16L,16L,17L,17L,17L,18L,18L,18L,18L,19L,19L,20L,20L,20L,21L,21L,22L,22L,22L,23L,23L,23L,24L,24L,24L,24L,25L,25L,26L,26L,26L,27L,27L,27L,28L,28L,28L,29L,29L,29L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112325Inst : IEnumerable<long>
{
public static readonly long[] Value=A112325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112325.Bytes);
public long this[int i]=>Value[i];

public static A112325Inst Instance=new A112325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112326
{
public static readonly long[] Value={ 2L,6L,4L,20L,16L,8L,70L,60L,40L,16L,252L,224L,168L,96L,32L,924L,840L,672L,448L,224L,64L,3432L,3168L,2640L,1920L,1152L,512L,128L,12870L,12012L,10296L,7920L,5280L,2880L,1152L,256L,48620L,45760L,40040L,32032L,22880L,14080L,7040L,2560L,512L,184756L,175032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112326Inst : IEnumerable<long>
{
public static readonly long[] Value=A112326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112326.Bytes);
public long this[int i]=>Value[i];

public static A112326Inst Instance=new A112326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112327
{
public static readonly long[] Value={ 2L,2L,16L,4L,32L,72L,10L,80L,216L,256L,28L,224L,648L,1024L,800L,84L,672L,2016L,3584L,4000L,2304L,264L,2112L,6480L,12288L,16000L,13824L,6272L,858L,6864L,21384L,42240L,60000L,62208L,43904L,16384L,2860L,22880L,72072L,146432L,220000L,253440L,219520L,131072L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112327Inst : IEnumerable<long>
{
public static readonly long[] Value=A112327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112327.Bytes);
public long this[int i]=>Value[i];

public static A112327Inst Instance=new A112327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112328
{
public static readonly long[] Value={ 2L,18L,108L,562L,2724L,12660L,57240L,253842L,1109748L,4798780L,20572392L,87580308L,370706408L,1561573032L,6551178288L,27387484242L,114146434068L,474476717292L,1967642119368L,8142727008732L,33634295542968L,138696447565272L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112328Inst : IEnumerable<long>
{
public static readonly long[] Value=A112328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112328.Bytes);
public long this[int i]=>Value[i];

public static A112328Inst Instance=new A112328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112329
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,0L,2L,2L,3L,0L,2L,2L,2L,0L,4L,3L,2L,0L,2L,2L,4L,0L,2L,4L,3L,0L,4L,2L,2L,0L,2L,4L,4L,0L,4L,3L,2L,0L,4L,4L,2L,0L,2L,2L,6L,0L,2L,6L,3L,0L,4L,2L,2L,0L,4L,4L,4L,0L,2L,4L,2L,0L,6L,5L,4L,0L,2L,2L,4L,0L,2L,6L,2L,0L,6L,2L,4L,0L,2L,6L,5L,0L,2L,4L,4L,0L,4L,4L,2L,0L,4L,2L,4L,0L,4L,8L,2L,0L,6L,3L,2L,0L,2L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112329Inst : IEnumerable<long>
{
public static readonly long[] Value=A112329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112329.Bytes);
public long this[int i]=>Value[i];

public static A112329Inst Instance=new A112329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112330
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,5L,6L,5L,7L,8L,7L,6L,9L,7L,8L,8L,9L,8L,8L,9L,8L,11L,11L,11L,11L,9L,14L,10L,15L,12L,12L,15L,11L,14L,10L,14L,12L,13L,12L,16L,15L,13L,12L,12L,17L,13L,16L,16L,15L,16L,19L,14L,17L,16L,16L,21L,15L,18L,16L,18L,18L,18L,19L,21L,20L,19L,20L,22L,17L,20L,27L,19L,25L,20L,18L,23L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112330Inst : IEnumerable<long>
{
public static readonly long[] Value=A112330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112330.Bytes);
public long this[int i]=>Value[i];

public static A112330Inst Instance=new A112330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112331
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,4L,1L,5L,16L,5L,6L,35L,1L,9L,1L,9L,10L,12L,1L,15L,107L,15L,479L,18L,578L,19L,965L,936L,27L,64L,21L,29L,2374L,72L,39L,32L,4527L,33L,6483L,43L,41L,129L,13942L,78L,18119L,127L,81L,71L,28481L,220L,66L,55L,123L,713L,70222L,85L,85970L,1155L,73L,123542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112331Inst : IEnumerable<long>
{
public static readonly long[] Value=A112331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112331.Bytes);
public long this[int i]=>Value[i];

public static A112331Inst Instance=new A112331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112332
{
public static readonly BigInteger[] Value={ 1L,1L,2L,24L,2880L,4838400L,146313216000L,97339256340480000L,BigInteger.Parse("1683704371913057894400000"),BigInteger.Parse("873705178746128941669416960000000"),BigInteger.Parse("15414977576506278044562764045746176000000000") };
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
public class A112332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112332Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A112332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112332.Bytes);
public BigInteger this[int i]=>Value[i];

public static A112332Inst Instance=new A112332Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112333
{
public static readonly long[] Value={ 1L,2L,1L,10L,5L,1L,80L,40L,8L,1L,880L,440L,88L,11L,1L,12320L,6160L,1232L,154L,14L,1L,209440L,104720L,20944L,2618L,238L,17L,1L,4188800L,2094400L,418880L,52360L,4760L,340L,20L,1L,96342400L,48171200L,9634240L,1204280L,109480L,7820L,460L,23L,1L,2504902400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112333Inst : IEnumerable<long>
{
public static readonly long[] Value=A112333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112333.Bytes);
public long this[int i]=>Value[i];

public static A112333Inst Instance=new A112333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112334
{
public static readonly long[] Value={ 1L,-2L,1L,0L,-5L,1L,0L,0L,-8L,1L,0L,0L,0L,-11L,1L,0L,0L,0L,0L,-14L,1L,0L,0L,0L,0L,0L,-17L,1L,0L,0L,0L,0L,0L,0L,-20L,1L,0L,0L,0L,0L,0L,0L,0L,-23L,1L,0L,0L,0L,0L,0L,0L,0L,0L,-26L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-29L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-32L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-35L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-38L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112334Inst : IEnumerable<long>
{
public static readonly long[] Value=A112334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112334.Bytes);
public long this[int i]=>Value[i];

public static A112334Inst Instance=new A112334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112335
{
public static readonly long[] Value={ 1L,-1L,-4L,-7L,-10L,-13L,-16L,-19L,-22L,-25L,-28L,-31L,-34L,-37L,-40L,-43L,-46L,-49L,-52L,-55L,-58L,-61L,-64L,-67L,-70L,-73L,-76L,-79L,-82L,-85L,-88L,-91L,-94L,-97L,-100L,-103L,-106L,-109L,-112L,-115L,-118L,-121L,-124L,-127L,-130L,-133L,-136L,-139L,-142L,-145L,-148L,-151L,-154L,-157L,-160L,-163L,-166L,-169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112335Inst : IEnumerable<long>
{
public static readonly long[] Value=A112335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112335.Bytes);
public long this[int i]=>Value[i];

public static A112335Inst Instance=new A112335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112336
{
public static readonly long[] Value={ 1L,2L,2L,6L,4L,4L,20L,12L,8L,8L,70L,40L,24L,16L,16L,252L,140L,80L,48L,32L,32L,924L,504L,280L,160L,96L,64L,64L,3432L,1848L,1008L,560L,320L,192L,128L,128L,12870L,6864L,3696L,2016L,1120L,640L,384L,256L,256L,48620L,25740L,13728L,7392L,4032L,2240L,1280L,768L,512L,512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112336Inst : IEnumerable<long>
{
public static readonly long[] Value=A112336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112336.Bytes);
public long this[int i]=>Value[i];

public static A112336Inst Instance=new A112336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112337
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,7L,15L,12L,18L,15L,23L,38L,42L,45L,47L,92L,70L,99L,81L,102L,98L,109L,207L,132L,218L,241L,459L,258L,502L,509L,1011L,846L,1058L,869L,1137L,1248L,1150L,1271L,1191L,1668L,1330L,1687L,1571L,3258L,1752L,3331L,5083L,3354L,5126L,3587L,5337L,4180L,5356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112337Inst : IEnumerable<long>
{
public static readonly long[] Value=A112337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112337.Bytes);
public long this[int i]=>Value[i];

public static A112337Inst Instance=new A112337Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112338
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,5L,1L,1L,4L,12L,14L,1L,1L,5L,22L,57L,42L,1L,1L,6L,35L,148L,303L,132L,1L,1L,7L,51L,305L,1144L,1743L,429L,1L,8L,70L,546L,3105L,9784L,10629L,1430L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112338Inst : IEnumerable<long>
{
public static readonly long[] Value=A112338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112338.Bytes);
public long this[int i]=>Value[i];

public static A112338Inst Instance=new A112338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112339
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,3L,1L,13L,16L,4L,1L,28L,67L,34L,5L,1L,60L,249L,229L,65L,6L,1L,123L,853L,1265L,609L,107L,7L,1L,251L,2787L,6325L,4696L,1376L,168L,8L,1L,506L,8840L,29484L,31947L,14068L,2772L,244L,9L,1L,1018L,27503L,131402L,199766L,124859L,36252L,5118L,345L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112339Inst : IEnumerable<long>
{
public static readonly long[] Value=A112339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112339.Bytes);
public long this[int i]=>Value[i];

public static A112339Inst Instance=new A112339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A112340
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,1L,5L,3L,0L,1L,13L,16L,4L,0L,1L,28L,67L,34L,5L,0L,1L,60L,249L,229L,65L,6L,0L,1L,123L,853L,1265L,609L,107L,7L,0L,1L,251L,2787L,6325L,4696L,1376L,168L,8L,0L,1L,506L,8840L,29484L,31947L,14068L,2772L,244L,9L,0L,1L,1018L,27503L,131402L,199766L,124859L,36252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A112340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A112340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A112340Inst : IEnumerable<long>
{
public static readonly long[] Value=A112340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A112340.Bytes);
public long this[int i]=>Value[i];

public static A112340Inst Instance=new A112340Inst();

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