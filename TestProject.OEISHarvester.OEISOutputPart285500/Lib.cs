using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A188367
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,289L,213L,22L,177L,266L,1257L,3278L,14999L,3011L,7506L,5531L,3590L,13714L,2456L,20010L,3584L,30464L,14611L,23835L,3937L,22689L,20687L,76314L,34164L,23928L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188367Inst : IEnumerable<long>
{
public static readonly long[] Value=A188367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188367.Bytes);
public long this[int i]=>Value[i];

public static A188367Inst Instance=new A188367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188368
{
public static readonly BigInteger[] Value={ 704L,15776L,315520L,6781400L,146491208L,3204417424L,70324529528L,1550290704312L,34247741174176L,758246919492968L,16810324686733992L,373161215486655440L,8291015786317391720L,BigInteger.Parse("184361263940488110328"),BigInteger.Parse("4102028210533831306896") };
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
public class A188368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188368Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188368.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188368Inst Instance=new A188368Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188369
{
public static readonly long[] Value={ 1936L,315520L,11342816L,716732884L,34292827560L,1927798104328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188369Inst : IEnumerable<long>
{
public static readonly long[] Value=A188369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188369.Bytes);
public long this[int i]=>Value[i];

public static A188369Inst Instance=new A188369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188370
{
public static readonly long[] Value={ 0L,704L,704L,1936L,15776L,1936L,34816L,315520L,315520L,34816L,172992L,6781400L,11342816L,6781400L,172992L,2053216L,146491208L,716732884L,716732884L,146491208L,2053216L,12950528L,3204417424L,34292827560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188370Inst : IEnumerable<long>
{
public static readonly long[] Value=A188370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188370.Bytes);
public long this[int i]=>Value[i];

public static A188370Inst Instance=new A188370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188371
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188371Inst : IEnumerable<long>
{
public static readonly long[] Value=A188371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188371.Bytes);
public long this[int i]=>Value[i];

public static A188371Inst Instance=new A188371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188372
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,7L,8L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,24L,25L,26L,28L,29L,31L,32L,33L,35L,36L,38L,39L,40L,41L,42L,43L,45L,46L,48L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,64L,65L,66L,67L,69L,70L,72L,73L,74L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,89L,90L,91L,93L,94L,96L,97L,98L,100L,101L,103L,104L,105L,106L,107L,108L,110L,111L,113L,114L,115L,117L,118L,120L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188372Inst : IEnumerable<long>
{
public static readonly long[] Value=A188372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188372.Bytes);
public long this[int i]=>Value[i];

public static A188372Inst Instance=new A188372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188373
{
public static readonly long[] Value={ 3L,10L,13L,17L,20L,27L,30L,34L,37L,44L,47L,51L,54L,58L,61L,68L,71L,75L,78L,85L,88L,92L,95L,99L,102L,109L,112L,116L,119L,126L,129L,133L,136L,143L,146L,150L,153L,157L,160L,167L,170L,174L,177L,184L,187L,191L,194L,198L,201L,208L,211L,215L,218L,225L,228L,232L,235L,242L,245L,249L,252L,256L,259L,266L,269L,273L,276L,283L,286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188373Inst : IEnumerable<long>
{
public static readonly long[] Value=A188373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188373.Bytes);
public long this[int i]=>Value[i];

public static A188373Inst Instance=new A188373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188374
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188374Inst : IEnumerable<long>
{
public static readonly long[] Value=A188374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188374.Bytes);
public long this[int i]=>Value[i];

public static A188374Inst Instance=new A188374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188375
{
public static readonly long[] Value={ 2L,3L,5L,6L,9L,10L,12L,13L,16L,17L,19L,20L,22L,23L,26L,27L,29L,30L,33L,34L,36L,37L,39L,40L,43L,44L,46L,47L,50L,51L,53L,54L,57L,58L,60L,61L,63L,64L,67L,68L,70L,71L,74L,75L,77L,78L,80L,81L,84L,85L,87L,88L,91L,92L,94L,95L,98L,99L,101L,102L,104L,105L,108L,109L,111L,112L,115L,116L,118L,119L,121L,122L,125L,126L,128L,129L,132L,133L,135L,136L,138L,139L,142L,143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188375Inst : IEnumerable<long>
{
public static readonly long[] Value=A188375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188375.Bytes);
public long this[int i]=>Value[i];

public static A188375Inst Instance=new A188375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188376
{
public static readonly long[] Value={ 1L,4L,7L,8L,11L,14L,15L,18L,21L,24L,25L,28L,31L,32L,35L,38L,41L,42L,45L,48L,49L,52L,55L,56L,59L,62L,65L,66L,69L,72L,73L,76L,79L,82L,83L,86L,89L,90L,93L,96L,97L,100L,103L,106L,107L,110L,113L,114L,117L,120L,123L,124L,127L,130L,131L,134L,137L,140L,141L,144L,147L,148L,151L,154L,155L,158L,161L,164L,165L,168L,171L,172L,175L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188376Inst : IEnumerable<long>
{
public static readonly long[] Value=A188376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188376.Bytes);
public long this[int i]=>Value[i];

public static A188376Inst Instance=new A188376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188377
{
public static readonly long[] Value={ 7L,22L,53L,106L,187L,302L,457L,658L,911L,1222L,1597L,2042L,2563L,3166L,3857L,4642L,5527L,6518L,7621L,8842L,10187L,11662L,13273L,15026L,16927L,18982L,21197L,23578L,26131L,28862L,31777L,34882L,38183L,41686L,45397L,49322L,53467L,57838L,62441L,67282L,72367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188377Inst : IEnumerable<long>
{
public static readonly long[] Value=A188377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188377.Bytes);
public long this[int i]=>Value[i];

public static A188377Inst Instance=new A188377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188378
{
public static readonly long[] Value={ 2L,5L,12L,30L,77L,200L,522L,1365L,3572L,9350L,24477L,64080L,167762L,439205L,1149852L,3010350L,7881197L,20633240L,54018522L,141422325L,370248452L,969323030L,2537720637L,6643838880L,17393796002L,45537549125L,119218851372L,312119004990L,817138163597L,2139295485800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188378Inst : IEnumerable<long>
{
public static readonly long[] Value=A188378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188378.Bytes);
public long this[int i]=>Value[i];

public static A188378Inst Instance=new A188378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188379
{
public static readonly long[] Value={ 0L,0L,0L,6L,18L,46L,115L,374L,1204L,3752L,11300L,34324L,105124L,322989L,989692L,3028484L,9267328L,28374898L,86891022L,266058106L,814585879L,2494006074L,7636057864L,23380074400L,71584762200L,219176102664L,671066472872L,2054652945289L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188379Inst : IEnumerable<long>
{
public static readonly long[] Value=A188379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188379.Bytes);
public long this[int i]=>Value[i];

public static A188379Inst Instance=new A188379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188428
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,9L,54L,276L,1282L,5585L,23223L,93146L,362928L,1380535L,5145692L,18846775L,67982489L,241940204L,850777688L,2959796467L,10197732687L,34828459508L,118003182174L,396897710483L,1326018464696L,4402883891950L,14536059784925L,47737688829399L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188428Inst : IEnumerable<long>
{
public static readonly long[] Value=A188428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188428.Bytes);
public long this[int i]=>Value[i];

public static A188428Inst Instance=new A188428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188429
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,3L,4L,0L,0L,4L,5L,5L,6L,7L,5L,6L,6L,6L,7L,7L,6L,7L,7L,7L,7L,8L,8L,7L,8L,8L,8L,8L,8L,9L,9L,8L,9L,9L,9L,9L,9L,9L,10L,10L,9L,10L,10L,10L,10L,10L,10L,10L,11L,11L,10L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,13L,13L,12L,13L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188429Inst : IEnumerable<long>
{
public static readonly long[] Value=A188429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188429.Bytes);
public long this[int i]=>Value[i];

public static A188429Inst Instance=new A188429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188430
{
public static readonly long[] Value={ 1L,0L,2L,0L,0L,3L,4L,0L,0L,4L,5L,6L,7L,7L,8L,6L,7L,8L,9L,10L,11L,11L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188430Inst : IEnumerable<long>
{
public static readonly long[] Value=A188430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188430.Bytes);
public long this[int i]=>Value[i];

public static A188430Inst Instance=new A188430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188431
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,2L,2L,1L,2L,1L,2L,3L,4L,5L,7L,7L,8L,9L,11L,10L,13L,14L,17L,20L,25L,28L,34L,40L,46L,54L,62L,69L,80L,90L,102L,115L,131L,144L,167L,186L,213L,239L,273L,304L,349L,388L,441L,495L,563L,625L,710L,790L,890L,990L,1114L,1232L,1387L,1530L,1713L,1894L,2119L,2330L,2605L,2866L,3192L,3512L,3910L,4289L,4774L,5237L,5809L,6377L,7068L,7739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188431Inst : IEnumerable<long>
{
public static readonly long[] Value=A188431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188431.Bytes);
public long this[int i]=>Value[i];

public static A188431Inst Instance=new A188431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188432
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188432Inst : IEnumerable<long>
{
public static readonly long[] Value=A188432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188432.Bytes);
public long this[int i]=>Value[i];

public static A188432Inst Instance=new A188432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188433
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188433Inst : IEnumerable<long>
{
public static readonly long[] Value=A188433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188433.Bytes);
public long this[int i]=>Value[i];

public static A188433Inst Instance=new A188433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188434
{
public static readonly long[] Value={ 2L,5L,10L,13L,18L,23L,26L,31L,34L,39L,44L,47L,52L,57L,60L,65L,68L,73L,78L,81L,86L,89L,94L,99L,102L,107L,112L,115L,120L,123L,128L,133L,136L,141L,146L,149L,154L,157L,162L,167L,170L,175L,178L,183L,188L,191L,196L,201L,204L,209L,212L,217L,222L,225L,230L,233L,238L,243L,246L,251L,256L,259L,264L,267L,272L,277L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188434Inst : IEnumerable<long>
{
public static readonly long[] Value=A188434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188434.Bytes);
public long this[int i]=>Value[i];

public static A188434Inst Instance=new A188434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188435
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,9L,11L,12L,14L,15L,16L,17L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,40L,41L,42L,43L,45L,46L,48L,49L,50L,51L,53L,54L,55L,56L,58L,59L,61L,62L,63L,64L,66L,67L,69L,70L,71L,72L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,87L,88L,90L,91L,92L,93L,95L,96L,97L,98L,100L,101L,103L,104L,105L,106L,108L,109L,110L,111L,113L,114L,116L,117L,118L,119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188435Inst : IEnumerable<long>
{
public static readonly long[] Value=A188435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188435.Bytes);
public long this[int i]=>Value[i];

public static A188435Inst Instance=new A188435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188436
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188436Inst : IEnumerable<long>
{
public static readonly long[] Value=A188436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188436.Bytes);
public long this[int i]=>Value[i];

public static A188436Inst Instance=new A188436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188437
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,26L,27L,28L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,43L,44L,45L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,77L,78L,79L,80L,81L,82L,83L,85L,86L,87L,88L,89L,90L,91L,93L,94L,95L,96L,98L,99L,100L,101L,102L,103L,104L,106L,107L,108L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188437Inst : IEnumerable<long>
{
public static readonly long[] Value=A188437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188437.Bytes);
public long this[int i]=>Value[i];

public static A188437Inst Instance=new A188437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188438
{
public static readonly long[] Value={ 8L,16L,21L,29L,37L,42L,50L,55L,63L,71L,76L,84L,92L,97L,105L,110L,118L,126L,131L,139L,144L,152L,160L,165L,173L,181L,186L,194L,199L,207L,215L,220L,228L,236L,241L,249L,254L,262L,270L,275L,283L,288L,296L,304L,309L,317L,325L,330L,338L,343L,351L,359L,364L,372L,377L,385L,393L,398L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188438Inst : IEnumerable<long>
{
public static readonly long[] Value=A188438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188438.Bytes);
public long this[int i]=>Value[i];

public static A188438Inst Instance=new A188438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188439
{
public static readonly long[] Value={ 945L,1575L,2205L,7425L,78975L,131625L,342225L,570375L,3465L,4095L,5355L,5775L,5985L,6435L,6825L,7245L,8085L,8415L,8925L,9135L,9555L,9765L,11655L,12705L,12915L,13545L,14805L,16695L,18585L,19215L,21105L,22365L,22995L,24885L,26145L,28035L,28215L,29835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188439Inst : IEnumerable<long>
{
public static readonly long[] Value=A188439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188439.Bytes);
public long this[int i]=>Value[i];

public static A188439Inst Instance=new A188439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188440
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,4L,4L,1L,4L,4L,1L,6L,12L,8L,1L,6L,12L,8L,1L,8L,24L,32L,16L,1L,8L,24L,32L,16L,1L,10L,40L,80L,80L,32L,1L,10L,40L,80L,80L,32L,1L,12L,60L,160L,240L,192L,64L,1L,12L,60L,160L,240L,192L,64L,1L,14L,84L,280L,560L,672L,448L,128L,1L,14L,84L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188440Inst : IEnumerable<long>
{
public static readonly long[] Value=A188440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188440.Bytes);
public long this[int i]=>Value[i];

public static A188440Inst Instance=new A188440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188441
{
public static readonly BigInteger[] Value={ 1L,7L,97L,1777L,36427L,793183L,17946319L,417019279L,9882531049L,237755962549L,5788752753889L,142315748216929L,3527047510738129L,88005145583604529L,2208577811494332529L,BigInteger.Parse("55703557596868964209"),BigInteger.Parse("1411049022002884046539") };
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
public class A188441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188441Inst Instance=new A188441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188442
{
public static readonly long[] Value={ 0L,1L,1L,3L,6L,16L,39L,103L,269L,721L,1941L,5285L,14476L,39918L,110633L,308081L,861390L,2417264L,6805477L,19216297L,54404562L,154402264L,439172189L,1251701837L,3574234089L,10223988665L,29292665059L,84052426683L,241518890124L,694900077226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188442Inst : IEnumerable<long>
{
public static readonly long[] Value=A188442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188442.Bytes);
public long this[int i]=>Value[i];

public static A188442Inst Instance=new A188442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188443
{
public static readonly long[] Value={ 25L,33L,63L,66L,75L,88L,191L,269L,285L,309L,348L,379L,399L,400L,404L,413L,437L,443L,456L,548L,553L,594L,616L,638L,675L,684L,702L,724L,764L,810L,819L,823L,829L,843L,897L,901L,906L,907L,1000L,1031L,1041L,1068L,1075L,1159L,1200L,1230L,1241L,1255L,1279L,1280L,1281L,1300L,1323L,1332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188443Inst : IEnumerable<long>
{
public static readonly long[] Value=A188443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188443.Bytes);
public long this[int i]=>Value[i];

public static A188443Inst Instance=new A188443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188476
{
public static readonly long[] Value={ 1L,1L,2L,6L,12L,27L,65L,150L,353L,843L,2014L,4843L,11713L,28433L,69292L,169470L,415754L,1022868L,2523120L,6238645L,15459561L,38387191L,95497612L,237989801L,594062697L,1485141397L,3718116380L,9320941698L,23396109986L,58795356627L,147920737819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188476Inst : IEnumerable<long>
{
public static readonly long[] Value=A188476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188476.Bytes);
public long this[int i]=>Value[i];

public static A188476Inst Instance=new A188476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188477
{
public static readonly long[] Value={ 1L,1L,1L,-8L,-25L,-25L,-17L,32L,81L,81L,49L,-72L,-169L,-169L,-97L,128L,289L,289L,161L,-200L,-441L,-441L,-241L,288L,625L,625L,337L,-392L,-841L,-841L,-449L,512L,1089L,1089L,577L,-648L,-1369L,-1369L,-721L,800L,1681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188477Inst : IEnumerable<long>
{
public static readonly long[] Value=A188477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188477.Bytes);
public long this[int i]=>Value[i];

public static A188477Inst Instance=new A188477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188478
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,4L,11L,33L,116L,456L,1999L,9623L,50603L,288287L,1769352L,11636669L,81652911L,608857325L,4807873069L,40080193414L,351751992542L,3241754135966L,31301851579056L,316012152140592L,3329322705562603L,36539984716325869L,417102552119591395L,4944630222121834001L,BigInteger.Parse("60791493200390178470") };
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
public class A188478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188478Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188478.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188478Inst Instance=new A188478Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188479
{
public static readonly BigInteger[] Value={ 1L,1L,2L,4L,12L,40L,156L,700L,3520L,19592L,119992L,801272L,5792464L,45071600L,375615696L,3338063600L,31511918816L,314913425280L,3321357021600L,36868596345056L,429672869359360L,5245439731918784L,66941714022827072L,891387254398818752L,12363478873222765568UL,BigInteger.Parse("178331546692362644992"),BigInteger.Parse("2671094825005048612224") };
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
public class A188479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188479Inst Instance=new A188479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188480
{
public static readonly long[] Value={ 1L,10L,39L,99L,203L,366L,605L,939L,1389L,1978L,2731L,3675L,4839L,6254L,7953L,9971L,12345L,15114L,18319L,22003L,26211L,30990L,36389L,42459L,49253L,56826L,65235L,74539L,84799L,96078L,108441L,121955L,136689L,152714L,170103L,188931L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188480Inst : IEnumerable<long>
{
public static readonly long[] Value=A188480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188480.Bytes);
public long this[int i]=>Value[i];

public static A188480Inst Instance=new A188480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188481
{
public static readonly long[] Value={ 1L,4L,1L,16L,7L,1L,64L,38L,10L,1L,256L,187L,69L,13L,1L,1024L,874L,406L,109L,16L,1L,4096L,3958L,2186L,748L,158L,19L,1L,16384L,17548L,11124L,4570L,1240L,216L,22L,1L,65536L,76627L,54445L,25879L,8485L,1909L,283L,25L,1L,262144L,330818L,259006L,138917L,52984L,14471L,2782L,359L,28L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188481Inst : IEnumerable<long>
{
public static readonly long[] Value=A188481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188481.Bytes);
public long this[int i]=>Value[i];

public static A188481Inst Instance=new A188481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188482
{
public static readonly long[] Value={ 1L,4L,17L,71L,295L,1221L,5040L,20761L,85380L,350659L,1438568L,5896098L,24145941L,98812861L,404118745L,1651811920L,6748282361L,27556753703L,112482005583L,458958881572L,1872034052651L,7633342954234L,31116252892098L,126806214027741L,516633711969649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188482Inst : IEnumerable<long>
{
public static readonly long[] Value=A188482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188482.Bytes);
public long this[int i]=>Value[i];

public static A188482Inst Instance=new A188482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188483
{
public static readonly long[] Value={ 742L,3878L,7574L,16058L,2155174L,17886218L,312562708L,599256826L,5015867878L,6305036122L,7661332826L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188483Inst : IEnumerable<long>
{
public static readonly long[] Value=A188483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188483.Bytes);
public long this[int i]=>Value[i];

public static A188483Inst Instance=new A188483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188484
{
public static readonly long[] Value={ 98L,2116L,4232L,49928L,80656L,140450L,550564L,729632L,1667138L,2666689L,8853632L,9210632L,12380288L,15038884L,37810208L,57365476L,108103808L,155725952L,197686728L,247397768L,257859364L,327782408L,398353538L,544236032L,775864832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188484Inst : IEnumerable<long>
{
public static readonly long[] Value=A188484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188484.Bytes);
public long this[int i]=>Value[i];

public static A188484Inst Instance=new A188484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188485
{
public static readonly long[] Value={ 1L,7L,8L,0L,7L,7L,6L,4L,0L,6L,4L,0L,4L,4L,1L,5L,1L,3L,7L,4L,5L,5L,3L,5L,2L,4L,6L,3L,9L,9L,3L,5L,1L,9L,2L,5L,6L,2L,8L,6L,7L,9L,9L,8L,0L,6L,3L,4L,3L,4L,0L,5L,1L,0L,8L,5L,9L,9L,6L,5L,8L,3L,9L,3L,2L,7L,3L,7L,3L,8L,5L,8L,6L,5L,8L,4L,4L,0L,5L,3L,9L,8L,3L,9L,6L,9L,6L,5L,9L,1L,2L,7L,0L,2L,6L,7L,1L,0L,7L,4L,1L,7L,1L,1L,3L,6L,0L,1L,0L,2L,3L,4L,8L,0L,3L,5L,3L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188485Inst : IEnumerable<long>
{
public static readonly long[] Value=A188485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188485.Bytes);
public long this[int i]=>Value[i];

public static A188485Inst Instance=new A188485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188486
{
public static readonly long[] Value={ 550564L,15038884L,57365476L,197686728L,257859364L,1027291978962L,4644774970276L,319916794343524L,694453849937352L,97695446432293264L,359108743507594276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188486Inst : IEnumerable<long>
{
public static readonly long[] Value=A188486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188486.Bytes);
public long this[int i]=>Value[i];

public static A188486Inst Instance=new A188486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188487
{
public static readonly long[] Value={ -25L,-361L,-169L,-5041L,-2809L,-14641L,41209L,-13225L,-552049L,-2505889L,-1849L,-38809L,-17161L,648025L,-1113025L,2265025L,-609961L,-935089L,140351409L,-18156121L,41744521L,-20241001L,-139405249L,-7225L,-255025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188487Inst : IEnumerable<long>
{
public static readonly long[] Value=A188487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188487.Bytes);
public long this[int i]=>Value[i];

public static A188487Inst Instance=new A188487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188488
{
public static readonly long[] Value={ 41209L,648025L,2265025L,140351409L,41744521L,171224646849L,165946243225L,18258793926961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188488Inst : IEnumerable<long>
{
public static readonly long[] Value=A188488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188488.Bytes);
public long this[int i]=>Value[i];

public static A188488Inst Instance=new A188488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188489
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,61L,797L,16021L,457285L,17529203L,867230231L,53745914922L,4076301322848L,371301496685164L,39992538951200636L,5027440719872343598L,BigInteger.Parse("729432303460596468394"),BigInteger.Parse("120977789712983152108734"),BigInteger.Parse("22743262423568258626295550") };
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
public class A188489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188489Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188489.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188489Inst Instance=new A188489Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188490
{
public static readonly BigInteger[] Value={ 1L,1L,2L,10L,146L,6010L,636428L,163326124L,98126803670L,134925234752998L,417644922244986812L,BigInteger.Parse("2873459543869519132876"),BigInteger.Parse("43497844823465975411261876"),BigInteger.Parse("1436705096446765490152625035300"),BigInteger.Parse("102817732537500055044863771641124696") };
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
public class A188490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188490Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188490.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188490Inst Instance=new A188490Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188491
{
public static readonly long[] Value={ 0L,1L,2L,6L,14L,48L,152L,476L,1425L,4340L,13288L,40852L,125124L,382888L,1171612L,3587505L,10985790L,33638142L,102988410L,315318756L,965432832L,2955964296L,9050522241L,27710613432L,84843476928L,259771465608L,795361704776L,2435217884992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188491Inst : IEnumerable<long>
{
public static readonly long[] Value=A188491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188491.Bytes);
public long this[int i]=>Value[i];

public static A188491Inst Instance=new A188491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188556
{
public static readonly long[] Value={ 6L,11L,20L,36L,64L,112L,192L,321L,522L,825L,1268L,1898L,2772L,3958L,5536L,7599L,10254L,13623L,17844L,23072L,29480L,37260L,46624L,57805L,71058L,86661L,104916L,126150L,150716L,178994L,211392L,248347L,290326L,337827L,391380L,451548L,518928L,594152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188556Inst : IEnumerable<long>
{
public static readonly long[] Value=A188556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188556.Bytes);
public long this[int i]=>Value[i];

public static A188556Inst Instance=new A188556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188557
{
public static readonly long[] Value={ 7L,13L,24L,44L,80L,144L,256L,448L,769L,1291L,2116L,3384L,5282L,8054L,12012L,17548L,25147L,35401L,49024L,66868L,89940L,119420L,156680L,203304L,261109L,332167L,418828L,523744L,649894L,800610L,979604L,1190996L,1439343L,1729669L,2067496L,2458876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188557Inst : IEnumerable<long>
{
public static readonly long[] Value=A188557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188557.Bytes);
public long this[int i]=>Value[i];

public static A188557Inst Instance=new A188557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188558
{
public static readonly long[] Value={ 8L,15L,28L,52L,96L,176L,320L,576L,1024L,1793L,3084L,5200L,8584L,13866L,21920L,33932L,51480L,76627L,112028L,161052L,227920L,317860L,437280L,593960L,797264L,1058373L,1390540L,1809368L,2333112L,2983006L,3783616L,4763220L,5954216L,7393559L,9123228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188558Inst : IEnumerable<long>
{
public static readonly long[] Value=A188558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188558.Bytes);
public long this[int i]=>Value[i];

public static A188558Inst Instance=new A188558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188559
{
public static readonly long[] Value={ 9L,17L,32L,60L,112L,208L,384L,704L,1280L,2304L,4097L,7181L,12381L,20965L,34831L,56751L,90683L,142163L,218790L,330818L,491870L,719790L,1037650L,1474930L,2068890L,2866154L,3924527L,5315067L,7124435L,9457547L,12440553L,16224169L,20987389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188559Inst : IEnumerable<long>
{
public static readonly long[] Value=A188559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188559.Bytes);
public long this[int i]=>Value[i];

public static A188559Inst Instance=new A188559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188560
{
public static readonly BigInteger[] Value={ 2L,16L,247L,13306L,2109386L,924245906L,1199747927824L,4515869742994831L,BigInteger.Parse("49132225919211100127"),BigInteger.Parse("1553292806575822383425281"),BigInteger.Parse("142435222420745509758550159896"),BigInteger.Parse("37880215295994989398957106920807127") };
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
public class A188560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188560Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188560.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188560Inst Instance=new A188560Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188561
{
public static readonly long[] Value={ 7L,49L,247L,1383L,7722L,42712L,237116L,1315783L,7300042L,40505756L,224748056L,1247024929L,6919195733L,38391539384L,213017628693L,1181940415631L,6558063227535L,36387785244039L,201899687047572L,1120251845376251L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188561Inst : IEnumerable<long>
{
public static readonly long[] Value=A188561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188561.Bytes);
public long this[int i]=>Value[i];

public static A188561Inst Instance=new A188561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188562
{
public static readonly long[] Value={ 13L,169L,1383L,13306L,127951L,1204078L,11433452L,108485757L,1028265705L,9752393774L,92483653644L,876991515012L,8316617769514L,78866430165460L,747888040870634L,7092226692541037L,67255536562092087L,637783755852399275L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188562Inst : IEnumerable<long>
{
public static readonly long[] Value=A188562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188562.Bytes);
public long this[int i]=>Value[i];

public static A188562Inst Instance=new A188562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188563
{
public static readonly BigInteger[] Value={ 24L,576L,7722L,127951L,2109386L,33878337L,550371695L,8927734479L,144690439154L,2346488899945L,38046632240393L,616893545538780L,10002761857812112L,162189251938735563L,2629815638615310378L,BigInteger.Parse("42641195365724382052") };
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
public class A188563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188563Inst Instance=new A188563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188564
{
public static readonly BigInteger[] Value={ 44L,1936L,42712L,1204078L,33878337L,924245906L,25507294349L,703601341153L,19385833712450L,534376376148754L,14729728015524015L,405999164002796680L,11190832837280857035UL,BigInteger.Parse("308460516372631128792"),BigInteger.Parse("8502292714849587051901") };
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
public class A188564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188564Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188564.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188564Inst Instance=new A188564Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188565
{
public static readonly BigInteger[] Value={ 81L,6561L,237116L,11433452L,550371695L,25507294349L,1199747927824L,56394861720488L,2646119200975135L,124263900074691604L,5835027374030395082L,BigInteger.Parse("273966247390359990893"),BigInteger.Parse("12864061918841330330771"),BigInteger.Parse("604024661760799430803651") };
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
public class A188565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188565Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188565.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188565Inst Instance=new A188565Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188566
{
public static readonly BigInteger[] Value={ 149L,22201L,1315783L,108485757L,8927734479L,703601341153L,56394861720488L,4515869742994831L,360954508416470472L,BigInteger.Parse("28877150666649667161"),BigInteger.Parse("2309866725886227499401"),BigInteger.Parse("184755280244849565353940") };
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
public class A188566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188566Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188566.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188566Inst Instance=new A188566Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188567
{
public static readonly long[] Value={ 2L,4L,4L,7L,16L,7L,13L,49L,49L,13L,24L,169L,247L,169L,24L,44L,576L,1383L,1383L,576L,44L,81L,1936L,7722L,13306L,7722L,1936L,81L,149L,6561L,42712L,127951L,127951L,42712L,6561L,149L,274L,22201L,237116L,1204078L,2109386L,1204078L,237116L,22201L,274L,504L,75076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188567Inst : IEnumerable<long>
{
public static readonly long[] Value=A188567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188567.Bytes);
public long this[int i]=>Value[i];

public static A188567Inst Instance=new A188567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188568
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,4L,7L,9L,8L,10L,15L,12L,13L,14L,11L,16L,20L,18L,19L,17L,21L,28L,23L,26L,25L,24L,27L,22L,29L,35L,31L,33L,32L,34L,30L,36L,45L,38L,43L,40L,41L,42L,39L,44L,37L,46L,54L,48L,52L,50L,51L,49L,53L,47L,55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188568Inst : IEnumerable<long>
{
public static readonly long[] Value=A188568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188568.Bytes);
public long this[int i]=>Value[i];

public static A188568Inst Instance=new A188568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188569
{
public static readonly long[] Value={ 3L,5L,7L,8L,10L,10L,11L,13L,14L,15L,13L,14L,19L,18L,19L,17L,16L,21L,20L,25L,21L,18L,26L,21L,25L,22L,23L,30L,24L,31L,21L,22L,32L,30L,33L,21L,29L,31L,28L,36L,27L,30L,35L,36L,34L,23L,27L,41L,35L,38L,35L,26L,40L,36L,45L,34L,25L,44L,34L,39L,32L,37L,49L,38L,51L,33L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188569Inst : IEnumerable<long>
{
public static readonly long[] Value=A188569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188569.Bytes);
public long this[int i]=>Value[i];

public static A188569Inst Instance=new A188569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188570
{
public static readonly long[] Value={ 1L,1L,6L,16L,80L,296L,1296L,5216L,21952L,90304L,375936L,1555456L,6456320L,26754560L,110963712L,460015616L,1907494912L,7908659200L,32792076288L,135963148288L,563742310400L,2337417887744L,9691567030272L,40183767891968L,166612591968256L,690819710058496L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188570Inst : IEnumerable<long>
{
public static readonly long[] Value=A188570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188570.Bytes);
public long this[int i]=>Value[i];

public static A188570Inst Instance=new A188570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188571
{
public static readonly long[] Value={ 0L,1L,2L,14L,48L,224L,880L,3760L,15360L,64192L,265088L,1101440L,4561920L,18925568L,78447616L,325313536L,1348730880L,5592420352L,23187169280L,96141172736L,398624489472L,1652807303168L,6852965761024L,28414229807104L,117812861337600L,488483370827776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188571Inst : IEnumerable<long>
{
public static readonly long[] Value=A188571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188571.Bytes);
public long this[int i]=>Value[i];

public static A188571Inst Instance=new A188571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188876
{
public static readonly long[] Value={ 16L,256L,2032L,21937L,233756L,2368612L,24609576L,255014376L,2634386061L,27264641304L,282086403837L,2918043746684L,30189606384325L,312327215078591L,3231163537843117L,33428102017481312L,345830567133874557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188876Inst : IEnumerable<long>
{
public static readonly long[] Value=A188876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188876.Bytes);
public long this[int i]=>Value[i];

public static A188876Inst Instance=new A188876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188877
{
public static readonly BigInteger[] Value={ 32L,1024L,13045L,252932L,4805140L,84965120L,1558668181L,28472229080L,517776315573L,9442392487092L,172104527985533L,3136183930249272L,57160501361811036L,1041761230924349515L,BigInteger.Parse("18986128724688300231") };
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
public class A188877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188877Inst Instance=new A188877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188878
{
public static readonly BigInteger[] Value={ 64L,4096L,83737L,2915832L,98892196L,3043939392L,98523889293L,3172528318064L,101464669143512L,3258224293964324L,104560302171744053L,3354085571383579972L,BigInteger.Parse("107624415834964708600"),BigInteger.Parse("3453181474717075939696"),BigInteger.Parse("110794646417240343858097") };
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
public class A188878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188878Inst Instance=new A188878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188879
{
public static readonly BigInteger[] Value={ 128L,16384L,537496L,33617513L,2035428944L,109002398784L,6231989402196L,353870576831949L,19905175576044841L,1126107155232462372L,BigInteger.Parse("63649373276613825016"),BigInteger.Parse("3595294680877439593742"),BigInteger.Parse("203177355059869569596960") };
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
public class A188879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188879Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188879.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188879Inst Instance=new A188879Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188880
{
public static readonly BigInteger[] Value={ 256L,65536L,3450100L,387583973L,41894114820L,3903192037184L,394199392835388L,39466951597153578L,3904179563792169392L,BigInteger.Parse("389112055304583124864"),BigInteger.Parse("38733126975093560310741"),BigInteger.Parse("3852354123185134763957569") };
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
public class A188880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188880Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188880.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188880Inst Instance=new A188880Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188881
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,2L,6L,11L,12L,6L,24L,50L,70L,60L,24L,120L,274L,450L,510L,360L,120L,720L,1764L,3248L,4410L,4200L,2520L,720L,5040L,13068L,26264L,40614L,47040L,38640L,20160L,5040L,40320L,109584L,236248L,403704L,538776L,544320L,393120L,181440L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188881Inst : IEnumerable<long>
{
public static readonly long[] Value=A188881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188881.Bytes);
public long this[int i]=>Value[i];

public static A188881Inst Instance=new A188881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188882
{
public static readonly long[] Value={ 3L,6L,1L,0L,3L,1L,7L,2L,9L,8L,2L,8L,1L,7L,6L,6L,8L,2L,3L,6L,2L,4L,7L,1L,7L,6L,2L,5L,8L,4L,8L,5L,2L,7L,6L,9L,2L,1L,7L,3L,7L,9L,9L,4L,4L,4L,9L,6L,1L,9L,9L,0L,6L,5L,1L,4L,8L,3L,3L,3L,5L,5L,8L,1L,6L,2L,2L,6L,0L,3L,3L,5L,3L,9L,9L,8L,9L,0L,4L,2L,0L,9L,2L,2L,1L,7L,4L,6L,7L,7L,5L,4L,8L,4L,3L,4L,5L,1L,3L,2L,8L,5L,2L,2L,6L,3L,2L,0L,7L,3L,5L,8L,4L,5L,1L,6L,3L,7L,1L,1L,7L,2L,7L,1L,2L,9L,1L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188882Inst : IEnumerable<long>
{
public static readonly long[] Value=A188882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188882.Bytes);
public long this[int i]=>Value[i];

public static A188882Inst Instance=new A188882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188883
{
public static readonly long[] Value={ 1L,3L,6L,7L,7L,4L,8L,3L,9L,4L,9L,3L,1L,3L,6L,7L,4L,4L,4L,6L,9L,9L,6L,9L,1L,7L,6L,5L,6L,8L,2L,2L,0L,5L,4L,5L,5L,6L,5L,1L,1L,1L,3L,2L,6L,8L,9L,0L,2L,1L,4L,8L,8L,6L,9L,4L,7L,5L,0L,0L,4L,6L,5L,7L,5L,6L,7L,1L,5L,3L,4L,5L,6L,2L,8L,2L,0L,1L,7L,6L,9L,3L,0L,7L,9L,0L,1L,9L,3L,0L,9L,7L,4L,1L,9L,3L,2L,3L,3L,5L,3L,1L,2L,2L,6L,6L,3L,0L,2L,7L,3L,4L,3L,3L,0L,8L,1L,4L,5L,9L,8L,2L,2L,8L,1L,5L,8L,9L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188883Inst : IEnumerable<long>
{
public static readonly long[] Value=A188883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188883.Bytes);
public long this[int i]=>Value[i];

public static A188883Inst Instance=new A188883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188884
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,1L,3L,1L,1L,5L,1L,7L,1L,1L,23L,2L,2L,4L,3L,1L,11L,158L,1L,1L,1L,1L,4L,2L,1L,6L,2L,19L,75L,1L,1L,1L,28L,1L,29L,6L,8L,1L,5L,1L,4L,2L,1L,8L,1L,1L,19L,1L,1L,9L,2L,2L,3L,1L,2L,11L,1L,1L,3L,1L,1L,4L,169L,1L,1L,2L,1L,3L,1L,1L,10L,2L,1L,3L,8L,2L,4L,8L,5L,1L,8L,1L,7L,1L,1L,1L,1L,4L,38L,1L,5L,1L,43L,1L,1L,1L,1L,2L,1L,8L,1L,20L,1L,1L,1L,2L,13L,51L,2L,21L,1L,2L,5L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188884Inst : IEnumerable<long>
{
public static readonly long[] Value=A188884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188884.Bytes);
public long this[int i]=>Value[i];

public static A188884Inst Instance=new A188884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188885
{
public static readonly long[] Value={ 1L,4L,3L,3L,4L,0L,0L,5L,7L,3L,4L,0L,5L,1L,5L,4L,8L,4L,6L,3L,3L,1L,9L,0L,6L,9L,1L,9L,9L,7L,6L,7L,5L,2L,3L,2L,8L,8L,4L,3L,3L,9L,1L,1L,8L,3L,9L,5L,3L,6L,7L,0L,7L,8L,9L,8L,2L,5L,7L,9L,4L,6L,7L,9L,5L,0L,7L,5L,2L,7L,3L,9L,3L,9L,0L,5L,2L,7L,0L,6L,8L,9L,7L,5L,0L,7L,3L,6L,9L,7L,8L,9L,0L,9L,2L,5L,4L,5L,6L,5L,0L,5L,7L,4L,3L,2L,9L,4L,0L,8L,7L,5L,5L,5L,9L,0L,7L,4L,4L,7L,4L,8L,2L,3L,5L,3L,9L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188885Inst : IEnumerable<long>
{
public static readonly long[] Value=A188885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188885.Bytes);
public long this[int i]=>Value[i];

public static A188885Inst Instance=new A188885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188886
{
public static readonly long[] Value={ 1L,2L,3L,3L,1L,15L,1L,3L,7L,1L,2L,4L,2L,1L,4L,1L,1L,12L,4L,52L,1L,2L,1L,7L,3L,6L,1L,21L,1L,11L,1L,4L,1L,3L,2L,3L,2L,7L,1L,1L,2L,1L,3L,2L,1L,43L,4L,1L,1L,4L,4L,18L,2L,4L,4L,2L,1L,2L,3L,1L,3L,9L,1L,9L,4L,1L,6L,1L,1L,1L,2L,10L,1L,1L,1L,1L,2L,1L,2L,1L,2L,21L,2L,2L,1L,4L,1L,3L,12L,1L,9L,6L,1L,1L,4L,5L,2L,1L,1L,1L,1L,3L,1L,3L,16L,1L,6L,3L,10L,1L,8L,1L,8L,1L,13L,21L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188886Inst : IEnumerable<long>
{
public static readonly long[] Value=A188886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188886.Bytes);
public long this[int i]=>Value[i];

public static A188886Inst Instance=new A188886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188887
{
public static readonly long[] Value={ 1L,9L,3L,1L,8L,5L,1L,6L,5L,2L,5L,7L,8L,1L,3L,6L,5L,7L,3L,4L,9L,9L,4L,8L,6L,3L,9L,9L,4L,5L,7L,7L,9L,4L,7L,3L,5L,2L,6L,7L,8L,0L,9L,6L,7L,8L,0L,1L,6L,8L,0L,9L,1L,0L,0L,8L,0L,4L,6L,8L,6L,1L,5L,2L,6L,2L,0L,8L,4L,6L,4L,2L,7L,9L,5L,9L,7L,1L,1L,0L,3L,2L,6L,9L,5L,1L,2L,3L,4L,8L,3L,7L,1L,6L,1L,4L,0L,9L,0L,3L,7L,7L,6L,8L,0L,4L,2L,2L,3L,7L,2L,8L,7L,6L,3L,2L,4L,3L,0L,7L,4L,8L,9L,1L,8L,5L,0L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188887Inst : IEnumerable<long>
{
public static readonly long[] Value=A188887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188887.Bytes);
public long this[int i]=>Value[i];

public static A188887Inst Instance=new A188887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188888
{
public static readonly long[] Value={ 1L,1L,13L,1L,2L,15L,10L,1L,18L,1L,1L,21L,2L,1L,1L,2L,4L,5L,2L,2L,2L,11L,1L,2L,2L,3L,1L,1L,10L,1L,2L,1L,2L,3L,2L,3L,15L,1L,2L,3L,1L,1L,90L,1L,44L,2L,4L,10L,1L,11L,9L,1L,17L,1L,8L,2L,2L,6L,2L,6L,1L,3L,1L,1L,1L,2L,20L,1L,7L,27L,1L,19L,40L,1L,304L,1L,1L,2L,1L,1L,1L,62L,1L,1L,2L,1L,2L,1L,32L,1L,1L,1L,11L,1L,20L,1L,85L,1L,1L,1L,3L,3L,13L,1L,4L,1L,3L,1L,3L,1L,16L,1L,9L,3L,2L,1L,1L,30L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188888Inst : IEnumerable<long>
{
public static readonly long[] Value=A188888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188888.Bytes);
public long this[int i]=>Value[i];

public static A188888Inst Instance=new A188888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188889
{
public static readonly long[] Value={ 3L,5L,3L,5L,7L,5L,9L,5L,7L,5L,3L,3L,3L,5L,5L,5L,3L,5L,3L,3L,5L,3L,3L,5L,3L,5L,7L,7L,3L,3L,5L,5L,3L,3L,3L,5L,5L,7L,7L,5L,9L,7L,3L,3L,3L,15L,7L,3L,3L,3L,3L,5L,3L,7L,3L,5L,5L,7L,3L,3L,5L,3L,5L,3L,3L,3L,5L,5L,5L,5L,5L,5L,7L,5L,5L,3L,5L,3L,3L,3L,5L,3L,13L,3L,3L,3L,3L,13L,3L,3L,5L,5L,3L,7L,3L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188889Inst : IEnumerable<long>
{
public static readonly long[] Value=A188889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188889.Bytes);
public long this[int i]=>Value[i];

public static A188889Inst Instance=new A188889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188890
{
public static readonly BigInteger[] Value={ 1L,8L,9216L,1763704832L,55786539933761536L,BigInteger.Parse("291139753716719964894789632"),BigInteger.Parse("250571020614762113258116708732764160000"),BigInteger.Parse("35558299325468842404742419202148426327085023232000000"),BigInteger.Parse("831952537599396321581603077837672266625608464198409017861335832068096") };
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
public class A188890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188890Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188890.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188890Inst Instance=new A188890Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188891
{
public static readonly long[] Value={ 3L,36L,210L,6L,55L,21L,325L,10L,0L,105L,36L,1275L,15L,45L,231L,0L,946L,276L,21L,11935L,66L,136L,351L,1596L,78L,28L,1225L,595L,820L,58653L,190L,325L,1335795L,36L,6670L,0L,561L,4005L,120L,1128L,1485L,203841L,45L,666L,6903L,465L,4950L,20910L,741L,153L,10731L,8911L,55L,1953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188891Inst : IEnumerable<long>
{
public static readonly long[] Value=A188891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188891.Bytes);
public long this[int i]=>Value[i];

public static A188891Inst Instance=new A188891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188908
{
public static readonly BigInteger[] Value={ 128L,16384L,665252L,18939904L,677191152L,28911561156L,1206854973408L,47643981661444L,1870392568831572L,74546289546608896L,2989564396574586164L,BigInteger.Parse("119559739844207522500"),BigInteger.Parse("4770354565229669315712"),BigInteger.Parse("190382246019401796651204") };
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
public class A188908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188908Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188908.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188908Inst Instance=new A188908Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188909
{
public static readonly BigInteger[] Value={ 256L,65536L,4268356L,180741136L,10097838144L,705042350224L,47643981661444L,2985549816834225L,185475182040880209L,11768170780317237049UL,BigInteger.Parse("753113609713108644676"),BigInteger.Parse("47991037250729119391296"),BigInteger.Parse("3047006228790888999180484") };
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
public class A188909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188909Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188909.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188909Inst Instance=new A188909Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188910
{
public static readonly long[] Value={ 2L,4L,4L,8L,16L,8L,16L,64L,64L,16L,32L,256L,400L,256L,32L,64L,1024L,2500L,2500L,1024L,64L,128L,4096L,16100L,21904L,16100L,4096L,128L,256L,16384L,103684L,204304L,204304L,103684L,16384L,256L,512L,65536L,665252L,1971216L,2895584L,1971216L,665252L,65536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188910Inst : IEnumerable<long>
{
public static readonly long[] Value=A188910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188910.Bytes);
public long this[int i]=>Value[i];

public static A188910Inst Instance=new A188910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188911
{
public static readonly long[] Value={ 1L,6L,48L,438L,4356L,46056L,509106L,5814738L,68050116L,811240872L,9810384048L,119990105208L,1481115683754L,18421300391760L,230574816629310L,2901721280735838L,36688485233689668L,465774244616805624L,5934465567864915024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188911Inst : IEnumerable<long>
{
public static readonly long[] Value=A188911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188911.Bytes);
public long this[int i]=>Value[i];

public static A188911Inst Instance=new A188911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188912
{
public static readonly long[] Value={ 1L,2L,8L,42L,260L,1816L,13962L,116094L,1029124L,9609144L,93569808L,942642696L,9763181946L,103455616400L,1117379189926L,12264816349938L,136501928050116L,1537591374945704L,17503603786398576L,201128739609458904L,2330480521265639136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188912Inst : IEnumerable<long>
{
public static readonly long[] Value=A188912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188912.Bytes);
public long this[int i]=>Value[i];

public static A188912Inst Instance=new A188912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188913
{
public static readonly long[] Value={ 1L,4L,24L,168L,1300L,10896L,97734L,928752L,9262116L,96091440L,1029267888L,11311712352L,126921365298L,1448378629600L,16760687848890L,196237061599008L,2320532776851972L,27676644749022672L,332568471941572944L,4022574792189178080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188913Inst : IEnumerable<long>
{
public static readonly long[] Value=A188913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188913.Bytes);
public long this[int i]=>Value[i];

public static A188913Inst Instance=new A188913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188914
{
public static readonly long[] Value={ 2L,5L,19L,97L,601L,4321L,35281L,322561L,3265921L,36288001L,439084801L,5748019201L,80951270401L,1220496076801L,19615115520001L,334764638208001L,6046686277632001L,115242726703104001L,2311256907767808001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188914Inst : IEnumerable<long>
{
public static readonly long[] Value=A188914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188914.Bytes);
public long this[int i]=>Value[i];

public static A188914Inst Instance=new A188914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188915
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,16L,25L,32L,36L,49L,64L,81L,100L,121L,128L,144L,169L,196L,225L,256L,289L,324L,361L,400L,441L,484L,512L,529L,576L,625L,676L,729L,784L,841L,900L,961L,1024L,1089L,1156L,1225L,1296L,1369L,1444L,1521L,1600L,1681L,1764L,1849L,1936L,2025L,2048L,2116L,2209L,2304L,2401L,2500L,2601L,2704L,2809L,2916L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188915Inst : IEnumerable<long>
{
public static readonly long[] Value=A188915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188915.Bytes);
public long this[int i]=>Value[i];

public static A188915Inst Instance=new A188915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188916
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,7L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,23L,24L,25L,26L,28L,29L,30L,31L,32L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,80L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,91L,92L,93L,94L,95L,96L,98L,99L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188916Inst : IEnumerable<long>
{
public static readonly long[] Value=A188916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188916.Bytes);
public long this[int i]=>Value[i];

public static A188916Inst Instance=new A188916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188917
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,11L,15L,20L,27L,37L,51L,70L,97L,135L,189L,264L,371L,521L,734L,1034L,1459L,2059L,2908L,4108L,5805L,8205L,11599L,16398L,23185L,32783L,46356L,65552L,92698L,131089L,185381L,262162L,370746L,524307L,741475L,1048596L,1482931L,2097173L,2965842L,4194326L,5931664L,8388631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188917Inst : IEnumerable<long>
{
public static readonly long[] Value=A188917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188917.Bytes);
public long this[int i]=>Value[i];

public static A188917Inst Instance=new A188917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188918
{
public static readonly BigInteger[] Value={ 1L,5L,85L,1595L,33055L,723701L,16429435L,382643525L,9082868245L,218790563255L,5332206228085L,131194789234955L,3253536973286245L,81224561099580155L,2039348104811147845L,BigInteger.Parse("51455631680563483835"),BigInteger.Parse("1303889832725451598495") };
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
public class A188918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188918Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188918.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188918Inst Instance=new A188918Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188919
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,2L,4L,3L,3L,1L,1L,1L,2L,4L,7L,8L,9L,9L,6L,4L,1L,1L,1L,2L,4L,7L,13L,16L,22L,26L,29L,26L,23L,17L,10L,5L,1L,1L,1L,2L,4L,7L,13L,22L,31L,44L,60L,74L,89L,95L,98L,93L,82L,63L,47L,29L,15L,6L,1L,1L,1L,2L,4L,7L,13L,22L,38L,55L,83L,116L,160L,207L,259L,304L,347L,375L,386L,378L,348L,304L,249L,190L,131L,85L,46L,21L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188919Inst : IEnumerable<long>
{
public static readonly long[] Value=A188919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188919.Bytes);
public long this[int i]=>Value[i];

public static A188919Inst Instance=new A188919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188920
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,13L,22L,38L,63L,105L,169L,274L,434L,686L,1069L,1660L,2548L,3897L,5906L,8911L,13352L,19917L,29532L,43605L,64056L,93715L,136499L,198059L,286233L,412199L,591455L,845851L,1205687L,1713286L,2427177L,3428611L,4829563L,6784550L,9505840L,13284849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188920Inst : IEnumerable<long>
{
public static readonly long[] Value=A188920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188920.Bytes);
public long this[int i]=>Value[i];

public static A188920Inst Instance=new A188920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188921
{
public static readonly long[] Value={ 0L,1L,1L,0L,2L,1L,1L,1L,0L,0L,2L,0L,2L,2L,1L,1L,3L,0L,0L,0L,1L,0L,2L,0L,0L,0L,2L,1L,0L,2L,2L,2L,2L,1L,2L,2L,1L,2L,0L,2L,0L,1L,2L,1L,2L,0L,2L,0L,0L,0L,0L,0L,1L,2L,2L,2L,2L,1L,2L,1L,0L,1L,2L,0L,0L,0L,0L,2L,2L,1L,1L,0L,0L,2L,2L,1L,0L,0L,2L,0L,0L,1L,0L,1L,0L,2L,2L,1L,0L,0L,1L,1L,0L,2L,2L,0L,2L,2L,0L,2L,0L,2L,1L,1L,0L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,1L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188921Inst : IEnumerable<long>
{
public static readonly long[] Value=A188921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188921.Bytes);
public long this[int i]=>Value[i];

public static A188921Inst Instance=new A188921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188922
{
public static readonly long[] Value={ 2L,1L,8L,8L,9L,0L,1L,0L,5L,9L,3L,1L,6L,7L,3L,3L,9L,4L,2L,0L,1L,4L,5L,3L,1L,0L,4L,7L,5L,7L,2L,5L,6L,6L,3L,9L,6L,3L,2L,6L,5L,3L,2L,2L,1L,8L,4L,4L,6L,4L,1L,5L,4L,0L,4L,2L,1L,2L,0L,7L,0L,7L,1L,9L,3L,2L,6L,5L,0L,0L,9L,2L,0L,0L,6L,9L,5L,4L,1L,8L,3L,2L,4L,2L,0L,7L,6L,9L,5L,3L,6L,6L,1L,5L,8L,9L,6L,0L,9L,3L,1L,4L,5L,3L,4L,5L,3L,5L,9L,8L,7L,6L,9L,5L,2L,0L,8L,3L,0L,6L,2L,8L,5L,6L,7L,3L,7L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188922Inst : IEnumerable<long>
{
public static readonly long[] Value=A188922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188922.Bytes);
public long this[int i]=>Value[i];

public static A188922Inst Instance=new A188922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188923
{
public static readonly long[] Value={ 2L,5L,3L,2L,2L,9L,1L,2L,1L,2L,1L,9L,4L,1L,2L,1L,1L,1L,3L,1L,1L,2L,7L,1L,3L,1203L,1L,1L,10L,2L,1L,1L,3L,85L,11L,3L,1L,1L,1L,4L,1L,2L,10L,1L,2L,1L,4L,2L,2L,11L,1L,100L,1L,10L,5L,17L,2L,1L,9L,6L,1L,2L,1L,2L,3L,1L,2L,1L,11L,9L,5L,1L,3L,8L,1L,10L,3L,1L,1L,1L,3L,1L,1L,1L,1L,37L,10L,3L,1L,11L,5L,2L,2L,2L,32L,1L,11L,20L,3L,1L,7L,2L,4L,6L,1L,1L,3L,1L,4L,1L,1L,3L,1L,1L,1L,1L,2L,8L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188923Inst : IEnumerable<long>
{
public static readonly long[] Value=A188923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188923.Bytes);
public long this[int i]=>Value[i];

public static A188923Inst Instance=new A188923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188940
{
public static readonly long[] Value={ 2L,3L,4L,4L,3L,5L,5L,6L,2L,9L,2L,5L,3L,6L,2L,5L,8L,6L,9L,0L,8L,3L,4L,6L,6L,9L,2L,4L,2L,4L,0L,5L,7L,2L,1L,7L,2L,1L,6L,4L,0L,0L,9L,2L,3L,5L,9L,7L,8L,5L,6L,6L,5L,3L,0L,1L,5L,8L,5L,1L,9L,0L,2L,6L,8L,4L,0L,3L,1L,2L,6L,2L,2L,4L,3L,5L,7L,7L,9L,4L,9L,2L,5L,9L,9L,6L,1L,4L,3L,3L,3L,2L,0L,6L,9L,2L,3L,3L,9L,0L,9L,0L,6L,3L,9L,3L,8L,3L,4L,6L,5L,0L,1L,3L,5L,2L,1L,9L,4L,6L,5L,6L,2L,8L,3L,6L,9L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188940Inst : IEnumerable<long>
{
public static readonly long[] Value=A188940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188940.Bytes);
public long this[int i]=>Value[i];

public static A188940Inst Instance=new A188940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188941
{
public static readonly long[] Value={ 4L,2L,6L,5L,5L,6L,4L,4L,3L,7L,0L,7L,4L,6L,3L,7L,4L,1L,3L,0L,9L,1L,6L,5L,3L,3L,0L,7L,5L,7L,5L,9L,4L,2L,7L,8L,2L,7L,8L,3L,5L,9L,9L,0L,7L,6L,4L,0L,2L,1L,4L,3L,3L,4L,6L,9L,8L,4L,1L,4L,8L,0L,9L,7L,3L,1L,5L,9L,6L,8L,7L,3L,7L,7L,5L,6L,4L,2L,2L,0L,5L,0L,7L,4L,0L,0L,3L,8L,5L,6L,6L,6L,7L,9L,3L,0L,7L,6L,6L,0L,9L,0L,9L,3L,6L,0L,6L,1L,6L,5L,3L,4L,9L,8L,6L,4L,7L,8L,0L,5L,3L,4L,3L,7L,1L,6L,3L,0L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188941Inst : IEnumerable<long>
{
public static readonly long[] Value=A188941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188941.Bytes);
public long this[int i]=>Value[i];

public static A188941Inst Instance=new A188941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188942
{
public static readonly long[] Value={ 5L,6L,5L,7L,4L,1L,4L,5L,4L,0L,8L,9L,3L,3L,5L,1L,1L,7L,8L,1L,3L,4L,6L,3L,1L,2L,2L,0L,8L,8L,2L,5L,0L,6L,7L,5L,6L,2L,4L,7L,8L,3L,9L,0L,4L,3L,5L,9L,1L,2L,5L,6L,3L,1L,2L,1L,4L,9L,2L,4L,4L,9L,0L,6L,2L,8L,8L,0L,5L,5L,0L,8L,6L,1L,7L,8L,3L,1L,5L,9L,2L,4L,6L,5L,8L,9L,6L,8L,1L,9L,6L,6L,3L,5L,8L,4L,8L,8L,0L,3L,8L,7L,7L,4L,7L,6L,3L,6L,3L,2L,9L,3L,2L,2L,7L,4L,3L,2L,7L,0L,6L,6L,1L,5L,5L,3L,6L,2L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188942Inst : IEnumerable<long>
{
public static readonly long[] Value=A188942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188942.Bytes);
public long this[int i]=>Value[i];

public static A188942Inst Instance=new A188942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188943
{
public static readonly long[] Value={ 1L,7L,6L,7L,5L,9L,1L,8L,7L,9L,2L,4L,3L,9L,9L,8L,2L,1L,5L,5L,1L,9L,8L,7L,0L,2L,1L,1L,2L,4L,5L,0L,8L,2L,6L,5L,7L,7L,0L,8L,5L,4L,9L,4L,2L,8L,9L,7L,4L,2L,0L,7L,7L,0L,2L,1L,1L,8L,4L,0L,8L,8L,4L,2L,7L,0L,4L,5L,2L,7L,8L,2L,4L,7L,1L,5L,5L,0L,1L,7L,4L,0L,8L,6L,7L,4L,3L,6L,5L,1L,3L,6L,6L,9L,7L,4L,8L,4L,5L,2L,9L,4L,5L,5L,8L,5L,6L,9L,7L,0L,0L,4L,0L,1L,0L,5L,9L,0L,0L,6L,2L,6L,7L,1L,7L,7L,9L,7L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188943Inst : IEnumerable<long>
{
public static readonly long[] Value=A188943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188943.Bytes);
public long this[int i]=>Value[i];

public static A188943Inst Instance=new A188943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188944
{
public static readonly long[] Value={ 4L,5L,1L,4L,1L,6L,2L,2L,9L,6L,4L,5L,1L,3L,6L,4L,6L,9L,8L,3L,2L,7L,9L,4L,7L,4L,8L,7L,8L,6L,9L,1L,3L,1L,9L,1L,4L,2L,9L,9L,1L,3L,6L,0L,5L,6L,3L,9L,1L,8L,3L,2L,7L,3L,2L,1L,0L,5L,5L,5L,1L,8L,0L,2L,6L,6L,3L,1L,0L,3L,9L,2L,2L,5L,6L,5L,7L,2L,1L,2L,4L,0L,7L,9L,8L,6L,9L,0L,3L,7L,8L,4L,1L,8L,1L,8L,7L,9L,6L,4L,6L,1L,6L,4L,5L,1L,4L,0L,5L,5L,3L,8L,3L,4L,1L,7L,8L,9L,6L,8L,0L,8L,5L,4L,9L,0L,0L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188944Inst : IEnumerable<long>
{
public static readonly long[] Value=A188944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188944.Bytes);
public long this[int i]=>Value[i];

public static A188944Inst Instance=new A188944Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188945
{
public static readonly long[] Value={ 2L,2L,1L,5L,2L,5L,0L,4L,3L,7L,0L,2L,1L,5L,3L,0L,1L,9L,6L,8L,3L,3L,8L,7L,1L,9L,1L,7L,8L,7L,9L,7L,5L,3L,4L,7L,5L,2L,3L,6L,7L,5L,3L,0L,6L,1L,0L,2L,7L,4L,8L,3L,3L,9L,3L,4L,5L,6L,1L,1L,1L,4L,8L,6L,4L,0L,0L,3L,5L,6L,2L,7L,4L,4L,1L,0L,0L,9L,4L,5L,4L,2L,5L,8L,6L,7L,9L,7L,6L,2L,8L,8L,2L,4L,8L,4L,7L,8L,7L,0L,2L,0L,5L,0L,2L,1L,5L,2L,6L,1L,1L,2L,8L,3L,2L,4L,8L,7L,6L,9L,8L,5L,8L,1L,1L,7L,6L,6L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A188945Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188945.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188945Inst : IEnumerable<long>
{
public static readonly long[] Value=A188945.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188945.Bytes);
public long this[int i]=>Value[i];

public static A188945Inst Instance=new A188945Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A188946
{
public static readonly BigInteger[] Value={ 1L,7L,103L,1969L,41935L,947737L,22248409L,536310271L,13183283743L,328970388985L,8307368234473L,211822788505951L,5444571611722369L,140892128574440887L,3667015053678269095L,BigInteger.Parse("95918056089104563489"),BigInteger.Parse("2519845343307697266943") };
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
public class A188946Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A188946.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A188946Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A188946.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A188946.Bytes);
public BigInteger this[int i]=>Value[i];

public static A188946Inst Instance=new A188946Inst();

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