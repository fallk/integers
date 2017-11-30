using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A286281
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L,5L,4L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286281Inst : IEnumerable<long>
{
public static readonly long[] Value=A286281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286281.Bytes);
public long this[int i]=>Value[i];

public static A286281Inst Instance=new A286281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286282
{
public static readonly BigInteger[] Value={ 1L,2L,5L,18L,79L,408L,2469L,17314L,138555L,1247052L,12470593L,137176614L,1646119479L,21399553360L,299593747197L,4493906208138L,71902499330419L,1222342488617364L,22002164795112825L,418041131107143982L,8360822622142879983L,BigInteger.Parse("175577275065000480024"),BigInteger.Parse("3862700051430010560949") };
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
public class A286282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286282Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286282.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286282Inst Instance=new A286282Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286283
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,3L,5L,7L,9L,11L,14L,17L,21L,24L,28L,32L,37L,42L,47L,52L,58L,64L,70L,77L,84L,91L,98L,106L,114L,122L,131L,140L,149L,158L,168L,178L,189L,199L,210L,221L,233L,245L,257L,269L,282L,295L,308L,322L,336L,350L,364L,379L,394L,409L,425L,441L,457L,473L,490L,507L,525L,542L,560L,578L,597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286283Inst : IEnumerable<long>
{
public static readonly long[] Value=A286283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286283.Bytes);
public long this[int i]=>Value[i];

public static A286283Inst Instance=new A286283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286284
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,20L,82L,565L,5688L,102039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286284Inst : IEnumerable<long>
{
public static readonly long[] Value=A286284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286284.Bytes);
public long this[int i]=>Value[i];

public static A286284Inst Instance=new A286284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286285
{
public static readonly long[] Value={ 1L,1L,1L,2L,5L,20L,82L,565L,5688L,102039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286285Inst : IEnumerable<long>
{
public static readonly long[] Value=A286285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286285.Bytes);
public long this[int i]=>Value[i];

public static A286285Inst Instance=new A286285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286286
{
public static readonly BigInteger[] Value={ 0L,1L,4L,21L,148L,1333L,14664L,190633L,2859496L,48611433L,923617228L,19395961789L,446107121148L,11152678028701L,301122306774928L,8732546896472913L,270708953790660304L,8933395475091790033L,BigInteger.Parse("312668841628212651156"),BigInteger.Parse("11568747140243868092773") };
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
public class A286286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286286Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286286.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286286Inst Instance=new A286286Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286287
{
public static readonly long[] Value={ 106L,11L,13L,7L,512L,1L,1941L,141L,6847L,211L,195031L,82321L,808083L,534077L,3355906L,526093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286287Inst : IEnumerable<long>
{
public static readonly long[] Value=A286287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286287.Bytes);
public long this[int i]=>Value[i];

public static A286287Inst Instance=new A286287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286288
{
public static readonly long[] Value={ 46L,5L,43L,1L,2021L,121L,25202L,2521L,162121L,460801L,27268546L,23553169L,244068841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286288Inst : IEnumerable<long>
{
public static readonly long[] Value=A286288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286288.Bytes);
public long this[int i]=>Value[i];

public static A286288Inst Instance=new A286288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286289
{
public static readonly long[] Value={ 314L,6L,315L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286289Inst : IEnumerable<long>
{
public static readonly long[] Value=A286289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286289.Bytes);
public long this[int i]=>Value[i];

public static A286289Inst Instance=new A286289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286290
{
public static readonly long[] Value={ 1L,6L,12L,20L,35L,56L,72L,90L,110L,143L,182L,210L,240L,272L,306L,342L,399L,462L,506L,552L,600L,650L,702L,756L,812L,870L,930L,992L,1056L,1122L,1224L,1332L,1406L,1482L,1560L,1640L,1722L,1806L,1892L,1980L,2070L,2162L,2256L,2352L,2450L,2550L,2652L,2756L,2862L,2970L,3135L,3306L,3422L,3540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286290Inst : IEnumerable<long>
{
public static readonly long[] Value=A286290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286290.Bytes);
public long this[int i]=>Value[i];

public static A286290Inst Instance=new A286290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286291
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,15L,16L,17L,18L,19L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286291Inst : IEnumerable<long>
{
public static readonly long[] Value=A286291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286291.Bytes);
public long this[int i]=>Value[i];

public static A286291Inst Instance=new A286291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286292
{
public static readonly long[] Value={ 3L,4L,6L,13L,19L,14L,16L,18L,31L,37L,26L,28L,30L,32L,34L,55L,61L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,64L,100L,106L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,106L,163L,169L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286292Inst : IEnumerable<long>
{
public static readonly long[] Value=A286292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286292.Bytes);
public long this[int i]=>Value[i];

public static A286292Inst Instance=new A286292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286293
{
public static readonly long[] Value={ 1L,2L,4L,11L,17L,12L,14L,16L,29L,35L,24L,26L,28L,30L,32L,53L,59L,40L,42L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,98L,104L,70L,72L,74L,76L,78L,80L,82L,84L,86L,88L,90L,92L,94L,96L,98L,100L,102L,104L,161L,167L,112L,114L,116L,118L,120L,122L,124L,126L,128L,130L,132L,134L,136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286293Inst : IEnumerable<long>
{
public static readonly long[] Value=A286293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286293.Bytes);
public long this[int i]=>Value[i];

public static A286293Inst Instance=new A286293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286294
{
public static readonly long[] Value={ 0L,1L,3L,2L,5L,4L,6L,8L,7L,11L,9L,10L,12L,13L,15L,14L,16L,18L,17L,19L,20L,22L,21L,23L,25L,24L,27L,26L,28L,29L,31L,30L,32L,33L,35L,34L,36L,38L,37L,40L,39L,41L,44L,42L,43L,45L,46L,47L,49L,48L,50L,51L,53L,52L,54L,55L,57L,56L,58L,60L,59L,62L,61L,64L,65L,63L,66L,68L,67L,70L,71L,69L,72L,73L,75L,74L,76L,77L,78L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286294Inst : IEnumerable<long>
{
public static readonly long[] Value=A286294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286294.Bytes);
public long this[int i]=>Value[i];

public static A286294Inst Instance=new A286294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286311
{
public static readonly long[] Value={ 0L,1L,1L,3L,5L,8L,12L,19L,31L,51L,83L,134L,216L,349L,565L,915L,1481L,2396L,3876L,6271L,10147L,16419L,26567L,42986L,69552L,112537L,182089L,294627L,476717L,771344L,1248060L,2019403L,3267463L,5286867L,8554331L,13841198L,22395528L,36236725L,58632253L,94868979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286311Inst : IEnumerable<long>
{
public static readonly long[] Value=A286311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286311.Bytes);
public long this[int i]=>Value[i];

public static A286311Inst Instance=new A286311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286312
{
public static readonly long[] Value={ 1L,2L,1L,3L,3L,1L,4L,5L,3L,1L,5L,7L,6L,5L,1L,6L,9L,9L,6L,6L,1L,7L,11L,12L,10L,7L,7L,1L,8L,13L,15L,14L,10L,7L,8L,1L,9L,15L,18L,18L,15L,11L,7L,9L,1L,10L,17L,21L,22L,20L,15L,12L,17L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286312Inst : IEnumerable<long>
{
public static readonly long[] Value=A286312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286312.Bytes);
public long this[int i]=>Value[i];

public static A286312Inst Instance=new A286312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286313
{
public static readonly long[] Value={ 19L,31L,43L,61L,73L,79L,127L,157L,163L,229L,271L,349L,373L,379L,433L,439L,499L,607L,643L,673L,733L,751L,937L,967L,1009L,1093L,1213L,1279L,1291L,1429L,1489L,1543L,1549L,1597L,1609L,1657L,1777L,1861L,1987L,2131L,2203L,2287L,2341L,2347L,2371L,2383L,2389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286313Inst : IEnumerable<long>
{
public static readonly long[] Value=A286313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286313.Bytes);
public long this[int i]=>Value[i];

public static A286313Inst Instance=new A286313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286314
{
public static readonly BigInteger[] Value={ 6L,231L,20400L,2003001L,200045352L,20000567352L,1959085094400L,200000030000001L,20118337236261000L,1999999999505541852L,BigInteger.Parse("200000000030000000001"),BigInteger.Parse("19994255180823548693100"),BigInteger.Parse("1959183673472326530612252"),BigInteger.Parse("200000000000105810631542400"),BigInteger.Parse("20118343160415860069040000000") };
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
public class A286314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286314Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286314.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286314Inst Instance=new A286314Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286315
{
public static readonly BigInteger[] Value={ 8L,1332L,1030302L,1007141184L,1000302990372L,1000781337641904L,1000003970597090004L,BigInteger.Parse("1000751615026326041904"),BigInteger.Parse("1000203571630368710405892"),BigInteger.Parse("1004272191614371538730009600"),BigInteger.Parse("1000000970912716777250166728808"),BigInteger.Parse("1000834130646589459517111102258880") };
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
public class A286315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286315Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286315.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286315Inst Instance=new A286315Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286316
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,3L,4L,5L,6L,8L,9L,11L,13L,15L,17L,20L,22L,25L,28L,32L,35L,40L,44L,50L,56L,63L,70L,80L,89L,101L,113L,128L,143L,162L,181L,204L,228L,256L,285L,320L,355L,396L,439L,489L,540L,599L,660L,730L,803L,886L,972L,1070L,1172L,1287L,1408L,1544L,1686L,1846L,2014L,2202L,2400L,2621L,2854L,3114L,3389L,3693L,4016L,4374L,4753L,5172L,5617L,6107L,6628L,7201L,7810L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286316Inst : IEnumerable<long>
{
public static readonly long[] Value=A286316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286316.Bytes);
public long this[int i]=>Value[i];

public static A286316Inst Instance=new A286316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286317
{
public static readonly long[] Value={ 1L,2L,5L,18L,59L,306L,1861L,15097L,146893L,1693416L,22239872L,327670703L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286317Inst : IEnumerable<long>
{
public static readonly long[] Value=A286317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286317.Bytes);
public long this[int i]=>Value[i];

public static A286317Inst Instance=new A286317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286318
{
public static readonly long[] Value={ 1L,1L,3L,11L,36L,213L,1405L,12274L,125235L,1490851L,20003121L,299274006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286318Inst : IEnumerable<long>
{
public static readonly long[] Value=A286318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286318.Bytes);
public long this[int i]=>Value[i];

public static A286318Inst Instance=new A286318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286319
{
public static readonly long[] Value={ 2L,3L,5L,7L,41L,59L,67L,89L,101L,131L,139L,379L,457L,743L,761L,1193L,1201L,1381L,1549L,1567L,1747L,1789L,2137L,2411L,2557L,2647L,2663L,2729L,2731L,3011L,3221L,3251L,3449L,4057L,4159L,4447L,4561L,4751L,5179L,5641L,6173L,6397L,6599L,6833L,7229L,8669L,9059L,9157L,9323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286319Inst : IEnumerable<long>
{
public static readonly long[] Value=A286319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286319.Bytes);
public long this[int i]=>Value[i];

public static A286319Inst Instance=new A286319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286320
{
public static readonly long[] Value={ 1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,2L,1L,0L,1L,3L,2L,1L,2L,3L,2L,1L,2L,3L,3L,2L,4L,5L,3L,2L,4L,5L,3L,2L,4L,6L,4L,2L,4L,7L,5L,2L,5L,8L,5L,2L,5L,8L,6L,3L,5L,10L,8L,4L,6L,10L,8L,4L,6L,10L,9L,5L,8L,12L,10L,6L,9L,13L,10L,6L,9L,15L,12L,7L,10L,17L,14L,7L,11L,18L,15L,8L,11L,18L,16L,9L,11L,20L,18L,10L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286320Inst : IEnumerable<long>
{
public static readonly long[] Value=A286320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286320.Bytes);
public long this[int i]=>Value[i];

public static A286320Inst Instance=new A286320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286321
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,4L,2L,1L,3L,4L,2L,6L,1L,3L,6L,4L,4L,2L,6L,5L,1L,8L,3L,9L,10L,4L,12L,4L,2L,15L,6L,9L,5L,1L,10L,8L,3L,6L,9L,20L,10L,4L,7L,12L,4L,12L,2L,8L,15L,6L,14L,16L,5L,18L,1L,16L,20L,8L,18L,3L,6L,19L,9L,24L,20L,10L,28L,4L,7L,30L,12L,32L,4L,12L,35L,2L,8L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286321Inst : IEnumerable<long>
{
public static readonly long[] Value=A286321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286321.Bytes);
public long this[int i]=>Value[i];

public static A286321Inst Instance=new A286321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286322
{
public static readonly long[] Value={ 4L,9L,221L,289L,697L,1819L,2329L,4369L,4913L,6439L,18769L,21331L,35209L,66049L,128881L,184783L,197143L,258121L,281929L,516961L,739903L,971203L,1762249L,1942663L,2070721L,2898703L,2952673L,3820819L,4142881L,5550943L,5869681L,8288641L,16230481L,16773619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286322Inst : IEnumerable<long>
{
public static readonly long[] Value=A286322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286322.Bytes);
public long this[int i]=>Value[i];

public static A286322Inst Instance=new A286322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286323
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,10L,12L,13L,15L,17L,18L,20L,21L,23L,24L,26L,27L,29L,30L,32L,34L,35L,37L,38L,40L,41L,43L,44L,46L,47L,49L,51L,52L,54L,55L,57L,58L,60L,61L,63L,64L,66L,68L,69L,71L,72L,74L,75L,77L,78L,80L,81L,83L,85L,86L,88L,89L,91L,92L,94L,95L,97L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286323Inst : IEnumerable<long>
{
public static readonly long[] Value=A286323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286323.Bytes);
public long this[int i]=>Value[i];

public static A286323Inst Instance=new A286323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286324
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,4L,2L,4L,2L,4L,2L,4L,2L,4L,4L,4L,2L,4L,2L,4L,4L,4L,2L,8L,2L,4L,4L,4L,2L,8L,2L,6L,4L,4L,4L,4L,2L,4L,4L,8L,2L,8L,2L,4L,4L,4L,2L,8L,2L,4L,4L,4L,2L,8L,4L,8L,4L,4L,2L,8L,2L,4L,4L,6L,4L,8L,2L,4L,4L,8L,2L,8L,2L,4L,4L,4L,4L,8L,2L,8L,4L,4L,2L,8L,4L,4L,4L,8L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286324Inst : IEnumerable<long>
{
public static readonly long[] Value=A286324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286324.Bytes);
public long this[int i]=>Value[i];

public static A286324Inst Instance=new A286324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286325
{
public static readonly long[] Value={ 1L,6L,45L,60L,90L,270L,420L,630L,672L,2970L,5460L,8190L,9072L,9100L,10080L,15925L,22680L,22848L,27300L,30240L,40950L,45360L,54600L,81900L,95550L,99792L,136500L,163800L,172900L,204750L,208656L,245700L,249480L,312480L,332640L,342720L,385560L,409500L,472500L,491400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286325Inst : IEnumerable<long>
{
public static readonly long[] Value=A286325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286325.Bytes);
public long this[int i]=>Value[i];

public static A286325Inst Instance=new A286325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286326
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,2L,1L,3L,2L,2L,3L,1L,3L,3L,2L,4L,2L,3L,4L,1L,4L,3L,3L,5L,2L,4L,4L,2L,5L,3L,4L,5L,1L,5L,4L,3L,6L,3L,5L,5L,2L,6L,4L,4L,6L,2L,6L,5L,3L,7L,4L,5L,6L,1L,7L,5L,4L,7L,3L,6L,6L,3L,8L,5L,5L,7L,2L,7L,6L,4L,8L,4L,6L,7L,2L,8L,6L,5L,8L,3L,7L,7L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286326Inst : IEnumerable<long>
{
public static readonly long[] Value=A286326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286326.Bytes);
public long this[int i]=>Value[i];

public static A286326Inst Instance=new A286326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286359
{
public static readonly long[] Value={ 4L,39L,109L,217L,259L,753L,473L,1005L,1288L,1729L,1093L,3769L,1499L,3105L,4489L,4309L,2503L,8295L,3101L,8557L,8033L,7057L,4489L,16713L,7534L,9633L,12601L,15281L,7051L,28513L,8033L,17829L,18193L,15985L,18193L,40561L,11363L,19761L,24809L,37765L,13903L,50817L,15269L,34537L,48283L,28513L,18193L,70249L,25708L,47679L,41113L,47069L,23059L,79521L,41113L,67281L,50801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286359Inst : IEnumerable<long>
{
public static readonly long[] Value=A286359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286359.Bytes);
public long this[int i]=>Value[i];

public static A286359Inst Instance=new A286359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286360
{
public static readonly long[] Value={ 1L,8L,12L,49L,23L,142L,38L,239L,124L,259L,80L,753L,107L,412L,412L,1051L,173L,1237L,212L,1390L,672L,826L,302L,3427L,565L,1087L,1089L,2223L,467L,5080L,530L,4403L,1384L,1717L,1384L,7911L,743L,2086L,1836L,6352L,905L,7780L,992L,4477L,3928L,2932L,1178L,14583L,1774L,5368L,2932L,5898L,1487L,10177L,2932L,10177L,3576L,4471L,1832L,25711L,1955L,5056L,6567L,18019L,3922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286360Inst : IEnumerable<long>
{
public static readonly long[] Value=A286360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286360.Bytes);
public long this[int i]=>Value[i];

public static A286360Inst Instance=new A286360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286361
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,1L,1L,1L,4L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,1L,1L,1L,4L,2L,2L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,1L,6L,1L,1L,2L,1L,2L,1L,1L,2L,2L,4L,1L,1L,2L,1L,2L,1L,2L,1L,1L,6L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,4L,2L,2L,1L,2L,2L,2L,1L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286361Inst : IEnumerable<long>
{
public static readonly long[] Value=A286361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286361.Bytes);
public long this[int i]=>Value[i];

public static A286361Inst Instance=new A286361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286362
{
public static readonly long[] Value={ 1L,2L,5L,7L,2L,23L,9L,29L,7L,16L,5L,80L,2L,31L,40L,121L,2L,67L,5L,67L,16L,23L,9L,302L,7L,16L,38L,94L,2L,532L,20L,497L,16L,16L,23L,631L,2L,23L,31L,277L,2L,436L,5L,80L,67L,31L,14L,1178L,7L,67L,23L,67L,2L,302L,31L,328L,16L,16L,5L,1957L,2L,50L,142L,2017L,16L,436L,5L,67L,16L,467L,9L,2557L,2L,16L,80L,80L,16L,499L,14L,1129L,121L,16L,5L,1771L,16L,23L,31L,302L,2L,1771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286362Inst : IEnumerable<long>
{
public static readonly long[] Value=A286362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286362.Bytes);
public long this[int i]=>Value[i];

public static A286362Inst Instance=new A286362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286363
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,2L,2L,1L,4L,1L,2L,2L,1L,2L,2L,1L,1L,4L,2L,1L,6L,2L,2L,2L,1L,1L,8L,2L,1L,2L,2L,1L,6L,1L,2L,4L,1L,2L,2L,1L,1L,6L,2L,2L,4L,2L,2L,2L,4L,1L,2L,1L,1L,8L,2L,2L,6L,1L,2L,2L,1L,2L,12L,1L,1L,6L,2L,1L,6L,2L,2L,4L,1L,1L,2L,2L,6L,2L,2L,1L,16L,1L,2L,6L,1L,2L,2L,2L,1L,4L,2L,2L,6L,2L,2L,2L,1L,4L,12L,1L,1L,2L,2L,1L,6L,1L,2L,8L,1L,2L,2L,2L,1L,6L,2L,1L,4L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286363Inst : IEnumerable<long>
{
public static readonly long[] Value=A286363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286363.Bytes);
public long this[int i]=>Value[i];

public static A286363Inst Instance=new A286363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286364
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,2L,1L,7L,3L,2L,2L,3L,2L,5L,1L,3L,7L,2L,3L,16L,2L,2L,2L,10L,3L,29L,2L,3L,5L,2L,1L,16L,3L,5L,7L,3L,2L,5L,3L,3L,16L,2L,2L,12L,2L,2L,2L,7L,10L,5L,3L,3L,29L,5L,2L,16L,3L,2L,5L,3L,2L,67L,1L,21L,16L,2L,3L,16L,5L,2L,7L,3L,3L,14L,2L,16L,5L,2L,3L,121L,3L,2L,16L,21L,2L,5L,2L,3L,12L,5L,2L,16L,2L,5L,2L,3L,7L,67L,10L,3L,5L,2L,3L,23L,3L,2L,29L,3L,5L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286364Inst : IEnumerable<long>
{
public static readonly long[] Value=A286364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286364.Bytes);
public long this[int i]=>Value[i];

public static A286364Inst Instance=new A286364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286365
{
public static readonly long[] Value={ 2L,3L,4L,2L,6L,5L,4L,3L,14L,7L,4L,4L,6L,5L,10L,2L,6L,15L,4L,6L,32L,5L,4L,5L,20L,7L,58L,4L,6L,11L,4L,3L,32L,7L,10L,14L,6L,5L,10L,7L,6L,33L,4L,4L,24L,5L,4L,4L,14L,21L,10L,6L,6L,59L,10L,5L,32L,7L,4L,10L,6L,5L,134L,2L,42L,33L,4L,6L,32L,11L,4L,15L,6L,7L,28L,4L,32L,11L,4L,6L,242L,7L,4L,32L,42L,5L,10L,5L,6L,25L,10L,4L,32L,5L,10L,5L,6L,15L,134L,20L,6L,11L,4L,7L,46L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286365Inst : IEnumerable<long>
{
public static readonly long[] Value=A286365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286365.Bytes);
public long this[int i]=>Value[i];

public static A286365Inst Instance=new A286365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286366
{
public static readonly long[] Value={ 4L,6L,8L,4L,13L,11L,9L,6L,28L,14L,8L,8L,13L,11L,21L,4L,12L,30L,8L,13L,65L,11L,9L,11L,40L,14L,116L,9L,13L,23L,9L,6L,64L,14L,20L,28L,13L,11L,21L,14L,12L,66L,8L,8L,49L,11L,9L,8L,28L,42L,20L,13L,13L,119L,21L,11L,64L,14L,8L,21L,13L,11L,269L,4L,84L,66L,8L,12L,65L,23L,9L,30L,12L,14L,56L,8L,65L,23L,9L,13L,484L,14L,8L,65L,85L,11L,21L,11L,12L,50L,20L,9L,65L,11L,21L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286366Inst : IEnumerable<long>
{
public static readonly long[] Value=A286366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286366.Bytes);
public long this[int i]=>Value[i];

public static A286366Inst Instance=new A286366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286367
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,2L,10L,22L,8L,2L,9L,4L,5L,11L,15L,4L,30L,2L,13L,121L,5L,2L,14L,46L,8L,407L,9L,4L,17L,2L,21L,121L,8L,11L,39L,4L,5L,11L,19L,4L,138L,2L,9L,67L,5L,2L,20L,22L,57L,11L,13L,4L,437L,11L,14L,121L,8L,2L,24L,4L,5L,2212L,28L,211L,138L,2L,13L,121L,17L,2L,49L,4L,8L,92L,9L,121L,17L,2L,26L,7261L,8L,2L,156L,211L,5L,11L,14L,4L,80L,11L,9L,121L,5L,11L,27L,4L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286367Inst : IEnumerable<long>
{
public static readonly long[] Value=A286367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286367.Bytes);
public long this[int i]=>Value[i];

public static A286367Inst Instance=new A286367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286368
{
public static readonly long[] Value={ 3L,2L,0L,3L,2L,0L,4L,2L,3L,2L,0L,0L,2L,0L,4L,3L,2L,2L,0L,2L,0L,0L,4L,0L,3L,2L,0L,4L,2L,0L,4L,2L,0L,2L,0L,3L,2L,0L,4L,2L,2L,0L,0L,0L,2L,0L,4L,0L,3L,2L,0L,2L,2L,0L,4L,0L,0L,2L,0L,4L,2L,0L,4L,3L,2L,0L,0L,2L,0L,0L,4L,2L,2L,2L,0L,0L,0L,0L,4L,2L,3L,2L,0L,0L,2L,0L,4L,0L,2L,2L,0L,4L,0L,0L,4L,0L,2L,2L,0L,3L,2L,0L,4L,2L,0L,2L,0L,0L,2L,0L,4L,4L,2L,0L,0L,2L,2L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286368Inst : IEnumerable<long>
{
public static readonly long[] Value=A286368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286368.Bytes);
public long this[int i]=>Value[i];

public static A286368Inst Instance=new A286368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286369
{
public static readonly long[] Value={ 2L,2L,4L,2L,7L,5L,5L,2L,14L,6L,4L,4L,7L,5L,11L,2L,6L,14L,4L,7L,33L,5L,5L,5L,20L,6L,58L,5L,7L,11L,5L,2L,32L,6L,10L,14L,7L,5L,11L,6L,6L,32L,4L,4L,25L,5L,5L,4L,14L,20L,10L,7L,7L,59L,11L,5L,32L,6L,4L,11L,7L,5L,135L,2L,42L,32L,4L,6L,33L,11L,5L,14L,6L,6L,28L,4L,33L,11L,5L,7L,242L,6L,4L,33L,43L,5L,11L,5L,6L,24L,10L,5L,33L,5L,11L,5L,6L,14L,134L,20L,7L,11L,5L,6L,46L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286369Inst : IEnumerable<long>
{
public static readonly long[] Value=A286369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286369.Bytes);
public long this[int i]=>Value[i];

public static A286369Inst Instance=new A286369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286370
{
public static readonly long[] Value={ 2L,2L,7L,2L,2L,4L,4L,2L,5L,7L,6L,4L,7L,5L,5L,2L,7L,14L,7L,7L,2L,4L,10L,4L,4L,7L,6L,5L,4L,11L,5L,2L,20L,6L,7L,14L,5L,4L,4L,7L,5L,33L,42L,4L,6L,5L,5L,4L,7L,20L,33L,7L,7L,58L,4L,5L,4L,7L,6L,11L,5L,5L,11L,2L,14L,32L,7L,6L,7L,10L,4L,14L,11L,7L,6L,4L,7L,11L,11L,7L,7L,6L,73L,33L,2L,4L,4L,4L,4L,25L,6L,5L,10L,5L,11L,4L,6L,14L,7L,20L,4L,10L,10L,7L,5L,7L,32L,58L,6L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286370Inst : IEnumerable<long>
{
public static readonly long[] Value=A286370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286370.Bytes);
public long this[int i]=>Value[i];

public static A286370Inst Instance=new A286370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286371
{
public static readonly long[] Value={ 2L,4L,7L,14L,5L,11L,4L,58L,20L,33L,7L,25L,6L,32L,10L,242L,4L,28L,5L,135L,11L,11L,7L,77L,14L,10L,73L,134L,5L,46L,7L,994L,42L,32L,33L,50L,6L,33L,43L,555L,4L,47L,5L,25L,29L,11L,7L,277L,14L,134L,11L,24L,4L,89L,10L,554L,10L,33L,7L,160L,4L,11L,28L,4034L,11L,54L,5L,134L,42L,873L,6L,118L,5L,10L,25L,135L,11L,55L,4L,2259L,272L,32L,6L,161L,33L,33L,10L,77L,6L,81L,10L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286371Inst : IEnumerable<long>
{
public static readonly long[] Value=A286371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286371.Bytes);
public long this[int i]=>Value[i];

public static A286371Inst Instance=new A286371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286372
{
public static readonly long[] Value={ 4L,6L,8L,13L,4L,9L,8L,11L,13L,12L,14L,8L,28L,6L,9L,13L,11L,21L,9L,11L,13L,12L,8L,8L,40L,14L,9L,65L,14L,13L,8L,13L,64L,13L,11L,8L,9L,30L,20L,12L,4L,9L,21L,11L,8L,21L,14L,20L,12L,9L,12L,13L,23L,9L,8L,11L,13L,64L,8L,84L,28L,14L,116L,12L,14L,9L,85L,11L,8L,12L,11L,65L,65L,42L,8L,13L,13L,21L,9L,11L,21L,13L,66L,8L,28L,12L,9L,49L,14L,13L,8L,11L,65L,20L,14L,13L,9L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286372Inst : IEnumerable<long>
{
public static readonly long[] Value=A286372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286372.Bytes);
public long this[int i]=>Value[i];

public static A286372Inst Instance=new A286372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286373
{
public static readonly long[] Value={ 4L,6L,8L,13L,4L,6L,11L,11L,13L,8L,9L,9L,28L,12L,30L,12L,14L,11L,8L,6L,9L,13L,21L,12L,40L,14L,269L,42L,4L,13L,8L,14L,64L,13L,21L,12L,65L,20L,8L,21L,11L,8L,11L,8L,11L,8L,116L,20L,13L,14L,8L,65L,23L,9L,11L,13L,14L,9L,9L,11L,14L,11L,66L,85L,21L,30L,28L,11L,12L,13L,13L,42L,14L,11L,20L,14L,30L,6L,66L,9L,12L,84L,49L,11L,8L,9L,23L,8L,28L,9L,11L,8L,65L,13L,484L,11L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286373Inst : IEnumerable<long>
{
public static readonly long[] Value=A286373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286373.Bytes);
public long this[int i]=>Value[i];

public static A286373Inst Instance=new A286373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286374
{
public static readonly long[] Value={ 1L,2L,2L,6L,2L,12L,6L,12L,2L,30L,12L,48L,6L,210L,12L,24L,2L,30L,30L,420L,12L,360L,48L,30L,6L,120L,210L,1260L,12L,420L,24L,48L,2L,30L,30L,420L,30L,4620L,420L,480L,12L,420L,360L,1080L,48L,960L,30L,210L,6L,420L,120L,2310L,210L,3360L,1260L,1680L,12L,1260L,420L,6300L,24L,840L,48L,96L,2L,30L,30L,420L,30L,4620L,420L,2520L,30L,4620L,4620L,6720L,420L,9240L,480L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286374Inst : IEnumerable<long>
{
public static readonly long[] Value=A286374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286374.Bytes);
public long this[int i]=>Value[i];

public static A286374Inst Instance=new A286374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286423
{
public static readonly BigInteger[] Value={ 2L,7L,130L,4207L,1166928L,541240697L,2907639077764L,25886034363696809L,BigInteger.Parse("3341096345926174809912"),BigInteger.Parse("713738790204487208874991935"),BigInteger.Parse("2645105778378736719464340469683304"),BigInteger.Parse("16238808907214611705432043192158547965751") };
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
public class A286423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286423Inst Instance=new A286423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286424
{
public static readonly long[] Value={ 0L,0L,1L,1L,4L,110L,1432L,23338L,397661L,8193828L,212858328L,5941706227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286424Inst : IEnumerable<long>
{
public static readonly long[] Value=A286424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286424.Bytes);
public long this[int i]=>Value[i];

public static A286424Inst Instance=new A286424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286425
{
public static readonly long[] Value={ 1L,2L,8L,44L,285L,2028L,15338L,120960L,983108L,8172094L,69116592L,592590616L,5136777504L,44928712804L,395907022448L,3510622573064L,31296093794827L,280275392413204L,2520017580255461L,22736733105613548L,205767848345966976L,1867240544055742660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286425Inst : IEnumerable<long>
{
public static readonly long[] Value=A286425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286425.Bytes);
public long this[int i]=>Value[i];

public static A286425Inst Instance=new A286425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286426
{
public static readonly long[] Value={ 0L,1L,2L,6L,20L,23L,86L,146L,167L,340L,472L,500L,898L,907L,936L,1133L,2069L,3166L,4207L,5275L,9700L,20407L,28009L,32923L,53264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286426Inst : IEnumerable<long>
{
public static readonly long[] Value=A286426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286426.Bytes);
public long this[int i]=>Value[i];

public static A286426Inst Instance=new A286426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286427
{
public static readonly long[] Value={ 1L,0L,3L,5L,24L,78L,325L,1272L,5373L,22572L,97762L,425716L,1882062L,8375064L,37601643L,169773435L,771096972L,3518065767L,16119884297L,74125225732L,341970676466L,1582133854847L,7338641255894L,34117910537671L,158946919835352L,741884929970516L,3468677541274922L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286427Inst : IEnumerable<long>
{
public static readonly long[] Value=A286427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286427.Bytes);
public long this[int i]=>Value[i];

public static A286427Inst Instance=new A286427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286428
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,25L,26L,28L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,52L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,68L,70L,71L,73L,74L,75L,77L,78L,80L,81L,82L,84L,85L,87L,88L,89L,91L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286428Inst : IEnumerable<long>
{
public static readonly long[] Value=A286428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286428.Bytes);
public long this[int i]=>Value[i];

public static A286428Inst Instance=new A286428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286429
{
public static readonly long[] Value={ 0L,0L,0L,0L,16L,27L,40L,55L,72L,91L,112L,135L,160L,187L,216L,247L,280L,315L,352L,391L,432L,475L,520L,567L,616L,667L,720L,775L,832L,891L,952L,1015L,1080L,1147L,1216L,1287L,1360L,1435L,1512L,1591L,1672L,1755L,1840L,1927L,2016L,2107L,2200L,2295L,2392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286429Inst : IEnumerable<long>
{
public static readonly long[] Value=A286429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286429.Bytes);
public long this[int i]=>Value[i];

public static A286429Inst Instance=new A286429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286430
{
public static readonly long[] Value={ 0L,0L,0L,0L,36L,78L,136L,210L,300L,406L,528L,666L,820L,990L,1176L,1378L,1596L,1830L,2080L,2346L,2628L,2926L,3240L,3570L,3916L,4278L,4656L,5050L,5460L,5886L,6328L,6786L,7260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286430Inst : IEnumerable<long>
{
public static readonly long[] Value=A286430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286430.Bytes);
public long this[int i]=>Value[i];

public static A286430Inst Instance=new A286430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286431
{
public static readonly long[] Value={ 2L,3L,4L,5L,8L,9L,16L,17L,18L,36L,54L,69L,183L,200L,240L,846L,1424L,2511L,4750L,13854L,15414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286431Inst : IEnumerable<long>
{
public static readonly long[] Value=A286431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286431.Bytes);
public long this[int i]=>Value[i];

public static A286431Inst Instance=new A286431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286432
{
public static readonly BigInteger[] Value={ 0L,1L,12L,151L,2545L,54466L,1417318L,43472780L,1536228588L,61466251616L,2746907348768L,135619260805568L,7331022129923648L,430638151053316480L,BigInteger.Parse("27315015477709844352"),BigInteger.Parse("1860627613021322933248"),BigInteger.Parse("135465573609158928964096"),BigInteger.Parse("10498038569346091127451136"),BigInteger.Parse("862792664850194915870874112") };
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
public class A286432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286432Inst Instance=new A286432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286433
{
public static readonly long[] Value={ 1L,6L,25L,98L,399L,1746L,8271L,42284L,231939L,1357128L,8427181L,55288860L,381798629L,2765917074L,20960284277L,165729739590L,1364153612299L,11665484410094L,103448316470723L,949739632313480L,9013431476894623L,88304011710168668L,891917738589610553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286433Inst : IEnumerable<long>
{
public static readonly long[] Value=A286433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286433.Bytes);
public long this[int i]=>Value[i];

public static A286433Inst Instance=new A286433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286434
{
public static readonly long[] Value={ 2L,3L,6L,9L,10L,14L,15L,34L,56L,138L,250L,350L,357L,374L,392L,1594L,4794L,5290L,6702L,11936L,22296L,55762L,55834L,96195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286434Inst : IEnumerable<long>
{
public static readonly long[] Value=A286434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286434.Bytes);
public long this[int i]=>Value[i];

public static A286434Inst Instance=new A286434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286435
{
public static readonly long[] Value={ 2L,3L,6L,9L,27L,48L,60L,74L,161L,242L,269L,518L,1092L,1220L,1883L,2618L,3266L,6699L,8855L,17022L,17454L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286435Inst : IEnumerable<long>
{
public static readonly long[] Value=A286435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286435.Bytes);
public long this[int i]=>Value[i];

public static A286435Inst Instance=new A286435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286436
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,7L,9L,4L,1L,1L,13L,48L,63L,25L,1L,21L,153L,494L,747L,546L,219L,57L,9L,1L,1L,31L,372L,2247L,7459L,14064L,15160L,9233L,3069L,480L,14L,1L,43L,765L,7396L,42983L,157248L,369787L,563287L,556932L,358974L,153520L,45282L,9634L,1529L,186L,16L,1L,1L,57L,1404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286436Inst : IEnumerable<long>
{
public static readonly long[] Value=A286436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286436.Bytes);
public long this[int i]=>Value[i];

public static A286436Inst Instance=new A286436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286437
{
public static readonly long[] Value={ 0L,9L,48L,153L,372L,765L,1404L,2373L,3768L,5697L,8280L,11649L,15948L,21333L,27972L,36045L,45744L,57273L,70848L,86697L,105060L,126189L,150348L,177813L,208872L,243825L,282984L,326673L,375228L,428997L,488340L,553629L,625248L,703593L,789072L,882105L,983124L,1092573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286437Inst : IEnumerable<long>
{
public static readonly long[] Value=A286437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286437.Bytes);
public long this[int i]=>Value[i];

public static A286437Inst Instance=new A286437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286438
{
public static readonly long[] Value={ 0L,4L,63L,494L,2247L,7396L,19739L,45518L,94259L,179732L,321031L,543774L,881423L,1376724L,2083267L,3067166L,4408859L,6205028L,8570639L,11641102L,15574551L,20554244L,26791083L,34526254L,44033987L,55624436L,69646679L,86491838L,106596319L,130445172L,158575571L,191580414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286438Inst : IEnumerable<long>
{
public static readonly long[] Value=A286438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286438.Bytes);
public long this[int i]=>Value[i];

public static A286438Inst Instance=new A286438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286487
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286487Inst : IEnumerable<long>
{
public static readonly long[] Value=A286487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286487.Bytes);
public long this[int i]=>Value[i];

public static A286487Inst Instance=new A286487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286488
{
public static readonly long[] Value={ 1L,4L,6L,7L,13L,18L,19L,22L,24L,25L,31L,32L,35L,40L,42L,43L,49L,54L,55L,58L,63L,65L,66L,72L,73L,76L,78L,79L,85L,90L,91L,94L,96L,97L,103L,104L,107L,112L,114L,115L,121L,122L,125L,127L,128L,134L,139L,140L,143L,148L,150L,151L,157L,162L,163L,166L,168L,169L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286488Inst : IEnumerable<long>
{
public static readonly long[] Value=A286488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286488.Bytes);
public long this[int i]=>Value[i];

public static A286488Inst Instance=new A286488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286489
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,10L,11L,12L,14L,15L,16L,17L,20L,21L,23L,26L,27L,28L,29L,30L,33L,34L,36L,37L,38L,39L,41L,44L,45L,46L,47L,48L,50L,51L,52L,53L,56L,57L,59L,60L,61L,62L,64L,67L,68L,69L,70L,71L,74L,75L,77L,80L,81L,82L,83L,84L,86L,87L,88L,89L,92L,93L,95L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286489Inst : IEnumerable<long>
{
public static readonly long[] Value=A286489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286489.Bytes);
public long this[int i]=>Value[i];

public static A286489Inst Instance=new A286489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286490
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286490Inst : IEnumerable<long>
{
public static readonly long[] Value=A286490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286490.Bytes);
public long this[int i]=>Value[i];

public static A286490Inst Instance=new A286490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286491
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,11L,13L,15L,16L,18L,19L,22L,24L,25L,28L,29L,31L,32L,35L,37L,38L,40L,42L,43L,46L,47L,49L,51L,52L,54L,55L,58L,60L,61L,63L,65L,66L,69L,70L,72L,73L,76L,78L,79L,82L,83L,85L,87L,88L,90L,91L,94L,96L,97L,100L,101L,103L,104L,107L,109L,110L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286491Inst : IEnumerable<long>
{
public static readonly long[] Value=A286491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286491.Bytes);
public long this[int i]=>Value[i];

public static A286491Inst Instance=new A286491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286492
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,12L,14L,17L,20L,21L,23L,26L,27L,30L,33L,34L,36L,39L,41L,44L,45L,48L,50L,53L,56L,57L,59L,62L,64L,67L,68L,71L,74L,75L,77L,80L,81L,84L,86L,89L,92L,93L,95L,98L,99L,102L,105L,106L,108L,111L,113L,116L,117L,120L,123L,124L,126L,129L,130L,133L,135L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286492Inst : IEnumerable<long>
{
public static readonly long[] Value=A286492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286492.Bytes);
public long this[int i]=>Value[i];

public static A286492Inst Instance=new A286492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286493
{
public static readonly long[] Value={ 0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286493Inst : IEnumerable<long>
{
public static readonly long[] Value=A286493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286493.Bytes);
public long this[int i]=>Value[i];

public static A286493Inst Instance=new A286493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286494
{
public static readonly long[] Value={ 1L,4L,6L,7L,10L,11L,12L,13L,15L,16L,17L,18L,19L,22L,24L,25L,28L,29L,30L,31L,32L,35L,37L,38L,39L,40L,42L,43L,46L,47L,48L,49L,51L,52L,53L,54L,55L,58L,60L,61L,62L,63L,65L,66L,69L,70L,71L,72L,73L,76L,78L,79L,82L,83L,84L,85L,87L,88L,89L,90L,91L,94L,96L,97L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286494Inst : IEnumerable<long>
{
public static readonly long[] Value=A286494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286494.Bytes);
public long this[int i]=>Value[i];

public static A286494Inst Instance=new A286494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286495
{
public static readonly long[] Value={ 2L,3L,5L,8L,9L,14L,20L,21L,23L,26L,27L,33L,34L,36L,41L,44L,45L,50L,56L,57L,59L,64L,67L,68L,74L,75L,77L,80L,81L,86L,92L,93L,95L,98L,99L,105L,106L,108L,113L,116L,117L,123L,124L,126L,129L,130L,135L,141L,142L,144L,149L,152L,153L,158L,164L,165L,167L,170L,171L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286495Inst : IEnumerable<long>
{
public static readonly long[] Value=A286495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286495.Bytes);
public long this[int i]=>Value[i];

public static A286495Inst Instance=new A286495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286496
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,8L,16L,28L,50L,92L,170L,314L,584L,1092L,2048L,3854L,7280L,13796L,26214L,49932L,95324L,182360L,349524L,671088L,1290554L,2485512L,4793490L,9256394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286496Inst : IEnumerable<long>
{
public static readonly long[] Value=A286496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286496.Bytes);
public long this[int i]=>Value[i];

public static A286496Inst Instance=new A286496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286497
{
public static readonly long[] Value={ 12L,30L,56L,306L,380L,858L,992L,1722L,2552L,2862L,16256L,30704L,66198L,73712L,86142L,249500L,629802L,1703872L,6127552L,16191736L,19127502L,35359900L,67100672L,101999900L,172173762L,182552538L,266677578L,575688042L,1180712682L,2214408306L,6179139056L,17179738112L,21083999500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286497Inst : IEnumerable<long>
{
public static readonly long[] Value=A286497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286497.Bytes);
public long this[int i]=>Value[i];

public static A286497Inst Instance=new A286497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286498
{
public static readonly BigInteger[] Value={ 1L,11L,11L,1111L,11L,111111L,1111L,11111111L,1111L,1111111111L,1111L,111111111111L,1111L,11111111111111L,11011111L,1111111111111111L,11111111L,111111111111111111L,11111111L,11111111111111111111UL,11111111L,BigInteger.Parse("1111111111111111111111"),11111111L };
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
public class A286498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286498Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286498.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286498Inst Instance=new A286498Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286499
{
public static readonly BigInteger[] Value={ 2L,3L,5L,7L,17L,19L,43L,101L,163L,257L,487L,1459L,14407L,26407L,39367L,62501L,65537L,77659L,1020101L,1336337L,86093443L,242121643L,258280327L,3103616899L,4528177054183L,15258789062501L,411782264189299L,21108889701347407L,BigInteger.Parse("953735353027359375062501") };
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
public class A286499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286499Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A286499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286499.Bytes);
public BigInteger this[int i]=>Value[i];

public static A286499Inst Instance=new A286499Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286500
{
public static readonly ulong[] Value={ 1L,11L,110L,1111L,11000L,111111L,1111000L,11111111L,111100000L,1111111111L,11110000000L,111111111111L,1111000000000L,11111111111111L,111110110000000L,1111111111111111L,11111111000000000L,111111111111111111L,1111111100000000000L,11111111111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286500Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A286500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286500.Bytes);
public ulong this[int i]=>Value[i];

public static A286500Inst Instance=new A286500Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286501
{
public static readonly long[] Value={ 1L,3L,3L,15L,3L,63L,15L,255L,15L,1023L,15L,4095L,15L,16383L,223L,65535L,255L,262143L,255L,1048575L,255L,4194303L,255L,16777215L,255L,67108863L,255L,268435455L,255L,1073741823L,53247L,4294967295L,65535L,17179869183L,65535L,68719476735L,65535L,274877906943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286501Inst : IEnumerable<long>
{
public static readonly long[] Value=A286501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286501.Bytes);
public long this[int i]=>Value[i];

public static A286501Inst Instance=new A286501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286502
{
public static readonly long[] Value={ 1L,3L,6L,15L,24L,63L,120L,255L,480L,1023L,1920L,4095L,7680L,16383L,32128L,65535L,130560L,262143L,522240L,1048575L,2088960L,4194303L,8355840L,16777215L,33423360L,67108863L,133693440L,268435455L,534773760L,1073741823L,2147057664L,4294967295L,8589803520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286502Inst : IEnumerable<long>
{
public static readonly long[] Value=A286502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286502.Bytes);
public long this[int i]=>Value[i];

public static A286502Inst Instance=new A286502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286551
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,4L,3L,5L,6L,7L,6L,8L,3L,2L,9L,10L,11L,12L,13L,14L,11L,15L,12L,16L,3L,6L,4L,6L,10L,5L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,19L,27L,20L,28L,21L,29L,26L,30L,3L,31L,11L,32L,6L,32L,11L,33L,17L,3L,9L,34L,35L,36L,37L,38L,27L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,27L,45L,54L,55L,40L,56L,57L,58L,42L,59L,60L,61L,52L,43L,62L,30L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286551Inst : IEnumerable<long>
{
public static readonly long[] Value=A286551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286551.Bytes);
public long this[int i]=>Value[i];

public static A286551Inst Instance=new A286551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286552
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,1L,2L,1L,4L,2L,3L,1L,3L,2L,2L,1L,5L,4L,5L,3L,6L,1L,4L,1L,4L,5L,6L,1L,3L,2L,2L,1L,6L,7L,8L,7L,9L,2L,8L,3L,10L,3L,4L,1L,9L,2L,4L,1L,5L,10L,11L,2L,12L,3L,3L,1L,4L,5L,6L,2L,3L,2L,2L,1L,7L,11L,12L,13L,13L,5L,14L,7L,14L,6L,7L,4L,15L,5L,8L,3L,15L,8L,9L,6L,10L,1L,7L,1L,16L,8L,9L,1L,9L,2L,4L,1L,6L,17L,18L,4L,19L,10L,5L,3L,20L,11L,12L,2L,6L,3L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286552Inst : IEnumerable<long>
{
public static readonly long[] Value=A286552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286552.Bytes);
public long this[int i]=>Value[i];

public static A286552Inst Instance=new A286552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286553
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,4L,8L,2L,6L,6L,12L,4L,12L,6L,16L,2L,6L,8L,12L,6L,30L,6L,24L,4L,12L,6L,36L,6L,30L,12L,32L,2L,6L,6L,12L,6L,24L,6L,24L,6L,30L,6L,60L,6L,30L,6L,48L,4L,12L,12L,36L,8L,30L,30L,72L,6L,30L,6L,60L,6L,60L,6L,64L,2L,6L,12L,12L,6L,30L,16L,24L,6L,30L,6L,72L,6L,30L,12L,48L,6L,30L,12L,60L,6L,30L,6L,120L,6L,30L,30L,60L,12L,30L,6L,96L,4L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286553Inst : IEnumerable<long>
{
public static readonly long[] Value=A286553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286553.Bytes);
public long this[int i]=>Value[i];

public static A286553Inst Instance=new A286553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286554
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,1L,3L,3L,1L,1L,2L,2L,2L,3L,4L,4L,3L,1L,4L,2L,1L,1L,3L,4L,1L,2L,5L,5L,6L,6L,5L,5L,7L,2L,8L,3L,1L,1L,9L,3L,1L,1L,2L,3L,2L,4L,4L,7L,2L,2L,3L,5L,2L,3L,10L,8L,4L,6L,11L,9L,12L,10L,6L,6L,13L,4L,14L,5L,3L,4L,15L,6L,1L,1L,4L,5L,2L,6L,16L,4L,3L,2L,4L,2L,1L,1L,3L,7L,1L,1L,5L,8L,6L,9L,5L,11L,5L,7L,6L,8L,2L,1L,7L,10L,3L,2L,5L,9L,3L,10L,17L,12L,8L,11L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286554Inst : IEnumerable<long>
{
public static readonly long[] Value=A286554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286554.Bytes);
public long this[int i]=>Value[i];

public static A286554Inst Instance=new A286554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286555
{
public static readonly long[] Value={ 1L,2L,4L,3L,9L,8L,6L,5L,25L,18L,16L,21L,15L,12L,10L,7L,49L,50L,36L,51L,45L,32L,42L,55L,35L,30L,24L,33L,27L,20L,14L,11L,121L,98L,100L,147L,105L,72L,102L,125L,115L,90L,64L,93L,123L,84L,110L,91L,77L,70L,60L,87L,69L,48L,66L,85L,65L,54L,40L,57L,39L,28L,22L,13L,169L,242L,196L,291L,297L,200L,294L,365L,265L,210L,144L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286555Inst : IEnumerable<long>
{
public static readonly long[] Value=A286555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286555.Bytes);
public long this[int i]=>Value[i];

public static A286555Inst Instance=new A286555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286556
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,15L,5L,4L,14L,31L,13L,63L,30L,12L,10L,127L,9L,255L,29L,11L,62L,511L,26L,8L,126L,28L,61L,1023L,25L,2047L,21L,27L,254L,24L,18L,4095L,510L,60L,58L,8191L,22L,16383L,125L,20L,1022L,32767L,53L,16L,17L,19L,253L,65535L,57L,23L,122L,59L,2046L,131071L,50L,262143L,4094L,124L,42L,56L,54L,524287L,509L,52L,49L,1048575L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286556Inst : IEnumerable<long>
{
public static readonly long[] Value=A286556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286556.Bytes);
public long this[int i]=>Value[i];

public static A286556Inst Instance=new A286556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286557
{
public static readonly long[] Value={ 1L,2L,4L,2L,4L,8L,6L,2L,4L,12L,16L,6L,6L,12L,6L,2L,4L,12L,36L,6L,12L,32L,30L,6L,6L,30L,24L,6L,8L,12L,6L,2L,4L,12L,36L,12L,30L,72L,30L,8L,6L,60L,64L,6L,6L,60L,30L,6L,6L,30L,60L,6L,6L,48L,30L,6L,6L,24L,24L,6L,6L,12L,6L,2L,4L,12L,36L,6L,24L,72L,60L,6L,6L,210L,144L,6L,6L,60L,24L,6L,6L,30L,180L,6L,24L,128L,30L,6L,6L,30L,120L,6L,6L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286557Inst : IEnumerable<long>
{
public static readonly long[] Value=A286557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286557.Bytes);
public long this[int i]=>Value[i];

public static A286557Inst Instance=new A286557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286558
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,3L,3L,4L,2L,1L,3L,5L,4L,6L,4L,7L,5L,2L,6L,3L,1L,4L,7L,8L,8L,5L,9L,9L,10L,10L,5L,11L,11L,6L,12L,7L,2L,8L,13L,9L,3L,1L,4L,10L,5L,11L,14L,12L,15L,12L,16L,13L,6L,14L,17L,13L,18L,15L,19L,14L,20L,15L,6L,16L,21L,16L,22L,17L,7L,18L,23L,19L,8L,2L,9L,20L,10L,21L,24L,22L,11L,3L,12L,4L,1L,5L,13L,23L,14L,6L,15L,24L,16L,25L,25L,17L,26L,26L,27L,27L,17L,28L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286558Inst : IEnumerable<long>
{
public static readonly long[] Value=A286558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286558.Bytes);
public long this[int i]=>Value[i];

public static A286558Inst Instance=new A286558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286559
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,5L,8L,8L,13L,13L,13L,25L,24L,25L,41L,32L,41L,50L,50L,61L,61L,61L,61L,113L,84L,86L,113L,113L,113L,113L,181L,128L,129L,181L,200L,163L,182L,221L,200L,221L,242L,242L,265L,265L,265L,265L,265L,481L,263L,290L,420L,363L,314L,422L,420L,365L,481L,420L,481L,481L,481L,481L,761L,512L,452L,687L,577L,513L,722L,761L,650L,687L,762L,723L,760L,722L,842L,760L,801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286559Inst : IEnumerable<long>
{
public static readonly long[] Value=A286559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286559.Bytes);
public long this[int i]=>Value[i];

public static A286559Inst Instance=new A286559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286560
{
public static readonly long[] Value={ 0L,0L,1L,2L,5L,41L,71L,71L,198L,313L,484L,922L,1153L,1201L,2105L,1565L,2588L,4046L,5001L,7443L,7443L,8851L,10671L,19589L,16570L,16935L,22254L,25313L,25313L,25313L,42891L,28793L,32768L,52795L,65504L,59178L,73355L,89033L,88632L,107660L,129045L,129045L,153471L,167646L,167646L,182446L,182446L,336130L,197244L,233297L,330472L,307358L,270167L,355325L,378466L,332156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286560Inst : IEnumerable<long>
{
public static readonly long[] Value=A286560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286560.Bytes);
public long this[int i]=>Value[i];

public static A286560Inst Instance=new A286560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286561
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,0L,1L,2L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,3L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,1L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286561Inst : IEnumerable<long>
{
public static readonly long[] Value=A286561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286561.Bytes);
public long this[int i]=>Value[i];

public static A286561Inst Instance=new A286561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286562
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,1L,3L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,1L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286562Inst : IEnumerable<long>
{
public static readonly long[] Value=A286562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286562.Bytes);
public long this[int i]=>Value[i];

public static A286562Inst Instance=new A286562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286563
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,2L,0L,1L,1L,0L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,1L,3L,0L,1L,0L,0L,0L,1L,1L,0L,2L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,2L,1L,1L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286563Inst : IEnumerable<long>
{
public static readonly long[] Value=A286563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286563.Bytes);
public long this[int i]=>Value[i];

public static A286563Inst Instance=new A286563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286564
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,1L,0L,2L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,3L,1L,1L,0L,0L,0L,0L,0L,2L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,1L,0L,1L,1L,2L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286564Inst : IEnumerable<long>
{
public static readonly long[] Value=A286564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286564.Bytes);
public long this[int i]=>Value[i];

public static A286564Inst Instance=new A286564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286565
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,2L,3L,4L,3L,2L,5L,2L,3L,6L,6L,2L,7L,2L,7L,6L,6L,2L,8L,6L,3L,9L,10L,3L,8L,2L,5L,5L,3L,5L,11L,3L,3L,6L,12L,3L,12L,2L,8L,13L,6L,3L,14L,3L,8L,10L,8L,3L,15L,7L,16L,5L,10L,6L,17L,2L,3L,13L,8L,10L,18L,3L,8L,5L,18L,3L,19L,3L,5L,8L,8L,10L,16L,2L,11L,20L,5L,10L,19L,6L,5L,5L,14L,6L,17L,10L,18L,5L,10L,5L,21L,5L,5L,22L,23L,2L,24L,3L,14L,24L,10L,3L,25L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286565Inst : IEnumerable<long>
{
public static readonly long[] Value=A286565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286565.Bytes);
public long this[int i]=>Value[i];

public static A286565Inst Instance=new A286565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286566
{
public static readonly long[] Value={ 1L,3L,5L,9L,5L,19L,5L,26L,18L,19L,5L,51L,5L,19L,40L,73L,5L,72L,5L,72L,40L,40L,5L,113L,31L,19L,83L,111L,8L,129L,5L,101L,32L,19L,32L,221L,8L,19L,40L,179L,8L,199L,5L,84L,159L,40L,8L,312L,13L,84L,82L,84L,8L,239L,49L,261L,32L,82L,23L,419L,5L,19L,159L,224L,82L,334L,8L,84L,32L,334L,8L,543L,8L,32L,84L,84L,82L,285L,5L,243L,332L,32L,57L,478L,40L,32L,32L,218L,23L,419L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286566Inst : IEnumerable<long>
{
public static readonly long[] Value=A286566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286566.Bytes);
public long this[int i]=>Value[i];

public static A286566Inst Instance=new A286566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286599
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,4L,5L,2L,3L,6L,4L,7L,5L,6L,5L,2L,3L,6L,6L,8L,4L,9L,7L,10L,5L,11L,6L,9L,5L,6L,5L,2L,3L,6L,6L,8L,6L,12L,8L,13L,4L,9L,9L,13L,7L,14L,10L,15L,5L,11L,11L,12L,6L,12L,9L,14L,5L,11L,6L,9L,5L,6L,5L,2L,3L,6L,6L,8L,6L,12L,8L,13L,6L,12L,12L,16L,8L,16L,13L,17L,4L,9L,9L,13L,9L,18L,13L,19L,7L,14L,14L,17L,10L,20L,15L,21L,5L,11L,11L,12L,11L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286599Inst : IEnumerable<long>
{
public static readonly long[] Value=A286599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286599.Bytes);
public long this[int i]=>Value[i];

public static A286599Inst Instance=new A286599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286600
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,3L,5L,7L,5L,3L,6L,4L,6L,4L,2L,4L,2L,4L,6L,4L,8L,9L,6L,7L,11L,9L,5L,10L,6L,3L,6L,10L,6L,3L,6L,10L,14L,12L,6L,7L,13L,15L,11L,9L,5L,9L,14L,4L,6L,4L,2L,9L,6L,4L,8L,12L,6L,9L,13L,4L,8L,12L,8L,16L,8L,12L,17L,4L,8L,12L,8L,12L,18L,12L,6L,19L,13L,9L,17L,4L,8L,9L,6L,4L,2L,4L,6L,12L,8L,4L,8L,9L,13L,12L,6L,10L,14L,12L,6L,10L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286600Inst : IEnumerable<long>
{
public static readonly long[] Value=A286600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286600.Bytes);
public long this[int i]=>Value[i];

public static A286600Inst Instance=new A286600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286601
{
public static readonly long[] Value={ 1L,2L,4L,2L,6L,2L,4L,8L,16L,8L,4L,12L,6L,12L,6L,2L,6L,2L,6L,12L,6L,30L,24L,12L,16L,32L,24L,8L,36L,12L,4L,12L,36L,12L,4L,12L,36L,72L,60L,12L,16L,48L,64L,32L,24L,8L,24L,72L,6L,12L,6L,2L,24L,12L,6L,30L,60L,12L,24L,48L,6L,30L,60L,30L,210L,30L,60L,120L,6L,30L,60L,30L,60L,180L,60L,12L,96L,48L,24L,120L,6L,30L,24L,12L,6L,2L,6L,12L,60L,30L,6L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286601Inst : IEnumerable<long>
{
public static readonly long[] Value=A286601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286601.Bytes);
public long this[int i]=>Value[i];

public static A286601Inst Instance=new A286601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286602
{
public static readonly long[] Value={ 1L,2L,3L,2L,4L,2L,3L,5L,6L,5L,3L,7L,4L,7L,4L,2L,4L,2L,4L,7L,4L,8L,9L,7L,6L,10L,9L,5L,11L,7L,3L,7L,11L,7L,3L,7L,11L,12L,13L,7L,6L,14L,15L,10L,9L,5L,9L,12L,4L,7L,4L,2L,9L,7L,4L,8L,13L,7L,9L,14L,4L,8L,13L,8L,16L,8L,13L,17L,4L,8L,13L,8L,13L,18L,13L,7L,19L,14L,9L,17L,4L,8L,9L,7L,4L,2L,4L,7L,13L,8L,4L,8L,9L,14L,13L,7L,11L,12L,13L,7L,11L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286602Inst : IEnumerable<long>
{
public static readonly long[] Value=A286602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286602.Bytes);
public long this[int i]=>Value[i];

public static A286602Inst Instance=new A286602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286603
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,6L,11L,12L,13L,13L,14L,10L,15L,16L,17L,18L,19L,13L,20L,14L,17L,21L,22L,23L,24L,18L,25L,26L,27L,26L,28L,29L,20L,22L,30L,17L,31L,32L,33L,34L,24L,26L,35L,36L,37L,24L,38L,27L,39L,24L,39L,40L,30L,20L,41L,42L,31L,43L,44L,33L,45L,46L,47L,31L,45L,24L,48L,49L,50L,35L,51L,31L,41L,40L,52L,53L,47L,33L,54L,55L,56L,39L,57L,30L,58L,59L,41L,60L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286603Inst : IEnumerable<long>
{
public static readonly long[] Value=A286603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286603.Bytes);
public long this[int i]=>Value[i];

public static A286603Inst Instance=new A286603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A286604
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,0L,1L,0L,0L,1L,3L,0L,1L,2L,3L,0L,2L,0L,3L,0L,1L,2L,5L,0L,1L,0L,0L,1L,1L,0L,1L,2L,1L,2L,0L,0L,1L,2L,4L,0L,5L,2L,3L,4L,3L,4L,5L,0L,1L,2L,3L,0L,3L,0L,3L,0L,2L,3L,5L,0L,1L,2L,3L,4L,2L,1L,1L,2L,6L,0L,7L,0L,1L,2L,0L,1L,5L,2L,4L,0L,3L,4L,6L,4L,1L,2L,3L,4L,1L,0L,0L,1L,5L,6L,5L,0L,2L,3L,3L,4L,3L,2L,1L,2L,0L,1L,3L,0L,4L,5L,7L,0L,5L,2L,3L,4L,0L,1L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A286604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A286604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A286604Inst : IEnumerable<long>
{
public static readonly long[] Value=A286604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A286604.Bytes);
public long this[int i]=>Value[i];

public static A286604Inst Instance=new A286604Inst();

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