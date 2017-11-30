using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A259562
{
public static readonly long[] Value={ 2L,414L,556L,3962L,4972L,6151L,6521L,8440L,8665L,13769L,13909L,15576L,16696L,17176L,19926L,20630L,21541L,27090L,30822L,62118L,65349L,74014L,94203L,98600L,101231L,103058L,108333L,112332L,136036L,142714L,145588L,147150L,160730L,162366L,169137L,194681L,200837L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259562Inst : IEnumerable<long>
{
public static readonly long[] Value=A259562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259562.Bytes);
public long this[int i]=>Value[i];

public static A259562Inst Instance=new A259562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259563
{
public static readonly BigInteger[] Value={ 0L,0L,2571912L,2472394752L,138662798400L,1666179072000L,-4637478825000L,-272992368918528L,-3187483870330368L,-23209723979366400L,-126970182577359000L,-566493158246400000L,-2161675076294530368L,-7278963158259007488L,BigInteger.Parse("-22112928086617859400"),BigInteger.Parse("-61611251010011136000") };
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
public class A259563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259563Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259563.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259563Inst Instance=new A259563Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259564
{
public static readonly long[] Value={ 5L,7L,11L,30L,133L,160L,415L,527L,883L,1257L,2025L,2771L,2775L,6650L,6932L,13793L,19091L,30695L,32341L,33722L,36372L,37944L,40532L,42141L,47230L,60986L,77956L,82165L,90564L,111414L,113106L,136036L,147573L,148357L,158279L,169137L,169604L,171549L,174540L,187679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259564Inst : IEnumerable<long>
{
public static readonly long[] Value=A259564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259564.Bytes);
public long this[int i]=>Value[i];

public static A259564Inst Instance=new A259564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259565
{
public static readonly long[] Value={ 1L,3L,7L,5L,9L,11L,15L,13L,17L,21L,23L,19L,25L,27L,31L,29L,33L,35L,39L,37L,41L,43L,49L,45L,47L,55L,51L,59L,57L,53L,61L,63L,67L,65L,69L,71L,75L,73L,81L,77L,79L,85L,87L,83L,89L,93L,95L,91L,97L,105L,99L,103L,101L,109L,111L,107L,113L,115L,121L,117L,119L,125L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259565Inst : IEnumerable<long>
{
public static readonly long[] Value=A259565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259565.Bytes);
public long this[int i]=>Value[i];

public static A259565Inst Instance=new A259565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259566
{
public static readonly long[] Value={ 1L,4L,7L,13L,16L,22L,25L,40L,43L,49L,52L,67L,70L,76L,79L,121L,124L,130L,133L,148L,151L,157L,160L,202L,205L,211L,214L,229L,232L,238L,241L,364L,367L,373L,376L,391L,394L,400L,403L,445L,448L,454L,457L,472L,475L,481L,484L,607L,610L,616L,619L,634L,637L,643L,646L,688L,691L,697L,700L,715L,718L,724L,727L,1093L,1096L,1102L,1105L,1120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259566Inst : IEnumerable<long>
{
public static readonly long[] Value=A259566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259566.Bytes);
public long this[int i]=>Value[i];

public static A259566Inst Instance=new A259566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259567
{
public static readonly long[] Value={ 0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,3L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259567Inst : IEnumerable<long>
{
public static readonly long[] Value=A259567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259567.Bytes);
public long this[int i]=>Value[i];

public static A259567Inst Instance=new A259567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259568
{
public static readonly long[] Value={ 1L,5L,9L,13L,21L,25L,29L,37L,41L,45L,53L,57L,61L,85L,89L,93L,101L,105L,109L,117L,121L,125L,149L,153L,157L,165L,169L,173L,181L,185L,189L,213L,217L,221L,229L,233L,237L,245L,249L,253L,341L,345L,349L,357L,361L,365L,373L,377L,381L,405L,409L,413L,421L,425L,429L,437L,441L,445L,469L,473L,477L,485L,489L,493L,501L,505L,509L,597L,601L,605L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259568Inst : IEnumerable<long>
{
public static readonly long[] Value=A259568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259568.Bytes);
public long this[int i]=>Value[i];

public static A259568Inst Instance=new A259568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259569
{
public static readonly long[] Value={ 1L,2L,1L,6L,6L,1L,12L,24L,14L,1L,20L,60L,70L,30L,1L,30L,120L,210L,180L,62L,1L,42L,210L,490L,630L,434L,126L,1L,56L,336L,980L,1680L,1736L,1008L,254L,1L,72L,504L,1764L,3780L,5208L,4536L,2286L,510L,1L,90L,720L,2940L,7560L,13020L,15120L,11430L,5100L,1022L,1L,110L,990L,4620L,13860L,28644L,41580L,41910L,28050L,11242L,2046L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259569Inst : IEnumerable<long>
{
public static readonly long[] Value=A259569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259569.Bytes);
public long this[int i]=>Value[i];

public static A259569Inst Instance=new A259569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259570
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,6L,8L,7L,9L,12L,10L,11L,13L,14L,16L,15L,17L,18L,20L,19L,21L,22L,24L,25L,23L,27L,30L,26L,29L,28L,31L,32L,34L,33L,35L,36L,38L,37L,40L,41L,39L,44L,42L,43L,45L,48L,46L,47L,49L,51L,53L,52L,50L,56L,54L,55L,57L,58L,60L,61L,59L,65L,62L,67L,63L,64L,68L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259570Inst : IEnumerable<long>
{
public static readonly long[] Value=A259570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259570.Bytes);
public long this[int i]=>Value[i];

public static A259570Inst Instance=new A259570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259571
{
public static readonly long[] Value={ 3L,7L,8L,17L,23L,27L,38L,39L,43L,48L,58L,65L,66L,67L,68L,69L,74L,75L,76L,77L,78L,83L,84L,88L,89L,91L,92L,93L,98L,99L,105L,110L,113L,140L,156L,157L,170L,182L,186L,188L,191L,194L,205L,212L,215L,218L,222L,227L,229L,234L,235L,241L,246L,247L,252L,267L,287L,293L,294L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259571Inst : IEnumerable<long>
{
public static readonly long[] Value=A259571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259571.Bytes);
public long this[int i]=>Value[i];

public static A259571Inst Instance=new A259571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259572
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,2L,3L,2L,0L,0L,2L,3L,3L,2L,0L,0L,3L,4L,6L,4L,3L,0L,0L,3L,6L,6L,6L,6L,3L,0L,0L,4L,6L,8L,10L,8L,6L,4L,0L,0L,4L,7L,9L,10L,10L,9L,7L,4L,0L,0L,5L,9L,12L,12L,15L,12L,12L,9L,5L,0L,0L,5L,9L,12L,14L,15L,15L,14L,12L,9L,5L,0L,0L,6L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259572Inst : IEnumerable<long>
{
public static readonly long[] Value=A259572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259572.Bytes);
public long this[int i]=>Value[i];

public static A259572Inst Instance=new A259572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259573
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,3L,6L,5L,6L,3L,8L,3L,6L,7L,8L,3L,8L,3L,8L,9L,6L,3L,12L,5L,6L,7L,10L,3L,14L,3L,10L,9L,6L,9L,14L,3L,6L,9L,12L,3L,12L,3L,12L,11L,6L,3L,18L,5L,10L,9L,12L,3L,12L,9L,14L,9L,6L,3L,22L,3L,6L,13L,12L,9L,14L,3L,12L,9L,14L,3L,18L,3L,6L,13L,12L,9L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259573Inst : IEnumerable<long>
{
public static readonly long[] Value=A259573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259573.Bytes);
public long this[int i]=>Value[i];

public static A259573Inst Instance=new A259573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259574
{
public static readonly long[] Value={ 0L,1L,4L,11L,22L,42L,66L,104L,150L,211L,280L,377L,474L,604L,750L,916L,1096L,1323L,1548L,1831L,2122L,2446L,2794L,3212L,3620L,4087L,4590L,5141L,5698L,6360L,6990L,7728L,8484L,9289L,10156L,11091L,12006L,13042L,14122L,15280L,16420L,17727L,18984L,20401L,21852L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259574Inst : IEnumerable<long>
{
public static readonly long[] Value=A259574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259574.Bytes);
public long this[int i]=>Value[i];

public static A259574Inst Instance=new A259574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259575
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,1L,1L,2L,3L,2L,1L,1L,3L,4L,4L,3L,1L,1L,3L,5L,6L,5L,3L,1L,1L,4L,6L,7L,7L,6L,4L,1L,1L,4L,7L,8L,10L,8L,7L,4L,1L,1L,5L,8L,10L,11L,11L,10L,8L,5L,1L,1L,5L,9L,12L,13L,15L,13L,12L,9L,5L,1L,1L,6L,10L,13L,15L,16L,16L,15L,13L,10L,6L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259575Inst : IEnumerable<long>
{
public static readonly long[] Value=A259575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259575.Bytes);
public long this[int i]=>Value[i];

public static A259575Inst Instance=new A259575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259576
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,3L,4L,3L,6L,3L,6L,3L,6L,5L,6L,3L,8L,3L,8L,5L,6L,3L,10L,5L,6L,5L,10L,3L,10L,3L,8L,5L,6L,7L,14L,3L,6L,5L,12L,3L,12L,3L,10L,11L,6L,3L,14L,5L,10L,5L,10L,3L,12L,9L,12L,5L,6L,3L,18L,3L,6L,11L,10L,9L,14L,3L,10L,5L,16L,3L,18L,3L,6L,9L,10L,7L,14L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259576Inst : IEnumerable<long>
{
public static readonly long[] Value=A259576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259576.Bytes);
public long this[int i]=>Value[i];

public static A259576Inst Instance=new A259576Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259577
{
public static readonly long[] Value={ 1L,2L,6L,13L,26L,44L,72L,108L,156L,215L,290L,381L,486L,610L,758L,924L,1112L,1329L,1566L,1839L,2134L,2456L,2816L,3220L,3640L,4099L,4608L,5153L,5726L,6368L,7020L,7744L,8504L,9305L,10180L,11103L,12042L,13060L,14146L,15296L,16460L,17739L,19026L,20421L,21876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259577Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259577.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259577Inst : IEnumerable<long>
{
public static readonly long[] Value=A259577.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259577.Bytes);
public long this[int i]=>Value[i];

public static A259577Inst Instance=new A259577Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259578
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,3L,3L,2L,2L,4L,3L,4L,2L,2L,4L,5L,5L,4L,2L,2L,5L,6L,6L,6L,5L,2L,2L,5L,6L,8L,8L,6L,5L,2L,2L,6L,8L,10L,10L,10L,8L,6L,2L,2L,6L,9L,11L,12L,12L,11L,9L,6L,2L,2L,7L,9L,12L,14L,15L,14L,12L,9L,7L,2L,2L,7L,11L,14L,16L,17L,17L,16L,14L,11L,7L,2L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259578Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259578.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259578Inst : IEnumerable<long>
{
public static readonly long[] Value=A259578.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259578.Bytes);
public long this[int i]=>Value[i];

public static A259578Inst Instance=new A259578Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259579
{
public static readonly long[] Value={ 1L,2L,3L,2L,1L,4L,3L,4L,5L,4L,3L,6L,3L,4L,5L,6L,3L,6L,3L,6L,7L,6L,3L,10L,3L,6L,7L,8L,3L,12L,3L,8L,9L,6L,5L,12L,3L,6L,9L,10L,3L,12L,3L,10L,9L,6L,3L,16L,5L,8L,9L,10L,3L,10L,5L,10L,9L,6L,3L,20L,3L,6L,9L,10L,5L,14L,3L,10L,9L,12L,3L,16L,3L,6L,11L,10L,9L,14L,3L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259579Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259579.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259579Inst : IEnumerable<long>
{
public static readonly long[] Value=A259579.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259579.Bytes);
public long this[int i]=>Value[i];

public static A259579Inst Instance=new A259579Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259580
{
public static readonly long[] Value={ 2L,5L,8L,17L,30L,50L,78L,116L,162L,227L,300L,389L,498L,628L,766L,940L,1128L,1347L,1584L,1855L,2146L,2486L,2838L,3236L,3660L,4135L,4626L,5177L,5754L,6392L,7050L,7776L,8524L,9353L,10204L,11127L,12078L,13114L,14170L,15328L,16500L,17775L,19068L,20461L,21900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259580Inst : IEnumerable<long>
{
public static readonly long[] Value=A259580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259580.Bytes);
public long this[int i]=>Value[i];

public static A259580Inst Instance=new A259580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259581
{
public static readonly long[] Value={ 3L,3L,3L,3L,3L,3L,3L,4L,4L,3L,3L,4L,6L,4L,3L,3L,5L,6L,6L,5L,3L,3L,5L,7L,6L,7L,5L,3L,3L,6L,9L,9L,9L,9L,6L,3L,3L,6L,9L,10L,10L,10L,9L,6L,3L,3L,7L,10L,12L,13L,13L,12L,10L,7L,3L,3L,7L,12L,12L,15L,15L,15L,12L,12L,7L,3L,3L,8L,12L,15L,17L,18L,18L,17L,15L,12L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259581Inst : IEnumerable<long>
{
public static readonly long[] Value=A259581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259581.Bytes);
public long this[int i]=>Value[i];

public static A259581Inst Instance=new A259581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259582
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,4L,1L,4L,3L,4L,3L,6L,3L,4L,7L,6L,3L,6L,3L,6L,5L,6L,3L,8L,5L,6L,5L,8L,3L,8L,3L,8L,7L,6L,5L,10L,3L,6L,9L,8L,3L,12L,3L,12L,9L,6L,3L,14L,3L,8L,9L,12L,3L,10L,9L,10L,9L,6L,3L,18L,3L,6L,7L,10L,9L,14L,3L,12L,9L,12L,3L,14L,3L,6L,13L,12L,5L,14L,3L,14L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259582Inst : IEnumerable<long>
{
public static readonly long[] Value=A259582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259582.Bytes);
public long this[int i]=>Value[i];

public static A259582Inst Instance=new A259582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259583
{
public static readonly long[] Value={ 3L,6L,13L,19L,34L,55L,84L,120L,174L,231L,310L,399L,510L,634L,786L,948L,1144L,1359L,1602L,1863L,2176L,2496L,2860L,3256L,3680L,4147L,4662L,5189L,5782L,6412L,7080L,7792L,8574L,9369L,10228L,11151L,12114L,13132L,14230L,15344L,16540L,17805L,19110L,20481L,21948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259583Inst : IEnumerable<long>
{
public static readonly long[] Value=A259583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259583.Bytes);
public long this[int i]=>Value[i];

public static A259583Inst Instance=new A259583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259584
{
public static readonly long[] Value={ 116L,314L,512L,657L,1340L,1422L,1620L,1818L,1900L,2161L,2243L,2441L,2639L,2982L,3124L,3322L,3747L,3800L,3945L,4027L,4143L,4225L,4766L,5251L,5449L,5531L,5729L,5927L,6125L,6270L,6352L,6953L,7091L,7233L,7431L,7711L,7774L,7856L,8054L,8252L,8457L,8595L,9278L,9360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259584Inst : IEnumerable<long>
{
public static readonly long[] Value=A259584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259584.Bytes);
public long this[int i]=>Value[i];

public static A259584Inst Instance=new A259584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259585
{
public static readonly long[] Value={ 5L,8L,15L,29L,34L,39L,42L,45L,46L,49L,56L,58L,68L,71L,75L,87L,92L,95L,99L,102L,105L,109L,112L,121L,124L,127L,128L,131L,145L,150L,157L,162L,169L,174L,177L,184L,187L,191L,198L,203L,206L,213L,232L,237L,240L,243L,244L,247L,254L,256L,266L,269L,273L,285L,290L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259585Inst : IEnumerable<long>
{
public static readonly long[] Value=A259585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259585.Bytes);
public long this[int i]=>Value[i];

public static A259585Inst Instance=new A259585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259586
{
public static readonly long[] Value={ 41L,67L,70L,123L,130L,205L,212L,328L,350L,403L,410L,444L,526L,548L,555L,608L,671L,700L,724L,750L,753L,806L,869L,888L,898L,951L,1026L,1033L,1067L,1086L,1096L,1149L,1224L,1231L,1265L,1291L,1294L,1347L,1376L,1429L,1489L,1504L,1545L,1571L,1574L,1627L,1709L,1716L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259586Inst : IEnumerable<long>
{
public static readonly long[] Value=A259586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259586.Bytes);
public long this[int i]=>Value[i];

public static A259586Inst Instance=new A259586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259587
{
public static readonly long[] Value={ 2L,3L,6L,7L,9L,11L,12L,14L,26L,33L,36L,40L,43L,48L,52L,55L,59L,62L,65L,72L,74L,77L,82L,84L,89L,91L,93L,94L,96L,101L,108L,111L,115L,118L,119L,122L,125L,134L,137L,140L,141L,144L,147L,148L,149L,151L,152L,154L,159L,164L,171L,175L,178L,181L,188L,190L,193L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259587Inst : IEnumerable<long>
{
public static readonly long[] Value=A259587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259587.Bytes);
public long this[int i]=>Value[i];

public static A259587Inst Instance=new A259587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259588
{
public static readonly long[] Value={ 1L,2L,4L,7L,11L,39L,71L,110L,536L,1001L,1537L,9545L,18089L,27634L,208524L,398959L,607483L,5394991L,10391023L,15786014L,161260336L,312129649L,473389985L,5467464369L,10622799089L,16090263458L,207300647060L,403978495031L,611279142091L,8690849042711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259588Inst : IEnumerable<long>
{
public static readonly long[] Value=A259588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259588.Bytes);
public long this[int i]=>Value[i];

public static A259588Inst Instance=new A259588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259589
{
public static readonly long[] Value={ 3L,5L,11L,19L,30L,106L,193L,299L,1457L,2721L,4178L,25946L,49171L,75117L,566827L,1084483L,1651310L,14665106L,28245729L,42910835L,438351041L,848456353L,1286807394L,14862109042L,28875761731L,43737870773L,563501581931L,1098127402131L,1661628984062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259589Inst : IEnumerable<long>
{
public static readonly long[] Value=A259589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259589.Bytes);
public long this[int i]=>Value[i];

public static A259589Inst Instance=new A259589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259590
{
public static readonly long[] Value={ 1L,8L,113L,219L,33215L,66317L,99532L,165849L,364913L,630294L,1725033L,3085153L,27235615L,78256779L,131002976L,209259755L,471265707L,1151791169L,2774848045L,6701487259L,11439654911L,574364584667L,1709690779483L,2851718461558L,4561409241041L,47337186164411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259590Inst : IEnumerable<long>
{
public static readonly long[] Value=A259590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259590.Bytes);
public long this[int i]=>Value[i];

public static A259590Inst Instance=new A259590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259591
{
public static readonly long[] Value={ 4L,25L,355L,688L,104348L,208341L,312689L,521030L,1146408L,1980127L,5419351L,9692294L,85563208L,245850922L,411557987L,657408909L,1480524883L,3618458675L,8717442233L,21053343141L,35938735828L,1804419559672L,5371151992734L,8958937768937L,14330089761671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259591Inst : IEnumerable<long>
{
public static readonly long[] Value=A259591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259591.Bytes);
public long this[int i]=>Value[i];

public static A259591Inst Instance=new A259591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259592
{
public static readonly long[] Value={ 1L,2L,4L,7L,15L,26L,56L,97L,209L,362L,780L,1351L,2911L,5042L,10864L,18817L,40545L,70226L,151316L,262087L,564719L,978122L,2107560L,3650401L,7865521L,13623482L,29354524L,50843527L,109552575L,189750626L,408855776L,708158977L,1525870529L,2642885282L,5694626340L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259592Inst : IEnumerable<long>
{
public static readonly long[] Value=A259592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259592.Bytes);
public long this[int i]=>Value[i];

public static A259592Inst Instance=new A259592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259593
{
public static readonly long[] Value={ 2L,3L,7L,12L,26L,45L,97L,168L,362L,627L,1351L,2340L,5042L,8733L,18817L,32592L,70226L,121635L,262087L,453948L,978122L,1694157L,3650401L,6322680L,13623482L,23596563L,50843527L,88063572L,189750626L,328657725L,708158977L,1226567328L,2642885282L,4577611587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259593Inst : IEnumerable<long>
{
public static readonly long[] Value=A259593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259593.Bytes);
public long this[int i]=>Value[i];

public static A259593Inst Instance=new A259593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259594
{
public static readonly long[] Value={ 1L,3L,11L,29L,109L,287L,1079L,2841L,10681L,28123L,105731L,278389L,1046629L,2755767L,10360559L,27279281L,102558961L,270037043L,1015229051L,2673091149L,10049731549L,26460874447L,99482086439L,261935653321L,984771132841L,2592895658763L,9748229241971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259594Inst : IEnumerable<long>
{
public static readonly long[] Value=A259594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259594.Bytes);
public long this[int i]=>Value[i];

public static A259594Inst Instance=new A259594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259595
{
public static readonly long[] Value={ 3L,7L,27L,71L,267L,703L,2643L,6959L,26163L,68887L,258987L,681911L,2563707L,6750223L,25378083L,66820319L,251217123L,661452967L,2486793147L,6547709351L,24616714347L,64815640543L,243680350323L,641608696079L,2412186788883L,6351271320247L,23878187538507L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259595Inst : IEnumerable<long>
{
public static readonly long[] Value=A259595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259595.Bytes);
public long this[int i]=>Value[i];

public static A259595Inst Instance=new A259595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259596
{
public static readonly long[] Value={ 1L,2L,3L,5L,17L,31L,48L,79L,271L,494L,765L,1259L,4319L,7873L,12192L,20065L,68833L,125474L,194307L,319781L,1097009L,1999711L,3096720L,5096431L,17483311L,31869902L,49353213L,81223115L,278635967L,507918721L,786554688L,1294473409L,4440692161L,8094829634L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259596Inst : IEnumerable<long>
{
public static readonly long[] Value=A259596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259596.Bytes);
public long this[int i]=>Value[i];

public static A259596Inst Instance=new A259596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259597
{
public static readonly long[] Value={ 3L,5L,8L,13L,45L,82L,127L,209L,717L,1307L,2024L,3331L,11427L,20830L,32257L,53087L,182115L,331973L,514088L,846061L,2902413L,5290738L,8193151L,13483889L,46256493L,84319835L,130576328L,214896163L,737201475L,1343826622L,2081028097L,3424854719L,11748967107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259597Inst : IEnumerable<long>
{
public static readonly long[] Value=A259597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259597.Bytes);
public long this[int i]=>Value[i];

public static A259597Inst Instance=new A259597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259598
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,2L,0L,3L,1L,2L,4L,0L,4L,4L,1L,6L,2L,4L,7L,0L,8L,4L,4L,9L,1L,8L,8L,2L,11L,4L,7L,12L,0L,12L,9L,4L,14L,4L,10L,14L,1L,16L,8L,8L,17L,2L,15L,14L,4L,19L,7L,12L,20L,0L,21L,12L,9L,22L,4L,18L,19L,4L,24L,10L,14L,25L,1L,24L,18L,8L,27L,8L,19L,26L,2L,29L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259598Inst : IEnumerable<long>
{
public static readonly long[] Value=A259598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259598.Bytes);
public long this[int i]=>Value[i];

public static A259598Inst Instance=new A259598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259599
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259599Inst : IEnumerable<long>
{
public static readonly long[] Value=A259599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259599.Bytes);
public long this[int i]=>Value[i];

public static A259599Inst Instance=new A259599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259600
{
public static readonly long[] Value={ 4L,5L,7L,7L,9L,10L,9L,11L,12L,14L,10L,12L,13L,15L,17L,12L,14L,15L,17L,19L,20L,13L,15L,16L,18L,20L,21L,23L,15L,17L,18L,20L,22L,23L,25L,26L,17L,19L,20L,22L,24L,25L,27L,28L,30L,18L,20L,21L,23L,25L,26L,28L,29L,31L,33L,20L,22L,23L,25L,27L,28L,30L,31L,33L,35L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259600Inst : IEnumerable<long>
{
public static readonly long[] Value=A259600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259600.Bytes);
public long this[int i]=>Value[i];

public static A259600Inst Instance=new A259600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259601
{
public static readonly long[] Value={ 7L,9L,12L,12L,15L,17L,15L,18L,20L,23L,17L,20L,22L,25L,28L,20L,23L,25L,28L,31L,33L,22L,25L,27L,30L,33L,35L,38L,25L,28L,30L,33L,36L,38L,41L,43L,28L,31L,33L,36L,39L,41L,44L,46L,49L,30L,33L,35L,38L,41L,43L,46L,48L,51L,54L,33L,36L,38L,41L,44L,46L,49L,51L,54L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259601Inst : IEnumerable<long>
{
public static readonly long[] Value=A259601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259601.Bytes);
public long this[int i]=>Value[i];

public static A259601Inst Instance=new A259601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259602
{
public static readonly long[] Value={ 4L,9L,16L,25L,16L,4L,9L,16L,25L,36L,25L,16L,25L,36L,49L,64L,81L,100L,64L,16L,25L,36L,49L,64L,81L,64L,36L,49L,64L,81L,100L,81L,64L,81L,100L,121L,144L,169L,196L,144L,64L,100L,144L,81L,36L,49L,64L,81L,64L,49L,64L,81L,100L,121L,144L,169L,144L,121L,100L,64L,81L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259602Inst : IEnumerable<long>
{
public static readonly long[] Value=A259602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259602.Bytes);
public long this[int i]=>Value[i];

public static A259602Inst Instance=new A259602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259603
{
public static readonly long[] Value={ 8L,27L,64L,125L,216L,343L,216L,27L,64L,125L,216L,343L,216L,27L,64L,125L,216L,343L,216L,27L,64L,125L,216L,343L,216L,27L,64L,125L,216L,343L,216L,27L,64L,125L,216L,343L,216L,64L,125L,216L,343L,512L,343L,64L,125L,216L,125L,8L,27L,64L,125L,216L,343L,216L,8L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259603Inst : IEnumerable<long>
{
public static readonly long[] Value=A259603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259603.Bytes);
public long this[int i]=>Value[i];

public static A259603Inst Instance=new A259603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259604
{
public static readonly long[] Value={ 3L,6L,10L,15L,10L,6L,10L,15L,21L,28L,36L,45L,36L,28L,36L,45L,55L,36L,21L,28L,36L,45L,36L,28L,36L,45L,55L,66L,78L,91L,78L,66L,78L,91L,105L,78L,55L,66L,78L,91L,78L,66L,78L,91L,105L,120L,136L,153L,120L,78L,91L,105L,91L,78L,66L,78L,105L,120L,136L,153L,171L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259604Inst : IEnumerable<long>
{
public static readonly long[] Value=A259604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259604.Bytes);
public long this[int i]=>Value[i];

public static A259604Inst Instance=new A259604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259605
{
public static readonly long[] Value={ 2L,5L,6L,7L,10L,13L,14L,15L,19L,22L,21L,22L,26L,29L,30L,31L,34L,37L,38L,39L,42L,46L,47L,46L,51L,53L,55L,58L,55L,57L,62L,65L,66L,67L,70L,73L,74L,77L,79L,78L,82L,86L,85L,86L,91L,94L,93L,94L,101L,102L,101L,102L,105L,110L,109L,110L,114L,118L,119L,118L,122L,127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259605Inst : IEnumerable<long>
{
public static readonly long[] Value=A259605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259605.Bytes);
public long this[int i]=>Value[i];

public static A259605Inst Instance=new A259605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259606
{
public static readonly BigInteger[] Value={ 1L,1L,6L,60L,790L,12488L,226176L,4567245L,101057170L,2421311002L,62292579316L,1709994461396L,49844902545256L,1536870296603860L,49965056185462360L,1708221871912841430L,BigInteger.Parse("61272046476315041664"),BigInteger.Parse("2301058164207089144028"),BigInteger.Parse("90309756129843950212480"),BigInteger.Parse("3697832634432220792202296") };
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
public class A259606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259606Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259606.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259606Inst Instance=new A259606Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259607
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,9L,66L,646L,7760L,109585L,1771810L,32211854L,649833996L,14399543754L,347618918364L,9080945744920L,255239884317292L,7680997048377377L,246417820289930866L,8395878803694101510L,BigInteger.Parse("302786064773642534220"),BigInteger.Parse("11523127939987785101646"),BigInteger.Parse("461518291638811484923036") };
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
public class A259607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259607Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259607.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259607Inst Instance=new A259607Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259608
{
public static readonly BigInteger[] Value={ 1L,2L,15L,164L,2190L,33384L,561659L,10226376L,198975366L,4101249990L,88985266436L,2022670569000L,47986654728506L,1184722493746988L,30364559922967455L,806313807163378768L,BigInteger.Parse("22146014022165507644"),BigInteger.Parse("628220131284285896472"),BigInteger.Parse("18382404744008384580629"),BigInteger.Parse("554214116675011187495440") };
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
public class A259608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259608Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259608.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259608Inst Instance=new A259608Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259609
{
public static readonly BigInteger[] Value={ 1L,1L,5L,41L,438L,5564L,80237L,1278297L,22108374L,410124999L,8089569676L,168555880750L,3691281132962L,84623035267642L,2024303994864497L,50394612947711173L,1302706707186206332L,BigInteger.Parse("34901118404682549804"),BigInteger.Parse("967494986526757083191"),BigInteger.Parse("27710705833750559374772"),BigInteger.Parse("818986747695251513692537") };
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
public class A259609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259609Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259609.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259609Inst Instance=new A259609Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259610
{
public static readonly BigInteger[] Value={ 1L,3L,26L,320L,4776L,81018L,1510336L,30328173L,647535770L,14569480376L,343234151688L,8425926474186L,214747018423616L,5665854689772960L,154393844206506248L,4337151982457354192L,BigInteger.Parse("125404753959532852236"),BigInteger.Parse("3727264826995512243092"),BigInteger.Parse("113749283318621304173840"),BigInteger.Parse("3560977119168952929308604") };
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
public class A259610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259610Inst Instance=new A259610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259611
{
public static readonly BigInteger[] Value={ 1L,2L,13L,128L,1592L,23148L,377584L,6739594L,129507154L,2648996432L,57205691948L,1296296380644L,30678145489088L,755447291969728L,19299230525813281L,510253174406747552L,13933861551059205804UL,BigInteger.Parse("392343665999527604536"),BigInteger.Parse("11374928331862130417384"),BigInteger.Parse("339140678016090755172248") };
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
public class A259611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259611Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259611.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259611Inst Instance=new A259611Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259612
{
public static readonly BigInteger[] Value={ 1L,1L,6L,58L,720L,10506L,172284L,3092717L,59758608L,1228626514L,26657057728L,606616602302L,14410894287172L,356081682054300L,9124705519233832L,241916247567814448L,6622686675121529288L,BigInteger.Parse("186900262172114801748"),BigInteger.Parse("5429779249015331564288"),BigInteger.Parse("162190080378495122207760") };
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
public class A259612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259612Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259612.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259612Inst Instance=new A259612Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259613
{
public static readonly BigInteger[] Value={ 1L,5L,165L,6188L,245157L,10015005L,417225900L,17620076360L,751616304549L,32308782859535L,1397281501935165L,60727722660586800L,2650087220696342700L,BigInteger.Parse("116043807643289338428"),BigInteger.Parse("5096278545356362962504"),BigInteger.Parse("224377658168860057076688") };
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
public class A259613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259613Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259613.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259613Inst Instance=new A259613Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259614
{
public static readonly long[] Value={ 17L,29L,53L,65L,89L,101L,125L,137L,161L,173L,197L,209L,233L,245L,269L,281L,305L,317L,341L,353L,377L,389L,413L,425L,449L,461L,485L,497L,521L,533L,557L,569L,593L,605L,629L,641L,665L,677L,701L,713L,737L,749L,773L,785L,809L,821L,845L,857L,881L,893L,917L,929L,953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259614Inst : IEnumerable<long>
{
public static readonly long[] Value=A259614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259614.Bytes);
public long this[int i]=>Value[i];

public static A259614Inst Instance=new A259614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259615
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,3L,4L,5L,9L,9L,11L,19L,23L,27L,45L,87L,105L,205L,401L,587L,747L,1121L,1763L,2145L,4085L,7965L,15529L,16545L,32503L,38323L,49767L,74305L,146847L,180069L,210427L,341745L,650987L,787109L,917411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259615Inst : IEnumerable<long>
{
public static readonly long[] Value=A259615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259615.Bytes);
public long this[int i]=>Value[i];

public static A259615Inst Instance=new A259615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259616
{
public static readonly long[] Value={ 1L,8L,4L,1L,1L,8L,3L,7L,8L,1L,3L,4L,0L,6L,5L,9L,3L,0L,2L,6L,4L,3L,6L,2L,9L,5L,1L,3L,6L,4L,4L,4L,4L,3L,3L,2L,2L,4L,3L,6L,1L,2L,7L,0L,3L,9L,0L,9L,6L,8L,1L,9L,2L,6L,4L,3L,5L,0L,4L,6L,7L,7L,4L,2L,9L,2L,4L,2L,2L,9L,2L,0L,9L,8L,5L,9L,0L,6L,5L,3L,8L,6L,1L,8L,9L,3L,3L,5L,4L,1L,7L,2L,0L,0L,9L,3L,7L,8L,4L,8L,4L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259616Inst : IEnumerable<long>
{
public static readonly long[] Value=A259616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259616.Bytes);
public long this[int i]=>Value[i];

public static A259616Inst Instance=new A259616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259617
{
public static readonly long[] Value={ 3L,0L,5L,4L,2L,3L,6L,9L,2L,8L,2L,2L,7L,1L,4L,0L,3L,2L,2L,7L,5L,5L,9L,3L,2L,0L,9L,1L,1L,4L,8L,5L,6L,0L,8L,9L,7L,6L,4L,1L,4L,9L,6L,7L,6L,0L,5L,2L,9L,9L,4L,5L,9L,1L,9L,8L,1L,6L,4L,3L,7L,5L,6L,6L,6L,5L,8L,5L,4L,5L,1L,7L,6L,6L,1L,2L,9L,1L,9L,4L,5L,6L,9L,7L,4L,7L,0L,8L,0L,5L,6L,3L,0L,5L,7L,7L,5L,5L,5L,0L,9L,4L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259617Inst : IEnumerable<long>
{
public static readonly long[] Value=A259617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259617.Bytes);
public long this[int i]=>Value[i];

public static A259617Inst Instance=new A259617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259618
{
public static readonly long[] Value={ 4L,2L,0L,1L,1L,8L,8L,9L,4L,1L,2L,1L,0L,5L,2L,8L,4L,9L,6L,1L,8L,7L,8L,5L,5L,2L,9L,7L,4L,5L,6L,7L,1L,2L,1L,8L,7L,9L,4L,4L,6L,0L,3L,2L,1L,3L,5L,8L,9L,9L,8L,3L,3L,5L,2L,1L,7L,6L,0L,0L,1L,7L,9L,1L,0L,2L,0L,9L,5L,8L,4L,0L,5L,0L,3L,1L,9L,3L,3L,5L,1L,6L,1L,1L,1L,7L,3L,5L,0L,2L,6L,5L,4L,2L,4L,7L,2L,1L,8L,9L,0L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259618Inst : IEnumerable<long>
{
public static readonly long[] Value=A259618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259618.Bytes);
public long this[int i]=>Value[i];

public static A259618Inst Instance=new A259618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259619
{
public static readonly long[] Value={ 5L,3L,1L,7L,5L,5L,3L,1L,2L,6L,0L,8L,3L,9L,9L,4L,3L,5L,0L,3L,6L,3L,3L,5L,5L,5L,5L,8L,1L,8L,8L,9L,1L,9L,2L,1L,4L,7L,6L,6L,6L,9L,8L,2L,8L,6L,2L,2L,0L,1L,0L,2L,8L,6L,6L,2L,2L,0L,4L,2L,9L,3L,3L,7L,6L,0L,4L,0L,5L,9L,0L,5L,3L,8L,8L,6L,0L,5L,7L,3L,7L,1L,9L,4L,3L,4L,1L,1L,5L,1L,2L,0L,5L,3L,6L,9L,5L,9L,6L,2L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259619Inst : IEnumerable<long>
{
public static readonly long[] Value=A259619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259619.Bytes);
public long this[int i]=>Value[i];

public static A259619Inst Instance=new A259619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259620
{
public static readonly long[] Value={ 6L,4L,1L,5L,6L,1L,6L,3L,7L,5L,7L,0L,0L,2L,4L,0L,2L,8L,2L,8L,3L,9L,8L,1L,4L,7L,1L,9L,0L,8L,7L,9L,2L,4L,0L,3L,8L,1L,0L,9L,0L,0L,0L,5L,6L,5L,2L,0L,7L,7L,2L,0L,7L,7L,8L,6L,7L,4L,9L,4L,7L,6L,2L,7L,3L,2L,2L,8L,8L,0L,6L,0L,3L,3L,4L,7L,1L,6L,6L,5L,3L,2L,3L,2L,4L,6L,5L,3L,2L,0L,8L,6L,4L,6L,9L,9L,5L,6L,6L,8L,8L,0L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259620Inst : IEnumerable<long>
{
public static readonly long[] Value=A259620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259620.Bytes);
public long this[int i]=>Value[i];

public static A259620Inst Instance=new A259620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259621
{
public static readonly long[] Value={ 1L,6L,32L,179L,243L,352L,2705L,3063L,8601L,25560L,144770L,516060L,2605860L,31786380L,66178620L,1024465680L,1090644300L,6477687180L,7568331480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259621Inst : IEnumerable<long>
{
public static readonly long[] Value=A259621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259621.Bytes);
public long this[int i]=>Value[i];

public static A259621Inst Instance=new A259621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259622
{
public static readonly BigInteger[] Value={ 0L,1L,2L,5L,17L,79L,503L,4243L,45823L,612809L,9903031L,189244327L,4203344543L,106963067069L,3081230793857L,99460155441599L,3566360917197283L,140987300677114811L,6104597616658111069L,BigInteger.Parse("287835273618906460259") };
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
public class A259622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259622Inst Instance=new A259622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259623
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,13L,14L,21L,22L,34L,35L,55L,56L,89L,90L,144L,145L,233L,234L,377L,378L,610L,611L,987L,988L,1597L,1598L,2584L,2585L,4181L,4182L,6765L,6766L,10946L,10947L,17711L,17712L,28657L,28658L,46368L,46369L,75025L,75026L,121393L,121394L,196418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259623Inst : IEnumerable<long>
{
public static readonly long[] Value=A259623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259623.Bytes);
public long this[int i]=>Value[i];

public static A259623Inst Instance=new A259623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259624
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,12L,13L,14L,20L,21L,22L,33L,34L,35L,54L,55L,56L,88L,89L,90L,143L,144L,145L,232L,233L,234L,376L,377L,378L,609L,610L,611L,986L,987L,988L,1596L,1597L,1598L,2583L,2584L,2585L,4180L,4181L,4182L,6764L,6765L,6766L,10945L,10946L,10947L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259624Inst : IEnumerable<long>
{
public static readonly long[] Value=A259624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259624.Bytes);
public long this[int i]=>Value[i];

public static A259624Inst Instance=new A259624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259625
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,10L,11L,17L,18L,28L,29L,46L,47L,75L,76L,122L,123L,198L,199L,321L,322L,520L,521L,842L,843L,1363L,1364L,2206L,2207L,3570L,3571L,5777L,5778L,9348L,9349L,15126L,15127L,24475L,24476L,39602L,39603L,64078L,64079L,103681L,103682L,167760L,167761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259625Inst : IEnumerable<long>
{
public static readonly long[] Value=A259625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259625.Bytes);
public long this[int i]=>Value[i];

public static A259625Inst Instance=new A259625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259626
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,8L,11L,12L,18L,19L,29L,30L,47L,48L,76L,77L,123L,124L,199L,200L,322L,323L,521L,522L,843L,844L,1364L,1365L,2207L,2208L,3571L,3572L,5778L,5779L,9349L,9350L,15127L,15128L,24476L,24477L,39603L,39604L,64079L,64080L,103682L,103683L,167761L,167762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259626Inst : IEnumerable<long>
{
public static readonly long[] Value=A259626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259626.Bytes);
public long this[int i]=>Value[i];

public static A259626Inst Instance=new A259626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259627
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,10L,11L,12L,17L,18L,19L,28L,29L,30L,46L,47L,48L,75L,76L,77L,122L,123L,124L,198L,199L,200L,321L,322L,323L,520L,521L,522L,842L,843L,844L,1363L,1364L,1365L,2206L,2207L,2208L,3570L,3571L,3572L,5777L,5778L,5779L,9348L,9349L,9350L,15126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259627Inst : IEnumerable<long>
{
public static readonly long[] Value=A259627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259627.Bytes);
public long this[int i]=>Value[i];

public static A259627Inst Instance=new A259627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259628
{
public static readonly long[] Value={ 2523708L,6740478L,6759030L,14655522L,22885698L,28384200L,44630148L,71742300L,87002328L,87466500L,89842200L,153110622L,153647490L,184373490L,283232040L,312124920L,366318960L,408770670L,412216920L,439429128L,456486030L,486730398L,517602600L,606159978L,607942848L,675661080L,855983352L,869593998L,923864562L,971400672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259628Inst : IEnumerable<long>
{
public static readonly long[] Value=A259628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259628.Bytes);
public long this[int i]=>Value[i];

public static A259628Inst Instance=new A259628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259629
{
public static readonly long[] Value={ 10L,15L,42L,70L,105L,330L,462L,770L,1155L,2730L,4290L,6006L,10010L,15015L,39270L,46410L,72930L,102102L,170170L,255255L,570570L,746130L,881790L,1385670L,1939938L,3233230L,4849845L,11741730L,13123110L,17160990L,20281170L,31870410L,44618574L,74364290L,111546435L,281291010L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259629Inst : IEnumerable<long>
{
public static readonly long[] Value=A259629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259629.Bytes);
public long this[int i]=>Value[i];

public static A259629Inst Instance=new A259629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259630
{
public static readonly long[] Value={ 1L,0L,2L,4L,3L,12L,5L,14L,27L,8L,25L,30L,31L,36L,13L,18L,131L,60L,133L,458L,247L,1040L,21L,618L,283L,300L,209L,6282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259630Inst : IEnumerable<long>
{
public static readonly long[] Value=A259630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259630.Bytes);
public long this[int i]=>Value[i];

public static A259630Inst Instance=new A259630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259631
{
public static readonly long[] Value={ 8929L,45937L,49256L,50060L,76204L,76855L,125708L,127919L,137050L,137335L,137944L,147466L,163822L,193939L,267131L,295882L,299977L,312610L,322255L,322499L,322988L,370763L,403085L,436060L,458119L,571253L,574597L,601558L,610697L,626978L,627820L,630109L,647039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259631Inst : IEnumerable<long>
{
public static readonly long[] Value=A259631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259631.Bytes);
public long this[int i]=>Value[i];

public static A259631Inst Instance=new A259631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259632
{
public static readonly long[] Value={ -2L,-2L,-3L,-2L,0L,28L,199L,483L,9040L,143814L,306295L,963844L,5155067L,81053615L,1334916470L,29106956400L,58655156000L,1817551640000L,56466287000000L,376943530000000L,1144451930000000L,41803527000000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259632Inst : IEnumerable<long>
{
public static readonly long[] Value=A259632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259632.Bytes);
public long this[int i]=>Value[i];

public static A259632Inst Instance=new A259632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259633
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,12L,1L,43L,132L,547L,1L,7834L,1L,30442L,608887L,3834978L,1L,84536629L,1L,3030450058L,79538220753L,16701983083L,1L,4136127573912L,26625599501697L,2730194738935L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259633Inst : IEnumerable<long>
{
public static readonly long[] Value=A259633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259633.Bytes);
public long this[int i]=>Value[i];

public static A259633Inst Instance=new A259633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259634
{
public static readonly BigInteger[] Value={ 18L,64L,581L,4146L,44500L,899557L,19848497L,593505391L,28804661988L,1803294030851L,150215435682396L,18581117366931470L,3161106877662837437L,BigInteger.Parse("725638805668965032687"),BigInteger.Parse("236686439674936087627391") };
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
public class A259634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259634Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259634.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259634Inst Instance=new A259634Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259635
{
public static readonly long[] Value={ 18L,29L,69L,133L,236L,472L,940L,1781L,3433L,6725L,13008L,25088L,48696L,94445L,182717L,353893L,685924L,1328520L,2572916L,4984581L,9656065L,18703333L,36229992L,70182768L,135948832L,263342141L,510120437L,988149701L,1914124956L,3707828408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259635Inst : IEnumerable<long>
{
public static readonly long[] Value=A259635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259635.Bytes);
public long this[int i]=>Value[i];

public static A259635Inst Instance=new A259635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259636
{
public static readonly long[] Value={ 29L,64L,171L,365L,813L,1964L,4499L,10188L,23712L,54825L,125645L,289829L,669250L,1540429L,3548858L,8183956L,18857787L,43449225L,100146613L,230800868L,531852951L,1225710880L,2824793748L,6509782737L,15002141393L,34573642293L,79676799626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259636Inst : IEnumerable<long>
{
public static readonly long[] Value=A259636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259636.Bytes);
public long this[int i]=>Value[i];

public static A259636Inst Instance=new A259636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259637
{
public static readonly long[] Value={ 69L,171L,581L,1483L,3849L,11261L,30957L,82977L,231015L,639787L,1746635L,4808581L,13273939L,36465831L,100266697L,276172373L,759825267L,2089908821L,5751835379L,15827945517L,43546434477L,119824549005L,329723993993L,907239344187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259637Inst : IEnumerable<long>
{
public static readonly long[] Value=A259637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259637.Bytes);
public long this[int i]=>Value[i];

public static A259637Inst Instance=new A259637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259638
{
public static readonly long[] Value={ 133L,365L,1483L,4146L,12348L,42524L,133078L,406770L,1313046L,4180198L,13059524L,41407226L,131557812L,414760302L,1310911640L,4153427590L,13129841142L,41501667938L,131324101864L,415367424944L,1313373627382L,4154238856134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259638Inst : IEnumerable<long>
{
public static readonly long[] Value=A259638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259638.Bytes);
public long this[int i]=>Value[i];

public static A259638Inst Instance=new A259638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259639
{
public static readonly long[] Value={ 236L,813L,3849L,12348L,44500L,182654L,670088L,2436036L,9361060L,35240824L,130549550L,491638762L,1851623400L,6921303290L,25956767494L,97538420980L,365652086782L,1370955967484L,5145436930220L,19301728914022L,72388123438246L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259639Inst : IEnumerable<long>
{
public static readonly long[] Value=A259639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259639.Bytes);
public long this[int i]=>Value[i];

public static A259639Inst Instance=new A259639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259640
{
public static readonly long[] Value={ 472L,1964L,11261L,42524L,182654L,899557L,3919925L,16946757L,77735408L,348525973L,1536576910L,6895676466L,30940535849L,137721843827L,615229646787L,2754036127174L,12296912173643L,54916113461292L,245512383603304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259640Inst : IEnumerable<long>
{
public static readonly long[] Value=A259640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259640.Bytes);
public long this[int i]=>Value[i];

public static A259640Inst Instance=new A259640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259641
{
public static readonly long[] Value={ 940L,4499L,30957L,133078L,670088L,3919925L,19848497L,100074919L,540718241L,2836175763L,14601337621L,76851462133L,403972462723L,2103028520409L,11002287701399L,57691734432881L,301509897465995L,1576431183067455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259641Inst : IEnumerable<long>
{
public static readonly long[] Value=A259641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259641.Bytes);
public long this[int i]=>Value[i];

public static A259641Inst Instance=new A259641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259642
{
public static readonly long[] Value={ 18L,29L,29L,69L,64L,69L,133L,171L,171L,133L,236L,365L,581L,365L,236L,472L,813L,1483L,1483L,813L,472L,940L,1964L,3849L,4146L,3849L,1964L,940L,1781L,4499L,11261L,12348L,12348L,11261L,4499L,1781L,3433L,10188L,30957L,42524L,44500L,42524L,30957L,10188L,3433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259642Inst : IEnumerable<long>
{
public static readonly long[] Value=A259642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259642.Bytes);
public long this[int i]=>Value[i];

public static A259642Inst Instance=new A259642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259643
{
public static readonly long[] Value={ 1L,3L,5L,11L,25L,29L,41L,49L,51L,59L,69L,81L,99L,103L,113L,131L,133L,135L,147L,149L,153L,181L,187L,193L,197L,199L,205L,211L,213L,217L,219L,229L,235L,239L,243L,255L,271L,277L,281L,287L,289L,303L,309L,313L,323L,333L,335L,343L,347L,357L,359L,365L,367L,381L,383L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259643Inst : IEnumerable<long>
{
public static readonly long[] Value=A259643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259643.Bytes);
public long this[int i]=>Value[i];

public static A259643Inst Instance=new A259643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259644
{
public static readonly BigInteger[] Value={ 1L,2L,5L,31L,2419L,176795035L,BigInteger.Parse("883922739668546300971"),BigInteger.Parse("1511516294872733607299090320742127160367108420362968907") };
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
public class A259644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259644Inst Instance=new A259644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259645
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,16L,20L,24L,36L,66L,90L,94L,116L,120L,134L,150L,156L,160L,206L,240L,280L,340L,350L,384L,396L,430L,436L,470L,536L,634L,690L,700L,714L,780L,826L,864L,930L,946L,960L,1004L,1124L,1150L,1176L,1294L,1316L,1376L,1410L,1430L,1494L,1644L,1674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259645Inst : IEnumerable<long>
{
public static readonly long[] Value=A259645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259645.Bytes);
public long this[int i]=>Value[i];

public static A259645Inst Instance=new A259645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259646
{
public static readonly long[] Value={ 3L,6L,10L,14L,19L,23L,27L,31L,36L,40L,44L,49L,53L,57L,62L,66L,70L,75L,79L,83L,88L,92L,96L,101L,105L,109L,114L,118L,122L,127L,131L,136L,140L,144L,149L,153L,157L,162L,166L,171L,175L,179L,184L,188L,192L,197L,201L,206L,210L,214L,219L,223L,227L,232L,236L,241L,245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259646Inst : IEnumerable<long>
{
public static readonly long[] Value=A259646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259646.Bytes);
public long this[int i]=>Value[i];

public static A259646Inst Instance=new A259646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259647
{
public static readonly BigInteger[] Value={ 1L,2L,16L,294L,10424L,635130L,60535212L,8378845734L,1591416365520L,397329777218034L,126160335768212820L,BigInteger.Parse("49635257475383554590"),BigInteger.Parse("23694522124288261524984"),BigInteger.Parse("13490127107426613875639850"),BigInteger.Parse("9029074877857980800375629500"),BigInteger.Parse("7018229497764789751949369835030") };
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
public class A259647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259647Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259647.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259647Inst Instance=new A259647Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259648
{
public static readonly long[] Value={ 19L,37L,61L,165L,204L,360L,412L,615L,1059L,1129L,1698L,2066L,2151L,2555L,3356L,4264L,4362L,5376L,5973L,6084L,7250L,7928L,9242L,11341L,12162L,12279L,13129L,13261L,14141L,19242L,20270L,22285L,22399L,26583L,26688L,28965L,31330L,32597L,35090L,37668L,37773L,43082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259648Inst : IEnumerable<long>
{
public static readonly long[] Value=A259648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259648.Bytes);
public long this[int i]=>Value[i];

public static A259648Inst Instance=new A259648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259649
{
public static readonly long[] Value={ 5L,2L,2L,5L,3L,2L,2L,3L,5L,2L,2L,13L,7L,2L,2L,5L,3L,2L,2L,3L,5L,2L,2L,5L,7L,2L,2L,29L,3L,2L,2L,3L,17L,2L,2L,5L,19L,2L,2L,41L,3L,2L,2L,3L,23L,2L,2L,7L,5L,2L,2L,53L,3L,2L,2L,3L,29L,2L,2L,7L,5L,2L,2L,5L,3L,2L,2L,3L,5L,2L,2L,73L,13L,2L,2L,5L,3L,2L,2L,3L,5L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259649Inst : IEnumerable<long>
{
public static readonly long[] Value=A259649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259649.Bytes);
public long this[int i]=>Value[i];

public static A259649Inst Instance=new A259649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259650
{
public static readonly long[] Value={ 5L,3L,11L,7L,17L,7L,23L,13L,29L,11L,7L,19L,41L,11L,47L,17L,53L,19L,59L,31L,13L,23L,71L,37L,13L,5L,83L,43L,89L,31L,19L,11L,101L,13L,107L,37L,113L,29L,17L,61L,7L,43L,131L,67L,137L,47L,13L,73L,149L,19L,31L,79L,23L,41L,167L,19L,173L,59L,179L,61L,37L,47L,191L,97L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259650Inst : IEnumerable<long>
{
public static readonly long[] Value=A259650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259650.Bytes);
public long this[int i]=>Value[i];

public static A259650Inst Instance=new A259650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259651
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,3L,2L,2L,2L,2L,4L,2L,2L,4L,2L,2L,2L,3L,3L,3L,3L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,3L,2L,4L,3L,3L,2L,4L,4L,2L,3L,2L,3L,3L,2L,4L,4L,2L,2L,4L,4L,2L,3L,4L,3L,4L,2L,3L,4L,3L,3L,4L,2L,3L,3L,3L,4L,3L,4L,3L,4L,2L,3L,4L,3L,4L,3L,3L,3L,2L,3L,3L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259651Inst : IEnumerable<long>
{
public static readonly long[] Value=A259651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259651.Bytes);
public long this[int i]=>Value[i];

public static A259651Inst Instance=new A259651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259652
{
public static readonly long[] Value={ 0L,1L,3L,2L,2L,2L,3L,3L,3L,2L,5L,4L,2L,2L,4L,4L,3L,3L,4L,3L,3L,3L,3L,4L,3L,3L,7L,3L,2L,3L,3L,6L,4L,2L,5L,4L,3L,2L,4L,5L,2L,5L,7L,3L,4L,2L,4L,6L,3L,3L,5L,4L,2L,5L,4L,4L,4L,2L,5L,4L,3L,3L,5L,6L,3L,3L,5L,4L,3L,4L,3L,6L,2L,3L,8L,3L,4L,3L,3L,5L,6L,4L,4L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259652Inst : IEnumerable<long>
{
public static readonly long[] Value=A259652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259652.Bytes);
public long this[int i]=>Value[i];

public static A259652Inst Instance=new A259652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259653
{
public static readonly long[] Value={ 0L,1L,4L,7L,16L,25L,34L,61L,88L,115L,142L,223L,304L,385L,466L,547L,790L,1033L,1276L,1519L,1762L,2005L,2734L,3463L,4192L,4921L,5650L,6379L,7108L,9295L,11482L,13669L,15856L,18043L,20230L,22417L,24604L,31165L,37726L,44287L,50848L,57409L,63970L,70531L,77092L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259653Inst : IEnumerable<long>
{
public static readonly long[] Value=A259653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259653.Bytes);
public long this[int i]=>Value[i];

public static A259653Inst Instance=new A259653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259654
{
public static readonly BigInteger[] Value={ 2L,18L,3000L,821142L,285311509560L,302875101765444L,BigInteger.Parse("827240261885926425504"),BigInteger.Parse("1978419655660296605560938"),BigInteger.Parse("20880467999847912032553880249104"),BigInteger.Parse("2567686153161211134561828214310308893183268"),BigInteger.Parse("17069174130723235958610643029033906279148329600") };
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
public class A259654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259654Inst Instance=new A259654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259655
{
public static readonly long[] Value={ 1L,1L,3L,1L,4L,1L,5L,2L,5L,2L,5L,3L,7L,1L,7L,2L,9L,3L,7L,2L,6L,4L,11L,3L,8L,3L,10L,3L,8L,4L,9L,3L,14L,2L,10L,2L,15L,6L,7L,5L,7L,3L,14L,5L,14L,3L,16L,5L,8L,4L,13L,5L,13L,3L,12L,4L,18L,5L,14L,4L,13L,5L,15L,4L,15L,5L,16L,7L,9L,6L,11L,7L,22L,3L,16L,3L,19L,7L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259655Inst : IEnumerable<long>
{
public static readonly long[] Value=A259655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259655.Bytes);
public long this[int i]=>Value[i];

public static A259655Inst Instance=new A259655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259656
{
public static readonly long[] Value={ 1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,1L,4L,3L,2L,3L,4L,3L,4L,3L,2L,3L,2L,1L,2L,1L,2L,3L,2L,3L,2L,3L,2L,1L,2L,3L,2L,3L,2L,3L,4L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259656Inst : IEnumerable<long>
{
public static readonly long[] Value=A259656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259656.Bytes);
public long this[int i]=>Value[i];

public static A259656Inst Instance=new A259656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259657
{
public static readonly long[] Value={ 1L,0L,0L,-2L,-3L,0L,0L,6L,0L,0L,0L,0L,8L,0L,0L,-12L,-9L,0L,0L,6L,0L,0L,0L,0L,12L,0L,0L,-2L,-12L,0L,0L,18L,0L,0L,0L,0L,6L,0L,0L,-24L,-12L,0L,0L,6L,0L,0L,0L,0L,20L,0L,0L,-12L,-12L,0L,0L,24L,0L,0L,0L,0L,24L,0L,0L,-12L,-21L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,-14L,-24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259657Inst : IEnumerable<long>
{
public static readonly long[] Value=A259657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259657.Bytes);
public long this[int i]=>Value[i];

public static A259657Inst Instance=new A259657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259658
{
public static readonly long[] Value={ 0L,1L,2L,11L,38L,271L,544L,2093L,2624L,8607L,17984L,35343L,35904L,70671L,71744L,141327L,143424L,282639L,286784L,565263L,573504L,1130511L,1146944L,2261007L,2293824L,4521999L,4587584L,9043983L,9175104L,18087951L,18350144L,36175887L,36700224L,72351759L,73400384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259658Inst : IEnumerable<long>
{
public static readonly long[] Value=A259658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259658.Bytes);
public long this[int i]=>Value[i];

public static A259658Inst Instance=new A259658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259659
{
public static readonly long[] Value={ 1L,-3L,0L,6L,-3L,0L,1L,-9L,0L,12L,-3L,0L,6L,-12L,0L,6L,-3L,0L,7L,-15L,0L,18L,-6L,0L,0L,-15L,0L,24L,-6L,0L,6L,-15L,0L,6L,-9L,0L,7L,-21L,0L,30L,-3L,0L,6L,-21L,0L,24L,-6L,0L,12L,-27L,0L,0L,-9L,0L,12L,-21L,0L,36L,-6L,0L,1L,-18L,0L,36L,-12L,0L,6L,-33L,0L,18L,-9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259659Inst : IEnumerable<long>
{
public static readonly long[] Value=A259659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259659.Bytes);
public long this[int i]=>Value[i];

public static A259659Inst Instance=new A259659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259660
{
public static readonly long[] Value={ 1L,0L,0L,-1L,1L,1L,0L,0L,1L,0L,0L,-1L,1L,0L,0L,1L,1L,-1L,0L,-1L,2L,1L,0L,0L,0L,1L,0L,-1L,1L,0L,0L,-1L,1L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L,-1L,1L,0L,0L,0L,1L,-1L,0L,-1L,0L,1L,0L,2L,1L,0L,0L,-2L,2L,0L,0L,0L,1L,1L,0L,-1L,0L,1L,0L,0L,2L,-1L,0L,0L,1L,0L,0L,0L,1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259660Inst : IEnumerable<long>
{
public static readonly long[] Value=A259660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259660.Bytes);
public long this[int i]=>Value[i];

public static A259660Inst Instance=new A259660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259661
{
public static readonly ulong[] Value={ 1L,11L,110L,1100L,11001L,110011L,1100110L,11001100L,110011001L,1100110011L,11001100110L,110011001100L,1100110011001L,11001100110011L,110011001100110L,1100110011001100L,11001100110011001L,110011001100110011L,1100110011001100110L,11001100110011001100UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259661Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A259661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259661.Bytes);
public ulong this[int i]=>Value[i];

public static A259661Inst Instance=new A259661Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}