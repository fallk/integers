using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A078644
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,6L,3L,4L,5L,6L,3L,9L,3L,6L,9L,5L,3L,10L,3L,9L,9L,6L,3L,12L,5L,6L,7L,9L,3L,18L,3L,6L,9L,6L,9L,15L,3L,6L,9L,12L,3L,18L,3L,9L,15L,6L,3L,15L,5L,10L,9L,9L,3L,14L,9L,12L,9L,6L,3L,27L,3L,6L,15L,7L,9L,18L,3L,9L,9L,18L,3L,20L,3L,6L,15L,9L,9L,18L,3L,15L,9L,6L,3L,27L,9L,6L,9L,12L,3L,30L,9L,9L,9L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078644Inst : IEnumerable<long>
{
public static readonly long[] Value=A078644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078644.Bytes);
public long this[int i]=>Value[i];

public static A078644Inst Instance=new A078644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078611
{
public static readonly long[] Value={ 2L,4L,6L,6L,6L,12L,6L,12L,12L,6L,12L,24L,6L,6L,12L,18L,6L,12L,6L,18L,24L,18L,30L,12L,6L,6L,30L,24L,24L,18L,30L,12L,18L,12L,6L,36L,30L,6L,12L,18L,42L,30L,30L,42L,12L,60L,30L,48L,6L,12L,30L,12L,6L,6L,12L,42L,6L,12L,54L,24L,24L,42L,36L,36L,18L,30L,36L,18L,6L,42L,30L,6L,30L,36L,30L,24L,18L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078611Inst : IEnumerable<long>
{
public static readonly long[] Value=A078611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078611.Bytes);
public long this[int i]=>Value[i];

public static A078611Inst Instance=new A078611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078610
{
public static readonly long[] Value={ 1L,2L,3L,9L,15L,16L,17L,129L,129L,271L,256L,1055L,1025L,2048L,2049L,32769L,32769L,65537L,65536L,262144L,262144L,524289L,524288L,4194307L,4194311L,8388609L,8388608L,33554435L,33554433L,67108864L,67108865L,2147483649L,2147483649L,4294967297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078610Inst : IEnumerable<long>
{
public static readonly long[] Value=A078610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078610.Bytes);
public long this[int i]=>Value[i];

public static A078610Inst Instance=new A078610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078609
{
public static readonly long[] Value={ 8L,12L,16L,21L,25L,29L,34L,38L,42L,47L,51L,55L,60L,64L,68L,73L,77L,81L,86L,90L,94L,99L,103L,107L,112L,116L,120L,125L,129L,133L,138L,142L,146L,150L,155L,159L,163L,168L,172L,176L,181L,185L,189L,194L,198L,202L,207L,211L,215L,220L,224L,228L,233L,237L,241L,246L,250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078609Inst : IEnumerable<long>
{
public static readonly long[] Value=A078609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078609.Bytes);
public long this[int i]=>Value[i];

public static A078609Inst Instance=new A078609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078608
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,20L,23L,25L,28L,31L,34L,37L,40L,43L,46L,49L,51L,54L,57L,60L,63L,66L,69L,72L,75L,77L,80L,83L,86L,89L,92L,95L,98L,100L,103L,106L,109L,112L,115L,118L,121L,124L,126L,129L,132L,135L,138L,141L,144L,147L,150L,152L,155L,158L,161L,164L,167L,170L,173L,176L,178L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078608Inst : IEnumerable<long>
{
public static readonly long[] Value=A078608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078608.Bytes);
public long this[int i]=>Value[i];

public static A078608Inst Instance=new A078608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078607
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,10L,12L,13L,14L,16L,17L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,35L,36L,38L,39L,40L,42L,43L,45L,46L,48L,49L,50L,52L,53L,55L,56L,58L,59L,61L,62L,63L,65L,66L,68L,69L,71L,72L,74L,75L,76L,78L,79L,81L,82L,84L,85L,87L,88L,89L,91L,92L,94L,95L,97L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078607Inst : IEnumerable<long>
{
public static readonly long[] Value=A078607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078607.Bytes);
public long this[int i]=>Value[i];

public static A078607Inst Instance=new A078607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078606
{
public static readonly long[] Value={ -2L,-1L,4L,-5L,2L,7L,3L,-3L,-11L,-4L,13L,-14L,16L,6L,-6L,-20L,-7L,22L,8L,25L,9L,-29L,-10L,31L,-32L,11L,34L,-38L,-13L,-41L,14L,15L,-15L,-47L,49L,-50L,52L,18L,-18L,-19L,58L,-59L,20L,-21L,67L,-68L,23L,70L,24L,-24L,-25L,-77L,79L,27L,-27L,-83L,-28L,85L,88L,-92L,-31L,94L,-95L,-33L,-101L,-104L,35L,106L,36L,-110L,112L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078606Inst : IEnumerable<long>
{
public static readonly long[] Value=A078606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078606.Bytes);
public long this[int i]=>Value[i];

public static A078606Inst Instance=new A078606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078605
{
public static readonly long[] Value={ 1L,12L,97L,672L,4261L,25588L,147821L,830576L,4566917L,24692980L,131682825L,694386864L,3626770709L,18790632772L,96675376705L,494382431552L,2514666026897L,12730690730212L,64177763220925L,322314275563424L,1613192327878789L,8049191357609204L,40048773875769449L,198750753713937600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078605Inst : IEnumerable<long>
{
public static readonly long[] Value=A078605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078605.Bytes);
public long this[int i]=>Value[i];

public static A078605Inst Instance=new A078605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078604
{
public static readonly long[] Value={ 3L,31L,157L,349L,103L,314159L,392699L,8263L,7853L,9786893L,28954771L,157079632679L,68246533L,4304347L,67649047L,1002742628021L,1170899L,990371647L,14523877L,1186001L,1023100457L,451661057L,1492315939L,381315143078063L,950007203269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078604Inst : IEnumerable<long>
{
public static readonly long[] Value=A078604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078604.Bytes);
public long this[int i]=>Value[i];

public static A078604Inst Instance=new A078604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078603
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,6L,46L,354L,3106L,29926L,315862L,3628906L,45132474L,604534846L,8680957902L,133082437730L,2169964347282L,37505486702678L,685046187718022L,13186335387855770L,266816610979894058L,5662225862272325550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078603Inst : IEnumerable<long>
{
public static readonly long[] Value=A078603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078603.Bytes);
public long this[int i]=>Value[i];

public static A078603Inst Instance=new A078603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078602
{
public static readonly long[] Value={ 1L,2L,21L,601L,34278L,3144357L,421928841L,77832868334L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078602Inst : IEnumerable<long>
{
public static readonly long[] Value=A078602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078602.Bytes);
public long this[int i]=>Value[i];

public static A078602Inst Instance=new A078602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078601
{
public static readonly BigInteger[] Value={ 1L,3L,42L,1080L,51840L,3758400L,382838400L,52733721600L,9400624128000L,2105593491456000L,579255485276160000L,BigInteger.Parse("191957359005941760000"),BigInteger.Parse("75420399121328701440000"),BigInteger.Parse("34668462695110852608000000"),BigInteger.Parse("18432051070888873171353600000"),BigInteger.Parse("11223248177765618214764544000000"),BigInteger.Parse("7759395812038133743242706944000000") };
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
public class A078601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078601Inst Instance=new A078601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078600
{
public static readonly long[] Value={ 0L,0L,12L,20L,630L,5368L,42120L,3634950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078600Inst : IEnumerable<long>
{
public static readonly long[] Value=A078600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078600.Bytes);
public long this[int i]=>Value[i];

public static A078600Inst Instance=new A078600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078599
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,36L,7L,2L,3L,100L,11L,36L,13L,196L,225L,2L,17L,36L,19L,100L,441L,484L,23L,36L,5L,676L,3L,196L,29L,810000L,31L,2L,1089L,1156L,1225L,36L,37L,1444L,1521L,100L,41L,3111696L,43L,484L,225L,2116L,47L,36L,7L,100L,2601L,676L,53L,36L,3025L,196L,3249L,3364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078599Inst : IEnumerable<long>
{
public static readonly long[] Value=A078599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078599.Bytes);
public long this[int i]=>Value[i];

public static A078599Inst Instance=new A078599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078598
{
public static readonly long[] Value={ 5L,13L,29L,37L,61L,101L,109L,157L,181L,229L,277L,349L,373L,421L,541L,613L,661L,709L,757L,829L,1021L,1069L,1093L,1117L,1213L,1381L,1429L,1453L,1549L,1621L,1669L,1741L,1789L,1933L,2029L,2053L,2221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078598Inst : IEnumerable<long>
{
public static readonly long[] Value=A078598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078598.Bytes);
public long this[int i]=>Value[i];

public static A078598Inst Instance=new A078598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078597
{
public static readonly long[] Value={ 23L,79L,223L,439L,4759L,53359L,77839L,95479L,99223L,159199L,194479L,239119L,378223L,416023L,680623L,2223079L,2595319L,2873023L,3186223L,3515623L,4003999L,5022079L,6456679L,6859159L,8732023L,9235519L,9492559L,10017223L,10595023L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078597Inst : IEnumerable<long>
{
public static readonly long[] Value=A078597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078597.Bytes);
public long this[int i]=>Value[i];

public static A078597Inst Instance=new A078597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078596
{
public static readonly long[] Value={ 6L,12L,18L,24L,30L,36L,42L,48L,54L,60L,66L,72L,90L,96L,108L,120L,126L,132L,144L,150L,162L,180L,192L,198L,210L,216L,234L,240L,264L,270L,276L,288L,294L,300L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078596Inst : IEnumerable<long>
{
public static readonly long[] Value=A078596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078596.Bytes);
public long this[int i]=>Value[i];

public static A078596Inst Instance=new A078596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078435
{
public static readonly long[] Value={ 1L,2L,5L,10L,16L,25L,34L,46L,59L,75L,91L,110L,130L,152L,177L,202L,228L,258L,289L,322L,356L,392L,430L,471L,511L,554L,600L,647L,695L,746L,799L,852L,908L,965L,1025L,1086L,1150L,1216L,1281L,1349L,1418L,1490L,1566L,1641L,1719L,1797L,1880L,1962L,2044L,2133L,2223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078435Inst : IEnumerable<long>
{
public static readonly long[] Value=A078435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078435.Bytes);
public long this[int i]=>Value[i];

public static A078435Inst Instance=new A078435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078434
{
public static readonly long[] Value={ 2L,6L,1L,2L,3L,7L,5L,3L,4L,8L,6L,8L,5L,4L,8L,8L,3L,4L,3L,3L,4L,8L,5L,6L,7L,5L,6L,7L,9L,2L,4L,0L,7L,1L,6L,3L,0L,5L,7L,0L,8L,0L,0L,6L,5L,2L,4L,0L,0L,0L,6L,3L,4L,0L,7L,5L,7L,3L,3L,2L,8L,2L,4L,8L,8L,1L,4L,9L,2L,7L,7L,6L,7L,6L,8L,8L,2L,7L,2L,8L,6L,0L,9L,9L,6L,2L,4L,3L,8L,6L,8L,1L,2L,6L,3L,1L,1L,9L,5L,2L,3L,8L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078434Inst : IEnumerable<long>
{
public static readonly long[] Value=A078434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078434.Bytes);
public long this[int i]=>Value[i];

public static A078434Inst Instance=new A078434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078433
{
public static readonly long[] Value={ 0L,2L,2L,10L,30L,124L,992L,5700L,39844L,366172L,3587856L,38861778L,435816838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078433Inst : IEnumerable<long>
{
public static readonly long[] Value=A078433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078433.Bytes);
public long this[int i]=>Value[i];

public static A078433Inst Instance=new A078433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078432
{
public static readonly long[] Value={ 0L,1L,4L,14L,32L,204L,994L,7526L,48636L,421392L,4018976L,41304726L,490878388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078432Inst : IEnumerable<long>
{
public static readonly long[] Value=A078432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078432.Bytes);
public long this[int i]=>Value[i];

public static A078432Inst Instance=new A078432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078431
{
public static readonly long[] Value={ 0L,1L,1L,3L,3L,20L,126L,694L,2874L,25059L,218517L,2054986L,21050226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078431Inst : IEnumerable<long>
{
public static readonly long[] Value=A078431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078431.Bytes);
public long this[int i]=>Value[i];

public static A078431Inst Instance=new A078431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078430
{
public static readonly long[] Value={ 1L,3L,5L,10L,9L,15L,13L,28L,33L,27L,21L,50L,25L,39L,45L,88L,33L,99L,37L,90L,65L,63L,45L,140L,145L,75L,153L,130L,57L,135L,61L,240L,105L,99L,117L,330L,73L,111L,125L,252L,81L,195L,85L,210L,297L,135L,93L,440L,385L,435L,165L,250L,105L,459L,189L,364L,185L,171L,117L,450L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078430Inst : IEnumerable<long>
{
public static readonly long[] Value=A078430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078430.Bytes);
public long this[int i]=>Value[i];

public static A078430Inst Instance=new A078430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078429
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,2L,6L,5L,6L,4L,10L,4L,12L,6L,8L,9L,16L,6L,18L,8L,12L,10L,22L,10L,20L,12L,19L,12L,28L,8L,30L,18L,20L,16L,24L,12L,36L,18L,24L,20L,40L,12L,42L,20L,24L,22L,46L,18L,42L,20L,32L,24L,52L,19L,40L,30L,36L,28L,58L,16L,60L,30L,36L,37L,48L,20L,66L,32L,44L,24L,70L,30L,72L,36L,40L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078429Inst : IEnumerable<long>
{
public static readonly long[] Value=A078429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078429.Bytes);
public long this[int i]=>Value[i];

public static A078429Inst Instance=new A078429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078428
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,3L,3L,4L,4L,6L,6L,6L,6L,6L,7L,7L,7L,9L,10L,10L,10L,10L,10L,11L,11L,11L,11L,13L,13L,15L,15L,15L,15L,15L,16L,16L,16L,16L,16L,18L,18L,18L,20L,21L,21L,21L,21L,22L,22L,22L,22L,22L,22L,24L,24L,24L,24L,26L,26L,28L,28L,28L,29L,29L,29L,29L,29L,29L,29L,31L,31L,31L,31L,31L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078428Inst : IEnumerable<long>
{
public static readonly long[] Value=A078428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078428.Bytes);
public long this[int i]=>Value[i];

public static A078428Inst Instance=new A078428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078427
{
public static readonly BigInteger[] Value={ 46L,901L,13501L,180001L,2250001L,27000001L,315000001L,3600000001L,40500000001L,450000000001L,4950000000001L,54000000000001L,585000000000001L,6300000000000001L,67500000000000001L,720000000000000001L,7650000000000000001L,BigInteger.Parse("81000000000000000001") };
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
public class A078427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078427Inst Instance=new A078427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078426
{
public static readonly long[] Value={ 1L,4L,6L,11L,470L,475L,477L,480L,482L,483L,484L,485L,486L,487L,488L,489L,490L,491L,492L,493L,494L,495L,496L,497L,498L,499L,500L,501L,502L,503L,504L,505L,506L,507L,508L,509L,510L,511L,512L,513L,514L,515L,516L,517L,518L,519L,520L,522L,525L,527L,532L,1077L,1082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078426Inst : IEnumerable<long>
{
public static readonly long[] Value=A078426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078426.Bytes);
public long this[int i]=>Value[i];

public static A078426Inst Instance=new A078426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078425
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,19L,29L,41L,43L,59L,83L,89L,107L,109L,127L,139L,157L,163L,173L,199L,211L,223L,257L,271L,277L,293L,307L,331L,347L,367L,397L,421L,443L,457L,491L,541L,557L,587L,601L,631L,691L,761L,769L,821L,911L,941L,971L,991L,1009L,1033L,1103L,1129L,1153L,1201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078425Inst : IEnumerable<long>
{
public static readonly long[] Value=A078425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078425.Bytes);
public long this[int i]=>Value[i];

public static A078425Inst Instance=new A078425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078424
{
public static readonly long[] Value={ 3L,2L,1L,1L,7L,6L,4L,1L,1L,1L,8L,8L,5L,2L,0L,9L,8L,3L,2L,1L,3L,6L,8L,9L,5L,2L,8L,3L,8L,8L,5L,4L,7L,8L,5L,4L,9L,9L,9L,7L,0L,8L,9L,4L,9L,3L,5L,4L,2L,2L,8L,3L,3L,4L,8L,5L,8L,4L,3L,2L,6L,6L,0L,2L,0L,4L,6L,2L,5L,4L,8L,8L,3L,7L,6L,3L,4L,8L,8L,7L,3L,3L,1L,4L,2L,3L,3L,7L,5L,6L,9L,2L,5L,5L,6L,6L,0L,6L,3L,2L,2L,8L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078424Inst : IEnumerable<long>
{
public static readonly long[] Value=A078424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078424.Bytes);
public long this[int i]=>Value[i];

public static A078424Inst Instance=new A078424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078423
{
public static readonly BigInteger[] Value={ 2L,60L,30240L,98017920L,857180548224000L,BigInteger.Parse("109720581991308288000"),BigInteger.Parse("70265584374661732509573120000"),BigInteger.Parse("61765285634580106110458762035200000"),BigInteger.Parse("642817384174195049892129048242945261568000000") };
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
public class A078423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078423Inst Instance=new A078423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078422
{
public static readonly BigInteger[] Value={ 9L,125L,16807L,19487171L,1792160394037L,9904578032905937L,BigInteger.Parse("5480386857784802185939"),BigInteger.Parse("74615470927590710561908487"),BigInteger.Parse("4316720717749415770740818372739989") };
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
public class A078422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078422Inst Instance=new A078422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078421
{
public static readonly long[] Value={ 13L,2L,105L,3L,9L,1742L,1961L,1705L,161L,11945L,68718937L,36453025L,411755350L,3222597649L,2808250369L,14913078L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078421Inst : IEnumerable<long>
{
public static readonly long[] Value=A078421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078421.Bytes);
public long this[int i]=>Value[i];

public static A078421Inst Instance=new A078421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078420
{
public static readonly long[] Value={ 105L,548L,683L,1508L,3652L,4278L,4295L,8145L,8150L,9417L,9419L,18247L,18287L,18370L,18433L,18586L,18695L,18706L,18742L,18945L,22024L,22140L,22311L,22324L,22708L,22714L,25336L,25681L,25771L,25777L,25785L,25814L,44545L,44593L,46505L,46847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078420Inst : IEnumerable<long>
{
public static readonly long[] Value=A078420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078420.Bytes);
public long this[int i]=>Value[i];

public static A078420Inst Instance=new A078420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078355
{
public static readonly long[] Value={ 1L,3L,16L,1L,5L,8L,24L,640L,1L,7L,40L,195L,32L,3L,534000L,1L,9L,106000L,3L,12754704L,40L,8L,6525L,226592L,1L,11L,2968L,15L,1039424L,16L,48L,305L,352L,3621L,1856L,1L,13L,9384L,126585L,1360L,8L,896073208080L,56L,72664L,3L,6440L,5L,521904L,1L,15L,140510608L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078355Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078355.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078355Inst : IEnumerable<long>
{
public static readonly long[] Value=A078355.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078355.Bytes);
public long this[int i]=>Value[i];

public static A078355Inst Instance=new A078355Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078354
{
public static readonly BigInteger[] Value={ 1L,20L,160000L,512000000000L,BigInteger.Parse("655360000000000000000"),BigInteger.Parse("335544320000000000000000000000000"),BigInteger.Parse("68719476736000000000000000000000000000000000000") };
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
public class A078354Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078354.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078354Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078354.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078354.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078354Inst Instance=new A078354Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078353
{
public static readonly BigInteger[] Value={ 1L,19L,130321L,322687697779L,BigInteger.Parse("288441413567621167681"),BigInteger.Parse("93076495688256089536609610280499"),BigInteger.Parse("10842505080063916320800450434338728415281531281") };
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
public class A078353Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078353.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078353Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078353.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078353.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078353Inst Instance=new A078353Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078352
{
public static readonly BigInteger[] Value={ 1L,18L,104976L,198359290368L,BigInteger.Parse("121439531096594251776"),BigInteger.Parse("24088659210943104643915283693568"),BigInteger.Parse("1548139828427760582529495524831238344488779776") };
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
public class A078352Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078352.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078352Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078352.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078352.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078352Inst Instance=new A078352Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078351
{
public static readonly BigInteger[] Value={ 1L,17L,83521L,118587876497L,BigInteger.Parse("48661191875666868481"),BigInteger.Parse("5770627412348402378939569991057"),BigInteger.Parse("197770344305988984840145602058543169130838081") };
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
public class A078351Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078351.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078351Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078351.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078351.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078351Inst Instance=new A078351Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078350
{
public static readonly long[] Value={ 0L,1L,3L,1L,2L,3L,6L,1L,6L,2L,5L,3L,3L,6L,4L,1L,4L,6L,7L,2L,1L,5L,4L,3L,7L,3L,25L,6L,6L,4L,24L,1L,7L,4L,3L,6L,7L,7L,11L,2L,25L,1L,8L,5L,4L,4L,23L,3L,7L,7L,6L,3L,3L,25L,24L,6L,8L,6L,11L,4L,5L,24L,20L,1L,7L,7L,9L,4L,3L,3L,22L,6L,25L,7L,2L,7L,6L,11L,11L,2L,5L,25L,24L,1L,1L,8L,9L,5L,10L,4L,20L,4L,3L,23L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078350Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078350.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078350Inst : IEnumerable<long>
{
public static readonly long[] Value=A078350.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078350.Bytes);
public long this[int i]=>Value[i];

public static A078350Inst Instance=new A078350Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078349
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,2L,1L,1L,2L,3L,1L,2L,2L,2L,1L,2L,1L,2L,2L,2L,3L,4L,1L,1L,2L,2L,2L,3L,2L,3L,1L,1L,2L,2L,1L,2L,2L,2L,2L,3L,2L,3L,3L,3L,4L,5L,1L,1L,1L,1L,2L,3L,2L,2L,2L,2L,3L,4L,2L,3L,3L,3L,1L,1L,1L,2L,2L,2L,2L,3L,1L,2L,2L,2L,2L,2L,2L,3L,2L,2L,3L,4L,2L,2L,3L,3L,3L,4L,3L,3L,4L,4L,5L,5L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078349Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078349.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078349Inst : IEnumerable<long>
{
public static readonly long[] Value=A078349.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078349.Bytes);
public long this[int i]=>Value[i];

public static A078349Inst Instance=new A078349Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078348
{
public static readonly long[] Value={ 3313L,3331L,32233L,32323L,33223L,123323L,132233L,223133L,223313L,223331L,231323L,233231L,312233L,321323L,323123L,3344443L,3434443L,3443443L,4434343L,4443433L,14334443L,14443343L,14443433L,31434443L,31443443L,33434441L,33555553L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078348Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078348.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078348Inst : IEnumerable<long>
{
public static readonly long[] Value=A078348.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078348.Bytes);
public long this[int i]=>Value[i];

public static A078348Inst Instance=new A078348Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078347
{
public static readonly long[] Value={ 1L,24L,36L,48L,72L,96L,108L,120L,144L,160L,168L,180L,192L,216L,240L,288L,320L,336L,360L,384L,432L,480L,504L,540L,576L,600L,640L,648L,672L,720L,756L,768L,792L,800L,840L,864L,896L,900L,960L,1008L,1056L,1080L,1120L,1152L,1200L,1248L,1260L,1280L,1296L,1320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078347Inst : IEnumerable<long>
{
public static readonly long[] Value=A078347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078347.Bytes);
public long this[int i]=>Value[i];

public static A078347Inst Instance=new A078347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078346
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,17L,24L,34L,46L,62L,79L,104L,130L,163L,201L,249L,298L,363L,429L,513L,605L,714L,824L,966L,1112L,1284L,1468L,1687L,1907L,2181L,2456L,2779L,3120L,3510L,3910L,4394L,4879L,5430L,6008L,6677L,7347L,8139L,8932L,9836L,10788L,11850L,12913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078346Inst : IEnumerable<long>
{
public static readonly long[] Value=A078346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078346.Bytes);
public long this[int i]=>Value[i];

public static A078346Inst Instance=new A078346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078345
{
public static readonly long[] Value={ 1L,2L,5L,8L,10L,11L,12L,13L,19L,20L,21L,22L,24L,25L,26L,29L,31L,32L,36L,37L,38L,41L,44L,48L,49L,50L,55L,58L,59L,60L,61L,62L,65L,71L,72L,73L,79L,80L,82L,84L,89L,95L,96L,97L,101L,104L,108L,109L,118L,120L,122L,125L,131L,132L,139L,140L,142L,144L,145L,149L,151L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078345Inst : IEnumerable<long>
{
public static readonly long[] Value=A078345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078345.Bytes);
public long this[int i]=>Value[i];

public static A078345Inst Instance=new A078345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078344
{
public static readonly long[] Value={ 1L,2L,3L,6L,17L,43L,109L,278L,708L,1803L,4592L,11695L,29785L,75857L,193194L,492030L,1253111L,3191446L,8128033L,20700623L,52720725L,134270106L,341961560L,870913951L,2218059568L,5648994647L,14386962813L,36640979841L,93317917142L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078344Inst : IEnumerable<long>
{
public static readonly long[] Value=A078344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078344.Bytes);
public long this[int i]=>Value[i];

public static A078344Inst Instance=new A078344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078343
{
public static readonly long[] Value={ -1L,2L,3L,8L,19L,46L,111L,268L,647L,1562L,3771L,9104L,21979L,53062L,128103L,309268L,746639L,1802546L,4351731L,10506008L,25363747L,61233502L,147830751L,356895004L,861620759L,2080136522L,5021893803L,12123924128L,29269742059L,70663408246L,170596558551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078343Inst : IEnumerable<long>
{
public static readonly long[] Value=A078343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078343.Bytes);
public long this[int i]=>Value[i];

public static A078343Inst Instance=new A078343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078342
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,3L,3L,4L,3L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,7L,7L,7L,7L,8L,7L,7L,7L,7L,7L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,11L,11L,12L,12L,12L,12L,13L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,14L,14L,15L,15L,15L,15L,15L,15L,16L,16L,16L,16L,17L,17L,18L,18L,18L,18L,18L,18L,19L,19L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078342Inst : IEnumerable<long>
{
public static readonly long[] Value=A078342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078342.Bytes);
public long this[int i]=>Value[i];

public static A078342Inst Instance=new A078342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078341
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,2L,0L,1L,7L,6L,0L,1L,18L,46L,24L,0L,1L,41L,228L,326L,120L,0L,1L,88L,930L,2672L,2556L,720L,0L,1L,183L,3406L,17198L,31484L,22212L,5040L,0L,1L,374L,11682L,96040L,295004L,385144L,212976L,40320L,0L,1L,757L,38412L,489298L,2339380L,4965900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078341Inst : IEnumerable<long>
{
public static readonly long[] Value=A078341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078341.Bytes);
public long this[int i]=>Value[i];

public static A078341Inst Instance=new A078341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078340
{
public static readonly long[] Value={ 2L,6L,3L,9L,6L,1L,8L,18L,9L,4L,1L,5L,11L,11L,7L,21L,3L,1L,13L,3L,7L,9L,12L,3L,5L,54L,11L,1L,14L,11L,15L,2L,34L,5L,12L,48L,3L,7L,3L,25L,3L,7L,13L,7L,10L,2L,6L,15L,28L,4L,7L,36L,7L,3L,36L,3L,56L,16L,2L,2L,3L,6L,15L,12L,4L,7L,3L,3L,3L,11L,24L,3L,33L,9L,10L,11L,2L,49L,13L,162L,13L,44L,7L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078340Inst : IEnumerable<long>
{
public static readonly long[] Value=A078340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078340.Bytes);
public long this[int i]=>Value[i];

public static A078340Inst Instance=new A078340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078291
{
public static readonly long[] Value={ 70L,72L,70L,70L,77L,78L,714L,76L,713L,725L,713L,74L,738L,731L,705L,742L,708L,732L,737L,710L,730L,711L,747L,712L,776L,707L,721L,749L,763L,791L,762L,786L,7124L,7089L,745L,755L,785L,7009L,7014L,7093L,716L,724L,764L,772L,788L,796L,7174L,7136L,7037L,7099L,7223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078291Inst : IEnumerable<long>
{
public static readonly long[] Value=A078291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078291.Bytes);
public long this[int i]=>Value[i];

public static A078291Inst Instance=new A078291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078290
{
public static readonly long[] Value={ 6L,6L,60L,63L,66L,65L,68L,608L,69L,609L,62L,629L,615L,602L,611L,636L,649L,610L,603L,639L,657L,632L,664L,623L,679L,606L,618L,642L,654L,678L,635L,655L,685L,695L,6109L,604L,628L,652L,668L,692L,6086L,6154L,6112L,6176L,6107L,6169L,633L,669L,681L,687L,699L,6214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078290Inst : IEnumerable<long>
{
public static readonly long[] Value=A078290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078290.Bytes);
public long this[int i]=>Value[i];

public static A078290Inst Instance=new A078290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078289
{
public static readonly long[] Value={ 50L,51L,50L,56L,55L,52L,51L,57L,506L,58L,527L,518L,533L,516L,517L,530L,531L,549L,536L,568L,511L,553L,581L,534L,582L,505L,515L,535L,545L,565L,508L,524L,548L,556L,596L,5134L,5024L,5053L,501L,519L,537L,543L,573L,579L,591L,597L,5064L,5129L,5221L,5038L,5126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078289Inst : IEnumerable<long>
{
public static readonly long[] Value=A078289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078289.Bytes);
public long this[int i]=>Value[i];

public static A078289Inst Instance=new A078289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078288
{
public static readonly long[] Value={ 4L,42L,40L,42L,44L,403L,408L,418L,46L,406L,403L,407L,410L,430L,423L,424L,413L,427L,402L,426L,438L,474L,415L,445L,485L,404L,412L,428L,436L,452L,4064L,4061L,411L,417L,447L,453L,471L,489L,4008L,4152L,4117L,4163L,4011L,4053L,4137L,4179L,422L,446L,454L,458L,466L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078288Inst : IEnumerable<long>
{
public static readonly long[] Value=A078288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078288.Bytes);
public long this[int i]=>Value[i];

public static A078288Inst Instance=new A078288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078287
{
public static readonly long[] Value={ 30L,30L,30L,35L,33L,39L,34L,38L,322L,319L,310L,333L,328L,301L,329L,318L,354L,305L,335L,355L,365L,316L,332L,356L,388L,303L,309L,321L,327L,339L,381L,393L,3014L,3058L,3129L,302L,314L,326L,334L,346L,358L,362L,382L,386L,394L,398L,3165L,3122L,3178L,3206L,3029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078287Inst : IEnumerable<long>
{
public static readonly long[] Value=A078287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078287.Bytes);
public long this[int i]=>Value[i];

public static A078287Inst Instance=new A078287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078286
{
public static readonly long[] Value={ 20L,21L,20L,21L,22L,26L,204L,209L,207L,203L,217L,222L,205L,215L,235L,212L,236L,244L,201L,213L,219L,237L,249L,267L,291L,202L,206L,214L,218L,226L,254L,262L,274L,278L,298L,2114L,2041L,2119L,2004L,2076L,2148L,2172L,2101L,2123L,2167L,2189L,2110L,2007L,2043L,2061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078286Inst : IEnumerable<long>
{
public static readonly long[] Value=A078286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078286.Bytes);
public long this[int i]=>Value[i];

public static A078286Inst Instance=new A078286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078285
{
public static readonly long[] Value={ 10L,12L,10L,14L,110L,104L,102L,114L,115L,116L,124L,111L,123L,129L,141L,106L,118L,122L,134L,142L,146L,158L,166L,178L,194L,1010L,1030L,1070L,1090L,1017L,1016L,1048L,1096L,1112L,1043L,1057L,1099L,1141L,1002L,1038L,1074L,1086L,1146L,1158L,1182L,1194L,1055L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078285Inst : IEnumerable<long>
{
public static readonly long[] Value=A078285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078285.Bytes);
public long this[int i]=>Value[i];

public static A078285Inst Instance=new A078285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078284
{
public static readonly long[] Value={ 1L,5L,34L,253L,2024L,16867L,144575L,1265032L,11235584L,101120256L,919272960L,8342666880L,77009232720L,715008573240L,6667341335024L,62500632501585L,588241236472080L,5555611677791867L,52632110631712424L,500005051001268028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078284Inst : IEnumerable<long>
{
public static readonly long[] Value=A078284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078284.Bytes);
public long this[int i]=>Value[i];

public static A078284Inst Instance=new A078284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078283
{
public static readonly long[] Value={ 1L,10L,102L,1012L,10120L,101202L,1012025L,10120256L,101120256L,1011202560L,10112002560L,100112002560L,1001120025360L,10010120025360L,100010120025360L,1000010120025360L,10000101020025360L,100001010200253606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078283Inst : IEnumerable<long>
{
public static readonly long[] Value=A078283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078283.Bytes);
public long this[int i]=>Value[i];

public static A078283Inst Instance=new A078283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078282
{
public static readonly ulong[] Value={ 1L,10L,102L,1020L,10200L,102000L,1020005L,10200056L,102000564L,1020005640L,10200056405L,1020005640504L,10200056405045L,1020005640504508L,10200056405045085L,1020005640504508512L,10200056405045085129UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078282Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A078282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078282.Bytes);
public ulong this[int i]=>Value[i];

public static A078282Inst Instance=new A078282Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078281
{
public static readonly BigInteger[] Value={ 1L,106L,11516L,1243426L,9688988696L,96978050779606L,971598777778061426L,BigInteger.Parse("9725080505141505352336"),BigInteger.Parse("101523541416869687141725106"),BigInteger.Parse("1017966959632335053323596697836") };
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
public class A078281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078281Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078281.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078281Inst Instance=new A078281Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078280
{
public static readonly long[] Value={ 2L,212L,22122L,2258577L,18913180982L,189219046321892L,1893099641364512802L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078280Inst : IEnumerable<long>
{
public static readonly long[] Value=A078280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078280.Bytes);
public long this[int i]=>Value[i];

public static A078280Inst Instance=new A078280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078279
{
public static readonly BigInteger[] Value={ 44L,4664L,486684L,49688694L,416089981604L,4162819019081624L,BigInteger.Parse("41648192110019281644"),BigInteger.Parse("416581941102112019481654"),BigInteger.Parse("4166819511041122114019581664"),BigInteger.Parse("41688196110511241142115019681684") };
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
public class A078279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078279Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078279.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078279Inst Instance=new A078279Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078278
{
public static readonly BigInteger[] Value={ 22L,2332L,253352L,27355372L,213157751312L,2133517117151332L,BigInteger.Parse("21375173111117351372"),BigInteger.Parse("213951771113113117751392"),BigInteger.Parse("2233517911171133117117952332"),BigInteger.Parse("22395273111911371173119127352392") };
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
public class A078278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078278Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078278.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078278Inst Instance=new A078278Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078277
{
public static readonly BigInteger[] Value={ 1L,121L,13941L,1577761L,176141581L,1028725268301L,12104701810650121L,BigInteger.Parse("139230653737447031941"),BigInteger.Parse("1574142902828283083413761"),BigInteger.Parse("17559792682830102828719795581"),BigInteger.Parse("102963381555591939195556174359301"),BigInteger.Parse("1211379362828828501048288283629741121") };
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
public class A078277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078277Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078277.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078277Inst Instance=new A078277Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078276
{
public static readonly long[] Value={ 2L,222L,24042L,2587862L,19460805582L,194783456187402L,1949652919092569222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078276Inst : IEnumerable<long>
{
public static readonly long[] Value=A078276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078276.Bytes);
public long this[int i]=>Value[i];

public static A078276Inst Instance=new A078276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078211
{
public static readonly long[] Value={ 1L,212L,333L,464L,525L,6156L,7007L,8128L,9639L,0L,11011L,122112L,13013L,0L,0L,162816L,1720417L,0L,1905719L,0L,212121L,0L,2320723L,244224L,25625L,0L,2743227L,287728L,2917429L,0L,3143431L,325632L,3372633L,0L,0L,3617136L,373737L,0L,393939L,0L,4136941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078211Inst : IEnumerable<long>
{
public static readonly long[] Value=A078211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078211.Bytes);
public long this[int i]=>Value[i];

public static A078211Inst Instance=new A078211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078210
{
public static readonly long[] Value={ 1L,20L,36L,48L,50L,612L,735L,832L,972L,100L,11011L,1296L,1352L,14112L,1575L,16128L,1734L,18144L,19133L,2000L,21168L,22264L,23276L,24192L,2500L,26364L,27702L,28224L,29435L,30600L,31713L,32768L,33759L,3468L,35525L,36288L,370999L,38988L,39546L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078210Inst : IEnumerable<long>
{
public static readonly long[] Value=A078210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078210.Bytes);
public long this[int i]=>Value[i];

public static A078210Inst Instance=new A078210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078209
{
public static readonly long[] Value={ 10L,21L,30L,42L,55L,65L,714L,817L,92L,1015L,1116L,1221L,1312L,1419L,1504L,1643L,177L,183L,1943L,2059L,219L,2212L,2324L,2403L,2522L,2626L,2781L,2889L,2943L,3051L,3175L,3275L,33017L,3475L,3576L,3624L,3768L,38142L,39078L,40136L,4117L,42173L,4393L,4439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078209Inst : IEnumerable<long>
{
public static readonly long[] Value=A078209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078209.Bytes);
public long this[int i]=>Value[i];

public static A078209Inst Instance=new A078209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078208
{
public static readonly long[] Value={ 2L,30L,51L,72L,110L,132L,175L,192L,234L,290L,319L,372L,416L,434L,4710L,5312L,595L,612L,6707L,7100L,735L,792L,8303L,8904L,975L,1014L,10314L,10724L,10904L,11310L,1271L,1312L,13728L,1394L,14910L,1512L,15725L,1634L,1677L,17320L,17917L,18102L,19135L,1936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078208Inst : IEnumerable<long>
{
public static readonly long[] Value=A078208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078208.Bytes);
public long this[int i]=>Value[i];

public static A078208Inst Instance=new A078208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078207
{
public static readonly BigInteger[] Value={ 1L,6L,384L,2856L,22727L,188679L,1612903L,14084506L,124999999L,112359549631L,1111234572418L,1019369022515831L,9409019496692991L,873646201597158837L,BigInteger.Parse("815363874644766139852"),BigInteger.Parse("76437144029054504848414"),BigInteger.Parse("719381682508917578872474"),BigInteger.Parse("679393593475575516018040602") };
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
public class A078207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078207Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078207.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078207Inst Instance=new A078207Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078206
{
public static readonly BigInteger[] Value={ 1L,126L,123264L,12340776L,1234553367L,123456631959L,12345677303863L,1234567810050426L,123456789137345679L,BigInteger.Parse("1234567891008671105551"),BigInteger.Parse("1234567891011073225118178"),BigInteger.Parse("123456789101112073716778055751") };
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
public class A078206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078206Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078206.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078206Inst Instance=new A078206Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078205
{
public static readonly BigInteger[] Value={ 1L,18L,261L,3502L,44003L,530004L,6200005L,71000006L,800000008L,8900000074L,8999000074522L,98099900812365L,10628099988011209L,11446281093786559142UL,BigInteger.Parse("122644629115519160114"),BigInteger.Parse("13082644736437172941406"),BigInteger.Parse("139008265613936288720365") };
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
public class A078205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078205Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078205.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078205Inst Instance=new A078205Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078204
{
public static readonly BigInteger[] Value={ 1L,216L,32103L,4321468L,543217035L,65432173824L,7654321572835L,876543212074068L,98765432187654312L,BigInteger.Parse("109876543212580239340"),BigInteger.Parse("11109876543210457373921742"),BigInteger.Parse("12111098765432151566924849880") };
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
public class A078204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078204Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078204.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078204Inst Instance=new A078204Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078203
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,14L,15L,24L,74L,191L,222L,276L,2200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078203Inst : IEnumerable<long>
{
public static readonly long[] Value=A078203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078203.Bytes);
public long this[int i]=>Value[i];

public static A078203Inst Instance=new A078203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078202
{
public static readonly BigInteger[] Value={ 2L,7L,2L,3L,7L,5L,79L,7L,431L,58049L,8375575711L,11L,13055867207L,13L,BigInteger.Parse("94233563770233419658037661865757455268745312881861761180195872329157714108064193"),-1L,130783L,17L,523927L,19L,BigInteger.Parse("2046526777460104549122039297254727662107009") };
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
public class A078202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078202Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078202.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078202Inst Instance=new A078202Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078201
{
public static readonly BigInteger[] Value={ 2L,3L,17L,5L,59604644783353249L,7L,BigInteger.Parse("4318114567396436564035293097707729426477458833"),BigInteger.Parse("205688069665150755269371147819668813122841983204711281293004769"),593L,11L };
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
public class A078201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078201Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A078201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078201.Bytes);
public BigInteger this[int i]=>Value[i];

public static A078201Inst Instance=new A078201Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078200
{
public static readonly long[] Value={ 11L,10L,1L,1L,1L,1L,1L,1L,1L,1L,10L,1L,5L,4L,3L,2L,3L,2L,2L,2L,1L,5L,5L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,4L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,3L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,2L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078200Inst : IEnumerable<long>
{
public static readonly long[] Value=A078200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078200.Bytes);
public long this[int i]=>Value[i];

public static A078200Inst Instance=new A078200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078199
{
public static readonly long[] Value={ 1100L,1010L,102L,103L,104L,105L,106L,107L,108L,109L,1100L,111L,560L,452L,342L,230L,348L,234L,236L,238L,120L,605L,610L,123L,124L,125L,126L,127L,128L,129L,130L,524L,132L,532L,134L,135L,136L,137L,138L,139L,140L,423L,142L,143L,432L,145L,146L,147L,148L,149L,150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078199Inst : IEnumerable<long>
{
public static readonly long[] Value=A078199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078199.Bytes);
public long this[int i]=>Value[i];

public static A078199Inst Instance=new A078199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078198
{
public static readonly long[] Value={ 1L,2L,4L,6L,11L,13L,18L,20L,22L,23L,26L,29L,31L,38L,45L,47L,50L,53L,72L,75L,78L,80L,87L,94L,99L,103L,107L,112L,119L,126L,131L,156L,175L,200L,205L,212L,219L,224L,228L,232L,237L,244L,256L,281L,293L,318L,330L,337L,342L,369L,374L,418L,455L,462L,499L,543L,548L,575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078198Inst : IEnumerable<long>
{
public static readonly long[] Value=A078198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078198.Bytes);
public long this[int i]=>Value[i];

public static A078198Inst Instance=new A078198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078197
{
public static readonly long[] Value={ 13L,2L,4L,17L,10L,11L,20L,1L,3L,12L,195L,200L,370L,27L,223L,201L,94L,88L,2L,108L,111L,87L,252L,16L,33L,92L,30L,62L,4L,131L,71L,189L,110L,142L,143L,17L,19L,270L,85L,106L,66L,124L,97L,134L,239L,10L,103L,25L,228L,34L,235L,93L,15L,18L,76L,301L,153L,38L,325L,11L,20L,242L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078197Inst : IEnumerable<long>
{
public static readonly long[] Value=A078197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078197.Bytes);
public long this[int i]=>Value[i];

public static A078197Inst Instance=new A078197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078196
{
public static readonly long[] Value={ 6L,9L,0L,1L,5L,2L,8L,9L,5L,6L,5L,9L,0L,8L,6L,5L,8L,3L,2L,0L,5L,7L,0L,5L,2L,4L,5L,3L,3L,4L,1L,0L,0L,8L,7L,6L,8L,1L,4L,3L,7L,7L,0L,7L,9L,0L,7L,0L,3L,9L,6L,3L,0L,9L,5L,3L,0L,7L,6L,8L,1L,3L,0L,0L,8L,8L,2L,2L,0L,0L,3L,3L,0L,4L,4L,3L,7L,8L,1L,6L,6L,7L,0L,8L,4L,4L,1L,1L,5L,3L,6L,2L,0L,8L,4L,5L,0L,5L,0L,7L,9L,9L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078196Inst : IEnumerable<long>
{
public static readonly long[] Value=A078196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078196.Bytes);
public long this[int i]=>Value[i];

public static A078196Inst Instance=new A078196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078179
{
public static readonly long[] Value={ 5L,11L,19L,29L,41L,349L,71L,89L,109L,131L,20747L,181L,2177953337809371149L,239L,271L,83537L,5849L,379L,419L,461L,2494357909L,279863L,599L,15649L,701L,19709L,811L,420707233300229L,929L,991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078179Inst : IEnumerable<long>
{
public static readonly long[] Value=A078179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078179.Bytes);
public long this[int i]=>Value[i];

public static A078179Inst Instance=new A078179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078178
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,3L,2L,2L,2L,2L,4L,2L,16L,2L,2L,4L,3L,2L,2L,2L,7L,4L,2L,3L,2L,3L,2L,10L,2L,2L,108L,3L,6L,2L,3L,7L,2L,2L,4L,2L,16L,3L,2L,2L,2L,20L,2L,7L,2L,3L,3L,2L,2L,2L,2L,9L,4L,2L,2L,7L,8L,3L,2L,2L,2L,24L,2L,6L,2L,12L,4L,3L,8L,6L,2L,4L,3L,9L,194L,3L,13L,2L,8L,2L,2L,3L,8L,2L,10L,6L,4L,2L,2L,54L,2L,132L,4L,10L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078178Inst : IEnumerable<long>
{
public static readonly long[] Value=A078178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078178.Bytes);
public long this[int i]=>Value[i];

public static A078178Inst Instance=new A078178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078177
{
public static readonly long[] Value={ 4L,8L,9L,15L,16L,20L,21L,25L,27L,32L,33L,35L,39L,42L,44L,49L,50L,51L,55L,57L,60L,64L,65L,68L,69L,77L,78L,81L,85L,87L,91L,92L,93L,95L,105L,110L,111L,112L,114L,115L,116L,119L,121L,123L,125L,128L,129L,133L,140L,141L,143L,145L,155L,156L,159L,161L,164L,169L,170L,177L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078177Inst : IEnumerable<long>
{
public static readonly long[] Value=A078177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078177.Bytes);
public long this[int i]=>Value[i];

public static A078177Inst Instance=new A078177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078176
{
public static readonly long[] Value={ 7L,11L,15L,19L,23L,27L,63L,67L,71L,75L,79L,83L,87L,91L,127L,131L,135L,139L,143L,147L,151L,155L,191L,195L,455L,715L,975L,1235L,1495L,1755L,4095L,4099L,4103L,4107L,4111L,4115L,4119L,4123L,4159L,4163L,4167L,4171L,4175L,4179L,4183L,4187L,4223L,4227L,4231L,4235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078176Inst : IEnumerable<long>
{
public static readonly long[] Value=A078176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078176.Bytes);
public long this[int i]=>Value[i];

public static A078176Inst Instance=new A078176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078175
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,20L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,42L,43L,44L,47L,49L,50L,51L,53L,55L,57L,59L,60L,61L,64L,65L,67L,68L,69L,71L,73L,77L,78L,79L,81L,83L,85L,87L,89L,91L,92L,93L,95L,97L,101L,103L,105L,107L,109L,110L,111L,112L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078175Inst : IEnumerable<long>
{
public static readonly long[] Value=A078175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078175.Bytes);
public long this[int i]=>Value[i];

public static A078175Inst Instance=new A078175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078174
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,21L,23L,25L,27L,29L,31L,32L,33L,35L,37L,39L,41L,42L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,65L,67L,69L,71L,73L,75L,77L,78L,79L,81L,83L,84L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,110L,111L,113L,114L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078174Inst : IEnumerable<long>
{
public static readonly long[] Value=A078174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078174.Bytes);
public long this[int i]=>Value[i];

public static A078174Inst Instance=new A078174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078173
{
public static readonly long[] Value={ 1L,2L,3L,2L,3L,3L,3L,4L,4L,4L,4L,6L,3L,5L,5L,6L,4L,6L,5L,6L,7L,4L,5L,6L,5L,7L,9L,7L,6L,6L,5L,8L,9L,6L,8L,8L,3L,8L,9L,10L,7L,7L,5L,10L,9L,7L,7L,12L,7L,10L,9L,9L,7L,10L,11L,12L,9L,6L,7L,10L,7L,8L,11L,12L,13L,11L,5L,11L,9L,10L,9L,12L,5L,8L,15L,10L,12L,12L,9L,12L,12L,7L,8L,14L,15L,11L,11L,12L,10L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078173Inst : IEnumerable<long>
{
public static readonly long[] Value=A078173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078173.Bytes);
public long this[int i]=>Value[i];

public static A078173Inst Instance=new A078173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078172
{
public static readonly long[] Value={ 3L,4L,8L,13L,22L,29L,40L,44L,56L,74L,84L,104L,113L,124L,133L,155L,177L,184L,207L,217L,232L,247L,266L,283L,316L,337L,342L,353L,360L,382L,434L,445L,475L,480L,522L,529L,561L,579L,589L,622L,639L,649L,692L,700L,725L,732L,787L,823L,851L,858L,871L,889L,915L,944L,982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078172Inst : IEnumerable<long>
{
public static readonly long[] Value=A078172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078172.Bytes);
public long this[int i]=>Value[i];

public static A078172Inst Instance=new A078172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078171
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,6L,7L,7L,8L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,19L,19L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,24L,24L,25L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,29L,29L,30L,30L,31L,31L,31L,31L,32L,32L,32L,33L,34L,34L,34L,34L,35L,35L,36L,36L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078171Inst : IEnumerable<long>
{
public static readonly long[] Value=A078171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078171.Bytes);
public long this[int i]=>Value[i];

public static A078171Inst Instance=new A078171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078170
{
public static readonly long[] Value={ 1L,2L,1285L,2048L,2056L,2176L,2560L,2570L,2720L,3072L,3084L,3264L,3840L,4080L,1114129L,2097152L,2097184L,2105344L,2228224L,2228258L,2236928L,2621440L,2621480L,2631680L,2785280L,2796160L,3145728L,3145776L,3158016L,3342336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078170Inst : IEnumerable<long>
{
public static readonly long[] Value=A078170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078170.Bytes);
public long this[int i]=>Value[i];

public static A078170Inst Instance=new A078170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078169
{
public static readonly long[] Value={ 1L,2L,771L,1024L,1028L,1088L,1280L,1360L,1536L,1542L,1632L,1920L,2040L,327685L,524288L,524296L,526336L,557056L,559232L,655360L,655370L,657920L,696320L,699040L,786432L,786444L,789504L,835584L,838848L,983040L,986880L,1044480L,1048560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078169Inst : IEnumerable<long>
{
public static readonly long[] Value=A078169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078169.Bytes);
public long this[int i]=>Value[i];

public static A078169Inst Instance=new A078169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078168
{
public static readonly long[] Value={ 1L,2L,257L,512L,514L,544L,640L,680L,768L,816L,960L,1020L,65537L,131072L,131074L,131584L,139264L,139808L,163840L,164480L,174080L,174760L,196608L,197376L,208896L,209712L,245760L,246720L,261120L,262140L,1682227L,1683109L,1683559L,1683937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078168Inst : IEnumerable<long>
{
public static readonly long[] Value=A078168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078168.Bytes);
public long this[int i]=>Value[i];

public static A078168Inst Instance=new A078168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078167
{
public static readonly long[] Value={ 1L,2L,255L,256L,272L,320L,340L,384L,408L,480L,510L,21845L,32768L,32896L,34816L,34952L,40960L,41120L,43520L,43690L,49152L,49344L,52224L,52428L,61440L,61680L,65280L,280999L,281587L,282637L,282949L,283897L,294409L,297449L,300409L,302039L,304399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078167Inst : IEnumerable<long>
{
public static readonly long[] Value=A078167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078167.Bytes);
public long this[int i]=>Value[i];

public static A078167Inst Instance=new A078167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078166
{
public static readonly long[] Value={ 1L,2L,85L,128L,136L,160L,170L,192L,204L,240L,4369L,8192L,8224L,8704L,8738L,10240L,10280L,10880L,12288L,12336L,13056L,15360L,15420L,16320L,47197L,47239L,47989L,49267L,49589L,50557L,51319L,52429L,52649L,55699L,57589L,57953L,59495L,63973L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078166Inst : IEnumerable<long>
{
public static readonly long[] Value=A078166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078166.Bytes);
public long this[int i]=>Value[i];

public static A078166Inst Instance=new A078166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078165
{
public static readonly long[] Value={ 1L,2L,51L,64L,68L,80L,96L,102L,120L,1285L,2048L,2056L,2176L,2560L,2570L,2720L,3072L,3084L,3264L,3840L,4080L,7957L,8227L,8279L,9079L,9139L,9709L,9919L,10355L,10595L,11667L,11673L,11691L,12099L,12393L,12483L,12753L,12987L,13797L,14715L,14763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078165Inst : IEnumerable<long>
{
public static readonly long[] Value=A078165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078165.Bytes);
public long this[int i]=>Value[i];

public static A078165Inst Instance=new A078165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078164
{
public static readonly long[] Value={ 1L,2L,17L,32L,34L,40L,48L,60L,257L,512L,514L,544L,640L,680L,768L,816L,960L,1020L,1297L,1387L,1417L,1729L,1971L,2109L,2223L,2289L,2331L,2445L,2457L,2565L,2594L,2608L,2774L,2812L,2834L,2835L,3052L,3260L,3458L,3888L,3912L,3924L,3942L,3996L,4104L,4212L,4218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078164Inst : IEnumerable<long>
{
public static readonly long[] Value=A078164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078164.Bytes);
public long this[int i]=>Value[i];

public static A078164Inst Instance=new A078164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078051
{
public static readonly long[] Value={ 1L,-2L,0L,3L,-1L,-5L,4L,7L,-10L,-8L,21L,5L,-39L,8L,65L,-42L,-96L,115L,119L,-253L,-100L,487L,-34L,-840L,421L,1293L,-1295L,-1712L,3009L,1710L,-6016L,-413L,10735L,-3893L,-17164L,14215L,24006L,-35272L,-26955L,73493L,15689L,-135720L,30849L,224902L,-150880L,-329773L,406631L,403795L,-887284L,-326937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078051Inst : IEnumerable<long>
{
public static readonly long[] Value=A078051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078051.Bytes);
public long this[int i]=>Value[i];

public static A078051Inst Instance=new A078051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078050
{
public static readonly long[] Value={ 1L,-2L,0L,4L,-4L,-4L,12L,-4L,-20L,28L,12L,-68L,44L,92L,-180L,-4L,364L,-356L,-372L,1084L,-340L,-1828L,2508L,1148L,-6164L,3868L,8460L,-16196L,-724L,33116L,-31668L,-34564L,97900L,-28772L,-167028L,224572L,109484L,-558628L,339660L,777596L,-1456916L,-98276L,3012108L,-2815556L,-3208660L,8839772L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078050Inst : IEnumerable<long>
{
public static readonly long[] Value=A078050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078050.Bytes);
public long this[int i]=>Value[i];

public static A078050Inst Instance=new A078050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078049
{
public static readonly long[] Value={ 1L,-2L,0L,5L,-7L,-3L,22L,-23L,-24L,92L,-67L,-141L,367L,-152L,-723L,1394L,-100L,-3411L,5005L,1717L,-15138L,16709L,15284L,-63840L,49981L,92983L,-256785L,120800L,485753L,-984138L,133432L,2320597L,-3571599L,-936163L,10399958L,-12099231L,-9636848L,44235268L,-37060803L,-61046581L,179403455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078049Inst : IEnumerable<long>
{
public static readonly long[] Value=A078049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078049.Bytes);
public long this[int i]=>Value[i];

public static A078049Inst Instance=new A078049Inst();

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