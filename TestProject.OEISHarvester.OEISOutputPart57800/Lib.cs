using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A065345
{
public static readonly long[] Value={ 2L,6L,20L,70L,252L,420L,552L,0L,1100L,1144L,0L,1456L,1400L,2040L,2448L,0L,3420L,0L,0L,0L,6072L,5520L,0L,5850L,13104L,0L,12992L,17980L,22320L,27280L,5984L,7854L,7140L,15540L,0L,36556L,13832L,0L,45920L,24682L,0L,0L,0L,0L,51888L,0L,23520L,0L,0L,0L,0L,94446L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065345Inst : IEnumerable<long>
{
public static readonly long[] Value=A065345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065345.Bytes);
public long this[int i]=>Value[i];

public static A065345Inst Instance=new A065345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065346
{
public static readonly long[] Value={ 2L,6L,20L,70L,252L,924L,3432L,990L,14300L,16588L,17472L,39676L,4760L,18360L,46512L,29070L,30780L,87780L,0L,191268L,273240L,322920L,140400L,58500L,190008L,350784L,402752L,611320L,81840L,649264L,41888L,164934L,264180L,295260L,1316016L,694564L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065346Inst : IEnumerable<long>
{
public static readonly long[] Value=A065346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065346.Bytes);
public long this[int i]=>Value[i];

public static A065346Inst Instance=new A065346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065347
{
public static readonly long[] Value={ 3L,5L,8L,9L,11L,12L,15L,16L,17L,18L,19L,20L,21L,22L,23L,24L,26L,27L,29L,32L,33L,35L,36L,38L,39L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,80L,81L,83L,84L,86L,87L,89L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065347Inst : IEnumerable<long>
{
public static readonly long[] Value=A065347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065347.Bytes);
public long this[int i]=>Value[i];

public static A065347Inst Instance=new A065347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065348
{
public static readonly long[] Value={ 8L,11L,16L,18L,19L,20L,23L,26L,35L,38L,41L,42L,43L,44L,46L,48L,49L,50L,51L,53L,54L,55L,56L,58L,59L,60L,64L,66L,67L,68L,70L,71L,72L,73L,74L,75L,76L,80L,83L,86L,89L,92L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,107L,110L,113L,116L,119L,123L,124L,128L,130L,131L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065348Inst : IEnumerable<long>
{
public static readonly long[] Value=A065348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065348.Bytes);
public long this[int i]=>Value[i];

public static A065348Inst Instance=new A065348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065349
{
public static readonly long[] Value={ 19L,41L,42L,43L,49L,50L,53L,54L,55L,58L,67L,71L,74L,75L,95L,97L,98L,99L,102L,103L,123L,135L,138L,139L,145L,149L,153L,154L,155L,159L,163L,165L,166L,167L,168L,169L,170L,173L,174L,175L,178L,179L,180L,183L,184L,185L,191L,193L,194L,195L,197L,198L,199L,200L,201L,202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065349Inst : IEnumerable<long>
{
public static readonly long[] Value=A065349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065349.Bytes);
public long this[int i]=>Value[i];

public static A065349Inst Instance=new A065349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065350
{
public static readonly long[] Value={ 2L,6L,4L,20L,0L,42L,40L,72L,20L,110L,120L,156L,56L,0L,208L,272L,108L,342L,200L,378L,176L,506L,432L,600L,260L,459L,0L,812L,840L,930L,928L,396L,476L,490L,360L,1332L,608L,1131L,1200L,1640L,0L,1806L,880L,0L,920L,2162L,864L,2352L,1100L,1224L,208L,2756L,1296L,2145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065350Inst : IEnumerable<long>
{
public static readonly long[] Value=A065350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065350.Bytes);
public long this[int i]=>Value[i];

public static A065350Inst Instance=new A065350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065351
{
public static readonly long[] Value={ 5L,14L,27L,41L,44L,65L,76L,90L,109L,125L,139L,152L,155L,169L,186L,189L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065351Inst : IEnumerable<long>
{
public static readonly long[] Value=A065351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065351.Bytes);
public long this[int i]=>Value[i];

public static A065351Inst Instance=new A065351Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065352
{
public static readonly long[] Value={ 1L,3L,8L,19L,42L,153L,216L,375L,950L,3565L,4068L,12273L,12274L,31729L,122352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065352Inst : IEnumerable<long>
{
public static readonly long[] Value=A065352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065352.Bytes);
public long this[int i]=>Value[i];

public static A065352Inst Instance=new A065352Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065353
{
public static readonly BigInteger[] Value={ 1L,0L,3L,2L,27L,90L,7003L,744282L,14687099739L,12786682083105626L,BigInteger.Parse("529158535306496354546309979"),BigInteger.Parse("7914572860144723898900437268660641289952090") };
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
public class A065353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065353Inst Instance=new A065353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065354
{
public static readonly BigInteger[] Value={ 1L,5L,6L,107L,730L,224091L,190536538L,120316721060699L,BigInteger.Parse("26815615903949132618586"),BigInteger.Parse("9090874414162652716478489106641017691"),BigInteger.Parse("285152539069955354427985396951391834474389843433339258362714") };
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
public class A065354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065354Inst Instance=new A065354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065355
{
public static readonly long[] Value={ 1L,0L,0L,2L,14L,86L,566L,4166L,34406L,316646L,3219686L,35878886L,435046886L,5704064486L,80428314086L,1213746099686L,19521187251686L,333363035571686L,6024361885107686L,114864714882483686L,2304476522241459686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065355Inst : IEnumerable<long>
{
public static readonly long[] Value=A065355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065355.Bytes);
public long this[int i]=>Value[i];

public static A065355Inst Instance=new A065355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065356
{
public static readonly long[] Value={ 6L,8L,6L,9L,5L,0L,9L,7L,5L,9L,7L,0L,1L,7L,4L,3L,6L,6L,7L,5L,5L,3L,4L,4L,7L,4L,9L,0L,6L,9L,4L,9L,8L,6L,0L,4L,6L,7L,6L,5L,9L,1L,5L,0L,0L,2L,9L,8L,8L,7L,3L,1L,6L,2L,5L,1L,3L,1L,2L,5L,0L,2L,5L,2L,5L,7L,7L,0L,9L,9L,5L,6L,6L,9L,4L,3L,4L,1L,3L,4L,9L,9L,7L,3L,3L,4L,8L,4L,0L,2L,1L,1L,8L,3L,7L,9L,7L,1L,8L,7L,8L,6L,2L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065356Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065356.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065356Inst : IEnumerable<long>
{
public static readonly long[] Value=A065356.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065356.Bytes);
public long this[int i]=>Value[i];

public static A065356Inst Instance=new A065356Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065357
{
public static readonly long[] Value={ 1L,1L,-1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,-1L,-1L,1L,1L,1L,1L,1L,1L,1L,1L,-1L,-1L,-1L,-1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065357Inst : IEnumerable<long>
{
public static readonly long[] Value=A065357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065357.Bytes);
public long this[int i]=>Value[i];

public static A065357Inst Instance=new A065357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065358
{
public static readonly long[] Value={ 1L,0L,1L,2L,1L,0L,1L,2L,3L,4L,3L,2L,3L,4L,5L,6L,5L,4L,5L,6L,7L,8L,7L,6L,5L,4L,3L,2L,3L,4L,3L,2L,1L,0L,-1L,-2L,-1L,0L,1L,2L,1L,0L,1L,2L,3L,4L,3L,2L,1L,0L,-1L,-2L,-1L,0L,1L,2L,3L,4L,3L,2L,3L,4L,5L,6L,7L,8L,7L,6L,5L,4L,5L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,3L,2L,1L,0L,-1L,-2L,-1L,0L,1L,2L,3L,4L,5L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065358Inst : IEnumerable<long>
{
public static readonly long[] Value=A065358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065358.Bytes);
public long this[int i]=>Value[i];

public static A065358Inst Instance=new A065358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065359
{
public static readonly long[] Value={ 0L,1L,-1L,0L,1L,2L,0L,1L,-1L,0L,-2L,-1L,0L,1L,-1L,0L,1L,2L,0L,1L,2L,3L,1L,2L,0L,1L,-1L,0L,1L,2L,0L,1L,-1L,0L,-2L,-1L,0L,1L,-1L,0L,-2L,-1L,-3L,-2L,-1L,0L,-2L,-1L,0L,1L,-1L,0L,1L,2L,0L,1L,-1L,0L,-2L,-1L,0L,1L,-1L,0L,1L,2L,0L,1L,2L,3L,1L,2L,0L,1L,-1L,0L,1L,2L,0L,1L,2L,3L,1L,2L,3L,4L,2L,3L,1L,2L,0L,1L,2L,3L,1L,2L,0L,1L,-1L,0L,1L,2L,0L,1L,-1L,0L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065359Inst : IEnumerable<long>
{
public static readonly long[] Value=A065359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065359.Bytes);
public long this[int i]=>Value[i];

public static A065359Inst Instance=new A065359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065360
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,-1L,0L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,2L,3L,-2L,-1L,-1L,0L,-1L,0L,0L,1L,-1L,0L,0L,1L,0L,1L,1L,2L,-1L,0L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,2L,3L,-1L,0L,0L,1L,0L,1L,1L,2L,0L,1L,1L,2L,1L,2L,2L,3L,0L,1L,1L,2L,1L,2L,2L,3L,1L,2L,2L,3L,2L,3L,3L,4L,-3L,-2L,-2L,-1L,-2L,-1L,-1L,0L,-2L,-1L,-1L,0L,-1L,0L,0L,1L,-2L,-1L,-1L,0L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065360Inst : IEnumerable<long>
{
public static readonly long[] Value=A065360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065360.Bytes);
public long this[int i]=>Value[i];

public static A065360Inst Instance=new A065360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065361
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,4L,5L,6L,6L,7L,8L,8L,9L,10L,8L,9L,10L,10L,11L,12L,12L,13L,14L,8L,9L,10L,10L,11L,12L,12L,13L,14L,12L,13L,14L,14L,15L,16L,16L,17L,18L,16L,17L,18L,18L,19L,20L,20L,21L,22L,16L,17L,18L,18L,19L,20L,20L,21L,22L,20L,21L,22L,22L,23L,24L,24L,25L,26L,24L,25L,26L,26L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065361Inst : IEnumerable<long>
{
public static readonly long[] Value=A065361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065361.Bytes);
public long this[int i]=>Value[i];

public static A065361Inst Instance=new A065361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065362
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,4L,5L,6L,7L,6L,7L,8L,9L,8L,9L,10L,11L,10L,11L,12L,13L,8L,9L,10L,11L,10L,11L,12L,13L,12L,13L,14L,15L,14L,15L,16L,17L,12L,13L,14L,15L,14L,15L,16L,17L,16L,17L,18L,19L,18L,19L,20L,21L,8L,9L,10L,11L,10L,11L,12L,13L,12L,13L,14L,15L,14L,15L,16L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065362Inst : IEnumerable<long>
{
public static readonly long[] Value=A065362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065362.Bytes);
public long this[int i]=>Value[i];

public static A065362Inst Instance=new A065362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065363
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,-2L,-1L,0L,-1L,0L,1L,0L,1L,2L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,0L,1L,2L,1L,2L,3L,2L,3L,4L,-3L,-2L,-1L,-2L,-1L,0L,-1L,0L,1L,-2L,-1L,0L,-1L,0L,1L,0L,1L,2L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,-2L,-1L,0L,-1L,0L,1L,0L,1L,2L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,0L,1L,2L,1L,2L,3L,2L,3L,4L,-1L,0L,1L,0L,1L,2L,1L,2L,3L,0L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065363Inst : IEnumerable<long>
{
public static readonly long[] Value=A065363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065363.Bytes);
public long this[int i]=>Value[i];

public static A065363Inst Instance=new A065363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065364
{
public static readonly long[] Value={ 1L,-2L,-1L,0L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,-3L,-2L,-1L,-4L,-3L,-2L,-1L,0L,1L,-2L,-1L,0L,-3L,-2L,-1L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,2L,3L,4L,1L,2L,3L,0L,1L,2L,3L,4L,5L,2L,3L,4L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,2L,3L,4L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,-3L,-2L,-1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065364Inst : IEnumerable<long>
{
public static readonly long[] Value=A065364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065364.Bytes);
public long this[int i]=>Value[i];

public static A065364Inst Instance=new A065364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065365
{
public static readonly long[] Value={ 1L,1L,2L,3L,1L,2L,3L,3L,4L,5L,5L,6L,7L,1L,2L,3L,3L,4L,5L,5L,6L,7L,5L,6L,7L,7L,8L,9L,9L,10L,11L,9L,10L,11L,11L,12L,13L,13L,14L,15L,1L,2L,3L,3L,4L,5L,5L,6L,7L,5L,6L,7L,7L,8L,9L,9L,10L,11L,9L,10L,11L,11L,12L,13L,13L,14L,15L,9L,10L,11L,11L,12L,13L,13L,14L,15L,13L,14L,15L,15L,16L,17L,17L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065365Inst : IEnumerable<long>
{
public static readonly long[] Value=A065365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065365.Bytes);
public long this[int i]=>Value[i];

public static A065365Inst Instance=new A065365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065366
{
public static readonly long[] Value={ 1L,-3L,-2L,-1L,5L,6L,7L,3L,4L,5L,1L,2L,3L,-11L,-10L,-9L,-13L,-12L,-11L,-15L,-14L,-13L,-7L,-6L,-5L,-9L,-8L,-7L,-11L,-10L,-9L,-3L,-2L,-1L,-5L,-4L,-3L,-7L,-6L,-5L,21L,22L,23L,19L,20L,21L,17L,18L,19L,25L,26L,27L,23L,24L,25L,21L,22L,23L,29L,30L,31L,27L,28L,29L,25L,26L,27L,13L,14L,15L,11L,12L,13L,9L,10L,11L,17L,18L,19L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065366Inst : IEnumerable<long>
{
public static readonly long[] Value=A065366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065366.Bytes);
public long this[int i]=>Value[i];

public static A065366Inst Instance=new A065366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065367
{
public static readonly long[] Value={ 1L,-4L,-3L,-2L,11L,12L,13L,8L,9L,10L,5L,6L,7L,-34L,-33L,-32L,-37L,-36L,-35L,-40L,-39L,-38L,-25L,-24L,-23L,-28L,-27L,-26L,-31L,-30L,-29L,-16L,-15L,-14L,-19L,-18L,-17L,-22L,-21L,-20L,101L,102L,103L,98L,99L,100L,95L,96L,97L,110L,111L,112L,107L,108L,109L,104L,105L,106L,119L,120L,121L,116L,117L,118L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065367Inst : IEnumerable<long>
{
public static readonly long[] Value=A065367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065367.Bytes);
public long this[int i]=>Value[i];

public static A065367Inst Instance=new A065367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065368
{
public static readonly long[] Value={ 0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,2L,3L,4L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,-3L,-2L,-1L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,-3L,-2L,-1L,-4L,-3L,-2L,-1L,0L,1L,-2L,-1L,0L,-3L,-2L,-1L,0L,1L,2L,-1L,0L,1L,-2L,-1L,0L,1L,2L,3L,0L,1L,2L,-1L,0L,1L,2L,3L,4L,1L,2L,3L,0L,1L,2L,3L,4L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065368Inst : IEnumerable<long>
{
public static readonly long[] Value=A065368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065368.Bytes);
public long this[int i]=>Value[i];

public static A065368Inst Instance=new A065368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065369
{
public static readonly long[] Value={ 0L,1L,2L,-3L,-2L,-1L,-6L,-5L,-4L,9L,10L,11L,6L,7L,8L,3L,4L,5L,18L,19L,20L,15L,16L,17L,12L,13L,14L,-27L,-26L,-25L,-30L,-29L,-28L,-33L,-32L,-31L,-18L,-17L,-16L,-21L,-20L,-19L,-24L,-23L,-22L,-9L,-8L,-7L,-12L,-11L,-10L,-15L,-14L,-13L,-54L,-53L,-52L,-57L,-56L,-55L,-60L,-59L,-58L,-45L,-44L,-43L,-48L,-47L,-46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065369Inst : IEnumerable<long>
{
public static readonly long[] Value=A065369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065369.Bytes);
public long this[int i]=>Value[i];

public static A065369Inst Instance=new A065369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065370
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,5L,2L,8L,3L,11L,4L,19L,7L,49L,18L,68L,25L,87L,32L,106L,39L,193L,71L,685L,252L,878L,323L,1071L,394L,1264L,465L,1457L,536L,2721L,1001L,12341L,4540L,15062L,5541L,17783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065370Inst : IEnumerable<long>
{
public static readonly long[] Value=A065370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065370.Bytes);
public long this[int i]=>Value[i];

public static A065370Inst Instance=new A065370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065371
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,3L,1L,1L,2L,6L,1L,7L,3L,2L,1L,10L,1L,11L,2L,3L,6L,14L,1L,4L,7L,1L,3L,19L,2L,20L,1L,6L,10L,6L,1L,25L,11L,7L,2L,28L,3L,29L,6L,2L,14L,32L,1L,9L,4L,10L,7L,37L,1L,12L,3L,11L,19L,42L,2L,43L,20L,3L,1L,14L,6L,48L,10L,14L,6L,51L,1L,52L,25L,4L,11L,18L,7L,57L,2L,1L,28L,60L,3L,20L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065371Inst : IEnumerable<long>
{
public static readonly long[] Value=A065371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065371.Bytes);
public long this[int i]=>Value[i];

public static A065371Inst Instance=new A065371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065372
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,2L,1L,6L,1L,1L,1L,3L,1L,1L,3L,1L,1L,11L,1L,2L,1L,1L,2L,1L,1L,4L,6L,3L,1L,3L,1L,19L,1L,1L,3L,1L,1L,1L,1L,2L,3L,25L,1L,1L,1L,6L,11L,3L,1L,29L,2L,1L,1L,3L,1L,1L,2L,3L,1L,10L,1L,7L,4L,1L,6L,1L,3L,11L,1L,1L,3L,2L,1L,2L,19L,11L,1L,14L,1L,3L,3L,2L,1L,6L,1L,1L,1L,1L,1L,4L,2L,11L,3L,1L,25L,57L,1L,2L,1L,4L,1L,60L,6L,3L,11L,3L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065372Inst : IEnumerable<long>
{
public static readonly long[] Value=A065372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065372.Bytes);
public long this[int i]=>Value[i];

public static A065372Inst Instance=new A065372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065373
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,3L,2L,2L,1L,3L,1L,3L,2L,2L,2L,3L,1L,2L,3L,1L,2L,4L,2L,3L,1L,2L,3L,2L,1L,3L,3L,3L,2L,3L,2L,5L,2L,2L,3L,2L,1L,2L,2L,3L,3L,4L,1L,2L,2L,3L,4L,3L,2L,6L,3L,2L,1L,3L,2L,2L,3L,3L,2L,4L,1L,4L,3L,2L,3L,2L,3L,4L,2L,1L,3L,3L,2L,3L,5L,4L,2L,4L,2L,3L,3L,3L,2L,3L,1L,2L,2L,2L,2L,3L,3L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065373Inst : IEnumerable<long>
{
public static readonly long[] Value=A065373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065373.Bytes);
public long this[int i]=>Value[i];

public static A065373Inst Instance=new A065373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065374
{
public static readonly long[] Value={ 5L,13L,29L,43L,61L,307L,383L,2689L,9209L,14897L,83557L,274679L,598333L,3516973L,11295673L,24104629L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065374Inst : IEnumerable<long>
{
public static readonly long[] Value=A065374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065374.Bytes);
public long this[int i]=>Value[i];

public static A065374Inst Instance=new A065374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065375
{
public static readonly long[] Value={ 1L,1L,3L,2L,4L,3L,7L,5L,17L,12L,24L,17L,41L,29L,99L,70L,140L,99L,239L,169L,577L,408L,816L,577L,1393L,985L,3363L,2378L,8119L,5741L,19601L,13860L,47321L,33461L,114243L,80782L,275807L,195025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065375Inst : IEnumerable<long>
{
public static readonly long[] Value=A065375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065375.Bytes);
public long this[int i]=>Value[i];

public static A065375Inst Instance=new A065375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065376
{
public static readonly long[] Value={ 3L,7L,11L,17L,19L,23L,29L,41L,43L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065376Inst : IEnumerable<long>
{
public static readonly long[] Value=A065376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065376.Bytes);
public long this[int i]=>Value[i];

public static A065376Inst Instance=new A065376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065377
{
public static readonly long[] Value={ 2L,5L,13L,31L,37L,61L,127L,379L,439L,571L,829L,991L,1549L,3319L,7549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065377Inst : IEnumerable<long>
{
public static readonly long[] Value=A065377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065377.Bytes);
public long this[int i]=>Value[i];

public static A065377Inst Instance=new A065377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065378
{
public static readonly long[] Value={ 2L,3L,11L,101L,307L,30001253L,100111001L,110111011L,111010111L,111091111L,1011099011101L,1100011100011L,1100101010011L,1101010101011L,100110101011001L,100110990111001L,101000010000101L,101011000110101L,101110000011101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065378Inst : IEnumerable<long>
{
public static readonly long[] Value=A065378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065378.Bytes);
public long this[int i]=>Value[i];

public static A065378Inst Instance=new A065378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065379
{
public static readonly BigInteger[] Value={ 4L,9L,121L,10201L,94249L,900075181570009L,12124434743442121L,12323244744232321L,12341234943214321L,BigInteger.Parse("1022321210249420121232201"),BigInteger.Parse("1210024420147410244200121"),BigInteger.Parse("1210222232227222322220121") };
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
public class A065379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065379Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065379.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065379Inst Instance=new A065379Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065380
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,257L,263L,269L,271L,277L,281L,283L,293L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065380Inst : IEnumerable<long>
{
public static readonly long[] Value=A065380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065380.Bytes);
public long this[int i]=>Value[i];

public static A065380Inst Instance=new A065380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065381
{
public static readonly long[] Value={ 2L,127L,149L,251L,331L,337L,373L,509L,599L,701L,757L,809L,877L,907L,977L,997L,1019L,1087L,1259L,1549L,1597L,1619L,1657L,1759L,1777L,1783L,1867L,1973L,2203L,2213L,2293L,2377L,2503L,2579L,2683L,2789L,2843L,2879L,2909L,2999L,3119L,3163L,3181L,3187L,3299L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065381Inst : IEnumerable<long>
{
public static readonly long[] Value=A065381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065381.Bytes);
public long this[int i]=>Value[i];

public static A065381Inst Instance=new A065381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065382
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,1L,2L,3L,2L,2L,3L,3L,3L,3L,2L,4L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,6L,4L,5L,3L,6L,6L,7L,5L,5L,6L,4L,8L,5L,6L,6L,8L,6L,8L,5L,7L,5L,11L,4L,6L,9L,7L,8L,9L,8L,7L,7L,9L,7L,8L,7L,12L,5L,9L,9L,11L,9L,7L,7L,12L,10L,10L,9L,9L,9L,6L,11L,10L,11L,9L,12L,11L,12L,9L,10L,11L,12L,10L,13L,9L,11L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065382Inst : IEnumerable<long>
{
public static readonly long[] Value=A065382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065382.Bytes);
public long this[int i]=>Value[i];

public static A065382Inst Instance=new A065382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065383
{
public static readonly long[] Value={ 2L,2L,3L,7L,11L,17L,23L,29L,37L,47L,59L,67L,79L,97L,107L,127L,137L,157L,173L,191L,211L,233L,257L,277L,307L,331L,353L,379L,409L,439L,467L,499L,541L,563L,599L,631L,673L,709L,743L,787L,821L,863L,907L,947L,991L,1039L,1087L,1129L,1181L,1229L,1277L,1327L,1381L,1433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065383Inst : IEnumerable<long>
{
public static readonly long[] Value=A065383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065383.Bytes);
public long this[int i]=>Value[i];

public static A065383Inst Instance=new A065383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065384
{
public static readonly long[] Value={ 3L,5L,7L,13L,19L,23L,31L,43L,53L,61L,73L,89L,103L,113L,131L,151L,167L,181L,199L,229L,251L,271L,293L,317L,349L,373L,401L,433L,463L,491L,523L,557L,593L,619L,661L,701L,739L,773L,811L,859L,887L,941L,983L,1033L,1069L,1123L,1171L,1223L,1259L,1321L,1373L,1429L,1483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065384Inst : IEnumerable<long>
{
public static readonly long[] Value=A065384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065384.Bytes);
public long this[int i]=>Value[i];

public static A065384Inst Instance=new A065384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065385
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,12L,18L,24L,30L,36L,42L,48L,54L,60L,66L,72L,78L,84L,90L,102L,108L,114L,120L,126L,132L,138L,144L,150L,168L,180L,198L,204L,210L,240L,252L,264L,270L,294L,300L,330L,360L,378L,390L,420L,450L,462L,480L,504L,510L,540L,546L,570L,600L,630L,660L,690L,714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065385Inst : IEnumerable<long>
{
public static readonly long[] Value=A065385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065385.Bytes);
public long this[int i]=>Value[i];

public static A065385Inst Instance=new A065385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065386
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,12L,16L,22L,24L,30L,32L,36L,44L,46L,48L,54L,60L,66L,70L,72L,78L,88L,90L,92L,94L,96L,110L,120L,132L,138L,140L,162L,176L,180L,184L,198L,210L,220L,250L,264L,270L,294L,324L,330L,342L,352L,360L,382L,396L,402L,426L,440L,486L,500L,514L,522L,528L,550L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065386Inst : IEnumerable<long>
{
public static readonly long[] Value=A065386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065386.Bytes);
public long this[int i]=>Value[i];

public static A065386Inst Instance=new A065386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065387
{
public static readonly long[] Value={ 2L,4L,6L,9L,10L,14L,14L,19L,19L,22L,22L,32L,26L,30L,32L,39L,34L,45L,38L,50L,44L,46L,46L,68L,51L,54L,58L,68L,58L,80L,62L,79L,68L,70L,72L,103L,74L,78L,80L,106L,82L,108L,86L,104L,102L,94L,94L,140L,99L,113L,104L,122L,106L,138L,112L,144L,116L,118L,118L,184L,122L,126L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065387Inst : IEnumerable<long>
{
public static readonly long[] Value=A065387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065387.Bytes);
public long this[int i]=>Value[i];

public static A065387Inst Instance=new A065387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065388
{
public static readonly long[] Value={ 2L,4L,6L,9L,10L,14L,19L,22L,32L,39L,45L,50L,68L,80L,103L,106L,108L,140L,144L,184L,219L,248L,258L,284L,316L,392L,451L,528L,594L,624L,672L,808L,816L,915L,948L,955L,1088L,1266L,1440L,1640L,1704L,1824L,1843L,2020L,2031L,2176L,2208L,2610L,3072L,3304L,3512L,3888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065388Inst : IEnumerable<long>
{
public static readonly long[] Value=A065388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065388.Bytes);
public long this[int i]=>Value[i];

public static A065388Inst Instance=new A065388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065389
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,25L,29L,31L,37L,43L,53L,61L,73L,97L,109L,127L,143L,151L,157L,181L,211L,241L,313L,331L,337L,397L,403L,421L,527L,541L,601L,631L,661L,757L,779L,899L,1009L,1147L,1201L,1321L,1333L,1517L,1621L,1763L,1801L,2017L,2161L,2341L,2501L,2521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065389Inst : IEnumerable<long>
{
public static readonly long[] Value=A065389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065389.Bytes);
public long this[int i]=>Value[i];

public static A065389Inst Instance=new A065389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065390
{
public static readonly long[] Value={ 1L,3L,7L,12L,18L,28L,31L,39L,42L,56L,72L,91L,96L,98L,168L,195L,252L,280L,312L,360L,372L,392L,546L,576L,744L,840L,864L,992L,1092L,1170L,1344L,1512L,1680L,1860L,1872L,2016L,2240L,2418L,2880L,3224L,3600L,3844L,4320L,4368L,4914L,5082L,5952L,6045L,6552L,7440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065390Inst : IEnumerable<long>
{
public static readonly long[] Value=A065390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065390.Bytes);
public long this[int i]=>Value[i];

public static A065390Inst Instance=new A065390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065391
{
public static readonly long[] Value={ 1L,2L,4L,8L,9L,16L,32L,36L,64L,100L,144L,256L,324L,400L,576L,900L,1296L,1600L,2304L,2916L,3600L,5184L,8100L,9216L,11664L,14400L,20736L,22500L,25600L,30276L,32400L,41616L,46656L,57600L,69696L,72900L,82944L,90000L,104976L,115600L,121104L,129600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065391Inst : IEnumerable<long>
{
public static readonly long[] Value=A065391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065391.Bytes);
public long this[int i]=>Value[i];

public static A065391Inst Instance=new A065391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065392
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,30L,36L,72L,126L,180L,360L,432L,660L,930L,1512L,2160L,3300L,3780L,5184L,6552L,11160L,13860L,19800L,23232L,32760L,45360L,47520L,50400L,58080L,61776L,102300L,110160L,137592L,155520L,163296L,196560L,212960L,252000L,272160L,284580L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065392Inst : IEnumerable<long>
{
public static readonly long[] Value=A065392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065392.Bytes);
public long this[int i]=>Value[i];

public static A065392Inst Instance=new A065392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065393
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,17L,19L,29L,31L,37L,41L,53L,61L,73L,95L,97L,109L,127L,143L,157L,181L,209L,241L,287L,313L,323L,337L,377L,403L,407L,421L,473L,527L,533L,541L,589L,601L,661L,713L,731L,757L,779L,899L,1009L,1073L,1147L,1159L,1199L,1271L,1321L,1333L,1349L,1517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065393Inst : IEnumerable<long>
{
public static readonly long[] Value=A065393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065393.Bytes);
public long this[int i]=>Value[i];

public static A065393Inst Instance=new A065393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065394
{
public static readonly long[] Value={ 1L,5L,8L,14L,22L,25L,31L,48L,56L,73L,78L,80L,138L,159L,163L,210L,240L,248L,312L,314L,474L,482L,634L,648L,684L,723L,836L,896L,978L,1026L,1134L,1184L,1320L,1344L,1410L,1424L,1608L,1686L,1760L,1776L,1862L,2226L,2624L,2824L,2936L,3024L,3120L,3280L,3460L,3660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065394Inst : IEnumerable<long>
{
public static readonly long[] Value=A065394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065394.Bytes);
public long this[int i]=>Value[i];

public static A065394Inst Instance=new A065394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065395
{
public static readonly long[] Value={ 0L,-1L,1L,-3L,5L,-1L,8L,-1L,0L,1L,14L,-5L,22L,4L,7L,-15L,25L,-12L,31L,3L,12L,6L,28L,-1L,12L,16L,23L,4L,48L,-9L,56L,-5L,26L,13L,44L,-44L,73L,23L,36L,7L,78L,-4L,76L,18L,36L,12L,56L,-29L,60L,-18L,39L,18L,80L,7L,66L,28L,59L,32L,74L,-17L,138L,40L,43L,-63L,100L,-6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065395Inst : IEnumerable<long>
{
public static readonly long[] Value=A065395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065395.Bytes);
public long this[int i]=>Value[i];

public static A065395Inst Instance=new A065395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065396
{
public static readonly long[] Value={ 3L,5L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L,281L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065396Inst : IEnumerable<long>
{
public static readonly long[] Value=A065396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065396.Bytes);
public long this[int i]=>Value[i];

public static A065396Inst Instance=new A065396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065397
{
public static readonly long[] Value={ 2L,7L,61L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065397Inst : IEnumerable<long>
{
public static readonly long[] Value=A065397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065397.Bytes);
public long this[int i]=>Value[i];

public static A065397Inst Instance=new A065397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065398
{
public static readonly long[] Value={ 2L,3L,5L,21L,34L,89L,377L,610L,2584L,17711L,75025L,121393L,196418L,514229L,832040L,1346269L,5702887L,63245986L,165580141L,433494437L,1134903170L,2971215073L,20365011074L,53316291173L,86267571272L,591286729879L,2504730781961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065398Inst : IEnumerable<long>
{
public static readonly long[] Value=A065398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065398.Bytes);
public long this[int i]=>Value[i];

public static A065398Inst Instance=new A065398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065399
{
public static readonly long[] Value={ 3L,79L,8185L,1953086L,798151657L,791260228781L,603160664037585L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065399Inst : IEnumerable<long>
{
public static readonly long[] Value=A065399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065399.Bytes);
public long this[int i]=>Value[i];

public static A065399Inst Instance=new A065399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065400
{
public static readonly long[] Value={ 3L,65L,7655L,1636439L,742729679L,657497877119L,534282568283519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065400Inst : IEnumerable<long>
{
public static readonly long[] Value=A065400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065400.Bytes);
public long this[int i]=>Value[i];

public static A065400Inst Instance=new A065400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065401
{
public static readonly long[] Value={ 1L,4L,22L,1474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065401Inst : IEnumerable<long>
{
public static readonly long[] Value=A065401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065401.Bytes);
public long this[int i]=>Value[i];

public static A065401Inst Instance=new A065401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065402
{
public static readonly long[] Value={ 1L,3L,18L,1452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065402Inst : IEnumerable<long>
{
public static readonly long[] Value=A065402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065402.Bytes);
public long this[int i]=>Value[i];

public static A065402Inst Instance=new A065402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065403
{
public static readonly long[] Value={ 31L,127L,1093L,2801L,8191L,19531L,30941L,131071L,88741L,524287L,292561L,797161L,732541L,3500201L,5229043L,12207031L,25646167L,28792661L,39449441L,48037081L,305175781L,262209281L,917087137L,2147483647L,1394714501L,2666986681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065403Inst : IEnumerable<long>
{
public static readonly long[] Value=A065403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065403.Bytes);
public long this[int i]=>Value[i];

public static A065403Inst Instance=new A065403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065404
{
public static readonly long[] Value={ 16L,64L,729L,2401L,4096L,15625L,28561L,65536L,83521L,262144L,279841L,531441L,707281L,3418801L,4826809L,9765625L,24137569L,28398241L,38950081L,47458321L,244140625L,260144641L,887503681L,1073741824L,1387488001L,2655237841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065404Inst : IEnumerable<long>
{
public static readonly long[] Value=A065404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065404.Bytes);
public long this[int i]=>Value[i];

public static A065404Inst Instance=new A065404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065405
{
public static readonly long[] Value={ 4L,8L,27L,49L,64L,125L,169L,256L,289L,512L,529L,729L,841L,1849L,2197L,3125L,4913L,5329L,6241L,6889L,15625L,16129L,29791L,32768L,37249L,51529L,57121L,69169L,76729L,113569L,117649L,128881L,139129L,157609L,192721L,208849L,226981L,229441L,253009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065405Inst : IEnumerable<long>
{
public static readonly long[] Value=A065405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065405.Bytes);
public long this[int i]=>Value[i];

public static A065405Inst Instance=new A065405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065406
{
public static readonly long[] Value={ 2L,3L,5L,89L,9689L,21701L,859433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065406Inst : IEnumerable<long>
{
public static readonly long[] Value=A065406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065406.Bytes);
public long this[int i]=>Value[i];

public static A065406Inst Instance=new A065406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065407
{
public static readonly long[] Value={ 1L,3L,9L,45L,2949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065407Inst : IEnumerable<long>
{
public static readonly long[] Value=A065407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065407.Bytes);
public long this[int i]=>Value[i];

public static A065407Inst Instance=new A065407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065408
{
public static readonly long[] Value={ 16L,25L,49L,256L,289L,625L,676L,784L,841L,1024L,1156L,1369L,1444L,1600L,1936L,2209L,2401L,2500L,2704L,2809L,3136L,3721L,3844L,4096L,4225L,4900L,5329L,6241L,6724L,6889L,7921L,8281L,9604L,11236L,11449L,11881L,13225L,13456L,13924L,14161L,15625L,16129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065408Inst : IEnumerable<long>
{
public static readonly long[] Value=A065408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065408.Bytes);
public long this[int i]=>Value[i];

public static A065408Inst Instance=new A065408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065409
{
public static readonly ulong[] Value={ 1L,8L,144L,2432L,40000L,649728L,10486784L,168681472L,2708038656L,43425996800L,695894425600L,11146676797440L,178493059563520L,2857665426882560L,45744737668300800L,732196083173687296L,11718755500209471488UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065409Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A065409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065409.Bytes);
public ulong this[int i]=>Value[i];

public static A065409Inst Instance=new A065409Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065410
{
public static readonly BigInteger[] Value={ 2L,6L,74L,16430L,1079779602L,5829619944476392022L,BigInteger.Parse("203906812182221592008725937367751490906"),BigInteger.Parse("291045916380210542889328709144540300448800843154329245652913718353100604905854") };
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
public class A065410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065410Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065410.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065410Inst Instance=new A065410Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065411
{
public static readonly BigInteger[] Value={ 0L,1L,13L,144L,806515533049393L,61305790721611591L,BigInteger.Parse("83621143489848422977"),BigInteger.Parse("6356306993006846248183"),BigInteger.Parse("155576970220531065681649693"),BigInteger.Parse("78569350599398894027251472817058687522") };
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
public class A065411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065411Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065411.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065411Inst Instance=new A065411Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065412
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,1L,20L,480L,10560L,272640L,8709120L,280627200L,10644480000L,439404134400L,18781972070400L,873535419187200L,45751167221760000L,2665172872986624000L,BigInteger.Parse("160281737951182848000"),BigInteger.Parse("10593163661832880128000") };
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
public class A065412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065412Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065412.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065412Inst Instance=new A065412Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065413
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,3L,1L,0L,0L,2L,1L,1L,1L,1L,1L,1L,1L,0L,1L,2L,0L,1L,1L,2L,1L,1L,1L,1L,3L,0L,1L,0L,0L,1L,0L,2L,2L,0L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,0L,1L,2L,0L,2L,1L,1L,2L,1L,0L,2L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,2L,1L,2L,3L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065413Inst : IEnumerable<long>
{
public static readonly long[] Value=A065413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065413.Bytes);
public long this[int i]=>Value[i];

public static A065413Inst Instance=new A065413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065414
{
public static readonly long[] Value={ 6L,9L,7L,5L,0L,1L,3L,5L,8L,4L,9L,6L,3L,6L,5L,9L,0L,3L,2L,8L,4L,6L,7L,0L,3L,5L,0L,8L,2L,0L,9L,2L,2L,9L,2L,4L,0L,7L,3L,1L,5L,3L,9L,4L,6L,2L,1L,4L,5L,1L,5L,3L,9L,5L,3L,5L,4L,3L,7L,8L,7L,5L,2L,8L,8L,6L,4L,5L,9L,1L,1L,0L,5L,9L,6L,0L,9L,5L,5L,6L,6L,6L,6L,6L,1L,5L,4L,8L,3L,8L,5L,1L,3L,0L,7L,1L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065414Inst : IEnumerable<long>
{
public static readonly long[] Value=A065414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065414.Bytes);
public long this[int i]=>Value[i];

public static A065414Inst Instance=new A065414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065415
{
public static readonly long[] Value={ 8L,5L,6L,5L,4L,0L,4L,4L,4L,8L,5L,3L,5L,4L,2L,1L,7L,4L,4L,2L,6L,1L,6L,7L,9L,8L,4L,1L,3L,5L,9L,5L,3L,8L,8L,2L,1L,6L,6L,5L,7L,2L,8L,0L,0L,3L,1L,7L,6L,5L,2L,1L,4L,0L,3L,2L,5L,4L,8L,3L,2L,1L,6L,1L,6L,9L,4L,3L,1L,4L,4L,9L,8L,0L,3L,5L,9L,8L,9L,6L,3L,9L,2L,8L,3L,2L,3L,1L,1L,3L,0L,8L,2L,5L,9L,2L,0L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065415Inst : IEnumerable<long>
{
public static readonly long[] Value=A065415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065415.Bytes);
public long this[int i]=>Value[i];

public static A065415Inst Instance=new A065415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065416
{
public static readonly long[] Value={ 9L,3L,1L,2L,6L,5L,1L,8L,4L,1L,6L,0L,0L,0L,4L,3L,3L,4L,3L,8L,9L,2L,3L,7L,2L,0L,5L,5L,5L,0L,6L,7L,6L,9L,8L,2L,5L,5L,8L,4L,2L,3L,7L,3L,4L,5L,8L,7L,8L,0L,1L,0L,5L,9L,0L,1L,6L,9L,8L,7L,7L,1L,5L,4L,5L,9L,5L,4L,3L,3L,6L,0L,2L,8L,6L,8L,2L,3L,8L,5L,1L,5L,8L,2L,5L,1L,2L,8L,9L,6L,4L,8L,1L,0L,8L,9L,5L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065416Inst : IEnumerable<long>
{
public static readonly long[] Value=A065416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065416.Bytes);
public long this[int i]=>Value[i];

public static A065416Inst Instance=new A065416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065417
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,2L,3L,4L,6L,7L,11L,14L,20L,27L,39L,52L,75L,102L,145L,201L,286L,397L,565L,791L,1123L,1581L,2248L,3173L,4517L,6399L,9112L,12945L,18457L,26270L,37502L,53478L,76416L,109146L,156135L,223301L,319764L,457884L,656288L,940795L,1349671L,1936620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065417Inst : IEnumerable<long>
{
public static readonly long[] Value=A065417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065417.Bytes);
public long this[int i]=>Value[i];

public static A065417Inst Instance=new A065417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065418
{
public static readonly long[] Value={ 6L,3L,5L,1L,6L,6L,3L,5L,4L,6L,0L,4L,2L,7L,1L,2L,0L,7L,2L,0L,6L,6L,9L,6L,5L,9L,1L,2L,7L,2L,5L,2L,2L,4L,1L,7L,3L,4L,2L,0L,6L,5L,6L,8L,7L,3L,3L,2L,3L,7L,2L,4L,5L,0L,8L,9L,9L,7L,3L,4L,4L,6L,0L,4L,8L,6L,7L,8L,4L,6L,1L,3L,1L,1L,6L,1L,3L,9L,1L,8L,8L,2L,0L,8L,0L,2L,9L,1L,3L,8L,6L,7L,6L,4L,0L,4L,6L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065418Inst : IEnumerable<long>
{
public static readonly long[] Value=A065418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065418.Bytes);
public long this[int i]=>Value[i];

public static A065418Inst Instance=new A065418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065419
{
public static readonly long[] Value={ 3L,0L,7L,4L,9L,4L,8L,7L,8L,7L,5L,8L,3L,2L,7L,0L,9L,3L,1L,2L,3L,3L,5L,4L,4L,8L,6L,0L,7L,1L,0L,7L,6L,8L,5L,3L,0L,2L,2L,1L,7L,8L,5L,1L,9L,9L,5L,0L,6L,6L,3L,9L,2L,8L,2L,9L,8L,3L,0L,8L,3L,9L,6L,2L,6L,0L,8L,8L,8L,7L,6L,7L,2L,9L,6L,6L,9L,2L,9L,9L,4L,8L,1L,3L,8L,4L,0L,2L,6L,4L,6L,8L,1L,7L,1L,4L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065419Inst : IEnumerable<long>
{
public static readonly long[] Value=A065419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065419.Bytes);
public long this[int i]=>Value[i];

public static A065419Inst Instance=new A065419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065420
{
public static readonly long[] Value={ 2L,6L,6L,12L,30L,12L,20L,90L,90L,20L,30L,210L,380L,210L,30L,42L,420L,1190L,1190L,420L,42L,56L,756L,3080L,4830L,3080L,756L,56L,72L,1260L,6972L,15750L,15750L,6972L,1260L,72L,90L,1980L,14280L,43890L,63252L,43890L,14280L,1980L,90L,110L,2970L,27060L,108570L,212982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065420Inst : IEnumerable<long>
{
public static readonly long[] Value=A065420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065420.Bytes);
public long this[int i]=>Value[i];

public static A065420Inst Instance=new A065420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065421
{
public static readonly long[] Value={ 1L,9L,0L,2L,1L,6L,0L,5L,8L,3L,1L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065421Inst : IEnumerable<long>
{
public static readonly long[] Value=A065421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065421.Bytes);
public long this[int i]=>Value[i];

public static A065421Inst Instance=new A065421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065422
{
public static readonly long[] Value={ 1L,1L,2L,6L,24L,120L,20L,140L,1120L,10080L,1008L,11088L,77L,1001L,14014L,210210L,3363360L,57177120L,1029188160L,19554575040L,977728752L,2217072L,100776L,2317848L,96577L,2414425L,62775050L,1694926350L,47457937800L,1376280196200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065422Inst : IEnumerable<long>
{
public static readonly long[] Value=A065422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065422.Bytes);
public long this[int i]=>Value[i];

public static A065422Inst Instance=new A065422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065423
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,2L,6L,3L,8L,4L,10L,5L,12L,6L,14L,7L,16L,8L,18L,9L,20L,10L,22L,11L,24L,12L,26L,13L,28L,14L,30L,15L,32L,16L,34L,17L,36L,18L,38L,19L,40L,20L,42L,21L,44L,22L,46L,23L,48L,24L,50L,25L,52L,26L,54L,27L,56L,28L,58L,29L,60L,30L,62L,31L,64L,32L,66L,33L,68L,34L,70L,35L,72L,36L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065423Inst : IEnumerable<long>
{
public static readonly long[] Value=A065423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065423.Bytes);
public long this[int i]=>Value[i];

public static A065423Inst Instance=new A065423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065424
{
public static readonly BigInteger[] Value={ 1L,33L,1326L,59432L,2851425L,143291610L,7446255180L,396893583792L,21579377870484L,1192183281903845L,66734212415276406L,3776778437640143208L,BigInteger.Parse("215744630060724034270"),BigInteger.Parse("12423227699242323077940") };
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
public class A065424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065424Inst Instance=new A065424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065425
{
public static readonly long[] Value={ 3L,67L,5L,13L,7L,17L,11L,37L,11L,31L,13L,29L,17L,41L,17L,37L,19L,41L,23L,53L,23L,113L,31L,53L,29L,109L,29L,61L,31L,71L,41L,89L,37L,73L,37L,83L,41L,89L,41L,109L,43L,89L,47L,101L,47L,97L,61L,101L,53L,113L,53L,109L,61L,113L,59L,137L,59L,127L,61L,131L,71L,137L,67L,139L,67L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065425Inst : IEnumerable<long>
{
public static readonly long[] Value=A065425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065425.Bytes);
public long this[int i]=>Value[i];

public static A065425Inst Instance=new A065425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065426
{
public static readonly long[] Value={ 0L,1L,16L,18L,21L,405L,1199L,2301L,19965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065426Inst : IEnumerable<long>
{
public static readonly long[] Value=A065426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065426.Bytes);
public long this[int i]=>Value[i];

public static A065426Inst Instance=new A065426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065427
{
public static readonly BigInteger[] Value={ 0L,0L,2985984L,0L,8230494633984L,3337361219911680L,6228256734040080384L,BigInteger.Parse("3805798464766127112192"),BigInteger.Parse("3709157902229878153150464"),BigInteger.Parse("2551322088493458484723974144"),BigInteger.Parse("1975434352763670408966273884160"),BigInteger.Parse("1365996733186337666590790664585216") };
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
public class A065427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065427Inst Instance=new A065427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065428
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,12L,15L,16L,24L,28L,40L,48L,56L,60L,72L,88L,112L,120L,168L,232L,240L,280L,312L,408L,520L,760L,840L,1320L,1848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065428Inst : IEnumerable<long>
{
public static readonly long[] Value=A065428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065428.Bytes);
public long this[int i]=>Value[i];

public static A065428Inst Instance=new A065428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065429
{
public static readonly BigInteger[] Value={ 0L,0L,1L,7L,50L,371L,3023L,26962L,263503L,2806759L,32439638L,404794391L,5429249279L,77941628854L,1193095348531L,19406686847167L,334372746780002L,6085085617645595L,116659595136911903L,2350442395504338154L,BigInteger.Parse("49658877772798776295"),BigInteger.Parse("1097945956312067172727") };
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
public class A065429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065429Inst Instance=new A065429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065430
{
public static readonly long[] Value={ 1L,3L,24L,24L,120L,72L,336L,192L,648L,360L,1320L,576L,2184L,1008L,2880L,1536L,4896L,1944L,6840L,2880L,8064L,3960L,12144L,4608L,15000L,6552L,17496L,8064L,24360L,8640L,29760L,12288L,31680L,14688L,40320L,15552L,50616L,20520L,52416L,23040L,68880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065430Inst : IEnumerable<long>
{
public static readonly long[] Value=A065430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065430.Bytes);
public long this[int i]=>Value[i];

public static A065430Inst Instance=new A065430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065431
{
public static readonly long[] Value={ 0L,3L,3L,1L,29L,4L,1L,20L,1L,2L,1L,45L,1L,1L,1L,5L,2L,1L,6L,1L,7L,9L,1L,12L,5L,4L,1L,22L,8L,1L,1L,1L,4L,1L,2L,1L,1L,13L,2L,2L,1L,20L,1L,1L,6L,1L,4L,5L,8L,12L,1L,1L,1L,18L,1L,1L,1L,11L,1L,1813L,2L,1L,6L,2L,1L,517L,1L,1L,4L,3L,6L,1L,4L,1L,1L,7L,4L,24L,3L,5L,1L,5L,2L,4L,1L,24L,4L,2L,7L,9L,1L,59L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065431Inst : IEnumerable<long>
{
public static readonly long[] Value=A065431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065431.Bytes);
public long this[int i]=>Value[i];

public static A065431Inst Instance=new A065431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065432
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-2L,0L,1L,-3L,1L,1L,1L,-4L,3L,2L,0L,1L,-5L,6L,2L,-2L,-2L,1L,-6L,10L,0L,-6L,-4L,0L,1L,-7L,15L,-5L,-11L,-3L,5L,5L,1L,-8L,21L,-14L,-15L,4L,15L,10L,0L,1L,-9L,28L,-28L,-15L,19L,26L,6L,-14L,-14L,1L,-10L,36L,-48L,-7L,42L,30L,-16L,-42L,-28L,0L,1L,-11L,45L,-75L,14L,70L,16L,-60L,-70L,-14L,42L,42L,1L,-12L,55L,-110L,54L,96L,-28L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065432Inst : IEnumerable<long>
{
public static readonly long[] Value=A065432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065432.Bytes);
public long this[int i]=>Value[i];

public static A065432Inst Instance=new A065432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065433
{
public static readonly long[] Value={ 2L,5L,11L,12L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065433Inst : IEnumerable<long>
{
public static readonly long[] Value=A065433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065433.Bytes);
public long this[int i]=>Value[i];

public static A065433Inst Instance=new A065433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065434
{
public static readonly long[] Value={ 2L,1L,0L,2L,2L,0L,3L,9L,6L,3L,8L,7L,7L,1L,5L,5L,4L,9L,9L,2L,6L,2L,8L,4L,7L,9L,5L,9L,3L,8L,9L,6L,9L,0L,2L,7L,7L,7L,3L,3L,4L,3L,4L,0L,5L,2L,4L,9L,0L,2L,7L,8L,1L,7L,5L,4L,6L,2L,9L,5L,2L,0L,4L,0L,3L,5L,8L,7L,5L,9L,8L,5L,8L,6L,0L,6L,8L,8L,9L,0L,7L,9L,9L,7L,1L,3L,6L,5L,8L,5L,1L,4L,1L,8L,0L,1L,5L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065434Inst : IEnumerable<long>
{
public static readonly long[] Value=A065434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065434.Bytes);
public long this[int i]=>Value[i];

public static A065434Inst Instance=new A065434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065435
{
public static readonly long[] Value={ 2L,3L,5L,8L,12L,18L,28L,40L,60L,96L,148L,228L,366L,586L,936L,1506L,2428L,3922L,6342L,10256L,16590L,26826L,43394L,70212L,113598L,183798L,297388L,481174L,778548L,1259712L,2038242L,3297918L,5336130L,8634042L,13970112L,22604076L,36574162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065435Inst : IEnumerable<long>
{
public static readonly long[] Value=A065435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065435.Bytes);
public long this[int i]=>Value[i];

public static A065435Inst Instance=new A065435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065436
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,17L,23L,37L,59L,89L,139L,227L,359L,577L,929L,1499L,2423L,3919L,6337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065436Inst : IEnumerable<long>
{
public static readonly long[] Value=A065436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065436.Bytes);
public long this[int i]=>Value[i];

public static A065436Inst Instance=new A065436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065437
{
public static readonly long[] Value={ 3L,2L,2L,2L,10L,3L,2L,18L,3L,4L,2L,6L,5L,6L,46L,52L,4L,6L,5L,7L,2L,78L,5L,8L,8L,10L,102L,2L,5L,8L,2L,10L,136L,138L,148L,3L,7L,162L,166L,3L,178L,10L,6L,12L,6L,11L,8L,222L,8L,12L,3L,14L,12L,8L,2L,262L,268L,7L,11L,14L,282L,292L,7L,310L,2L,316L,15L,9L,346L,8L,10L,358L,366L,4L,13L,10L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065437Inst : IEnumerable<long>
{
public static readonly long[] Value=A065437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065437.Bytes);
public long this[int i]=>Value[i];

public static A065437Inst Instance=new A065437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065438
{
public static readonly long[] Value={ 10L,21L,32L,43L,54L,65L,76L,87L,98L,109L,110L,121L,132L,143L,154L,165L,176L,187L,198L,209L,220L,221L,232L,243L,254L,265L,276L,287L,298L,309L,320L,331L,332L,343L,354L,365L,376L,387L,398L,409L,420L,431L,442L,443L,454L,465L,476L,487L,498L,509L,520L,531L,542L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065438Inst : IEnumerable<long>
{
public static readonly long[] Value=A065438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065438.Bytes);
public long this[int i]=>Value[i];

public static A065438Inst Instance=new A065438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065439
{
public static readonly long[] Value={ 12L,21L,1112L,1121L,1211L,2111L,1111111112L,1111111121L,1111111211L,1111112111L,1111121111L,1111211111L,1112111111L,1121111111L,1211111111L,2111111111L,1111111111111112L,1111111111111121L,1111111111111211L,1111111111112111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065439Inst : IEnumerable<long>
{
public static readonly long[] Value=A065439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065439.Bytes);
public long this[int i]=>Value[i];

public static A065439Inst Instance=new A065439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065440
{
public static readonly BigInteger[] Value={ 1L,0L,1L,8L,81L,1024L,15625L,279936L,5764801L,134217728L,3486784401L,100000000000L,3138428376721L,106993205379072L,3937376385699289L,155568095557812224L,6568408355712890625L,BigInteger.Parse("295147905179352825856") };
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
public class A065440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A065440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A065440Inst Instance=new A065440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065441
{
public static readonly long[] Value={ 1L,2L,3L,6L,10L,18L,27L,52L,88L,160L,260L,460L,812L,1450L,2583L,4428L,8044L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065441Inst : IEnumerable<long>
{
public static readonly long[] Value=A065441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065441.Bytes);
public long this[int i]=>Value[i];

public static A065441Inst Instance=new A065441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065442
{
public static readonly long[] Value={ 1L,6L,0L,6L,6L,9L,5L,1L,5L,2L,4L,1L,5L,2L,9L,1L,7L,6L,3L,7L,8L,3L,3L,0L,1L,5L,2L,3L,1L,9L,0L,9L,2L,4L,5L,8L,0L,4L,8L,0L,5L,7L,9L,6L,7L,1L,5L,0L,5L,7L,5L,6L,4L,3L,5L,7L,7L,8L,0L,7L,9L,5L,5L,3L,6L,9L,1L,4L,1L,8L,4L,2L,0L,7L,4L,3L,4L,8L,6L,6L,9L,0L,5L,6L,5L,7L,1L,1L,8L,0L,1L,6L,7L,0L,1L,5L,5L,5L,7L,5L,8L,9L,7L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065442Inst : IEnumerable<long>
{
public static readonly long[] Value=A065442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065442.Bytes);
public long this[int i]=>Value[i];

public static A065442Inst Instance=new A065442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065443
{
public static readonly long[] Value={ 1L,1L,3L,7L,3L,3L,8L,7L,3L,6L,3L,4L,4L,1L,9L,6L,5L,9L,6L,6L,9L,6L,9L,1L,3L,3L,6L,8L,3L,0L,1L,3L,4L,7L,5L,8L,3L,8L,3L,0L,8L,4L,9L,3L,0L,9L,8L,1L,3L,8L,8L,2L,8L,8L,2L,0L,7L,0L,4L,4L,9L,3L,3L,1L,0L,4L,6L,4L,9L,3L,8L,6L,2L,5L,2L,0L,4L,0L,8L,9L,9L,8L,0L,0L,0L,5L,4L,0L,5L,0L,9L,0L,4L,2L,3L,5L,1L,3L,1L,1L,8L,4L,0L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065443Inst : IEnumerable<long>
{
public static readonly long[] Value=A065443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065443.Bytes);
public long this[int i]=>Value[i];

public static A065443Inst Instance=new A065443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A065444
{
public static readonly long[] Value={ 1L,1L,0L,0L,9L,1L,8L,1L,9L,0L,8L,3L,6L,2L,0L,0L,7L,3L,6L,3L,7L,9L,8L,5L,5L,1L,0L,1L,6L,5L,4L,3L,8L,0L,0L,4L,3L,2L,0L,3L,4L,5L,4L,3L,9L,7L,8L,7L,3L,2L,8L,1L,6L,5L,6L,3L,5L,9L,8L,9L,0L,2L,2L,0L,7L,3L,4L,3L,8L,3L,4L,9L,0L,2L,1L,9L,8L,3L,4L,7L,4L,8L,8L,9L,2L,0L,0L,3L,4L,9L,2L,1L,8L,0L,0L,7L,0L,4L,0L,2L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A065444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A065444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A065444Inst : IEnumerable<long>
{
public static readonly long[] Value=A065444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A065444.Bytes);
public long this[int i]=>Value[i];

public static A065444Inst Instance=new A065444Inst();

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