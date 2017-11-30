using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A190409
{
public static readonly long[] Value={ 1L,6L,1L,4L,4L,8L,1L,5L,9L,5L,6L,5L,5L,1L,8L,7L,5L,9L,9L,3L,8L,3L,6L,7L,6L,6L,8L,6L,4L,4L,1L,9L,9L,8L,5L,5L,1L,2L,6L,2L,4L,3L,0L,9L,5L,3L,3L,4L,8L,2L,5L,1L,8L,1L,3L,5L,3L,8L,2L,0L,4L,9L,9L,0L,8L,7L,6L,3L,1L,5L,6L,7L,2L,5L,7L,3L,5L,7L,4L,7L,7L,4L,6L,5L,4L,4L,1L,9L,5L,5L,0L,6L,9L,9L,7L,1L,3L,5L,3L,7L,0L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190409Inst : IEnumerable<long>
{
public static readonly long[] Value=A190409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190409.Bytes);
public long this[int i]=>Value[i];

public static A190409Inst Instance=new A190409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190410
{
public static readonly long[] Value={ 7L,0L,8L,6L,5L,9L,0L,1L,3L,1L,1L,7L,2L,3L,6L,7L,1L,5L,3L,6L,9L,6L,4L,8L,5L,9L,2L,0L,5L,2L,6L,7L,6L,3L,3L,3L,2L,0L,1L,5L,9L,6L,9L,4L,1L,3L,2L,0L,4L,0L,5L,0L,9L,7L,2L,8L,8L,7L,0L,4L,3L,7L,3L,2L,1L,4L,3L,4L,6L,4L,3L,5L,1L,6L,8L,4L,7L,4L,7L,3L,5L,9L,9L,8L,8L,9L,6L,6L,7L,8L,9L,4L,4L,4L,2L,4L,3L,9L,8L,0L,6L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190410Inst : IEnumerable<long>
{
public static readonly long[] Value=A190410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190410.Bytes);
public long this[int i]=>Value[i];

public static A190410Inst Instance=new A190410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190411
{
public static readonly long[] Value={ 2L,9L,1L,3L,4L,0L,9L,8L,6L,8L,8L,2L,7L,6L,3L,2L,8L,4L,6L,3L,0L,3L,5L,1L,4L,0L,7L,9L,4L,7L,3L,2L,3L,6L,6L,6L,7L,9L,8L,4L,0L,3L,0L,5L,8L,6L,7L,9L,5L,9L,4L,9L,0L,2L,7L,1L,1L,2L,9L,5L,6L,2L,6L,7L,8L,5L,6L,5L,3L,5L,6L,4L,8L,3L,1L,5L,2L,5L,2L,6L,4L,0L,0L,1L,1L,0L,3L,3L,2L,1L,0L,5L,5L,5L,7L,5L,6L,0L,1L,9L,3L,2L,5L,2L,9L,6L,7L,9L,9L,0L,7L,9L,6L,5L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190411Inst : IEnumerable<long>
{
public static readonly long[] Value=A190411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190411.Bytes);
public long this[int i]=>Value[i];

public static A190411Inst Instance=new A190411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190764
{
public static readonly long[] Value={ 2L,5L,6L,9L,12L,13L,15L,16L,19L,22L,23L,26L,29L,30L,32L,33L,36L,37L,39L,40L,43L,46L,47L,50L,53L,54L,56L,57L,60L,63L,64L,67L,70L,71L,73L,74L,77L,78L,80L,81L,84L,87L,88L,90L,91L,94L,95L,97L,98L,101L,104L,105L,108L,111L,112L,114L,115L,118L,121L,122L,125L,128L,129L,131L,132L,135L,136L,138L,139L,142L,145L,146L,149L,152L,153L,155L,156L,159L,162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190764Inst : IEnumerable<long>
{
public static readonly long[] Value=A190764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190764.Bytes);
public long this[int i]=>Value[i];

public static A190764Inst Instance=new A190764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190765
{
public static readonly long[] Value={ 1L,4L,7L,8L,11L,14L,18L,21L,24L,25L,28L,31L,35L,38L,41L,42L,45L,48L,49L,52L,55L,59L,62L,65L,66L,69L,72L,76L,79L,82L,83L,86L,89L,93L,96L,100L,103L,106L,107L,110L,113L,117L,120L,123L,124L,127L,130L,134L,137L,140L,141L,144L,147L,148L,151L,154L,158L,161L,164L,165L,168L,171L,175L,178L,181L,182L,185L,188L,192L,195L,199L,202L,205L,206L,209L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190765Inst : IEnumerable<long>
{
public static readonly long[] Value=A190765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190765.Bytes);
public long this[int i]=>Value[i];

public static A190765Inst Instance=new A190765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190766
{
public static readonly long[] Value={ 2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,1L,1L,0L,2L,1L,0L,2L,1L,0L,0L,2L,1L,0L,2L,1L,0L,2L,2L,1L,0L,2L,1L,0L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190766Inst : IEnumerable<long>
{
public static readonly long[] Value=A190766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190766.Bytes);
public long this[int i]=>Value[i];

public static A190766Inst Instance=new A190766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190767
{
public static readonly long[] Value={ 3L,6L,10L,13L,16L,17L,20L,23L,27L,30L,34L,37L,40L,44L,47L,51L,54L,57L,58L,61L,64L,68L,71L,74L,75L,78L,81L,85L,88L,92L,95L,98L,99L,102L,105L,109L,112L,115L,116L,119L,122L,126L,129L,133L,136L,139L,143L,146L,150L,153L,156L,157L,160L,163L,167L,170L,173L,174L,177L,180L,184L,187L,191L,194L,197L,198L,201L,204L,208L,211L,214L,215L,218L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190767Inst : IEnumerable<long>
{
public static readonly long[] Value=A190767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190767.Bytes);
public long this[int i]=>Value[i];

public static A190767Inst Instance=new A190767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190768
{
public static readonly long[] Value={ 2L,5L,8L,9L,12L,15L,19L,22L,26L,29L,32L,33L,36L,39L,43L,46L,49L,50L,53L,56L,60L,63L,67L,70L,73L,77L,80L,84L,87L,90L,91L,94L,97L,101L,104L,107L,108L,111L,114L,118L,121L,125L,128L,131L,132L,135L,138L,142L,145L,148L,149L,152L,155L,159L,162L,166L,169L,172L,176L,179L,183L,186L,189L,190L,193L,196L,200L,203L,206L,207L,210L,213L,217L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190768Inst : IEnumerable<long>
{
public static readonly long[] Value=A190768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190768.Bytes);
public long this[int i]=>Value[i];

public static A190768Inst Instance=new A190768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190769
{
public static readonly long[] Value={ 1L,4L,7L,11L,14L,18L,21L,24L,25L,28L,31L,35L,38L,41L,42L,45L,48L,52L,55L,59L,62L,65L,66L,69L,72L,76L,79L,82L,83L,86L,89L,93L,96L,100L,103L,106L,110L,113L,117L,120L,123L,124L,127L,130L,134L,137L,140L,141L,144L,147L,151L,154L,158L,161L,164L,165L,168L,171L,175L,178L,181L,182L,185L,188L,192L,195L,199L,202L,205L,209L,212L,216L,219L,222L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190769Inst : IEnumerable<long>
{
public static readonly long[] Value=A190769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190769.Bytes);
public long this[int i]=>Value[i];

public static A190769Inst Instance=new A190769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190770
{
public static readonly long[] Value={ 2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,2L,1L,3L,2L,1L,3L,2L,1L,0L,3L,2L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190770Inst : IEnumerable<long>
{
public static readonly long[] Value=A190770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190770.Bytes);
public long this[int i]=>Value[i];

public static A190770Inst Instance=new A190770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190771
{
public static readonly long[] Value={ 10L,17L,27L,34L,51L,58L,68L,75L,92L,99L,109L,116L,126L,133L,150L,157L,167L,174L,191L,198L,208L,215L,232L,249L,256L,266L,273L,290L,297L,307L,314L,331L,338L,348L,355L,365L,372L,389L,396L,406L,413L,430L,437L,447L,454L,464L,471L,488L,495L,505L,512L,529L,536L,546L,553L,570L,577L,587L,594L,604L,611L,628L,635L,645L,652L,669L,676L,686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190771Inst : IEnumerable<long>
{
public static readonly long[] Value=A190771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190771.Bytes);
public long this[int i]=>Value[i];

public static A190771Inst Instance=new A190771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190772
{
public static readonly long[] Value={ 2L,3L,6L,9L,13L,16L,20L,23L,26L,30L,33L,37L,40L,43L,44L,47L,50L,54L,57L,60L,61L,64L,67L,71L,74L,78L,81L,84L,85L,88L,91L,95L,98L,101L,102L,105L,108L,112L,115L,119L,122L,125L,129L,132L,136L,139L,142L,143L,146L,149L,153L,156L,159L,160L,163L,166L,170L,173L,177L,180L,183L,184L,187L,190L,194L,197L,200L,201L,204L,207L,211L,214L,218L,221L,224L,228L,231L,235L,238L,241L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190772Inst : IEnumerable<long>
{
public static readonly long[] Value=A190772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190772.Bytes);
public long this[int i]=>Value[i];

public static A190772Inst Instance=new A190772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190773
{
public static readonly long[] Value={ 1L,5L,8L,12L,15L,18L,19L,22L,25L,29L,32L,35L,36L,39L,42L,46L,49L,53L,56L,59L,63L,66L,70L,73L,76L,77L,80L,83L,87L,90L,93L,94L,97L,100L,104L,107L,111L,114L,117L,118L,121L,124L,128L,131L,134L,135L,138L,141L,145L,148L,152L,155L,158L,162L,165L,169L,172L,175L,176L,179L,182L,186L,189L,193L,196L,199L,203L,206L,210L,213L,216L,217L,220L,223L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190773Inst : IEnumerable<long>
{
public static readonly long[] Value=A190773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190773.Bytes);
public long this[int i]=>Value[i];

public static A190773Inst Instance=new A190773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190774
{
public static readonly long[] Value={ 4L,7L,11L,14L,21L,24L,28L,31L,38L,41L,45L,48L,52L,55L,62L,65L,69L,72L,79L,82L,86L,89L,96L,103L,106L,110L,113L,120L,123L,127L,130L,137L,140L,144L,147L,151L,154L,161L,164L,168L,171L,178L,181L,185L,188L,192L,195L,202L,205L,209L,212L,219L,222L,226L,229L,236L,239L,243L,246L,250L,253L,260L,263L,267L,270L,277L,280L,284L,287L,291L,294L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190774Inst : IEnumerable<long>
{
public static readonly long[] Value=A190774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190774.Bytes);
public long this[int i]=>Value[i];

public static A190774Inst Instance=new A190774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190775
{
public static readonly long[] Value={ 2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L,0L,2L,1L,0L,2L,2L,1L,3L,2L,1L,0L,2L,1L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190775Inst : IEnumerable<long>
{
public static readonly long[] Value=A190775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190775.Bytes);
public long this[int i]=>Value[i];

public static A190775Inst Instance=new A190775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190776
{
public static readonly long[] Value={ 3L,10L,13L,17L,20L,27L,34L,37L,44L,51L,54L,58L,61L,68L,75L,78L,85L,92L,95L,99L,102L,109L,116L,119L,126L,133L,136L,143L,150L,153L,157L,160L,167L,174L,177L,184L,191L,194L,198L,201L,208L,215L,218L,225L,232L,235L,242L,249L,252L,256L,259L,266L,273L,276L,283L,290L,293L,297L,300L,307L,314L,317L,324L,331L,334L,338L,341L,348L,351L,355L,358L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190776Inst : IEnumerable<long>
{
public static readonly long[] Value=A190776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190776.Bytes);
public long this[int i]=>Value[i];

public static A190776Inst Instance=new A190776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190777
{
public static readonly long[] Value={ 2L,6L,9L,12L,16L,19L,23L,26L,29L,30L,33L,36L,40L,43L,46L,47L,50L,53L,57L,60L,64L,67L,70L,71L,74L,77L,81L,84L,87L,88L,91L,94L,98L,101L,105L,108L,111L,112L,115L,118L,122L,125L,128L,129L,132L,135L,139L,142L,146L,149L,152L,156L,159L,163L,166L,169L,170L,173L,176L,180L,183L,186L,187L,190L,193L,197L,200L,204L,207L,210L,211L,214L,217L,221L,224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190777Inst : IEnumerable<long>
{
public static readonly long[] Value=A190777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190777.Bytes);
public long this[int i]=>Value[i];

public static A190777Inst Instance=new A190777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190778
{
public static readonly long[] Value={ 1L,4L,5L,8L,11L,15L,18L,21L,22L,25L,28L,32L,35L,39L,42L,45L,49L,52L,56L,59L,62L,63L,66L,69L,73L,76L,79L,80L,83L,86L,90L,93L,97L,100L,103L,104L,107L,110L,114L,117L,120L,121L,124L,127L,131L,134L,138L,141L,144L,145L,148L,151L,155L,158L,161L,162L,165L,168L,172L,175L,179L,182L,185L,189L,192L,196L,199L,202L,203L,206L,209L,213L,216L,219L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190778Inst : IEnumerable<long>
{
public static readonly long[] Value=A190778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190778.Bytes);
public long this[int i]=>Value[i];

public static A190778Inst Instance=new A190778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190779
{
public static readonly long[] Value={ 7L,14L,24L,31L,38L,41L,48L,55L,65L,72L,82L,89L,96L,106L,113L,123L,130L,137L,140L,147L,154L,164L,171L,178L,181L,188L,195L,205L,212L,222L,229L,236L,239L,246L,253L,263L,270L,277L,280L,287L,294L,304L,311L,321L,328L,335L,345L,352L,362L,369L,376L,379L,386L,393L,403L,410L,417L,420L,427L,434L,444L,451L,461L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190779Inst : IEnumerable<long>
{
public static readonly long[] Value=A190779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190779.Bytes);
public long this[int i]=>Value[i];

public static A190779Inst Instance=new A190779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190796
{
public static readonly long[] Value={ 1L,4L,5L,5L,8L,8L,9L,9L,9L,9L,9L,12L,12L,12L,12L,12L,12L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,13L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190796Inst : IEnumerable<long>
{
public static readonly long[] Value=A190796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190796.Bytes);
public long this[int i]=>Value[i];

public static A190796Inst Instance=new A190796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190797
{
public static readonly long[] Value={ 11L,23L,41L,83L,107L,167L,191L,263L,307L,347L,367L,461L,641L,653L,877L,881L,1103L,1187L,1367L,2081L,2393L,2677L,3607L,4283L,4357L,4967L,5081L,5231L,5387L,5471L,5651L,6037L,6197L,6311L,6353L,6857L,7823L,8117L,8693L,8747L,9221L,9743L,9851L,9923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190797Inst : IEnumerable<long>
{
public static readonly long[] Value=A190797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190797.Bytes);
public long this[int i]=>Value[i];

public static A190797Inst Instance=new A190797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190798
{
public static readonly long[] Value={ 0L,0L,1L,4L,9L,18L,32L,50L,75L,108L,147L,196L,256L,324L,405L,500L,605L,726L,864L,1014L,1183L,1372L,1575L,1800L,2048L,2312L,2601L,2916L,3249L,3610L,4000L,4410L,4851L,5324L,5819L,6348L,6912L,7500L,8125L,8788L,9477L,10206L,10976L,11774L,12615L,13500L,14415L,15376L,16384L,17424L,18513L,19652L,20825L,22050L,23328L,24642L,26011L,27436L,28899L,30420L,32000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190798Inst : IEnumerable<long>
{
public static readonly long[] Value=A190798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190798.Bytes);
public long this[int i]=>Value[i];

public static A190798Inst Instance=new A190798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190799
{
public static readonly long[] Value={ 47L,83L,131L,137L,173L,191L,251L,257L,347L,419L,443L,557L,587L,593L,1013L,1019L,1031L,1049L,1217L,1301L,1427L,1433L,1439L,1979L,1997L,2069L,2267L,2531L,2657L,2687L,2693L,2699L,2711L,3251L,3299L,3539L,4007L,4211L,4241L,4253L,4643L,4931L,5003L,5099L,5399L,5501L,5861L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190799Inst : IEnumerable<long>
{
public static readonly long[] Value=A190799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190799.Bytes);
public long this[int i]=>Value[i];

public static A190799Inst Instance=new A190799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190800
{
public static readonly long[] Value={ 11L,17L,41L,844427L,51448361L,51867197L,85776137L,86966771L,93685301L,97122197L,107599757L,113575727L,118136267L,122983031L,180078317L,232728647L,316973621L,483040757L,564537761L,749930717L,840472307L,901288517L,960959381L,1278189947L,1559839991L,1696818647L,1761702947L,1829187287L,2251028567L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190800Inst : IEnumerable<long>
{
public static readonly long[] Value=A190800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190800.Bytes);
public long this[int i]=>Value[i];

public static A190800Inst Instance=new A190800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190801
{
public static readonly ulong[] Value={ 6L,15L,55L,145L,889L,5089L,55561L,927889L,6169249L,39916921L,678585889L,13891047241L,417210398089L,1656387533161L,56229997825849L,481224167424529L,11026310270976961L,236887827111937369L,10826413936386055921UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190801Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A190801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190801.Bytes);
public ulong this[int i]=>Value[i];

public static A190801Inst Instance=new A190801Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190802
{
public static readonly long[] Value={ 5L,29L,177L,1245L,9629L,78627L,664917L,5762208L,50849234L,455055614L,4118066400L,37607950280L,346065645809L,3204942065691L,29844571475287L,279238344248556L,2623557165610821L,24739954309690414L,234057667376222381L,2220819602783663483L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190802Inst : IEnumerable<long>
{
public static readonly long[] Value=A190802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190802.Bytes);
public long this[int i]=>Value[i];

public static A190802Inst Instance=new A190802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190803
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,9L,14L,15L,17L,23L,26L,27L,29L,33L,41L,44L,45L,50L,51L,53L,57L,65L,68L,77L,80L,81L,86L,87L,89L,98L,99L,101L,105L,113L,122L,129L,131L,134L,135L,149L,152L,153L,158L,159L,161L,170L,171L,173L,177L,194L,195L,197L,201L,203L,209L,225L,230L,239L,242L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190803Inst : IEnumerable<long>
{
public static readonly long[] Value=A190803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190803.Bytes);
public long this[int i]=>Value[i];

public static A190803Inst Instance=new A190803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190804
{
public static readonly long[] Value={ 1L,3L,5L,9L,15L,17L,27L,29L,33L,45L,51L,53L,57L,65L,81L,87L,89L,99L,101L,105L,113L,129L,135L,153L,159L,161L,171L,173L,177L,195L,197L,201L,209L,225L,243L,257L,261L,267L,269L,297L,303L,305L,315L,317L,321L,339L,341L,345L,353L,387L,389L,393L,401L,405L,417L,449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190804Inst : IEnumerable<long>
{
public static readonly long[] Value=A190804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190804.Bytes);
public long this[int i]=>Value[i];

public static A190804Inst Instance=new A190804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190805
{
public static readonly long[] Value={ 1L,4L,7L,13L,22L,25L,40L,43L,49L,67L,76L,79L,85L,97L,121L,130L,133L,148L,151L,157L,169L,193L,202L,229L,238L,241L,256L,259L,265L,292L,295L,301L,313L,337L,364L,385L,391L,400L,403L,445L,454L,457L,472L,475L,481L,508L,511L,517L,529L,580L,583L,589L,601L,607L,625L,673L,688L,715L,724L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190805Inst : IEnumerable<long>
{
public static readonly long[] Value=A190805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190805.Bytes);
public long this[int i]=>Value[i];

public static A190805Inst Instance=new A190805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190806
{
public static readonly long[] Value={ 1L,5L,9L,17L,29L,33L,53L,57L,65L,89L,101L,105L,113L,129L,161L,173L,177L,197L,201L,209L,225L,257L,269L,305L,317L,321L,341L,345L,353L,389L,393L,401L,417L,449L,485L,513L,521L,533L,537L,593L,605L,609L,629L,633L,641L,677L,681L,689L,705L,773L,777L,785L,801L,809L,833L,897L,917L,953L,965L,969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190806Inst : IEnumerable<long>
{
public static readonly long[] Value=A190806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190806.Bytes);
public long this[int i]=>Value[i];

public static A190806Inst Instance=new A190806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190807
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,11L,14L,16L,20L,22L,23L,28L,29L,32L,40L,41L,44L,46L,47L,56L,58L,59L,64L,65L,68L,80L,82L,83L,86L,88L,92L,94L,95L,112L,116L,118L,119L,122L,128L,130L,131L,136L,137L,140L,160L,164L,166L,167L,172L,173L,176L,184L,188L,190L,191L,194L,203L,224L,232L,236L,238L,239L,244L,245L,248L,256L,257L,260L,262L,263L,272L,274L,275L,280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190807Inst : IEnumerable<long>
{
public static readonly long[] Value=A190807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190807.Bytes);
public long this[int i]=>Value[i];

public static A190807Inst Instance=new A190807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190808
{
public static readonly long[] Value={ 1L,2L,4L,7L,8L,13L,14L,16L,22L,25L,26L,28L,32L,40L,43L,44L,49L,50L,52L,56L,64L,67L,76L,79L,80L,85L,86L,88L,97L,98L,100L,104L,112L,121L,128L,130L,133L,134L,148L,151L,152L,157L,158L,160L,169L,170L,172L,176L,193L,194L,196L,200L,202L,208L,224L,229L,238L,241L,242L,256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190808Inst : IEnumerable<long>
{
public static readonly long[] Value=A190808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190808.Bytes);
public long this[int i]=>Value[i];

public static A190808Inst Instance=new A190808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190809
{
public static readonly long[] Value={ 1L,2L,4L,5L,8L,10L,14L,16L,17L,20L,26L,28L,32L,34L,40L,44L,50L,52L,53L,56L,62L,64L,68L,80L,86L,88L,98L,100L,104L,106L,112L,122L,124L,128L,134L,136L,152L,158L,160L,161L,170L,172L,176L,188L,194L,196L,200L,206L,208L,212L,224L,242L,244L,248L,256L,260L,266L,268L,272L,296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190809Inst : IEnumerable<long>
{
public static readonly long[] Value=A190809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190809.Bytes);
public long this[int i]=>Value[i];

public static A190809Inst Instance=new A190809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190810
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,14L,15L,17L,20L,23L,29L,31L,32L,35L,41L,44L,47L,50L,59L,63L,65L,68L,71L,83L,86L,89L,92L,95L,101L,104L,119L,122L,127L,131L,137L,140L,143L,149L,167L,173L,176L,179L,185L,188L,191L,194L,203L,209L,212L,239L,245L,248L,255L,257L,263L,266L,275L,281L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190810Inst : IEnumerable<long>
{
public static readonly long[] Value=A190810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190810.Bytes);
public long this[int i]=>Value[i];

public static A190810Inst Instance=new A190810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A190811
{
public static readonly long[] Value={ 1L,3L,7L,9L,15L,19L,21L,27L,31L,39L,43L,45L,55L,57L,63L,79L,81L,87L,91L,93L,111L,115L,117L,127L,129L,135L,159L,163L,165L,171L,175L,183L,187L,189L,223L,231L,235L,237L,243L,255L,259L,261L,271L,273L,279L,319L,327L,331L,333L,343L,345L,351L,367L,375L,379L,381L,387L,405L,447L,463L,471L,475L,477L,487L,489L,495L,511L,513L,519L,523L,525L,543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A190811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A190811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A190811Inst : IEnumerable<long>
{
public static readonly long[] Value=A190811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A190811.Bytes);
public long this[int i]=>Value[i];

public static A190811Inst Instance=new A190811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191020
{
public static readonly long[] Value={ 13L,19L,23L,29L,31L,43L,47L,61L,71L,83L,89L,97L,101L,103L,107L,109L,113L,131L,137L,139L,149L,173L,191L,197L,199L,211L,223L,227L,257L,277L,283L,293L,307L,311L,313L,347L,349L,353L,367L,373L,383L,401L,433L,449L,461L,463L,487L,491L,521L,523L,541L,547L,557L,563L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191020Inst : IEnumerable<long>
{
public static readonly long[] Value=A191020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191020.Bytes);
public long this[int i]=>Value[i];

public static A191020Inst Instance=new A191020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191021
{
public static readonly long[] Value={ 2L,3L,13L,29L,31L,41L,47L,59L,71L,73L,101L,127L,131L,139L,151L,163L,167L,173L,179L,193L,197L,211L,223L,233L,239L,257L,269L,271L,277L,307L,311L,317L,331L,347L,349L,353L,397L,409L,439L,443L,449L,461L,463L,487L,491L,499L,509L,541L,547L,577L,587L,593L,599L,601L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191021Inst : IEnumerable<long>
{
public static readonly long[] Value=A191021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191021.Bytes);
public long this[int i]=>Value[i];

public static A191021Inst Instance=new A191021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191022
{
public static readonly long[] Value={ 5L,7L,13L,23L,53L,59L,67L,71L,83L,103L,107L,109L,139L,149L,151L,167L,173L,179L,181L,197L,199L,223L,227L,233L,239L,241L,257L,277L,281L,283L,313L,347L,349L,353L,373L,383L,397L,401L,419L,431L,439L,457L,463L,487L,499L,509L,521L,523L,547L,557L,571L,587L,593L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191022Inst : IEnumerable<long>
{
public static readonly long[] Value=A191022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191022.Bytes);
public long this[int i]=>Value[i];

public static A191022Inst Instance=new A191022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191023
{
public static readonly long[] Value={ 11L,13L,17L,23L,29L,31L,37L,43L,47L,59L,67L,79L,101L,113L,131L,137L,149L,151L,157L,163L,167L,179L,199L,233L,241L,251L,257L,263L,269L,271L,277L,283L,307L,353L,373L,383L,389L,397L,409L,419L,439L,461L,491L,503L,509L,523L,547L,593L,601L,613L,617L,631L,643L,647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191023Inst : IEnumerable<long>
{
public static readonly long[] Value=A191023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191023.Bytes);
public long this[int i]=>Value[i];

public static A191023Inst Instance=new A191023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191024
{
public static readonly long[] Value={ 2L,5L,7L,19L,41L,47L,59L,67L,71L,97L,101L,103L,107L,109L,113L,131L,149L,157L,163L,173L,191L,193L,211L,227L,233L,257L,281L,283L,293L,307L,311L,317L,349L,359L,373L,379L,397L,419L,421L,431L,439L,443L,467L,479L,503L,521L,541L,547L,563L,577L,593L,599L,607L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191024Inst : IEnumerable<long>
{
public static readonly long[] Value=A191024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191024.Bytes);
public long this[int i]=>Value[i];

public static A191024Inst Instance=new A191024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191025
{
public static readonly long[] Value={ 3L,5L,11L,29L,37L,47L,61L,89L,103L,107L,109L,127L,131L,137L,139L,151L,163L,173L,181L,191L,197L,211L,223L,227L,239L,257L,263L,269L,271L,277L,281L,283L,317L,347L,353L,359L,379L,383L,397L,409L,419L,433L,457L,463L,499L,541L,547L,569L,571L,577L,593L,599L,619L,631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191025Inst : IEnumerable<long>
{
public static readonly long[] Value=A191025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191025.Bytes);
public long this[int i]=>Value[i];

public static A191025Inst Instance=new A191025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191026
{
public static readonly long[] Value={ 3L,11L,13L,17L,29L,47L,71L,73L,79L,83L,97L,103L,109L,149L,151L,157L,167L,173L,179L,191L,211L,223L,227L,239L,257L,281L,283L,293L,307L,313L,331L,353L,359L,367L,379L,383L,389L,397L,401L,421L,431L,433L,449L,467L,491L,499L,503L,523L,541L,563L,569L,571L,577L,587L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191026Inst : IEnumerable<long>
{
public static readonly long[] Value=A191026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191026.Bytes);
public long this[int i]=>Value[i];

public static A191026Inst Instance=new A191026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191027
{
public static readonly long[] Value={ 3L,7L,11L,41L,47L,53L,67L,71L,73L,83L,101L,107L,127L,137L,139L,149L,151L,157L,173L,181L,197L,211L,223L,229L,233L,263L,269L,271L,293L,307L,317L,337L,349L,359L,367L,373L,379L,397L,419L,433L,443L,491L,509L,521L,571L,593L,599L,601L,613L,617L,619L,641L,659L,673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191027Inst : IEnumerable<long>
{
public static readonly long[] Value=A191027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191027.Bytes);
public long this[int i]=>Value[i];

public static A191027Inst Instance=new A191027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191028
{
public static readonly long[] Value={ 3L,7L,13L,17L,23L,29L,37L,47L,53L,59L,67L,73L,107L,109L,137L,173L,179L,181L,191L,199L,211L,227L,233L,239L,263L,269L,271L,293L,307L,311L,313L,317L,331L,353L,359L,367L,373L,379L,421L,457L,463L,479L,503L,509L,523L,547L,563L,577L,593L,617L,631L,647L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191028Inst : IEnumerable<long>
{
public static readonly long[] Value=A191028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191028.Bytes);
public long this[int i]=>Value[i];

public static A191028Inst Instance=new A191028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191029
{
public static readonly long[] Value={ 2L,5L,11L,41L,43L,47L,59L,61L,71L,79L,83L,89L,103L,127L,137L,139L,149L,157L,167L,181L,197L,199L,211L,227L,239L,277L,281L,283L,293L,313L,317L,337L,353L,359L,367L,373L,383L,401L,431L,433L,439L,449L,461L,479L,509L,523L,547L,557L,571L,587L,593L,601L,607L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191029Inst : IEnumerable<long>
{
public static readonly long[] Value=A191029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191029.Bytes);
public long this[int i]=>Value[i];

public static A191029Inst Instance=new A191029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191030
{
public static readonly long[] Value={ 2L,5L,23L,31L,37L,43L,59L,61L,73L,83L,103L,107L,113L,127L,131L,139L,163L,173L,197L,223L,241L,251L,269L,271L,277L,283L,307L,337L,349L,353L,359L,367L,373L,379L,389L,401L,409L,419L,431L,433L,443L,449L,461L,467L,487L,491L,523L,541L,569L,599L,607L,613L,617L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191030Inst : IEnumerable<long>
{
public static readonly long[] Value=A191030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191030.Bytes);
public long this[int i]=>Value[i];

public static A191030Inst Instance=new A191030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191031
{
public static readonly long[] Value={ 11L,13L,17L,23L,31L,41L,47L,53L,59L,67L,79L,83L,97L,101L,103L,107L,109L,127L,139L,167L,173L,181L,193L,197L,229L,239L,251L,269L,271L,281L,283L,293L,307L,311L,317L,337L,353L,359L,367L,379L,397L,401L,431L,439L,443L,461L,479L,487L,509L,541L,547L,557L,563L,569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191031Inst : IEnumerable<long>
{
public static readonly long[] Value=A191031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191031.Bytes);
public long this[int i]=>Value[i];

public static A191031Inst Instance=new A191031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191032
{
public static readonly long[] Value={ 5L,11L,19L,31L,37L,41L,43L,47L,53L,61L,67L,71L,73L,83L,107L,109L,127L,149L,151L,157L,167L,181L,193L,223L,227L,229L,233L,239L,251L,257L,271L,283L,293L,311L,353L,373L,379L,389L,409L,419L,421L,439L,449L,463L,467L,487L,523L,557L,563L,571L,577L,593L,599L,601L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191032Inst : IEnumerable<long>
{
public static readonly long[] Value=A191032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191032.Bytes);
public long this[int i]=>Value[i];

public static A191032Inst Instance=new A191032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191033
{
public static readonly long[] Value={ 2L,3L,7L,17L,37L,53L,59L,61L,71L,79L,83L,89L,97L,101L,103L,131L,149L,157L,173L,191L,197L,239L,241L,251L,263L,269L,271L,277L,283L,307L,331L,337L,347L,353L,379L,383L,397L,401L,431L,439L,457L,479L,487L,491L,521L,523L,541L,571L,601L,613L,617L,619L,643L,647L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191033Inst : IEnumerable<long>
{
public static readonly long[] Value=A191033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191033.Bytes);
public long this[int i]=>Value[i];

public static A191033Inst Instance=new A191033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191034
{
public static readonly long[] Value={ 5L,11L,13L,19L,23L,29L,41L,43L,67L,71L,103L,107L,113L,127L,131L,151L,157L,167L,173L,197L,223L,227L,229L,233L,269L,271L,307L,311L,317L,331L,347L,349L,373L,401L,409L,419L,421L,431L,433L,449L,457L,463L,479L,503L,521L,523L,577L,613L,617L,631L,641L,653L,661L,677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191034Inst : IEnumerable<long>
{
public static readonly long[] Value=A191034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191034.Bytes);
public long this[int i]=>Value[i];

public static A191034Inst Instance=new A191034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191035
{
public static readonly long[] Value={ 7L,11L,13L,17L,29L,37L,43L,47L,59L,89L,97L,107L,113L,131L,149L,163L,197L,199L,211L,223L,227L,229L,241L,269L,271L,281L,293L,307L,311L,317L,331L,347L,367L,409L,431L,433L,439L,449L,461L,467L,487L,521L,523L,541L,547L,577L,587L,593L,599L,607L,619L,643L,647L,653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191035Inst : IEnumerable<long>
{
public static readonly long[] Value=A191035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191035.Bytes);
public long this[int i]=>Value[i];

public static A191035Inst Instance=new A191035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191100
{
public static readonly long[] Value={ 2L,6L,1L,6L,4L,1L,21L,6L,1L,30L,33L,2L,5L,42L,2L,6L,26L,2L,57L,30L,2L,13L,69L,0L,8L,78L,1L,42L,5L,10L,93L,6L,2L,102L,105L,2L,28L,114L,13L,30L,62L,5L,129L,66L,1L,20L,28L,2L,11L,30L,2L,78L,40L,2L,165L,42L,10L,174L,177L,3L,6L,186L,7L,6L,98L,22L,201L,102L,2L,210L,213L,0L,110L,222L,5L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191100Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191100.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191100Inst : IEnumerable<long>
{
public static readonly long[] Value=A191100.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191100.Bytes);
public long this[int i]=>Value[i];

public static A191100Inst Instance=new A191100Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191101
{
public static readonly long[] Value={ 6L,18L,43L,72L,145L,210L,364L,432L,768L,938L,1441L,1680L,2483L,2448L,4010L,4480L,6154L,6798L,9063L,9000L,12901L,13962L,17848L,19152L,24100L,21450L,31869L,33824L,41383L,43758L,52886L,52920L,66638L,69958L,82915L,86760L,102009L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191101Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191101.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191101Inst : IEnumerable<long>
{
public static readonly long[] Value=A191101.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191101.Bytes);
public long this[int i]=>Value[i];

public static A191101Inst Instance=new A191101Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191102
{
public static readonly long[] Value={ 6L,5L,7L,8L,9L,3L,3L,8L,3L,9L,6L,2L,5L,2L,5L,9L,3L,1L,8L,0L,8L,6L,9L,4L,3L,7L,7L,1L,0L,6L,0L,6L,6L,7L,8L,9L,1L,9L,6L,1L,3L,2L,7L,4L,8L,4L,9L,8L,1L,1L,6L,6L,1L,6L,3L,8L,0L,8L,4L,3L,5L,8L,9L,9L,9L,7L,5L,9L,1L,1L,9L,4L,9L,5L,4L,3L,8L,9L,2L,7L,9L,2L,2L,0L,9L,1L,4L,4L,4L,9L,8L,6L,0L,6L,0L,5L,0L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191102Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191102.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191102Inst : IEnumerable<long>
{
public static readonly long[] Value=A191102.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191102.Bytes);
public long this[int i]=>Value[i];

public static A191102Inst Instance=new A191102Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191103
{
public static readonly long[] Value={ 3L,6L,7L,10L,14L,17L,21L,24L,28L,31L,35L,38L,39L,42L,45L,46L,49L,53L,56L,60L,63L,67L,70L,74L,77L,78L,81L,85L,88L,92L,95L,99L,102L,106L,109L,110L,113L,116L,117L,120L,124L,127L,131L,134L,138L,141L,145L,148L,149L,152L,156L,159L,163L,166L,170L,173L,177L,180L,181L,184L,187L,188L,191L,195L,198L,202L,205L,209L,212L,216L,219L,220L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191103Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191103.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191103Inst : IEnumerable<long>
{
public static readonly long[] Value=A191103.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191103.Bytes);
public long this[int i]=>Value[i];

public static A191103Inst Instance=new A191103Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191104
{
public static readonly long[] Value={ 2L,5L,9L,12L,13L,16L,19L,20L,23L,27L,30L,34L,37L,41L,44L,48L,51L,52L,55L,58L,59L,62L,66L,69L,73L,76L,80L,83L,84L,87L,90L,91L,94L,98L,101L,105L,108L,112L,115L,119L,122L,123L,126L,129L,130L,133L,137L,140L,144L,147L,151L,154L,155L,158L,161L,162L,165L,169L,172L,176L,179L,183L,186L,190L,193L,194L,197L,200L,201L,204L,208L,211L,215L,218L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191104Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191104.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191104Inst : IEnumerable<long>
{
public static readonly long[] Value=A191104.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191104.Bytes);
public long this[int i]=>Value[i];

public static A191104Inst Instance=new A191104Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191105
{
public static readonly long[] Value={ 1L,4L,8L,11L,15L,18L,22L,25L,26L,29L,32L,33L,36L,40L,43L,47L,50L,54L,57L,61L,64L,65L,68L,71L,72L,75L,79L,82L,86L,89L,93L,96L,97L,100L,103L,104L,107L,111L,114L,118L,121L,125L,128L,132L,135L,136L,139L,142L,143L,146L,150L,153L,157L,160L,164L,167L,168L,171L,174L,175L,178L,182L,185L,189L,192L,196L,199L,203L,206L,207L,210L,213L,214L,217L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191105Inst : IEnumerable<long>
{
public static readonly long[] Value=A191105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191105.Bytes);
public long this[int i]=>Value[i];

public static A191105Inst Instance=new A191105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191106
{
public static readonly long[] Value={ 1L,3L,7L,9L,19L,21L,25L,27L,55L,57L,61L,63L,73L,75L,79L,81L,163L,165L,169L,171L,181L,183L,187L,189L,217L,219L,223L,225L,235L,237L,241L,243L,487L,489L,493L,495L,505L,507L,511L,513L,541L,543L,547L,549L,559L,561L,565L,567L,649L,651L,655L,657L,667L,669L,673L,675L,703L,705L,709L,711L,721L,723L,727L,729L,1459L,1461L,1465L,1467L,1477L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191106Inst : IEnumerable<long>
{
public static readonly long[] Value=A191106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191106.Bytes);
public long this[int i]=>Value[i];

public static A191106Inst Instance=new A191106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191107
{
public static readonly long[] Value={ 1L,4L,10L,13L,28L,31L,37L,40L,82L,85L,91L,94L,109L,112L,118L,121L,244L,247L,253L,256L,271L,274L,280L,283L,325L,328L,334L,337L,352L,355L,361L,364L,730L,733L,739L,742L,757L,760L,766L,769L,811L,814L,820L,823L,838L,841L,847L,850L,973L,976L,982L,985L,1000L,1003L,1009L,1012L,1054L,1057L,1063L,1066L,1081L,1084L,1090L,1093L,2188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191107Inst : IEnumerable<long>
{
public static readonly long[] Value=A191107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191107.Bytes);
public long this[int i]=>Value[i];

public static A191107Inst Instance=new A191107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191108
{
public static readonly long[] Value={ 1L,5L,13L,17L,37L,41L,49L,53L,109L,113L,121L,125L,145L,149L,157L,161L,325L,329L,337L,341L,361L,365L,373L,377L,433L,437L,445L,449L,469L,473L,481L,485L,973L,977L,985L,989L,1009L,1013L,1021L,1025L,1081L,1085L,1093L,1097L,1117L,1121L,1129L,1133L,1297L,1301L,1309L,1313L,1333L,1337L,1345L,1349L,1405L,1409L,1417L,1421L,1441L,1445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191108Inst : IEnumerable<long>
{
public static readonly long[] Value=A191108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191108.Bytes);
public long this[int i]=>Value[i];

public static A191108Inst Instance=new A191108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191109
{
public static readonly long[] Value={ 1L,2L,5L,8L,14L,17L,23L,26L,41L,44L,50L,53L,68L,71L,77L,80L,122L,125L,131L,134L,149L,152L,158L,161L,203L,206L,212L,215L,230L,233L,239L,242L,365L,368L,374L,377L,392L,395L,401L,404L,446L,449L,455L,458L,473L,476L,482L,485L,608L,611L,617L,620L,635L,638L,644L,647L,689L,692L,698L,701L,716L,719L,725L,728L,1094L,1097L,1103L,1106L,1121L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191109Inst : IEnumerable<long>
{
public static readonly long[] Value=A191109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191109.Bytes);
public long this[int i]=>Value[i];

public static A191109Inst Instance=new A191109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191110
{
public static readonly long[] Value={ 1L,3L,5L,9L,11L,15L,17L,27L,29L,33L,35L,45L,47L,51L,53L,81L,83L,87L,89L,99L,101L,105L,107L,135L,137L,141L,143L,153L,155L,159L,161L,243L,245L,249L,251L,261L,263L,267L,269L,297L,299L,303L,305L,315L,317L,321L,323L,405L,407L,411L,413L,423L,425L,429L,431L,459L,461L,465L,467L,477L,479L,483L,485L,729L,731L,735L,737L,747L,749L,753L,755L,783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191110Inst : IEnumerable<long>
{
public static readonly long[] Value=A191110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191110.Bytes);
public long this[int i]=>Value[i];

public static A191110Inst Instance=new A191110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191111
{
public static readonly long[] Value={ 11L,1110L,1120L,1130L,1140L,1150L,1160L,1170L,1180L,1190L,11100L,11110L,11120L,11130L,11140L,11150L,11160L,11170L,11180L,11190L,11200L,11210L,11220L,11230L,11240L,11250L,11260L,11270L,11280L,11290L,11300L,11310L,11320L,11330L,11340L,11350L,11360L,11370L,11380L,11390L,11400L,11410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191111Inst : IEnumerable<long>
{
public static readonly long[] Value=A191111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191111.Bytes);
public long this[int i]=>Value[i];

public static A191111Inst Instance=new A191111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191112
{
public static readonly BigInteger[] Value={ 1L,3L,12L,42L,165L,3000L,2142L,39270L,838695L,2185092L,194467182L,649154415L,33547795512L,40753286805L,24563658547425L,1364238471026340L,2297427262231332L,1662166966658270160L,783186317937632697L,BigInteger.Parse("404695317060455732220"),BigInteger.Parse("162293533192142440777455"),BigInteger.Parse("634357227813958501290435") };
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
public class A191112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191112Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191112.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191112.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191112Inst Instance=new A191112Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191113
{
public static readonly long[] Value={ 1L,2L,4L,6L,10L,14L,16L,22L,28L,38L,40L,46L,54L,62L,64L,82L,86L,110L,112L,118L,136L,150L,158L,160L,182L,184L,190L,214L,244L,246L,254L,256L,326L,328L,334L,342L,352L,406L,438L,446L,448L,470L,472L,478L,542L,544L,550L,568L,598L,630L,638L,640L,726L,730L,734L,736L,758L,760L,766L,854L,974L,976L,982L,1000L,1014L,1022L,1024L,1054L,1216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191113Inst : IEnumerable<long>
{
public static readonly long[] Value=A191113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191113.Bytes);
public long this[int i]=>Value[i];

public static A191113Inst Instance=new A191113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191114
{
public static readonly long[] Value={ 1L,3L,7L,11L,19L,27L,31L,43L,55L,75L,79L,91L,107L,123L,127L,163L,171L,219L,223L,235L,271L,299L,315L,319L,363L,367L,379L,427L,487L,491L,507L,511L,651L,655L,667L,683L,703L,811L,875L,891L,895L,939L,943L,955L,1083L,1087L,1099L,1135L,1195L,1259L,1275L,1279L,1451L,1459L,1467L,1471L,1515L,1519L,1531L,1707L,1947L,1951L,1963L,1999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191114Inst : IEnumerable<long>
{
public static readonly long[] Value=A191114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191114.Bytes);
public long this[int i]=>Value[i];

public static A191114Inst Instance=new A191114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191115
{
public static readonly long[] Value={ 1L,4L,10L,16L,28L,40L,46L,64L,82L,112L,118L,136L,160L,184L,190L,244L,256L,328L,334L,352L,406L,448L,472L,478L,544L,550L,568L,640L,730L,736L,760L,766L,976L,982L,1000L,1024L,1054L,1216L,1312L,1336L,1342L,1408L,1414L,1432L,1624L,1630L,1648L,1702L,1792L,1888L,1912L,1918L,2176L,2188L,2200L,2206L,2272L,2278L,2296L,2560L,2920L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191115Inst : IEnumerable<long>
{
public static readonly long[] Value=A191115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191115.Bytes);
public long this[int i]=>Value[i];

public static A191115Inst Instance=new A191115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191404
{
public static readonly long[] Value={ 4L,7L,11L,13L,17L,20L,23L,27L,29L,33L,37L,39L,43L,46L,49L,53L,55L,59L,62L,65L,69L,71L,75L,79L,81L,85L,88L,91L,95L,97L,101L,105L,107L,111L,114L,117L,121L,123L,127L,130L,133L,137L,139L,143L,147L,149L,153L,156L,159L,163L,165L,169L,172L,175L,179L,181L,185L,189L,191L,195L,198L,201L,205L,207L,211L,215L,217L,221L,224L,227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191404Inst : IEnumerable<long>
{
public static readonly long[] Value=A191404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191404.Bytes);
public long this[int i]=>Value[i];

public static A191404Inst Instance=new A191404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191405
{
public static readonly long[] Value={ 1L,3L,6L,9L,12L,15L,17L,20L,23L,26L,29L,31L,34L,37L,40L,43L,46L,49L,51L,54L,57L,60L,63L,65L,68L,71L,74L,77L,80L,83L,85L,88L,91L,94L,97L,99L,102L,105L,108L,111L,113L,116L,119L,122L,125L,128L,131L,133L,136L,139L,142L,145L,147L,150L,153L,156L,159L,162L,165L,167L,170L,173L,176L,179L,181L,184L,187L,190L,193L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191405Inst : IEnumerable<long>
{
public static readonly long[] Value=A191405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191405.Bytes);
public long this[int i]=>Value[i];

public static A191405Inst Instance=new A191405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191406
{
public static readonly long[] Value={ 2L,5L,7L,11L,13L,16L,19L,21L,25L,27L,30L,33L,35L,39L,41L,45L,47L,50L,53L,55L,59L,61L,64L,67L,69L,73L,75L,79L,81L,84L,87L,89L,93L,95L,98L,101L,103L,107L,109L,112L,115L,117L,121L,123L,127L,129L,132L,135L,137L,141L,143L,146L,149L,151L,155L,157L,161L,163L,166L,169L,171L,175L,177L,180L,183L,185L,189L,191L,194L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191406Inst : IEnumerable<long>
{
public static readonly long[] Value=A191406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191406.Bytes);
public long this[int i]=>Value[i];

public static A191406Inst Instance=new A191406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191407
{
public static readonly long[] Value={ 4L,6L,9L,12L,14L,18L,20L,23L,26L,28L,32L,34L,37L,40L,43L,46L,48L,52L,54L,57L,60L,62L,66L,68L,71L,74L,77L,80L,82L,86L,88L,91L,94L,96L,100L,102L,105L,108L,110L,114L,116L,119L,122L,125L,128L,130L,134L,136L,139L,142L,144L,148L,150L,153L,156L,159L,162L,164L,168L,170L,173L,176L,178L,182L,184L,187L,190L,192L,196L,198L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191407Inst : IEnumerable<long>
{
public static readonly long[] Value=A191407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191407.Bytes);
public long this[int i]=>Value[i];

public static A191407Inst Instance=new A191407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191408
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,2L,2L,2L,1L,1L,2L,1L,2L,1L,1L,1L,1L,1L,3L,1L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,2L,2L,1L,1L,1L,2L,1L,2L,1L,1L,1L,2L,2L,1L,1L,1L,2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,1L,2L,4L,3L,1L,1L,4L,2L,6L,1L,1L,2L,1L,1L,4L,2L,2L,1L,2L,2L,1L,1L,2L,1L,2L,4L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191408Inst : IEnumerable<long>
{
public static readonly long[] Value=A191408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191408.Bytes);
public long this[int i]=>Value[i];

public static A191408Inst Instance=new A191408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191409
{
public static readonly BigInteger[] Value={ 5L,131L,54869L,863585783L,BigInteger.Parse("174960197237646244878763893842845824429634127969") };
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
public class A191409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191409Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191409.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191409Inst Instance=new A191409Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191410
{
public static readonly long[] Value={ 0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,0L,2L,0L,0L,0L,1L,2L,0L,0L,3L,2L,0L,0L,0L,0L,0L,0L,3L,0L,0L,0L,2L,0L,0L,0L,4L,2L,0L,0L,1L,0L,0L,0L,5L,0L,0L,0L,2L,2L,0L,0L,4L,4L,0L,0L,3L,0L,0L,0L,0L,0L,0L,0L,1L,4L,0L,0L,7L,0L,0L,0L,0L,0L,0L,0L,5L,0L,0L,0L,3L,4L,0L,0L,6L,2L,0L,0L,2L,0L,0L,0L,8L,0L,0L,0L,0L,0L,0L,0L,5L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191410Inst : IEnumerable<long>
{
public static readonly long[] Value=A191410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191410.Bytes);
public long this[int i]=>Value[i];

public static A191410Inst Instance=new A191410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191411
{
public static readonly long[] Value={ 1L,1L,1L,0L,2L,2L,1L,0L,0L,2L,1L,0L,2L,4L,2L,0L,4L,0L,1L,0L,4L,2L,3L,0L,0L,6L,0L,0L,6L,4L,3L,0L,4L,4L,2L,0L,2L,6L,4L,0L,8L,4L,1L,0L,0L,4L,5L,0L,0L,0L,2L,0L,6L,0L,4L,0L,4L,2L,3L,0L,6L,8L,0L,0L,8L,8L,1L,0L,8L,4L,7L,0L,4L,10L,0L,0L,8L,4L,5L,0L,0L,4L,3L,0L,4L,10L,6L,0L,12L,0L,2L,0L,4L,8L,8L,0L,4L,0L,0L,0L,14L,4L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191411Inst : IEnumerable<long>
{
public static readonly long[] Value=A191411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191411.Bytes);
public long this[int i]=>Value[i];

public static A191411Inst Instance=new A191411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191412
{
public static readonly long[] Value={ 1L,1L,3L,9L,34L,139L,643L,3198L,17186L,98438L,598551L,3842893L,25957607L,183858842L,1361853786L,10523285935L,84648613474L,707461189513L,6132612218266L,55050390426042L,510994289786018L,4898133459331104L,48424584171850411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191412Inst : IEnumerable<long>
{
public static readonly long[] Value=A191412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191412.Bytes);
public long this[int i]=>Value[i];

public static A191412Inst Instance=new A191412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191413
{
public static readonly long[] Value={ 7L,8L,15L,28L,47L,72L,103L,140L,183L,232L,287L,348L,415L,488L,567L,652L,743L,840L,943L,1052L,1167L,1288L,1415L,1548L,1687L,1832L,1983L,2140L,2303L,2472L,2647L,2828L,3015L,3208L,3407L,3612L,3823L,4040L,4263L,4492L,4727L,4968L,5215L,5468L,5727L,5992L,6263L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191413Inst : IEnumerable<long>
{
public static readonly long[] Value=A191413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191413.Bytes);
public long this[int i]=>Value[i];

public static A191413Inst Instance=new A191413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191414
{
public static readonly long[] Value={ 1L,3L,8L,15L,24L,24L,48L,63L,80L,72L,120L,120L,168L,144L,192L,255L,288L,240L,360L,360L,384L,360L,528L,504L,624L,504L,728L,720L,840L,576L,960L,1023L,960L,864L,1152L,1200L,1368L,1080L,1344L,1512L,1680L,1152L,1848L,1800L,1920L,1584L,2208L,2040L,2400L,1872L,2304L,2520L,2808L,2184L,2880L,3024L,2880L,2520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191414Inst : IEnumerable<long>
{
public static readonly long[] Value=A191414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191414.Bytes);
public long this[int i]=>Value[i];

public static A191414Inst Instance=new A191414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191415
{
public static readonly BigInteger[] Value={ 1L,0L,6L,12L,340L,2340L,58338L,786240L,20890224L,428954400L,12845444040L,351885980160L,12049309321608L,408370359196800L,15960347878230000L,639599649237319680L,BigInteger.Parse("28303809398414031360"),BigInteger.Parse("1302999243310662912000"),BigInteger.Parse("64651744760744124697536"),BigInteger.Parse("3352722890027561625600000") };
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
public class A191415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191415Inst Instance=new A191415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191416
{
public static readonly long[] Value={ 1L,0L,2L,3L,16L,70L,360L,2212L,14488L,106272L,846530L,7287896L,67550052L,669276452L,7062219710L,79046250480L,935246925616L,11662366603504L,152856287604594L,2100714749805472L,30205647605518900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191416Inst : IEnumerable<long>
{
public static readonly long[] Value=A191416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191416.Bytes);
public long this[int i]=>Value[i];

public static A191416Inst Instance=new A191416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191417
{
public static readonly BigInteger[] Value={ 1L,0L,0L,4L,0L,0L,32L,0L,0L,384L,0L,0L,6912L,0L,0L,202752L,0L,0L,9060352L,0L,0L,537133056L,0L,0L,38729089024L,0L,0L,3250319523840L,0L,0L,309812206239744L,0L,0L,33002445042876416L,0L,0L,3882425071117008896L,0L,0L,BigInteger.Parse("499695395684082515968"),0L,0L };
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
public class A191417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191417Inst Instance=new A191417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191418
{
public static readonly BigInteger[] Value={ 0L,2L,0L,0L,16L,0L,0L,192L,0L,0L,3456L,0L,0L,101376L,0L,0L,4530176L,0L,0L,268566528L,0L,0L,19364544512L,0L,0L,1625159761920L,0L,0L,154906103119872L,0L,0L,16501222521438208L,0L,0L,1941212535558504448L,0L,0L,BigInteger.Parse("249847697842041257984"),0L,0L,BigInteger.Parse("34914299540455999668224") };
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
public class A191418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191418Inst Instance=new A191418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191419
{
public static readonly BigInteger[] Value={ 1L,0L,0L,8L,0L,0L,128L,0L,0L,2560L,0L,0L,60416L,0L,0L,1728512L,0L,0L,63438848L,0L,0L,3096477696L,0L,0L,196811685888L,0L,0L,15408280109056L,0L,0L,1413600665141248L,0L,0L,147160243434946560L,0L,0L,17047411713181220864UL,0L,0L,BigInteger.Parse("2169625122325921792000") };
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
public class A191419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191419Inst Instance=new A191419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191452
{
public static readonly long[] Value={ 1L,4L,2L,16L,8L,3L,64L,32L,12L,5L,256L,128L,48L,20L,6L,1024L,512L,192L,80L,24L,7L,4096L,2048L,768L,320L,96L,28L,9L,16384L,8192L,3072L,1280L,384L,112L,36L,10L,65536L,32768L,12288L,5120L,1536L,448L,144L,40L,11L,262144L,131072L,49152L,20480L,6144L,1792L,576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191452Inst : IEnumerable<long>
{
public static readonly long[] Value=A191452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191452.Bytes);
public long this[int i]=>Value[i];

public static A191452Inst Instance=new A191452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191453
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,4L,18L,24L,12L,5L,54L,72L,36L,14L,7L,162L,216L,108L,42L,20L,9L,486L,648L,324L,126L,60L,26L,10L,1458L,1944L,972L,378L,180L,78L,30L,11L,4374L,5832L,2916L,1134L,540L,234L,90L,32L,13L,13122L,17496L,8748L,3402L,1620L,702L,270L,96L,38L,15L,39366L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191453Inst : IEnumerable<long>
{
public static readonly long[] Value=A191453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191453.Bytes);
public long this[int i]=>Value[i];

public static A191453Inst Instance=new A191453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191454
{
public static readonly long[] Value={ 1L,2L,3L,6L,8L,4L,18L,24L,12L,5L,58L,76L,38L,16L,7L,186L,244L,122L,50L,22L,9L,600L,788L,394L,160L,70L,28L,10L,1940L,2550L,1274L,516L,226L,90L,32L,11L,6276L,8250L,4122L,1668L,730L,290L,102L,34L,13L,20308L,26696L,13338L,5396L,2362L,938L,330L,110L,42L,14L,65718L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191454Inst : IEnumerable<long>
{
public static readonly long[] Value=A191454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191454.Bytes);
public long this[int i]=>Value[i];

public static A191454Inst Instance=new A191454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191455
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,4L,13L,21L,10L,6L,35L,57L,27L,16L,7L,95L,154L,73L,43L,19L,9L,258L,418L,198L,116L,51L,24L,11L,701L,1136L,538L,315L,138L,65L,29L,12L,1905L,3087L,1462L,856L,375L,176L,78L,32L,14L,5178L,8391L,3974L,2326L,1019L,478L,212L,86L,38L,15L,14075L,22809L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191455Inst : IEnumerable<long>
{
public static readonly long[] Value=A191455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191455.Bytes);
public long this[int i]=>Value[i];

public static A191455Inst Instance=new A191455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191456
{
public static readonly long[] Value={ 11L,17L,41L,844427L,51448361L,86966771L,122983031L,180078317L,960959381L,1278189947L,1761702947L,1829187287L,2426256797L,2911675511L,3013107257L,4778888351L,5221343711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191456Inst : IEnumerable<long>
{
public static readonly long[] Value=A191456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191456.Bytes);
public long this[int i]=>Value[i];

public static A191456Inst Instance=new A191456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191457
{
public static readonly long[] Value={ 17L,41L,180078317L,1278189947L,1761702947L,1829187287L,5862143447L,6369321857L,7226006861L,8776320587L,10102729577L,11085833111L,12412643261L,50626299797L,53039299211L,72355485857L,74621287901L,76233413141L,81948881447L,115826556611L,129077263697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191457Inst : IEnumerable<long>
{
public static readonly long[] Value=A191457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191457.Bytes);
public long this[int i]=>Value[i];

public static A191457Inst Instance=new A191457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191458
{
public static readonly long[] Value={ 17L,41L,1761702947L,8776320587L,10102729577L,11085833111L,177558051107L,273373448057L,473787509537L,557149355507L,715464238661L,1359854730821L,2131528031441L,2170341748697L,2236159108277L,2308235320997L,2751203698151L,3247566894821L,3288002848511L,3424305123047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191458Inst : IEnumerable<long>
{
public static readonly long[] Value=A191458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191458.Bytes);
public long this[int i]=>Value[i];

public static A191458Inst Instance=new A191458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191459
{
public static readonly BigInteger[] Value={ 1L,1L,4L,32L,404L,7136L,164088L,4683680L,160473988L,6437653568L,296657482888L,15467576203136L,901391710293832L,58122426582341120L,4111838048797360624L,BigInteger.Parse("316858691136196764672"),BigInteger.Parse("26432968974665127895908"),BigInteger.Parse("2374343115004631725352960") };
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
public class A191459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191459Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191459.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191459Inst Instance=new A191459Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191460
{
public static readonly BigInteger[] Value={ 1L,1L,-1L,2L,6L,24L,-480L,720L,13440L,100800L,-1874880L,3628800L,22619520L,479001600L,-36739422720L,468583315200L,6345334195200L,20922789888000L,-4289844445286400L,6402373705728000L,363873320191180800L,BigInteger.Parse("18895538930171904000"),BigInteger.Parse("-350378437544239104000") };
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
public class A191460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191460Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191460.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191460Inst Instance=new A191460Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191461
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,18L,24L,480L,720L,23520L,100800L,1874880L,3628800L,341953920L,479001600L,36739422720L,468583315200L,8960682931200L,20922789888000L,4289844445286400L,6402373705728000L,1012647189038284800L,BigInteger.Parse("18895538930171904000"),BigInteger.Parse("350378437544239104000") };
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
public class A191461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191461Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191461.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191461Inst Instance=new A191461Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191462
{
public static readonly long[] Value={ 1L,1L,0L,6L,12L,100L,780L,-1092L,43344L,48816L,1264320L,24662880L,-162851040L,4327633440L,-17686783296L,275230488960L,3743721112320L,-70886371933440L,2127136959383040L,-25991855154846720L,402985066993459200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191462Inst : IEnumerable<long>
{
public static readonly long[] Value=A191462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191462.Bytes);
public long this[int i]=>Value[i];

public static A191462Inst Instance=new A191462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191463
{
public static readonly BigInteger[] Value={ 1L,0L,6L,15L,1596L,28155L,2752266L,152499165L,18328556616L,2081907926295L,342948671262246L,63036450590713545L,14410958655520684956UL,BigInteger.Parse("3796531150529363706915"),BigInteger.Parse("1173277778862573074248746"),BigInteger.Parse("415134737359852340707539405"),BigInteger.Parse("167697531024902643857808300816"),BigInteger.Parse("76517905142019788108453415876015") };
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
public class A191463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A191463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A191463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A191463Inst Instance=new A191463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191464
{
public static readonly long[] Value={ 1L,0L,2L,-3L,12L,-60L,226L,-1323L,7872L,-47688L,350760L,-2677323L,21860264L,-197850276L,1885325040L,-19153887483L,208328775168L,-2386457931984L,28865395641280L,-368167396914963L,4923222534781824L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191464Inst : IEnumerable<long>
{
public static readonly long[] Value=A191464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191464.Bytes);
public long this[int i]=>Value[i];

public static A191464Inst Instance=new A191464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191465
{
public static readonly long[] Value={ 0L,7L,77L,721L,6545L,59017L,531377L,4782841L,43046465L,387419977L,3486783377L,31381057561L,282429532385L,2541865820137L,22876792438577L,205891132061881L,1853020188786305L,16677181699535497L,150094635296736977L,1350851717672467801L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191465Inst : IEnumerable<long>
{
public static readonly long[] Value=A191465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191465.Bytes);
public long this[int i]=>Value[i];

public static A191465Inst Instance=new A191465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191466
{
public static readonly long[] Value={ 0L,4L,56L,604L,5936L,55924L,515816L,4704844L,42656096L,385467364L,3477018776L,31332231484L,282185395856L,2540645125204L,22870688939336L,205860614516524L,1852867600961216L,16676418760213444L,150090820599733496L,1350832644186663964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191466Inst : IEnumerable<long>
{
public static readonly long[] Value=A191466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191466.Bytes);
public long this[int i]=>Value[i];

public static A191466Inst Instance=new A191466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191467
{
public static readonly long[] Value={ 0L,2L,32L,386L,4160L,42242L,413792L,3959426L,37281920L,347066882L,3204309152L,29403732866L,268588249280L,2444976817922L,22198569382112L,201143570584706L,1819787258282240L,16444551185679362L,148466221699088672L,1339452822487618946L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191467Inst : IEnumerable<long>
{
public static readonly long[] Value=A191467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191467.Bytes);
public long this[int i]=>Value[i];

public static A191467Inst Instance=new A191467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A191484
{
public static readonly long[] Value={ 1L,16L,122L,512L,1563L,3888L,8404L,16384L,29525L,50000L,80526L,124416L,185647L,268912L,379688L,524288L,709929L,944784L,1238050L,1600000L,2042051L,2576816L,3218172L,3981312L,4882813L,5940688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A191484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A191484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A191484Inst : IEnumerable<long>
{
public static readonly long[] Value=A191484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A191484.Bytes);
public long this[int i]=>Value[i];

public static A191484Inst Instance=new A191484Inst();

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