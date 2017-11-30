using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A130769
{
public static readonly BigInteger[] Value={ 2L,12L,BigInteger.Parse("1649253940128607650037732224082865475000"),720L,BigInteger.Parse("2032221170141662500000"),BigInteger.Parse("7372155480163603867228249918067794802791875000000") };
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
public class A130769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130769Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130769.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130769Inst Instance=new A130769Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130770
{
public static readonly long[] Value={ 1L,1L,7L,13L,7L,31L,43L,19L,73L,91L,37L,133L,157L,61L,211L,241L,91L,307L,343L,127L,421L,463L,169L,553L,601L,217L,703L,757L,271L,871L,931L,331L,1057L,1123L,397L,1261L,1333L,469L,1483L,1561L,547L,1723L,1807L,631L,1981L,2071L,721L,2257L,2353L,817L,2551L,2653L,919L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130770Inst : IEnumerable<long>
{
public static readonly long[] Value=A130770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130770.Bytes);
public long this[int i]=>Value[i];

public static A130770Inst Instance=new A130770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130771
{
public static readonly long[] Value={ 26L,44L,59L,61L,79L,86L,103L,106L,109L,125L,128L,131L,146L,149L,151L,161L,163L,166L,169L,179L,184L,187L,194L,205L,224L,236L,239L,254L,257L,265L,266L,268L,271L,274L,278L,281L,289L,293L,296L,304L,313L,316L,326L,334L,341L,346L,350L,355L,359L,364L,367L,376L,389L,391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130771Inst : IEnumerable<long>
{
public static readonly long[] Value=A130771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130771.Bytes);
public long this[int i]=>Value[i];

public static A130771Inst Instance=new A130771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130772
{
public static readonly long[] Value={ 2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130772Inst : IEnumerable<long>
{
public static readonly long[] Value=A130772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130772.Bytes);
public long this[int i]=>Value[i];

public static A130772Inst Instance=new A130772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130773
{
public static readonly long[] Value={ 0L,2L,5L,7L,9L,11L,13L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,139L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130773Inst : IEnumerable<long>
{
public static readonly long[] Value=A130773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130773.Bytes);
public long this[int i]=>Value[i];

public static A130773Inst Instance=new A130773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130774
{
public static readonly BigInteger[] Value={ 1L,13L,134L,1347L,134711L,13471118L,1347111829L,134711182947L,13471118294776L,13471118294776123L,13471118294776123199UL,BigInteger.Parse("13471118294776123199322"),BigInteger.Parse("13471118294776123199322521"),BigInteger.Parse("13471118294776123199322521843") };
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
public class A130774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130774Inst Instance=new A130774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130775
{
public static readonly BigInteger[] Value={ 0L,1L,8L,180L,604800L,68428800L,2324754432000L,640237370572800L,BigInteger.Parse("93666727314800640000"),BigInteger.Parse("20325889640780924033433600000"),BigInteger.Parse("16578303738261941164769280000000") };
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
public class A130775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130775Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130775.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130775Inst Instance=new A130775Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130824
{
public static readonly long[] Value={ 0L,2L,6L,10L,14L,18L,22L,26L,30L,34L,38L,42L,46L,50L,54L,58L,62L,66L,70L,74L,78L,82L,86L,90L,94L,98L,102L,106L,110L,114L,118L,122L,126L,130L,134L,138L,142L,146L,150L,154L,158L,162L,166L,170L,174L,178L,182L,186L,190L,194L,198L,202L,206L,210L,214L,218L,222L,226L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130824Inst : IEnumerable<long>
{
public static readonly long[] Value=A130824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130824.Bytes);
public long this[int i]=>Value[i];

public static A130824Inst Instance=new A130824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130825
{
public static readonly long[] Value={ 23L,31L,2741L,10613L,63199L,85853L,1039153L,2285291L,52962017L,66998857L,315796799L,336125837L,834972769L,1309750063L,1617454199L,2056836121L,5455816469L,9030058187L,10622144453L,237371071699L,341296396619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130825Inst : IEnumerable<long>
{
public static readonly long[] Value=A130825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130825.Bytes);
public long this[int i]=>Value[i];

public static A130825Inst Instance=new A130825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130826
{
public static readonly long[] Value={ 4L,8L,15L,16L,23L,42L,55L,200L,81L,46L,119L,192L,205L,196622L,12303L,88L,449L,558L,127L,1748L,786453L,58L,2183L,3096L,1105L,786458L,12582939L,568L,2189L,2730L,9247L,572L,8673L,3106L,2195L,8676L,145L,110630L,3819L,2200L,786473L,20202L,79L,7604L,7077933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130826Inst : IEnumerable<long>
{
public static readonly long[] Value=A130826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130826.Bytes);
public long this[int i]=>Value[i];

public static A130826Inst Instance=new A130826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130827
{
public static readonly long[] Value={ 3L,2L,1L,3L,1L,7L,3L,1L,1L,11L,2L,7L,1L,1L,7L,3L,5L,23L,4L,1L,1L,3L,2L,1L,1L,21L,14L,11L,12L,7L,16L,1L,1L,1L,26L,37L,1L,1L,4L,21L,6L,31L,4L,25L,1L,71L,14L,1L,10L,1L,10L,371L,36L,1L,3L,1L,1L,185L,2L,43L,1L,49L,104L,1L,18L,205L,70L,1L,2L,33L,38L,541L,1L,105L,8L,1L,24L,395L,30L,3L,1L,71L,20L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130827Inst : IEnumerable<long>
{
public static readonly long[] Value=A130827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130827.Bytes);
public long this[int i]=>Value[i];

public static A130827Inst Instance=new A130827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130828
{
public static readonly long[] Value={ 5L,11L,19L,29L,37L,43L,89L,97L,113L,139L,269L,311L,337L,359L,367L,433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130828Inst : IEnumerable<long>
{
public static readonly long[] Value=A130828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130828.Bytes);
public long this[int i]=>Value[i];

public static A130828Inst Instance=new A130828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130829
{
public static readonly long[] Value={ 3L,3L,5L,5L,5L,5L,7L,7L,7L,7L,7L,7L,9L,9L,9L,9L,9L,9L,9L,9L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,15L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130829Inst : IEnumerable<long>
{
public static readonly long[] Value=A130829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130829.Bytes);
public long this[int i]=>Value[i];

public static A130829Inst Instance=new A130829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130830
{
public static readonly long[] Value={ 1L,2L,3L,1L,2L,3L,2L,4L,6L,3L,6L,9L,1L,2L,3L,2L,4L,6L,3L,6L,9L,2L,4L,6L,4L,8L,12L,6L,12L,18L,3L,6L,9L,6L,12L,18L,9L,18L,27L,2L,4L,6L,4L,8L,12L,6L,12L,18L,4L,8L,12L,8L,16L,24L,12L,24L,36L,6L,12L,18L,12L,24L,36L,18L,36L,54L,3L,6L,9L,6L,12L,18L,9L,18L,27L,6L,12L,18L,12L,24L,36L,18L,36L,54L,9L,18L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130830Inst : IEnumerable<long>
{
public static readonly long[] Value=A130830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130830.Bytes);
public long this[int i]=>Value[i];

public static A130830Inst Instance=new A130830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130831
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,4L,1L,2L,2L,4L,2L,4L,4L,8L,2L,4L,4L,8L,4L,8L,8L,16L,1L,2L,2L,4L,2L,4L,4L,8L,2L,4L,4L,8L,4L,8L,8L,16L,2L,4L,4L,8L,4L,8L,8L,16L,4L,8L,8L,16L,8L,16L,16L,32L,2L,4L,4L,8L,4L,8L,8L,16L,4L,8L,8L,16L,8L,16L,16L,32L,4L,8L,8L,16L,8L,16L,16L,32L,8L,16L,16L,32L,16L,32L,32L,64L,2L,4L,4L,8L,4L,8L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130831Inst : IEnumerable<long>
{
public static readonly long[] Value=A130831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130831.Bytes);
public long this[int i]=>Value[i];

public static A130831Inst Instance=new A130831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130832
{
public static readonly BigInteger[] Value={ 20L,420L,160420L,25600160420L,BigInteger.Parse("655360000025600160420"),BigInteger.Parse("429496729600000000000655360000025600160420") };
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
public class A130832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130832Inst Instance=new A130832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130833
{
public static readonly long[] Value={ 97L,641L,706L,722L,2417L,2482L,2498L,3026L,3042L,3107L,3123L,14657L,14722L,14738L,15266L,15282L,15347L,15363L,17042L,17058L,17123L,17139L,17667L,17683L,17748L,17764L,28577L,28642L,28658L,29186L,29202L,29267L,29283L,30962L,30978L,31043L,31059L,31587L,31603L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130833Inst : IEnumerable<long>
{
public static readonly long[] Value=A130833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130833.Bytes);
public long this[int i]=>Value[i];

public static A130833Inst Instance=new A130833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130834
{
public static readonly long[] Value={ 1L,7L,9L,1L,6L,2L,2L,8L,1L,2L,0L,6L,9L,5L,9L,3L,4L,2L,4L,7L,3L,0L,5L,4L,7L,0L,8L,9L,3L,4L,2L,9L,8L,2L,4L,3L,2L,2L,6L,8L,1L,3L,4L,3L,9L,3L,1L,3L,2L,9L,5L,4L,7L,6L,7L,7L,6L,7L,5L,8L,3L,4L,7L,6L,4L,9L,9L,4L,2L,5L,0L,7L,4L,2L,3L,7L,6L,5L,7L,8L,9L,6L,0L,1L,3L,2L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130834Inst : IEnumerable<long>
{
public static readonly long[] Value=A130834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130834.Bytes);
public long this[int i]=>Value[i];

public static A130834Inst Instance=new A130834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130835
{
public static readonly BigInteger[] Value={ 1L,33L,1110L,38885L,1399986L,51333282L,1906666476L,71499999285L,2701111108410L,102631111100848L,3917722222183045L,150126888888738762L,5771538888888311735L,BigInteger.Parse("222499777777775552780"),BigInteger.Parse("8598259999999991401740"),BigInteger.Parse("332968856666666633369781"),BigInteger.Parse("12918171566666666537484951") };
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
public class A130835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130835Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130835.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130835Inst Instance=new A130835Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130836
{
public static readonly long[] Value={ 0L,1L,1L,1L,0L,1L,2L,2L,2L,2L,1L,1L,0L,1L,1L,2L,2L,3L,3L,2L,2L,1L,1L,2L,0L,2L,1L,1L,3L,2L,1L,3L,3L,1L,2L,3L,2L,2L,2L,2L,0L,2L,2L,2L,2L,2L,3L,4L,3L,3L,3L,3L,4L,3L,2L,1L,1L,1L,1L,2L,0L,2L,1L,1L,1L,1L,3L,2L,3L,4L,4L,3L,3L,4L,4L,3L,2L,3L,1L,2L,2L,2L,3L,3L,0L,3L,3L,2L,2L,2L,1L,2L,2L,2L,3L,1L,2L,4L,4L,2L,1L,3L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130836Inst : IEnumerable<long>
{
public static readonly long[] Value=A130836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130836.Bytes);
public long this[int i]=>Value[i];

public static A130836Inst Instance=new A130836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130837
{
public static readonly long[] Value={ 0L,11L,1L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,4L,1L,1L,10L,1L,1L,8L,2L,18L,2L,6L,1L,2L,1L,2L,2L,1L,1L,1L,4L,8L,2L,1L,3L,2L,19L,2L,1L,1L,2L,2L,7L,1L,7L,1L,17L,3L,3L,4L,1L,1L,87L,4L,1L,2L,11L,12L,16L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130837Inst : IEnumerable<long>
{
public static readonly long[] Value=A130837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130837.Bytes);
public long this[int i]=>Value[i];

public static A130837Inst Instance=new A130837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130838
{
public static readonly long[] Value={ 12L,112L,122L,1112L,1122L,1212L,1222L,11112L,11122L,11212L,11222L,12112L,12122L,12212L,12222L,111112L,111122L,111212L,111222L,112112L,112122L,112212L,112222L,121112L,121122L,121212L,121222L,122112L,122122L,122212L,122222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130838Inst : IEnumerable<long>
{
public static readonly long[] Value=A130838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130838.Bytes);
public long this[int i]=>Value[i];

public static A130838Inst Instance=new A130838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130839
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,3L,2L,7L,5L,5L,8L,14L,14L,8L,20L,26L,32L,15L,40L,40L,45L,22L,47L,65L,23L,77L,94L,75L,63L,98L,122L,37L,135L,196L,120L,148L,188L,117L,216L,55L,226L,231L,187L,206L,377L,187L,310L,338L,286L,366L,83L,483L,375L,99L,454L,405L,683L,284L,598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130839Inst : IEnumerable<long>
{
public static readonly long[] Value=A130839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130839.Bytes);
public long this[int i]=>Value[i];

public static A130839Inst Instance=new A130839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130904
{
public static readonly long[] Value={ 3L,4L,6L,9L,10L,15L,16L,18L,25L,27L,28L,30L,33L,34L,48L,49L,51L,52L,54L,55L,57L,58L,63L,64L,66L,91L,93L,94L,96L,99L,100L,102L,105L,106L,108L,111L,112L,114L,119L,121L,123L,124L,126L,129L,130L,169L,180L,183L,184L,186L,187L,189L,190L,195L,196L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130904Inst : IEnumerable<long>
{
public static readonly long[] Value=A130904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130904.Bytes);
public long this[int i]=>Value[i];

public static A130904Inst Instance=new A130904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130905
{
public static readonly long[] Value={ 1L,1L,3L,9L,39L,195L,1185L,8295L,66465L,598185L,5982795L,65810745L,789739335L,10266611355L,143732694105L,2155990411575L,34495848612225L,586429426407825L,10555729709800275L,200558864486205225L,4011177290378833575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130905Inst : IEnumerable<long>
{
public static readonly long[] Value=A130905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130905.Bytes);
public long this[int i]=>Value[i];

public static A130905Inst Instance=new A130905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130906
{
public static readonly long[] Value={ 1L,1L,2L,7L,28L,140L,850L,5950L,47600L,428680L,4286800L,47154800L,565873000L,7356349000L,102988886000L,1544834691400L,24717355062400L,420195036060800L,7563510839684800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130906Inst : IEnumerable<long>
{
public static readonly long[] Value=A130906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130906.Bytes);
public long this[int i]=>Value[i];

public static A130906Inst Instance=new A130906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130907
{
public static readonly long[] Value={ 1L,2L,6L,22L,98L,516L,3172L,22436L,180252L,1624888L,16258376L,178877832L,2146674136L,27907332272L,390705042288L,5860585983856L,93769421948432L,1594080384922656L,28693447925921632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130907Inst : IEnumerable<long>
{
public static readonly long[] Value=A130907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130907.Bytes);
public long this[int i]=>Value[i];

public static A130907Inst Instance=new A130907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130908
{
public static readonly BigInteger[] Value={ 1L,2L,6L,23L,106L,576L,3622L,26006L,210828L,1910096L,19162096L,211095732L,2534829376L,32962249568L,461527198056L,6923249156336L,110774157354832L,1883174989346016L,33897247428278368L,644048388555567536L,12880972761058252896UL,BigInteger.Parse("270500465268345299072"),BigInteger.Parse("5951010522336442007776"),BigInteger.Parse("136873244273143429751328") };
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
public class A130908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130908Inst Instance=new A130908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130909
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,0L,1L,2L,3L,4L,5L,6L,7L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130909Inst : IEnumerable<long>
{
public static readonly long[] Value=A130909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130909.Bytes);
public long this[int i]=>Value[i];

public static A130909Inst Instance=new A130909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130910
{
public static readonly long[] Value={ 0L,1L,3L,6L,10L,15L,21L,28L,36L,45L,55L,66L,78L,91L,105L,120L,120L,121L,123L,126L,130L,135L,141L,148L,156L,165L,175L,186L,198L,211L,225L,240L,240L,241L,243L,246L,250L,255L,261L,268L,276L,285L,295L,306L,318L,331L,345L,360L,360L,361L,363L,366L,370L,375L,381L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130910Inst : IEnumerable<long>
{
public static readonly long[] Value=A130910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130910.Bytes);
public long this[int i]=>Value[i];

public static A130910Inst Instance=new A130910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130911
{
public static readonly long[] Value={ 1L,0L,-1L,0L,1L,2L,1L,2L,1L,0L,1L,2L,3L,2L,3L,2L,3L,4L,5L,4L,5L,6L,5L,4L,5L,4L,5L,6L,7L,6L,7L,8L,9L,8L,7L,8L,9L,8L,9L,10L,11L,12L,13L,14L,13L,14L,15L,16L,17L,18L,19L,20L,21L,22L,21L,20L,19L,20L,19L,18L,19L,18L,19L,18L,19L,18L,19L,18L,17L,16L,15L,14L,15L,14L,15L,14L,13L,14L,13L,14L,15L,16L,17L,18L,19L,20L,19L,20L,19L,20L,19L,18L,19L,20L,21L,20L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130911Inst : IEnumerable<long>
{
public static readonly long[] Value=A130911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130911.Bytes);
public long this[int i]=>Value[i];

public static A130911Inst Instance=new A130911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130912
{
public static readonly long[] Value={ 1L,3L,2L,5L,3L,13L,3L,17L,1L,6L,1L,23L,25L,44L,36L,8L,36L,10L,2L,56L,19L,48L,6L,57L,92L,59L,13L,67L,83L,18L,17L,53L,30L,96L,56L,82L,67L,47L,3L,50L,148L,50L,104L,175L,135L,109L,189L,201L,68L,7L,26L,142L,247L,225L,128L,260L,109L,70L,74L,58L,78L,294L,175L,120L,175L,139L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130912Inst : IEnumerable<long>
{
public static readonly long[] Value=A130912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130912.Bytes);
public long this[int i]=>Value[i];

public static A130912Inst Instance=new A130912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130913
{
public static readonly long[] Value={ 44722206L,69067317L,460647525L,485700768L,427528099084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130913Inst : IEnumerable<long>
{
public static readonly long[] Value=A130913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130913.Bytes);
public long this[int i]=>Value[i];

public static A130913Inst Instance=new A130913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130914
{
public static readonly long[] Value={ 2L,6L,20L,70L,252L,894L,3432L,12870L,48620L,149226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130914Inst : IEnumerable<long>
{
public static readonly long[] Value=A130914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130914.Bytes);
public long this[int i]=>Value[i];

public static A130914Inst Instance=new A130914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130915
{
public static readonly long[] Value={ 0L,0L,2L,0L,24L,40L,720L,2688L,42560L,245376L,4072320L,31672960L,569935872L,5576263680L,109492807424L,1290701905920L,27616577064960L,380852962029568L,8845627365089280L,139696582370328576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130915Inst : IEnumerable<long>
{
public static readonly long[] Value=A130915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130915.Bytes);
public long this[int i]=>Value[i];

public static A130915Inst Instance=new A130915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130916
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,8L,9L,10L,12L,12L,15L,15L,15L,16L,18L,18L,20L,20L,24L,24L,24L,24L,25L,27L,27L,30L,30L,30L,32L,32L,36L,36L,36L,36L,40L,40L,40L,40L,45L,45L,45L,45L,45L,48L,48L,48L,50L,50L,54L,54L,54L,54L,60L,60L,60L,60L,60L,60L,64L,64L,64L,64L,72L,72L,72L,72L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130916Inst : IEnumerable<long>
{
public static readonly long[] Value=A130916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130916.Bytes);
public long this[int i]=>Value[i];

public static A130916Inst Instance=new A130916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130917
{
public static readonly long[] Value={ 1L,1L,2L,4L,8L,16L,23L,28L,29L,31L,35L,43L,50L,55L,56L,58L,62L,70L,77L,82L,83L,85L,89L,97L,104L,109L,110L,112L,116L,124L,131L,136L,137L,139L,143L,151L,158L,163L,164L,166L,170L,178L,185L,190L,191L,193L,197L,205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130917Inst : IEnumerable<long>
{
public static readonly long[] Value=A130917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130917.Bytes);
public long this[int i]=>Value[i];

public static A130917Inst Instance=new A130917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130918
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,6L,5L,4L,22L,21L,20L,19L,18L,17L,16L,15L,14L,13L,12L,11L,10L,9L,64L,63L,62L,61L,60L,59L,58L,57L,56L,55L,54L,53L,52L,51L,50L,49L,48L,47L,46L,45L,44L,43L,42L,41L,40L,39L,38L,37L,36L,35L,34L,33L,32L,31L,30L,29L,28L,27L,26L,25L,24L,23L,196L,195L,194L,193L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130918Inst : IEnumerable<long>
{
public static readonly long[] Value=A130918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130918.Bytes);
public long this[int i]=>Value[i];

public static A130918Inst Instance=new A130918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130919
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,5L,7L,8L,9L,11L,14L,16L,19L,10L,15L,12L,17L,18L,13L,20L,21L,22L,23L,25L,28L,30L,33L,37L,39L,42L,44L,47L,51L,53L,56L,60L,24L,29L,38L,43L,52L,26L,40L,31L,45L,54L,32L,46L,49L,50L,27L,41L,34L,48L,55L,35L,57L,58L,62L,36L,61L,59L,63L,64L,65L,67L,70L,72L,75L,79L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130919Inst : IEnumerable<long>
{
public static readonly long[] Value=A130919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130919.Bytes);
public long this[int i]=>Value[i];

public static A130919Inst Instance=new A130919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130968
{
public static readonly long[] Value={ 1L,1L,2L,3L,7L,10L,25L,54L,131L,331L,864L,2292L,6169L,16835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130968Inst : IEnumerable<long>
{
public static readonly long[] Value=A130968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130968.Bytes);
public long this[int i]=>Value[i];

public static A130968Inst Instance=new A130968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130969
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,20L,51L,128L,345L,944L,2658L,7600L,22150L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130969Inst : IEnumerable<long>
{
public static readonly long[] Value=A130969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130969.Bytes);
public long this[int i]=>Value[i];

public static A130969Inst Instance=new A130969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130970
{
public static readonly long[] Value={ 3L,2L,3L,3L,3L,5L,13L,3L,7L,13L,23L,5L,37L,11L,31L,37L,43L,29L,3L,7L,41L,47L,19L,73L,89L,37L,71L,43L,101L,97L,131L,3L,73L,11L,151L,23L,29L,131L,103L,109L,163L,53L,127L,191L,181L,71L,83L,191L,163L,101L,229L,223L,113L,283L,193L,7L,13L,239L,149L,277L,251L,37L,179L,307L,281L,61L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130970Inst : IEnumerable<long>
{
public static readonly long[] Value=A130970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130970.Bytes);
public long this[int i]=>Value[i];

public static A130970Inst Instance=new A130970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130971
{
public static readonly long[] Value={ 2L,2L,3L,3L,3L,3L,13L,3L,7L,3L,23L,5L,23L,11L,17L,11L,5L,3L,3L,7L,41L,47L,19L,73L,31L,37L,71L,43L,19L,97L,131L,3L,73L,11L,107L,23L,29L,131L,89L,83L,163L,53L,127L,191L,59L,71L,83L,191L,29L,101L,23L,17L,113L,5L,193L,7L,13L,239L,149L,277L,229L,37L,179L,307L,199L,61L,181L,353L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130971Inst : IEnumerable<long>
{
public static readonly long[] Value=A130971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130971.Bytes);
public long this[int i]=>Value[i];

public static A130971Inst Instance=new A130971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130972
{
public static readonly long[] Value={ 1L,3L,7L,11L,21L,22L,24L,30L,31L,41L,44L,55L,58L,60L,64L,68L,77L,86L,88L,94L,109L,118L,120L,126L,134L,140L,146L,151L,155L,168L,176L,181L,187L,197L,201L,204L,205L,213L,217L,221L,228L,230L,239L,251L,256L,260L,274L,286L,290L,295L,298L,450L,549L,1379L,2456L,5658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130972Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130972.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130972Inst : IEnumerable<long>
{
public static readonly long[] Value=A130972.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130972.Bytes);
public long this[int i]=>Value[i];

public static A130972Inst Instance=new A130972Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130973
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,3L,4L,2L,1L,3L,1L,2L,3L,10L,4L,7L,4L,3L,2L,1L,2L,18L,2L,2L,17L,1L,2L,6L,9L,3L,1L,1L,1L,8L,3L,2L,15L,1L,4L,1L,1L,7L,7L,4L,4L,3L,4L,1L,1L,7L,2L,5L,1L,5L,18L,2L,5L,4L,3L,1L,5L,1L,18L,12L,2L,8L,1L,4L,2L,5L,4L,1L,1L,1L,9L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130973Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130973.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130973Inst : IEnumerable<long>
{
public static readonly long[] Value=A130973.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130973.Bytes);
public long this[int i]=>Value[i];

public static A130973Inst Instance=new A130973Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130974
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L,3L,3L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130974Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130974.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130974Inst : IEnumerable<long>
{
public static readonly long[] Value=A130974.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130974.Bytes);
public long this[int i]=>Value[i];

public static A130974Inst Instance=new A130974Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130975
{
public static readonly long[] Value={ 0L,2L,3L,26L,5L,61L,7L,296L,42L,77L,942L,99L,88L,3264L,1108L,1098L,110L,13338L,55L,465L,1342L,2341L,35906L,132L,21869L,14806L,2807L,1375L,179141L,77L,1332L,16826L,17494L,45546L,1619L,394746L,3108L,376165L,1443L,192545L,5097L,53100L,49989L,2326191L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130975Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130975.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130975Inst : IEnumerable<long>
{
public static readonly long[] Value=A130975.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130975.Bytes);
public long this[int i]=>Value[i];

public static A130975Inst Instance=new A130975Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130976
{
public static readonly BigInteger[] Value={ 1L,5L,45L,485L,5725L,71445L,925965L,12335685L,167817405L,2321105525L,32536755565L,461181239205L,6598203881245L,95157851939285L,1381842797170125L,20187779510360325L,296499276685062525L,4375281190871356725L,BigInteger.Parse("64836419120040890925") };
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
public class A130976Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130976.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130976Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130976.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130976.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130976Inst Instance=new A130976Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130977
{
public static readonly long[] Value={ 1L,6L,66L,876L,12786L,197796L,3183156L,52718616L,892401426L,15368638836L,268388185596L,4741271556456L,84573471344916L,1521119577791976L,27554494253636136L,502257203287150896L,9205363627419463506L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130977Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130977.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130977Inst : IEnumerable<long>
{
public static readonly long[] Value=A130977.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130977.Bytes);
public long this[int i]=>Value[i];

public static A130977Inst Instance=new A130977Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130978
{
public static readonly long[] Value={ 1L,7L,91L,1435L,24955L,460747L,8859739L,175466347L,3553964155L,73266506635L,1532152991131L,32420721097387L,692865048943291L,14932919812627915L,324195908270339035L,7083228794200550635L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130978Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130978.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130978Inst : IEnumerable<long>
{
public static readonly long[] Value=A130978.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130978.Bytes);
public long this[int i]=>Value[i];

public static A130978Inst Instance=new A130978Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130979
{
public static readonly BigInteger[] Value={ 1L,8L,120L,2192L,44248L,949488L,21237168L,489517344L,11544312984L,277190766896L,6753051796240L,166505875155936L,4146984734796016L,104174408364697952L,2636346768784492128L,BigInteger.Parse("67149645964991840832"),BigInteger.Parse("1720072455615130558488") };
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
public class A130979Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130979.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130979Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130979.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130979.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130979Inst Instance=new A130979Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130980
{
public static readonly BigInteger[] Value={ 1L,9L,153L,3177L,73017L,1785609L,45543897L,1197639081L,32231934585L,883404542025L,24570973169433L,691759954058985L,19674867844155321L,564462038150345097L,16315646312285498457UL,BigInteger.Parse("474680922491822688297") };
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
public class A130980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130980Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A130980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130980.Bytes);
public BigInteger this[int i]=>Value[i];

public static A130980Inst Instance=new A130980Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130981
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,13L,12L,11L,10L,9L,15L,14L,16L,18L,17L,19L,20L,21L,22L,36L,35L,34L,32L,31L,33L,30L,29L,27L,26L,28L,25L,24L,23L,41L,40L,39L,38L,37L,43L,42L,47L,50L,49L,44L,48L,46L,45L,52L,51L,53L,55L,54L,56L,57L,59L,58L,60L,61L,62L,63L,64L,106L,105L,104L,101L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130981Inst : IEnumerable<long>
{
public static readonly long[] Value=A130981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130981.Bytes);
public long this[int i]=>Value[i];

public static A130981Inst Instance=new A130981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130982
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,5L,4L,7L,8L,15L,19L,16L,12L,13L,14L,9L,11L,20L,18L,10L,17L,21L,22L,52L,41L,40L,56L,60L,43L,44L,53L,34L,32L,47L,31L,35L,36L,37L,51L,42L,25L,24L,39L,28L,29L,55L,61L,33L,57L,49L,50L,38L,23L,30L,54L,45L,26L,48L,62L,59L,27L,46L,58L,63L,64L,153L,178L,164L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130982Inst : IEnumerable<long>
{
public static readonly long[] Value=A130982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130982.Bytes);
public long this[int i]=>Value[i];

public static A130982Inst Instance=new A130982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A130983
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,4L,7L,8L,13L,15L,12L,16L,19L,9L,14L,10L,18L,20L,11L,17L,21L,22L,36L,41L,35L,43L,52L,31L,40L,32L,47L,53L,34L,44L,56L,60L,25L,37L,24L,42L,51L,23L,38L,27L,50L,55L,29L,49L,57L,61L,28L,39L,26L,45L,54L,30L,46L,59L,62L,33L,48L,58L,63L,64L,106L,120L,105L,125L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A130983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A130983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A130983Inst : IEnumerable<long>
{
public static readonly long[] Value=A130983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A130983.Bytes);
public long this[int i]=>Value[i];

public static A130983Inst Instance=new A130983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131000
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,6L,4L,5L,18L,17L,20L,22L,21L,16L,19L,14L,9L,10L,15L,11L,12L,13L,50L,49L,48L,46L,45L,55L,54L,61L,64L,63L,57L,62L,59L,58L,47L,44L,53L,60L,56L,42L,51L,37L,23L,24L,38L,25L,26L,27L,43L,52L,39L,28L,29L,40L,30L,32L,31L,41L,33L,34L,36L,35L,147L,148L,146L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131000Inst : IEnumerable<long>
{
public static readonly long[] Value=A131000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131000.Bytes);
public long this[int i]=>Value[i];

public static A131000Inst Instance=new A131000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131001
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,4L,5L,19L,14L,15L,21L,22L,16L,20L,18L,12L,9L,17L,10L,13L,11L,51L,56L,60L,38L,37L,52L,40L,39L,63L,58L,41L,59L,64L,62L,53L,42L,43L,57L,61L,47L,55L,48L,32L,34L,50L,30L,24L,23L,44L,54L,49L,31L,26L,45L,25L,29L,35L,46L,27L,36L,28L,33L,163L,150L,149L,172L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131001Inst : IEnumerable<long>
{
public static readonly long[] Value=A131001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131001.Bytes);
public long this[int i]=>Value[i];

public static A131001Inst Instance=new A131001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131002
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,4L,6L,5L,18L,20L,22L,17L,21L,10L,11L,14L,19L,16L,9L,15L,12L,13L,50L,49L,57L,55L,61L,63L,58L,48L,54L,45L,64L,46L,59L,62L,27L,26L,30L,29L,33L,38L,39L,51L,56L,60L,42L,44L,53L,47L,23L,28L,37L,52L,43L,24L,40L,32L,34L,25L,41L,36L,31L,35L,147L,142L,146L,148L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131002Inst : IEnumerable<long>
{
public static readonly long[] Value=A131002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131002.Bytes);
public long this[int i]=>Value[i];

public static A131002Inst Instance=new A131002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131003
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,5L,4L,6L,22L,21L,18L,17L,20L,13L,12L,10L,9L,11L,15L,19L,16L,14L,64L,63L,59L,58L,62L,50L,49L,46L,45L,48L,55L,61L,57L,54L,36L,35L,32L,31L,34L,27L,26L,24L,23L,25L,29L,33L,30L,28L,41L,40L,52L,60L,56L,43L,47L,44L,53L,38L,51L,37L,39L,42L,196L,195L,190L,189L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131003Inst : IEnumerable<long>
{
public static readonly long[] Value=A131003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131003.Bytes);
public long this[int i]=>Value[i];

public static A131003Inst Instance=new A131003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131004
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,5L,4L,17L,16L,18L,15L,14L,22L,19L,21L,12L,11L,20L,13L,10L,9L,45L,44L,46L,43L,42L,50L,47L,49L,40L,39L,48L,41L,38L,37L,62L,60L,63L,52L,51L,64L,56L,58L,31L,30L,57L,32L,29L,28L,61L,53L,59L,36L,33L,55L,35L,26L,25L,54L,34L,27L,24L,23L,129L,128L,130L,127L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131004Inst : IEnumerable<long>
{
public static readonly long[] Value=A131004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131004.Bytes);
public long this[int i]=>Value[i];

public static A131004Inst Instance=new A131004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131005
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,6L,5L,22L,21L,17L,20L,18L,11L,10L,14L,19L,16L,9L,12L,15L,13L,64L,63L,58L,62L,59L,48L,46L,54L,61L,57L,45L,49L,55L,50L,33L,30L,26L,29L,27L,39L,38L,51L,60L,56L,42L,44L,53L,47L,28L,23L,24L,34L,32L,37L,40L,52L,43L,25L,31L,35L,41L,36L,196L,195L,189L,194L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131005Inst : IEnumerable<long>
{
public static readonly long[] Value=A131005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131005.Bytes);
public long this[int i]=>Value[i];

public static A131005Inst Instance=new A131005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131006
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,8L,7L,5L,4L,19L,15L,14L,20L,22L,16L,21L,18L,11L,13L,17L,12L,10L,9L,52L,53L,60L,39L,41L,51L,40L,38L,61L,55L,37L,54L,62L,64L,56L,43L,42L,57L,63L,47L,59L,48L,33L,29L,50L,28L,34L,36L,44L,58L,49L,30L,35L,46L,32L,25L,27L,45L,31L,26L,24L,23L,155L,151L,153L,179L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131006Inst : IEnumerable<long>
{
public static readonly long[] Value=A131006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131006.Bytes);
public long this[int i]=>Value[i];

public static A131006Inst Instance=new A131006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131007
{
public static readonly long[] Value={ 0L,1L,3L,2L,8L,7L,4L,5L,6L,22L,21L,17L,18L,20L,10L,11L,9L,13L,12L,14L,16L,19L,15L,64L,63L,58L,59L,62L,46L,48L,45L,50L,49L,54L,57L,61L,55L,27L,26L,30L,33L,29L,23L,28L,24L,36L,35L,25L,31L,32L,34L,38L,39L,42L,47L,53L,51L,44L,60L,56L,37L,43L,40L,41L,52L,196L,195L,189L,190L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131007Inst : IEnumerable<long>
{
public static readonly long[] Value=A131007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131007.Bytes);
public long this[int i]=>Value[i];

public static A131007Inst Instance=new A131007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131008
{
public static readonly long[] Value={ 0L,1L,3L,2L,6L,7L,8L,5L,4L,16L,14L,15L,18L,17L,19L,22L,20L,11L,12L,21L,13L,10L,9L,42L,44L,47L,38L,37L,43L,41L,39L,48L,49L,40L,50L,46L,45L,60L,51L,52L,62L,63L,53L,61L,57L,30L,28L,54L,29L,32L,31L,56L,64L,55L,33L,36L,59L,34L,25L,26L,58L,35L,27L,24L,23L,126L,121L,122L,131L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131008Inst : IEnumerable<long>
{
public static readonly long[] Value=A131008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131008.Bytes);
public long this[int i]=>Value[i];

public static A131008Inst Instance=new A131008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131009
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,6L,8L,4L,5L,17L,16L,18L,15L,14L,20L,19L,22L,10L,13L,21L,9L,11L,12L,45L,44L,46L,42L,43L,48L,47L,50L,40L,37L,49L,39L,41L,38L,54L,53L,55L,52L,51L,61L,60L,63L,25L,35L,62L,26L,34L,33L,57L,56L,64L,27L,36L,58L,23L,28L,32L,59L,24L,29L,30L,31L,129L,128L,130L,127L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131009Inst : IEnumerable<long>
{
public static readonly long[] Value=A131009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131009.Bytes);
public long this[int i]=>Value[i];

public static A131009Inst Instance=new A131009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131010
{
public static readonly long[] Value={ 0L,1L,3L,2L,7L,8L,5L,4L,6L,20L,17L,21L,22L,18L,13L,12L,10L,9L,11L,15L,14L,19L,16L,57L,61L,45L,48L,54L,58L,62L,63L,64L,59L,50L,49L,46L,55L,32L,36L,34L,31L,35L,26L,27L,24L,23L,25L,29L,28L,33L,30L,41L,40L,38L,37L,39L,52L,51L,56L,60L,43L,42L,47L,44L,53L,183L,169L,187L,192L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131010Inst : IEnumerable<long>
{
public static readonly long[] Value=A131010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131010.Bytes);
public long this[int i]=>Value[i];

public static A131010Inst Instance=new A131010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131011
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,45L,134L,309L,652L,1323L,2634L,5193L,10184L,19911L,38854L,133040L,412527L,1241773L,3701864L,10999194L,32642353L,96825335L,287134794L,851344708L,2523819059L,10866247001L,43994094066L,175538023511L,697843906028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131011Inst : IEnumerable<long>
{
public static readonly long[] Value=A131011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131011.Bytes);
public long this[int i]=>Value[i];

public static A131011Inst Instance=new A131011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131012
{
public static readonly BigInteger[] Value={ 0L,0L,0L,0L,0L,-2L,-3L,-3L,1L,-72L,3303L,10788L,287767L,-2441508L,41165366097L,1073195273432754L,BigInteger.Parse("155912367904160034530"),BigInteger.Parse("3136560083478359027185613587"),BigInteger.Parse("539970867097445764756784886568605205005"),BigInteger.Parse("-6513790584274345956893756600832505179138091590508595552") };
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
public class A131012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131012Inst Instance=new A131012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131013
{
public static readonly long[] Value={ 2438195760L,3785942160L,4753869120L,4876391520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131013Inst : IEnumerable<long>
{
public static readonly long[] Value=A131013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131013.Bytes);
public long this[int i]=>Value[i];

public static A131013Inst Instance=new A131013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131014
{
public static readonly long[] Value={ 4L,61L,274L,1764L,13068L,109584L,1026576L,10628640L,120543840L,1486442880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131014Inst : IEnumerable<long>
{
public static readonly long[] Value=A131014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131014.Bytes);
public long this[int i]=>Value[i];

public static A131014Inst Instance=new A131014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131015
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L,3L,3L,4L,1L,1L,3L,2L,2L,1L,4L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131015Inst : IEnumerable<long>
{
public static readonly long[] Value=A131015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131015.Bytes);
public long this[int i]=>Value[i];

public static A131015Inst Instance=new A131015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131128
{
public static readonly long[] Value={ 1L,2L,8L,20L,44L,92L,188L,380L,764L,1532L,3068L,6140L,12284L,24572L,49148L,98300L,196604L,393212L,786428L,1572860L,3145724L,6291452L,12582908L,25165820L,50331644L,100663292L,201326588L,402653180L,805306364L,1610612732L,3221225468L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131128Inst : IEnumerable<long>
{
public static readonly long[] Value=A131128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131128.Bytes);
public long this[int i]=>Value[i];

public static A131128Inst Instance=new A131128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131129
{
public static readonly long[] Value={ 1L,1L,1L,3L,4L,1L,3L,9L,7L,1L,3L,12L,18L,10L,1L,3L,15L,30L,30L,13L,1L,3L,18L,45L,60L,45L,16L,1L,3L,21L,63L,105L,105L,63L,19L,1L,3L,24L,84L,168L,210L,168L,84L,22L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131129Inst : IEnumerable<long>
{
public static readonly long[] Value=A131129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131129.Bytes);
public long this[int i]=>Value[i];

public static A131129Inst Instance=new A131129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131130
{
public static readonly long[] Value={ 1L,2L,10L,26L,58L,122L,250L,506L,1018L,2042L,4090L,8186L,16378L,32762L,65530L,131066L,262138L,524282L,1048570L,2097146L,4194298L,8388602L,16777210L,33554426L,67108858L,134217722L,268435450L,536870906L,1073741818L,2147483642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131130Inst : IEnumerable<long>
{
public static readonly long[] Value=A131130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131130.Bytes);
public long this[int i]=>Value[i];

public static A131130Inst Instance=new A131130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131131
{
public static readonly long[] Value={ 1L,1L,1L,4L,5L,1L,4L,12L,9L,1L,4L,16L,24L,13L,1L,4L,20L,40L,40L,17L,1L,4L,24L,60L,80L,60L,21L,1L,4L,28L,84L,140L,140L,84L,25L,1L,4L,32L,112L,224L,280L,224L,112L,29L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131131Inst : IEnumerable<long>
{
public static readonly long[] Value=A131131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131131.Bytes);
public long this[int i]=>Value[i];

public static A131131Inst Instance=new A131131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131132
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,22L,36L,58L,94L,152L,247L,399L,646L,1045L,1691L,2736L,4428L,7164L,11592L,18756L,30348L,49104L,79453L,128557L,208010L,336567L,544577L,881144L,1425722L,2306866L,3732588L,6039454L,9772042L,15811496L,25583539L,41395035L,66978574L,108373609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131132Inst : IEnumerable<long>
{
public static readonly long[] Value=A131132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131132.Bytes);
public long this[int i]=>Value[i];

public static A131132Inst Instance=new A131132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131133
{
public static readonly long[] Value={ 1L,2L,2L,5L,9L,14L,10L,17L,25L,34L,22L,3L,5L,18L,16L,31L,47L,64L,41L,60L,4L,25L,47L,70L,47L,72L,49L,76L,26L,55L,17L,48L,5L,38L,36L,71L,107L,144L,91L,10L,5L,46L,44L,87L,131L,176L,111L,158L,103L,152L,101L,152L,51L,104L,79L,134L,95L,8L,33L,92L,38L,99L,161L,32L,3L,68L,67L,2L,35L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131133Inst : IEnumerable<long>
{
public static readonly long[] Value=A131133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131133.Bytes);
public long this[int i]=>Value[i];

public static A131133Inst Instance=new A131133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131134
{
public static readonly long[] Value={ 1L,3L,2L,3L,8L,7L,2L,5L,14L,12L,23L,35L,48L,31L,46L,31L,48L,11L,30L,5L,26L,24L,47L,71L,96L,61L,88L,29L,2L,16L,47L,79L,112L,73L,108L,4L,41L,79L,118L,79L,120L,27L,70L,57L,34L,40L,87L,45L,94L,72L,41L,93L,146L,100L,31L,87L,48L,53L,112L,43L,104L,83L,146L,105L,34L,50L,117L,185L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131134Inst : IEnumerable<long>
{
public static readonly long[] Value=A131134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131134.Bytes);
public long this[int i]=>Value[i];

public static A131134Inst Instance=new A131134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131135
{
public static readonly long[] Value={ 1L,2L,8L,24L,64L,160L,128L,896L,2048L,4608L,10240L,22528L,16384L,106496L,229376L,491520L,1048576L,2228224L,524288L,9961472L,4194304L,6291456L,92274688L,192937984L,134217728L,838860800L,1744830464L,3623878656L,7516192768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131135Inst : IEnumerable<long>
{
public static readonly long[] Value=A131135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131135.Bytes);
public long this[int i]=>Value[i];

public static A131135Inst Instance=new A131135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131136
{
public static readonly long[] Value={ 1L,2L,4L,4L,8L,4L,8L,8L,16L,4L,8L,8L,16L,8L,16L,16L,32L,4L,8L,8L,16L,8L,16L,16L,32L,8L,16L,16L,32L,16L,32L,32L,64L,4L,8L,8L,16L,8L,16L,16L,32L,8L,16L,16L,32L,16L,32L,32L,64L,8L,16L,16L,32L,16L,32L,32L,64L,16L,32L,32L,64L,32L,64L,64L,128L,4L,8L,8L,16L,8L,16L,16L,32L,8L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131136Inst : IEnumerable<long>
{
public static readonly long[] Value=A131136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131136.Bytes);
public long this[int i]=>Value[i];

public static A131136Inst Instance=new A131136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131137
{
public static readonly long[] Value={ 1L,3L,9L,27L,27L,81L,243L,243L,729L,2187L,729L,2187L,6561L,6561L,19683L,59049L,59049L,177147L,531441L,177147L,531441L,1594323L,1594323L,4782969L,14348907L,14348907L,43046721L,129140163L,14348907L,43046721L,129140163L,129140163L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131137Inst : IEnumerable<long>
{
public static readonly long[] Value=A131137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131137.Bytes);
public long this[int i]=>Value[i];

public static A131137Inst Instance=new A131137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131138
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,4L,5L,5L,6L,7L,6L,7L,8L,8L,9L,10L,10L,11L,12L,11L,12L,13L,13L,14L,15L,15L,16L,17L,15L,16L,17L,17L,18L,19L,19L,20L,21L,20L,21L,22L,22L,23L,24L,24L,25L,26L,25L,26L,27L,27L,28L,29L,29L,30L,31L,29L,30L,31L,31L,32L,33L,33L,34L,35L,34L,35L,36L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131138Inst : IEnumerable<long>
{
public static readonly long[] Value=A131138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131138.Bytes);
public long this[int i]=>Value[i];

public static A131138Inst Instance=new A131138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131139
{
public static readonly long[] Value={ 1L,1L,4L,5L,36L,40L,145L,180L,1572L,1712L,6181L,7712L,43860L,49856L,171844L,213953L,1634448L,1798404L,6362336L,7945252L,43391232L,49532049L,169120448L,210664996L,1310330112L,1471297572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131139Inst : IEnumerable<long>
{
public static readonly long[] Value=A131139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131139.Bytes);
public long this[int i]=>Value[i];

public static A131139Inst Instance=new A131139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131140
{
public static readonly long[] Value={ 1L,1L,2L,9L,11L,19L,83L,99L,172L,1100L,1244L,2250L,8687L,10683L,18173L,67950L,82785L,140825L,665955L,780030L,1367543L,4867750L,6027860L,10149291L,35453711L,43581422L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131140Inst : IEnumerable<long>
{
public static readonly long[] Value=A131140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131140.Bytes);
public long this[int i]=>Value[i];

public static A131140Inst Instance=new A131140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131141
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,13L,12L,11L,10L,9L,15L,14L,16L,17L,18L,19L,20L,21L,22L,36L,35L,34L,32L,31L,33L,30L,29L,26L,27L,28L,25L,24L,23L,41L,40L,39L,38L,37L,43L,42L,44L,45L,46L,47L,48L,49L,50L,52L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,106L,105L,104L,101L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131141Inst : IEnumerable<long>
{
public static readonly long[] Value=A131141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131141.Bytes);
public long this[int i]=>Value[i];

public static A131141Inst Instance=new A131141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131142
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,4L,6L,7L,8L,13L,12L,11L,10L,9L,15L,14L,16L,17L,18L,19L,20L,21L,22L,36L,35L,34L,31L,32L,33L,30L,29L,27L,26L,28L,25L,24L,23L,41L,40L,39L,38L,37L,43L,42L,44L,45L,46L,47L,48L,49L,50L,52L,51L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,106L,105L,104L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131142Inst : IEnumerable<long>
{
public static readonly long[] Value=A131142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131142.Bytes);
public long this[int i]=>Value[i];

public static A131142Inst Instance=new A131142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131143
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,6L,4L,7L,8L,13L,15L,12L,16L,19L,9L,14L,10L,17L,18L,11L,20L,21L,22L,36L,41L,35L,43L,52L,31L,40L,32L,44L,47L,34L,53L,56L,60L,25L,37L,24L,42L,51L,23L,38L,26L,45L,46L,27L,48L,49L,50L,28L,39L,29L,54L,55L,30L,57L,58L,59L,33L,61L,62L,63L,64L,106L,120L,105L,125L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131143Inst : IEnumerable<long>
{
public static readonly long[] Value=A131143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131143.Bytes);
public long this[int i]=>Value[i];

public static A131143Inst Instance=new A131143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131176
{
public static readonly long[] Value={ -1L,-1L,2L,23L,101L,311L,776L,1679L,3275L,5903L,9998L,16103L,24881L,37127L,53780L,75935L,104855L,141983L,188954L,247607L,319997L,408407L,515360L,643631L,796259L,976559L,1188134L,1434887L,1721033L,2051111L,2429996L,2862911L,3355439L,3913535L,4543538L,5252183L,6046613L,6934391L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131176Inst : IEnumerable<long>
{
public static readonly long[] Value=A131176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131176.Bytes);
public long this[int i]=>Value[i];

public static A131176Inst Instance=new A131176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131177
{
public static readonly long[] Value={ 1L,4L,11L,23L,41L,67L,102L,147L,204L,274L,358L,458L,575L,710L,865L,1041L,1239L,1461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131177Inst : IEnumerable<long>
{
public static readonly long[] Value=A131177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131177.Bytes);
public long this[int i]=>Value[i];

public static A131177Inst Instance=new A131177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131178
{
public static readonly BigInteger[] Value={ 1L,2L,5L,16L,64L,308L,1730L,11104L,80176L,643232L,5676560L,54650176L,569980384L,6401959328L,77042282000L,988949446144L,13488013248256L,194780492544512L,2969094574403840L,47640794742439936L,802644553810683904L,14166772337295285248UL,BigInteger.Parse("261410917571703825920") };
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
public class A131178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131178Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131178.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131178Inst Instance=new A131178Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131179
{
public static readonly long[] Value={ 0L,1L,3L,4L,10L,11L,21L,22L,36L,37L,55L,56L,78L,79L,105L,106L,136L,137L,171L,172L,210L,211L,253L,254L,300L,301L,351L,352L,406L,407L,465L,466L,528L,529L,595L,596L,666L,667L,741L,742L,820L,821L,903L,904L,990L,991L,1081L,1082L,1176L,1177L,1275L,1276L,1378L,1379L,1485L,1486L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131179Inst : IEnumerable<long>
{
public static readonly long[] Value=A131179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131179.Bytes);
public long this[int i]=>Value[i];

public static A131179Inst Instance=new A131179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131180
{
public static readonly long[] Value={ 1L,2L,4L,14L,53L,313L,2170L,31896L,387802L,11507269L,290487893L,15905409672L,816544187208L,90196956861272L,9093799327168995L,2023727669041604444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131180Inst : IEnumerable<long>
{
public static readonly long[] Value=A131180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131180.Bytes);
public long this[int i]=>Value[i];

public static A131180Inst Instance=new A131180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131181
{
public static readonly long[] Value={ 6L,8L,10L,12L,14L,15L,18L,20L,21L,22L,26L,27L,28L,32L,33L,34L,35L,36L,38L,39L,44L,45L,46L,48L,50L,51L,52L,55L,57L,58L,60L,62L,63L,64L,65L,68L,69L,72L,74L,75L,76L,77L,80L,82L,84L,85L,86L,87L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L,106L,108L,111L,112L,115L,116L,117L,118L,119L,120L,122L,123L,124L,125L,126L,129L,132L,133L,134L,140L,141L,142L,143L,144L,145L,146L,147L,148L,150L,153L,155L,156L,158L,159L,160L,161L,162L,164L,166L,168L,171L,172L,175L,176L,177L,178L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131181Inst : IEnumerable<long>
{
public static readonly long[] Value=A131181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131181.Bytes);
public long this[int i]=>Value[i];

public static A131181Inst Instance=new A131181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131182
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,2L,2L,1L,0L,6L,8L,3L,1L,0L,24L,48L,18L,4L,1L,0L,120L,384L,162L,32L,5L,1L,0L,720L,3840L,1944L,384L,50L,6L,1L,0L,5040L,46080L,29160L,6144L,750L,72L,7L,1L,0L,40320L,645120L,524880L,122880L,15000L,1296L,98L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131182Inst : IEnumerable<long>
{
public static readonly long[] Value=A131182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131182.Bytes);
public long this[int i]=>Value[i];

public static A131182Inst Instance=new A131182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131183
{
public static readonly BigInteger[] Value={ 1L,1L,2L,1L,2L,2L,4L,2L,8L,4L,12L,8L,96L,12L,108L,96L,10368L,108L,10476L,10368L,108615168L,10476L,108625644L,108615168L,11798392572168192L,108625644L,11798392680793836L,11798392572168192L,BigInteger.Parse("139202068568601556987554268864512") };
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
public class A131183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131183Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A131183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131183.Bytes);
public BigInteger this[int i]=>Value[i];

public static A131183Inst Instance=new A131183Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131184
{
public static readonly long[] Value={ 1L,7L,6L,4L,2L,2L,6L,7L,3L,8L,6L,8L,6L,3L,6L,8L,6L,8L,6L,7L,6L,7L,2L,7L,6L,7L,6L,5L,6L,8L,3L,3L,3L,8L,6L,5L,3L,3L,3L,3L,1L,3L,3L,3L,3L,3L,6L,8L,3L,3L,1L,8L,6L,5L,6L,7L,6L,7L,2L,7L,6L,7L,6L,8L,6L,8L,6L,3L,6L,8L,6L,8L,3L,7L,6L,4L,2L,4L,6L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131184Inst : IEnumerable<long>
{
public static readonly long[] Value=A131184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131184.Bytes);
public long this[int i]=>Value[i];

public static A131184Inst Instance=new A131184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131185
{
public static readonly long[] Value={ 0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L,0L,2L,-1L,0L,-1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131185Inst : IEnumerable<long>
{
public static readonly long[] Value=A131185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131185.Bytes);
public long this[int i]=>Value[i];

public static A131185Inst Instance=new A131185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131186
{
public static readonly long[] Value={ 0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L,0L,3L,1L,0L,1L,2L,0L,2L,4L,0L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131186Inst : IEnumerable<long>
{
public static readonly long[] Value=A131186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131186.Bytes);
public long this[int i]=>Value[i];

public static A131186Inst Instance=new A131186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131187
{
public static readonly long[] Value={ 0L,0L,0L,1L,1L,2L,3L,3L,4L,6L,5L,6L,9L,8L,8L,11L,11L,12L,13L,12L,15L,18L,15L,15L,20L,20L,19L,22L,21L,22L,25L,24L,27L,28L,24L,27L,33L,32L,29L,32L,33L,34L,37L,34L,37L,42L,37L,37L,42L,42L,43L,46L,45L,44L,45L,46L,51L,54L,47L,48L,57L,54L,52L,55L,55L,58L,61L,60L,59L,62L,59L,60L,69L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131187Inst : IEnumerable<long>
{
public static readonly long[] Value=A131187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131187.Bytes);
public long this[int i]=>Value[i];

public static A131187Inst Instance=new A131187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A131188
{
public static readonly long[] Value={ 6L,13L,48L,103L,270L,508L,1001L,1413L,2724L,3052L,4859L,5668L,8029L,9062L,9608L,12558L,13828L,17319L,18823L,22781L,28077L,40162L,42359L,48113L,60703L,71793L,79161L,83792L,90129L,94954L,140436L,144445L,146452L,156704L,165199L,218110L,223095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A131188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A131188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A131188Inst : IEnumerable<long>
{
public static readonly long[] Value=A131188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A131188.Bytes);
public long this[int i]=>Value[i];

public static A131188Inst Instance=new A131188Inst();

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