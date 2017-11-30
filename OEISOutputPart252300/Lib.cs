using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A077675
{
public static readonly long[] Value={ 11L,14L,19L,41L,89L,91L,94L,111L,114L,118L,119L,141L,149L,181L,191L,194L,199L,411L,418L,419L,449L,481L,489L,491L,494L,498L,499L,811L,814L,818L,849L,881L,889L,894L,898L,899L,911L,914L,919L,941L,949L,989L,991L,994L,998L,1111L,1114L,1118L,1119L,1141L,1149L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077675Inst : IEnumerable<long>
{
public static readonly long[] Value=A077675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077675.Bytes);
public long this[int i]=>Value[i];

public static A077675Inst Instance=new A077675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077676
{
public static readonly long[] Value={ 25L,36L,225L,256L,576L,625L,676L,5625L,5776L,7225L,27225L,27556L,37636L,55225L,65536L,75625L,225625L,226576L,235225L,265225L,266256L,275625L,276676L,367236L,525625L,553536L,732736L,765625L,767376L,2322576L,2325625L,2356225L,2637376L,2673225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077676Inst : IEnumerable<long>
{
public static readonly long[] Value=A077676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077676.Bytes);
public long this[int i]=>Value[i];

public static A077676Inst Instance=new A077676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077677
{
public static readonly long[] Value={ 1L,10L,11L,13L,14L,15L,17L,19L,101L,102L,103L,105L,106L,107L,109L,110L,111L,113L,114L,115L,118L,119L,122L,123L,127L,129L,130L,131L,133L,134L,137L,138L,139L,141L,142L,143L,145L,146L,149L,151L,154L,155L,157L,158L,159L,161L,163L,165L,166L,167L,170L,173L,174L,177L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077677Inst : IEnumerable<long>
{
public static readonly long[] Value=A077677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077677.Bytes);
public long this[int i]=>Value[i];

public static A077677Inst Instance=new A077677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077678
{
public static readonly long[] Value={ 2L,21L,22L,23L,26L,29L,201L,202L,203L,205L,206L,209L,210L,211L,213L,214L,215L,217L,218L,219L,221L,222L,223L,226L,227L,229L,230L,231L,233L,235L,237L,238L,239L,241L,246L,247L,249L,251L,253L,254L,255L,257L,258L,259L,262L,263L,265L,266L,267L,269L,271L,273L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077678Inst : IEnumerable<long>
{
public static readonly long[] Value=A077678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077678.Bytes);
public long this[int i]=>Value[i];

public static A077678Inst Instance=new A077678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077679
{
public static readonly long[] Value={ 3L,30L,31L,33L,34L,35L,37L,38L,39L,301L,302L,303L,305L,307L,309L,310L,311L,313L,314L,317L,318L,319L,321L,322L,323L,326L,327L,329L,330L,331L,334L,335L,337L,339L,341L,345L,346L,347L,349L,353L,354L,355L,357L,358L,359L,362L,365L,366L,367L,370L,371L,373L,374L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077679Inst : IEnumerable<long>
{
public static readonly long[] Value=A077679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077679.Bytes);
public long this[int i]=>Value[i];

public static A077679Inst Instance=new A077679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077680
{
public static readonly long[] Value={ 41L,42L,43L,46L,47L,401L,402L,403L,406L,407L,409L,410L,411L,413L,415L,417L,418L,419L,421L,422L,426L,427L,429L,430L,431L,433L,434L,435L,437L,438L,439L,442L,443L,445L,446L,447L,449L,451L,453L,454L,455L,457L,458L,461L,462L,463L,465L,466L,467L,469L,470L,471L,473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077680Inst : IEnumerable<long>
{
public static readonly long[] Value=A077680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077680.Bytes);
public long this[int i]=>Value[i];

public static A077680Inst Instance=new A077680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077681
{
public static readonly long[] Value={ 5L,51L,53L,55L,57L,58L,59L,501L,502L,503L,505L,506L,509L,510L,511L,514L,515L,517L,518L,519L,521L,523L,526L,527L,530L,533L,534L,535L,537L,538L,541L,542L,543L,545L,546L,547L,551L,553L,554L,555L,557L,559L,561L,562L,563L,565L,566L,569L,570L,571L,573L,574L,577L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077681Inst : IEnumerable<long>
{
public static readonly long[] Value=A077681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077681.Bytes);
public long this[int i]=>Value[i];

public static A077681Inst Instance=new A077681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077682
{
public static readonly long[] Value={ 6L,61L,62L,65L,66L,67L,69L,601L,602L,606L,607L,609L,610L,611L,613L,614L,615L,617L,618L,619L,622L,623L,626L,627L,629L,631L,633L,634L,635L,638L,641L,642L,643L,645L,646L,647L,649L,651L,653L,654L,655L,658L,659L,661L,662L,663L,665L,667L,669L,670L,671L,673L,674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077682Inst : IEnumerable<long>
{
public static readonly long[] Value=A077682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077682.Bytes);
public long this[int i]=>Value[i];

public static A077682Inst Instance=new A077682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077683
{
public static readonly long[] Value={ 7L,70L,71L,73L,74L,77L,78L,79L,701L,703L,705L,706L,707L,709L,710L,713L,714L,715L,717L,718L,719L,721L,723L,727L,730L,731L,733L,734L,737L,739L,741L,742L,743L,745L,746L,749L,751L,753L,754L,755L,757L,758L,759L,761L,762L,763L,766L,767L,769L,770L,771L,773L,777L,778L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077683Inst : IEnumerable<long>
{
public static readonly long[] Value=A077683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077683.Bytes);
public long this[int i]=>Value[i];

public static A077683Inst Instance=new A077683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077764
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,4L,4L,8L,6L,14L,14L,44L,22L,30L,12L,41L,137L,667L,401L,517L,149L,286L,306L,1312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077764Inst : IEnumerable<long>
{
public static readonly long[] Value=A077764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077764.Bytes);
public long this[int i]=>Value[i];

public static A077764Inst Instance=new A077764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077765
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,7L,2L,4L,15L,4L,2L,11L,18L,14L,53L,2L,54L,1606L,482L,104L,754L,536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077765Inst : IEnumerable<long>
{
public static readonly long[] Value=A077765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077765.Bytes);
public long this[int i]=>Value[i];

public static A077765Inst Instance=new A077765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077766
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,1L,2L,3L,1L,2L,3L,1L,3L,4L,3L,3L,3L,4L,3L,2L,3L,5L,4L,3L,5L,4L,4L,4L,5L,4L,6L,5L,5L,4L,5L,4L,3L,7L,7L,3L,7L,5L,6L,5L,8L,8L,5L,4L,8L,9L,6L,5L,7L,7L,6L,8L,7L,8L,7L,6L,8L,7L,9L,8L,7L,7L,8L,9L,5L,10L,8L,7L,11L,9L,6L,10L,12L,8L,10L,10L,7L,8L,10L,12L,10L,11L,11L,9L,10L,10L,11L,10L,11L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077766Inst : IEnumerable<long>
{
public static readonly long[] Value=A077766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077766.Bytes);
public long this[int i]=>Value[i];

public static A077766Inst Instance=new A077766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077767
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,1L,3L,1L,2L,3L,3L,2L,3L,3L,3L,2L,3L,3L,3L,4L,5L,3L,4L,4L,4L,3L,5L,4L,4L,5L,5L,4L,4L,5L,5L,4L,8L,8L,5L,4L,6L,5L,6L,7L,5L,5L,7L,5L,7L,7L,7L,6L,8L,4L,5L,11L,5L,9L,8L,6L,11L,7L,7L,7L,7L,8L,10L,5L,12L,10L,5L,9L,10L,7L,13L,8L,8L,11L,5L,10L,9L,13L,9L,6L,9L,12L,7L,7L,11L,10L,9L,12L,11L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077767Inst : IEnumerable<long>
{
public static readonly long[] Value=A077767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077767.Bytes);
public long this[int i]=>Value[i];

public static A077767Inst Instance=new A077767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077768
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,4L,6L,7L,7L,7L,8L,10L,10L,11L,11L,12L,13L,15L,15L,14L,18L,17L,17L,19L,19L,21L,20L,21L,23L,22L,26L,25L,26L,27L,25L,29L,27L,32L,30L,28L,33L,33L,36L,34L,33L,37L,36L,39L,38L,40L,39L,38L,42L,40L,46L,43L,45L,44L,46L,48L,47L,49L,50L,48L,50L,50L,53L,55L,52L,55L,53L,60L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077768Inst : IEnumerable<long>
{
public static readonly long[] Value=A077768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077768.Bytes);
public long this[int i]=>Value[i];

public static A077768Inst Instance=new A077768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077769
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,3L,4L,3L,2L,4L,5L,5L,3L,6L,5L,5L,7L,6L,7L,8L,9L,5L,6L,11L,7L,8L,8L,12L,9L,10L,12L,13L,11L,10L,11L,14L,11L,11L,13L,11L,17L,15L,12L,14L,18L,14L,15L,18L,18L,15L,16L,17L,18L,17L,20L,18L,19L,18L,19L,22L,20L,21L,17L,20L,21L,25L,18L,20L,23L,26L,24L,23L,23L,25L,28L,24L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077769Inst : IEnumerable<long>
{
public static readonly long[] Value=A077769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077769.Bytes);
public long this[int i]=>Value[i];

public static A077769Inst Instance=new A077769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077770
{
public static readonly long[] Value={ 0L,4L,12L,16L,20L,28L,32L,44L,52L,52L,56L,60L,76L,80L,84L,84L,92L,104L,116L,116L,112L,140L,132L,136L,148L,148L,164L,160L,164L,180L,176L,204L,196L,204L,216L,196L,228L,216L,252L,236L,224L,260L,260L,284L,272L,260L,292L,288L,308L,300L,316L,312L,300L,332L,320L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077770Inst : IEnumerable<long>
{
public static readonly long[] Value=A077770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077770.Bytes);
public long this[int i]=>Value[i];

public static A077770Inst Instance=new A077770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077771
{
public static readonly long[] Value={ 5L,9L,8L,9L,5L,8L,1L,6L,7L,5L,3L,8L,4L,3L,3L,9L,9L,2L,5L,0L,0L,1L,7L,2L,2L,1L,7L,9L,2L,9L,4L,3L,6L,5L,9L,0L,9L,7L,8L,2L,0L,8L,7L,6L,8L,6L,7L,6L,1L,0L,5L,9L,3L,6L,7L,5L,4L,7L,8L,6L,0L,7L,5L,4L,7L,9L,6L,5L,1L,8L,4L,1L,9L,5L,2L,8L,0L,8L,4L,2L,0L,5L,5L,4L,0L,7L,2L,1L,1L,0L,8L,0L,5L,2L,7L,9L,6L,4L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077771Inst : IEnumerable<long>
{
public static readonly long[] Value=A077771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077771.Bytes);
public long this[int i]=>Value[i];

public static A077771Inst Instance=new A077771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077772
{
public static readonly BigInteger[] Value={ 0L,1L,1L,2L,37L,1L,162L,1L,1L,1L,3L,1L,7L,1L,9L,2L,3L,1L,3068518062211324L,2L,1L,2L,6L,13L,1L,2L,1L,3L,1L,10L,1L,21L,1L,1L,4L,3L,577L,1L,BigInteger.Parse("1079268324684171943515797470873767312825026176345571319042096689270") };
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
public class A077772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077772Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A077772.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A077772.Bytes);
public BigInteger this[int i]=>Value[i];

public static A077772Inst Instance=new A077772Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077773
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,4L,4L,5L,6L,6L,7L,6L,9L,8L,8L,10L,10L,11L,11L,12L,11L,14L,12L,13L,15L,16L,15L,15L,17L,16L,17L,19L,18L,19L,20L,19L,20L,21L,20L,22L,22L,24L,22L,25L,23L,26L,26L,24L,29L,26L,27L,28L,27L,29L,26L,31L,32L,30L,29L,33L,33L,31L,31L,35L,34L,35L,35L,35L,36L,37L,37L,33L,42L,37L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077773Inst : IEnumerable<long>
{
public static readonly long[] Value=A077773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077773.Bytes);
public long this[int i]=>Value[i];

public static A077773Inst Instance=new A077773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077774
{
public static readonly long[] Value={ 0L,1L,1L,1L,1L,2L,2L,2L,3L,3L,2L,3L,4L,3L,3L,5L,4L,4L,5L,5L,5L,5L,6L,5L,5L,7L,6L,6L,6L,8L,7L,7L,8L,9L,8L,7L,8L,9L,7L,9L,10L,7L,11L,10L,9L,10L,13L,11L,8L,11L,12L,12L,11L,11L,13L,11L,13L,12L,12L,13L,13L,13L,14L,14L,13L,14L,13L,15L,13L,15L,14L,17L,15L,14L,17L,16L,16L,16L,17L,16L,18L,18L,16L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077774Inst : IEnumerable<long>
{
public static readonly long[] Value=A077774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077774.Bytes);
public long this[int i]=>Value[i];

public static A077774Inst Instance=new A077774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077775
{
public static readonly long[] Value={ 3L,7L,15L,123L,181L,185L,539L,597L,643L,743L,1553L,3135L,4769L,5133L,6177L,11733L,16103L,18997L,25271L,49025L,65043L,87965L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077775Inst : IEnumerable<long>
{
public static readonly long[] Value=A077775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077775.Bytes);
public long this[int i]=>Value[i];

public static A077775Inst Instance=new A077775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077776
{
public static readonly long[] Value={ 3L,11L,27L,87L,339L,363L,3159L,36155L,45305L,314727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077776Inst : IEnumerable<long>
{
public static readonly long[] Value=A077776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077776.Bytes);
public long this[int i]=>Value[i];

public static A077776Inst Instance=new A077776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077777
{
public static readonly long[] Value={ 3L,7L,15L,21L,25L,961L,1899L,3891L,15097L,17847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077777Inst : IEnumerable<long>
{
public static readonly long[] Value=A077777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077777.Bytes);
public long this[int i]=>Value[i];

public static A077777Inst Instance=new A077777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077778
{
public static readonly long[] Value={ 3L,17L,19L,705L,1061L,1395L,2631L,3837L,5749L,11753L,13537L,125877L,269479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077778Inst : IEnumerable<long>
{
public static readonly long[] Value=A077778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077778.Bytes);
public long this[int i]=>Value[i];

public static A077778Inst Instance=new A077778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077779
{
public static readonly long[] Value={ 3L,5L,39L,195L,19637L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077779Inst : IEnumerable<long>
{
public static readonly long[] Value=A077779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077779.Bytes);
public long this[int i]=>Value[i];

public static A077779Inst Instance=new A077779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077844
{
public static readonly long[] Value={ 1L,3L,9L,27L,79L,231L,675L,1971L,5755L,16803L,49059L,143235L,418195L,1220979L,3564819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077844Inst : IEnumerable<long>
{
public static readonly long[] Value=A077844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077844.Bytes);
public long this[int i]=>Value[i];

public static A077844Inst Instance=new A077844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077845
{
public static readonly long[] Value={ 1L,3L,9L,26L,74L,210L,595L,1685L,4771L,13508L,38244L,108276L,306549L,867895L,2457165L,6956670L,19695566L,55761638L,157871079L,446961001L,1265425799L,3582644680L,10143101960L,28716919080L,81302686761L,230182313643L,651686919889L,1845041153826L,5223638461074L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077845Inst : IEnumerable<long>
{
public static readonly long[] Value=A077845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077845.Bytes);
public long this[int i]=>Value[i];

public static A077845Inst Instance=new A077845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077846
{
public static readonly long[] Value={ 1L,3L,9L,25L,69L,189L,517L,1413L,3861L,10549L,28821L,78741L,215125L,587733L,1605717L,4386901L,11985237L,32744277L,89459029L,244406613L,667731285L,1824275797L,4984014165L,13616579925L,37201188181L,101635536213L,277673448789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077846Inst : IEnumerable<long>
{
public static readonly long[] Value=A077846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077846.Bytes);
public long this[int i]=>Value[i];

public static A077846Inst Instance=new A077846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077847
{
public static readonly long[] Value={ 1L,3L,9L,23L,59L,147L,367L,911L,2263L,5615L,13935L,34575L,85791L,212863L,528159L,1310463L,3251519L,8067647L,20017407L,49667071L,123233663L,305766655L,758666495L,1882398975L,4670597631L,11588660223L,28753717759L,71343560703L,177017236479L,439214158847L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077847Inst : IEnumerable<long>
{
public static readonly long[] Value=A077847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077847.Bytes);
public long this[int i]=>Value[i];

public static A077847Inst Instance=new A077847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077848
{
public static readonly long[] Value={ 1L,3L,8L,22L,59L,157L,418L,1112L,2957L,7863L,20908L,55594L,147823L,393057L,1045126L,2778956L,7389153L,19647515L,52242096L,138910014L,369357155L,982108517L,2611394218L,6943611264L,18462833781L,49092067263L,130534190836L,347086116498L,922890558359L,2453935614889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077848Inst : IEnumerable<long>
{
public static readonly long[] Value=A077848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077848.Bytes);
public long this[int i]=>Value[i];

public static A077848Inst Instance=new A077848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077849
{
public static readonly long[] Value={ 1L,3L,8L,21L,54L,138L,352L,897L,2285L,5820L,14823L,37752L,96148L,244872L,623645L,1588311L,4045140L,10302237L,26237926L,66823230L,170186624L,433434405L,1103878665L,2811378360L,7160069791L,18235396608L,46442241368L,118279949136L,301237536249L,767197263003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077849Inst : IEnumerable<long>
{
public static readonly long[] Value=A077849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077849.Bytes);
public long this[int i]=>Value[i];

public static A077849Inst Instance=new A077849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077850
{
public static readonly long[] Value={ 1L,3L,8L,19L,44L,100L,226L,509L,1145L,2574L,5785L,13000L,29212L,65640L,147493L,331415L,744684L,1673291L,3759852L,8448312L,18983186L,42654833L,95844541L,215360730L,483911169L,1087338528L,2443227496L,5489882352L,12335653673L,27717962203L,62281695728L,139945699987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077850Inst : IEnumerable<long>
{
public static readonly long[] Value=A077850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077850.Bytes);
public long this[int i]=>Value[i];

public static A077850Inst Instance=new A077850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077851
{
public static readonly long[] Value={ 1L,3L,7L,17L,41L,97L,229L,541L,1277L,3013L,7109L,16773L,39573L,93365L,220277L,519701L,1226133L,2892821L,6825045L,16102357L,37990357L,89630805L,211466325L,498913365L,1177088341L,2777109333L,6552045397L,15458267477L,36470753621L,86045598037L,203007731029L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077851Inst : IEnumerable<long>
{
public static readonly long[] Value=A077851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077851.Bytes);
public long this[int i]=>Value[i];

public static A077851Inst Instance=new A077851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077852
{
public static readonly long[] Value={ 1L,3L,7L,16L,36L,80L,177L,391L,863L,1904L,4200L,9264L,20433L,45067L,99399L,219232L,483532L,1066464L,2352161L,5187855L,11442175L,25236512L,55660880L,122763936L,270764385L,597189651L,1317143239L,2905050864L,6407291380L,14131726000L,31168502865L,68744297111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077852Inst : IEnumerable<long>
{
public static readonly long[] Value=A077852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077852.Bytes);
public long this[int i]=>Value[i];

public static A077852Inst Instance=new A077852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077853
{
public static readonly long[] Value={ 1L,3L,7L,13L,21L,29L,33L,25L,-7L,-79L,-207L,-399L,-639L,-863L,-927L,-575L,577L,3009L,7169L,13185L,20353L,26369L,26369L,12033L,-28671L,-110079L,-244223L,-431103L,-642047L,-795647L,-729087L,-174079L,1243137L,3944449L,8237057L,13987841L,20086785L,23699457L,19423233L,-1327103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077853Inst : IEnumerable<long>
{
public static readonly long[] Value=A077853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077853.Bytes);
public long this[int i]=>Value[i];

public static A077853Inst Instance=new A077853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077854
{
public static readonly long[] Value={ 1L,3L,6L,12L,25L,51L,102L,204L,409L,819L,1638L,3276L,6553L,13107L,26214L,52428L,104857L,209715L,419430L,838860L,1677721L,3355443L,6710886L,13421772L,26843545L,53687091L,107374182L,214748364L,429496729L,858993459L,1717986918L,3435973836L,6871947673L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077854Inst : IEnumerable<long>
{
public static readonly long[] Value=A077854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077854.Bytes);
public long this[int i]=>Value[i];

public static A077854Inst Instance=new A077854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077855
{
public static readonly long[] Value={ 1L,3L,6L,11L,20L,36L,64L,113L,199L,350L,615L,1080L,1896L,3328L,5841L,10251L,17990L,31571L,55404L,97228L,170624L,299425L,525455L,922110L,1618191L,2839728L,4983376L,8745216L,15346785L,26931731L,47261894L,82938843L,145547524L,255418100L,448227520L,786584465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077855Inst : IEnumerable<long>
{
public static readonly long[] Value=A077855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077855.Bytes);
public long this[int i]=>Value[i];

public static A077855Inst Instance=new A077855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077856
{
public static readonly long[] Value={ 1L,3L,6L,9L,10L,6L,-6L,-27L,-53L,-72L,-63L,0L,136L,336L,537L,603L,334L,-471L,-1878L,-3618L,-4886L,-4275L,-45L,9072L,22465L,35904L,40272L,22176L,-31823L,-126093L,-242538L,-327159L,-285686L,-1674L,609498L,1506357L,2404891L,2693928L,1476609L,-2145600L,-8461736L,-16254480L,-21901623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077856Inst : IEnumerable<long>
{
public static readonly long[] Value=A077856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077856.Bytes);
public long this[int i]=>Value[i];

public static A077856Inst Instance=new A077856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077857
{
public static readonly long[] Value={ 1L,3L,6L,8L,5L,-9L,-38L,-76L,-95L,-37L,174L,576L,1053L,1183L,162L,-2964L,-8455L,-14269L,-14154L,2872L,48437L,122311L,190442L,161700L,-111663L,-765909L,-1743554L,-2497872L,-1720371L,2544239L,11804594L,24505692L,32118313L,16121747L,-48886202L,-178130776L,-339618843L,-403334505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077857Inst : IEnumerable<long>
{
public static readonly long[] Value=A077857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077857.Bytes);
public long this[int i]=>Value[i];

public static A077857Inst Instance=new A077857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077858
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,19L,31L,47L,71L,111L,175L,271L,415L,639L,991L,1535L,2367L,3647L,5631L,8703L,13439L,20735L,31999L,49407L,76287L,117759L,181759L,280575L,433151L,668671L,1032191L,1593343L,2459647L,3796991L,5861375L,9048063L,13967359L,21561343L,33284095L,51380223L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077858Inst : IEnumerable<long>
{
public static readonly long[] Value=A077858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077858.Bytes);
public long this[int i]=>Value[i];

public static A077858Inst Instance=new A077858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077859
{
public static readonly long[] Value={ 1L,3L,5L,6L,6L,6L,7L,9L,11L,12L,12L,12L,13L,15L,17L,18L,18L,18L,19L,21L,23L,24L,24L,24L,25L,27L,29L,30L,30L,30L,31L,33L,35L,36L,36L,36L,37L,39L,41L,42L,42L,42L,43L,45L,47L,48L,48L,48L,49L,51L,53L,54L,54L,54L,55L,57L,59L,60L,60L,60L,61L,63L,65L,66L,66L,66L,67L,69L,71L,72L,72L,72L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077859Inst : IEnumerable<long>
{
public static readonly long[] Value=A077859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077859.Bytes);
public long this[int i]=>Value[i];

public static A077859Inst Instance=new A077859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077876
{
public static readonly long[] Value={ 1L,2L,1L,-2L,-3L,2L,9L,6L,-11L,-22L,1L,46L,45L,-46L,-135L,-42L,229L,314L,-143L,-770L,-483L,1058L,2025L,-90L,-4139L,-3958L,4321L,12238L,3597L,-20878L,-28071L,13686L,69829L,42458L,-97199L,-182114L,12285L,376514L,351945L,-401082L,-1104971L,-302806L,1907137L,2512750L,-1301523L,-6327022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077876Inst : IEnumerable<long>
{
public static readonly long[] Value=A077876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077876.Bytes);
public long this[int i]=>Value[i];

public static A077876Inst Instance=new A077876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077877
{
public static readonly long[] Value={ 1L,2L,1L,-3L,-6L,0L,16L,23L,-8L,-69L,-75L,72L,292L,224L,-431L,-1170L,-531L,2241L,4474L,524L,-10664L,-16185L,4620L,47655L,54601L,-45328L,-202184L,-166128L,283569L,818010L,417001L,-1502587L,-3154598L,-566424L,7245360L,11532807L,-2391488L,-32702461L,-39452291L,28344120L,139951164L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077877Inst : IEnumerable<long>
{
public static readonly long[] Value=A077877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077877.Bytes);
public long this[int i]=>Value[i];

public static A077877Inst Instance=new A077877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077878
{
public static readonly long[] Value={ 1L,2L,1L,-4L,-9L,-2L,25L,48L,3L,-142L,-243L,36L,807L,1222L,-463L,-4520L,-6037L,3930L,25045L,29260L,-28689L,-137298L,-138439L,193536L,745011L,634818L,-1242275L,-4001932L,-2787017L,7701398L,21279297L,11450536L,-46510853L,-111970518L,-41849883L,275112860L,582753663L,116227710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077878Inst : IEnumerable<long>
{
public static readonly long[] Value=A077878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077878.Bytes);
public long this[int i]=>Value[i];

public static A077878Inst Instance=new A077878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077879
{
public static readonly long[] Value={ 1L,1L,3L,5L,9L,17L,29L,53L,93L,165L,293L,517L,917L,1621L,2869L,5077L,8981L,15893L,28117L,49749L,88021L,155733L,275541L,487509L,862549L,1526101L,2700117L,4777301L,8452437L,14954837L,26459477L,46814549L,82828629L,146548053L,259286357L,458753365L,811668821L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077879Inst : IEnumerable<long>
{
public static readonly long[] Value=A077879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077879.Bytes);
public long this[int i]=>Value[i];

public static A077879Inst Instance=new A077879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077880
{
public static readonly long[] Value={ 1L,1L,3L,2L,6L,2L,11L,-1L,21L,-12L,44L,-44L,101L,-131L,247L,-362L,626L,-970L,1615L,-2565L,4201L,-6744L,10968L,-17688L,28681L,-46343L,75051L,-121366L,196446L,-317782L,514259L,-832009L,1346301L,-2178276L,3524612L,-5702852L,9227501L,-14930315L,24157855L,-39088130L,63246026L,-102334114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077880Inst : IEnumerable<long>
{
public static readonly long[] Value=A077880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077880.Bytes);
public long this[int i]=>Value[i];

public static A077880Inst Instance=new A077880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077881
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,-3L,9L,-15L,25L,-47L,81L,-143L,257L,-447L,801L,-1407L,2497L,-4415L,7809L,-13823L,24449L,-43263L,76545L,-135423L,239617L,-423935L,750081L,-1327103L,2348033L,-4154367L,7350273L,-13004799L,23009281L,-40710143L,72028161L,-127438847L,225476609L,-398934015L,705830913L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077881Inst : IEnumerable<long>
{
public static readonly long[] Value=A077881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077881.Bytes);
public long this[int i]=>Value[i];

public static A077881Inst Instance=new A077881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077882
{
public static readonly long[] Value={ 0L,1L,1L,2L,4L,5L,9L,14L,20L,33L,49L,74L,116L,173L,265L,406L,612L,937L,1425L,2162L,3300L,5013L,7625L,11614L,17652L,26865L,40881L,62170L,94612L,143933L,218953L,333158L,506820L,771065L,1173137L,1784706L,2715268L,4130981L,6284681L,9561518L,14546644L,22130881L,33669681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077882Inst : IEnumerable<long>
{
public static readonly long[] Value=A077882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077882.Bytes);
public long this[int i]=>Value[i];

public static A077882Inst Instance=new A077882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077883
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,0L,2L,-1L,3L,-2L,5L,-4L,8L,-8L,13L,-15L,22L,-27L,38L,-48L,66L,-85L,115L,-150L,201L,-264L,352L,-464L,617L,-815L,1082L,-1431L,1898L,-2512L,3330L,-4409L,5843L,-7738L,10253L,-13580L,17992L,-23832L,31573L,-41823L,55406L,-73395L,97230L,-128800L,170626L,-226029L,299427L,-396654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077883Inst : IEnumerable<long>
{
public static readonly long[] Value=A077883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077883.Bytes);
public long this[int i]=>Value[i];

public static A077883Inst Instance=new A077883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077884
{
public static readonly long[] Value={ 1L,1L,2L,0L,1L,-3L,2L,-4L,9L,-7L,18L,-24L,33L,-59L,82L,-124L,201L,-287L,450L,-688L,1025L,-1587L,2402L,-3636L,5577L,-8439L,12850L,-19592L,29729L,-45291L,68914L,-104748L,159497L,-242575L,368994L,-561568L,854145L,-1299555L,1977282L,-3007844L,4576393L,-6962407L,10592082L,-16115192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077884Inst : IEnumerable<long>
{
public static readonly long[] Value=A077884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077884.Bytes);
public long this[int i]=>Value[i];

public static A077884Inst Instance=new A077884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077885
{
public static readonly long[] Value={ 1L,1L,1L,3L,3L,3L,7L,7L,7L,15L,15L,15L,31L,31L,31L,63L,63L,63L,127L,127L,127L,255L,255L,255L,511L,511L,511L,1023L,1023L,1023L,2047L,2047L,2047L,4095L,4095L,4095L,8191L,8191L,8191L,16383L,16383L,16383L,32767L,32767L,32767L,65535L,65535L,65535L,131071L,131071L,131071L,262143L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077885Inst : IEnumerable<long>
{
public static readonly long[] Value=A077885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077885.Bytes);
public long this[int i]=>Value[i];

public static A077885Inst Instance=new A077885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077886
{
public static readonly long[] Value={ 1L,1L,1L,-1L,-1L,-1L,3L,3L,3L,-5L,-5L,-5L,11L,11L,11L,-21L,-21L,-21L,43L,43L,43L,-85L,-85L,-85L,171L,171L,171L,-341L,-341L,-341L,683L,683L,683L,-1365L,-1365L,-1365L,2731L,2731L,2731L,-5461L,-5461L,-5461L,10923L,10923L,10923L,-21845L,-21845L,-21845L,43691L,43691L,43691L,-87381L,-87381L,-87381L,174763L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077886Inst : IEnumerable<long>
{
public static readonly long[] Value=A077886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077886.Bytes);
public long this[int i]=>Value[i];

public static A077886Inst Instance=new A077886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077887
{
public static readonly long[] Value={ 1L,1L,0L,2L,3L,-1L,2L,8L,-3L,-3L,20L,-2L,-25L,43L,22L,-92L,65L,137L,-248L,-6L,523L,-489L,-534L,1536L,-443L,-2603L,3516L,1718L,-8721L,5315L,12158L,-22756L,-1527L,47073L,-43984L,-50126L,138131L,-37841L,-238382L,314104L,162701L,-790867L,465508L,1116270L,-2047241L,-185253L,4279782L,-3909228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077887Inst : IEnumerable<long>
{
public static readonly long[] Value=A077887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077887.Bytes);
public long this[int i]=>Value[i];

public static A077887Inst Instance=new A077887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077888
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,0L,0L,3L,1L,-2L,3L,4L,-4L,0L,9L,-3L,-8L,13L,6L,-20L,8L,27L,-27L,-18L,55L,-8L,-72L,64L,65L,-135L,0L,201L,-134L,-200L,336L,67L,-535L,270L,603L,-804L,-332L,1408L,-471L,-1739L,1880L,1269L,-3618L,612L,4888L,-4229L,-4275L,9118L,47L,-13392L,9072L,13440L,-22463L,-4367L,35904L,-18095L,-40270L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077888Inst : IEnumerable<long>
{
public static readonly long[] Value=A077888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077888.Bytes);
public long this[int i]=>Value[i];

public static A077888Inst Instance=new A077888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077889
{
public static readonly long[] Value={ 1L,1L,0L,-1L,0L,2L,2L,-1L,-3L,0L,5L,4L,-4L,-8L,1L,13L,8L,-13L,-20L,6L,34L,15L,-39L,-48L,25L,88L,24L,-112L,-111L,89L,224L,23L,-312L,-246L,290L,559L,-43L,-848L,-515L,892L,1364L,-376L,-2255L,-987L,2632L,3243L,-1644L,-5874L,-1598L,7519L,7473L,-5920L,-14991L,-1552L,20912L,16544L,-19359L,-37455L,2816L,56815L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077889Inst : IEnumerable<long>
{
public static readonly long[] Value=A077889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077889.Bytes);
public long this[int i]=>Value[i];

public static A077889Inst Instance=new A077889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077890
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-1L,3L,6L,0L,-11L,-11L,12L,34L,11L,-57L,-78L,36L,193L,121L,-264L,-506L,23L,1035L,990L,-1080L,-3059L,-899L,5220L,7018L,-3421L,-17457L,-10614L,24300L,45529L,-3071L,-94128L,-87986L,100271L,276243L,75702L,-476784L,-628187L,325381L,1581756L,930994L,-2232517L,-4094505L,370530L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077890Inst : IEnumerable<long>
{
public static readonly long[] Value=A077890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077890.Bytes);
public long this[int i]=>Value[i];

public static A077890Inst Instance=new A077890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077891
{
public static readonly long[] Value={ 1L,1L,-1L,1L,5L,-3L,-7L,17L,9L,-47L,17L,113L,-127L,-191L,481L,129L,-1343L,705L,2945L,-4095L,-4479L,14081L,769L,-37119L,26625L,75777L,-127487L,-98303L,406529L,-58367L,-1009663L,929793L,1902593L,-3878911L,-1945599L,11563009L,-3866623L,-27017215L,30859265L,46301185L,-115752959L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077891Inst : IEnumerable<long>
{
public static readonly long[] Value=A077891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077891.Bytes);
public long this[int i]=>Value[i];

public static A077891Inst Instance=new A077891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077892
{
public static readonly long[] Value={ 1L,1L,-1L,0L,4L,0L,-7L,5L,15L,-16L,-24L,48L,33L,-119L,-17L,272L,-84L,-560L,441L,1037L,-1441L,-1632L,3920L,1824L,-9471L,273L,20767L,-10016L,-41260L,40800L,72505L,-122859L,-104209L,318224L,85560L,-740656L,147105L,1566873L,-1034865L,-2986640L,3636604L,4938416L,-10259847L,-6240227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077892Inst : IEnumerable<long>
{
public static readonly long[] Value=A077892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077892.Bytes);
public long this[int i]=>Value[i];

public static A077892Inst Instance=new A077892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077893
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,3L,5L,5L,11L,11L,21L,21L,43L,43L,85L,85L,171L,171L,341L,341L,683L,683L,1365L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077893Inst : IEnumerable<long>
{
public static readonly long[] Value=A077893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077893.Bytes);
public long this[int i]=>Value[i];

public static A077893Inst Instance=new A077893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077894
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,2L,6L,-1L,-13L,-3L,28L,20L,-52L,-67L,85L,187L,-102L,-458L,18L,1019L,423L,-2055L,-1864L,3688L,5784L,-5511L,-15255L,5239L,36022L,4778L,-77282L,-45577L,149787L,168437L,-253996L,-486660L,339556L,1227317L,-192451L,-2794189L,-842414L,5780830L,4479018L,-10719245L,-14738865L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077894Inst : IEnumerable<long>
{
public static readonly long[] Value=A077894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077894.Bytes);
public long this[int i]=>Value[i];

public static A077894Inst Instance=new A077894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077895
{
public static readonly long[] Value={ 1L,1L,-1L,-3L,1L,9L,5L,-19L,-27L,29L,93L,-3L,-243L,-179L,493L,845L,-627L,-2675L,-435L,6605L,6221L,-12339L,-25651L,12237L,75981L,26829L,-176435L,-205619L,299213L,764109L,-187187L,-2126643L,-1153843L,4627661L,6560973L,-6947635L,-22377267L,773325L,58649805L,43207885L,-118846259L,-203715379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077895Inst : IEnumerable<long>
{
public static readonly long[] Value=A077895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077895.Bytes);
public long this[int i]=>Value[i];

public static A077895Inst Instance=new A077895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077896
{
public static readonly long[] Value={ 1L,0L,3L,0L,7L,0L,15L,0L,31L,0L,63L,0L,127L,0L,255L,0L,511L,0L,1023L,0L,2047L,0L,4095L,0L,8191L,0L,16383L,0L,32767L,0L,65535L,0L,131071L,0L,262143L,0L,524287L,0L,1048575L,0L,2097151L,0L,4194303L,0L,8388607L,0L,16777215L,0L,33554431L,0L,67108863L,0L,134217727L,0L,268435455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077896Inst : IEnumerable<long>
{
public static readonly long[] Value=A077896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077896.Bytes);
public long this[int i]=>Value[i];

public static A077896Inst Instance=new A077896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077897
{
public static readonly long[] Value={ 1L,0L,3L,-1L,8L,-6L,22L,-25L,64L,-91L,195L,-312L,612L,-1040L,1953L,-3420L,6287L,-11173L,20328L,-36386L,65870L,-118313L,213668L,-384423L,693447L,-1248624L,2251096L,-4054896L,7308465L,-13167160L,23729195L,-42755049L,77046280L,-138827182L,250164694L,-450772777L,812274984L,-1463655843L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077897Inst : IEnumerable<long>
{
public static readonly long[] Value=A077897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077897.Bytes);
public long this[int i]=>Value[i];

public static A077897Inst Instance=new A077897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077898
{
public static readonly long[] Value={ 1L,0L,3L,-2L,9L,-12L,31L,-54L,117L,-224L,459L,-906L,1825L,-3636L,7287L,-14558L,29133L,-58248L,116515L,-233010L,466041L,-932060L,1864143L,-3728262L,7456549L,-14913072L,29826171L,-59652314L,119304657L,-238609284L,477218599L,-954437166L,1908874365L,-3817748696L,7635497427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077898Inst : IEnumerable<long>
{
public static readonly long[] Value=A077898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077898.Bytes);
public long this[int i]=>Value[i];

public static A077898Inst Instance=new A077898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077899
{
public static readonly long[] Value={ 1L,0L,3L,-3L,10L,-18L,42L,-87L,190L,-405L,873L,-1872L,4024L,-8640L,18561L,-39864L,85627L,-183915L,395034L,-848490L,1822474L,-3914487L,8407926L,-18059373L,38789713L,-83316384L,178955184L,-384377664L,825604417L,-1773314928L,3808901427L,-8181135699L,17572253482L,-37743426306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077899Inst : IEnumerable<long>
{
public static readonly long[] Value=A077899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077899.Bytes);
public long this[int i]=>Value[i];

public static A077899Inst Instance=new A077899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077900
{
public static readonly long[] Value={ 1L,0L,3L,-4L,11L,-24L,55L,-124L,283L,-640L,1455L,-3300L,7491L,-17000L,38583L,-87564L,198731L,-451024L,1023615L,-2323124L,5272403L,-11965880L,27156935L,-61633500L,139879131L,-317460000L,720485263L,-1635163524L,3711054051L,-8422351624L,19114786775L,-43381598124L,98455874923L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077900Inst : IEnumerable<long>
{
public static readonly long[] Value=A077900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077900.Bytes);
public long this[int i]=>Value[i];

public static A077900Inst Instance=new A077900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077901
{
public static readonly long[] Value={ 1L,0L,2L,1L,2L,4L,1L,8L,2L,9L,10L,4L,25L,0L,34L,17L,18L,68L,-15L,120L,2L,89L,154L,-60L,393L,-144L,418L,225L,-94L,1156L,-799L,1768L,-254L,425L,2858L,-2940L,6649L,-3872L,4642L,4785L,-7886L,21956L,-20271L,26456L,-2814L,-11271L,61370L,-78268L,117097L,-72624L,33186L,128385L,-240446L,435204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077901Inst : IEnumerable<long>
{
public static readonly long[] Value=A077901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077901.Bytes);
public long this[int i]=>Value[i];

public static A077901Inst Instance=new A077901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077902
{
public static readonly long[] Value={ 1L,0L,2L,-2L,5L,-8L,16L,-28L,53L,-96L,178L,-326L,601L,-1104L,2032L,-3736L,6873L,-12640L,23250L,-42762L,78653L,-144664L,266080L,-489396L,900141L,-1655616L,3045154L,-5600910L,10301681L,-18947744L,34850336L,-64099760L,117897841L,-216847936L,398845538L,-733591314L,1349284789L,-2481721640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077902Inst : IEnumerable<long>
{
public static readonly long[] Value=A077902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077902.Bytes);
public long this[int i]=>Value[i];

public static A077902Inst Instance=new A077902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077903
{
public static readonly long[] Value={ 1L,0L,2L,-3L,6L,-12L,25L,-48L,98L,-195L,390L,-780L,1561L,-3120L,6242L,-12483L,24966L,-49932L,99865L,-199728L,399458L,-798915L,1597830L,-3195660L,6391321L,-12782640L,25565282L,-51130563L,102261126L,-204522252L,409044505L,-818089008L,1636178018L,-3272356035L,6544712070L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077903Inst : IEnumerable<long>
{
public static readonly long[] Value=A077903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077903.Bytes);
public long this[int i]=>Value[i];

public static A077903Inst Instance=new A077903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077904
{
public static readonly long[] Value={ 1L,0L,1L,2L,-1L,4L,1L,-2L,11L,-8L,5L,18L,-33L,44L,-7L,-58L,147L,-160L,45L,250L,-569L,660L,-159L,-978L,2299L,-2616L,661L,3938L,-9169L,10492L,-2615L,-15722L,36707L,-41936L,10493L,62922L,-146793L,167780L,-41935L,-251650L,587211L,-671080L,167781L,1006642L,-2348801L,2684364L,-671079L,-4026522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077904Inst : IEnumerable<long>
{
public static readonly long[] Value=A077904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077904.Bytes);
public long this[int i]=>Value[i];

public static A077904Inst Instance=new A077904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077905
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,2L,0L,1L,2L,-1L,3L,0L,0L,4L,-3L,4L,1L,-3L,8L,-6L,4L,5L,-10L,15L,-9L,0L,16L,-24L,25L,-8L,-15L,41L,-48L,34L,8L,-55L,90L,-81L,27L,64L,-144L,172L,-107L,-36L,209L,-315L,280L,-70L,-244L,525L,-594L,351L,175L,-768L,1120L,-944L,177L,944L,-1887L,2065L,-1120L,-766L,2832L,-3951L,3186L,-353L,-3597L,6784L,-7136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077905Inst : IEnumerable<long>
{
public static readonly long[] Value=A077905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077905.Bytes);
public long this[int i]=>Value[i];

public static A077905Inst Instance=new A077905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077906
{
public static readonly long[] Value={ 1L,0L,1L,-2L,3L,-4L,9L,-14L,23L,-40L,69L,-114L,195L,-332L,561L,-950L,1615L,-2736L,4637L,-7866L,13339L,-22612L,38345L,-65022L,110247L,-186936L,316981L,-537474L,911347L,-1545308L,2620257L,-4442950L,7533567L,-12774080L,21659981L,-36727114L,62275275L,-105595236L,179049465L,-303600014L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077906Inst : IEnumerable<long>
{
public static readonly long[] Value=A077906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077906.Bytes);
public long this[int i]=>Value[i];

public static A077906Inst Instance=new A077906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077907
{
public static readonly long[] Value={ 1L,0L,0L,3L,-2L,0L,9L,-12L,4L,27L,-54L,36L,73L,-216L,216L,147L,-794L,1080L,9L,-2676L,4828L,-2133L,-8046L,19836L,-16055L,-19872L,75600L,-87837L,-27506L,266544L,-414711L,93156L,854644L,-1777221L,1108890L,2377620L,-7040951L,6881112L,4915080L,-25878093L,34725238L,983016L,-87464439L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077907Inst : IEnumerable<long>
{
public static readonly long[] Value=A077907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077907.Bytes);
public long this[int i]=>Value[i];

public static A077907Inst Instance=new A077907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077956
{
public static readonly long[] Value={ 1L,1L,-1L,-5L,-5L,7L,27L,23L,-45L,-145L,-101L,279L,771L,415L,-1685L,-4057L,-1517L,9967L,21115L,4215L,-57949L,-108609L,-1141L,331975L,551475L,-110193L,-1877093L,-2759657L,1214915L,10488415L,13577899L,-9828761L,-57961389L,-65459665L,70120635L,316962743L,307640803L,-466525953L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077956Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077956.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077956Inst : IEnumerable<long>
{
public static readonly long[] Value=A077956.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077956.Bytes);
public long this[int i]=>Value[i];

public static A077956Inst Instance=new A077956Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077957
{
public static readonly long[] Value={ 1L,0L,2L,0L,4L,0L,8L,0L,16L,0L,32L,0L,64L,0L,128L,0L,256L,0L,512L,0L,1024L,0L,2048L,0L,4096L,0L,8192L,0L,16384L,0L,32768L,0L,65536L,0L,131072L,0L,262144L,0L,524288L,0L,1048576L,0L,2097152L,0L,4194304L,0L,8388608L,0L,16777216L,0L,33554432L,0L,67108864L,0L,134217728L,0L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077957Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077957.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077957Inst : IEnumerable<long>
{
public static readonly long[] Value=A077957.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077957.Bytes);
public long this[int i]=>Value[i];

public static A077957Inst Instance=new A077957Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077958
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,4L,0L,0L,8L,0L,0L,16L,0L,0L,32L,0L,0L,64L,0L,0L,128L,0L,0L,256L,0L,0L,512L,0L,0L,1024L,0L,0L,2048L,0L,0L,4096L,0L,0L,8192L,0L,0L,16384L,0L,0L,32768L,0L,0L,65536L,0L,0L,131072L,0L,0L,262144L,0L,0L,524288L,0L,0L,1048576L,0L,0L,2097152L,0L,0L,4194304L,0L,0L,8388608L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077958Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077958.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077958Inst : IEnumerable<long>
{
public static readonly long[] Value=A077958.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077958.Bytes);
public long this[int i]=>Value[i];

public static A077958Inst Instance=new A077958Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077959
{
public static readonly long[] Value={ 1L,0L,0L,-2L,0L,0L,4L,0L,0L,-8L,0L,0L,16L,0L,0L,-32L,0L,0L,64L,0L,0L,-128L,0L,0L,256L,0L,0L,-512L,0L,0L,1024L,0L,0L,-2048L,0L,0L,4096L,0L,0L,-8192L,0L,0L,16384L,0L,0L,-32768L,0L,0L,65536L,0L,0L,-131072L,0L,0L,262144L,0L,0L,-524288L,0L,0L,1048576L,0L,0L,-2097152L,0L,0L,4194304L,0L,0L,-8388608L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077959Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077959.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077959Inst : IEnumerable<long>
{
public static readonly long[] Value=A077959.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077959.Bytes);
public long this[int i]=>Value[i];

public static A077959Inst Instance=new A077959Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077960
{
public static readonly long[] Value={ 18L,122L,118L,117L,226L,130L,136L,1117L,187L,57L,28L,114L,128L,1111111L,52628L,111748L,114663L,212174L,110111L,35131L,81414L,122615L,33341L,4584L,111243L,25475L,33171L,21339L,22351L,41127L,21621L,2920L,111321L,2224811L,223249L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077960Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077960.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077960Inst : IEnumerable<long>
{
public static readonly long[] Value=A077960.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077960.Bytes);
public long this[int i]=>Value[i];

public static A077960Inst Instance=new A077960Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077961
{
public static readonly long[] Value={ 1L,0L,-1L,1L,1L,-2L,0L,3L,-2L,-3L,5L,1L,-8L,4L,9L,-12L,-5L,21L,-7L,-26L,28L,19L,-54L,9L,73L,-63L,-64L,136L,1L,-200L,135L,201L,-335L,-66L,536L,-269L,-602L,805L,333L,-1407L,472L,1740L,-1879L,-1268L,3619L,-611L,-4887L,4230L,4276L,-9117L,-46L,13393L,-9071L,-13439L,22464L,4368L,-35903L,18096L,40271L,-53999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077961Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077961.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077961Inst : IEnumerable<long>
{
public static readonly long[] Value=A077961.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077961.Bytes);
public long this[int i]=>Value[i];

public static A077961Inst Instance=new A077961Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077962
{
public static readonly long[] Value={ 1L,0L,-1L,-1L,1L,2L,0L,-3L,-2L,3L,5L,-1L,-8L,-4L,9L,12L,-5L,-21L,-7L,26L,28L,-19L,-54L,-9L,73L,63L,-64L,-136L,1L,200L,135L,-201L,-335L,66L,536L,269L,-602L,-805L,333L,1407L,472L,-1740L,-1879L,1268L,3619L,611L,-4887L,-4230L,4276L,9117L,-46L,-13393L,-9071L,13439L,22464L,-4368L,-35903L,-18096L,40271L,53999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077962Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077962.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077962Inst : IEnumerable<long>
{
public static readonly long[] Value=A077962.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077962.Bytes);
public long this[int i]=>Value[i];

public static A077962Inst Instance=new A077962Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077963
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,1L,4L,3L,-6L,-11L,0L,23L,22L,-23L,-68L,-21L,114L,157L,-72L,-385L,-242L,529L,1012L,-45L,-2070L,-1979L,2160L,6119L,1798L,-10439L,-14036L,6843L,34914L,21229L,-48600L,-91057L,6142L,188257L,175972L,-200541L,-552486L,-151403L,953568L,1256375L,-650762L,-3163511L,-1861988L,4465035L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077963Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077963.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077963Inst : IEnumerable<long>
{
public static readonly long[] Value=A077963.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077963.Bytes);
public long this[int i]=>Value[i];

public static A077963Inst Instance=new A077963Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077964
{
public static readonly long[] Value={ 1L,0L,-2L,2L,4L,-8L,-4L,24L,-8L,-56L,64L,96L,-240L,-64L,672L,-352L,-1472L,2048L,2240L,-7040L,-384L,18560L,-13312L,-37888L,63744L,49152L,-203264L,29184L,504832L,-464896L,-951296L,1939456L,972800L,-5781504L,1933312L,13508608L,-15429632L,-23150592L,57876480L,15441920L,-162054144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077964Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077964.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077964Inst : IEnumerable<long>
{
public static readonly long[] Value=A077964.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077964.Bytes);
public long this[int i]=>Value[i];

public static A077964Inst Instance=new A077964Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077965
{
public static readonly long[] Value={ 1L,0L,-2L,1L,4L,-4L,-7L,12L,10L,-31L,-8L,72L,-15L,-152L,102L,289L,-356L,-476L,1001L,596L,-2478L,-191L,5552L,-2096L,-11295L,9744L,20494L,-30783L,-31244L,82060L,31705L,-195364L,18650L,422433L,-232664L,-826216L,887761L,1419768L,-2601738L,-1951775L,6623244L,1301812L,-15198263L,4019620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077965Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077965.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077965Inst : IEnumerable<long>
{
public static readonly long[] Value=A077965.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077965.Bytes);
public long this[int i]=>Value[i];

public static A077965Inst Instance=new A077965Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077966
{
public static readonly long[] Value={ 1L,0L,-2L,0L,4L,0L,-8L,0L,16L,0L,-32L,0L,64L,0L,-128L,0L,256L,0L,-512L,0L,1024L,0L,-2048L,0L,4096L,0L,-8192L,0L,16384L,0L,-32768L,0L,65536L,0L,-131072L,0L,262144L,0L,-524288L,0L,1048576L,0L,-2097152L,0L,4194304L,0L,-8388608L,0L,16777216L,0L,-33554432L,0L,67108864L,0L,-134217728L,0L,268435456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077966Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077966.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077966Inst : IEnumerable<long>
{
public static readonly long[] Value=A077966.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077966.Bytes);
public long this[int i]=>Value[i];

public static A077966Inst Instance=new A077966Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077967
{
public static readonly long[] Value={ 1L,0L,-2L,-1L,4L,4L,-7L,-12L,10L,31L,-8L,-72L,-15L,152L,102L,-289L,-356L,476L,1001L,-596L,-2478L,191L,5552L,2096L,-11295L,-9744L,20494L,30783L,-31244L,-82060L,31705L,195364L,18650L,-422433L,-232664L,826216L,887761L,-1419768L,-2601738L,1951775L,6623244L,-1301812L,-15198263L,-4019620L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077967Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077967.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077967Inst : IEnumerable<long>
{
public static readonly long[] Value=A077967.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077967.Bytes);
public long this[int i]=>Value[i];

public static A077967Inst Instance=new A077967Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077968
{
public static readonly long[] Value={ 1L,0L,-2L,-2L,4L,8L,-4L,-24L,-8L,56L,64L,-96L,-240L,64L,672L,352L,-1472L,-2048L,2240L,7040L,-384L,-18560L,-13312L,37888L,63744L,-49152L,-203264L,-29184L,504832L,464896L,-951296L,-1939456L,972800L,5781504L,1933312L,-13508608L,-15429632L,23150592L,57876480L,-15441920L,-162054144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077968Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077968.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077968Inst : IEnumerable<long>
{
public static readonly long[] Value=A077968.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077968.Bytes);
public long this[int i]=>Value[i];

public static A077968Inst Instance=new A077968Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077969
{
public static readonly long[] Value={ 24L,30L,34L,40L,44L,46L,52L,56L,58L,98L,122L,128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077969Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077969.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077969Inst : IEnumerable<long>
{
public static readonly long[] Value=A077969.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077969.Bytes);
public long this[int i]=>Value[i];

public static A077969Inst Instance=new A077969Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077970
{
public static readonly long[] Value={ 1L,-1L,3L,-7L,15L,-35L,79L,-179L,407L,-923L,2095L,-4755L,10791L,-24491L,55583L,-126147L,286295L,-649755L,1474639L,-3346739L,7595527L,-17238283L,39122815L,-88790435L,201512631L,-457339131L,1037945263L,-2355648787L,5346217575L,-12133405675L,27537138399L,-62496384899L,141837473047L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077970Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077970.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077970Inst : IEnumerable<long>
{
public static readonly long[] Value=A077970.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077970.Bytes);
public long this[int i]=>Value[i];

public static A077970Inst Instance=new A077970Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A077971
{
public static readonly long[] Value={ 1L,-1L,2L,-1L,1L,2L,-3L,7L,-6L,7L,1L,-6L,21L,-25L,34L,-17L,1L,50L,-83L,135L,-118L,87L,65L,-214L,453L,-537L,562L,-193L,-319L,1250L,-1955L,2567L,-2022L,679L,2433L,-5798L,9589L,-10521L,8514L,143L,-12671L,29842L,-42227L,46727L,-29270L,-8457L,72641L,-139638L,195365L,-189721L,105810L,95199L,-368831L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A077971Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A077971.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A077971Inst : IEnumerable<long>
{
public static readonly long[] Value=A077971.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A077971.Bytes);
public long this[int i]=>Value[i];

public static A077971Inst Instance=new A077971Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078004
{
public static readonly long[] Value={ 1L,1L,0L,-3L,-7L,-8L,1L,25L,56L,61L,-15L,-208L,-447L,-463L,176L,1725L,3561L,3496L,-1855L,-14263L,-28312L,-26243L,18401L,117600L,224641L,195681L,-175520L,-967043L,-1778727L,-1447848L,1628801L,7932025L,14054296L,10615741L,-14809135L,-64904048L,-110805567L,-76993903L,132527376L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078004Inst : IEnumerable<long>
{
public static readonly long[] Value=A078004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078004.Bytes);
public long this[int i]=>Value[i];

public static A078004Inst Instance=new A078004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078005
{
public static readonly long[] Value={ 1L,1L,0L,-4L,-10L,-12L,4L,52L,120L,128L,-88L,-672L,-1424L,-1328L,1536L,8576L,16736L,13248L,-24128L,-108224L,-194688L,-124672L,356480L,1351680L,2239744L,1063168L,-5056512L,-16718848L,-25451008L,-7351296L,69637120L,204878848L,285186048L,21340160L,-937449472L,-2487951360L,-3143684096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078005Inst : IEnumerable<long>
{
public static readonly long[] Value=A078005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078005.Bytes);
public long this[int i]=>Value[i];

public static A078005Inst Instance=new A078005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078006
{
public static readonly long[] Value={ 1L,0L,2L,4L,8L,20L,44L,100L,228L,516L,1172L,2660L,6036L,13700L,31092L,70564L,160148L,363460L,824884L,1872100L,4248788L,9642756L,21884532L,49667620L,112722196L,255826500L,580606132L,1317703524L,2990568788L,6787188100L,15403732724L,34959246500L,79341088148L,180067046596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078006Inst : IEnumerable<long>
{
public static readonly long[] Value=A078006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078006.Bytes);
public long this[int i]=>Value[i];

public static A078006Inst Instance=new A078006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078007
{
public static readonly long[] Value={ 1L,0L,2L,3L,7L,15L,32L,69L,148L,318L,683L,1467L,3151L,6768L,14537L,31224L,67066L,144051L,309407L,664575L,1427440L,3065997L,6585452L,14144886L,30381787L,65257011L,140165471L,301061280L,646649233L,1388937264L,2983297010L,6407820771L,13763352055L,29562290607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078007Inst : IEnumerable<long>
{
public static readonly long[] Value=A078007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078007.Bytes);
public long this[int i]=>Value[i];

public static A078007Inst Instance=new A078007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078008
{
public static readonly long[] Value={ 1L,0L,2L,2L,6L,10L,22L,42L,86L,170L,342L,682L,1366L,2730L,5462L,10922L,21846L,43690L,87382L,174762L,349526L,699050L,1398102L,2796202L,5592406L,11184810L,22369622L,44739242L,89478486L,178956970L,357913942L,715827882L,1431655766L,2863311530L,5726623062L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078008Inst : IEnumerable<long>
{
public static readonly long[] Value=A078008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078008.Bytes);
public long this[int i]=>Value[i];

public static A078008Inst Instance=new A078008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078009
{
public static readonly long[] Value={ 1L,1L,6L,41L,306L,2426L,20076L,171481L,1500666L,13386206L,121267476L,1112674026L,10318939956L,96572168916L,910896992856L,8650566601401L,82644968321226L,793753763514806L,7659535707782916L,74225795172589006L,722042370787826076L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078009Inst : IEnumerable<long>
{
public static readonly long[] Value=A078009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078009.Bytes);
public long this[int i]=>Value[i];

public static A078009Inst Instance=new A078009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078010
{
public static readonly long[] Value={ 1L,0L,1L,3L,4L,9L,19L,36L,73L,147L,292L,585L,1171L,2340L,4681L,9363L,18724L,37449L,74899L,149796L,299593L,599187L,1198372L,2396745L,4793491L,9586980L,19173961L,38347923L,76695844L,153391689L,306783379L,613566756L,1227133513L,2454267027L,4908534052L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078010Inst : IEnumerable<long>
{
public static readonly long[] Value=A078010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078010.Bytes);
public long this[int i]=>Value[i];

public static A078010Inst Instance=new A078010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078011
{
public static readonly long[] Value={ 1L,0L,1L,-1L,0L,-3L,-1L,-4L,1L,-1L,8L,5L,15L,4L,9L,-17L,-16L,-51L,-33L,-52L,17L,31L,152L,149L,239L,84L,25L,-369L,-512L,-931L,-705L,-612L,545L,1343L,3112L,3365L,3791L,932L,-2007L,-8657L,-12528L,-17171L,-12385L,-4500L,17457L,37727L,64184L,66997L,55727L,-5644L,-83911L,-201009L,-273632L,-306819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078011Inst : IEnumerable<long>
{
public static readonly long[] Value=A078011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078011.Bytes);
public long this[int i]=>Value[i];

public static A078011Inst Instance=new A078011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078012
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,2L,3L,4L,6L,9L,13L,19L,28L,41L,60L,88L,129L,189L,277L,406L,595L,872L,1278L,1873L,2745L,4023L,5896L,8641L,12664L,18560L,27201L,39865L,58425L,85626L,125491L,183916L,269542L,395033L,578949L,848491L,1243524L,1822473L,2670964L,3914488L,5736961L,8407925L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078012Inst : IEnumerable<long>
{
public static readonly long[] Value=A078012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078012.Bytes);
public long this[int i]=>Value[i];

public static A078012Inst Instance=new A078012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078013
{
public static readonly long[] Value={ 1L,0L,0L,-1L,-1L,-1L,0L,1L,2L,2L,1L,-1L,-3L,-4L,-3L,0L,4L,7L,7L,3L,-4L,-11L,-14L,-10L,1L,15L,25L,24L,9L,-16L,-40L,-49L,-33L,7L,56L,89L,82L,26L,-63L,-145L,-171L,-108L,37L,208L,316L,279L,71L,-245L,-524L,-595L,-350L,174L,769L,1119L,945L,176L,-943L,-1888L,-2064L,-1121L,767L,2831L,3952L,3185L,354L,-3598L,-6783L,-7137L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078013Inst : IEnumerable<long>
{
public static readonly long[] Value=A078013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078013.Bytes);
public long this[int i]=>Value[i];

public static A078013Inst Instance=new A078013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A078014
{
public static readonly long[] Value={ 1L,0L,0L,-2L,-2L,-2L,2L,6L,10L,6L,-6L,-26L,-38L,-26L,26L,102L,154L,102L,-102L,-410L,-614L,-410L,410L,1638L,2458L,1638L,-1638L,-6554L,-9830L,-6554L,6554L,26214L,39322L,26214L,-26214L,-104858L,-157286L,-104858L,104858L,419430L,629146L,419430L,-419430L,-1677722L,-2516582L,-1677722L,1677722L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A078014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A078014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A078014Inst : IEnumerable<long>
{
public static readonly long[] Value=A078014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A078014.Bytes);
public long this[int i]=>Value[i];

public static A078014Inst Instance=new A078014Inst();

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