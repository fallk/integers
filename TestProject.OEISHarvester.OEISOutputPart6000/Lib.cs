using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191451
{
public static readonly long[] Value={ 1L,4L,2L,13L,7L,3L,40L,22L,10L,5L,121L,67L,31L,16L,6L,364L,202L,94L,49L,19L,8L,1093L,607L,283L,148L,58L,25L,9L,3280L,1822L,850L,445L,175L,76L,28L,11L,9841L,5467L,2551L,1336L,526L,229L,85L,34L,12L,29524L,16402L,7654L,4009L,1579L,688L,256L,103L,37L,14L,88573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191451Inst : IEnumerable<long>
{
public static readonly long[] Value=A191451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191451.Bytes);
public long this[int i]=>Value[i];

public static A191451Inst Instance=new A191451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191450
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,4L,14L,23L,11L,6L,41L,68L,32L,17L,7L,122L,203L,95L,50L,20L,9L,365L,608L,284L,149L,59L,26L,10L,1094L,1823L,851L,446L,176L,77L,29L,12L,3281L,5468L,2552L,1337L,527L,230L,86L,35L,13L,9842L,16403L,7655L,4010L,1580L,689L,257L,104L,38L,15L,29525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191450Inst : IEnumerable<long>
{
public static readonly long[] Value=A191450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191450.Bytes);
public long this[int i]=>Value[i];

public static A191450Inst Instance=new A191450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191449
{
public static readonly long[] Value={ 1L,3L,2L,9L,6L,4L,27L,18L,12L,5L,81L,54L,36L,15L,7L,243L,162L,108L,45L,21L,8L,729L,486L,324L,135L,63L,24L,10L,2187L,1458L,972L,405L,189L,72L,30L,11L,6561L,4374L,2916L,1215L,567L,216L,90L,33L,13L,19683L,13122L,8748L,3645L,1701L,648L,270L,99L,39L,14L,59049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191449Inst : IEnumerable<long>
{
public static readonly long[] Value=A191449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191449.Bytes);
public long this[int i]=>Value[i];

public static A191449Inst Instance=new A191449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191448
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,15L,11L,9L,6L,31L,23L,19L,13L,8L,63L,47L,39L,27L,17L,10L,127L,95L,79L,55L,35L,21L,12L,255L,191L,159L,111L,71L,43L,25L,14L,511L,383L,319L,223L,143L,87L,51L,29L,16L,1023L,767L,639L,447L,287L,175L,103L,59L,33L,18L,2047L,1535L,1279L,895L,575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191448Inst : IEnumerable<long>
{
public static readonly long[] Value=A191448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191448.Bytes);
public long this[int i]=>Value[i];

public static A191448Inst Instance=new A191448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191447
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,4L,16L,12L,9L,6L,36L,27L,21L,14L,8L,81L,61L,47L,32L,18L,10L,182L,137L,106L,72L,41L,23L,11L,407L,307L,238L,161L,92L,52L,25L,13L,911L,687L,533L,361L,206L,117L,56L,30L,15L,2038L,1537L,1192L,808L,461L,262L,126L,68L,34L,17L,4558L,3437L,2666L,1807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191447Inst : IEnumerable<long>
{
public static readonly long[] Value=A191447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191447.Bytes);
public long this[int i]=>Value[i];

public static A191447Inst Instance=new A191447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191446
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,8L,13L,11L,7L,17L,29L,24L,15L,9L,38L,64L,53L,33L,20L,10L,84L,143L,118L,73L,44L,22L,12L,187L,319L,263L,163L,98L,49L,26L,14L,418L,713L,588L,364L,219L,109L,58L,31L,16L,934L,1594L,1314L,813L,489L,243L,129L,69L,35L,18L,2088L,3564L,2938L,1817L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191446Inst : IEnumerable<long>
{
public static readonly long[] Value=A191446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191446.Bytes);
public long this[int i]=>Value[i];

public static A191446Inst Instance=new A191446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191445
{
public static readonly long[] Value={ 1L,3L,2L,6L,5L,4L,12L,10L,8L,7L,22L,19L,15L,13L,9L,39L,34L,27L,24L,17L,11L,69L,60L,48L,43L,31L,20L,14L,121L,105L,84L,76L,55L,36L,25L,16L,211L,183L,147L,133L,96L,64L,45L,29L,18L,367L,318L,256L,232L,168L,112L,79L,51L,32L,21L,637L,552L,445L,403L,292L,195L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191445Inst : IEnumerable<long>
{
public static readonly long[] Value=A191445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191445.Bytes);
public long this[int i]=>Value[i];

public static A191445Inst Instance=new A191445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191444
{
public static readonly long[] Value={ 1L,3L,2L,6L,4L,5L,11L,8L,10L,7L,20L,15L,18L,13L,9L,36L,27L,32L,24L,17L,12L,63L,48L,56L,43L,30L,22L,14L,110L,84L,98L,75L,53L,39L,25L,16L,192L,146L,171L,131L,93L,69L,44L,29L,19L,334L,254L,297L,228L,162L,121L,77L,51L,34L,21L,580L,441L,515L,396L,282L,211L,134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191444Inst : IEnumerable<long>
{
public static readonly long[] Value=A191444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191444.Bytes);
public long this[int i]=>Value[i];

public static A191444Inst Instance=new A191444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191443
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,7L,11L,9L,8L,13L,20L,16L,14L,10L,23L,35L,28L,25L,18L,12L,40L,61L,49L,44L,32L,21L,15L,70L,106L,85L,77L,56L,37L,26L,17L,122L,184L,148L,134L,97L,65L,46L,30L,19L,212L,319L,257L,233L,169L,113L,80L,52L,33L,22L,368L,553L,446L,404L,293L,196L,139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191443Inst : IEnumerable<long>
{
public static readonly long[] Value=A191443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191443.Bytes);
public long this[int i]=>Value[i];

public static A191443Inst Instance=new A191443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191442
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,6L,5L,12L,10L,8L,9L,21L,17L,14L,11L,16L,36L,29L,24L,19L,13L,28L,62L,50L,42L,33L,23L,15L,48L,107L,87L,73L,57L,40L,26L,18L,83L,185L,151L,126L,99L,69L,45L,31L,20L,144L,320L,262L,218L,171L,120L,78L,54L,35L,22L,249L,554L,454L,378L,296L,208L,135L,94L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191442Inst : IEnumerable<long>
{
public static readonly long[] Value=A191442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191442.Bytes);
public long this[int i]=>Value[i];

public static A191442Inst Instance=new A191442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191441
{
public static readonly long[] Value={ 1L,4L,2L,12L,7L,3L,31L,19L,9L,5L,77L,48L,24L,14L,6L,188L,118L,60L,36L,16L,8L,456L,287L,147L,89L,41L,21L,10L,1103L,695L,357L,217L,101L,53L,26L,11L,2665L,1680L,864L,526L,246L,130L,65L,28L,13L,6436L,4058L,2088L,1272L,596L,316L,159L,70L,33L,15L,15540L,9799L,5043L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191441Inst : IEnumerable<long>
{
public static readonly long[] Value=A191441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191441.Bytes);
public long this[int i]=>Value[i];

public static A191441Inst Instance=new A191441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191440
{
public static readonly long[] Value={ 1L,3L,2L,8L,6L,4L,20L,15L,11L,5L,49L,37L,28L,13L,7L,119L,90L,69L,32L,18L,9L,288L,218L,168L,78L,44L,23L,10L,696L,527L,407L,189L,107L,57L,25L,12L,1681L,1273L,984L,457L,259L,139L,61L,30L,14L,4059L,3074L,2377L,1104L,626L,337L,148L,73L,35L,16L,9800L,7422L,5740L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191440Inst : IEnumerable<long>
{
public static readonly long[] Value=A191440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191440.Bytes);
public long this[int i]=>Value[i];

public static A191440Inst Instance=new A191440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191439
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,4L,12L,17L,10L,6L,29L,41L,24L,14L,8L,70L,99L,58L,34L,19L,9L,169L,239L,140L,82L,46L,22L,11L,408L,577L,338L,198L,111L,53L,27L,13L,985L,1393L,816L,478L,268L,128L,65L,31L,15L,2378L,3363L,1970L,1154L,647L,309L,157L,75L,36L,16L,5741L,8119L,4756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191439Inst : IEnumerable<long>
{
public static readonly long[] Value=A191439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191439.Bytes);
public long this[int i]=>Value[i];

public static A191439Inst Instance=new A191439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191438
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,5L,9L,16L,12L,6L,21L,38L,28L,14L,8L,50L,91L,67L,33L,19L,10L,120L,219L,161L,79L,45L,24L,11L,289L,528L,388L,190L,108L,57L,26L,13L,697L,1274L,936L,458L,260L,137L,62L,31L,15L,1682L,3075L,2259L,1105L,627L,330L,149L,74L,36L,17L,4060L,7423L,5453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191438Inst : IEnumerable<long>
{
public static readonly long[] Value=A191438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191438.Bytes);
public long this[int i]=>Value[i];

public static A191438Inst Instance=new A191438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191437
{
public static readonly long[] Value={ 1L,3L,2L,8L,5L,4L,21L,13L,11L,6L,55L,34L,29L,16L,7L,144L,89L,76L,42L,18L,9L,377L,233L,199L,110L,47L,24L,10L,987L,610L,521L,288L,123L,63L,26L,12L,2584L,1597L,1364L,754L,322L,165L,68L,32L,14L,6765L,4181L,3571L,1974L,843L,432L,178L,84L,37L,15L,17711L,10946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191437Inst : IEnumerable<long>
{
public static readonly long[] Value=A191437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191437.Bytes);
public long this[int i]=>Value[i];

public static A191437Inst Instance=new A191437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191436
{
public static readonly long[] Value={ 1L,4L,2L,12L,6L,3L,33L,17L,9L,5L,88L,46L,25L,14L,7L,232L,122L,67L,38L,19L,8L,609L,321L,177L,101L,51L,22L,10L,1596L,842L,465L,266L,135L,59L,27L,11L,4180L,2206L,1219L,698L,355L,156L,72L,30L,13L,10945L,5777L,3193L,1829L,931L,410L,190L,80L,35L,15L,28656L,15126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191436Inst : IEnumerable<long>
{
public static readonly long[] Value=A191436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191436.Bytes);
public long this[int i]=>Value[i];

public static A191436Inst Instance=new A191436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191403
{
public static readonly long[] Value={ 3L,5L,9L,12L,15L,19L,21L,25L,28L,31L,35L,38L,41L,45L,47L,51L,54L,57L,61L,63L,67L,70L,73L,77L,80L,83L,87L,89L,93L,96L,99L,103L,106L,109L,113L,115L,119L,122L,125L,129L,131L,135L,138L,141L,145L,148L,151L,155L,157L,161L,164L,167L,171L,173L,177L,180L,183L,187L,190L,193L,197L,199L,203L,206L,209L,213L,216L,219L,223L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191403Inst : IEnumerable<long>
{
public static readonly long[] Value=A191403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191403.Bytes);
public long this[int i]=>Value[i];

public static A191403Inst Instance=new A191403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191402
{
public static readonly long[] Value={ 1L,4L,7L,10L,14L,17L,20L,23L,26L,30L,33L,36L,40L,43L,46L,49L,52L,56L,59L,62L,65L,68L,72L,75L,78L,82L,85L,88L,91L,94L,98L,101L,104L,108L,111L,114L,117L,120L,124L,127L,130L,133L,136L,140L,143L,146L,150L,153L,156L,159L,162L,166L,169L,172L,175L,178L,182L,185L,188L,192L,195L,198L,201L,204L,208L,211L,214L,218L,221L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191402Inst : IEnumerable<long>
{
public static readonly long[] Value=A191402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191402.Bytes);
public long this[int i]=>Value[i];

public static A191402Inst Instance=new A191402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191401
{
public static readonly long[] Value={ 2L,9L,10L,42L,44L,50L,52L,135L,150L,156L,184L,198L,204L,210L,225L,228L,232L,675L,684L,696L,728L,744L,752L,920L,944L,968L,976L,2484L,2544L,2646L,2673L,2744L,2772L,2835L,2904L,2928L,2992L,3132L,3150L,3192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191401Inst : IEnumerable<long>
{
public static readonly long[] Value=A191401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191401.Bytes);
public long this[int i]=>Value[i];

public static A191401Inst Instance=new A191401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191400
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,1L,0L,0L,2L,2L,3L,1L,1L,0L,3L,0L,1L,2L,0L,2L,1L,3L,2L,1L,4L,1L,3L,0L,2L,3L,4L,0L,4L,1L,2L,2L,1L,0L,2L,2L,2L,1L,0L,3L,4L,2L,3L,1L,0L,4L,2L,1L,0L,3L,5L,0L,1L,2L,2L,3L,2L,4L,2L,0L,3L,4L,1L,1L,3L,2L,2L,2L,1L,1L,5L,0L,3L,2L,3L,2L,4L,2L,3L,1L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191400Inst : IEnumerable<long>
{
public static readonly long[] Value=A191400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191400.Bytes);
public long this[int i]=>Value[i];

public static A191400Inst Instance=new A191400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191399
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,1L,8L,2L,13L,7L,21L,14L,34L,35L,1L,55L,68L,3L,89L,149L,14L,144L,282L,36L,233L,576L,114L,1L,377L,1068L,267L,4L,610L,2088L,711L,23L,987L,3810L,1566L,72L,1597L,7229L,3771L,272L,1L,2584L,13024L,7953L,744L,5L,4181L,24179L,17922L,2304L,34L,6765L,43114L,36594L,5780L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191399Inst : IEnumerable<long>
{
public static readonly long[] Value=A191399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191399.Bytes);
public long this[int i]=>Value[i];

public static A191399Inst Instance=new A191399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191398
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,18L,28L,56L,89L,179L,289L,585L,956L,1948L,3214L,6591L,10959L,22609L,37833L,78486L,132037L,275316L,465255L,974659L,1653418L,3478520L,5920569L,12504448L,21344348L,45240473L,77417309L,164624203L,282335973L,602163830L,1034757445L,2212959172L,3809387953L,8167344875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191398Inst : IEnumerable<long>
{
public static readonly long[] Value=A191398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191398.Bytes);
public long this[int i]=>Value[i];

public static A191398Inst Instance=new A191398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191397
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,9L,1L,18L,2L,28L,7L,56L,14L,89L,37L,179L,72L,1L,289L,170L,3L,585L,326L,13L,956L,726L,34L,1948L,1380L,104L,3214L,2970L,250L,1L,6591L,5616L,659L,4L,10959L,11829L,1502L,20L,22609L,22300L,3647L,64L,37833L,46306L,8019L,220L,78486L,87154L,18495L,620L,1L,132037L,179222L,39648L,1804L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191397Inst : IEnumerable<long>
{
public static readonly long[] Value=A191397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191397.Bytes);
public long this[int i]=>Value[i];

public static A191397Inst Instance=new A191397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191396
{
public static readonly long[] Value={ 0L,0L,1L,2L,7L,14L,35L,70L,156L,312L,663L,1326L,2756L,5512L,11325L,22650L,46227L,92454L,187891L,375782L,761465L,1522930L,3079475L,6158950L,12434015L,24868030L,50142687L,100285374L,202010787L,404021574L,813191039L,1626382078L,3271314744L,6542629488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191396Inst : IEnumerable<long>
{
public static readonly long[] Value=A191396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191396.Bytes);
public long this[int i]=>Value[i];

public static A191396Inst Instance=new A191396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191395
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,3L,2L,1L,4L,5L,2L,5L,9L,4L,3L,6L,14L,12L,8L,9L,20L,25L,8L,13L,14L,27L,44L,28L,31L,29L,40L,70L,66L,16L,49L,54L,62L,104L,129L,64L,109L,115L,116L,159L,225L,168L,32L,170L,212L,217L,250L,363L,360L,144L,371L,430L,445L,444L,581L,681L,416L,64L,581L,772L,854L,820L,938L,1182L,968L,320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191395Inst : IEnumerable<long>
{
public static readonly long[] Value=A191395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191395.Bytes);
public long this[int i]=>Value[i];

public static A191395Inst Instance=new A191395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191394
{
public static readonly long[] Value={ 0L,0L,1L,2L,6L,12L,28L,56L,121L,242L,507L,1014L,2093L,4186L,8569L,17138L,34902L,69804L,141664L,283328L,573574L,1147148L,2318010L,4636020L,9354540L,18709080L,37708672L,75417344L,151868100L,303736200L,611180252L,1222360504L,2458123705L,4916247410L,9881255187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191394Inst : IEnumerable<long>
{
public static readonly long[] Value=A191394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191394.Bytes);
public long this[int i]=>Value[i];

public static A191394Inst Instance=new A191394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191393
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,3L,8L,13L,31L,49L,109L,170L,371L,581L,1270L,2010L,4417L,7063L,15581L,25123L,55554L,90179L,199752L,326089L,723351L,1186670L,2635764L,4342829L,9657336L,15973459L,35558165L,59017088L,131500422L,218932442L,488234057L,815127111L,1819186163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191393Inst : IEnumerable<long>
{
public static readonly long[] Value=A191393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191393.Bytes);
public long this[int i]=>Value[i];

public static A191393Inst Instance=new A191393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191392
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,4L,1L,1L,6L,3L,2L,9L,8L,1L,3L,12L,16L,4L,8L,18L,30L,13L,1L,13L,26L,50L,32L,5L,31L,47L,83L,71L,19L,1L,49L,80L,132L,140L,55L,6L,109L,162L,223L,263L,140L,26L,1L,170L,292L,377L,468L,316L,86L,7L,371L,592L,693L,830L,665L,246L,34L,1L,581L,1064L,1264L,1456L,1314L,622L,126L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191392Inst : IEnumerable<long>
{
public static readonly long[] Value=A191392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191392.Bytes);
public long this[int i]=>Value[i];

public static A191392Inst Instance=new A191392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191391
{
public static readonly long[] Value={ 0L,1L,1L,3L,5L,12L,22L,49L,93L,200L,386L,814L,1586L,3304L,6476L,13381L,26333L,54096L,106762L,218386L,431910L,880616L,1744436L,3547658L,7036530L,14281072L,28354132L,57451164L,114159428L,230993296L,459312152L,928319149L,1846943453L,3729244576L,7423131482L,14975907754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191391Inst : IEnumerable<long>
{
public static readonly long[] Value=A191391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191391.Bytes);
public long this[int i]=>Value[i];

public static A191391Inst Instance=new A191391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191390
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,3L,2L,3L,1L,0L,8L,2L,5L,8L,7L,0L,22L,12L,1L,14L,22L,31L,3L,0L,64L,50L,12L,42L,64L,117L,28L,1L,0L,196L,184L,78L,4L,132L,196L,416L,162L,18L,0L,625L,648L,390L,52L,1L,429L,625L,1452L,762L,159L,5L,0L,2055L,2256L,1707L,392L,25L,1430L,2055L,5062L,3225L,1012L,85L,1L,0L,6917L,7868L,6954L,2280L,285L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191390Inst : IEnumerable<long>
{
public static readonly long[] Value=A191390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191390.Bytes);
public long this[int i]=>Value[i];

public static A191390Inst Instance=new A191390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191389
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,7L,14L,37L,74L,176L,352L,794L,1588L,3473L,6946L,14893L,29786L,63004L,126008L,263950L,527900L,1097790L,2195580L,4540386L,9080772L,18696432L,37392864L,76717268L,153434536L,313889477L,627778954L,1281220733L,2562441466L,5219170052L,10438340104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191389Inst : IEnumerable<long>
{
public static readonly long[] Value=A191389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191389.Bytes);
public long this[int i]=>Value[i];

public static A191389Inst Instance=new A191389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191388
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,14L,23L,41L,69L,125L,214L,393L,682L,1267L,2223L,4171L,7385L,13976L,24935L,47544L,85377L,163863L,295900L,571216L,1036471L,2011130L,3664548L,7143068L,13063637L,25568085L,46912433L,92152906L,169570215L,334194418L,616530391L,1218694221L,2253451666L,4466410838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191388Inst : IEnumerable<long>
{
public static readonly long[] Value=A191388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191388.Bytes);
public long this[int i]=>Value[i];

public static A191388Inst Instance=new A191388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191211
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,10L,11L,15L,21L,23L,26L,31L,43L,47L,50L,53L,63L,87L,95L,101L,107L,122L,127L,175L,191L,203L,215L,226L,245L,255L,351L,383L,407L,431L,442L,453L,491L,511L,530L,677L,703L,767L,815L,863L,885L,907L,962L,983L,1023L,1061L,1355L,1407L,1535L,1631L,1727L,1771L,1815L,1850L,1925L,1967L,2047L,2123L,2210L,2501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191211Inst : IEnumerable<long>
{
public static readonly long[] Value=A191211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191211.Bytes);
public long this[int i]=>Value[i];

public static A191211Inst Instance=new A191211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191210
{
public static readonly long[] Value={ 1L,5L,17L,21L,53L,65L,69L,85L,113L,161L,197L,209L,213L,257L,261L,277L,341L,369L,485L,593L,629L,641L,645L,773L,785L,789L,833L,837L,853L,1025L,1029L,1045L,1109L,1137L,1365L,1393L,1457L,1781L,1889L,1925L,1937L,1941L,2321L,2357L,2369L,2373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191210Inst : IEnumerable<long>
{
public static readonly long[] Value=A191210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191210.Bytes);
public long this[int i]=>Value[i];

public static A191210Inst Instance=new A191210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191209
{
public static readonly long[] Value={ 1L,4L,5L,11L,14L,16L,17L,20L,38L,44L,47L,50L,53L,56L,62L,64L,68L,80L,101L,128L,134L,146L,152L,155L,161L,170L,176L,182L,188L,194L,200L,206L,212L,224L,242L,248L,256L,272L,320L,344L,398L,404L,425L,452L,458L,479L,485L,506L,512L,530L,536L,560L,566L,578L,584L,602L,608L,614L,620L,638L,644L,674L,680L,704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191209Inst : IEnumerable<long>
{
public static readonly long[] Value=A191209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191209.Bytes);
public long this[int i]=>Value[i];

public static A191209Inst Instance=new A191209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191208
{
public static readonly long[] Value={ 1L,4L,5L,6L,14L,16L,17L,18L,20L,22L,26L,44L,50L,53L,56L,58L,62L,64L,66L,68L,70L,74L,80L,82L,90L,106L,134L,152L,161L,170L,176L,178L,188L,194L,200L,202L,206L,212L,214L,224L,226L,234L,242L,248L,250L,256L,258L,266L,272L,274L,282L,298L,320L,322L,330L,362L,404L,426L,458L,485L,512L,530L,536L,538L,566L,584L,602L,608L,610L,620L,638L,644L,646L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191208Inst : IEnumerable<long>
{
public static readonly long[] Value=A191208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191208.Bytes);
public long this[int i]=>Value[i];

public static A191208Inst Instance=new A191208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191207
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,19L,27L,33L,35L,43L,45L,51L,53L,57L,59L,67L,75L,81L,99L,105L,107L,129L,131L,135L,139L,153L,159L,161L,171L,177L,179L,201L,203L,211L,225L,227L,235L,243L,267L,297L,299L,315L,321L,323L,387L,393L,395L,405L,417L,419L,427L,459L,477L,483L,485L,513L,515L,523L,531L,537L,539L,555L,603L,609L,611L,633L,635L,643L,675L,681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191207Inst : IEnumerable<long>
{
public static readonly long[] Value=A191207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191207.Bytes);
public long this[int i]=>Value[i];

public static A191207Inst Instance=new A191207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191206
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,19L,35L,43L,53L,59L,67L,75L,99L,107L,131L,139L,161L,171L,179L,203L,211L,227L,235L,267L,299L,323L,355L,395L,419L,427L,485L,515L,523L,539L,555L,611L,635L,643L,683L,707L,715L,739L,803L,811L,843L,899L,907L,939L,971L,1067L,1123L,1187L,1195L,1251L,1259L,1283L,1291L,1457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191206Inst : IEnumerable<long>
{
public static readonly long[] Value=A191206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191206.Bytes);
public long this[int i]=>Value[i];

public static A191206Inst Instance=new A191206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191205
{
public static readonly long[] Value={ 1L,2L,5L,6L,7L,8L,16L,17L,18L,20L,22L,26L,30L,43L,52L,53L,56L,61L,62L,66L,68L,70L,78L,80L,86L,92L,102L,118L,142L,151L,160L,161L,170L,178L,188L,196L,200L,206L,210L,212L,222L,232L,236L,242L,246L,260L,262L,268L,270L,278L,308L,310L,318L,342L,356L,366L,385L,406L,466L,470L,475L,485L,502L,512L,547L,556L,566L,592L,602L,610L,620L,628L,632L,638L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191205Inst : IEnumerable<long>
{
public static readonly long[] Value=A191205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191205.Bytes);
public long this[int i]=>Value[i];

public static A191205Inst Instance=new A191205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191204
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,17L,18L,20L,22L,26L,28L,30L,53L,56L,62L,66L,68L,70L,78L,80L,86L,92L,102L,118L,156L,161L,170L,188L,200L,206L,210L,212L,222L,236L,242L,246L,260L,262L,270L,278L,308L,310L,318L,342L,348L,356L,366L,406L,412L,470L,485L,512L,540L,566L,602L,620L,632L,638L,642L,668L,678L,710L,728L,740L,750L,782L,788L,798L,812L,822L,836L,838L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191204Inst : IEnumerable<long>
{
public static readonly long[] Value=A191204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191204.Bytes);
public long this[int i]=>Value[i];

public static A191204Inst Instance=new A191204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191203
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,16L,17L,20L,26L,32L,34L,40L,52L,64L,65L,68L,80L,101L,104L,128L,130L,136L,160L,202L,208L,256L,257L,260L,272L,290L,320L,401L,404L,416L,512L,514L,520L,544L,580L,640L,677L,802L,808L,832L,1024L,1025L,1028L,1040L,1088L,1157L,1160L,1280L,1354L,1601L,1604L,1616L,1664L,2048L,2050L,2056L,2080L,2176L,2314L,2320L,2560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191203Inst : IEnumerable<long>
{
public static readonly long[] Value=A191203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191203.Bytes);
public long this[int i]=>Value[i];

public static A191203Inst Instance=new A191203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191202
{
public static readonly long[] Value={ 1L,3L,5L,7L,8L,10L,12L,14L,17L,19L,21L,24L,26L,28L,30L,31L,33L,35L,37L,38L,40L,42L,44L,47L,49L,51L,54L,56L,58L,60L,61L,63L,65L,67L,68L,70L,72L,74L,77L,79L,81L,84L,86L,88L,90L,91L,93L,95L,97L,98L,100L,102L,104L,107L,109L,111L,113L,114L,116L,118L,120L,121L,123L,125L,127L,130L,132L,134L,137L,139L,141L,143L,144L,146L,148L,150L,151L,153L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191202Inst : IEnumerable<long>
{
public static readonly long[] Value=A191202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191202.Bytes);
public long this[int i]=>Value[i];

public static A191202Inst Instance=new A191202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191201
{
public static readonly long[] Value={ 1L,4L,7L,13L,16L,19L,22L,31L,40L,43L,55L,58L,67L,70L,79L,91L,94L,121L,124L,127L,151L,163L,166L,175L,178L,202L,205L,223L,235L,238L,271L,274L,283L,286L,319L,364L,367L,379L,382L,394L,487L,490L,499L,502L,511L,526L,529L,607L,610L,637L,655L,667L,670L,703L,706L,715L,718L,811L,814L,823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191201Inst : IEnumerable<long>
{
public static readonly long[] Value=A191201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191201.Bytes);
public long this[int i]=>Value[i];

public static A191201Inst Instance=new A191201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191200
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,10L,13L,18L,19L,22L,26L,30L,31L,40L,42L,54L,55L,58L,67L,74L,78L,79L,90L,91L,94L,106L,121L,122L,126L,127L,162L,163L,166L,170L,175L,202L,218L,222L,223L,234L,235L,238L,270L,271L,274L,283L,298L,314L,318L,319L,362L,364L,366L,367L,378L,379L,382L,426L,486L,487L,490L,499L,506L,510L,511L,526L,607L,650L,654L,655L,666L,667L,670L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191200Inst : IEnumerable<long>
{
public static readonly long[] Value=A191200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191200.Bytes);
public long this[int i]=>Value[i];

public static A191200Inst Instance=new A191200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191199
{
public static readonly long[] Value={ 1L,4L,6L,13L,14L,18L,19L,26L,40L,41L,54L,55L,58L,59L,74L,78L,79L,106L,121L,122L,131L,162L,163L,166L,167L,175L,176L,218L,222L,223L,234L,235L,238L,239L,298L,314L,318L,319L,364L,365L,374L,426L,486L,487L,490L,491L,499L,500L,526L,527L,536L,650L,654L,655L,666L,667L,670L,671L,702L,703L,706L,707L,715L,716L,874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191199Inst : IEnumerable<long>
{
public static readonly long[] Value=A191199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191199.Bytes);
public long this[int i]=>Value[i];

public static A191199Inst Instance=new A191199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191198
{
public static readonly long[] Value={ 1L,4L,6L,13L,18L,19L,26L,35L,40L,54L,55L,58L,74L,78L,79L,99L,106L,121L,162L,163L,166L,175L,218L,222L,223L,234L,235L,238L,291L,298L,314L,318L,319L,364L,419L,426L,486L,487L,490L,499L,526L,650L,654L,655L,666L,667L,670L,702L,703L,706L,715L,867L,874L,890L,894L,895L,938L,942L,943L,954L,955L,958L,1093L,1187L,1194L,1251L,1258L,1274L,1278L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191198Inst : IEnumerable<long>
{
public static readonly long[] Value=A191198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191198.Bytes);
public long this[int i]=>Value[i];

public static A191198Inst Instance=new A191198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191197
{
public static readonly long[] Value={ 1L,3L,4L,5L,12L,13L,16L,17L,21L,30L,39L,40L,48L,49L,52L,53L,64L,65L,69L,85L,111L,120L,121L,147L,148L,156L,157L,160L,161L,192L,193L,196L,197L,208L,209L,213L,256L,257L,261L,273L,277L,341L,354L,363L,364L,435L,444L,445L,471L,472L,480L,481L,484L,485L,579L,580L,588L,589L,592L,593L,624L,625L,628L,629L,640L,641L,645L,768L,769L,772L,773L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191197Inst : IEnumerable<long>
{
public static readonly long[] Value=A191197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191197.Bytes);
public long this[int i]=>Value[i];

public static A191197Inst Instance=new A191197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191196
{
public static readonly long[] Value={ 1L,4L,5L,13L,16L,17L,21L,28L,40L,49L,52L,53L,64L,65L,69L,85L,92L,121L,148L,157L,160L,161L,193L,196L,197L,208L,209L,213L,256L,257L,261L,277L,284L,341L,348L,364L,445L,472L,481L,484L,485L,580L,589L,592L,593L,625L,628L,629L,640L,641L,645L,769L,772L,773L,784L,785L,789L,832L,833L,837L,853L,860L,1024L,1025L,1029L,1045L,1052L,1093L,1109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191196Inst : IEnumerable<long>
{
public static readonly long[] Value=A191196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191196.Bytes);
public long this[int i]=>Value[i];

public static A191196Inst Instance=new A191196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191147
{
public static readonly long[] Value={ 1L,3L,7L,17L,18L,31L,12L,22L,59L,67L,44L,38L,73L,79L,88L,83L,160L,71L,78L,81L,129L,70L,131L,210L,297L,89L,312L,189L,234L,254L,394L,143L,252L,220L,186L,304L,329L,299L,230L,360L,295L,466L,383L,193L,679L,218L,340L,561L,229L,427L,531L,575L,512L,547L,1328L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191147Inst : IEnumerable<long>
{
public static readonly long[] Value=A191147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191147.Bytes);
public long this[int i]=>Value[i];

public static A191147Inst Instance=new A191147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191146
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,14L,16L,22L,28L,38L,40L,46L,54L,62L,64L,72L,82L,86L,110L,112L,118L,136L,150L,158L,160L,182L,184L,190L,200L,214L,244L,246L,254L,256L,326L,328L,334L,342L,352L,406L,438L,446L,448L,456L,470L,472L,478L,542L,544L,550L,568L,584L,598L,630L,638L,640L,726L,730L,734L,736L,758L,760L,766L,840L,854L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191146Inst : IEnumerable<long>
{
public static readonly long[] Value=A191146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191146.Bytes);
public long this[int i]=>Value[i];

public static A191146Inst Instance=new A191146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191145
{
public static readonly long[] Value={ 1L,5L,7L,17L,23L,31L,53L,71L,95L,127L,161L,215L,287L,383L,485L,511L,647L,863L,1151L,1457L,1535L,1943L,2047L,2591L,3455L,4373L,4607L,5831L,6143L,7775L,8191L,10367L,13121L,13823L,17495L,18431L,23327L,24575L,31103L,32767L,39365L,41471L,52487L,55295L,69983L,73727L,93311L,98303L,118097L,124415L,131071L,157463L,165887L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191145Inst : IEnumerable<long>
{
public static readonly long[] Value=A191145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191145.Bytes);
public long this[int i]=>Value[i];

public static A191145Inst Instance=new A191145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191144
{
public static readonly long[] Value={ 1L,5L,6L,17L,20L,22L,26L,53L,62L,68L,70L,80L,82L,90L,106L,161L,188L,206L,212L,214L,242L,248L,250L,272L,274L,282L,320L,322L,330L,362L,426L,485L,566L,620L,638L,644L,646L,728L,746L,752L,754L,818L,824L,826L,848L,850L,858L,962L,968L,970L,992L,994L,1002L,1088L,1090L,1098L,1130L,1280L,1282L,1290L,1322L,1450L,1457L,1700L,1706L,1862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191144Inst : IEnumerable<long>
{
public static readonly long[] Value=A191144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191144.Bytes);
public long this[int i]=>Value[i];

public static A191144Inst Instance=new A191144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191143
{
public static readonly long[] Value={ 1L,5L,17L,21L,53L,65L,69L,85L,161L,197L,209L,213L,257L,261L,277L,341L,485L,593L,629L,641L,645L,773L,785L,789L,833L,837L,853L,1025L,1029L,1045L,1109L,1365L,1457L,1781L,1889L,1925L,1937L,1941L,2321L,2357L,2369L,2373L,2501L,2513L,2517L,2561L,2565L,2581L,3077L,3089L,3093L,3137L,3141L,3157L,3329L,3333L,3349L,3413L,4097L,4101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191143Inst : IEnumerable<long>
{
public static readonly long[] Value=A191143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191143.Bytes);
public long this[int i]=>Value[i];

public static A191143Inst Instance=new A191143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191142
{
public static readonly long[] Value={ 1L,4L,5L,14L,16L,17L,20L,44L,50L,53L,56L,62L,64L,68L,80L,134L,152L,161L,170L,176L,188L,194L,200L,206L,212L,224L,242L,248L,256L,272L,320L,404L,458L,485L,512L,530L,536L,566L,584L,602L,608L,620L,638L,644L,674L,680L,704L,728L,746L,752L,770L,776L,800L,818L,824L,848L,896L,962L,968L,992L,1024L,1088L,1214L,1280L,1376L,1457L,1538L,1592L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191142Inst : IEnumerable<long>
{
public static readonly long[] Value=A191142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191142.Bytes);
public long this[int i]=>Value[i];

public static A191142Inst Instance=new A191142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191141
{
public static readonly long[] Value={ 1L,3L,5L,11L,17L,19L,35L,43L,53L,59L,67L,75L,107L,131L,139L,161L,171L,179L,203L,211L,227L,235L,267L,299L,323L,395L,419L,427L,485L,515L,523L,539L,555L,611L,635L,643L,683L,707L,715L,803L,811L,843L,899L,907L,939L,971L,1067L,1187L,1195L,1259L,1283L,1291L,1457L,1547L,1571L,1579L,1619L,1667L,1675L,1707L,1835L,1907L,1931L,1939L,2051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191141Inst : IEnumerable<long>
{
public static readonly long[] Value=A191141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191141.Bytes);
public long this[int i]=>Value[i];

public static A191141Inst Instance=new A191141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191140
{
public static readonly long[] Value={ 1L,2L,5L,6L,8L,17L,18L,20L,22L,26L,30L,53L,56L,62L,66L,68L,70L,78L,80L,86L,92L,102L,118L,161L,170L,188L,200L,206L,210L,212L,222L,236L,242L,246L,260L,262L,270L,278L,308L,310L,318L,342L,356L,366L,406L,470L,485L,512L,566L,602L,620L,632L,638L,642L,668L,678L,710L,728L,740L,750L,782L,788L,798L,812L,822L,836L,838L,846L,886L,926L,932L,942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191140Inst : IEnumerable<long>
{
public static readonly long[] Value=A191140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191140.Bytes);
public long this[int i]=>Value[i];

public static A191140Inst Instance=new A191140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191139
{
public static readonly long[] Value={ 1L,5L,17L,53L,65L,161L,197L,209L,257L,485L,593L,629L,641L,773L,785L,833L,1025L,1457L,1781L,1889L,1925L,1937L,2321L,2357L,2369L,2501L,2513L,2561L,3077L,3089L,3137L,3329L,4097L,4373L,5345L,5669L,5777L,5813L,5825L,6965L,7073L,7109L,7121L,7505L,7541L,7553L,7685L,7697L,7745L,9233L,9269L,9281L,9413L,9425L,9473L,9989L,10001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191139Inst : IEnumerable<long>
{
public static readonly long[] Value=A191139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191139.Bytes);
public long this[int i]=>Value[i];

public static A191139Inst Instance=new A191139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191138
{
public static readonly long[] Value={ 1L,4L,7L,13L,19L,22L,31L,40L,55L,58L,67L,79L,91L,94L,121L,127L,163L,166L,175L,202L,223L,235L,238L,271L,274L,283L,319L,364L,367L,379L,382L,487L,490L,499L,511L,526L,607L,655L,667L,670L,703L,706L,715L,811L,814L,823L,850L,895L,943L,955L,958L,1087L,1093L,1099L,1102L,1135L,1138L,1147L,1279L,1459L,1462L,1471L,1498L,1519L,1531L,1534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191138Inst : IEnumerable<long>
{
public static readonly long[] Value=A191138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191138.Bytes);
public long this[int i]=>Value[i];

public static A191138Inst Instance=new A191138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191137
{
public static readonly long[] Value={ 1L,4L,6L,13L,18L,19L,26L,40L,54L,55L,58L,74L,78L,79L,106L,121L,162L,163L,166L,175L,218L,222L,223L,234L,235L,238L,298L,314L,318L,319L,364L,426L,486L,487L,490L,499L,526L,650L,654L,655L,666L,667L,670L,702L,703L,706L,715L,874L,890L,894L,895L,938L,942L,943L,954L,955L,958L,1093L,1194L,1258L,1274L,1278L,1279L,1458L,1459L,1462L,1471L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191137Inst : IEnumerable<long>
{
public static readonly long[] Value=A191137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191137.Bytes);
public long this[int i]=>Value[i];

public static A191137Inst Instance=new A191137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191136
{
public static readonly long[] Value={ 1L,4L,5L,13L,16L,17L,21L,40L,49L,52L,53L,64L,65L,69L,85L,121L,148L,157L,160L,161L,193L,196L,197L,208L,209L,213L,256L,257L,261L,277L,341L,364L,445L,472L,481L,484L,485L,580L,589L,592L,593L,625L,628L,629L,640L,641L,645L,769L,772L,773L,784L,785L,789L,832L,833L,837L,853L,1024L,1025L,1029L,1045L,1093L,1109L,1336L,1365L,1417L,1444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191136Inst : IEnumerable<long>
{
public static readonly long[] Value=A191136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191136.Bytes);
public long this[int i]=>Value[i];

public static A191136Inst Instance=new A191136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191135
{
public static readonly long[] Value={ 1L,4L,13L,16L,40L,49L,52L,64L,121L,148L,157L,160L,193L,196L,208L,256L,364L,445L,472L,481L,484L,580L,589L,592L,625L,628L,640L,769L,772L,784L,832L,1024L,1093L,1336L,1417L,1444L,1453L,1456L,1741L,1768L,1777L,1780L,1876L,1885L,1888L,1921L,1924L,1936L,2308L,2317L,2320L,2353L,2356L,2368L,2497L,2500L,2512L,2560L,3073L,3076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191135Inst : IEnumerable<long>
{
public static readonly long[] Value=A191135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191135.Bytes);
public long this[int i]=>Value[i];

public static A191135Inst Instance=new A191135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191134
{
public static readonly long[] Value={ 1L,3L,4L,10L,11L,13L,15L,31L,34L,39L,40L,43L,46L,51L,59L,94L,103L,118L,121L,123L,130L,135L,139L,154L,155L,159L,171L,178L,183L,203L,235L,283L,310L,355L,364L,370L,375L,391L,406L,411L,418L,463L,466L,471L,478L,483L,491L,514L,519L,535L,539L,550L,555L,610L,615L,619L,635L,683L,706L,711L,731L,811L,850L,931L,939L,1066L,1093L,1111L,1126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191134Inst : IEnumerable<long>
{
public static readonly long[] Value=A191134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191134.Bytes);
public long this[int i]=>Value[i];

public static A191134Inst Instance=new A191134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191133
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,13L,14L,19L,22L,26L,40L,43L,50L,54L,58L,67L,74L,79L,86L,102L,121L,130L,151L,158L,163L,170L,175L,198L,202L,214L,223L,230L,238L,259L,266L,294L,307L,314L,342L,364L,391L,406L,454L,475L,482L,490L,511L,518L,526L,595L,602L,607L,630L,643L,650L,670L,678L,691L,698L,715L,778L,790L,799L,806L,854L,883L,890L,918L,922L,943L,950L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191133Inst : IEnumerable<long>
{
public static readonly long[] Value=A191133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191133.Bytes);
public long this[int i]=>Value[i];

public static A191133Inst Instance=new A191133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191132
{
public static readonly long[] Value={ 1L,4L,13L,40L,49L,121L,148L,157L,193L,364L,445L,472L,481L,580L,589L,625L,769L,1093L,1336L,1417L,1444L,1453L,1741L,1768L,1777L,1876L,1885L,1921L,2308L,2317L,2353L,2497L,3073L,3280L,4009L,4252L,4333L,4360L,4369L,5224L,5305L,5332L,5341L,5629L,5656L,5665L,5764L,5773L,5809L,6925L,6952L,6961L,7060L,7069L,7105L,7492L,7501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191132Inst : IEnumerable<long>
{
public static readonly long[] Value=A191132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191132.Bytes);
public long this[int i]=>Value[i];

public static A191132Inst Instance=new A191132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191083
{
public static readonly long[] Value={ 7L,11L,13L,53L,59L,67L,71L,73L,83L,89L,101L,107L,109L,113L,137L,139L,151L,173L,181L,191L,197L,199L,223L,229L,233L,241L,251L,257L,263L,269L,283L,293L,307L,313L,317L,379L,383L,397L,409L,433L,443L,449L,457L,461L,463L,503L,509L,521L,541L,547L,557L,563L,577L,593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191083Inst : IEnumerable<long>
{
public static readonly long[] Value=A191083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191083.Bytes);
public long this[int i]=>Value[i];

public static A191083Inst Instance=new A191083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191082
{
public static readonly long[] Value={ 2L,5L,13L,19L,43L,47L,53L,67L,71L,73L,79L,89L,97L,101L,103L,107L,137L,139L,149L,157L,163L,179L,181L,211L,223L,233L,239L,251L,257L,263L,269L,271L,281L,283L,307L,311L,331L,337L,347L,367L,379L,389L,421L,433L,439L,449L,457L,461L,467L,487L,491L,503L,541L,569L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191082Inst : IEnumerable<long>
{
public static readonly long[] Value=A191082.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191082.Bytes);
public long this[int i]=>Value[i];

public static A191082Inst Instance=new A191082Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191081
{
public static readonly long[] Value={ 3L,7L,17L,29L,37L,41L,43L,47L,53L,59L,61L,71L,103L,107L,109L,113L,127L,137L,139L,149L,157L,173L,191L,193L,197L,199L,211L,227L,229L,233L,251L,271L,293L,307L,311L,331L,349L,353L,359L,373L,379L,401L,409L,419L,443L,449L,461L,463L,491L,503L,509L,521L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191081Inst : IEnumerable<long>
{
public static readonly long[] Value=A191081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191081.Bytes);
public long this[int i]=>Value[i];

public static A191081Inst Instance=new A191081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191080
{
public static readonly long[] Value={ 5L,7L,11L,17L,23L,31L,43L,59L,61L,73L,83L,97L,113L,139L,149L,151L,157L,181L,191L,193L,197L,211L,223L,227L,233L,241L,257L,263L,271L,277L,283L,293L,311L,317L,373L,409L,457L,461L,463L,487L,503L,509L,521L,523L,547L,557L,569L,571L,577L,587L,599L,631L,641L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191080Inst : IEnumerable<long>
{
public static readonly long[] Value=A191080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191080.Bytes);
public long this[int i]=>Value[i];

public static A191080Inst Instance=new A191080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191079
{
public static readonly long[] Value={ 7L,11L,13L,17L,23L,31L,41L,47L,53L,59L,61L,67L,97L,113L,127L,137L,139L,149L,163L,173L,181L,193L,197L,211L,227L,239L,241L,257L,269L,281L,283L,307L,317L,331L,337L,347L,349L,353L,383L,389L,397L,401L,421L,433L,439L,443L,449L,457L,461L,467L,479L,487L,491L,523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191079Inst : IEnumerable<long>
{
public static readonly long[] Value=A191079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191079.Bytes);
public long this[int i]=>Value[i];

public static A191079Inst Instance=new A191079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191078
{
public static readonly long[] Value={ 3L,11L,13L,23L,29L,31L,41L,83L,89L,109L,113L,127L,137L,149L,157L,173L,179L,193L,199L,211L,227L,233L,241L,263L,271L,283L,293L,307L,311L,331L,337L,379L,389L,397L,409L,421L,439L,457L,463L,467L,479L,487L,491L,499L,521L,523L,541L,563L,571L,587L,601L,617L,643L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191078Inst : IEnumerable<long>
{
public static readonly long[] Value=A191078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191078.Bytes);
public long this[int i]=>Value[i];

public static A191078Inst Instance=new A191078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191077
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,31L,41L,43L,53L,61L,79L,97L,101L,109L,113L,137L,139L,179L,191L,197L,229L,233L,239L,251L,271L,281L,311L,313L,331L,337L,347L,353L,367L,373L,379L,383L,401L,409L,433L,443L,463L,487L,499L,503L,521L,541L,547L,563L,577L,587L,593L,599L,631L,641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191077Inst : IEnumerable<long>
{
public static readonly long[] Value=A191077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191077.Bytes);
public long this[int i]=>Value[i];

public static A191077Inst Instance=new A191077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191076
{
public static readonly long[] Value={ 5L,17L,19L,23L,59L,67L,73L,79L,89L,101L,107L,109L,127L,131L,137L,149L,151L,157L,163L,167L,173L,199L,211L,223L,227L,239L,241L,263L,271L,283L,293L,307L,313L,317L,337L,349L,353L,367L,373L,379L,383L,397L,401L,409L,419L,421L,433L,443L,449L,457L,463L,467L,487L,541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191076Inst : IEnumerable<long>
{
public static readonly long[] Value=A191076.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191076.Bytes);
public long this[int i]=>Value[i];

public static A191076Inst Instance=new A191076Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191075
{
public static readonly long[] Value={ 2L,11L,13L,23L,31L,37L,43L,47L,61L,67L,73L,83L,89L,97L,101L,103L,109L,113L,131L,149L,151L,157L,173L,179L,191L,211L,227L,229L,233L,269L,283L,313L,337L,347L,349L,353L,367L,397L,401L,409L,419L,421L,431L,443L,457L,463L,467L,503L,509L,541L,563L,569L,571L,587L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191075Inst : IEnumerable<long>
{
public static readonly long[] Value=A191075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191075.Bytes);
public long this[int i]=>Value[i];

public static A191075Inst Instance=new A191075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191074
{
public static readonly long[] Value={ 3L,19L,23L,29L,37L,41L,47L,53L,61L,67L,79L,97L,101L,103L,109L,113L,131L,137L,139L,149L,151L,157L,163L,211L,223L,239L,241L,257L,271L,281L,313L,317L,349L,353L,359L,367L,383L,397L,409L,431L,433L,439L,443L,461L,463L,467L,479L,487L,491L,541L,569L,571L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191074Inst : IEnumerable<long>
{
public static readonly long[] Value=A191074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191074.Bytes);
public long this[int i]=>Value[i];

public static A191074Inst Instance=new A191074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191073
{
public static readonly long[] Value={ 2L,7L,31L,37L,47L,53L,59L,61L,73L,79L,83L,89L,97L,101L,109L,137L,139L,149L,163L,179L,181L,191L,193L,199L,211L,239L,241L,251L,257L,263L,277L,281L,283L,293L,313L,337L,353L,359L,367L,379L,383L,389L,397L,439L,443L,461L,467L,487L,491L,499L,509L,541L,547L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191073Inst : IEnumerable<long>
{
public static readonly long[] Value=A191073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191073.Bytes);
public long this[int i]=>Value[i];

public static A191073Inst Instance=new A191073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191072
{
public static readonly long[] Value={ 5L,11L,13L,19L,23L,29L,31L,41L,43L,67L,73L,107L,109L,113L,127L,137L,139L,151L,163L,167L,179L,181L,193L,199L,211L,223L,227L,229L,233L,257L,281L,293L,311L,313L,317L,349L,359L,367L,373L,389L,409L,419L,421L,433L,443L,449L,461L,463L,467L,499L,503L,509L,547L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191072Inst : IEnumerable<long>
{
public static readonly long[] Value=A191072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191072.Bytes);
public long this[int i]=>Value[i];

public static A191072Inst Instance=new A191072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191071
{
public static readonly long[] Value={ 3L,7L,13L,17L,29L,59L,79L,89L,97L,101L,103L,113L,131L,137L,139L,163L,173L,179L,191L,197L,199L,211L,241L,263L,269L,277L,281L,307L,313L,317L,331L,337L,347L,349L,359L,367L,383L,397L,401L,431L,433L,443L,457L,461L,479L,491L,499L,503L,509L,521L,541L,547L,569L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191071Inst : IEnumerable<long>
{
public static readonly long[] Value=A191071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191071.Bytes);
public long this[int i]=>Value[i];

public static A191071Inst Instance=new A191071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191070
{
public static readonly long[] Value={ 7L,17L,19L,23L,29L,31L,37L,53L,67L,73L,97L,101L,107L,109L,113L,131L,151L,163L,173L,179L,191L,193L,223L,229L,233L,241L,251L,257L,263L,269L,271L,307L,311L,331L,347L,349L,379L,389L,397L,409L,419L,421L,443L,457L,463L,467L,487L,491L,499L,503L,521L,541L,563L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191070Inst : IEnumerable<long>
{
public static readonly long[] Value=A191070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191070.Bytes);
public long this[int i]=>Value[i];

public static A191070Inst Instance=new A191070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191069
{
public static readonly long[] Value={ 5L,11L,31L,41L,43L,61L,71L,79L,83L,89L,97L,101L,103L,113L,127L,131L,139L,149L,151L,157L,163L,167L,193L,197L,223L,229L,241L,251L,257L,277L,281L,283L,337L,347L,349L,383L,389L,397L,401L,409L,419L,431L,433L,439L,443L,449L,461L,467L,487L,491L,499L,521L,541L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191069Inst : IEnumerable<long>
{
public static readonly long[] Value=A191069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191069.Bytes);
public long this[int i]=>Value[i];

public static A191069Inst Instance=new A191069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191068
{
public static readonly long[] Value={ 2L,19L,23L,31L,37L,41L,43L,53L,59L,61L,67L,89L,101L,107L,113L,127L,131L,137L,139L,163L,181L,193L,197L,199L,229L,233L,241L,251L,263L,269L,271L,277L,311L,317L,337L,347L,349L,373L,409L,419L,439L,443L,457L,461L,463L,479L,487L,509L,521L,547L,557L,601L,613L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191068Inst : IEnumerable<long>
{
public static readonly long[] Value=A191068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191068.Bytes);
public long this[int i]=>Value[i];

public static A191068Inst Instance=new A191068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191019
{
public static readonly long[] Value={ 5L,7L,11L,17L,23L,43L,47L,61L,73L,83L,101L,131L,137L,139L,149L,157L,163L,191L,197L,199L,229L,233L,239L,251L,263L,271L,277L,283L,311L,313L,347L,349L,353L,359L,367L,389L,397L,419L,443L,457L,461L,463L,467L,479L,491L,499L,503L,541L,557L,571L,577L,587L,593L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191019Inst : IEnumerable<long>
{
public static readonly long[] Value=A191019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191019.Bytes);
public long this[int i]=>Value[i];

public static A191019Inst Instance=new A191019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191018
{
public static readonly long[] Value={ 2L,17L,19L,23L,31L,47L,53L,61L,79L,83L,107L,109L,113L,137L,139L,151L,167L,173L,181L,197L,199L,211L,227L,229L,233L,241L,257L,263L,271L,293L,317L,331L,347L,349L,353L,379L,383L,409L,421L,439L,443L,467L,499L,503L,541L,557L,563L,571L,587L,593L,601L,617L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191018Inst : IEnumerable<long>
{
public static readonly long[] Value=A191018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191018.Bytes);
public long this[int i]=>Value[i];

public static A191018Inst Instance=new A191018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191017
{
public static readonly long[] Value={ 3L,5L,13L,19L,23L,59L,61L,71L,79L,83L,101L,113L,127L,131L,137L,139L,151L,157L,173L,181L,191L,193L,227L,229L,233L,239L,251L,263L,269L,281L,283L,293L,307L,337L,349L,359L,397L,401L,419L,431L,449L,457L,461L,463L,467L,487L,509L,523L,563L,569L,587L,599L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191017Inst : IEnumerable<long>
{
public static readonly long[] Value=A191017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191017.Bytes);
public long this[int i]=>Value[i];

public static A191017Inst Instance=new A191017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191016
{
public static readonly BigInteger[] Value={ 1L,1L,2L,8L,38L,238L,1558L,10966L,106334L,1050974L,10295324L,114643744L,1426970188L,19128627772L,301484330492L,4785515966492L,75490216911932L,1287754035291964L,23735661951947896L,462001846720538656L,9472366452963142856UL,BigInteger.Parse("202869898263715663016"),BigInteger.Parse("4536294970208910412232"),BigInteger.Parse("107194755891965843670088"),BigInteger.Parse("2634562640821884269137768") };
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
public class A191016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191016Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191016.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191016Inst Instance=new A191016Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191015
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,7L,9L,12L,18L,25L,32L,47L,61L,79L,108L,143L,182L,246L,315L,404L,526L,674L,849L,1102L,1389L,1745L,2215L,2788L,3467L,4384L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191015Inst : IEnumerable<long>
{
public static readonly long[] Value=A191015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191015.Bytes);
public long this[int i]=>Value[i];

public static A191015Inst Instance=new A191015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191014
{
public static readonly ulong[] Value={ 0L,1L,10L,102L,1040L,10604L,108120L,1102408L,11240320L,114608016L,1168560800L,11914824032L,121485361920L,1238683267264L,12629803396480L,128775400499328L,1313013611786240L,13387686918861056L,136502896412183040L,1391804337959552512L,14191049172419891200UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191014Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A191014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191014.Bytes);
public ulong this[int i]=>Value[i];

public static A191014Inst Instance=new A191014Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191013
{
public static readonly long[] Value={ 1L,5L,9L,29L,61L,119L,249L,507L,1017L,2045L,4047L,8181L,16381L,32765L,65521L,131069L,262137L,524277L,1048567L,2097145L,4194285L,8388597L,16777185L,33554421L,67108821L,134217725L,268435405L,536870909L,1073741811L,2147483619L,4294967275L,8589934569L,17179869177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191013Inst : IEnumerable<long>
{
public static readonly long[] Value=A191013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191013.Bytes);
public long this[int i]=>Value[i];

public static A191013Inst Instance=new A191013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191012
{
public static readonly long[] Value={ 0L,1L,22L,183L,820L,2605L,6666L,14707L,29128L,53145L,90910L,147631L,229692L,344773L,501970L,711915L,986896L,1340977L,1790118L,2352295L,3047620L,3898461L,4929562L,6168163L,7644120L,9390025L,11441326L,13836447L,16616908L,19827445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191012Inst : IEnumerable<long>
{
public static readonly long[] Value=A191012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191012.Bytes);
public long this[int i]=>Value[i];

public static A191012Inst Instance=new A191012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191011
{
public static readonly long[] Value={ 0L,1L,-1L,-1L,6L,9L,-120L,-225L,5040L,11025L,-362880L,-893025L,39916800L,108056025L,-6227020800L,-18261468225L,1307674368000L,4108830350625L,-355687428096000L,-1187451971330625L,121645100408832000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191011Inst : IEnumerable<long>
{
public static readonly long[] Value=A191011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191011.Bytes);
public long this[int i]=>Value[i];

public static A191011Inst Instance=new A191011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191010
{
public static readonly long[] Value={ 1L,7L,41L,215L,1065L,5079L,23593L,107479L,482345L,2139095L,9395241L,40936407L,177167401L,762356695L,3264175145L,13915694039L,59098749993L,250138895319L,1055531162665L,4442026976215L,18647717207081L,78109306037207L,326510972984361L,1362338887279575L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191010Inst : IEnumerable<long>
{
public static readonly long[] Value=A191010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191010.Bytes);
public long this[int i]=>Value[i];

public static A191010Inst Instance=new A191010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191009
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,3L,1L,3L,0L,4L,0L,3L,4L,7L,0L,3L,0L,2L,4L,3L,0L,0L,1L,3L,4L,0L,0L,12L,0L,15L,4L,3L,6L,1L,0L,3L,4L,10L,0L,12L,0L,18L,3L,3L,0L,4L,1L,18L,4L,20L,0L,12L,6L,8L,4L,3L,0L,18L,0L,3L,20L,31L,6L,12L,0L,24L,4L,4L,0L,15L,0L,3L,24L,26L,8L,12L,0L,26L,13L,3L,0L,14L,6L,3L,4L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191009Inst : IEnumerable<long>
{
public static readonly long[] Value=A191009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191009.Bytes);
public long this[int i]=>Value[i];

public static A191009Inst Instance=new A191009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191008
{
public static readonly long[] Value={ 1L,5L,22L,86L,319L,1139L,3964L,13532L,45517L,151313L,498226L,1627538L,5281195L,17039327L,54705208L,174877304L,556916953L,1767605981L,5593383310L,17651846030L,55570626391L,174557144075L,547207226932L,1712229064916L,5348509347109L,16680994498409L,51949382866474L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191008Inst : IEnumerable<long>
{
public static readonly long[] Value=A191008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191008.Bytes);
public long this[int i]=>Value[i];

public static A191008Inst Instance=new A191008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191007
{
public static readonly long[] Value={ 3L,9L,27L,69L,171L,405L,939L,2133L,4779L,10581L,23211L,50517L,109227L,234837L,502443L,1070421L,2271915L,4805973L,10136235L,21321045L,44739243L,93672789L,195734187L,408245589L,850045611L,1767200085L,3668617899L,7605671253L,15748213419L,32570168661L,67287820971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191007Inst : IEnumerable<long>
{
public static readonly long[] Value=A191007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191007.Bytes);
public long this[int i]=>Value[i];

public static A191007Inst Instance=new A191007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191006
{
public static readonly BigInteger[] Value={ 1L,2L,6L,24L,144L,1296L,16848L,320112L,8963136L,367488576L,22049314560L,1940339681280L,250303818885120L,47307421769287680L,13104155830092687360UL,BigInteger.Parse("5320287267017631068160"),BigInteger.Parse("3165570923875490485555200") };
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
public class A191006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191006Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191006.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191006Inst Instance=new A191006Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191005
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,48L,325L,2640L,24997L,270592L,3295017L,44582400L,663532001L,10773295104L,189494874413L,3589475821568L,72849709631805L,1577078610001920L,36275031333172945L,883457851718762496L,BigInteger.Parse("22711455593084360761"),BigInteger.Parse("614582936996534026240") };
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
public class A191005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191005Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191005.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191005Inst Instance=new A191005Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191004
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,3L,2L,3L,3L,2L,1L,1L,2L,2L,1L,1L,1L,2L,2L,4L,2L,2L,2L,2L,2L,2L,1L,1L,2L,4L,3L,5L,4L,1L,4L,1L,2L,3L,2L,2L,2L,3L,1L,4L,1L,2L,4L,2L,2L,3L,1L,2L,4L,5L,3L,3L,1L,4L,3L,2L,3L,5L,3L,4L,8L,2L,2L,7L,4L,4L,5L,2L,2L,6L,3L,3L,4L,4L,2L,4L,2L,1L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191004Inst : IEnumerable<long>
{
public static readonly long[] Value=A191004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191004.Bytes);
public long this[int i]=>Value[i];

public static A191004Inst Instance=new A191004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190731
{
public static readonly long[] Value={ 23L,37L,53L,73L,127L,131L,137L,139L,151L,157L,173L,179L,223L,229L,233L,239L,331L,337L,421L,431L,433L,457L,523L,631L,677L,733L,739L,751L,773L,823L,829L,839L,853L,859L,937L,977L,1117L,1171L,1193L,1213L,1279L,1433L,1471L,1493L,1579L,1637L,1697L,1733L,1873L,1879L,1997L,2131L,2137L,2239L,2293L,2437L,2539L,2593L,2731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190731Inst : IEnumerable<long>
{
public static readonly long[] Value=A190731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190731.Bytes);
public long this[int i]=>Value[i];

public static A190731Inst Instance=new A190731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190730
{
public static readonly long[] Value={ 3L,16L,53L,146L,367L,876L,2025L,4582L,10211L,22496L,49117L,106458L,229335L,491476L,1048529L,2228174L,4718539L,9961416L,20971461L,44040130L,92274623L,192937916L,402653113L,838860726L,1744830387L,3623878576L,7516192685L,15569256362L,32212254631L,66571992996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190730Inst : IEnumerable<long>
{
public static readonly long[] Value=A190730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190730.Bytes);
public long this[int i]=>Value[i];

public static A190730Inst Instance=new A190730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190729
{
public static readonly long[] Value={ 1L,1L,1L,2L,6L,16L,46L,176L,722L,2906L,13106L,66716L,345676L,1849992L,10802156L,66543296L,418075036L,2750329276L,19145683612L,137410493656L,1012831509736L,7785886770656L,62105849642376L,507682088621632L,4271236045340056L,37171085370443576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190729Inst : IEnumerable<long>
{
public static readonly long[] Value=A190729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190729.Bytes);
public long this[int i]=>Value[i];

public static A190729Inst Instance=new A190729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190728
{
public static readonly long[] Value={ 5L,4L,17L,26L,13L,18L,65L,28L,101L,122L,49L,22L,165L,76L,257L,290L,109L,68L,401L,67L,485L,530L,193L,626L,529L,244L,177L,842L,301L,439L,1025L,364L,1157L,226L,433L,581L,429L,22L,1601L,1682L,361L,423L,1937L,676L,2117L,2210L,769L,1047L,2501L,868L,529L,2810L,973L,3026L,961L,292L,3365L,3482L,1201L,1660L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190728Inst : IEnumerable<long>
{
public static readonly long[] Value=A190728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190728.Bytes);
public long this[int i]=>Value[i];

public static A190728Inst Instance=new A190728Inst();

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