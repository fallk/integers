using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A244582
{
public static readonly long[] Value={ 2L,1L,10L,9L,8L,7L,18L,36L,54L,17L,86L,80L,35L,87L,55L,31L,37L,15L,19L,33L,11L,16L,53L,49L,3L,34L,50L,84L,83L,85L,81L,48L,82L,30L,52L,51L,12L,93L,94L,13L,88L,56L,38L,58L,63L,70L,102L,20L,99L,98L,57L,59L,32L,47L,97L,95L,60L,89L,79L,62L,29L,61L,92L,25L,4L,64L,96L,65L,14L,66L,28L,67L,27L,68L,39L,100L,26L,21L,69L,46L,91L,103L,71L,22L,90L,78L,40L,24L,23L,45L,72L,43L,44L,5L,77L,41L,42L,73L,76L,75L,74L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244582Inst : IEnumerable<long>
{
public static readonly long[] Value=A244582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244582.Bytes);
public long this[int i]=>Value[i];

public static A244582Inst Instance=new A244582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244583
{
public static readonly long[] Value={ 4L,8L,21L,41L,99L,141L,238L,297L,431L,690L,794L,1136L,1384L,1524L,1806L,2304L,2846L,3076L,3699L,4137L,4406L,5128L,5645L,6499L,7755L,8401L,8721L,9393L,9783L,10513L,13280L,14095L,15443L,15871L,18232L,18756L,20320L,21873L,22875L,24604L,26274L,27002L,29982L,30684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244583Inst : IEnumerable<long>
{
public static readonly long[] Value=A244583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244583.Bytes);
public long this[int i]=>Value[i];

public static A244583Inst Instance=new A244583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244584
{
public static readonly long[] Value={ 3L,3L,3L,3L,7L,7L,7L,7L,11L,11L,11L,11L,15L,15L,15L,15L,19L,19L,19L,19L,23L,23L,23L,23L,27L,27L,27L,27L,31L,31L,31L,31L,35L,35L,35L,35L,39L,39L,39L,39L,43L,43L,43L,43L,47L,47L,47L,47L,51L,51L,51L,51L,55L,55L,55L,55L,59L,59L,59L,59L,63L,63L,63L,63L,67L,67L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244584Inst : IEnumerable<long>
{
public static readonly long[] Value=A244584.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244584.Bytes);
public long this[int i]=>Value[i];

public static A244584Inst Instance=new A244584Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244585
{
public static readonly BigInteger[] Value={ 1L,5L,79L,2621L,149071L,12954365L,1596620719L,264914218301L,56934521042191L,15385666763366525L,5106110041462786159L,BigInteger.Parse("2041611328770984737981"),BigInteger.Parse("967972254733121945653711"),BigInteger.Parse("536962084044317668770841085"),BigInteger.Parse("344546100916295014902350596399") };
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
public class A244585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244585Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244585.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244585Inst Instance=new A244585Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244586
{
public static readonly long[] Value={ 4L,5L,6L,7L,4L,5L,6L,7L,12L,13L,14L,15L,12L,13L,14L,15L,20L,21L,22L,23L,20L,21L,22L,23L,28L,29L,30L,31L,28L,29L,30L,31L,36L,37L,38L,39L,36L,37L,38L,39L,44L,45L,46L,47L,44L,45L,46L,47L,52L,53L,54L,55L,52L,53L,54L,55L,60L,61L,62L,63L,60L,61L,62L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244586Inst : IEnumerable<long>
{
public static readonly long[] Value=A244586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244586.Bytes);
public long this[int i]=>Value[i];

public static A244586Inst Instance=new A244586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244587
{
public static readonly long[] Value={ 5L,5L,7L,7L,5L,5L,7L,7L,13L,13L,15L,15L,13L,13L,15L,15L,21L,21L,23L,23L,21L,21L,23L,23L,29L,29L,31L,31L,29L,29L,31L,31L,37L,37L,39L,39L,37L,37L,39L,39L,45L,45L,47L,47L,45L,45L,47L,47L,53L,53L,55L,55L,53L,53L,55L,55L,61L,61L,63L,63L,61L,61L,63L,63L,69L,69L,71L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244587Inst : IEnumerable<long>
{
public static readonly long[] Value=A244587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244587.Bytes);
public long this[int i]=>Value[i];

public static A244587Inst Instance=new A244587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244588
{
public static readonly long[] Value={ 6L,7L,6L,7L,6L,7L,6L,7L,14L,15L,14L,15L,14L,15L,14L,15L,22L,23L,22L,23L,22L,23L,22L,23L,30L,31L,30L,31L,30L,31L,30L,31L,38L,39L,38L,39L,38L,39L,38L,39L,46L,47L,46L,47L,46L,47L,46L,47L,54L,55L,54L,55L,54L,55L,54L,55L,62L,63L,62L,63L,62L,63L,62L,63L,70L,71L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244588Inst : IEnumerable<long>
{
public static readonly long[] Value=A244588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244588.Bytes);
public long this[int i]=>Value[i];

public static A244588Inst Instance=new A244588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244589
{
public static readonly BigInteger[] Value={ 1L,1L,5L,67L,1937L,98791L,7744549L,857382695L,126889656641L,24157912257775L,5749369223697701L,1672527291075462559L,BigInteger.Parse("584038879457972531185"),BigInteger.Parse("241150002566590866157943"),BigInteger.Parse("116245385996298375640197893"),BigInteger.Parse("64707252902905394310560934391"),BigInteger.Parse("41198982747438307655532993553409") };
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
public class A244589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244589Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244589.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244589Inst Instance=new A244589Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244590
{
public static readonly long[] Value={ 0L,0L,4L,7L,12L,14L,18L,21L,28L,28L,32L,35L,40L,42L,46L,49L,56L,56L,60L,63L,68L,70L,74L,77L,84L,84L,88L,91L,96L,98L,102L,105L,112L,112L,116L,119L,124L,126L,130L,133L,140L,140L,144L,147L,152L,154L,158L,161L,168L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244590Inst : IEnumerable<long>
{
public static readonly long[] Value=A244590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244590.Bytes);
public long this[int i]=>Value[i];

public static A244590Inst Instance=new A244590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244591
{
public static readonly long[] Value={ 0L,1L,2L,4L,7L,5L,8L,13L,22L,16L,25L,14L,23L,17L,26L,40L,67L,49L,76L,43L,70L,52L,79L,41L,68L,50L,77L,44L,71L,53L,80L,121L,202L,148L,229L,130L,211L,157L,238L,124L,205L,151L,232L,133L,214L,160L,241L,122L,203L,149L,230L,131L,212L,158L,239L,125L,206L,152L,233L,134L,215L,161L,242L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244591Inst : IEnumerable<long>
{
public static readonly long[] Value=A244591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244591.Bytes);
public long this[int i]=>Value[i];

public static A244591Inst Instance=new A244591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244592
{
public static readonly long[] Value={ 3L,7L,8L,13L,14L,34L,43L,49L,51L,76L,83L,92L,94L,98L,103L,109L,113L,127L,139L,141L,169L,177L,179L,181L,194L,218L,229L,283L,323L,338L,367L,394L,397L,401L,437L,524L,526L,537L,579L,587L,626L,659L,661L,673L,674L,687L,701L,719L,724L,743L,767L,769L,802L,823L,838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244592Inst : IEnumerable<long>
{
public static readonly long[] Value=A244592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244592.Bytes);
public long this[int i]=>Value[i];

public static A244592Inst Instance=new A244592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244593
{
public static readonly long[] Value={ 1L,1L,0L,9L,0L,1L,6L,9L,9L,4L,3L,7L,4L,9L,4L,7L,4L,2L,4L,1L,0L,2L,2L,9L,3L,4L,1L,7L,1L,8L,2L,8L,1L,9L,0L,5L,8L,8L,6L,0L,1L,5L,4L,5L,8L,9L,9L,0L,2L,8L,8L,1L,4L,3L,1L,0L,6L,7L,7L,2L,4L,3L,1L,1L,3L,5L,2L,6L,3L,0L,2L,3L,1L,4L,0L,9L,4L,5L,1L,2L,2L,4L,8L,5L,3L,6L,0L,3L,6L,0L,2L,0L,9L,4L,6L,9L,5L,5L,6L,8L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244593Inst : IEnumerable<long>
{
public static readonly long[] Value=A244593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244593.Bytes);
public long this[int i]=>Value[i];

public static A244593Inst Instance=new A244593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244594
{
public static readonly BigInteger[] Value={ 1L,1L,4L,29L,263L,2672L,29088L,331749L,3912660L,47329811L,583983656L,7321173872L,92990672635L,1194113490556L,15476763809428L,202197552311829L,2659975668005367L,35205831900984144L,468468683002725372L,6263539340729569047L,BigInteger.Parse("84103985900174324256"),BigInteger.Parse("1133671250214654009000") };
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
public class A244594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244594Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244594.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244594Inst Instance=new A244594Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244595
{
public static readonly long[] Value={ 2L,3L,5L,7L,53L,149L,281L,373L,641L,643L,647L,821L,823L,919L,1049L,1091L,1093L,1097L,1319L,1361L,1367L,1409L,1543L,1637L,1811L,1861L,1907L,2081L,2083L,2087L,2089L,2129L,2179L,2309L,2357L,4153L,4241L,4243L,4421L,4423L,5009L,5233L,5237L,5413L,5417L,5507L,5641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244595Inst : IEnumerable<long>
{
public static readonly long[] Value=A244595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244595.Bytes);
public long this[int i]=>Value[i];

public static A244595Inst Instance=new A244595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244596
{
public static readonly long[] Value={ 2L,9L,7L,4L,6L,1L,5L,5L,2L,9L,8L,1L,2L,6L,0L,1L,8L,8L,9L,7L,1L,4L,6L,2L,4L,0L,2L,2L,7L,0L,1L,4L,7L,6L,7L,9L,8L,3L,2L,8L,4L,7L,0L,5L,4L,2L,2L,9L,5L,5L,1L,1L,9L,6L,7L,2L,9L,6L,7L,1L,7L,3L,8L,8L,4L,0L,1L,9L,8L,2L,4L,7L,7L,9L,3L,1L,0L,5L,0L,5L,0L,4L,1L,8L,4L,7L,9L,9L,6L,7L,4L,2L,4L,2L,2L,8L,0L,1L,4L,5L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244596Inst : IEnumerable<long>
{
public static readonly long[] Value=A244596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244596.Bytes);
public long this[int i]=>Value[i];

public static A244596Inst Instance=new A244596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244597
{
public static readonly long[] Value={ 2L,3L,5L,7L,53L,149L,281L,373L,641L,643L,647L,821L,823L,919L,1319L,1361L,1367L,1637L,1811L,1861L,2129L,2179L,2357L,4421L,4423L,5233L,5237L,5413L,5417L,5737L,5783L,6229L,6277L,6451L,6547L,8521L,9241L,9337L,9511L,9833L,12611L,12613L,12841L,13159L,13331L,13337L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244597Inst : IEnumerable<long>
{
public static readonly long[] Value=A244597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244597.Bytes);
public long this[int i]=>Value[i];

public static A244597Inst Instance=new A244597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244598
{
public static readonly long[] Value={ 152206L,1522060L,4109489L,4459665L,6001522L,7761557L,9489041L,10948904L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244598Inst : IEnumerable<long>
{
public static readonly long[] Value=A244598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244598.Bytes);
public long this[int i]=>Value[i];

public static A244598Inst Instance=new A244598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244599
{
public static readonly long[] Value={ 2L,29L,227L,22807L,86269L,2206031L,668880743L,4208046655963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244599Inst : IEnumerable<long>
{
public static readonly long[] Value=A244599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244599.Bytes);
public long this[int i]=>Value[i];

public static A244599Inst Instance=new A244599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244600
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,1L,0L,2L,-1L,-1L,0L,0L,0L,0L,3L,-3L,-2L,0L,0L,1L,0L,5L,-3L,-3L,0L,0L,2L,0L,8L,-6L,-5L,0L,0L,3L,0L,11L,-8L,-7L,0L,0L,3L,0L,17L,-13L,-11L,0L,0L,6L,0L,24L,-17L,-14L,0L,0L,7L,0L,34L,-25L,-21L,0L,0L,11L,0L,47L,-33L,-28L,0L,0L,14L,0L,64L,-47L,-39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244600Inst : IEnumerable<long>
{
public static readonly long[] Value=A244600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244600.Bytes);
public long this[int i]=>Value[i];

public static A244600Inst Instance=new A244600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244601
{
public static readonly long[] Value={ 1L,31L,47L,723L,4992L,89296L,210482L,384340L,110702779L,419970418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244601Inst : IEnumerable<long>
{
public static readonly long[] Value=A244601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244601.Bytes);
public long this[int i]=>Value[i];

public static A244601Inst Instance=new A244601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244602
{
public static readonly long[] Value={ 7L,66L,999L,8888L,66666L,0L,5555555L,99999999L,111111111L,1111111111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244602Inst : IEnumerable<long>
{
public static readonly long[] Value=A244602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244602.Bytes);
public long this[int i]=>Value[i];

public static A244602Inst Instance=new A244602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244603
{
public static readonly long[] Value={ 1L,18L,21L,32L,30L,38L,33L,55L,69L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244603Inst : IEnumerable<long>
{
public static readonly long[] Value=A244603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244603.Bytes);
public long this[int i]=>Value[i];

public static A244603Inst Instance=new A244603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244604
{
public static readonly long[] Value={ 1L,1L,15L,179L,261L,435L,426L,1083L,2169L,2137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244604Inst : IEnumerable<long>
{
public static readonly long[] Value=A244604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244604.Bytes);
public long this[int i]=>Value[i];

public static A244604Inst Instance=new A244604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244605
{
public static readonly long[] Value={ 1L,3L,19L,7L,449L,31L,2647L,127L,7649L,511L,67523L,2047L,11178659L,8191L,98305L,32767L,33419233L,131071L,209233981L,524287L,345855139L,2097151L,579668327L,8388607L,45565432859L,33554431L,411206281L,134217727L,209789384821L,536870911L,23993971665011L,2147483647L,-5518887720767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244605Inst : IEnumerable<long>
{
public static readonly long[] Value=A244605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244605.Bytes);
public long this[int i]=>Value[i];

public static A244605Inst Instance=new A244605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244606
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,5L,3L,2L,7L,0L,0L,5L,3L,6L,4L,0L,3L,5L,3L,0L,2L,6L,5L,3L,0L,0L,0L,6L,2L,3L,4L,2L,4L,2L,2L,2L,3L,4L,3L,5L,2L,2L,4L,5L,2L,2L,0L,4L,0L,3L,7L,2L,5L,3L,4L,0L,4L,2L,4L,2L,7L,7L,7L,2L,0L,3L,2L,8L,6L,6L,2L,0L,3L,7L,2L,4L,0L,6L,0L,0L,0L,8L,5L,4L,3L,0L,0L,6L,5L,2L,5L,0L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244606Inst : IEnumerable<long>
{
public static readonly long[] Value=A244606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244606.Bytes);
public long this[int i]=>Value[i];

public static A244606Inst Instance=new A244606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244607
{
public static readonly long[] Value={ 3L,4L,6L,8L,13L,14L,16L,18L,22L,23L,24L,26L,27L,29L,31L,32L,34L,36L,38L,41L,42L,43L,45L,46L,48L,54L,56L,61L,62L,63L,64L,65L,67L,68L,69L,72L,76L,81L,83L,84L,86L,89L,92L,96L,98L,113L,114L,116L,118L,122L,123L,124L,126L,127L,129L,131L,132L,134L,136L,138L,141L,142L,143L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244607Inst : IEnumerable<long>
{
public static readonly long[] Value=A244607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244607.Bytes);
public long this[int i]=>Value[i];

public static A244607Inst Instance=new A244607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244608
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,4L,1L,11L,-1L,1L,26L,-27L,1L,57L,-289L,-1L,1L,120L,-2160L,-256L,1L,247L,-13359L,-13604L,1L,1L,502L,-73749L,-383750L,3125L,1L,1013L,-378283L,-7682623L,1006734L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244608Inst : IEnumerable<long>
{
public static readonly long[] Value=A244608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244608.Bytes);
public long this[int i]=>Value[i];

public static A244608Inst Instance=new A244608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244609
{
public static readonly long[] Value={ 2L,3L,5L,3L,13L,3L,5L,3L,73L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,977L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,31L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,73L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,13477L,3L,5L,3L,7L,3L,5L,3L,13L,3L,5L,3L,48430237L,3L,5L,3L,7L,3L,5L,3L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244609Inst : IEnumerable<long>
{
public static readonly long[] Value=A244609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244609.Bytes);
public long this[int i]=>Value[i];

public static A244609Inst Instance=new A244609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244610
{
public static readonly BigInteger[] Value={ 1L,3L,12L,69L,531L,4902L,50829L,572205L,6862689L,86688894L,1144856748L,15729634734L,224087784921L,3302687639634L,50281130534937L,789933587289762L,12797723149002135L,213714114688378335L,3677422015083776007L,BigInteger.Parse("65182431142298139342"),BigInteger.Parse("1189739115108589181733"),BigInteger.Parse("22353074429721448236369") };
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
public class A244610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244610Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244610.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244610Inst Instance=new A244610Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244611
{
public static readonly long[] Value={ 1L,1L,-1L,1L,0L,-1L,0L,1L,1L,0L,0L,-1L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,-1L,1L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,1L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244611Inst : IEnumerable<long>
{
public static readonly long[] Value=A244611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244611.Bytes);
public long this[int i]=>Value[i];

public static A244611Inst Instance=new A244611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244612
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,-1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244612Inst : IEnumerable<long>
{
public static readonly long[] Value=A244612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244612.Bytes);
public long this[int i]=>Value[i];

public static A244612Inst Instance=new A244612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244613
{
public static readonly long[] Value={ 1L,8L,28L,328L,1328L,11328L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244613Inst : IEnumerable<long>
{
public static readonly long[] Value=A244613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244613.Bytes);
public long this[int i]=>Value[i];

public static A244613Inst Instance=new A244613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244614
{
public static readonly long[] Value={ 2L,1361L,1811L,4423L,5233L,5413L,33811L,2181217L,2233417L,2234227L,2241427L,2253127L,2311537L,2315317L,2512417L,2631217L,3225127L,3412327L,3421237L,3422227L,3621217L,4264313L,4274213L,4281413L,4282133L,4331543L,4346213L,4412183L,4412453L,4417313L,4428113L,4532513L,4535123L,4543313L,4551233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244614Inst : IEnumerable<long>
{
public static readonly long[] Value=A244614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244614.Bytes);
public long this[int i]=>Value[i];

public static A244614Inst Instance=new A244614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244615
{
public static readonly long[] Value={ 1L,3L,10L,29L,88L,259L,771L,2284L,6786L,20191L,60189L,179654L,536925L,1606221L,4808601L,14403804L,43163793L,129388755L,387946445L,1163370778L,3489117566L,10465248174L,31391306504L,94164586011L,282474177151L,847381544167L,2542059008323L,7625998475474L,22877623720244L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244615Inst : IEnumerable<long>
{
public static readonly long[] Value=A244615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244615.Bytes);
public long this[int i]=>Value[i];

public static A244615Inst Instance=new A244615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244616
{
public static readonly long[] Value={ 1L,4L,17L,66L,265L,1046L,4165L,16561L,66017L,263377L,1051774L,4202363L,16797551L,67159565L,268561326L,1074052233L,4295730126L,17181735211L,68724026662L,274888965526L,1099538433297L,4398111321331L,17592342396443L,70369120593536L,281475881240563L,1125902076700152L,4503604824386737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244616Inst : IEnumerable<long>
{
public static readonly long[] Value=A244616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244616.Bytes);
public long this[int i]=>Value[i];

public static A244616Inst Instance=new A244616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244617
{
public static readonly long[] Value={ 1L,5L,26L,127L,636L,3153L,15727L,78406L,391494L,1955563L,9772721L,48847892L,244196337L,1220857221L,6103941997L,30518746918L,152591088797L,762948154799L,3814720881833L,19073550187976L,95367603900506L,476837621600990L,2384187034951204L,11920932287085421L,59604653684027019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244617Inst : IEnumerable<long>
{
public static readonly long[] Value=A244617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244617.Bytes);
public long this[int i]=>Value[i];

public static A244617Inst Instance=new A244617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244618
{
public static readonly long[] Value={ 1L,6L,37L,218L,1309L,7810L,46797L,280345L,1681029L,10081939L,60479790L,362838047L,2176908951L,13061074143L,78365313414L,470188412205L,2821120141002L,16926689765961L,101560046400158L,609360004351714L,3656159217328421L,21936952918704867L,131621710507870811L,789730242509398308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244618Inst : IEnumerable<long>
{
public static readonly long[] Value=A244618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244618.Bytes);
public long this[int i]=>Value[i];

public static A244618Inst Instance=new A244618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244619
{
public static readonly long[] Value={ 3L,6L,2L,8L,4L,7L,3L,2L,0L,2L,4L,3L,0L,2L,8L,8L,3L,9L,0L,0L,6L,6L,4L,1L,9L,1L,9L,4L,3L,4L,5L,3L,8L,4L,6L,1L,8L,3L,0L,9L,5L,0L,8L,6L,1L,8L,5L,9L,1L,6L,0L,7L,4L,2L,8L,7L,5L,4L,9L,3L,9L,8L,3L,9L,3L,8L,8L,5L,5L,4L,6L,7L,3L,3L,6L,8L,4L,1L,0L,1L,3L,6L,4L,0L,8L,8L,6L,0L,1L,1L,9L,2L,4L,4L,8L,9L,6L,2L,3L,4L,6L,3L,4L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244619Inst : IEnumerable<long>
{
public static readonly long[] Value=A244619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244619.Bytes);
public long this[int i]=>Value[i];

public static A244619Inst Instance=new A244619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244620
{
public static readonly long[] Value={ 3521210L,6178458L,13220900L,15878148L,22920590L,25577838L,32620280L,35277528L,42319970L,44977218L,52019660L,54676908L,61719350L,64376598L,71419040L,74076288L,81118730L,83775978L,90818420L,93475668L,100518110L,103175358L,110217800L,112875048L,119917490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244620Inst : IEnumerable<long>
{
public static readonly long[] Value=A244620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244620.Bytes);
public long this[int i]=>Value[i];

public static A244620Inst Instance=new A244620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244621
{
public static readonly long[] Value={ 1L,5L,7L,7L,11L,5L,7L,7L,11L,1L,1L,7L,5L,5L,1L,11L,7L,1L,1L,5L,11L,11L,7L,5L,11L,1L,1L,5L,11L,1L,1L,5L,7L,7L,5L,5L,11L,11L,7L,5L,1L,7L,11L,5L,7L,7L,7L,7L,11L,5L,7L,11L,5L,1L,11L,7L,5L,5L,11L,1L,1L,11L,11L,7L,1L,11L,11L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244621Inst : IEnumerable<long>
{
public static readonly long[] Value=A244621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244621.Bytes);
public long this[int i]=>Value[i];

public static A244621Inst Instance=new A244621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244622
{
public static readonly BigInteger[] Value={ 5L,31L,2927L,40361L,BigInteger.Parse("201015517717077830328949"),BigInteger.Parse("13585328068403621603022853"),BigInteger.Parse("5692733621468679832887230172131"),BigInteger.Parse("3215488142498485484492183158345029261034221047849345857469577412562094716564064084247") };
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
public class A244622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244622Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244622.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244622Inst Instance=new A244622Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244623
{
public static readonly long[] Value={ 1L,9L,25L,27L,49L,81L,121L,125L,169L,243L,289L,343L,361L,529L,625L,729L,841L,961L,1331L,1369L,1681L,1849L,2187L,2197L,2209L,2401L,2809L,3125L,3481L,3721L,4489L,4913L,5041L,5329L,6241L,6561L,6859L,6889L,7921L,9409L,10201L,10609L,11449L,11881L,12167L,12769L,14641L,15625L,16129L,16807L,17161L,18769L,19321L,19683L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244623Inst : IEnumerable<long>
{
public static readonly long[] Value=A244623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244623.Bytes);
public long this[int i]=>Value[i];

public static A244623Inst Instance=new A244623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244624
{
public static readonly long[] Value={ 1L,2L,4L,9L,14L,34L,61L,120L,215L,690L,1144L,2584L,5626L,13709L,31275L,63461L,145767L,340332L,649190L,1703684L,4218462L,10675070L,22892978L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244624Inst : IEnumerable<long>
{
public static readonly long[] Value=A244624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244624.Bytes);
public long this[int i]=>Value[i];

public static A244624Inst Instance=new A244624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244625
{
public static readonly long[] Value={ 7L,9L,9L,3L,7L,0L,4L,0L,1L,3L,0L,6L,3L,3L,2L,8L,7L,8L,9L,8L,7L,2L,5L,2L,8L,5L,3L,9L,7L,5L,3L,5L,2L,5L,6L,6L,8L,7L,7L,7L,0L,2L,3L,5L,0L,8L,4L,3L,4L,8L,4L,1L,2L,5L,8L,9L,1L,9L,6L,3L,4L,3L,3L,1L,2L,8L,7L,0L,8L,3L,1L,9L,9L,7L,1L,7L,6L,1L,4L,6L,0L,5L,9L,5L,7L,1L,7L,7L,6L,5L,9L,7L,0L,3L,7L,2L,4L,7L,5L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244625Inst : IEnumerable<long>
{
public static readonly long[] Value=A244625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244625.Bytes);
public long this[int i]=>Value[i];

public static A244625Inst Instance=new A244625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244626
{
public static readonly long[] Value={ 3277L,29341L,49141L,80581L,88357L,104653L,196093L,314821L,458989L,489997L,800605L,838861L,873181L,1004653L,1251949L,1373653L,1509709L,1678541L,1811573L,1987021L,2269093L,2284453L,2387797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244626Inst : IEnumerable<long>
{
public static readonly long[] Value=A244626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244626.Bytes);
public long this[int i]=>Value[i];

public static A244626Inst Instance=new A244626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244627
{
public static readonly BigInteger[] Value={ 1L,2L,10L,84L,882L,10380L,130916L,1729960L,23640770L,331357276L,4737405356L,68818101400L,1012852747220L,15070913484664L,226340757825800L,3426481380787024L,52232521742541410L,801068351764540540L,12351730365539402076UL,BigInteger.Parse("191363830520437179960") };
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
public class A244627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244627Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244627.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244627Inst Instance=new A244627Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244628
{
public static readonly long[] Value={ 476971L,877099L,1302451L,1325843L,1397419L,1441091L,1507963L,1530787L,1907851L,2004403L,3090091L,3116107L,5256091L,5919187L,7883731L,9371251L,11081459L,11541307L,12263131L,13057787L,13338371L,15976747L,17134043L,18740971L,19404139L,20261251L,21623659L,22075579L,24214051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244628Inst : IEnumerable<long>
{
public static readonly long[] Value=A244628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244628.Bytes);
public long this[int i]=>Value[i];

public static A244628Inst Instance=new A244628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244629
{
public static readonly long[] Value={ 1L,3L,7L,17L,37L,79L,163L,321L,617L,1179L,2047L,3761L,6773L,12103L,20723L,36733L,62881L,110231L,186379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244629Inst : IEnumerable<long>
{
public static readonly long[] Value=A244629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244629.Bytes);
public long this[int i]=>Value[i];

public static A244629Inst Instance=new A244629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244630
{
public static readonly long[] Value={ 0L,17L,68L,153L,272L,425L,612L,833L,1088L,1377L,1700L,2057L,2448L,2873L,3332L,3825L,4352L,4913L,5508L,6137L,6800L,7497L,8228L,8993L,9792L,10625L,11492L,12393L,13328L,14297L,15300L,16337L,17408L,18513L,19652L,20825L,22032L,23273L,24548L,25857L,27200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244630Inst : IEnumerable<long>
{
public static readonly long[] Value=A244630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244630.Bytes);
public long this[int i]=>Value[i];

public static A244630Inst Instance=new A244630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244631
{
public static readonly long[] Value={ 0L,19L,76L,171L,304L,475L,684L,931L,1216L,1539L,1900L,2299L,2736L,3211L,3724L,4275L,4864L,5491L,6156L,6859L,7600L,8379L,9196L,10051L,10944L,11875L,12844L,13851L,14896L,15979L,17100L,18259L,19456L,20691L,21964L,23275L,24624L,26011L,27436L,28899L,30400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244631Inst : IEnumerable<long>
{
public static readonly long[] Value=A244631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244631.Bytes);
public long this[int i]=>Value[i];

public static A244631Inst Instance=new A244631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244632
{
public static readonly long[] Value={ 0L,23L,92L,207L,368L,575L,828L,1127L,1472L,1863L,2300L,2783L,3312L,3887L,4508L,5175L,5888L,6647L,7452L,8303L,9200L,10143L,11132L,12167L,13248L,14375L,15548L,16767L,18032L,19343L,20700L,22103L,23552L,25047L,26588L,28175L,29808L,31487L,33212L,34983L,36800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244632Inst : IEnumerable<long>
{
public static readonly long[] Value=A244632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244632.Bytes);
public long this[int i]=>Value[i];

public static A244632Inst Instance=new A244632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244633
{
public static readonly long[] Value={ 0L,26L,104L,234L,416L,650L,936L,1274L,1664L,2106L,2600L,3146L,3744L,4394L,5096L,5850L,6656L,7514L,8424L,9386L,10400L,11466L,12584L,13754L,14976L,16250L,17576L,18954L,20384L,21866L,23400L,24986L,26624L,28314L,30056L,31850L,33696L,35594L,37544L,39546L,41600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244633Inst : IEnumerable<long>
{
public static readonly long[] Value=A244633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244633.Bytes);
public long this[int i]=>Value[i];

public static A244633Inst Instance=new A244633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244634
{
public static readonly long[] Value={ 0L,27L,108L,243L,432L,675L,972L,1323L,1728L,2187L,2700L,3267L,3888L,4563L,5292L,6075L,6912L,7803L,8748L,9747L,10800L,11907L,13068L,14283L,15552L,16875L,18252L,19683L,21168L,22707L,24300L,25947L,27648L,29403L,31212L,33075L,34992L,36963L,38988L,41067L,43200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244634Inst : IEnumerable<long>
{
public static readonly long[] Value=A244634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244634.Bytes);
public long this[int i]=>Value[i];

public static A244634Inst Instance=new A244634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244635
{
public static readonly long[] Value={ 0L,29L,116L,261L,464L,725L,1044L,1421L,1856L,2349L,2900L,3509L,4176L,4901L,5684L,6525L,7424L,8381L,9396L,10469L,11600L,12789L,14036L,15341L,16704L,18125L,19604L,21141L,22736L,24389L,26100L,27869L,29696L,31581L,33524L,35525L,37584L,39701L,41876L,44109L,46400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244635Inst : IEnumerable<long>
{
public static readonly long[] Value=A244635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244635.Bytes);
public long this[int i]=>Value[i];

public static A244635Inst Instance=new A244635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244636
{
public static readonly long[] Value={ 0L,30L,120L,270L,480L,750L,1080L,1470L,1920L,2430L,3000L,3630L,4320L,5070L,5880L,6750L,7680L,8670L,9720L,10830L,12000L,13230L,14520L,15870L,17280L,18750L,20280L,21870L,23520L,25230L,27000L,28830L,30720L,32670L,34680L,36750L,38880L,41070L,43320L,45630L,48000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244636Inst : IEnumerable<long>
{
public static readonly long[] Value=A244636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244636.Bytes);
public long this[int i]=>Value[i];

public static A244636Inst Instance=new A244636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244637
{
public static readonly long[] Value={ 13L,29L,53L,83L,173L,179L,199L,227L,293L,347L,367L,373L,419L,439L,463L,467L,487L,491L,541L,563L,569L,587L,607L,613L,617L,641L,653L,659L,709L,727L,733L,751L,809L,823L,827L,829L,853L,857L,877L,881L,919L,953L,971L,977L,991L,997L,1013L,1019L,1021L,1039L,1049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244637Inst : IEnumerable<long>
{
public static readonly long[] Value=A244637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244637.Bytes);
public long this[int i]=>Value[i];

public static A244637Inst Instance=new A244637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244638
{
public static readonly long[] Value={ 2L,3L,7L,19L,31L,41L,73L,97L,193L,257L,313L,487L,859L,937L,1249L,2539L,3331L,3947L,5351L,5839L,7963L,9257L,12343L,21943L,31687L,45127L,60169L,78791L,115547L,180463L,213881L,234239L,270271L,376603L,875681L,1023871L,1252663L,1564063L,2585279L,4063723L,5649499L,9973919L,11200681L,39824647L,41464303L,73583071L,95592191L,226588897L,1359533387L,2263333321L,3349304527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244638Inst : IEnumerable<long>
{
public static readonly long[] Value=A244638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244638.Bytes);
public long this[int i]=>Value[i];

public static A244638Inst Instance=new A244638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244639
{
public static readonly long[] Value={ 1L,3L,2L,2L,7L,7L,9L,2L,5L,3L,1L,2L,2L,3L,8L,8L,8L,5L,6L,7L,4L,9L,4L,4L,2L,2L,6L,1L,3L,1L,0L,0L,8L,4L,0L,1L,6L,5L,2L,2L,8L,0L,1L,1L,7L,3L,7L,1L,3L,9L,2L,4L,3L,7L,2L,2L,8L,5L,4L,5L,7L,6L,2L,6L,8L,8L,5L,1L,6L,2L,2L,1L,0L,7L,6L,8L,5L,8L,4L,4L,7L,5L,3L,5L,6L,8L,0L,9L,0L,8L,6L,0L,4L,1L,2L,4L,4L,7L,1L,1L,9L,3L,2L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244639Inst : IEnumerable<long>
{
public static readonly long[] Value=A244639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244639.Bytes);
public long this[int i]=>Value[i];

public static A244639Inst Instance=new A244639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244640
{
public static readonly long[] Value={ 2L,4L,4L,16L,16L,16L,8L,192L,240L,128L,512L,36L,24L,224L,96L,896L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244640Inst : IEnumerable<long>
{
public static readonly long[] Value=A244640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244640.Bytes);
public long this[int i]=>Value[i];

public static A244640Inst Instance=new A244640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244641
{
public static readonly long[] Value={ 1L,4L,8L,2L,0L,3L,7L,5L,0L,1L,7L,7L,0L,1L,1L,1L,2L,2L,3L,5L,9L,1L,6L,5L,7L,4L,5L,3L,1L,2L,5L,4L,2L,1L,3L,8L,1L,6L,5L,8L,4L,0L,5L,4L,2L,5L,3L,7L,5L,5L,0L,7L,7L,7L,9L,6L,3L,4L,1L,9L,8L,0L,6L,5L,5L,2L,4L,3L,5L,9L,6L,9L,8L,5L,2L,9L,4L,7L,3L,0L,1L,6L,9L,3L,6L,7L,2L,2L,2L,7L,6L,2L,2L,9L,1L,3L,6L,0L,9L,7L,5L,0L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244641Inst : IEnumerable<long>
{
public static readonly long[] Value=A244641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244641.Bytes);
public long this[int i]=>Value[i];

public static A244641Inst Instance=new A244641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244642
{
public static readonly long[] Value={ 1L,5L,9L,21L,25L,29L,41L,85L,89L,61L,65L,109L,121L,125L,169L,341L,345L,189L,161L,205L,209L,181L,225L,429L,441L,285L,289L,461L,505L,509L,681L,1365L,1369L,701L,545L,589L,561L,405L,449L,781L,785L,469L,441L,645L,689L,661L,865L,1709L,1721L,925L,769L,941L,945L,789L,961L,1805L,1849L,1181L,1185L,1869L,2041L,2045L,2729L,5461L,5465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244642Inst : IEnumerable<long>
{
public static readonly long[] Value=A244642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244642.Bytes);
public long this[int i]=>Value[i];

public static A244642Inst Instance=new A244642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244643
{
public static readonly long[] Value={ 0L,1L,4L,5L,16L,9L,20L,21L,64L,25L,36L,29L,80L,41L,84L,85L,256L,89L,100L,61L,144L,65L,116L,109L,320L,121L,164L,125L,336L,169L,340L,341L,1024L,345L,356L,189L,400L,161L,244L,205L,576L,209L,260L,181L,464L,225L,436L,429L,1280L,441L,484L,285L,656L,289L,500L,461L,1344L,505L,676L,509L,1360L,681L,1364L,1365L,4096L,1369L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244643Inst : IEnumerable<long>
{
public static readonly long[] Value=A244643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244643.Bytes);
public long this[int i]=>Value[i];

public static A244643Inst Instance=new A244643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244644
{
public static readonly long[] Value={ 0L,1L,3L,5L,6L,8L,10L,11L,13L,15L,16L,18L,20L,21L,23L,25L,26L,28L,29L,31L,33L,34L,36L,38L,39L,41L,43L,44L,46L,48L,49L,51L,53L,54L,56L,58L,59L,61L,63L,64L,66L,68L,69L,71L,73L,74L,76L,78L,79L,81L,83L,84L,86L,88L,89L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,108L,109L,111L,113L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244644Inst : IEnumerable<long>
{
public static readonly long[] Value=A244644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244644.Bytes);
public long this[int i]=>Value[i];

public static A244644Inst Instance=new A244644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244645
{
public static readonly long[] Value={ 1L,2L,7L,7L,4L,0L,9L,0L,5L,7L,5L,5L,9L,6L,3L,6L,7L,3L,1L,1L,9L,4L,9L,5L,3L,4L,9L,2L,1L,0L,2L,4L,3L,3L,2L,1L,1L,5L,5L,6L,6L,3L,4L,4L,8L,0L,3L,9L,0L,2L,4L,7L,2L,3L,2L,6L,9L,3L,4L,9L,1L,9L,8L,4L,0L,7L,5L,1L,5L,1L,5L,1L,5L,1L,9L,5L,5L,4L,5L,1L,9L,6L,0L,7L,6L,2L,4L,3L,0L,6L,3L,1L,6L,3L,3L,1L,4L,1L,0L,8L,8L,0L,5L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244645Inst : IEnumerable<long>
{
public static readonly long[] Value=A244645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244645.Bytes);
public long this[int i]=>Value[i];

public static A244645Inst Instance=new A244645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244646
{
public static readonly long[] Value={ 1L,2L,4L,3L,3L,2L,0L,9L,2L,6L,1L,5L,3L,7L,1L,2L,9L,8L,9L,2L,0L,6L,6L,0L,7L,7L,3L,9L,6L,3L,1L,0L,1L,4L,2L,8L,2L,1L,3L,5L,8L,4L,4L,1L,0L,1L,0L,3L,0L,0L,9L,9L,6L,2L,4L,4L,1L,5L,2L,8L,1L,7L,5L,2L,5L,3L,8L,6L,6L,0L,7L,4L,3L,8L,4L,4L,0L,8L,5L,1L,9L,7L,8L,6L,9L,0L,0L,1L,3L,2L,3L,2L,5L,8L,8L,3L,2L,8L,6L,0L,0L,7L,3L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244646Inst : IEnumerable<long>
{
public static readonly long[] Value=A244646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244646.Bytes);
public long this[int i]=>Value[i];

public static A244646Inst Instance=new A244646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244647
{
public static readonly long[] Value={ 1L,2L,1L,6L,7L,4L,5L,9L,5L,6L,1L,5L,8L,2L,4L,4L,1L,8L,2L,4L,9L,4L,3L,3L,9L,3L,5L,2L,0L,0L,4L,7L,6L,0L,3L,8L,2L,1L,0L,8L,3L,6L,1L,7L,0L,0L,9L,2L,2L,7L,7L,2L,8L,9L,0L,9L,4L,9L,8L,3L,7L,4L,4L,1L,5L,4L,4L,6L,9L,6L,3L,5L,6L,3L,5L,0L,7L,2L,9L,5L,4L,8L,7L,1L,0L,5L,3L,5L,7L,9L,7L,8L,8L,6L,7L,7L,1L,5L,3L,2L,2L,0L,5L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244647Inst : IEnumerable<long>
{
public static readonly long[] Value=A244647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244647.Bytes);
public long this[int i]=>Value[i];

public static A244647Inst Instance=new A244647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244648
{
public static readonly long[] Value={ 1L,1L,9L,5L,4L,3L,4L,1L,1L,6L,5L,2L,9L,6L,2L,7L,9L,7L,4L,3L,5L,2L,4L,9L,9L,2L,3L,4L,6L,9L,8L,4L,9L,9L,3L,5L,4L,8L,8L,4L,6L,8L,2L,6L,2L,7L,0L,8L,4L,6L,5L,8L,0L,6L,2L,3L,8L,6L,0L,2L,1L,6L,0L,3L,0L,1L,7L,3L,5L,8L,4L,7L,3L,3L,7L,0L,3L,1L,7L,6L,0L,1L,4L,6L,4L,4L,8L,4L,1L,7L,5L,4L,8L,5L,5L,1L,1L,2L,3L,1L,8L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244648Inst : IEnumerable<long>
{
public static readonly long[] Value=A244648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244648.Bytes);
public long this[int i]=>Value[i];

public static A244648Inst Instance=new A244648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244649
{
public static readonly long[] Value={ 1L,1L,7L,7L,9L,5L,6L,0L,5L,7L,9L,2L,2L,6L,6L,3L,8L,5L,8L,7L,3L,5L,1L,7L,3L,9L,6L,8L,0L,9L,1L,8L,8L,7L,4L,1L,8L,4L,4L,5L,8L,5L,7L,2L,3L,4L,5L,6L,6L,6L,7L,9L,8L,0L,2L,8L,4L,2L,5L,2L,2L,8L,5L,7L,3L,2L,6L,6L,8L,9L,2L,5L,6L,8L,2L,8L,4L,8L,8L,7L,4L,5L,4L,0L,2L,4L,0L,7L,6L,9L,0L,2L,5L,6L,9L,5L,5L,9L,0L,3L,2L,2L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244649Inst : IEnumerable<long>
{
public static readonly long[] Value=A244649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244649.Bytes);
public long this[int i]=>Value[i];

public static A244649Inst Instance=new A244649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244650
{
public static readonly long[] Value={ 1L,9L,55L,290L,1430L,6827L,32083L,149665L,696130L,3236140L,15055750L,70149880L,327464665L,1531766715L,7180234915L,33728718755L,158765477150L,748819793990L,3538574254840L,16752185111615L,79445373603241L,377382842713434L,1795459769465370L,8554888685073420L,40819261337588995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244650Inst : IEnumerable<long>
{
public static readonly long[] Value=A244650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244650.Bytes);
public long this[int i]=>Value[i];

public static A244650Inst Instance=new A244650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244651
{
public static readonly BigInteger[] Value={ 1L,14L,135L,1148L,9325L,74634L,596083L,4775288L,38447961L,311305350L,2534757855L,20749571316L,170705908421L,1410874891522L,11710273480395L,97573698950384L,815919118022833L,6845174820882174L,57601263531202871L,486057767175907180L,4112073577799441181L,BigInteger.Parse("34871360280503319674") };
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
public class A244651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244651Inst Instance=new A244651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244652
{
public static readonly BigInteger[] Value={ 1L,19L,262L,3322L,41455L,520165L,6602716L,84860884L,1103478733L,14500102087L,192309166018L,2571407785918L,34631087423419L,469382779109305L,6398055968407480L,87653105740545976L,1206315271455768505L,16669999282643795899UL,BigInteger.Parse("231219555870655381438"),BigInteger.Parse("3217973871571202211778") };
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
public class A244652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244652Inst Instance=new A244652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244653
{
public static readonly BigInteger[] Value={ 1L,20L,280L,3521L,42945L,521913L,6379233L,78640740L,978172724L,12270946072L,155139813381L,1975245161155L,25308115539770L,326106155857041L,4223481710794292L,54951230993010196L,717942326681863941L,9415448193554916520UL,BigInteger.Parse("123904268078599269723"),BigInteger.Parse("1635676807214777434793") };
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
public class A244653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244653Inst Instance=new A244653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244654
{
public static readonly BigInteger[] Value={ 1L,34L,889L,22344L,568750L,14812084L,394432598L,10708188328L,295488284471L,8266624187654L,233974149056711L,6688412821905136L,192840384283521996L,5601534217892577384L,BigInteger.Parse("163776154208030704124"),BigInteger.Parse("4816121399286395128048"),BigInteger.Parse("142353930553713780303773"),BigInteger.Parse("4226997830260963262597162") };
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
public class A244654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244654Inst Instance=new A244654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244655
{
public static readonly long[] Value={ 1L,5L,27L,496L,4996L,49996L,499996L,4999996L,49999996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244655Inst : IEnumerable<long>
{
public static readonly long[] Value=A244655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244655.Bytes);
public long this[int i]=>Value[i];

public static A244655Inst Instance=new A244655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244656
{
public static readonly long[] Value={ 2L,2L,6L,12L,60L,60L,420L,840L,2520L,2520L,55440L,55440L,360360L,360360L,360360L,2162160L,85765680L,85765680L,33522128640L,33522128640L,33522128640L,33522128640L,19275223968000L,19275223968000L,19275223968000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244656Inst : IEnumerable<long>
{
public static readonly long[] Value=A244656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244656.Bytes);
public long this[int i]=>Value[i];

public static A244656Inst Instance=new A244656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244657
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,3L,1L,1L,0L,1L,4L,3L,1L,1L,0L,1L,9L,6L,3L,1L,1L,0L,1L,13L,13L,6L,3L,1L,1L,0L,1L,26L,25L,15L,6L,3L,1L,1L,0L,1L,42L,55L,29L,15L,6L,3L,1L,1L,0L,1L,81L,107L,68L,31L,15L,6L,3L,1L,1L,0L,1L,138L,224L,140L,72L,31L,15L,6L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244657Inst : IEnumerable<long>
{
public static readonly long[] Value=A244657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244657.Bytes);
public long this[int i]=>Value[i];

public static A244657Inst Instance=new A244657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244658
{
public static readonly long[] Value={ -1L,1L,2L,-1L,1L,2L,0L,4L,-1L,1L,2L,3L,0L,0L,6L,-1L,1L,2L,0L,4L,0L,0L,0L,8L,-1L,1L,2L,0L,0L,5L,0L,0L,0L,0L,10L,-1L,1L,2L,3L,4L,0L,6L,0L,0L,0L,0L,0L,12L,-1L,1L,2L,0L,0L,0L,0L,7L,0L,0L,0L,0L,0L,0L,14L,-1L,1L,2L,0L,4L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,16L,-1L,1L,2L,3L,0L,0L,6L,0L,0L,9L,0L,0L,0L,0L,0L,0L,0L,0L,18L,-1L,1L,2L,0L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244658Inst : IEnumerable<long>
{
public static readonly long[] Value=A244658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244658.Bytes);
public long this[int i]=>Value[i];

public static A244658Inst Instance=new A244658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244659
{
public static readonly long[] Value={ 9L,7L,3L,0L,3L,9L,7L,7L,6L,7L,7L,1L,7L,8L,1L,9L,9L,4L,2L,5L,4L,4L,9L,1L,2L,8L,1L,1L,7L,3L,6L,4L,6L,8L,1L,1L,0L,7L,6L,3L,4L,3L,9L,6L,3L,4L,7L,9L,0L,8L,2L,4L,2L,7L,3L,7L,6L,3L,0L,9L,0L,2L,1L,6L,3L,2L,5L,9L,7L,1L,0L,1L,8L,6L,4L,1L,5L,1L,6L,3L,4L,2L,9L,5L,2L,0L,4L,0L,4L,2L,0L,7L,6L,2L,1L,3L,8L,7L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244659Inst : IEnumerable<long>
{
public static readonly long[] Value=A244659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244659.Bytes);
public long this[int i]=>Value[i];

public static A244659Inst Instance=new A244659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244660
{
public static readonly long[] Value={ 11142L,11553L,14088L,16713L,18801L,22284L,23097L,23718L,26787L,28818L,323589L,327939L,328992L,416103L,438357L,459069L,502149L,595194L,617928L,647178L,656457L,665853L,677019L,682230L,747099L,767748L,775782L,799233L,813861L,832986L,847266L,855897L,858648L,862014L,924366L,970767L,10174023L,10240146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244660Inst : IEnumerable<long>
{
public static readonly long[] Value=A244660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244660.Bytes);
public long this[int i]=>Value[i];

public static A244660Inst Instance=new A244660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244661
{
public static readonly long[] Value={ 149L,298L,596L,646L,745L,1192L,1490L,1615L,2119L,2584L,2980L,3109L,3725L,3878L,5960L,6218L,6357L,6460L,7106L,7294L,7450L,8476L,9262L,9868L,10941L,11627L,11634L,11920L,12436L,14535L,14900L,15049L,15545L,16150L,18625L,21190L,22718L,23256L,23902L,24872L,24915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244661Inst : IEnumerable<long>
{
public static readonly long[] Value=A244661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244661.Bytes);
public long this[int i]=>Value[i];

public static A244661Inst Instance=new A244661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244662
{
public static readonly long[] Value={ 7L,0L,4L,7L,5L,3L,4L,5L,1L,7L,0L,5L,9L,4L,7L,8L,8L,4L,1L,2L,2L,5L,5L,8L,1L,9L,7L,5L,9L,1L,8L,9L,8L,8L,1L,8L,5L,2L,1L,5L,9L,9L,7L,6L,4L,5L,4L,9L,2L,3L,5L,8L,3L,1L,6L,1L,7L,4L,4L,5L,4L,8L,8L,3L,4L,1L,3L,6L,2L,8L,4L,6L,3L,9L,0L,3L,1L,8L,8L,4L,4L,4L,6L,0L,6L,3L,6L,4L,9L,2L,5L,3L,5L,2L,2L,3L,0L,2L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244662Inst : IEnumerable<long>
{
public static readonly long[] Value=A244662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244662.Bytes);
public long this[int i]=>Value[i];

public static A244662Inst Instance=new A244662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244663
{
public static readonly BigInteger[] Value={ 111L,10111L,1001111L,100011111L,10000111111L,1000001111111L,100000011111111L,10000000111111111L,1000000001111111111L,BigInteger.Parse("100000000011111111111"),BigInteger.Parse("10000000000111111111111"),BigInteger.Parse("1000000000001111111111111"),BigInteger.Parse("100000000000011111111111111"),BigInteger.Parse("10000000000000111111111111111") };
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
public class A244663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244663Inst Instance=new A244663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244664
{
public static readonly long[] Value={ 1L,8L,9L,4L,0L,6L,5L,6L,5L,8L,9L,9L,4L,4L,9L,1L,8L,3L,5L,1L,5L,3L,0L,0L,6L,4L,6L,8L,9L,4L,7L,0L,4L,3L,8L,2L,9L,8L,5L,5L,8L,1L,4L,1L,6L,5L,8L,5L,7L,7L,7L,2L,0L,8L,8L,4L,4L,5L,2L,0L,8L,3L,7L,7L,0L,2L,7L,2L,1L,1L,0L,7L,8L,3L,2L,7L,1L,9L,5L,4L,8L,1L,4L,7L,4L,5L,9L,1L,8L,6L,2L,8L,9L,7L,9L,7L,4L,8L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244664Inst : IEnumerable<long>
{
public static readonly long[] Value=A244664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244664.Bytes);
public long this[int i]=>Value[i];

public static A244664Inst Instance=new A244664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244665
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,4L,1L,9L,3L,0L,2L,0L,9L,0L,4L,1L,6L,8L,6L,8L,1L,4L,1L,0L,1L,5L,0L,4L,2L,9L,8L,9L,5L,4L,1L,7L,7L,5L,4L,2L,7L,7L,6L,4L,4L,7L,8L,9L,8L,3L,7L,1L,1L,1L,7L,9L,8L,6L,9L,2L,1L,4L,1L,2L,9L,5L,1L,4L,5L,8L,0L,1L,9L,5L,1L,6L,6L,5L,5L,9L,9L,9L,9L,2L,4L,4L,8L,3L,5L,3L,8L,2L,2L,8L,5L,2L,6L,3L,2L,5L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244665Inst : IEnumerable<long>
{
public static readonly long[] Value=A244665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244665.Bytes);
public long this[int i]=>Value[i];

public static A244665Inst Instance=new A244665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244666
{
public static readonly long[] Value={ 1L,2L,3L,9L,21L,33L,81L,261L,897L,1334L,1364L,2974L,4364L,14282L,26937L,46593L,64665L,74918L,79833L,92685L,145215L,147454L,161001L,162602L,166934L,289454L,347738L,383594L,422073L,430137L,440013L,443402L,445874L,621027L,649154L,655005L,1174305L,1187361L,1670955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244666Inst : IEnumerable<long>
{
public static readonly long[] Value=A244666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244666.Bytes);
public long this[int i]=>Value[i];

public static A244666Inst Instance=new A244666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244667
{
public static readonly long[] Value={ 9L,7L,5L,4L,2L,6L,2L,5L,1L,3L,8L,7L,2L,5L,7L,0L,5L,6L,5L,6L,8L,2L,3L,2L,6L,5L,8L,9L,9L,1L,2L,8L,8L,1L,8L,3L,2L,5L,1L,0L,2L,5L,8L,3L,6L,2L,9L,2L,4L,4L,8L,0L,2L,9L,8L,5L,0L,2L,2L,6L,7L,3L,6L,1L,3L,3L,3L,2L,4L,1L,9L,5L,7L,5L,4L,3L,7L,1L,5L,3L,4L,1L,9L,0L,2L,7L,0L,7L,6L,7L,1L,7L,0L,0L,2L,4L,9L,6L,3L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244667Inst : IEnumerable<long>
{
public static readonly long[] Value=A244667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244667.Bytes);
public long this[int i]=>Value[i];

public static A244667Inst Instance=new A244667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244668
{
public static readonly long[] Value={ 1L,2L,3L,8L,5L,3L,7L,64L,27L,50L,11L,432L,13L,49L,75L,1024L,17L,1944L,19L,4000L,441L,121L,23L,27648L,125L,338L,729L,392L,29L,11250L,31L,32768L,363L,578L,1225L,10077696L,37L,361L,1521L,256000L,41L,64827L,43L,21296L,30375L,529L,47L,63700992L,343L,125000L,289L,70304L,53L,354294L,3025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244668Inst : IEnumerable<long>
{
public static readonly long[] Value=A244668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244668.Bytes);
public long this[int i]=>Value[i];

public static A244668Inst Instance=new A244668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244669
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,1L,8L,15L,13L,9L,12L,7L,14L,6L,8L,31L,18L,13L,20L,21L,32L,9L,24L,5L,31L,21L,40L,1L,30L,1L,32L,63L,16L,27L,48L,91L,38L,15L,56L,9L,42L,2L,44L,21L,26L,18L,48L,31L,57L,93L,8L,49L,54L,5L,72L,15L,80L,45L,60L,7L,62L,24L,104L,127L,84L,1L,68L,63L,32L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244669Inst : IEnumerable<long>
{
public static readonly long[] Value=A244669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244669.Bytes);
public long this[int i]=>Value[i];

public static A244669Inst Instance=new A244669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244670
{
public static readonly BigInteger[] Value={ 1L,3L,392L,11250L,131769L,1568294784L,501126L,119439360000000L,6566468639062500L,39226324511250000L,15780962L,162778775259375000L,2966827112704L,BigInteger.Parse("22417760034702144000000000000"),1801703513076518898L,30261936128L,3531477204506250000L,5876813016539072244L };
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
public class A244670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A244670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A244670Inst Instance=new A244670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244671
{
public static readonly long[] Value={ 1L,3L,5L,6L,10L,11L,12L,13L,14L,15L,20L,22L,24L,26L,28L,29L,30L,31L,32L,48L,49L,55L,56L,60L,61L,67L,68L,72L,89L,93L,97L,101L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,113L,114L,115L,116L,141L,161L,162L,163L,164L,165L,166L,175L,188L,189L,190L,191L,222L,269L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244671Inst : IEnumerable<long>
{
public static readonly long[] Value=A244671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244671.Bytes);
public long this[int i]=>Value[i];

public static A244671Inst Instance=new A244671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244672
{
public static readonly long[] Value={ 1L,4L,9L,15L,25L,36L,48L,61L,75L,90L,110L,132L,156L,182L,210L,239L,269L,300L,332L,380L,429L,484L,540L,600L,661L,728L,796L,868L,957L,1050L,1147L,1248L,1350L,1453L,1557L,1662L,1768L,1875L,1983L,2092L,2202L,2313L,2425L,2538L,2652L,2767L,2883L,3024L,3185L,3347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244672Inst : IEnumerable<long>
{
public static readonly long[] Value=A244672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244672.Bytes);
public long this[int i]=>Value[i];

public static A244672Inst Instance=new A244672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244673
{
public static readonly long[] Value={ 1L,2L,3L,4L,20L,260L,740L,2132L,2180L,5252L,43364L,49268L,49737L,80660L,130052L,293620L,542852L,661412L,717027L,865460L,1564180L,2185220L,2192132L,2816372L,3784916L,4377620L,4427540L,5722004L,6307652L,6919460L,8765252L,9084452L,9498260L,9723611L,11346260L,12208820L,12220132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244673Inst : IEnumerable<long>
{
public static readonly long[] Value=A244673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244673.Bytes);
public long this[int i]=>Value[i];

public static A244673Inst Instance=new A244673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244674
{
public static readonly long[] Value={ 7L,9L,1L,6L,1L,1L,5L,3L,1L,5L,2L,4L,3L,4L,2L,1L,1L,7L,1L,6L,6L,1L,7L,6L,9L,2L,7L,4L,2L,0L,2L,0L,2L,0L,6L,5L,5L,6L,9L,9L,7L,2L,2L,3L,8L,3L,3L,5L,0L,1L,6L,8L,7L,6L,9L,6L,2L,9L,0L,0L,4L,5L,4L,2L,8L,8L,2L,3L,2L,5L,8L,5L,0L,2L,7L,4L,2L,0L,0L,3L,9L,5L,4L,9L,1L,6L,4L,8L,6L,7L,5L,3L,8L,8L,0L,6L,1L,7L,2L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244674Inst : IEnumerable<long>
{
public static readonly long[] Value=A244674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244674.Bytes);
public long this[int i]=>Value[i];

public static A244674Inst Instance=new A244674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244675
{
public static readonly long[] Value={ 1L,7L,7L,5L,8L,6L,8L,8L,4L,2L,2L,6L,5L,9L,1L,1L,6L,8L,8L,2L,1L,0L,5L,2L,5L,5L,5L,4L,3L,3L,8L,0L,5L,4L,5L,2L,2L,3L,0L,0L,4L,1L,5L,0L,9L,1L,1L,0L,9L,4L,0L,7L,2L,3L,9L,4L,6L,6L,7L,3L,4L,6L,8L,3L,2L,8L,4L,5L,2L,8L,6L,1L,8L,3L,5L,5L,2L,7L,1L,8L,1L,7L,4L,5L,4L,7L,0L,9L,7L,8L,9L,8L,5L,2L,4L,5L,3L,8L,3L,9L,3L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244675Inst : IEnumerable<long>
{
public static readonly long[] Value=A244675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244675.Bytes);
public long this[int i]=>Value[i];

public static A244675Inst Instance=new A244675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244676
{
public static readonly long[] Value={ 0L,2L,2L,8L,9L,1L,2L,6L,7L,8L,8L,2L,2L,4L,0L,7L,4L,9L,1L,3L,7L,7L,4L,3L,6L,4L,0L,7L,1L,9L,9L,7L,7L,4L,3L,7L,4L,6L,5L,1L,1L,3L,5L,9L,0L,1L,5L,1L,9L,0L,2L,7L,5L,2L,1L,6L,3L,9L,7L,9L,9L,3L,4L,0L,1L,9L,2L,2L,2L,5L,2L,1L,7L,1L,8L,0L,9L,7L,2L,4L,1L,0L,9L,6L,3L,1L,3L,6L,2L,7L,8L,0L,9L,2L,7L,5L,0L,3L,7L,7L,1L,7L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244676Inst : IEnumerable<long>
{
public static readonly long[] Value=A244676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244676.Bytes);
public long this[int i]=>Value[i];

public static A244676Inst Instance=new A244676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244677
{
public static readonly long[] Value={ 1L,2L,0L,1L,1L,4L,8L,9L,1L,1L,6L,8L,2L,4L,8L,3L,6L,0L,4L,9L,5L,6L,6L,1L,7L,4L,1L,9L,0L,1L,1L,1L,7L,1L,4L,7L,6L,1L,6L,6L,7L,1L,0L,9L,0L,2L,3L,5L,5L,2L,7L,4L,2L,3L,1L,6L,1L,3L,5L,1L,2L,3L,0L,9L,5L,4L,5L,1L,0L,4L,1L,6L,7L,5L,6L,4L,6L,6L,3L,5L,7L,6L,9L,0L,0L,7L,6L,8L,5L,8L,3L,9L,2L,8L,0L,3L,1L,9L,8L,0L,0L,3L,0L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244677Inst : IEnumerable<long>
{
public static readonly long[] Value=A244677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244677.Bytes);
public long this[int i]=>Value[i];

public static A244677Inst Instance=new A244677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244678
{
public static readonly long[] Value={ 1L,1L,2L,7L,5L,1L,2L,6L,3L,4L,3L,6L,7L,6L,0L,1L,1L,1L,5L,1L,2L,1L,1L,2L,1L,4L,9L,3L,8L,0L,8L,4L,3L,9L,8L,5L,6L,0L,0L,6L,7L,5L,2L,7L,6L,2L,6L,9L,3L,2L,0L,4L,1L,1L,4L,1L,2L,1L,1L,3L,3L,0L,1L,1L,2L,5L,0L,1L,1L,3L,7L,2L,1L,1L,6L,0L,6L,2L,2L,1L,2L,1L,2L,2L,7L,5L,8L,2L,2L,4L,8L,6L,2L,2L,4L,1L,6L,3L,3L,4L,4L,7L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244678Inst : IEnumerable<long>
{
public static readonly long[] Value=A244678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244678.Bytes);
public long this[int i]=>Value[i];

public static A244678Inst Instance=new A244678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244679
{
public static readonly long[] Value={ 1L,3L,1L,0L,3L,0L,1L,6L,1L,1L,3L,1L,2L,3L,2L,3L,7L,4L,4L,5L,5L,6L,7L,7L,7L,3L,9L,9L,7L,1L,2L,2L,5L,3L,6L,4L,5L,6L,2L,7L,7L,9L,0L,1L,1L,2L,0L,4L,7L,6L,2L,8L,5L,0L,6L,2L,5L,4L,2L,7L,7L,9L,0L,2L,1L,4L,0L,7L,7L,0L,2L,2L,5L,5L,6L,8L,5L,1L,2L,4L,7L,7L,0L,1L,1L,4L,0L,8L,7L,1L,2L,5L,5L,8L,6L,2L,5L,6L,2L,0L,0L,4L,0L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244679Inst : IEnumerable<long>
{
public static readonly long[] Value=A244679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244679.Bytes);
public long this[int i]=>Value[i];

public static A244679Inst Instance=new A244679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244680
{
public static readonly long[] Value={ 1L,1L,4L,7L,1L,6L,2L,9L,7L,4L,6L,7L,7L,2L,0L,6L,9L,1L,5L,0L,2L,2L,1L,7L,3L,2L,9L,7L,2L,3L,8L,9L,9L,4L,8L,5L,4L,5L,0L,3L,7L,6L,3L,4L,8L,8L,7L,7L,7L,9L,0L,4L,3L,1L,1L,1L,3L,4L,2L,1L,3L,2L,5L,4L,1L,5L,1L,6L,6L,1L,7L,0L,7L,9L,1L,0L,9L,8L,1L,2L,2L,8L,9L,4L,2L,5L,7L,0L,6L,2L,8L,6L,1L,9L,3L,1L,5L,2L,2L,3L,4L,4L,3L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244680Inst : IEnumerable<long>
{
public static readonly long[] Value=A244680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244680.Bytes);
public long this[int i]=>Value[i];

public static A244680Inst Instance=new A244680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A244681
{
public static readonly long[] Value={ 1L,4L,2L,2L,5L,5L,4L,1L,9L,1L,1L,4L,2L,2L,3L,3L,3L,6L,4L,5L,3L,6L,6L,4L,7L,8L,9L,1L,4L,1L,1L,1L,3L,5L,4L,1L,4L,3L,7L,1L,7L,4L,0L,2L,2L,9L,3L,2L,9L,6L,7L,2L,8L,7L,1L,3L,9L,1L,6L,3L,2L,8L,1L,4L,7L,8L,6L,4L,4L,2L,1L,5L,3L,8L,7L,5L,4L,8L,3L,6L,7L,1L,9L,7L,2L,8L,6L,7L,9L,7L,3L,8L,8L,0L,0L,9L,9L,6L,8L,0L,0L,2L,1L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A244681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A244681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A244681Inst : IEnumerable<long>
{
public static readonly long[] Value=A244681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A244681.Bytes);
public long this[int i]=>Value[i];

public static A244681Inst Instance=new A244681Inst();

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