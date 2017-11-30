using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A047533
{
public static readonly long[] Value={ 1L,2L,3L,7L,9L,10L,11L,15L,17L,18L,19L,23L,25L,26L,27L,31L,33L,34L,35L,39L,41L,42L,43L,47L,49L,50L,51L,55L,57L,58L,59L,63L,65L,66L,67L,71L,73L,74L,75L,79L,81L,82L,83L,87L,89L,90L,91L,95L,97L,98L,99L,103L,105L,106L,107L,111L,113L,114L,115L,119L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047533Inst : IEnumerable<long>
{
public static readonly long[] Value=A047533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047533.Bytes);
public long this[int i]=>Value[i];

public static A047533Inst Instance=new A047533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047532
{
public static readonly long[] Value={ 0L,2L,3L,7L,8L,10L,11L,15L,16L,18L,19L,23L,24L,26L,27L,31L,32L,34L,35L,39L,40L,42L,43L,47L,48L,50L,51L,55L,56L,58L,59L,63L,64L,66L,67L,71L,72L,74L,75L,79L,80L,82L,83L,87L,88L,90L,91L,95L,96L,98L,99L,103L,104L,106L,107L,111L,112L,114L,115L,119L,120L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047532Inst : IEnumerable<long>
{
public static readonly long[] Value=A047532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047532.Bytes);
public long this[int i]=>Value[i];

public static A047532Inst Instance=new A047532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047531
{
public static readonly long[] Value={ 2L,3L,7L,10L,11L,15L,18L,19L,23L,26L,27L,31L,34L,35L,39L,42L,43L,47L,50L,51L,55L,58L,59L,63L,66L,67L,71L,74L,75L,79L,82L,83L,87L,90L,91L,95L,98L,99L,103L,106L,107L,111L,114L,115L,119L,122L,123L,127L,130L,131L,135L,138L,139L,143L,146L,147L,151L,154L,155L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047531Inst : IEnumerable<long>
{
public static readonly long[] Value=A047531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047531.Bytes);
public long this[int i]=>Value[i];

public static A047531Inst Instance=new A047531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047530
{
public static readonly long[] Value={ 0L,1L,3L,7L,8L,9L,11L,15L,16L,17L,19L,23L,24L,25L,27L,31L,32L,33L,35L,39L,40L,41L,43L,47L,48L,49L,51L,55L,56L,57L,59L,63L,64L,65L,67L,71L,72L,73L,75L,79L,80L,81L,83L,87L,88L,89L,91L,95L,96L,97L,99L,103L,104L,105L,107L,111L,112L,113L,115L,119L,120L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047530Inst : IEnumerable<long>
{
public static readonly long[] Value=A047530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047530.Bytes);
public long this[int i]=>Value[i];

public static A047530Inst Instance=new A047530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047529
{
public static readonly long[] Value={ 1L,3L,7L,9L,11L,15L,17L,19L,23L,25L,27L,31L,33L,35L,39L,41L,43L,47L,49L,51L,55L,57L,59L,63L,65L,67L,71L,73L,75L,79L,81L,83L,87L,89L,91L,95L,97L,99L,103L,105L,107L,111L,113L,115L,119L,121L,123L,127L,129L,131L,135L,137L,139L,143L,145L,147L,151L,153L,155L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047529Inst : IEnumerable<long>
{
public static readonly long[] Value=A047529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047529.Bytes);
public long this[int i]=>Value[i];

public static A047529Inst Instance=new A047529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047528
{
public static readonly long[] Value={ 0L,3L,7L,8L,11L,15L,16L,19L,23L,24L,27L,31L,32L,35L,39L,40L,43L,47L,48L,51L,55L,56L,59L,63L,64L,67L,71L,72L,75L,79L,80L,83L,87L,88L,91L,95L,96L,99L,103L,104L,107L,111L,112L,115L,119L,120L,123L,127L,128L,131L,135L,136L,139L,143L,144L,147L,151L,152L,155L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047528Inst : IEnumerable<long>
{
public static readonly long[] Value=A047528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047528.Bytes);
public long this[int i]=>Value[i];

public static A047528Inst Instance=new A047528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047527
{
public static readonly long[] Value={ 0L,1L,2L,7L,8L,9L,10L,15L,16L,17L,18L,23L,24L,25L,26L,31L,32L,33L,34L,39L,40L,41L,42L,47L,48L,49L,50L,55L,56L,57L,58L,63L,64L,65L,66L,71L,72L,73L,74L,79L,80L,81L,82L,87L,88L,89L,90L,95L,96L,97L,98L,103L,104L,105L,106L,111L,112L,113L,114L,119L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047527Inst : IEnumerable<long>
{
public static readonly long[] Value=A047527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047527.Bytes);
public long this[int i]=>Value[i];

public static A047527Inst Instance=new A047527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047526
{
public static readonly long[] Value={ 1L,2L,7L,9L,10L,15L,17L,18L,23L,25L,26L,31L,33L,34L,39L,41L,42L,47L,49L,50L,55L,57L,58L,63L,65L,66L,71L,73L,74L,79L,81L,82L,87L,89L,90L,95L,97L,98L,103L,105L,106L,111L,113L,114L,119L,121L,122L,127L,129L,130L,135L,137L,138L,143L,145L,146L,151L,153L,154L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047526Inst : IEnumerable<long>
{
public static readonly long[] Value=A047526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047526.Bytes);
public long this[int i]=>Value[i];

public static A047526Inst Instance=new A047526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047525
{
public static readonly long[] Value={ 0L,2L,7L,8L,10L,15L,16L,18L,23L,24L,26L,31L,32L,34L,39L,40L,42L,47L,48L,50L,55L,56L,58L,63L,64L,66L,71L,72L,74L,79L,80L,82L,87L,88L,90L,95L,96L,98L,103L,104L,106L,111L,112L,114L,119L,120L,122L,127L,128L,130L,135L,136L,138L,143L,144L,146L,151L,152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047525Inst : IEnumerable<long>
{
public static readonly long[] Value=A047525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047525.Bytes);
public long this[int i]=>Value[i];

public static A047525Inst Instance=new A047525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047524
{
public static readonly long[] Value={ 2L,7L,10L,15L,18L,23L,26L,31L,34L,39L,42L,47L,50L,55L,58L,63L,66L,71L,74L,79L,82L,87L,90L,95L,98L,103L,106L,111L,114L,119L,122L,127L,130L,135L,138L,143L,146L,151L,154L,159L,162L,167L,170L,175L,178L,183L,186L,191L,194L,199L,202L,207L,210L,215L,218L,223L,226L,231L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047524Inst : IEnumerable<long>
{
public static readonly long[] Value=A047524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047524.Bytes);
public long this[int i]=>Value[i];

public static A047524Inst Instance=new A047524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047523
{
public static readonly long[] Value={ 0L,1L,7L,8L,9L,15L,16L,17L,23L,24L,25L,31L,32L,33L,39L,40L,41L,47L,48L,49L,55L,56L,57L,63L,64L,65L,71L,72L,73L,79L,80L,81L,87L,88L,89L,95L,96L,97L,103L,104L,105L,111L,112L,113L,119L,120L,121L,127L,128L,129L,135L,136L,137L,143L,144L,145L,151L,152L,153L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047523Inst : IEnumerable<long>
{
public static readonly long[] Value=A047523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047523.Bytes);
public long this[int i]=>Value[i];

public static A047523Inst Instance=new A047523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047522
{
public static readonly long[] Value={ 1L,7L,9L,15L,17L,23L,25L,31L,33L,39L,41L,47L,49L,55L,57L,63L,65L,71L,73L,79L,81L,87L,89L,95L,97L,103L,105L,111L,113L,119L,121L,127L,129L,135L,137L,143L,145L,151L,153L,159L,161L,167L,169L,175L,177L,183L,185L,191L,193L,199L,201L,207L,209L,215L,217L,223L,225L,231L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047522Inst : IEnumerable<long>
{
public static readonly long[] Value=A047522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047522.Bytes);
public long this[int i]=>Value[i];

public static A047522Inst Instance=new A047522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047521
{
public static readonly long[] Value={ 0L,7L,8L,15L,16L,23L,24L,31L,32L,39L,40L,47L,48L,55L,56L,63L,64L,71L,72L,79L,80L,87L,88L,95L,96L,103L,104L,111L,112L,119L,120L,127L,128L,135L,136L,143L,144L,151L,152L,159L,160L,167L,168L,175L,176L,183L,184L,191L,192L,199L,200L,207L,208L,215L,216L,223L,224L,231L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047521Inst : IEnumerable<long>
{
public static readonly long[] Value=A047521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047521.Bytes);
public long this[int i]=>Value[i];

public static A047521Inst Instance=new A047521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047520
{
public static readonly long[] Value={ 0L,1L,6L,21L,58L,141L,318L,685L,1434L,2949L,5998L,12117L,24378L,48925L,98046L,196317L,392890L,786069L,1572462L,3145285L,6290970L,12582381L,25165246L,50331021L,100662618L,201325861L,402652398L,805305525L,1610611834L,3221224509L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047520Inst : IEnumerable<long>
{
public static readonly long[] Value=A047520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047520.Bytes);
public long this[int i]=>Value[i];

public static A047520Inst Instance=new A047520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047519
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,9L,10L,11L,12L,14L,15L,17L,18L,19L,20L,22L,23L,25L,26L,27L,28L,30L,31L,33L,34L,35L,36L,38L,39L,41L,42L,43L,44L,46L,47L,49L,50L,51L,52L,54L,55L,57L,58L,59L,60L,62L,63L,65L,66L,67L,68L,70L,71L,73L,74L,75L,76L,78L,79L,81L,82L,83L,84L,86L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047519Inst : IEnumerable<long>
{
public static readonly long[] Value=A047519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047519.Bytes);
public long this[int i]=>Value[i];

public static A047519Inst Instance=new A047519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047518
{
public static readonly long[] Value={ 2L,3L,4L,6L,7L,10L,11L,12L,14L,15L,18L,19L,20L,22L,23L,26L,27L,28L,30L,31L,34L,35L,36L,38L,39L,42L,43L,44L,46L,47L,50L,51L,52L,54L,55L,58L,59L,60L,62L,63L,66L,67L,68L,70L,71L,74L,75L,76L,78L,79L,82L,83L,84L,86L,87L,90L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047518Inst : IEnumerable<long>
{
public static readonly long[] Value=A047518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047518.Bytes);
public long this[int i]=>Value[i];

public static A047518Inst Instance=new A047518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047517
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,7L,8L,9L,11L,12L,14L,15L,16L,17L,19L,20L,22L,23L,24L,25L,27L,28L,30L,31L,32L,33L,35L,36L,38L,39L,40L,41L,43L,44L,46L,47L,48L,49L,51L,52L,54L,55L,56L,57L,59L,60L,62L,63L,64L,65L,67L,68L,70L,71L,72L,73L,75L,76L,78L,79L,80L,81L,83L,84L,86L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047517Inst : IEnumerable<long>
{
public static readonly long[] Value=A047517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047517.Bytes);
public long this[int i]=>Value[i];

public static A047517Inst Instance=new A047517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047516
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,9L,11L,12L,14L,15L,17L,19L,20L,22L,23L,25L,27L,28L,30L,31L,33L,35L,36L,38L,39L,41L,43L,44L,46L,47L,49L,51L,52L,54L,55L,57L,59L,60L,62L,63L,65L,67L,68L,70L,71L,73L,75L,76L,78L,79L,81L,83L,84L,86L,87L,89L,91L,92L,94L,95L,97L,99L,100L,102L,103L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047516Inst : IEnumerable<long>
{
public static readonly long[] Value=A047516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047516.Bytes);
public long this[int i]=>Value[i];

public static A047516Inst Instance=new A047516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047515
{
public static readonly long[] Value={ 0L,3L,4L,6L,7L,8L,11L,12L,14L,15L,16L,19L,20L,22L,23L,24L,27L,28L,30L,31L,32L,35L,36L,38L,39L,40L,43L,44L,46L,47L,48L,51L,52L,54L,55L,56L,59L,60L,62L,63L,64L,67L,68L,70L,71L,72L,75L,76L,78L,79L,80L,83L,84L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047515Inst : IEnumerable<long>
{
public static readonly long[] Value=A047515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047515.Bytes);
public long this[int i]=>Value[i];

public static A047515Inst Instance=new A047515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047514
{
public static readonly long[] Value={ 3L,4L,6L,7L,11L,12L,14L,15L,19L,20L,22L,23L,27L,28L,30L,31L,35L,36L,38L,39L,43L,44L,46L,47L,51L,52L,54L,55L,59L,60L,62L,63L,67L,68L,70L,71L,75L,76L,78L,79L,83L,84L,86L,87L,91L,92L,94L,95L,99L,100L,102L,103L,107L,108L,110L,111L,115L,116L,118L,119L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047514Inst : IEnumerable<long>
{
public static readonly long[] Value=A047514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047514.Bytes);
public long this[int i]=>Value[i];

public static A047514Inst Instance=new A047514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047513
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,7L,8L,9L,10L,12L,14L,15L,16L,17L,18L,20L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,36L,38L,39L,40L,41L,42L,44L,46L,47L,48L,49L,50L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,70L,71L,72L,73L,74L,76L,78L,79L,80L,81L,82L,84L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047513Inst : IEnumerable<long>
{
public static readonly long[] Value=A047513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047513.Bytes);
public long this[int i]=>Value[i];

public static A047513Inst Instance=new A047513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047512
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,17L,18L,20L,22L,23L,25L,26L,28L,30L,31L,33L,34L,36L,38L,39L,41L,42L,44L,46L,47L,49L,50L,52L,54L,55L,57L,58L,60L,62L,63L,65L,66L,68L,70L,71L,73L,74L,76L,78L,79L,81L,82L,84L,86L,87L,89L,90L,92L,94L,95L,97L,98L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047512Inst : IEnumerable<long>
{
public static readonly long[] Value=A047512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047512.Bytes);
public long this[int i]=>Value[i];

public static A047512Inst Instance=new A047512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047511
{
public static readonly long[] Value={ 0L,2L,4L,6L,7L,8L,10L,12L,14L,15L,16L,18L,20L,22L,23L,24L,26L,28L,30L,31L,32L,34L,36L,38L,39L,40L,42L,44L,46L,47L,48L,50L,52L,54L,55L,56L,58L,60L,62L,63L,64L,66L,68L,70L,71L,72L,74L,76L,78L,79L,80L,82L,84L,86L,87L,88L,90L,92L,94L,95L,96L,98L,100L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047511Inst : IEnumerable<long>
{
public static readonly long[] Value=A047511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047511.Bytes);
public long this[int i]=>Value[i];

public static A047511Inst Instance=new A047511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047510
{
public static readonly long[] Value={ 2L,4L,6L,7L,10L,12L,14L,15L,18L,20L,22L,23L,26L,28L,30L,31L,34L,36L,38L,39L,42L,44L,46L,47L,50L,52L,54L,55L,58L,60L,62L,63L,66L,68L,70L,71L,74L,76L,78L,79L,82L,84L,86L,87L,90L,92L,94L,95L,98L,100L,102L,103L,106L,108L,110L,111L,114L,116L,118L,119L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047510Inst : IEnumerable<long>
{
public static readonly long[] Value=A047510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047510.Bytes);
public long this[int i]=>Value[i];

public static A047510Inst Instance=new A047510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047509
{
public static readonly long[] Value={ 0L,1L,4L,6L,7L,8L,9L,12L,14L,15L,16L,17L,20L,22L,23L,24L,25L,28L,30L,31L,32L,33L,36L,38L,39L,40L,41L,44L,46L,47L,48L,49L,52L,54L,55L,56L,57L,60L,62L,63L,64L,65L,68L,70L,71L,72L,73L,76L,78L,79L,80L,81L,84L,86L,87L,88L,89L,92L,94L,95L,96L,97L,100L,102L,103L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047509Inst : IEnumerable<long>
{
public static readonly long[] Value=A047509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047509.Bytes);
public long this[int i]=>Value[i];

public static A047509Inst Instance=new A047509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047508
{
public static readonly long[] Value={ 1L,4L,6L,7L,9L,12L,14L,15L,17L,20L,22L,23L,25L,28L,30L,31L,33L,36L,38L,39L,41L,44L,46L,47L,49L,52L,54L,55L,57L,60L,62L,63L,65L,68L,70L,71L,73L,76L,78L,79L,81L,84L,86L,87L,89L,92L,94L,95L,97L,100L,102L,103L,105L,108L,110L,111L,113L,116L,118L,119L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047508Inst : IEnumerable<long>
{
public static readonly long[] Value=A047508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047508.Bytes);
public long this[int i]=>Value[i];

public static A047508Inst Instance=new A047508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047507
{
public static readonly long[] Value={ 0L,4L,6L,7L,8L,12L,14L,15L,16L,20L,22L,23L,24L,28L,30L,31L,32L,36L,38L,39L,40L,44L,46L,47L,48L,52L,54L,55L,56L,60L,62L,63L,64L,68L,70L,71L,72L,76L,78L,79L,80L,84L,86L,87L,88L,92L,94L,95L,96L,100L,102L,103L,104L,108L,110L,111L,112L,116L,118L,119L,120L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047507Inst : IEnumerable<long>
{
public static readonly long[] Value=A047507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047507.Bytes);
public long this[int i]=>Value[i];

public static A047507Inst Instance=new A047507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047506
{
public static readonly long[] Value={ 4L,6L,7L,12L,14L,15L,20L,22L,23L,28L,30L,31L,36L,38L,39L,44L,46L,47L,52L,54L,55L,60L,62L,63L,68L,70L,71L,76L,78L,79L,84L,86L,87L,92L,94L,95L,100L,102L,103L,108L,110L,111L,116L,118L,119L,124L,126L,127L,132L,134L,135L,140L,142L,143L,148L,150L,151L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047506Inst : IEnumerable<long>
{
public static readonly long[] Value=A047506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047506.Bytes);
public long this[int i]=>Value[i];

public static A047506Inst Instance=new A047506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047505
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,7L,8L,9L,10L,11L,14L,15L,16L,17L,18L,19L,22L,23L,24L,25L,26L,27L,30L,31L,32L,33L,34L,35L,38L,39L,40L,41L,42L,43L,46L,47L,48L,49L,50L,51L,54L,55L,56L,57L,58L,59L,62L,63L,64L,65L,66L,67L,70L,71L,72L,73L,74L,75L,78L,79L,80L,81L,82L,83L,86L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047505Inst : IEnumerable<long>
{
public static readonly long[] Value=A047505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047505.Bytes);
public long this[int i]=>Value[i];

public static A047505Inst Instance=new A047505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047504
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,10L,11L,12L,13L,15L,17L,18L,19L,20L,21L,23L,25L,26L,27L,28L,29L,31L,33L,34L,35L,36L,37L,39L,41L,42L,43L,44L,45L,47L,49L,50L,51L,52L,53L,55L,57L,58L,59L,60L,61L,63L,65L,66L,67L,68L,69L,71L,73L,74L,75L,76L,77L,79L,81L,82L,83L,84L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047504Inst : IEnumerable<long>
{
public static readonly long[] Value=A047504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047504.Bytes);
public long this[int i]=>Value[i];

public static A047504Inst Instance=new A047504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047503
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,7L,8L,10L,11L,12L,13L,15L,16L,18L,19L,20L,21L,23L,24L,26L,27L,28L,29L,31L,32L,34L,35L,36L,37L,39L,40L,42L,43L,44L,45L,47L,48L,50L,51L,52L,53L,55L,56L,58L,59L,60L,61L,63L,64L,66L,67L,68L,69L,71L,72L,74L,75L,76L,77L,79L,80L,82L,83L,84L,85L,87L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047503Inst : IEnumerable<long>
{
public static readonly long[] Value=A047503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047503.Bytes);
public long this[int i]=>Value[i];

public static A047503Inst Instance=new A047503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047502
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,10L,11L,12L,13L,15L,18L,19L,20L,21L,23L,26L,27L,28L,29L,31L,34L,35L,36L,37L,39L,42L,43L,44L,45L,47L,50L,51L,52L,53L,55L,58L,59L,60L,61L,63L,66L,67L,68L,69L,71L,74L,75L,76L,77L,79L,82L,83L,84L,85L,87L,90L,91L,92L,93L,95L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047502Inst : IEnumerable<long>
{
public static readonly long[] Value=A047502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047502.Bytes);
public long this[int i]=>Value[i];

public static A047502Inst Instance=new A047502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047501
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,9L,11L,12L,13L,15L,17L,19L,20L,21L,23L,25L,27L,28L,29L,31L,33L,35L,36L,37L,39L,41L,43L,44L,45L,47L,49L,51L,52L,53L,55L,57L,59L,60L,61L,63L,65L,67L,68L,69L,71L,73L,75L,76L,77L,79L,81L,83L,84L,85L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047501Inst : IEnumerable<long>
{
public static readonly long[] Value=A047501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047501.Bytes);
public long this[int i]=>Value[i];

public static A047501Inst Instance=new A047501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047500
{
public static readonly long[] Value={ 0L,3L,4L,5L,7L,8L,11L,12L,13L,15L,16L,19L,20L,21L,23L,24L,27L,28L,29L,31L,32L,35L,36L,37L,39L,40L,43L,44L,45L,47L,48L,51L,52L,53L,55L,56L,59L,60L,61L,63L,64L,67L,68L,69L,71L,72L,75L,76L,77L,79L,80L,83L,84L,85L,87L,88L,91L,92L,93L,95L,96L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047500Inst : IEnumerable<long>
{
public static readonly long[] Value=A047500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047500.Bytes);
public long this[int i]=>Value[i];

public static A047500Inst Instance=new A047500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047499
{
public static readonly long[] Value={ 3L,4L,5L,7L,11L,12L,13L,15L,19L,20L,21L,23L,27L,28L,29L,31L,35L,36L,37L,39L,43L,44L,45L,47L,51L,52L,53L,55L,59L,60L,61L,63L,67L,68L,69L,71L,75L,76L,77L,79L,83L,84L,85L,87L,91L,92L,93L,95L,99L,100L,101L,103L,107L,108L,109L,111L,115L,116L,117L,119L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047499Inst : IEnumerable<long>
{
public static readonly long[] Value=A047499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047499.Bytes);
public long this[int i]=>Value[i];

public static A047499Inst Instance=new A047499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047498
{
public static readonly long[] Value={ 0L,1L,2L,4L,5L,7L,8L,9L,10L,12L,13L,15L,16L,17L,18L,20L,21L,23L,24L,25L,26L,28L,29L,31L,32L,33L,34L,36L,37L,39L,40L,41L,42L,44L,45L,47L,48L,49L,50L,52L,53L,55L,56L,57L,58L,60L,61L,63L,64L,65L,66L,68L,69L,71L,72L,73L,74L,76L,77L,79L,80L,81L,82L,84L,85L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047498Inst : IEnumerable<long>
{
public static readonly long[] Value=A047498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047498.Bytes);
public long this[int i]=>Value[i];

public static A047498Inst Instance=new A047498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047497
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,12L,13L,15L,17L,18L,20L,21L,23L,25L,26L,28L,29L,31L,33L,34L,36L,37L,39L,41L,42L,44L,45L,47L,49L,50L,52L,53L,55L,57L,58L,60L,61L,63L,65L,66L,68L,69L,71L,73L,74L,76L,77L,79L,81L,82L,84L,85L,87L,89L,90L,92L,93L,95L,97L,98L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047497Inst : IEnumerable<long>
{
public static readonly long[] Value=A047497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047497.Bytes);
public long this[int i]=>Value[i];

public static A047497Inst Instance=new A047497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047496
{
public static readonly long[] Value={ 0L,2L,4L,5L,7L,8L,10L,12L,13L,15L,16L,18L,20L,21L,23L,24L,26L,28L,29L,31L,32L,34L,36L,37L,39L,40L,42L,44L,45L,47L,48L,50L,52L,53L,55L,56L,58L,60L,61L,63L,64L,66L,68L,69L,71L,72L,74L,76L,77L,79L,80L,82L,84L,85L,87L,88L,90L,92L,93L,95L,96L,98L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047496Inst : IEnumerable<long>
{
public static readonly long[] Value=A047496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047496.Bytes);
public long this[int i]=>Value[i];

public static A047496Inst Instance=new A047496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047495
{
public static readonly long[] Value={ 2L,4L,5L,7L,10L,12L,13L,15L,18L,20L,21L,23L,26L,28L,29L,31L,34L,36L,37L,39L,42L,44L,45L,47L,50L,52L,53L,55L,58L,60L,61L,63L,66L,68L,69L,71L,74L,76L,77L,79L,82L,84L,85L,87L,90L,92L,93L,95L,98L,100L,101L,103L,106L,108L,109L,111L,114L,116L,117L,119L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047495Inst : IEnumerable<long>
{
public static readonly long[] Value=A047495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047495.Bytes);
public long this[int i]=>Value[i];

public static A047495Inst Instance=new A047495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047494
{
public static readonly long[] Value={ 0L,1L,4L,5L,7L,8L,9L,12L,13L,15L,16L,17L,20L,21L,23L,24L,25L,28L,29L,31L,32L,33L,36L,37L,39L,40L,41L,44L,45L,47L,48L,49L,52L,53L,55L,56L,57L,60L,61L,63L,64L,65L,68L,69L,71L,72L,73L,76L,77L,79L,80L,81L,84L,85L,87L,88L,89L,92L,93L,95L,96L,97L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047494Inst : IEnumerable<long>
{
public static readonly long[] Value=A047494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047494.Bytes);
public long this[int i]=>Value[i];

public static A047494Inst Instance=new A047494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047493
{
public static readonly long[] Value={ 1L,4L,5L,7L,9L,12L,13L,15L,17L,20L,21L,23L,25L,28L,29L,31L,33L,36L,37L,39L,41L,44L,45L,47L,49L,52L,53L,55L,57L,60L,61L,63L,65L,68L,69L,71L,73L,76L,77L,79L,81L,84L,85L,87L,89L,92L,93L,95L,97L,100L,101L,103L,105L,108L,109L,111L,113L,116L,117L,119L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047493Inst : IEnumerable<long>
{
public static readonly long[] Value=A047493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047493.Bytes);
public long this[int i]=>Value[i];

public static A047493Inst Instance=new A047493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047492
{
public static readonly long[] Value={ 0L,4L,5L,7L,8L,12L,13L,15L,16L,20L,21L,23L,24L,28L,29L,31L,32L,36L,37L,39L,40L,44L,45L,47L,48L,52L,53L,55L,56L,60L,61L,63L,64L,68L,69L,71L,72L,76L,77L,79L,80L,84L,85L,87L,88L,92L,93L,95L,96L,100L,101L,103L,104L,108L,109L,111L,112L,116L,117L,119L,120L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047492Inst : IEnumerable<long>
{
public static readonly long[] Value=A047492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047492.Bytes);
public long this[int i]=>Value[i];

public static A047492Inst Instance=new A047492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047491
{
public static readonly long[] Value={ 4L,5L,7L,12L,13L,15L,20L,21L,23L,28L,29L,31L,36L,37L,39L,44L,45L,47L,52L,53L,55L,60L,61L,63L,68L,69L,71L,76L,77L,79L,84L,85L,87L,92L,93L,95L,100L,101L,103L,108L,109L,111L,116L,117L,119L,124L,125L,127L,132L,133L,135L,140L,141L,143L,148L,149L,151L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047491Inst : IEnumerable<long>
{
public static readonly long[] Value=A047491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047491.Bytes);
public long this[int i]=>Value[i];

public static A047491Inst Instance=new A047491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047490
{
public static readonly long[] Value={ 0L,1L,2L,3L,5L,7L,8L,9L,10L,11L,13L,15L,16L,17L,18L,19L,21L,23L,24L,25L,26L,27L,29L,31L,32L,33L,34L,35L,37L,39L,40L,41L,42L,43L,45L,47L,48L,49L,50L,51L,53L,55L,56L,57L,58L,59L,61L,63L,64L,65L,66L,67L,69L,71L,72L,73L,74L,75L,77L,79L,80L,81L,82L,83L,85L,87L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047490Inst : IEnumerable<long>
{
public static readonly long[] Value=A047490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047490.Bytes);
public long this[int i]=>Value[i];

public static A047490Inst Instance=new A047490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047489
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,9L,10L,11L,13L,15L,17L,18L,19L,21L,23L,25L,26L,27L,29L,31L,33L,34L,35L,37L,39L,41L,42L,43L,45L,47L,49L,50L,51L,53L,55L,57L,58L,59L,61L,63L,65L,66L,67L,69L,71L,73L,74L,75L,77L,79L,81L,82L,83L,85L,87L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047489Inst : IEnumerable<long>
{
public static readonly long[] Value=A047489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047489.Bytes);
public long this[int i]=>Value[i];

public static A047489Inst Instance=new A047489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047488
{
public static readonly long[] Value={ 0L,2L,3L,5L,7L,8L,10L,11L,13L,15L,16L,18L,19L,21L,23L,24L,26L,27L,29L,31L,32L,34L,35L,37L,39L,40L,42L,43L,45L,47L,48L,50L,51L,53L,55L,56L,58L,59L,61L,63L,64L,66L,67L,69L,71L,72L,74L,75L,77L,79L,80L,82L,83L,85L,87L,88L,90L,91L,93L,95L,96L,98L,99L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047488Inst : IEnumerable<long>
{
public static readonly long[] Value=A047488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047488.Bytes);
public long this[int i]=>Value[i];

public static A047488Inst Instance=new A047488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047487
{
public static readonly long[] Value={ 2L,3L,5L,7L,10L,11L,13L,15L,18L,19L,21L,23L,26L,27L,29L,31L,34L,35L,37L,39L,42L,43L,45L,47L,50L,51L,53L,55L,58L,59L,61L,63L,66L,67L,69L,71L,74L,75L,77L,79L,82L,83L,85L,87L,90L,91L,93L,95L,98L,99L,101L,103L,106L,107L,109L,111L,114L,115L,117L,119L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047487Inst : IEnumerable<long>
{
public static readonly long[] Value=A047487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047487.Bytes);
public long this[int i]=>Value[i];

public static A047487Inst Instance=new A047487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047486
{
public static readonly long[] Value={ 0L,1L,3L,5L,7L,8L,9L,11L,13L,15L,16L,17L,19L,21L,23L,24L,25L,27L,29L,31L,32L,33L,35L,37L,39L,40L,41L,43L,45L,47L,48L,49L,51L,53L,55L,56L,57L,59L,61L,63L,64L,65L,67L,69L,71L,72L,73L,75L,77L,79L,80L,81L,83L,85L,87L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047486Inst : IEnumerable<long>
{
public static readonly long[] Value=A047486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047486.Bytes);
public long this[int i]=>Value[i];

public static A047486Inst Instance=new A047486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047485
{
public static readonly long[] Value={ 0L,3L,5L,7L,8L,11L,13L,15L,16L,19L,21L,23L,24L,27L,29L,31L,32L,35L,37L,39L,40L,43L,45L,47L,48L,51L,53L,55L,56L,59L,61L,63L,64L,67L,69L,71L,72L,75L,77L,79L,80L,83L,85L,87L,88L,91L,93L,95L,96L,99L,101L,103L,104L,107L,109L,111L,112L,115L,117L,119L,120L,123L,125L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047485Inst : IEnumerable<long>
{
public static readonly long[] Value=A047485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047485.Bytes);
public long this[int i]=>Value[i];

public static A047485Inst Instance=new A047485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047468
{
public static readonly long[] Value={ 1L,2L,9L,10L,17L,18L,25L,26L,33L,34L,41L,42L,49L,50L,57L,58L,65L,66L,73L,74L,81L,82L,89L,90L,97L,98L,105L,106L,113L,114L,121L,122L,129L,130L,137L,138L,145L,146L,153L,154L,161L,162L,169L,170L,177L,178L,185L,186L,193L,194L,201L,202L,209L,210L,217L,218L,225L,226L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047468Inst : IEnumerable<long>
{
public static readonly long[] Value=A047468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047468.Bytes);
public long this[int i]=>Value[i];

public static A047468Inst Instance=new A047468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047467
{
public static readonly long[] Value={ 0L,2L,8L,10L,16L,18L,24L,26L,32L,34L,40L,42L,48L,50L,56L,58L,64L,66L,72L,74L,80L,82L,88L,90L,96L,98L,104L,106L,112L,114L,120L,122L,128L,130L,136L,138L,144L,146L,152L,154L,160L,162L,168L,170L,176L,178L,184L,186L,192L,194L,200L,202L,208L,210L,216L,218L,224L,226L,232L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047467Inst : IEnumerable<long>
{
public static readonly long[] Value=A047467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047467.Bytes);
public long this[int i]=>Value[i];

public static A047467Inst Instance=new A047467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047466
{
public static readonly long[] Value={ 0L,1L,2L,4L,8L,9L,10L,12L,16L,17L,18L,20L,24L,25L,26L,28L,32L,33L,34L,36L,40L,41L,42L,44L,48L,49L,50L,52L,56L,57L,58L,60L,64L,65L,66L,68L,72L,73L,74L,76L,80L,81L,82L,84L,88L,89L,90L,92L,96L,97L,98L,100L,104L,105L,106L,108L,112L,113L,114L,116L,120L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047466Inst : IEnumerable<long>
{
public static readonly long[] Value=A047466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047466.Bytes);
public long this[int i]=>Value[i];

public static A047466Inst Instance=new A047466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047465
{
public static readonly long[] Value={ 1L,2L,4L,9L,10L,12L,17L,18L,20L,25L,26L,28L,33L,34L,36L,41L,42L,44L,49L,50L,52L,57L,58L,60L,65L,66L,68L,73L,74L,76L,81L,82L,84L,89L,90L,92L,97L,98L,100L,105L,106L,108L,113L,114L,116L,121L,122L,124L,129L,130L,132L,137L,138L,140L,145L,146L,148L,153L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047465Inst : IEnumerable<long>
{
public static readonly long[] Value=A047465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047465.Bytes);
public long this[int i]=>Value[i];

public static A047465Inst Instance=new A047465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047464
{
public static readonly long[] Value={ 0L,2L,4L,8L,10L,12L,16L,18L,20L,24L,26L,28L,32L,34L,36L,40L,42L,44L,48L,50L,52L,56L,58L,60L,64L,66L,68L,72L,74L,76L,80L,82L,84L,88L,90L,92L,96L,98L,100L,104L,106L,108L,112L,114L,116L,120L,122L,124L,128L,130L,132L,136L,138L,140L,144L,146L,148L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047464Inst : IEnumerable<long>
{
public static readonly long[] Value=A047464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047464.Bytes);
public long this[int i]=>Value[i];

public static A047464Inst Instance=new A047464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047463
{
public static readonly long[] Value={ 2L,4L,10L,12L,18L,20L,26L,28L,34L,36L,42L,44L,50L,52L,58L,60L,66L,68L,74L,76L,82L,84L,90L,92L,98L,100L,106L,108L,114L,116L,122L,124L,130L,132L,138L,140L,146L,148L,154L,156L,162L,164L,170L,172L,178L,180L,186L,188L,194L,196L,202L,204L,210L,212L,218L,220L,226L,228L,234L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047463Inst : IEnumerable<long>
{
public static readonly long[] Value=A047463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047463.Bytes);
public long this[int i]=>Value[i];

public static A047463Inst Instance=new A047463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047462
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,12L,16L,17L,20L,24L,25L,28L,32L,33L,36L,40L,41L,44L,48L,49L,52L,56L,57L,60L,64L,65L,68L,72L,73L,76L,80L,81L,84L,88L,89L,92L,96L,97L,100L,104L,105L,108L,112L,113L,116L,120L,121L,124L,128L,129L,132L,136L,137L,140L,144L,145L,148L,152L,153L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047462Inst : IEnumerable<long>
{
public static readonly long[] Value=A047462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047462.Bytes);
public long this[int i]=>Value[i];

public static A047462Inst Instance=new A047462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047461
{
public static readonly long[] Value={ 1L,4L,9L,12L,17L,20L,25L,28L,33L,36L,41L,44L,49L,52L,57L,60L,65L,68L,73L,76L,81L,84L,89L,92L,97L,100L,105L,108L,113L,116L,121L,124L,129L,132L,137L,140L,145L,148L,153L,156L,161L,164L,169L,172L,177L,180L,185L,188L,193L,196L,201L,204L,209L,212L,217L,220L,225L,228L,233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047461Inst : IEnumerable<long>
{
public static readonly long[] Value=A047461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047461.Bytes);
public long this[int i]=>Value[i];

public static A047461Inst Instance=new A047461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047460
{
public static readonly long[] Value={ 0L,1L,3L,4L,8L,9L,11L,12L,16L,17L,19L,20L,24L,25L,27L,28L,32L,33L,35L,36L,40L,41L,43L,44L,48L,49L,51L,52L,56L,57L,59L,60L,64L,65L,67L,68L,72L,73L,75L,76L,80L,81L,83L,84L,88L,89L,91L,92L,96L,97L,99L,100L,104L,105L,107L,108L,112L,113L,115L,116L,120L,121L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047460Inst : IEnumerable<long>
{
public static readonly long[] Value=A047460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047460.Bytes);
public long this[int i]=>Value[i];

public static A047460Inst Instance=new A047460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047459
{
public static readonly long[] Value={ 1L,3L,4L,9L,11L,12L,17L,19L,20L,25L,27L,28L,33L,35L,36L,41L,43L,44L,49L,51L,52L,57L,59L,60L,65L,67L,68L,73L,75L,76L,81L,83L,84L,89L,91L,92L,97L,99L,100L,105L,107L,108L,113L,115L,116L,121L,123L,124L,129L,131L,132L,137L,139L,140L,145L,147L,148L,153L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047459Inst : IEnumerable<long>
{
public static readonly long[] Value=A047459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047459.Bytes);
public long this[int i]=>Value[i];

public static A047459Inst Instance=new A047459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047458
{
public static readonly long[] Value={ 0L,3L,4L,8L,11L,12L,16L,19L,20L,24L,27L,28L,32L,35L,36L,40L,43L,44L,48L,51L,52L,56L,59L,60L,64L,67L,68L,72L,75L,76L,80L,83L,84L,88L,91L,92L,96L,99L,100L,104L,107L,108L,112L,115L,116L,120L,123L,124L,128L,131L,132L,136L,139L,140L,144L,147L,148L,152L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047458Inst : IEnumerable<long>
{
public static readonly long[] Value=A047458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047458.Bytes);
public long this[int i]=>Value[i];

public static A047458Inst Instance=new A047458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047457
{
public static readonly long[] Value={ 3L,4L,11L,12L,19L,20L,27L,28L,35L,36L,43L,44L,51L,52L,59L,60L,67L,68L,75L,76L,83L,84L,91L,92L,99L,100L,107L,108L,115L,116L,123L,124L,131L,132L,139L,140L,147L,148L,155L,156L,163L,164L,171L,172L,179L,180L,187L,188L,195L,196L,203L,204L,211L,212L,219L,220L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047457Inst : IEnumerable<long>
{
public static readonly long[] Value=A047457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047457.Bytes);
public long this[int i]=>Value[i];

public static A047457Inst Instance=new A047457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047456
{
public static readonly long[] Value={ 0L,2L,3L,4L,8L,10L,11L,12L,16L,18L,19L,20L,24L,26L,27L,28L,32L,34L,35L,36L,40L,42L,43L,44L,48L,50L,51L,52L,56L,58L,59L,60L,64L,66L,67L,68L,72L,74L,75L,76L,80L,82L,83L,84L,88L,90L,91L,92L,96L,98L,99L,100L,104L,106L,107L,108L,112L,114L,115L,116L,120L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047456Inst : IEnumerable<long>
{
public static readonly long[] Value=A047456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047456.Bytes);
public long this[int i]=>Value[i];

public static A047456Inst Instance=new A047456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047455
{
public static readonly long[] Value={ 2L,3L,4L,10L,11L,12L,18L,19L,20L,26L,27L,28L,34L,35L,36L,42L,43L,44L,50L,51L,52L,58L,59L,60L,66L,67L,68L,74L,75L,76L,82L,83L,84L,90L,91L,92L,98L,99L,100L,106L,107L,108L,114L,115L,116L,122L,123L,124L,130L,131L,132L,138L,139L,140L,146L,147L,148L,154L,155L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047455Inst : IEnumerable<long>
{
public static readonly long[] Value=A047455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047455.Bytes);
public long this[int i]=>Value[i];

public static A047455Inst Instance=new A047455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047454
{
public static readonly long[] Value={ 1L,2L,3L,4L,9L,10L,11L,12L,17L,18L,19L,20L,25L,26L,27L,28L,33L,34L,35L,36L,41L,42L,43L,44L,49L,50L,51L,52L,57L,58L,59L,60L,65L,66L,67L,68L,73L,74L,75L,76L,81L,82L,83L,84L,89L,90L,91L,92L,97L,98L,99L,100L,105L,106L,107L,108L,113L,114L,115L,116L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047454Inst : IEnumerable<long>
{
public static readonly long[] Value=A047454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047454.Bytes);
public long this[int i]=>Value[i];

public static A047454Inst Instance=new A047454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047453
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,8L,9L,10L,11L,12L,16L,17L,18L,19L,20L,24L,25L,26L,27L,28L,32L,33L,34L,35L,36L,40L,41L,42L,43L,44L,48L,49L,50L,51L,52L,56L,57L,58L,59L,60L,64L,65L,66L,67L,68L,72L,73L,74L,75L,76L,80L,81L,82L,83L,84L,88L,89L,90L,91L,92L,96L,97L,98L,99L,100L,104L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047453Inst : IEnumerable<long>
{
public static readonly long[] Value=A047453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047453.Bytes);
public long this[int i]=>Value[i];

public static A047453Inst Instance=new A047453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047436
{
public static readonly long[] Value={ 5L,6L,13L,14L,21L,22L,29L,30L,37L,38L,45L,46L,53L,54L,61L,62L,69L,70L,77L,78L,85L,86L,93L,94L,101L,102L,109L,110L,117L,118L,125L,126L,133L,134L,141L,142L,149L,150L,157L,158L,165L,166L,173L,174L,181L,182L,189L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047436Inst : IEnumerable<long>
{
public static readonly long[] Value=A047436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047436.Bytes);
public long this[int i]=>Value[i];

public static A047436Inst Instance=new A047436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047435
{
public static readonly long[] Value={ 1L,2L,4L,5L,6L,9L,10L,12L,13L,14L,17L,18L,20L,21L,22L,25L,26L,28L,29L,30L,33L,34L,36L,37L,38L,41L,42L,44L,45L,46L,49L,50L,52L,53L,54L,57L,58L,60L,61L,62L,65L,66L,68L,69L,70L,73L,74L,76L,77L,78L,81L,82L,84L,85L,86L,89L,90L,92L,93L,94L,97L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047435Inst : IEnumerable<long>
{
public static readonly long[] Value=A047435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047435.Bytes);
public long this[int i]=>Value[i];

public static A047435Inst Instance=new A047435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047434
{
public static readonly long[] Value={ 0L,2L,4L,5L,6L,8L,10L,12L,13L,14L,16L,18L,20L,21L,22L,24L,26L,28L,29L,30L,32L,34L,36L,37L,38L,40L,42L,44L,45L,46L,48L,50L,52L,53L,54L,56L,58L,60L,61L,62L,64L,66L,68L,69L,70L,72L,74L,76L,77L,78L,80L,82L,84L,85L,86L,88L,90L,92L,93L,94L,96L,98L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047434Inst : IEnumerable<long>
{
public static readonly long[] Value=A047434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047434.Bytes);
public long this[int i]=>Value[i];

public static A047434Inst Instance=new A047434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047433
{
public static readonly long[] Value={ 2L,4L,5L,6L,10L,12L,13L,14L,18L,20L,21L,22L,26L,28L,29L,30L,34L,36L,37L,38L,42L,44L,45L,46L,50L,52L,53L,54L,58L,60L,61L,62L,66L,68L,69L,70L,74L,76L,77L,78L,82L,84L,85L,86L,90L,92L,93L,94L,98L,100L,101L,102L,106L,108L,109L,110L,114L,116L,117L,118L,122L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047433Inst : IEnumerable<long>
{
public static readonly long[] Value=A047433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047433.Bytes);
public long this[int i]=>Value[i];

public static A047433Inst Instance=new A047433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047432
{
public static readonly long[] Value={ 0L,1L,4L,5L,6L,8L,9L,12L,13L,14L,16L,17L,20L,21L,22L,24L,25L,28L,29L,30L,32L,33L,36L,37L,38L,40L,41L,44L,45L,46L,48L,49L,52L,53L,54L,56L,57L,60L,61L,62L,64L,65L,68L,69L,70L,72L,73L,76L,77L,78L,80L,81L,84L,85L,86L,88L,89L,92L,93L,94L,96L,97L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047432Inst : IEnumerable<long>
{
public static readonly long[] Value=A047432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047432.Bytes);
public long this[int i]=>Value[i];

public static A047432Inst Instance=new A047432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047431
{
public static readonly long[] Value={ 1L,4L,5L,6L,9L,12L,13L,14L,17L,20L,21L,22L,25L,28L,29L,30L,33L,36L,37L,38L,41L,44L,45L,46L,49L,52L,53L,54L,57L,60L,61L,62L,65L,68L,69L,70L,73L,76L,77L,78L,81L,84L,85L,86L,89L,92L,93L,94L,97L,100L,101L,102L,105L,108L,109L,110L,113L,116L,117L,118L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047431Inst : IEnumerable<long>
{
public static readonly long[] Value=A047431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047431.Bytes);
public long this[int i]=>Value[i];

public static A047431Inst Instance=new A047431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047430
{
public static readonly long[] Value={ 0L,4L,5L,6L,8L,12L,13L,14L,16L,20L,21L,22L,24L,28L,29L,30L,32L,36L,37L,38L,40L,44L,45L,46L,48L,52L,53L,54L,56L,60L,61L,62L,64L,68L,69L,70L,72L,76L,77L,78L,80L,84L,85L,86L,88L,92L,93L,94L,96L,100L,101L,102L,104L,108L,109L,110L,112L,116L,117L,118L,120L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047430Inst : IEnumerable<long>
{
public static readonly long[] Value=A047430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047430.Bytes);
public long this[int i]=>Value[i];

public static A047430Inst Instance=new A047430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047429
{
public static readonly long[] Value={ 4L,5L,6L,12L,13L,14L,20L,21L,22L,28L,29L,30L,36L,37L,38L,44L,45L,46L,52L,53L,54L,60L,61L,62L,68L,69L,70L,76L,77L,78L,84L,85L,86L,92L,93L,94L,100L,101L,102L,108L,109L,110L,116L,117L,118L,124L,125L,126L,132L,133L,134L,140L,141L,142L,148L,149L,150L,156L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047429Inst : IEnumerable<long>
{
public static readonly long[] Value=A047429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047429.Bytes);
public long this[int i]=>Value[i];

public static A047429Inst Instance=new A047429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047428
{
public static readonly long[] Value={ 0L,1L,3L,4L,5L,6L,8L,9L,11L,12L,13L,14L,16L,17L,19L,20L,21L,22L,24L,25L,27L,28L,29L,30L,32L,33L,35L,36L,37L,38L,40L,41L,43L,44L,45L,46L,48L,49L,51L,52L,53L,54L,56L,57L,59L,60L,61L,62L,64L,65L,67L,68L,69L,70L,72L,73L,75L,76L,77L,78L,80L,81L,83L,84L,85L,86L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047428Inst : IEnumerable<long>
{
public static readonly long[] Value=A047428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047428.Bytes);
public long this[int i]=>Value[i];

public static A047428Inst Instance=new A047428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047427
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,9L,11L,12L,13L,14L,17L,19L,20L,21L,22L,25L,27L,28L,29L,30L,33L,35L,36L,37L,38L,41L,43L,44L,45L,46L,49L,51L,52L,53L,54L,57L,59L,60L,61L,62L,65L,67L,68L,69L,70L,73L,75L,76L,77L,78L,81L,83L,84L,85L,86L,89L,91L,92L,93L,94L,97L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047427Inst : IEnumerable<long>
{
public static readonly long[] Value=A047427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047427.Bytes);
public long this[int i]=>Value[i];

public static A047427Inst Instance=new A047427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047426
{
public static readonly long[] Value={ 0L,3L,4L,5L,6L,8L,11L,12L,13L,14L,16L,19L,20L,21L,22L,24L,27L,28L,29L,30L,32L,35L,36L,37L,38L,40L,43L,44L,45L,46L,48L,51L,52L,53L,54L,56L,59L,60L,61L,62L,64L,67L,68L,69L,70L,72L,75L,76L,77L,78L,80L,83L,84L,85L,86L,88L,91L,92L,93L,94L,96L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047426Inst : IEnumerable<long>
{
public static readonly long[] Value=A047426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047426.Bytes);
public long this[int i]=>Value[i];

public static A047426Inst Instance=new A047426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047425
{
public static readonly long[] Value={ 3L,4L,5L,6L,11L,12L,13L,14L,19L,20L,21L,22L,27L,28L,29L,30L,35L,36L,37L,38L,43L,44L,45L,46L,51L,52L,53L,54L,59L,60L,61L,62L,67L,68L,69L,70L,75L,76L,77L,78L,83L,84L,85L,86L,91L,92L,93L,94L,99L,100L,101L,102L,107L,108L,109L,110L,115L,116L,117L,118L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047425Inst : IEnumerable<long>
{
public static readonly long[] Value=A047425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047425.Bytes);
public long this[int i]=>Value[i];

public static A047425Inst Instance=new A047425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047424
{
public static readonly long[] Value={ 0L,2L,3L,4L,5L,6L,8L,10L,11L,12L,13L,14L,16L,18L,19L,20L,21L,22L,24L,26L,27L,28L,29L,30L,32L,34L,35L,36L,37L,38L,40L,42L,43L,44L,45L,46L,48L,50L,51L,52L,53L,54L,56L,58L,59L,60L,61L,62L,64L,66L,67L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047424Inst : IEnumerable<long>
{
public static readonly long[] Value=A047424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047424.Bytes);
public long this[int i]=>Value[i];

public static A047424Inst Instance=new A047424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047423
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,10L,11L,12L,13L,14L,18L,19L,20L,21L,22L,26L,27L,28L,29L,30L,34L,35L,36L,37L,38L,42L,43L,44L,45L,46L,50L,51L,52L,53L,54L,58L,59L,60L,61L,62L,66L,67L,68L,69L,70L,74L,75L,76L,77L,78L,82L,83L,84L,85L,86L,90L,91L,92L,93L,94L,98L,99L,100L,101L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047423Inst : IEnumerable<long>
{
public static readonly long[] Value=A047423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047423.Bytes);
public long this[int i]=>Value[i];

public static A047423Inst Instance=new A047423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047422
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,9L,10L,11L,12L,13L,14L,17L,18L,19L,20L,21L,22L,25L,26L,27L,28L,29L,30L,33L,34L,35L,36L,37L,38L,41L,42L,43L,44L,45L,46L,49L,50L,51L,52L,53L,54L,57L,58L,59L,60L,61L,62L,65L,66L,67L,68L,69L,70L,73L,74L,75L,76L,77L,78L,81L,82L,83L,84L,85L,86L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047422Inst : IEnumerable<long>
{
public static readonly long[] Value=A047422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047422.Bytes);
public long this[int i]=>Value[i];

public static A047422Inst Instance=new A047422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047421
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,13L,14L,16L,17L,18L,19L,20L,21L,22L,24L,25L,26L,27L,28L,29L,30L,32L,33L,34L,35L,36L,37L,38L,40L,41L,42L,43L,44L,45L,46L,48L,49L,50L,51L,52L,53L,54L,56L,57L,58L,59L,60L,61L,62L,64L,65L,66L,67L,68L,69L,70L,72L,73L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047421Inst : IEnumerable<long>
{
public static readonly long[] Value=A047421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047421.Bytes);
public long this[int i]=>Value[i];

public static A047421Inst Instance=new A047421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047420
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,6L,8L,9L,10L,11L,12L,14L,16L,17L,18L,19L,20L,22L,24L,25L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,40L,41L,42L,43L,44L,46L,48L,49L,50L,51L,52L,54L,56L,57L,58L,59L,60L,62L,64L,65L,66L,67L,68L,70L,72L,73L,74L,75L,76L,78L,80L,81L,82L,83L,84L,86L,88L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047420Inst : IEnumerable<long>
{
public static readonly long[] Value=A047420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047420.Bytes);
public long this[int i]=>Value[i];

public static A047420Inst Instance=new A047420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047419
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,10L,11L,12L,14L,17L,18L,19L,20L,22L,25L,26L,27L,28L,30L,33L,34L,35L,36L,38L,41L,42L,43L,44L,46L,49L,50L,51L,52L,54L,57L,58L,59L,60L,62L,65L,66L,67L,68L,70L,73L,74L,75L,76L,78L,81L,82L,83L,84L,86L,89L,90L,91L,92L,94L,97L,98L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047419Inst : IEnumerable<long>
{
public static readonly long[] Value=A047419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047419.Bytes);
public long this[int i]=>Value[i];

public static A047419Inst Instance=new A047419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047418
{
public static readonly long[] Value={ 0L,2L,3L,4L,6L,8L,10L,11L,12L,14L,16L,18L,19L,20L,22L,24L,26L,27L,28L,30L,32L,34L,35L,36L,38L,40L,42L,43L,44L,46L,48L,50L,51L,52L,54L,56L,58L,59L,60L,62L,64L,66L,67L,68L,70L,72L,74L,75L,76L,78L,80L,82L,83L,84L,86L,88L,90L,91L,92L,94L,96L,98L,99L,100L,102L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047418Inst : IEnumerable<long>
{
public static readonly long[] Value=A047418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047418.Bytes);
public long this[int i]=>Value[i];

public static A047418Inst Instance=new A047418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047417
{
public static readonly long[] Value={ 2L,3L,4L,6L,10L,11L,12L,14L,18L,19L,20L,22L,26L,27L,28L,30L,34L,35L,36L,38L,42L,43L,44L,46L,50L,51L,52L,54L,58L,59L,60L,62L,66L,67L,68L,70L,74L,75L,76L,78L,82L,83L,84L,86L,90L,91L,92L,94L,98L,99L,100L,102L,106L,107L,108L,110L,114L,115L,116L,118L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047417Inst : IEnumerable<long>
{
public static readonly long[] Value=A047417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047417.Bytes);
public long this[int i]=>Value[i];

public static A047417Inst Instance=new A047417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047416
{
public static readonly long[] Value={ 0L,1L,3L,4L,6L,8L,9L,11L,12L,14L,16L,17L,19L,20L,22L,24L,25L,27L,28L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,49L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,72L,73L,75L,76L,78L,80L,81L,83L,84L,86L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047416Inst : IEnumerable<long>
{
public static readonly long[] Value=A047416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047416.Bytes);
public long this[int i]=>Value[i];

public static A047416Inst Instance=new A047416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047415
{
public static readonly long[] Value={ 1L,3L,4L,6L,9L,11L,12L,14L,17L,19L,20L,22L,25L,27L,28L,30L,33L,35L,36L,38L,41L,43L,44L,46L,49L,51L,52L,54L,57L,59L,60L,62L,65L,67L,68L,70L,73L,75L,76L,78L,81L,83L,84L,86L,89L,91L,92L,94L,97L,99L,100L,102L,105L,107L,108L,110L,113L,115L,116L,118L,121L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047415Inst : IEnumerable<long>
{
public static readonly long[] Value=A047415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047415.Bytes);
public long this[int i]=>Value[i];

public static A047415Inst Instance=new A047415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047414
{
public static readonly long[] Value={ 0L,3L,4L,6L,8L,11L,12L,14L,16L,19L,20L,22L,24L,27L,28L,30L,32L,35L,36L,38L,40L,43L,44L,46L,48L,51L,52L,54L,56L,59L,60L,62L,64L,67L,68L,70L,72L,75L,76L,78L,80L,83L,84L,86L,88L,91L,92L,94L,96L,99L,100L,102L,104L,107L,108L,110L,112L,115L,116L,118L,120L,123L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047414Inst : IEnumerable<long>
{
public static readonly long[] Value=A047414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047414.Bytes);
public long this[int i]=>Value[i];

public static A047414Inst Instance=new A047414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047413
{
public static readonly long[] Value={ 3L,4L,6L,11L,12L,14L,19L,20L,22L,27L,28L,30L,35L,36L,38L,43L,44L,46L,51L,52L,54L,59L,60L,62L,67L,68L,70L,75L,76L,78L,83L,84L,86L,91L,92L,94L,99L,100L,102L,107L,108L,110L,115L,116L,118L,123L,124L,126L,131L,132L,134L,139L,140L,142L,147L,148L,150L,155L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047413Inst : IEnumerable<long>
{
public static readonly long[] Value=A047413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047413.Bytes);
public long this[int i]=>Value[i];

public static A047413Inst Instance=new A047413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047412
{
public static readonly long[] Value={ 0L,1L,2L,4L,6L,8L,9L,10L,12L,14L,16L,17L,18L,20L,22L,24L,25L,26L,28L,30L,32L,33L,34L,36L,38L,40L,41L,42L,44L,46L,48L,49L,50L,52L,54L,56L,57L,58L,60L,62L,64L,65L,66L,68L,70L,72L,73L,74L,76L,78L,80L,81L,82L,84L,86L,88L,89L,90L,92L,94L,96L,97L,98L,100L,102L,104L,105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047412Inst : IEnumerable<long>
{
public static readonly long[] Value=A047412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047412.Bytes);
public long this[int i]=>Value[i];

public static A047412Inst Instance=new A047412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047411
{
public static readonly long[] Value={ 1L,2L,4L,6L,9L,10L,12L,14L,17L,18L,20L,22L,25L,26L,28L,30L,33L,34L,36L,38L,41L,42L,44L,46L,49L,50L,52L,54L,57L,58L,60L,62L,65L,66L,68L,70L,73L,74L,76L,78L,81L,82L,84L,86L,89L,90L,92L,94L,97L,98L,100L,102L,105L,106L,108L,110L,113L,114L,116L,118L,121L,122L,124L,126L,129L,130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047411Inst : IEnumerable<long>
{
public static readonly long[] Value=A047411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047411.Bytes);
public long this[int i]=>Value[i];

public static A047411Inst Instance=new A047411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047410
{
public static readonly long[] Value={ 2L,4L,6L,10L,12L,14L,18L,20L,22L,26L,28L,30L,34L,36L,38L,42L,44L,46L,50L,52L,54L,58L,60L,62L,66L,68L,70L,74L,76L,78L,82L,84L,86L,90L,92L,94L,98L,100L,102L,106L,108L,110L,114L,116L,118L,122L,124L,126L,130L,132L,134L,138L,140L,142L,146L,148L,150L,154L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047410Inst : IEnumerable<long>
{
public static readonly long[] Value=A047410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047410.Bytes);
public long this[int i]=>Value[i];

public static A047410Inst Instance=new A047410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047409
{
public static readonly long[] Value={ 0L,1L,4L,6L,8L,9L,12L,14L,16L,17L,20L,22L,24L,25L,28L,30L,32L,33L,36L,38L,40L,41L,44L,46L,48L,49L,52L,54L,56L,57L,60L,62L,64L,65L,68L,70L,72L,73L,76L,78L,80L,81L,84L,86L,88L,89L,92L,94L,96L,97L,100L,102L,104L,105L,108L,110L,112L,113L,116L,118L,120L,121L,124L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047409Inst : IEnumerable<long>
{
public static readonly long[] Value=A047409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047409.Bytes);
public long this[int i]=>Value[i];

public static A047409Inst Instance=new A047409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047408
{
public static readonly long[] Value={ 1L,4L,6L,9L,12L,14L,17L,20L,22L,25L,28L,30L,33L,36L,38L,41L,44L,46L,49L,52L,54L,57L,60L,62L,65L,68L,70L,73L,76L,78L,81L,84L,86L,89L,92L,94L,97L,100L,102L,105L,108L,110L,113L,116L,118L,121L,124L,126L,129L,132L,134L,137L,140L,142L,145L,148L,150L,153L,156L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047408Inst : IEnumerable<long>
{
public static readonly long[] Value=A047408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047408.Bytes);
public long this[int i]=>Value[i];

public static A047408Inst Instance=new A047408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047407
{
public static readonly long[] Value={ 0L,4L,6L,8L,12L,14L,16L,20L,22L,24L,28L,30L,32L,36L,38L,40L,44L,46L,48L,52L,54L,56L,60L,62L,64L,68L,70L,72L,76L,78L,80L,84L,86L,88L,92L,94L,96L,100L,102L,104L,108L,110L,112L,116L,118L,120L,124L,126L,128L,132L,134L,136L,140L,142L,144L,148L,150L,152L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047407Inst : IEnumerable<long>
{
public static readonly long[] Value=A047407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047407.Bytes);
public long this[int i]=>Value[i];

public static A047407Inst Instance=new A047407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047406
{
public static readonly long[] Value={ 4L,6L,12L,14L,20L,22L,28L,30L,36L,38L,44L,46L,52L,54L,60L,62L,68L,70L,76L,78L,84L,86L,92L,94L,100L,102L,108L,110L,116L,118L,124L,126L,132L,134L,140L,142L,148L,150L,156L,158L,164L,166L,172L,174L,180L,182L,188L,190L,196L,198L,204L,206L,212L,214L,220L,222L,228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047406Inst : IEnumerable<long>
{
public static readonly long[] Value=A047406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047406.Bytes);
public long this[int i]=>Value[i];

public static A047406Inst Instance=new A047406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047405
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,8L,9L,10L,11L,14L,16L,17L,18L,19L,22L,24L,25L,26L,27L,30L,32L,33L,34L,35L,38L,40L,41L,42L,43L,46L,48L,49L,50L,51L,54L,56L,57L,58L,59L,62L,64L,65L,66L,67L,70L,72L,73L,74L,75L,78L,80L,81L,82L,83L,86L,88L,89L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047405Inst : IEnumerable<long>
{
public static readonly long[] Value=A047405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047405.Bytes);
public long this[int i]=>Value[i];

public static A047405Inst Instance=new A047405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047404
{
public static readonly long[] Value={ 1L,2L,3L,6L,9L,10L,11L,14L,17L,18L,19L,22L,25L,26L,27L,30L,33L,34L,35L,38L,41L,42L,43L,46L,49L,50L,51L,54L,57L,58L,59L,62L,65L,66L,67L,70L,73L,74L,75L,78L,81L,82L,83L,86L,89L,90L,91L,94L,97L,98L,99L,102L,105L,106L,107L,110L,113L,114L,115L,118L,121L,122L,123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047404Inst : IEnumerable<long>
{
public static readonly long[] Value=A047404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047404.Bytes);
public long this[int i]=>Value[i];

public static A047404Inst Instance=new A047404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047403
{
public static readonly long[] Value={ 0L,2L,3L,6L,8L,10L,11L,14L,16L,18L,19L,22L,24L,26L,27L,30L,32L,34L,35L,38L,40L,42L,43L,46L,48L,50L,51L,54L,56L,58L,59L,62L,64L,66L,67L,70L,72L,74L,75L,78L,80L,82L,83L,86L,88L,90L,91L,94L,96L,98L,99L,102L,104L,106L,107L,110L,112L,114L,115L,118L,120L,122L,123L,126L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047403Inst : IEnumerable<long>
{
public static readonly long[] Value=A047403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047403.Bytes);
public long this[int i]=>Value[i];

public static A047403Inst Instance=new A047403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A047402
{
public static readonly long[] Value={ 2L,3L,6L,10L,11L,14L,18L,19L,22L,26L,27L,30L,34L,35L,38L,42L,43L,46L,50L,51L,54L,58L,59L,62L,66L,67L,70L,74L,75L,78L,82L,83L,86L,90L,91L,94L,98L,99L,102L,106L,107L,110L,114L,115L,118L,122L,123L,126L,130L,131L,134L,138L,139L,142L,146L,147L,150L,154L,155L,158L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A047402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A047402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A047402Inst : IEnumerable<long>
{
public static readonly long[] Value=A047402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A047402.Bytes);
public long this[int i]=>Value[i];

public static A047402Inst Instance=new A047402Inst();

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