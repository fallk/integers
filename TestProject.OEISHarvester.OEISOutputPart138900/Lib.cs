using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A168205
{
public static readonly long[] Value={ 2L,7L,6L,11L,10L,15L,14L,19L,18L,23L,22L,27L,26L,31L,30L,35L,34L,39L,38L,43L,42L,47L,46L,51L,50L,55L,54L,59L,58L,63L,62L,67L,66L,71L,70L,75L,74L,79L,78L,83L,82L,87L,86L,91L,90L,95L,94L,99L,98L,103L,102L,107L,106L,111L,110L,115L,114L,119L,118L,123L,122L,127L,126L,131L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168205Inst : IEnumerable<long>
{
public static readonly long[] Value=A168205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168205.Bytes);
public long this[int i]=>Value[i];

public static A168205Inst Instance=new A168205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168206
{
public static readonly long[] Value={ 0L,11L,5L,16L,10L,21L,15L,26L,20L,31L,25L,36L,30L,41L,35L,46L,40L,51L,45L,56L,50L,61L,55L,66L,60L,71L,65L,76L,70L,81L,75L,86L,80L,91L,85L,96L,90L,101L,95L,106L,100L,111L,105L,116L,110L,121L,115L,126L,120L,131L,125L,136L,130L,141L,135L,146L,140L,151L,145L,156L,150L,161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168206Inst : IEnumerable<long>
{
public static readonly long[] Value=A168206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168206.Bytes);
public long this[int i]=>Value[i];

public static A168206Inst Instance=new A168206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168207
{
public static readonly long[] Value={ 2L,14L,7L,19L,12L,24L,17L,29L,22L,34L,27L,39L,32L,44L,37L,49L,42L,54L,47L,59L,52L,64L,57L,69L,62L,74L,67L,79L,72L,84L,77L,89L,82L,94L,87L,99L,92L,104L,97L,109L,102L,114L,107L,119L,112L,124L,117L,129L,122L,134L,127L,139L,132L,144L,137L,149L,142L,154L,147L,159L,152L,164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168207Inst : IEnumerable<long>
{
public static readonly long[] Value=A168207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168207.Bytes);
public long this[int i]=>Value[i];

public static A168207Inst Instance=new A168207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168208
{
public static readonly long[] Value={ 1L,2L,2L,1L,2L,2L,2L,3L,2L,4L,2L,5L,2L,6L,2L,7L,2L,8L,2L,8L,1L,2L,8L,2L,2L,8L,3L,2L,8L,4L,2L,8L,5L,2L,8L,6L,2L,8L,7L,2L,8L,8L,2L,8L,8L,1L,2L,8L,8L,2L,2L,8L,9L,2L,2L,8L,10L,2L,2L,8L,11L,2L,2L,8L,13L,1L,2L,8L,13L,2L,2L,8L,14L,2L,2L,8L,15L,2L,2L,8L,16L,2L,2L,8L,18L,1L,2L,8L,18L,2L,2L,8L,18L,3L,2L,8L,18L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168208Inst : IEnumerable<long>
{
public static readonly long[] Value=A168208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168208.Bytes);
public long this[int i]=>Value[i];

public static A168208Inst Instance=new A168208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168209
{
public static readonly long[] Value={ 3L,8L,8L,13L,13L,18L,18L,23L,23L,28L,28L,33L,33L,38L,38L,43L,43L,48L,48L,53L,53L,58L,58L,63L,63L,68L,68L,73L,73L,78L,78L,83L,83L,88L,88L,93L,93L,98L,98L,103L,103L,108L,108L,113L,113L,118L,118L,123L,123L,128L,128L,133L,133L,138L,138L,143L,143L,148L,148L,153L,153L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168209Inst : IEnumerable<long>
{
public static readonly long[] Value=A168209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168209.Bytes);
public long this[int i]=>Value[i];

public static A168209Inst Instance=new A168209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168210
{
public static readonly long[] Value={ 0L,13L,6L,19L,12L,25L,18L,31L,24L,37L,30L,43L,36L,49L,42L,55L,48L,61L,54L,67L,60L,73L,66L,79L,72L,85L,78L,91L,84L,97L,90L,103L,96L,109L,102L,115L,108L,121L,114L,127L,120L,133L,126L,139L,132L,145L,138L,151L,144L,157L,150L,163L,156L,169L,162L,175L,168L,181L,174L,187L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168210Inst : IEnumerable<long>
{
public static readonly long[] Value=A168210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168210.Bytes);
public long this[int i]=>Value[i];

public static A168210Inst Instance=new A168210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168211
{
public static readonly long[] Value={ 0L,15L,7L,22L,14L,29L,21L,36L,28L,43L,35L,50L,42L,57L,49L,64L,56L,71L,63L,78L,70L,85L,77L,92L,84L,99L,91L,106L,98L,113L,105L,120L,112L,127L,119L,134L,126L,141L,133L,148L,140L,155L,147L,162L,154L,169L,161L,176L,168L,183L,175L,190L,182L,197L,189L,204L,196L,211L,203L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168211Inst : IEnumerable<long>
{
public static readonly long[] Value=A168211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168211.Bytes);
public long this[int i]=>Value[i];

public static A168211Inst Instance=new A168211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168212
{
public static readonly long[] Value={ 4L,11L,11L,18L,18L,25L,25L,32L,32L,39L,39L,46L,46L,53L,53L,60L,60L,67L,67L,74L,74L,81L,81L,88L,88L,95L,95L,102L,102L,109L,109L,116L,116L,123L,123L,130L,130L,137L,137L,144L,144L,151L,151L,158L,158L,165L,165L,172L,172L,179L,179L,186L,186L,193L,193L,200L,200L,207L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168212Inst : IEnumerable<long>
{
public static readonly long[] Value=A168212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168212.Bytes);
public long this[int i]=>Value[i];

public static A168212Inst Instance=new A168212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168213
{
public static readonly long[] Value={ 5L,14L,14L,23L,23L,32L,32L,41L,41L,50L,50L,59L,59L,68L,68L,77L,77L,86L,86L,95L,95L,104L,104L,113L,113L,122L,122L,131L,131L,140L,140L,149L,149L,158L,158L,167L,167L,176L,176L,185L,185L,194L,194L,203L,203L,212L,212L,221L,221L,230L,230L,239L,239L,248L,248L,257L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168213Inst : IEnumerable<long>
{
public static readonly long[] Value=A168213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168213.Bytes);
public long this[int i]=>Value[i];

public static A168213Inst Instance=new A168213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168214
{
public static readonly long[] Value={ 1L,11L,51L,192L,669L,2222L,7135L,22374L,68916L,209348L,628916L,1872269L,5531641L,16238866L,47410139L,137758585L,398617683L,1149205715L,3302324374L,9461757569L,27038402095L,77082571383L,219276117983L,622541323482L,1764242459656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168214Inst : IEnumerable<long>
{
public static readonly long[] Value=A168214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168214.Bytes);
public long this[int i]=>Value[i];

public static A168214Inst Instance=new A168214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168215
{
public static readonly long[] Value={ 27346L,85910L,1916478335L,6020794258L,225843133696748L,709507129685401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168215Inst : IEnumerable<long>
{
public static readonly long[] Value=A168215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168215.Bytes);
public long this[int i]=>Value[i];

public static A168215Inst Instance=new A168215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168216
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,1L,8L,5L,1L,1L,23L,19L,7L,1L,1L,74L,69L,34L,9L,1L,1L,262L,256L,147L,53L,11L,1L,1L,993L,986L,615L,265L,76L,13L,1L,1L,3943L,3935L,2571L,1235L,431L,103L,15L,1L,1L,16178L,16169L,10862L,5591L,2216L,653L,134L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168216Inst : IEnumerable<long>
{
public static readonly long[] Value=A168216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168216.Bytes);
public long this[int i]=>Value[i];

public static A168216Inst Instance=new A168216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168217
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,12L,3L,10L,48L,224L,10L,42L,226L,1620L,9040L,40L,245L,1530L,10024L,95904L,720192L,245L,1365L,10892L,93096L,744528L,8855616L,87805824L,1225L,11326L,87696L,799344L,8702064L,87478464L,1179952128L,14662445184L,11326L,80094L,836556L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168217Inst : IEnumerable<long>
{
public static readonly long[] Value=A168217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168217.Bytes);
public long this[int i]=>Value[i];

public static A168217Inst Instance=new A168217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168218
{
public static readonly long[] Value={ 6L,0L,5L,5L,2L,1L,7L,8L,8L,8L,8L,2L,6L,0L,0L,4L,4L,7L,6L,9L,9L,5L,4L,9L,0L,0L,5L,2L,0L,7L,2L,4L,0L,4L,4L,7L,3L,0L,3L,2L,3L,8L,8L,9L,8L,4L,5L,5L,0L,6L,5L,7L,8L,3L,3L,1L,1L,1L,4L,7L,5L,9L,0L,4L,2L,0L,6L,8L,9L,4L,1L,1L,9L,7L,8L,0L,8L,8L,6L,8L,1L,7L,6L,1L,1L,8L,3L,1L,2L,8L,4L,1L,9L,3L,0L,8L,9L,4L,0L,1L,9L,8L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168218Inst : IEnumerable<long>
{
public static readonly long[] Value=A168218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168218.Bytes);
public long this[int i]=>Value[i];

public static A168218Inst Instance=new A168218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168219
{
public static readonly long[] Value={ 1L,3L,4L,6L,15L,16L,18L,24L,27L,30L,31L,36L,37L,43L,51L,52L,57L,60L,73L,75L,81L,82L,87L,90L,93L,106L,108L,109L,114L,145L,154L,159L,160L,163L,165L,171L,174L,175L,178L,196L,201L,204L,207L,208L,211L,220L,222L,225L,228L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168219Inst : IEnumerable<long>
{
public static readonly long[] Value=A168219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168219.Bytes);
public long this[int i]=>Value[i];

public static A168219Inst Instance=new A168219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168220
{
public static readonly long[] Value={ 0L,1L,520L,29565L,524416L,4883125L,30233736L,141238825L,536872960L,1743395481L,5000005000L,12968719621L,30958692480L,68929260205L,144627346696L,288325220625L,549755846656L,1007996991985L,1785233665800L,3065533194061L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168220Inst : IEnumerable<long>
{
public static readonly long[] Value=A168220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168220.Bytes);
public long this[int i]=>Value[i];

public static A168220Inst Instance=new A168220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168221
{
public static readonly long[] Value={ 0L,1L,2L,3L,9L,6L,7L,4L,18L,5L,11L,12L,27L,15L,16L,8L,36L,10L,20L,21L,45L,24L,25L,13L,54L,14L,29L,30L,63L,33L,34L,17L,72L,19L,38L,39L,81L,42L,43L,22L,90L,23L,47L,48L,99L,51L,52L,26L,108L,28L,56L,57L,117L,60L,61L,31L,126L,32L,65L,66L,135L,69L,70L,35L,144L,37L,74L,75L,153L,78L,79L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168221Inst : IEnumerable<long>
{
public static readonly long[] Value=A168221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168221.Bytes);
public long this[int i]=>Value[i];

public static A168221Inst Instance=new A168221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168222
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,9L,5L,6L,15L,4L,17L,10L,11L,23L,25L,13L,14L,31L,8L,33L,18L,19L,39L,41L,21L,22L,47L,12L,49L,26L,27L,55L,57L,29L,30L,63L,16L,65L,34L,35L,71L,73L,37L,38L,79L,20L,81L,42L,43L,87L,89L,45L,46L,95L,24L,97L,50L,51L,103L,105L,53L,54L,111L,28L,113L,58L,59L,119L,121L,61L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168222Inst : IEnumerable<long>
{
public static readonly long[] Value=A168222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168222.Bytes);
public long this[int i]=>Value[i];

public static A168222Inst Instance=new A168222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168223
{
public static readonly long[] Value={ 0L,0L,0L,0L,-1L,3L,-5L,4L,-1L,-1L,-2L,7L,-10L,7L,-2L,-1L,-3L,10L,-15L,11L,-3L,-2L,-4L,14L,-20L,14L,-4L,-2L,-5L,17L,-25L,18L,-5L,-3L,-6L,21L,-30L,21L,-6L,-3L,-7L,24L,-35L,25L,-7L,-4L,-8L,28L,-40L,28L,-8L,-4L,-9L,31L,-45L,32L,-9L,-5L,-10L,35L,-50L,35L,-10L,-5L,-11L,38L,-55L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168223Inst : IEnumerable<long>
{
public static readonly long[] Value=A168223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168223.Bytes);
public long this[int i]=>Value[i];

public static A168223Inst Instance=new A168223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168224
{
public static readonly long[] Value={ 0L,5L,7L,11L,17L,19L,23L,29L,31L,35L,41L,43L,47L,53L,55L,59L,65L,67L,71L,77L,79L,83L,89L,91L,95L,101L,103L,107L,113L,115L,119L,125L,127L,131L,137L,139L,143L,149L,151L,155L,161L,163L,167L,173L,175L,179L,185L,187L,191L,197L,199L,203L,209L,211L,215L,221L,223L,227L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168224Inst : IEnumerable<long>
{
public static readonly long[] Value=A168224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168224.Bytes);
public long this[int i]=>Value[i];

public static A168224Inst Instance=new A168224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168225
{
public static readonly long[] Value={ 0L,1L,1032L,88614L,2097280L,24414375L,181399176L,988664572L,4294969344L,15690533085L,50000005000L,142655842626L,371504195712L,896080211299L,2024782604040L,4324877955000L,8796093054976L,17135948195577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168225Inst : IEnumerable<long>
{
public static readonly long[] Value=A168225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168225.Bytes);
public long this[int i]=>Value[i];

public static A168225Inst Instance=new A168225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168226
{
public static readonly long[] Value={ 1890L,2520L,3150L,3780L,4410L,5040L,5670L,6300L,6720L,6930L,7350L,7380L,7560L,7770L,7980L,8010L,8190L,8370L,8400L,8610L,8640L,8820L,9000L,9030L,9240L,9270L,9360L,9450L,9630L,9660L,9870L,9900L,9990L,10080L,10260L,10290L,10500L,10530L,10620L,10710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168226Inst : IEnumerable<long>
{
public static readonly long[] Value=A168226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168226.Bytes);
public long this[int i]=>Value[i];

public static A168226Inst Instance=new A168226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168227
{
public static readonly long[] Value={ 0L,1L,2056L,265761L,8388736L,122070625L,1088391816L,6920644801L,34359740416L,141214771521L,500000005000L,1569214195681L,4458050234496L,11649042575521L,28346956206856L,64873168970625L,140737488388096L,291311118656641L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168227Inst : IEnumerable<long>
{
public static readonly long[] Value=A168227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168227.Bytes);
public long this[int i]=>Value[i];

public static A168227Inst Instance=new A168227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168228
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-1L,1L,1L,1L,-1L,-1L,1L,1L,0L,1L,1L,1L,-5L,10L,-10L,5L,-1L,1L,-5L,-4L,25L,-4L,-5L,1L,1L,15L,64L,50L,-50L,-64L,-15L,-1L,1L,15L,65L,66L,30L,66L,65L,15L,1L,1L,-55L,455L,-671L,1410L,-1410L,671L,-455L,55L,-1L,1L,-55L,1815L,-4730L,11495L,-7251L,11495L,-4730L,1815L,-55L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168228Inst : IEnumerable<long>
{
public static readonly long[] Value=A168228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168228.Bytes);
public long this[int i]=>Value[i];

public static A168228Inst Instance=new A168228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168229
{
public static readonly long[] Value={ 1L,2L,0L,9L,4L,2L,9L,2L,0L,2L,8L,8L,8L,1L,8L,8L,8L,1L,3L,6L,4L,2L,1L,3L,3L,0L,1L,5L,3L,1L,9L,0L,8L,4L,7L,6L,1L,0L,8L,5L,9L,7L,5L,4L,5L,6L,4L,7L,5L,3L,3L,2L,7L,7L,6L,6L,7L,4L,0L,9L,5L,2L,2L,9L,8L,6L,2L,0L,5L,4L,5L,1L,2L,1L,8L,5L,7L,8L,9L,3L,6L,6L,8L,3L,1L,6L,0L,3L,6L,0L,7L,2L,0L,1L,5L,0L,7L,8L,8L,2L,1L,4L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168229Inst : IEnumerable<long>
{
public static readonly long[] Value=A168229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168229.Bytes);
public long this[int i]=>Value[i];

public static A168229Inst Instance=new A168229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168230
{
public static readonly long[] Value={ 0L,4L,1L,5L,2L,6L,3L,7L,4L,8L,5L,9L,6L,10L,7L,11L,8L,12L,9L,13L,10L,14L,11L,15L,12L,16L,13L,17L,14L,18L,15L,19L,16L,20L,17L,21L,18L,22L,19L,23L,20L,24L,21L,25L,22L,26L,23L,27L,24L,28L,25L,29L,26L,30L,27L,31L,28L,32L,29L,33L,30L,34L,31L,35L,32L,36L,33L,37L,34L,38L,35L,39L,36L,40L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168230Inst : IEnumerable<long>
{
public static readonly long[] Value=A168230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168230.Bytes);
public long this[int i]=>Value[i];

public static A168230Inst Instance=new A168230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168231
{
public static readonly long[] Value={ 2L,3L,2L,4L,4L,4L,4L,4L,5L,2L,4L,5L,4L,4L,5L,5L,4L,4L,4L,5L,5L,5L,5L,4L,5L,4L,5L,5L,5L,4L,4L,5L,4L,5L,5L,5L,5L,5L,4L,5L,5L,5L,5L,4L,5L,5L,5L,5L,5L,4L,4L,5L,5L,5L,5L,5L,4L,5L,5L,4L,4L,5L,5L,5L,5L,7L,5L,4L,5L,5L,5L,5L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,7L,5L,5L,7L,5L,5L,7L,5L,5L,5L,7L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168231Inst : IEnumerable<long>
{
public static readonly long[] Value=A168231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168231.Bytes);
public long this[int i]=>Value[i];

public static A168231Inst Instance=new A168231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168232
{
public static readonly long[] Value={ 2L,0L,4L,2L,6L,4L,8L,6L,10L,8L,12L,10L,14L,12L,16L,14L,18L,16L,20L,18L,22L,20L,24L,22L,26L,24L,28L,26L,30L,28L,32L,30L,34L,32L,36L,34L,38L,36L,40L,38L,42L,40L,44L,42L,46L,44L,48L,46L,50L,48L,52L,50L,54L,52L,56L,54L,58L,56L,60L,58L,62L,60L,64L,62L,66L,64L,68L,66L,70L,68L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168232Inst : IEnumerable<long>
{
public static readonly long[] Value=A168232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168232.Bytes);
public long this[int i]=>Value[i];

public static A168232Inst Instance=new A168232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168233
{
public static readonly long[] Value={ 1L,4L,4L,7L,7L,10L,10L,13L,13L,16L,16L,19L,19L,22L,22L,25L,25L,28L,28L,31L,31L,34L,34L,37L,37L,40L,40L,43L,43L,46L,46L,49L,49L,52L,52L,55L,55L,58L,58L,61L,61L,64L,64L,67L,67L,70L,70L,73L,73L,76L,76L,79L,79L,82L,82L,85L,85L,88L,88L,91L,91L,94L,94L,97L,97L,100L,100L,103L,103L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168233Inst : IEnumerable<long>
{
public static readonly long[] Value=A168233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168233.Bytes);
public long this[int i]=>Value[i];

public static A168233Inst Instance=new A168233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168234
{
public static readonly long[] Value={ 3L,3L,13L,13L,13L,13L,13L,13L,13L,13L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,39L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,89L,171L,171L,171L,171L,171L,171L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168234Inst : IEnumerable<long>
{
public static readonly long[] Value=A168234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168234.Bytes);
public long this[int i]=>Value[i];

public static A168234Inst Instance=new A168234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168235
{
public static readonly long[] Value={ 13L,39L,79L,133L,201L,283L,379L,489L,613L,751L,903L,1069L,1249L,1443L,1651L,1873L,2109L,2359L,2623L,2901L,3193L,3499L,3819L,4153L,4501L,4863L,5239L,5629L,6033L,6451L,6883L,7329L,7789L,8263L,8751L,9253L,9769L,10299L,10843L,11401L,11973L,12559L,13159L,13773L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168235Inst : IEnumerable<long>
{
public static readonly long[] Value=A168235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168235.Bytes);
public long this[int i]=>Value[i];

public static A168235Inst Instance=new A168235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168236
{
public static readonly long[] Value={ 2L,2L,5L,5L,8L,8L,11L,11L,14L,14L,17L,17L,20L,20L,23L,23L,26L,26L,29L,29L,32L,32L,35L,35L,38L,38L,41L,41L,44L,44L,47L,47L,50L,50L,53L,53L,56L,56L,59L,59L,62L,62L,65L,65L,68L,68L,71L,71L,74L,74L,77L,77L,80L,80L,83L,83L,86L,86L,89L,89L,92L,92L,95L,95L,98L,98L,101L,101L,104L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168236Inst : IEnumerable<long>
{
public static readonly long[] Value=A168236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168236.Bytes);
public long this[int i]=>Value[i];

public static A168236Inst Instance=new A168236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168237
{
public static readonly long[] Value={ 0L,3L,3L,6L,6L,9L,9L,12L,12L,15L,15L,18L,18L,21L,21L,24L,24L,27L,27L,30L,30L,33L,33L,36L,36L,39L,39L,42L,42L,45L,45L,48L,48L,51L,51L,54L,54L,57L,57L,60L,60L,63L,63L,66L,66L,69L,69L,72L,72L,75L,75L,78L,78L,81L,81L,84L,84L,87L,87L,90L,90L,93L,93L,96L,96L,99L,99L,102L,102L,105L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168237Inst : IEnumerable<long>
{
public static readonly long[] Value=A168237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168237.Bytes);
public long this[int i]=>Value[i];

public static A168237Inst Instance=new A168237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168238
{
public static readonly BigInteger[] Value={ 1L,4L,29L,263L,2724L,30554L,361677L,4454273L,56546511L,735298671L,9749613914L,131377492010L,1794546880363L,24798396567242L,346130144084641L,4873560434459530L,69149450121948083L,987844051312409668L,14198028410251734447UL,BigInteger.Parse("205181815270346718199") };
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
public class A168238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168238Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A168238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168238.Bytes);
public BigInteger this[int i]=>Value[i];

public static A168238Inst Instance=new A168238Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168239
{
public static readonly long[] Value={ 6L,5L,4L,12L,11L,3L,2L,6L,7L,7L,10L,5L,0L,1L,7L,3L,9L,8L,2L,6L,12L,5L,13L,8L,11L,3L,12L,8L,12L,5L,14L,3L,1L,10L,14L,3L,3L,8L,4L,13L,9L,13L,1L,13L,11L,3L,2L,4L,9L,8L,7L,12L,14L,11L,5L,3L,3L,8L,5L,4L,11L,13L,13L,2L,14L,3L,12L,8L,15L,3L,6L,3L,4L,12L,6L,8L,4L,8L,14L,13L,2L,7L,9L,7L,2L,7L,13L,8L,4L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168239Inst : IEnumerable<long>
{
public static readonly long[] Value=A168239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168239.Bytes);
public long this[int i]=>Value[i];

public static A168239Inst Instance=new A168239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168240
{
public static readonly long[] Value={ 21L,67L,139L,237L,361L,511L,687L,889L,1117L,1371L,1651L,1957L,2289L,2647L,3031L,3441L,3877L,4339L,4827L,5341L,5881L,6447L,7039L,7657L,8301L,8971L,9667L,10389L,11137L,11911L,12711L,13537L,14389L,15267L,16171L,17101L,18057L,19039L,20047L,21081L,22141L,23227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168240Inst : IEnumerable<long>
{
public static readonly long[] Value=A168240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168240.Bytes);
public long this[int i]=>Value[i];

public static A168240Inst Instance=new A168240Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168241
{
public static readonly long[] Value={ 1L,3L,6L,10L,13L,15L,19L,21L,24L,27L,29L,32L,35L,38L,41L,43L,47L,51L,54L,56L,59L,61L,63L,66L,69L,71L,74L,76L,78L,82L,85L,90L,93L,96L,100L,102L,104L,107L,110L,114L,116L,118L,121L,124L,126L,129L,131L,135L,137L,140L,144L,146L,149L,151L,153L,157L,160L,163L,165L,168L,171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168241Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168241.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168241Inst : IEnumerable<long>
{
public static readonly long[] Value=A168241.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168241.Bytes);
public long this[int i]=>Value[i];

public static A168241Inst Instance=new A168241Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168242
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-3L,1L,1L,-29L,21L,-1L,1L,-1769L,1872L,-265L,1L,1L,-615871L,1227274L,-405530L,5975L,-1L,1L,-1124878187L,14488841796L,-8196098025L,250869024L,-194883L,1L,1L,-10146337387971L,4127467195814962L,-2684293284374908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168242Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168242.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168242Inst : IEnumerable<long>
{
public static readonly long[] Value=A168242.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168242.Bytes);
public long this[int i]=>Value[i];

public static A168242Inst Instance=new A168242Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168243
{
public static readonly long[] Value={ 1L,1L,1L,5L,11L,59L,439L,2659L,13705L,160649L,2009681L,16966421L,183312931L,2078169235L,34203787591L,657685416179L,8054585463569L,104530824746129L,2595754682459425L,39767021562661669L,758079429084897211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168243Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168243.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168243Inst : IEnumerable<long>
{
public static readonly long[] Value=A168243.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168243.Bytes);
public long this[int i]=>Value[i];

public static A168243Inst Instance=new A168243Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168244
{
public static readonly long[] Value={ 1L,2L,-1L,-8L,-19L,-34L,-53L,-76L,-103L,-134L,-169L,-208L,-251L,-298L,-349L,-404L,-463L,-526L,-593L,-664L,-739L,-818L,-901L,-988L,-1079L,-1174L,-1273L,-1376L,-1483L,-1594L,-1709L,-1828L,-1951L,-2078L,-2209L,-2344L,-2483L,-2626L,-2773L,-2924L,-3079L,-3238L,-3401L,-3568L,-3739L,-3914L,-4093L,-4276L,-4463L,-4654L,-4849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168244Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168244.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168244Inst : IEnumerable<long>
{
public static readonly long[] Value=A168244.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168244.Bytes);
public long this[int i]=>Value[i];

public static A168244Inst Instance=new A168244Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168245
{
public static readonly long[] Value={ 1L,5L,7L,17L,19L,33L,33L,45L,63L,69L,95L,105L,109L,125L,147L,171L,165L,209L,219L,225L,255L,273L,295L,331L,353L,361L,381L,385L,399L,483L,485L,511L,523L,581L,579L,617L,653L,665L,697L,717L,729L,791L,789L,815L,823L,899L,987L,987L,993L,1013L,1033L,1045L,1115L,1119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168245Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168245.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168245Inst : IEnumerable<long>
{
public static readonly long[] Value=A168245.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168245.Bytes);
public long this[int i]=>Value[i];

public static A168245Inst Instance=new A168245Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168246
{
public static readonly long[] Value={ 1L,2L,4L,19L,92L,576L,4156L,34178L,314368L,3199936L,35703996L,433422071L,5687955724L,80256879068L,1211781887796L,19496946568898L,333041104402860L,6019770247224496L,114794574818830716L,2303332661419442569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168246Inst : IEnumerable<long>
{
public static readonly long[] Value=A168246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168246.Bytes);
public long this[int i]=>Value[i];

public static A168246Inst Instance=new A168246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168247
{
public static readonly long[] Value={ 1L,2L,6L,8L,12L,46L,48L,49L,71L,126L,147L,151L,162L,172L,189L,211L,223L,257L,272L,306L,309L,337L,347L,364L,382L,458L,495L,504L,525L,549L,550L,563L,596L,598L,615L,657L,664L,677L,685L,719L,720L,771L,824L,829L,862L,870L,892L,927L,954L,1052L,1065L,1069L,1083L,1097L,1099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168247Inst : IEnumerable<long>
{
public static readonly long[] Value=A168247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168247.Bytes);
public long this[int i]=>Value[i];

public static A168247Inst Instance=new A168247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168248
{
public static readonly long[] Value={ 1159L,2217L,3463L,4161L,5713L,5911L,6037L,6451L,6699L,7333L,9403L,10249L,10447L,10483L,11019L,11347L,11383L,13039L,13503L,14173L,15127L,15879L,18489L,19569L,20307L,20563L,21333L,22921L,23713L,24613L,25009L,26877L,27111L,30207L,30229L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168248Inst : IEnumerable<long>
{
public static readonly long[] Value=A168248.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168248.Bytes);
public long this[int i]=>Value[i];

public static A168248Inst Instance=new A168248Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168249
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,16L,20L,26L,29L,33L,38L,43L,48L,51L,57L,60L,63L,68L,72L,77L,80L,93L,96L,101L,112L,118L,122L,125L,130L,134L,145L,147L,158L,168L,171L,175L,181L,190L,195L,198L,204L,210L,213L,223L,236L,239L,243L,254L,259L,269L,271L,276L,282L,287L,292L,294L,298L,304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168249Inst : IEnumerable<long>
{
public static readonly long[] Value=A168249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168249.Bytes);
public long this[int i]=>Value[i];

public static A168249Inst Instance=new A168249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168250
{
public static readonly long[] Value={ 17L,13L,17L,13L,17L,17L,17L,17L,31L,17L,17L,17L,17L,17L,13L,17L,17L,17L,13L,17L,17L,31L,31L,31L,13L,17L,13L,17L,17L,17L,17L,31L,13L,13L,17L,13L,17L,17L,13L,17L,31L,31L,31L,17L,17L,31L,13L,17L,31L,17L,17L,13L,37L,31L,17L,31L,17L,31L,31L,13L,31L,13L,17L,17L,31L,37L,31L,17L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168250Inst : IEnumerable<long>
{
public static readonly long[] Value=A168250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168250.Bytes);
public long this[int i]=>Value[i];

public static A168250Inst Instance=new A168250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168251
{
public static readonly long[] Value={ 0L,1L,4L,9L,64L,25L,576L,49L,4096L,81L,25600L,121L,147456L,169L,802816L,225L,4194304L,289L,21233664L,361L,104857600L,441L,507510784L,529L,2415919104L,625L,11341398016L,729L,52613349376L,841L,241591910400L,961L,1099511627776L,1089L,4964982194176L,1225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168251Inst : IEnumerable<long>
{
public static readonly long[] Value=A168251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168251.Bytes);
public long this[int i]=>Value[i];

public static A168251Inst Instance=new A168251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168252
{
public static readonly long[] Value={ 1L,3L,5L,7L,10L,11L,13L,14L,15L,17L,19L,21L,22L,26L,29L,31L,33L,34L,35L,38L,39L,41L,43L,46L,51L,55L,57L,58L,59L,61L,62L,65L,66L,69L,70L,71L,73L,74L,77L,78L,82L,85L,86L,87L,91L,93L,94L,95L,101L,103L,105L,106L,107L,109L,110L,111L,114L,115L,118L,119L,122L,123L,129L,130L,133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168252Inst : IEnumerable<long>
{
public static readonly long[] Value=A168252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168252.Bytes);
public long this[int i]=>Value[i];

public static A168252Inst Instance=new A168252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168253
{
public static readonly long[] Value={ 5L,3L,23L,89L,139L,199L,113L,1933L,523L,3089L,1129L,1669L,2477L,2971L,4297L,5591L,1327L,28351L,30593L,19333L,16141L,36389L,81463L,28229L,31907L,19609L,35617L,82073L,44293L,102701L,34061L,288583L,221327L,134513L,173359L,360091L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168253Inst : IEnumerable<long>
{
public static readonly long[] Value=A168253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168253.Bytes);
public long this[int i]=>Value[i];

public static A168253Inst Instance=new A168253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168254
{
public static readonly long[] Value={ 0L,1L,28L,103L,403L,613L,658L,1018L,1138L,1318L,1678L,2023L,2188L,2383L,2653L,3418L,3853L,3958L,4333L,4393L,4828L,5278L,5908L,6163L,8218L,8428L,8683L,8848L,9028L,9043L,9478L,9868L,10003L,10243L,10978L,11518L,11533L,12133L,12493L,13603L,13633L,14593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168254Inst : IEnumerable<long>
{
public static readonly long[] Value=A168254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168254.Bytes);
public long this[int i]=>Value[i];

public static A168254Inst Instance=new A168254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168255
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,3L,3L,3L,3L,3L,3L,4L,4L,4L,4L,4L,4L,4L,4L,5L,5L,5L,5L,5L,5L,5L,5L,5L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168255Inst : IEnumerable<long>
{
public static readonly long[] Value=A168255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168255.Bytes);
public long this[int i]=>Value[i];

public static A168255Inst Instance=new A168255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168256
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,5L,5L,5L,5L,14L,14L,14L,14L,14L,42L,42L,42L,42L,42L,42L,132L,132L,132L,132L,132L,132L,132L,429L,429L,429L,429L,429L,429L,429L,429L,1430L,1430L,1430L,1430L,1430L,1430L,1430L,1430L,1430L,4862L,4862L,4862L,4862L,4862L,4862L,4862L,4862L,4862L,4862L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168256Inst : IEnumerable<long>
{
public static readonly long[] Value=A168256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168256.Bytes);
public long this[int i]=>Value[i];

public static A168256Inst Instance=new A168256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168257
{
public static readonly long[] Value={ 0L,1L,9L,784L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168257Inst : IEnumerable<long>
{
public static readonly long[] Value=A168257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168257.Bytes);
public long this[int i]=>Value[i];

public static A168257Inst Instance=new A168257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168258
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,2L,2L,1L,3L,3L,3L,2L,1L,3L,3L,3L,3L,2L,1L,4L,4L,4L,4L,3L,2L,1L,4L,4L,4L,4L,4L,3L,2L,1L,5L,5L,5L,5L,5L,4L,3L,2L,1L,5L,5L,5L,5L,5L,5L,4L,3L,2L,1L,6L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L,6L,6L,6L,6L,6L,6L,6L,5L,4L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168258Inst : IEnumerable<long>
{
public static readonly long[] Value=A168258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168258.Bytes);
public long this[int i]=>Value[i];

public static A168258Inst Instance=new A168258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168259
{
public static readonly long[] Value={ 1L,2L,6L,14L,38L,96L,254L,656L,1724L,4492L,11776L,30774L,80608L,210892L,552226L,1445374L,3784308L,9906482L,25936206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168259Inst : IEnumerable<long>
{
public static readonly long[] Value=A168259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168259.Bytes);
public long this[int i]=>Value[i];

public static A168259Inst Instance=new A168259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168260
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,2L,2L,2L,4L,6L,3L,3L,6L,12L,14L,3L,3L,6L,18L,28L,38L,4L,4L,8L,24L,42L,76L,96L,4L,4L,8L,24L,56L,114L,192L,254L,5L,5L,10L,30L,70L,152L,288L,508L,656L,5L,5L,10L,30L,70L,190L,384L,762L,1312L,1724L,6L,6L,12L,36L,84L,228L,480L,1016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168260Inst : IEnumerable<long>
{
public static readonly long[] Value=A168260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168260.Bytes);
public long this[int i]=>Value[i];

public static A168260Inst Instance=new A168260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168261
{
public static readonly long[] Value={ 1L,1L,1L,0L,0L,2L,1L,1L,0L,2L,0L,0L,0L,0L,4L,0L,0L,2L,0L,0L,4L,0L,0L,0L,0L,0L,0L,6L,1L,1L,0L,2L,0L,0L,0L,6L,0L,0L,0L,0L,0L,0L,0L,0L,10L,0L,0L,0L,0L,4L,0L,0L,0L,0L,10L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,14L,0L,0L,2L,0L,0L,4L,0L,0L,0L,0L,0L,14L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168261Inst : IEnumerable<long>
{
public static readonly long[] Value=A168261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168261.Bytes);
public long this[int i]=>Value[i];

public static A168261Inst Instance=new A168261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168262
{
public static readonly long[] Value={ 1L,2L,6L,12L,60L,420L,840L,27720L,360360L,5354228880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168262Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168262.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168262Inst : IEnumerable<long>
{
public static readonly long[] Value=A168262.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168262.Bytes);
public long this[int i]=>Value[i];

public static A168262Inst Instance=new A168262Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168263
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,60L,120L,180L,840L,1260L,1680L,27720L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168263Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168263.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168263Inst : IEnumerable<long>
{
public static readonly long[] Value=A168263.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168263.Bytes);
public long this[int i]=>Value[i];

public static A168263Inst Instance=new A168263Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168264
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,24L,30L,60L,120L,180L,210L,420L,840L,1260L,1680L,2310L,4620L,9240L,13860L,18480L,27720L,30030L,60060L,120120L,180180L,240240L,360360L,510510L,1021020L,2042040L,3063060L,4084080L,6126120L,9699690L,19399380L,38798760L,58198140L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168264Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168264.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168264Inst : IEnumerable<long>
{
public static readonly long[] Value=A168264.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168264.Bytes);
public long this[int i]=>Value[i];

public static A168264Inst Instance=new A168264Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168265
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,4L,1L,2L,3L,4L,5L,6L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168265Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168265.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168265Inst : IEnumerable<long>
{
public static readonly long[] Value=A168265.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168265.Bytes);
public long this[int i]=>Value[i];

public static A168265Inst Instance=new A168265Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168266
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,4L,1L,2L,4L,6L,1L,2L,4L,6L,8L,1L,2L,4L,6L,8L,12L,1L,2L,4L,6L,8L,12L,1L,2L,4L,6L,8L,12L,1L,2L,4L,6L,8L,12L,1L,2L,4L,6L,8L,12L,24L,1L,2L,4L,6L,8L,12L,24L,1L,2L,4L,6L,8L,12L,24L,36L,1L,2L,4L,6L,8L,12L,24L,36L,1L,2L,4L,6L,8L,12L,24L,36L,1L,2L,4L,6L,8L,12L,24L,36L,1L,2L,4L,6L,8L,12L,24L,36L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168266Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168266.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168266Inst : IEnumerable<long>
{
public static readonly long[] Value=A168266.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168266.Bytes);
public long this[int i]=>Value[i];

public static A168266Inst Instance=new A168266Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168267
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,12L,24L,36L,48L,60L,72L,96L,120L,180L,240L,360L,480L,720L,840L,1080L,1260L,1440L,1680L,2160L,2520L,3360L,4320L,5040L,7560L,10080L,15120L,20160L,25200L,27720L,30240L,40320L,45360L,50400L,55440L,75600L,83160L,110880L,151200L,166320L,221760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168267Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168267.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168267Inst : IEnumerable<long>
{
public static readonly long[] Value=A168267.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168267.Bytes);
public long this[int i]=>Value[i];

public static A168267Inst Instance=new A168267Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168268
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,6L,20L,45L,116L,385L,2224L,6396L,23708L,88065L,445784L,3962502L,14478825L,64495508L,309085415L,1608099881L,10856426344L,142802148953L,604464533847L,3324499738872L,17795211310951L,112537384959231L,718232376832560L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168268Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168268.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168268Inst : IEnumerable<long>
{
public static readonly long[] Value=A168268.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168268.Bytes);
public long this[int i]=>Value[i];

public static A168268Inst Instance=new A168268Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168269
{
public static readonly long[] Value={ 3L,3L,7L,7L,11L,11L,15L,15L,19L,19L,23L,23L,27L,27L,31L,31L,35L,35L,39L,39L,43L,43L,47L,47L,51L,51L,55L,55L,59L,59L,63L,63L,67L,67L,71L,71L,75L,75L,79L,79L,83L,83L,87L,87L,91L,91L,95L,95L,99L,99L,103L,103L,107L,107L,111L,111L,115L,115L,119L,119L,123L,123L,127L,127L,131L,131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168269Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168269.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168269Inst : IEnumerable<long>
{
public static readonly long[] Value=A168269.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168269.Bytes);
public long this[int i]=>Value[i];

public static A168269Inst Instance=new A168269Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168270
{
public static readonly long[] Value={ 2L,6L,23L,30L,37L,42L,47L,53L,67L,79L,83L,89L,97L,102L,113L,127L,131L,138L,157L,163L,167L,173L,211L,223L,233L,251L,257L,263L,277L,282L,293L,307L,317L,331L,337L,353L,359L,367L,373L,379L,383L,389L,397L,401L,409L,439L,443L,449L,457L,462L,467L,479L,487L,491L,499L,503L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168270Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168270.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168270Inst : IEnumerable<long>
{
public static readonly long[] Value=A168270.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168270.Bytes);
public long this[int i]=>Value[i];

public static A168270Inst Instance=new A168270Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168271
{
public static readonly long[] Value={ 1L,3L,5L,9L,7L,9L,12L,16L,14L,13L,17L,20L,17L,21L,25L,25L,21L,21L,17L,19L,35L,32L,28L,31L,25L,31L,33L,33L,39L,47L,33L,30L,47L,49L,39L,39L,37L,43L,44L,44L,43L,41L,38L,48L,58L,59L,47L,35L,50L,58L,55L,59L,71L,64L,61L,61L,62L,71L,75L,71L,81L,75L,62L,63L,69L,70L,57L,63L,59L,61L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168271Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168271.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168271Inst : IEnumerable<long>
{
public static readonly long[] Value=A168271.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168271.Bytes);
public long this[int i]=>Value[i];

public static A168271Inst Instance=new A168271Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168272
{
public static readonly long[] Value={ 1L,2L,2L,2L,8L,12L,22L,24L,36L,56L,66L,86L,106L,112L,122L,144L,176L,180L,224L,240L,236L,264L,292L,312L,358L,384L,396L,414L,418L,424L,512L,540L,550L,570L,630L,644L,680L,716L,734L,768L,794L,816L,872L,878L,894L,906L,984L,1092L,1096L,1100L,1122L,1140L,1150L,1218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168272Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168272.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168272Inst : IEnumerable<long>
{
public static readonly long[] Value=A168272.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168272.Bytes);
public long this[int i]=>Value[i];

public static A168272Inst Instance=new A168272Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168273
{
public static readonly long[] Value={ 0L,4L,4L,8L,8L,12L,12L,16L,16L,20L,20L,24L,24L,28L,28L,32L,32L,36L,36L,40L,40L,44L,44L,48L,48L,52L,52L,56L,56L,60L,60L,64L,64L,68L,68L,72L,72L,76L,76L,80L,80L,84L,84L,88L,88L,92L,92L,96L,96L,100L,100L,104L,104L,108L,108L,112L,112L,116L,116L,120L,120L,124L,124L,128L,128L,132L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168273Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168273.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168273Inst : IEnumerable<long>
{
public static readonly long[] Value=A168273.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168273.Bytes);
public long this[int i]=>Value[i];

public static A168273Inst Instance=new A168273Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168274
{
public static readonly long[] Value={ 3L,31L,37L,43L,73L,109L,163L,211L,241L,313L,337L,409L,499L,673L,739L,757L,907L,1033L,1039L,1069L,1237L,1327L,1447L,1483L,1489L,1597L,1663L,1741L,1777L,1933L,2083L,2143L,2251L,2437L,2683L,2797L,3001L,3181L,3307L,3319L,3463L,3739L,3793L,4051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168274Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168274.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168274Inst : IEnumerable<long>
{
public static readonly long[] Value=A168274.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168274.Bytes);
public long this[int i]=>Value[i];

public static A168274Inst Instance=new A168274Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168275
{
public static readonly long[] Value={ 3L,4L,7L,6L,7L,8L,11L,11L,11L,12L,12L,14L,15L,15L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168275Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168275.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168275Inst : IEnumerable<long>
{
public static readonly long[] Value=A168275.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168275.Bytes);
public long this[int i]=>Value[i];

public static A168275Inst Instance=new A168275Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168276
{
public static readonly long[] Value={ 2L,2L,6L,6L,10L,10L,14L,14L,18L,18L,22L,22L,26L,26L,30L,30L,34L,34L,38L,38L,42L,42L,46L,46L,50L,50L,54L,54L,58L,58L,62L,62L,66L,66L,70L,70L,74L,74L,78L,78L,82L,82L,86L,86L,90L,90L,94L,94L,98L,98L,102L,102L,106L,106L,110L,110L,114L,114L,118L,118L,122L,122L,126L,126L,130L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168276Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168276.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168276Inst : IEnumerable<long>
{
public static readonly long[] Value=A168276.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168276.Bytes);
public long this[int i]=>Value[i];

public static A168276Inst Instance=new A168276Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168277
{
public static readonly long[] Value={ 1L,1L,5L,5L,9L,9L,13L,13L,17L,17L,21L,21L,25L,25L,29L,29L,33L,33L,37L,37L,41L,41L,45L,45L,49L,49L,53L,53L,57L,57L,61L,61L,65L,65L,69L,69L,73L,73L,77L,77L,81L,81L,85L,85L,89L,89L,93L,93L,97L,97L,101L,101L,105L,105L,109L,109L,113L,113L,117L,117L,121L,121L,125L,125L,129L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168277Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168277.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168277Inst : IEnumerable<long>
{
public static readonly long[] Value=A168277.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168277.Bytes);
public long this[int i]=>Value[i];

public static A168277Inst Instance=new A168277Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168278
{
public static readonly long[] Value={ 2L,7L,7L,12L,12L,17L,17L,22L,22L,27L,27L,32L,32L,37L,37L,42L,42L,47L,47L,52L,52L,57L,57L,62L,62L,67L,67L,72L,72L,77L,77L,82L,82L,87L,87L,92L,92L,97L,97L,102L,102L,107L,107L,112L,112L,117L,117L,122L,122L,127L,127L,132L,132L,137L,137L,142L,142L,147L,147L,152L,152L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168278Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168278.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168278Inst : IEnumerable<long>
{
public static readonly long[] Value=A168278.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168278.Bytes);
public long this[int i]=>Value[i];

public static A168278Inst Instance=new A168278Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168279
{
public static readonly long[] Value={ 1L,3L,3L,5L,7L,8L,8L,10L,11L,13L,14L,15L,15L,17L,19L,21L,21L,23L,23L,23L,26L,28L,29L,29L,31L,31L,33L,33L,33L,37L,38L,39L,39L,41L,43L,45L,45L,46L,46L,47L,49L,52L,52L,52L,53L,55L,59L,60L,60L,61L,61L,61L,64L,65L,65L,66L,67L,67L,69L,69L,71L,74L,75L,75L,76L,79L,79L,81L,81L,83L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168279Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168279.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168279Inst : IEnumerable<long>
{
public static readonly long[] Value=A168279.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168279.Bytes);
public long this[int i]=>Value[i];

public static A168279Inst Instance=new A168279Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168280
{
public static readonly long[] Value={ 4L,4L,9L,9L,14L,14L,19L,19L,24L,24L,29L,29L,34L,34L,39L,39L,44L,44L,49L,49L,54L,54L,59L,59L,64L,64L,69L,69L,74L,74L,79L,79L,84L,84L,89L,89L,94L,94L,99L,99L,104L,104L,109L,109L,114L,114L,119L,119L,124L,124L,129L,129L,134L,134L,139L,139L,144L,144L,149L,149L,154L,154L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168280Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168280.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168280Inst : IEnumerable<long>
{
public static readonly long[] Value=A168280.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168280.Bytes);
public long this[int i]=>Value[i];

public static A168280Inst Instance=new A168280Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168281
{
public static readonly long[] Value={ 2L,2L,2L,2L,8L,2L,2L,8L,8L,2L,2L,8L,18L,8L,2L,2L,8L,18L,18L,8L,2L,2L,8L,18L,32L,18L,8L,2L,2L,8L,18L,32L,32L,18L,8L,2L,2L,8L,18L,32L,50L,32L,18L,8L,2L,2L,8L,18L,32L,50L,50L,32L,18L,8L,2L,2L,8L,18L,32L,50L,72L,50L,32L,18L,8L,2L,2L,8L,18L,32L,50L,72L,72L,50L,32L,18L,8L,2L,2L,8L,18L,32L,50L,72L,98L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168281Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168281.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168281Inst : IEnumerable<long>
{
public static readonly long[] Value=A168281.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168281.Bytes);
public long this[int i]=>Value[i];

public static A168281Inst Instance=new A168281Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168282
{
public static readonly long[] Value={ 1L,6L,6L,11L,11L,16L,16L,21L,21L,26L,26L,31L,31L,36L,36L,41L,41L,46L,46L,51L,51L,56L,56L,61L,61L,66L,66L,71L,71L,76L,76L,81L,81L,86L,86L,91L,91L,96L,96L,101L,101L,106L,106L,111L,111L,116L,116L,121L,121L,126L,126L,131L,131L,136L,136L,141L,141L,146L,146L,151L,151L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168282Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168282.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168282Inst : IEnumerable<long>
{
public static readonly long[] Value=A168282.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168282.Bytes);
public long this[int i]=>Value[i];

public static A168282Inst Instance=new A168282Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168283
{
public static readonly long[] Value={ 3L,3L,8L,8L,13L,13L,18L,18L,23L,23L,28L,28L,33L,33L,38L,38L,43L,43L,48L,48L,53L,53L,58L,58L,63L,63L,68L,68L,73L,73L,78L,78L,83L,83L,88L,88L,93L,93L,98L,98L,103L,103L,108L,108L,113L,113L,118L,118L,123L,123L,128L,128L,133L,133L,138L,138L,143L,143L,148L,148L,153L,153L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168283Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168283.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168283Inst : IEnumerable<long>
{
public static readonly long[] Value=A168283.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168283.Bytes);
public long this[int i]=>Value[i];

public static A168283Inst Instance=new A168283Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168284
{
public static readonly long[] Value={ 0L,5L,5L,10L,10L,15L,15L,20L,20L,25L,25L,30L,30L,35L,35L,40L,40L,45L,45L,50L,50L,55L,55L,60L,60L,65L,65L,70L,70L,75L,75L,80L,80L,85L,85L,90L,90L,95L,95L,100L,100L,105L,105L,110L,110L,115L,115L,120L,120L,125L,125L,130L,130L,135L,135L,140L,140L,145L,145L,150L,150L,155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168284Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168284.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168284Inst : IEnumerable<long>
{
public static readonly long[] Value=A168284.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168284.Bytes);
public long this[int i]=>Value[i];

public static A168284Inst Instance=new A168284Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168285
{
public static readonly long[] Value={ 1L,3L,7L,11L,14L,19L,25L,29L,32L,37L,43L,51L,52L,57L,65L,72L,75L,76L,79L,83L,99L,104L,105L,114L,115L,125L,128L,133L,139L,149L,152L,153L,175L,178L,179L,182L,187L,197L,202L,207L,212L,213L,221L,231L,244L,247L,248L,251L,269L,278L,279L,287L,299L,304L,307L,312L,319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168285Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168285.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168285Inst : IEnumerable<long>
{
public static readonly long[] Value=A168285.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168285.Bytes);
public long this[int i]=>Value[i];

public static A168285Inst Instance=new A168285Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168286
{
public static readonly long[] Value={ 2L,8L,8L,14L,14L,20L,20L,26L,26L,32L,32L,38L,38L,44L,44L,50L,50L,56L,56L,62L,62L,68L,68L,74L,74L,80L,80L,86L,86L,92L,92L,98L,98L,104L,104L,110L,110L,116L,116L,122L,122L,128L,128L,134L,134L,140L,140L,146L,146L,152L,152L,158L,158L,164L,164L,170L,170L,176L,176L,182L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168286Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168286.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168286Inst : IEnumerable<long>
{
public static readonly long[] Value=A168286.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168286.Bytes);
public long this[int i]=>Value[i];

public static A168286Inst Instance=new A168286Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168287
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,1L,1L,11L,11L,1L,1L,26L,60L,26L,1L,1L,57L,252L,252L,57L,1L,1L,120L,931L,1746L,931L,120L,1L,1L,247L,3201L,10187L,10187L,3201L,247L,1L,1L,502L,10534L,53542L,89788L,53542L,10534L,502L,1L,1L,1013L,33698L,262466L,688976L,688976L,262466L,33698L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168287Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168287.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168287Inst : IEnumerable<long>
{
public static readonly long[] Value=A168287.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168287.Bytes);
public long this[int i]=>Value[i];

public static A168287Inst Instance=new A168287Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168288
{
public static readonly long[] Value={ 1L,1L,1L,1L,5L,1L,1L,15L,15L,1L,1L,37L,87L,37L,1L,1L,83L,373L,373L,83L,1L,1L,177L,1389L,2609L,1389L,177L,1L,1L,367L,4791L,15263L,15263L,4791L,367L,1L,1L,749L,15787L,80285L,134647L,80285L,15787L,749L,1L,1L,1515L,50529L,393657L,1033401L,1033401L,393657L,50529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168288Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168288.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168288Inst : IEnumerable<long>
{
public static readonly long[] Value=A168288.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168288.Bytes);
public long this[int i]=>Value[i];

public static A168288Inst Instance=new A168288Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168289
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,19L,19L,1L,1L,48L,114L,48L,1L,1L,109L,494L,494L,109L,1L,1L,234L,1847L,3472L,1847L,234L,1L,1L,487L,6381L,20339L,20339L,6381L,487L,1L,1L,996L,21040L,107028L,179506L,107028L,21040L,996L,1L,1L,2017L,67360L,524848L,1377826L,1377826L,524848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168289Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168289.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168289Inst : IEnumerable<long>
{
public static readonly long[] Value=A168289.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168289.Bytes);
public long this[int i]=>Value[i];

public static A168289Inst Instance=new A168289Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168290
{
public static readonly long[] Value={ 1L,1L,1L,1L,7L,1L,1L,23L,23L,1L,1L,59L,141L,59L,1L,1L,135L,615L,615L,135L,1L,1L,291L,2305L,4335L,2305L,291L,1L,1L,607L,7971L,25415L,25415L,7971L,607L,1L,1L,1243L,26293L,133771L,224365L,133771L,26293L,1243L,1L,1L,2519L,84191L,656039L,1722251L,1722251L,656039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168290Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168290.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168290Inst : IEnumerable<long>
{
public static readonly long[] Value=A168290.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168290.Bytes);
public long this[int i]=>Value[i];

public static A168290Inst Instance=new A168290Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168291
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,15L,15L,1L,1L,32L,82L,32L,1L,1L,65L,330L,330L,65L,1L,1L,130L,1159L,2304L,1159L,130L,1L,1L,259L,3801L,13195L,13195L,3801L,259L,1L,1L,516L,12016L,67316L,117170L,67316L,12016L,516L,1L,1L,1029L,37212L,319332L,889230L,889230L,319332L,37212L,1029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168291Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168291.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168291Inst : IEnumerable<long>
{
public static readonly long[] Value=A168291.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168291.Bytes);
public long this[int i]=>Value[i];

public static A168291Inst Instance=new A168291Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168292
{
public static readonly long[] Value={ 7L,7L,7L,7L,38L,7L,7L,99L,99L,7L,7L,220L,546L,220L,7L,7L,461L,2236L,2236L,461L,7L,7L,942L,8001L,15596L,8001L,942L,7L,7L,1903L,26697L,89921L,89921L,26697L,1903L,7L,7L,3824L,85660L,463520L,796594L,463520L,85660L,3824L,7L,7L,7665L,268530L,2224350L,6068400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168292Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168292.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168292Inst : IEnumerable<long>
{
public static readonly long[] Value=A168292.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168292.Bytes);
public long this[int i]=>Value[i];

public static A168292Inst Instance=new A168292Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168293
{
public static readonly long[] Value={ 1L,1L,1L,1L,14L,1L,1L,33L,33L,1L,1L,64L,186L,64L,1L,1L,119L,724L,724L,119L,1L,1L,222L,2415L,5120L,2415L,222L,1L,1L,421L,7491L,28799L,28799L,7491L,421L,1L,1L,812L,22456L,142268L,257866L,142268L,22456L,812L,1L,1L,1587L,66342L,649554L,1934544L,1934544L,649554L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168293Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168293.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168293Inst : IEnumerable<long>
{
public static readonly long[] Value=A168293.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168293.Bytes);
public long this[int i]=>Value[i];

public static A168293Inst Instance=new A168293Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168294
{
public static readonly long[] Value={ 0L,2L,6L,2L,0L,0L,2L,6L,2L,90L,110L,132L,156L,172L,190L,110L,132L,156L,172L,280L,420L,462L,406L,442L,480L,420L,462L,406L,442L,670L,930L,992L,956L,912L,970L,930L,992L,956L,912L,260L,640L,622L,606L,682L,660L,640L,622L,606L,682L,50L,550L,552L,556L,552L,550L,550L,552L,556L,552L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168294Inst : IEnumerable<long>
{
public static readonly long[] Value=A168294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168294.Bytes);
public long this[int i]=>Value[i];

public static A168294Inst Instance=new A168294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168295
{
public static readonly long[] Value={ 1L,1L,2L,2L,10L,10L,6L,52L,120L,80L,24L,280L,1160L,1760L,880L,120L,1520L,10000L,27200L,30800L,12320L,720L,11280L,78160L,343200L,695200L,628320L,209440L,5040L,164640L,784000L,3684800L,12073600L,19490240L,14660800L,4188800L,40320L,1438080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168295Inst : IEnumerable<long>
{
public static readonly long[] Value=A168295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168295.Bytes);
public long this[int i]=>Value[i];

public static A168295Inst Instance=new A168295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168296
{
public static readonly long[] Value={ 1L,1L,2L,2L,18L,18L,6L,156L,432L,288L,24L,792L,7416L,13248L,6624L,120L,-11280L,64800L,374400L,496800L,198720L,720L,-62640L,-1254960L,4968000L,20865600L,22057920L,7352640L,5040L,24012000L,-11854080L,-125677440L,389491200L,1288103040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168296Inst : IEnumerable<long>
{
public static readonly long[] Value=A168296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168296.Bytes);
public long this[int i]=>Value[i];

public static A168296Inst Instance=new A168296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168297
{
public static readonly long[] Value={ 1L,1L,9L,31L,73L,141L,241L,379L,561L,793L,1081L,1431L,1849L,2341L,2913L,3571L,4321L,5169L,6121L,7183L,8361L,9661L,11089L,12651L,14353L,16201L,18201L,20359L,22681L,25173L,27841L,30691L,33729L,36961L,40393L,44031L,47881L,51949L,56241L,60763L,65521L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168297Inst : IEnumerable<long>
{
public static readonly long[] Value=A168297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168297.Bytes);
public long this[int i]=>Value[i];

public static A168297Inst Instance=new A168297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168298
{
public static readonly long[] Value={ 1L,-1L,-15L,-71L,-255L,-799L,-2303L,-6271L,-16383L,-41471L,-102399L,-247807L,-589823L,-1384447L,-3211263L,-7372799L,-16777215L,-37879807L,-84934655L,-189267967L,-419430399L,-924844031L,-2030043135L,-4437573631L,-9663676415L,-20971519999L,-45365592063L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168298Inst : IEnumerable<long>
{
public static readonly long[] Value=A168298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168298.Bytes);
public long this[int i]=>Value[i];

public static A168298Inst Instance=new A168298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168299
{
public static readonly long[] Value={ 1L,4L,73L,730L,5185L,30376L,157465L,750142L,3359233L,14348908L,59049001L,235782658L,918330049L,3502727632L,13124466937L,48427561126L,176319369217L,634465620820L,2259436291849L,7971951402154L,27894275208001L,96873331012984L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168299Inst : IEnumerable<long>
{
public static readonly long[] Value=A168299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168299.Bytes);
public long this[int i]=>Value[i];

public static A168299Inst Instance=new A168299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168300
{
public static readonly long[] Value={ 5L,5L,11L,11L,17L,17L,23L,23L,29L,29L,35L,35L,41L,41L,47L,47L,53L,53L,59L,59L,65L,65L,71L,71L,77L,77L,83L,83L,89L,89L,95L,95L,101L,101L,107L,107L,113L,113L,119L,119L,125L,125L,131L,131L,137L,137L,143L,143L,149L,149L,155L,155L,161L,161L,167L,167L,173L,173L,179L,179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168300Inst : IEnumerable<long>
{
public static readonly long[] Value=A168300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168300.Bytes);
public long this[int i]=>Value[i];

public static A168300Inst Instance=new A168300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168301
{
public static readonly long[] Value={ 1L,7L,7L,13L,13L,19L,19L,25L,25L,31L,31L,37L,37L,43L,43L,49L,49L,55L,55L,61L,61L,67L,67L,73L,73L,79L,79L,85L,85L,91L,91L,97L,97L,103L,103L,109L,109L,115L,115L,121L,121L,127L,127L,133L,133L,139L,139L,145L,145L,151L,151L,157L,157L,163L,163L,169L,169L,175L,175L,181L,181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168301Inst : IEnumerable<long>
{
public static readonly long[] Value=A168301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168301.Bytes);
public long this[int i]=>Value[i];

public static A168301Inst Instance=new A168301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168302
{
public static readonly long[] Value={ -8L,-66L,-264L,-689L,-1255L,-1360L,684L,8502L,28842L,73150L,159588L,315549L,580723L,1010768L,1681640L,2694636L,4182204L,6314574L,9307264L,13429515L,19013709L,26465824L,36276980L,49036130L,65443950L,86327982L,112659084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168302Inst : IEnumerable<long>
{
public static readonly long[] Value=A168302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168302.Bytes);
public long this[int i]=>Value[i];

public static A168302Inst Instance=new A168302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168303
{
public static readonly long[] Value={ 24L,308L,2236L,11640L,47753L,163419L,485121L,1284987L,3101175L,6927921L,14502059L,28718989L,54217878L,98183330L,171418854L,289756194L,475873962L,761609034L,1190854830L,1823151902L,2738088199L,4040638965L,5867589455L,8395197525L,11848267665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168303Inst : IEnumerable<long>
{
public static readonly long[] Value=A168303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168303.Bytes);
public long this[int i]=>Value[i];

public static A168303Inst Instance=new A168303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A168304
{
public static readonly long[] Value={ 24L,368L,2736L,13712L,53121L,171258L,480711L,1210572L,2793219L,5996562L,12117677L,23257104L,42696758L,75408396L,128723898L,213203256L,343741122L,540958044L,832928118L,1257300704L,1863880095L,2717733590L,3902905305L,5526820260L,7725470805L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A168304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A168304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A168304Inst : IEnumerable<long>
{
public static readonly long[] Value=A168304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A168304.Bytes);
public long this[int i]=>Value[i];

public static A168304Inst Instance=new A168304Inst();

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