using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A080377
{
public static readonly long[] Value={ 2L,4L,6L,8L,14L,10L,18L,22L,34L,16L,26L,32L,38L,50L,62L,54L,58L,46L,64L,86L,82L,74L,98L,106L,94L,118L,122L,128L,146L,134L,142L,162L,178L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080377Inst : IEnumerable<long>
{
public static readonly long[] Value=A080377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080377.Bytes);
public long this[int i]=>Value[i];

public static A080377Inst Instance=new A080377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080378
{
public static readonly long[] Value={ 1L,2L,2L,0L,2L,0L,2L,0L,2L,2L,2L,0L,2L,0L,2L,2L,2L,2L,0L,2L,2L,0L,2L,0L,0L,2L,0L,2L,0L,2L,0L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,2L,2L,0L,2L,0L,0L,0L,2L,0L,2L,2L,2L,2L,2L,2L,2L,2L,0L,2L,2L,2L,0L,2L,0L,2L,2L,2L,2L,0L,2L,0L,2L,2L,0L,2L,0L,0L,0L,2L,2L,2L,2L,2L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,0L,2L,2L,2L,2L,2L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080378Inst : IEnumerable<long>
{
public static readonly long[] Value=A080378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080378.Bytes);
public long this[int i]=>Value[i];

public static A080378Inst Instance=new A080378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080379
{
public static readonly long[] Value={ 5L,2L,9L,15L,39L,32L,305L,51L,2631L,3685L,170L,1156L,8775L,98L,5295L,41914L,106469L,167115L,186917L,1098776L,187784L,976193L,1166047L,423098L,77442332L,2643158L,11004239L,36330320L,259652255L,307899596L,2573725031L,411764049L,4080634008L,14841740642L,6022532018L,17035372732L,35045523209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080379Inst : IEnumerable<long>
{
public static readonly long[] Value=A080379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080379.Bytes);
public long this[int i]=>Value[i];

public static A080379Inst Instance=new A080379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080380
{
public static readonly long[] Value={ 4L,24L,46L,153L,1480L,90L,3875L,1395L,16591L,61457L,240748L,21355L,772038L,613491L,804584L,6067263L,16791134L,16138563L,37593808L,250379098L,73857828L,124789332L,56307979L,3295708683L,3511121443L,27497699943L,64430269615L,26284355567L,118413975572L,225822728018L,4645422093L,118027458557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080380Inst : IEnumerable<long>
{
public static readonly long[] Value=A080380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080380.Bytes);
public long this[int i]=>Value[i];

public static A080380Inst Instance=new A080380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080381
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,2L,6L,2L,1L,1L,5L,10L,10L,5L,1L,1L,2L,5L,20L,5L,2L,1L,1L,7L,7L,35L,35L,7L,7L,1L,1L,2L,14L,14L,70L,14L,14L,2L,1L,1L,9L,18L,42L,126L,126L,42L,18L,9L,1L,1L,2L,9L,12L,42L,252L,42L,12L,9L,2L,1L,1L,11L,11L,33L,66L,462L,462L,66L,33L,11L,11L,1L,1L,12L,66L,44L,33L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080381Inst : IEnumerable<long>
{
public static readonly long[] Value=A080381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080381.Bytes);
public long this[int i]=>Value[i];

public static A080381Inst Instance=new A080381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080382
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,1L,3L,6L,3L,1L,3L,6L,10L,2L,1L,1L,2L,10L,20L,10L,4L,1L,4L,10L,20L,35L,5L,5L,1L,1L,5L,5L,35L,70L,35L,5L,5L,1L,5L,5L,35L,70L,126L,14L,7L,3L,1L,1L,3L,7L,14L,126L,252L,126L,28L,21L,6L,1L,6L,21L,28L,126L,252L,462L,42L,42L,14L,7L,1L,1L,7L,14L,42L,42L,462L,924L,77L,14L,21L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080382Inst : IEnumerable<long>
{
public static readonly long[] Value=A080382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080382.Bytes);
public long this[int i]=>Value[i];

public static A080382Inst Instance=new A080382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080383
{
public static readonly long[] Value={ 1L,2L,3L,4L,3L,6L,3L,6L,3L,6L,3L,6L,7L,10L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,8L,3L,6L,3L,6L,7L,10L,3L,6L,3L,6L,3L,8L,3L,6L,5L,10L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,7L,10L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L,7L,10L,3L,6L,3L,6L,7L,10L,3L,6L,3L,6L,3L,6L,3L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080383Inst : IEnumerable<long>
{
public static readonly long[] Value=A080383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080383.Bytes);
public long this[int i]=>Value[i];

public static A080383Inst Instance=new A080383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080384
{
public static readonly long[] Value={ 5L,7L,9L,11L,15L,17L,19L,21L,23L,27L,29L,33L,35L,39L,43L,45L,47L,49L,51L,53L,55L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,87L,89L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,135L,137L,139L,141L,143L,145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080384Inst : IEnumerable<long>
{
public static readonly long[] Value=A080384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080384.Bytes);
public long this[int i]=>Value[i];

public static A080384Inst Instance=new A080384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080385
{
public static readonly long[] Value={ 12L,30L,56L,84L,90L,132L,154L,182L,220L,252L,280L,306L,312L,340L,374L,380L,408L,418L,440L,456L,462L,476L,532L,552L,598L,616L,624L,630L,644L,650L,660L,690L,756L,828L,840L,858L,870L,880L,884L,900L,918L,936L,952L,966L,986L,992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080385Inst : IEnumerable<long>
{
public static readonly long[] Value=A080385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080385.Bytes);
public long this[int i]=>Value[i];

public static A080385Inst Instance=new A080385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080386
{
public static readonly long[] Value={ 25L,37L,169L,199L,201L,241L,397L,433L,547L,685L,865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080386Inst : IEnumerable<long>
{
public static readonly long[] Value=A080386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080386.Bytes);
public long this[int i]=>Value[i];

public static A080386Inst Instance=new A080386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080387
{
public static readonly long[] Value={ 13L,31L,41L,57L,85L,91L,133L,155L,177L,183L,209L,221L,253L,281L,307L,313L,341L,375L,381L,409L,419L,441L,457L,463L,477L,481L,533L,553L,599L,617L,625L,631L,645L,651L,661L,691L,737L,757L,829L,841L,859L,871L,881L,885L,901L,919L,929L,937L,953L,967L,987L,993L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080387Inst : IEnumerable<long>
{
public static readonly long[] Value=A080387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080387.Bytes);
public long this[int i]=>Value[i];

public static A080387Inst Instance=new A080387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080388
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,1L,6L,1L,2L,3L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,2L,1L,4L,1L,30L,1L,1L,3L,2L,5L,6L,1L,2L,3L,10L,1L,6L,1L,4L,15L,2L,1L,6L,1L,2L,3L,4L,1L,2L,1L,28L,1L,2L,1L,4L,1L,2L,7L,1L,1L,6L,1L,2L,3L,14L,1L,2L,1L,2L,1L,4L,7L,2L,1L,10L,1L,2L,1L,84L,5L,2L,3L,4L,1L,90L,7L,4L,3L,2L,5L,6L,1L,2L,9L,4L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080388Inst : IEnumerable<long>
{
public static readonly long[] Value=A080388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080388.Bytes);
public long this[int i]=>Value[i];

public static A080388Inst Instance=new A080388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080389
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,10L,12L,15L,16L,18L,20L,22L,24L,26L,28L,30L,31L,36L,40L,42L,46L,48L,52L,54L,56L,58L,60L,63L,64L,66L,70L,72L,74L,78L,80L,82L,88L,96L,100L,102L,106L,108L,112L,114L,118L,120L,124L,126L,127L,130L,132L,136L,138L,148L,150L,156L,162L,166L,168L,170L,172L,178L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080389Inst : IEnumerable<long>
{
public static readonly long[] Value=A080389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080389.Bytes);
public long this[int i]=>Value[i];

public static A080389Inst Instance=new A080389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080390
{
public static readonly long[] Value={ 1L,5L,14L,27L,34L,11L,62L,183L,98L,39L,142L,107L,220L,69L,44L,495L,322L,143L,436L,139L,482L,637L,574L,119L,674L,233L,782L,55L,898L,29L,1146L,4063L,230L,441L,174L,467L,1516L,493L,662L,239L,1762L,377L,2020L,175L,764L,781L,2302L,2543L,2596L,949L,968L,207L,3126L,1241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080390Inst : IEnumerable<long>
{
public static readonly long[] Value=A080390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080390.Bytes);
public long this[int i]=>Value[i];

public static A080390Inst Instance=new A080390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080391
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,4L,5L,3L,6L,6L,7L,6L,7L,6L,7L,4L,8L,5L,7L,4L,5L,6L,7L,4L,5L,8L,9L,8L,9L,8L,9L,4L,8L,7L,9L,10L,13L,12L,13L,13L,18L,9L,11L,8L,9L,8L,9L,7L,9L,8L,9L,8L,9L,4L,5L,8L,9L,12L,13L,4L,5L,4L,5L,4L,9L,9L,12L,9L,11L,8L,9L,4L,5L,4L,5L,10L,11L,8L,9L,7L,9L,14L,15L,14L,15L,14L,15L,12L,13L,12L,13L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080391Inst : IEnumerable<long>
{
public static readonly long[] Value=A080391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080391.Bytes);
public long this[int i]=>Value[i];

public static A080391Inst Instance=new A080391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080392
{
public static readonly long[] Value={ 2L,420L,920L,1122L,1218L,1892L,1978L,2444L,2914L,3198L,3782L,4028L,4136L,4292L,4664L,4958L,4960L,5330L,5762L,5986L,6020L,6032L,6710L,6834L,6864L,6882L,6954L,6956L,6968L,7106L,7130L,7140L,7238L,7254L,7448L,7616L,8178L,8190L,8400L,8692L,9462L,9506L,10712L,11060L,11288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080392Inst : IEnumerable<long>
{
public static readonly long[] Value=A080392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080392.Bytes);
public long this[int i]=>Value[i];

public static A080392Inst Instance=new A080392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080393
{
public static readonly long[] Value={ 0L,1L,2L,3L,40L,5L,12L,25L,1122L,13L,420L,1103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080393Inst : IEnumerable<long>
{
public static readonly long[] Value=A080393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080393.Bytes);
public long this[int i]=>Value[i];

public static A080393Inst Instance=new A080393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080394
{
public static readonly long[] Value={ 1L,195L,273L,357L,385L,399L,585L,627L,665L,897L,935L,945L,957L,975L,1071L,1085L,1155L,1209L,1235L,1395L,1547L,1581L,1595L,1705L,1771L,1848L,1881L,1925L,1935L,1995L,2035L,2091L,2193L,2255L,2295L,2331L,2365L,2405L,2475L,2574L,2583L,2585L,2639L,2665L,2679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080394Inst : IEnumerable<long>
{
public static readonly long[] Value=A080394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080394.Bytes);
public long this[int i]=>Value[i];

public static A080394Inst Instance=new A080394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080395
{
public static readonly long[] Value={ 1848L,2574L,4004L,4290L,6732L,7480L,8398L,12012L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080395Inst : IEnumerable<long>
{
public static readonly long[] Value=A080395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080395.Bytes);
public long this[int i]=>Value[i];

public static A080395Inst Instance=new A080395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080396
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,1L,2L,6L,2L,1L,1L,5L,10L,10L,5L,1L,1L,6L,15L,10L,15L,6L,1L,1L,7L,21L,35L,35L,21L,7L,1L,1L,2L,14L,14L,70L,14L,14L,2L,1L,1L,3L,6L,42L,42L,42L,42L,6L,3L,1L,1L,10L,15L,30L,210L,42L,210L,30L,15L,10L,1L,1L,11L,55L,165L,330L,462L,462L,330L,165L,55L,11L,1L,1L,6L,66L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080396Inst : IEnumerable<long>
{
public static readonly long[] Value=A080396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080396.Bytes);
public long this[int i]=>Value[i];

public static A080396Inst Instance=new A080396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080397
{
public static readonly long[] Value={ 1L,2L,6L,10L,70L,42L,462L,858L,4290L,24310L,92378L,176358L,1352078L,520030L,222870L,6463230L,200360130L,129644790L,907513530L,1767263190L,22974421470L,134564468610L,526024740930L,22870640910L,1074920122770L,1504888171878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080397Inst : IEnumerable<long>
{
public static readonly long[] Value=A080397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080397.Bytes);
public long this[int i]=>Value[i];

public static A080397Inst Instance=new A080397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080398
{
public static readonly long[] Value={ 1L,3L,2L,7L,6L,6L,2L,15L,13L,6L,6L,14L,14L,6L,6L,31L,6L,39L,10L,42L,2L,6L,6L,30L,31L,42L,10L,14L,30L,6L,2L,21L,6L,6L,6L,91L,38L,30L,14L,30L,42L,6L,22L,42L,78L,6L,6L,62L,57L,93L,6L,14L,6L,30L,6L,30L,10L,30L,30L,42L,62L,6L,26L,127L,42L,6L,34L,42L,6L,6L,6L,195L,74L,114L,62L,70L,6L,42L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080398Inst : IEnumerable<long>
{
public static readonly long[] Value=A080398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080398.Bytes);
public long this[int i]=>Value[i];

public static A080398Inst Instance=new A080398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080399
{
public static readonly long[] Value={ 1L,5L,10L,21L,26L,10L,10L,85L,91L,130L,122L,210L,170L,10L,130L,341L,290L,455L,362L,546L,10L,610L,530L,170L,651L,170L,410L,210L,842L,130L,962L,1365L,610L,290L,130L,273L,1370L,1810L,170L,2210L,58L,10L,370L,2562L,182L,530L,2210L,3410L,2451L,3255L,290L,3570L,2810L,410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080399Inst : IEnumerable<long>
{
public static readonly long[] Value=A080399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080399.Bytes);
public long this[int i]=>Value[i];

public static A080399Inst Instance=new A080399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080400
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,2L,6L,2L,6L,2L,10L,2L,6L,6L,2L,2L,2L,6L,6L,2L,6L,10L,22L,2L,10L,6L,6L,6L,14L,2L,30L,2L,10L,2L,6L,6L,6L,6L,6L,2L,10L,6L,42L,10L,6L,22L,46L,2L,42L,10L,2L,6L,26L,6L,10L,6L,6L,14L,58L,2L,30L,30L,6L,2L,6L,10L,66L,2L,22L,6L,70L,6L,6L,6L,10L,6L,30L,6L,78L,2L,6L,10L,82L,6L,2L,42L,14L,10L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080400Inst : IEnumerable<long>
{
public static readonly long[] Value=A080400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080400.Bytes);
public long this[int i]=>Value[i];

public static A080400Inst Instance=new A080400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080401
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,9L,10L,11L,12L,13L,16L,17L,18L,19L,20L,22L,23L,25L,29L,31L,32L,37L,38L,40L,44L,47L,48L,49L,50L,52L,53L,58L,59L,61L,62L,64L,67L,68L,71L,72L,73L,75L,76L,79L,80L,83L,88L,89L,92L,97L,98L,99L,101L,103L,109L,113L,116L,117L,118L,121L,122L,124L,127L,128L,131L,137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080401Inst : IEnumerable<long>
{
public static readonly long[] Value=A080401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080401.Bytes);
public long this[int i]=>Value[i];

public static A080401Inst Instance=new A080401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080402
{
public static readonly long[] Value={ 6L,7L,14L,15L,21L,24L,26L,27L,28L,30L,33L,34L,35L,36L,39L,41L,42L,43L,45L,46L,51L,54L,55L,56L,57L,60L,63L,65L,66L,69L,70L,74L,77L,78L,81L,82L,84L,85L,86L,87L,90L,91L,93L,94L,95L,96L,100L,102L,104L,105L,106L,107L,108L,110L,111L,112L,114L,115L,119L,120L,123L,125L,126L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080402Inst : IEnumerable<long>
{
public static readonly long[] Value=A080402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080402.Bytes);
public long this[int i]=>Value[i];

public static A080402Inst Instance=new A080402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080403
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,9L,13L,16L,18L,20L,25L,29L,37L,49L,50L,61L,64L,72L,73L,80L,101L,109L,113L,116L,117L,121L,122L,128L,137L,144L,148L,169L,173L,181L,200L,208L,218L,229L,242L,244L,261L,277L,281L,289L,292L,313L,317L,320L,325L,333L,353L,362L,373L,389L,397L,401L,404L,409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080403Inst : IEnumerable<long>
{
public static readonly long[] Value=A080403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080403.Bytes);
public long this[int i]=>Value[i];

public static A080403Inst Instance=new A080403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080420
{
public static readonly long[] Value={ 1L,7L,36L,162L,675L,2673L,10206L,37908L,137781L,492075L,1732104L,6022998L,20726199L,70681653L,239148450L,803538792L,2683245609L,8910671247L,29443957164L,96855122250L,317297380491L,1035574967097L,3368233731366L,10920608743932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080420Inst : IEnumerable<long>
{
public static readonly long[] Value=A080420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080420.Bytes);
public long this[int i]=>Value[i];

public static A080420Inst Instance=new A080420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080421
{
public static readonly long[] Value={ 1L,10L,66L,360L,1755L,7938L,34020L,139968L,557685L,2165130L,8227494L,30705480L,112842639L,409209570L,1466777160L,5203870272L,18294856425L,63795240522L,220829678730L,759344158440L,2595329855811L,8821564534530L,29832927334956L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080421Inst : IEnumerable<long>
{
public static readonly long[] Value=A080421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080421.Bytes);
public long this[int i]=>Value[i];

public static A080421Inst Instance=new A080421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080422
{
public static readonly long[] Value={ 1L,13L,105L,675L,3780L,19278L,91854L,415530L,1804275L,7577955L,30961359L,123589557L,483611310L,1860043500L,7046907660L,26344593252L,97328636181L,355781149065L,1288173125925L,4623863536215L,16466920464456L,58222325927898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080422Inst : IEnumerable<long>
{
public static readonly long[] Value=A080422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080422.Bytes);
public long this[int i]=>Value[i];

public static A080422Inst Instance=new A080422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080423
{
public static readonly long[] Value={ 1L,16L,153L,1134L,7182L,40824L,214326L,1058508L,4979799L,22517352L,98513415L,419129802L,1741000716L,7083045648L,28296044604L,111232727064L,431026817373L,1648861601184L,6234757929477L,23328137324646L,86451332438394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080423Inst : IEnumerable<long>
{
public static readonly long[] Value=A080423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080423.Bytes);
public long this[int i]=>Value[i];

public static A080423Inst Instance=new A080423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080424
{
public static readonly long[] Value={ 0L,1L,3L,27L,135L,891L,5103L,31347L,185895L,1121931L,6711903L,40330467L,241805655L,1451365371L,8706597903L,52244370387L,313451873415L,1880754287211L,11284396583103L,67706766919107L,406239439253175L,2437440122303451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080424Inst : IEnumerable<long>
{
public static readonly long[] Value=A080424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080424.Bytes);
public long this[int i]=>Value[i];

public static A080424Inst Instance=new A080424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080425
{
public static readonly long[] Value={ 0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080425Inst : IEnumerable<long>
{
public static readonly long[] Value=A080425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080425.Bytes);
public long this[int i]=>Value[i];

public static A080425Inst Instance=new A080425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080426
{
public static readonly long[] Value={ 1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,3L,3L,1L,1L,3L,1L,1L,3L,1L,1L,3L,3L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080426Inst : IEnumerable<long>
{
public static readonly long[] Value=A080426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080426.Bytes);
public long this[int i]=>Value[i];

public static A080426Inst Instance=new A080426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080427
{
public static readonly long[] Value={ 1L,1L,2L,4L,1L,5L,10L,1L,7L,14L,1L,9L,19L,1L,12L,24L,1L,15L,30L,1L,17L,34L,1L,20L,40L,1L,22L,44L,1L,25L,50L,1L,27L,54L,1L,29L,59L,1L,32L,64L,1L,35L,70L,1L,37L,74L,1L,39L,79L,1L,42L,84L,1L,45L,90L,1L,47L,94L,1L,49L,99L,1L,52L,104L,1L,55L,110L,1L,57L,114L,1L,60L,120L,1L,62L,124L,1L,65L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080427Inst : IEnumerable<long>
{
public static readonly long[] Value=A080427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080427.Bytes);
public long this[int i]=>Value[i];

public static A080427Inst Instance=new A080427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080428
{
public static readonly long[] Value={ 3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,3L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080428Inst : IEnumerable<long>
{
public static readonly long[] Value=A080428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080428.Bytes);
public long this[int i]=>Value[i];

public static A080428Inst Instance=new A080428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080429
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,17L,19L,23L,25L,29L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,81L,83L,89L,97L,101L,103L,105L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,169L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080429Inst : IEnumerable<long>
{
public static readonly long[] Value=A080429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080429.Bytes);
public long this[int i]=>Value[i];

public static A080429Inst Instance=new A080429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080430
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,25L,41L,59L,77L,105L,147L,189L,255L,303L,363L,423L,515L,631L,747L,825L,951L,1061L,1091L,1215L,1433L,1595L,1723L,1929L,2119L,2321L,2613L,2771L,2869L,3111L,3443L,3667L,3867L,4115L,4521L,4993L,5397L,5747L,6121L,6393L,6663L,7257L,7423L,7735L,8279L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080430Inst : IEnumerable<long>
{
public static readonly long[] Value=A080430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080430.Bytes);
public long this[int i]=>Value[i];

public static A080430Inst Instance=new A080430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080431
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,14L,18L,22L,26L,32L,34L,38L,46L,50L,58L,60L,62L,74L,82L,86L,94L,98L,106L,118L,122L,134L,142L,146L,158L,162L,166L,168L,178L,194L,202L,206L,214L,218L,226L,242L,254L,256L,262L,274L,278L,298L,302L,308L,314L,326L,334L,338L,346L,358L,360L,362L,382L,386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080431Inst : IEnumerable<long>
{
public static readonly long[] Value=A080431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080431.Bytes);
public long this[int i]=>Value[i];

public static A080431Inst Instance=new A080431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080432
{
public static readonly long[] Value={ 2L,4L,6L,10L,16L,26L,42L,60L,78L,106L,148L,190L,256L,304L,364L,424L,516L,632L,748L,826L,952L,1062L,1092L,1216L,1434L,1596L,1724L,1930L,2120L,2322L,2614L,2772L,2870L,3112L,3444L,3668L,3868L,4116L,4522L,4994L,5398L,5748L,6122L,6394L,6664L,7258L,7424L,7736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080432Inst : IEnumerable<long>
{
public static readonly long[] Value=A080432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080432.Bytes);
public long this[int i]=>Value[i];

public static A080432Inst Instance=new A080432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080433
{
public static readonly long[] Value={ 2L,22L,24L,44L,45L,54L,49L,96L,63L,30L,33L,36L,65L,56L,615L,512L,221L,108L,817L,700L,714L,44L,46L,624L,425L,52L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080433Inst : IEnumerable<long>
{
public static readonly long[] Value=A080433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080433.Bytes);
public long this[int i]=>Value[i];

public static A080433Inst Instance=new A080433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080434
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,11L,48L,494L,252L,510L,272L,272L,216L,171L,0L,168L,22L,161L,696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080434Inst : IEnumerable<long>
{
public static readonly long[] Value=A080434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080434.Bytes);
public long this[int i]=>Value[i];

public static A080434Inst Instance=new A080434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080435
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,13L,14L,19L,20L,23L,25L,27L,31L,37L,43L,47L,49L,50L,55L,57L,61L,67L,73L,75L,79L,85L,91L,97L,98L,103L,107L,109L,111L,115L,121L,127L,131L,133L,135L,139L,140L,145L,151L,157L,163L,169L,175L,181L,185L,187L,193L,199L,200L,205L,211L,212L,217L,223L,229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080435Inst : IEnumerable<long>
{
public static readonly long[] Value=A080435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080435.Bytes);
public long this[int i]=>Value[i];

public static A080435Inst Instance=new A080435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080436
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,100L,121L,132L,143L,154L,105L,176L,187L,108L,1159L,200L,231L,242L,253L,264L,225L,286L,297L,2128L,2059L,300L,341L,352L,363L,374L,315L,396L,3367L,3078L,3159L,400L,451L,462L,473L,484L,405L,4186L,4277L,4128L,4459L,500L,561L,572L,583L,594L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080436Inst : IEnumerable<long>
{
public static readonly long[] Value=A080436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080436.Bytes);
public long this[int i]=>Value[i];

public static A080436Inst Instance=new A080436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080437
{
public static readonly long[] Value={ 2L,3L,5L,7L,101L,103L,107L,109L,223L,229L,311L,307L,401L,433L,457L,503L,509L,601L,607L,701L,733L,709L,823L,809L,907L,10061L,10093L,10007L,10009L,10103L,10247L,10301L,10337L,10369L,10429L,10501L,10567L,10613L,10607L,10723L,10709L,10831L,11941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080437Inst : IEnumerable<long>
{
public static readonly long[] Value=A080437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080437.Bytes);
public long this[int i]=>Value[i];

public static A080437Inst Instance=new A080437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080438
{
public static readonly long[] Value={ 1L,4L,9L,196L,225L,3136L,4489L,6084L,841L,10000L,10201L,10404L,10609L,12996L,27225L,27556L,27889L,39204L,39601L,40000L,40401L,40804L,54289L,54756L,616225L,617796L,71289L,71824L,89401L,90000L,90601L,10036224L,1108809L,10150596L,1525225L,1920996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080438Inst : IEnumerable<long>
{
public static readonly long[] Value=A080438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080438.Bytes);
public long this[int i]=>Value[i];

public static A080438Inst Instance=new A080438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080439
{
public static readonly BigInteger[] Value={ 11L,101L,10061L,100000651L,10000000000060571L,BigInteger.Parse("100000000000000000000000600052761"),BigInteger.Parse("10000000000000000000000000000000000000000000000060000000502271641") };
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
public class A080439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080439Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080439.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080439Inst Instance=new A080439Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080440
{
public static readonly BigInteger[] Value={ 13L,103L,10093L,100000963L,10000000000092653L,BigInteger.Parse("100000000000000000000000902060523"),BigInteger.Parse("10000000000000000000000000000000000000000000000090002000600051233") };
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
public class A080440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080440Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080440.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080440Inst Instance=new A080440Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080441
{
public static readonly BigInteger[] Value={ 17L,107L,10007L,100000007L,10000000000003037L,BigInteger.Parse("100000000000000000000000003000307"),BigInteger.Parse("10000000000000000000000000000000000000000000000000003000000030057") };
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
public class A080441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080441Inst Instance=new A080441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080442
{
public static readonly BigInteger[] Value={ 19L,109L,10009L,100000039L,10000000000002359L,BigInteger.Parse("100000000000000000000000002031519"),BigInteger.Parse("10000000000000000000000000000000000000000000000000002000301050179") };
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
public class A080442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080442Inst Instance=new A080442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080443
{
public static readonly long[] Value={ 3L,5L,11L,29L,83L,7L,43L,199L,6563L,127L,59051L,25307L,48313L,63773L,4782971L,14348909L,119243L,335429L,23203L,10613L,60089L,1224149L,795323L,919L,282429536483L,1583717027L,2541865828331L,693236134999L,174632003473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080443Inst : IEnumerable<long>
{
public static readonly long[] Value=A080443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080443.Bytes);
public long this[int i]=>Value[i];

public static A080443Inst Instance=new A080443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080444
{
public static readonly long[] Value={ 1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,8L,9L,9L,10L,10L,11L,12L,12L,12L,12L,13L,14L,14L,15L,15L,16L,16L,16L,16L,16L,17L,18L,18L,18L,18L,19L,20L,20L,20L,20L,21L,21L,22L,22L,23L,24L,24L,24L,24L,24L,24L,24L,25L,25L,26L,26L,27L,27L,27L,28L,28L,28L,28L,29L,30L,30L,30L,30L,30L,31L,32L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080444Inst : IEnumerable<long>
{
public static readonly long[] Value=A080444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080444.Bytes);
public long this[int i]=>Value[i];

public static A080444Inst Instance=new A080444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080445
{
public static readonly long[] Value={ 1L,11L,121L,1089L,11979L,107811L,1185921L,10673289L,117406179L,1056655611L,11623211721L,104608905489L,1150697960379L,10356281643411L,113919098077521L,1025271882697689L,11277990709674579L,101501916387071211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080445Inst : IEnumerable<long>
{
public static readonly long[] Value=A080445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080445.Bytes);
public long this[int i]=>Value[i];

public static A080445Inst Instance=new A080445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080446
{
public static readonly long[] Value={ 2L,12L,108L,1188L,10692L,117612L,1058508L,11643588L,104792292L,1152715212L,10374436908L,114118805988L,1027069253892L,11297761792812L,101679856135308L,1118478417488388L,10066305757395492L,110729363331350412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080446Inst : IEnumerable<long>
{
public static readonly long[] Value=A080446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080446.Bytes);
public long this[int i]=>Value[i];

public static A080446Inst Instance=new A080446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080447
{
public static readonly long[] Value={ 3L,12L,108L,1188L,10692L,117612L,1058508L,11643588L,104792292L,1152715212L,10374436908L,114118805988L,1027069253892L,11297761792812L,101679856135308L,1118478417488388L,10066305757395492L,110729363331350412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080447Inst : IEnumerable<long>
{
public static readonly long[] Value=A080447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080447.Bytes);
public long this[int i]=>Value[i];

public static A080447Inst Instance=new A080447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080448
{
public static readonly long[] Value={ 4L,12L,108L,1188L,10692L,117612L,1058508L,11643588L,104792292L,1152715212L,10374436908L,114118805988L,1027069253892L,11297761792812L,101679856135308L,1118478417488388L,10066305757395492L,110729363331350412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080448Inst : IEnumerable<long>
{
public static readonly long[] Value=A080448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080448.Bytes);
public long this[int i]=>Value[i];

public static A080448Inst Instance=new A080448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080449
{
public static readonly long[] Value={ 5L,15L,105L,1155L,10395L,114345L,1029105L,11320155L,101881395L,1120695345L,10086258105L,110948839155L,1220437230705L,10983935076345L,120823285839795L,1087409572558155L,11961505298139705L,107653547683257345L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080449Inst : IEnumerable<long>
{
public static readonly long[] Value=A080449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080449.Bytes);
public long this[int i]=>Value[i];

public static A080449Inst Instance=new A080449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080450
{
public static readonly long[] Value={ 6L,12L,108L,1188L,10692L,117612L,1058508L,11643588L,104792292L,1152715212L,10374436908L,114118805988L,1027069253892L,11297761792812L,101679856135308L,1118478417488388L,10066305757395492L,110729363331350412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080450Inst : IEnumerable<long>
{
public static readonly long[] Value=A080450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080450.Bytes);
public long this[int i]=>Value[i];

public static A080450Inst Instance=new A080450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080451
{
public static readonly long[] Value={ 7L,14L,112L,1008L,11088L,121968L,1097712L,12074832L,108673488L,1195408368L,10758675312L,118345428432L,1065108855888L,11716197414768L,105445776732912L,1159903544062032L,10439131896558288L,114830450862141168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080451Inst : IEnumerable<long>
{
public static readonly long[] Value=A080451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080451.Bytes);
public long this[int i]=>Value[i];

public static A080451Inst Instance=new A080451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080452
{
public static readonly long[] Value={ 8L,16L,112L,1008L,11088L,121968L,1097712L,12074832L,108673488L,1195408368L,10758675312L,118345428432L,1065108855888L,11716197414768L,105445776732912L,1159903544062032L,10439131896558288L,114830450862141168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080452Inst : IEnumerable<long>
{
public static readonly long[] Value=A080452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080452.Bytes);
public long this[int i]=>Value[i];

public static A080452Inst Instance=new A080452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080453
{
public static readonly long[] Value={ 9L,18L,108L,1188L,10692L,117612L,1058508L,11643588L,104792292L,1152715212L,10374436908L,114118805988L,1027069253892L,11297761792812L,101679856135308L,1118478417488388L,10066305757395492L,110729363331350412L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080453Inst : IEnumerable<long>
{
public static readonly long[] Value=A080453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080453.Bytes);
public long this[int i]=>Value[i];

public static A080453Inst Instance=new A080453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080454
{
public static readonly BigInteger[] Value={ 0L,10L,21L,3212L,43210L,543210L,6543215L,76543216L,87654321L,9876543210L,109876543216L,11109876543216L,1211109876543216L,131211109876543214L,14131211109876543210UL,BigInteger.Parse("1514131211109876543216"),BigInteger.Parse("1615141312111098765432108") };
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
public class A080454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080454Inst Instance=new A080454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080455
{
public static readonly long[] Value={ 1L,5L,9L,13L,13L,17L,21L,25L,25L,29L,33L,37L,37L,41L,45L,49L,49L,53L,57L,61L,61L,65L,69L,73L,73L,77L,81L,85L,85L,89L,93L,97L,97L,101L,105L,109L,109L,113L,117L,121L,121L,125L,129L,133L,133L,137L,141L,145L,145L,149L,153L,157L,157L,161L,165L,169L,169L,173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080455Inst : IEnumerable<long>
{
public static readonly long[] Value=A080455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080455.Bytes);
public long this[int i]=>Value[i];

public static A080455Inst Instance=new A080455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080456
{
public static readonly long[] Value={ 2L,6L,10L,14L,18L,18L,22L,26L,30L,30L,34L,38L,42L,42L,46L,50L,54L,54L,58L,62L,66L,66L,70L,74L,78L,78L,82L,86L,90L,90L,94L,98L,102L,102L,106L,110L,114L,114L,118L,122L,126L,126L,130L,134L,138L,138L,142L,146L,150L,150L,154L,158L,162L,162L,166L,170L,174L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080456Inst : IEnumerable<long>
{
public static readonly long[] Value=A080456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080456.Bytes);
public long this[int i]=>Value[i];

public static A080456Inst Instance=new A080456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080457
{
public static readonly long[] Value={ 3L,7L,7L,11L,15L,19L,19L,23L,27L,31L,31L,35L,39L,43L,43L,47L,51L,55L,55L,59L,63L,67L,67L,71L,75L,79L,79L,83L,87L,91L,91L,95L,99L,103L,103L,107L,111L,115L,115L,119L,123L,127L,127L,131L,135L,139L,139L,143L,147L,151L,151L,155L,159L,163L,163L,167L,171L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080457Inst : IEnumerable<long>
{
public static readonly long[] Value=A080457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080457.Bytes);
public long this[int i]=>Value[i];

public static A080457Inst Instance=new A080457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080458
{
public static readonly long[] Value={ 4L,8L,12L,12L,16L,20L,24L,24L,28L,32L,36L,36L,40L,44L,48L,48L,52L,56L,60L,60L,64L,68L,72L,72L,76L,80L,84L,84L,88L,92L,96L,96L,100L,104L,108L,108L,112L,116L,120L,120L,124L,128L,132L,132L,136L,140L,144L,144L,148L,152L,156L,156L,160L,164L,168L,168L,172L,176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080458Inst : IEnumerable<long>
{
public static readonly long[] Value=A080458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080458.Bytes);
public long this[int i]=>Value[i];

public static A080458Inst Instance=new A080458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080459
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,20L,30L,40L,50L,60L,70L,80L,90L,100L,110L,200L,220L,300L,330L,400L,440L,500L,550L,600L,660L,700L,770L,800L,880L,900L,990L,1000L,1010L,1020L,1050L,1100L,1320L,2000L,2010L,2020L,2040L,2200L,2310L,2640L,3000L,3030L,3060L,3300L,3960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080459Inst : IEnumerable<long>
{
public static readonly long[] Value=A080459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080459.Bytes);
public long this[int i]=>Value[i];

public static A080459Inst Instance=new A080459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080460
{
public static readonly long[] Value={ 2L,2L,6L,10L,14L,14L,18L,22L,26L,26L,30L,34L,38L,38L,42L,46L,50L,50L,54L,58L,62L,62L,66L,70L,74L,74L,78L,82L,86L,86L,90L,94L,98L,98L,102L,106L,110L,110L,114L,118L,122L,122L,126L,130L,134L,134L,138L,142L,146L,146L,150L,154L,158L,158L,162L,166L,170L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080460Inst : IEnumerable<long>
{
public static readonly long[] Value=A080460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080460.Bytes);
public long this[int i]=>Value[i];

public static A080460Inst Instance=new A080460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080461
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,10L,5L,4L,3L,2L,2L,2L,2L,2L,1L,10L,7L,5L,4L,4L,3L,3L,3L,2L,2L,10L,7L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080461Inst : IEnumerable<long>
{
public static readonly long[] Value=A080461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080461.Bytes);
public long this[int i]=>Value[i];

public static A080461Inst Instance=new A080461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080462
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,2L,2L,2L,2L,1L,2L,1L,1L,2L,2L,1L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,1L,2L,2L,2L,2L,2L,2L,1L,2L,1L,2L,2L,2L,2L,2L,2L,2L,1L,1L,2L,2L,1L,2L,2L,2L,2L,2L,1L,2L,2L,2L,2L,2L,2L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080462Inst : IEnumerable<long>
{
public static readonly long[] Value=A080462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080462.Bytes);
public long this[int i]=>Value[i];

public static A080462Inst Instance=new A080462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080463
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,8L,9L,10L,11L,12L,13L,14L,15L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080463Inst : IEnumerable<long>
{
public static readonly long[] Value=A080463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080463.Bytes);
public long this[int i]=>Value[i];

public static A080463Inst Instance=new A080463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080464
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,0L,2L,4L,6L,8L,10L,12L,14L,16L,18L,0L,3L,6L,9L,12L,15L,18L,21L,24L,27L,0L,4L,8L,12L,16L,20L,24L,28L,32L,36L,0L,5L,10L,15L,20L,25L,30L,35L,40L,45L,0L,6L,12L,18L,24L,30L,36L,42L,48L,54L,0L,7L,14L,21L,28L,35L,42L,49L,56L,63L,0L,8L,16L,24L,32L,40L,48L,56L,64L,72L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080464Inst : IEnumerable<long>
{
public static readonly long[] Value=A080464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080464.Bytes);
public long this[int i]=>Value[i];

public static A080464Inst Instance=new A080464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080465
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080465Inst : IEnumerable<long>
{
public static readonly long[] Value=A080465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080465.Bytes);
public long this[int i]=>Value[i];

public static A080465Inst Instance=new A080465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080466
{
public static readonly long[] Value={ 121L,143L,165L,187L,341L,363L,385L,561L,583L,781L,1012L,1034L,1056L,1078L,1210L,1232L,1254L,1276L,1298L,1430L,1452L,1474L,1496L,1650L,1672L,1694L,1870L,1892L,3014L,3036L,3058L,3212L,3234L,3256L,3278L,3410L,3432L,3454L,3476L,3498L,3630L,3652L,3674L,3696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080466Inst : IEnumerable<long>
{
public static readonly long[] Value=A080466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080466.Bytes);
public long this[int i]=>Value[i];

public static A080466Inst Instance=new A080466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080467
{
public static readonly long[] Value={ 1012L,1034L,1056L,1078L,1210L,1232L,1254L,1276L,1298L,1430L,1452L,1474L,1496L,1650L,1672L,1694L,1870L,1892L,3014L,3036L,3058L,3212L,3234L,3256L,3278L,3410L,3432L,3454L,3476L,3498L,3630L,3652L,3674L,3696L,3850L,3872L,3894L,5016L,5038L,5214L,5236L,5258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080467Inst : IEnumerable<long>
{
public static readonly long[] Value=A080467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080467.Bytes);
public long this[int i]=>Value[i];

public static A080467Inst Instance=new A080467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080468
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,2L,1L,2L,3L,2L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,3L,2L,1L,0L,1L,2L,1L,2L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L,5L,4L,3L,2L,1L,2L,3L,2L,3L,4L,3L,2L,3L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080468Inst : IEnumerable<long>
{
public static readonly long[] Value=A080468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080468.Bytes);
public long this[int i]=>Value[i];

public static A080468Inst Instance=new A080468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080469
{
public static readonly long[] Value={ 36L,57L,121L,132L,552L,8397L,7000713L,9692541L,36294723L,564033861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080469Inst : IEnumerable<long>
{
public static readonly long[] Value=A080469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080469.Bytes);
public long this[int i]=>Value[i];

public static A080469Inst Instance=new A080469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080470
{
public static readonly long[] Value={ 10L,12L,30L,4L,15L,6L,27L,8L,9L,10L,110L,12L,123L,14L,15L,16L,117L,18L,119L,20L,21L,22L,123L,24L,25L,26L,27L,28L,129L,30L,231L,32L,33L,34L,35L,36L,237L,38L,39L,40L,141L,42L,143L,44L,45L,46L,147L,48L,49L,50L,51L,52L,153L,54L,55L,56L,57L,58L,159L,60L,161L,62L,63L,64L,65L,66L,267L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080470Inst : IEnumerable<long>
{
public static readonly long[] Value=A080470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080470.Bytes);
public long this[int i]=>Value[i];

public static A080470Inst Instance=new A080470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080471
{
public static readonly long[] Value={ 1L,2L,3L,34L,5L,610L,377L,8L,89L,610L,4181L,121393L,13L,144L,1597L,10946L,1597L,4181L,1597L,832040L,21L,514229L,233L,2584L,2584L,28657L,28657L,2584L,121393L,832040L,317811L,832040L,233L,34L,3524578L,46368L,377L,46368L,121393L,832040L,4181L,514229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080471Inst : IEnumerable<long>
{
public static readonly long[] Value=A080471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080471.Bytes);
public long this[int i]=>Value[i];

public static A080471Inst Instance=new A080471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080472
{
public static readonly long[] Value={ 1L,21L,3L,45L,15L,6L,78L,28L,91L,10L,171L,120L,136L,1431L,15L,136L,171L,1081L,190L,120L,21L,1225L,231L,2145L,253L,276L,276L,28L,2926L,300L,231L,325L,3003L,2346L,325L,36L,378L,378L,3916L,406L,741L,4278L,435L,4465L,45L,406L,4278L,1485L,496L,1540L,351L,528L,153L,1540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080472Inst : IEnumerable<long>
{
public static readonly long[] Value=A080472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080472.Bytes);
public long this[int i]=>Value[i];

public static A080472Inst Instance=new A080472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080473
{
public static readonly BigInteger[] Value={ 1L,5L,74L,2414L,140274L,12780984L,1681732464L,301837526640L,70870658200560L,21085710340560480L,7752245316736838400L,BigInteger.Parse("3451176556978487944320"),BigInteger.Parse("1829509243576458084345600"),BigInteger.Parse("1138750671753488468994278400") };
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
public class A080473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080473Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080473.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080473Inst Instance=new A080473Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080474
{
public static readonly BigInteger[] Value={ 1L,6L,990L,421200L,379501200L,625757605200L,1707530790369600L,7172573016426048000L,BigInteger.Parse("43928207579534870592000"),BigInteger.Parse("376055676152225153019936000"),BigInteger.Parse("4350748615258091511751558272000") };
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
public class A080474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080474Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080474.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080474Inst Instance=new A080474Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080475
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,91L,125L,129L,139L,175L,219L,259L,305L,309L,329L,333L,339L,349L,375L,391L,417L,421L,451L,479L,487L,499L,511L,521L,539L,541L,543L,549L,559L,565L,589L,595L,639L,643L,685L,703L,709L,717L,721L,727L,735L,751L,759L,785L,789L,799L,809L,847L,851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080475Inst : IEnumerable<long>
{
public static readonly long[] Value=A080475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080475.Bytes);
public long this[int i]=>Value[i];

public static A080475Inst Instance=new A080475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080476
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,18L,24L,32L,40L,50L,60L,72L,84L,98L,112L,128L,144L,162L,180L,200L,220L,242L,264L,288L,312L,338L,364L,392L,420L,450L,480L,512L,544L,578L,612L,648L,684L,722L,760L,800L,840L,882L,924L,968L,1012L,1058L,1104L,1152L,1200L,1250L,1300L,1352L,1404L,1458L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080476Inst : IEnumerable<long>
{
public static readonly long[] Value=A080476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080476.Bytes);
public long this[int i]=>Value[i];

public static A080476Inst Instance=new A080476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080477
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,71862L,38266515L,6114942900L,475562216745L,18824858869630L,397449398883096L,4630515150103920L,30531593455793640L,116023986363853264L,257257754706576192L,335200293307691456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080477Inst : IEnumerable<long>
{
public static readonly long[] Value=A080477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080477.Bytes);
public long this[int i]=>Value[i];

public static A080477Inst Instance=new A080477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080478
{
public static readonly long[] Value={ 1L,2L,3L,8L,13L,20L,23L,30L,31L,44L,49L,74L,79L,80L,89L,96L,101L,104L,105L,116L,119L,124L,131L,134L,139L,140L,149L,150L,157L,158L,165L,172L,173L,178L,183L,202L,203L,230L,231L,250L,257L,260L,261L,274L,289L,290L,291L,296L,311L,334L,335L,342L,343L,360L,367L,372L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080478Inst : IEnumerable<long>
{
public static readonly long[] Value=A080478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080478.Bytes);
public long this[int i]=>Value[i];

public static A080478Inst Instance=new A080478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080479
{
public static readonly BigInteger[] Value={ 1L,23L,456L,10789L,1111112345L,101111226789L,22222222345678L,1022333333334569L,102333344444445789L,10234444455555556789UL,BigInteger.Parse("1023455555666666666789"),BigInteger.Parse("102345666677777777777889") };
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
public class A080479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080479Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080479.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080479Inst Instance=new A080479Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080480
{
public static readonly BigInteger[] Value={ 1L,32L,654L,98710L,5432111111L,987622111110L,87654322222222L,9654333333332210L,987544444443333210L,BigInteger.Parse("98765555555444443210"),BigInteger.Parse("9876666666665555543210"),BigInteger.Parse("988777777777776666543210"),BigInteger.Parse("99998888888888877654321100"),BigInteger.Parse("9999999998765544332211111110000000") };
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
public class A080480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080480Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080480.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080480Inst Instance=new A080480Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080481
{
public static readonly BigInteger[] Value={ 0L,12L,345L,6789L,1011121314L,151617181920L,21222324252627L,2829303132333435L,363738394041424344L,BigInteger.Parse("45464748495051525354"),BigInteger.Parse("5556575859606162636465"),BigInteger.Parse("666768697071727374757677"),BigInteger.Parse("78798081828384858687888990") };
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
public class A080481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080481Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080481.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080481Inst Instance=new A080481Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080482
{
public static readonly BigInteger[] Value={ 0L,4L,115L,2263L,337040438L,50539060640L,7074108084209L,943101044111145L,121246131347141448L,15154916165017175118UL,BigInteger.Parse("1852191953202054212155"),BigInteger.Parse("222256232357242458252559"),BigInteger.Parse("26266027276128286229296330") };
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
public class A080482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080482Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080482.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080482Inst Instance=new A080482Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080483
{
public static readonly BigInteger[] Value={ 0L,21L,543L,9876L,1413121110L,201918171615L,27262524232221L,3534333231302928L,444342414039383736L,BigInteger.Parse("54535251504948474645"),BigInteger.Parse("6564636261605958575655"),BigInteger.Parse("777675747372717069686766"),BigInteger.Parse("90898887868584838281807978") };
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
public class A080483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080483Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080483.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080483Inst Instance=new A080483Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080500
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,10L,18L,28L,40L,54L,140L,264L,432L,650L,924L,1260L,1664L,4284L,8100L,13376L,20400L,29484L,40964L,55200L,72576L,93500L,236808L,443232L,728000L,1108380L,1603800L,2235968L,3028992L,4009500L,5206760L,6652800L,8382528L,20867704L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080500Inst : IEnumerable<long>
{
public static readonly long[] Value=A080500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080500.Bytes);
public long this[int i]=>Value[i];

public static A080500Inst Instance=new A080500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080501
{
public static readonly long[] Value={ 11L,6L,11L,6L,3L,6L,11L,6L,11L,11L,11L,11L,11L,11L,7L,11L,11L,6L,61L,6L,11L,11L,11L,11L,5L,11L,11L,26L,71L,11L,11L,11L,11L,11L,9L,11L,83L,36L,61L,6L,11L,11L,11L,11L,9L,31L,31L,26L,51L,3L,11L,11L,11L,11L,21L,26L,89L,26L,27L,6L,11L,11L,11L,26L,21L,51L,25L,26L,39L,11L,11L,11L,51L,51L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080501Inst : IEnumerable<long>
{
public static readonly long[] Value=A080501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080501.Bytes);
public long this[int i]=>Value[i];

public static A080501Inst Instance=new A080501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080502
{
public static readonly long[] Value={ 1L,10L,102L,1012L,10120L,101202L,1012025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080502Inst : IEnumerable<long>
{
public static readonly long[] Value=A080502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080502.Bytes);
public long this[int i]=>Value[i];

public static A080502Inst Instance=new A080502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080503
{
public static readonly long[] Value={ 1L,5L,34L,253L,2024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080503Inst : IEnumerable<long>
{
public static readonly long[] Value=A080503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080503.Bytes);
public long this[int i]=>Value[i];

public static A080503Inst Instance=new A080503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080504
{
public static readonly long[] Value={ 1L,1L,9L,1L,2L,108L,1L,2L,5L,1000L,1L,2L,3L,4L,1012500L,1L,2L,3L,4L,8L,15552L,1L,2L,3L,4L,5L,6L,25015118625000L,1L,2L,3L,4L,5L,6L,11L,17757684573750000L,1L,2L,3L,4L,5L,6L,7L,8L,19699405917187500L,1L,2L,3L,4L,5L,6L,7L,8L,14L,295491088757812500L,1L,2L,3L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080504Inst : IEnumerable<long>
{
public static readonly long[] Value=A080504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080504.Bytes);
public long this[int i]=>Value[i];

public static A080504Inst Instance=new A080504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080505
{
public static readonly BigInteger[] Value={ 1L,9L,108L,1000L,1012500L,15552L,25015118625000L,17757684573750000L,19699405917187500L,295491088757812500L,BigInteger.Parse("2754030502015722328328015625000"),BigInteger.Parse("69471494082638078965978431093750000") };
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
public class A080505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080505Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080505.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080505Inst Instance=new A080505Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080506
{
public static readonly long[] Value={ 1L,3L,6L,10L,30L,12L,210L,330L,210L,210L,2310L,3570L,30030L,2310L,30030L,690690L,510510L,30030L,9699690L,14804790L,9699690L,19399380L,223092870L,9699690L,223092870L,223092870L,223092870L,9146807670L,6469693230L,223092870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080506Inst : IEnumerable<long>
{
public static readonly long[] Value=A080506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080506.Bytes);
public long this[int i]=>Value[i];

public static A080506Inst Instance=new A080506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080507
{
public static readonly BigInteger[] Value={ 1L,5L,37L,252L,202502L,2595L,3573588375003L,2219710571718754L,2188822879687504L,29549108875781255L,BigInteger.Parse("250366409274156575302546875005"),BigInteger.Parse("5789291173553173247164869257812506") };
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
public class A080507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080507Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A080507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080507.Bytes);
public BigInteger this[int i]=>Value[i];

public static A080507Inst Instance=new A080507Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A080508
{
public static readonly long[] Value={ 1L,1L,4L,1L,2L,4L,1L,2L,3L,216L,1L,2L,3L,4L,324L,1L,2L,3L,4L,5L,6075000L,1L,2L,3L,4L,5L,6L,30375000L,1L,2L,3L,4L,5L,6L,7L,750453558750000L,1L,2L,3L,4L,5L,6L,7L,8L,19699405917187500L,1L,2L,3L,4L,5L,6L,7L,8L,9L,459652804734375000L,1L,2L,3L,4L,5L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A080508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A080508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A080508Inst : IEnumerable<long>
{
public static readonly long[] Value=A080508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A080508.Bytes);
public long this[int i]=>Value[i];

public static A080508Inst Instance=new A080508Inst();

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