using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A231495
{
public static readonly long[] Value={ 1L,1L,2L,8L,41L,266L,1976L,16569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231495Inst : IEnumerable<long>
{
public static readonly long[] Value=A231495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231495.Bytes);
public long this[int i]=>Value[i];

public static A231495Inst Instance=new A231495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231496
{
public static readonly long[] Value={ 1L,1L,2L,8L,39L,220L,1396L,9716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231496Inst : IEnumerable<long>
{
public static readonly long[] Value=A231496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231496.Bytes);
public long this[int i]=>Value[i];

public static A231496Inst Instance=new A231496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231497
{
public static readonly long[] Value={ 1L,1L,1L,3L,11L,43L,191L,939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231497Inst : IEnumerable<long>
{
public static readonly long[] Value=A231497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231497.Bytes);
public long this[int i]=>Value[i];

public static A231497Inst Instance=new A231497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231498
{
public static readonly long[] Value={ 0L,1L,1L,4L,29L,343L,6536L,202890L,10403135L,889855638L,127697994191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231498Inst : IEnumerable<long>
{
public static readonly long[] Value=A231498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231498.Bytes);
public long this[int i]=>Value[i];

public static A231498Inst Instance=new A231498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231499
{
public static readonly long[] Value={ 0L,1L,0L,2L,20L,277L,5776L,188900L,9980698L,868571406L,125895356788L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231499Inst : IEnumerable<long>
{
public static readonly long[] Value=A231499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231499.Bytes);
public long this[int i]=>Value[i];

public static A231499Inst Instance=new A231499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231500
{
public static readonly long[] Value={ 0L,1L,2L,6L,7L,11L,15L,24L,25L,29L,33L,42L,46L,55L,64L,80L,81L,85L,89L,98L,102L,111L,120L,136L,140L,149L,158L,174L,183L,199L,215L,240L,241L,245L,249L,258L,262L,271L,280L,296L,300L,309L,318L,334L,343L,359L,375L,400L,404L,413L,422L,438L,447L,463L,479L,504L,513L,529L,545L,570L,586L,611L,636L,672L,673L,677L,681L,690L,694L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231500Inst : IEnumerable<long>
{
public static readonly long[] Value=A231500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231500.Bytes);
public long this[int i]=>Value[i];

public static A231500Inst Instance=new A231500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231501
{
public static readonly long[] Value={ 0L,1L,2L,10L,11L,19L,27L,54L,55L,63L,71L,98L,106L,133L,160L,224L,225L,233L,241L,268L,276L,303L,330L,394L,402L,429L,456L,520L,547L,611L,675L,800L,801L,809L,817L,844L,852L,879L,906L,970L,978L,1005L,1032L,1096L,1123L,1187L,1251L,1376L,1384L,1411L,1438L,1502L,1529L,1593L,1657L,1782L,1809L,1873L,1937L,2062L,2126L,2251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231501Inst : IEnumerable<long>
{
public static readonly long[] Value=A231501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231501.Bytes);
public long this[int i]=>Value[i];

public static A231501Inst Instance=new A231501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231502
{
public static readonly long[] Value={ 0L,1L,2L,18L,19L,35L,51L,132L,133L,149L,165L,246L,262L,343L,424L,680L,681L,697L,713L,794L,810L,891L,972L,1228L,1244L,1325L,1406L,1662L,1743L,1999L,2255L,2880L,2881L,2897L,2913L,2994L,3010L,3091L,3172L,3428L,3444L,3525L,3606L,3862L,3943L,4199L,4455L,5080L,5096L,5177L,5258L,5514L,5595L,5851L,6107L,6732L,6813L,7069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231502Inst : IEnumerable<long>
{
public static readonly long[] Value=A231502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231502.Bytes);
public long this[int i]=>Value[i];

public static A231502Inst Instance=new A231502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231503
{
public static readonly long[] Value={ 0L,1L,5L,6L,10L,19L,23L,32L,48L,49L,53L,62L,66L,75L,91L,100L,116L,141L,145L,154L,170L,179L,195L,220L,236L,261L,297L,298L,302L,311L,315L,324L,340L,349L,365L,390L,394L,403L,419L,428L,444L,469L,485L,510L,546L,555L,571L,596L,612L,637L,673L,698L,734L,783L,787L,796L,812L,821L,837L,862L,878L,903L,939L,948L,964L,989L,1005L,1030L,1066L,1091L,1127L,1176L,1192L,1217L,1253L,1278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231503Inst : IEnumerable<long>
{
public static readonly long[] Value=A231503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231503.Bytes);
public long this[int i]=>Value[i];

public static A231503Inst Instance=new A231503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231632
{
public static readonly long[] Value={ 169L,225L,289L,625L,676L,841L,900L,1156L,1225L,1369L,1521L,1681L,2025L,2500L,2601L,2704L,2809L,3025L,3364L,3600L,3721L,4225L,4624L,4900L,5329L,5476L,5625L,6084L,6724L,7225L,7569L,7921L,8100L,8281L,9025L,9409L,10000L,10201L,10404L,10816L,11025L,11236L,11881L,12100L,12321L,12769L,13225L,13456L,13689L,14161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231632Inst : IEnumerable<long>
{
public static readonly long[] Value=A231632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231632.Bytes);
public long this[int i]=>Value[i];

public static A231632Inst Instance=new A231632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231633
{
public static readonly long[] Value={ 0L,0L,1L,2L,3L,1L,3L,2L,5L,2L,4L,2L,7L,2L,5L,3L,5L,3L,10L,4L,5L,3L,8L,3L,14L,6L,5L,4L,11L,5L,11L,3L,11L,9L,4L,5L,10L,5L,11L,9L,12L,3L,19L,7L,11L,6L,12L,9L,11L,7L,17L,7L,13L,5L,22L,3L,3L,15L,16L,5L,25L,4L,9L,11L,13L,5L,19L,6L,22L,6L,11L,6L,39L,6L,24L,7L,7L,6L,25L,8L,21L,11L,24L,7L,31L,7L,19L,11L,33L,10L,14L,8L,15L,27L,18L,9L,21L,4L,27L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231633Inst : IEnumerable<long>
{
public static readonly long[] Value=A231633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231633.Bytes);
public long this[int i]=>Value[i];

public static A231633Inst Instance=new A231633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231634
{
public static readonly BigInteger[] Value={ 1L,3L,15L,105L,2835L,31185L,2027025L,91216125L,10854718875L,206239658625L,7795859096025L,4482618980214375L,72512954091703125L,BigInteger.Parse("99850337784275203125"),BigInteger.Parse("37643577344671751578125"),BigInteger.Parse("8168656283793770092453125"),BigInteger.Parse("12518528979807790079765625") };
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
public class A231634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231634Inst Instance=new A231634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231635
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,2L,1L,1L,4L,2L,6L,1L,3L,2L,8L,4L,5L,4L,3L,2L,7L,5L,6L,2L,3L,2L,8L,5L,10L,6L,3L,1L,8L,3L,9L,4L,4L,4L,14L,6L,16L,7L,7L,2L,12L,6L,8L,4L,5L,5L,21L,5L,8L,6L,4L,8L,11L,7L,12L,5L,6L,4L,10L,8L,22L,6L,10L,6L,17L,9L,23L,7L,11L,12L,18L,10L,19L,10L,10L,7L,23L,8L,15L,4L,7L,8L,14L,11L,19L,9L,2L,4L,11L,10L,35L,6L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231635Inst : IEnumerable<long>
{
public static readonly long[] Value=A231635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231635.Bytes);
public long this[int i]=>Value[i];

public static A231635Inst Instance=new A231635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231636
{
public static readonly long[] Value={ 1L,5L,25L,124L,599L,2907L,14098L,68345L,331411L,1606976L,7792087L,37783439L,183209634L,888373029L,4307670407L,20887647824L,101283014043L,491115562211L,2381391364586L,11547230982705L,55991864805211L,271501360719136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231636Inst : IEnumerable<long>
{
public static readonly long[] Value=A231636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231636.Bytes);
public long this[int i]=>Value[i];

public static A231636Inst Instance=new A231636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231637
{
public static readonly long[] Value={ 3L,25L,362L,5110L,69671L,953726L,13036446L,178192422L,2435768976L,33294651915L,455108952124L,6220940586463L,85034818039884L,1162351701934606L,15888332641640874L,217179633334137617L,2968655946926989630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231637Inst : IEnumerable<long>
{
public static readonly long[] Value=A231637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231637.Bytes);
public long this[int i]=>Value[i];

public static A231637Inst Instance=new A231637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231638
{
public static readonly BigInteger[] Value={ 8L,124L,5110L,193596L,7176194L,266730604L,9902703284L,367678630271L,13651615789060L,506869469707295L,18819548834677196L,698750427030584024L,BigInteger.Parse("25943883731772910738"),BigInteger.Parse("963269692028936919099"),BigInteger.Parse("35765211805260137301887") };
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
public class A231638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231638Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231638.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231638Inst Instance=new A231638Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231639
{
public static readonly BigInteger[] Value={ 21L,599L,69671L,7176194L,722149510L,72839521581L,7337927223290L,739300928401336L,74484943708241718L,7504342874539244449L,BigInteger.Parse("756062619205812384051"),BigInteger.Parse("76173283584466268712696"),BigInteger.Parse("7674456207021624430421367") };
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
public class A231639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231639Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231639.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231639Inst Instance=new A231639Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231640
{
public static readonly BigInteger[] Value={ 55L,2907L,953726L,266730604L,72839521581L,19935360619245L,5448852806527104L,1489472227762012570L,BigInteger.Parse("407153748122282833931"),BigInteger.Parse("111296504708033952837061"),BigInteger.Parse("30423245413711787972071775"),BigInteger.Parse("8316285148242091648350745493") };
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
public class A231640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231640Inst Instance=new A231640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231641
{
public static readonly long[] Value={ 1L,1L,1L,3L,5L,3L,8L,25L,25L,8L,21L,124L,362L,124L,21L,55L,599L,5110L,5110L,599L,55L,144L,2907L,69671L,193596L,69671L,2907L,144L,377L,14098L,953726L,7176194L,7176194L,953726L,14098L,377L,987L,68345L,13036446L,266730604L,722149510L,266730604L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231641Inst : IEnumerable<long>
{
public static readonly long[] Value=A231641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231641.Bytes);
public long this[int i]=>Value[i];

public static A231641Inst Instance=new A231641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231642
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,0L,0L,1L,0L,3L,2L,3L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,4L,0L,6L,0L,4L,0L,1L,0L,0L,3L,0L,0L,3L,0L,0L,1L,0L,5L,0L,0L,2L,0L,0L,5L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,6L,4L,3L,0L,0L,0L,3L,4L,6L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,7L,0L,7L,0L,7L,2L,7L,0L,7L,0L,7L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231642Inst : IEnumerable<long>
{
public static readonly long[] Value=A231642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231642.Bytes);
public long this[int i]=>Value[i];

public static A231642Inst Instance=new A231642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231643
{
public static readonly long[] Value={ 10L,15L,25L,45L,85L,165L,325L,645L,1285L,2565L,5125L,10245L,20485L,40965L,81925L,163845L,327685L,655365L,1310725L,2621445L,5242885L,10485765L,20971525L,41943045L,83886085L,167772165L,335544325L,671088645L,1342177285L,2684354565L,5368709125L,10737418245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231643Inst : IEnumerable<long>
{
public static readonly long[] Value=A231643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231643.Bytes);
public long this[int i]=>Value[i];

public static A231643Inst Instance=new A231643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231644
{
public static readonly BigInteger[] Value={ 3L,35L,920L,137961L,96014413L,374409597564L,7673178325424236L,BigInteger.Parse("823755531731133088630"),BigInteger.Parse("468550736330699430524865279") };
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
public class A231644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231644Inst Instance=new A231644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231645
{
public static readonly long[] Value={ 3L,35L,104L,341L,1189L,4040L,13560L,45803L,155131L,524683L,1773770L,5998876L,20290918L,68629108L,232120783L,785115525L,2655576210L,8982247095L,30381769982L,102764504913L,347595681724L,1175726561166L,3976846922803L,13451535863780L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231645Inst : IEnumerable<long>
{
public static readonly long[] Value=A231645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231645.Bytes);
public long this[int i]=>Value[i];

public static A231645Inst Instance=new A231645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231646
{
public static readonly long[] Value={ 9L,104L,920L,7682L,61574L,490760L,3929027L,31501117L,252454167L,2022844426L,16209670759L,129896538285L,1040912909763L,8341204621591L,66841228911422L,535624801555647L,4292168448581044L,34394795269925139L,275618732897288063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231646Inst : IEnumerable<long>
{
public static readonly long[] Value=A231646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231646.Bytes);
public long this[int i]=>Value[i];

public static A231646Inst Instance=new A231646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231647
{
public static readonly BigInteger[] Value={ 22L,341L,7682L,137961L,2412274L,42882766L,765163605L,13643499478L,243317286312L,4340128403053L,77412117578960L,1380680024126767L,24625023800964584L,439200986311182069L,7833405373009045177L,BigInteger.Parse("139713294059336266128") };
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
public class A231647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231647Inst Instance=new A231647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231696
{
public static readonly BigInteger[] Value={ 50L,1998L,115583L,6074096L,286808607L,14007173906L,696904625544L,34390368202345L,1693611631652448L,83546478885400765L,4121506683565058802L,BigInteger.Parse("203261277285880002250"),BigInteger.Parse("10024941696145652614843"),BigInteger.Parse("494455010365407138814774") };
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
public class A231696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231696Inst Instance=new A231696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231697
{
public static readonly BigInteger[] Value={ 144L,13260L,2049855L,286808607L,34764511754L,4333974317355L,556835183317668L,71067313709831125L,9020067185976407959L,BigInteger.Parse("1146622410485781036080"),BigInteger.Parse("145894809076844042966799"),BigInteger.Parse("18557178929287225291004307") };
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
public class A231697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231697Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231697.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231697Inst Instance=new A231697Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231698
{
public static readonly BigInteger[] Value={ 422L,94996L,37872601L,14007173906L,4333974317355L,1383168339985798L,458723384178436491L,BigInteger.Parse("151028533752547571008"),BigInteger.Parse("49335557302876746551356"),BigInteger.Parse("16145864650820204721710388"),BigInteger.Parse("5292025656827127971428710436") };
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
public class A231698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231698Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231698.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231698Inst Instance=new A231698Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231699
{
public static readonly BigInteger[] Value={ 1268L,691229L,711067486L,696904625544L,556835183317668L,458723384178436491L,BigInteger.Parse("394600405782342943410"),BigInteger.Parse("337091385019548510376164"),BigInteger.Parse("285400541198740304070351399"),BigInteger.Parse("242059566770098900152264298823") };
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
public class A231699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231699Inst Instance=new A231699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231700
{
public static readonly long[] Value={ 4L,4L,4L,16L,28L,16L,50L,272L,272L,50L,144L,1998L,5972L,1998L,144L,422L,13260L,115583L,115583L,13260L,422L,1268L,94996L,2049855L,6074096L,2049855L,94996L,1268L,3823L,691229L,37872601L,286808607L,286808607L,37872601L,691229L,3823L,11472L,4926082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231700Inst : IEnumerable<long>
{
public static readonly long[] Value=A231700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231700.Bytes);
public long this[int i]=>Value[i];

public static A231700Inst Instance=new A231700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231701
{
public static readonly long[] Value={ 109L,111L,123L,135L,147L,159L,161L,173L,185L,197L,208L,210L,222L,234L,246L,258L,260L,272L,284L,296L,307L,319L,321L,333L,345L,357L,369L,371L,383L,395L,406L,418L,420L,432L,444L,456L,468L,470L,482L,494L,505L,517L,529L,531L,543L,555L,567L,579L,581L,593L,604L,616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231701Inst : IEnumerable<long>
{
public static readonly long[] Value=A231701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231701.Bytes);
public long this[int i]=>Value[i];

public static A231701Inst Instance=new A231701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231702
{
public static readonly BigInteger[] Value={ 5L,87L,2840L,332529L,115091431L,108702736653L,302778325808865L,2471353666263112035L,BigInteger.Parse("58118910922698278619927"),BigInteger.Parse("3968246179910884317349374115"),BigInteger.Parse("787645110600810210613646674667649") };
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
public class A231702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231702Inst Instance=new A231702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231703
{
public static readonly long[] Value={ 5L,17L,42L,121L,351L,978L,2768L,7851L,22168L,62688L,177333L,501398L,1417871L,4009693L,11338691L,32064185L,90673442L,256411571L,725096165L,2050472356L,5798450868L,16397214669L,46369052496L,131125251872L,370804035439L,1048582421408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231703Inst : IEnumerable<long>
{
public static readonly long[] Value=A231703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231703.Bytes);
public long this[int i]=>Value[i];

public static A231703Inst Instance=new A231703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231704
{
public static readonly long[] Value={ 17L,87L,387L,1903L,9352L,45126L,218976L,1063266L,5157832L,25029089L,121453256L,589322201L,2859633713L,13876023287L,67331513300L,326717840479L,1585356878661L,7692742049748L,37328056194113L,181129653079705L,878908640782024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231704Inst : IEnumerable<long>
{
public static readonly long[] Value=A231704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231704.Bytes);
public long this[int i]=>Value[i];

public static A231704Inst Instance=new A231704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231705
{
public static readonly long[] Value={ 42L,387L,2840L,23584L,197605L,1601683L,13087828L,107398293L,878894477L,7193285719L,58898156726L,482180316552L,3947375486172L,32316205361007L,264563453161915L,2165898853276949L,17731567206469017L,145163047328289678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231705Inst : IEnumerable<long>
{
public static readonly long[] Value=A231705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231705.Bytes);
public long this[int i]=>Value[i];

public static A231705Inst Instance=new A231705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231706
{
public static readonly long[] Value={ 121L,1903L,23584L,332529L,4734057L,65213128L,907753996L,12682706594L,176596945800L,2460065350035L,34285813050422L,477719134188549L,6656334381797448L,92750381409100734L,1292374690807750073L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231706Inst : IEnumerable<long>
{
public static readonly long[] Value=A231706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231706.Bytes);
public long this[int i]=>Value[i];

public static A231706Inst Instance=new A231706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231707
{
public static readonly BigInteger[] Value={ 351L,9352L,197605L,4734057L,115091431L,2710953352L,64449267435L,1537649843980L,36565903346612L,869868073036783L,20703716623272502L,492654848823048438L,11722867136672182885UL,BigInteger.Parse("278960884987428457197"),BigInteger.Parse("6638141869460230995898") };
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
public class A231707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231707Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231707.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231707Inst Instance=new A231707Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231708
{
public static readonly BigInteger[] Value={ 978L,45126L,1601683L,65213128L,2710953352L,108702736653L,4397103321129L,178637016494076L,7231676877762957L,292858412207690044L,11867158650189110733UL,BigInteger.Parse("480748480305913820618"),BigInteger.Parse("19474949312698830159485") };
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
public class A231708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231708Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231708.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231708Inst Instance=new A231708Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231709
{
public static readonly BigInteger[] Value={ 2768L,218976L,13087828L,907753996L,64449267435L,4397103321129L,302778325808865L,20952485843800523L,1444541280140169200L,BigInteger.Parse("99629994394766797436"),BigInteger.Parse("6875988804756686889640"),BigInteger.Parse("474400949867226927308820") };
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
public class A231709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231709Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231709.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231709Inst Instance=new A231709Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231710
{
public static readonly long[] Value={ 5L,17L,17L,42L,87L,42L,121L,387L,387L,121L,351L,1903L,2840L,1903L,351L,978L,9352L,23584L,23584L,9352L,978L,2768L,45126L,197605L,332529L,197605L,45126L,2768L,7851L,218976L,1601683L,4734057L,4734057L,1601683L,218976L,7851L,22168L,1063266L,13087828L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231710Inst : IEnumerable<long>
{
public static readonly long[] Value=A231710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231710.Bytes);
public long this[int i]=>Value[i];

public static A231710Inst Instance=new A231710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231711
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,25L,26L,27L,28L,29L,31L,32L,33L,34L,35L,37L,38L,39L,40L,41L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,81L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231711Inst : IEnumerable<long>
{
public static readonly long[] Value=A231711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231711.Bytes);
public long this[int i]=>Value[i];

public static A231711Inst Instance=new A231711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231744
{
public static readonly BigInteger[] Value={ 144L,6064L,784076L,71742015L,6425495277L,598711367728L,56006640316980L,5220406326242670L,486885544941495652L,BigInteger.Parse("45439583623043602188"),BigInteger.Parse("4239994977410757148897"),BigInteger.Parse("395581225544558104634606") };
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
public class A231744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231744Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231744.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231744Inst Instance=new A231744Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231745
{
public static readonly BigInteger[] Value={ 422L,26918L,9945132L,2426463539L,598711367728L,155985773478611L,40539474933206048L,10471241201508754882UL,BigInteger.Parse("2708333085420702066371"),BigInteger.Parse("701131301655294979491764"),BigInteger.Parse("181453765111432778651835050") };
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
public class A231745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231745Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231745.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231745Inst Instance=new A231745Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231746
{
public static readonly long[] Value={ 4L,4L,4L,16L,84L,16L,50L,318L,318L,50L,144L,1328L,4430L,1328L,144L,422L,6064L,60806L,60806L,6064L,422L,1268L,26918L,784076L,2154900L,784076L,26918L,1268L,3823L,116909L,9945132L,71742015L,71742015L,9945132L,116909L,3823L,11472L,511264L,126926437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231746Inst : IEnumerable<long>
{
public static readonly long[] Value=A231746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231746.Bytes);
public long this[int i]=>Value[i];

public static A231746Inst Instance=new A231746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231747
{
public static readonly long[] Value={ 3L,15L,51L,186L,687L,2485L,9068L,33308L,121445L,444183L,1626731L,5949198L,21774916L,79713938L,291767058L,1068145321L,3910543065L,14316731138L,52417430039L,191916565888L,702674552025L,2572785049162L,9420099176524L,34491356066515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231747Inst : IEnumerable<long>
{
public static readonly long[] Value=A231747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231747.Bytes);
public long this[int i]=>Value[i];

public static A231747Inst Instance=new A231747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231748
{
public static readonly long[] Value={ 9L,51L,589L,5106L,41288L,397219L,3745096L,34036486L,313782748L,2927905037L,27164864918L,251564198963L,2335778916642L,21695352159535L,201366887006680L,1869228803618176L,17356005419910937L,161143681489604094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231748Inst : IEnumerable<long>
{
public static readonly long[] Value=A231748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231748.Bytes);
public long this[int i]=>Value[i];

public static A231748Inst Instance=new A231748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231749
{
public static readonly BigInteger[] Value={ 22L,186L,5106L,101517L,1787168L,36596191L,764681711L,15421779553L,309633476778L,6284893573378L,127697430555401L,2587148736974819L,52408991398868709L,1062536884554302876L,BigInteger.Parse("21542235015238071587"),BigInteger.Parse("436659223538195787389") };
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
public class A231749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231749Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231749.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231749Inst Instance=new A231749Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231750
{
public static readonly BigInteger[] Value={ 51L,687L,41288L,1787168L,67411714L,2966010838L,131956285636L,5669387332934L,243573416110820L,10555475178328001L,457172040211929179L,BigInteger.Parse("19760692150060588600"),BigInteger.Parse("854390327504135396722"),BigInteger.Parse("36958540950287007144750") };
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
public class A231750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231750Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231750.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231750Inst Instance=new A231750Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231751
{
public static readonly BigInteger[] Value={ 121L,2485L,397219L,36596191L,2966010838L,309458955366L,31638510266609L,3041193156650724L,296576264769131499L,BigInteger.Parse("29380275874994459363"),BigInteger.Parse("2892477394704091137503"),BigInteger.Parse("283798285900590449754004") };
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
public class A231751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231751Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231751.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231751Inst Instance=new A231751Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231752
{
public static readonly BigInteger[] Value={ 292L,9068L,3745096L,764681711L,131956285636L,31638510266609L,7467132505589749L,1615073569445439856L,BigInteger.Parse("354430510983036028174"),BigInteger.Parse("79728003072248618902703"),BigInteger.Parse("17808572706541641197645512"),BigInteger.Parse("3952770212213173521620797011") };
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
public class A231752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231752Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231752.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231752Inst Instance=new A231752Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231753
{
public static readonly long[] Value={ 3L,3L,3L,9L,15L,9L,22L,51L,51L,22L,51L,186L,589L,186L,51L,121L,687L,5106L,5106L,687L,121L,292L,2485L,41288L,101517L,41288L,2485L,292L,704L,9068L,397219L,1787168L,1787168L,397219L,9068L,704L,1691L,33308L,3745096L,36596191L,67411714L,36596191L,3745096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231753Inst : IEnumerable<long>
{
public static readonly long[] Value=A231753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231753.Bytes);
public long this[int i]=>Value[i];

public static A231753Inst Instance=new A231753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231754
{
public static readonly long[] Value={ 1L,5L,13L,17L,29L,37L,41L,53L,61L,65L,73L,85L,89L,97L,101L,109L,113L,137L,145L,149L,157L,173L,181L,185L,193L,197L,205L,221L,229L,233L,241L,257L,265L,269L,277L,281L,293L,305L,313L,317L,337L,349L,353L,365L,373L,377L,389L,397L,401L,409L,421L,433L,445L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231754Inst : IEnumerable<long>
{
public static readonly long[] Value=A231754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231754.Bytes);
public long this[int i]=>Value[i];

public static A231754Inst Instance=new A231754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231755
{
public static readonly BigInteger[] Value={ 331L,1398079L,89478457L,BigInteger.Parse("393530540239137101071"),BigInteger.Parse("1730765619511609209510165443073253"),BigInteger.Parse("8173309551284740577911184144801648979299941984979211421"),BigInteger.Parse("2142584059011987034055949456454883470029603991710390447068299") };
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
public class A231755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231755Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231755.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231755Inst Instance=new A231755Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231756
{
public static readonly long[] Value={ 1L,2L,5L,8L,9L,10L,15L,16L,17L,20L,26L,29L,46L,50L,51L,52L,79L,80L,81L,83L,90L,92L,94L,100L,142L,144L,149L,150L,159L,160L,161L,162L,167L,168L,170L,171L,172L,173L,200L,246L,247L,251L,254L,255L,258L,259L,260L,262L,264L,283L,284L,287L,289L,290L,297L,299L,449L,454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231756Inst : IEnumerable<long>
{
public static readonly long[] Value=A231756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231756.Bytes);
public long this[int i]=>Value[i];

public static A231756Inst Instance=new A231756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231757
{
public static readonly BigInteger[] Value={ 9L,136L,5041L,493695L,175642009L,216545491864L,682267982467600L,6184663140527966655L,BigInteger.Parse("184835030323441507989529"),BigInteger.Parse("17039092957711747812559207879"),BigInteger.Parse("4549223325244087259619117440725081") };
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
public class A231757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231757Inst Instance=new A231757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231758
{
public static readonly long[] Value={ 33L,136L,660L,3213L,14989L,70927L,338352L,1603633L,7596720L,36066272L,171140301L,811651995L,3850637109L,18269376384L,86668158745L,411153474416L,1950577525332L,9253691650061L,43899995716425L,208265361505983L,988028267125504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231758Inst : IEnumerable<long>
{
public static readonly long[] Value=A231758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231758.Bytes);
public long this[int i]=>Value[i];

public static A231758Inst Instance=new A231758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231759
{
public static readonly long[] Value={ 100L,625L,5041L,40000L,303601L,2353156L,18318400L,141681409L,1096603225L,8501393209L,65862549769L,510117350625L,3952044600625L,30617619155761L,237184671441601L,1837438830737449L,14234617914330724L,110274092537986624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231759Inst : IEnumerable<long>
{
public static readonly long[] Value=A231759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231759.Bytes);
public long this[int i]=>Value[i];

public static A231759Inst Instance=new A231759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231824
{
public static readonly BigInteger[] Value={ 8L,439L,21770L,1043604L,49913988L,2386203232L,114066364087L,5452552422721L,260639820308206L,12458949924513786L,595555266275826559L,BigInteger.Parse("28468375889842472535"),BigInteger.Parse("1360828238560274914467"),BigInteger.Parse("65049495673466518331031") };
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
public class A231824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231824Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231824.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231824Inst Instance=new A231824Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231825
{
public static readonly BigInteger[] Value={ 21L,2992L,393408L,49913988L,6320545103L,800089656653L,101271407955316L,12818259615003968L,1622444211916657853L,BigInteger.Parse("205357307411023046970"),BigInteger.Parse("25992645488143063760536"),BigInteger.Parse("3289961325223483451122730") };
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
public class A231825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231825Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231825.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231825Inst Instance=new A231825Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231826
{
public static readonly BigInteger[] Value={ 55L,20382L,7103846L,2386203232L,800089656653L,268201160539247L,89898324366354186L,BigInteger.Parse("30132701233909614426"),BigInteger.Parse("10100040231429709499771"),BigInteger.Parse("3385383306883066827388203"),BigInteger.Parse("1134729955505683847727639879") };
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
public class A231826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231826Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231826.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231826Inst Instance=new A231826Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231827
{
public static readonly BigInteger[] Value={ 144L,138852L,128269829L,114066364087L,101271407955316L,89898324366354186L,BigInteger.Parse("79797684859445363871"),BigInteger.Parse("70831430430134151721833"),BigInteger.Parse("62872486092172191075739307"),BigInteger.Parse("55807813117284440069439544084"),BigInteger.Parse("49536955255745171418608535533833") };
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
public class A231827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231827Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231827.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231827Inst Instance=new A231827Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231828
{
public static readonly long[] Value={ 1L,1L,1L,3L,9L,3L,8L,64L,64L,8L,21L,439L,1205L,439L,21L,55L,2992L,21770L,21770L,2992L,55L,144L,20382L,393408L,1043604L,393408L,20382L,144L,377L,138852L,7103846L,49913988L,49913988L,7103846L,138852L,377L,987L,945923L,128269829L,2386203232L,6320545103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231828Inst : IEnumerable<long>
{
public static readonly long[] Value=A231828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231828.Bytes);
public long this[int i]=>Value[i];

public static A231828Inst Instance=new A231828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231829
{
public static readonly long[] Value={ 1L,3L,3L,6L,13L,6L,10L,40L,40L,10L,15L,108L,213L,108L,15L,21L,275L,1049L,1049L,275L,21L,28L,681L,5034L,9349L,5034L,681L,28L,36L,1664L,23984L,80626L,80626L,23984L,1664L,36L,45L,4040L,114069L,692194L,1222363L,692194L,114069L,4040L,45L,55L,9779L,542295L,5948291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231829Inst : IEnumerable<long>
{
public static readonly long[] Value=A231829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231829.Bytes);
public long this[int i]=>Value[i];

public static A231829Inst Instance=new A231829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231830
{
public static readonly BigInteger[] Value={ 5L,101L,1020101L,1061522231810040101L,BigInteger.Parse("1196154511175776540960913502483611007728163340227060101") };
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
public class A231830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231830Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231830.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231830Inst Instance=new A231830Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231831
{
public static readonly BigInteger[] Value={ 3L,35L,44099L,85762231424099L,BigInteger.Parse("630794963141019085083178800095033630804099") };
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
public class A231831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231831Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231831.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231831Inst Instance=new A231831Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231832
{
public static readonly BigInteger[] Value={ 4L,50L,4508L,3477361L,24188209253L,1254045703514371L,BigInteger.Parse("474822731471136470440"),BigInteger.Parse("1348354196926200275839295164"),BigInteger.Parse("29381088329574641941731352369292061"),BigInteger.Parse("4908846924825797705595322427394823109676747") };
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
public class A231832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231832Inst Instance=new A231832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231833
{
public static readonly long[] Value={ 4L,50L,422L,3823L,34350L,308419L,2771101L,24892609L,223618304L,2008825312L,18045827096L,162110668160L,1456284886944L,13082209530648L,117521102664489L,1055724534522884L,9483865176690522L,85196181144951446L,765340833781554407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231833Inst : IEnumerable<long>
{
public static readonly long[] Value=A231833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231833.Bytes);
public long this[int i]=>Value[i];

public static A231833Inst Instance=new A231833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231834
{
public static readonly BigInteger[] Value={ 16L,188L,4508L,111621L,2836554L,71178861L,1792092360L,45099279326L,1134900171250L,28560684486812L,718739864735561L,18087411635523189L,455177754069590473L,11454748470680974894UL,BigInteger.Parse("288263810554257272575") };
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
public class A231834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231834Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231834.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231834Inst Instance=new A231834Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231835
{
public static readonly BigInteger[] Value={ 50L,760L,52411L,3477361L,241961326L,16599585680L,1140658285204L,78428361897720L,5390322528656652L,370517687958114665L,BigInteger.Parse("25468098036554313595"),BigInteger.Parse("1750580722347118467767"),BigInteger.Parse("120328698088745644429376") };
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
public class A231835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231835Inst Instance=new A231835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231836
{
public static readonly BigInteger[] Value={ 144L,3309L,678660L,124132900L,24188209253L,4666623161419L,899426070636904L,173546274977761257L,BigInteger.Parse("33474310504831841795"),BigInteger.Parse("6456965889651937136227"),BigInteger.Parse("1245519756272860837583554"),BigInteger.Parse("240252847617486843960049416") };
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
public class A231836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231836Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231836.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231836Inst Instance=new A231836Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231837
{
public static readonly BigInteger[] Value={ 422L,14666L,8887871L,4378313800L,2346558875473L,1254045703514371L,667414220139740867L,BigInteger.Parse("355666172689879084210"),BigInteger.Parse("189521117184760778293515"),BigInteger.Parse("100979609057565187903930604"),BigInteger.Parse("53805681791889243019883807740") };
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
public class A231837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231837Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231837.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231837Inst Instance=new A231837Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231838
{
public static readonly BigInteger[] Value={ 1268L,64607L,114873933L,150624159314L,220309043506362L,324616806882571299L,BigInteger.Parse("474822731471136470440"),BigInteger.Parse("695244971516001773033192"),BigInteger.Parse("1018294151929133028079374411"),BigInteger.Parse("1491192875210978136830040921123") };
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
public class A231838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231838Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231838.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231838Inst Instance=new A231838Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231839
{
public static readonly long[] Value={ 4L,4L,16L,16L,50L,64L,50L,188L,422L,256L,144L,760L,4508L,3823L,1024L,422L,3309L,52411L,111621L,34350L,4096L,1268L,14666L,678660L,3477361L,2836554L,308419L,16384L,3823L,64607L,8887871L,124132900L,241961326L,71178861L,2771101L,65536L,11472L,283479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231839Inst : IEnumerable<long>
{
public static readonly long[] Value=A231839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231839.Bytes);
public long this[int i]=>Value[i];

public static A231839Inst Instance=new A231839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231920
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,110L,202L,220L,1000L,102L,21L,111L,122L,212L,221L,1001L,112L,121L,200L,211L,222L,1002L,120L,201L,210L,1011L,1022L,1101L,1110L,1202L,1220L,2012L,2021L,2102L,2120L,2201L,2210L,10000L,1010L,1100L,1111L,1122L,1212L,1221L,2002L,2020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231920Inst : IEnumerable<long>
{
public static readonly long[] Value=A231920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231920.Bytes);
public long this[int i]=>Value[i];

public static A231920Inst Instance=new A231920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231921
{
public static readonly long[] Value={ 0L,4L,1L,3L,9L,5L,2L,6L,10L,8L,12L,20L,24L,27L,11L,7L,13L,17L,23L,25L,28L,14L,16L,18L,22L,26L,29L,15L,19L,21L,31L,35L,37L,39L,47L,51L,59L,61L,65L,69L,73L,75L,81L,30L,36L,40L,44L,50L,52L,56L,60L,68L,70L,72L,76L,80L,82L,32L,34L,38L,42L,46L,48L,54L,58L,62L,64L,66L,74L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231921Inst : IEnumerable<long>
{
public static readonly long[] Value=A231921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231921.Bytes);
public long this[int i]=>Value[i];

public static A231921Inst Instance=new A231921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231922
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,3L,13L,31L,103L,30L,110L,33L,111L,21L,102L,120L,201L,210L,1000L,122L,133L,212L,221L,313L,331L,1001L,112L,23L,32L,113L,131L,223L,232L,300L,311L,322L,333L,1003L,123L,132L,213L,231L,312L,321L,1002L,121L,200L,211L,222L,233L,323L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231922Inst : IEnumerable<long>
{
public static readonly long[] Value=A231922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231922.Bytes);
public long this[int i]=>Value[i];

public static A231922Inst Instance=new A231922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231923
{
public static readonly long[] Value={ 0L,5L,1L,4L,16L,6L,2L,8L,17L,10L,3L,7L,13L,19L,12L,20L,15L,21L,9L,18L,24L,33L,36L,64L,26L,31L,38L,41L,55L,61L,65L,22L,11L,14L,23L,29L,43L,46L,48L,53L,58L,63L,67L,27L,30L,39L,45L,54L,57L,66L,25L,32L,37L,42L,47L,59L,62L,68L,34L,40L,51L,60L,69L,28L,49L,52L,71L,35L,44L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231923Inst : IEnumerable<long>
{
public static readonly long[] Value=A231923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231923.Bytes);
public long this[int i]=>Value[i];

public static A231923Inst Instance=new A231923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231924
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,3L,13L,31L,103L,30L,110L,33L,4L,14L,41L,104L,40L,114L,24L,42L,112L,21L,102L,120L,201L,210L,1000L,111L,44L,113L,23L,32L,121L,200L,211L,222L,233L,244L,323L,332L,424L,442L,1001L,122L,133L,144L,212L,221L,313L,331L,414L,441L,1002L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231924Inst : IEnumerable<long>
{
public static readonly long[] Value=A231924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231924.Bytes);
public long this[int i]=>Value[i];

public static A231924Inst Instance=new A231924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231925
{
public static readonly long[] Value={ 0L,6L,1L,5L,25L,7L,2L,10L,26L,12L,3L,8L,16L,28L,15L,30L,18L,4L,9L,21L,29L,20L,34L,14L,22L,32L,11L,27L,35L,51L,55L,125L,31L,24L,33L,13L,17L,36L,50L,56L,62L,68L,74L,88L,92L,114L,122L,126L,37L,43L,49L,57L,61L,83L,91L,109L,121L,127L,38L,42L,58L,66L,82L,86L,128L,40L,76L,80L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231925Inst : IEnumerable<long>
{
public static readonly long[] Value=A231925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231925.Bytes);
public long this[int i]=>Value[i];

public static A231925Inst Instance=new A231925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231926
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,3L,13L,31L,103L,30L,110L,33L,4L,14L,41L,104L,40L,114L,24L,42L,112L,21L,102L,120L,201L,210L,1000L,105L,15L,5L,25L,52L,115L,35L,53L,113L,23L,32L,121L,44L,55L,111L,51L,122L,133L,144L,155L,212L,221L,313L,331L,414L,441L,515L,551L,1001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231926Inst : IEnumerable<long>
{
public static readonly long[] Value=A231926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231926.Bytes);
public long this[int i]=>Value[i];

public static A231926Inst Instance=new A231926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231927
{
public static readonly long[] Value={ 0L,7L,1L,6L,36L,8L,2L,12L,37L,14L,3L,9L,19L,39L,18L,42L,21L,4L,10L,25L,40L,24L,46L,16L,26L,44L,13L,38L,48L,73L,78L,216L,41L,11L,5L,17L,32L,47L,23L,33L,45L,15L,20L,49L,28L,35L,43L,31L,50L,57L,64L,71L,80L,85L,117L,127L,154L,169L,191L,211L,217L,55L,22L,27L,58L,63L,118L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231927Inst : IEnumerable<long>
{
public static readonly long[] Value=A231927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231927.Bytes);
public long this[int i]=>Value[i];

public static A231927Inst Instance=new A231927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231928
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,3L,13L,31L,103L,30L,110L,33L,4L,14L,41L,104L,40L,114L,24L,42L,112L,21L,102L,120L,201L,210L,1000L,105L,15L,5L,25L,52L,115L,35L,53L,113L,23L,32L,121L,26L,6L,16L,61L,106L,60L,116L,36L,63L,131L,34L,43L,134L,143L,314L,341L,413L,431L,1003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231928Inst : IEnumerable<long>
{
public static readonly long[] Value=A231928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231928.Bytes);
public long this[int i]=>Value[i];

public static A231928Inst Instance=new A231928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231929
{
public static readonly long[] Value={ 0L,8L,1L,7L,49L,9L,2L,14L,50L,16L,3L,10L,22L,52L,21L,56L,24L,4L,11L,29L,53L,28L,60L,18L,30L,58L,15L,51L,63L,99L,105L,343L,54L,12L,5L,19L,37L,61L,26L,38L,59L,17L,23L,64L,20L,6L,13L,43L,55L,42L,62L,27L,45L,71L,25L,31L,74L,80L,158L,176L,206L,218L,346L,57L,32L,40L,48L,65L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231929Inst : IEnumerable<long>
{
public static readonly long[] Value=A231929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231929.Bytes);
public long this[int i]=>Value[i];

public static A231929Inst Instance=new A231929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231930
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,3L,13L,31L,103L,30L,110L,33L,4L,14L,41L,104L,40L,114L,24L,42L,112L,21L,102L,120L,201L,210L,1000L,105L,15L,5L,25L,52L,115L,35L,53L,113L,23L,32L,121L,26L,6L,16L,61L,106L,60L,116L,36L,63L,131L,34L,43L,134L,143L,314L,341L,413L,431L,1003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231930Inst : IEnumerable<long>
{
public static readonly long[] Value=A231930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231930.Bytes);
public long this[int i]=>Value[i];

public static A231930Inst Instance=new A231930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231931
{
public static readonly long[] Value={ 0L,9L,1L,8L,64L,10L,2L,16L,65L,18L,3L,11L,25L,67L,24L,72L,27L,4L,12L,33L,68L,32L,76L,20L,34L,74L,17L,66L,80L,129L,136L,512L,69L,13L,5L,21L,42L,77L,29L,43L,75L,19L,26L,81L,22L,6L,14L,49L,70L,48L,78L,30L,51L,89L,28L,35L,92L,99L,204L,225L,267L,281L,515L,73L,15L,7L,23L,58L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231931Inst : IEnumerable<long>
{
public static readonly long[] Value=A231931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231931.Bytes);
public long this[int i]=>Value[i];

public static A231931Inst Instance=new A231931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231932
{
public static readonly long[] Value={ 0L,11L,1L,10L,100L,12L,2L,20L,101L,22L,3L,13L,31L,103L,30L,110L,33L,4L,14L,41L,104L,40L,114L,24L,42L,112L,21L,102L,120L,201L,210L,1000L,105L,15L,5L,25L,52L,115L,35L,53L,113L,23L,32L,121L,26L,6L,16L,61L,106L,60L,116L,36L,63L,131L,34L,43L,134L,143L,314L,341L,413L,431L,1003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231932Inst : IEnumerable<long>
{
public static readonly long[] Value=A231932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231932.Bytes);
public long this[int i]=>Value[i];

public static A231932Inst Instance=new A231932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231933
{
public static readonly long[] Value={ 0L,10L,1L,9L,81L,11L,2L,18L,82L,20L,3L,12L,28L,84L,27L,90L,30L,4L,13L,37L,85L,36L,94L,22L,38L,92L,19L,83L,99L,163L,171L,729L,86L,14L,5L,23L,47L,95L,32L,48L,93L,21L,29L,100L,24L,6L,15L,55L,87L,54L,96L,33L,57L,109L,31L,39L,112L,120L,256L,280L,336L,352L,732L,91L,16L,7L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231933Inst : IEnumerable<long>
{
public static readonly long[] Value=A231933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231933.Bytes);
public long this[int i]=>Value[i];

public static A231933Inst Instance=new A231933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231934
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,6L,27L,163L,1271L,12354L,145801L,2047083L,33642256L,638588460L,13845027215L,339607971556L,9347964267192L,286688210033698L,9734737020358855L,363942977852123850L,14906164891970353970UL,BigInteger.Parse("665835978084064725837"),BigInteger.Parse("32304867226779146102085"),BigInteger.Parse("1696127595521806495181023") };
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
public class A231934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231934Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231934.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231934Inst Instance=new A231934Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231935
{
public static readonly long[] Value={ 5L,7L,7L,11L,13L,13L,17L,19L,19L,23L,23L,23L,29L,31L,31L,31L,37L,37L,41L,43L,43L,47L,47L,47L,53L,53L,53L,59L,61L,61L,61L,67L,67L,71L,73L,73L,73L,79L,79L,83L,83L,83L,89L,89L,89L,79L,97L,97L,101L,103L,103L,107L,109L,109L,113L,113L,113L,109L,113L,113L,109L,127L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231935Inst : IEnumerable<long>
{
public static readonly long[] Value=A231935.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231935.Bytes);
public long this[int i]=>Value[i];

public static A231935Inst Instance=new A231935Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231984
{
public static readonly long[] Value={ 9L,9L,9L,9L,7L,4L,6L,1L,6L,4L,3L,9L,2L,7L,8L,6L,5L,4L,3L,2L,1L,9L,8L,5L,0L,9L,4L,7L,8L,4L,9L,6L,8L,2L,2L,5L,5L,1L,7L,9L,5L,9L,1L,5L,2L,4L,1L,8L,5L,7L,6L,4L,5L,2L,7L,4L,0L,6L,4L,6L,7L,2L,8L,4L,2L,8L,1L,4L,8L,7L,7L,7L,6L,0L,7L,1L,7L,3L,3L,6L,5L,8L,1L,8L,1L,5L,1L,7L,6L,0L,5L,8L,9L,6L,7L,7L,1L,4L,7L,6L,7L,1L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231984Inst : IEnumerable<long>
{
public static readonly long[] Value=A231984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231984.Bytes);
public long this[int i]=>Value[i];

public static A231984Inst Instance=new A231984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231985
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,2L,6L,9L,2L,3L,4L,4L,1L,6L,3L,3L,7L,9L,1L,6L,0L,6L,0L,3L,6L,3L,3L,3L,5L,8L,6L,6L,1L,7L,7L,8L,6L,3L,9L,6L,5L,2L,1L,8L,5L,2L,8L,7L,7L,6L,6L,6L,4L,9L,0L,3L,5L,0L,7L,8L,1L,3L,6L,4L,3L,8L,2L,8L,4L,3L,2L,4L,1L,8L,9L,7L,4L,7L,5L,1L,7L,2L,2L,4L,0L,2L,4L,1L,2L,1L,1L,9L,0L,2L,4L,6L,7L,9L,8L,8L,5L,9L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231985Inst : IEnumerable<long>
{
public static readonly long[] Value=A231985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231985.Bytes);
public long this[int i]=>Value[i];

public static A231985Inst Instance=new A231985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231986
{
public static readonly long[] Value={ 9L,2L,7L,6L,8L,9L,4L,7L,5L,3L,2L,2L,3L,1L,3L,6L,4L,0L,7L,9L,5L,6L,1L,3L,2L,3L,8L,1L,4L,5L,9L,5L,4L,9L,1L,7L,6L,3L,0L,4L,0L,4L,0L,0L,6L,4L,2L,4L,5L,7L,4L,3L,4L,0L,8L,9L,9L,9L,8L,6L,9L,0L,4L,6L,6L,9L,1L,7L,4L,8L,6L,1L,8L,8L,5L,9L,1L,4L,5L,1L,8L,8L,9L,3L,9L,3L,7L,1L,3L,1L,0L,9L,9L,0L,3L,1L,9L,1L,2L,3L,5L,3L,9L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231986Inst : IEnumerable<long>
{
public static readonly long[] Value=A231986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231986.Bytes);
public long this[int i]=>Value[i];

public static A231986Inst Instance=new A231986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231987
{
public static readonly long[] Value={ 1L,0L,4L,1L,1L,9L,1L,8L,0L,3L,6L,0L,6L,8L,7L,3L,3L,4L,0L,2L,3L,4L,6L,0L,7L,5L,3L,3L,5L,9L,2L,5L,6L,8L,7L,8L,8L,9L,0L,0L,6L,9L,6L,6L,7L,6L,0L,0L,6L,0L,8L,7L,1L,3L,4L,9L,1L,5L,2L,3L,0L,2L,8L,1L,3L,1L,2L,9L,9L,7L,1L,9L,7L,0L,4L,8L,2L,2L,3L,8L,5L,8L,9L,2L,8L,9L,5L,5L,5L,8L,8L,7L,1L,8L,8L,6L,4L,4L,3L,0L,7L,2L,7L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231987Inst : IEnumerable<long>
{
public static readonly long[] Value=A231987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231987.Bytes);
public long this[int i]=>Value[i];

public static A231987Inst Instance=new A231987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231988
{
public static readonly long[] Value={ 7L,29L,67L,191L,277L,947L,1129L,2557L,5779L,8647L,13367L,14029L,16111L,22367L,24977L,31627L,36857L,47279L,64621L,87991L,93097L,96581L,98347L,109279L,126757L,163307L,239087L,282377L,329267L,342379L,352381L,372817L,411779L,448879L,468029L,471907L,491537L,519691L,531997L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231988Inst : IEnumerable<long>
{
public static readonly long[] Value=A231988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231988.Bytes);
public long this[int i]=>Value[i];

public static A231988Inst Instance=new A231988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231989
{
public static readonly long[] Value={ 3L,3L,43L,236367611L,31542795419L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231989Inst : IEnumerable<long>
{
public static readonly long[] Value=A231989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231989.Bytes);
public long this[int i]=>Value[i];

public static A231989Inst Instance=new A231989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231990
{
public static readonly long[] Value={ 5L,1L,2L,1L,5L,1L,2L,10L,4L,1L,4L,2L,4L,1L,8L,14L,8L,1L,8L,7L,11L,1L,6L,2L,14L,29L,2L,11L,9L,3L,2L,11L,8L,13L,5L,4L,7L,6L,3L,24L,59L,9L,7L,1L,20L,5L,1L,8L,3L,33L,27L,11L,9L,12L,3L,2L,11L,9L,27L,4L,2L,5L,12L,1L,5L,16L,54L,80L,37L,15L,1L,6L,3L,33L,3L,17L,5L,9L,17L,1L,35L,32L,2L,72L,10L,3L,82L,6L,4L,6L,5L,2L,1L,5L,31L,14L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231990Inst : IEnumerable<long>
{
public static readonly long[] Value=A231990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231990.Bytes);
public long this[int i]=>Value[i];

public static A231990Inst Instance=new A231990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231991
{
public static readonly BigInteger[] Value={ 4L,32L,1024L,80511L,15594601L,9716967198L,17330552348004L,86052358301456560L,BigInteger.Parse("1193370539733163272100"),BigInteger.Parse("47736311347811120780540634"),BigInteger.Parse("5427560264549933547128560973449"),BigInteger.Parse("1747506522236821289436659004322720324") };
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
public class A231991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231991Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231991.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231991Inst Instance=new A231991Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231992
{
public static readonly long[] Value={ 6L,32L,156L,800L,4000L,20228L,101808L,513400L,2586980L,13039568L,65717568L,331222548L,1669362032L,8413644600L,42404958708L,213722166160L,1077165216736L,5428941217444L,27362005944240L,137905229697144L,695045979384260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231992Inst : IEnumerable<long>
{
public static readonly long[] Value=A231992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231992.Bytes);
public long this[int i]=>Value[i];

public static A231992Inst Instance=new A231992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231993
{
public static readonly long[] Value={ 39L,406L,5778L,80511L,1129755L,15851094L,222394359L,3120433160L,43782113196L,614302069661L,8619184643070L,120934641149878L,1696817594085078L,23807819771598730L,334044315193101606L,4686930858103951041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A231993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231993Inst : IEnumerable<long>
{
public static readonly long[] Value=A231993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231993.Bytes);
public long this[int i]=>Value[i];

public static A231993Inst Instance=new A231993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A231994
{
public static readonly BigInteger[] Value={ 81L,1225L,28900L,674041L,15594601L,362293156L,8404672329L,195072388900L,4526898777801L,105058031047524L,2438091190374961L,56581345271408896L,1313093651031910225L,BigInteger.Parse("30473226515305728361"),BigInteger.Parse("707198080089528623376") };
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
public class A231994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A231994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A231994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A231994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A231994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A231994Inst Instance=new A231994Inst();

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