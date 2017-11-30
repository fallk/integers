using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A120141
{
public static readonly long[] Value={ 14L,21L,32L,48L,72L,108L,162L,243L,364L,546L,819L,1229L,1843L,2765L,4147L,6221L,9331L,13997L,20995L,31493L,47239L,70859L,106288L,159432L,239148L,358722L,538083L,807125L,1210687L,1816031L,2724046L,4086069L,6129104L,9193656L,13790484L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120141Inst : IEnumerable<long>
{
public static readonly long[] Value=A120141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120141.Bytes);
public long this[int i]=>Value[i];

public static A120141Inst Instance=new A120141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120142
{
public static readonly long[] Value={ 16L,24L,36L,54L,81L,121L,182L,273L,409L,614L,921L,1381L,2072L,3108L,4662L,6993L,10489L,15734L,23601L,35401L,53102L,79653L,119479L,179219L,268828L,403242L,604863L,907295L,1360942L,2041413L,3062120L,4593180L,6889770L,10334655L,15501982L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120142Inst : IEnumerable<long>
{
public static readonly long[] Value=A120142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120142.Bytes);
public long this[int i]=>Value[i];

public static A120142Inst Instance=new A120142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120143
{
public static readonly long[] Value={ 17L,26L,39L,58L,87L,131L,196L,294L,441L,662L,993L,1489L,2234L,3351L,5026L,7539L,11309L,16963L,25445L,38167L,57251L,85876L,128814L,193221L,289832L,434748L,652122L,978183L,1467274L,2200911L,3301367L,4952050L,7428075L,11142113L,16713169L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120143Inst : IEnumerable<long>
{
public static readonly long[] Value=A120143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120143.Bytes);
public long this[int i]=>Value[i];

public static A120143Inst Instance=new A120143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120144
{
public static readonly long[] Value={ 19L,28L,42L,63L,95L,142L,213L,320L,480L,720L,1080L,1620L,2430L,3645L,5467L,8201L,12301L,18452L,27678L,41517L,62275L,93413L,140119L,210179L,315268L,472902L,709353L,1064030L,1596045L,2394067L,3591101L,5386651L,8079977L,12119965L,18179948L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120144Inst : IEnumerable<long>
{
public static readonly long[] Value=A120144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120144.Bytes);
public long this[int i]=>Value[i];

public static A120144Inst Instance=new A120144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120145
{
public static readonly long[] Value={ 20L,30L,45L,68L,102L,153L,229L,344L,516L,774L,1161L,1741L,2612L,3918L,5877L,8815L,13223L,19834L,29751L,44627L,66940L,100410L,150615L,225923L,338884L,508326L,762489L,1143734L,1715601L,2573401L,3860102L,5790153L,8685229L,13027844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120145Inst : IEnumerable<long>
{
public static readonly long[] Value=A120145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120145.Bytes);
public long this[int i]=>Value[i];

public static A120145Inst Instance=new A120145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120146
{
public static readonly long[] Value={ 22L,33L,49L,74L,111L,166L,249L,374L,561L,841L,1262L,1893L,2839L,4259L,6388L,9582L,14373L,21560L,32340L,48510L,72765L,109147L,163721L,245581L,368372L,552558L,828837L,1243255L,1864883L,2797324L,4195986L,6293979L,9440969L,14161453L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120146Inst : IEnumerable<long>
{
public static readonly long[] Value=A120146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120146.Bytes);
public long this[int i]=>Value[i];

public static A120146Inst Instance=new A120146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120147
{
public static readonly long[] Value={ 23L,35L,52L,78L,117L,176L,264L,396L,594L,891L,1336L,2004L,3006L,4509L,6764L,10146L,15219L,22828L,34242L,51363L,77045L,115567L,173351L,260026L,390039L,585059L,877588L,1316382L,1974573L,2961860L,4442790L,6664185L,9996277L,14994416L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120147Inst : IEnumerable<long>
{
public static readonly long[] Value=A120147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120147.Bytes);
public long this[int i]=>Value[i];

public static A120147Inst Instance=new A120147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120148
{
public static readonly long[] Value={ 25L,37L,56L,84L,126L,189L,283L,425L,637L,956L,1434L,2151L,3226L,4839L,7259L,10888L,16332L,24498L,36747L,55121L,82681L,124022L,186033L,279049L,418574L,627861L,941791L,1412687L,2119030L,3178545L,4767818L,7151727L,10727590L,16091385L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120148Inst : IEnumerable<long>
{
public static readonly long[] Value=A120148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120148.Bytes);
public long this[int i]=>Value[i];

public static A120148Inst Instance=new A120148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120149
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,9L,12L,16L,21L,28L,38L,50L,67L,89L,119L,159L,212L,282L,376L,502L,669L,892L,1189L,1586L,2114L,2819L,3759L,5012L,6682L,8910L,11880L,15840L,21120L,28160L,37546L,50062L,66749L,88999L,118665L,158220L,210960L,281280L,375040L,500053L,666738L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120149Inst : IEnumerable<long>
{
public static readonly long[] Value=A120149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120149.Bytes);
public long this[int i]=>Value[i];

public static A120149Inst Instance=new A120149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120150
{
public static readonly long[] Value={ 3L,4L,6L,8L,10L,14L,18L,24L,32L,43L,57L,76L,102L,136L,181L,241L,322L,429L,572L,763L,1017L,1356L,1808L,2411L,3214L,4286L,5714L,7619L,10159L,13545L,18060L,24080L,32107L,42809L,57079L,76105L,101473L,135298L,180397L,240529L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120150Inst : IEnumerable<long>
{
public static readonly long[] Value=A120150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120150.Bytes);
public long this[int i]=>Value[i];

public static A120150Inst Instance=new A120150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120151
{
public static readonly long[] Value={ 5L,6L,8L,11L,15L,20L,26L,35L,47L,62L,83L,111L,148L,197L,263L,350L,467L,623L,830L,1107L,1476L,1968L,2624L,3499L,4665L,6220L,8293L,11058L,14744L,19658L,26211L,34948L,46597L,62130L,82840L,110453L,147271L,196361L,261815L,349086L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120151Inst : IEnumerable<long>
{
public static readonly long[] Value=A120151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120151.Bytes);
public long this[int i]=>Value[i];

public static A120151Inst Instance=new A120151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120152
{
public static readonly long[] Value={ 6L,8L,11L,14L,19L,25L,34L,45L,60L,80L,107L,142L,190L,253L,337L,450L,600L,800L,1066L,1422L,1896L,2528L,3370L,4494L,5992L,7989L,10652L,14203L,18937L,25249L,33666L,44888L,59850L,79800L,106400L,141867L,189156L,252208L,336277L,448370L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120152Inst : IEnumerable<long>
{
public static readonly long[] Value=A120152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120152.Bytes);
public long this[int i]=>Value[i];

public static A120152Inst Instance=new A120152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120153
{
public static readonly long[] Value={ 7L,10L,13L,17L,23L,31L,41L,55L,73L,97L,130L,173L,231L,308L,410L,547L,729L,972L,1296L,1728L,2304L,3072L,4096L,5462L,7282L,9710L,12946L,17262L,23016L,30688L,40917L,54556L,72741L,96988L,129318L,172424L,229898L,306531L,408708L,544944L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120153Inst : IEnumerable<long>
{
public static readonly long[] Value=A120153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120153.Bytes);
public long this[int i]=>Value[i];

public static A120153Inst Instance=new A120153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120154
{
public static readonly long[] Value={ 9L,12L,16L,21L,28L,37L,50L,66L,88L,118L,157L,209L,279L,372L,496L,661L,882L,1176L,1568L,2090L,2787L,3716L,4955L,6606L,8808L,11744L,15659L,20879L,27838L,37118L,49490L,65987L,87983L,117310L,156414L,208552L,278069L,370759L,494345L,659127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120154Inst : IEnumerable<long>
{
public static readonly long[] Value=A120154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120154.Bytes);
public long this[int i]=>Value[i];

public static A120154Inst Instance=new A120154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120155
{
public static readonly long[] Value={ 10L,13L,18L,24L,32L,42L,56L,75L,100L,133L,178L,237L,316L,421L,562L,749L,999L,1332L,1776L,2368L,3157L,4209L,5612L,7483L,9977L,13303L,17737L,23650L,31533L,42044L,56059L,74745L,99660L,132880L,177173L,236231L,314975L,419966L,559955L,746607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120155Inst : IEnumerable<long>
{
public static readonly long[] Value=A120155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120155.Bytes);
public long this[int i]=>Value[i];

public static A120155Inst Instance=new A120155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120156
{
public static readonly long[] Value={ 11L,15L,20L,27L,36L,48L,64L,85L,113L,151L,201L,268L,358L,477L,636L,848L,1131L,1508L,2010L,2680L,3574L,4765L,6353L,8471L,11295L,15060L,20080L,26773L,35697L,47596L,63462L,84616L,112821L,150428L,200571L,267428L,356570L,475427L,633903L,845204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120156Inst : IEnumerable<long>
{
public static readonly long[] Value=A120156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120156.Bytes);
public long this[int i]=>Value[i];

public static A120156Inst Instance=new A120156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120157
{
public static readonly long[] Value={ 13L,17L,23L,30L,40L,54L,72L,96L,128L,170L,227L,303L,404L,538L,718L,957L,1276L,1701L,2268L,3024L,4032L,5376L,7168L,9558L,12744L,16992L,22656L,30208L,40277L,53703L,71604L,95472L,127296L,169728L,226304L,301738L,402318L,536424L,715232L,953642L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120157Inst : IEnumerable<long>
{
public static readonly long[] Value=A120157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120157.Bytes);
public long this[int i]=>Value[i];

public static A120157Inst Instance=new A120157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120158
{
public static readonly long[] Value={ 14L,19L,25L,33L,44L,59L,79L,105L,140L,187L,249L,332L,443L,590L,787L,1049L,1399L,1865L,2487L,3316L,4421L,5895L,7860L,10480L,13973L,18631L,24841L,33122L,44162L,58883L,78511L,104681L,139575L,186100L,248133L,330844L,441125L,588167L,784223L,1045630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120158Inst : IEnumerable<long>
{
public static readonly long[] Value=A120158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120158.Bytes);
public long this[int i]=>Value[i];

public static A120158Inst Instance=new A120158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120159
{
public static readonly long[] Value={ 15L,20L,27L,36L,48L,64L,85L,114L,152L,202L,270L,360L,480L,640L,853L,1137L,1516L,2022L,2696L,3594L,4792L,6390L,8520L,11360L,15146L,20195L,26927L,35902L,47870L,63826L,85102L,113469L,151292L,201723L,268964L,358618L,478158L,637544L,850058L,1133411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120159Inst : IEnumerable<long>
{
public static readonly long[] Value=A120159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120159.Bytes);
public long this[int i]=>Value[i];

public static A120159Inst Instance=new A120159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120160
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,2L,3L,3L,4L,5L,6L,8L,10L,12L,15L,19L,24L,30L,37L,47L,58L,73L,91L,114L,142L,178L,222L,278L,347L,434L,543L,678L,848L,1060L,1325L,1656L,2070L,2588L,3235L,4043L,5054L,6318L,7897L,9871L,12339L,15424L,19280L,24100L,30125L,37656L,47070L,58838L,73547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120160Inst : IEnumerable<long>
{
public static readonly long[] Value=A120160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120160.Bytes);
public long this[int i]=>Value[i];

public static A120160Inst Instance=new A120160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120161
{
public static readonly long[] Value={ 2L,2L,3L,4L,5L,6L,7L,9L,11L,14L,18L,22L,28L,35L,43L,54L,68L,85L,106L,132L,165L,207L,258L,323L,404L,505L,631L,789L,986L,1232L,1540L,1925L,2407L,3008L,3760L,4700L,5875L,7344L,9180L,11475L,14344L,17930L,22412L,28015L,35019L,43774L,54717L,68397L,85496L,106870L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120161Inst : IEnumerable<long>
{
public static readonly long[] Value=A120161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120161.Bytes);
public long this[int i]=>Value[i];

public static A120161Inst Instance=new A120161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120162
{
public static readonly long[] Value={ 3L,4L,5L,6L,8L,10L,12L,15L,19L,24L,30L,37L,46L,58L,72L,90L,113L,141L,176L,220L,275L,344L,430L,538L,672L,840L,1050L,1313L,1641L,2051L,2564L,3205L,4006L,5008L,6260L,7825L,9781L,12226L,15283L,19103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120162Inst : IEnumerable<long>
{
public static readonly long[] Value=A120162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120162.Bytes);
public long this[int i]=>Value[i];

public static A120162Inst Instance=new A120162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120163
{
public static readonly long[] Value={ 4L,5L,7L,8L,10L,13L,16L,20L,25L,31L,39L,49L,61L,76L,95L,119L,149L,186L,233L,291L,364L,455L,568L,710L,888L,1110L,1387L,1734L,2168L,2710L,3387L,4234L,5292L,6615L,8269L,10336L,12920L,16150L,20188L,25235L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120163Inst : IEnumerable<long>
{
public static readonly long[] Value=A120163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120163.Bytes);
public long this[int i]=>Value[i];

public static A120163Inst Instance=new A120163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120164
{
public static readonly long[] Value={ 6L,7L,9L,11L,14L,17L,22L,27L,34L,42L,53L,66L,83L,103L,129L,161L,202L,252L,315L,394L,492L,615L,769L,961L,1202L,1502L,1878L,2347L,2934L,3667L,4584L,5730L,7163L,8953L,11192L,13990L,17487L,21859L,27324L,34155L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120164Inst : IEnumerable<long>
{
public static readonly long[] Value=A120164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120164.Bytes);
public long this[int i]=>Value[i];

public static A120164Inst Instance=new A120164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120165
{
public static readonly long[] Value={ 7L,9L,11L,14L,17L,21L,27L,33L,42L,52L,65L,81L,102L,127L,159L,199L,248L,310L,388L,485L,606L,758L,947L,1184L,1480L,1850L,2312L,2890L,3613L,4516L,5645L,7056L,8820L,11025L,13782L,17227L,21534L,26917L,33647L,42058L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120165Inst : IEnumerable<long>
{
public static readonly long[] Value=A120165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120165.Bytes);
public long this[int i]=>Value[i];

public static A120165Inst Instance=new A120165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120166
{
public static readonly long[] Value={ 8L,10L,13L,16L,20L,25L,31L,39L,49L,61L,76L,95L,119L,149L,186L,232L,290L,363L,454L,567L,709L,886L,1108L,1385L,1731L,2164L,2705L,3381L,4226L,5283L,6603L,8254L,10318L,12897L,16121L,20152L,25190L,31487L,39359L,49199L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120166Inst : IEnumerable<long>
{
public static readonly long[] Value=A120166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120166.Bytes);
public long this[int i]=>Value[i];

public static A120166Inst Instance=new A120166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120167
{
public static readonly long[] Value={ 9L,12L,15L,18L,23L,29L,36L,45L,56L,70L,88L,110L,137L,171L,214L,268L,335L,418L,523L,654L,817L,1021L,1277L,1596L,1995L,2494L,3117L,3896L,4870L,6088L,7610L,9512L,11890L,14863L,18579L,23223L,29029L,36286L,45358L,56697L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120167Inst : IEnumerable<long>
{
public static readonly long[] Value=A120167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120167.Bytes);
public long this[int i]=>Value[i];

public static A120167Inst Instance=new A120167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120168
{
public static readonly long[] Value={ 11L,13L,17L,21L,26L,33L,41L,51L,64L,80L,100L,125L,156L,195L,244L,305L,381L,476L,595L,744L,930L,1163L,1453L,1817L,2271L,2839L,3548L,4435L,5544L,6930L,8663L,10828L,13535L,16919L,21149L,26436L,33045L,41306L,51633L,64541L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120168Inst : IEnumerable<long>
{
public static readonly long[] Value=A120168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120168.Bytes);
public long this[int i]=>Value[i];

public static A120168Inst Instance=new A120168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120169
{
public static readonly long[] Value={ 12L,15L,19L,23L,29L,36L,45L,57L,71L,89L,111L,139L,173L,217L,271L,339L,423L,529L,661L,827L,1033L,1292L,1615L,2018L,2523L,3154L,3942L,4928L,6160L,7700L,9625L,12031L,15039L,18798L,23498L,29372L,36715L,45894L,57368L,71710L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120169Inst : IEnumerable<long>
{
public static readonly long[] Value=A120169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120169.Bytes);
public long this[int i]=>Value[i];

public static A120169Inst Instance=new A120169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120170
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,5L,6L,7L,8L,10L,12L,14L,17L,21L,25L,30L,36L,43L,52L,62L,74L,89L,107L,128L,154L,185L,222L,266L,319L,383L,460L,552L,662L,795L,954L,1144L,1373L,1648L,1977L,2373L,2847L,3417L,4100L,4920L,5904L,7085L,8502L,10202L,12243L,14691L,17630L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120170Inst : IEnumerable<long>
{
public static readonly long[] Value=A120170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120170.Bytes);
public long this[int i]=>Value[i];

public static A120170Inst Instance=new A120170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120171
{
public static readonly long[] Value={ 2L,2L,3L,3L,4L,5L,6L,7L,8L,10L,12L,14L,17L,20L,24L,29L,35L,42L,50L,60L,72L,87L,104L,125L,150L,180L,216L,259L,311L,373L,448L,537L,645L,774L,929L,1114L,1337L,1605L,1926L,2311L,2773L,3328L,3993L,4792L,5750L,6900L,8280L,9936L,11923L,14308L,17170L,20604L,24724L,29669L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120171Inst : IEnumerable<long>
{
public static readonly long[] Value=A120171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120171.Bytes);
public long this[int i]=>Value[i];

public static A120171Inst Instance=new A120171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120172
{
public static readonly long[] Value={ 3L,4L,4L,5L,6L,7L,9L,11L,13L,15L,18L,22L,26L,32L,38L,46L,55L,66L,79L,95L,114L,137L,164L,197L,236L,283L,340L,408L,490L,588L,705L,846L,1015L,1218L,1462L,1754L,2105L,2526L,3031L,3638L,4365L,5238L,6286L,7543L,9052L,10862L,13034L,15641L,18769L,22523L,27028L,32433L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120172Inst : IEnumerable<long>
{
public static readonly long[] Value=A120172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120172.Bytes);
public long this[int i]=>Value[i];

public static A120172Inst Instance=new A120172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120173
{
public static readonly long[] Value={ 4L,5L,6L,7L,9L,10L,12L,15L,18L,21L,26L,31L,37L,44L,53L,64L,77L,92L,110L,132L,159L,191L,229L,275L,330L,396L,475L,570L,684L,821L,985L,1182L,1418L,1702L,2042L,2451L,2941L,3529L,4235L,5082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120173Inst : IEnumerable<long>
{
public static readonly long[] Value=A120173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120173.Bytes);
public long this[int i]=>Value[i];

public static A120173Inst Instance=new A120173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120174
{
public static readonly long[] Value={ 5L,6L,8L,9L,11L,13L,16L,19L,23L,27L,33L,39L,47L,57L,68L,82L,98L,118L,141L,169L,203L,244L,293L,351L,421L,506L,607L,728L,874L,1049L,1258L,1510L,1812L,2174L,2609L,3131L,3757L,4509L,5410L,6492L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120174Inst : IEnumerable<long>
{
public static readonly long[] Value=A120174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120174.Bytes);
public long this[int i]=>Value[i];

public static A120174Inst Instance=new A120174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120175
{
public static readonly long[] Value={ 7L,8L,10L,12L,14L,17L,20L,24L,29L,35L,42L,50L,60L,72L,87L,104L,125L,150L,180L,216L,259L,311L,373L,448L,537L,645L,774L,928L,1114L,1337L,1604L,1925L,2310L,2772L,3326L,3992L,4790L,5748L,6898L,8277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120175Inst : IEnumerable<long>
{
public static readonly long[] Value=A120175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120175.Bytes);
public long this[int i]=>Value[i];

public static A120175Inst Instance=new A120175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120176
{
public static readonly long[] Value={ 8L,9L,11L,13L,16L,19L,23L,28L,33L,40L,48L,57L,69L,83L,99L,119L,143L,171L,206L,247L,296L,355L,426L,512L,614L,737L,884L,1061L,1273L,1528L,1833L,2200L,2640L,3168L,3802L,4562L,5474L,6569L,7883L,9460L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120176Inst : IEnumerable<long>
{
public static readonly long[] Value=A120176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120176.Bytes);
public long this[int i]=>Value[i];

public static A120176Inst Instance=new A120176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120177
{
public static readonly long[] Value={ 9L,11L,13L,16L,19L,23L,27L,33L,39L,47L,56L,68L,81L,97L,117L,140L,168L,202L,242L,291L,349L,419L,502L,603L,723L,868L,1042L,1250L,1500L,1800L,2160L,2592L,3110L,3732L,4479L,5375L,6450L,7740L,9288L,11145L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120177Inst : IEnumerable<long>
{
public static readonly long[] Value=A120177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120177.Bytes);
public long this[int i]=>Value[i];

public static A120177Inst Instance=new A120177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120178
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,9L,11L,13L,15L,17L,20L,23L,27L,32L,37L,43L,50L,59L,69L,80L,93L,109L,127L,148L,173L,202L,235L,275L,320L,374L,436L,509L,594L,693L,808L,943L,1100L,1283L,1497L,1747L,2038L,2377L,2774L,3236L,3775L,4404L,5138L,5995L,6994L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120178Inst : IEnumerable<long>
{
public static readonly long[] Value=A120178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120178.Bytes);
public long this[int i]=>Value[i];

public static A120178Inst Instance=new A120178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120179
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,4L,4L,5L,6L,7L,8L,9L,11L,13L,15L,17L,20L,24L,28L,32L,38L,44L,51L,60L,70L,81L,95L,111L,129L,151L,176L,205L,239L,279L,326L,380L,443L,517L,603L,704L,821L,958L,1118L,1304L,1521L,1775L,2071L,2416L,2819L,3288L,3836L,4476L,5222L,6092L,7107L,8292L,9674L,11286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120179Inst : IEnumerable<long>
{
public static readonly long[] Value=A120179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120179.Bytes);
public long this[int i]=>Value[i];

public static A120179Inst Instance=new A120179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120180
{
public static readonly long[] Value={ 3L,3L,4L,5L,5L,6L,7L,8L,10L,11L,13L,15L,18L,21L,24L,28L,33L,39L,45L,53L,61L,72L,84L,98L,114L,133L,155L,181L,211L,246L,287L,335L,391L,456L,532L,621L,724L,845L,986L,1150L,1342L,1565L,1826L,2131L,2486L,2900L,3383L,3947L,4605L,5373L,6268L,7313L,8532L,9954L,11613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120180Inst : IEnumerable<long>
{
public static readonly long[] Value=A120180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120180.Bytes);
public long this[int i]=>Value[i];

public static A120180Inst Instance=new A120180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120181
{
public static readonly long[] Value={ 4L,5L,6L,7L,8L,9L,11L,12L,14L,17L,20L,23L,27L,31L,36L,42L,49L,58L,67L,78L,91L,107L,124L,145L,169L,197L,230L,269L,313L,366L,427L,498L,581L,678L,791L,922L,1076L,1255L,1465L,1709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120181Inst : IEnumerable<long>
{
public static readonly long[] Value=A120181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120181.Bytes);
public long this[int i]=>Value[i];

public static A120181Inst Instance=new A120181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120182
{
public static readonly long[] Value={ 5L,6L,7L,8L,10L,11L,13L,15L,18L,21L,24L,28L,33L,38L,45L,52L,61L,71L,83L,97L,113L,132L,154L,179L,209L,244L,285L,332L,388L,452L,528L,616L,718L,838L,978L,1141L,1331L,1553L,1811L,2113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120182Inst : IEnumerable<long>
{
public static readonly long[] Value=A120182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120182.Bytes);
public long this[int i]=>Value[i];

public static A120182Inst Instance=new A120182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120183
{
public static readonly long[] Value={ 6L,7L,9L,10L,12L,14L,16L,19L,22L,26L,30L,35L,41L,48L,56L,65L,76L,88L,103L,120L,140L,164L,191L,223L,260L,303L,354L,413L,482L,562L,656L,765L,892L,1041L,1215L,1417L,1653L,1929L,2250L,2625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120183Inst : IEnumerable<long>
{
public static readonly long[] Value=A120183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120183.Bytes);
public long this[int i]=>Value[i];

public static A120183Inst Instance=new A120183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120184
{
public static readonly long[] Value={ 8L,9L,10L,12L,14L,16L,19L,22L,26L,30L,35L,41L,48L,56L,65L,76L,89L,104L,121L,141L,165L,192L,224L,261L,305L,356L,415L,484L,565L,659L,769L,897L,1047L,1221L,1425L,1662L,1939L,2262L,2639L,3079L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120184Inst : IEnumerable<long>
{
public static readonly long[] Value=A120184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120184.Bytes);
public long this[int i]=>Value[i];

public static A120184Inst Instance=new A120184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120185
{
public static readonly long[] Value={ 9L,10L,12L,14L,16L,19L,22L,26L,30L,35L,41L,48L,56L,65L,76L,89L,103L,121L,141L,164L,192L,224L,261L,304L,355L,414L,483L,564L,658L,767L,895L,1044L,1218L,1421L,1658L,1935L,2257L,2633L,3072L,3584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120185Inst : IEnumerable<long>
{
public static readonly long[] Value=A120185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120185.Bytes);
public long this[int i]=>Value[i];

public static A120185Inst Instance=new A120185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120186
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,4L,4L,5L,5L,6L,7L,8L,9L,10L,12L,14L,16L,18L,20L,23L,27L,30L,35L,40L,45L,52L,59L,68L,77L,88L,101L,115L,132L,151L,172L,197L,225L,257L,294L,336L,384L,439L,501L,573L,655L,748L,855L,977L,1117L,1277L,1459L,1667L,1906L,2178L,2489L,2845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120186Inst : IEnumerable<long>
{
public static readonly long[] Value=A120186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120186.Bytes);
public long this[int i]=>Value[i];

public static A120186Inst Instance=new A120186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120187
{
public static readonly long[] Value={ 2L,2L,2L,3L,3L,3L,4L,4L,5L,6L,7L,8L,9L,10L,11L,13L,15L,17L,19L,22L,25L,29L,33L,38L,43L,49L,56L,64L,73L,84L,96L,110L,125L,143L,164L,187L,214L,244L,279L,319L,365L,417L,476L,544L,622L,711L,812L,928L,1061L,1213L,1386L,1584L,1810L,2069L,2364L,2702L,3088L,3529L,4033L,4609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120187Inst : IEnumerable<long>
{
public static readonly long[] Value=A120187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120187.Bytes);
public long this[int i]=>Value[i];

public static A120187Inst Instance=new A120187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120188
{
public static readonly long[] Value={ 3L,3L,4L,4L,5L,6L,6L,7L,8L,9L,11L,12L,14L,16L,18L,21L,24L,27L,31L,36L,41L,47L,53L,61L,70L,80L,91L,104L,119L,136L,155L,177L,203L,232L,265L,303L,346L,395L,452L,516L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120188Inst : IEnumerable<long>
{
public static readonly long[] Value=A120188.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120188.Bytes);
public long this[int i]=>Value[i];

public static A120188Inst Instance=new A120188Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120189
{
public static readonly long[] Value={ 4L,5L,5L,6L,7L,8L,9L,10L,12L,13L,15L,17L,20L,23L,26L,30L,34L,39L,44L,51L,58L,66L,76L,87L,99L,113L,129L,148L,169L,193L,221L,252L,288L,329L,376L,430L,491L,562L,642L,734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120189Inst : IEnumerable<long>
{
public static readonly long[] Value=A120189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120189.Bytes);
public long this[int i]=>Value[i];

public static A120189Inst Instance=new A120189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120190
{
public static readonly long[] Value={ 5L,6L,7L,8L,9L,10L,12L,13L,15L,17L,20L,23L,26L,30L,34L,39L,44L,51L,58L,66L,76L,86L,99L,113L,129L,147L,168L,192L,220L,251L,287L,328L,375L,429L,490L,560L,640L,731L,836L,955L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120190Inst : IEnumerable<long>
{
public static readonly long[] Value=A120190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120190.Bytes);
public long this[int i]=>Value[i];

public static A120190Inst Instance=new A120190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120191
{
public static readonly long[] Value={ 6L,7L,8L,9L,11L,12L,14L,16L,18L,21L,24L,27L,31L,35L,40L,46L,53L,60L,69L,79L,90L,103L,118L,134L,154L,176L,201L,229L,262L,300L,342L,391L,447L,511L,584L,667L,763L,872L,996L,1139L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120191Inst : IEnumerable<long>
{
public static readonly long[] Value=A120191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120191.Bytes);
public long this[int i]=>Value[i];

public static A120191Inst Instance=new A120191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120192
{
public static readonly long[] Value={ 7L,8L,10L,11L,13L,14L,16L,19L,21L,24L,28L,32L,36L,42L,48L,54L,62L,71L,81L,93L,106L,121L,138L,158L,181L,207L,236L,270L,308L,352L,403L,460L,526L,601L,687L,785L,897L,1025L,1172L,1339L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120192Inst : IEnumerable<long>
{
public static readonly long[] Value=A120192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120192.Bytes);
public long this[int i]=>Value[i];

public static A120192Inst Instance=new A120192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120193
{
public static readonly long[] Value={ 9L,10L,11L,13L,15L,17L,19L,22L,25L,29L,33L,38L,43L,49L,56L,64L,73L,84L,96L,109L,125L,143L,163L,187L,213L,244L,279L,318L,364L,416L,475L,543L,621L,709L,811L,927L,1059L,1210L,1383L,1581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120193Inst : IEnumerable<long>
{
public static readonly long[] Value=A120193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120193.Bytes);
public long this[int i]=>Value[i];

public static A120193Inst Instance=new A120193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120194
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,18L,20L,22L,25L,28L,32L,36L,40L,45L,51L,57L,64L,72L,81L,91L,103L,116L,130L,146L,165L,185L,208L,234L,264L,297L,334L,376L,423L,475L,535L,602L,677L,762L,857L,964L,1084L,1220L,1372L,1544L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120194Inst : IEnumerable<long>
{
public static readonly long[] Value=A120194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120194.Bytes);
public long this[int i]=>Value[i];

public static A120194Inst Instance=new A120194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120195
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,7L,8L,9L,10L,11L,12L,14L,16L,18L,20L,22L,25L,28L,32L,36L,40L,45L,51L,57L,64L,72L,81L,92L,103L,116L,130L,147L,165L,186L,209L,235L,264L,297L,335L,376L,423L,476L,536L,603L,678L,763L,858L,966L,1086L,1222L,1375L,1547L,1740L,1958L,2202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120195Inst : IEnumerable<long>
{
public static readonly long[] Value=A120195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120195.Bytes);
public long this[int i]=>Value[i];

public static A120195Inst Instance=new A120195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120196
{
public static readonly long[] Value={ 3L,3L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,12L,13L,15L,17L,19L,21L,24L,27L,30L,34L,38L,43L,48L,54L,61L,69L,77L,87L,98L,110L,124L,139L,157L,176L,198L,223L,251L,282L,318L,357L,402L,452L,509L,572L,644L,724L,815L,917L,1031L,1160L,1305L,1468L,1652L,1858L,2091L,2352L,2646L,2977L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120196Inst : IEnumerable<long>
{
public static readonly long[] Value=A120196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120196.Bytes);
public long this[int i]=>Value[i];

public static A120196Inst Instance=new A120196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120197
{
public static readonly long[] Value={ 4L,4L,5L,6L,6L,7L,8L,9L,10L,11L,13L,14L,16L,18L,20L,23L,26L,29L,33L,37L,41L,46L,52L,59L,66L,74L,84L,94L,106L,119L,134L,151L,170L,191L,215L,242L,272L,306L,344L,387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120197Inst : IEnumerable<long>
{
public static readonly long[] Value=A120197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120197.Bytes);
public long this[int i]=>Value[i];

public static A120197Inst Instance=new A120197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120198
{
public static readonly long[] Value={ 5L,6L,6L,7L,8L,9L,10L,11L,13L,14L,16L,18L,20L,23L,26L,29L,33L,37L,41L,47L,52L,59L,66L,75L,84L,94L,106L,119L,134L,151L,170L,191L,215L,242L,272L,306L,344L,387L,436L,490L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120198Inst : IEnumerable<long>
{
public static readonly long[] Value=A120198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120198.Bytes);
public long this[int i]=>Value[i];

public static A120198Inst Instance=new A120198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120199
{
public static readonly long[] Value={ 6L,7L,8L,9L,10L,11L,13L,14L,16L,18L,20L,23L,26L,29L,32L,36L,41L,46L,52L,58L,66L,74L,83L,93L,105L,118L,133L,150L,168L,189L,213L,240L,270L,303L,341L,384L,432L,486L,547L,615L,692L,778L,876L,985L,1108L,1247L,1403L,1578L,1775L,1997L,2247L,2528L,2844L,3199L,3599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120199Inst : IEnumerable<long>
{
public static readonly long[] Value=A120199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120199.Bytes);
public long this[int i]=>Value[i];

public static A120199Inst Instance=new A120199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120200
{
public static readonly long[] Value={ 7L,8L,9L,10L,12L,13L,15L,17L,19L,21L,24L,27L,30L,34L,38L,43L,48L,54L,61L,69L,77L,87L,98L,110L,124L,139L,157L,176L,198L,223L,251L,282L,317L,357L,402L,452L,508L,572L,643L,724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120200Inst : IEnumerable<long>
{
public static readonly long[] Value=A120200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120200.Bytes);
public long this[int i]=>Value[i];

public static A120200Inst Instance=new A120200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120201
{
public static readonly long[] Value={ 8L,9L,11L,12L,13L,15L,17L,19L,21L,24L,27L,30L,34L,38L,43L,49L,55L,62L,69L,78L,88L,99L,111L,125L,141L,158L,178L,200L,225L,253L,285L,321L,361L,406L,457L,514L,578L,650L,731L,823L,926L,1041L,1172L,1318L,1483L,1668L,1877L,2111L,2375L,2672L,3006L,3382L,3805L,4280L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120201Inst : IEnumerable<long>
{
public static readonly long[] Value=A120201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120201.Bytes);
public long this[int i]=>Value[i];

public static A120201Inst Instance=new A120201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120202
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,2L,2L,2L,2L,3L,3L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,18L,20L,22L,25L,28L,31L,34L,38L,42L,47L,52L,58L,64L,71L,79L,88L,98L,109L,121L,134L,149L,166L,184L,205L,227L,253L,281L,312L,347L,385L,428L,476L,528L,587L,652L,725L,805L,895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120202Inst : IEnumerable<long>
{
public static readonly long[] Value=A120202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120202.Bytes);
public long this[int i]=>Value[i];

public static A120202Inst Instance=new A120202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120203
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,3L,3L,4L,4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,12L,14L,15L,17L,19L,21L,23L,26L,29L,32L,36L,40L,44L,49L,54L,60L,67L,74L,83L,92L,102L,113L,126L,140L,156L,173L,192L,213L,237L,263L,293L,325L,361L,401L,446L,496L,551L,612L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120203Inst : IEnumerable<long>
{
public static readonly long[] Value=A120203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120203.Bytes);
public long this[int i]=>Value[i];

public static A120203Inst Instance=new A120203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120204
{
public static readonly long[] Value={ 3L,3L,3L,4L,4L,5L,5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,15L,17L,18L,20L,23L,25L,28L,31L,35L,38L,43L,47L,53L,59L,65L,72L,80L,89L,99L,110L,122L,136L,151L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120204Inst : IEnumerable<long>
{
public static readonly long[] Value=A120204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120204.Bytes);
public long this[int i]=>Value[i];

public static A120204Inst Instance=new A120204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120205
{
public static readonly long[] Value={ 4L,4L,5L,5L,6L,7L,7L,8L,9L,10L,11L,12L,14L,15L,17L,19L,21L,23L,26L,29L,32L,35L,39L,44L,49L,54L,60L,67L,74L,82L,91L,102L,113L,125L,139L,155L,172L,191L,212L,236L,262L,291L,324L,360L,400L,444L,493L,548L,609L,677L,752L,835L,928L,1031L,1146L,1273L,1415L,1572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120205Inst : IEnumerable<long>
{
public static readonly long[] Value=A120205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120205.Bytes);
public long this[int i]=>Value[i];

public static A120205Inst Instance=new A120205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120206
{
public static readonly long[] Value={ 5L,6L,6L,7L,8L,9L,10L,11L,12L,13L,15L,16L,18L,20L,22L,25L,28L,31L,34L,38L,42L,47L,52L,58L,64L,71L,79L,88L,98L,109L,121L,134L,149L,166L,184L,205L,227L,253L,281L,312L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120206Inst : IEnumerable<long>
{
public static readonly long[] Value=A120206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120206.Bytes);
public long this[int i]=>Value[i];

public static A120206Inst Instance=new A120206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120207
{
public static readonly long[] Value={ 6L,7L,8L,8L,9L,10L,11L,13L,14L,16L,17L,19L,21L,24L,26L,29L,33L,36L,40L,45L,50L,55L,61L,68L,76L,84L,93L,104L,115L,128L,142L,158L,176L,195L,217L,241L,268L,298L,331L,367L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120207Inst : IEnumerable<long>
{
public static readonly long[] Value=A120207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120207.Bytes);
public long this[int i]=>Value[i];

public static A120207Inst Instance=new A120207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120208
{
public static readonly long[] Value={ 7L,8L,9L,10L,11L,12L,14L,15L,17L,19L,21L,23L,26L,29L,32L,35L,39L,44L,48L,54L,60L,66L,74L,82L,91L,101L,112L,125L,139L,154L,171L,190L,211L,235L,261L,290L,322L,358L,398L,442L,491L,546L,606L,674L,749L,832L,924L,1027L,1141L,1268L,1409L,1565L,1739L,1932L,2147L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120208Inst : IEnumerable<long>
{
public static readonly long[] Value=A120208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120208.Bytes);
public long this[int i]=>Value[i];

public static A120208Inst Instance=new A120208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120209
{
public static readonly long[] Value={ 8L,9L,10L,11L,13L,14L,16L,17L,19L,21L,24L,26L,29L,32L,36L,40L,44L,49L,55L,61L,68L,75L,84L,93L,103L,115L,127L,142L,157L,175L,194L,216L,240L,266L,296L,329L,365L,406L,451L,501L,557L,619L,688L,764L,849L,943L,1048L,1164L,1294L,1438L,1597L,1775L,1972L,2191L,2435L,2705L,3006L,3340L,3711L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120209Inst : IEnumerable<long>
{
public static readonly long[] Value=A120209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120209.Bytes);
public long this[int i]=>Value[i];

public static A120209Inst Instance=new A120209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120210
{
public static readonly long[] Value={ 20L,30L,156L,600L,420L,1640L,3660L,520L,2590L,7140L,1224L,10920L,8190L,20880L,32580L,4872L,19998L,5220L,48620L,69960L,3150L,41470L,97656L,132860L,19080L,76830L,176820L,230880L,131070L,12740L,296480L,11100L,375156L,52360L,209950L,468540L,64080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120210Inst : IEnumerable<long>
{
public static readonly long[] Value=A120210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120210.Bytes);
public long this[int i]=>Value[i];

public static A120210Inst Instance=new A120210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120211
{
public static readonly long[] Value={ 4L,6L,12L,24L,15L,40L,60L,40L,70L,84L,72L,56L,126L,144L,180L,168L,198L,180L,220L,264L,126L,286L,312L,364L,360L,390L,420L,480L,510L,49L,544L,300L,612L,616L,646L,684L,720L,760L,288L,798L,840L,924L,726L,966L,700L,1012L,1104L,990L,1150L,1200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120211Inst : IEnumerable<long>
{
public static readonly long[] Value=A120211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120211.Bytes);
public long this[int i]=>Value[i];

public static A120211Inst Instance=new A120211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120212
{
public static readonly long[] Value={ 3L,5L,7L,8L,9L,11L,13L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120212Inst : IEnumerable<long>
{
public static readonly long[] Value=A120212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120212.Bytes);
public long this[int i]=>Value[i];

public static A120212Inst Instance=new A120212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120213
{
public static readonly long[] Value={ 4L,12L,12L,15L,15L,16L,20L,20L,21L,24L,24L,28L,28L,32L,33L,35L,36L,36L,39L,40L,40L,44L,44L,45L,48L,48L,51L,52L,52L,55L,56L,56L,57L,60L,60L,60L,60L,63L,64L,65L,68L,68L,69L,72L,72L,75L,76L,76L,77L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120213Inst : IEnumerable<long>
{
public static readonly long[] Value=A120213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120213.Bytes);
public long this[int i]=>Value[i];

public static A120213Inst Instance=new A120213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120214
{
public static readonly long[] Value={ 1013L,3103L,3015L,5105L,5017L,7107L,7019L,9109L,9021L,1211L,1123L,3213L,3125L,5215L,5127L,7217L,7129L,9219L,9131L,1321L,1233L,3323L,3235L,5325L,5237L,7327L,7239L,9329L,9241L,1431L,1343L,3433L,3345L,5435L,5347L,7437L,7349L,9439L,9351L,1541L,1453L,3543L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120214Inst : IEnumerable<long>
{
public static readonly long[] Value=A120214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120214.Bytes);
public long this[int i]=>Value[i];

public static A120214Inst Instance=new A120214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120215
{
public static readonly long[] Value={ 1057L,7503L,3059L,9505L,5061L,1607L,7063L,3609L,9065L,5611L,1167L,7613L,3169L,9615L,5171L,1717L,7173L,3719L,9175L,5721L,1277L,7723L,3279L,9725L,5281L,1827L,7283L,3829L,9285L,5831L,1387L,7833L,3389L,9835L,5391L,1937L,7393L,3939L,9395L,5941L,1497L,7943L,3499L,9945L,5501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120215Inst : IEnumerable<long>
{
public static readonly long[] Value=A120215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120215.Bytes);
public long this[int i]=>Value[i];

public static A120215Inst Instance=new A120215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120216
{
public static readonly long[] Value={ 100013L,310003L,300015L,510005L,500017L,710007L,700019L,910009L,900021L,120011L,110023L,320013L,310025L,520015L,510027L,720017L,710029L,920019L,910031L,130021L,120033L,330023L,320035L,530025L,520037L,730027L,720039L,930029L,920041L,140031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120216Inst : IEnumerable<long>
{
public static readonly long[] Value=A120216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120216.Bytes);
public long this[int i]=>Value[i];

public static A120216Inst Instance=new A120216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120217
{
public static readonly long[] Value={ 100057L,750003L,300059L,950005L,500061L,160007L,700063L,360009L,900065L,560011L,110067L,760013L,310069L,960015L,510071L,170017L,710073L,370019L,910075L,570021L,120077L,770023L,320079L,970025L,520081L,180027L,720083L,380029L,920085L,580031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120217Inst : IEnumerable<long>
{
public static readonly long[] Value=A120217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120217.Bytes);
public long this[int i]=>Value[i];

public static A120217Inst Instance=new A120217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120218
{
public static readonly long[] Value={ 100103L,301003L,300105L,501005L,500107L,701007L,700109L,901009L,900111L,111011L,110113L,311013L,310115L,511015L,510117L,711017L,710119L,911019L,910121L,121021L,120123L,321023L,320125L,521025L,520127L,721027L,720129L,921029L,920131L,131031L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120218Inst : IEnumerable<long>
{
public static readonly long[] Value=A120218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120218.Bytes);
public long this[int i]=>Value[i];

public static A120218Inst Instance=new A120218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120219
{
public static readonly long[] Value={ 8L,2L,6L,7L,3L,2L,3L,1L,4L,4L,4L,9L,4L,2L,1L,1L,5L,3L,6L,4L,6L,7L,5L,6L,5L,7L,3L,8L,4L,2L,5L,8L,7L,3L,2L,4L,6L,3L,7L,5L,3L,7L,0L,6L,0L,4L,5L,4L,4L,7L,3L,0L,1L,4L,6L,9L,6L,7L,0L,8L,8L,7L,3L,2L,8L,4L,4L,3L,6L,2L,2L,2L,2L,6L,3L,5L,1L,9L,1L,8L,8L,9L,7L,2L,1L,3L,5L,0L,1L,8L,9L,8L,3L,8L,5L,0L,2L,7L,9L,2L,3L,7L,4L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120219Inst : IEnumerable<long>
{
public static readonly long[] Value=A120219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120219.Bytes);
public long this[int i]=>Value[i];

public static A120219Inst Instance=new A120219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120220
{
public static readonly long[] Value={ 5L,5L,7L,8L,5L,8L,6L,5L,3L,7L,6L,7L,9L,5L,6L,6L,6L,3L,5L,7L,7L,2L,5L,9L,6L,6L,1L,1L,2L,5L,3L,6L,8L,8L,9L,7L,5L,4L,8L,5L,2L,2L,3L,9L,6L,8L,9L,0L,1L,8L,7L,7L,5L,7L,0L,2L,0L,2L,6L,0L,2L,5L,2L,4L,4L,6L,8L,1L,6L,6L,3L,1L,7L,0L,5L,1L,6L,4L,2L,9L,1L,5L,5L,5L,0L,2L,2L,5L,7L,4L,1L,9L,3L,4L,7L,9L,3L,3L,8L,1L,4L,0L,2L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120220Inst : IEnumerable<long>
{
public static readonly long[] Value=A120220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120220.Bytes);
public long this[int i]=>Value[i];

public static A120220Inst Instance=new A120220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120221
{
public static readonly long[] Value={ 0L,1L,1L,2L,1L,1L,1L,3L,2L,3L,1L,2L,4L,1L,1L,2L,3L,1L,2L,5L,1L,3L,2L,3L,1L,3L,1L,2L,3L,2L,1L,4L,1L,4L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,5L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,3L,1L,2L,2L,5L,1L,1L,2L,2L,2L,1L,3L,2L,1L,3L,4L,2L,1L,3L,1L,3L,1L,1L,1L,2L,2L,2L,1L,2L,1L,5L,3L,3L,1L,1L,1L,1L,1L,1L,1L,3L,2L,1L,2L,1L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120221Inst : IEnumerable<long>
{
public static readonly long[] Value=A120221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120221.Bytes);
public long this[int i]=>Value[i];

public static A120221Inst Instance=new A120221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120222
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,17L,23L,25L,35L,37L,47L,55L,61L,73L,77L,83L,91L,95L,101L,103L,107L,121L,125L,131L,143L,151L,161L,173L,175L,187L,205L,217L,221L,233L,245L,257L,263L,271L,277L,287L,305L,311L,325L,331L,347L,367L,373L,391L,395L,425L,443L,451L,455L,461L,481L,503L,551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120222Inst : IEnumerable<long>
{
public static readonly long[] Value=A120222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120222.Bytes);
public long this[int i]=>Value[i];

public static A120222Inst Instance=new A120222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120223
{
public static readonly long[] Value={ 2L,3L,2L,3L,2L,5L,4L,5L,2L,3L,2L,5L,4L,3L,2L,7L,6L,11L,10L,3L,2L,9L,6L,13L,4L,3L,4L,15L,2L,7L,10L,11L,10L,3L,2L,5L,4L,5L,2L,7L,2L,5L,4L,9L,14L,13L,6L,5L,4L,3L,2L,21L,14L,5L,6L,5L,4L,9L,12L,7L,6L,5L,10L,3L,2L,5L,4L,15L,2L,3L,8L,25L,6L,27L,8L,3L,6L,11L,4L,3L,2L,15L,6L,5L,12L,11L,20L,15L,12L,7L,6L,5L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120223Inst : IEnumerable<long>
{
public static readonly long[] Value=A120223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120223.Bytes);
public long this[int i]=>Value[i];

public static A120223Inst Instance=new A120223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120224
{
public static readonly long[] Value={ 1L,3L,4L,7L,6L,7L,10L,9L,14L,13L,18L,19L,24L,15L,16L,21L,24L,29L,22L,21L,22L,31L,30L,43L,28L,33L,34L,39L,32L,41L,36L,39L,34L,37L,66L,43L,60L,41L,50L,43L,42L,55L,46L,53L,52L,51L,50L,59L,52L,51L,56L,55L,56L,55L,58L,75L,74L,69L,68L,67L,66L,75L,74L,67L,86L,83L,70L,89L,70L,79L,102L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120224Inst : IEnumerable<long>
{
public static readonly long[] Value=A120224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120224.Bytes);
public long this[int i]=>Value[i];

public static A120224Inst Instance=new A120224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120225
{
public static readonly long[] Value={ 2L,3L,4L,7L,6L,7L,10L,9L,14L,13L,18L,19L,24L,15L,16L,21L,24L,29L,22L,21L,22L,31L,30L,43L,28L,33L,34L,39L,32L,41L,36L,39L,34L,37L,66L,43L,60L,41L,50L,43L,42L,55L,46L,53L,52L,51L,50L,59L,52L,51L,56L,55L,56L,55L,58L,75L,74L,69L,68L,67L,66L,75L,74L,67L,86L,83L,70L,89L,70L,79L,102L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120225Inst : IEnumerable<long>
{
public static readonly long[] Value=A120225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120225.Bytes);
public long this[int i]=>Value[i];

public static A120225Inst Instance=new A120225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120226
{
public static readonly long[] Value={ 1L,3L,7L,9L,13L,15L,25L,27L,37L,39L,43L,49L,57L,67L,69L,79L,93L,97L,99L,105L,127L,135L,153L,163L,169L,175L,177L,189L,193L,207L,219L,235L,253L,265L,267L,273L,277L,279L,303L,307L,309L,343L,345L,363L,405L,417L,427L,435L,475L,483L,487L,499L,517L,553L,559L,567L,573L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120226Inst : IEnumerable<long>
{
public static readonly long[] Value=A120226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120226.Bytes);
public long this[int i]=>Value[i];

public static A120226Inst Instance=new A120226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120227
{
public static readonly long[] Value={ 2L,6L,8L,12L,14L,26L,36L,38L,42L,48L,54L,56L,62L,66L,84L,92L,98L,104L,108L,126L,132L,152L,162L,176L,188L,194L,206L,218L,234L,236L,246L,258L,264L,272L,276L,302L,306L,344L,348L,362L,374L,416L,426L,428L,444L,456L,462L,474L,482L,504L,518L,542L,558L,572L,594L,602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120227Inst : IEnumerable<long>
{
public static readonly long[] Value=A120227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120227.Bytes);
public long this[int i]=>Value[i];

public static A120227Inst Instance=new A120227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120228
{
public static readonly long[] Value={ 5L,9L,11L,29L,35L,39L,51L,65L,71L,75L,95L,101L,119L,129L,131L,141L,149L,165L,185L,215L,219L,225L,249L,261L,269L,285L,299L,305L,309L,329L,339L,341L,371L,375L,381L,401L,431L,441L,449L,459L,471L,479L,491L,555L,591L,599L,611L,635L,639L,651L,711L,725L,731L,735L,761L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120228Inst : IEnumerable<long>
{
public static readonly long[] Value=A120228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120228.Bytes);
public long this[int i]=>Value[i];

public static A120228Inst Instance=new A120228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120229
{
public static readonly long[] Value={ 3L,6L,1L,12L,15L,2L,21L,24L,27L,30L,33L,4L,39L,42L,5L,48L,51L,54L,57L,60L,7L,66L,69L,8L,75L,78L,9L,84L,87L,10L,93L,96L,11L,102L,105L,108L,111L,114L,13L,120L,123L,14L,129L,132L,135L,138L,141L,16L,147L,150L,17L,156L,159L,18L,165L,168L,19L,174L,177L,20L,183L,186L,189L,192L,195L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120229Inst : IEnumerable<long>
{
public static readonly long[] Value=A120229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120229.Bytes);
public long this[int i]=>Value[i];

public static A120229Inst Instance=new A120229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120230
{
public static readonly long[] Value={ 4L,8L,12L,1L,20L,24L,28L,2L,36L,40L,44L,3L,52L,56L,60L,64L,68L,72L,76L,5L,84L,88L,92L,6L,100L,104L,108L,7L,116L,120L,124L,128L,132L,136L,140L,9L,148L,152L,156L,10L,164L,168L,172L,11L,180L,184L,188L,192L,196L,200L,204L,13L,212L,216L,220L,14L,228L,232L,236L,15L,244L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120230Inst : IEnumerable<long>
{
public static readonly long[] Value=A120230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120230.Bytes);
public long this[int i]=>Value[i];

public static A120230Inst Instance=new A120230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120231
{
public static readonly long[] Value={ 1L,3L,2L,6L,7L,4L,10L,5L,13L,15L,16L,8L,19L,9L,22L,24L,11L,12L,28L,30L,14L,33L,34L,36L,37L,17L,18L,42L,43L,20L,46L,21L,49L,51L,23L,54L,55L,25L,26L,60L,27L,63L,64L,29L,67L,69L,31L,32L,73L,75L,76L,78L,35L,81L,82L,84L,38L,87L,39L,40L,91L,41L,94L,96L,97L,44L,100L,45L,103L,105L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120231Inst : IEnumerable<long>
{
public static readonly long[] Value=A120231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120231.Bytes);
public long this[int i]=>Value[i];

public static A120231Inst Instance=new A120231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120232
{
public static readonly long[] Value={ 1L,3L,2L,6L,8L,4L,5L,12L,14L,7L,17L,18L,9L,21L,10L,11L,26L,27L,13L,30L,32L,15L,35L,16L,38L,39L,41L,19L,44L,20L,47L,48L,22L,23L,53L,24L,25L,57L,59L,60L,62L,28L,29L,66L,68L,31L,71L,72L,33L,75L,34L,78L,80L,36L,37L,84L,86L,87L,89L,40L,92L,93L,42L,43L,98L,99L,45L,102L,46L,105L,107L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120232Inst : IEnumerable<long>
{
public static readonly long[] Value=A120232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120232.Bytes);
public long this[int i]=>Value[i];

public static A120232Inst Instance=new A120232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120233
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,8L,5L,10L,12L,7L,14L,9L,17L,18L,11L,21L,22L,13L,25L,15L,28L,16L,30L,32L,33L,19L,20L,37L,38L,40L,23L,24L,44L,45L,26L,27L,49L,50L,29L,53L,54L,31L,57L,58L,60L,34L,35L,36L,65L,66L,68L,39L,70L,72L,41L,42L,76L,43L,78L,80L,81L,46L,47L,48L,86L,88L,89L,51L,92L,52L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120233Inst : IEnumerable<long>
{
public static readonly long[] Value=A120233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120233.Bytes);
public long this[int i]=>Value[i];

public static A120233Inst Instance=new A120233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120234
{
public static readonly long[] Value={ 1L,2L,4L,3L,7L,5L,10L,6L,12L,8L,15L,9L,18L,11L,20L,22L,13L,14L,26L,27L,16L,17L,31L,32L,19L,35L,36L,21L,39L,23L,42L,24L,25L,46L,47L,48L,28L,29L,52L,30L,55L,56L,58L,33L,34L,62L,63L,64L,37L,38L,68L,70L,40L,41L,74L,75L,43L,44L,79L,45L,82L,83L,84L,86L,49L,50L,90L,51L,92L,53L,95L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120234Inst : IEnumerable<long>
{
public static readonly long[] Value=A120234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120234.Bytes);
public long this[int i]=>Value[i];

public static A120234Inst Instance=new A120234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120235
{
public static readonly long[] Value={ 2L,5L,1L,10L,12L,15L,17L,3L,22L,4L,27L,30L,32L,35L,6L,40L,42L,7L,47L,8L,52L,55L,9L,60L,62L,65L,67L,11L,72L,75L,77L,80L,13L,85L,14L,90L,92L,95L,97L,16L,102L,105L,107L,110L,18L,115L,117L,19L,122L,20L,127L,130L,21L,135L,140L,142L,23L,147L,24L,152L,155L,25L,160L,26L,165L,167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120235Inst : IEnumerable<long>
{
public static readonly long[] Value=A120235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120235.Bytes);
public long this[int i]=>Value[i];

public static A120235Inst Instance=new A120235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120236
{
public static readonly long[] Value={ 3L,1L,8L,10L,2L,15L,18L,20L,23L,4L,28L,5L,33L,35L,6L,40L,7L,45L,48L,50L,53L,9L,58L,60L,63L,65L,11L,70L,73L,12L,78L,13L,83L,85L,14L,90L,93L,95L,98L,16L,103L,17L,108L,110L,113L,115L,19L,120L,123L,125L,128L,21L,133L,135L,22L,140L,143L,145L,148L,24L,153L,25L,138L,160L,26L,165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120236Inst : IEnumerable<long>
{
public static readonly long[] Value=A120236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120236.Bytes);
public long this[int i]=>Value[i];

public static A120236Inst Instance=new A120236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120237
{
public static readonly long[] Value={ 1L,2L,4L,5L,3L,8L,9L,11L,6L,7L,15L,16L,18L,19L,10L,22L,12L,25L,13L,14L,29L,31L,32L,33L,17L,36L,38L,39L,20L,21L,43L,45L,23L,24L,49L,50L,26L,53L,27L,28L,57L,59L,30L,62L,63L,65L,66L,67L,34L,35L,72L,73L,37L,76L,77L,79L,40L,41L,83L,42L,86L,87L,44L,90L,91L,46L,47L,48L,97L,98L,100L,101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120237Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120237.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120237Inst : IEnumerable<long>
{
public static readonly long[] Value=A120237.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120237.Bytes);
public long this[int i]=>Value[i];

public static A120237Inst Instance=new A120237Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120238
{
public static readonly long[] Value={ 1L,2L,5L,3L,4L,9L,10L,6L,7L,15L,8L,17L,19L,20L,11L,12L,25L,13L,14L,29L,30L,16L,33L,34L,18L,37L,39L,40L,21L,43L,22L,23L,24L,49L,50L,26L,53L,27L,28L,57L,58L,60L,31L,63L,32L,66L,67L,68L,35L,36L,73L,74L,38L,77L,78L,80L,41L,83L,42L,85L,87L,44L,45L,91L,46L,47L,48L,97L,98L,99L,101L,51L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120238Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120238.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120238Inst : IEnumerable<long>
{
public static readonly long[] Value=A120238.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120238.Bytes);
public long this[int i]=>Value[i];

public static A120238Inst Instance=new A120238Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120239
{
public static readonly long[] Value={ 1L,3L,4L,2L,8L,9L,11L,12L,5L,6L,17L,7L,21L,22L,24L,25L,10L,29L,30L,32L,33L,13L,14L,38L,15L,16L,43L,45L,46L,18L,19L,51L,20L,55L,56L,58L,59L,23L,63L,64L,66L,67L,26L,27L,72L,28L,76L,77L,79L,80L,31L,84L,85L,87L,88L,34L,35L,93L,36L,37L,98L,100L,101L,39L,40L,106L,41L,42L,111L,113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120239Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120239.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120239Inst : IEnumerable<long>
{
public static readonly long[] Value=A120239.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120239.Bytes);
public long this[int i]=>Value[i];

public static A120239Inst Instance=new A120239Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A120240
{
public static readonly long[] Value={ 1L,4L,2L,3L,9L,10L,12L,5L,6L,17L,7L,8L,22L,23L,25L,26L,11L,30L,31L,33L,13L,14L,38L,15L,16L,43L,44L,46L,18L,19L,51L,20L,21L,56L,57L,59L,60L,24L,64L,65L,67L,68L,27L,72L,28L,29L,77L,78L,80L,81L,32L,85L,86L,88L,34L,35L,93L,36L,37L,98L,99L,101L,39L,40L,106L,41L,42L,111L,112L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A120240Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A120240.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A120240Inst : IEnumerable<long>
{
public static readonly long[] Value=A120240.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A120240.Bytes);
public long this[int i]=>Value[i];

public static A120240Inst Instance=new A120240Inst();

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