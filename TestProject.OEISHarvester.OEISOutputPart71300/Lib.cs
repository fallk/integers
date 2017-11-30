using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A184421
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,41L,43L,44L,45L,46L,48L,49L,50L,52L,53L,55L,56L,57L,58L,60L,61L,63L,64L,65L,67L,68L,69L,70L,72L,73L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L,95L,96L,97L,99L,100L,101L,103L,104L,105L,107L,108L,109L,111L,112L,114L,115L,116L,117L,119L,120L,121L,123L,124L,125L,127L,128L,129L,131L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184421Inst : IEnumerable<long>
{
public static readonly long[] Value=A184421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184421.Bytes);
public long this[int i]=>Value[i];

public static A184421Inst Instance=new A184421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184422
{
public static readonly long[] Value={ 3L,7L,11L,15L,19L,23L,27L,30L,35L,39L,42L,47L,51L,54L,59L,62L,66L,71L,74L,78L,82L,86L,91L,94L,98L,102L,106L,110L,113L,118L,122L,126L,130L,134L,137L,142L,145L,149L,154L,157L,162L,165L,169L,173L,177L,181L,186L,189L,193L,197L,201L,205L,208L,213L,216L,221L,225L,228L,233L,237L,240L,245L,248L,252L,257L,260L,264L,268L,272L,276L,280L,284L,288L,292L,296L,299L,304L,308L,311L,316L,320L,323L,328L,331L,336L,340L,343L,347L,352L,355L,359L,363L,367L,371L,375L,379L,382L,387L,391L,394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184422Inst : IEnumerable<long>
{
public static readonly long[] Value=A184422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184422.Bytes);
public long this[int i]=>Value[i];

public static A184422Inst Instance=new A184422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184423
{
public static readonly BigInteger[] Value={ 1L,12L,540L,33600L,2425500L,190702512L,15849497664L,1369618398720L,121821136479900L,11079206239530000L,1025579963180813040L,BigInteger.Parse("96310511463483233280"),BigInteger.Parse("9152842704012278107200"),BigInteger.Parse("878622906816654279840000") };
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
public class A184423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184423Inst Instance=new A184423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184424
{
public static readonly BigInteger[] Value={ 1L,6L,252L,15288L,1089270L,84963060L,7023612960L,604604070720L,53620823521980L,4865593245513000L,449580815885401200L,BigInteger.Parse("42156561463105471200"),BigInteger.Parse("4001360292206427641400"),BigInteger.Parse("383704407665664889683600") };
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
public class A184424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184424Inst Instance=new A184424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184425
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,9L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,55L,56L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,109L,110L,111L,112L,113L,114L,115L,116L,117L,118L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184425Inst : IEnumerable<long>
{
public static readonly long[] Value=A184425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184425.Bytes);
public long this[int i]=>Value[i];

public static A184425Inst Instance=new A184425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184426
{
public static readonly long[] Value={ 2L,6L,10L,15L,22L,29L,37L,47L,57L,68L,80L,94L,108L,123L,139L,156L,174L,194L,214L,235L,257L,280L,304L,330L,356L,383L,411L,440L,470L,501L,534L,567L,601L,636L,672L,709L,747L,786L,826L,868L,910L,953L,997L,1042L,1088L,1135L,1183L,1232L,1283L,1334L,1386L,1439L,1493L,1548L,1604L,1661L,1719L,1778L,1839L,1900L,1962L,2025L,2089L,2154L,2220L,2287L,2355L,2424L,2494L,2566L,2638L,2711L,2785L,2860L,2936L,3013L,3091L,3170L,3250L,3331L,3413L,3496L,3581L,3666L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184426Inst : IEnumerable<long>
{
public static readonly long[] Value=A184426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184426.Bytes);
public long this[int i]=>Value[i];

public static A184426Inst Instance=new A184426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184427
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,9L,10L,11L,12L,14L,15L,16L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,97L,98L,99L,100L,101L,102L,103L,104L,105L,106L,107L,108L,109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184427Inst : IEnumerable<long>
{
public static readonly long[] Value=A184427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184427.Bytes);
public long this[int i]=>Value[i];

public static A184427Inst Instance=new A184427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184476
{
public static readonly long[] Value={ 2147931L,2386807L,2652785L,2967411L,3727073L,4808779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184476Inst : IEnumerable<long>
{
public static readonly long[] Value=A184476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184476.Bytes);
public long this[int i]=>Value[i];

public static A184476Inst Instance=new A184476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184477
{
public static readonly long[] Value={ 315L,1095L,1095L,3705L,2755L,3705L,12339L,7085L,7085L,12339L,45585L,19119L,14119L,19119L,45585L,161739L,62213L,30681L,30681L,62213L,161739L,559305L,200215L,86575L,53739L,86575L,200215L,559305L,2147931L,645837L,249953L,127689L,127689L,249953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184477Inst : IEnumerable<long>
{
public static readonly long[] Value=A184477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184477.Bytes);
public long this[int i]=>Value[i];

public static A184477Inst Instance=new A184477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184478
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,10L,11L,12L,14L,15L,16L,18L,19L,20L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,40L,41L,42L,44L,45L,46L,47L,49L,50L,51L,53L,54L,55L,57L,58L,59L,60L,62L,63L,64L,66L,67L,68L,70L,71L,72L,74L,75L,76L,77L,79L,80L,81L,83L,84L,85L,87L,88L,89L,90L,92L,93L,94L,96L,97L,98L,100L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,117L,118L,119L,120L,122L,123L,124L,126L,127L,128L,130L,131L,132L,133L,135L,136L,137L,139L,140L,141L,143L,144L,145L,146L,148L,149L,150L,152L,153L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184478Inst : IEnumerable<long>
{
public static readonly long[] Value=A184478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184478.Bytes);
public long this[int i]=>Value[i];

public static A184478Inst Instance=new A184478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184479
{
public static readonly long[] Value={ 5L,9L,13L,17L,22L,26L,30L,35L,39L,43L,48L,52L,56L,61L,65L,69L,73L,78L,82L,86L,91L,95L,99L,104L,108L,112L,116L,121L,125L,129L,134L,138L,142L,147L,151L,155L,159L,164L,168L,172L,177L,181L,185L,190L,194L,198L,202L,207L,211L,215L,220L,224L,228L,233L,237L,241L,246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184479Inst : IEnumerable<long>
{
public static readonly long[] Value=A184479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184479.Bytes);
public long this[int i]=>Value[i];

public static A184479Inst Instance=new A184479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184480
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,16L,18L,19L,20L,22L,23L,24L,26L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,40L,41L,42L,44L,45L,46L,48L,49L,50L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,65L,66L,67L,69L,70L,71L,72L,74L,75L,76L,78L,79L,80L,82L,83L,84L,85L,87L,88L,89L,91L,92L,93L,95L,96L,97L,99L,100L,101L,102L,104L,105L,106L,108L,109L,110L,112L,113L,114L,115L,117L,118L,119L,121L,122L,123L,125L,126L,127L,128L,130L,131L,132L,134L,135L,136L,138L,139L,140L,142L,143L,144L,145L,147L,148L,149L,151L,152L,153L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184480Inst : IEnumerable<long>
{
public static readonly long[] Value=A184480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184480.Bytes);
public long this[int i]=>Value[i];

public static A184480Inst Instance=new A184480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184481
{
public static readonly long[] Value={ 4L,10L,46L,85L,166L,235L,274L,361L,514L,694L,901L,1135L,1219L,1306L,1585L,1891L,2461L,2839L,3106L,3385L,3826L,3979L,4135L,5311L,5674L,6049L,6241L,6835L,7246L,8551L,9481L,10966L,11485L,11749L,12286L,12559L,13969L,15151L,15454L,17335L,18649L,18985L,19666L,21421L,21781L,22879L,23626L,24385L,26734L,27949L,28774L,30034L,32194L,33079L,33526L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184481Inst : IEnumerable<long>
{
public static readonly long[] Value=A184481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184481.Bytes);
public long this[int i]=>Value[i];

public static A184481Inst Instance=new A184481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184482
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,8L,9L,10L,11L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,26L,27L,28L,30L,31L,32L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,73L,74L,75L,77L,78L,79L,81L,82L,83L,84L,86L,87L,88L,90L,91L,92L,94L,95L,96L,97L,99L,100L,101L,103L,104L,105L,107L,108L,109L,110L,112L,113L,114L,116L,117L,118L,120L,121L,122L,123L,125L,126L,127L,129L,130L,131L,133L,134L,135L,137L,138L,139L,140L,142L,143L,144L,146L,147L,148L,150L,151L,152L,153L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184482Inst : IEnumerable<long>
{
public static readonly long[] Value=A184482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184482.Bytes);
public long this[int i]=>Value[i];

public static A184482Inst Instance=new A184482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184483
{
public static readonly long[] Value={ 3L,7L,12L,16L,20L,25L,29L,33L,37L,42L,46L,50L,55L,59L,63L,68L,72L,76L,80L,85L,89L,93L,98L,102L,106L,111L,115L,119L,124L,128L,132L,136L,141L,145L,149L,154L,158L,162L,167L,171L,175L,179L,184L,188L,192L,197L,201L,205L,210L,214L,218L,222L,227L,231L,235L,240L,244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184483Inst : IEnumerable<long>
{
public static readonly long[] Value=A184483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184483.Bytes);
public long this[int i]=>Value[i];

public static A184483Inst Instance=new A184483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184484
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,8L,9L,10L,12L,13L,14L,16L,17L,18L,20L,21L,22L,23L,25L,26L,27L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,68L,69L,70L,72L,73L,74L,76L,77L,78L,79L,81L,82L,83L,85L,86L,87L,89L,90L,91L,92L,94L,95L,96L,98L,99L,100L,102L,103L,104L,105L,107L,108L,109L,111L,112L,113L,115L,116L,117L,119L,120L,121L,122L,124L,125L,126L,128L,129L,130L,132L,133L,134L,135L,137L,138L,139L,141L,142L,143L,145L,146L,147L,148L,150L,151L,152L,154L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184484Inst : IEnumerable<long>
{
public static readonly long[] Value=A184484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184484.Bytes);
public long this[int i]=>Value[i];

public static A184484Inst Instance=new A184484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184485
{
public static readonly long[] Value={ 2L,7L,11L,15L,19L,24L,28L,32L,37L,41L,45L,50L,54L,58L,63L,67L,71L,75L,80L,84L,88L,93L,97L,101L,106L,110L,114L,118L,123L,127L,131L,136L,140L,144L,149L,153L,157L,161L,166L,170L,174L,179L,183L,187L,192L,196L,200L,204L,209L,213L,217L,222L,226L,230L,235L,239L,243L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184485Inst : IEnumerable<long>
{
public static readonly long[] Value=A184485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184485.Bytes);
public long this[int i]=>Value[i];

public static A184485Inst Instance=new A184485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184486
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,9L,10L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,59L,60L,61L,62L,64L,65L,66L,67L,69L,70L,71L,72L,73L,75L,76L,77L,78L,80L,81L,82L,83L,85L,86L,87L,88L,90L,91L,92L,93L,94L,96L,97L,98L,99L,101L,102L,103L,104L,106L,107L,108L,109L,111L,112L,113L,114L,115L,117L,118L,119L,120L,122L,123L,124L,125L,127L,128L,129L,130L,132L,133L,134L,135L,137L,138L,139L,140L,141L,143L,144L,145L,146L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184486Inst : IEnumerable<long>
{
public static readonly long[] Value=A184486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184486.Bytes);
public long this[int i]=>Value[i];

public static A184486Inst Instance=new A184486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184487
{
public static readonly long[] Value={ 6L,11L,16L,21L,26L,32L,37L,42L,47L,53L,58L,63L,68L,74L,79L,84L,89L,95L,100L,105L,110L,116L,121L,126L,131L,136L,142L,147L,152L,157L,163L,168L,173L,178L,184L,189L,194L,199L,205L,210L,215L,220L,225L,231L,236L,241L,246L,252L,257L,262L,267L,273L,278L,283L,288L,294L,299L,304L,309L,314L,320L,325L,330L,335L,341L,346L,351L,356L,362L,367L,372L,377L,383L,388L,393L,398L,403L,409L,414L,419L,424L,430L,435L,440L,445L,451L,456L,461L,466L,472L,477L,482L,487L,492L,498L,503L,508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184487Inst : IEnumerable<long>
{
public static readonly long[] Value=A184487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184487.Bytes);
public long this[int i]=>Value[i];

public static A184487Inst Instance=new A184487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184488
{
public static readonly BigInteger[] Value={ 31L,1983L,421879L,460055427L,2002349014445L,39657122226381527L,BigInteger.Parse("3342508236591318287277"),BigInteger.Parse("1238778403260497748171275569"),BigInteger.Parse("1987238481358577950495683464612101") };
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
public class A184488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184488Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184488.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184488Inst Instance=new A184488Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184489
{
public static readonly long[] Value={ 31L,165L,792L,3971L,19593L,97312L,482071L,2390621L,11850280L,58751643L,291260673L,1443961520L,7158542031L,35489140405L,175940409400L,872240066291L,4324205636281L,21437626315584L,106278895767879L,526886873434445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184489Inst : IEnumerable<long>
{
public static readonly long[] Value=A184489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184489.Bytes);
public long this[int i]=>Value[i];

public static A184489Inst Instance=new A184489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184490
{
public static readonly long[] Value={ 165L,1983L,20514L,225739L,2429833L,26384550L,285552669L,3094453927L,33517063586L,363104617411L,3933373186569L,42609958428230L,461585542594517L,5000289770972767L,54167328433304858L,586786270194480467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184490Inst : IEnumerable<long>
{
public static readonly long[] Value=A184490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184490.Bytes);
public long this[int i]=>Value[i];

public static A184490Inst Instance=new A184490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184491
{
public static readonly BigInteger[] Value={ 792L,20514L,421879L,9573698L,209361859L,4649028105L,102612963762L,2270452765634L,50187203345248L,1109807953423781L,24537612768982878L,542556880890398985L,11996283587851942891UL,BigInteger.Parse("265248437061417663664") };
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
public class A184491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184491Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184491.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184491Inst Instance=new A184491Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184540
{
public static readonly long[] Value={ 45L,89L,147L,220L,309L,415L,539L,682L,845L,1029L,1235L,1464L,1717L,1995L,2299L,2630L,2989L,3377L,3795L,4244L,4725L,5239L,5787L,6370L,6989L,7645L,8339L,9072L,9845L,10659L,11515L,12414L,13357L,14345L,15379L,16460L,17589L,18767L,19995L,21274L,22605L,23989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184540Inst : IEnumerable<long>
{
public static readonly long[] Value=A184540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184540.Bytes);
public long this[int i]=>Value[i];

public static A184540Inst Instance=new A184540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184541
{
public static readonly long[] Value={ 89L,193L,340L,537L,792L,1114L,1513L,2000L,2587L,3287L,4114L,5083L,6210L,7512L,9007L,10714L,12653L,14845L,17312L,20077L,23164L,26598L,30405L,34612L,39247L,44339L,49918L,56015L,62662L,69892L,77739L,86238L,95425L,105337L,116012L,127489L,139808L,153010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184541Inst : IEnumerable<long>
{
public static readonly long[] Value=A184541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184541.Bytes);
public long this[int i]=>Value[i];

public static A184541Inst Instance=new A184541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184542
{
public static readonly long[] Value={ 147L,340L,631L,1048L,1627L,2413L,3461L,4837L,6619L,8898L,11779L,15382L,19843L,25315L,31969L,39995L,49603L,61024L,74511L,90340L,108811L,130249L,155005L,183457L,216011L,253102L,295195L,342786L,396403L,456607L,523993L,599191L,682867L,775724L,878503L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184542Inst : IEnumerable<long>
{
public static readonly long[] Value=A184542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184542.Bytes);
public long this[int i]=>Value[i];

public static A184542Inst Instance=new A184542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184543
{
public static readonly long[] Value={ 220L,537L,1048L,1837L,3024L,4774L,7307L,10909L,15944L,22867L,32238L,44737L,61180L,82536L,109945L,144737L,188452L,242861L,309988L,392133L,491896L,612202L,756327L,927925L,1131056L,1370215L,1650362L,1976953L,2355972L,2793964L,3298069L,3876057L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184543Inst : IEnumerable<long>
{
public static readonly long[] Value=A184543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184543.Bytes);
public long this[int i]=>Value[i];

public static A184543Inst Instance=new A184543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184544
{
public static readonly long[] Value={ 309L,792L,1627L,3024L,5313L,8989L,14767L,23648L,36997L,56634L,84939L,124972L,180609L,256695L,359215L,495484L,674357L,906460L,1204443L,1583256L,2060449L,2656497L,3395151L,4303816L,5413957L,6761534L,8387467L,10338132L,12665889L,15429643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184544Inst : IEnumerable<long>
{
public static readonly long[] Value=A184544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184544.Bytes);
public long this[int i]=>Value[i];

public static A184544Inst Instance=new A184544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184545
{
public static readonly long[] Value={ 415L,1114L,2413L,4774L,8989L,16345L,28844L,49489L,82648L,134509L,213640L,331669L,504100L,751282L,1099549L,1582550L,2242789L,3133396L,4320151L,5883784L,7922575L,10555279L,13924402L,18199855L,23583014L,30311215L,38662714L,48962143L,61586494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184545Inst : IEnumerable<long>
{
public static readonly long[] Value=A184545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184545.Bytes);
public long this[int i]=>Value[i];

public static A184545Inst Instance=new A184545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184546
{
public static readonly long[] Value={ 539L,1513L,3461L,7307L,14767L,28844L,54543L,99872L,177207L,305112L,510719L,832788L,1325583L,2063717L,3148137L,4713439L,6936723L,10048219L,14343937L,20200617L,28093279L,38615698L,52504155L,70664842L,94205327L,124470514L,163083563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184546Inst : IEnumerable<long>
{
public static readonly long[] Value=A184546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184546.Bytes);
public long this[int i]=>Value[i];

public static A184546Inst Instance=new A184546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184547
{
public static readonly long[] Value={ 682L,2000L,4837L,10909L,23648L,49489L,99872L,194245L,364432L,660821L,1160932L,1981045L,3291704L,5338066L,8466235L,13156911L,20067894L,30087214L,44398911L,64563765L,92617576L,131189919L,183646650L,254259817L,348409036L,472818827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184547Inst : IEnumerable<long>
{
public static readonly long[] Value=A184547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184547.Bytes);
public long this[int i]=>Value[i];

public static A184547Inst Instance=new A184547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184548
{
public static readonly long[] Value={ 45L,89L,89L,147L,193L,147L,220L,340L,340L,220L,309L,537L,631L,537L,309L,415L,792L,1048L,1048L,792L,415L,539L,1114L,1627L,1837L,1627L,1114L,539L,682L,1513L,2413L,3024L,3024L,2413L,1513L,682L,845L,2000L,3461L,4774L,5313L,4774L,3461L,2000L,845L,1029L,2587L,4837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184548Inst : IEnumerable<long>
{
public static readonly long[] Value=A184548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184548.Bytes);
public long this[int i]=>Value[i];

public static A184548Inst Instance=new A184548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184549
{
public static readonly long[] Value={ 0L,6L,17L,23L,28L,34L,45L,51L,56L,62L,73L,79L,84L,90L,101L,107L,112L,118L,129L,135L,140L,146L,157L,163L,168L,174L,185L,191L,196L,202L,213L,219L,224L,230L,241L,247L,252L,258L,269L,275L,280L,286L,297L,303L,308L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184549Inst : IEnumerable<long>
{
public static readonly long[] Value=A184549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184549.Bytes);
public long this[int i]=>Value[i];

public static A184549Inst Instance=new A184549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184550
{
public static readonly long[] Value={ 0L,6L,11L,17L,28L,34L,39L,45L,56L,62L,67L,73L,84L,90L,95L,101L,112L,118L,123L,129L,140L,146L,151L,157L,168L,174L,179L,185L,196L,202L,207L,213L,224L,230L,235L,241L,252L,258L,263L,269L,280L,286L,291L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184550Inst : IEnumerable<long>
{
public static readonly long[] Value=A184550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184550.Bytes);
public long this[int i]=>Value[i];

public static A184550Inst Instance=new A184550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184551
{
public static readonly long[] Value={ 0L,11L,17L,22L,28L,39L,45L,50L,56L,67L,73L,78L,84L,95L,101L,106L,112L,123L,129L,134L,140L,151L,157L,162L,168L,179L,185L,190L,196L,207L,213L,218L,224L,235L,241L,246L,252L,263L,269L,274L,280L,291L,297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184551Inst : IEnumerable<long>
{
public static readonly long[] Value=A184551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184551.Bytes);
public long this[int i]=>Value[i];

public static A184551Inst Instance=new A184551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184552
{
public static readonly long[] Value={ 0L,5L,11L,22L,28L,33L,39L,50L,56L,61L,67L,78L,84L,89L,95L,106L,112L,117L,123L,134L,140L,145L,151L,162L,168L,173L,179L,190L,196L,201L,207L,218L,224L,229L,235L,246L,252L,257L,263L,274L,280L,285L,291L,302L,308L,313L,319L,330L,336L,341L,347L,358L,364L,369L,375L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184552Inst : IEnumerable<long>
{
public static readonly long[] Value=A184552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184552.Bytes);
public long this[int i]=>Value[i];

public static A184552Inst Instance=new A184552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184553
{
public static readonly long[] Value={ 1L,6L,79L,1158L,17851L,283246L,4579306L,75013112L,1240774907L,20677408080L,346638007264L,5839169781594L,98755770443674L,1675855850883818L,28520685212980872L,486589040917153648L,8319672542504635643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184553Inst : IEnumerable<long>
{
public static readonly long[] Value=A184553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184553.Bytes);
public long this[int i]=>Value[i];

public static A184553Inst Instance=new A184553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184554
{
public static readonly long[] Value={ 1L,3L,35L,474L,6891L,104360L,1623050L,25718472L,413215707L,6710439939L,109904635992L,1812533851286L,30064278051066L,501094410251724L,8386624585529736L,140867399832201392L,2373517896651329211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184554Inst : IEnumerable<long>
{
public static readonly long[] Value=A184554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184554.Bytes);
public long this[int i]=>Value[i];

public static A184554Inst Instance=new A184554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184555
{
public static readonly BigInteger[] Value={ 50L,5736L,3436266L,12900566348L,276510402290782L,BigInteger.Parse("35245029137091490532"),BigInteger.Parse("26246732217663407375879655"),BigInteger.Parse("115019923806287297509943176811916"),BigInteger.Parse("2957519612846906106776158316962863659667") };
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
public class A184555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184555Inst Instance=new A184555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184572
{
public static readonly long[] Value={ 107058241L,2816118529L,43935544294L,503785839330L,4626643143791L,35627770917826L,236912838360594L,1389863286849772L,7315301238941444L,35019093954902897L,154213012365058057L,630709975793568592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184572Inst : IEnumerable<long>
{
public static readonly long[] Value=A184572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184572.Bytes);
public long this[int i]=>Value[i];

public static A184572Inst Instance=new A184572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184573
{
public static readonly long[] Value={ 318063303L,9696377100L,171891306894L,2213469458762L,22587829272879L,191432663548535L,1389863286849772L,8847094859463950L,50288280003912690L,259097398200707061L,1225103456113642803L,5371748111324539632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184573Inst : IEnumerable<long>
{
public static readonly long[] Value=A184573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184573.Bytes);
public long this[int i]=>Value[i];

public static A184573Inst Instance=new A184573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184574
{
public static readonly long[] Value={ 14178L,102445L,102445L,545662L,993538L,545662L,2430950L,6803631L,6803631L,2430950L,9496395L,37767705L,57374460L,37767705L,9496395L,33351260L,179122657L,380532059L,380532059L,179122657L,33351260L,107058241L,748499580L,2113138210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184574Inst : IEnumerable<long>
{
public static readonly long[] Value=A184574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184574.Bytes);
public long this[int i]=>Value[i];

public static A184574Inst Instance=new A184574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184575
{
public static readonly BigInteger[] Value={ 1L,1L,3L,30L,892L,76554L,19138212L,14126533902L,31053145918644L,204151364083796877L,BigInteger.Parse("4021430292908836847748"),BigInteger.Parse("237530957105884844479669995"),BigInteger.Parse("42082478775006270167542801189164"),BigInteger.Parse("22365250673182738144111737076795384386") };
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
public class A184575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184575Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184575.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184575Inst Instance=new A184575Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184576
{
public static readonly BigInteger[] Value={ 1L,1L,4L,70L,4772L,1256737L,1300189840L,5343387957552L,87635577037531120L,BigInteger.Parse("5745017883201162928720"),BigInteger.Parse("1506152833843572741772875256"),BigInteger.Parse("1579354544764797425414872390884936"),BigInteger.Parse("6624338541974058042578557252396267711144") };
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
public class A184576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184576Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184576.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184576Inst Instance=new A184576Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184577
{
public static readonly BigInteger[] Value={ 1L,1L,5L,135L,17635L,11196380L,35146865626L,549810415675025L,BigInteger.Parse("42966178319025765725"),BigInteger.Parse("16784792206658535573353275"),BigInteger.Parse("32783305434744311217446987595100"),BigInteger.Parse("320150590803319511079060107920058643150") };
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
public class A184577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184577Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184577.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184577Inst Instance=new A184577Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184578
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,10L,11L,13L,14L,16L,17L,18L,20L,21L,23L,24L,25L,27L,28L,30L,31L,32L,34L,35L,37L,38L,40L,41L,42L,44L,45L,47L,48L,49L,51L,52L,54L,55L,57L,58L,59L,61L,62L,64L,65L,66L,68L,69L,71L,72L,74L,75L,76L,78L,79L,81L,82L,83L,85L,86L,88L,89L,90L,92L,93L,95L,96L,98L,99L,100L,102L,103L,105L,106L,107L,109L,110L,112L,113L,115L,116L,117L,119L,120L,122L,123L,124L,126L,127L,129L,130L,131L,133L,134L,136L,137L,139L,140L,141L,143L,144L,146L,147L,148L,150L,151L,153L,154L,156L,157L,158L,160L,161L,163L,164L,165L,167L,168L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184578Inst : IEnumerable<long>
{
public static readonly long[] Value=A184578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184578.Bytes);
public long this[int i]=>Value[i];

public static A184578Inst Instance=new A184578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184579
{
public static readonly long[] Value={ 2L,5L,9L,12L,15L,19L,22L,26L,29L,33L,36L,39L,43L,46L,50L,53L,56L,60L,63L,67L,70L,73L,77L,80L,84L,87L,91L,94L,97L,101L,104L,108L,111L,114L,118L,121L,125L,128L,132L,135L,138L,142L,145L,149L,152L,155L,159L,162L,166L,169L,172L,176L,179L,183L,186L,190L,193L,196L,200L,203L,207L,210L,213L,217L,220L,224L,227L,231L,234L,237L,241L,244L,248L,251L,254L,258L,261L,265L,268L,271L,275L,278L,282L,285L,289L,292L,295L,299L,302L,306L,309L,312L,316L,319L,323L,326L,330L,333L,336L,340L,343L,347L,350L,353L,357L,360L,364L,367L,371L,374L,377L,381L,384L,388L,391L,394L,398L,401L,405L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184579Inst : IEnumerable<long>
{
public static readonly long[] Value=A184579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184579.Bytes);
public long this[int i]=>Value[i];

public static A184579Inst Instance=new A184579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184580
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,8L,9L,10L,12L,13L,15L,16L,18L,19L,20L,22L,23L,25L,26L,27L,29L,30L,32L,33L,35L,36L,37L,39L,40L,42L,43L,44L,46L,47L,49L,50L,51L,53L,54L,56L,57L,59L,60L,61L,63L,64L,66L,67L,68L,70L,71L,73L,74L,76L,77L,78L,80L,81L,83L,84L,85L,87L,88L,90L,91L,92L,94L,95L,97L,98L,100L,101L,102L,104L,105L,107L,108L,109L,111L,112L,114L,115L,117L,118L,119L,121L,122L,124L,125L,126L,128L,129L,131L,132L,133L,135L,136L,138L,139L,141L,142L,143L,145L,146L,148L,149L,150L,152L,153L,155L,156L,158L,159L,160L,162L,163L,165L,166L,167L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184580Inst : IEnumerable<long>
{
public static readonly long[] Value=A184580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184580.Bytes);
public long this[int i]=>Value[i];

public static A184580Inst Instance=new A184580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184581
{
public static readonly long[] Value={ 4L,7L,11L,14L,17L,21L,24L,28L,31L,34L,38L,41L,45L,48L,52L,55L,58L,62L,65L,69L,72L,75L,79L,82L,86L,89L,93L,96L,99L,103L,106L,110L,113L,116L,120L,123L,127L,130L,134L,137L,140L,144L,147L,151L,154L,157L,161L,164L,168L,171L,174L,178L,181L,185L,188L,192L,195L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184581Inst : IEnumerable<long>
{
public static readonly long[] Value=A184581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184581.Bytes);
public long this[int i]=>Value[i];

public static A184581Inst Instance=new A184581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184582
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,11L,13L,14L,16L,18L,19L,21L,22L,24L,26L,27L,29L,31L,32L,34L,35L,37L,39L,40L,42L,44L,45L,47L,48L,50L,52L,53L,55L,56L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,77L,79L,81L,82L,84L,86L,87L,89L,90L,92L,94L,95L,97L,99L,100L,102L,103L,105L,107L,108L,110L,111L,113L,115L,116L,118L,120L,121L,123L,124L,126L,128L,129L,131L,133L,134L,136L,137L,139L,141L,142L,144L,145L,147L,149L,150L,152L,154L,155L,157L,158L,160L,162L,163L,165L,166L,168L,170L,171L,173L,175L,176L,178L,179L,181L,183L,184L,186L,188L,189L,191L,192L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184582Inst : IEnumerable<long>
{
public static readonly long[] Value=A184582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184582.Bytes);
public long this[int i]=>Value[i];

public static A184582Inst Instance=new A184582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184583
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,15L,17L,20L,23L,25L,28L,30L,33L,36L,38L,41L,43L,46L,49L,51L,54L,57L,59L,62L,64L,67L,70L,72L,75L,78L,80L,83L,85L,88L,91L,93L,96L,98L,101L,104L,106L,109L,112L,114L,117L,119L,122L,125L,127L,130L,132L,135L,138L,140L,143L,146L,148L,151L,153L,156L,159L,161L,164L,167L,169L,172L,174L,177L,180L,182L,185L,187L,190L,193L,195L,198L,201L,203L,206L,208L,211L,214L,216L,219L,222L,224L,227L,229L,232L,235L,237L,240L,242L,245L,248L,250L,253L,256L,258L,261L,263L,266L,269L,271L,274L,276L,279L,282L,284L,287L,290L,292L,295L,297L,300L,303L,305L,308L,311L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184583Inst : IEnumerable<long>
{
public static readonly long[] Value=A184583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184583.Bytes);
public long this[int i]=>Value[i];

public static A184583Inst Instance=new A184583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184584
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,12L,14L,17L,19L,21L,23L,26L,28L,30L,32L,35L,37L,39L,41L,43L,46L,48L,50L,52L,55L,57L,59L,61L,64L,66L,68L,70L,73L,75L,77L,79L,81L,84L,86L,88L,90L,93L,95L,97L,99L,102L,104L,106L,108L,111L,113L,115L,117L,120L,122L,124L,126L,128L,131L,133L,135L,137L,140L,142L,144L,146L,149L,151L,153L,155L,158L,160L,162L,164L,166L,169L,171L,173L,175L,178L,180L,182L,184L,187L,189L,191L,193L,196L,198L,200L,202L,204L,207L,209L,211L,213L,216L,218L,220L,222L,225L,227L,229L,231L,234L,236L,238L,240L,242L,245L,247L,249L,251L,254L,256L,258L,260L,263L,265L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184584Inst : IEnumerable<long>
{
public static readonly long[] Value=A184584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184584.Bytes);
public long this[int i]=>Value[i];

public static A184584Inst Instance=new A184584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184585
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,11L,13L,15L,16L,18L,20L,22L,24L,25L,27L,29L,31L,33L,34L,36L,38L,40L,42L,44L,45L,47L,49L,51L,53L,54L,56L,58L,60L,62L,63L,65L,67L,69L,71L,72L,74L,76L,78L,80L,82L,83L,85L,87L,89L,91L,92L,94L,96L,98L,100L,101L,103L,105L,107L,109L,110L,112L,114L,116L,118L,119L,121L,123L,125L,127L,129L,130L,132L,134L,136L,138L,139L,141L,143L,145L,147L,148L,150L,152L,154L,156L,157L,159L,161L,163L,165L,167L,168L,170L,172L,174L,176L,177L,179L,181L,183L,185L,186L,188L,190L,192L,194L,195L,197L,199L,201L,203L,205L,206L,208L,210L,212L,214L,215L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184585Inst : IEnumerable<long>
{
public static readonly long[] Value=A184585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184585.Bytes);
public long this[int i]=>Value[i];

public static A184585Inst Instance=new A184585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184586
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,12L,14L,16L,19L,21L,23L,25L,27L,30L,32L,34L,36L,39L,41L,43L,45L,48L,50L,52L,54L,57L,59L,61L,63L,65L,68L,70L,72L,74L,77L,79L,81L,83L,86L,88L,90L,92L,95L,97L,99L,101L,103L,106L,108L,110L,112L,115L,117L,119L,121L,124L,126L,128L,130L,133L,135L,137L,139L,141L,144L,146L,148L,150L,153L,155L,157L,159L,162L,164L,166L,168L,171L,173L,175L,177L,180L,182L,184L,186L,188L,191L,193L,195L,197L,200L,202L,204L,206L,209L,211L,213L,215L,218L,220L,222L,224L,226L,229L,231L,233L,235L,238L,240L,242L,244L,247L,249L,251L,253L,256L,258L,260L,262L,264L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184586Inst : IEnumerable<long>
{
public static readonly long[] Value=A184586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184586.Bytes);
public long this[int i]=>Value[i];

public static A184586Inst Instance=new A184586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184587
{
public static readonly long[] Value={ 2L,4L,6L,8L,9L,11L,13L,15L,17L,18L,20L,22L,24L,26L,28L,29L,31L,33L,35L,37L,38L,40L,42L,44L,46L,47L,49L,51L,53L,55L,56L,58L,60L,62L,64L,66L,67L,69L,71L,73L,75L,76L,78L,80L,82L,84L,85L,87L,89L,91L,93L,94L,96L,98L,100L,102L,104L,105L,107L,109L,111L,113L,114L,116L,118L,120L,122L,123L,125L,127L,129L,131L,132L,134L,136L,138L,140L,142L,143L,145L,147L,149L,151L,152L,154L,156L,158L,160L,161L,163L,165L,167L,169L,170L,172L,174L,176L,178L,179L,181L,183L,185L,187L,189L,190L,192L,194L,196L,198L,199L,201L,203L,205L,207L,208L,210L,212L,214L,216L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184587Inst : IEnumerable<long>
{
public static readonly long[] Value=A184587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184587.Bytes);
public long this[int i]=>Value[i];

public static A184587Inst Instance=new A184587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184748
{
public static readonly long[] Value={ 1L,3L,4L,6L,8L,10L,11L,13L,15L,17L,18L,20L,22L,24L,25L,27L,29L,31L,33L,34L,36L,38L,40L,41L,43L,45L,47L,48L,50L,52L,54L,55L,57L,59L,61L,63L,64L,66L,68L,70L,71L,73L,75L,77L,78L,80L,82L,84L,85L,87L,89L,91L,92L,94L,96L,98L,100L,101L,103L,105L,107L,108L,110L,112L,114L,115L,117L,119L,121L,122L,124L,126L,128L,130L,131L,133L,135L,137L,138L,140L,142L,144L,145L,147L,149L,151L,152L,154L,156L,158L,160L,161L,163L,165L,167L,168L,170L,172L,174L,175L,177L,179L,181L,182L,184L,186L,188L,190L,191L,193L,195L,197L,198L,200L,202L,204L,205L,207L,209L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184748Inst : IEnumerable<long>
{
public static readonly long[] Value=A184748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184748.Bytes);
public long this[int i]=>Value[i];

public static A184748Inst Instance=new A184748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184749
{
public static readonly long[] Value={ 2L,5L,7L,9L,12L,14L,16L,19L,21L,23L,26L,28L,30L,32L,35L,37L,39L,42L,44L,46L,49L,51L,53L,56L,58L,60L,62L,65L,67L,69L,72L,74L,76L,79L,81L,83L,86L,88L,90L,93L,95L,97L,99L,102L,104L,106L,109L,111L,113L,116L,118L,120L,123L,125L,127L,129L,132L,134L,136L,139L,141L,143L,146L,148L,150L,153L,155L,157L,159L,162L,164L,166L,169L,171L,173L,176L,178L,180L,183L,185L,187L,189L,192L,194L,196L,199L,201L,203L,206L,208L,210L,213L,215L,217L,220L,222L,224L,226L,229L,231L,233L,236L,238L,240L,243L,245L,247L,250L,252L,254L,256L,259L,261L,263L,266L,268L,270L,273L,275L,277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184749Inst : IEnumerable<long>
{
public static readonly long[] Value=A184749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184749.Bytes);
public long this[int i]=>Value[i];

public static A184749Inst Instance=new A184749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184750
{
public static readonly long[] Value={ 0L,0L,0L,0L,19L,32L,48L,67L,89L,114L,142L,173L,207L,244L,284L,327L,373L,422L,474L,529L,587L,648L,712L,779L,849L,922L,998L,1077L,1159L,1244L,1332L,1423L,1517L,1614L,1714L,1817L,1923L,2032L,2144L,2259L,2377L,2498L,2622L,2749L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184750Inst : IEnumerable<long>
{
public static readonly long[] Value=A184750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184750.Bytes);
public long this[int i]=>Value[i];

public static A184750Inst Instance=new A184750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184751
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,1L,2L,1L,1L,3L,2L,1L,3L,4L,4L,3L,1L,2L,6L,1L,1L,9L,8L,1L,3L,2L,2L,3L,1L,4L,12L,1L,1L,6L,2L,1L,3L,16L,16L,9L,1L,2L,19L,1L,1L,12L,4L,19L,9L,2L,2L,3L,1L,8L,24L,1L,1L,18L,23L,1L,3L,19L,4L,3L,1L,23L,19L,1L,1L,32L,16L,1L,3L,2L,2L,27L,1L,4L,12L,1L,19L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184751Inst : IEnumerable<long>
{
public static readonly long[] Value=A184751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184751.Bytes);
public long this[int i]=>Value[i];

public static A184751Inst Instance=new A184751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184752
{
public static readonly long[] Value={ 0L,0L,16L,13L,26L,26L,18L,40L,43L,40L,48L,41L,60L,64L,66L,65L,74L,74L,64L,86L,97L,96L,99L,100L,106L,112L,115L,110L,123L,120L,122L,129L,146L,143L,152L,144L,163L,160L,169L,170L,170L,173L,168L,178L,184L,186L,185L,183L,202L,202L,214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184752Inst : IEnumerable<long>
{
public static readonly long[] Value=A184752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184752.Bytes);
public long this[int i]=>Value[i];

public static A184752Inst Instance=new A184752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184753
{
public static readonly long[] Value={ 0L,0L,4L,1L,13L,2L,1L,10L,1L,5L,16L,1L,15L,16L,22L,5L,37L,2L,4L,2L,1L,24L,11L,10L,2L,28L,23L,11L,41L,20L,2L,3L,73L,13L,76L,12L,1L,20L,13L,85L,34L,1L,21L,2L,46L,62L,5L,3L,2L,2L,2L,1L,2L,78L,39L,80L,81L,122L,3L,63L,51L,32L,88L,1L,1L,1L,69L,70L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184753Inst : IEnumerable<long>
{
public static readonly long[] Value=A184753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184753.Bytes);
public long this[int i]=>Value[i];

public static A184753Inst Instance=new A184753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184754
{
public static readonly BigInteger[] Value={ 1L,7L,163L,12397L,3110914L,2568513843L,6982256142285L,62483420093901107L,BigInteger.Parse("1840782554883258104105"),BigInteger.Parse("178527915853668578288219231"),BigInteger.Parse("57000185549334885919706636039360"),BigInteger.Parse("59911857895558455825087768017439269698") };
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
public class A184754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184754Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184754.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184754Inst Instance=new A184754Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184755
{
public static readonly long[] Value={ 4L,25L,163L,1056L,6847L,44391L,287802L,1865917L,12097367L,78431296L,508496451L,3296753387L,21373960178L,138574567177L,898425491035L,5824794400480L,37764099690423L,244837350020575L,1587362824918602L,10291406673539877L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184755Inst : IEnumerable<long>
{
public static readonly long[] Value=A184755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184755.Bytes);
public long this[int i]=>Value[i];

public static A184755Inst Instance=new A184755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184756
{
public static readonly long[] Value={ 8L,89L,1056L,12397L,145778L,1713803L,20148584L,236878817L,2784890782L,32740859687L,384921344068L,4525368067837L,53202963328218L,625486206737315L,7353594054643744L,86453298151112665L,1016397248157274582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184756Inst : IEnumerable<long>
{
public static readonly long[] Value=A184756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184756.Bytes);
public long this[int i]=>Value[i];

public static A184756Inst Instance=new A184756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184757
{
public static readonly BigInteger[] Value={ 16L,317L,6847L,145778L,3110914L,66363023L,1415755252L,30202770902L,644326291402L,13745636657969L,293240447607511L,6255800447755343L,133457166530876185L,2847088145920628222L,BigInteger.Parse("60737921547191898319"),BigInteger.Parse("1295743203159170280830") };
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
public class A184757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184757Inst Instance=new A184757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184758
{
public static readonly BigInteger[] Value={ 32L,1129L,44391L,1713803L,66363023L,2568513843L,99419347147L,3848174315295L,148949599913987L,5765325542821919L,223155884726125003L,8637595276083930107L,BigInteger.Parse("334331547130486255947"),BigInteger.Parse("12940822049109738429467"),BigInteger.Parse("500894626143397858765227") };
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
public class A184758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184758Inst Instance=new A184758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184759
{
public static readonly BigInteger[] Value={ 64L,4021L,287802L,20148584L,1415755252L,99419347147L,6982256142285L,490358739919898L,34437619490245450L,2418533807739519677L,BigInteger.Parse("169852219543126318591"),BigInteger.Parse("11928622276532341733243"),BigInteger.Parse("837740183488415335215180") };
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
public class A184759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184759Inst Instance=new A184759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184760
{
public static readonly BigInteger[] Value={ 128L,14321L,1865917L,236878817L,30202770902L,3848174315295L,490358739919898L,62483420093901107L,7961905153672004774L,BigInteger.Parse("1014539579452170241886"),BigInteger.Parse("129276927715415033559253"),BigInteger.Parse("16473013159661022852279611") };
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
public class A184760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184760Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184760.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184760Inst Instance=new A184760Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184761
{
public static readonly long[] Value={ 1L,2L,2L,4L,7L,4L,8L,25L,25L,8L,16L,89L,163L,89L,16L,32L,317L,1056L,1056L,317L,32L,64L,1129L,6847L,12397L,6847L,1129L,64L,128L,4021L,44391L,145778L,145778L,44391L,4021L,128L,256L,14321L,287802L,1713803L,3110914L,1713803L,287802L,14321L,256L,512L,51005L,1865917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184761Inst : IEnumerable<long>
{
public static readonly long[] Value=A184761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184761.Bytes);
public long this[int i]=>Value[i];

public static A184761Inst Instance=new A184761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184762
{
public static readonly long[] Value={ 1L,0L,3L,0L,0L,0L,5L,0L,2L,0L,1L,0L,1L,0L,2L,0L,2L,1L,0L,4L,1L,2L,0L,0L,7L,0L,2L,2L,0L,1L,0L,4L,0L,0L,0L,0L,0L,5L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,1L,0L,0L,1L,0L,2L,0L,0L,0L,1L,2L,0L,2L,0L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184762Inst : IEnumerable<long>
{
public static readonly long[] Value=A184762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184762.Bytes);
public long this[int i]=>Value[i];

public static A184762Inst Instance=new A184762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184763
{
public static readonly long[] Value={ 24L,4L,580L,963L,29L,39L,56L,190L,2215L,32L,552057L,22908L,108L,111L,326L,39L,5345L,28L,21L,43L,308L,1221044L,116L,80L,6910L,48L,50L,73L,578L,624L,3625L,21624L,59L,364L,77L,123L,198L,609L,4087L,61281L,148856L,48L,96L,349L,686L,11918L,67L,93L,171L,15674L,147L,389L,3533L,2132L,92L,3238L,305L,282L,928L,116L,8516L,194L,22873L,36554L,99L,276L,26003L,136L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184763Inst : IEnumerable<long>
{
public static readonly long[] Value=A184763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184763.Bytes);
public long this[int i]=>Value[i];

public static A184763Inst Instance=new A184763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184812
{
public static readonly long[] Value={ 3L,7L,10L,14L,18L,22L,26L,29L,34L,37L,41L,44L,48L,53L,56L,60L,63L,68L,72L,75L,79L,82L,87L,90L,94L,98L,102L,106L,109L,113L,117L,121L,125L,128L,132L,136L,140L,144L,147L,151L,155L,159L,162L,166L,171L,174L,178L,181L,186L,190L,193L,197L,200L,205L,208L,212L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184812Inst : IEnumerable<long>
{
public static readonly long[] Value=A184812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184812.Bytes);
public long this[int i]=>Value[i];

public static A184812Inst Instance=new A184812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184813
{
public static readonly long[] Value={ 2L,5L,8L,12L,15L,17L,21L,24L,27L,30L,33L,36L,39L,43L,46L,49L,51L,55L,58L,61L,65L,67L,70L,73L,77L,80L,83L,86L,89L,92L,96L,99L,101L,104L,108L,111L,114L,118L,120L,123L,126L,130L,133L,135L,139L,142L,145L,148L,152L,154L,157L,161L,164L,167L,170L,173L,176L,179L,183L,185L,188L,192L,195L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184813Inst : IEnumerable<long>
{
public static readonly long[] Value=A184813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184813.Bytes);
public long this[int i]=>Value[i];

public static A184813Inst Instance=new A184813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184814
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,13L,16L,19L,20L,23L,25L,28L,31L,32L,35L,38L,40L,42L,45L,47L,50L,52L,54L,57L,59L,62L,64L,66L,69L,71L,74L,76L,78L,81L,84L,85L,88L,91L,93L,95L,97L,100L,103L,105L,107L,110L,112L,115L,116L,119L,122L,124L,127L,129L,131L,134L,137L,138L,141L,143L,146L,149L,150L,153L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184814Inst : IEnumerable<long>
{
public static readonly long[] Value=A184814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184814.Bytes);
public long this[int i]=>Value[i];

public static A184814Inst Instance=new A184814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184815
{
public static readonly long[] Value={ 2L,4L,10L,12L,13L,16L,22L,29L,30L,36L,42L,44L,45L,49L,52L,57L,59L,60L,64L,70L,71L,76L,82L,84L,90L,91L,92L,97L,101L,103L,108L,111L,114L,115L,119L,123L,125L,138L,140L,142L,149L,150L,165L,171L,178L,180L,182L,185L,189L,191L,192L,193L,195L,198L,205L,211L,215L,217L,220L,222L,224L,233L,235L,236L,247L,248L,249L,252L,254L,255L,264L,265L,269L,273L,286L,295L,301L,302L,306L,307L,309L,316L,318L,325L,326L,327L,328L,329L,332L,336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184815Inst : IEnumerable<long>
{
public static readonly long[] Value=A184815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184815.Bytes);
public long this[int i]=>Value[i];

public static A184815Inst Instance=new A184815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184816
{
public static readonly long[] Value={ 1L,3L,7L,14L,18L,19L,21L,23L,24L,26L,34L,37L,39L,40L,41L,50L,53L,54L,55L,56L,65L,68L,69L,72L,78L,80L,81L,83L,86L,93L,95L,96L,98L,105L,106L,109L,113L,117L,124L,126L,129L,131L,133L,135L,137L,139L,143L,145L,148L,152L,157L,158L,159L,160L,161L,162L,168L,169L,172L,173L,174L,176L,183L,187L,190L,197L,200L,207L,208L,212L,214L,219L,229L,232L,234L,238L,242L,243L,245L,246L,257L,258L,259L,266L,267L,268L,270L,275L,276L,278L,279L,280L,281L,284L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184816Inst : IEnumerable<long>
{
public static readonly long[] Value=A184816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184816.Bytes);
public long this[int i]=>Value[i];

public static A184816Inst Instance=new A184816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184817
{
public static readonly long[] Value={ 5L,6L,8L,9L,11L,15L,17L,20L,25L,27L,28L,31L,32L,33L,35L,38L,43L,46L,47L,48L,51L,58L,61L,62L,63L,66L,67L,73L,74L,75L,77L,79L,85L,87L,88L,89L,94L,99L,100L,102L,104L,107L,110L,112L,116L,118L,120L,121L,122L,127L,128L,130L,132L,134L,136L,141L,144L,146L,147L,151L,153L,154L,155L,156L,163L,164L,166L,167L,170L,175L,177L,179L,181L,184L,186L,188L,194L,196L,199L,201L,202L,203L,204L,206L,209L,210L,213L,216L,218L,221L,223L,225L,226L,227L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184817Inst : IEnumerable<long>
{
public static readonly long[] Value=A184817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184817.Bytes);
public long this[int i]=>Value[i];

public static A184817Inst Instance=new A184817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184818
{
public static readonly long[] Value={ 1L,1L,1L,3L,13L,69L,431L,3100L,25264L,230301L,2323448L,25713402L,309822547L,4038325082L,56625410687L,850040474751L,13603082015860L,231189547428654L,4158861518106668L,78949554006168724L,1577308905369288069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184818Inst : IEnumerable<long>
{
public static readonly long[] Value=A184818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184818.Bytes);
public long this[int i]=>Value[i];

public static A184818Inst Instance=new A184818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184819
{
public static readonly long[] Value={ 1L,0L,1L,3L,11L,51L,289L,1940L,15056L,132579L,1305352L,14203398L,169179053L,2188695718L,30552880513L,457633893249L,7319707872140L,124497880667346L,2243512187621332L,42695546402663276L,855593102807351931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184819Inst : IEnumerable<long>
{
public static readonly long[] Value=A184819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184819.Bytes);
public long this[int i]=>Value[i];

public static A184819Inst Instance=new A184819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184820
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,12L,14L,15L,17L,19L,21L,23L,25L,27L,28L,31L,32L,34L,35L,38L,39L,41L,44L,45L,47L,48L,51L,52L,54L,56L,58L,59L,62L,64L,65L,67L,69L,71L,72L,75L,76L,78L,80L,82L,84L,85L,88L,89L,91L,93L,95L,96L,98L,100L,102L,103L,106L,108L,109L,112L,113L,115L,116L,119L,120L,122L,124L,126L,128L,129L,132L,133L,135L,137L,139L,140L,143L,144L,146L,148L,150L,152L,153L,156L,157L,159L,161L,163L,164L,166L,169L,170L,172L,174L,176L,177L,179L,181L,183L,184L,187L,188L,190L,193L,194L,196L,197L,200L,201L,203L,205L,207L,208L,210L,213L,214L,216L,218L,220L,221L,224L,225L,227L,228L,231L,233L,234L,237L,238L,240L,242L,244L,245L,247L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184820Inst : IEnumerable<long>
{
public static readonly long[] Value=A184820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184820.Bytes);
public long this[int i]=>Value[i];

public static A184820Inst Instance=new A184820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184821
{
public static readonly long[] Value={ 2L,6L,9L,13L,16L,20L,22L,26L,29L,33L,36L,40L,43L,46L,50L,53L,57L,60L,63L,66L,70L,73L,77L,81L,83L,87L,90L,94L,97L,101L,104L,107L,110L,114L,118L,121L,125L,127L,131L,134L,138L,141L,145L,147L,151L,155L,158L,162L,165L,168L,171L,175L,178L,182L,185L,189L,191L,195L,199L,202L,206L,209L,212L,215L,219L,222L,226L,229L,232L,236L,239L,243L,246L,250L,252L,256L,259L,263L,266L,270L,273L,276L,280L,283L,287L,290L,294L,296L,300L,303L,307L,311L,314L,317L,320L,324L,327L,331L,334L,337L,340L,344L,347L,351L,355L,357L,361L,364L,368L,371L,375L,378L,381L,384L,388L,392L,395L,399L,401L,405L,408L,412L,415L,419L,421L,425L,429L,432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184821Inst : IEnumerable<long>
{
public static readonly long[] Value=A184821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184821.Bytes);
public long this[int i]=>Value[i];

public static A184821Inst Instance=new A184821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184822
{
public static readonly long[] Value={ 5L,11L,18L,24L,30L,37L,42L,49L,55L,61L,68L,74L,79L,86L,92L,99L,105L,111L,117L,123L,130L,136L,142L,149L,154L,160L,167L,173L,180L,186L,192L,198L,204L,211L,217L,223L,230L,235L,241L,248L,254L,261L,267L,272L,279L,285L,291L,298L,304L,310L,316L,322L,329L,335L,342L,348L,353L,360L,366L,372L,379L,385L,391L,397L,403L,410L,416L,423L,428L,434L,441L,447L,453L,460L,465L,472L,478L,484L,491L,497L,503L,509L,515L,522L,528L,534L,541L,546L,553L,559L,565L,572L,578L,583L,590L,596L,603L,609L,615L,621L,627L,634L,640L,646L,653L,658L,664L,671L,677L,684L,690L,696L,702L,708L,715L,721L,727L,734L,739L,745L,752L,758L,765L,771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184822Inst : IEnumerable<long>
{
public static readonly long[] Value=A184822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184822.Bytes);
public long this[int i]=>Value[i];

public static A184822Inst Instance=new A184822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184823
{
public static readonly long[] Value={ 1L,3L,4L,7L,8L,10L,11L,15L,16L,18L,19L,22L,23L,25L,28L,30L,31L,33L,35L,37L,38L,41L,43L,45L,46L,48L,51L,52L,55L,57L,59L,60L,62L,64L,66L,68L,70L,72L,74L,75L,78L,79L,82L,83L,86L,87L,89L,90L,93L,94L,97L,98L,101L,103L,104L,107L,108L,111L,112L,115L,116L,118L,119L,122L,124L,126L,128L,130L,131L,133L,135L,138L,139L,141L,143L,145L,146L,148L,151L,153L,155L,157L,159L,160L,162L,165L,167L,168L,170L,172L,174L,175L,178L,180L,182L,183L,186L,187L,189L,190L,194L,195L,197L,198L,201L,202L,204L,208L,209L,211L,212L,215L,216L,218L,220L,223L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184823Inst : IEnumerable<long>
{
public static readonly long[] Value=A184823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184823.Bytes);
public long this[int i]=>Value[i];

public static A184823Inst Instance=new A184823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184824
{
public static readonly long[] Value={ 2L,6L,9L,14L,17L,21L,24L,29L,32L,36L,39L,44L,47L,50L,54L,58L,61L,65L,69L,73L,76L,80L,84L,88L,91L,95L,100L,102L,106L,110L,114L,117L,121L,125L,129L,132L,136L,140L,144L,147L,152L,154L,158L,161L,166L,169L,173L,176L,181L,184L,188L,191L,196L,200L,203L,207L,210L,214L,217L,222L,225L,229L,232L,237L,240L,244L,248L,252L,255L,258L,262L,266L,269L,273L,277L,281L,284L,288L,292L,296L,300L,304L,307L,310L,314L,318L,322L,325L,329L,333L,337L,340L,345L,348L,352L,355L,359L,362L,366L,369L,374L,377L,381L,384L,389L,392L,396L,401L,404L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184824Inst : IEnumerable<long>
{
public static readonly long[] Value=A184824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184824.Bytes);
public long this[int i]=>Value[i];

public static A184824Inst Instance=new A184824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184825
{
public static readonly long[] Value={ 5L,13L,20L,27L,34L,42L,49L,56L,63L,71L,77L,85L,92L,99L,105L,113L,120L,127L,134L,142L,149L,156L,163L,171L,177L,185L,193L,199L,206L,213L,221L,227L,235L,242L,250L,256L,264L,271L,278L,285L,293L,299L,306L,313L,321L,327L,335L,342L,350L,356L,364L,371L,378L,386L,393L,400L,406L,414L,421L,428L,435L,443L,450L,457L,464L,472L,478L,486L,493L,500L,506L,514L,521L,528L,535L,543L,550L,557L,564L,572L,579L,586L,593L,600L,607L,614L,622L,628L,636L,643L,651L,657L,665L,672L,679L,686L,693L,700L,707L,714L,722L,728L,736L,743L,751L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184825Inst : IEnumerable<long>
{
public static readonly long[] Value=A184825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184825.Bytes);
public long this[int i]=>Value[i];

public static A184825Inst Instance=new A184825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184826
{
public static readonly long[] Value={ 12L,26L,40L,53L,67L,81L,96L,109L,123L,137L,150L,164L,179L,192L,205L,219L,233L,246L,261L,275L,289L,302L,316L,330L,344L,358L,372L,385L,398L,412L,427L,440L,454L,468L,482L,495L,509L,524L,537L,551L,565L,578L,591L,606L,620L,633L,647L,661L,675L,689L,703L,717L,730L,744L,758L,772L,785L,799L,813L,826L,840L,855L,869L,882L,896L,910L,923L,938L,952L,965L,978L,992L,1006L,1019L,1034L,1048L,1062L,1075L,1089L,1103L,1117L,1131L,1144L,1158L,1171L,1185L,1200L,1213L,1227L,1241L,1255L,1268L,1283L,1297L,1310L,1324L,1337L,1351L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184826Inst : IEnumerable<long>
{
public static readonly long[] Value=A184826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184826.Bytes);
public long this[int i]=>Value[i];

public static A184826Inst Instance=new A184826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184827
{
public static readonly long[] Value={ 0L,0L,5L,5L,11L,9L,17L,19L,29L,29L,31L,37L,47L,39L,59L,65L,65L,71L,71L,71L,81L,87L,93L,99L,107L,103L,125L,125L,131L,129L,131L,143L,155L,157L,167L,153L,185L,191L,189L,197L,199L,203L,215L,215L,227L,233L,233L,223L,257L,255L,261L,263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184827Inst : IEnumerable<long>
{
public static readonly long[] Value=A184827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184827.Bytes);
public long this[int i]=>Value[i];

public static A184827Inst Instance=new A184827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184892
{
public static readonly BigInteger[] Value={ 1L,40L,8100L,2310000L,768075000L,278719056000L,107022956040000L,42753018765600000L,17585519046944062500UL,BigInteger.Parse("7397979398239787500000"),BigInteger.Parse("3168258657090171394750000"),BigInteger.Parse("1376657183877933677265000000") };
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
public class A184892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184892Inst Instance=new A184892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184893
{
public static readonly long[] Value={ 132L,7854L,116520L,916860L,4820439L,19624035L,65713455L,190759077L,493962822L,1168477251L,2559841278L,5270707320L,10278584778L,19140242421L,34233601737L,59117179833L,98911520802L,160982370882L,255478326648L,396430119123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184893Inst : IEnumerable<long>
{
public static readonly long[] Value=A184893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184893.Bytes);
public long this[int i]=>Value[i];

public static A184893Inst Instance=new A184893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184894
{
public static readonly BigInteger[] Value={ 1L,2L,9L,78L,1045L,19320L,458304L,13306902L,457649757L,18202765482L,822272600160L,41592018711672L,2329051560965532L,143045976577538632L,9561491720518777632UL,BigInteger.Parse("690994864767311671302"),BigInteger.Parse("53688078414653072521485"),BigInteger.Parse("4462898094035056790939070") };
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
public class A184894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184894Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184894.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184894Inst Instance=new A184894Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184895
{
public static readonly BigInteger[] Value={ 1L,42L,22050L,16909900L,15269639700L,15109613875944L,15853342647837688L,17325438750851187600UL,BigInteger.Parse("19510609713302293636050"),BigInteger.Parse("22482485054570487449402900"),BigInteger.Parse("26382746561837375612125315092"),BigInteger.Parse("31419888802098260334367621118904") };
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
public class A184895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184895Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184895.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184895Inst Instance=new A184895Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184896
{
public static readonly BigInteger[] Value={ 1L,84L,45864L,35672000L,32445913500L,32247604076688L,33935228690034672L,BigInteger.Parse("37165308416775931392"),BigInteger.Parse("41919854708375196052500"),BigInteger.Parse("48365506771435816732770000"),BigInteger.Parse("56812832722107710740048677120"),BigInteger.Parse("67715433011522917282547695380480") };
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
public class A184896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184896Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184896.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184896Inst Instance=new A184896Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184897
{
public static readonly BigInteger[] Value={ 1L,56L,43792L,50098048L,67507119680L,99694514343424L,156121609461801984L,BigInteger.Parse("254663020429855285248"),BigInteger.Parse("428056704465033002591232"),BigInteger.Parse("736257531679856764456919040"),BigInteger.Parse("1289628692490437108622739390464") };
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
public class A184897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184897Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184897.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184897Inst Instance=new A184897Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184898
{
public static readonly BigInteger[] Value={ 1L,112L,90720L,105100800L,142542960000L,211337613527040L,331831362513530880L,BigInteger.Parse("542307255307827609600"),BigInteger.Parse("912855634598629193472000"),BigInteger.Parse("1571864775032876891607040000"),BigInteger.Parse("2755743023914838714304931102720") };
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
public class A184898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184898Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184898.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184898Inst Instance=new A184898Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184899
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,10L,11L,13L,14L,19L,20L,21L,23L,24L,31L,32L,33L,34L,36L,37L,39L,42L,43L,44L,46L,47L,48L,52L,56L,59L,61L,66L,68L,74L,75L,78L,79L,85L,87L,89L,94L,96L,98L,101L,102L,105L,107L,108L,110L,113L,118L,121L,124L,125L,127L,130L,131L,133L,135L,136L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184899Inst : IEnumerable<long>
{
public static readonly long[] Value=A184899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184899.Bytes);
public long this[int i]=>Value[i];

public static A184899Inst Instance=new A184899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184900
{
public static readonly BigInteger[] Value={ 1L,3L,30L,588L,17550L,708840L,36195159L,2237012232L,162374762574L,13540681147257L,1275717308712000L,134010130947557040L,15530163914778879015UL,BigInteger.Parse("1968213292803618315390"),BigInteger.Parse("270798818519865663526320") };
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
public class A184900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184900Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184900.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184900Inst Instance=new A184900Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184901
{
public static readonly long[] Value={ 4L,9L,13L,18L,24L,28L,33L,37L,43L,48L,52L,57L,63L,67L,72L,76L,82L,87L,91L,96L,100L,106L,111L,115L,120L,126L,130L,135L,139L,145L,150L,154L,159L,165L,169L,174L,178L,183L,189L,193L,198L,202L,208L,213L,217L,222L,228L,232L,237L,241L,247L,252L,256L,261L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184901Inst : IEnumerable<long>
{
public static readonly long[] Value=A184901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184901.Bytes);
public long this[int i]=>Value[i];

public static A184901Inst Instance=new A184901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184902
{
public static readonly long[] Value={ 2L,3L,5L,7L,19L,29L,37L,61L,71L,73L,89L,113L,131L,137L,149L,151L,157L,163L,179L,191L,199L,211L,223L,227L,233L,241L,257L,263L,277L,313L,331L,347L,349L,373L,383L,389L,409L,419L,421L,433L,449L,457L,463L,467L,491L,499L,503L,521L,523L,571L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184902Inst : IEnumerable<long>
{
public static readonly long[] Value=A184902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184902.Bytes);
public long this[int i]=>Value[i];

public static A184902Inst Instance=new A184902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184903
{
public static readonly long[] Value={ 1L,3L,6L,7L,10L,12L,15L,16L,19L,21L,22L,25L,27L,30L,31L,34L,36L,39L,40L,42L,45L,46L,49L,51L,54L,55L,58L,60L,61L,64L,66L,69L,70L,73L,75L,78L,79L,81L,84L,85L,88L,90L,93L,94L,97L,99L,102L,103L,105L,108L,109L,112L,114L,117L,118L,121L,123L,124L,127L,129L,132L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184903Inst : IEnumerable<long>
{
public static readonly long[] Value=A184903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184903.Bytes);
public long this[int i]=>Value[i];

public static A184903Inst Instance=new A184903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184904
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,15L,18L,21L,24L,26L,28L,31L,34L,37L,40L,42L,45L,48L,50L,53L,56L,58L,61L,64L,67L,70L,72L,74L,77L,80L,83L,85L,88L,91L,94L,97L,99L,101L,104L,107L,110L,113L,115L,118L,121L,123L,126L,128L,131L,134L,137L,140L,143L,145L,147L,150L,153L,156L,158L,161L,164L,167L,170L,172L,174L,177L,180L,183L,186L,188L,191L,194L,197L,199L,201L,204L,207L,210L,213L,215L,218L,221L,223L,226L,229L,231L,234L,237L,240L,243L,245L,247L,250L,253L,256L,258L,261L,264L,267L,270L,272L,274L,277L,280L,283L,286L,288L,291L,294L,296L,299L,301L,304L,307L,310L,313L,316L,318L,321L,323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184904Inst : IEnumerable<long>
{
public static readonly long[] Value=A184904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184904.Bytes);
public long this[int i]=>Value[i];

public static A184904Inst Instance=new A184904Inst();

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