using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A226557
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,4L,2L,4L,2L,2L,0L,2L,4L,12L,12L,4L,6L,4L,8L,2L,6L,6L,4L,2L,0L,0L,6L,2L,4L,2L,8L,0L,2L,4L,2L,4L,8L,10L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226557Inst : IEnumerable<long>
{
public static readonly long[] Value=A226557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226557.Bytes);
public long this[int i]=>Value[i];

public static A226557Inst Instance=new A226557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226558
{
public static readonly long[] Value={ 64L,1984L,23232L,153824L,724352L,2661504L,8208640L,22114304L,53570368L,119129856L,246971072L,482429024L,896290944L,1594476160L,2732250688L,4529267712L,7292346816L,11438236320L,17528382400L,26300206624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226558Inst : IEnumerable<long>
{
public static readonly long[] Value=A226558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226558.Bytes);
public long this[int i]=>Value[i];

public static A226558Inst Instance=new A226558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226559
{
public static readonly long[] Value={ 1L,-1L,-1L,2L,1L,-2L,-2L,2L,4L,-4L,-5L,6L,6L,-7L,-9L,10L,13L,-15L,-17L,20L,21L,-25L,-28L,32L,39L,-43L,-49L,56L,60L,-69L,-78L,86L,101L,-112L,-125L,142L,153L,-172L,-192L,212L,241L,-266L,-295L,328L,357L,-397L,-438L,482L,540L,-592L,-652L,720L,781L,-862L,-946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226559Inst : IEnumerable<long>
{
public static readonly long[] Value=A226559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226559.Bytes);
public long this[int i]=>Value[i];

public static A226559Inst Instance=new A226559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226560
{
public static readonly BigInteger[] Value={ 1L,1L,3L,21L,155L,2691L,18924L,732230L,9223166L,269544904L,4308339664L,264486350330L,3252603264996L,283488024709418L,5058264756924275L,239269507574263597L,9478611818612363119UL,BigInteger.Parse("788664781674375008343"),BigInteger.Parse("13928483471031628860556"),BigInteger.Parse("1889997256419148641470346") };
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
public class A226560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226560Inst Instance=new A226560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226561
{
public static readonly BigInteger[] Value={ 1L,5L,55L,529L,12501L,94835L,4941259L,67240193L,2324562301L,40039063525L,2853116706111L,35668789979107L,3634501279107037L,66676110291801575L,3503151245145885315L,BigInteger.Parse("147575078498173255681"),BigInteger.Parse("13235844190181388226833"),BigInteger.Parse("236079349222711695887225"),BigInteger.Parse("35611553801885644604231623") };
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
public class A226561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226561Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226561.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226561Inst Instance=new A226561Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226562
{
public static readonly long[] Value={ 2210L,3770L,5330L,6290L,12818L,16490L,18122L,19370L,24050L,24650L,26690L,32810L,33410L,34970L,36530L,39650L,39770L,44642L,45050L,45890L,49010L,50690L,51578L,57770L,59450L,61610L,63050L,66170L,67490L,72410L,73610L,74210L,80330L,85202L,86210L,86330L,88010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226562Inst : IEnumerable<long>
{
public static readonly long[] Value=A226562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226562.Bytes);
public long this[int i]=>Value[i];

public static A226562Inst Instance=new A226562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226563
{
public static readonly long[] Value={ 1L,2L,10L,185L,370L,3145L,6290L,40885L,53465L,63750L,81770L,106930L,241400L,348750L,427720L,828750L,866200L,1207000L,1306875L,1635449L,2613750L,3138200L,3270898L,7149375L,8054345L,8177245L,14298750L,14725400L,15691000L,16108690L,16354490L,16989375L,30368120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226563Inst : IEnumerable<long>
{
public static readonly long[] Value=A226563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226563.Bytes);
public long this[int i]=>Value[i];

public static A226563Inst Instance=new A226563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226564
{
public static readonly long[] Value={ 1L,205L,3895L,8525L,17050L,71951L,74005L,148010L,359755L,451825L,903650L,1628110L,1632005L,1798775L,2346674L,3597550L,4218285L,8436570L,8993875L,14749955L,17987750L,50471410L,59071771L,92802270L,95335075L,190670150L,280249145L,295358855L,451356495L,481068170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226564Inst : IEnumerable<long>
{
public static readonly long[] Value=A226564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226564.Bytes);
public long this[int i]=>Value[i];

public static A226564Inst Instance=new A226564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226565
{
public static readonly long[] Value={ 1L,2L,14L,32L,39L,42L,78L,96L,105L,117L,126L,133L,189L,195L,210L,224L,234L,266L,288L,378L,390L,399L,465L,480L,546L,585L,672L,793L,798L,930L,975L,1170L,1197L,1248L,1365L,1470L,1586L,1638L,1862L,1950L,1995L,2016L,2379L,2394L,2646L,2730L,3255L,3360L,3393L,3591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226565Inst : IEnumerable<long>
{
public static readonly long[] Value=A226565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226565.Bytes);
public long this[int i]=>Value[i];

public static A226565Inst Instance=new A226565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226566
{
public static readonly long[] Value={ 1L,201L,981L,1962L,3663L,7326L,10791L,12753L,15879L,21582L,25506L,30411L,56898L,60822L,135749L,140283L,172161L,212454L,266727L,280566L,334521L,344322L,360027L,395343L,399267L,407247L,507177L,625878L,669042L,720054L,739674L,790686L,798534L,881919L,1014354L,1221741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226566Inst : IEnumerable<long>
{
public static readonly long[] Value=A226566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226566.Bytes);
public long this[int i]=>Value[i];

public static A226566Inst Instance=new A226566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226567
{
public static readonly long[] Value={ 7L,10L,13L,16L,17L,19L,22L,25L,27L,28L,31L,32L,34L,37L,38L,42L,43L,45L,46L,47L,49L,52L,55L,57L,58L,59L,61L,62L,64L,66L,67L,70L,71L,72L,73L,76L,77L,79L,80L,82L,85L,87L,88L,91L,92L,93L,94L,97L,100L,101L,102L,103L,104L,106L,107L,108L,109L,110L,115L,117L,118L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226567Inst : IEnumerable<long>
{
public static readonly long[] Value=A226567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226567.Bytes);
public long this[int i]=>Value[i];

public static A226567Inst Instance=new A226567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226568
{
public static readonly long[] Value={ 3L,0L,3L,6L,5L,9L,1L,2L,7L,0L,2L,9L,9L,6L,6L,0L,5L,1L,2L,4L,5L,0L,1L,8L,9L,5L,1L,2L,1L,3L,2L,2L,2L,6L,5L,9L,9L,9L,1L,1L,9L,9L,6L,1L,8L,7L,6L,1L,1L,7L,2L,7L,0L,9L,6L,4L,4L,1L,7L,0L,3L,3L,4L,5L,6L,0L,6L,6L,1L,7L,6L,6L,6L,2L,0L,1L,3L,7L,7L,8L,4L,7L,8L,2L,3L,6L,6L,2L,0L,6L,2L,9L,3L,4L,8L,1L,6L,5L,4L,1L,8L,2L,0L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226568Inst : IEnumerable<long>
{
public static readonly long[] Value=A226568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226568.Bytes);
public long this[int i]=>Value[i];

public static A226568Inst Instance=new A226568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226569
{
public static readonly long[] Value={ 1L,2L,6L,4L,15L,3L,35L,8L,36L,30L,77L,24L,143L,70L,10L,16L,221L,72L,323L,60L,210L,154L,437L,12L,225L,286L,216L,140L,667L,5L,899L,32L,462L,442L,21L,9L,1147L,646L,858L,120L,1517L,105L,1763L,308L,540L,874L,2021L,96L,1225L,450L,1326L,572L,2491L,108L,1155L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226569Inst : IEnumerable<long>
{
public static readonly long[] Value=A226569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226569.Bytes);
public long this[int i]=>Value[i];

public static A226569Inst Instance=new A226569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226570
{
public static readonly long[] Value={ 0L,0L,2L,0L,2L,2L,4L,0L,8L,2L,10L,8L,8L,4L,2L,8L,11L,8L,7L,12L,11L,10L,19L,8L,12L,8L,8L,4L,15L,2L,0L,24L,32L,28L,32L,8L,3L,26L,8L,32L,2L,32L,14L,32L,17L,42L,16L,8L,46L,12L,11L,8L,11L,8L,32L,32L,26L,44L,26L,32L,20L,0L,53L,24L,47L,32L,63L,28L,65L,32L,66L,8L,53L,40L,62L,64L,32L,8L,18L,72L,62L,2L,25L,32L,62L,14L,44L,32L,74L,62L,60L,88L,62L,16L,7L,56L,78L,46L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226570Inst : IEnumerable<long>
{
public static readonly long[] Value=A226570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226570.Bytes);
public long this[int i]=>Value[i];

public static A226570Inst Instance=new A226570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226571
{
public static readonly long[] Value={ 1L,5L,5L,7L,1L,4L,5L,5L,9L,8L,9L,9L,7L,6L,1L,1L,4L,1L,6L,8L,5L,8L,6L,7L,2L,0L,0L,0L,0L,0L,0L,6L,6L,3L,1L,8L,0L,2L,8L,3L,7L,3L,7L,8L,7L,0L,6L,2L,6L,5L,2L,0L,3L,1L,5L,2L,8L,2L,2L,6L,6L,9L,2L,3L,0L,1L,7L,9L,8L,4L,0L,0L,7L,8L,5L,7L,9L,9L,5L,9L,2L,1L,5L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226571Inst : IEnumerable<long>
{
public static readonly long[] Value=A226571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226571.Bytes);
public long this[int i]=>Value[i];

public static A226571Inst Instance=new A226571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226572
{
public static readonly long[] Value={ 3L,1L,4L,6L,1L,9L,3L,2L,2L,0L,6L,2L,0L,5L,8L,2L,5L,8L,5L,2L,3L,7L,0L,6L,1L,0L,2L,8L,5L,2L,1L,3L,6L,8L,2L,5L,2L,8L,8L,8L,6L,6L,2L,0L,4L,6L,1L,8L,2L,4L,8L,8L,4L,2L,6L,0L,3L,4L,6L,1L,9L,2L,9L,1L,2L,8L,6L,7L,7L,5L,1L,6L,3L,9L,8L,7L,5L,4L,8L,8L,7L,0L,7L,7L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226572Inst : IEnumerable<long>
{
public static readonly long[] Value=A226572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226572.Bytes);
public long this[int i]=>Value[i];

public static A226572Inst Instance=new A226572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226573
{
public static readonly long[] Value={ 2L,0L,1L,6L,7L,7L,9L,7L,6L,4L,8L,9L,2L,2L,0L,0L,6L,2L,4L,2L,7L,7L,7L,9L,0L,5L,5L,4L,1L,9L,4L,0L,1L,1L,7L,3L,3L,7L,7L,2L,6L,1L,7L,8L,3L,6L,7L,6L,3L,7L,0L,6L,4L,0L,2L,4L,4L,1L,0L,3L,3L,0L,7L,2L,1L,4L,2L,7L,5L,0L,5L,7L,4L,4L,9L,0L,9L,8L,9L,9L,9L,9L,1L,5L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226573Inst : IEnumerable<long>
{
public static readonly long[] Value=A226573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226573.Bytes);
public long this[int i]=>Value[i];

public static A226573Inst Instance=new A226573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226574
{
public static readonly long[] Value={ 4L,1L,3L,8L,6L,5L,1L,9L,4L,6L,4L,7L,9L,1L,2L,8L,6L,9L,3L,8L,1L,8L,7L,0L,8L,7L,5L,5L,2L,5L,2L,4L,3L,5L,4L,7L,8L,3L,4L,3L,6L,7L,4L,4L,3L,0L,4L,6L,4L,8L,5L,4L,8L,1L,1L,2L,9L,4L,4L,3L,1L,6L,3L,9L,3L,5L,4L,0L,5L,1L,8L,4L,4L,3L,6L,7L,5L,5L,3L,9L,3L,0L,4L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226574Inst : IEnumerable<long>
{
public static readonly long[] Value=A226574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226574.Bytes);
public long this[int i]=>Value[i];

public static A226574Inst Instance=new A226574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226575
{
public static readonly long[] Value={ 4L,24L,48L,72L,160L,168L,180L,300L,448L,504L,520L,768L,784L,900L,1080L,1152L,1176L,1320L,1584L,1620L,1920L,2200L,2232L,2268L,2548L,2904L,3108L,3744L,3784L,3808L,3840L,4416L,4680L,4732L,5508L,5880L,5880L,5928L,6624L,6720L,6732L,7600L,8568L,8760L,9280L,9900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226575Inst : IEnumerable<long>
{
public static readonly long[] Value=A226575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226575.Bytes);
public long this[int i]=>Value[i];

public static A226575Inst Instance=new A226575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226576
{
public static readonly long[] Value={ 0L,3L,3L,1L,4L,4L,2L,5L,5L,3L,6L,6L,4L,7L,7L,5L,8L,8L,6L,9L,9L,7L,10L,10L,8L,11L,11L,9L,12L,12L,10L,13L,13L,11L,14L,14L,12L,15L,15L,13L,16L,16L,14L,17L,17L,15L,18L,18L,16L,19L,19L,17L,20L,20L,18L,21L,21L,19L,22L,22L,20L,23L,23L,21L,24L,24L,22L,25L,25L,23L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226576Inst : IEnumerable<long>
{
public static readonly long[] Value=A226576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226576.Bytes);
public long this[int i]=>Value[i];

public static A226576Inst Instance=new A226576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226577
{
public static readonly long[] Value={ 0L,4L,2L,4L,1L,5L,3L,5L,2L,6L,4L,6L,3L,7L,5L,7L,4L,8L,6L,8L,5L,9L,7L,9L,6L,10L,8L,10L,7L,11L,9L,11L,8L,12L,10L,12L,9L,13L,11L,13L,10L,14L,12L,14L,11L,15L,13L,15L,12L,16L,14L,16L,13L,17L,15L,17L,14L,18L,16L,18L,15L,19L,17L,19L,16L,20L,18L,20L,17L,21L,19L,21L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226577Inst : IEnumerable<long>
{
public static readonly long[] Value=A226577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226577.Bytes);
public long this[int i]=>Value[i];

public static A226577Inst Instance=new A226577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226578
{
public static readonly long[] Value={ 0L,5L,4L,4L,5L,1L,5L,5L,5L,6L,2L,6L,6L,6L,7L,3L,7L,7L,7L,8L,4L,8L,8L,8L,9L,5L,9L,9L,9L,10L,6L,10L,10L,10L,11L,7L,11L,11L,11L,12L,8L,12L,12L,12L,13L,9L,13L,13L,13L,14L,10L,14L,14L,14L,15L,11L,15L,15L,15L,16L,12L,16L,16L,16L,17L,13L,17L,17L,17L,18L,14L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226578Inst : IEnumerable<long>
{
public static readonly long[] Value=A226578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226578.Bytes);
public long this[int i]=>Value[i];

public static A226578Inst Instance=new A226578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226579
{
public static readonly long[] Value={ 0L,6L,3L,2L,3L,5L,1L,5L,4L,3L,4L,6L,2L,6L,5L,4L,5L,7L,3L,7L,6L,5L,6L,8L,4L,8L,7L,6L,7L,9L,5L,9L,8L,7L,8L,10L,6L,10L,9L,8L,9L,11L,7L,11L,10L,9L,10L,12L,8L,12L,11L,10L,11L,13L,9L,13L,12L,11L,12L,14L,10L,14L,13L,12L,13L,15L,11L,15L,14L,13L,14L,16L,12L,16L,15L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226579Inst : IEnumerable<long>
{
public static readonly long[] Value=A226579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226579.Bytes);
public long this[int i]=>Value[i];

public static A226579Inst Instance=new A226579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226580
{
public static readonly long[] Value={ 0L,7L,5L,5L,5L,5L,5L,1L,7L,6L,6L,6L,6L,6L,2L,8L,7L,7L,7L,7L,7L,3L,9L,8L,8L,8L,8L,8L,4L,10L,9L,9L,9L,9L,9L,5L,11L,10L,10L,10L,10L,10L,6L,12L,11L,11L,11L,11L,11L,7L,13L,12L,12L,12L,12L,12L,8L,14L,13L,13L,13L,13L,13L,9L,15L,14L,14L,14L,14L,14L,10L,16L,15L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226580Inst : IEnumerable<long>
{
public static readonly long[] Value=A226580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226580.Bytes);
public long this[int i]=>Value[i];

public static A226580Inst Instance=new A226580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226581
{
public static readonly long[] Value={ 0L,8L,4L,5L,2L,5L,4L,7L,1L,7L,5L,6L,3L,6L,5L,8L,2L,8L,6L,7L,4L,7L,6L,9L,3L,9L,7L,8L,5L,8L,7L,10L,4L,10L,8L,9L,6L,9L,8L,11L,5L,11L,9L,10L,7L,10L,9L,12L,6L,12L,10L,11L,8L,11L,10L,13L,7L,13L,11L,12L,9L,12L,11L,14L,8L,14L,12L,13L,10L,13L,12L,15L,9L,15L,13L,14L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226581Inst : IEnumerable<long>
{
public static readonly long[] Value=A226581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226581.Bytes);
public long this[int i]=>Value[i];

public static A226581Inst Instance=new A226581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226582
{
public static readonly long[] Value={ 0L,9L,6L,3L,6L,6L,3L,6L,7L,1L,6L,7L,4L,7L,7L,4L,7L,8L,2L,7L,8L,5L,8L,8L,5L,8L,9L,3L,8L,9L,6L,9L,9L,6L,9L,10L,4L,9L,10L,7L,10L,10L,7L,10L,11L,5L,10L,11L,8L,11L,11L,8L,11L,12L,6L,11L,12L,9L,12L,12L,9L,12L,13L,7L,12L,13L,10L,13L,13L,10L,13L,14L,8L,13L,14L,11L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226582Inst : IEnumerable<long>
{
public static readonly long[] Value=A226582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226582.Bytes);
public long this[int i]=>Value[i];

public static A226582Inst Instance=new A226582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226583
{
public static readonly long[] Value={ 0L,10L,5L,6L,4L,2L,4L,6L,5L,6L,1L,6L,5L,7L,5L,3L,5L,7L,6L,7L,2L,7L,6L,8L,6L,4L,6L,8L,7L,8L,3L,8L,7L,9L,7L,5L,7L,9L,8L,9L,4L,9L,8L,10L,8L,6L,8L,10L,9L,10L,5L,10L,9L,11L,9L,7L,9L,11L,10L,11L,6L,11L,10L,12L,10L,8L,10L,12L,11L,12L,7L,12L,11L,13L,11L,9L,11L,13L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226583Inst : IEnumerable<long>
{
public static readonly long[] Value=A226583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226583.Bytes);
public long this[int i]=>Value[i];

public static A226583Inst Instance=new A226583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226584
{
public static readonly long[] Value={ -1L,-1L,-19L,-593L,-23877L,-4496245L,-1588528613L,-12927125815211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226584Inst : IEnumerable<long>
{
public static readonly long[] Value=A226584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226584.Bytes);
public long this[int i]=>Value[i];

public static A226584Inst Instance=new A226584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226585
{
public static readonly long[] Value={ 2L,2L,8L,32L,128L,2048L,55296L,31850496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226585Inst : IEnumerable<long>
{
public static readonly long[] Value=A226585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226585.Bytes);
public long this[int i]=>Value[i];

public static A226585Inst Instance=new A226585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226586
{
public static readonly long[] Value={ 5L,11L,7L,23L,33L,11L,47L,79L,15L,73L,95L,171L,67L,129L,177L,23L,191L,355L,309L,27L,315L,385L,283L,289L,383L,723L,35L,739L,393L,39L,687L,801L,489L,1089L,711L,767L,47L,1459L,649L,281L,1599L,969L,801L,607L,1431L,1633L,59L,1971L,2581L,63L,1555L,1535L,1153L,1069L,2931L,1605L,927L,1843L,3319L,2121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226586Inst : IEnumerable<long>
{
public static readonly long[] Value=A226586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226586.Bytes);
public long this[int i]=>Value[i];

public static A226586Inst Instance=new A226586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226587
{
public static readonly long[] Value={ 154L,198L,220L,1554L,1998L,2220L,9768L,15554L,17094L,19998L,21978L,22220L,24420L,89890L,97768L,105444L,112918L,120190L,127260L,134128L,140794L,147258L,153520L,155554L,159580L,165438L,171094L,176548L,181800L,186850L,191698L,196344L,199998L,200788L,205030L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226587Inst : IEnumerable<long>
{
public static readonly long[] Value=A226587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226587.Bytes);
public long this[int i]=>Value[i];

public static A226587Inst Instance=new A226587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226588
{
public static readonly BigInteger[] Value={ 0L,1L,4L,16L,154L,12091L,73114279L,2672849006516341L,BigInteger.Parse("3572060905817699556013859788654"),BigInteger.Parse("6379809557435582128907282471160505774257452233828787563248841") };
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
public class A226588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226588Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226588.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226588Inst Instance=new A226588Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226589
{
public static readonly long[] Value={ 183783600L,232792560L,273873600L,367567200L,410810400L,441080640L,465585120L,547747200L,551350800L,575134560L,612612000L,616215600L,698377680L,735134400L,745945200L,821620800L,845404560L,882161280L,908107200L,931170240L,944863920L,958557600L,1102701600L,1127206080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226589Inst : IEnumerable<long>
{
public static readonly long[] Value=A226589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226589.Bytes);
public long this[int i]=>Value[i];

public static A226589Inst Instance=new A226589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226590
{
public static readonly long[] Value={ 0L,1L,0L,3L,1L,2L,0L,6L,2L,4L,1L,6L,1L,2L,1L,10L,3L,7L,2L,9L,2L,4L,1L,12L,3L,4L,3L,6L,1L,6L,0L,15L,5L,8L,4L,15L,3L,6L,3L,16L,3L,8L,2L,9L,5L,4L,1L,20L,3L,9L,5L,9L,2L,10L,3L,12L,4L,4L,1L,15L,1L,2L,4L,21L,7L,14L,4L,15L,5L,12L,3L,26L,4L,8L,6L,12L,4L,10L,2L,25L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226590Inst : IEnumerable<long>
{
public static readonly long[] Value=A226590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226590.Bytes);
public long this[int i]=>Value[i];

public static A226590Inst Instance=new A226590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226591
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,4L,6L,6L,7L,10L,9L,12L,14L,14L,20L,20L,23L,30L,29L,39L,44L,46L,62L,63L,76L,94L,95L,124L,137L,151L,195L,202L,246L,293L,309L,395L,433L,492L,612L,648L,792L,921L,1003L,1253L,1374L,1593L,1928L,2084L,2537L,2907L,3244L,3973L,4379L,5133L,6088L,6702L,8103L,9214L,10461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226591Inst : IEnumerable<long>
{
public static readonly long[] Value=A226591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226591.Bytes);
public long this[int i]=>Value[i];

public static A226591Inst Instance=new A226591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226592
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,3L,3L,5L,5L,9L,11L,10L,18L,18L,26L,38L,36L,60L,68L,82L,130L,130L,192L,248L,272L,432L,472L,620L,876L,940L,1412L,1700L,2044L,3000L,3320L,4608L,6016L,6912L,10064L,11792L,15184L,20856L,23864L,33432L,41616L,50832L,71056L,83344L,111056L,145072L,172976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226592Inst : IEnumerable<long>
{
public static readonly long[] Value=A226592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226592.Bytes);
public long this[int i]=>Value[i];

public static A226592Inst Instance=new A226592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226593
{
public static readonly long[] Value={ 1L,3L,8L,18L,96L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226593Inst : IEnumerable<long>
{
public static readonly long[] Value=A226593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226593.Bytes);
public long this[int i]=>Value[i];

public static A226593Inst Instance=new A226593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226594
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,11L,22L,42L,102L,204L,488L,1078L,2723L,6403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226594Inst : IEnumerable<long>
{
public static readonly long[] Value=A226594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226594.Bytes);
public long this[int i]=>Value[i];

public static A226594Inst Instance=new A226594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226595
{
public static readonly long[] Value={ 0L,2L,4L,7L,9L,12L,15L,17L,20L,24L,27L,29L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226595Inst : IEnumerable<long>
{
public static readonly long[] Value=A226595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226595.Bytes);
public long this[int i]=>Value[i];

public static A226595Inst Instance=new A226595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226596
{
public static readonly long[] Value={ 0L,2L,4L,7L,10L,13L,16L,20L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226596Inst : IEnumerable<long>
{
public static readonly long[] Value=A226596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226596.Bytes);
public long this[int i]=>Value[i];

public static A226596Inst Instance=new A226596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226597
{
public static readonly BigInteger[] Value={ 0L,1L,8L,69L,2705L,3673410L,6746994391242L,BigInteger.Parse("22760966657776105541085632"),BigInteger.Parse("259030801598197790167764376907440725907087677647628") };
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
public class A226597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226597Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226597.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226597Inst Instance=new A226597Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226598
{
public static readonly BigInteger[] Value={ 0L,1L,7L,172L,159331L,457962302281L,BigInteger.Parse("34728196483190756583320206"),BigInteger.Parse("10559069708767287358379688495183368797732655643889529662") };
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
public class A226598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226598Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A226598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226598.Bytes);
public BigInteger this[int i]=>Value[i];

public static A226598Inst Instance=new A226598Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226599
{
public static readonly long[] Value={ 10370L,10730L,11570L,12410L,13130L,19610L,22490L,25010L,31610L,38090L,38930L,39338L,39962L,40970L,41810L,55250L,55970L,59330L,59930L,69530L,70850L,73730L,76850L,77090L,89570L,98090L,98930L,103298L,118898L,125450L,126290L,130730L,135218L,139490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226599Inst : IEnumerable<long>
{
public static readonly long[] Value=A226599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226599.Bytes);
public long this[int i]=>Value[i];

public static A226599Inst Instance=new A226599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226600
{
public static readonly long[] Value={ 1L,8L,23L,44L,74L,107L,152L,197L,255L,315L,384L,453L,543L,624L,717L,816L,927L,1032L,1158L,1275L,1413L,1548L,1689L,1830L,2004L,2160L,2325L,2497L,2683L,2860L,3067L,3256L,3469L,3676L,3889L,4108L,4360L,4585L,4822L,5065L,5335L,5584L,5863L,6124L,6406L,6694L,6979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226600Inst : IEnumerable<long>
{
public static readonly long[] Value=A226600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226600.Bytes);
public long this[int i]=>Value[i];

public static A226600Inst Instance=new A226600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226601
{
public static readonly long[] Value={ 1L,8L,17L,32L,50L,77L,98L,137L,170L,212L,245L,308L,350L,425L,470L,527L,587L,686L,740L,851L,917L,998L,1067L,1202L,1277L,1403L,1484L,1601L,1691L,1862L,1937L,2120L,2231L,2360L,2465L,2618L,2726L,2945L,3062L,3215L,3338L,3581L,3680L,3935L,4073L,4235L,4376L,4655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226601Inst : IEnumerable<long>
{
public static readonly long[] Value=A226601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226601.Bytes);
public long this[int i]=>Value[i];

public static A226601Inst Instance=new A226601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226602
{
public static readonly long[] Value={ 1L,1L,3L,3L,6L,3L,9L,3L,9L,6L,9L,3L,18L,3L,9L,9L,12L,3L,18L,3L,18L,9L,9L,3L,27L,6L,9L,9L,18L,3L,27L,3L,15L,9L,9L,9L,36L,3L,9L,9L,27L,3L,27L,3L,18L,18L,9L,3L,36L,6L,18L,9L,18L,3L,27L,9L,27L,9L,9L,3L,54L,3L,9L,18L,18L,9L,27L,3L,18L,9L,27L,3L,54L,3L,9L,18L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226602Inst : IEnumerable<long>
{
public static readonly long[] Value=A226602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226602.Bytes);
public long this[int i]=>Value[i];

public static A226602Inst Instance=new A226602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226603
{
public static readonly long[] Value={ 1L,1L,2L,6L,13L,2L,9L,13L,2744L,2L,1L,93L,2L,1L,19L,15L,6L,6L,168L,6L,13L,2L,5L,1L,26L,91L,3L,6L,1L,5L,10L,18L,1L,293L,250L,11L,1L,41L,30L,5L,1L,8L,16L,4L,2L,497L,176316L,95L,4L,592L,65L,6L,3L,113L,36L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226603Inst : IEnumerable<long>
{
public static readonly long[] Value=A226603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226603.Bytes);
public long this[int i]=>Value[i];

public static A226603Inst Instance=new A226603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226604
{
public static readonly long[] Value={ 1L,0L,1L,8L,1L,6L,0L,9L,4L,3L,9L,7L,2L,6L,8L,4L,3L,7L,5L,3L,4L,8L,2L,3L,2L,1L,5L,2L,6L,3L,0L,5L,5L,8L,1L,1L,9L,5L,8L,7L,5L,2L,3L,8L,1L,5L,3L,1L,3L,9L,5L,7L,4L,7L,3L,6L,7L,4L,3L,6L,4L,4L,8L,3L,7L,2L,8L,9L,3L,2L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226604Inst : IEnumerable<long>
{
public static readonly long[] Value=A226604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226604.Bytes);
public long this[int i]=>Value[i];

public static A226604Inst Instance=new A226604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226605
{
public static readonly long[] Value={ -1L,0L,1L,-5L,1L,-19L,5L,1L,-65L,19L,23L,5L,7L,1L,-211L,-65L,-73L,19L,23L,31L,1L,7L,1L,-665L,-211L,-227L,65L,-251L,73L,89L,19L,85L,101L,23L,31L,47L,5L,37L,1L,11L,1L,-2059L,-665L,-697L,211L,-745L,227L,259L,13L,251L,283L,73L,331L,89L,121L,19L,319L,17L,101L,19L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226605Inst : IEnumerable<long>
{
public static readonly long[] Value=A226605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226605.Bytes);
public long this[int i]=>Value[i];

public static A226605Inst Instance=new A226605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226606
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,11L,7L,13L,49L,5L,5L,23L,23L,29L,179L,17L,17L,37L,37L,37L,11L,55L,61L,601L,115L,115L,47L,115L,47L,47L,101L,47L,47L,101L,101L,101L,119L,101L,17L,119L,125L,1931L,473L,473L,13L,473L,13L,13L,35L,13L,13L,175L,13L,175L,175L,229L,13L,35L,175L,25L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226606Inst : IEnumerable<long>
{
public static readonly long[] Value=A226606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226606.Bytes);
public long this[int i]=>Value[i];

public static A226606Inst Instance=new A226606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226607
{
public static readonly long[] Value={ 1L,1L,19L,23L,187L,347L,5L,1L,13L,1L,131L,211L,227L,251L,259L,283L,287L,319L,1L,23L,5L,5L,7L,41L,7L,17L,1L,11L,3811L,7055L,13L,13L,17L,19L,23L,29L,1L,1L,5L,25L,65L,73L,85L,89L,101L,25L,103L,1L,7L,41L,1L,133L,149L,181L,185L,217L,221L,1L,235L,19L,17L,29L,31L,2585L,2809L,3985L,4121L,4409L,5L,19L,47L,1L,1L,7L,233L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226607Inst : IEnumerable<long>
{
public static readonly long[] Value=A226607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226607.Bytes);
public long this[int i]=>Value[i];

public static A226607Inst Instance=new A226607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226608
{
public static readonly long[] Value={ 1L,1L,49L,37L,2773L,3397L,11L,7L,79L,1L,1853L,1121L,797L,665L,905L,653L,761L,557L,5L,181L,35L,19L,11L,1651L,137L,41L,1L,121L,2277097L,1051393L,131L,127L,79L,89L,53L,65L,157L,23L,43L,643L,331L,223L,211L,259L,175L,1409L,757L,71L,19L,827L,139L,1399L,775L,751L,967L,559L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226608Inst : IEnumerable<long>
{
public static readonly long[] Value=A226608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226608.Bytes);
public long this[int i]=>Value[i];

public static A226608Inst Instance=new A226608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226609
{
public static readonly long[] Value={ 2L,3L,5L,5L,27L,27L,4L,6L,14L,4L,24L,8L,8L,8L,8L,8L,8L,8L,7L,31L,11L,5L,5L,43L,16L,8L,5L,17L,65L,65L,23L,8L,8L,6L,6L,6L,20L,11L,18L,28L,7L,7L,7L,7L,7L,38L,29L,12L,6L,28L,28L,10L,10L,10L,10L,10L,10L,6L,66L,24L,30L,10L,10L,27L,27L,27L,27L,27L,12L,60L,15L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226609Inst : IEnumerable<long>
{
public static readonly long[] Value=A226609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226609.Bytes);
public long this[int i]=>Value[i];

public static A226609Inst Instance=new A226609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226610
{
public static readonly long[] Value={ 1L,1L,3L,3L,17L,17L,2L,2L,8L,1L,15L,5L,5L,5L,5L,5L,5L,5L,2L,18L,5L,2L,2L,26L,8L,4L,1L,9L,41L,41L,12L,4L,4L,3L,3L,3L,8L,3L,7L,16L,4L,4L,4L,4L,4L,22L,17L,4L,2L,16L,11L,6L,6L,6L,6L,6L,6L,1L,41L,12L,16L,5L,5L,17L,17L,17L,17L,17L,4L,32L,8L,16L,20L,20L,14L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226610Inst : IEnumerable<long>
{
public static readonly long[] Value=A226610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226610.Bytes);
public long this[int i]=>Value[i];

public static A226610Inst Instance=new A226610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226611
{
public static readonly long[] Value={ 1L,1L,3L,23L,123L,171L,1L,1L,3L,1L,19L,99L,147L,163L,123L,283L,159L,319L,1L,9L,1L,5L,7L,1L,1L,3L,1L,3L,2531L,5859L,1L,1L,3L,1L,3L,7L,1L,1L,5L,1L,9L,33L,39L,21L,101L,1L,1L,1L,7L,9L,1L,3L,149L,21L,93L,125L,221L,1L,175L,1L,1L,1L,7L,2585L,1073L,2301L,4121L,893L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226611Inst : IEnumerable<long>
{
public static readonly long[] Value=A226611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226611.Bytes);
public long this[int i]=>Value[i];

public static A226611Inst Instance=new A226611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226612
{
public static readonly long[] Value={ 1L,2L,7L,8L,10L,19L,21L,22L,25L,27L,31L,32L,34L,37L,38L,39L,46L,47L,48L,51L,58L,60L,61L,62L,69L,72L,73L,77L,80L,81L,82L,85L,88L,90L,97L,99L,100L,101L,102L,104L,109L,111L,115L,117L,120L,122L,127L,128L,131L,134L,136L,138L,139L,140L,144L,146L,149L,151L,153L,160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226612Inst : IEnumerable<long>
{
public static readonly long[] Value=A226612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226612.Bytes);
public long this[int i]=>Value[i];

public static A226612Inst Instance=new A226612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226613
{
public static readonly long[] Value={ 1L,5L,1L,2L,9L,2L,1L,3L,2L,4L,1L,2L,3L,1L,1L,7L,1L,1L,3L,7L,2L,1L,1L,7L,3L,1L,4L,3L,1L,1L,3L,3L,2L,7L,2L,1L,1L,1L,2L,5L,2L,4L,2L,3L,2L,5L,1L,3L,3L,2L,2L,1L,1L,4L,2L,3L,2L,2L,7L,1L,3L,1L,2L,3L,4L,1L,2L,2L,1L,4L,1L,3L,2L,1L,2L,1L,8L,19L,3L,4L,2L,2L,6L,2L,3L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226613Inst : IEnumerable<long>
{
public static readonly long[] Value=A226613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226613.Bytes);
public long this[int i]=>Value[i];

public static A226613Inst Instance=new A226613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226614
{
public static readonly long[] Value={ 1L,5L,11L,13L,17L,29L,41L,43L,55L,59L,61L,77L,79L,91L,95L,97L,107L,113L,119L,125L,127L,137L,145L,155L,185L,193L,203L,209L,215L,239L,247L,253L,257L,275L,281L,289L,317L,329L,335L,353L,355L,407L,437L,445L,473L,493L,499L,509L,553L,559L,593L,629L,637L,643L,673L,697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226614Inst : IEnumerable<long>
{
public static readonly long[] Value=A226614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226614.Bytes);
public long this[int i]=>Value[i];

public static A226614Inst Instance=new A226614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226615
{
public static readonly long[] Value={ 2L,3L,6L,4L,7L,5L,20L,11L,12L,28L,6L,38L,44L,48L,72L,18L,106L,29L,75L,7L,37L,14L,10L,42L,72L,66L,10L,68L,38L,58L,72L,8L,43L,110L,22L,33L,68L,29L,42L,71L,13L,46L,121L,28L,182L,200L,47L,9L,21L,60L,108L,28L,156L,19L,22L,85L,79L,151L,62L,56L,71L,60L,78L,226L,104L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226615Inst : IEnumerable<long>
{
public static readonly long[] Value=A226615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226615.Bytes);
public long this[int i]=>Value[i];

public static A226615Inst Instance=new A226615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226616
{
public static readonly long[] Value={ 1L,5L,13L,29L,11L,17L,253L,509L,145L,43L,55L,355L,137L,1129L,1007L,131069L,97L,643L,41L,553L,281L,8388605L,4069L,4793489L,3817L,1843L,59L,113L,1301L,2155L,9397L,289L,131153L,3247L,949L,127L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226616Inst : IEnumerable<long>
{
public static readonly long[] Value=A226616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226616.Bytes);
public long this[int i]=>Value[i];

public static A226616Inst Instance=new A226616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226617
{
public static readonly long[] Value={ 1L,11L,43L,55L,643L,97L,673L,41L,1843L,329L,59L,113L,5603L,289L,6505L,77L,407L,127L,499L,79L,865L,749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226617Inst : IEnumerable<long>
{
public static readonly long[] Value=A226617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226617.Bytes);
public long this[int i]=>Value[i];

public static A226617Inst Instance=new A226617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226618
{
public static readonly long[] Value={ 1L,5L,13L,29L,11L,61L,17L,125L,253L,509L,145L,203L,1021L,43L,2045L,55L,4093L,355L,1169L,8189L,137L,3275L,16381L,1129L,32765L,1007L,5957L,9361L,65533L,131069L,97L,52427L,262141L,643L,74897L,524285L,41L,1048573L,553L,28727L,110375L,2097149L,281L,673L,2075L,9731L,34663L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226618Inst : IEnumerable<long>
{
public static readonly long[] Value=A226618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226618.Bytes);
public long this[int i]=>Value[i];

public static A226618Inst Instance=new A226618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226619
{
public static readonly long[] Value={ -1L,1L,1L,-1L,5L,-11L,7L,13L,-49L,5L,23L,29L,-179L,-17L,11L,37L,55L,61L,-601L,-115L,17L,47L,101L,119L,125L,-1931L,-473L,13L,25L,35L,175L,229L,247L,253L,-6049L,-1675L,-217L,-31L,97L,269L,431L,485L,503L,509L,-18659L,-5537L,-1163L,-791L,59L,71L,145L,203L,295L,781L,943L,997L,1015L,1021L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226619Inst : IEnumerable<long>
{
public static readonly long[] Value=A226619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226619.Bytes);
public long this[int i]=>Value[i];

public static A226619Inst Instance=new A226619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226620
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,2L,3L,2L,1L,6L,5L,2L,4L,3L,2L,1L,7L,6L,5L,4L,4L,4L,3L,2L,1L,8L,7L,6L,6L,3L,5L,4L,3L,2L,1L,9L,8L,7L,8L,6L,5L,2L,2L,6L,5L,4L,3L,2L,1L,10L,9L,8L,7L,7L,5L,3L,5L,4L,5L,6L,5L,4L,3L,2L,1L,11L,10L,9L,8L,9L,8L,8L,8L,8L,4L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226620Inst : IEnumerable<long>
{
public static readonly long[] Value=A226620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226620.Bytes);
public long this[int i]=>Value[i];

public static A226620Inst Instance=new A226620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226621
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,3L,1L,1L,1L,3L,1L,5L,5L,2L,1L,1L,3L,7L,1L,2L,5L,7L,3L,1L,1L,4L,8L,1L,1L,14L,14L,8L,4L,1L,1L,3L,12L,1L,6L,2L,1L,1L,14L,23L,20L,12L,2L,1L,1L,5L,15L,29L,1L,1L,1L,2L,5L,5L,42L,34L,25L,14L,5L,1L,1L,5L,16L,28L,2L,9L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226621Inst : IEnumerable<long>
{
public static readonly long[] Value=A226621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226621.Bytes);
public long this[int i]=>Value[i];

public static A226621Inst Instance=new A226621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226622
{
public static readonly long[] Value={ 1L,1L,4L,5L,9L,13L,21L,29L,46L,62L,90L,122L,171L,227L,311L,408L,545L,709L,933L,1198L,1555L,1980L,2536L,3205L,4063L,5092L,6400L,7966L,9928L,12281L,15198L,18684L,22979L,28097L,34346L,41789L,50813L,61527L,74453L,89757L,108114L,129809L,155704L,186221L,222503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226622Inst : IEnumerable<long>
{
public static readonly long[] Value=A226622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226622.Bytes);
public long this[int i]=>Value[i];

public static A226622Inst Instance=new A226622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226623
{
public static readonly long[] Value={ 1L,5L,17L,19L,65L,73L,115L,2263L,2359L,2743L,2963L,3091L,3415L,3743L,4819L,113L,109L,95L,65L,989L,1153L,1165L,293L,511L,505L,625L,769L,211L,227L,251L,311L,1085L,2089L,7471L,10883L,13963L,15875L,16099L,1291L,1355L,1367L,1495L,1931L,2059L,2123L,2203L,2219L,2251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226623Inst : IEnumerable<long>
{
public static readonly long[] Value=A226623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226623.Bytes);
public long this[int i]=>Value[i];

public static A226623Inst Instance=new A226623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226624
{
public static readonly long[] Value={ 1L,7L,91L,29L,179L,143L,505L,17033L,16793L,15497L,31613L,19589L,25781L,15845L,12137L,2011L,311L,517L,103L,19031L,24623L,8339L,811L,2609L,7387L,2995L,18275L,601L,493L,421L,1577L,74611L,13699L,1793597L,275693L,177521L,226769L,144881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226624Inst : IEnumerable<long>
{
public static readonly long[] Value=A226624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226624.Bytes);
public long this[int i]=>Value[i];

public static A226624Inst Instance=new A226624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226625
{
public static readonly long[] Value={ 1L,3L,11L,4L,6L,6L,17L,19L,19L,19L,19L,19L,19L,19L,19L,34L,12L,9L,5L,22L,22L,22L,12L,17L,17L,17L,69L,7L,7L,7L,18L,44L,22L,38L,38L,38L,38L,38L,22L,22L,33L,33L,22L,11L,11L,22L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,48L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226625Inst : IEnumerable<long>
{
public static readonly long[] Value=A226625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226625.Bytes);
public long this[int i]=>Value[i];

public static A226625Inst Instance=new A226625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226626
{
public static readonly long[] Value={ 1L,2L,7L,3L,4L,4L,11L,12L,12L,12L,12L,12L,12L,12L,12L,22L,8L,6L,4L,14L,14L,14L,8L,11L,11L,11L,44L,5L,5L,5L,12L,28L,14L,24L,24L,24L,24L,24L,14L,14L,21L,21L,14L,7L,7L,14L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,32L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226626Inst : IEnumerable<long>
{
public static readonly long[] Value=A226626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226626.Bytes);
public long this[int i]=>Value[i];

public static A226626Inst Instance=new A226626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226627
{
public static readonly long[] Value={ 1L,5L,17L,19L,33L,73L,51L,2263L,2359L,2451L,1671L,2463L,1719L,2367L,4819L,89L,85L,63L,65L,685L,397L,1165L,293L,507L,369L,449L,769L,147L,227L,251L,247L,1085L,777L,7471L,7299L,11811L,5379L,8115L,267L,1355L,1367L,1043L,587L,779L,2123L,827L,2219L,843L,1611L,1707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226627Inst : IEnumerable<long>
{
public static readonly long[] Value=A226627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226627.Bytes);
public long this[int i]=>Value[i];

public static A226627Inst Instance=new A226627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226628
{
public static readonly long[] Value={ 1L,4L,5L,7L,8L,16L,17L,18L,19L,20L,23L,24L,25L,27L,28L,31L,32L,34L,39L,74L,76L,77L,79L,80L,86L,95L,231L,232L,233L,237L,239L,240L,241L,257L,260L,268L,276L,277L,286L,287L,289L,290L,306L,313L,322L,323L,324L,325L,351L,372L,385L,388L,392L,395L,397L,399L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226628Inst : IEnumerable<long>
{
public static readonly long[] Value=A226628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226628.Bytes);
public long this[int i]=>Value[i];

public static A226628Inst Instance=new A226628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226629
{
public static readonly long[] Value={ 3L,1L,2L,1L,8L,1L,1L,1L,1L,3L,1L,1L,2L,1L,3L,1L,2L,5L,35L,2L,1L,2L,1L,6L,9L,136L,1L,1L,4L,2L,1L,1L,16L,3L,8L,8L,1L,9L,1L,2L,1L,16L,7L,9L,1L,1L,1L,26L,21L,13L,3L,4L,3L,2L,2L,38L,4L,2L,29L,3L,1L,1L,1L,1L,1L,5L,1L,3L,1L,1L,8L,8L,1L,34L,33L,3L,1L,3L,1L,1L,1L,96L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226629Inst : IEnumerable<long>
{
public static readonly long[] Value=A226629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226629.Bytes);
public long this[int i]=>Value[i];

public static A226629Inst Instance=new A226629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226630
{
public static readonly long[] Value={ 1L,11L,17L,19L,23L,25L,29L,31L,49L,77L,85L,95L,97L,113L,115L,119L,121L,131L,139L,145L,179L,181L,185L,193L,217L,311L,313L,371L,385L,407L,431L,451L,467L,473L,475L,485L,491L,493L,503L,527L,601L,605L,641L,695L,697L,791L,805L,847L,973L,1163L,1219L,1241L,1295L,1417L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226630Inst : IEnumerable<long>
{
public static readonly long[] Value=A226630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226630.Bytes);
public long this[int i]=>Value[i];

public static A226630Inst Instance=new A226630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226631
{
public static readonly long[] Value={ 1L,4L,6L,17L,19L,34L,12L,9L,5L,22L,12L,17L,17L,69L,7L,18L,22L,38L,11L,12L,6L,68L,44L,30L,9L,19L,68L,14L,22L,44L,23L,30L,84L,8L,17L,17L,30L,12L,68L,18L,7L,22L,15L,22L,85L,10L,14L,22L,22L,10L,14L,18L,44L,12L,68L,22L,9L,38L,17L,14L,55L,8L,56L,50L,36L,44L,25L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226631Inst : IEnumerable<long>
{
public static readonly long[] Value=A226631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226631.Bytes);
public long this[int i]=>Value[i];

public static A226631Inst Instance=new A226631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226632
{
public static readonly long[] Value={ 1L,3L,4L,11L,12L,22L,8L,6L,4L,14L,8L,11L,11L,44L,5L,12L,14L,24L,7L,8L,5L,43L,28L,19L,6L,12L,43L,10L,14L,28L,15L,20L,53L,6L,11L,11L,20L,8L,43L,12L,6L,14L,10L,14L,54L,8L,10L,14L,14L,7L,10L,12L,28L,9L,43L,14L,7L,25L,11L,10L,35L,7L,36L,32L,24L,28L,17L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226632Inst : IEnumerable<long>
{
public static readonly long[] Value=A226632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226632.Bytes);
public long this[int i]=>Value[i];

public static A226632Inst Instance=new A226632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226633
{
public static readonly long[] Value={ 1L,19L,65L,115L,2263L,113L,109L,95L,65L,989L,293L,511L,505L,769L,211L,311L,1085L,7471L,1291L,241L,211L,3605L,1273L,3841L,313L,15415L,6329L,563L,3457L,3095L,1775L,1483L,436099L,665L,2011L,2021L,1003L,1261L,24607L,1199L,665L,4397L,1153L,6839L,6073L,919L,1189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226633Inst : IEnumerable<long>
{
public static readonly long[] Value=A226633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226633.Bytes);
public long this[int i]=>Value[i];

public static A226633Inst Instance=new A226633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226634
{
public static readonly long[] Value={ 1L,4L,6L,17L,19L,34L,12L,9L,5L,22L,12L,17L,17L,69L,7L,18L,44L,38L,22L,48L,6L,68L,44L,30L,54L,38L,68L,14L,22L,44L,23L,30L,84L,8L,17L,17L,30L,12L,68L,18L,7L,66L,30L,22L,85L,10L,14L,66L,44L,30L,14L,54L,44L,12L,68L,44L,9L,38L,34L,14L,55L,8L,56L,50L,36L,44L,25L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226634Inst : IEnumerable<long>
{
public static readonly long[] Value=A226634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226634.Bytes);
public long this[int i]=>Value[i];

public static A226634Inst Instance=new A226634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226635
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,13L,18L,27L,37L,53L,71L,100L,132L,179L,235L,313L,405L,531L,681L,880L,1119L,1429L,1801L,2280L,2852L,3575L,4444L,5529L,6827L,8436L,10357L,12716L,15530L,18958L,23036L,27978L,33839L,40896L,49254L,59265L,71083L,85180L,101781L,121494L,144659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226635Inst : IEnumerable<long>
{
public static readonly long[] Value=A226635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226635.Bytes);
public long this[int i]=>Value[i];

public static A226635Inst Instance=new A226635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226636
{
public static readonly long[] Value={ 5L,7L,11L,13L,15L,19L,21L,29L,31L,33L,37L,39L,45L,55L,57L,63L,83L,85L,87L,91L,93L,99L,109L,111L,117L,135L,163L,165L,171L,189L,245L,247L,249L,253L,255L,261L,271L,273L,279L,297L,325L,327L,333L,351L,405L,487L,489L,495L,513L,567L,731L,733L,735L,739L,741L,747L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226636Inst : IEnumerable<long>
{
public static readonly long[] Value=A226636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226636.Bytes);
public long this[int i]=>Value[i];

public static A226636Inst Instance=new A226636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226637
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,29L,39L,49L,59L,69L,79L,99L,199L,299L,399L,499L,599L,699L,799L,999L,1999L,2999L,3999L,4999L,5999L,6999L,7999L,9999L,19999L,29999L,39999L,49999L,59999L,69999L,79999L,99999L,199999L,299999L,399999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226637Inst : IEnumerable<long>
{
public static readonly long[] Value=A226637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226637.Bytes);
public long this[int i]=>Value[i];

public static A226637Inst Instance=new A226637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226638
{
public static readonly long[] Value={ 0L,1L,6L,20L,84L,319L,1260L,4901L,19176L,74860L,292494L,1142459L,4462920L,17433181L,68099226L,266014100L,1039126224L,4059116419L,15856045380L,61938144041L,241947712356L,945115407340L,3691885043874L,14421535219799L,56334548849040L,220058498917081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226638Inst : IEnumerable<long>
{
public static readonly long[] Value=A226638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226638.Bytes);
public long this[int i]=>Value[i];

public static A226638Inst Instance=new A226638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226639
{
public static readonly long[] Value={ 1L,1L,1L,5L,20L,56L,126L,246L,435L,715L,1111L,1651L,2366L,3290L,4460L,5916L,7701L,9861L,12445L,15505L,19096L,23276L,28106L,33650L,39975L,47151L,55251L,64351L,74530L,85870L,98456L,112376L,127721L,144585L,163065L,183261L,205276L,229216L,255190L,283310L,313691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226639Inst : IEnumerable<long>
{
public static readonly long[] Value=A226639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226639.Bytes);
public long this[int i]=>Value[i];

public static A226639Inst Instance=new A226639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226640
{
public static readonly long[] Value={ 6L,12L,18L,36L,66L,48L,132L,96L,264L,288L,528L,1026L,1032L,384L,2064L,1152L,2112L,8196L,1536L,4224L,16386L,32772L,8448L,32784L,65538L,9216L,16896L,65568L,131076L,12288L,18432L,66048L,262176L,131328L,262272L,132096L,524352L,1048578L,1048584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226640Inst : IEnumerable<long>
{
public static readonly long[] Value=A226640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226640.Bytes);
public long this[int i]=>Value[i];

public static A226640Inst Instance=new A226640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226641
{
public static readonly long[] Value={ 1L,3L,8L,10L,12L,21L,17L,28L,26L,36L,25L,57L,20L,42L,81L,70L,25L,79L,32L,96L,86L,62L,42L,160L,53L,59L,89L,136L,33L,196L,37L,128L,103L,73L,185L,211L,32L,80L,160L,292L,40L,245L,40L,157L,235L,93L,60L,366L,85L,156L,147L,174L,42L,230L,223L,340L,143L,106L,76L,497L,34L,90L,331L,269L,206L,322L,50L,211L,175L,453L,72L,538L,37L,85L,332L,216L,260L,378L,69L,604L,167L,121L,79L,623L,204L,104L,203L,473L,59L,648L,253L,204L,166L,135L,318L,706L,46L,227L,427L,437L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226641Inst : IEnumerable<long>
{
public static readonly long[] Value=A226641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226641.Bytes);
public long this[int i]=>Value[i];

public static A226641Inst Instance=new A226641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226642
{
public static readonly long[] Value={ 1L,3L,3L,6L,10L,10L,9L,20L,21L,21L,16L,28L,11L,33L,36L,31L,24L,57L,11L,68L,42L,35L,23L,70L,37L,51L,79L,76L,30L,96L,17L,65L,62L,50L,138L,160L,18L,51L,59L,142L,34L,136L,24L,140L,196L,46L,32L,128L,43L,98L,73L,111L,46L,211L,111L,192L,80L,63L,46L,292L,24L,81L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226642Inst : IEnumerable<long>
{
public static readonly long[] Value=A226642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226642.Bytes);
public long this[int i]=>Value[i];

public static A226642Inst Instance=new A226642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226643
{
public static readonly long[] Value={ 81L,162L,169L,324L,338L,648L,676L,1296L,1352L,2401L,2592L,2704L,3249L,4802L,5184L,5408L,6498L,9604L,10368L,10816L,12996L,19208L,20736L,21632L,25992L,38416L,41472L,43264L,51984L,76832L,82944L,86528L,103968L,112225L,153664L,165888L,173056L,194481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226643Inst : IEnumerable<long>
{
public static readonly long[] Value=A226643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226643.Bytes);
public long this[int i]=>Value[i];

public static A226643Inst Instance=new A226643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226644
{
public static readonly long[] Value={ 0L,1L,2L,4L,3L,4L,4L,7L,12L,10L,3L,17L,6L,21L,21L,12L,6L,26L,13L,28L,22L,18L,9L,61L,36L,18L,24L,48L,22L,57L,5L,27L,38L,26L,42L,60L,11L,24L,56L,70L,6L,71L,13L,79L,79L,19L,12L,99L,41L,96L,38L,55L,12L,84L,62L,86L,50L,41L,36L,160L,6L,26L,104L,57L,59L,76L,16L,71L,74L,136L,12L,158L,22L,60L,196L,52L,65L,103L,25L,128L,46L,30L,15L,224L,73L,32L,58L,141L,38L,211L,71L,67L,59L,41L,80L,151L,24L,97L,222L,292L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226644Inst : IEnumerable<long>
{
public static readonly long[] Value=A226644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226644.Bytes);
public long this[int i]=>Value[i];

public static A226644Inst Instance=new A226644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226645
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,3L,1L,6L,8L,10L,7L,10L,1L,9L,12L,20L,8L,21L,2L,21L,17L,16L,11L,28L,7L,11L,26L,33L,9L,36L,3L,31L,25L,24L,60L,57L,2L,11L,20L,68L,10L,42L,6L,35L,81L,23L,15L,70L,10L,37L,25L,51L,14L,79L,33L,76L,32L,30L,20L,96L,2L,17L,86L,65L,48L,62L,9L,50L,42L,138L,35L,160L,2L,18L,53L,51L,52L,59L,8L,142L,89L,34L,23L,136L,37L,24L,33L,140L,23L,196L,30L,46L,37L,32L,75L,128L,5L,43L,103L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226645Inst : IEnumerable<long>
{
public static readonly long[] Value=A226645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226645.Bytes);
public long this[int i]=>Value[i];

public static A226645Inst Instance=new A226645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226646
{
public static readonly long[] Value={ 3L,1L,10L,1L,3L,21L,0L,3L,8L,28L,0L,1L,3L,10L,36L,0L,1L,3L,6L,12L,57L,0L,1L,2L,3L,10L,21L,42L,0L,0L,1L,4L,2L,10L,17L,70L,0L,0L,1L,3L,3L,8L,9L,28L,79L,0L,0L,0L,1L,3L,4L,7L,20L,26L,96L,0L,0L,1L,1L,2L,3L,4L,10L,21L,36L,62L,0L,0L,0L,1L,1L,7L,1L,7L,6L,21L,25L,160L,0L,0L,0L,1L,0L,3L,3L,6L,12L,12L,16L,57L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226646Inst : IEnumerable<long>
{
public static readonly long[] Value=A226646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226646.Bytes);
public long this[int i]=>Value[i];

public static A226646Inst Instance=new A226646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226647
{
public static readonly long[] Value={ 1L,9L,25L,37L,63L,71876888199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226647Inst : IEnumerable<long>
{
public static readonly long[] Value=A226647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226647.Bytes);
public long this[int i]=>Value[i];

public static A226647Inst Instance=new A226647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226648
{
public static readonly long[] Value={ 1L,4L,5L,50L,64L,906L,966L,5805L,40514L,133667L,262277L,1416109L,42142704L,189758142L,350476553L,957982453L,1420733777L,1421477786L,2557347701L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226648Inst : IEnumerable<long>
{
public static readonly long[] Value=A226648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226648.Bytes);
public long this[int i]=>Value[i];

public static A226648Inst Instance=new A226648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226649
{
public static readonly long[] Value={ 0L,2L,0L,3L,1L,4L,2L,6L,4L,9L,7L,14L,12L,22L,20L,35L,33L,56L,54L,90L,88L,145L,143L,234L,232L,378L,376L,611L,609L,988L,986L,1598L,1596L,2585L,2583L,4182L,4180L,6766L,6764L,10947L,10945L,17712L,17710L,28658L,28656L,46369L,46367L,75026L,75024L,121394L,121392L,196419L,196417L,317812L,317810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226649Inst : IEnumerable<long>
{
public static readonly long[] Value=A226649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226649.Bytes);
public long this[int i]=>Value[i];

public static A226649Inst Instance=new A226649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226650
{
public static readonly long[] Value={ 1L,2L,5L,7L,10L,18L,52L,83L,113L,133L,169L,226L,347L,568L,909L,4612L,8014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226650Inst : IEnumerable<long>
{
public static readonly long[] Value=A226650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226650.Bytes);
public long this[int i]=>Value[i];

public static A226650Inst Instance=new A226650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226651
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,3L,2L,6L,1L,4L,5L,6L,12L,8L,24L,1L,5L,9L,10L,5L,16L,20L,25L,30L,20L,16L,60L,40L,120L,1L,6L,14L,15L,14L,25L,20L,21L,30L,54L,60L,30L,96L,40L,66L,61L,75L,90L,48L,120L,150L,180L,120L,96L,80L,360L,240L,720L,1L,7L,20L,21L,28L,64L,35L,14L,70L,56L,90L,42L,42L,98L,105L,98L,245L,140L,147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226651Inst : IEnumerable<long>
{
public static readonly long[] Value=A226651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226651.Bytes);
public long this[int i]=>Value[i];

public static A226651Inst Instance=new A226651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226652
{
public static readonly long[] Value={ 3L,5L,12L,17L,110L,182L,217L,347L,352L,397L,432L,495L,707L,712L,775L,787L,822L,907L,920L,1115L,1127L,1265L,1370L,1500L,1722L,1810L,1860L,1953L,1995L,2167L,2742L,2943L,3087L,3372L,3713L,3840L,3985L,4030L,4153L,4580L,4762L,5093L,5750L,6018L,6540L,6920L,7263L,7355L,7367L,7378L,7637L,7957L,8727L,8932L,9002L,9340L,9368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226652Inst : IEnumerable<long>
{
public static readonly long[] Value=A226652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226652.Bytes);
public long this[int i]=>Value[i];

public static A226652Inst Instance=new A226652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226653
{
public static readonly long[] Value={ 3L,5L,7L,11L,17L,19L,23L,29L,31L,43L,47L,53L,59L,67L,71L,79L,83L,87L,89L,97L,101L,107L,109L,125L,127L,131L,137L,139L,149L,151L,167L,173L,179L,181L,191L,197L,199L,207L,223L,227L,229L,233L,239L,251L,263L,269L,271L,279L,281L,287L,293L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226653Inst : IEnumerable<long>
{
public static readonly long[] Value=A226653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226653.Bytes);
public long this[int i]=>Value[i];

public static A226653Inst Instance=new A226653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226654
{
public static readonly long[] Value={ 1L,4L,3L,5L,9L,9L,1L,1L,2L,4L,1L,7L,6L,9L,1L,7L,4L,3L,2L,3L,5L,5L,9L,8L,6L,3L,2L,9L,9L,5L,9L,2L,7L,2L,2L,1L,6L,1L,2L,8L,1L,0L,6L,2L,9L,4L,0L,6L,6L,6L,1L,4L,6L,3L,8L,9L,3L,2L,0L,6L,5L,3L,7L,3L,9L,1L,5L,3L,9L,3L,9L,4L,0L,2L,7L,1L,8L,7L,2L,9L,2L,3L,0L,1L,4L,0L,9L,3L,3L,9L,0L,9L,7L,9L,6L,7L,5L,1L,1L,1L,7L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226654Inst : IEnumerable<long>
{
public static readonly long[] Value=A226654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226654.Bytes);
public long this[int i]=>Value[i];

public static A226654Inst Instance=new A226654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226655
{
public static readonly long[] Value={ 1L,6L,4L,2L,1L,8L,8L,4L,3L,5L,2L,2L,2L,1L,2L,1L,1L,3L,6L,8L,7L,3L,6L,2L,7L,9L,8L,8L,9L,2L,2L,9L,4L,0L,3L,4L,4L,1L,8L,3L,8L,2L,3L,4L,5L,5L,4L,8L,4L,8L,8L,7L,4L,3L,0L,0L,7L,7L,6L,2L,0L,4L,2L,0L,7L,7L,0L,4L,6L,6L,5L,6L,9L,5L,5L,2L,5L,0L,2L,4L,9L,2L,8L,4L,5L,6L,4L,0L,8L,3L,3L,2L,7L,7L,0L,0L,7L,9L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226655Inst : IEnumerable<long>
{
public static readonly long[] Value=A226655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226655.Bytes);
public long this[int i]=>Value[i];

public static A226655Inst Instance=new A226655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A226656
{
public static readonly long[] Value={ 1L,7L,7L,8L,3L,2L,2L,8L,6L,1L,5L,2L,5L,8L,7L,5L,8L,6L,2L,9L,6L,0L,9L,6L,1L,1L,8L,8L,9L,5L,9L,2L,8L,3L,1L,3L,5L,4L,4L,1L,6L,1L,5L,1L,9L,1L,4L,6L,1L,5L,7L,4L,5L,0L,8L,0L,6L,6L,3L,4L,5L,9L,9L,1L,2L,3L,7L,6L,0L,6L,0L,5L,5L,1L,8L,5L,7L,0L,0L,5L,7L,3L,1L,0L,1L,5L,2L,6L,3L,9L,7L,1L,4L,7L,2L,3L,4L,0L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A226656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A226656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A226656Inst : IEnumerable<long>
{
public static readonly long[] Value=A226656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A226656.Bytes);
public long this[int i]=>Value[i];

public static A226656Inst Instance=new A226656Inst();

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