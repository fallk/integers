using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A186280
{
public static readonly long[] Value={ 41L,47L,89L,131L,167L,233L,257L,269L,293L,311L,317L,359L,401L,431L,449L,521L,593L,617L,647L,653L,701L,773L,797L,809L,941L,953L,971L,977L,983L,1097L,1151L,1187L,1229L,1259L,1283L,1319L,1409L,1427L,1481L,1493L,1571L,1583L,1607L,1619L,1667L,1871L,1877L,1889L,1907L,1913L,1931L,1949L,1979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186280Inst : IEnumerable<long>
{
public static readonly long[] Value=A186280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186280.Bytes);
public long this[int i]=>Value[i];

public static A186280Inst Instance=new A186280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186281
{
public static readonly long[] Value={ 37L,43L,73L,79L,109L,127L,139L,181L,229L,241L,271L,277L,313L,331L,349L,367L,397L,421L,433L,457L,487L,547L,571L,577L,607L,613L,673L,691L,727L,733L,751L,757L,769L,823L,829L,853L,907L,919L,991L,1009L,1063L,1087L,1093L,1117L,1123L,1171L,1231L,1249L,1279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186281Inst : IEnumerable<long>
{
public static readonly long[] Value=A186281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186281.Bytes);
public long this[int i]=>Value[i];

public static A186281Inst Instance=new A186281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186282
{
public static readonly long[] Value={ 1L,1L,0L,6L,7L,6L,6L,7L,2L,5L,2L,3L,0L,0L,7L,1L,1L,8L,6L,2L,9L,1L,9L,7L,5L,2L,4L,0L,3L,3L,8L,6L,5L,8L,7L,0L,8L,0L,5L,4L,8L,8L,6L,7L,1L,8L,6L,5L,1L,6L,2L,4L,0L,5L,4L,8L,9L,9L,0L,7L,3L,8L,9L,5L,3L,5L,0L,7L,7L,2L,9L,7L,6L,8L,1L,5L,5L,9L,6L,6L,8L,5L,3L,4L,8L,5L,2L,2L,5L,2L,5L,3L,4L,9L,5L,3L,1L,7L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186282Inst : IEnumerable<long>
{
public static readonly long[] Value=A186282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186282.Bytes);
public long this[int i]=>Value[i];

public static A186282Inst Instance=new A186282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186283
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,18L,2L,8L,1L,2L,1L,630L,3L,2L,1L,7710L,1L,27594L,2L,6L,1L,2L,10L,24L,105L,9728L,1L,8L,1L,69273666L,8L,18166L,1285L,2L,1L,6L,4599L,2L,1L,326L,1L,10L,2L,14L,1L,50L,2L,90462791808L,5L,2L,1L,120L,1615L,16L,2L,568L,1L,3050L,1L,37800705069076950L,11545611L,2L,4L,126L,1L,2891160L,2L,145690999102L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186283Inst : IEnumerable<long>
{
public static readonly long[] Value=A186283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186283.Bytes);
public long this[int i]=>Value[i];

public static A186283Inst Instance=new A186283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186316
{
public static readonly long[] Value={ 2L,4L,6L,9L,11L,14L,16L,18L,21L,23L,26L,28L,31L,33L,35L,38L,40L,43L,45L,47L,50L,52L,55L,57L,60L,62L,64L,67L,69L,72L,74L,76L,79L,81L,84L,86L,88L,91L,93L,96L,98L,101L,103L,105L,108L,110L,113L,115L,117L,120L,122L,125L,127L,130L,132L,134L,137L,139L,142L,144L,146L,149L,151L,154L,156L,158L,161L,163L,166L,168L,171L,173L,175L,178L,180L,183L,185L,187L,190L,192L,195L,197L,200L,202L,204L,207L,209L,212L,214L,216L,219L,221L,224L,226L,228L,231L,233L,236L,238L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186316Inst : IEnumerable<long>
{
public static readonly long[] Value=A186316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186316.Bytes);
public long this[int i]=>Value[i];

public static A186316Inst Instance=new A186316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186317
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,12L,13L,15L,17L,19L,20L,22L,24L,25L,27L,29L,30L,32L,34L,36L,37L,39L,41L,42L,44L,46L,48L,49L,51L,53L,54L,56L,58L,60L,61L,63L,65L,66L,68L,70L,71L,73L,75L,77L,78L,80L,82L,83L,85L,87L,89L,90L,92L,94L,95L,97L,99L,100L,102L,104L,106L,107L,109L,111L,112L,114L,116L,118L,119L,121L,123L,124L,126L,128L,129L,131L,133L,135L,136L,138L,140L,141L,143L,145L,147L,148L,150L,152L,153L,155L,157L,159L,160L,162L,164L,165L,167L,169L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186317Inst : IEnumerable<long>
{
public static readonly long[] Value=A186317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186317.Bytes);
public long this[int i]=>Value[i];

public static A186317Inst Instance=new A186317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186318
{
public static readonly long[] Value={ 1L,4L,6L,9L,11L,14L,16L,18L,21L,23L,26L,28L,31L,33L,35L,38L,40L,43L,45L,47L,50L,52L,55L,57L,59L,62L,64L,67L,69L,72L,74L,76L,79L,81L,84L,86L,88L,91L,93L,96L,98L,101L,103L,105L,108L,110L,113L,115L,117L,120L,122L,125L,127L,130L,132L,134L,137L,139L,142L,144L,146L,149L,151L,154L,156L,158L,161L,163L,166L,168L,171L,173L,175L,178L,180L,183L,185L,187L,190L,192L,195L,197L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186318Inst : IEnumerable<long>
{
public static readonly long[] Value=A186318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186318.Bytes);
public long this[int i]=>Value[i];

public static A186318Inst Instance=new A186318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186319
{
public static readonly long[] Value={ 35L,50L,52L,56L,68L,71L,72L,75L,79L,92L,94L,98L,119L,123L,125L,127L,129L,131L,133L,135L,141L,143L,149L,150L,152L,156L,165L,181L,183L,185L,187L,193L,195L,197L,199L,203L,217L,219L,257L,259L,261L,263L,267L,269L,279L,281L,285L,293L,351L,355L,357L,363L,369L,453L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186319Inst : IEnumerable<long>
{
public static readonly long[] Value=A186319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186319.Bytes);
public long this[int i]=>Value[i];

public static A186319Inst Instance=new A186319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186320
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,10L,11L,13L,14L,16L,18L,19L,21L,23L,24L,26L,28L,29L,31L,32L,34L,36L,37L,39L,41L,42L,44L,46L,47L,49L,50L,52L,54L,55L,57L,59L,60L,62L,63L,65L,67L,68L,70L,72L,73L,75L,77L,78L,80L,81L,83L,85L,86L,88L,90L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,108L,109L,111L,112L,114L,116L,117L,119L,121L,122L,124L,125L,127L,129L,130L,132L,134L,135L,137L,139L,140L,142L,143L,145L,147L,148L,150L,152L,153L,155L,157L,158L,160L,161L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186320Inst : IEnumerable<long>
{
public static readonly long[] Value=A186320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186320.Bytes);
public long this[int i]=>Value[i];

public static A186320Inst Instance=new A186320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186321
{
public static readonly long[] Value={ 2L,4L,7L,9L,12L,15L,17L,20L,22L,25L,27L,30L,33L,35L,38L,40L,43L,45L,48L,51L,53L,56L,58L,61L,64L,66L,69L,71L,74L,76L,79L,82L,84L,87L,89L,92L,95L,97L,100L,102L,105L,107L,110L,113L,115L,118L,120L,123L,126L,128L,131L,133L,136L,138L,141L,144L,146L,149L,151L,154L,156L,159L,162L,164L,167L,169L,172L,175L,177L,180L,182L,185L,187L,190L,193L,195L,198L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186321Inst : IEnumerable<long>
{
public static readonly long[] Value=A186321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186321.Bytes);
public long this[int i]=>Value[i];

public static A186321Inst Instance=new A186321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186322
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,13L,15L,16L,18L,19L,21L,23L,24L,26L,28L,29L,31L,32L,34L,36L,37L,39L,41L,42L,44L,46L,47L,49L,50L,52L,54L,55L,57L,59L,60L,62L,63L,65L,67L,68L,70L,72L,73L,75L,77L,78L,80L,81L,83L,85L,86L,88L,90L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,108L,109L,111L,112L,114L,116L,117L,119L,121L,122L,124L,126L,127L,129L,130L,132L,134L,135L,137L,139L,140L,142L,143L,145L,147L,148L,150L,152L,153L,155L,157L,158L,160L,161L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186322Inst : IEnumerable<long>
{
public static readonly long[] Value=A186322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186322.Bytes);
public long this[int i]=>Value[i];

public static A186322Inst Instance=new A186322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186323
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,14L,17L,20L,22L,25L,27L,30L,33L,35L,38L,40L,43L,45L,48L,51L,53L,56L,58L,61L,64L,66L,69L,71L,74L,76L,79L,82L,84L,87L,89L,92L,95L,97L,100L,102L,105L,107L,110L,113L,115L,118L,120L,123L,125L,128L,131L,133L,136L,138L,141L,144L,146L,149L,151L,154L,156L,159L,162L,164L,167L,169L,172L,175L,177L,180L,182L,185L,187L,190L,193L,195L,198L,200L,203L,206L,208L,211L,213L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186323Inst : IEnumerable<long>
{
public static readonly long[] Value=A186323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186323.Bytes);
public long this[int i]=>Value[i];

public static A186323Inst Instance=new A186323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186324
{
public static readonly long[] Value={ 1L,3L,5L,6L,8L,9L,11L,12L,14L,16L,17L,19L,20L,22L,23L,25L,27L,28L,30L,31L,33L,35L,36L,38L,39L,41L,42L,44L,46L,47L,49L,50L,52L,53L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,72L,74L,76L,77L,79L,80L,82L,83L,85L,87L,88L,90L,91L,93L,94L,96L,98L,99L,101L,102L,104L,106L,107L,109L,110L,112L,113L,115L,117L,118L,120L,121L,123L,124L,126L,128L,129L,131L,132L,134L,135L,137L,139L,140L,142L,143L,145L,147L,148L,150L,151L,153L,154L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186324Inst : IEnumerable<long>
{
public static readonly long[] Value=A186324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186324.Bytes);
public long this[int i]=>Value[i];

public static A186324Inst Instance=new A186324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186325
{
public static readonly long[] Value={ 2L,4L,7L,10L,13L,15L,18L,21L,24L,26L,29L,32L,34L,37L,40L,43L,45L,48L,51L,54L,56L,59L,62L,64L,67L,70L,73L,75L,78L,81L,84L,86L,89L,92L,95L,97L,100L,103L,105L,108L,111L,114L,116L,119L,122L,125L,127L,130L,133L,136L,138L,141L,144L,146L,149L,152L,155L,157L,160L,163L,166L,168L,171L,174L,177L,179L,182L,185L,187L,190L,193L,196L,198L,201L,204L,207L,209L,212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186325Inst : IEnumerable<long>
{
public static readonly long[] Value=A186325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186325.Bytes);
public long this[int i]=>Value[i];

public static A186325Inst Instance=new A186325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186326
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,9L,11L,12L,14L,16L,17L,19L,20L,22L,24L,25L,27L,28L,30L,31L,33L,35L,36L,38L,39L,41L,42L,44L,46L,47L,49L,50L,52L,53L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,72L,74L,76L,77L,79L,80L,82L,83L,85L,87L,88L,90L,91L,93L,94L,96L,98L,99L,101L,102L,104L,106L,107L,109L,110L,112L,113L,115L,117L,118L,120L,121L,123L,124L,126L,128L,129L,131L,132L,134L,135L,137L,139L,140L,142L,143L,145L,147L,148L,150L,151L,153L,154L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186326Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186326.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186326Inst : IEnumerable<long>
{
public static readonly long[] Value=A186326.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186326.Bytes);
public long this[int i]=>Value[i];

public static A186326Inst Instance=new A186326Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186327
{
public static readonly long[] Value={ 1L,4L,7L,10L,13L,15L,18L,21L,23L,26L,29L,32L,34L,37L,40L,43L,45L,48L,51L,54L,56L,59L,62L,64L,67L,70L,73L,75L,78L,81L,84L,86L,89L,92L,95L,97L,100L,103L,105L,108L,111L,114L,116L,119L,122L,125L,127L,130L,133L,136L,138L,141L,144L,146L,149L,152L,155L,157L,160L,163L,166L,168L,171L,174L,177L,179L,182L,185L,187L,190L,193L,196L,198L,201L,204L,207L,209L,212L,215L,217L,220L,223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186327Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186327.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186327Inst : IEnumerable<long>
{
public static readonly long[] Value=A186327.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186327.Bytes);
public long this[int i]=>Value[i];

public static A186327Inst Instance=new A186327Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186328
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,15L,16L,18L,20L,22L,24L,26L,28L,29L,31L,33L,35L,37L,39L,41L,43L,44L,46L,48L,50L,52L,54L,56L,57L,59L,61L,63L,65L,67L,69L,71L,72L,74L,76L,78L,80L,82L,84L,85L,87L,89L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L,112L,113L,115L,117L,119L,121L,123L,125L,126L,128L,130L,132L,134L,136L,138L,140L,141L,143L,145L,147L,149L,151L,153L,154L,156L,158L,160L,162L,164L,166L,168L,169L,171L,173L,175L,177L,179L,181L,182L,184L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186328Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186328.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186328Inst : IEnumerable<long>
{
public static readonly long[] Value=A186328.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186328.Bytes);
public long this[int i]=>Value[i];

public static A186328Inst Instance=new A186328Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186329
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,17L,19L,21L,23L,25L,27L,30L,32L,34L,36L,38L,40L,42L,45L,47L,49L,51L,53L,55L,58L,60L,62L,64L,66L,68L,70L,73L,75L,77L,79L,81L,83L,86L,88L,90L,92L,94L,96L,98L,101L,103L,105L,107L,109L,111L,114L,116L,118L,120L,122L,124L,127L,129L,131L,133L,135L,137L,139L,142L,144L,146L,148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186329Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186329.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186329Inst : IEnumerable<long>
{
public static readonly long[] Value=A186329.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186329.Bytes);
public long this[int i]=>Value[i];

public static A186329Inst Instance=new A186329Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186330
{
public static readonly long[] Value={ 2L,3L,5L,7L,9L,11L,13L,15L,16L,18L,20L,22L,24L,26L,28L,29L,31L,33L,35L,37L,39L,41L,43L,44L,46L,48L,50L,52L,54L,56L,57L,59L,61L,63L,65L,67L,69L,71L,72L,74L,76L,78L,80L,82L,84L,85L,87L,89L,91L,93L,95L,97L,99L,100L,102L,104L,106L,108L,110L,112L,113L,115L,117L,119L,121L,123L,125L,126L,128L,130L,132L,134L,136L,138L,140L,141L,143L,145L,147L,149L,151L,153L,154L,156L,158L,160L,162L,164L,166L,168L,169L,171L,173L,175L,177L,179L,181L,182L,184L,186L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186330Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186330.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186330Inst : IEnumerable<long>
{
public static readonly long[] Value=A186330.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186330.Bytes);
public long this[int i]=>Value[i];

public static A186330Inst Instance=new A186330Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186331
{
public static readonly long[] Value={ 1L,4L,6L,8L,10L,12L,14L,17L,19L,21L,23L,25L,27L,30L,32L,34L,36L,38L,40L,42L,45L,47L,49L,51L,53L,55L,58L,60L,62L,64L,66L,68L,70L,73L,75L,77L,79L,81L,83L,86L,88L,90L,92L,94L,96L,98L,101L,103L,105L,107L,109L,111L,114L,116L,118L,120L,122L,124L,127L,129L,131L,133L,135L,137L,139L,142L,144L,146L,148L,150L,152L,155L,157L,159L,161L,163L,165L,167L,170L,172L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186331Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186331.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186331Inst : IEnumerable<long>
{
public static readonly long[] Value=A186331.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186331.Bytes);
public long this[int i]=>Value[i];

public static A186331Inst Instance=new A186331Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186364
{
public static readonly BigInteger[] Value={ 1L,0L,1L,1L,5L,15L,71L,341L,1945L,12135L,84091L,635281L,5212085L,46091955L,437198711L,4426839821L,47657861425L,543551916975L,6546911178931L,83039587809961L,1106307936885965L,15445529882517195L,225502102290364751L,3436240674908121701L,BigInteger.Parse("54555087491802061705") };
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
public class A186364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186364Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186364.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186364Inst Instance=new A186364Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186365
{
public static readonly BigInteger[] Value={ 0L,1L,2L,6L,20L,80L,366L,1904L,11080L,71424L,505210L,3891712L,32433180L,290787328L,2791053734L,28556359680L,310264194320L,3567710830592L,43287834157938L,552688817143808L,7407423764750500L,103981459115606016L,1525675236649033822L,BigInteger.Parse("23354749389657604096") };
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
public class A186365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186365Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186365.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186365Inst Instance=new A186365Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186366
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,2L,7L,6L,1L,5L,20L,25L,10L,1L,16L,70L,105L,65L,15L,1L,61L,287L,490L,385L,140L,21L,1L,272L,1356L,2548L,2345L,1120L,266L,28L,1L,1385L,7248L,14698L,15204L,8715L,2772L,462L,36L,1L,7936L,43280L,93420L,105880L,69405L,26985L,6090L,750L,45L,1L,50521L,285571L,649715L,793210L,577225L,260337L,72765L,12210L,1155L,55L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186366Inst : IEnumerable<long>
{
public static readonly long[] Value=A186366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186366.Bytes);
public long this[int i]=>Value[i];

public static A186366Inst Instance=new A186366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186367
{
public static readonly long[] Value={ 1L,3L,10L,38L,165L,812L,4478L,27408L,184529L,1356256L,10809786L,92892928L,856329253L,8430600960L,88292571934L,980197173248L,11499036105537L,142147625652224L,1846872283846922L,25161923756064768L,358706981125488581L,5340498034862030848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186367Inst : IEnumerable<long>
{
public static readonly long[] Value=A186367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186367.Bytes);
public long this[int i]=>Value[i];

public static A186367Inst Instance=new A186367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186368
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,1L,10L,5L,1L,20L,40L,1L,35L,175L,61L,1L,56L,560L,768L,1L,84L,1470L,4996L,1385L,1L,120L,3360L,22720L,24320L,1L,165L,6930L,81730L,214445L,50521L,1L,220L,13200L,248512L,1288320L,1152512L,1L,286L,23595L,665236L,5986695L,12989678L,2702765L,1L,364L,40040L,1610752L,23063040L,98169344L,76477440L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186368Inst : IEnumerable<long>
{
public static readonly long[] Value=A186368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186368.Bytes);
public long this[int i]=>Value[i];

public static A186368Inst Instance=new A186368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186369
{
public static readonly ulong[] Value={ 0L,0L,1L,4L,20L,100L,568L,3480L,23552L,172280L,1369600L,11687996L,107154944L,1046876220L,10891574272L,119977808752L,1397745975296L,17147547551920L,221248695107584L,2992325932512948L,42370119842398208L,626422742409351380L,9659199474524225536UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186369Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A186369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186369.Bytes);
public ulong this[int i]=>Value[i];

public static A186369Inst Instance=new A186369Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186370
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,7L,11L,5L,1L,15L,43L,45L,16L,1L,31L,148L,268L,211L,61L,1L,63L,480L,1344L,1767L,1113L,272L,1L,127L,1509L,6171L,12099L,12477L,6551L,1385L,1L,255L,4661L,26955L,74211L,111645L,94631L,42585L,7936L,1L,511L,14246L,114266L,425976L,878856L,1070906L,770246L,303271L,50521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186370Inst : IEnumerable<long>
{
public static readonly long[] Value=A186370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186370.Bytes);
public long this[int i]=>Value[i];

public static A186370Inst Instance=new A186370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186371
{
public static readonly BigInteger[] Value={ 0L,1L,3L,13L,68L,420L,3000L,24360L,221760L,2237760L,24796800L,299376000L,3911846400L,55005350400L,828193766400L,13294689408000L,226663557120000L,4090405423104000L,77895546753024000L,1561112121913344000L,BigInteger.Parse("32844177110384640000"),BigInteger.Parse("723788347432550400000") };
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
public class A186371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186371Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186371.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186371Inst Instance=new A186371Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186372
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,4L,0L,1L,1L,10L,1L,7L,4L,0L,1L,1L,20L,7L,27L,28L,8L,14L,8L,6L,0L,1L,1L,35L,28L,78L,118L,68L,96L,89L,83L,44L,36L,23L,12L,8L,0L,1L,1L,56L,84L,192L,388L,335L,459L,550L,594L,503L,462L,408L,317L,275L,161L,118L,70L,40L,16L,10L,0L,1L,1L,84L,210L,433L,1093L,1255L,1769L,2511L,3045L,3259L,3455L,3609L,3429L,3420L,2896L,2540L,2084L,1646L,1230L,918L,606L,376L,232L,125L,61L,20L,12L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186372Inst : IEnumerable<long>
{
public static readonly long[] Value=A186372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186372.Bytes);
public long this[int i]=>Value[i];

public static A186372Inst Instance=new A186372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186373
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,3L,3L,14L,9L,1L,77L,38L,5L,497L,198L,25L,3676L,1229L,134L,1L,30677L,8819L,815L,9L,285335L,71825L,5657L,63L,2928846L,654985L,44549L,419L,1L,32903721L,6615932L,394266L,2868L,13L,401739797L,73357572L,3883182L,20932L,117L,5298600772L,886078937L,42174500L,165662L,928L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186373Inst : IEnumerable<long>
{
public static readonly long[] Value=A186373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186373.Bytes);
public long this[int i]=>Value[i];

public static A186373Inst Instance=new A186373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186374
{
public static readonly BigInteger[] Value={ 0L,1L,1L,3L,11L,48L,248L,1500L,10476L,83328L,745344L,7413120L,81187200L,970928640L,12589240320L,175900757760L,2634526944000L,42103369728000L,715107004416000L,12862666543104000L,244249409359872000L,4882687056543744000L,BigInteger.Parse("102496533840691200000") };
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
public class A186374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186374Inst Instance=new A186374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186375
{
public static readonly long[] Value={ 1L,6L,54L,588L,7110L,91476L,1224636L,16849944L,236523078L,3371140740L,48630906324L,708412918824L,10403176168476L,153813188724552L,2287366047735480L,34185974267420208L,513159651195396678L,7732530110414488932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186375Inst : IEnumerable<long>
{
public static readonly long[] Value=A186375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186375.Bytes);
public long this[int i]=>Value[i];

public static A186375Inst Instance=new A186375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186376
{
public static readonly BigInteger[] Value={ 1L,14L,294L,7292L,198310L,5717124L,171485916L,5290989816L,166688596998L,5335746337460L,172951272017524L,5662840724506056L,186960502253087836L,6215612039963043368L,BigInteger.Parse("207865952390729881080"),BigInteger.Parse("6987002286567227550192") };
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
public class A186376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186376Inst Instance=new A186376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186377
{
public static readonly BigInteger[] Value={ 1L,7L,79L,1129L,18559L,333577L,6365089L,126652183L,2598628543L,54577439833L,1167481074529L,25346459683783L,557042221952881L,12368307313680871L,277027947337574911L,6251808554314780009L,BigInteger.Parse("142015508983550880703") };
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
public class A186377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186377Inst Instance=new A186377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186378
{
public static readonly BigInteger[] Value={ 1L,7L,95L,1609L,30271L,606057L,12636689L,271026455L,5934011839L,131978406553L,2971793928145L,67586972435495L,1549805136840625L,35783848365934663L,831089570101489423L,BigInteger.Parse("19400246240227360809"),BigInteger.Parse("454864027237803296703") };
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
public class A186378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186378Inst Instance=new A186378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186379
{
public static readonly long[] Value={ 3L,5L,7L,9L,10L,12L,13L,15L,16L,18L,19L,21L,22L,24L,25L,26L,28L,29L,30L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,46L,47L,48L,49L,51L,52L,53L,54L,56L,57L,58L,59L,61L,62L,63L,64L,65L,67L,68L,69L,70L,71L,73L,74L,75L,76L,77L,79L,80L,81L,82L,83L,84L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186379Inst : IEnumerable<long>
{
public static readonly long[] Value=A186379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186379.Bytes);
public long this[int i]=>Value[i];

public static A186379Inst Instance=new A186379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186428
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,7L,1L,7L,4L,1L,1L,11L,1L,15L,19L,15L,1L,28L,1L,37L,5L,31L,1L,31L,6L,21L,13L,31L,1L,13L,1L,31L,1L,43L,39L,20L,1L,27L,27L,67L,1L,3L,1L,7L,7L,55L,1L,71L,8L,73L,31L,87L,1L,91L,19L,39L,73L,67L,1L,61L,1L,39L,33L,63L,45L,7L,1L,67L,85L,129L,1L,157L,1L,45L,109L,51L,93L,21L,1L,31L,40L,91L,1L,123L,13L,51L,43L,151L,1L,49L,15L,7L,109L,103L,51L,151L,1L,113L,25L,124L,1L,73L,1L,141L,123L,115L,1L,3L,1L,133L,51L,111L,1L,111L,7L,121L,121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186428Inst : IEnumerable<long>
{
public static readonly long[] Value=A186428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186428.Bytes);
public long this[int i]=>Value[i];

public static A186428Inst Instance=new A186428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186429
{
public static readonly long[] Value={ 1L,3L,28L,85L,151L,302L,864L,3197L,4780L,5438L,5815L,6413L,7769L,7985L,11062L,16672L,24805L,27379L,35435L,41718L,45047L,58383L,69835L,70235L,76305L,91178L,95963L,97763L,103173L,111375L,118498L,138405L,158200L,170333L,184132L,191707L,201693L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186429Inst : IEnumerable<long>
{
public static readonly long[] Value=A186429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186429.Bytes);
public long this[int i]=>Value[i];

public static A186429Inst Instance=new A186429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186430
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,12L,12L,1L,1L,2L,12L,2L,1L,1L,120L,120L,120L,120L,1L,1L,2L,120L,20L,120L,2L,1L,1L,252L,252L,2520L,2520L,252L,252L,1L,1L,2L,252L,42L,2520L,42L,252L,2L,1L,1L,240L,240L,5040L,5040L,5040L,5040L,240L,240L,1L,1L,2L,240L,40L,5040L,84L,5040L,40L,240L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186430Inst : IEnumerable<long>
{
public static readonly long[] Value=A186430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186430.Bytes);
public long this[int i]=>Value[i];

public static A186430Inst Instance=new A186430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186431
{
public static readonly long[] Value={ 1L,2L,4L,26L,18L,482L,266L,6050L,3114L,21122L,10730L,22178L,11226L,4455362L,2256338L,343874L,173610L,13643522L,6869842L,690621122L,347772738L,16250361602L,8187307306L,17146915106L,8584448890L,720152334722L,365024665978L,59381983394L,29700003082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186431Inst : IEnumerable<long>
{
public static readonly long[] Value=A186431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186431.Bytes);
public long this[int i]=>Value[i];

public static A186431Inst Instance=new A186431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186432
{
public static readonly long[] Value={ 1L,1L,1L,1L,12L,1L,1L,30L,30L,1L,1L,56L,140L,56L,1L,1L,90L,420L,420L,90L,1L,1L,132L,990L,1848L,990L,132L,1L,1L,182L,2002L,6006L,6006L,2002L,182L,1L,1L,240L,3640L,16016L,25740L,16016L,3640L,240L,1L,1L,306L,6120L,37128L,87516L,87516L,37128L,6120L,306L,1L,1L,380L,9690L,77520L,251940L,369512L,251940L,77520L,9690L,380L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186432Inst : IEnumerable<long>
{
public static readonly long[] Value=A186432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186432.Bytes);
public long this[int i]=>Value[i];

public static A186432Inst Instance=new A186432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186433
{
public static readonly long[] Value={ 1L,-1L,1L,11L,-12L,1L,-301L,330L,-30L,1L,15371L,-16856L,1540L,-56L,1L,-1261501L,1383390L,-126420L,4620L,-90L,1L,151846331L,-166518132L,15217290L,-556248L,10890L,-132L,1L,-25201039501L,27636032242L,-2525525002L,92318226L,-1807806L,22022L,-182L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186433Inst : IEnumerable<long>
{
public static readonly long[] Value=A186433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186433.Bytes);
public long this[int i]=>Value[i];

public static A186433Inst Instance=new A186433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186434
{
public static readonly long[] Value={ 0L,4L,36L,148L,444L,1064L,2200L,4024L,6976L,11284L,17396L,25620L,36812L,51216L,69672L,92656L,121392L,156092L,198364L,248292L,307988L,377816L,459072L,552216L,660704L,784076L,924340L,1082228L,1261132L,1460408L,1684464L,1931800L,2208368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186434Inst : IEnumerable<long>
{
public static readonly long[] Value=A186434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186434.Bytes);
public long this[int i]=>Value[i];

public static A186434Inst Instance=new A186434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186435
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,6L,1L,3L,4L,19L,3L,10L,16L,4L,1L,2L,7L,37L,6L,31L,48L,4L,4L,14L,24L,5L,26L,152L,12L,80L,1L,2L,4L,51L,12L,39L,100L,20L,8L,23L,90L,4L,81L,14L,8L,242L,5L,12L,36L,4L,38L,215L,16L,172L,36L,190L,395L,40L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186435Inst : IEnumerable<long>
{
public static readonly long[] Value=A186435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186435.Bytes);
public long this[int i]=>Value[i];

public static A186435Inst Instance=new A186435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186436
{
public static readonly long[] Value={ 1L,0L,15L,0L,25L,12L,35L,0L,45L,0L,11L,0L,65L,0L,75L,32L,85L,0L,95L,0L,21L,0L,115L,0L,125L,52L,135L,0L,145L,0L,31L,0L,165L,0L,175L,72L,185L,0L,195L,0L,41L,0L,215L,0L,225L,92L,235L,0L,245L,0L,51L,0L,265L,0L,275L,112L,285L,0L,295L,0L,61L,0L,315L,0L,325L,132L,335L,0L,345L,0L,71L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186436Inst : IEnumerable<long>
{
public static readonly long[] Value=A186436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186436.Bytes);
public long this[int i]=>Value[i];

public static A186436Inst Instance=new A186436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186437
{
public static readonly long[] Value={ 0L,1L,1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,4L,5L,5L,5L,4L,5L,5L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186437Inst : IEnumerable<long>
{
public static readonly long[] Value=A186437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186437.Bytes);
public long this[int i]=>Value[i];

public static A186437Inst Instance=new A186437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186438
{
public static readonly long[] Value={ 10L,12L,20L,30L,38L,40L,50L,60L,62L,70L,80L,88L,90L,100L,110L,112L,120L,130L,138L,140L,150L,160L,162L,170L,180L,188L,190L,200L,210L,212L,220L,230L,238L,240L,250L,260L,262L,270L,280L,288L,290L,300L,310L,312L,320L,330L,338L,340L,350L,360L,362L,370L,380L,388L,390L,400L,410L,412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186438Inst : IEnumerable<long>
{
public static readonly long[] Value=A186438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186438.Bytes);
public long this[int i]=>Value[i];

public static A186438Inst Instance=new A186438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186439
{
public static readonly long[] Value={ 38L,100L,200L,300L,400L,462L,500L,538L,600L,700L,800L,900L,962L,1000L,1038L,1100L,1200L,1300L,1400L,1462L,1500L,1538L,1600L,1700L,1800L,1900L,1962L,2000L,2038L,2100L,2200L,2300L,2400L,2462L,2500L,2538L,2600L,2700L,2800L,2900L,2962L,3000L,3038L,3100L,3200L,3300L,3400L,3462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186439Inst : IEnumerable<long>
{
public static readonly long[] Value=A186439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186439.Bytes);
public long this[int i]=>Value[i];

public static A186439Inst Instance=new A186439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186440
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,3L,3L,2L,2L,1L,2L,3L,1L,1L,2L,2L,4L,2L,1L,1L,2L,3L,2L,2L,2L,4L,3L,2L,3L,1L,1L,1L,4L,4L,2L,1L,2L,2L,2L,1L,3L,4L,1L,3L,2L,5L,2L,1L,2L,2L,2L,2L,3L,1L,2L,3L,4L,2L,4L,1L,4L,2L,2L,3L,4L,1L,3L,2L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186440Inst : IEnumerable<long>
{
public static readonly long[] Value=A186440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186440.Bytes);
public long this[int i]=>Value[i];

public static A186440Inst Instance=new A186440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186441
{
public static readonly long[] Value={ 64L,336L,1672L,8320L,39616L,186544L,847520L,3846192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186441Inst : IEnumerable<long>
{
public static readonly long[] Value=A186441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186441.Bytes);
public long this[int i]=>Value[i];

public static A186441Inst Instance=new A186441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186442
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,81L,9L,3L,5L,7L,9L,11L,13L,15L,17L,83L,83L,27L,15L,17L,19L,21L,23L,25L,27L,85L,85L,85L,43L,27L,29L,31L,33L,35L,37L,87L,87L,87L,87L,57L,39L,41L,43L,45L,47L,89L,89L,89L,89L,89L,69L,51L,53L,55L,57L,91L,91L,91L,91L,91L,91L,79L,63L,65L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186442Inst : IEnumerable<long>
{
public static readonly long[] Value=A186442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186442.Bytes);
public long this[int i]=>Value[i];

public static A186442Inst Instance=new A186442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186443
{
public static readonly long[] Value={ 9L,18L,90L,180L,819L,1638L,7461L,14922L,67968L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186443Inst : IEnumerable<long>
{
public static readonly long[] Value=A186443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186443.Bytes);
public long this[int i]=>Value[i];

public static A186443Inst Instance=new A186443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186492
{
public static readonly long[] Value={ 1L,0L,1L,2L,0L,3L,0L,14L,0L,15L,28L,0L,132L,0L,105L,0L,5556L,0L,1500L,0L,945L,1112L,0L,10668L,0L,1995L,0L,10395L,0L,43784L,0L,212940L,0L,304290L,0L,135135L,87568L,0L,1408992L,0L,4533480L,0L,5239080L,0L,2027025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186492Inst : IEnumerable<long>
{
public static readonly long[] Value=A186492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186492.Bytes);
public long this[int i]=>Value[i];

public static A186492Inst Instance=new A186492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186493
{
public static readonly long[] Value={ 2L,4L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,79L,80L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L,93L,94L,95L,96L,97L,98L,99L,100L,101L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,131L,132L,133L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186493Inst : IEnumerable<long>
{
public static readonly long[] Value=A186493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186493.Bytes);
public long this[int i]=>Value[i];

public static A186493Inst Instance=new A186493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186494
{
public static readonly long[] Value={ 1L,3L,5L,8L,12L,16L,21L,26L,32L,39L,46L,54L,62L,71L,81L,91L,102L,113L,125L,138L,151L,165L,179L,194L,210L,226L,243L,260L,278L,297L,316L,336L,356L,377L,399L,421L,444L,467L,491L,516L,541L,567L,593L,620L,648L,676L,705L,734L,764L,795L,826L,858L,890L,923L,957L,991L,1026L,1061L,1097L,1134L,1171L,1209L,1247L,1286L,1326L,1366L,1407L,1448L,1490L,1533L,1576L,1620L,1664L,1709L,1755L,1801L,1848L,1895L,1943L,1992L,2041L,2091L,2141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186494Inst : IEnumerable<long>
{
public static readonly long[] Value=A186494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186494.Bytes);
public long this[int i]=>Value[i];

public static A186494Inst Instance=new A186494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186495
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,10L,12L,13L,14L,15L,17L,18L,19L,21L,22L,23L,24L,25L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,39L,40L,41L,42L,43L,44L,45L,47L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L,84L,85L,86L,87L,88L,89L,90L,92L,93L,94L,95L,96L,97L,98L,99L,100L,102L,103L,104L,105L,106L,107L,108L,109L,110L,111L,112L,114L,115L,116L,117L,118L,119L,120L,121L,122L,123L,124L,126L,127L,128L,129L,130L,131L,132L,133L,134L,135L,136L,138L,139L,140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186495Inst : IEnumerable<long>
{
public static readonly long[] Value=A186495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186495.Bytes);
public long this[int i]=>Value[i];

public static A186495Inst Instance=new A186495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186496
{
public static readonly long[] Value={ 1L,2L,5L,8L,11L,16L,20L,26L,32L,38L,46L,53L,62L,71L,80L,91L,101L,113L,125L,137L,151L,164L,179L,194L,209L,226L,242L,260L,278L,296L,316L,335L,356L,377L,398L,421L,443L,467L,491L,515L,541L,566L,593L,620L,647L,676L,704L,734L,764L,794L,826L,857L,890L,923L,956L,991L,1025L,1061L,1097L,1133L,1171L,1208L,1247L,1286L,1325L,1366L,1406L,1448L,1490L,1532L,1576L,1619L,1664L,1709L,1754L,1801L,1847L,1895L,1943L,1991L,2041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186496Inst : IEnumerable<long>
{
public static readonly long[] Value=A186496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186496.Bytes);
public long this[int i]=>Value[i];

public static A186496Inst Instance=new A186496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186497
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,11L,12L,14L,15L,16L,18L,19L,21L,22L,23L,25L,26L,27L,28L,30L,31L,32L,34L,35L,36L,37L,39L,40L,41L,42L,43L,45L,46L,47L,48L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,63L,64L,65L,66L,67L,69L,70L,71L,72L,73L,74L,76L,77L,78L,79L,80L,81L,82L,84L,85L,86L,87L,88L,89L,91L,92L,93L,94L,95L,96L,97L,99L,100L,101L,102L,103L,104L,105L,106L,108L,109L,110L,111L,112L,113L,114L,116L,117L,118L,119L,120L,121L,122L,123L,125L,126L,127L,128L,129L,130L,131L,132L,133L,135L,136L,137L,138L,139L,140L,141L,142L,144L,145L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186497Inst : IEnumerable<long>
{
public static readonly long[] Value=A186497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186497.Bytes);
public long this[int i]=>Value[i];

public static A186497Inst Instance=new A186497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186498
{
public static readonly long[] Value={ 2L,3L,5L,8L,10L,13L,17L,20L,24L,29L,33L,38L,44L,49L,55L,62L,68L,75L,83L,90L,98L,107L,115L,124L,134L,143L,153L,164L,174L,185L,197L,208L,220L,233L,245L,258L,272L,285L,299L,314L,328L,343L,359L,374L,390L,407L,423L,440L,458L,475L,493L,512L,530L,549L,569L,588L,608L,629L,649L,670L,692L,713L,735L,758L,780L,803L,827L,850L,874L,899L,923L,948L,974L,999L,1025L,1052L,1078L,1105L,1133L,1160L,1188L,1217L,1245L,1274L,1304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186498Inst : IEnumerable<long>
{
public static readonly long[] Value=A186498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186498.Bytes);
public long this[int i]=>Value[i];

public static A186498Inst Instance=new A186498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186499
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,10L,11L,13L,14L,15L,17L,18L,20L,21L,23L,24L,26L,27L,28L,30L,31L,33L,34L,36L,37L,39L,40L,41L,43L,44L,46L,47L,49L,50L,52L,53L,55L,56L,57L,59L,60L,62L,63L,65L,66L,68L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,83L,85L,86L,88L,89L,91L,92L,94L,95L,96L,98L,99L,101L,102L,104L,105L,107L,108L,109L,111L,112L,114L,115L,117L,118L,120L,121L,123L,124L,125L,127L,128L,130L,131L,133L,134L,136L,137L,138L,140L,141L,143L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186499Inst : IEnumerable<long>
{
public static readonly long[] Value=A186499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186499.Bytes);
public long this[int i]=>Value[i];

public static A186499Inst Instance=new A186499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186500
{
public static readonly long[] Value={ 2L,6L,9L,12L,16L,19L,22L,25L,29L,32L,35L,38L,42L,45L,48L,51L,54L,58L,61L,64L,67L,71L,74L,77L,80L,84L,87L,90L,93L,97L,100L,103L,106L,110L,113L,116L,119L,122L,126L,129L,132L,135L,139L,142L,145L,148L,152L,155L,158L,161L,165L,168L,171L,174L,177L,181L,184L,187L,190L,194L,197L,200L,203L,207L,210L,213L,216L,220L,223L,226L,229L,232L,236L,239L,242L,245L,249L,252L,255L,258L,262L,265L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186500Inst : IEnumerable<long>
{
public static readonly long[] Value=A186500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186500.Bytes);
public long this[int i]=>Value[i];

public static A186500Inst Instance=new A186500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186501
{
public static readonly long[] Value={ 2L,5L,5L,5L,6L,0L,4L,6L,1L,2L,1L,0L,0L,8L,2L,0L,6L,1L,5L,2L,5L,1L,4L,5L,4L,2L,6L,5L,4L,7L,1L,6L,6L,8L,8L,2L,5L,1L,6L,6L,6L,2L,4L,5L,5L,4L,6L,7L,7L,0L,0L,8L,2L,6L,5L,7L,4L,4L,4L,7L,7L,9L,0L,5L,1L,9L,4L,6L,9L,4L,0L,9L,1L,0L,5L,5L,6L,7L,9L,2L,3L,8L,0L,7L,8L,5L,3L,5L,0L,3L,1L,4L,6L,9L,5L,3L,6L,8L,2L,1L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186501Inst : IEnumerable<long>
{
public static readonly long[] Value=A186501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186501.Bytes);
public long this[int i]=>Value[i];

public static A186501Inst Instance=new A186501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186502
{
public static readonly long[] Value={ 2L,6L,0L,0L,2L,9L,5L,0L,0L,0L,0L,5L,3L,9L,1L,5L,5L,8L,7L,7L,1L,7L,2L,0L,8L,2L,2L,1L,9L,4L,1L,1L,6L,9L,9L,1L,6L,4L,3L,7L,8L,3L,7L,7L,1L,0L,1L,0L,8L,3L,8L,8L,2L,0L,0L,2L,3L,2L,6L,1L,9L,5L,4L,9L,8L,2L,5L,9L,1L,5L,1L,6L,1L,4L,7L,5L,0L,4L,2L,2L,4L,8L,2L,2L,5L,3L,8L,6L,3L,8L,8L,1L,7L,7L,7L,4L,1L,9L,1L,0L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186502Inst : IEnumerable<long>
{
public static readonly long[] Value=A186502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186502.Bytes);
public long this[int i]=>Value[i];

public static A186502Inst Instance=new A186502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186503
{
public static readonly long[] Value={ 2L,6L,4L,1L,0L,6L,1L,9L,1L,6L,4L,8L,4L,3L,9L,5L,8L,0L,8L,4L,1L,1L,8L,3L,9L,0L,0L,4L,0L,6L,5L,7L,9L,1L,2L,5L,4L,9L,3L,0L,8L,7L,3L,2L,2L,4L,6L,0L,5L,9L,4L,9L,6L,6L,7L,7L,1L,5L,2L,7L,2L,7L,2L,4L,0L,4L,8L,1L,8L,9L,5L,4L,6L,4L,0L,1L,5L,3L,1L,0L,4L,1L,9L,9L,5L,1L,3L,5L,4L,0L,2L,1L,3L,5L,2L,8L,2L,8L,7L,4L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186503Inst : IEnumerable<long>
{
public static readonly long[] Value=A186503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186503.Bytes);
public long this[int i]=>Value[i];

public static A186503Inst Instance=new A186503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186504
{
public static readonly long[] Value={ 2L,6L,7L,8L,5L,2L,3L,4L,8L,5L,8L,9L,1L,2L,9L,9L,5L,8L,1L,3L,0L,1L,1L,9L,9L,0L,0L,1L,0L,0L,9L,9L,5L,0L,6L,1L,5L,7L,7L,8L,6L,9L,9L,1L,7L,5L,5L,6L,1L,7L,3L,6L,5L,7L,7L,8L,6L,0L,8L,7L,2L,5L,0L,8L,8L,2L,3L,9L,9L,0L,0L,6L,9L,2L,8L,6L,8L,7L,8L,9L,9L,6L,2L,9L,4L,7L,4L,8L,7L,5L,1L,0L,0L,7L,1L,3L,8L,4L,0L,9L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186504Inst : IEnumerable<long>
{
public static readonly long[] Value=A186504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186504.Bytes);
public long this[int i]=>Value[i];

public static A186504Inst Instance=new A186504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186505
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,2L,3L,4L,5L,8L,9L,14L,18L,25L,34L,46L,64L,86L,119L,162L,222L,304L,416L,571L,780L,1071L,1466L,2010L,2754L,3775L,5175L,7092L,9724L,13329L,18274L,25052L,34347L,47091L,64562L,88522L,121369L,166411L,228168L,312848L,428959L,588163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186505Inst : IEnumerable<long>
{
public static readonly long[] Value=A186505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186505.Bytes);
public long this[int i]=>Value[i];

public static A186505Inst Instance=new A186505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186506
{
public static readonly BigInteger[] Value={ 1L,13L,139L,12739L,1281739L,1281739243L,1281737299243L,12817372218799243L,BigInteger.Parse("128173765612218799243"),BigInteger.Parse("12196838173765612218799243"),BigInteger.Parse("1219683817376590495612218799243"),BigInteger.Parse("1219683817714717376590495612218799243"),BigInteger.Parse("1219683853144117714717376590495612218799243"),BigInteger.Parse("12196838531441159432317714717376590495612218799243"),BigInteger.Parse("121968385314411594323177147478296917376590495612218799243") };
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
public class A186506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186506Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186506.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186506Inst Instance=new A186506Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186507
{
public static readonly long[] Value={ 2L,2L,2L,6L,10L,14L,30L,47L,62L,91L,134L,217L,316L,483L,743L,1118L,1598L,2422L,3616L,5316L,8061L,12284L,18675L,26946L,39146L,59339L,90790L,137602L,206390L,316184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186507Inst : IEnumerable<long>
{
public static readonly long[] Value=A186507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186507.Bytes);
public long this[int i]=>Value[i];

public static A186507Inst Instance=new A186507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186540
{
public static readonly long[] Value={ 2L,5L,8L,10L,13L,16L,19L,21L,24L,27L,30L,32L,35L,38L,40L,43L,46L,49L,51L,54L,57L,60L,62L,65L,68L,71L,73L,76L,79L,81L,84L,87L,90L,92L,95L,98L,101L,103L,106L,109L,112L,114L,117L,120L,122L,125L,128L,131L,133L,136L,139L,142L,144L,147L,150L,152L,155L,158L,161L,163L,166L,169L,172L,174L,177L,180L,183L,185L,188L,191L,193L,196L,199L,202L,204L,207L,210L,213L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186540Inst : IEnumerable<long>
{
public static readonly long[] Value=A186540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186540.Bytes);
public long this[int i]=>Value[i];

public static A186540Inst Instance=new A186540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186541
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,9L,11L,12L,14L,15L,17L,18L,20L,22L,23L,25L,26L,28L,30L,31L,33L,34L,36L,37L,39L,41L,42L,44L,45L,47L,48L,50L,52L,53L,55L,56L,58L,59L,61L,63L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,82L,83L,85L,86L,88L,89L,91L,93L,94L,96L,97L,99L,100L,102L,104L,105L,107L,108L,110L,112L,113L,115L,116L,118L,119L,121L,123L,124L,126L,127L,129L,130L,132L,134L,135L,137L,138L,140L,141L,143L,145L,146L,148L,149L,151L,153L,154L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186541Inst : IEnumerable<long>
{
public static readonly long[] Value=A186541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186541.Bytes);
public long this[int i]=>Value[i];

public static A186541Inst Instance=new A186541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186542
{
public static readonly long[] Value={ 1L,5L,7L,10L,13L,16L,19L,21L,24L,27L,29L,32L,35L,38L,40L,43L,46L,49L,51L,54L,57L,60L,62L,65L,68L,71L,73L,76L,79L,81L,84L,87L,90L,92L,95L,98L,101L,103L,106L,109L,111L,114L,117L,120L,122L,125L,128L,131L,133L,136L,139L,142L,144L,147L,150L,152L,155L,158L,161L,163L,166L,169L,172L,174L,177L,180L,183L,185L,188L,191L,193L,196L,199L,202L,204L,207L,210L,213L,215L,218L,221L,224L,226L,229L,232L,234L,237L,240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186542Inst : IEnumerable<long>
{
public static readonly long[] Value=A186542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186542.Bytes);
public long this[int i]=>Value[i];

public static A186542Inst Instance=new A186542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186543
{
public static readonly long[] Value={ 2L,4L,7L,8L,12L,13L,15L,18L,21L,22L,25L,26L,29L,31L,34L,36L,38L,41L,43L,45L,47L,50L,51L,54L,56L,59L,61L,63L,66L,68L,70L,73L,74L,77L,79L,81L,83L,86L,88L,90L,92L,95L,97L,99L,102L,104L,107L,108L,111L,113L,116L,118L,120L,122L,125L,127L,129L,131L,133L,135L,138L,140L,142L,145L,147L,149L,151L,154L,156L,158L,160L,163L,165L,168L,170L,172L,174L,176L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186543Inst : IEnumerable<long>
{
public static readonly long[] Value=A186543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186543.Bytes);
public long this[int i]=>Value[i];

public static A186543Inst Instance=new A186543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186544
{
public static readonly long[] Value={ 8L,16L,24L,32L,40L,48L,56L,64L,72L,80L,88L,96L,104L,112L,120L,129L,137L,145L,153L,161L,169L,177L,185L,193L,201L,209L,217L,225L,233L,241L,249L,258L,266L,274L,282L,290L,298L,306L,314L,322L,330L,338L,346L,354L,362L,370L,378L,387L,395L,403L,411L,419L,427L,435L,443L,451L,459L,467L,475L,483L,491L,499L,507L,516L,524L,532L,540L,548L,556L,564L,572L,580L,588L,596L,604L,612L,620L,628L,636L,645L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186544Inst : IEnumerable<long>
{
public static readonly long[] Value=A186544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186544.Bytes);
public long this[int i]=>Value[i];

public static A186544Inst Instance=new A186544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186545
{
public static readonly long[] Value={ 1L,-1L,3L,-2L,5L,-5L,8L,-7L,13L,-13L,18L,-19L,26L,-29L,39L,-40L,52L,-60L,72L,-81L,101L,-113L,134L,-152L,181L,-206L,243L,-273L,318L,-365L,418L,-473L,549L,-620L,710L,-803L,914L,-1034L,1177L,-1322L,1498L,-1691L,1904L,-2139L,2416L,-2704L,3036L,-3400L,3811L,-4261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186545Inst : IEnumerable<long>
{
public static readonly long[] Value=A186545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186545.Bytes);
public long this[int i]=>Value[i];

public static A186545Inst Instance=new A186545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186546
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,11L,20L,37L,69L,129L,242L,456L,861L,1635L,3113L,5946L,11386L,21854L,42038L,81019L,156416L,302460L,585712L,1135739L,2204982L,4285715L,8338678L,16240318L,31658209L,61765576L,120601144L,235656667L,460799447L,901634095L,1765300397L,3458294143L,6778702259L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186546Inst : IEnumerable<long>
{
public static readonly long[] Value=A186546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186546.Bytes);
public long this[int i]=>Value[i];

public static A186546Inst Instance=new A186546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186547
{
public static readonly BigInteger[] Value={ 0L,290L,2972L,168200L,3090668L,111188198L,2585394080L,78931270418L,2022581728964L,57893438838608L,1543873188898724L,43063896490838390L,1167248594013245504L,BigInteger.Parse("32220586362367051898"),BigInteger.Parse("879136485710121947756") };
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
public class A186547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186547Inst Instance=new A186547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186548
{
public static readonly BigInteger[] Value={ 290L,19016L,1279862L,88662978L,6215002266L,435599518160L,30577245619492L,2145961447892386L,150629240515340670L,10572567332219259666UL,BigInteger.Parse("742094548656309697042"),BigInteger.Parse("52087780768510204956480"),BigInteger.Parse("3656060603655477820657112") };
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
public class A186548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186548Inst Instance=new A186548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186549
{
public static readonly BigInteger[] Value={ 2972L,1279862L,177942264L,31976088817L,5253540132125L,891778365437358L,149628929202973235L,BigInteger.Parse("25212444270769802733"),BigInteger.Parse("4241667400028024496621"),BigInteger.Parse("714009811534975107167492"),BigInteger.Parse("120166248667449739439413727") };
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
public class A186549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186549Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186549.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186549Inst Instance=new A186549Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186550
{
public static readonly BigInteger[] Value={ 168200L,88662978L,31976088817L,13544245035035L,5541254050323697L,2292090739550640497L,BigInteger.Parse("945658119457845662613"),BigInteger.Parse("390484318597052432729179"),BigInteger.Parse("161199926899075628268006706"),BigInteger.Parse("66551276226155618695804703318") };
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
public class A186550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186550Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186550.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186550Inst Instance=new A186550Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186551
{
public static readonly BigInteger[] Value={ 3090668L,6215002266L,5253540132125L,5541254050323697L,5484853650034152292L,BigInteger.Parse("5583822993675095945553") };
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
public class A186551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186551Inst Instance=new A186551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186552
{
public static readonly BigInteger[] Value={ 111188198L,435599518160L,891778365437358L,2292090739550640497L,BigInteger.Parse("5583822993675095945553") };
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
public class A186552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186552Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186552.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186552Inst Instance=new A186552Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186553
{
public static readonly long[] Value={ 0L,290L,290L,2972L,19016L,2972L,168200L,1279862L,1279862L,168200L,3090668L,88662978L,177942264L,88662978L,3090668L,111188198L,6215002266L,31976088817L,31976088817L,6215002266L,111188198L,2585394080L,435599518160L,5253540132125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186553Inst : IEnumerable<long>
{
public static readonly long[] Value=A186553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186553.Bytes);
public long this[int i]=>Value[i];

public static A186553Inst Instance=new A186553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186554
{
public static readonly ulong[] Value={ 256L,3891L,60074L,927477L,14319230L,221073168L,3413126694L,52694924343L,813551707879L,12560344087053L,193917905964431L,2993879307207532L,46222205533558883L,713620044483130375L,11017509052404905567UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186554Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A186554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186554.Bytes);
public ulong this[int i]=>Value[i];

public static A186554Inst Instance=new A186554Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186555
{
public static readonly BigInteger[] Value={ 3891L,227890L,13360840L,783375343L,45931015744L,2693039069563L,157898954845170L,9257972050372672L,542815792619425874L,BigInteger.Parse("31826514833666294971"),BigInteger.Parse("1866060384036495988230"),BigInteger.Parse("109411331246371391577832") };
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
public class A186555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186555Inst Instance=new A186555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186764
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,14L,7L,3L,70L,35L,15L,419L,226L,60L,15L,2933L,1582L,420L,105L,23421L,12741L,3423L,630L,105L,210789L,114669L,30807L,5670L,945L,2108144L,1144921L,311160L,55755L,7875L,945L,23189584L,12594131L,3422760L,613305L,86625L,10395L,278279165L,151125052L,41041968L,7429290L,1001385L,114345L,10395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186764Inst : IEnumerable<long>
{
public static readonly long[] Value=A186764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186764.Bytes);
public long this[int i]=>Value[i];

public static A186764Inst Instance=new A186764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186765
{
public static readonly BigInteger[] Value={ 1L,1L,1L,3L,14L,70L,419L,2933L,23421L,210789L,2108144L,23189584L,278279165L,3617629145L,50646737049L,759701055735L,12155215581362L,206638664883154L,3719496008830391L,70670424167777429L,1413408484443295197L,BigInteger.Parse("29681578173309199137") };
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
public class A186765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186765Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186765.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186765Inst Instance=new A186765Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186766
{
public static readonly long[] Value={ 1L,1L,2L,5L,1L,20L,4L,77L,43L,472L,238L,10L,2585L,2385L,70L,21968L,16504L,1848L,157113L,189695L,15792L,280L,1724064L,1591082L,310854L,2800L,15229645L,21449481L,3100614L,137060L,204738624L,213397204L,59267252L,1583120L,15400L,2151199429L,3347368503L,676271024L,51981644L,200200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186766Inst : IEnumerable<long>
{
public static readonly long[] Value=A186766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186766.Bytes);
public long this[int i]=>Value[i];

public static A186766Inst Instance=new A186766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186767
{
public static readonly ulong[] Value={ 1L,1L,2L,5L,20L,77L,472L,2585L,21968L,157113L,1724064L,15229645L,204738624L,2151199429L,34194201472L,416221515169L,7631627843840L,105565890206193L,2192501224174080L,33962775502534165L,787900686999286784L,13509825183288167869UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186767Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A186767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186767.Bytes);
public ulong this[int i]=>Value[i];

public static A186767Inst Instance=new A186767Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186768
{
public static readonly BigInteger[] Value={ 0L,0L,0L,1L,4L,43L,258L,2525L,20200L,222119L,2221190L,28061889L,336742668L,4856656283L,67993187962L,1107076110629L,17713217770064L,322047491979087L,5796854855623566L,116542615962575753L,2330852319251515060L,BigInteger.Parse("51380800712458456259") };
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
public class A186768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186768Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186768.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186768Inst Instance=new A186768Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186769
{
public static readonly long[] Value={ 1L,1L,2L,6L,19L,5L,95L,25L,451L,269L,3157L,1883L,21092L,18353L,875L,189828L,165177L,7875L,1660351L,1764749L,203700L,18263861L,19412239L,2240700L,197541565L,237001478L,43736682L,721875L,2568040345L,3081019214L,568576866L,9384375L,33029787974L,43065489284L,10638945317L,444068625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186769Inst : IEnumerable<long>
{
public static readonly long[] Value=A186769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186769.Bytes);
public long this[int i]=>Value[i];

public static A186769Inst Instance=new A186769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186770
{
public static readonly ulong[] Value={ 1L,1L,2L,6L,19L,95L,451L,3157L,21092L,189828L,1660351L,18263861L,197541565L,2568040345L,33029787974L,495446819610L,7377279473779L,125413751054243L,2120559951767503L,40290639083582557L,762353357154540584L,16009420500245352264UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186770Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A186770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186770.Bytes);
public ulong this[int i]=>Value[i];

public static A186770Inst Instance=new A186770Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186771
{
public static readonly long[] Value={ 1L,2L,3L,6L,12L,27L,48L,130L,252L,705L,1386L,2295L,7125L,17316L,31959L,51054L,74601L,102600L,351315L,748440L,2123189L,4198848L,6975417L,10452896L,14631285L,19510584L,25090793L,31371912L,38353941L,46036880L,54420729L,63505488L,73291157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186771Inst : IEnumerable<long>
{
public static readonly long[] Value=A186771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186771.Bytes);
public long this[int i]=>Value[i];

public static A186771Inst Instance=new A186771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186772
{
public static readonly BigInteger[] Value={ 1L,1L,3L,14L,122L,1538L,28160L,687216L,21985504L,877927620L,43310174393L,2579819875036L,182645907850321L,15166854447512754L,1459204576675950496L,BigInteger.Parse("161391028121114185561"),BigInteger.Parse("20297024256655626819933"),BigInteger.Parse("2880152675051053471691329"),BigInteger.Parse("458990926597368013495650709") };
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
public class A186772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186772Inst Instance=new A186772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186773
{
public static readonly long[] Value={ 3L,5L,7L,11L,21L,23L,25L,29L,41L,43L,47L,49L,61L,65L,67L,83L,85L,89L,101L,111L,113L,115L,119L,131L,133L,137L,139L,151L,155L,157L,173L,175L,179L,191L,193L,197L,199L,201L,203L,205L,209L,221L,223L,227L,229L,241L,245L,247L,263L,265L,269L,281L,283L,287L,289L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186773Inst : IEnumerable<long>
{
public static readonly long[] Value=A186773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186773.Bytes);
public long this[int i]=>Value[i];

public static A186773Inst Instance=new A186773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186774
{
public static readonly BigInteger[] Value={ 32L,243L,256L,625L,7776L,16807L,4096L,31381059609L,0L,121L,BigInteger.Parse("79496847203390844133441536"),51185893014090757L,155568095557812224L,BigInteger.Parse("22168378200531005859375"),17592186044416L,118587876497L,11019960576L,42052983462257059L };
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
public class A186774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186774Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A186774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186774.Bytes);
public BigInteger this[int i]=>Value[i];

public static A186774Inst Instance=new A186774Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186775
{
public static readonly long[] Value={ 3L,4L,8L,9L,15L,16L,20L,21L,23L,24L,26L,28L,29L,33L,34L,36L,39L,40L,41L,46L,48L,51L,52L,55L,56L,57L,60L,63L,64L,67L,68L,69L,74L,75L,76L,77L,80L,82L,83L,85L,86L,88L,91L,92L,94L,95L,97L,98L,100L,102L,106L,108L,112L,113L,116L,118L,121L,124L,126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186775Inst : IEnumerable<long>
{
public static readonly long[] Value=A186775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186775.Bytes);
public long this[int i]=>Value[i];

public static A186775Inst Instance=new A186775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186776
{
public static readonly long[] Value={ 0L,2L,3L,5L,9L,11L,12L,14L,27L,29L,30L,32L,36L,38L,39L,41L,81L,83L,84L,86L,90L,92L,93L,95L,108L,110L,111L,113L,117L,119L,120L,122L,243L,245L,246L,248L,252L,254L,255L,257L,270L,272L,273L,275L,279L,281L,282L,284L,324L,326L,327L,329L,333L,335L,336L,338L,351L,353L,354L,356L,360L,362L,363L,365L,729L,731L,732L,734L,738L,740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186776Inst : IEnumerable<long>
{
public static readonly long[] Value=A186776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186776.Bytes);
public long this[int i]=>Value[i];

public static A186776Inst Instance=new A186776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186777
{
public static readonly long[] Value={ 4L,6L,10L,15L,35L,77L,91L,143L,187L,209L,221L,247L,299L,323L,391L,437L,493L,527L,551L,589L,667L,703L,713L,851L,899L,943L,989L,1073L,1147L,1189L,1247L,1271L,1333L,1363L,1457L,1517L,1537L,1591L,1643L,1739L,1763L,1829L,1891L,1927L,1961L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186777Inst : IEnumerable<long>
{
public static readonly long[] Value=A186777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186777.Bytes);
public long this[int i]=>Value[i];

public static A186777Inst Instance=new A186777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186778
{
public static readonly long[] Value={ 9L,14L,21L,24L,33L,40L,55L,65L,119L,133L,253L,319L,341L,377L,403L,481L,629L,697L,731L,779L,799L,817L,893L,1007L,1081L,1219L,1357L,1403L,1541L,1711L,1769L,1943L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186778Inst : IEnumerable<long>
{
public static readonly long[] Value=A186778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186778.Bytes);
public long this[int i]=>Value[i];

public static A186778Inst Instance=new A186778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A186779
{
public static readonly long[] Value={ 12L,39L,56L,85L,88L,95L,104L,161L,407L,451L,473L,533L,559L,611L,901L,1003L,1037L,1121L,1139L,1159L,1273L,1349L,1387L,1633L,1679L,1817L,1909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A186779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A186779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A186779Inst : IEnumerable<long>
{
public static readonly long[] Value=A186779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A186779.Bytes);
public long this[int i]=>Value[i];

public static A186779Inst Instance=new A186779Inst();

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