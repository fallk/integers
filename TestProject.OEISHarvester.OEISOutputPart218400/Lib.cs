using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A256782
{
public static readonly long[] Value={ 0L,8L,4L,3L,1L,9L,6L,8L,8L,4L,3L,3L,1L,6L,2L,9L,5L,5L,9L,3L,9L,0L,4L,0L,3L,5L,6L,8L,0L,3L,7L,5L,4L,8L,0L,0L,1L,2L,8L,1L,2L,4L,3L,7L,3L,8L,2L,5L,9L,1L,7L,0L,6L,8L,5L,2L,3L,0L,3L,0L,3L,9L,9L,9L,3L,8L,7L,7L,8L,8L,1L,6L,6L,3L,2L,4L,9L,5L,4L,3L,5L,1L,9L,7L,6L,3L,9L,7L,8L,7L,3L,1L,6L,0L,2L,9L,5L,3L,3L,2L,0L,1L,0L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256782Inst : IEnumerable<long>
{
public static readonly long[] Value=A256782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256782.Bytes);
public long this[int i]=>Value[i];

public static A256782Inst Instance=new A256782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256783
{
public static readonly long[] Value={ 8L,3L,0L,2L,4L,9L,8L,8L,9L,8L,8L,6L,6L,2L,4L,3L,3L,9L,3L,8L,9L,0L,3L,4L,1L,9L,7L,0L,3L,2L,1L,4L,9L,6L,5L,0L,5L,5L,5L,7L,9L,6L,3L,9L,2L,7L,9L,7L,2L,7L,4L,9L,6L,2L,0L,1L,5L,4L,3L,9L,8L,6L,8L,1L,1L,3L,9L,3L,1L,2L,5L,3L,4L,4L,1L,4L,2L,7L,9L,9L,6L,1L,0L,1L,6L,0L,1L,3L,0L,5L,8L,1L,2L,5L,5L,8L,4L,0L,3L,5L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256783Inst : IEnumerable<long>
{
public static readonly long[] Value=A256783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256783.Bytes);
public long this[int i]=>Value[i];

public static A256783Inst Instance=new A256783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256784
{
public static readonly long[] Value={ 0L,0L,3L,3L,7L,2L,9L,4L,9L,3L,2L,2L,4L,0L,3L,2L,9L,7L,0L,2L,5L,0L,3L,2L,4L,9L,4L,8L,1L,8L,5L,9L,2L,1L,9L,4L,6L,1L,6L,0L,3L,4L,0L,3L,4L,6L,9L,9L,4L,9L,8L,3L,9L,5L,3L,8L,7L,3L,1L,6L,7L,0L,0L,8L,6L,3L,1L,2L,7L,1L,0L,3L,1L,6L,7L,6L,1L,5L,8L,5L,1L,3L,3L,3L,6L,5L,9L,1L,2L,3L,6L,3L,9L,7L,0L,0L,3L,1L,1L,9L,9L,9L,7L,7L,8L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256784Inst : IEnumerable<long>
{
public static readonly long[] Value=A256784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256784.Bytes);
public long this[int i]=>Value[i];

public static A256784Inst Instance=new A256784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256785
{
public static readonly long[] Value={ 1L,5L,11L,14L,20L,21L,22L,23L,26L,29L,30L,31L,33L,34L,38L,39L,40L,41L,45L,46L,51L,52L,53L,56L,57L,58L,60L,61L,65L,69L,70L,71L,74L,78L,79L,83L,84L,85L,87L,88L,89L,90L,91L,95L,101L,105L,106L,110L,111L,112L,113L,116L,117L,118L,122L,126L,127L,132L,133L,135L,136L,140L,146L,149L,155L,159L,160L,161L,164L,165L,166L,168L,169L,173L,174L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256785Inst : IEnumerable<long>
{
public static readonly long[] Value=A256785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256785.Bytes);
public long this[int i]=>Value[i];

public static A256785Inst Instance=new A256785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256786
{
public static readonly long[] Value={ 12L,14L,42L,55L,154L,222L,228L,714L,1122L,1196L,1212L,1414L,2112L,2142L,2262L,3355L,4144L,4242L,5335L,5544L,5555L,6162L,9499L,11112L,11144L,11214L,11424L,11466L,11622L,11818L,11914L,12222L,12882L,14112L,15554L,16666L,21216L,21222L,21252L,21888L,22122L,22212L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256786Inst : IEnumerable<long>
{
public static readonly long[] Value=A256786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256786.Bytes);
public long this[int i]=>Value[i];

public static A256786Inst Instance=new A256786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256787
{
public static readonly long[] Value={ 1L,5L,3L,5L,15L,9L,5L,5L,9L,11L,11L,45L,5L,15L,23L,35L,9L,59L,15L,5L,3L,9L,35L,27L,23L,17L,51L,5L,29L,27L,53L,9L,9L,9L,23L,39L,23L,5L,29L,249L,9L,51L,5L,75L,51L,117L,29L,77L,131L,219L,221L,29L,53L,105L,321L,95L,179L,197L,101L,51L,81L,101L,11L,5L,21L,221L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256787Inst : IEnumerable<long>
{
public static readonly long[] Value=A256787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256787.Bytes);
public long this[int i]=>Value[i];

public static A256787Inst Instance=new A256787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256788
{
public static readonly long[] Value={ 1L,2L,4L,16L,23L,25L,27L,29L,34L,68L,89L,127L,200L,418L,868L,1173L,2553L,4131L,5675L,8318L,8445L,10820L,15793L,16671L,32275L,43995L,48026L,50035L,88459L,126839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256788Inst : IEnumerable<long>
{
public static readonly long[] Value=A256788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256788.Bytes);
public long this[int i]=>Value[i];

public static A256788Inst Instance=new A256788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256789
{
public static readonly long[] Value={ 0L,1L,4L,-2L,4L,-1L,4L,9L,-4L,9L,-4L,1L,9L,-4L,2L,9L,-1L,9L,16L,-9L,4L,-1L,16L,-9L,4L,16L,-4L,16L,-4L,1L,16L,-4L,2L,16L,-1L,16L,25L,-9L,1L,25L,-9L,4L,-2L,25L,-9L,4L,-1L,25L,-9L,4L,25L,-4L,25L,-4L,1L,25L,-4L,2L,25L,-1L,25L,36L,-16L,9L,-4L,1L,36L,-9L,36L,-9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256789Inst : IEnumerable<long>
{
public static readonly long[] Value=A256789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256789.Bytes);
public long this[int i]=>Value[i];

public static A256789Inst Instance=new A256789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256790
{
public static readonly long[] Value={ 1L,1L,2L,2L,1L,2L,3L,3L,2L,1L,4L,3L,2L,3L,3L,2L,1L,3L,4L,4L,3L,2L,3L,3L,2L,1L,5L,2L,3L,4L,4L,3L,2L,3L,3L,2L,1L,3L,4L,5L,2L,3L,4L,4L,3L,2L,3L,3L,2L,1L,4L,4L,3L,4L,5L,2L,3L,4L,4L,3L,2L,3L,3L,2L,1L,2L,3L,4L,4L,3L,4L,5L,2L,3L,4L,4L,3L,2L,3L,3L,2L,1L,5L,4L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256790Inst : IEnumerable<long>
{
public static readonly long[] Value=A256790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256790.Bytes);
public long this[int i]=>Value[i];

public static A256790Inst Instance=new A256790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256791
{
public static readonly long[] Value={ 0L,1L,-2L,-1L,4L,-4L,1L,2L,-1L,9L,-1L,4L,-4L,1L,2L,-1L,16L,1L,-2L,-1L,4L,-4L,1L,2L,-1L,25L,1L,-9L,1L,-2L,-1L,4L,-4L,1L,2L,-1L,36L,4L,-4L,1L,-9L,1L,-2L,-1L,4L,-4L,1L,2L,-1L,49L,-2L,-1L,4L,-4L,1L,-9L,1L,-2L,-1L,4L,-4L,1L,2L,-1L,64L,-16L,1L,-2L,-1L,4L,-4L,1L,-9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256791Inst : IEnumerable<long>
{
public static readonly long[] Value=A256791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256791.Bytes);
public long this[int i]=>Value[i];

public static A256791Inst Instance=new A256791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256792
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,11L,13L,14L,16L,17L,20L,22L,23L,25L,26L,28L,31L,33L,34L,36L,37L,39L,41L,44L,46L,47L,49L,52L,54L,56L,59L,61L,62L,64L,66L,69L,71L,73L,76L,78L,79L,81L,82L,85L,88L,90L,92L,95L,97L,98L,100L,102L,103L,106L,109L,111L,113L,116L,118L,119L,121L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256792Inst : IEnumerable<long>
{
public static readonly long[] Value=A256792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256792.Bytes);
public long this[int i]=>Value[i];

public static A256792Inst Instance=new A256792Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256793
{
public static readonly long[] Value={ 2L,3L,5L,8L,10L,12L,15L,18L,19L,21L,24L,27L,29L,30L,32L,35L,38L,40L,42L,43L,45L,48L,50L,51L,53L,55L,57L,58L,60L,63L,65L,67L,68L,70L,72L,74L,75L,77L,80L,83L,84L,86L,87L,89L,91L,93L,94L,96L,99L,101L,104L,105L,107L,108L,110L,112L,114L,115L,117L,120L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256793Inst : IEnumerable<long>
{
public static readonly long[] Value=A256793.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256793.Bytes);
public long this[int i]=>Value[i];

public static A256793Inst Instance=new A256793Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256794
{
public static readonly long[] Value={ 3L,2L,1L,2L,2L,2L,1L,2L,1L,3L,2L,1L,2L,1L,2L,3L,2L,1L,2L,1L,2L,2L,3L,2L,1L,2L,3L,2L,2L,3L,2L,1L,2L,2L,3L,2L,2L,3L,2L,1L,2L,1L,3L,3L,2L,2L,3L,2L,1L,2L,2L,1L,3L,3L,2L,2L,3L,2L,1L,2L,2L,2L,1L,3L,3L,2L,2L,3L,2L,1L,2L,1L,3L,2L,1L,3L,3L,2L,2L,3L,2L,1L,2L,3L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256794Inst : IEnumerable<long>
{
public static readonly long[] Value=A256794.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256794.Bytes);
public long this[int i]=>Value[i];

public static A256794Inst Instance=new A256794Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256795
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,3L,3L,1L,2L,3L,3L,2L,1L,2L,3L,3L,2L,2L,1L,2L,3L,2L,1L,2L,2L,2L,1L,2L,3L,2L,2L,1L,2L,2L,2L,1L,2L,3L,3L,1L,2L,1L,2L,2L,2L,1L,2L,3L,2L,3L,1L,2L,1L,2L,2L,2L,1L,2L,3L,2L,2L,3L,1L,2L,1L,2L,2L,2L,1L,2L,3L,3L,1L,2L,3L,1L,2L,1L,2L,2L,2L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256795Inst : IEnumerable<long>
{
public static readonly long[] Value=A256795.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256795.Bytes);
public long this[int i]=>Value[i];

public static A256795Inst Instance=new A256795Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256796
{
public static readonly long[] Value={ 1L,4L,4L,4L,9L,10L,11L,9L,9L,20L,20L,16L,17L,18L,16L,16L,26L,29L,29L,29L,25L,26L,27L,25L,25L,46L,36L,37L,40L,40L,40L,36L,37L,38L,36L,36L,53L,58L,59L,49L,50L,53L,53L,53L,49L,50L,51L,49L,49L,68L,68L,68L,73L,74L,64L,65L,68L,68L,68L,64L,65L,66L,64L,64L,81L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256796Inst : IEnumerable<long>
{
public static readonly long[] Value=A256796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256796.Bytes);
public long this[int i]=>Value[i];

public static A256796Inst Instance=new A256796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256797
{
public static readonly long[] Value={ 0L,2L,1L,0L,4L,4L,4L,1L,0L,10L,9L,4L,4L,4L,1L,0L,9L,11L,10L,9L,4L,4L,4L,1L,0L,20L,9L,9L,11L,10L,9L,4L,4L,4L,1L,0L,16L,20L,20L,9L,9L,11L,10L,9L,4L,4L,4L,1L,0L,18L,17L,16L,20L,20L,9L,9L,11L,10L,9L,4L,4L,4L,1L,0L,16L,16L,18L,17L,16L,20L,20L,9L,9L,11L,10L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256797Inst : IEnumerable<long>
{
public static readonly long[] Value=A256797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256797.Bytes);
public long this[int i]=>Value[i];

public static A256797Inst Instance=new A256797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256798
{
public static readonly long[] Value={ 2L,7L,14L,18L,23L,29L,34L,42L,47L,50L,57L,62L,67L,74L,79L,82L,86L,93L,98L,103L,107L,114L,119L,126L,130L,137L,142L,146L,151L,155L,162L,167L,173L,178L,182L,189L,194L,202L,207L,211L,218L,223L,227L,233L,238L,242L,249L,254L,260L,266L,271L,275L,282L,287L,290L,295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256798Inst : IEnumerable<long>
{
public static readonly long[] Value=A256798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256798.Bytes);
public long this[int i]=>Value[i];

public static A256798Inst Instance=new A256798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256799
{
public static readonly BigInteger[] Value={ 1L,1L,6L,203L,40222L,46410442L,312163223724L,12237378320283699L,BigInteger.Parse("2796071362211148193590"),BigInteger.Parse("3723566980632561787914135870"),BigInteger.Parse("28901575272390972687956930234335380"),BigInteger.Parse("1307480498356321410289575304307661963042110"),BigInteger.Parse("344746842780849469098742541704318199701366091840620") };
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
public class A256799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256799Inst Instance=new A256799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256800
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,13L,22L,28L,32L,126L,172L,186L,267L,650L,693L,1083L,3783L,12294L,18134L,53859L,66650L,72097L,98890L,125706L,200001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256800Inst : IEnumerable<long>
{
public static readonly long[] Value=A256800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256800.Bytes);
public long this[int i]=>Value[i];

public static A256800Inst Instance=new A256800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256801
{
public static readonly long[] Value={ 2L,4L,11L,23L,86L,148L,191L,232L,271L,656L,844L,1069L,1318L,1348L,1411L,2329L,4120L,4831L,12691L,14695L,17719L,39614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256801Inst : IEnumerable<long>
{
public static readonly long[] Value=A256801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256801.Bytes);
public long this[int i]=>Value[i];

public static A256801Inst Instance=new A256801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256802
{
public static readonly BigInteger[] Value={ 32L,312L,5891L,187203L,10791281L,1138136868L,215464267564L,73460897153458L,45244446929195903L,BigInteger.Parse("50270946310754652511"),BigInteger.Parse("100729046029931700116928"),BigInteger.Parse("364111018909574379029951571"),BigInteger.Parse("2374431276261700527941601475769") };
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
public class A256802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256802Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256802.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256802.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256802Inst Instance=new A256802Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256803
{
public static readonly long[] Value={ 32L,86L,237L,641L,1731L,4690L,12707L,34408L,93168L,252313L,683305L,1850413L,5011000L,13570213L,36749148L,99519030L,269504389L,729837077L,1976449263L,5352360678L,14494564867L,39252288748L,106297917568L,287862131449L,779550625853L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256803Inst : IEnumerable<long>
{
public static readonly long[] Value=A256803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256803.Bytes);
public long this[int i]=>Value[i];

public static A256803Inst Instance=new A256803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256804
{
public static readonly long[] Value={ 86L,312L,1167L,4219L,15291L,55798L,203129L,738760L,2689072L,9788263L,35621557L,129642381L,471844124L,1717266695L,6249942014L,22746670844L,82786372499L,301300009747L,1096578905535L,3990990415282L,14525173993491L,52864244476540L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256804Inst : IEnumerable<long>
{
public static readonly long[] Value=A256804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256804.Bytes);
public long this[int i]=>Value[i];

public static A256804Inst Instance=new A256804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256805
{
public static readonly long[] Value={ 237L,1167L,5891L,28655L,140031L,688353L,3375943L,16546465L,81148017L,397969727L,1951494975L,9569654587L,46928263987L,230127443349L,1128498797539L,5533946633513L,27137441115377L,133076860538449L,652583716491933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256805Inst : IEnumerable<long>
{
public static readonly long[] Value=A256805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256805.Bytes);
public long this[int i]=>Value[i];

public static A256805Inst Instance=new A256805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256806
{
public static readonly long[] Value={ 641L,4219L,28655L,187203L,1226781L,8090191L,53254665L,350253925L,2304752967L,15167443677L,99803396861L,656712280793L,4321347940353L,28435562985711L,187111644664607L,1231234858650427L,8101804934566085L,53311657284829409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256806Inst : IEnumerable<long>
{
public static readonly long[] Value=A256806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256806.Bytes);
public long this[int i]=>Value[i];

public static A256806Inst Instance=new A256806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256807
{
public static readonly long[] Value={ 1731L,15291L,140031L,1226781L,10791281L,95609517L,845074953L,7462718887L,65946786795L,582793811989L,5149483657453L,45501162090307L,402065378129851L,3552750855171131L,31392826101389087L,277394754458635673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256807Inst : IEnumerable<long>
{
public static readonly long[] Value=A256807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256807.Bytes);
public long this[int i]=>Value[i];

public static A256807Inst Instance=new A256807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256808
{
public static readonly long[] Value={ 4690L,55798L,688353L,8090191L,95609517L,1138136868L,13512239171L,160298389688L,1902928304204L,22590412601705L,268141162733191L,3182827104119933L,37781089864549012L,448467854628363649L,5323365293380936886L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256808Inst : IEnumerable<long>
{
public static readonly long[] Value=A256808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256808.Bytes);
public long this[int i]=>Value[i];

public static A256808Inst Instance=new A256808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256809
{
public static readonly BigInteger[] Value={ 12707L,203129L,3375943L,53254665L,845074953L,13512239171L,215464267564L,3432996430917L,54734222100688L,872697161884847L,13912483854824538L,221795217415897043L,3536009069533019771L,BigInteger.Parse("56372932016438815229") };
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
public class A256809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256809Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256809.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256809.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256809Inst Instance=new A256809Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256810
{
public static readonly long[] Value={ 32L,86L,86L,237L,312L,237L,641L,1167L,1167L,641L,1731L,4219L,5891L,4219L,1731L,4690L,15291L,28655L,28655L,15291L,4690L,12707L,55798L,140031L,187203L,140031L,55798L,12707L,34408L,203129L,688353L,1226781L,1226781L,688353L,203129L,34408L,93168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256810Inst : IEnumerable<long>
{
public static readonly long[] Value=A256810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256810.Bytes);
public long this[int i]=>Value[i];

public static A256810Inst Instance=new A256810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256811
{
public static readonly long[] Value={ 37L,521L,881L,1619L,2053L,2213L,2341L,3527L,3637L,3727L,4157L,5147L,7019L,10009L,10891L,12277L,14741L,15913L,16273L,17747L,18757L,24499L,25307L,25577L,26209L,27073L,31481L,31517L,32833L,35083L,36739L,36791L,39079L,40231L,40949L,41039L,42013L,42461L,42767L,47917L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256811Inst : IEnumerable<long>
{
public static readonly long[] Value=A256811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256811.Bytes);
public long this[int i]=>Value[i];

public static A256811Inst Instance=new A256811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256812
{
public static readonly long[] Value={ 0L,2L,0L,2L,0L,0L,0L,0L,5L,0L,0L,6L,20L,0L,0L,5L,20L,0L,20L,0L,5L,13L,5L,5L,0L,0L,0L,0L,5L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,6L,20L,0L,41L,2L,0L,5L,13L,0L,0L,0L,0L,6L,0L,0L,0L,5L,0L,0L,0L,0L,0L,0L,0L,0L,5L,0L,20L,0L,20L,41L,0L,0L,0L,5L,0L,0L,0L,41L,0L,13L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256812Inst : IEnumerable<long>
{
public static readonly long[] Value=A256812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256812.Bytes);
public long this[int i]=>Value[i];

public static A256812Inst Instance=new A256812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256813
{
public static readonly long[] Value={ 63L,124L,245L,484L,956L,1888L,3728L,7362L,14539L,28712L,56701L,111974L,221128L,436688L,862380L,1703044L,3363203L,6641716L,13116185L,25902088L,51151928L,101015784L,199487860L,393952358L,777984487L,1536378320L,3034068649L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256813Inst : IEnumerable<long>
{
public static readonly long[] Value=A256813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256813.Bytes);
public long this[int i]=>Value[i];

public static A256813Inst Instance=new A256813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256814
{
public static readonly long[] Value={ 120L,229L,442L,856L,1656L,3204L,6192L,11955L,23088L,44617L,86226L,166620L,321960L,622104L,1202016L,2322567L,4487848L,8671757L,16756074L,32377024L,62560664L,120883084L,233577104L,451331323L,872088416L,1685098737L,3256043394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256814Inst : IEnumerable<long>
{
public static readonly long[] Value=A256814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256814.Bytes);
public long this[int i]=>Value[i];

public static A256814Inst Instance=new A256814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256815
{
public static readonly long[] Value={ 219L,402L,753L,1424L,2693L,5088L,9613L,18104L,34013L,63928L,120362L,226816L,427341L,804974L,1516179L,2855304L,5376354L,10123582L,19065294L,35907400L,67626166L,127359488L,239852341L,451704432L,850669960L,1602023036L,3017039568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256815Inst : IEnumerable<long>
{
public static readonly long[] Value=A256815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256815.Bytes);
public long this[int i]=>Value[i];

public static A256815Inst Instance=new A256815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256816
{
public static readonly long[] Value={ 4L,8L,8L,16L,16L,16L,32L,32L,32L,32L,63L,64L,64L,64L,64L,120L,124L,128L,128L,128L,128L,219L,229L,245L,256L,256L,256L,256L,382L,402L,442L,484L,512L,512L,512L,512L,638L,673L,753L,856L,956L,1024L,1024L,1024L,1024L,1024L,1080L,1220L,1424L,1656L,1888L,2048L,2048L,2048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256816Inst : IEnumerable<long>
{
public static readonly long[] Value=A256816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256816.Bytes);
public long this[int i]=>Value[i];

public static A256816Inst Instance=new A256816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256817
{
public static readonly long[] Value={ 8L,16L,32L,64L,124L,229L,402L,673L,1080L,1670L,2500L,3638L,5164L,7171L,9766L,13071L,17224L,22380L,28712L,36412L,45692L,56785L,69946L,85453L,103608L,124738L,149196L,177362L,209644L,246479L,288334L,335707L,389128L,449160L,516400L,591480L,675068L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256817Inst : IEnumerable<long>
{
public static readonly long[] Value=A256817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256817.Bytes);
public long this[int i]=>Value[i];

public static A256817Inst Instance=new A256817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256818
{
public static readonly long[] Value={ 16L,32L,64L,128L,245L,442L,753L,1220L,1894L,2836L,4118L,5824L,8051L,10910L,14527L,19044L,24620L,31432L,39676L,49568L,61345L,75266L,91613L,110692L,132834L,158396L,187762L,221344L,259583L,302950L,351947L,407108L,469000L,538224L,615416L,701248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256818Inst : IEnumerable<long>
{
public static readonly long[] Value=A256818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256818.Bytes);
public long this[int i]=>Value[i];

public static A256818Inst Instance=new A256818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256819
{
public static readonly long[] Value={ 32L,64L,128L,256L,484L,856L,1424L,2249L,3402L,4965L,7032L,9710L,13120L,17398L,22696L,29183L,37046L,46491L,57744L,71052L,86684L,104932L,126112L,150565L,178658L,210785L,247368L,288858L,335736L,388514L,447736L,513979L,587854L,670007L,761120L,861912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256819Inst : IEnumerable<long>
{
public static readonly long[] Value=A256819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256819.Bytes);
public long this[int i]=>Value[i];

public static A256819Inst Instance=new A256819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256820
{
public static readonly long[] Value={ 64L,128L,256L,512L,956L,1656L,2693L,4158L,6153L,8792L,12202L,16524L,21914L,28544L,36603L,46298L,57855L,71520L,87560L,106264L,127944L,152936L,181601L,214326L,251525L,293640L,341142L,394532L,454342L,521136L,595511L,678098L,769563L,870608L,981972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256820Inst : IEnumerable<long>
{
public static readonly long[] Value=A256820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256820.Bytes);
public long this[int i]=>Value[i];

public static A256820Inst Instance=new A256820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256821
{
public static readonly long[] Value={ 128L,256L,512L,1024L,1888L,3204L,5088L,7677L,11120L,15579L,21230L,28264L,36888L,47326L,59820L,74631L,92040L,112349L,135882L,162986L,194032L,229416L,269560L,314913L,365952L,423183L,487142L,558396L,637544L,725218L,822084L,928843L,1046232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256821Inst : IEnumerable<long>
{
public static readonly long[] Value=A256821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256821.Bytes);
public long this[int i]=>Value[i];

public static A256821Inst Instance=new A256821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256822
{
public static readonly long[] Value={ 256L,512L,1024L,2048L,3728L,6192L,9613L,14168L,20075L,27566L,36888L,48304L,62094L,78556L,98007L,120784L,147245L,177770L,212762L,252648L,297880L,348936L,406321L,470568L,542239L,621926L,710252L,807872L,915474L,1033780L,1163547L,1305568L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256822Inst : IEnumerable<long>
{
public static readonly long[] Value=A256822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256822.Bytes);
public long this[int i]=>Value[i];

public static A256822Inst Instance=new A256822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256823
{
public static readonly long[] Value={ 4L,7L,9L,11L,27L,40L,63L,80L,120L,173L,227L,358L,445L,525L,767L,1164L,2180L,5368L,7898L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256823Inst : IEnumerable<long>
{
public static readonly long[] Value=A256823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256823.Bytes);
public long this[int i]=>Value[i];

public static A256823Inst Instance=new A256823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256824
{
public static readonly long[] Value={ 1L,21L,31L,421L,51L,6321L,71L,8421L,931L,5210L,1L,64321L,31L,7421L,531L,86421L,71L,986321L,91L,54210L,7321L,21L,321L,864321L,521L,6321L,97321L,87421L,921L,653210L,31L,864321L,31L,74321L,7531L,9864321L,731L,98321L,931L,854210L,41L,764321L,431L,421L,95431L,64321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256824Inst : IEnumerable<long>
{
public static readonly long[] Value=A256824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256824.Bytes);
public long this[int i]=>Value[i];

public static A256824Inst Instance=new A256824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256825
{
public static readonly long[] Value={ 1L,10L,21L,31L,41L,51L,61L,71L,81L,91L,210L,310L,321L,410L,421L,431L,510L,521L,531L,541L,610L,621L,631L,641L,651L,710L,721L,731L,741L,751L,761L,810L,821L,831L,841L,851L,861L,871L,910L,921L,931L,941L,951L,961L,971L,981L,3210L,4210L,4310L,4321L,5210L,5310L,5321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256825Inst : IEnumerable<long>
{
public static readonly long[] Value=A256825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256825.Bytes);
public long this[int i]=>Value[i];

public static A256825Inst Instance=new A256825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256826
{
public static readonly long[] Value={ 1L,101L,2L,3L,41L,5L,61L,7L,181L,19L,202L,103L,23L,401L,4L,43L,505L,25L,15L,451L,601L,122L,163L,461L,1661L,107L,127L,37L,47L,157L,67L,1801L,281L,83L,1481L,5581L,1861L,187L,109L,29L,9L,149L,59L,619L,79L,89L,2003L,404L,403L,123L,10L,503L,115L,4051L,12451L,453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256826Inst : IEnumerable<long>
{
public static readonly long[] Value=A256826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256826.Bytes);
public long this[int i]=>Value[i];

public static A256826Inst Instance=new A256826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256827
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,9L,11L,12L,13L,14L,15L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,40L,41L,42L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,65L,66L,67L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256827Inst : IEnumerable<long>
{
public static readonly long[] Value=A256827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256827.Bytes);
public long this[int i]=>Value[i];

public static A256827Inst Instance=new A256827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256828
{
public static readonly long[] Value={ 2L,6L,18L,48L,204L,10386L,19524L,28320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256828Inst : IEnumerable<long>
{
public static readonly long[] Value=A256828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256828.Bytes);
public long this[int i]=>Value[i];

public static A256828Inst Instance=new A256828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256829
{
public static readonly long[] Value={ 2L,5L,8L,13L,17L,50L,169L,193L,407L,1496L,1718L,3610L,6527L,6889L,12665L,15949L,23498L,32969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256829Inst : IEnumerable<long>
{
public static readonly long[] Value=A256829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256829.Bytes);
public long this[int i]=>Value[i];

public static A256829Inst Instance=new A256829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256830
{
public static readonly long[] Value={ 3L,4L,24L,106L,124L,162L,243L,258L,1344L,1386L,2494L,4200L,5859L,8844L,13122L,19908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256830Inst : IEnumerable<long>
{
public static readonly long[] Value=A256830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256830.Bytes);
public long this[int i]=>Value[i];

public static A256830Inst Instance=new A256830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256831
{
public static readonly long[] Value={ 1L,1L,4L,1L,9L,8L,2L,5L,6L,9L,6L,6L,7L,7L,9L,1L,2L,0L,6L,0L,2L,8L,0L,4L,3L,3L,3L,8L,3L,6L,7L,8L,6L,0L,1L,5L,0L,8L,6L,4L,7L,3L,0L,4L,8L,2L,4L,0L,8L,5L,4L,0L,7L,9L,1L,5L,5L,6L,2L,5L,4L,3L,5L,2L,4L,4L,9L,8L,4L,3L,7L,8L,5L,4L,8L,0L,6L,2L,0L,8L,6L,0L,7L,8L,2L,5L,0L,6L,3L,7L,0L,6L,0L,9L,2L,5L,3L,3L,4L,7L,8L,1L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256831Inst : IEnumerable<long>
{
public static readonly long[] Value=A256831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256831.Bytes);
public long this[int i]=>Value[i];

public static A256831Inst Instance=new A256831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256832
{
public static readonly BigInteger[] Value={ 1L,2L,10L,120L,3480L,243600L,41168400L,16796707200L,16544756592000L,39343431175776000L,BigInteger.Parse("225870638380130016000"),BigInteger.Parse("3130567047948602021760000"),BigInteger.Parse("104751903991408172250111360000"),BigInteger.Parse("8462068308233934970708495883520000"),BigInteger.Parse("1650314871813323167662424409683488000000") };
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
public class A256832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256832Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256832.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256832.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256832Inst Instance=new A256832Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256833
{
public static readonly long[] Value={ 6L,42L,110L,210L,342L,506L,702L,930L,1190L,1482L,1806L,2162L,2550L,2970L,3422L,3906L,4422L,4970L,5550L,6162L,6806L,7482L,8190L,8930L,9702L,10506L,11342L,12210L,13110L,14042L,15006L,16002L,17030L,18090L,19182L,20306L,21462L,22650L,23870L,25122L,26406L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256833Inst : IEnumerable<long>
{
public static readonly long[] Value=A256833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256833.Bytes);
public long this[int i]=>Value[i];

public static A256833Inst Instance=new A256833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256834
{
public static readonly long[] Value={ 1297L,1321L,1657L,2137L,2521L,3697L,5521L,6337L,7537L,8521L,10321L,11497L,13177L,15937L,16921L,18457L,23497L,24097L,25321L,34057L,35521L,40897L,43321L,45817L,47521L,58417L,59377L,88321L,90697L,94321L,98017L,106921L,109537L,117577L,127321L,131617L,138937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256834Inst : IEnumerable<long>
{
public static readonly long[] Value=A256834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256834.Bytes);
public long this[int i]=>Value[i];

public static A256834Inst Instance=new A256834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256835
{
public static readonly long[] Value={ 2417L,2437L,2657L,2801L,3301L,3557L,3697L,4001L,4337L,4517L,7877L,10501L,11617L,12401L,13217L,19301L,20357L,20897L,26737L,28001L,29297L,33377L,36997L,38501L,40037L,44017L,48197L,49057L,64901L,70001L,77477L,78577L,86501L,90017L,92401L,104801L,107377L,108677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256835Inst : IEnumerable<long>
{
public static readonly long[] Value=A256835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256835.Bytes);
public long this[int i]=>Value[i];

public static A256835Inst Instance=new A256835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256836
{
public static readonly long[] Value={ 4177L,4217L,4457L,4721L,4937L,6121L,7121L,7577L,7817L,9137L,9721L,10337L,10657L,11321L,12377L,13121L,15121L,16417L,17321L,18257L,23417L,23977L,25121L,26297L,31321L,34721L,36137L,36857L,38321L,40577L,44497L,47777L,50321L,52057L,52937L,54721L,57457L,81937L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256836Inst : IEnumerable<long>
{
public static readonly long[] Value=A256836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256836.Bytes);
public long this[int i]=>Value[i];

public static A256836Inst Instance=new A256836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256837
{
public static readonly long[] Value={ 6577L,6661L,6961L,7237L,7717L,8161L,8677L,9697L,10657L,12037L,16561L,17377L,18661L,21937L,24517L,25057L,26161L,33457L,35461L,37537L,56737L,57637L,69061L,74161L,77317L,81637L,84961L,106417L,108961L,124897L,129061L,143461L,146437L,147937L,150961L,155557L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256837Inst : IEnumerable<long>
{
public static readonly long[] Value=A256837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256837.Bytes);
public long this[int i]=>Value[i];

public static A256837Inst Instance=new A256837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256838
{
public static readonly long[] Value={ 10009L,10169L,10289L,10529L,10729L,11369L,11681L,12401L,12601L,12809L,13249L,13721L,14489L,15329L,16561L,16889L,17569L,17921L,19801L,20201L,21881L,22769L,23689L,26641L,27689L,29881L,30449L,32801L,33409L,34649L,35281L,37889L,38561L,39241L,39929L,48809L,53681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256838Inst : IEnumerable<long>
{
public static readonly long[] Value=A256838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256838.Bytes);
public long this[int i]=>Value[i];

public static A256838Inst Instance=new A256838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256839
{
public static readonly long[] Value={ 14657L,14741L,14897L,15217L,15541L,15797L,15937L,19541L,20117L,22037L,22741L,23857L,25457L,28097L,30517L,31541L,38977L,40241L,42197L,43541L,44917L,47041L,48497L,50741L,57077L,58741L,61297L,64817L,65717L,74177L,77141L,80177L,82241L,87541L,107057L,117041L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256839Inst : IEnumerable<long>
{
public static readonly long[] Value=A256839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256839.Bytes);
public long this[int i]=>Value[i];

public static A256839Inst Instance=new A256839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256840
{
public static readonly long[] Value={ 20857L,21577L,21961L,23761L,27961L,28657L,29017L,29761L,30937L,33961L,34897L,37897L,41761L,42937L,49297L,51361L,60337L,62761L,65257L,80761L,83737L,93097L,107761L,111337L,113761L,122497L,132961L,142537L,151057L,164377L,173617L,181537L,188017L,192961L,218761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256840Inst : IEnumerable<long>
{
public static readonly long[] Value=A256840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256840.Bytes);
public long this[int i]=>Value[i];

public static A256840Inst Instance=new A256840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256841
{
public static readonly long[] Value={ 28597L,28661L,28817L,28961L,29137L,29717L,30161L,30497L,30677L,31477L,32917L,33461L,34337L,34961L,35617L,37397L,38561L,42017L,42961L,47057L,49297L,49877L,51061L,55457L,60961L,62417L,64661L,66977L,70177L,70997L,72661L,74357L,75217L,76961L,78737L,86161L,93077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256841Inst : IEnumerable<long>
{
public static readonly long[] Value=A256841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256841.Bytes);
public long this[int i]=>Value[i];

public static A256841Inst Instance=new A256841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256842
{
public static readonly long[] Value={ 39713433671L,66419473031L,71525244611L,286371985811L,480612532451L,535181743301L,789972743471L,1195575264641L,1219449947921L,1256522812841L,1292207447351L,1351477467251L,1450982599271L,1460592638171L,1515361442261L,1592346154541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256842Inst : IEnumerable<long>
{
public static readonly long[] Value=A256842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256842.Bytes);
public long this[int i]=>Value[i];

public static A256842Inst Instance=new A256842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256843
{
public static readonly long[] Value={ 0L,7L,3L,2L,0L,7L,3L,7L,5L,7L,0L,6L,1L,5L,9L,5L,9L,3L,6L,6L,9L,0L,3L,1L,8L,5L,9L,9L,0L,7L,5L,2L,9L,1L,3L,9L,0L,7L,4L,6L,2L,3L,8L,3L,0L,2L,6L,8L,3L,0L,9L,3L,4L,5L,6L,2L,9L,3L,9L,0L,6L,4L,4L,6L,6L,9L,8L,5L,1L,0L,9L,4L,2L,7L,4L,5L,9L,7L,4L,0L,4L,1L,7L,7L,2L,3L,0L,8L,1L,5L,5L,3L,0L,8L,6L,0L,9L,0L,3L,1L,6L,0L,1L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256843Inst : IEnumerable<long>
{
public static readonly long[] Value=A256843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256843.Bytes);
public long this[int i]=>Value[i];

public static A256843Inst Instance=new A256843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256844
{
public static readonly long[] Value={ 1L,7L,3L,7L,9L,8L,8L,7L,4L,5L,8L,8L,8L,5L,8L,9L,4L,3L,5L,9L,6L,2L,4L,4L,3L,8L,2L,2L,8L,0L,0L,4L,1L,0L,9L,1L,2L,0L,1L,7L,7L,7L,0L,7L,3L,9L,6L,0L,9L,4L,1L,9L,5L,0L,9L,7L,6L,3L,0L,9L,0L,3L,2L,9L,1L,7L,5L,4L,2L,1L,8L,8L,8L,1L,3L,6L,4L,8L,0L,9L,8L,6L,4L,5L,5L,5L,6L,2L,3L,0L,5L,0L,7L,3L,2L,8L,4L,4L,6L,4L,2L,4L,4L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256844Inst : IEnumerable<long>
{
public static readonly long[] Value=A256844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256844.Bytes);
public long this[int i]=>Value[i];

public static A256844Inst Instance=new A256844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256845
{
public static readonly long[] Value={ 1L,4L,4L,3L,0L,3L,9L,1L,6L,2L,2L,5L,3L,8L,3L,2L,1L,5L,1L,5L,1L,6L,2L,8L,0L,2L,2L,5L,2L,0L,6L,0L,0L,6L,0L,7L,7L,6L,0L,5L,3L,9L,8L,3L,3L,9L,8L,4L,9L,8L,0L,8L,9L,9L,7L,0L,1L,4L,4L,1L,8L,0L,8L,7L,2L,1L,2L,1L,6L,9L,3L,1L,6L,9L,4L,4L,1L,6L,1L,6L,7L,7L,3L,4L,2L,3L,6L,7L,6L,5L,8L,2L,2L,9L,3L,6L,6L,8L,7L,3L,7L,8L,6L,5L,7L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256845Inst : IEnumerable<long>
{
public static readonly long[] Value=A256845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256845.Bytes);
public long this[int i]=>Value[i];

public static A256845Inst Instance=new A256845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256846
{
public static readonly long[] Value={ 0L,7L,5L,1L,0L,8L,3L,7L,0L,3L,3L,3L,3L,5L,4L,6L,1L,2L,3L,0L,1L,8L,9L,4L,3L,7L,0L,0L,2L,4L,7L,9L,3L,1L,1L,0L,7L,4L,5L,2L,3L,1L,3L,0L,7L,3L,4L,6L,8L,4L,3L,5L,1L,4L,3L,9L,0L,2L,5L,6L,2L,6L,2L,9L,4L,3L,9L,1L,1L,7L,1L,3L,5L,9L,8L,9L,3L,6L,2L,7L,8L,1L,9L,2L,8L,0L,1L,7L,5L,5L,5L,9L,5L,7L,2L,3L,2L,7L,4L,2L,3L,3L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256846Inst : IEnumerable<long>
{
public static readonly long[] Value=A256846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256846.Bytes);
public long this[int i]=>Value[i];

public static A256846Inst Instance=new A256846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256847
{
public static readonly long[] Value={ 2L,0L,2L,2L,6L,9L,6L,7L,4L,0L,5L,4L,5L,8L,9L,4L,3L,9L,5L,5L,6L,9L,8L,8L,0L,3L,8L,2L,0L,8L,4L,8L,7L,6L,7L,6L,2L,7L,7L,2L,1L,0L,2L,3L,3L,1L,9L,5L,1L,4L,6L,7L,2L,7L,3L,5L,8L,8L,9L,8L,1L,9L,6L,0L,2L,5L,4L,7L,9L,8L,7L,9L,2L,9L,0L,4L,3L,1L,1L,9L,0L,0L,6L,8L,6L,9L,4L,8L,9L,7L,6L,7L,5L,2L,7L,2L,6L,5L,6L,3L,9L,2L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256847Inst : IEnumerable<long>
{
public static readonly long[] Value=A256847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256847.Bytes);
public long this[int i]=>Value[i];

public static A256847Inst Instance=new A256847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256848
{
public static readonly long[] Value={ 0L,1L,3L,7L,6L,3L,7L,3L,9L,7L,0L,8L,1L,8L,1L,9L,9L,1L,9L,6L,8L,0L,1L,9L,0L,7L,6L,8L,8L,3L,9L,9L,1L,1L,3L,9L,6L,0L,3L,0L,1L,3L,4L,1L,9L,9L,1L,5L,7L,8L,2L,1L,0L,2L,7L,2L,9L,1L,9L,2L,5L,2L,5L,6L,4L,2L,6L,0L,2L,0L,2L,9L,2L,9L,3L,3L,1L,1L,0L,5L,9L,7L,1L,1L,3L,5L,8L,2L,8L,2L,0L,7L,4L,6L,8L,0L,1L,5L,8L,1L,3L,9L,8L,7L,7L,9L,9L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256848Inst : IEnumerable<long>
{
public static readonly long[] Value=A256848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256848.Bytes);
public long this[int i]=>Value[i];

public static A256848Inst Instance=new A256848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256849
{
public static readonly long[] Value={ 1L,2L,8L,8L,8L,5L,8L,6L,9L,1L,4L,5L,5L,9L,2L,3L,8L,3L,0L,4L,1L,8L,9L,2L,3L,4L,0L,0L,1L,3L,8L,7L,0L,4L,4L,3L,9L,7L,8L,2L,8L,8L,1L,7L,2L,9L,1L,4L,6L,5L,8L,9L,7L,8L,5L,6L,0L,5L,6L,7L,4L,1L,9L,4L,4L,5L,8L,4L,3L,5L,5L,6L,0L,6L,4L,3L,9L,4L,7L,5L,2L,0L,6L,4L,7L,5L,1L,4L,4L,3L,7L,7L,0L,6L,5L,1L,5L,1L,1L,7L,3L,3L,4L,7L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256849Inst : IEnumerable<long>
{
public static readonly long[] Value=A256849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256849.Bytes);
public long this[int i]=>Value[i];

public static A256849Inst Instance=new A256849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256850
{
public static readonly long[] Value={ 2L,0L,6L,4L,4L,4L,4L,4L,9L,5L,0L,6L,5L,1L,3L,5L,0L,2L,7L,9L,8L,8L,4L,9L,4L,4L,8L,6L,2L,8L,7L,5L,7L,0L,4L,1L,6L,9L,6L,6L,8L,8L,4L,0L,3L,6L,6L,5L,7L,1L,8L,8L,2L,4L,6L,2L,1L,3L,7L,6L,1L,3L,1L,3L,1L,7L,8L,6L,2L,2L,5L,2L,1L,8L,5L,9L,9L,8L,6L,1L,8L,7L,3L,8L,6L,3L,7L,3L,6L,2L,9L,6L,0L,2L,8L,6L,5L,7L,2L,2L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256850Inst : IEnumerable<long>
{
public static readonly long[] Value=A256850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256850.Bytes);
public long this[int i]=>Value[i];

public static A256850Inst Instance=new A256850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256851
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,-1L,0L,-1L,-4L,-3L,-6L,-5L,-8L,-7L,-10L,2L,-1L,0L,5L,2L,7L,4L,9L,6L,11L,-3L,2L,-5L,0L,-1L,-8L,-3L,-10L,-5L,-12L,4L,-3L,6L,-1L,0L,9L,2L,11L,4L,13L,-5L,4L,-7L,2L,-9L,0L,-1L,-12L,-3L,-14L,6L,-5L,8L,-3L,10L,-1L,0L,13L,2L,15L,-7L,6L,-9L,4L,-11L,2L,-13L,0L,-1L,-16L,8L,-7L,10L,-5L,12L,-3L,14L,-1L,0L,17L,-9L,8L,-11L,6L,-13L,4L,-15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256851Inst : IEnumerable<long>
{
public static readonly long[] Value=A256851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256851.Bytes);
public long this[int i]=>Value[i];

public static A256851Inst Instance=new A256851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256852
{
public static readonly long[] Value={ 1L,0L,1L,0L,0L,0L,2L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256852Inst : IEnumerable<long>
{
public static readonly long[] Value=A256852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256852.Bytes);
public long this[int i]=>Value[i];

public static A256852Inst Instance=new A256852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256853
{
public static readonly long[] Value={ 6L,1L,8L,1L,8L,2L,4L,1L,9L,3L,7L,7L,2L,9L,0L,0L,1L,2L,7L,2L,1L,3L,7L,4L,4L,0L,5L,9L,6L,1L,9L,7L,6L,3L,6L,1L,4L,9L,4L,1L,7L,1L,3L,3L,4L,8L,1L,3L,4L,3L,5L,8L,0L,9L,8L,3L,8L,6L,8L,6L,4L,2L,5L,5L,6L,6L,9L,7L,7L,1L,0L,7L,1L,2L,3L,3L,5L,8L,4L,6L,6L,4L,7L,6L,6L,3L,5L,9L,5L,5L,3L,3L,8L,9L,0L,7L,9L,1L,8L,4L,0L,9L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256853Inst : IEnumerable<long>
{
public static readonly long[] Value=A256853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256853.Bytes);
public long this[int i]=>Value[i];

public static A256853Inst Instance=new A256853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256854
{
public static readonly long[] Value={ 9L,3L,6L,5L,6L,3L,9L,9L,0L,6L,9L,4L,5L,4L,3L,7L,5L,2L,4L,8L,8L,2L,3L,5L,8L,4L,5L,3L,2L,8L,4L,3L,3L,4L,2L,8L,7L,8L,8L,2L,5L,7L,4L,9L,6L,1L,8L,3L,5L,0L,2L,7L,3L,8L,7L,6L,8L,9L,3L,1L,8L,6L,6L,7L,9L,4L,7L,8L,7L,0L,9L,3L,9L,8L,2L,3L,1L,0L,0L,7L,6L,4L,6L,1L,3L,0L,1L,3L,6L,4L,4L,1L,0L,4L,8L,1L,1L,2L,3L,0L,8L,3L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256854Inst : IEnumerable<long>
{
public static readonly long[] Value=A256854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256854.Bytes);
public long this[int i]=>Value[i];

public static A256854Inst Instance=new A256854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256855
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,3L,1L,4L,1L,3L,2L,3L,4L,1L,4L,3L,5L,4L,3L,3L,2L,3L,5L,1L,5L,2L,7L,3L,3L,6L,4L,7L,3L,4L,2L,3L,4L,7L,4L,5L,4L,6L,5L,3L,5L,6L,4L,4L,3L,4L,5L,8L,8L,4L,5L,6L,5L,5L,4L,7L,5L,6L,7L,3L,7L,4L,7L,5L,6L,2L,5L,8L,10L,3L,4L,6L,6L,7L,4L,9L,5L,10L,10L,5L,4L,6L,6L,8L,4L,8L,3L,6L,11L,5L,8L,4L,10L,4L,2L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256855Inst : IEnumerable<long>
{
public static readonly long[] Value=A256855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256855.Bytes);
public long this[int i]=>Value[i];

public static A256855Inst Instance=new A256855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256856
{
public static readonly long[] Value={ 1L,0L,6L,0L,12L,12L,6L,24L,18L,0L,24L,12L,12L,24L,66L,12L,48L,36L,6L,24L,60L,24L,60L,36L,18L,48L,60L,0L,156L,48L,24L,48L,102L,12L,72L,132L,12L,48L,96L,24L,144L,60L,66L,72L,132L,12L,108L,72L,48L,168L,138L,36L,144L,72L,6L,120L,342L,24L,132L,72L,60L,96L,144L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256856Inst : IEnumerable<long>
{
public static readonly long[] Value=A256856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256856.Bytes);
public long this[int i]=>Value[i];

public static A256856Inst Instance=new A256856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256857
{
public static readonly long[] Value={ 0L,1L,8L,24L,52L,95L,156L,238L,344L,477L,640L,836L,1068L,1339L,1652L,2010L,2416L,2873L,3384L,3952L,4580L,5271L,6028L,6854L,7752L,8725L,9776L,10908L,12124L,13427L,14820L,16306L,17888L,19569L,21352L,23240L,25236L,27343L,29564L,31902L,34360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256857Inst : IEnumerable<long>
{
public static readonly long[] Value=A256857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256857.Bytes);
public long this[int i]=>Value[i];

public static A256857Inst Instance=new A256857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256858
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,1L,-1L,2L,-3L,3L,-3L,4L,-2L,8L,9L,17L,29L,50L,83L,107L,56L,239L,-243L,1103L,-2351L,3775L,-7227L,14463L,-18648L,55283L,54011L,256666L,698301L,2059753L,5324929L,9820288L,15128062L,55075036L,-28437275L,503857819L,-1438167267L,4083736906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256858Inst : IEnumerable<long>
{
public static readonly long[] Value=A256858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256858.Bytes);
public long this[int i]=>Value[i];

public static A256858Inst Instance=new A256858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256859
{
public static readonly long[] Value={ 1L,6L,25L,80L,210L,476L,966L,1800L,3135L,5170L,8151L,12376L,18200L,26040L,36380L,49776L,66861L,88350L,115045L,147840L,187726L,235796L,293250L,361400L,441675L,535626L,644931L,771400L,916980L,1083760L,1273976L,1490016L,1734425L,2009910L,2319345L,2665776L,3052426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256859Inst : IEnumerable<long>
{
public static readonly long[] Value=A256859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256859.Bytes);
public long this[int i]=>Value[i];

public static A256859Inst Instance=new A256859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256860
{
public static readonly long[] Value={ 1L,7L,33L,119L,350L,882L,1974L,4026L,7623L,13585L,23023L,37401L,58604L,89012L,131580L,189924L,268413L,372267L,507661L,681835L,903210L,1181510L,1527890L,1955070L,2477475L,3111381L,3875067L,4788973L,5875864L,7161000L,8672312L,10440584L,12499641L,14886543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256860Inst : IEnumerable<long>
{
public static readonly long[] Value=A256860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256860.Bytes);
public long this[int i]=>Value[i];

public static A256860Inst Instance=new A256860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256861
{
public static readonly long[] Value={ 1L,8L,42L,168L,546L,1512L,3696L,8184L,16731L,32032L,58058L,100464L,167076L,268464L,418608L,635664L,942837L,1369368L,1951642L,2734424L,3772230L,5130840L,6888960L,9140040L,11994255L,15580656L,20049498L,25574752L,32356808L,40625376L,50642592L,62706336L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256861Inst : IEnumerable<long>
{
public static readonly long[] Value=A256861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256861.Bytes);
public long this[int i]=>Value[i];

public static A256861Inst Instance=new A256861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256862
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,15L,17L,19L,21L,25L,29L,31L,35L,37L,39L,49L,51L,55L,57L,59L,61L,69L,73L,77L,79L,81L,89L,91L,95L,103L,105L,107L,117L,119L,121L,125L,129L,131L,135L,139L,141L,149L,151L,155L,157L,165L,169L,171L,179L,183L,191L,195L,197L,199L,201L,205L,207L,217L,219L,221L,231L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256862Inst : IEnumerable<long>
{
public static readonly long[] Value=A256862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256862.Bytes);
public long this[int i]=>Value[i];

public static A256862Inst Instance=new A256862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256863
{
public static readonly long[] Value={ 3L,7L,11L,13L,19L,23L,29L,31L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,103L,107L,109L,113L,127L,131L,139L,149L,151L,157L,163L,167L,173L,179L,191L,193L,199L,211L,223L,227L,229L,233L,239L,251L,263L,269L,271L,283L,293L,307L,311L,313L,317L,331L,347L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256863Inst : IEnumerable<long>
{
public static readonly long[] Value=A256863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256863.Bytes);
public long this[int i]=>Value[i];

public static A256863Inst Instance=new A256863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256864
{
public static readonly long[] Value={ 3L,7L,13L,19L,31L,41L,43L,61L,71L,83L,103L,109L,131L,137L,139L,151L,157L,167L,179L,193L,197L,199L,223L,229L,241L,257L,271L,281L,283L,311L,337L,349L,383L,421L,433L,439L,461L,463L,487L,503L,523L,547L,571L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256864Inst : IEnumerable<long>
{
public static readonly long[] Value=A256864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256864.Bytes);
public long this[int i]=>Value[i];

public static A256864Inst Instance=new A256864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256865
{
public static readonly long[] Value={ 0L,6L,10L,30L,50L,60L,110L,126L,150L,156L,168L,180L,210L,231L,250L,260L,300L,310L,378L,550L,630L,660L,726L,750L,756L,780L,810L,840L,900L,930L,1008L,1050L,1250L,1260L,1300L,1310L,1320L,1380L,1410L,1500L,1510L,1530L,1550L,1560L,1680L,1760L,1870L,1890L,1960L,2016L,2268L,2310L,2331L,2618L,2750L,2860L,3124L,3126L,3150L,3156L,3180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256865Inst : IEnumerable<long>
{
public static readonly long[] Value=A256865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256865.Bytes);
public long this[int i]=>Value[i];

public static A256865Inst Instance=new A256865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256866
{
public static readonly long[] Value={ 0L,6L,21L,36L,42L,126L,216L,222L,252L,258L,273L,300L,480L,510L,525L,560L,693L,735L,756L,770L,777L,880L,924L,1001L,1012L,1296L,1302L,1320L,1326L,1332L,1338L,1380L,1482L,1512L,1518L,1548L,1554L,1560L,1590L,1638L,1716L,1740L,1770L,1785L,1800L,1995L,2058L,2079L,2310L,2418L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256866Inst : IEnumerable<long>
{
public static readonly long[] Value=A256866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256866.Bytes);
public long this[int i]=>Value[i];

public static A256866Inst Instance=new A256866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256867
{
public static readonly long[] Value={ 0L,15L,57L,100L,168L,182L,396L,450L,624L,700L,750L,800L,840L,1050L,1176L,1190L,1274L,1485L,1540L,1716L,2520L,2652L,2760L,2772L,2814L,2850L,2898L,2970L,3150L,3486L,3570L,3861L,4173L,4368L,4488L,4860L,4900L,4940L,4970L,5160L,5250L,5490L,5595L,5600L,5880L,5950L,6435L,6630L,7224L,7350L,7560L,7602L,7910L,8050L,8232L,8330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256867Inst : IEnumerable<long>
{
public static readonly long[] Value=A256867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256867.Bytes);
public long this[int i]=>Value[i];

public static A256867Inst Instance=new A256867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256868
{
public static readonly long[] Value={ 0L,9L,33L,57L,72L,130L,210L,264L,456L,570L,576L,585L,660L,969L,1040L,1050L,1170L,1365L,1540L,1680L,1995L,2112L,2145L,2508L,2600L,2730L,2860L,2925L,3366L,3648L,3705L,4047L,4104L,4170L,4356L,4488L,4560L,4608L,4620L,4680L,4683L,4809L,4998L,5130L,5250L,5265L,5280L,6825L,7752L,8210L,8320L,8400L,8850L,9240L,9350L,9360L,9555L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256868Inst : IEnumerable<long>
{
public static readonly long[] Value=A256868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256868.Bytes);
public long this[int i]=>Value[i];

public static A256868Inst Instance=new A256868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256869
{
public static readonly long[] Value={ 0L,20L,84L,90L,180L,252L,273L,455L,510L,738L,756L,810L,816L,840L,900L,1224L,1275L,1460L,1470L,1620L,1640L,2090L,2185L,2268L,2450L,2541L,3080L,3289L,3553L,4199L,4590L,5434L,6570L,6642L,6660L,6804L,7290L,7326L,7344L,7380L,7395L,7470L,7560L,7866L,8100L,8160L,8190L,8778L,8841L,8925L,9282L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256869Inst : IEnumerable<long>
{
public static readonly long[] Value=A256869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256869.Bytes);
public long this[int i]=>Value[i];

public static A256869Inst Instance=new A256869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256870
{
public static readonly long[] Value={ 0L,20L,44L,111L,120L,171L,200L,210L,220L,290L,440L,520L,1020L,1110L,1113L,1200L,1710L,1914L,2000L,2010L,2020L,2030L,2100L,2145L,2200L,2220L,2310L,2420L,2900L,3220L,3381L,4004L,4048L,4400L,4444L,5200L,5525L,6120L,7220L,8280L,9338L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256870Inst : IEnumerable<long>
{
public static readonly long[] Value=A256870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256870.Bytes);
public long this[int i]=>Value[i];

public static A256870Inst Instance=new A256870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256871
{
public static readonly long[] Value={ 6L,13L,30L,76L,216L,688L,2400L,8896L,34176L,133888L,529920L,2108416L,8411136L,33599488L,134307840L,537051136L,2147844096L,8590655488L,34361180160L,137441837056L,549761581056L,2199034789888L,8796116090880L,35184418226176L,140737580630016L,562950137970688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256871Inst : IEnumerable<long>
{
public static readonly long[] Value=A256871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256871.Bytes);
public long this[int i]=>Value[i];

public static A256871Inst Instance=new A256871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256872
{
public static readonly long[] Value={ 23L,31L,45L,47L,61L,93L,95L,119L,125L,127L,175L,187L,189L,191L,239L,247L,253L,255L,335L,357L,359L,363L,369L,379L,381L,383L,431L,439L,455L,477L,485L,491L,493L,495L,507L,509L,511L,573L,575L,631L,637L,639L,669L,671L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256872Inst : IEnumerable<long>
{
public static readonly long[] Value=A256872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256872.Bytes);
public long this[int i]=>Value[i];

public static A256872Inst Instance=new A256872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256873
{
public static readonly long[] Value={ 3L,7L,18L,52L,168L,592L,2208L,8512L,33408L,132352L,526848L,2102272L,8398848L,33574912L,134258688L,536952832L,2147647488L,8590262272L,34360393728L,137440264192L,549758435328L,2199028498432L,8796103507968L,35184393060352L,140737530298368L,562950037307392L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256873Inst : IEnumerable<long>
{
public static readonly long[] Value=A256873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256873.Bytes);
public long this[int i]=>Value[i];

public static A256873Inst Instance=new A256873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256874
{
public static readonly long[] Value={ 6L,15L,30L,42L,90L,102L,150L,255L,342L,426L,510L,618L,630L,666L,678L,750L,870L,990L,1386L,1434L,1446L,1470L,1530L,1626L,1638L,1686L,1710L,1770L,1950L,2010L,2394L,2406L,2430L,2454L,2490L,2550L,2646L,2670L,2730L,2790L,2910L,2970L,3030L,3450L,3510L,3690L,3750L,3930L,3990L,4095L,5466L,5478L,5526L,5550L,5610L,5718L,5790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256874Inst : IEnumerable<long>
{
public static readonly long[] Value=A256874.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256874.Bytes);
public long this[int i]=>Value[i];

public static A256874Inst Instance=new A256874Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256875
{
public static readonly long[] Value={ 6L,12L,36L,156L,162L,186L,282L,306L,312L,546L,784L,786L,906L,912L,924L,936L,1246L,1536L,1806L,2674L,2814L,2856L,3906L,3912L,3936L,4032L,4056L,4062L,4074L,4284L,4536L,4656L,4662L,4686L,4746L,4914L,5796L,5922L,6174L,7032L,7056L,7062L,7182L,7434L,7656L,7662L,7686L,7782L,7806L,7812L,8064L,8106L,8946L,9072L,9114L,9282L,9324L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256875Inst : IEnumerable<long>
{
public static readonly long[] Value=A256875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256875.Bytes);
public long this[int i]=>Value[i];

public static A256875Inst Instance=new A256875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256876
{
public static readonly long[] Value={ 15L,28L,154L,280L,525L,555L,735L,910L,1036L,1078L,1666L,3795L,4270L,4665L,4690L,5446L,5530L,5572L,5775L,5950L,6202L,7755L,9352L,9982L,10108L,13888L,14014L,15400L,18705L,18885L,18915L,19965L,19995L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256876Inst : IEnumerable<long>
{
public static readonly long[] Value=A256876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256876.Bytes);
public long this[int i]=>Value[i];

public static A256876Inst Instance=new A256876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256877
{
public static readonly long[] Value={ 8L,10L,114L,120L,195L,264L,286L,400L,408L,450L,456L,500L,650L,744L,750L,780L,792L,1100L,1170L,1200L,1804L,1870L,2802L,2808L,2850L,2886L,3144L,3198L,3600L,4290L,4524L,5202L,5280L,5610L,5655L,5742L,6000L,6798L,7020L,7710L,8010L,8340L,12804L,13200L,14820L,14846L,15210L,19608L,19610L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256877Inst : IEnumerable<long>
{
public static readonly long[] Value=A256877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256877.Bytes);
public long this[int i]=>Value[i];

public static A256877Inst Instance=new A256877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256878
{
public static readonly long[] Value={ 18L,35L,78L,84L,90L,138L,210L,255L,330L,429L,588L,594L,910L,1098L,1170L,1275L,1386L,1530L,1755L,1820L,1950L,2156L,2275L,2706L,3315L,3510L,3927L,3978L,4746L,4758L,4794L,4900L,4914L,5202L,5610L,5850L,6244L,6300L,6412L,6930L,7254L,7410L,7462L,7566L,8778L,8850L,9042L,9354L,9435L,9492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256878Inst : IEnumerable<long>
{
public static readonly long[] Value=A256878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256878.Bytes);
public long this[int i]=>Value[i];

public static A256878Inst Instance=new A256878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256879
{
public static readonly long[] Value={ 10L,30L,195L,275L,280L,364L,429L,546L,646L,820L,840L,1000L,1144L,1360L,1560L,1650L,2280L,2370L,2440L,2460L,2640L,2730L,3010L,3740L,4114L,4940L,5236L,5928L,6555L,7800L,8018L,8130L,8850L,8940L,8970L,9030L,9100L,9660L,9730L,9814L,10868L,11050L,11076L,14352L,14700L,14820L,15015L,15420L,18564L,20670L,21090L,21405L,22225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256879Inst : IEnumerable<long>
{
public static readonly long[] Value=A256879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256879.Bytes);
public long this[int i]=>Value[i];

public static A256879Inst Instance=new A256879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256880
{
public static readonly long[] Value={ 1L,4L,9L,48L,200L,1440L,8820L,80640L,653184L,7257600L,73180800L,958003200L,11564467200L,174356582400L,2451889440000L,41845579776000L,671854030848000L,12804747411456000L,231125690776780800L,4865804016353280000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A256880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256880Inst : IEnumerable<long>
{
public static readonly long[] Value=A256880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A256880.Bytes);
public long this[int i]=>Value[i];

public static A256880Inst Instance=new A256880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A256881
{
public static readonly BigInteger[] Value={ 1L,2L,3L,12L,40L,240L,1260L,10080L,72576L,725760L,6652800L,79833600L,889574400L,12454041600L,163459296000L,2615348736000L,39520825344000L,711374856192000L,12164510040883200L,243290200817664000L,4644631106519040000L,BigInteger.Parse("102181884343418880000"),BigInteger.Parse("2154334728240414720000") };
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
public class A256881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A256881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A256881Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A256881.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A256881.Bytes);
public BigInteger this[int i]=>Value[i];

public static A256881Inst Instance=new A256881Inst();

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