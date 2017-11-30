using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A191961
{
public static readonly long[] Value={ 1L,1L,9L,6998L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191961Inst : IEnumerable<long>
{
public static readonly long[] Value=A191961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191961.Bytes);
public long this[int i]=>Value[i];

public static A191961Inst Instance=new A191961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191962
{
public static readonly long[] Value={ 1L,1L,5L,45L,832L,37461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191962Inst : IEnumerable<long>
{
public static readonly long[] Value=A191962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191962.Bytes);
public long this[int i]=>Value[i];

public static A191962Inst Instance=new A191962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191963
{
public static readonly long[] Value={ 1L,17L,799L,74559L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191963Inst : IEnumerable<long>
{
public static readonly long[] Value=A191963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191963.Bytes);
public long this[int i]=>Value[i];

public static A191963Inst Instance=new A191963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191980
{
public static readonly long[] Value={ 6L,8L,9L,12L,16L,18L,19L,21L,22L,23L,24L,26L,27L,31L,33L,34L,36L,38L,39L,42L,44L,46L,49L,52L,53L,56L,58L,59L,62L,64L,66L,67L,73L,81L,82L,84L,91L,93L,94L,96L,97L,101L,102L,108L,111L,119L,128L,131L,137L,138L,143L,146L,148L,149L,152L,156L,158L,163L,166L,174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191980Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191980.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191980Inst : IEnumerable<long>
{
public static readonly long[] Value=A191980.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191980.Bytes);
public long this[int i]=>Value[i];

public static A191980Inst Instance=new A191980Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191981
{
public static readonly long[] Value={ 0L,2L,3L,6L,9L,12L,13L,14L,21L,24L,27L,32L,33L,41L,42L,54L,56L,61L,68L,71L,87L,88L,103L,108L,109L,118L,141L,144L,164L,177L,179L,184L,194L,228L,232L,267L,286L,287L,302L,307L,317L,369L,376L,431L,463L,466L,486L,501L,506L,516L,597L,608L,698L,749L,753L,788L,808L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191981Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191981.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191981Inst : IEnumerable<long>
{
public static readonly long[] Value=A191981.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191981.Bytes);
public long this[int i]=>Value[i];

public static A191981Inst Instance=new A191981Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191982
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,9L,11L,12L,13L,14L,16L,17L,19L,22L,24L,26L,28L,31L,32L,34L,36L,37L,43L,44L,48L,51L,52L,54L,58L,61L,69L,72L,79L,83L,86L,87L,89L,94L,98L,112L,116L,127L,134L,138L,141L,142L,144L,152L,159L,181L,188L,206L,217L,224L,228L,231L,232L,234L,246L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191982Inst : IEnumerable<long>
{
public static readonly long[] Value=A191982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191982.Bytes);
public long this[int i]=>Value[i];

public static A191982Inst Instance=new A191982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191983
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,11L,12L,13L,14L,16L,17L,19L,21L,22L,24L,26L,27L,28L,31L,32L,33L,34L,36L,37L,41L,42L,43L,44L,48L,51L,52L,54L,56L,58L,61L,68L,69L,71L,72L,79L,83L,86L,87L,88L,89L,94L,98L,103L,108L,109L,112L,116L,118L,127L,134L,138L,141L,142L,144L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191983Inst : IEnumerable<long>
{
public static readonly long[] Value=A191983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191983.Bytes);
public long this[int i]=>Value[i];

public static A191983Inst Instance=new A191983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191984
{
public static readonly long[] Value={ 4L,5L,7L,8L,10L,11L,13L,14L,16L,19L,20L,22L,25L,26L,28L,32L,35L,38L,40L,44L,49L,50L,52L,56L,64L,67L,70L,76L,80L,88L,97L,98L,100L,104L,112L,128L,131L,134L,140L,152L,160L,176L,193L,194L,196L,200L,208L,224L,256L,259L,262L,268L,280L,304L,320L,352L,385L,386L,388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191984Inst : IEnumerable<long>
{
public static readonly long[] Value=A191984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191984.Bytes);
public long this[int i]=>Value[i];

public static A191984Inst Instance=new A191984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191985
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,13L,16L,20L,26L,29L,32L,40L,52L,58L,61L,64L,80L,104L,116L,122L,125L,128L,160L,208L,232L,244L,250L,253L,256L,320L,416L,464L,488L,500L,506L,509L,512L,640L,832L,928L,976L,1000L,1012L,1018L,1021L,1024L,1280L,1664L,1856L,1952L,2000L,2024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191985Inst : IEnumerable<long>
{
public static readonly long[] Value=A191985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191985.Bytes);
public long this[int i]=>Value[i];

public static A191985Inst Instance=new A191985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191986
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,11L,16L,20L,22L,23L,32L,40L,44L,46L,47L,64L,80L,88L,92L,94L,95L,128L,160L,176L,184L,188L,190L,191L,256L,320L,352L,368L,376L,380L,382L,383L,512L,640L,704L,736L,752L,760L,764L,766L,767L,1024L,1280L,1408L,1472L,1504L,1520L,1528L,1532L,1534L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191986Inst : IEnumerable<long>
{
public static readonly long[] Value=A191986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191986.Bytes);
public long this[int i]=>Value[i];

public static A191986Inst Instance=new A191986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191987
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,8L,10L,11L,13L,16L,20L,22L,23L,26L,29L,32L,40L,44L,46L,47L,52L,58L,61L,64L,80L,88L,92L,94L,95L,104L,116L,122L,125L,128L,160L,176L,184L,188L,190L,191L,208L,232L,244L,250L,253L,256L,320L,352L,368L,376L,380L,382L,383L,416L,464L,488L,500L,506L,509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191987Inst : IEnumerable<long>
{
public static readonly long[] Value=A191987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191987.Bytes);
public long this[int i]=>Value[i];

public static A191987Inst Instance=new A191987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191988
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,21L,22L,23L,26L,27L,28L,29L,34L,37L,41L,42L,43L,49L,51L,56L,57L,61L,63L,69L,71L,73L,77L,78L,91L,92L,93L,96L,98L,99L,104L,109L,112L,113L,114L,126L,129L,147L,148L,149L,151L,153L,157L,159L,167L,172L,181L,184L,187L,203L,207L,237L,239L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191988Inst : IEnumerable<long>
{
public static readonly long[] Value=A191988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191988.Bytes);
public long this[int i]=>Value[i];

public static A191988Inst Instance=new A191988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191989
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,7L,9L,11L,16L,17L,18L,21L,23L,29L,31L,38L,39L,43L,47L,53L,59L,62L,74L,76L,79L,89L,97L,101L,117L,123L,132L,137L,147L,156L,163L,191L,199L,211L,226L,231L,241L,253L,264L,308L,322L,343L,363L,378L,383L,393L,409L,427L,499L,521L,554L,589L,609L,624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191989Inst : IEnumerable<long>
{
public static readonly long[] Value=A191989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191989.Bytes);
public long this[int i]=>Value[i];

public static A191989Inst Instance=new A191989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191990
{
public static readonly long[] Value={ 0L,1L,3L,6L,7L,9L,12L,13L,14L,18L,19L,21L,27L,29L,32L,33L,41L,47L,49L,51L,53L,54L,68L,76L,82L,83L,84L,87L,88L,109L,123L,131L,134L,137L,139L,141L,143L,177L,199L,213L,217L,221L,227L,228L,229L,233L,286L,322L,344L,351L,358L,366L,369L,372L,374L,378L,463L,521L,557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191990Inst : IEnumerable<long>
{
public static readonly long[] Value=A191990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191990.Bytes);
public long this[int i]=>Value[i];

public static A191990Inst Instance=new A191990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191991
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,7L,9L,11L,12L,13L,14L,16L,17L,18L,19L,21L,23L,27L,29L,31L,32L,33L,38L,39L,41L,43L,47L,49L,51L,53L,54L,59L,62L,68L,74L,76L,79L,82L,83L,84L,87L,88L,89L,97L,101L,109L,117L,123L,131L,132L,134L,137L,139L,141L,143L,147L,156L,163L,177L,191L,199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191991Inst : IEnumerable<long>
{
public static readonly long[] Value=A191991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191991.Bytes);
public long this[int i]=>Value[i];

public static A191991Inst Instance=new A191991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191992
{
public static readonly long[] Value={ 14L,26L,38L,49L,510L,612L,714L,815L,916L,1018L,1120L,1221L,1322L,1424L,1525L,1626L,1727L,1828L,1930L,2032L,2133L,2234L,2335L,2436L,2538L,2639L,2740L,2842L,2944L,3045L,3146L,3248L,3349L,3450L,3551L,3652L,3754L,3855L,3956L,4057L,4158L,4260L,4362L,4463L,4564L,4665L,4766L,4868L,4969L,5070L,5172L,5274L,5375L,5476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191992Inst : IEnumerable<long>
{
public static readonly long[] Value=A191992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191992.Bytes);
public long this[int i]=>Value[i];

public static A191992Inst Instance=new A191992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191993
{
public static readonly long[] Value={ 2L,6L,19L,62L,207L,705L,2445L,8622L,30871L,112061L,411765L,1529225L,5731741L,21652623L,82341729L,314889102L,1209849831L,4666707813L,18060052389L,70085525877L,272615721621L,1062509835063L,4148096423409L,16217945020377L,63487732755357L,248806555083495L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191993Inst : IEnumerable<long>
{
public static readonly long[] Value=A191993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191993.Bytes);
public long this[int i]=>Value[i];

public static A191993Inst Instance=new A191993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191994
{
public static readonly BigInteger[] Value={ 1L,2L,8L,42L,360L,4800L,102960L,3538080L,196035840L,17520703200L,2529842515200L,590412901478400L,222813349683724800L,BigInteger.Parse("136001024583142118400"),BigInteger.Parse("134285149587387262464000"),BigInteger.Parse("214504624277084224347264000"),BigInteger.Parse("554361997358383529330695680000") };
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
public class A191994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191994.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191994Inst Instance=new A191994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191995
{
public static readonly long[] Value={ 0L,1L,-1L,-2L,14L,-6L,-406L,2220L,13768L,-280224L,501824L,34875600L,-394160416L,-3296452368L,129418793776L,-532969950240L,-35512135858048L,654965382945408L,5943454902108032L,-395494767434053632L,2913398252129581312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191995Inst : IEnumerable<long>
{
public static readonly long[] Value=A191995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191995.Bytes);
public long this[int i]=>Value[i];

public static A191995Inst Instance=new A191995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192012
{
public static readonly BigInteger[] Value={ 1L,4L,35L,877L,46173L,4108044L,550917287L,103674052788L,26046619272535L,8420151470990221L,3404266960229749907L,BigInteger.Parse("1682802564587905472500"),BigInteger.Parse("998472258682783813839141"),BigInteger.Parse("700281698972322460184258208"),BigInteger.Parse("573086115189070229131370358179"),BigInteger.Parse("541208343386984031504989621465925") };
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
public class A192012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192012Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192012.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192012Inst Instance=new A192012Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192013
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,1L,2L,2L,1L,0L,2L,2L,1L,0L,1L,0L,2L,2L,2L,0L,1L,3L,0L,1L,2L,2L,2L,2L,1L,2L,0L,4L,1L,0L,0L,0L,2L,0L,2L,0L,2L,2L,0L,0L,1L,3L,3L,0L,0L,2L,1L,4L,2L,0L,2L,2L,2L,0L,2L,2L,1L,0L,2L,0L,0L,0L,4L,0L,1L,2L,0L,3L,0L,4L,0L,2L,2L,1L,0L,2L,2L,0L,0L,2L,2L,0L,2L,0L,0L,2L,0L,0L,1L,2L,3L,2L,3L,2L,0L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192013Inst : IEnumerable<long>
{
public static readonly long[] Value=A192013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192013.Bytes);
public long this[int i]=>Value[i];

public static A192013Inst Instance=new A192013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192014
{
public static readonly long[] Value={ 0L,4L,1L,8L,8L,3L,6L,8L,0L,8L,3L,1L,5L,0L,2L,9L,8L,5L,0L,7L,1L,2L,5L,2L,8L,9L,8L,6L,2L,4L,5L,7L,1L,6L,8L,2L,4L,2L,6L,0L,9L,6L,7L,5L,8L,4L,6L,5L,4L,8L,5L,7L,5L,3L,5L,1L,8L,2L,8L,9L,2L,1L,9L,5L,4L,2L,0L,5L,0L,0L,6L,7L,2L,8L,9L,6L,6L,7L,1L,0L,6L,4L,5L,1L,8L,6L,5L,5L,7L,0L,7L,4L,2L,2L,6L,8L,1L,6L,8L,7L,0L,1L,4L,8L,1L,7L,3L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192014Inst : IEnumerable<long>
{
public static readonly long[] Value=A192014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192014.Bytes);
public long this[int i]=>Value[i];

public static A192014Inst Instance=new A192014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192015
{
public static readonly long[] Value={ 0L,1L,1L,4L,1L,1L,12L,6L,1L,1L,32L,1L,1L,1L,10L,27L,1L,1L,80L,1L,1L,1L,1L,14L,1L,1L,1L,192L,1L,1L,1L,1L,108L,1L,1L,1L,1L,1L,1L,1L,1L,22L,75L,1L,448L,1L,1L,1L,1L,1L,1L,1L,1L,26L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,405L,1L,1024L,1L,1L,1L,1L,1L,1L,1L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192015Inst : IEnumerable<long>
{
public static readonly long[] Value=A192015.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192015.Bytes);
public long this[int i]=>Value[i];

public static A192015Inst Instance=new A192015Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192016
{
public static readonly long[] Value={ 0L,0L,0L,4L,0L,0L,16L,5L,0L,0L,80L,0L,0L,0L,7L,27L,0L,0L,176L,0L,0L,0L,0L,9L,0L,0L,0L,640L,0L,0L,0L,0L,216L,0L,0L,0L,0L,0L,0L,0L,0L,13L,55L,0L,1408L,0L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,621L,0L,5120L,0L,0L,0L,0L,0L,0L,0L,19L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192016Inst : IEnumerable<long>
{
public static readonly long[] Value=A192016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192016.Bytes);
public long this[int i]=>Value[i];

public static A192016Inst Instance=new A192016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192017
{
public static readonly long[] Value={ 1L,2L,1L,4L,4L,2L,7L,10L,9L,2L,12L,21L,27L,15L,3L,20L,40L,65L,57L,25L,3L,33L,72L,138L,163L,114L,37L,4L,54L,125L,270L,394L,378L,206L,54L,4L,88L,212L,500L,854L,1033L,796L,354L,74L,5L,143L,354L,891L,1716L,2479L,2463L,1571L,574L,100L,5L,232L,585L,1545L,3265L,5424L,6559L,5469L,2917L,896L,130L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192017Inst : IEnumerable<long>
{
public static readonly long[] Value=A192017.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192017.Bytes);
public long this[int i]=>Value[i];

public static A192017Inst Instance=new A192017Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192018
{
public static readonly long[] Value={ 1L,3L,2L,1L,6L,6L,5L,3L,1L,11L,13L,14L,12L,10L,5L,1L,19L,24L,30L,31L,31L,28L,19L,7L,1L,32L,42L,56L,66L,74L,78L,77L,61L,32L,9L,1L,53L,71L,98L,124L,152L,175L,196L,203L,180L,118L,49L,11L,1L,87L,118L,166L,218L,284L,349L,419L,485L,525L,502L,384L,207L,70L,13L,1L,142L,194L,276L,370L,499L,645L,812L,998L,1189L,1331L,1349L,1152L,749L,336L,95L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192018Inst : IEnumerable<long>
{
public static readonly long[] Value=A192018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192018.Bytes);
public long this[int i]=>Value[i];

public static A192018Inst Instance=new A192018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192019
{
public static readonly long[] Value={ 1L,10L,50L,214L,802L,2802L,9275L,29580L,91668L,277924L,828092L,2433140L,7067885L,20337318L,58054534L,164602410L,463990190L,1301338150L,3633753815L,10107239160L,28016346216L,77419909800L,213349801560L,586471432104L,1608485221177L,4402406713762L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192019Inst : IEnumerable<long>
{
public static readonly long[] Value=A192019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192019.Bytes);
public long this[int i]=>Value[i];

public static A192019Inst Instance=new A192019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192020
{
public static readonly long[] Value={ 1L,3L,2L,1L,7L,8L,8L,4L,1L,15L,22L,31L,28L,17L,6L,1L,31L,52L,90L,112L,104L,68L,30L,8L,1L,63L,114L,225L,344L,418L,388L,270L,136L,47L,10L,1L,127L,240L,516L,908L,1331L,1568L,1464L,1064L,589L,240L,68L,12L,1L,255L,494L,1123L,2180L,3663L,5138L,5931L,5560L,4181L,2482L,1137L,388L,93L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192020Inst : IEnumerable<long>
{
public static readonly long[] Value=A192020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192020.Bytes);
public long this[int i]=>Value[i];

public static A192020Inst Instance=new A192020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192021
{
public static readonly long[] Value={ 1L,10L,68L,392L,2064L,10272L,49216L,229504L,1048832L,4719104L,20972544L,92276736L,402657280L,1744838656L,7516209152L,32212287488L,137439019008L,584115683328L,2473901424640L,10445360988160L,43980466159616L,184717955563520L,774056190148608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192021Inst : IEnumerable<long>
{
public static readonly long[] Value=A192021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192021.Bytes);
public long this[int i]=>Value[i];

public static A192021Inst Instance=new A192021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192022
{
public static readonly long[] Value={ 1L,0L,3L,2L,1L,5L,5L,4L,1L,7L,8L,8L,4L,1L,9L,11L,12L,8L,4L,1L,11L,14L,16L,12L,8L,4L,1L,13L,17L,20L,16L,12L,8L,4L,1L,15L,20L,24L,20L,16L,12L,8L,4L,1L,17L,23L,28L,24L,20L,16L,12L,8L,4L,1L,19L,26L,32L,28L,24L,20L,16L,12L,8L,4L,1L,21L,29L,36L,32L,28L,24L,20L,16L,12L,8L,4L,1L,23L,32L,40L,36L,32L,28L,24L,20L,16L,12L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192022Inst : IEnumerable<long>
{
public static readonly long[] Value=A192022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192022.Bytes);
public long this[int i]=>Value[i];

public static A192022Inst Instance=new A192022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192023
{
public static readonly long[] Value={ 1L,10L,31L,68L,125L,206L,315L,456L,633L,850L,1111L,1420L,1781L,2198L,2675L,3216L,3825L,4506L,5263L,6100L,7021L,8030L,9131L,10328L,11625L,13026L,14535L,16156L,17893L,19750L,21731L,23840L,26081L,28458L,30975L,33636L,36445L,39406L,42523L,45800L,49241L,52850L,56631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192023Inst : IEnumerable<long>
{
public static readonly long[] Value=A192023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192023.Bytes);
public long this[int i]=>Value[i];

public static A192023Inst Instance=new A192023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192024
{
public static readonly long[] Value={ 2L,1L,5L,6L,4L,8L,12L,12L,4L,11L,18L,21L,12L,4L,14L,24L,30L,21L,12L,4L,17L,30L,39L,30L,21L,12L,4L,20L,36L,48L,39L,30L,21L,12L,4L,23L,42L,57L,48L,39L,30L,21L,12L,4L,26L,48L,66L,57L,48L,39L,30L,21L,12L,4L,29L,54L,75L,66L,57L,48L,39L,30L,21L,12L,4L,32L,60L,84L,75L,66L,57L,48L,39L,30L,21L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192024Inst : IEnumerable<long>
{
public static readonly long[] Value=A192024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192024.Bytes);
public long this[int i]=>Value[i];

public static A192024Inst Instance=new A192024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192025
{
public static readonly long[] Value={ 4L,29L,84L,178L,320L,519L,784L,1124L,1548L,2065L,2684L,3414L,4264L,5243L,6360L,7624L,9044L,10629L,12388L,14330L,16464L,18799L,21344L,24108L,27100L,30329L,33804L,37534L,41528L,45795L,50344L,55184L,60324L,65773L,71540L,77634L,84064L,90839L,97968L,105460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192025Inst : IEnumerable<long>
{
public static readonly long[] Value=A192025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192025.Bytes);
public long this[int i]=>Value[i];

public static A192025Inst Instance=new A192025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192026
{
public static readonly long[] Value={ 36L,72L,90L,120L,180L,168L,180L,300L,336L,270L,252L,450L,560L,540L,396L,336L,630L,840L,900L,792L,546L,432L,840L,1176L,1350L,1320L,1092L,720L,540L,1080L,1568L,1890L,1980L,1820L,1440L,918L,660L,1350L,2016L,2520L,2772L,2730L,2400L,1836L,1140L,792L,1650L,2520L,3240L,3696L,3822L,3600L,3060L,2280L,1386L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192026Inst : IEnumerable<long>
{
public static readonly long[] Value=A192026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192026.Bytes);
public long this[int i]=>Value[i];

public static A192026Inst Instance=new A192026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192027
{
public static readonly long[] Value={ 1L,10L,4L,27L,29L,9L,60L,75L,58L,16L,105L,160L,147L,97L,25L,174L,275L,308L,243L,146L,36L,259L,447L,525L,504L,363L,205L,49L,376L,658L,846L,855L,748L,507L,274L,64L,513L,944L,1239L,1371L,1265L,1040L,675L,353L,81L,690L,1278L,1768L,2002L,2022L,1755L,1380L,867L,442L,100L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192027Inst : IEnumerable<long>
{
public static readonly long[] Value=A192027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192027.Bytes);
public long this[int i]=>Value[i];

public static A192027Inst Instance=new A192027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192060
{
public static readonly BigInteger[] Value={ 1L,0L,-3L,15L,42L,-2895L,54417L,-251160L,-32268603L,1859064495L,-56137896318L,-300966155655L,194418466667697L,-17000801954550960L,829654990634826717L,8111862191577165855L,BigInteger.Parse("-7601061861134689474758"),BigInteger.Parse("1057729211267718608758065") };
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
public class A192060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192060Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192060.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192060Inst Instance=new A192060Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192061
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,11L,15L,22L,30L,42L,56L,65L,89L,111L,140L,171L,213L,253L,310L,363L,432L,498L,583L,705L,800L,924L,1060L,1216L,1379L,1578L,1772L,2013L,2259L,2554L,2847L,3147L,3507L,3897L,4305L,4756L,5225L,5748L,6297L,6909L,7546L,8250L,9000L,9724L,10626L,11512L,12478L,13482L,14616L,15714L,17007L,18215L,19602L,20930L,22470L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192061Inst : IEnumerable<long>
{
public static readonly long[] Value=A192061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192061.Bytes);
public long this[int i]=>Value[i];

public static A192061Inst Instance=new A192061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192062
{
public static readonly long[] Value={ 0L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,2L,2L,0L,1L,1L,3L,3L,1L,0L,1L,1L,4L,4L,5L,3L,0L,1L,1L,5L,5L,11L,8L,1L,0L,1L,1L,6L,6L,19L,15L,13L,4L,0L,1L,1L,7L,7L,29L,24L,41L,21L,1L,0L,1L,1L,8L,8L,41L,35L,91L,56L,34L,5L,0L,1L,1L,9L,9L,55L,48L,169L,115L,153L,55L,1L,0L,1L,1L,10L,10L,71L,63L,281L,204L,436L,209L,89L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192062Inst : IEnumerable<long>
{
public static readonly long[] Value=A192062.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192062.Bytes);
public long this[int i]=>Value[i];

public static A192062Inst Instance=new A192062Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192063
{
public static readonly BigInteger[] Value={ 0L,2L,4L,152L,8944L,933152L,151557184L,35402298752L,11250504212224L,4668840721981952L,2451963626804184064L,BigInteger.Parse("1589715293557268682752"),BigInteger.Parse("1247113599659216858312704"),BigInteger.Parse("1164315843409068590677041152"),BigInteger.Parse("127574292191869924893941171814") };
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
public class A192063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192063.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192063Inst Instance=new A192063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192064
{
public static readonly long[] Value={ 0L,1L,2L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,2L,1L,0L,1L,3L,3L,2L,3L,3L,2L,2L,2L,0L,1L,0L,0L,1L,0L,2L,2L,2L,0L,1L,3L,2L,0L,2L,0L,2L,3L,0L,1L,0L,1L,0L,0L,0L,2L,0L,1L,0L,2L,1L,3L,3L,2L,1L,0L,3L,1L,1L,1L,1L,2L,5L,1L,1L,1L,0L,0L,1L,3L,0L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192064Inst : IEnumerable<long>
{
public static readonly long[] Value=A192064.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192064.Bytes);
public long this[int i]=>Value[i];

public static A192064Inst Instance=new A192064Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192065
{
public static readonly long[] Value={ 1L,1L,3L,7L,14L,28L,58L,106L,201L,372L,669L,1187L,2101L,3624L,6229L,10591L,17796L,29659L,49107L,80492L,131157L,212237L,341084L,544883L,865717L,1367233L,2148552L,3359490L,5227270L,8096544L,12486800L,19174319L,29326306L,44678825L,67811375L,102549673L,154545549L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192065Inst : IEnumerable<long>
{
public static readonly long[] Value=A192065.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192065.Bytes);
public long this[int i]=>Value[i];

public static A192065Inst Instance=new A192065Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192066
{
public static readonly long[] Value={ 1L,1L,4L,1L,6L,4L,8L,1L,10L,6L,12L,4L,14L,8L,24L,1L,18L,10L,20L,6L,32L,12L,24L,4L,26L,14L,28L,8L,30L,24L,32L,1L,48L,18L,48L,10L,38L,20L,56L,6L,42L,32L,44L,12L,60L,24L,48L,4L,50L,26L,72L,14L,54L,28L,72L,8L,80L,30L,60L,24L,62L,32L,80L,1L,84L,48L,68L,18L,96L,48L,72L,10L,74L,38L,104L,20L,96L,56L,80L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192066Inst : IEnumerable<long>
{
public static readonly long[] Value=A192066.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192066.Bytes);
public long this[int i]=>Value[i];

public static A192066Inst Instance=new A192066Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192067
{
public static readonly long[] Value={ 5L,7L,8L,10L,11L,14L,16L,19L,20L,22L,26L,28L,32L,35L,38L,40L,44L,50L,52L,56L,64L,67L,70L,76L,80L,88L,98L,100L,104L,112L,128L,131L,134L,140L,152L,160L,176L,194L,196L,200L,208L,224L,256L,259L,262L,268L,280L,304L,320L,352L,386L,388L,392L,400L,416L,448L,512L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192067Inst : IEnumerable<long>
{
public static readonly long[] Value=A192067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192067.Bytes);
public long this[int i]=>Value[i];

public static A192067Inst Instance=new A192067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192068
{
public static readonly long[] Value={ 0L,3L,7L,21L,54L,144L,376L,987L,2583L,6765L,17710L,46368L,121392L,317811L,832039L,2178309L,5702886L,14930352L,39088168L,102334155L,267914295L,701408733L,1836311902L,4807526976L,12586269024L,32951280099L,86267571271L,225851433717L,591286729878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192068Inst : IEnumerable<long>
{
public static readonly long[] Value=A192068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192068.Bytes);
public long this[int i]=>Value[i];

public static A192068Inst Instance=new A192068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192069
{
public static readonly long[] Value={ 0L,1L,4L,18L,60L,186L,522L,1380L,3459L,8321L,19332L,43629L,96045L,206953L,437677L,910549L,1866952L,3778561L,7558953L,14963504L,29340482L,57033862L,109989752L,210575822L,400452782L,756836537L,1422191570L,2658250044L,4943946756L,9152396892L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192069Inst : IEnumerable<long>
{
public static readonly long[] Value=A192069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192069.Bytes);
public long this[int i]=>Value[i];

public static A192069Inst Instance=new A192069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192070
{
public static readonly long[] Value={ 0L,1L,4L,24L,129L,759L,4455L,26763L,161898L,988438L,6069228L,37460952L,232160184L,1443830084L,9005809184L,56316652784L,352949825249L,2216334391919L,13941409199519L,87830683173419L,554096566907069L,3499981913717189L,22132830286939649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192070Inst : IEnumerable<long>
{
public static readonly long[] Value=A192070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192070.Bytes);
public long this[int i]=>Value[i];

public static A192070Inst Instance=new A192070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192071
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-108L,0L,0L,-46656L,0L,0L,-56267136L,0L,0L,-91334158848L,0L,0L,-187875634540032L,0L,0L,-452928490364583936L,0L,0L,BigInteger.Parse("-1241099993772119162880"),0L,0L,BigInteger.Parse("-3783238246806589528473600"),0L,0L,BigInteger.Parse("-12650825837219458785210335232"),0L,0L,BigInteger.Parse("-45942311360783796910833996398592"),0L,0L };
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
public class A192071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192071Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192071.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192071Inst Instance=new A192071Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192072
{
public static readonly BigInteger[] Value={ 0L,6L,0L,0L,648L,0L,0L,793152L,0L,0L,1262231424L,0L,0L,2646377775360L,0L,0L,6519085424584704L,0L,0L,18278010233307389952UL,0L,0L,BigInteger.Parse("56939392133946726580224"),0L,0L,BigInteger.Parse("194204339279813558544629760"),0L,0L,BigInteger.Parse("717807985600217602759000326144"),0L,0L,BigInteger.Parse("2853876809466218301455118709555200"),0L,0L };
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
public class A192072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192072Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192072.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192072Inst Instance=new A192072Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192073
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-216L,0L,0L,-46656L,0L,0L,-64665216L,0L,0L,-99769190400L,0L,0L,-209379250944000L,0L,0L,-509919494798794752L,0L,0L,BigInteger.Parse("-1418277076317722640384"),0L,0L,BigInteger.Parse("-4383492791601029274796032"),0L,0L,BigInteger.Parse("-14847316831212641665639907328"),0L,0L,BigInteger.Parse("-54539904643021932808281375375360"),0L,0L };
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
public class A192073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192073Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192073.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192073Inst Instance=new A192073Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192074
{
public static readonly long[] Value={ 0L,0L,4L,16L,53L,172L,568L,1906L,6471L,22200L,76884L,268350L,942649L,3329606L,11817580L,42120338L,150682448L,540832272L,1946892840L,7027047846L,25424079337L,92185846606L,334925007126L,1219054432488L,4444545298877L,16229462702150L,59347661054362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192074Inst : IEnumerable<long>
{
public static readonly long[] Value=A192074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192074.Bytes);
public long this[int i]=>Value[i];

public static A192074Inst Instance=new A192074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192075
{
public static readonly long[] Value={ 0L,0L,0L,32L,324L,2448L,17041L,116004L,787965L,5380600L,37034319L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192075Inst : IEnumerable<long>
{
public static readonly long[] Value=A192075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192075.Bytes);
public long this[int i]=>Value[i];

public static A192075Inst Instance=new A192075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192108
{
public static readonly BigInteger[] Value={ 1L,100010101110L,212020020002101000L,BigInteger.Parse("33302203023130111130130130"),BigInteger.Parse("142330104010234210234210234210234210"),BigInteger.Parse("10225201200453221555314535245115155324023111430"),BigInteger.Parse("5152124535261564540656541032335232432112241035404402500510") };
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
public class A192108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192108Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192108.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192108Inst Instance=new A192108Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192109
{
public static readonly long[] Value={ 1L,2L,6L,10L,14L,22L,26L,30L,34L,38L,46L,58L,62L,74L,82L,86L,94L,106L,118L,122L,134L,142L,146L,158L,166L,170L,178L,182L,194L,202L,206L,214L,218L,226L,254L,262L,274L,278L,298L,302L,314L,326L,334L,346L,358L,362L,382L,386L,394L,398L,422L,446L,454L,458L,466L,478L,482L,502L,514L,526L,538L,542L,554L,562L,566L,586L,614L,622L,626L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192109Inst : IEnumerable<long>
{
public static readonly long[] Value=A192109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192109.Bytes);
public long this[int i]=>Value[i];

public static A192109Inst Instance=new A192109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192110
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,13L,15L,23L,29L,31L,37L,47L,55L,61L,63L,101L,119L,125L,127L,175L,229L,247L,253L,255L,269L,295L,431L,485L,503L,509L,511L,781L,943L,997L,1015L,1021L,1023L,1319L,1631L,1805L,1909L,1967L,2021L,2039L,2045L,2047L,3367L,3853L,4015L,4069L,4087L,4093L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192110Inst : IEnumerable<long>
{
public static readonly long[] Value=A192110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192110.Bytes);
public long this[int i]=>Value[i];

public static A192110Inst Instance=new A192110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192111
{
public static readonly long[] Value={ 0L,1L,2L,5L,7L,8L,11L,17L,19L,23L,25L,26L,49L,65L,73L,77L,79L,80L,115L,139L,179L,211L,217L,227L,235L,239L,241L,242L,473L,601L,665L,697L,713L,721L,725L,727L,728L,1163L,1675L,1931L,2059L,2123L,2155L,2171L,2179L,2183L,2185L,2186L,2465L,3299L,4513L,5537L,6049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192111Inst : IEnumerable<long>
{
public static readonly long[] Value=A192111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192111.Bytes);
public long this[int i]=>Value[i];

public static A192111Inst Instance=new A192111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192112
{
public static readonly long[] Value={ 0L,1L,3L,4L,7L,12L,15L,16L,28L,31L,48L,60L,63L,64L,112L,124L,127L,192L,240L,252L,255L,256L,448L,496L,508L,511L,768L,960L,1008L,1020L,1023L,1024L,1792L,1984L,2032L,2044L,2047L,3072L,3840L,4032L,4080L,4092L,4095L,4096L,7168L,7936L,8128L,8176L,8188L,8191L,12288L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192112Inst : IEnumerable<long>
{
public static readonly long[] Value=A192112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192112.Bytes);
public long this[int i]=>Value[i];

public static A192112Inst Instance=new A192112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192113
{
public static readonly long[] Value={ 0L,2L,3L,8L,12L,14L,15L,32L,48L,56L,60L,62L,63L,128L,192L,224L,240L,248L,252L,254L,255L,512L,768L,896L,960L,992L,1008L,1016L,1020L,1022L,1023L,2048L,3072L,3584L,3840L,3968L,4032L,4064L,4080L,4088L,4092L,4094L,4095L,8192L,12288L,14336L,15360L,15872L,16128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192113Inst : IEnumerable<long>
{
public static readonly long[] Value=A192113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192113.Bytes);
public long this[int i]=>Value[i];

public static A192113Inst Instance=new A192113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192114
{
public static readonly long[] Value={ 0L,1L,3L,7L,11L,15L,27L,31L,39L,59L,63L,103L,123L,127L,131L,231L,251L,255L,387L,399L,487L,507L,511L,759L,899L,971L,999L,1019L,1023L,1423L,1923L,2023L,2043L,2047L,3471L,3971L,4071L,4091L,4095L,5067L,7567L,8067L,8167L,8187L,8191L,13259L,15759L,16259L,16359L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192114Inst : IEnumerable<long>
{
public static readonly long[] Value=A192114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192114.Bytes);
public long this[int i]=>Value[i];

public static A192114Inst Instance=new A192114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192115
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,17L,21L,23L,24L,61L,93L,109L,113L,117L,121L,123L,124L,369L,497L,561L,593L,609L,617L,621L,623L,624L,1077L,2101L,2613L,2869L,2997L,3061L,3093L,3109L,3117L,3121L,3123L,3124L,7433L,11529L,12589L,13577L,14601L,15113L,15369L,15497L,15561L,15593L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192115Inst : IEnumerable<long>
{
public static readonly long[] Value=A192115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192115.Bytes);
public long this[int i]=>Value[i];

public static A192115Inst Instance=new A192115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192116
{
public static readonly long[] Value={ 0L,1L,2L,3L,7L,10L,15L,26L,28L,31L,40L,58L,63L,92L,122L,127L,220L,250L,255L,296L,416L,476L,506L,511L,752L,808L,988L,1018L,1023L,1832L,2012L,2042L,2047L,2800L,3880L,4060L,4090L,4095L,6896L,7976L,8156L,8186L,8191L,8608L,15088L,16168L,16348L,16378L,16383L,18880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192116Inst : IEnumerable<long>
{
public static readonly long[] Value=A192116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192116.Bytes);
public long this[int i]=>Value[i];

public static A192116Inst Instance=new A192116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192117
{
public static readonly long[] Value={ 0L,2L,4L,5L,20L,28L,32L,34L,35L,88L,152L,184L,200L,208L,212L,214L,215L,272L,784L,1040L,1168L,1232L,1264L,1280L,1288L,1292L,1294L,1295L,3680L,5728L,6752L,7264L,7520L,7648L,7712L,7744L,7760L,7768L,7772L,7774L,7775L,13888L,17792L,30272L,38464L,42560L,44608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192117Inst : IEnumerable<long>
{
public static readonly long[] Value=A192117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192117.Bytes);
public long this[int i]=>Value[i];

public static A192117Inst Instance=new A192117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192118
{
public static readonly long[] Value={ 0L,1L,3L,7L,9L,15L,25L,31L,57L,63L,79L,121L,127L,169L,207L,249L,255L,463L,505L,511L,681L,975L,1017L,1023L,1695L,1705L,1999L,2041L,2047L,3753L,4047L,4089L,4095L,5791L,7849L,8143L,8185L,8191L,13423L,13983L,15961L,16041L,16335L,16377L,16383L,30367L,32425L,32719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192118Inst : IEnumerable<long>
{
public static readonly long[] Value=A192118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192118.Bytes);
public long this[int i]=>Value[i];

public static A192118Inst Instance=new A192118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192119
{
public static readonly long[] Value={ 0L,3L,5L,6L,17L,33L,41L,45L,47L,48L,87L,215L,279L,311L,327L,335L,339L,341L,342L,353L,423L,1377L,1889L,2145L,2273L,2337L,2369L,2385L,2393L,2397L,2399L,2400L,8615L,12711L,14759L,15783L,16295L,16551L,16679L,16743L,16775L,16791L,16799L,16803L,16805L,16806L,52113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192119Inst : IEnumerable<long>
{
public static readonly long[] Value=A192119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192119.Bytes);
public long this[int i]=>Value[i];

public static A192119Inst Instance=new A192119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192120
{
public static readonly long[] Value={ 0L,1L,3L,7L,8L,15L,24L,31L,56L,63L,64L,120L,127L,192L,248L,255L,448L,504L,511L,512L,960L,1016L,1023L,1536L,1984L,2040L,2047L,3584L,4032L,4088L,4095L,4096L,7680L,8128L,8184L,8191L,12288L,15872L,16320L,16376L,16383L,28672L,32256L,32704L,32760L,32767L,32768L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192120Inst : IEnumerable<long>
{
public static readonly long[] Value=A192120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192120.Bytes);
public long this[int i]=>Value[i];

public static A192120Inst Instance=new A192120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192121
{
public static readonly long[] Value={ 0L,4L,6L,7L,32L,48L,56L,60L,62L,63L,256L,384L,448L,480L,496L,504L,508L,510L,511L,2048L,3072L,3584L,3840L,3968L,4032L,4064L,4080L,4088L,4092L,4094L,4095L,16384L,24576L,28672L,30720L,31744L,32256L,32512L,32640L,32704L,32736L,32752L,32760L,32764L,32766L,32767L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192121Inst : IEnumerable<long>
{
public static readonly long[] Value=A192121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192121.Bytes);
public long this[int i]=>Value[i];

public static A192121Inst Instance=new A192121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192122
{
public static readonly long[] Value={ 0L,1L,3L,7L,15L,23L,31L,47L,55L,63L,119L,127L,175L,247L,255L,295L,431L,503L,511L,943L,1015L,1023L,1319L,1631L,1967L,2039L,2047L,3367L,4015L,4087L,4095L,6487L,7463L,8111L,8183L,8191L,9823L,15655L,16303L,16375L,16383L,26207L,32039L,32687L,32759L,32767L,58975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192122Inst : IEnumerable<long>
{
public static readonly long[] Value=A192122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192122.Bytes);
public long this[int i]=>Value[i];

public static A192122Inst Instance=new A192122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192123
{
public static readonly long[] Value={ 0L,1L,5L,7L,8L,17L,49L,65L,73L,77L,79L,80L,217L,473L,601L,665L,697L,713L,721L,725L,727L,728L,2465L,4513L,5537L,6049L,6305L,6433L,6497L,6529L,6545L,6553L,6557L,6559L,6560L,7153L,26281L,42665L,50857L,54953L,57001L,58025L,58537L,58793L,58921L,58985L,59017L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192123Inst : IEnumerable<long>
{
public static readonly long[] Value=A192123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192123.Bytes);
public long this[int i]=>Value[i];

public static A192123Inst Instance=new A192123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192172
{
public static readonly long[] Value={ 0L,6L,9L,36L,84L,96L,99L,744L,936L,984L,996L,999L,5904L,8976L,9744L,9936L,9984L,9996L,9999L,34464L,83616L,95904L,98976L,99744L,99936L,99984L,99996L,99999L,737856L,934464L,983616L,995904L,998976L,999744L,999936L,999984L,999996L,999999L,5805696L,8951424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192172Inst : IEnumerable<long>
{
public static readonly long[] Value=A192172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192172.Bytes);
public long this[int i]=>Value[i];

public static A192172Inst Instance=new A192172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192173
{
public static readonly long[] Value={ 159L,179L,189L,239L,319L,389L,395L,397L,399L,489L,494L,498L,559L,598L,629L,639L,679L,691L,695L,696L,697L,698L,699L,709L,789L,791L,829L,839L,879L,894L,895L,897L,898L,917L,935L,953L,958L,962L,963L,964L,965L,966L,967L,968L,969L,978L,981L,983L,985L,986L,989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192173Inst : IEnumerable<long>
{
public static readonly long[] Value=A192173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192173.Bytes);
public long this[int i]=>Value[i];

public static A192173Inst Instance=new A192173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192174
{
public static readonly long[] Value={ -1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,0L,-1L,0L,-1L,1L,0L,-2L,0L,-1L,0L,1L,0L,-3L,0L,0L,0L,1L,1L,0L,-4L,0L,2L,0L,2L,0L,1L,0L,-5L,0L,5L,0L,2L,0L,-1L,1L,0L,-6L,0L,9L,0L,0L,0L,-3L,0L,1L,0L,-7L,0L,14L,0L,-5L,0L,-5L,0L,1L,1L,0L,-8L,0L,20L,0L,-14L,0L,-5L,0L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192174Inst : IEnumerable<long>
{
public static readonly long[] Value=A192174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192174.Bytes);
public long this[int i]=>Value[i];

public static A192174Inst Instance=new A192174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192175
{
public static readonly long[] Value={ 2L,3L,7L,5L,13L,23L,11L,19L,31L,89L,17L,37L,47L,359L,139L,29L,43L,53L,389L,181L,199L,41L,67L,61L,401L,241L,211L,113L,59L,79L,73L,449L,283L,467L,293L,1831L,71L,97L,83L,479L,337L,509L,317L,1933L,523L,101L,103L,131L,491L,409L,619L,773L,2113L,1069L,887L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192175Inst : IEnumerable<long>
{
public static readonly long[] Value=A192175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192175.Bytes);
public long this[int i]=>Value[i];

public static A192175Inst Instance=new A192175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192176
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,9L,5L,8L,11L,24L,7L,12L,15L,72L,34L,10L,14L,16L,77L,42L,46L,13L,19L,18L,79L,53L,47L,30L,17L,22L,21L,87L,61L,91L,62L,282L,20L,25L,23L,92L,68L,97L,66L,295L,99L,26L,27L,32L,94L,80L,114L,137L,319L,180L,154L,28L,29L,36L,124L,82L,121L,146L,331L,205L,259L,189L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192176Inst : IEnumerable<long>
{
public static readonly long[] Value=A192176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192176.Bytes);
public long this[int i]=>Value[i];

public static A192176Inst Instance=new A192176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192177
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,10L,4L,9L,16L,11L,6L,13L,22L,17L,28L,8L,15L,26L,23L,36L,29L,12L,19L,34L,27L,52L,37L,96L,14L,21L,40L,35L,58L,53L,120L,97L,18L,25L,46L,41L,66L,59L,146L,121L,122L,20L,31L,50L,47L,78L,67L,188L,147L,148L,123L,24L,33L,56L,51L,88L,79L,206L,189L,190L,149L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192177Inst : IEnumerable<long>
{
public static readonly long[] Value=A192177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192177.Bytes);
public long this[int i]=>Value[i];

public static A192177Inst Instance=new A192177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192178
{
public static readonly long[] Value={ 1L,2L,5L,3L,7L,26L,4L,9L,34L,23L,6L,11L,50L,37L,118L,8L,13L,56L,47L,122L,53L,10L,15L,64L,67L,144L,89L,120L,12L,17L,76L,79L,186L,119L,300L,409L,14L,19L,86L,83L,204L,121L,324L,479L,532L,16L,21L,92L,93L,206L,157L,530L,531L,896L,293L,18L,25L,94L,97L,216L,173L,534L,533L,898L,631L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192178Inst : IEnumerable<long>
{
public static readonly long[] Value=A192178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192178.Bytes);
public long this[int i]=>Value[i];

public static A192178Inst Instance=new A192178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192179
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,8L,6L,9L,14L,7L,10L,11L,20L,13L,24L,12L,15L,26L,19L,32L,23L,16L,17L,34L,25L,48L,31L,90L,18L,21L,38L,33L,54L,47L,120L,89L,22L,27L,44L,37L,62L,53L,142L,119L,118L,28L,29L,50L,43L,74L,61L,184L,141L,140L,117L,30L,35L,56L,49L,84L,73L,204L,183L,182L,139L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192179Inst : IEnumerable<long>
{
public static readonly long[] Value=A192179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192179.Bytes);
public long this[int i]=>Value[i];

public static A192179Inst Instance=new A192179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192180
{
public static readonly long[] Value={ 95L,132L,272L,312L,322L,326L,333L,731L,735L,912L,973L,995L,1111L,1212L,1255L,1292L,1972L,2112L,2132L,2232L,2272L,2512L,2672L,2737L,2994L,3171L,3192L,3210L,3212L,3243L,3315L,3393L,3792L,3933L,4172L,4341L,4371L,4383L,5150L,5192L,5271L,6973L,7132L,7210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192180Inst : IEnumerable<long>
{
public static readonly long[] Value=A192180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192180.Bytes);
public long this[int i]=>Value[i];

public static A192180Inst Instance=new A192180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192181
{
public static readonly long[] Value={ -2L,1L,1L,3L,1L,86L,63L,1006L,2L,1L,3L,3L,2L,3L,1L,1L,2L,4L,2L,7L,1L,1L,1L,1L,4L,2L,2L,1L,8L,1L,9L,1L,1L,50L,1L,3L,1L,16L,2L,1L,76L,1L,3L,3L,1L,3L,2L,1L,7L,2L,1L,46L,2L,1L,5L,4L,1L,1L,2L,1L,1L,11L,1L,1L,1L,2L,2L,2L,2L,13L,4L,1L,7L,2L,1L,1L,2L,1L,1L,4L,3L,1L,1L,3L,5L,7L,21L,5L,2L,1L,3L,1L,5L,1L,8L,9L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192181Inst : IEnumerable<long>
{
public static readonly long[] Value=A192181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192181.Bytes);
public long this[int i]=>Value[i];

public static A192181Inst Instance=new A192181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192182
{
public static readonly long[] Value={ 0L,2L,3L,53L,5L,1L,2L,1L,1L,1L,1L,91L,7L,1L,1L,5L,2L,1L,1L,1L,2L,1L,2L,5L,1L,2L,23L,1L,2L,6L,1L,30L,6L,1L,1L,1L,23L,2L,1L,14L,1L,1L,1L,1L,2L,1L,9L,3L,34L,2L,1L,176L,1L,114L,1L,27L,20L,2L,63L,36L,2L,6L,1L,7L,1L,1L,26L,8L,1L,1L,1L,1L,2L,1L,4L,15L,12L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192182Inst : IEnumerable<long>
{
public static readonly long[] Value=A192182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192182.Bytes);
public long this[int i]=>Value[i];

public static A192182Inst Instance=new A192182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192183
{
public static readonly long[] Value={ 1L,3L,2L,2L,4L,15L,4L,1L,7L,70L,1L,7L,2L,1L,8L,4L,3L,4L,1L,1L,1L,1L,3L,2L,2L,1L,9L,1L,1L,22L,1L,24L,899L,3L,1L,2L,1L,1L,5L,1L,22L,1L,1L,1L,1L,58L,1L,1L,13L,2L,1L,1L,1L,1L,5L,2L,1L,1L,34L,1L,1L,6L,11L,1L,3L,1L,1L,4L,2L,1L,230L,2L,16L,1L,1L,1L,1L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192183Inst : IEnumerable<long>
{
public static readonly long[] Value=A192183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192183.Bytes);
public long this[int i]=>Value[i];

public static A192183Inst Instance=new A192183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192184
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,3L,5L,6L,8L,11L,13L,16L,23L,26L,32L,41L,50L,60L,75L,88L,108L,130L,154L,183L,222L,260L,307L,363L,429L,500L,589L,685L,800L,934L,1083L,1250L,1458L,1678L,1933L,2231L,2565L,2940L,3381L,3859L,4418L,5050L,5753L,6547L,7464L,8470L,9617L,10904L,12352L,13968L,15801L,17827L,20115L,22675L,25531L,28702L,32288L,36242L,40664L,45597L,51079L,57157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192184Inst : IEnumerable<long>
{
public static readonly long[] Value=A192184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192184.Bytes);
public long this[int i]=>Value[i];

public static A192184Inst Instance=new A192184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192185
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,1L,1L,2L,1L,2L,3L,2L,4L,3L,5L,6L,5L,8L,7L,9L,13L,10L,16L,14L,18L,22L,21L,28L,29L,31L,42L,37L,50L,51L,57L,70L,69L,83L,91L,95L,120L,118L,139L,153L,161L,193L,200L,224L,254L,262L,312L,324L,360L,404L,427L,485L,525L,561L,640L,668L,758L,817L,878L,982L,1046L,1150L,1265L,1340L,1499L,1597L,1745L,1911L,2036L,2241L,2420L,2602L,2866L,3041L,3332L,3597L,3864L,4221L,4518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192185Inst : IEnumerable<long>
{
public static readonly long[] Value=A192185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192185.Bytes);
public long this[int i]=>Value[i];

public static A192185Inst Instance=new A192185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192186
{
public static readonly long[] Value={ 1L,2L,6L,15L,56L,120L,495L,2002L,4368L,18564L,38760L,170544L,735471L,1562275L,6906900L,14307150L,64512240L,131128140L,600805296L,2707475148L,5586853480L,25518731280L,51915526432L,239877544005L,1093260079344L,2250829575120L,10363194502115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192186Inst : IEnumerable<long>
{
public static readonly long[] Value=A192186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192186.Bytes);
public long this[int i]=>Value[i];

public static A192186Inst Instance=new A192186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192187
{
public static readonly long[] Value={ 7L,11L,19L,28L,33L,45L,69L,71L,118L,153L,199L,341L,360L,605L,894L,1079L,1881L,1962L,2294L,3591L,6060L,6636L,7772L,12371L,16229L,23151L,33292L,43580L,44126L,82268L,121021L,146014L,155922L,296348L,334771L,398221L,564689L,650688L,931905L,1078556L,2064590L,2454882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192187Inst : IEnumerable<long>
{
public static readonly long[] Value=A192187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192187.Bytes);
public long this[int i]=>Value[i];

public static A192187Inst Instance=new A192187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192220
{
public static readonly long[] Value={ 4L,6L,9L,34L,51L,55L,86L,94L,129L,142L,183L,185L,202L,214L,218L,247L,249L,302L,341L,394L,415L,446L,471L,473L,535L,583L,634L,698L,723L,737L,807L,851L,905L,922L,926L,949L,1042L,1138L,1149L,1205L,1211L,1241L,1257L,1262L,1313L,1315L,1337L,1346L,1402L,1527L,1546L,1577L,1594L,1642L,1646L,1673L,1687L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192220Inst : IEnumerable<long>
{
public static readonly long[] Value=A192220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192220.Bytes);
public long this[int i]=>Value[i];

public static A192220Inst Instance=new A192220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192221
{
public static readonly long[] Value={ 10L,16L,18L,22L,37L,54L,66L,93L,142L,150L,246L,294L,405L,457L,618L,630L,774L,803L,1013L,1026L,1110L,1146L,1254L,1272L,1297L,1458L,1590L,1686L,1822L,1830L,2032L,2166L,2454L,2625L,2646L,2662L,2694L,2934L,3030L,3218L,3323L,3510L,3990L,4266L,4342L,4374L,4614L,4806L,4854L,4950L,5182L,5286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192221Inst : IEnumerable<long>
{
public static readonly long[] Value=A192221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192221.Bytes);
public long this[int i]=>Value[i];

public static A192221Inst Instance=new A192221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192222
{
public static readonly BigInteger[] Value={ 1L,2L,5L,34L,1597L,3524578L,17167680177565L,BigInteger.Parse("407305795904080553832073954"),BigInteger.Parse("229265413057075367692743352179590077832064383222590237") };
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
public class A192222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192222Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192222.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192222Inst Instance=new A192222Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192223
{
public static readonly BigInteger[] Value={ 3L,4L,11L,76L,3571L,7881196L,38388099893011L,BigInteger.Parse("910763447271179530132922476"),BigInteger.Parse("512653048485188394162163283930413917147479973138989971") };
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
public class A192223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192223Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A192223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192223.Bytes);
public BigInteger this[int i]=>Value[i];

public static A192223Inst Instance=new A192223Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192224
{
public static readonly long[] Value={ 2L,4L,6L,12L,18L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192224Inst : IEnumerable<long>
{
public static readonly long[] Value=A192224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192224.Bytes);
public long this[int i]=>Value[i];

public static A192224Inst Instance=new A192224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192225
{
public static readonly long[] Value={ 0L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192225Inst : IEnumerable<long>
{
public static readonly long[] Value=A192225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192225.Bytes);
public long this[int i]=>Value[i];

public static A192225Inst Instance=new A192225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192226
{
public static readonly long[] Value={ 1L,28L,36L,96L,120L,121L,122L,123L,124L,125L,126L,146L,147L,148L,189L,190L,207L,208L,209L,210L,219L,220L,221L,222L,249L,250L,292L,302L,303L,304L,305L,306L,326L,327L,328L,329L,330L,346L,477L,478L,519L,520L,533L,534L,535L,536L,537L,538L,539L,540L,630L,672L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192226Inst : IEnumerable<long>
{
public static readonly long[] Value=A192226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192226.Bytes);
public long this[int i]=>Value[i];

public static A192226Inst Instance=new A192226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192227
{
public static readonly long[] Value={ 0L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,2L,1L,1L,1L,1L,0L,1L,1L,2L,2L,2L,1L,1L,0L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192227Inst : IEnumerable<long>
{
public static readonly long[] Value=A192227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192227.Bytes);
public long this[int i]=>Value[i];

public static A192227Inst Instance=new A192227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192228
{
public static readonly long[] Value={ 425783L,263145359L,744158711L,1805712959L,32484102023L,103206118583L,271979814143L,324434645039L,454854785303L,626321908703L,6944429711711L,21648847849679L,23586002145119L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192228Inst : IEnumerable<long>
{
public static readonly long[] Value=A192228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192228.Bytes);
public long this[int i]=>Value[i];

public static A192228Inst Instance=new A192228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192229
{
public static readonly long[] Value={ 1L,2L,3L,5L,10L,11L,17L,23L,31L,47L,59L,71L,107L,151L,167L,239L,367L,421L,569L,587L,653L,701L,733L,857L,1063L,1229L,1693L,2003L,2141L,2273L,2531L,2549L,3181L,3547L,3919L,4703L,5437L,5659L,6379L,7841L,8093L,8209L,9001L,13313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192229Inst : IEnumerable<long>
{
public static readonly long[] Value=A192229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192229.Bytes);
public long this[int i]=>Value[i];

public static A192229Inst Instance=new A192229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192230
{
public static readonly long[] Value={ 0L,1L,3L,5L,9L,19L,27L,32L,78L,106L,108L,156L,367L,509L,542L,1155L,1158L,1172L,1262L,1268L,1428L,1738L,2497L,2868L,3989L,6018L,6452L,8010L,8178L,10537L,10870L,11434L,13915L,15370L,20685L,20852L,22854L,29415L,32406L,35779L,40456L,43938L,48568L,84406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192230Inst : IEnumerable<long>
{
public static readonly long[] Value=A192230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192230.Bytes);
public long this[int i]=>Value[i];

public static A192230Inst Instance=new A192230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192231
{
public static readonly long[] Value={ 1L,123L,124L,125L,126L,306L,330L,538L,539L,540L,904L,905L,906L,1147L,1148L,1149L,1150L,1346L,1347L,1348L,1349L,1350L,1351L,1352L,1353L,1354L,1355L,1356L,1357L,1358L,1359L,1360L,1689L,1690L,1691L,1692L,1971L,1972L,2200L,2201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192231Inst : IEnumerable<long>
{
public static readonly long[] Value=A192231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192231.Bytes);
public long this[int i]=>Value[i];

public static A192231Inst Instance=new A192231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192232
{
public static readonly long[] Value={ 1L,0L,2L,1L,6L,7L,22L,36L,89L,168L,377L,756L,1630L,3353L,7110L,14783L,31130L,65016L,136513L,285648L,599041L,1254456L,2629418L,5508097L,11542854L,24183271L,50674318L,106173180L,222470009L,466131960L,976694489L,2046447180L,4287928678L,8984443769L,18825088134L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192232Inst : IEnumerable<long>
{
public static readonly long[] Value=A192232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192232.Bytes);
public long this[int i]=>Value[i];

public static A192232Inst Instance=new A192232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192233
{
public static readonly long[] Value={ -1L,1L,2L,2L,5L,2L,13L,3L,7L,3L,89L,2L,233L,5L,8L,14L,1597L,5L,4181L,10L,47L,23L,28657L,12L,4596L,57L,1619L,65L,514229L,16L,1346269L,611L,2102L,379L,12461L,85L,24157817L,989L,14357L,533L,165580141L,113L,433494437L,3026L,22201L,6767L,2971215073L,598L,171486453L,3836L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192233Inst : IEnumerable<long>
{
public static readonly long[] Value=A192233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192233.Bytes);
public long this[int i]=>Value[i];

public static A192233Inst Instance=new A192233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192234
{
public static readonly long[] Value={ 0L,1L,4L,9L,28L,81L,232L,673L,1944L,5617L,16236L,46921L,135604L,391905L,1132624L,3273345L,9460144L,27340321L,79014996L,228357577L,659965644L,1907336113L,5512303672L,15930853281L,46041020488L,133061018769L,384553481404L,1111380188041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192234Inst : IEnumerable<long>
{
public static readonly long[] Value=A192234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192234.Bytes);
public long this[int i]=>Value[i];

public static A192234Inst Instance=new A192234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192235
{
public static readonly long[] Value={ 0L,3L,8L,21L,64L,183L,528L,1529L,4416L,12763L,36888L,106605L,308096L,890415L,2573344L,7437105L,21493632L,62117747L,179523624L,518832901L,1499454912L,4333505127L,12524062256L,36195211689L,104606103232L,302317249227L,873713066040L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192235Inst : IEnumerable<long>
{
public static readonly long[] Value=A192235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192235.Bytes);
public long this[int i]=>Value[i];

public static A192235Inst Instance=new A192235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A192236
{
public static readonly long[] Value={ 2L,4L,12L,36L,102L,296L,856L,2472L,7146L,20652L,59684L,172492L,498510L,1440720L,4163760L,12033488L,34777426L,100508628L,290475324L,839489268L,2426169014L,7011758584L,20264358408L,58565082744L,169256230458L,489159584636L,1413697437268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A192236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A192236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A192236Inst : IEnumerable<long>
{
public static readonly long[] Value=A192236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A192236.Bytes);
public long this[int i]=>Value[i];

public static A192236Inst Instance=new A192236Inst();

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