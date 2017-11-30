using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A278493
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,3L,5L,4L,1L,3L,7L,7L,5L,1L,3L,7L,9L,9L,6L,1L,3L,7L,13L,13L,11L,7L,1L,3L,7L,13L,15L,15L,13L,8L,1L,3L,7L,13L,19L,19L,19L,15L,9L,1L,3L,7L,13L,19L,25L,25L,21L,17L,10L,1L,3L,7L,13L,19L,27L,27L,27L,25L,19L,11L,1L,3L,7L,13L,19L,27L,31L,31L,31L,27L,21L,12L,1L,3L,7L,13L,19L,27L,39L,39L,39L,37L,31L,23L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278493Inst : IEnumerable<long>
{
public static readonly long[] Value=A278493.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278493.Bytes);
public long this[int i]=>Value[i];

public static A278493Inst Instance=new A278493Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278494
{
public static readonly long[] Value={ 2L,5L,7L,13L,17L,23L,29L,31L,37L,47L,61L,79L,89L,97L,101L,103L,109L,113L,127L,157L,167L,193L,197L,199L,223L,229L,241L,257L,269L,271L,281L,293L,313L,317L,337L,353L,359L,383L,389L,397L,401L,409L,421L,433L,439L,449L,461L,463L,487L,509L,541L,569L,577L,593L,601L,607L,631L,647L,653L,673L,677L,709L,719L,727L,751L,761L,769L,773L,797L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278494Inst : IEnumerable<long>
{
public static readonly long[] Value=A278494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278494.Bytes);
public long this[int i]=>Value[i];

public static A278494Inst Instance=new A278494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278495
{
public static readonly long[] Value={ 1L,2L,1L,2L,2L,2L,1L,1L,2L,4L,1L,2L,1L,3L,2L,4L,3L,3L,3L,5L,3L,2L,2L,4L,4L,4L,4L,3L,4L,4L,4L,4L,2L,3L,3L,2L,4L,2L,5L,4L,6L,3L,5L,4L,5L,5L,4L,6L,3L,3L,6L,8L,4L,5L,3L,5L,5L,5L,4L,6L,6L,7L,5L,5L,7L,6L,8L,8L,8L,8L,5L,5L,5L,8L,7L,7L,7L,3L,13L,5L,8L,6L,8L,7L,8L,5L,14L,7L,8L,8L,10L,7L,5L,8L,6L,7L,6L,9L,4L,10L,4L,9L,8L,6L,8L,8L,8L,6L,10L,11L,13L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278495Inst : IEnumerable<long>
{
public static readonly long[] Value=A278495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278495.Bytes);
public long this[int i]=>Value[i];

public static A278495Inst Instance=new A278495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278496
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,9L,10L,10L,10L,10L,11L,12L,12L,13L,14L,14L,14L,15L,15L,16L,16L,16L,16L,17L,17L,17L,18L,18L,18L,19L,19L,19L,20L,20L,20L,20L,20L,21L,21L,21L,22L,22L,23L,23L,24L,24L,24L,24L,25L,25L,25L,25L,26L,26L,26L,26L,27L,27L,27L,27L,28L,28L,28L,29L,29L,29L,29L,30L,30L,30L,30L,31L,31L,31L,31L,32L,32L,32L,32L,33L,33L,34L,34L,34L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278496Inst : IEnumerable<long>
{
public static readonly long[] Value=A278496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278496.Bytes);
public long this[int i]=>Value[i];

public static A278496Inst Instance=new A278496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278497
{
public static readonly long[] Value={ 2L,6L,8L,2L,6L,16L,12L,6L,24L,8L,30L,32L,6L,6L,24L,2L,12L,48L,6L,2L,24L,2L,12L,64L,2L,30L,72L,12L,30L,48L,2L,6L,24L,60L,6L,96L,12L,30L,30L,72L,48L,6L,12L,120L,6L,60L,128L,2L,6L,24L,2L,6L,144L,12L,2L,24L,6L,6L,96L,48L,30L,120L,12L,2L,48L,2L,6L,30L,24L,192L,30L,60L,72L,6L,12L,210L,6L,216L,6L,6L,96L,2L,30L,2L,12L,240L,32L,12L,24L,2L,30L,256L,6L,12L,120L,6L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278497Inst : IEnumerable<long>
{
public static readonly long[] Value=A278497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278497.Bytes);
public long this[int i]=>Value[i];

public static A278497Inst Instance=new A278497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278498
{
public static readonly long[] Value={ 3L,6L,8L,3L,3L,16L,18L,9L,24L,27L,6L,32L,3L,6L,8L,3L,9L,48L,3L,1L,24L,3L,27L,64L,3L,6L,72L,3L,6L,16L,3L,1L,24L,18L,9L,96L,27L,6L,9L,108L,48L,3L,9L,24L,3L,54L,128L,3L,6L,8L,3L,3L,144L,27L,1L,24L,3L,6L,32L,162L,9L,72L,27L,1L,48L,3L,3L,18L,81L,192L,3L,54L,8L,3L,27L,18L,9L,216L,3L,1L,96L,3L,27L,1L,12L,48L,243L,9L,24L,3L,3L,256L,3L,9L,72L,3L,54L,16L,3L,1L,24L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278498Inst : IEnumerable<long>
{
public static readonly long[] Value=A278498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278498.Bytes);
public long this[int i]=>Value[i];

public static A278498Inst Instance=new A278498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278499
{
public static readonly long[] Value={ 0L,3L,2L,0L,3L,3L,0L,2L,1L,0L,3L,2L,0L,3L,2L,0L,3L,1L,0L,3L,1L,0L,3L,3L,0L,3L,2L,0L,3L,2L,0L,3L,1L,0L,2L,1L,0L,3L,2L,1L,0L,0L,3L,1L,0L,3L,2L,0L,3L,2L,0L,3L,3L,0L,3L,1L,0L,3L,2L,0L,2L,1L,0L,3L,1L,0L,3L,3L,2L,1L,0L,3L,2L,0L,3L,3L,2L,1L,0L,3L,1L,0L,3L,3L,1L,0L,0L,3L,1L,0L,3L,3L,0L,3L,1L,0L,3L,2L,0L,3L,1L,0L,3L,2L,0L,3L,2L,0L,2L,1L,0L,2L,1L,0L,3L,2L,0L,3L,2L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278499Inst : IEnumerable<long>
{
public static readonly long[] Value=A278499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278499.Bytes);
public long this[int i]=>Value[i];

public static A278499Inst Instance=new A278499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278516
{
public static readonly long[] Value={ 4L,4L,1L,3L,3L,2L,2L,2L,1L,4L,3L,2L,2L,4L,1L,1L,3L,1L,3L,3L,1L,3L,3L,3L,1L,2L,1L,2L,2L,1L,3L,3L,1L,3L,1L,1L,2L,4L,2L,1L,1L,1L,3L,1L,4L,3L,2L,2L,2L,1L,1L,2L,2L,2L,3L,1L,2L,3L,2L,2L,2L,1L,3L,3L,1L,2L,3L,2L,1L,1L,2L,4L,2L,2L,3L,1L,2L,1L,3L,3L,1L,3L,3L,1L,1L,1L,2L,3L,1L,3L,2L,3L,1L,3L,1L,1L,3L,2L,2L,3L,1L,2L,2L,1L,3L,3L,2L,2L,1L,1L,2L,1L,1L,3L,3L,2L,1L,4L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278516Inst : IEnumerable<long>
{
public static readonly long[] Value=A278516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278516.Bytes);
public long this[int i]=>Value[i];

public static A278516Inst Instance=new A278516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278517
{
public static readonly long[] Value={ 0L,1L,4L,8L,9L,12L,16L,18L,20L,24L,25L,29L,32L,34L,36L,40L,43L,45L,48L,49L,52L,56L,58L,61L,64L,67L,70L,72L,74L,77L,80L,81L,84L,88L,90L,93L,96L,98L,100L,104L,106L,109L,113L,116L,120L,121L,125L,128L,130L,133L,136L,139L,142L,144L,146L,148L,152L,155L,157L,160L,162L,164L,168L,169L,172L,176L,178L,180L,184L,187L,190L,193L,196L,200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278517Inst : IEnumerable<long>
{
public static readonly long[] Value=A278517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278517.Bytes);
public long this[int i]=>Value[i];

public static A278517Inst Instance=new A278517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278518
{
public static readonly long[] Value={ 1L,3L,4L,1L,3L,4L,2L,2L,4L,1L,4L,3L,2L,2L,4L,3L,2L,3L,1L,3L,4L,2L,3L,3L,3L,3L,2L,2L,3L,3L,1L,3L,4L,2L,3L,3L,2L,2L,4L,2L,3L,4L,3L,4L,1L,4L,3L,2L,3L,3L,3L,3L,2L,2L,2L,4L,3L,2L,3L,2L,2L,4L,1L,3L,4L,2L,2L,4L,3L,3L,3L,3L,4L,2L,3L,3L,3L,3L,3L,4L,3L,1L,3L,4L,2L,3L,4L,3L,4L,2L,3L,3L,3L,2L,3L,3L,2L,3L,2L,3L,3L,3L,3L,2L,1L,3L,4L,2L,3L,3L,2L,3L,3L,2L,3L,3L,3L,1L,4L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278518Inst : IEnumerable<long>
{
public static readonly long[] Value=A278518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278518.Bytes);
public long this[int i]=>Value[i];

public static A278518Inst Instance=new A278518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278519
{
public static readonly long[] Value={ 0L,3L,7L,8L,11L,15L,17L,19L,23L,24L,28L,31L,33L,35L,39L,42L,44L,47L,48L,51L,55L,57L,60L,63L,66L,69L,71L,73L,76L,79L,80L,83L,87L,89L,92L,95L,97L,99L,103L,105L,108L,112L,115L,119L,120L,124L,127L,129L,132L,135L,138L,141L,143L,145L,147L,151L,154L,156L,159L,161L,163L,167L,168L,171L,175L,177L,179L,183L,186L,189L,192L,195L,199L,201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278519Inst : IEnumerable<long>
{
public static readonly long[] Value=A278519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278519.Bytes);
public long this[int i]=>Value[i];

public static A278519Inst Instance=new A278519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278520
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,1L,0L,0L,-1L,2L,0L,2L,0L,3L,0L,0L,0L,0L,0L,4L,1L,4L,0L,3L,-2L,5L,-2L,6L,0L,2L,0L,0L,2L,6L,-1L,1L,0L,7L,3L,6L,0L,4L,0L,8L,0L,8L,0L,4L,-3L,0L,4L,10L,0L,-1L,0L,9L,5L,9L,0L,4L,0L,10L,2L,0L,1L,6L,0L,12L,6L,2L,0L,2L,0L,11L,-2L,14L,-2L,8L,0L,8L,-3L,12L,0L,7L,2L,13L,7L,12L,0L,2L,-1L,16L,8L,14L,3L,5L,0L,0L,4L,2L,0L,10L,0L,15L,0L,15L,0L,0L,0L,4L,9L,12L,0L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278520Inst : IEnumerable<long>
{
public static readonly long[] Value=A278520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278520.Bytes);
public long this[int i]=>Value[i];

public static A278520Inst Instance=new A278520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278521
{
public static readonly long[] Value={ 0L,2L,2L,0L,2L,3L,0L,0L,1L,0L,2L,1L,0L,1L,2L,0L,0L,0L,0L,2L,1L,0L,1L,2L,0L,0L,0L,0L,1L,1L,0L,2L,1L,0L,0L,0L,0L,1L,2L,1L,2L,3L,2L,1L,0L,2L,1L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,1L,0L,1L,3L,2L,2L,2L,2L,2L,0L,1L,2L,2L,2L,2L,2L,0L,0L,2L,3L,1L,2L,3L,2L,1L,0L,1L,2L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278521Inst : IEnumerable<long>
{
public static readonly long[] Value=A278521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278521.Bytes);
public long this[int i]=>Value[i];

public static A278521Inst Instance=new A278521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278522
{
public static readonly long[] Value={ 0L,0L,1L,0L,0L,0L,1L,1L,2L,0L,1L,1L,1L,0L,1L,2L,1L,2L,0L,0L,2L,1L,1L,0L,2L,2L,1L,1L,1L,1L,0L,0L,2L,1L,2L,2L,1L,0L,1L,0L,0L,0L,0L,2L,0L,1L,1L,1L,1L,1L,2L,2L,0L,1L,0L,2L,2L,1L,1L,1L,1L,2L,0L,0L,2L,1L,0L,0L,0L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,2L,1L,1L,0L,2L,1L,2L,2L,1L,1L,1L,1L,2L,2L,2L,1L,0L,0L,1L,1L,2L,2L,1L,2L,2L,1L,1L,1L,2L,0L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278522Inst : IEnumerable<long>
{
public static readonly long[] Value=A278522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278522.Bytes);
public long this[int i]=>Value[i];

public static A278522Inst Instance=new A278522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278523
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,2L,12L,2L,12L,8L,6L,2L,24L,4L,6L,6L,12L,2L,30L,2L,32L,12L,6L,6L,36L,2L,6L,6L,24L,2L,30L,2L,12L,16L,6L,2L,48L,4L,12L,12L,12L,2L,24L,8L,24L,12L,6L,2L,60L,2L,6L,6L,64L,6L,30L,2L,12L,24L,30L,2L,72L,2L,6L,6L,12L,6L,30L,2L,48L,12L,6L,2L,60L,12L,6L,30L,24L,2L,60L,8L,12L,32L,6L,6L,96L,2L,12L,6L,36L,2L,30L,2L,24L,36L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278523Inst : IEnumerable<long>
{
public static readonly long[] Value=A278523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278523.Bytes);
public long this[int i]=>Value[i];

public static A278523Inst Instance=new A278523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278524
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,6L,2L,8L,4L,6L,2L,12L,2L,6L,6L,16L,2L,12L,2L,12L,8L,6L,2L,24L,4L,6L,6L,12L,2L,30L,2L,32L,12L,6L,6L,36L,2L,6L,6L,24L,2L,24L,2L,12L,16L,6L,2L,48L,4L,12L,12L,12L,2L,30L,8L,24L,12L,6L,2L,60L,2L,6L,6L,64L,6L,60L,2L,12L,24L,30L,2L,72L,2L,6L,6L,12L,6L,30L,2L,48L,12L,6L,2L,72L,12L,6L,30L,24L,2L,48L,8L,12L,32L,6L,6L,96L,2L,12L,6L,36L,2L,60L,2L,24L,36L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278524Inst : IEnumerable<long>
{
public static readonly long[] Value=A278524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278524.Bytes);
public long this[int i]=>Value[i];

public static A278524Inst Instance=new A278524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278525
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,2L,8L,6L,4L,2L,8L,2L,4L,6L,16L,2L,12L,2L,8L,6L,4L,2L,16L,6L,4L,12L,8L,2L,12L,2L,32L,6L,4L,6L,24L,2L,4L,6L,16L,2L,12L,2L,8L,12L,4L,2L,32L,6L,12L,6L,8L,2L,36L,6L,16L,6L,4L,2L,24L,2L,4L,12L,64L,6L,12L,2L,8L,6L,12L,2L,48L,2L,4L,30L,8L,6L,12L,2L,32L,24L,4L,2L,24L,6L,4L,6L,16L,2L,36L,6L,8L,6L,4L,6L,64L,2L,12L,12L,24L,2L,12L,2L,16L,30L,4L,2L,72L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278525Inst : IEnumerable<long>
{
public static readonly long[] Value=A278525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278525.Bytes);
public long this[int i]=>Value[i];

public static A278525Inst Instance=new A278525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278526
{
public static readonly long[] Value={ 1L,2L,4L,2L,6L,2L,4L,2L,8L,2L,12L,2L,6L,2L,16L,2L,6L,2L,6L,2L,6L,2L,6L,2L,8L,2L,24L,2L,6L,2L,6L,2L,12L,2L,12L,2L,30L,2L,4L,2L,6L,2L,6L,2L,24L,2L,6L,2L,6L,2L,24L,2L,6L,2L,36L,2L,30L,2L,6L,2L,12L,2L,6L,2L,6L,2L,32L,2L,12L,2L,12L,2L,12L,2L,12L,2L,30L,2L,6L,2L,30L,2L,16L,2L,72L,2L,12L,2L,60L,2L,12L,2L,12L,2L,4L,2L,6L,2L,48L,2L,24L,2L,6L,2L,12L,2L,6L,2L,120L,2L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278526Inst : IEnumerable<long>
{
public static readonly long[] Value=A278526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278526.Bytes);
public long this[int i]=>Value[i];

public static A278526Inst Instance=new A278526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278527
{
public static readonly long[] Value={ 1L,4L,2L,4L,2L,6L,2L,16L,2L,6L,2L,12L,2L,8L,2L,6L,2L,6L,2L,24L,2L,8L,2L,6L,2L,6L,2L,6L,2L,6L,2L,6L,2L,12L,2L,6L,2L,30L,2L,36L,2L,6L,2L,24L,2L,6L,2L,6L,2L,24L,2L,6L,2L,6L,2L,4L,2L,30L,2L,12L,2L,12L,2L,24L,2L,6L,2L,30L,2L,48L,2L,72L,2L,6L,2L,60L,2L,12L,2L,12L,2L,120L,2L,6L,2L,12L,2L,6L,2L,24L,2L,48L,2L,6L,2L,4L,2L,12L,2L,12L,2L,60L,2L,12L,2L,72L,2L,16L,2L,30L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278527Inst : IEnumerable<long>
{
public static readonly long[] Value=A278527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278527.Bytes);
public long this[int i]=>Value[i];

public static A278527Inst Instance=new A278527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278528
{
public static readonly long[] Value={ 0L,1L,0L,1L,2L,1L,0L,1L,3L,1L,2L,1L,0L,1L,4L,1L,2L,1L,0L,1L,3L,1L,2L,1L,5L,1L,0L,1L,2L,1L,6L,1L,3L,1L,2L,1L,4L,1L,0L,1L,2L,1L,7L,1L,3L,1L,2L,1L,0L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L,8L,1L,0L,1L,2L,1L,9L,1L,3L,1L,2L,1L,6L,1L,4L,1L,2L,1L,0L,1L,3L,1L,2L,1L,5L,1L,10L,1L,2L,1L,0L,1L,3L,1L,2L,1L,4L,1L,7L,1L,2L,1L,11L,1L,3L,1L,2L,1L,0L,1L,5L,1L,2L,1L,4L,1L,3L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278528Inst : IEnumerable<long>
{
public static readonly long[] Value=A278528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278528.Bytes);
public long this[int i]=>Value[i];

public static A278528Inst Instance=new A278528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278529
{
public static readonly long[] Value={ 0L,1L,0L,2L,1L,3L,0L,4L,1L,5L,2L,6L,0L,7L,1L,8L,3L,9L,0L,10L,2L,11L,4L,12L,1L,13L,0L,14L,5L,15L,1L,16L,3L,17L,6L,18L,2L,19L,0L,20L,7L,21L,1L,22L,4L,23L,8L,24L,0L,25L,2L,26L,9L,27L,3L,28L,5L,29L,10L,30L,1L,31L,0L,32L,11L,33L,1L,34L,6L,35L,12L,36L,2L,37L,4L,38L,13L,39L,0L,40L,7L,41L,14L,42L,3L,43L,1L,44L,15L,45L,0L,46L,8L,47L,16L,48L,5L,49L,2L,50L,17L,51L,1L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278529Inst : IEnumerable<long>
{
public static readonly long[] Value=A278529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278529.Bytes);
public long this[int i]=>Value[i];

public static A278529Inst Instance=new A278529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278530
{
public static readonly long[] Value={ 0L,1L,2L,3L,3L,5L,5L,6L,4L,8L,8L,10L,7L,11L,9L,10L,5L,12L,12L,16L,11L,18L,15L,17L,9L,18L,16L,20L,12L,19L,14L,15L,6L,17L,17L,24L,16L,28L,23L,27L,14L,29L,26L,33L,20L,32L,24L,26L,11L,27L,25L,34L,21L,36L,28L,32L,15L,31L,26L,33L,18L,29L,20L,21L,7L,23L,23L,34L,22L,41L,33L,40L,20L,44L,39L,51L,30L,50L,37L,41L,17L,43L,40L,55L,34L,59L,46L,53L,25L,52L,44L,56L,31L,50L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278530Inst : IEnumerable<long>
{
public static readonly long[] Value=A278530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278530.Bytes);
public long this[int i]=>Value[i];

public static A278530Inst Instance=new A278530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278531
{
public static readonly long[] Value={ 1L,2L,4L,2L,8L,4L,6L,2L,16L,8L,12L,4L,12L,6L,6L,2L,32L,16L,24L,8L,36L,12L,12L,4L,24L,12L,30L,6L,12L,6L,6L,2L,64L,32L,48L,16L,72L,24L,24L,8L,72L,36L,60L,12L,36L,12L,12L,4L,48L,24L,60L,12L,60L,30L,30L,6L,24L,12L,30L,6L,12L,6L,6L,2L,128L,64L,96L,32L,144L,48L,48L,16L,216L,72L,120L,24L,72L,24L,24L,8L,144L,72L,180L,36L,180L,60L,60L,12L,72L,36L,60L,12L,36L,12L,12L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278531Inst : IEnumerable<long>
{
public static readonly long[] Value=A278531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278531.Bytes);
public long this[int i]=>Value[i];

public static A278531Inst Instance=new A278531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278580
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,9L,12L,13L,16L,18L,24L,25L,26L,27L,29L,31L,32L,35L,36L,39L,41L,47L,48L,49L,50L,52L,54L,55L,58L,59L,62L,64L,70L,71L,72L,73L,75L,77L,78L,81L,82L,85L,87L,93L,94L,95L,96L,98L,100L,101L,104L,105L,108L,110L,116L,117L,118L,119L,121L,123L,124L,127L,128L,131L,133L,139L,140L,141L,142L,144L,146L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278580Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278580.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278580Inst : IEnumerable<long>
{
public static readonly long[] Value=A278580.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278580.Bytes);
public long this[int i]=>Value[i];

public static A278580Inst Instance=new A278580Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278581
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,12L,13L,16L,18L,25L,36L,49L,50L,169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278581Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278581.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278581Inst : IEnumerable<long>
{
public static readonly long[] Value=A278581.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278581.Bytes);
public long this[int i]=>Value[i];

public static A278581Inst Instance=new A278581Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278582
{
public static readonly long[] Value={ 20L,21L,24L,32L,48L,64L,72L,96L,100L,144L,147L,199L,288L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278582Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278582.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278582Inst : IEnumerable<long>
{
public static readonly long[] Value=A278582.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278582.Bytes);
public long this[int i]=>Value[i];

public static A278582Inst Instance=new A278582Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278583
{
public static readonly long[] Value={ 12L,36L,156L,540L,876L,1200L,1380L,1620L,2016L,2556L,2856L,3060L,4356L,4440L,5076L,5580L,5700L,6336L,6636L,6660L,6996L,7416L,8220L,9180L,9660L,9900L,10836L,11496L,12456L,12600L,12720L,12756L,13680L,14436L,15240L,16920L,17076L,18216L,18300L,18396L,19440L,21000L,21576L,22620L,23556L,24480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278583Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278583.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278583Inst : IEnumerable<long>
{
public static readonly long[] Value=A278583.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278583.Bytes);
public long this[int i]=>Value[i];

public static A278583Inst Instance=new A278583Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278584
{
public static readonly BigInteger[] Value={ 1L,0L,101L,100L,1L,111000L,10101L,10010100L,1L,1111111000L,10101L,111110010100L,100000001L,11100011111000L,1010100010101L,1001010010010100L,1L,111111111111111000L,10101L,11111111111110010100UL,100000001L,BigInteger.Parse("1111111111100011111000"),1010100010101L };
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
public class A278584Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278584.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278584Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278584.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278584.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278584Inst Instance=new A278584Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278585
{
public static readonly long[] Value={ 12720L,16920L,19440L,24480L,49680L,61560L,104160L,229320L,255360L,259680L,266400L,291720L,298200L,311040L,331920L,419400L,423480L,436800L,446880L,471240L,525240L,532800L,539400L,581520L,600600L,663600L,704160L,709920L,783720L,867000L,904800L,908040L,918360L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278585Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278585.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278585Inst : IEnumerable<long>
{
public static readonly long[] Value=A278585.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278585.Bytes);
public long this[int i]=>Value[i];

public static A278585Inst Instance=new A278585Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278586
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,14L,17L,21L,24L,28L,32L,36L,40L,44L,49L,53L,57L,62L,66L,71L,75L,80L,84L,90L,94L,99L,103L,109L,113L,118L,123L,128L,133L,139L,143L,149L,154L,159L,164L,170L,175L,180L,185L,191L,196L,201L,207L,212L,217L,223L,229L,234L,240L,246L,251L,256L,262L,268L,273L,279L,284L,290L,296L,302L,308L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278586Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278586.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278586Inst : IEnumerable<long>
{
public static readonly long[] Value=A278586.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278586.Bytes);
public long this[int i]=>Value[i];

public static A278586Inst Instance=new A278586Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278587
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,-1L,-1L,0L,0L,1L,-1L,0L,0L,1L,-1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278587Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278587.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278587Inst : IEnumerable<long>
{
public static readonly long[] Value=A278587.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278587.Bytes);
public long this[int i]=>Value[i];

public static A278587Inst Instance=new A278587Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278588
{
public static readonly long[] Value={ 9L,18L,198L,27L,54L,2997L,36L,396L,108L,39996L,45L,90L,135L,180L,499995L,54L,594L,5994L,3564L,270L,5999994L,63L,126L,189L,252L,315L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278588Inst : IEnumerable<long>
{
public static readonly long[] Value=A278588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278588.Bytes);
public long this[int i]=>Value[i];

public static A278588Inst Instance=new A278588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278589
{
public static readonly long[] Value={ 1L,2L,16L,320L,12448L,809792L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278589Inst : IEnumerable<long>
{
public static readonly long[] Value=A278589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278589.Bytes);
public long this[int i]=>Value[i];

public static A278589Inst Instance=new A278589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278590
{
public static readonly long[] Value={ 1L,1L,4L,40L,778L,25306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278590Inst : IEnumerable<long>
{
public static readonly long[] Value=A278590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278590.Bytes);
public long this[int i]=>Value[i];

public static A278590Inst Instance=new A278590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278591
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,11L,14L,18L,25L,39L,81L,91L,347L,391L,438L,464L,539L,818L,1051L,1125L,1598L,3384L,11966L,79867L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278591Inst : IEnumerable<long>
{
public static readonly long[] Value=A278591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278591.Bytes);
public long this[int i]=>Value[i];

public static A278591Inst Instance=new A278591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278592
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1101L,1L,111101L,1L,11111101L,1L,1111111101L,1L,111111111101L,10001L,11111111010101L,10101L,1111111111010101L,10101L,111111111111010101L,10101L,11111111111111010101UL,10101L,BigInteger.Parse("1111111111111111010101"),10101L,BigInteger.Parse("111111111111111111010101"),100010101L };
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
public class A278592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278592Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278592.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278592.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278592Inst Instance=new A278592Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278593
{
public static readonly ulong[] Value={ 1L,10L,100L,1011L,10000L,101111L,1000000L,10111111L,100000000L,1011111111L,10000000000L,101111111111L,1000100000000L,10101011111111L,101010000000000L,1010101111111111L,10101000000000000L,101010111111111111L,1010100000000000000L,10101011111111111111UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278593Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A278593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278593.Bytes);
public ulong this[int i]=>Value[i];

public static A278593Inst Instance=new A278593Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278594
{
public static readonly long[] Value={ 1L,1L,1L,13L,1L,61L,1L,253L,1L,1021L,1L,4093L,17L,16341L,21L,65493L,21L,262101L,21L,1048533L,21L,4194261L,21L,16777173L,277L,67108189L,321L,268434909L,1L,1073741821L,1041L,4294964693L,1045L,17179866589L,1025L,68719474173L,1041L,274877904341L,66581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278594Inst : IEnumerable<long>
{
public static readonly long[] Value=A278594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278594.Bytes);
public long this[int i]=>Value[i];

public static A278594Inst Instance=new A278594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278595
{
public static readonly long[] Value={ 1L,2L,4L,11L,16L,47L,64L,191L,256L,767L,1024L,3071L,4352L,11007L,21504L,44031L,86016L,176127L,344064L,704511L,1376256L,2818047L,5505024L,11272191L,22085632L,48955391L,68419584L,196870143L,268435456L,805306367L,1141899264L,2880438271L,5641338880L,12595494911L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278595Inst : IEnumerable<long>
{
public static readonly long[] Value=A278595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278595.Bytes);
public long this[int i]=>Value[i];

public static A278595Inst Instance=new A278595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278628
{
public static readonly long[] Value={ 0L,13L,285L,3354L,27521L,175881L,932205L,4266912L,17344954L,63898594L,216606040L,683599110L,2027209742L,5691010421L,15216367989L,38944866772L,95817126997L,227430633270L,522402290790L,1164311022921L,2523775686270L,5331359865045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278628Inst : IEnumerable<long>
{
public static readonly long[] Value=A278628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278628.Bytes);
public long this[int i]=>Value[i];

public static A278628Inst Instance=new A278628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278629
{
public static readonly long[] Value={ 1L,285L,10824L,234484L,3739008L,48592635L,541463431L,5325263364L,47098291840L,379621129293L,2817194942225L,19407777240447L,124964309624036L,756392815286668L,4325156175914066L,23464134450391209L,121221027131246039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278629Inst : IEnumerable<long>
{
public static readonly long[] Value=A278629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278629.Bytes);
public long this[int i]=>Value[i];

public static A278629Inst Instance=new A278629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278630
{
public static readonly BigInteger[] Value={ 15L,3354L,234484L,10776210L,387551595L,11719632199L,309971214338L,7350438329498L,158870607154260L,3165150394868325L,58584816738347925L,1013219703287606525L,16445858865221341430UL,BigInteger.Parse("251416530890380206352") };
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
public class A278630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278630Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278630.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278630.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278630Inst Instance=new A278630Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278631
{
public static readonly BigInteger[] Value={ 90L,27521L,3739008L,387551595L,33967584488L,2593097277036L,175644502146694L,10734760074025367L,600850493598843960L,BigInteger.Parse("31181144570813141891"),BigInteger.Parse("1514424057857433189463"),BigInteger.Parse("69299571270775145840652") };
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
public class A278631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278631Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278631.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278631.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278631Inst Instance=new A278631Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278632
{
public static readonly BigInteger[] Value={ 357L,175881L,48592635L,11719632199L,2593097277036L,521528860552802L,94782697883923436L,15624069731088285787UL,BigInteger.Parse("2357725621673408985921"),BigInteger.Parse("329332639476242364241409"),BigInteger.Parse("43040255418713805460253898") };
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
public class A278632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278632Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278632.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278632.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278632Inst Instance=new A278632Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278633
{
public static readonly BigInteger[] Value={ 1107L,932205L,541463431L,309971214338L,175644502146694L,94782697883923436L,BigInteger.Parse("47369705674953303984"),BigInteger.Parse("21685396319356730003339"),BigInteger.Parse("9098829152955190125398905"),BigInteger.Parse("3522319073864419078316881080"),BigInteger.Parse("1269570351401707348639148214535") };
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
public class A278633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278633Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278633.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278633.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278633Inst Instance=new A278633Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278634
{
public static readonly long[] Value={ 0L,0L,0L,1L,13L,1L,15L,285L,285L,15L,90L,3354L,10824L,3354L,90L,357L,27521L,234484L,234484L,27521L,357L,1107L,175881L,3739008L,10776210L,3739008L,175881L,1107L,2907L,932205L,48592635L,387551595L,387551595L,48592635L,932205L,2907L,6765L,4266912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278634Inst : IEnumerable<long>
{
public static readonly long[] Value=A278634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278634.Bytes);
public long this[int i]=>Value[i];

public static A278634Inst Instance=new A278634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278635
{
public static readonly long[] Value={ 1L,3L,3L,4L,2L,4L,3L,2L,1L,3L,4L,4L,4L,6L,4L,3L,1L,4L,4L,4L,3L,6L,2L,2L,2L,6L,2L,6L,3L,6L,1L,2L,4L,2L,6L,3L,6L,2L,2L,2L,6L,1L,2L,6L,6L,3L,4L,2L,6L,2L,4L,2L,6L,2L,3L,4L,4L,4L,12L,4L,4L,12L,4L,10L,18L,4L,4L,2L,2L,2L,4L,4L,2L,4L,12L,4L,4L,4L,8L,24L,8L,8L,18L,8L,14L,24L,8L,8L,18L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278635Inst : IEnumerable<long>
{
public static readonly long[] Value=A278635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278635.Bytes);
public long this[int i]=>Value[i];

public static A278635Inst Instance=new A278635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278636
{
public static readonly long[] Value={ 2L,2L,2L,3L,2L,4L,3L,3L,2L,2L,2L,2L,5L,3L,4L,2L,2L,3L,2L,3L,2L,2L,6L,3L,5L,4L,4L,2L,2L,4L,2L,3L,3L,3L,2L,3L,2L,2L,2L,2L,2L,7L,3L,6L,4L,5L,2L,2L,5L,2L,3L,4L,2L,4L,3L,2L,5L,2L,3L,2L,4L,2L,2L,2L,3L,2L,2L,3L,2L,2L,8L,3L,7L,4L,6L,5L,5L,2L,2L,6L,2L,3L,5L,2L,4L,4L,2L,5L,3L,2L,6L,2L,3L,2L,5L,3L,3L,4L,3L,4L,3L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278636Inst : IEnumerable<long>
{
public static readonly long[] Value=A278636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278636.Bytes);
public long this[int i]=>Value[i];

public static A278636Inst Instance=new A278636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278637
{
public static readonly long[] Value={ 3L,4L,5L,7L,8L,9L,10L,11L,13L,14L,17L,19L,22L,23L,26L,29L,31L,34L,41L,43L,47L,53L,59L,61L,71L,73L,79L,83L,89L,94L,101L,107L,109L,113L,121L,127L,131L,137L,151L,167L,173L,191L,193L,199L,227L,251L,271L,277L,293L,331L,353L,359L,397L,401L,431L,433L,449L,467L,509L,569L,571L,587L,599L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278637Inst : IEnumerable<long>
{
public static readonly long[] Value=A278637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278637.Bytes);
public long this[int i]=>Value[i];

public static A278637Inst Instance=new A278637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278638
{
public static readonly long[] Value={ 6L,12L,15L,18L,20L,21L,24L,28L,30L,33L,35L,36L,40L,42L,44L,45L,48L,52L,54L,55L,56L,60L,63L,65L,66L,68L,70L,72L,75L,76L,77L,78L,80L,84L,85L,88L,90L,91L,95L,96L,99L,100L,102L,104L,105L,108L,110L,112L,114L,115L,117L,119L,120L,126L,130L,132L,133L,135L,136L,138L,140L,143L,144L,145L,147L,150L,152L,153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278638Inst : IEnumerable<long>
{
public static readonly long[] Value=A278638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278638.Bytes);
public long this[int i]=>Value[i];

public static A278638Inst Instance=new A278638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278639
{
public static readonly long[] Value={ 0L,0L,0L,1L,3L,12L,38L,117L,336L,976L,2724L,7689L,21455L,60228L,168714L,475037L,1338861L,3788400L,10742588L,30556305L,87112059L,248967564L,713032782L,2046325125L,5883428618L,16944975048L,48880471500L,141212377489L,408509453511L,1183275193908L,3431504760514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278639Inst : IEnumerable<long>
{
public static readonly long[] Value=A278639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278639.Bytes);
public long this[int i]=>Value[i];

public static A278639Inst Instance=new A278639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278640
{
public static readonly long[] Value={ 0L,0L,0L,4L,15L,72L,270L,1044L,3795L,14060L,51204L,188604L,694130L,2572920L,9567090L,35758704L,134137875L,505159200L,1908554190L,7233104844L,27486506268L,104713296760L,399817262550L,1529746919604L,5864041395730L,22517964582504L,86607602546220L,333599838189804L,1286742419927070L,4969488707124120L,19215357085867800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278640Inst : IEnumerable<long>
{
public static readonly long[] Value=A278640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278640.Bytes);
public long this[int i]=>Value[i];

public static A278640Inst Instance=new A278640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278641
{
public static readonly long[] Value={ 0L,0L,0L,10L,45L,252L,1130L,5270L,23520L,106960L,483756L,2211650L,10149805L,46911060L,217868310L,1017057518L,4767797895L,22438419120L,105960938380L,501928967930L,2384171386941L,11353241261180L,54185968572450L,259150507387910L,1241763071712930L,5960463867187752L,28656077411358180L,137973711706163210L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278641Inst : IEnumerable<long>
{
public static readonly long[] Value=A278641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278641.Bytes);
public long this[int i]=>Value[i];

public static A278641Inst Instance=new A278641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278642
{
public static readonly BigInteger[] Value={ 0L,0L,0L,20L,105L,672L,3535L,19350L,102795L,556010L,3010098L,16467450L,90619690L,502194420L,2798240265L,15671993560L,88156797855L,497837886000L,2821092554035L,16035752398770L,91403856697944L,522308167195260L,2991401733402075L,17168047238861070L,98716274117752900L,568605754068247644L,3280417827002225910L,BigInteger.Parse("18953525314104758810") };
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
public class A278642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278642Inst Instance=new A278642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278643
{
public static readonly long[] Value={ 27L,37L,47L,73L,83L,87L,125L,139L,141L,167L,175L,197L,237L,267L,273L,277L,281L,305L,307L,327L,335L,337L,345L,351L,379L,387L,397L,405L,421L,433L,463L,471L,477L,487L,505L,531L,537L,547L,567L,577L,589L,613L,619L,629L,631L,635L,659L,661L,665L,687L,691L,697L,703L,715L,727L,731L,743L,753L,789L,805L,821L,857L,877L,883L,919L,941L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278643Inst : IEnumerable<long>
{
public static readonly long[] Value=A278643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278643.Bytes);
public long this[int i]=>Value[i];

public static A278643Inst Instance=new A278643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278692
{
public static readonly long[] Value={ 4L,14L,49L,171L,596L,2077L,7238L,25223L,87897L,306303L,1067403L,3719680L,12962320L,45171020L,157411717L,548547468L,1911575138L,6661446313L,23213770727L,80895217952L,281903201529L,982374694626L,3423373822671L,11929753885009L,41572739387791L,144872448909191L,504850696923520L,1759300875378480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278692Inst : IEnumerable<long>
{
public static readonly long[] Value=A278692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278692.Bytes);
public long this[int i]=>Value[i];

public static A278692Inst Instance=new A278692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278693
{
public static readonly long[] Value={ 4L,181L,6458L,6460L,40083L,40121L,10553502L,69709942L,3140421718L,3140421737L,3140421740L,3140421768L,3140421805L,3140421845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278693Inst : IEnumerable<long>
{
public static readonly long[] Value=A278693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278693.Bytes);
public long this[int i]=>Value[i];

public static A278693Inst Instance=new A278693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278694
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,19L,23L,29L,59L,61L,73L,83L,163L,167L,173L,181L,191L,223L,487L,491L,509L,547L,569L,653L,659L,677L,709L,1459L,1481L,1487L,1531L,1621L,1949L,2027L,2111L,4397L,4447L,4457L,4547L,4597L,4861L,4943L,5051L,5861L,6323L,6563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278694Inst : IEnumerable<long>
{
public static readonly long[] Value=A278694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278694.Bytes);
public long this[int i]=>Value[i];

public static A278694Inst Instance=new A278694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278695
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,14L,16L,17L,20L,22L,38L,134L,136L,152L,829L,1087L,2110L,3524L,4412L,7079L,10538L,17672L,21583L,24163L,35126L,72050L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278695Inst : IEnumerable<long>
{
public static readonly long[] Value=A278695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278695.Bytes);
public long this[int i]=>Value[i];

public static A278695Inst Instance=new A278695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278696
{
public static readonly long[] Value={ 2L,5L,11L,23L,29L,59L,83L,167L,173L,191L,491L,509L,569L,653L,659L,677L,1481L,1487L,1949L,2027L,2111L,4397L,4457L,4547L,4943L,5051L,5861L,6323L,6563L,13127L,13151L,13313L,13613L,13691L,13781L,13799L,15149L,15233L,17519L,17579L,17669L,39371L,39857L,40847L,40853L,43913L,44417L,52517L,53147L,59051L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278696Inst : IEnumerable<long>
{
public static readonly long[] Value=A278696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278696.Bytes);
public long this[int i]=>Value[i];

public static A278696Inst Instance=new A278696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278697
{
public static readonly long[] Value={ 2L,3L,7L,13L,17L,23L,53L,67L,73L,103L,107L,113L,127L,257L,263L,317L,353L,503L,523L,607L,613L,1303L,1567L,1753L,1877L,2503L,3023L,6257L,6263L,6317L,6323L,6353L,6857L,6863L,7817L,8753L,9377L,12503L,12517L,12553L,12613L,12757L,12763L,12853L,13003L,31253L,31267L,31357L,31513L,31567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278697Inst : IEnumerable<long>
{
public static readonly long[] Value=A278697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278697.Bytes);
public long this[int i]=>Value[i];

public static A278697Inst Instance=new A278697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278698
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,17L,23L,53L,61L,67L,73L,101L,103L,107L,113L,127L,251L,257L,263L,311L,317L,353L,503L,523L,601L,607L,613L,1303L,1567L,1753L,1877L,2503L,3023L,6257L,6263L,6311L,6317L,6323L,6353L,6857L,6863L,7817L,8753L,9377L,12503L,12511L,12517L,12553L,12601L,12613L,12757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278698Inst : IEnumerable<long>
{
public static readonly long[] Value=A278698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278698.Bytes);
public long this[int i]=>Value[i];

public static A278698Inst Instance=new A278698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278699
{
public static readonly long[] Value={ 2L,3L,7L,11L,19L,23L,43L,59L,67L,71L,83L,107L,131L,139L,151L,199L,211L,251L,263L,467L,523L,571L,619L,643L,787L,811L,827L,839L,907L,919L,967L,1019L,1031L,1091L,1163L,1223L,1667L,1811L,1931L,2131L,2179L,2311L,2887L,3067L,3079L,3083L,3203L,3271L,3323L,3539L,3643L,3691L,3911L,4091L,4099L,4139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278699Inst : IEnumerable<long>
{
public static readonly long[] Value=A278699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278699.Bytes);
public long this[int i]=>Value[i];

public static A278699Inst Instance=new A278699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278700
{
public static readonly long[] Value={ 0L,0L,1L,1L,2L,1L,1L,0L,2L,0L,1L,3L,1L,0L,3L,0L,1L,2L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,5L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,3L,1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,2L,0L,0L,1L,0L,0L,1L,2L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,1L,0L,0L,1L,0L,0L,1L,0L,2L,0L,1L,0L,0L,1L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278700Inst : IEnumerable<long>
{
public static readonly long[] Value=A278700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278700.Bytes);
public long this[int i]=>Value[i];

public static A278700Inst Instance=new A278700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278701
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278701Inst : IEnumerable<long>
{
public static readonly long[] Value=A278701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278701.Bytes);
public long this[int i]=>Value[i];

public static A278701Inst Instance=new A278701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278702
{
public static readonly long[] Value={ 3L,3L,2L,1L,1L,1L,3L,5L,2L,2L,3L,2L,3L,1L,1L,1L,1L,1L,4L,2L,2L,3L,5L,2L,2L,2L,1L,2L,2L,4L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278702Inst : IEnumerable<long>
{
public static readonly long[] Value=A278702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278702.Bytes);
public long this[int i]=>Value[i];

public static A278702Inst Instance=new A278702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278703
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,4L,5L,3L,1L,2L,5L,6L,4L,3L,1L,2L,6L,5L,7L,4L,1L,3L,2L,7L,6L,8L,5L,4L,1L,3L,2L,7L,8L,6L,9L,5L,1L,4L,2L,3L,8L,9L,7L,10L,6L,5L,1L,4L,2L,3L,9L,8L,10L,7L,11L,6L,1L,5L,2L,4L,3L,10L,9L,11L,8L,12L,7L,6L,1L,5L,2L,4L,3L,10L,11L,9L,12L,8L,13L,7L,1L,6L,2L,5L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278703Inst : IEnumerable<long>
{
public static readonly long[] Value=A278703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278703.Bytes);
public long this[int i]=>Value[i];

public static A278703Inst Instance=new A278703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278704
{
public static readonly BigInteger[] Value={ 1L,32L,1280L,81920L,9175040L,1879048192L,721554505728L,527765581332480L,743093938516131840L,BigInteger.Parse("2029141848108050677760"),BigInteger.Parse("10804774512805748248936448"),BigInteger.Parse("112652543574969605015820304384"),BigInteger.Parse("2307124092415377510723999833784320"),BigInteger.Parse("93045959704944111103266494219624120320") };
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
public class A278704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278704Inst Instance=new A278704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278705
{
public static readonly BigInteger[] Value={ 12L,960L,92160L,13762560L,3523215360L,1623497637888L,1385384650997760L,2229281815548395520L,BigInteger.Parse("6848353737364671037440"),BigInteger.Parse("40517904423021555933511680"),BigInteger.Parse("464691742246749620690258755584"),BigInteger.Parse("10382058415869198798257999252029440"),BigInteger.Parse("453599053561602541628424159320667586560") };
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
public class A278705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278705Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278705.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278705.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278705Inst Instance=new A278705Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278706
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,5L,7L,10L,16L,24L,36L,54L,81L,123L,185L,278L,419L,631L,951L,1432L,2156L,3248L,4892L,7368L,11097L,16713L,25173L,37914L,57103L,86005L,129535L,195098L,293844L,442568L,666568L,1003942L,1512073L,2277387L,3430053L,5166126L,7780887L,11719071L,17650511L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278706Inst : IEnumerable<long>
{
public static readonly long[] Value=A278706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278706.Bytes);
public long this[int i]=>Value[i];

public static A278706Inst Instance=new A278706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278707
{
public static readonly long[] Value={ 2L,3L,5L,6L,9L,14L,18L,21L,24L,27L,29L,83L,513L,555L,750L,843L,1118L,4494L,5886L,6968L,9519L,12290L,15779L,76536L,76818L,90371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278707Inst : IEnumerable<long>
{
public static readonly long[] Value=A278707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278707.Bytes);
public long this[int i]=>Value[i];

public static A278707Inst Instance=new A278707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278756
{
public static readonly long[] Value={ 1L,0L,6L,1L,28L,3L,120L,7L,496L,15L,2016L,31L,8128L,63L,32640L,127L,130816L,255L,523776L,511L,2096128L,1023L,8386560L,2047L,33550336L,4095L,134209536L,8191L,536854528L,16383L,2147450880L,32767L,8589869056L,65535L,34359607296L,131071L,137438691328L,262143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278756Inst : IEnumerable<long>
{
public static readonly long[] Value=A278756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278756.Bytes);
public long this[int i]=>Value[i];

public static A278756Inst Instance=new A278756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278757
{
public static readonly BigInteger[] Value={ 1L,0L,11L,1010L,0L,111111L,0L,11111111L,0L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,0L,111111111111111111L,0L,11111111111111111111UL,0L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111111"),0L };
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
public class A278757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278757Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278757.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278757.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278757Inst Instance=new A278757Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278758
{
public static readonly BigInteger[] Value={ 1L,0L,110L,101L,0L,111111L,0L,11111111L,0L,1111111111L,0L,111111111111L,0L,11111111111111L,0L,1111111111111111L,0L,111111111111111111L,0L,11111111111111111111UL,0L,BigInteger.Parse("1111111111111111111111"),0L,BigInteger.Parse("111111111111111111111111"),0L,BigInteger.Parse("11111111111111111111111111"),0L };
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
public class A278758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278758Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278758.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278758.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278758Inst Instance=new A278758Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278759
{
public static readonly long[] Value={ 1L,0L,3L,10L,0L,63L,0L,255L,0L,1023L,0L,4095L,0L,16383L,0L,65535L,0L,262143L,0L,1048575L,0L,4194303L,0L,16777215L,0L,67108863L,0L,268435455L,0L,1073741823L,0L,4294967295L,0L,17179869183L,0L,68719476735L,0L,274877906943L,0L,1099511627775L,0L,4398046511103L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278759Inst : IEnumerable<long>
{
public static readonly long[] Value=A278759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278759.Bytes);
public long this[int i]=>Value[i];

public static A278759Inst Instance=new A278759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278760
{
public static readonly long[] Value={ 1L,0L,6L,5L,0L,63L,0L,255L,0L,1023L,0L,4095L,0L,16383L,0L,65535L,0L,262143L,0L,1048575L,0L,4194303L,0L,16777215L,0L,67108863L,0L,268435455L,0L,1073741823L,0L,4294967295L,0L,17179869183L,0L,68719476735L,0L,274877906943L,0L,1099511627775L,0L,4398046511103L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278760Inst : IEnumerable<long>
{
public static readonly long[] Value=A278760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278760.Bytes);
public long this[int i]=>Value[i];

public static A278760Inst Instance=new A278760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278761
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,1L,2L,4L,5L,6L,6L,7L,10L,10L,11L,12L,15L,16L,19L,20L,23L,25L,28L,30L,33L,35L,38L,40L,44L,47L,52L,54L,57L,59L,63L,65L,71L,73L,79L,81L,86L,89L,98L,101L,106L,108L,114L,117L,126L,130L,137L,142L,147L,150L,159L,162L,173L,178L,182L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278761Inst : IEnumerable<long>
{
public static readonly long[] Value=A278761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278761.Bytes);
public long this[int i]=>Value[i];

public static A278761Inst Instance=new A278761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278762
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,1L,2L,4L,2L,1L,3L,6L,5L,2L,1L,3L,9L,8L,5L,2L,1L,4L,12L,14L,9L,5L,2L,1L,4L,16L,20L,16L,9L,5L,2L,1L,5L,20L,30L,25L,17L,9L,5L,2L,1L,5L,25L,40L,39L,27L,17L,9L,5L,2L,1L,6L,30L,55L,56L,44L,28L,17L,9L,5L,2L,1L,6L,36L,70L,80L,65L,46L,28L,17L,9L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278762Inst : IEnumerable<long>
{
public static readonly long[] Value=A278762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278762.Bytes);
public long this[int i]=>Value[i];

public static A278762Inst Instance=new A278762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278763
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,2L,1L,2L,4L,2L,1L,2L,5L,6L,3L,1L,2L,5L,8L,9L,3L,1L,2L,5L,9L,14L,12L,4L,1L,2L,5L,9L,16L,20L,16L,4L,1L,2L,5L,9L,17L,25L,30L,20L,5L,1L,2L,5L,9L,17L,27L,39L,40L,25L,5L,1L,2L,5L,9L,17L,28L,44L,56L,55L,30L,6L,1L,2L,5L,9L,17L,28L,46L,65L,80L,70L,36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278763Inst : IEnumerable<long>
{
public static readonly long[] Value=A278763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278763.Bytes);
public long this[int i]=>Value[i];

public static A278763Inst Instance=new A278763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278764
{
public static readonly long[] Value={ 5L,13L,33L,83L,208L,521L,1305L,3268L,8183L,20490L,51306L,128467L,321673L,805448L,2016788L,5049902L,12644616L,31661270L,79277695L,198506027L,497045767L,1244569236L,3116317824L,7803050645L,19538315026L,48922629292L,122498979756L,306729222415L,768029383352L,1923094020999L,4815298338536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278764Inst : IEnumerable<long>
{
public static readonly long[] Value=A278764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278764.Bytes);
public long this[int i]=>Value[i];

public static A278764Inst Instance=new A278764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278765
{
public static readonly long[] Value={ 3L,3L,4L,4L,4L,6L,15L,48L,118L,147L,671L,1026L,3075L,44641L,48364L,1868380L,75080506L,96848501L,911582093L,2511879981L,8700005050L,15888441652L,108526838262L,446779835336L,632466801279L,1084794852728L,1184722346307L,1657692322844L,12376968750845L,17341469111712L,27996895637798L,38935285631573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278765Inst : IEnumerable<long>
{
public static readonly long[] Value=A278765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278765.Bytes);
public long this[int i]=>Value[i];

public static A278765Inst Instance=new A278765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278766
{
public static readonly long[] Value={ 1L,4L,4L,6L,6L,27L,74L,86L,372L,853L,947L,1475L,3686L,9084L,19174L,30737L,1530833L,2401466L,2521253L,3649563L,3802245L,9320024L,1092256819L,2114664794L,2878948610L,8842525055L,13769551820L,26996892389L,215947176106L,269439735691L,13694290818678L,18312336654245L,19649485782723L,63266709043539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278766Inst : IEnumerable<long>
{
public static readonly long[] Value=A278766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278766.Bytes);
public long this[int i]=>Value[i];

public static A278766Inst Instance=new A278766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278767
{
public static readonly long[] Value={ 1L,1L,7L,22L,71L,206L,616L,1712L,4743L,12677L,33407L,86085L,218677L,546060L,1345840L,3271893L,7861239L,18670881L,43883904L,102112483L,235401947L,537869136L,1218743007L,2739566083L,6111766043L,13536683750L,29775945929L,65065819486L,141285315728L,304935221675L,654318376244L,1396166024244L,2963068779402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278767Inst : IEnumerable<long>
{
public static readonly long[] Value=A278767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278767.Bytes);
public long this[int i]=>Value[i];

public static A278767Inst Instance=new A278767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278768
{
public static readonly long[] Value={ 1L,1L,6L,18L,55L,150L,424L,1113L,2923L,7401L,18510L,45271L,109297L,259447L,608428L,1407958L,3222132L,7292198L,16340830L,36265672L,79775931L,173999194L,376497975L,808471181L,1723592762L,3649271887L,7675809680L,16043777217L,33332888108L,68853608216L,141438908854L,288994878713L,587458691042L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278768Inst : IEnumerable<long>
{
public static readonly long[] Value=A278768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278768.Bytes);
public long this[int i]=>Value[i];

public static A278768Inst Instance=new A278768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278769
{
public static readonly long[] Value={ 1L,1L,8L,26L,88L,269L,843L,2456L,7115L,19892L,54756L,147355L,390517L,1017091L,2612670L,6617641L,16556913L,40933339L,100104289L,242276236L,580718077L,1379161494L,3247074738L,7581837910L,17564867853L,40388447308L,92206496318L,209069338580L,470944571003L,1054178579266L,2345477963043L,5188246121144L,11412352653001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278769Inst : IEnumerable<long>
{
public static readonly long[] Value=A278769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278769.Bytes);
public long this[int i]=>Value[i];

public static A278769Inst Instance=new A278769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278770
{
public static readonly BigInteger[] Value={ 1L,4L,159L,81296L,585396881L,61994262028020L,BigInteger.Parse("98925461617709743975"),BigInteger.Parse("2414583243140269424293854400"),BigInteger.Parse("910504281815476426073145299359052745"),BigInteger.Parse("5341354769384557074743892800174971438265757284"),BigInteger.Parse("489946515248844365403775650233194419858267427195735348151"),BigInteger.Parse("705379807799940807283682167156246485805791300481296966713394135535056") };
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
public class A278770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278770Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278770.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278770.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278770Inst Instance=new A278770Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278771
{
public static readonly BigInteger[] Value={ 0L,2L,266L,19750L,1673658L,251740932L,90752836672L,93037538287080L,293564184229043556L,BigInteger.Parse("2953569640505846392444") };
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
public class A278771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278771Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278771.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278771.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278771Inst Instance=new A278771Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278852
{
public static readonly long[] Value={ 0L,239L,15066L,449677L,9317846L,154090507L,2167109763L,26799758534L,297417275848L,3004658410735L,27940725989130L,241350612592135L,1951440294582041L,14865802497447044L,107290958051308517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278852Inst : IEnumerable<long>
{
public static readonly long[] Value=A278852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278852.Bytes);
public long this[int i]=>Value[i];

public static A278852Inst Instance=new A278852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278853
{
public static readonly BigInteger[] Value={ 1L,1486L,118158L,4950399L,154090507L,4026240722L,92891826961L,1935392159582L,36831668321915L,644951602341507L,10454319538089429L,157736949429737228L,2227039251935175027L,BigInteger.Parse("29569631792451694669"),BigInteger.Parse("370951068728197563294") };
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
public class A278853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278853Inst Instance=new A278853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278854
{
public static readonly BigInteger[] Value={ 8L,7072L,731444L,44571591L,2167109763L,92891826961L,3637198028018L,131770344218055L,4438698421228261L,139356074010503663L,4085772882929981162L,BigInteger.Parse("112111211337670010640"),BigInteger.Parse("2886455827088580869876"),BigInteger.Parse("69931800720183748326477") };
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
public class A278854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278854Inst Instance=new A278854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278855
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,0L,25L,66L,25L,0L,1L,239L,1348L,1348L,239L,1L,8L,1486L,15066L,30772L,15066L,1486L,8L,36L,7072L,118158L,449677L,449677L,118158L,7072L,36L,120L,27828L,731444L,4950399L,9317846L,4950399L,731444L,27828L,120L,330L,94720L,3813048L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278855Inst : IEnumerable<long>
{
public static readonly long[] Value=A278855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278855.Bytes);
public long this[int i]=>Value[i];

public static A278855Inst Instance=new A278855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278856
{
public static readonly long[] Value={ 0L,1L,10L,12L,2L,13L,3L,4L,14L,5L,6L,7L,15L,8L,9L,20L,16L,22L,23L,21L,24L,25L,26L,31L,27L,28L,29L,30L,17L,32L,33L,34L,35L,18L,36L,37L,38L,39L,41L,40L,42L,43L,44L,45L,51L,46L,47L,48L,49L,50L,52L,19L,53L,54L,55L,56L,57L,58L,100L,59L,60L,62L,63L,64L,65L,102L,66L,67L,68L,69L,70L,72L,61L,73L,74L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278856Inst : IEnumerable<long>
{
public static readonly long[] Value=A278856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278856.Bytes);
public long this[int i]=>Value[i];

public static A278856Inst Instance=new A278856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278857
{
public static readonly BigInteger[] Value={ 1L,0L,1L,8L,676L,49600L,10335908L,2658757248L,1214367336000L,730771063280640L,642638269862752320L,BigInteger.Parse("736176718456263406080"),BigInteger.Parse("1122592471007868379259136"),BigInteger.Parse("2168016139899273930219233280"),BigInteger.Parse("5288852927890824307509101287680"),BigInteger.Parse("15889369670472598370104100032512000") };
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
public class A278857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278857Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278857.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278857.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278857Inst Instance=new A278857Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278858
{
public static readonly BigInteger[] Value={ 1L,0L,9L,240L,36864L,7741440L,3363235524L,2203143038208L,2248347011420160L,3260265586467690240L,BigInteger.Parse("6578570637254005920000"),BigInteger.Parse("17755898734939822501524480"),BigInteger.Parse("62673017366111480630785474560"),BigInteger.Parse("282641923592380319367599892725760"),BigInteger.Parse("1599753679036773033206787507696238848") };
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
public class A278858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278858Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278858.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278858.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278858Inst Instance=new A278858Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278859
{
public static readonly long[] Value={ 1L,0L,3L,8L,1L,56L,15L,226L,8L,1007L,2L,4080L,55L,16336L,159L,65204L,151L,261876L,23L,1048180L,983L,4192260L,479L,16775492L,3447L,67101776L,2835L,268428154L,14672L,1073740559L,47204L,4294883375L,14436L,17179867263L,47212L,68719392871L,14450L,274877773932L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278859Inst : IEnumerable<long>
{
public static readonly long[] Value=A278859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278859.Bytes);
public long this[int i]=>Value[i];

public static A278859Inst Instance=new A278859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278860
{
public static readonly BigInteger[] Value={ 1L,1L,92L,7207016256L,BigInteger.Parse("22448940392028699561050505216"),BigInteger.Parse("462177945344267713413229252637478222244311831261385379020800000") };
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
public class A278860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278860Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278860.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278860.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278860Inst Instance=new A278860Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278861
{
public static readonly long[] Value={ 0L,1L,2L,3L,30L,31L,4L,32L,5L,6L,34L,7L,8L,9L,35L,10L,11L,36L,12L,14L,13L,15L,16L,17L,23L,18L,19L,20L,21L,37L,22L,24L,25L,26L,38L,27L,28L,29L,40L,43L,41L,42L,44L,45L,46L,53L,47L,48L,49L,50L,51L,52L,39L,54L,55L,56L,57L,58L,59L,300L,60L,61L,62L,64L,65L,66L,301L,67L,68L,69L,70L,71L,72L,63L,74L,75L,76L,77L,78L,79L,80L,81L,302L,82L,84L,85L,86L,87L,88L,89L,73L,90L,91L,92L,94L,95L,96L,97L,98L,99L,304L,100L,101L,102L,104L,105L,103L,106L,107L,108L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278861Inst : IEnumerable<long>
{
public static readonly long[] Value=A278861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278861.Bytes);
public long this[int i]=>Value[i];

public static A278861Inst Instance=new A278861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278862
{
public static readonly long[] Value={ 157441L,177617L,178637L,226891L,374359L,900745L,1456223L,1526983L,1545227L,1817999L,2232815L,2274595L,2320643L,2336935L,2363383L,2404487L,2461559L,2536595L,2812451L,2877463L,2893769L,2910811L,2912446L,3046915L,3053999L,3090575L,3105319L,3382141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278862Inst : IEnumerable<long>
{
public static readonly long[] Value=A278862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278862.Bytes);
public long this[int i]=>Value[i];

public static A278862Inst Instance=new A278862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278863
{
public static readonly long[] Value={ 1L,0L,6L,1L,16L,7L,120L,71L,32L,991L,512L,255L,7552L,767L,31872L,11647L,119296L,48639L,475136L,190463L,1931264L,526335L,8241152L,2269183L,31285248L,2662399L,105283584L,99385343L,22249472L,1010302975L,319717376L,4095574015L,1278738432L,17054040063L,7262961664L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A278863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278863Inst : IEnumerable<long>
{
public static readonly long[] Value=A278863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A278863.Bytes);
public long this[int i]=>Value[i];

public static A278863Inst Instance=new A278863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A278864
{
public static readonly BigInteger[] Value={ 1L,0L,11L,1000L,1L,111000L,11L,11111000L,1L,1111101100L,11L,111111001000L,11L,11111110001000L,1000001L,1111111111011100L,110001011L,111111110000101000L,11000111L,11111111111000000010UL,111111000L,BigInteger.Parse("1111111111110011010111"),1000010010L,BigInteger.Parse("111111111111010011000000") };
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
public class A278864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A278864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A278864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A278864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A278864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A278864Inst Instance=new A278864Inst();

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