using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A291245
{
public static readonly long[] Value={ 5L,24L,120L,599L,2990L,14925L,74500L,371876L,1856265L,9265776L,46251265L,230868900L,1152410620L,5752399899L,28713814350L,143328549649L,715442152480L,3571217840400L,17826174791885L,88981552487776L,444162405876285L,2217091490069376L,11066885918992400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291245Inst : IEnumerable<long>
{
public static readonly long[] Value=A291245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291245.Bytes);
public long this[int i]=>Value[i];

public static A291245Inst Instance=new A291245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291246
{
public static readonly long[] Value={ 6L,35L,210L,1259L,7548L,45252L,271296L,1626481L,9751122L,58460185L,350482050L,2101219272L,12597285450L,75523579487L,452780964690L,2714524435655L,16274188816248L,97567447965516L,584938949030724L,3506841484816717L,21024308981321682L,126045494230596949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291246Inst : IEnumerable<long>
{
public static readonly long[] Value=A291246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291246.Bytes);
public long this[int i]=>Value[i];

public static A291246Inst Instance=new A291246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291247
{
public static readonly long[] Value={ 1L,2L,5L,10L,24L,49L,112L,238L,526L,1142L,2491L,5442L,11842L,25873L,56344L,122975L,268042L,584633L,1274820L,2779895L,6062306L,13219186L,28827703L,62861754L,137082358L,298927682L,651861824L,1421488867L,3099781932L,6759580078L,14740333285L,32143687954L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291247Inst : IEnumerable<long>
{
public static readonly long[] Value=A291247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291247.Bytes);
public long this[int i]=>Value[i];

public static A291247Inst Instance=new A291247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291248
{
public static readonly long[] Value={ 1L,2L,5L,12L,27L,65L,146L,346L,788L,1845L,4239L,9865L,22758L,52818L,122072L,282954L,654528L,1516221L,3508817L,8125763L,18808494L,43550500L,100815652L,233418699L,540371471L,1251079052L,2896357943L,6705591388L,15524220275L,35941069252L,83208225215L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291248Inst : IEnumerable<long>
{
public static readonly long[] Value=A291248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291248.Bytes);
public long this[int i]=>Value[i];

public static A291248Inst Instance=new A291248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291297
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,5L,8L,12L,19L,26L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291297Inst : IEnumerable<long>
{
public static readonly long[] Value=A291297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291297.Bytes);
public long this[int i]=>Value[i];

public static A291297Inst Instance=new A291297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291298
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,10L,14L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291298Inst : IEnumerable<long>
{
public static readonly long[] Value=A291298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291298.Bytes);
public long this[int i]=>Value[i];

public static A291298Inst Instance=new A291298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291299
{
public static readonly long[] Value={ 2L,2L,2L,4L,6L,8L,10L,14L,20L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291299Inst : IEnumerable<long>
{
public static readonly long[] Value=A291299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291299.Bytes);
public long this[int i]=>Value[i];

public static A291299Inst Instance=new A291299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291300
{
public static readonly long[] Value={ 2L,3L,3L,2L,5L,9L,10L,17L,25L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291300Inst : IEnumerable<long>
{
public static readonly long[] Value=A291300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291300.Bytes);
public long this[int i]=>Value[i];

public static A291300Inst Instance=new A291300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291301
{
public static readonly BigInteger[] Value={ 2L,11L,71L,743L,6911L,117239L,2013983L,34836479L,921086711L,33596203871L,18754852859999L,1306753691335679L,2795529813471359L,200489563747397471L,7143750592470475271L,BigInteger.Parse("146095655504943513599"),BigInteger.Parse("161739770170976834876927"),BigInteger.Parse("543475838478389870591999"),BigInteger.Parse("317180662337566737324195839") };
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
public class A291301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291301Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291301.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291301Inst Instance=new A291301Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291302
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,3L,3L,1L,3L,4L,46L,57L,7L,9L,17L,1L,45L,1L,33L,8L,10L,4L,3L,32L,6L,47L,17L,21L,41L,17L,12L,11L,10L,31L,74L,25L,99L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291302Inst : IEnumerable<long>
{
public static readonly long[] Value=A291302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291302.Bytes);
public long this[int i]=>Value[i];

public static A291302Inst Instance=new A291302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291303
{
public static readonly long[] Value={ 1L,2L,4L,2L,5L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291303Inst : IEnumerable<long>
{
public static readonly long[] Value=A291303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291303.Bytes);
public long this[int i]=>Value[i];

public static A291303Inst Instance=new A291303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291304
{
public static readonly long[] Value={ 1L,1L,2L,0L,3L,3L,4L,4L,5L,5L,6L,6L,7L,5L,8L,8L,9L,9L,10L,10L,11L,11L,12L,10L,13L,13L,14L,14L,15L,15L,16L,16L,17L,15L,18L,18L,19L,19L,20L,20L,21L,21L,22L,20L,23L,23L,24L,24L,25L,25L,26L,26L,27L,25L,28L,28L,29L,29L,30L,30L,31L,31L,32L,30L,33L,33L,34L,34L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291304Inst : IEnumerable<long>
{
public static readonly long[] Value=A291304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291304.Bytes);
public long this[int i]=>Value[i];

public static A291304Inst Instance=new A291304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291305
{
public static readonly long[] Value={ 1L,2L,3L,0L,5L,6L,7L,8L,5L,10L,11L,12L,13L,10L,15L,16L,17L,18L,15L,20L,21L,22L,23L,20L,25L,26L,27L,28L,25L,30L,31L,32L,33L,30L,35L,36L,37L,38L,35L,40L,41L,42L,43L,40L,45L,46L,47L,48L,45L,50L,51L,52L,53L,50L,55L,56L,57L,58L,55L,60L,61L,62L,63L,60L,65L,66L,67L,68L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291305Inst : IEnumerable<long>
{
public static readonly long[] Value=A291305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291305.Bytes);
public long this[int i]=>Value[i];

public static A291305Inst Instance=new A291305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291306
{
public static readonly long[] Value={ 0L,0L,2L,4L,0L,6L,6L,6L,8L,10L,6L,12L,12L,12L,14L,16L,12L,18L,18L,18L,20L,22L,18L,24L,24L,24L,26L,28L,24L,30L,30L,30L,32L,34L,30L,36L,36L,36L,38L,40L,36L,42L,42L,42L,44L,46L,42L,48L,48L,48L,50L,52L,48L,54L,54L,54L,56L,58L,54L,60L,60L,60L,62L,64L,60L,66L,66L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291306Inst : IEnumerable<long>
{
public static readonly long[] Value=A291306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291306.Bytes);
public long this[int i]=>Value[i];

public static A291306Inst Instance=new A291306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291307
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,3L,3L,3L,4L,5L,3L,6L,6L,6L,7L,8L,6L,9L,9L,9L,10L,11L,9L,12L,12L,12L,13L,14L,12L,15L,15L,15L,16L,17L,15L,18L,18L,18L,19L,20L,18L,21L,21L,21L,22L,23L,21L,24L,24L,24L,25L,26L,24L,27L,27L,27L,28L,29L,27L,30L,30L,30L,31L,32L,30L,33L,33L,33L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291307Inst : IEnumerable<long>
{
public static readonly long[] Value=A291307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291307.Bytes);
public long this[int i]=>Value[i];

public static A291307Inst Instance=new A291307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291308
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,2L,2L,2L,4L,4L,3L,4L,4L,6L,5L,6L,4L,6L,8L,6L,8L,8L,6L,10L,8L,8L,9L,10L,12L,10L,10L,12L,12L,14L,10L,12L,12L,12L,16L,14L,12L,14L,16L,18L,16L,16L,15L,16L,20L,18L,17L,18L,16L,22L,18L,18L,20L,20L,24L,20L,20L,20L,21L,26L,24L,22L,24L,24L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291308Inst : IEnumerable<long>
{
public static readonly long[] Value=A291308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291308.Bytes);
public long this[int i]=>Value[i];

public static A291308Inst Instance=new A291308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291309
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,2L,2L,2L,3L,3L,3L,4L,3L,4L,4L,4L,5L,5L,6L,6L,6L,6L,6L,6L,6L,8L,7L,6L,8L,8L,9L,8L,10L,9L,9L,10L,9L,10L,10L,12L,11L,12L,11L,12L,12L,12L,14L,12L,12L,13L,13L,12L,15L,16L,15L,14L,15L,15L,15L,16L,18L,16L,16L,18L,17L,17L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291309Inst : IEnumerable<long>
{
public static readonly long[] Value=A291309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291309.Bytes);
public long this[int i]=>Value[i];

public static A291309Inst Instance=new A291309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291310
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,2L,2L,2L,2L,2L,3L,3L,4L,3L,4L,4L,4L,4L,5L,6L,4L,5L,6L,5L,6L,6L,8L,6L,6L,6L,8L,6L,8L,10L,9L,8L,8L,9L,10L,8L,12L,9L,11L,10L,10L,10L,12L,14L,10L,12L,13L,11L,12L,11L,16L,12L,12L,12L,15L,12L,12L,18L,16L,15L,12L,14L,17L,15L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291310Inst : IEnumerable<long>
{
public static readonly long[] Value=A291310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291310.Bytes);
public long this[int i]=>Value[i];

public static A291310Inst Instance=new A291310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291311
{
public static readonly long[] Value={ 1L,2L,3L,5L,9L,16L,27L,45L,75L,125L,207L,341L,560L,918L,1502L,2453L,4000L,6515L,10601L,17235L,28000L,45461L,73773L,119665L,194033L,314519L,509685L,825768L,1337612L,2166360L,3508085L,5680122L,9196043L,14886981L,24097953L,39005540L,63131935L,102176733L,165362855L,267614381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291311Inst : IEnumerable<long>
{
public static readonly long[] Value=A291311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291311.Bytes);
public long this[int i]=>Value[i];

public static A291311Inst Instance=new A291311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291312
{
public static readonly long[] Value={ 10001L,10010L,10011L,10100L,10101L,10110L,11000L,11001L,11010L,11100L,11122L,11133L,11144L,11155L,11166L,11177L,11188L,11199L,11212L,11221L,11222L,11313L,11331L,11333L,11414L,11441L,11444L,11515L,11551L,11555L,11616L,11661L,11666L,11717L,11771L,11777L,11818L,11881L,11888L,11919L,11991L,11999L,12112L,12121L,12122L,12211L,12212L,12221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291312Inst : IEnumerable<long>
{
public static readonly long[] Value=A291312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291312.Bytes);
public long this[int i]=>Value[i];

public static A291312Inst Instance=new A291312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291476
{
public static readonly long[] Value={ 25L,25L,25L,20L,25L,25L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,23L,8L,25L,13L,9L,7L,25L,10L,25L,8L,11L,17L,7L,9L,25L,19L,13L,8L,25L,7L,25L,11L,9L,23L,25L,8L,7L,10L,17L,13L,25L,9L,11L,7L,19L,25L,25L,10L,25L,25L,7L,8L,13L,11L,25L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291476Inst : IEnumerable<long>
{
public static readonly long[] Value=A291476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291476.Bytes);
public long this[int i]=>Value[i];

public static A291476Inst Instance=new A291476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291477
{
public static readonly long[] Value={ 31L,31L,31L,24L,30L,31L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,23L,8L,25L,13L,9L,7L,29L,10L,31L,8L,11L,17L,7L,9L,31L,19L,13L,8L,31L,7L,31L,11L,9L,23L,31L,8L,7L,10L,17L,13L,31L,9L,11L,7L,19L,29L,31L,10L,31L,31L,7L,8L,13L,11L,31L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291477Inst : IEnumerable<long>
{
public static readonly long[] Value=A291477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291477.Bytes);
public long this[int i]=>Value[i];

public static A291477Inst Instance=new A291477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291478
{
public static readonly long[] Value={ 37L,37L,37L,28L,35L,37L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,23L,8L,25L,13L,9L,7L,29L,10L,31L,8L,11L,17L,7L,9L,37L,19L,13L,8L,37L,7L,37L,11L,9L,23L,37L,8L,7L,10L,17L,13L,37L,9L,11L,7L,19L,29L,37L,10L,37L,31L,7L,8L,13L,11L,37L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291478Inst : IEnumerable<long>
{
public static readonly long[] Value=A291478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291478.Bytes);
public long this[int i]=>Value[i];

public static A291478Inst Instance=new A291478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291479
{
public static readonly long[] Value={ 43L,43L,43L,32L,40L,43L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,23L,8L,25L,13L,9L,7L,29L,10L,31L,8L,11L,17L,7L,9L,37L,19L,13L,8L,41L,7L,43L,11L,9L,23L,43L,8L,7L,10L,17L,13L,43L,9L,11L,7L,19L,29L,43L,10L,43L,31L,7L,8L,13L,11L,43L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291479Inst : IEnumerable<long>
{
public static readonly long[] Value=A291479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291479.Bytes);
public long this[int i]=>Value[i];

public static A291479Inst Instance=new A291479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291480
{
public static readonly long[] Value={ 49L,49L,49L,36L,45L,49L,7L,8L,9L,10L,11L,12L,13L,7L,15L,8L,17L,9L,19L,10L,7L,11L,23L,8L,25L,13L,9L,7L,29L,10L,31L,8L,11L,17L,7L,9L,37L,19L,13L,8L,41L,7L,43L,11L,9L,23L,47L,8L,7L,10L,17L,13L,49L,9L,11L,7L,19L,29L,49L,10L,49L,31L,7L,8L,13L,11L,49L,17L,23L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291480Inst : IEnumerable<long>
{
public static readonly long[] Value=A291480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291480.Bytes);
public long this[int i]=>Value[i];

public static A291480Inst Instance=new A291480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291482
{
public static readonly BigInteger[] Value={ 0L,1L,2L,4L,8L,24L,80L,456L,2368L,20352L,139648L,1577984L,13327360L,185992832L,1860708096L,30882985472L,356724338688L,6860887896064L,89815091306496L,1963843714723840L,28724760194564096L,703639672161697792L,11370790299166343168UL,BigInteger.Parse("308435832182144040960"),BigInteger.Parse("5456591088206554333184"),BigInteger.Parse("162354575283061816197120") };
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
public class A291482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291482Inst Instance=new A291482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291483
{
public static readonly BigInteger[] Value={ 0L,1L,2L,2L,0L,4L,40L,-64L,-1344L,3984L,85408L,-356896L,-8462080L,45908160L,1209040768L,-8080805888L,-235449260032L,1871655631104L,59955521585664L,-552758145525248L,-19339870285225984L,202927333558572032L,7707208199780517888L,BigInteger.Parse("-90698934927786770432"),BigInteger.Parse("-3718489569130941169664"),BigInteger.Parse("48507735629457304555520") };
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
public class A291483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291483Inst Instance=new A291483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291484
{
public static readonly BigInteger[] Value={ 0L,1L,2L,5L,12L,49L,190L,1301L,7224L,69441L,495898L,6095429L,53005700L,792143793L,8110146070L,142633278997L,1679413757168L,33964965659649L,451969255722162L,10331348137881349L,153288815339260796L,3907452790559751857L,BigInteger.Parse("63949589015139119598"),BigInteger.Parse("1798373345567005989781"),BigInteger.Parse("32179694275204166066728") };
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
public class A291484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291484Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291484.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291484Inst Instance=new A291484Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291485
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,12L,13L,15L,18L,20L,24L,27L,30L,31L,32L,35L,38L,39L,47L,48L,51L,55L,56L,62L,63L,64L,79L,80L,84L,90L,92L,95L,96L,104L,111L,116L,119L,120L,128L,135L,140L,142L,143L,144L,147L,152L,155L,156L,159L,160L,167L,168L,170L,171L,175L,176L,182L,184L,188L,191L,192L,195L,203L,207L,208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291485Inst : IEnumerable<long>
{
public static readonly long[] Value=A291485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291485.Bytes);
public long this[int i]=>Value[i];

public static A291485Inst Instance=new A291485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291487
{
public static readonly long[] Value={ 1L,1L,0L,4L,12L,75L,300L,1950L,13650L,122850L,1160250L,13340250L,140390250L,1825073250L,25318743450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291487Inst : IEnumerable<long>
{
public static readonly long[] Value=A291487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291487.Bytes);
public long this[int i]=>Value[i];

public static A291487Inst Instance=new A291487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291488
{
public static readonly long[] Value={ 1L,-3L,12L,-58L,318L,-1896L,11966L,-78595L,531486L,-3674324L,25845131L,-184348434L,1330147092L,-9690872427L,71189146313L,-526703176813L,3921274277132L,-29354616797397L,220824254874928L,-1668453804382315L,12655766723174710L,-96340024533522759L,735747052686408916L,-5635489764030599334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291488Inst : IEnumerable<long>
{
public static readonly long[] Value=A291488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291488.Bytes);
public long this[int i]=>Value[i];

public static A291488Inst Instance=new A291488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291489
{
public static readonly long[] Value={ 1L,-2L,3L,2L,-41L,196L,-541L,229L,7235L,-48228L,175956L,-254933L,-1575661L,14909191L,-67194669L,153944915L,292516673L,-4968647665L,27275432639L,-82747735226L,3883854725L,1660136515050L,-11302429310683L,42362000190568L,-53376259124482L,-520085199830413L,4671353423344131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291489Inst : IEnumerable<long>
{
public static readonly long[] Value=A291489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291489.Bytes);
public long this[int i]=>Value[i];

public static A291489Inst Instance=new A291489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291490
{
public static readonly long[] Value={ 15L,14L,15L,12L,15L,14L,15L,8L,9L,10L,11L,12L,13L,14L,15L,8L,15L,9L,15L,10L,15L,11L,15L,8L,15L,13L,9L,12L,15L,10L,15L,8L,11L,14L,15L,9L,15L,14L,13L,8L,15L,14L,15L,11L,9L,14L,15L,8L,15L,10L,15L,12L,15L,9L,11L,8L,15L,14L,15L,10L,15L,14L,9L,8L,13L,11L,15L,12L,15L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291490Inst : IEnumerable<long>
{
public static readonly long[] Value=A291490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291490.Bytes);
public long this[int i]=>Value[i];

public static A291490Inst Instance=new A291490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291491
{
public static readonly long[] Value={ 22L,20L,21L,16L,20L,20L,22L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,22L,8L,20L,13L,9L,14L,22L,10L,22L,8L,11L,17L,20L,9L,22L,19L,13L,8L,22L,14L,22L,11L,9L,20L,22L,8L,22L,10L,17L,13L,22L,9L,11L,8L,19L,20L,22L,10L,22L,20L,9L,8L,13L,11L,22L,16L,21L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291491Inst : IEnumerable<long>
{
public static readonly long[] Value=A291491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291491.Bytes);
public long this[int i]=>Value[i];

public static A291491Inst Instance=new A291491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291492
{
public static readonly long[] Value={ 29L,26L,27L,20L,25L,26L,29L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,9L,14L,29L,10L,29L,8L,11L,17L,25L,9L,29L,19L,13L,8L,29L,14L,29L,11L,9L,23L,29L,8L,29L,10L,17L,13L,29L,9L,11L,8L,19L,26L,29L,10L,29L,26L,9L,8L,13L,11L,29L,17L,23L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291492Inst : IEnumerable<long>
{
public static readonly long[] Value=A291492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291492.Bytes);
public long this[int i]=>Value[i];

public static A291492Inst Instance=new A291492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291493
{
public static readonly long[] Value={ 36L,32L,33L,24L,30L,32L,36L,8L,9L,10L,11L,12L,13L,14L,15L,8L,17L,9L,19L,10L,21L,11L,23L,8L,25L,13L,9L,14L,29L,10L,31L,8L,11L,17L,30L,9L,36L,19L,13L,8L,36L,14L,36L,11L,9L,23L,36L,8L,36L,10L,17L,13L,36L,9L,11L,8L,19L,29L,36L,10L,36L,31L,9L,8L,13L,11L,36L,17L,23L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291493Inst : IEnumerable<long>
{
public static readonly long[] Value=A291493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291493.Bytes);
public long this[int i]=>Value[i];

public static A291493Inst Instance=new A291493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291673
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291673Inst : IEnumerable<long>
{
public static readonly long[] Value=A291673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291673.Bytes);
public long this[int i]=>Value[i];

public static A291673Inst Instance=new A291673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291674
{
public static readonly long[] Value={ 1L,1L,3L,2L,3L,3L,2L,2L,4L,3L,19L,3L,6L,2L,3L,3L,7L,4L,10L,3L,4L,19L,43L,3L,19L,6L,10L,2L,39L,3L,19L,4L,19L,7L,6L,4L,18L,10L,6L,3L,19L,4L,13L,19L,6L,43L,137L,3L,26L,19L,7L,6L,103L,10L,19L,2L,10L,39L,173L,3L,38L,19L,4L,4L,6L,19L,86L,7L,43L,6L,139L,4L,10L,18L,19L,10L,25L,6L,206L,3L,34L,19L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291674Inst : IEnumerable<long>
{
public static readonly long[] Value=A291674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291674.Bytes);
public long this[int i]=>Value[i];

public static A291674Inst Instance=new A291674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291675
{
public static readonly long[] Value={ 4L,14L,40L,96L,222L,488L,1052L,2222L,4640L,9592L,19694L,40208L,81748L,165646L,334776L,675184L,1359486L,2733720L,5491308L,11021230L,22104944L,44310984L,88785550L,177835776L,356099812L,712892558L,1426906312L,2855626752L,5714188830L,11433127112L,22873939004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291675Inst : IEnumerable<long>
{
public static readonly long[] Value=A291675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291675.Bytes);
public long this[int i]=>Value[i];

public static A291675Inst Instance=new A291675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291676
{
public static readonly BigInteger[] Value={ 0L,1L,10L,3527L,123296356L,757031629267449L,BigInteger.Parse("1263498691933197473321646"),BigInteger.Parse("823340843273442113630752833831086703"),BigInteger.Parse("285062591046216676379736060856308430344065653125000") };
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
public class A291676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291676Inst Instance=new A291676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291677
{
public static readonly BigInteger[] Value={ 1L,1L,7L,148L,6171L,425976L,43979902L,6346283560L,1219725741715L,301190499710320L,92921064554444490L,BigInteger.Parse("35025128774218944648"),BigInteger.Parse("15838288022236083603486"),BigInteger.Parse("8462453158197423495502224"),BigInteger.Parse("5274234568391796228927038748"),BigInteger.Parse("3792391176672742840187796835728") };
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
public class A291677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291677Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291677.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291677Inst Instance=new A291677Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291678
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,2L,0L,0L,1L,3L,1L,-1L,0L,1L,4L,3L,-2L,0L,0L,1L,5L,6L,-2L,-2L,1L,0L,1L,6L,10L,0L,-6L,2L,1L,0L,1L,7L,15L,5L,-11L,0L,5L,-1L,0L,1L,8L,21L,14L,-15L,-8L,12L,0L,-2L,0L,1L,9L,28L,28L,-15L,-24L,18L,9L,-8L,0L,0L,1L,10L,36L,48L,-7L,-48L,15L,32L,-15L,-6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291678Inst : IEnumerable<long>
{
public static readonly long[] Value=A291678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291678.Bytes);
public long this[int i]=>Value[i];

public static A291678Inst Instance=new A291678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291679
{
public static readonly long[] Value={ 1L,1L,1L,-2L,-11L,-24L,-8L,141L,573L,1087L,-174L,-8700L,-31328L,-52740L,36387L,534198L,1742445L,2540583L,-3626189L,-33115232L,-97968686L,-118497822L,301668764L,2060526393L,5526622320L,5165256226L,-23033840842L,-127995025736L,-310560935969L,-193716799472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291679Inst : IEnumerable<long>
{
public static readonly long[] Value=A291679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291679.Bytes);
public long this[int i]=>Value[i];

public static A291679Inst Instance=new A291679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291680
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,3L,2L,0L,1L,9L,8L,4L,0L,1L,25L,36L,20L,10L,0L,1L,71L,156L,108L,58L,26L,0L,1L,205L,666L,586L,340L,170L,74L,0L,1L,607L,2860L,3098L,2014L,1078L,528L,218L,0L,1L,1833L,12336L,16230L,11888L,6772L,3550L,1672L,672L,0L,1L,5635L,53518L,85150L,69274L,42366L,23284L,11840L,5454L,2126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291680Inst : IEnumerable<long>
{
public static readonly long[] Value=A291680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291680.Bytes);
public long this[int i]=>Value[i];

public static A291680Inst Instance=new A291680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291683
{
public static readonly long[] Value={ 0L,0L,1L,3L,9L,25L,71L,205L,607L,1833L,5635L,17577L,55515L,177191L,570699L,1852571L,6055079L,19910729L,65823751L,218654099L,729459551L,2443051213L,8210993363L,27685671843L,93625082139L,317470233149L,1079183930827L,3676951654519L,12554734605495L,42952566314235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291683Inst : IEnumerable<long>
{
public static readonly long[] Value=A291683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291683.Bytes);
public long this[int i]=>Value[i];

public static A291683Inst Instance=new A291683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291684
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,2L,2L,0L,1L,5L,5L,5L,0L,1L,9L,12L,14L,16L,0L,1L,17L,36L,36L,47L,52L,0L,1L,31L,81L,98L,117L,166L,189L,0L,1L,57L,174L,327L,327L,425L,627L,683L,0L,1L,101L,413L,788L,988L,1116L,1633L,2400L,2621L,0L,1L,185L,889L,1890L,3392L,3392L,4291L,6471L,9459L,10061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291684Inst : IEnumerable<long>
{
public static readonly long[] Value=A291684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291684.Bytes);
public long this[int i]=>Value[i];

public static A291684Inst Instance=new A291684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291685
{
public static readonly long[] Value={ 1L,1L,2L,5L,16L,52L,189L,683L,2621L,10061L,40031L,159201L,650880L,2657089L,11062682L,46065143L,194595138L,822215099L,3513875245L,15021070567L,64785349064L,279575206629L,1214958544538L,5283266426743L,23106210465665L,101120747493793L,444614706427665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291685Inst : IEnumerable<long>
{
public static readonly long[] Value=A291685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291685.Bytes);
public long this[int i]=>Value[i];

public static A291685Inst Instance=new A291685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291687
{
public static readonly BigInteger[] Value={ 5L,7L,3469L,9949L,65839L,1514209L,5221129L,40883539L,151412629L,44358635479L,16713607661375629L,BigInteger.Parse("36453104912477522894629"),BigInteger.Parse("1027438963906784290227656915629"),BigInteger.Parse("7419136758370889359733910587728129"),BigInteger.Parse("4551830726072842264843919206776501006328129") };
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
public class A291687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291687Inst Instance=new A291687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291688
{
public static readonly BigInteger[] Value={ 1L,1L,5L,36L,327L,3392L,38795L,469662L,5935728L,77416352L,1035050705L,14094000938L,195075365778L,2734475097609L,38747262233793L,554199475506095L,7990492729051526L,115995691148658656L,1694340616136589743L,BigInteger.Parse("24882428969673439384"),BigInteger.Parse("367160435328847044586") };
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
public class A291688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A291688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A291688Inst Instance=new A291688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291689
{
public static readonly long[] Value={ 23L,37L,43L,52L,73L,74L,82L,88L,92L,98L,107L,108L,109L,113L,122L,123L,124L,128L,129L,133L,136L,137L,152L,157L,166L,178L,179L,183L,198L,201L,202L,205L,208L,211L,212L,213L,214L,217L,222L,223L,224L,227L,228L,229L,235L,238L,239L,243L,250L,251L,252L,253L,254L,255L,256L,257L,261L,262L,270L,271L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291689Inst : IEnumerable<long>
{
public static readonly long[] Value=A291689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291689.Bytes);
public long this[int i]=>Value[i];

public static A291689Inst Instance=new A291689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291690
{
public static readonly long[] Value={ 5L,2L,3L,17L,2L,6L,3L,10L,10L,3L,13L,13L,12L,5L,5L,2L,2L,2L,7L,11L,28L,6L,6L,7L,7L,11L,5L,6L,6L,3L,6L,6L,3L,2L,12L,6L,18L,20L,5L,2L,2L,21L,19L,5L,3L,3L,3L,5L,6L,6L,21L,7L,14L,6L,5L,7L,15L,6L,11L,3L,3L,5L,22L,17L,14L,3L,29L,15L,2L,13L,13L,19L,6L,2L,10L,10L,18L,6L,21L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291690Inst : IEnumerable<long>
{
public static readonly long[] Value=A291690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291690.Bytes);
public long this[int i]=>Value[i];

public static A291690Inst Instance=new A291690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A291692
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,8L,8L,0L,0L,0L,0L,0L,0L,28L,28L,0L,0L,0L,0L,0L,0L,56L,56L,0L,27L,27L,0L,0L,0L,70L,70L,0L,216L,216L,0L,0L,0L,56L,56L,0L,756L,756L,0L,0L,0L,28L,28L,0L,1512L,1512L,0L,351L,351L,8L,8L,0L,1890L,1890L,0L,2808L,2808L,65L,65L,0L,1512L,1512L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A291692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A291692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A291692Inst : IEnumerable<long>
{
public static readonly long[] Value=A291692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A291692.Bytes);
public long this[int i]=>Value[i];

public static A291692Inst Instance=new A291692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097193
{
public static readonly BigInteger[] Value={ 1L,12L,204L,3978L,83538L,1837836L,41745132L,970574319L,22970258883L,551286213192L,13381219902024L,327839887599588L,8095123378420596L,201221638263597672L,5030540956589941800L,BigInteger.Parse("126392341534322287725") };
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
public class A097193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097193Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097193.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097193Inst Instance=new A097193Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097194
{
public static readonly BigInteger[] Value={ 1L,25L,649L,17065L,451621L,11998801L,319623445L,8530126057L,227974775239L,6099550226965L,163340461497907L,4377292845062689L,117376545230379631L,3149059523347103293L,BigInteger.Parse("84522568856319875179"),BigInteger.Parse("2269506752111508954553") };
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
public class A097194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097194Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097194.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097194Inst Instance=new A097194Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097195
{
public static readonly long[] Value={ 1L,2L,2L,2L,1L,2L,2L,2L,3L,0L,2L,2L,2L,2L,0L,4L,2L,2L,2L,0L,1L,2L,4L,2L,0L,2L,2L,2L,3L,2L,2L,0L,2L,2L,0L,2L,4L,2L,2L,0L,2L,4L,0L,4L,0L,2L,2L,2L,1L,0L,4L,2L,2L,0L,2L,2L,2L,4L,2L,0L,3L,2L,2L,2L,0L,0L,2L,4L,2L,0L,2L,4L,2L,2L,0L,0L,2L,2L,4L,2L,4L,2L,0L,2L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097195Inst : IEnumerable<long>
{
public static readonly long[] Value=A097195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097195.Bytes);
public long this[int i]=>Value[i];

public static A097195Inst Instance=new A097195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097196
{
public static readonly long[] Value={ 1L,0L,1L,2L,2L,2L,4L,4L,6L,8L,9L,12L,16L,18L,22L,28L,33L,40L,50L,58L,70L,84L,98L,116L,138L,160L,188L,222L,256L,298L,348L,400L,463L,536L,614L,706L,812L,926L,1060L,1212L,1378L,1568L,1785L,2022L,2292L,2598L,2932L,3312L,3740L,4208L,4736L,5328L,5978L,6708L,7522L,8416L,9416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097196Inst : IEnumerable<long>
{
public static readonly long[] Value=A097196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097196.Bytes);
public long this[int i]=>Value[i];

public static A097196Inst Instance=new A097196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097197
{
public static readonly long[] Value={ 1L,1L,2L,4L,6L,9L,14L,20L,29L,42L,58L,80L,110L,148L,198L,264L,347L,454L,592L,764L,982L,1257L,1598L,2024L,2554L,3206L,4010L,5000L,6208L,7684L,9484L,11664L,14306L,17501L,21346L,25972L,31526L,38170L,46112L,55588L,66861L,80258L,96154L,114968L,137212L,163472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097197Inst : IEnumerable<long>
{
public static readonly long[] Value=A097197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097197.Bytes);
public long this[int i]=>Value[i];

public static A097197Inst Instance=new A097197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097198
{
public static readonly long[] Value={ 1L,0L,1L,-2L,2L,-2L,2L,-4L,6L,-6L,7L,-10L,12L,-12L,16L,-22L,25L,-28L,34L,-42L,50L,-56L,64L,-80L,94L,-104L,122L,-146L,168L,-190L,218L,-256L,295L,-330L,378L,-440L,500L,-560L,638L,-734L,830L,-930L,1053L,-1198L,1352L,-1510L,1696L,-1924L,2160L,-2404L,2696L,-3034L,3390L,-3770L,4208L,-4712L,5252L,-5824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097198Inst : IEnumerable<long>
{
public static readonly long[] Value=A097198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097198.Bytes);
public long this[int i]=>Value[i];

public static A097198Inst Instance=new A097198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097199
{
public static readonly BigInteger[] Value={ 32L,145L,1649L,18785L,4208945L,67137425L,17179952705L,274878037265L,70368744457505L,288230376152419025L,4611686018428311425L,BigInteger.Parse("18889465931478582728945"),BigInteger.Parse("4835703278458516701650465") };
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
public class A097199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097199Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097199.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097199Inst Instance=new A097199Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097200
{
public static readonly BigInteger[] Value={ 57L,368L,6250L,94932L,48989176L,1221074418L,762940872982L,19073488804224L,11920928961514468L,BigInteger.Parse("186264514923116214274"),BigInteger.Parse("4656612873077421207276"),BigInteger.Parse("72759576141834259102547082"),BigInteger.Parse("45474735088646411895867809326") };
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
public class A097200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097200Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097200.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097200Inst Instance=new A097200Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097201
{
public static readonly BigInteger[] Value={ 0L,-17L,399L,13983L,4179663L,67080303L,17179785663L,274877776623L,70368743897823L,288230376151004463L,4611686018426464383L,BigInteger.Parse("18889465931478578980623"),BigInteger.Parse("4835703278458516695998943") };
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
public class A097201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097201Inst Instance=new A097201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097202
{
public static readonly BigInteger[] Value={ -7L,-118L,0L,61318L,48667074L,1220331832L,762938033268L,19073483852026L,11920928948641782L,BigInteger.Parse("186264514923075191976"),BigInteger.Parse("4656612873077363948974"),BigInteger.Parse("72759576141834258963859168"),BigInteger.Parse("45474735088646411895636096924") };
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
public class A097202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097202Inst Instance=new A097202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097203
{
public static readonly long[] Value={ 0L,0L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,2L,0L,1L,2L,0L,1L,2L,1L,1L,2L,1L,2L,0L,0L,3L,2L,1L,2L,1L,2L,0L,2L,2L,1L,3L,1L,2L,3L,0L,2L,4L,1L,2L,2L,1L,3L,0L,1L,3L,3L,2L,2L,4L,2L,0L,3L,2L,3L,3L,2L,3L,3L,0L,2L,5L,2L,3L,3L,2L,4L,0L,1L,5L,4L,2L,4L,2L,3L,0L,4L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097203Inst : IEnumerable<long>
{
public static readonly long[] Value=A097203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097203.Bytes);
public long this[int i]=>Value[i];

public static A097203Inst Instance=new A097203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097204
{
public static readonly BigInteger[] Value={ 0L,0L,1L,8L,49L,294L,1893L,13572L,109345L,985898L,9863077L,108503064L,1302057249L,16926789294L,236975148421L,3554627439308L,56874039487681L,966858672273618L,17403456103022277L,330665665961879712L,6613313319247031425L,BigInteger.Parse("138879579704207582870") };
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
public class A097204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097204Inst Instance=new A097204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097205
{
public static readonly BigInteger[] Value={ 72L,729L,30375L,750141L,235782657L,3502727631L,634465620819L,7971951402153L,1145440056788109L,1673826273552131487L,18401108148695065077UL,BigInteger.Parse("22808230685096689428039"),BigInteger.Parse("2513755383310987769681163"),BigInteger.Parse("26098726706637459430889889"),BigInteger.Parse("2760530473190044863847909701") };
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
public class A097205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097205Inst Instance=new A097205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097206
{
public static readonly BigInteger[] Value={ 800L,30375L,9765625L,1313046875L,7863818359375L,453238525390625L,1083264923095703125L,BigInteger.Parse("47227840423583984375"),BigInteger.Parse("76727187633514404296875"),BigInteger.Parse("3820499219000339508056640625"),BigInteger.Parse("133314873091876506805419921875") };
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
public class A097206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097206Inst Instance=new A097206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097207
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,5L,1L,5L,9L,7L,1L,6L,14L,16L,9L,1L,7L,20L,30L,25L,11L,1L,8L,27L,50L,55L,36L,13L,1L,9L,35L,77L,105L,91L,49L,15L,1L,10L,44L,112L,182L,196L,140L,64L,17L,1L,11L,54L,156L,294L,378L,336L,204L,81L,19L,1L,12L,65L,210L,450L,672L,714L,540L,285L,100L,21L,1L,13L,77L,275L,660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097207Inst : IEnumerable<long>
{
public static readonly long[] Value=A097207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097207.Bytes);
public long this[int i]=>Value[i];

public static A097207Inst Instance=new A097207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097208
{
public static readonly long[] Value={ 40L,24L,19L,17L,16L,10L,23L,21L,92L,313L,155L,551L,2575L,757L,13537L,5525L,35133L,33953L,332975L,355573L,3157535L,1571573L,2732737L,3775555L,5737571L,37332775L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097208Inst : IEnumerable<long>
{
public static readonly long[] Value=A097208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097208.Bytes);
public long this[int i]=>Value[i];

public static A097208Inst Instance=new A097208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097209
{
public static readonly BigInteger[] Value={ 9091L,909091L,909090909090909091L,BigInteger.Parse("909090909090909090909090909091"),BigInteger.Parse("9090909090909090909090909090909090909090909090909091"),BigInteger.Parse("909090909090909090909090909090909090909090909090909090909090909091") };
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
public class A097209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097209Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097209.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097209Inst Instance=new A097209Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097210
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,16L,32L,44L,64L,128L,184L,218L,256L,400L,512L,752L,1024L,2048L,3040L,3392L,3748L,4096L,8192L,12224L,16384L,27904L,32768L,49024L,57856L,61064L,64594L,65536L,131072L,196352L,226304L,253808L,262144L,524288L,785920L,954368L,981520L,1048576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097210Inst : IEnumerable<long>
{
public static readonly long[] Value=A097210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097210.Bytes);
public long this[int i]=>Value[i];

public static A097210Inst Instance=new A097210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097211
{
public static readonly long[] Value={ 1L,2L,4L,10L,8L,44L,16L,184L,218L,32L,400L,752L,3748L,64L,3392L,3040L,61064L,128L,27904L,253808L,12224L,64594L,57856L,981520L,256L,226304L,16450240L,49024L,16700300L,954368L,15722528L,512L,1822720L,1055953664L,196352L,4278006328L,15499264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097211Inst : IEnumerable<long>
{
public static readonly long[] Value=A097211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097211.Bytes);
public long this[int i]=>Value[i];

public static A097211Inst Instance=new A097211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097212
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,30L,36L,48L,60L,120L,180L,240L,360L,420L,720L,840L,1260L,1680L,2520L,4620L,5040L,7560L,9240L,10080L,12600L,13860L,15120L,18480L,20160L,25200L,27720L,45360L,50400L,55440L,83160L,110880L,138600L,166320L,221760L,277200L,332640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097212Inst : IEnumerable<long>
{
public static readonly long[] Value=A097212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097212.Bytes);
public long this[int i]=>Value[i];

public static A097212Inst Instance=new A097212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097213
{
public static readonly long[] Value={ 30L,420L,4620L,9240L,12600L,13860L,18480L,138600L,360360L,1801800L,5405400L,6126120L,12252240L,18378360L,24504480L,30630600L,49008960L,91891800L,232792560L,349188840L,465585120L,931170240L,1163962800L,1745944200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097213Inst : IEnumerable<long>
{
public static readonly long[] Value=A097213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097213.Bytes);
public long this[int i]=>Value[i];

public static A097213Inst Instance=new A097213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097214
{
public static readonly long[] Value={ 1L,2L,4L,8L,10L,16L,32L,44L,64L,128L,184L,256L,512L,752L,1024L,2048L,4096L,8192L,12224L,16384L,32768L,49024L,61064L,65536L,131072L,262124L,524288L,981520L,1048576L,2097152L,4194304L,8388608L,12580864L,16777216L,33554432L,67108864L,134217728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097214Inst : IEnumerable<long>
{
public static readonly long[] Value=A097214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097214.Bytes);
public long this[int i]=>Value[i];

public static A097214Inst Instance=new A097214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097215
{
public static readonly BigInteger[] Value={ 10L,44L,184L,752L,12224L,49024L,61064L,981520L,12580864L,206158168064L,16492668126208L,1080863908958322688L,18374686467592175488UL,BigInteger.Parse("885443715520878608384"),BigInteger.Parse("4703919738602662723328") };
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
public class A097215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097215Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097215.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097215Inst Instance=new A097215Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097216
{
public static readonly long[] Value={ 6L,12L,18L,20L,24L,28L,30L,36L,40L,42L,48L,54L,56L,60L,66L,70L,72L,78L,80L,84L,88L,90L,96L,100L,102L,104L,105L,108L,110L,112L,114L,120L,126L,130L,132L,135L,136L,138L,140L,144L,150L,152L,154L,156L,160L,162L,165L,168L,170L,174L,176L,180L,182L,186L,190L,192L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097216Inst : IEnumerable<long>
{
public static readonly long[] Value=A097216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097216.Bytes);
public long this[int i]=>Value[i];

public static A097216Inst Instance=new A097216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097217
{
public static readonly long[] Value={ 105L,135L,165L,195L,225L,315L,405L,495L,525L,567L,585L,675L,693L,765L,819L,825L,855L,945L,975L,1035L,1071L,1125L,1155L,1197L,1215L,1275L,1287L,1305L,1323L,1365L,1395L,1425L,1449L,1485L,1575L,1665L,1683L,1701L,1725L,1755L,1785L,1827L,1845L,1881L,1925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097217Inst : IEnumerable<long>
{
public static readonly long[] Value=A097217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097217.Bytes);
public long this[int i]=>Value[i];

public static A097217Inst Instance=new A097217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097218
{
public static readonly long[] Value={ 3L,5L,7L,9L,11L,13L,14L,15L,17L,19L,21L,22L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,38L,39L,41L,43L,45L,46L,47L,49L,50L,51L,52L,53L,55L,57L,58L,59L,61L,62L,63L,65L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,81L,82L,83L,85L,86L,87L,89L,91L,92L,93L,94L,95L,97L,98L,99L,101L,103L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097218Inst : IEnumerable<long>
{
public static readonly long[] Value=A097218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097218.Bytes);
public long this[int i]=>Value[i];

public static A097218Inst Instance=new A097218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097219
{
public static readonly long[] Value={ 15625L,31250L,46875L,62500L,93750L,109375L,125000L,140625L,171875L,187500L,218750L,250000L,281250L,296875L,328125L,343750L,359375L,375000L,421875L,437500L,484375L,500000L,515625L,562500L,593750L,656250L,671875L,687500L,718750L,734375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097219Inst : IEnumerable<long>
{
public static readonly long[] Value=A097219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097219.Bytes);
public long this[int i]=>Value[i];

public static A097219Inst Instance=new A097219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097220
{
public static readonly long[] Value={ 16L,17L,63L,73L,364L,437L,545L,573L,963L,6475L,23797L,67458L,2475989L,2475998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097220Inst : IEnumerable<long>
{
public static readonly long[] Value=A097220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097220.Bytes);
public long this[int i]=>Value[i];

public static A097220Inst Instance=new A097220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097221
{
public static readonly long[] Value={ 16L,17L,63L,73L,132L,224L,322L,342L,352L,362L,364L,437L,545L,573L,619L,963L,1017L,1117L,1196L,1516L,2163L,2215L,2335L,2435L,2537L,3277L,3514L,3714L,4072L,4513L,4626L,5137L,6475L,8443L,11373L,11593L,11926L,12012L,12026L,12034L,12121L,12126L,12134L,12555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097221Inst : IEnumerable<long>
{
public static readonly long[] Value=A097221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097221.Bytes);
public long this[int i]=>Value[i];

public static A097221Inst Instance=new A097221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097222
{
public static readonly long[] Value={ 15L,27L,39L,130L,131L,252L,370L,489L,1195L,2345L,3484L,4619L,5752L,6879L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097222Inst : IEnumerable<long>
{
public static readonly long[] Value=A097222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097222.Bytes);
public long this[int i]=>Value[i];

public static A097222Inst Instance=new A097222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097223
{
public static readonly long[] Value={ 17L,73L,2475989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097223Inst : IEnumerable<long>
{
public static readonly long[] Value=A097223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097223.Bytes);
public long this[int i]=>Value[i];

public static A097223Inst Instance=new A097223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097224
{
public static readonly long[] Value={ 2L,3L,3L,3L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,7L,7L,19L,19L,23L,31L,31L,47L,73L,103L,139L,173L,173L,173L,211L,233L,293L,313L,331L,359L,383L,389L,389L,523L,601L,727L,751L,829L,929L,997L,1039L,1093L,1163L,1321L,1427L,1583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097224Inst : IEnumerable<long>
{
public static readonly long[] Value=A097224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097224.Bytes);
public long this[int i]=>Value[i];

public static A097224Inst Instance=new A097224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097225
{
public static readonly long[] Value={ 1625L,2125L,3250L,3625L,4250L,4625L,4875L,5125L,6375L,6500L,6625L,7250L,7625L,8500L,9125L,9250L,9750L,10250L,10875L,10985L,11125L,11375L,12125L,12625L,12750L,13000L,13250L,13625L,13875L,14125L,14500L,14625L,14875L,15250L,15375L,17000L,17125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097225Inst : IEnumerable<long>
{
public static readonly long[] Value=A097225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097225.Bytes);
public long this[int i]=>Value[i];

public static A097225Inst Instance=new A097225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097226
{
public static readonly long[] Value={ 4225L,7225L,8450L,12675L,14450L,16900L,21025L,21675L,25350L,28900L,29575L,33800L,34225L,38025L,42025L,42050L,43350L,46475L,48841L,50575L,50700L,57800L,59150L,63075L,65025L,67600L,68450L,70225L,76050L,79475L,80275L,84050L,84100L,86700L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097226Inst : IEnumerable<long>
{
public static readonly long[] Value=A097226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097226.Bytes);
public long this[int i]=>Value[i];

public static A097226Inst Instance=new A097226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097227
{
public static readonly long[] Value={ 14L,154L,1196L,279174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097227Inst : IEnumerable<long>
{
public static readonly long[] Value=A097227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097227.Bytes);
public long this[int i]=>Value[i];

public static A097227Inst Instance=new A097227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097228
{
public static readonly long[] Value={ 27L,38L,127L,138L,289L,298L,1127L,1138L,1289L,1298L,11127L,11138L,11289L,11298L,111127L,111138L,111289L,111298L,1111127L,1111138L,1111289L,1111298L,11111127L,11111138L,11111289L,11111298L,111111127L,111111138L,111111289L,111111298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097228Inst : IEnumerable<long>
{
public static readonly long[] Value=A097228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097228.Bytes);
public long this[int i]=>Value[i];

public static A097228Inst Instance=new A097228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097229
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,7L,1L,1L,15L,5L,1L,31L,18L,1L,1L,63L,56L,7L,1L,127L,160L,34L,1L,1L,255L,432L,138L,9L,1L,511L,1120L,500L,55L,1L,1L,1023L,2816L,1672L,275L,11L,1L,2047L,6912L,5264L,1205L,81L,1L,1L,4095L,16640L,15808L,4797L,481L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097229Inst : IEnumerable<long>
{
public static readonly long[] Value=A097229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097229.Bytes);
public long this[int i]=>Value[i];

public static A097229Inst Instance=new A097229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097230
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,2L,1L,1L,0L,3L,2L,1L,1L,0L,4L,3L,3L,1L,1L,0L,5L,4L,6L,4L,1L,1L,0L,6L,5L,10L,9L,5L,1L,1L,0L,7L,6L,15L,16L,13L,6L,1L,1L,0L,8L,7L,21L,25L,26L,18L,7L,1L,1L,0L,9L,8L,28L,36L,45L,40L,24L,8L,1L,1L,0L,10L,9L,36L,49L,71L,75L,59L,31L,9L,1L,1L,0L,11L,10L,45L,64L,105L,126L,120L,84L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097230Inst : IEnumerable<long>
{
public static readonly long[] Value=A097230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097230.Bytes);
public long this[int i]=>Value[i];

public static A097230Inst Instance=new A097230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097231
{
public static readonly long[] Value={ 0L,116L,545L,456L,352L,276L,265L,190L,0L,86L,96L,117L,70L,139L,68L,10L,48L,78L,40L,196L,15L,4L,0L,21L,7L,34L,20L,3L,21L,4L,9L,97L,55L,3L,26L,4L,0L,3L,28L,81L,85L,0L,19L,7L,3L,2L,0L,0L,0L,0L,0L,0L,3L,0L,23L,20L,2L,4L,5L,4L,0L,2L,7L,0L,11L,4L,0L,19L,0L,10L,0L,0L,0L,4L,9L,2L,7L,10L,11L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097231Inst : IEnumerable<long>
{
public static readonly long[] Value=A097231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097231.Bytes);
public long this[int i]=>Value[i];

public static A097231Inst Instance=new A097231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097232
{
public static readonly long[] Value={ 2L,23L,83L,157L,181L,211L,223L,227L,229L,233L,239L,251L,283L,311L,331L,347L,353L,359L,367L,421L,431L,433L,439L,443L,461L,463L,467L,503L,521L,541L,547L,557L,577L,587L,593L,599L,601L,619L,631L,641L,647L,677L,683L,691L,701L,709L,719L,727L,733L,797L,809L,811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097232Inst : IEnumerable<long>
{
public static readonly long[] Value=A097232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097232.Bytes);
public long this[int i]=>Value[i];

public static A097232Inst Instance=new A097232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097233
{
public static readonly long[] Value={ 419L,617L,827L,1097L,1187L,1229L,1487L,1531L,1609L,1669L,1811L,2143L,2243L,2251L,2311L,2539L,2677L,2693L,2707L,2713L,2819L,2953L,3203L,3221L,3539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097233Inst : IEnumerable<long>
{
public static readonly long[] Value=A097233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097233.Bytes);
public long this[int i]=>Value[i];

public static A097233Inst Instance=new A097233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097234
{
public static readonly BigInteger[] Value={ -1L,2L,13L,19L,29L,13L,254983L,2593L,137561L,65082637L,7254146201L,390121079L,1870450393439L,109336409527L,10204882558837L,163634261622076159L,BigInteger.Parse("75160931938786203761"),31012919260504739L,BigInteger.Parse("1378721049267804056272181") };
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
public class A097234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097234Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097234.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097234Inst Instance=new A097234Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097235
{
public static readonly BigInteger[] Value={ 1L,3L,90L,945L,12600L,53460L,10216206000L,1021620600L,534386160000L,2494674910728000L,2744142401800800000L,1456506351725040000L,BigInteger.Parse("68921880563628892800000"),BigInteger.Parse("39762623402093592000000") };
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
public class A097235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097235Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097235.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097235Inst Instance=new A097235Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097236
{
public static readonly BigInteger[] Value={ 0L,1L,1L,10L,31L,271L,1534L,14393L,117653L,1253524L,13140557L,160679069L,2026451948L,28278471729L,413532314433L,6516434058758L,107958571213579L,1899723866781859L,35092386753388698L,682552407940860353L,13893916425860413469UL,BigInteger.Parse("296049402365644855888") };
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
public class A097236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097236Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097236.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097236Inst Instance=new A097236Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097237
{
public static readonly BigInteger[] Value={ 0L,2L,12L,86L,780L,8462L,106092L,1507046L,23905740L,418581662L,8014481772L,166501716086L,3728936827980L,89530481995502L,2293539506425452L,62429371709206406L,1799021068567370700L,BigInteger.Parse("54707449240102350782"),BigInteger.Parse("1750530594833378049132"),BigInteger.Parse("58787407236482804618006") };
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
public class A097237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097237Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A097237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097237.Bytes);
public BigInteger this[int i]=>Value[i];

public static A097237Inst Instance=new A097237Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097238
{
public static readonly long[] Value={ 40625L,53125L,81250L,90625L,106250L,115625L,121875L,128125L,159375L,162500L,165625L,181250L,190625L,212500L,228125L,231250L,243750L,256250L,271875L,278125L,284375L,303125L,315625L,318750L,325000L,331250L,340625L,346875L,353125L,362500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097238Inst : IEnumerable<long>
{
public static readonly long[] Value=A097238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097238.Bytes);
public long this[int i]=>Value[i];

public static A097238Inst Instance=new A097238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097239
{
public static readonly long[] Value={ 21125L,36125L,42250L,54925L,63375L,72250L,84500L,105125L,108375L,109850L,122825L,126750L,144500L,147875L,164775L,169000L,171125L,190125L,210125L,210250L,216750L,219700L,232375L,245650L,252875L,253500L,289000L,295750L,315375L,325125L,329550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097239Inst : IEnumerable<long>
{
public static readonly long[] Value=A097239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097239.Bytes);
public long this[int i]=>Value[i];

public static A097239Inst Instance=new A097239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A097240
{
public static readonly long[] Value={ 7L,19L,41L,79L,131L,193L,269L,355L,491L,629L,779L,973L,1133L,1303L,1547L,1845L,2099L,2365L,2689L,2951L,3265L,3643L,4039L,4553L,5047L,5405L,5773L,6155L,6547L,7313L,8125L,8707L,9245L,9931L,10649L,11239L,11997L,12703L,13427L,14253L,14939L,15805L,16703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A097240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A097240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A097240Inst : IEnumerable<long>
{
public static readonly long[] Value=A097240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A097240.Bytes);
public long this[int i]=>Value[i];

public static A097240Inst Instance=new A097240Inst();

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