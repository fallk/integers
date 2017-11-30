using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A210457
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,2L,24L,36L,18L,3L,324L,432L,216L,48L,4L,5120L,6400L,3200L,800L,100L,5L,93750L,112500L,56250L,15000L,2250L,180L,6L,1959552L,2286144L,1143072L,317520L,52920L,5292L,294L,7L,46118408L,52706752L,26353376L,7529536L,1344560L,153664L,10976L,448L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210457Inst : IEnumerable<long>
{
public static readonly long[] Value=A210457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210457.Bytes);
public long this[int i]=>Value[i];

public static A210457Inst Instance=new A210457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210458
{
public static readonly long[] Value={ 1L,2L,3L,6L,11L,16L,24L,38L,57L,82L,117L,168L,238L,328L,448L,614L,834L,1114L,1480L,1966L,2592L,3384L,4398L,5704L,7361L,9436L,12045L,15344L,19470L,24576L,30922L,38822L,48576L,60548L,75259L,93342L,115454L,142360L,175104L,214958L,263262L,321584L,391993L,476952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210458Inst : IEnumerable<long>
{
public static readonly long[] Value=A210458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210458.Bytes);
public long this[int i]=>Value[i];

public static A210458Inst Instance=new A210458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210459
{
public static readonly long[] Value={ 1L,4L,6L,8L,17L,32L,54L,80L,116L,192L,290L,408L,585L,832L,1192L,1648L,2237L,3072L,4156L,5576L,7414L,9824L,12964L,16896L,22002L,28544L,36794L,47184L,60185L,76736L,97388L,122864L,154615L,194048L,242904L,302800L,376271L,466720L,577176L,711840L,875611L,1074752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210459Inst : IEnumerable<long>
{
public static readonly long[] Value=A210459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210459.Bytes);
public long this[int i]=>Value[i];

public static A210459Inst Instance=new A210459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210460
{
public static readonly long[] Value={ 1L,2L,4L,10L,23L,53L,123L,285L,660L,1529L,3542L,8205L,19007L,44030L,101996L,236275L,547334L,1267906L,2937120L,6803875L,15761261L,36511157L,84578549L,195927260L,453867933L,1051390708L,2435559643L,5642004185L,13069772820L,30276291184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210460Inst : IEnumerable<long>
{
public static readonly long[] Value=A210460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210460.Bytes);
public long this[int i]=>Value[i];

public static A210460Inst Instance=new A210460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210461
{
public static readonly BigInteger[] Value={ 91L,7381L,597871L,3922632451L,317733228541L,2084647712458321L,168856464709124011L,BigInteger.Parse("1107867264956562636991"),BigInteger.Parse("588766087155780604365200461"),BigInteger.Parse("47690053059618228953581237351"),BigInteger.Parse("25344449488056571213320166359119221"),BigInteger.Parse("166284933091139163730593611482181209801") };
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
public class A210461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210461Inst Instance=new A210461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210462
{
public static readonly long[] Value={ 8L,7L,7L,4L,3L,8L,8L,3L,3L,1L,2L,3L,3L,4L,6L,3L,8L,0L,0L,2L,4L,7L,5L,4L,4L,4L,8L,1L,7L,9L,2L,6L,4L,3L,4L,5L,9L,4L,7L,3L,0L,3L,3L,0L,8L,8L,8L,6L,3L,9L,6L,5L,7L,1L,9L,9L,4L,6L,4L,1L,9L,8L,5L,3L,2L,3L,0L,4L,0L,3L,2L,7L,5L,6L,4L,0L,4L,0L,5L,4L,5L,3L,6L,9L,1L,1L,3L,5L,4L,6L,4L,2L,1L,1L,2L,5L,1L,5L,1L,8L,2L,4L,1L,8L,8L,6L,8L,3L,9L,5L,6L,4L,0L,6L,7L,1L,1L,4L,6L,9L,1L,4L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210462Inst : IEnumerable<long>
{
public static readonly long[] Value=A210462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210462.Bytes);
public long this[int i]=>Value[i];

public static A210462Inst Instance=new A210462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210463
{
public static readonly long[] Value={ 7L,4L,4L,8L,6L,1L,7L,6L,6L,6L,1L,9L,7L,4L,4L,2L,3L,6L,5L,9L,3L,1L,7L,0L,4L,2L,8L,6L,0L,4L,3L,9L,2L,3L,6L,7L,2L,4L,0L,1L,6L,3L,0L,8L,4L,9L,0L,6L,8L,2L,4L,5L,7L,4L,2L,0L,1L,8L,4L,7L,5L,9L,2L,1L,5L,4L,4L,1L,5L,2L,1L,7L,8L,3L,7L,8L,3L,9L,7L,6L,7L,7L,9L,1L,1L,4L,3L,7L,5L,4L,9L,3L,2L,9L,6L,4L,1L,5L,9L,0L,3L,9L,2L,5L,2L,8L,0L,4L,8L,7L,3L,3L,7L,7L,3L,6L,6L,0L,3L,3L,4L,3L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210463Inst : IEnumerable<long>
{
public static readonly long[] Value=A210463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210463.Bytes);
public long this[int i]=>Value[i];

public static A210463Inst Instance=new A210463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210464
{
public static readonly long[] Value={ 4L,11L,18L,33L,48L,74L,100L,140L,180L,237L,294L,371L,448L,548L,648L,774L,900L,1055L,1210L,1397L,1584L,1806L,2028L,2288L,2548L,2849L,3150L,3495L,3840L,4232L,4624L,5066L,5508L,6003L,6498L,7049L,7600L,8210L,8820L,9492L,10164L,10901L,11638L,12443L,13248L,14124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210464Inst : IEnumerable<long>
{
public static readonly long[] Value=A210464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210464.Bytes);
public long this[int i]=>Value[i];

public static A210464Inst Instance=new A210464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210465
{
public static readonly long[] Value={ 7L,13L,193L,271L,157L,193L,1297L,1741L,1231L,1033L,3541L,1447L,727L,2341L,9337L,1747L,9007L,2287L,3307L,14401L,8887L,8161L,8461L,28753L,23623L,23893L,10861L,59233L,70111L,28927L,44257L,101113L,152947L,41941L,65167L,41263L,183301L,409573L,150517L,35803L,138883L,81547L,79693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210465Inst : IEnumerable<long>
{
public static readonly long[] Value=A210465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210465.Bytes);
public long this[int i]=>Value[i];

public static A210465Inst Instance=new A210465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210466
{
public static readonly long[] Value={ 2L,4L,4L,6L,6L,8L,6L,8L,8L,10L,10L,10L,10L,12L,8L,10L,12L,14L,14L,12L,14L,16L,10L,12L,12L,14L,14L,16L,16L,18L,18L,16L,16L,20L,12L,14L,14L,16L,16L,18L,18L,20L,20L,22L,22L,16L,18L,20L,22L,24L,14L,16L,20L,20L,24L,26L,26L,18L,20L,22L,22L,24L,26L,28L,16L,18L,18L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210466Inst : IEnumerable<long>
{
public static readonly long[] Value=A210466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210466.Bytes);
public long this[int i]=>Value[i];

public static A210466Inst Instance=new A210466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210467
{
public static readonly long[] Value={ 2L,2L,101L,263L,1097L,251L,311L,461L,641L,941L,1601L,2351L,2543L,5003L,2837L,4787L,5711L,4283L,7901L,10331L,8831L,2687L,7877L,54287L,5711L,5501L,5303L,56087L,69827L,15641L,63611L,138581L,106427L,91571L,69827L,266177L,142421L,177533L,179687L,309311L,55691L,119291L,509543L,593987L,1393913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210467Inst : IEnumerable<long>
{
public static readonly long[] Value=A210467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210467.Bytes);
public long this[int i]=>Value[i];

public static A210467Inst Instance=new A210467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210468
{
public static readonly long[] Value={ 0L,2L,3L,6L,5L,7L,4L,17L,8L,31L,10L,76L,24L,8L,5L,35L,28L,17L,16L,11L,27L,13L,22L,44L,72L,54L,90L,15L,16L,38L,6L,35L,39L,113L,86L,99L,92L,33L,53L,63L,13L,54L,170L,79L,56L,71L,41L,107L,23L,11L,96L,67L,30L,158L,87L,9L,40L,49L,22L,116L,62L,60L,7L,54L,71L,44L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210468Inst : IEnumerable<long>
{
public static readonly long[] Value=A210468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210468.Bytes);
public long this[int i]=>Value[i];

public static A210468Inst Instance=new A210468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210469
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,5L,5L,6L,7L,7L,8L,8L,8L,9L,9L,10L,11L,11L,12L,13L,13L,13L,14L,15L,15L,16L,16L,16L,17L,18L,18L,19L,19L,20L,21L,21L,22L,23L,24L,24L,25L,25L,25L,26L,26L,26L,27L,27L,28L,29L,30L,31L,32L,33L,33L,34L,34L,35L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210469Inst : IEnumerable<long>
{
public static readonly long[] Value=A210469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210469.Bytes);
public long this[int i]=>Value[i];

public static A210469Inst Instance=new A210469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210470
{
public static readonly long[] Value={ 841L,968L,2312L,3528L,5041L,5776L,12769L,14884L,16641L,45125L,51984L,109561L,123823L,157609L,168921L,207576L,373321L,450241L,498436L,609725L,711828L,731025L,798768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210470Inst : IEnumerable<long>
{
public static readonly long[] Value=A210470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210470.Bytes);
public long this[int i]=>Value[i];

public static A210470Inst Instance=new A210470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210471
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,8L,5L,18L,9L,32L,11L,77L,25L,9L,6L,36L,29L,18L,17L,12L,28L,14L,23L,45L,73L,55L,91L,16L,17L,39L,7L,36L,40L,114L,87L,100L,93L,34L,54L,64L,14L,55L,171L,80L,57L,72L,42L,108L,24L,12L,97L,68L,31L,159L,88L,10L,41L,50L,23L,117L,63L,61L,8L,55L,72L,45L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210471Inst : IEnumerable<long>
{
public static readonly long[] Value=A210471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210471.Bytes);
public long this[int i]=>Value[i];

public static A210471Inst Instance=new A210471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210472
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,0L,1L,2L,1L,0L,1L,3L,6L,1L,0L,1L,4L,33L,20L,1L,0L,1L,5L,196L,543L,70L,1L,0L,1L,6L,1305L,22096L,10497L,252L,1L,0L,1L,7L,9786L,1304045L,3323092L,220503L,924L,1L,0L,1L,8L,82201L,106478916L,1971644785L,574346824L,4870401L,3432L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210472Inst : IEnumerable<long>
{
public static readonly long[] Value=A210472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210472.Bytes);
public long this[int i]=>Value[i];

public static A210472Inst Instance=new A210472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210473
{
public static readonly long[] Value={ 3L,0L,1L,0L,9L,3L,1L,7L,6L,3L,5L,8L,3L,9L,9L,8L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210473Inst : IEnumerable<long>
{
public static readonly long[] Value=A210473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210473.Bytes);
public long this[int i]=>Value[i];

public static A210473Inst Instance=new A210473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210474
{
public static readonly BigInteger[] Value={ 1L,0L,4L,24L,156L,1072L,7668L,56520L,426380L,3276384L,25556196L,201828728L,1610647932L,12968268432L,105219588308L,859440482856L,7061361325164L,58320764249280L,483922589498820L,4032178320794328L,33723925620989532L,283021269941508336L,2382598282012764084L,BigInteger.Parse("20114924440891152264") };
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
public class A210474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210474Inst Instance=new A210474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210475
{
public static readonly long[] Value={ 13L,13L,29L,13L,193L,97L,97L,277L,457L,1193L,109L,229L,937L,397L,349L,1597L,2137L,937L,5569L,5737L,2833L,1549L,6733L,7477L,5077L,3457L,877L,4153L,12277L,11113L,8689L,14029L,11113L,5233L,24109L,14737L,26713L,1297L,77797L,12097L,51577L,57973L,33409L,30493L,49429L,112237L,10333L,143137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210475Inst : IEnumerable<long>
{
public static readonly long[] Value=A210475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210475.Bytes);
public long this[int i]=>Value[i];

public static A210475Inst Instance=new A210475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210476
{
public static readonly long[] Value={ 7L,67L,43L,67L,67L,191L,883L,43L,643L,379L,739L,103L,463L,643L,487L,883L,1303L,3847L,1447L,13963L,1087L,8863L,1999L,8167L,7687L,8443L,2707L,2203L,11083L,3463L,7687L,31387L,8419L,15919L,12979L,10099L,26683L,22027L,46687L,79687L,15439L,65839L,46723L,44683L,14887L,58963L,13879L,26947L,77587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210476Inst : IEnumerable<long>
{
public static readonly long[] Value=A210476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210476.Bytes);
public long this[int i]=>Value[i];

public static A210476Inst Instance=new A210476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210477
{
public static readonly long[] Value={ 667L,1147L,2491L,3127L,4087L,5767L,7387L,17947L,23707L,25591L,28891L,30967L,55687L,64507L,67591L,70747L,75067L,111547L,126727L,136891L,141367L,148987L,190087L,198907L,256027L,295927L,313591L,320347L,329467L,348091L,355207L,364807L,372091L,422491L,430327L,462391L,532891L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210477Inst : IEnumerable<long>
{
public static readonly long[] Value=A210477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210477.Bytes);
public long this[int i]=>Value[i];

public static A210477Inst Instance=new A210477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210478
{
public static readonly long[] Value={ 1L,1L,2L,4L,10L,23L,63L,155L,448L,1152L,3452L,9158L,28178L,76539L,240370L,665129L,2123439L,5964691L,19302315L,54898415L,179696520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210478Inst : IEnumerable<long>
{
public static readonly long[] Value=A210478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210478.Bytes);
public long this[int i]=>Value[i];

public static A210478Inst Instance=new A210478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210479
{
public static readonly long[] Value={ 3L,5L,7L,17L,19L,29L,31L,41L,79L,89L,127L,197L,199L,271L,307L,379L,449L,461L,463L,521L,701L,727L,811L,859L,881L,919L,929L,967L,991L,1217L,1231L,1289L,1301L,1409L,1471L,1481L,1483L,1567L,1721L,1889L,1951L,1999L,2129L,2393L,2441L,2549L,2551L,2729L,2753L,2861L,2969L,3041L,3079L,3319L,3329L,3331L,3499L,3739L,3761L,4049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210479Inst : IEnumerable<long>
{
public static readonly long[] Value=A210479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210479.Bytes);
public long this[int i]=>Value[i];

public static A210479Inst Instance=new A210479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210480
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,2L,3L,3L,3L,3L,2L,2L,2L,2L,2L,1L,3L,3L,4L,4L,4L,5L,4L,4L,3L,3L,2L,2L,4L,4L,4L,5L,5L,7L,6L,6L,3L,4L,3L,3L,5L,5L,4L,5L,5L,7L,7L,6L,4L,3L,3L,4L,4L,3L,2L,4L,4L,7L,6L,6L,3L,3L,4L,4L,4L,4L,2L,4L,4L,6L,5L,5L,3L,2L,4L,4L,6L,3L,3L,4L,4L,7L,5L,6L,4L,4L,4L,4L,7L,6L,5L,4L,3L,8L,5L,7L,3L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210480Inst : IEnumerable<long>
{
public static readonly long[] Value=A210480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210480.Bytes);
public long this[int i]=>Value[i];

public static A210480Inst Instance=new A210480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210481
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,2L,1L,1L,4L,2L,2L,4L,3L,2L,4L,3L,4L,3L,4L,4L,6L,3L,4L,5L,3L,5L,5L,4L,3L,6L,4L,7L,5L,4L,6L,5L,7L,9L,7L,5L,6L,5L,6L,6L,8L,5L,7L,9L,5L,6L,7L,5L,7L,7L,9L,10L,3L,11L,8L,11L,6L,9L,8L,12L,8L,9L,7L,10L,9L,7L,8L,8L,6L,14L,8L,10L,11L,11L,12L,11L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210481Inst : IEnumerable<long>
{
public static readonly long[] Value=A210481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210481.Bytes);
public long this[int i]=>Value[i];

public static A210481Inst Instance=new A210481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210482
{
public static readonly BigInteger[] Value={ 2L,5L,37L,44101L,5336101L,94083986096101L,BigInteger.Parse("1062053250251407755176413469419400772901") };
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
public class A210482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210482Inst Instance=new A210482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210483
{
public static readonly long[] Value={ 0L,2L,3L,3L,3L,15L,3L,6L,7L,11L,8L,5L,12L,5L,6L,2L,7L,6L,3L,10L,8L,7L,7L,25L,7L,22L,26L,7L,7L,27L,23L,4L,4L,17L,4L,12L,18L,9L,4L,16L,13L,15L,19L,17L,18L,3L,19L,2L,3L,18L,20L,15L,3L,5L,3L,8L,19L,8L,8L,21L,8L,8L,22L,15L,8L,52L,8L,49L,23L,19L,16L,49L,8L,31L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210483Inst : IEnumerable<long>
{
public static readonly long[] Value=A210483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210483.Bytes);
public long this[int i]=>Value[i];

public static A210483Inst Instance=new A210483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210484
{
public static readonly long[] Value={ 12L,252L,1872L,8400L,17100L,27900L,75852L,178752L,191100L,261072L,378432L,705600L,737100L,1063692L,1343100L,1976400L,2317392L,3483900L,3820752L,4038012L,6061692L,6760512L,8822352L,9305100L,9909900L,12024012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210484Inst : IEnumerable<long>
{
public static readonly long[] Value=A210484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210484.Bytes);
public long this[int i]=>Value[i];

public static A210484Inst Instance=new A210484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210485
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,3L,0L,3L,3L,6L,0L,3L,8L,8L,12L,0L,5L,11L,15L,15L,20L,0L,8L,17L,24L,29L,29L,35L,0L,10L,23L,36L,41L,47L,47L,54L,0L,13L,36L,50L,65L,71L,78L,78L,86L,0L,18L,48L,75L,91L,104L,111L,119L,119L,128L,0L,25L,69L,102L,132L,150L,165L,173L,182L,182L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210485Inst : IEnumerable<long>
{
public static readonly long[] Value=A210485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210485.Bytes);
public long this[int i]=>Value[i];

public static A210485Inst Instance=new A210485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210486
{
public static readonly BigInteger[] Value={ 0L,1L,20L,543L,22096L,1304045L,106478916L,11545342795L,1608000044288L,280061940550041L,59677171216017940L,15278632095285640631UL,BigInteger.Parse("4628964787172536267920"),BigInteger.Parse("1638318264614752659427333"),BigInteger.Parse("669895681115518466689138436"),BigInteger.Parse("313418973409285344224352078435") };
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
public class A210486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210486Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210486.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210486Inst Instance=new A210486Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210487
{
public static readonly long[] Value={ 5L,2L,3L,3L,3L,5L,3L,5L,5L,3L,5L,3L,3L,5L,5L,3L,5L,3L,7L,3L,5L,3L,3L,5L,5L,5L,5L,3L,5L,5L,5L,5L,5L,5L,5L,7L,5L,5L,5L,5L,5L,7L,3L,5L,5L,7L,7L,5L,7L,5L,7L,5L,7L,5L,5L,5L,5L,5L,11L,3L,5L,3L,11L,5L,5L,5L,7L,5L,7L,5L,7L,7L,7L,7L,5L,5L,7L,5L,5L,7L,5L,7L,3L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210487Inst : IEnumerable<long>
{
public static readonly long[] Value=A210487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210487.Bytes);
public long this[int i]=>Value[i];

public static A210487Inst Instance=new A210487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210488
{
public static readonly long[] Value={ 3L,4L,2L,20L,60L,92L,246L,752L,1289L,2084L,3383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210488Inst : IEnumerable<long>
{
public static readonly long[] Value=A210488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210488.Bytes);
public long this[int i]=>Value[i];

public static A210488Inst Instance=new A210488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210489
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,5L,4L,1L,5L,8L,7L,5L,1L,6L,12L,12L,9L,6L,1L,7L,17L,20L,16L,11L,7L,1L,8L,23L,32L,28L,20L,13L,8L,1L,9L,30L,49L,48L,36L,24L,15L,9L,1L,10L,38L,72L,80L,64L,44L,28L,17L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210489Inst : IEnumerable<long>
{
public static readonly long[] Value=A210489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210489.Bytes);
public long this[int i]=>Value[i];

public static A210489Inst Instance=new A210489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210490
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,17L,19L,21L,22L,23L,25L,26L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,46L,47L,49L,51L,53L,55L,57L,58L,59L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,91L,93L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210490Inst : IEnumerable<long>
{
public static readonly long[] Value=A210490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210490.Bytes);
public long this[int i]=>Value[i];

public static A210490Inst Instance=new A210490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210491
{
public static readonly long[] Value={ 1L,4L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210491Inst : IEnumerable<long>
{
public static readonly long[] Value=A210491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210491.Bytes);
public long this[int i]=>Value[i];

public static A210491Inst Instance=new A210491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210492
{
public static readonly long[] Value={ 2L,17L,5L,6L,37L,65L,8L,689L,1817L,18L,1652L,2135L,40886L,40332L,78740L,80661L,214227L,165389L,239008L,686015L,4260196L,5035566L,21402156L,7955040L,5018507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210492Inst : IEnumerable<long>
{
public static readonly long[] Value=A210492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210492.Bytes);
public long this[int i]=>Value[i];

public static A210492Inst Instance=new A210492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210493
{
public static readonly long[] Value={ 2317111L,2320030L,2364409L,2367328L,2405867L,2408786L,2453165L,2456085L,2458099L,2497542L,2541921L,2544841L,2583379L,2586298L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210493Inst : IEnumerable<long>
{
public static readonly long[] Value=A210493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210493.Bytes);
public long this[int i]=>Value[i];

public static A210493Inst Instance=new A210493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210494
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,35L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,119L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210494Inst : IEnumerable<long>
{
public static readonly long[] Value=A210494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210494.Bytes);
public long this[int i]=>Value[i];

public static A210494Inst Instance=new A210494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210495
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,11L,12L,15L,18L,22L,23L,24L,27L,29L,30L,32L,34L,39L,41L,42L,45L,52L,53L,54L,56L,57L,58L,63L,64L,68L,69L,76L,83L,84L,87L,89L,93L,96L,108L,110L,113L,115L,131L,142L,144L,147L,150L,152L,153L,156L,162L,165L,168L,170L,172L,173L,175L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210495Inst : IEnumerable<long>
{
public static readonly long[] Value=A210495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210495.Bytes);
public long this[int i]=>Value[i];

public static A210495Inst Instance=new A210495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210496
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,33L,81L,196L,470L,1126L,2699L,6487L,15633L,37788L,91589L,222572L,542145L,1323446L,3237074L,7932108L,19469151L,47860083L,117819348L,290424126L,716772644L,1771035921L,4380646788L,10846386691L,26880759090L,66678169061L,165534924098L,411281773379L,1022621256416L,2544478797575L,6335428289930L,15784538365081L,39350771601502L,98158461390807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210496Inst : IEnumerable<long>
{
public static readonly long[] Value=A210496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210496.Bytes);
public long this[int i]=>Value[i];

public static A210496Inst Instance=new A210496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210497
{
public static readonly long[] Value={ 4L,7L,9L,15L,15L,21L,21L,27L,35L,33L,43L,45L,45L,51L,59L,65L,63L,73L,75L,75L,85L,87L,95L,105L,105L,105L,111L,111L,117L,141L,135L,143L,141L,159L,153L,163L,169L,171L,179L,185L,183L,201L,195L,201L,201L,223L,235L,231L,231L,237L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210497Inst : IEnumerable<long>
{
public static readonly long[] Value=A210497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210497.Bytes);
public long this[int i]=>Value[i];

public static A210497Inst Instance=new A210497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210498
{
public static readonly long[] Value={ 131L,137L,139L,173L,179L,311L,313L,317L,373L,379L,719L,733L,739L,797L,971L,977L,1493L,1499L,1571L,1579L,1993L,1997L,1999L,3119L,3371L,3373L,3593L,7013L,7019L,7331L,7333L,7393L,7433L,7517L,7691L,7699L,9371L,9377L,9413L,9419L,9533L,9539L,9677L,9679L,9719L,9833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210498Inst : IEnumerable<long>
{
public static readonly long[] Value=A210498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210498.Bytes);
public long this[int i]=>Value[i];

public static A210498Inst Instance=new A210498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210499
{
public static readonly long[] Value={ 29L,73L,89L,101L,109L,149L,173L,181L,193L,229L,233L,269L,313L,317L,337L,349L,373L,389L,409L,449L,457L,509L,521L,569L,577L,653L,673L,677L,701L,709L,769L,809L,821L,829L,853L,857L,929L,941L,953L,1009L,1013L,1021L,1049L,1069L,1097L,1109L,1117L,1129L,1153L,1181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210499Inst : IEnumerable<long>
{
public static readonly long[] Value=A210499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210499.Bytes);
public long this[int i]=>Value[i];

public static A210499Inst Instance=new A210499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210500
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,5L,2L,1L,1L,1L,5L,6L,2L,1L,1L,1L,5L,1L,1L,11L,1L,1L,4L,13L,2L,1L,1L,5L,4L,1L,1L,1L,1L,1L,1L,4L,2L,1L,1L,1L,5L,1L,17L,1L,1L,1L,1L,1L,1L,4L,1L,21L,1L,9L,1L,1L,1L,5L,5L,1L,1L,1L,1L,10L,1L,1L,13L,1L,3L,9L,1L,1L,1L,1L,1L,1L,7L,9L,4L,1L,7L,1L,23L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210500Inst : IEnumerable<long>
{
public static readonly long[] Value=A210500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210500.Bytes);
public long this[int i]=>Value[i];

public static A210500Inst Instance=new A210500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210501
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,2L,1L,1L,1L,3L,3L,2L,1L,1L,1L,4L,1L,1L,6L,1L,1L,2L,4L,2L,1L,1L,4L,2L,1L,1L,1L,1L,1L,1L,3L,2L,1L,1L,1L,5L,1L,4L,1L,1L,1L,1L,1L,1L,2L,1L,10L,1L,1L,1L,1L,1L,4L,3L,1L,1L,1L,1L,6L,1L,1L,5L,1L,3L,3L,1L,1L,1L,1L,1L,1L,6L,4L,2L,1L,6L,1L,11L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210501Inst : IEnumerable<long>
{
public static readonly long[] Value=A210501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210501.Bytes);
public long this[int i]=>Value[i];

public static A210501Inst Instance=new A210501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210502
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,2L,2L,1L,0L,0L,0L,3L,0L,0L,5L,0L,0L,1L,3L,1L,0L,0L,3L,1L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,4L,0L,3L,0L,0L,0L,0L,0L,0L,1L,0L,9L,0L,0L,0L,0L,0L,3L,2L,0L,0L,0L,0L,5L,0L,0L,4L,0L,2L,2L,0L,0L,0L,0L,0L,0L,5L,3L,1L,0L,5L,0L,10L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210502Inst : IEnumerable<long>
{
public static readonly long[] Value=A210502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210502.Bytes);
public long this[int i]=>Value[i];

public static A210502Inst Instance=new A210502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210503
{
public static readonly long[] Value={ 15L,35L,143L,323L,899L,1763L,3599L,4641L,5183L,10403L,11663L,13585L,19043L,22499L,32399L,35581L,36863L,39203L,51983L,57599L,72899L,79523L,97343L,121103L,176399L,186623L,213443L,272483L,324899L,359999L,381923L,412163L,435599L,446641L,622081L,656099L,675683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210503Inst : IEnumerable<long>
{
public static readonly long[] Value=A210503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210503.Bytes);
public long this[int i]=>Value[i];

public static A210503Inst Instance=new A210503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210504
{
public static readonly long[] Value={ 0L,3L,6L,21L,24L,48L,63L,126L,213L,237L,297L,318L,402L,609L,657L,714L,783L,864L,948L,1053L,1287L,1347L,1449L,1581L,1683L,2166L,2184L,2358L,2457L,2463L,2481L,2736L,2793L,2898L,2919L,3024L,3723L,3786L,3909L,4017L,4479L,4584L,4602L,4857L,5169L,5634L,5733L,7101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210504Inst : IEnumerable<long>
{
public static readonly long[] Value=A210504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210504.Bytes);
public long this[int i]=>Value[i];

public static A210504Inst Instance=new A210504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210505
{
public static readonly long[] Value={ 0L,75L,1380L,1725L,4575L,7095L,10020L,10620L,31800L,38355L,58710L,61170L,67125L,92235L,92310L,94845L,118530L,137415L,156000L,168765L,189705L,238815L,249450L,257370L,339375L,353925L,507270L,584265L,590040L,617265L,625845L,631740L,761760L,845295L,866910L,943605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210505Inst : IEnumerable<long>
{
public static readonly long[] Value=A210505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210505.Bytes);
public long this[int i]=>Value[i];

public static A210505Inst Instance=new A210505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210506
{
public static readonly long[] Value={ 2L,5L,11L,13L,331L,599L,18839L,23747L,24371L,29339L,32141L,67421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210506Inst : IEnumerable<long>
{
public static readonly long[] Value=A210506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210506.Bytes);
public long this[int i]=>Value[i];

public static A210506Inst Instance=new A210506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210507
{
public static readonly BigInteger[] Value={ 1L,10L,111L,1468L,22940L,416250L,8626660L,201349672L,5230931454L,149783426470L,4688281021490L,159284662406460L,5838769123729984L,229711022253150382L,9655348958575618320UL,BigInteger.Parse("431845990498159342000"),BigInteger.Parse("20479127764425617465660"),BigInteger.Parse("1026429489947790074019978") };
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
public class A210507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210507Inst Instance=new A210507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210508
{
public static readonly BigInteger[] Value={ 3L,36L,80662L,2598761979625197L,BigInteger.Parse("2672496879634073073044276636697073994497970453122") };
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
public class A210508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210508Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210508.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210508Inst Instance=new A210508Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210509
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,5L,5L,5L,5L,6L,6L,6L,7L,7L,7L,8L,8L,9L,9L,9L,10L,10L,11L,11L,12L,13L,13L,14L,15L,15L,16L,17L,18L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,30L,31L,33L,34L,36L,37L,39L,41L,43L,45L,47L,49L,52L,54L,57L,60L,62L,65L,69L,72L,75L,79L,83L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210509Inst : IEnumerable<long>
{
public static readonly long[] Value=A210509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210509.Bytes);
public long this[int i]=>Value[i];

public static A210509Inst Instance=new A210509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210510
{
public static readonly long[] Value={ 2L,5L,9L,11L,16L,17L,21L,23L,25L,26L,29L,33L,35L,37L,39L,41L,45L,47L,49L,50L,51L,53L,55L,58L,59L,61L,65L,67L,69L,71L,73L,77L,79L,81L,82L,83L,85L,87L,88L,89L,91L,95L,99L,100L,101L,103L,107L,109L,111L,113L,115L,116L,117L,119L,125L,129L,131L,136L,137L,141L,143L,145L,146L,147L,149L,155L,157L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210510Inst : IEnumerable<long>
{
public static readonly long[] Value=A210510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210510.Bytes);
public long this[int i]=>Value[i];

public static A210510Inst Instance=new A210510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210511
{
public static readonly long[] Value={ 331L,661L,881L,991L,18181L,20201L,21211L,26261L,27271L,32321L,33331L,41411L,48481L,51511L,54541L,57571L,60601L,65651L,69691L,71711L,78781L,86861L,89891L,90901L,92921L,98981L,99991L,1041041L,1051051L,1131131L,1191191L,1201201L,1221221L,1231231L,1261261L,1281281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210511Inst : IEnumerable<long>
{
public static readonly long[] Value=A210511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210511.Bytes);
public long this[int i]=>Value[i];

public static A210511Inst Instance=new A210511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210512
{
public static readonly long[] Value={ 113L,223L,443L,773L,883L,10103L,11113L,14143L,25253L,26263L,28283L,32323L,35353L,41413L,50503L,61613L,68683L,71713L,77773L,80803L,83833L,85853L,88883L,97973L,1001003L,1011013L,1101103L,1131133L,1161163L,1181183L,1221223L,1241243L,1281283L,1331333L,1361363L,1391393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210512Inst : IEnumerable<long>
{
public static readonly long[] Value=A210512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210512.Bytes);
public long this[int i]=>Value[i];

public static A210512Inst Instance=new A210512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210513
{
public static readonly long[] Value={ 227L,337L,557L,887L,997L,11117L,24247L,26267L,27277L,29297L,30307L,32327L,39397L,48487L,51517L,54547L,60607L,62627L,65657L,68687L,69697L,72727L,74747L,78787L,81817L,87877L,89897L,90907L,92927L,93937L,95957L,101710177L,101910197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210513Inst : IEnumerable<long>
{
public static readonly long[] Value=A210513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210513.Bytes);
public long this[int i]=>Value[i];

public static A210513Inst Instance=new A210513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210514
{
public static readonly long[] Value={ 229L,449L,11119L,14149L,22229L,28289L,31319L,37379L,44449L,49499L,52529L,56569L,67679L,70709L,71719L,80809L,86869L,89899L,94949L,95959L,1061069L,1101109L,1131139L,1151159L,1161169L,1191199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210514Inst : IEnumerable<long>
{
public static readonly long[] Value=A210514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210514.Bytes);
public long this[int i]=>Value[i];

public static A210514Inst Instance=new A210514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210515
{
public static readonly long[] Value={ 1235L,4061L,8255L,22775L,24665L,36500L,44501L,52343L,54434L,57644L,58109L,59567L,59588L,65018L,69407L,71789L,78689L,94280L,98594L,106748L,114272L,122504L,134369L,137129L,138905L,144302L,162236L,196439L,235808L,238235L,269912L,277919L,278633L,282461L,290534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210515Inst : IEnumerable<long>
{
public static readonly long[] Value=A210515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210515.Bytes);
public long this[int i]=>Value[i];

public static A210515Inst Instance=new A210515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210516
{
public static readonly long[] Value={ 0L,1L,2L,7L,3L,3L,2L,0L,3L,6L,5L,4L,15L,7L,5L,8L,9L,3L,11L,6L,7L,16L,1L,0L,8L,2L,7L,4L,3L,4L,16L,5L,7L,25L,4L,17L,19L,5L,13L,12L,6L,7L,17L,18L,8L,6L,7L,3L,0L,3L,22L,4L,3L,8L,31L,14L,10L,6L,9L,11L,26L,12L,19L,21L,32L,10L,9L,10L,1L,31L,8L,7L,18L,2L,8L,16L,11L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210516Inst : IEnumerable<long>
{
public static readonly long[] Value=A210516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210516.Bytes);
public long this[int i]=>Value[i];

public static A210516Inst Instance=new A210516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210517
{
public static readonly long[] Value={ 1L,1L,2L,5L,11L,28L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210517Inst : IEnumerable<long>
{
public static readonly long[] Value=A210517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210517.Bytes);
public long this[int i]=>Value[i];

public static A210517Inst Instance=new A210517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210518
{
public static readonly long[] Value={ 0L,0L,2L,3L,4L,7L,11L,16L,25L,40L,65L,102L,168L,275L,446L,739L,1229L,2039L,3401L,5703L,9592L,16144L,27293L,46243L,78498L,133551L,227647L,388683L,664579L,1138288L,1951957L,3351550L,5761455L,9915892L,17082666L,29458442L,50847534L,87842213L,151876932L,262795354L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210518Inst : IEnumerable<long>
{
public static readonly long[] Value=A210518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210518.Bytes);
public long this[int i]=>Value[i];

public static A210518Inst Instance=new A210518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210519
{
public static readonly long[] Value={ 0L,4L,78L,399L,1263L,3084L,6395L,11848L,20212L,32377L,49348L,72250L,102328L,140942L,189575L,249824L,323407L,412159L,518035L,643108L,789568L,959725L,1156007L,1380959L,1637248L,1927657L,2255086L,2622556L,3033205L,3490291L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210519Inst : IEnumerable<long>
{
public static readonly long[] Value=A210519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210519.Bytes);
public long this[int i]=>Value[i];

public static A210519Inst Instance=new A210519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210520
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,6L,11L,17L,28L,42L,64L,105L,173L,267L,438L,726L,1200L,2015L,3325L,5524L,9289L,15659L,26494L,44946L,76483L,129930L,221530L,377856L,645685L,1105802L,1895983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210520Inst : IEnumerable<long>
{
public static readonly long[] Value=A210520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210520.Bytes);
public long this[int i]=>Value[i];

public static A210520Inst Instance=new A210520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210521
{
public static readonly long[] Value={ 1L,3L,5L,2L,4L,6L,8L,10L,12L,14L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,16L,18L,20L,22L,24L,26L,28L,30L,32L,34L,36L,38L,40L,42L,44L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,66L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210521Inst : IEnumerable<long>
{
public static readonly long[] Value=A210521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210521.Bytes);
public long this[int i]=>Value[i];

public static A210521Inst Instance=new A210521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210522
{
public static readonly long[] Value={ 5L,6L,2L,3L,4L,1L,3L,2L,5L,1L,9L,0L,3L,4L,9L,0L,8L,0L,3L,9L,4L,9L,5L,1L,0L,3L,9L,7L,7L,6L,4L,8L,1L,2L,3L,1L,4L,6L,8L,2L,5L,1L,0L,4L,3L,0L,9L,8L,6L,9L,1L,6L,6L,4L,0L,8L,1L,6L,8L,9L,4L,2L,3L,7L,3L,5L,8L,8L,3L,5L,6L,8L,6L,4L,3L,0L,6L,2L,8L,4L,8L,9L,0L,5L,8L,5L,7L,9L,8L,4L,5L,2L,6L,2L,2L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210522Inst : IEnumerable<long>
{
public static readonly long[] Value=A210522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210522.Bytes);
public long this[int i]=>Value[i];

public static A210522Inst Instance=new A210522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210523
{
public static readonly long[] Value={ 1L,3L,4L,6L,12L,18L,24L,36L,48L,72L,96L,108L,144L,168L,192L,216L,240L,288L,360L,384L,432L,576L,648L,672L,720L,864L,1008L,1152L,1296L,1344L,1440L,1728L,1800L,2016L,2304L,2592L,2880L,3024L,3456L,4032L,4320L,4608L,5184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210523Inst : IEnumerable<long>
{
public static readonly long[] Value=A210523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210523.Bytes);
public long this[int i]=>Value[i];

public static A210523Inst Instance=new A210523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210524
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,5L,0L,7L,0L,9L,10L,11L,10L,13L,10L,15L,10L,17L,10L,19L,18L,19L,18L,21L,18L,23L,18L,25L,18L,27L,30L,31L,30L,33L,30L,35L,30L,37L,30L,39L,36L,37L,36L,39L,36L,41L,36L,43L,36L,45L,50L,51L,50L,53L,50L,55L,50L,57L,50L,59L,54L,55L,54L,57L,54L,59L,54L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210524Inst : IEnumerable<long>
{
public static readonly long[] Value=A210524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210524.Bytes);
public long this[int i]=>Value[i];

public static A210524Inst Instance=new A210524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210525
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,5L,17L,129L,823L,16549L,203762L,9057969L,229117047L,20251050469L,1099941609906L,182745344595201L,21826976698036317L,6625997170286326085L,BigInteger.Parse("1760792727174811634066"),BigInteger.Parse("963263479575497024110193"),BigInteger.Parse("572732462137043288595101258"),BigInteger.Parse("560867188756075075604736149189") };
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
public class A210525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210525Inst Instance=new A210525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210526
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,384L,8001L,219200L,7639757L,338030592L,18221107681L,1161865470976L,86954156945501L,7533144553783296L,744010437498030561L,BigInteger.Parse("83107197798886031360"),BigInteger.Parse("10418926401222040969421"),BigInteger.Parse("1453531583873609883451392"),BigInteger.Parse("224285068607398484964201793"),BigInteger.Parse("38075052899686318527662522368") };
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
public class A210526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210526Inst Instance=new A210526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210527
{
public static readonly long[] Value={ 83L,131L,197L,281L,383L,503L,641L,797L,971L,1163L,1373L,1601L,1847L,2111L,2393L,2693L,3011L,3347L,3701L,4073L,4463L,4871L,5297L,5741L,6203L,6683L,7181L,7697L,8231L,8783L,9353L,9941L,10547L,11171L,11813L,12473L,13151L,13847L,14561L,15293L,16043L,16811L,17597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210527Inst : IEnumerable<long>
{
public static readonly long[] Value=A210527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210527.Bytes);
public long this[int i]=>Value[i];

public static A210527Inst Instance=new A210527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210528
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,2L,3L,3L,4L,3L,3L,3L,5L,3L,6L,2L,5L,4L,6L,3L,7L,3L,5L,4L,5L,3L,8L,3L,6L,6L,7L,4L,9L,4L,6L,6L,6L,3L,10L,4L,7L,8L,8L,3L,12L,4L,7L,9L,8L,4L,12L,5L,10L,8L,9L,4L,14L,3L,9L,8L,11L,4L,13L,4L,11L,9L,9L,4L,15L,4L,10L,9L,11L,5L,13L,4L,12L,11L,11L,5L,17L,4L,10L,11L,11L,4L,15L,4L,12L,11L,11L,3L,16L,3L,11L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210528Inst : IEnumerable<long>
{
public static readonly long[] Value=A210528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210528.Bytes);
public long this[int i]=>Value[i];

public static A210528Inst Instance=new A210528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210529
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,7L,1L,7L,7L,17L,11L,19L,17L,1L,17L,19L,13L,19L,13L,11L,23L,23L,11L,13L,83L,89L,17L,29L,61L,179L,283L,233L,13L,1213L,1999L,2029L,719L,1523L,2927L,2089L,3221L,5657L,6857L,541L,1223L,421L,1319L,3709L,653L,1277L,3371L,821L,563L,1721L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210529Inst : IEnumerable<long>
{
public static readonly long[] Value=A210529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210529.Bytes);
public long this[int i]=>Value[i];

public static A210529Inst Instance=new A210529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210530
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,4L,5L,6L,7L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210530Inst : IEnumerable<long>
{
public static readonly long[] Value=A210530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210530.Bytes);
public long this[int i]=>Value[i];

public static A210530Inst Instance=new A210530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210531
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,4L,2L,2L,2L,3L,2L,2L,4L,5L,4L,2L,3L,7L,5L,1L,2L,7L,4L,2L,7L,5L,6L,1L,5L,9L,4L,4L,6L,9L,9L,2L,5L,12L,9L,3L,5L,6L,8L,5L,6L,13L,4L,2L,8L,6L,11L,6L,11L,14L,8L,2L,4L,7L,4L,5L,7L,29L,8L,3L,5L,8L,11L,4L,13L,16L,13L,2L,7L,12L,13L,6L,10L,16L,10L,6L,15L,9L,13L,3L,9L,20L,11L,8L,11L,20L,9L,2L,8L,22L,14L,6L,15L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210531Inst : IEnumerable<long>
{
public static readonly long[] Value=A210531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210531.Bytes);
public long this[int i]=>Value[i];

public static A210531Inst Instance=new A210531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210532
{
public static readonly long[] Value={ 3L,7L,9L,15L,17L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210532Inst : IEnumerable<long>
{
public static readonly long[] Value=A210532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210532.Bytes);
public long this[int i]=>Value[i];

public static A210532Inst Instance=new A210532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210533
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,3L,3L,3L,4L,4L,4L,4L,4L,4L,5L,1L,5L,3L,5L,5L,5L,3L,6L,5L,6L,6L,6L,3L,6L,2L,7L,7L,6L,6L,7L,1L,6L,8L,8L,3L,8L,4L,6L,8L,7L,4L,8L,4L,8L,8L,6L,5L,8L,5L,6L,9L,7L,3L,9L,6L,8L,9L,8L,5L,9L,3L,7L,9L,7L,5L,9L,2L,7L,9L,7L,4L,10L,4L,8L,10L,8L,5L,10L,8L,7L,10L,10L,6L,10L,4L,9L,11L,8L,7L,11L,6L,11L,12L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210533Inst : IEnumerable<long>
{
public static readonly long[] Value=A210533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210533.Bytes);
public long this[int i]=>Value[i];

public static A210533Inst Instance=new A210533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210534
{
public static readonly long[] Value={ 331L,661L,881L,991L,12211L,14411L,15511L,20021L,21121L,23321L,24421L,29921L,33331L,35531L,41141L,45541L,47741L,50051L,51151L,57751L,59951L,63361L,71171L,72271L,74471L,75571L,81181L,84481L,99991L,1022011L,1255211L,1299211L,1311311L,1344311L,1355311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210534Inst : IEnumerable<long>
{
public static readonly long[] Value=A210534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210534.Bytes);
public long this[int i]=>Value[i];

public static A210534Inst Instance=new A210534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210535
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,1L,2L,4L,3L,1L,2L,4L,5L,3L,1L,2L,4L,6L,5L,3L,1L,2L,4L,6L,7L,5L,3L,1L,2L,4L,6L,8L,7L,5L,3L,1L,2L,4L,6L,8L,9L,7L,5L,3L,1L,2L,4L,6L,8L,10L,9L,7L,5L,3L,1L,2L,4L,6L,8L,10L,11L,9L,7L,5L,3L,1L,2L,4L,6L,8L,10L,12L,11L,9L,7L,5L,3L,1L,2L,4L,6L,8L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210535Inst : IEnumerable<long>
{
public static readonly long[] Value=A210535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210535.Bytes);
public long this[int i]=>Value[i];

public static A210535Inst Instance=new A210535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210536
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,1L,6L,8L,10L,2L,4L,9L,11L,13L,3L,5L,7L,12L,14L,16L,1L,6L,8L,10L,15L,17L,19L,2L,4L,9L,11L,13L,18L,20L,22L,3L,5L,7L,12L,14L,16L,21L,23L,25L,1L,6L,8L,10L,15L,17L,19L,24L,26L,28L,2L,4L,9L,11L,13L,18L,20L,22L,27L,29L,2L,9L,31L,3L,5L,7L,12L,14L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210536Inst : IEnumerable<long>
{
public static readonly long[] Value=A210536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210536.Bytes);
public long this[int i]=>Value[i];

public static A210536Inst Instance=new A210536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210537
{
public static readonly long[] Value={ 3L,5L,9L,11L,15L,21L,23L,29L,33L,35L,39L,45L,51L,53L,59L,65L,71L,75L,81L,89L,93L,99L,101L,105L,113L,119L,123L,131L,135L,141L,143L,149L,155L,159L,161L,165L,171L,179L,185L,189L,191L,201L,203L,213L,215L,219L,233L,243L,245L,249L,255L,263L,269L,273L,275L,281L,285L,291L,309L,311L,315L,323L,339L,341L,345L,351L,353L,365L,375L,383L,389L,395L,399L,413L,423L,425L,429L,431L,441L,453L,455L,465L,471L,473L,479L,491L,495L,501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210537Inst : IEnumerable<long>
{
public static readonly long[] Value=A210537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210537.Bytes);
public long this[int i]=>Value[i];

public static A210537Inst Instance=new A210537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210538
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,12L,30L,11L,14L,15L,40L,13L,16L,17L,24L,18L,25L,28L,50L,19L,21L,22L,36L,23L,35L,26L,32L,27L,48L,34L,45L,38L,56L,55L,60L,29L,54L,42L,31L,44L,46L,33L,66L,52L,39L,51L,65L,58L,72L,57L,62L,64L,49L,68L,80L,63L,76L,84L,70L,69L,88L,75L,78L,85L,90L,96L,100L,74L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210538Inst : IEnumerable<long>
{
public static readonly long[] Value=A210538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210538.Bytes);
public long this[int i]=>Value[i];

public static A210538Inst Instance=new A210538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210539
{
public static readonly long[] Value={ 1L,10L,19L,22L,28L,34L,187L,197L,210L,220L,232L,247L,250L,253L,256L,262L,280L,286L,289L,307L,318L,321L,329L,332L,353L,358L,361L,364L,383L,413L,426L,445L,451L,453L,462L,472L,484L,490L,512L,523L,532L,538L,559L,572L,577L,579L,586L,597L,635L,644L,723L,809L,882L,930L,941L,1020L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210539Inst : IEnumerable<long>
{
public static readonly long[] Value=A210539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210539.Bytes);
public long this[int i]=>Value[i];

public static A210539Inst Instance=new A210539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210540
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,8L,17L,40L,104L,291L,857L,2634L,8455L,28424L,100117L,368465L,1410903L,5599073L,22968514L,97267342L,424927846L,1913764155L,8877181958L,42358589064L,207639979365L,1044360973987L,5384167878948L,28429186870051L,153638182314504L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210540Inst : IEnumerable<long>
{
public static readonly long[] Value=A210540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210540.Bytes);
public long this[int i]=>Value[i];

public static A210540Inst Instance=new A210540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210541
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,4L,8L,16L,33L,73L,177L,467L,1309L,3813L,11409L,34999L,110510L,361194L,1226930L,4334048L,15877297L,60049447L,233426007L,929616461L,3786970033L,15777120457L,67260334185L,293617319221L,1312868943154L,6010792180952L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210541Inst : IEnumerable<long>
{
public static readonly long[] Value=A210541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210541.Bytes);
public long this[int i]=>Value[i];

public static A210541Inst Instance=new A210541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210542
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,4L,8L,16L,32L,65L,138L,315L,782L,2090L,5885L,17112L,50743L,152705L,466760L,1455562L,4658963L,15392116L,52663709L,186632887L,683133153L,2570929570L,9900731604L,38864321047L,155126476313L,629028834312L,2592051975917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210542Inst : IEnumerable<long>
{
public static readonly long[] Value=A210542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210542.Bytes);
public long this[int i]=>Value[i];

public static A210542Inst Instance=new A210542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210543
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,4L,8L,16L,32L,64L,129L,267L,582L,1364L,3454L,9338L,26429L,76929L,227579L,680113L,2050000L,6242818L,19284165L,60754153L,196341570L,654012814L,2251195713L,8005274899L,29325473071L,110181281435L,422565983725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210543Inst : IEnumerable<long>
{
public static readonly long[] Value=A210543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210543.Bytes);
public long this[int i]=>Value[i];

public static A210543Inst Instance=new A210543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210544
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,4L,8L,16L,32L,64L,128L,257L,524L,1106L,2470L,5924L,15262L,41690L,118595L,345861L,1023028L,3050590L,9146312L,27567958L,83678750L,256632743L,798853376L,2537255097L,8264988956L,27723246374L,95941707086L,342355797248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210544Inst : IEnumerable<long>
{
public static readonly long[] Value=A210544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210544.Bytes);
public long this[int i]=>Value[i];

public static A210544Inst Instance=new A210544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210545
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,5L,1L,1L,2L,15L,1L,1L,1L,4L,52L,1L,1L,1L,2L,9L,203L,1L,1L,1L,1L,4L,23L,877L,1L,1L,1L,1L,2L,8L,65L,4140L,1L,1L,1L,1L,1L,4L,17L,199L,21147L,1L,1L,1L,1L,1L,2L,8L,40L,654L,115975L,1L,1L,1L,1L,1L,1L,4L,16L,104L,2296L,678570L,1L,1L,1L,1L,1L,1L,2L,8L,33L,291L,8569L,4213597L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210545Inst : IEnumerable<long>
{
public static readonly long[] Value=A210545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210545.Bytes);
public long this[int i]=>Value[i];

public static A210545Inst Instance=new A210545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210546
{
public static readonly BigInteger[] Value={ 13L,17L,31L,71L,113L,311L,1151L,1511L,111211L,112111L,1111711L,1171111L,11111117L,11113111L,11131111L,71111111L,111111131L,131111111L,1111115111L,1115111111L,11111111113L,31111111111L,111111111111111131L,131111111111111111L,BigInteger.Parse("1111111111111111111111111511") };
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
public class A210546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210546Inst Instance=new A210546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210547
{
public static readonly BigInteger[] Value={ 13L,17L,113L,1151L,111211L,1111711L,11111117L,11113111L,111111131L,1111115111L,11111111113L,111111111111111131L,BigInteger.Parse("1111111111111111111111111511"),BigInteger.Parse("11111111111111111711111111111"),BigInteger.Parse("111111111111111111111111111111111111131") };
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
public class A210547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210547Inst Instance=new A210547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210548
{
public static readonly BigInteger[] Value={ 31L,71L,311L,1511L,112111L,1171111L,11131111L,71111111L,131111111L,1115111111L,31111111111L,131111111111111111L,BigInteger.Parse("1151111111111111111111111111"),BigInteger.Parse("11111111111711111111111111111"),BigInteger.Parse("131111111111111111111111111111111111111") };
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
public class A210548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A210548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A210548Inst Instance=new A210548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210549
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,3L,9L,8L,1L,3L,10L,25L,16L,1L,3L,10L,33L,65L,32L,1L,3L,10L,34L,104L,161L,64L,1L,3L,10L,34L,115L,311L,385L,128L,1L,3L,10L,34L,116L,381L,886L,897L,256L,1L,3L,10L,34L,116L,395L,1224L,2421L,2049L,512L,1L,3L,10L,34L,116L,396L,1334L,3796L,6388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210549Inst : IEnumerable<long>
{
public static readonly long[] Value=A210549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210549.Bytes);
public long this[int i]=>Value[i];

public static A210549Inst Instance=new A210549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210550
{
public static readonly long[] Value={ 1L,2L,2L,2L,6L,4L,2L,7L,16L,8L,2L,7L,23L,40L,16L,2L,7L,24L,71L,96L,32L,2L,7L,24L,81L,207L,224L,64L,2L,7L,24L,82L,266L,575L,512L,128L,2L,7L,24L,82L,279L,843L,1535L,1152L,256L,2L,7L,24L,82L,280L,939L,2572L,3967L,2560L,512L,2L,7L,24L,82L,280L,955L,3102L,7565L,9983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210550Inst : IEnumerable<long>
{
public static readonly long[] Value=A210550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210550.Bytes);
public long this[int i]=>Value[i];

public static A210550Inst Instance=new A210550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210551
{
public static readonly long[] Value={ 1L,3L,1L,5L,6L,1L,7L,15L,10L,1L,9L,28L,35L,15L,1L,11L,45L,84L,70L,21L,1L,13L,66L,165L,210L,126L,28L,1L,15L,91L,286L,495L,462L,210L,36L,1L,17L,120L,455L,1001L,1287L,924L,330L,45L,1L,19L,153L,680L,1820L,3003L,3003L,1716L,495L,55L,1L,21L,190L,969L,3060L,6188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210551Inst : IEnumerable<long>
{
public static readonly long[] Value=A210551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210551.Bytes);
public long this[int i]=>Value[i];

public static A210551Inst Instance=new A210551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210552
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,4L,5L,5L,1L,5L,7L,10L,8L,1L,6L,9L,16L,18L,13L,1L,7L,11L,23L,31L,33L,21L,1L,8L,13L,31L,47L,62L,59L,34L,1L,9L,15L,40L,66L,101L,119L,105L,55L,1L,10L,17L,50L,88L,151L,205L,227L,185L,89L,1L,11L,19L,61L,113L,213L,321L,414L,426L,324L,144L,1L,12L,21L,73L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210552Inst : IEnumerable<long>
{
public static readonly long[] Value=A210552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210552.Bytes);
public long this[int i]=>Value[i];

public static A210552Inst Instance=new A210552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210553
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,4L,3L,5L,3L,5L,4L,9L,8L,5L,6L,5L,14L,15L,15L,8L,7L,6L,20L,24L,31L,26L,13L,8L,7L,27L,35L,54L,57L,46L,21L,9L,8L,35L,48L,85L,104L,108L,80L,34L,10L,9L,44L,63L,125L,170L,209L,199L,139L,55L,11L,10L,54L,80L,175L,258L,360L,404L,366L,240L,89L,12L,11L,65L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210553Inst : IEnumerable<long>
{
public static readonly long[] Value=A210553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210553.Bytes);
public long this[int i]=>Value[i];

public static A210553Inst Instance=new A210553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210554
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,4L,4L,9L,12L,8L,5L,14L,25L,28L,16L,6L,20L,44L,66L,64L,32L,7L,27L,70L,129L,168L,144L,64L,8L,35L,104L,225L,360L,416L,320L,128L,9L,44L,147L,363L,681L,968L,1008L,704L,256L,10L,54L,200L,553L,1182L,1970L,2528L,2400L,1536L,512L,11L,65L,264L,806L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210554Inst : IEnumerable<long>
{
public static readonly long[] Value=A210554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210554.Bytes);
public long this[int i]=>Value[i];

public static A210554Inst Instance=new A210554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210555
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,4L,1L,4L,7L,8L,1L,5L,10L,17L,16L,1L,6L,13L,28L,39L,32L,1L,7L,16L,41L,70L,89L,64L,1L,8L,19L,56L,109L,176L,199L,128L,1L,9L,22L,73L,156L,297L,426L,441L,256L,1L,10L,25L,92L,211L,456L,765L,1020L,967L,512L,1L,11L,28L,113L,274L,657L,1236L,1953L,2398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210555Inst : IEnumerable<long>
{
public static readonly long[] Value=A210555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210555.Bytes);
public long this[int i]=>Value[i];

public static A210555Inst Instance=new A210555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A210556
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,4L,6L,10L,8L,5L,8L,18L,22L,16L,6L,10L,28L,42L,50L,32L,7L,12L,40L,68L,106L,110L,64L,8L,14L,54L,100L,188L,250L,242L,128L,9L,16L,70L,138L,300L,468L,594L,526L,256L,10L,18L,88L,182L,446L,780L,1188L,1378L,1138L,512L,11L,20L,108L,232L,630L,1202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A210556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A210556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A210556Inst : IEnumerable<long>
{
public static readonly long[] Value=A210556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A210556.Bytes);
public long this[int i]=>Value[i];

public static A210556Inst Instance=new A210556Inst();

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