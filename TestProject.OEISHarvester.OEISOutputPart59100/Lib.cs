using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A066645
{
public static readonly long[] Value={ 0L,4L,33L,113L,268L,523L,904L,1436L,2144L,3053L,4188L,5575L,7238L,9202L,11494L,14137L,17157L,20579L,24429L,28730L,33510L,38792L,44602L,50965L,57905L,65449L,73622L,82447L,91952L,102160L,113097L,124788L,137258L,150532L,164636L,179594L,195432L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066645Inst : IEnumerable<long>
{
public static readonly long[] Value=A066645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066645.Bytes);
public long this[int i]=>Value[i];

public static A066645Inst Instance=new A066645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066646
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,8L,15L,17L,22L,24L,25L,26L,27L,30L,55L,56L,61L,68L,81L,83L,87L,95L,106L,108L,112L,120L,121L,122L,123L,126L,127L,128L,135L,137L,142L,144L,265L,266L,267L,270L,289L,290L,315L,317L,340L,342L,391L,392L,397L,404L,415L,416L,445L,451L,470L,476L,513L,515L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066646Inst : IEnumerable<long>
{
public static readonly long[] Value=A066646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066646.Bytes);
public long this[int i]=>Value[i];

public static A066646Inst Instance=new A066646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066647
{
public static readonly long[] Value={ 9L,36L,100L,196L,225L,289L,441L,576L,784L,841L,1225L,1296L,1764L,1849L,2025L,2304L,3025L,3249L,3600L,3844L,3969L,4356L,5776L,6084L,6400L,6561L,8100L,8281L,9801L,11025L,12544L,13924L,14161L,14400L,15129L,16129L,16641L,17424L,18496L,19600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066647Inst : IEnumerable<long>
{
public static readonly long[] Value=A066647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066647.Bytes);
public long this[int i]=>Value[i];

public static A066647Inst Instance=new A066647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066648
{
public static readonly long[] Value={ 512L,1000L,2744L,21952L,32768L,35937L,64000L,175616L,185193L,274625L,357911L,373248L,405224L,474552L,729000L,1157625L,1404928L,1481544L,2000376L,2097152L,2197000L,2299968L,2744000L,3241792L,3652264L,3723875L,4096000L,5451776L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066648Inst : IEnumerable<long>
{
public static readonly long[] Value=A066648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066648.Bytes);
public long this[int i]=>Value[i];

public static A066648Inst Instance=new A066648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066649
{
public static readonly long[] Value={ 2L,5L,17L,31L,37L,43L,73L,89L,101L,113L,127L,197L,223L,233L,241L,257L,269L,283L,337L,347L,353L,359L,379L,401L,443L,449L,487L,521L,577L,593L,599L,677L,701L,733L,743L,811L,827L,829L,919L,953L,1009L,1019L,1049L,1051L,1097L,1129L,1153L,1213L,1289L,1297L,1361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066649Inst : IEnumerable<long>
{
public static readonly long[] Value=A066649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066649.Bytes);
public long this[int i]=>Value[i];

public static A066649Inst Instance=new A066649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066650
{
public static readonly long[] Value={ 1L,3L,4L,6L,7L,8L,11L,13L,14L,15L,16L,18L,19L,20L,21L,22L,23L,25L,27L,29L,30L,32L,34L,35L,38L,39L,40L,41L,42L,45L,46L,47L,48L,49L,51L,53L,54L,55L,56L,58L,59L,60L,61L,62L,64L,66L,67L,69L,70L,71L,74L,75L,77L,78L,79L,81L,83L,84L,85L,86L,87L,88L,90L,92L,93L,94L,95L,96L,97L,98L,99L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066650Inst : IEnumerable<long>
{
public static readonly long[] Value=A066650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066650.Bytes);
public long this[int i]=>Value[i];

public static A066650Inst Instance=new A066650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066651
{
public static readonly long[] Value={ 3L,5L,7L,11L,13L,23L,29L,31L,43L,47L,53L,59L,61L,67L,71L,79L,83L,103L,107L,131L,139L,149L,157L,167L,173L,179L,191L,211L,223L,227L,229L,239L,263L,269L,277L,283L,293L,311L,317L,331L,347L,349L,359L,367L,373L,383L,389L,419L,421L,431L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066651Inst : IEnumerable<long>
{
public static readonly long[] Value=A066651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066651.Bytes);
public long this[int i]=>Value[i];

public static A066651Inst Instance=new A066651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066652
{
public static readonly long[] Value={ 3L,5L,11L,13L,19L,29L,37L,41L,43L,59L,61L,67L,73L,83L,101L,109L,113L,131L,137L,139L,157L,163L,173L,181L,193L,211L,227L,229L,257L,277L,281L,283L,307L,313L,317L,331L,347L,353L,373L,379L,389L,397L,401L,409L,419L,421L,433L,443L,457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066652Inst : IEnumerable<long>
{
public static readonly long[] Value=A066652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066652.Bytes);
public long this[int i]=>Value[i];

public static A066652Inst Instance=new A066652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066653
{
public static readonly long[] Value={ 2L,3L,6L,15L,21L,30L,51L,69L,114L,141L,174L,210L,231L,285L,309L,321L,330L,411L,429L,510L,546L,615L,645L,651L,714L,741L,834L,849L,861L,894L,939L,966L,1041L,1065L,1119L,1155L,1191L,1329L,1365L,1401L,1626L,1686L,1695L,1731L,1770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066653Inst : IEnumerable<long>
{
public static readonly long[] Value=A066653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066653.Bytes);
public long this[int i]=>Value[i];

public static A066653Inst Instance=new A066653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066654
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,6L,5L,1L,2L,2L,1L,12L,1L,2L,12L,1L,6L,5L,2L,36L,4L,1L,1L,2L,1L,2L,4L,14L,4L,6L,2L,1L,12L,2L,3L,5L,28L,1L,2L,3L,3L,1L,2L,1L,24L,1L,29L,6L,1L,11L,1L,1L,2L,9L,3L,5L,5L,4L,3L,1L,5L,3L,1L,1L,1L,1L,3L,15L,4L,10L,1L,7L,1L,1L,5L,1L,6L,5L,2L,1L,1L,8L,1L,2L,1L,1L,13L,22L,1L,2L,2L,1L,2L,1L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066654Inst : IEnumerable<long>
{
public static readonly long[] Value=A066654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066654.Bytes);
public long this[int i]=>Value[i];

public static A066654Inst Instance=new A066654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066655
{
public static readonly long[] Value={ 1L,1L,3L,11L,42L,176L,792L,3718L,17977L,89134L,451276L,2323520L,12132164L,64112359L,342325709L,1844349560L,10015581680L,54770336324L,301384802048L,1667727404093L,9275102575355L,51820051838712L,290726957916112L,1637293969337171L,9253082936723602L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066655Inst : IEnumerable<long>
{
public static readonly long[] Value=A066655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066655.Bytes);
public long this[int i]=>Value[i];

public static A066655Inst Instance=new A066655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066656
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,2L,5L,2L,6L,4L,9L,2L,17L,2L,21L,10L,36L,2L,70L,2L,111L,22L,189L,2L,382L,8L,633L,60L,1185L,2L,2301L,2L,4116L,190L,7713L,26L,14940L,2L,27597L,634L,52518L,2L,101051L,2L,190749L,2248L,364725L,2L,703332L,20L,1342284L,7714L,2581431L,2L,4985610L,194L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066656Inst : IEnumerable<long>
{
public static readonly long[] Value=A066656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066656.Bytes);
public long this[int i]=>Value[i];

public static A066656Inst Instance=new A066656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066657
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,2L,3L,1L,2L,3L,5L,1L,1L,3L,5L,7L,1L,2L,3L,5L,7L,8L,1L,2L,3L,5L,7L,8L,11L,1L,2L,3L,5L,7L,8L,11L,13L,1L,1L,1L,5L,7L,4L,11L,13L,17L,1L,2L,3L,5L,7L,8L,11L,13L,17L,18L,1L,2L,3L,5L,7L,8L,11L,13L,17L,18L,19L,1L,2L,3L,5L,7L,8L,11L,13L,17L,18L,19L,23L,1L,2L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066657Inst : IEnumerable<long>
{
public static readonly long[] Value=A066657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066657.Bytes);
public long this[int i]=>Value[i];

public static A066657Inst Instance=new A066657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066658
{
public static readonly long[] Value={ 1L,2L,3L,3L,5L,5L,5L,7L,7L,7L,7L,8L,4L,8L,8L,8L,11L,11L,11L,11L,11L,11L,13L,13L,13L,13L,13L,13L,13L,17L,17L,17L,17L,17L,17L,17L,17L,18L,9L,6L,18L,18L,9L,18L,18L,18L,19L,19L,19L,19L,19L,19L,19L,19L,19L,19L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,23L,29L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066658Inst : IEnumerable<long>
{
public static readonly long[] Value=A066658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066658.Bytes);
public long this[int i]=>Value[i];

public static A066658Inst Instance=new A066658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066659
{
public static readonly long[] Value={ 2L,0L,4L,6L,8L,0L,9L,10L,14L,12L,22L,0L,21L,18L,16L,20L,32L,0L,27L,24L,26L,0L,46L,30L,33L,28L,38L,36L,58L,0L,62L,34L,44L,40L,39L,42L,57L,54L,45L,48L,55L,0L,49L,50L,52L,0L,94L,60L,86L,66L,64L,56L,106L,0L,75L,70L,63L,0L,118L,0L,77L,0L,74L,68L,104L,0L,134L,80L,92L,72L,142L,78L,91L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066659Inst : IEnumerable<long>
{
public static readonly long[] Value=A066659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066659.Bytes);
public long this[int i]=>Value[i];

public static A066659Inst Instance=new A066659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066660
{
public static readonly long[] Value={ 1L,2L,3L,3L,3L,5L,3L,4L,5L,5L,3L,7L,3L,5L,7L,5L,3L,8L,3L,7L,7L,5L,3L,9L,5L,5L,7L,7L,3L,11L,3L,6L,7L,5L,7L,11L,3L,5L,7L,9L,3L,11L,3L,7L,11L,5L,3L,11L,5L,8L,7L,7L,3L,11L,7L,9L,7L,5L,3L,15L,3L,5L,11L,7L,7L,11L,3L,7L,7L,11L,3L,14L,3L,5L,11L,7L,7L,11L,3L,11L,9L,5L,3L,15L,7L,5L,7L,9L,3L,17L,7L,7L,7L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066660Inst : IEnumerable<long>
{
public static readonly long[] Value=A066660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066660.Bytes);
public long this[int i]=>Value[i];

public static A066660Inst Instance=new A066660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066661
{
public static readonly long[] Value={ 2L,3L,4L,5L,7L,13L,20L,27L,31L,34L,36L,38L,48L,65L,70L,73L,76L,79L,95L,104L,112L,117L,125L,126L,144L,145L,153L,154L,159L,164L,179L,182L,185L,190L,195L,202L,204L,216L,218L,225L,235L,253L,269L,279L,285L,291L,292L,300L,313L,314L,315L,340L,341L,342L,355L,356L,365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066661Inst : IEnumerable<long>
{
public static readonly long[] Value=A066661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066661.Bytes);
public long this[int i]=>Value[i];

public static A066661Inst Instance=new A066661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066662
{
public static readonly long[] Value={ 3L,6L,9L,12L,7L,18L,21L,24L,27L,14L,33L,36L,16L,42L,21L,48L,13L,54L,57L,28L,63L,66L,69L,72L,35L,32L,81L,84L,17L,42L,93L,96L,99L,26L,49L,108L,57L,114L,48L,56L,45L,126L,129L,132L,63L,138L,141L,144L,147L,70L,39L,64L,23L,162L,77L,168L,171L,34L,177L,84L,55L,186L,189L,192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066662Inst : IEnumerable<long>
{
public static readonly long[] Value=A066662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066662.Bytes);
public long this[int i]=>Value[i];

public static A066662Inst Instance=new A066662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066663
{
public static readonly long[] Value={ 1320L,1640L,1768L,1996L,2640L,3960L,13200L,16400L,19984L,19996L,26400L,39600L,132000L,164000L,199996L,264000L,396000L,1320000L,1640000L,1999936L,2640000L,3960000L,13200000L,16400000L,16666240L,17999488L,18515584L,19999984L,19999996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066663Inst : IEnumerable<long>
{
public static readonly long[] Value=A066663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066663.Bytes);
public long this[int i]=>Value[i];

public static A066663Inst Instance=new A066663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066664
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,18L,22L,24L,26L,34L,38L,46L,58L,60L,62L,74L,82L,86L,94L,106L,118L,122L,134L,142L,146L,158L,166L,178L,194L,202L,206L,214L,218L,226L,254L,262L,274L,278L,298L,302L,314L,326L,334L,346L,358L,362L,382L,386L,394L,398L,422L,446L,454L,458L,466L,478L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066664Inst : IEnumerable<long>
{
public static readonly long[] Value=A066664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066664.Bytes);
public long this[int i]=>Value[i];

public static A066664Inst Instance=new A066664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066665
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,14L,16L,19L,23L,27L,31L,35L,38L,42L,47L,52L,56L,61L,65L,70L,76L,82L,88L,94L,100L,107L,114L,121L,128L,136L,143L,150L,158L,166L,175L,185L,194L,203L,213L,223L,233L,243L,252L,262L,272L,282L,291L,301L,311L,322L,334L,346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066665Inst : IEnumerable<long>
{
public static readonly long[] Value=A066665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066665.Bytes);
public long this[int i]=>Value[i];

public static A066665Inst Instance=new A066665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066666
{
public static readonly long[] Value={ 9L,8L,7L,7L,0L,0L,3L,9L,0L,7L,3L,6L,0L,5L,3L,4L,6L,0L,1L,3L,1L,9L,9L,9L,9L,1L,3L,5L,5L,8L,3L,2L,8L,5L,4L,7L,9L,1L,8L,4L,7L,2L,0L,7L,4L,1L,8L,3L,2L,7L,8L,8L,9L,2L,9L,4L,0L,7L,7L,1L,3L,9L,0L,9L,5L,5L,1L,6L,8L,7L,6L,8L,1L,9L,8L,6L,3L,4L,9L,0L,7L,2L,6L,6L,9L,6L,4L,8L,4L,4L,4L,0L,4L,8L,4L,9L,9L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066666Inst : IEnumerable<long>
{
public static readonly long[] Value=A066666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066666.Bytes);
public long this[int i]=>Value[i];

public static A066666Inst Instance=new A066666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066667
{
public static readonly long[] Value={ 1L,2L,-1L,6L,-6L,1L,24L,-36L,12L,-1L,120L,-240L,120L,-20L,1L,720L,-1800L,1200L,-300L,30L,-1L,5040L,-15120L,12600L,-4200L,630L,-42L,1L,40320L,-141120L,141120L,-58800L,11760L,-1176L,56L,-1L,362880L,-1451520L,1693440L,-846720L,211680L,-28224L,2016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066667Inst : IEnumerable<long>
{
public static readonly long[] Value=A066667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066667.Bytes);
public long this[int i]=>Value[i];

public static A066667Inst Instance=new A066667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066668
{
public static readonly BigInteger[] Value={ 1L,1L,1L,-1L,-19L,-151L,-1091L,-7841L,-56519L,-396271L,-2442439L,-7701409L,145269541L,4833158329L,104056218421L,2002667085119L,37109187217649L,679877731030049L,12440309297451121L,227773259993414719L,4155839606711748061L,BigInteger.Parse("74724654677947488521"),BigInteger.Parse("1293162252850914402221") };
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
public class A066668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066668Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066668.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066668.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066668Inst Instance=new A066668Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066669
{
public static readonly long[] Value={ 7L,9L,11L,13L,14L,18L,21L,22L,23L,25L,26L,28L,29L,33L,35L,36L,39L,41L,42L,44L,45L,46L,47L,50L,52L,53L,55L,56L,58L,59L,65L,66L,69L,70L,72L,75L,78L,82L,83L,84L,87L,88L,89L,90L,92L,94L,97L,100L,104L,105L,106L,107L,110L,112L,113L,115L,116L,118L,119L,123L,130L,132L,137L,138L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066669Inst : IEnumerable<long>
{
public static readonly long[] Value=A066669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066669.Bytes);
public long this[int i]=>Value[i];

public static A066669Inst Instance=new A066669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066670
{
public static readonly long[] Value={ 3L,3L,5L,3L,3L,3L,3L,5L,11L,5L,3L,3L,7L,5L,3L,3L,3L,5L,3L,5L,3L,11L,23L,5L,3L,13L,5L,3L,7L,29L,3L,5L,11L,3L,3L,5L,3L,5L,41L,3L,7L,5L,11L,3L,11L,23L,3L,5L,3L,3L,13L,53L,5L,3L,7L,11L,7L,29L,3L,5L,3L,5L,17L,11L,3L,23L,3L,7L,37L,5L,3L,3L,13L,5L,5L,41L,83L,3L,43L,7L,5L,29L,11L,89L,3L,11L,5L,23L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066670Inst : IEnumerable<long>
{
public static readonly long[] Value=A066670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066670.Bytes);
public long this[int i]=>Value[i];

public static A066670Inst Instance=new A066670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066671
{
public static readonly long[] Value={ 2L,2L,2L,4L,2L,2L,4L,2L,2L,4L,4L,4L,4L,4L,8L,4L,8L,8L,4L,4L,8L,2L,2L,4L,8L,4L,8L,8L,4L,2L,16L,4L,4L,8L,8L,8L,8L,8L,2L,8L,8L,8L,8L,8L,4L,2L,32L,8L,16L,16L,4L,2L,8L,16L,16L,8L,8L,2L,32L,16L,16L,8L,8L,4L,16L,4L,16L,16L,4L,8L,32L,16L,8L,16L,16L,2L,2L,16L,4L,8L,16L,4L,8L,2L,16L,8L,32L,4L,64L,32L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066671Inst : IEnumerable<long>
{
public static readonly long[] Value=A066671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066671.Bytes);
public long this[int i]=>Value[i];

public static A066671Inst Instance=new A066671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066672
{
public static readonly long[] Value={ 1L,1L,1L,2L,1L,1L,2L,1L,1L,2L,2L,2L,2L,2L,3L,2L,3L,3L,2L,2L,3L,1L,1L,2L,3L,2L,3L,3L,2L,1L,4L,2L,2L,3L,3L,3L,3L,3L,1L,3L,3L,3L,3L,3L,2L,1L,5L,3L,4L,4L,2L,1L,3L,4L,4L,3L,3L,1L,5L,4L,4L,3L,3L,2L,4L,2L,4L,4L,2L,3L,5L,4L,3L,4L,4L,1L,1L,4L,2L,3L,4L,2L,3L,1L,4L,3L,5L,2L,6L,5L,5L,4L,5L,5L,4L,3L,1L,4L,6L,5L,4L,1L,3L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066672Inst : IEnumerable<long>
{
public static readonly long[] Value=A066672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066672.Bytes);
public long this[int i]=>Value[i];

public static A066672Inst Instance=new A066672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066673
{
public static readonly long[] Value={ 7L,13L,35L,65L,97L,193L,485L,769L,1649L,3281L,8245L,12289L,24929L,49601L,124645L,197633L,423793L,786433L,2118965L,3158273L,6357089L,12648641L,31785445L,50397953L,108070513L,202113281L,540352565L,805384193L,1633771873L,3221225473L,8168859365L,12952273921L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066673Inst : IEnumerable<long>
{
public static readonly long[] Value=A066673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066673.Bytes);
public long this[int i]=>Value[i];

public static A066673Inst Instance=new A066673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066674
{
public static readonly long[] Value={ 3L,7L,11L,29L,23L,53L,103L,191L,47L,59L,311L,149L,83L,173L,283L,107L,709L,367L,269L,569L,293L,317L,167L,179L,389L,607L,619L,643L,1091L,227L,509L,263L,823L,557L,1193L,907L,1571L,653L,2339L,347L,359L,1087L,383L,773L,3547L,797L,2111L,2677L,5449L,2749L,467L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066674Inst : IEnumerable<long>
{
public static readonly long[] Value=A066674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066674.Bytes);
public long this[int i]=>Value[i];

public static A066674Inst Instance=new A066674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066675
{
public static readonly long[] Value={ 1L,2L,2L,4L,2L,4L,6L,10L,2L,2L,10L,4L,2L,4L,6L,2L,12L,6L,4L,8L,4L,4L,2L,2L,4L,6L,6L,6L,10L,2L,4L,2L,6L,4L,8L,6L,10L,4L,14L,2L,2L,6L,2L,4L,18L,4L,10L,12L,24L,12L,2L,2L,6L,2L,6L,6L,8L,6L,4L,2L,6L,2L,4L,6L,6L,26L,6L,10L,6L,10L,14L,2L,6L,4L,12L,12L,24L,6L,8L,4L,2L,10L,2L,4L,10L,2L,8L,30L,6L,12L,6L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066675Inst : IEnumerable<long>
{
public static readonly long[] Value=A066675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066675.Bytes);
public long this[int i]=>Value[i];

public static A066675Inst Instance=new A066675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066676
{
public static readonly BigInteger[] Value={ 3L,7L,31L,211L,2311L,60653L,1023053L,19417793L,446235509L,12939711677L,200560490131L,14841484883609L,608500576478849L,26165522997357677L,1229779567395958169L,BigInteger.Parse("65178316970529225209"),BigInteger.Parse("3845520700432469775917"),BigInteger.Parse("234576762719782814756597"),BigInteger.Parse("15716643102168462956621849") };
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
public class A066676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066676Inst Instance=new A066676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066677
{
public static readonly long[] Value={ 1L,3L,7L,5L,11L,7L,29L,15L,19L,11L,23L,13L,53L,29L,31L,17L,103L,19L,191L,25L,43L,23L,47L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066677Inst : IEnumerable<long>
{
public static readonly long[] Value=A066677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066677.Bytes);
public long this[int i]=>Value[i];

public static A066677Inst Instance=new A066677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066678
{
public static readonly long[] Value={ 1L,2L,6L,4L,10L,6L,28L,8L,18L,10L,22L,12L,52L,28L,30L,16L,102L,18L,190L,20L,42L,22L,46L,24L,100L,52L,54L,28L,58L,30L,310L,32L,66L,102L,70L,36L,148L,190L,78L,40L,82L,42L,172L,44L,180L,46L,282L,48L,196L,100L,102L,52L,106L,54L,110L,56L,228L,58L,708L,60L,366L,310L,126L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066678Inst : IEnumerable<long>
{
public static readonly long[] Value=A066678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066678.Bytes);
public long this[int i]=>Value[i];

public static A066678Inst Instance=new A066678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066679
{
public static readonly long[] Value={ 1L,2L,6L,10L,12L,44L,90L,184L,440L,528L,588L,672L,752L,3796L,8928L,9888L,12224L,35640L,37680L,49024L,50976L,89152L,94200L,108192L,146412L,159840L,279864L,1734720L,2554368L,2977920L,12580864L,14239872L,16544880L,28321920L,41362200L,56976480L,60610624L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066679Inst : IEnumerable<long>
{
public static readonly long[] Value=A066679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066679.Bytes);
public long this[int i]=>Value[i];

public static A066679Inst Instance=new A066679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066680
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,11L,12L,13L,17L,18L,19L,23L,27L,29L,30L,31L,37L,41L,43L,45L,47L,50L,53L,59L,61L,63L,67L,70L,71L,73L,75L,79L,80L,83L,89L,97L,98L,101L,103L,105L,107L,109L,112L,113L,125L,127L,128L,131L,137L,139L,147L,149L,151L,154L,157L,163L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066680Inst : IEnumerable<long>
{
public static readonly long[] Value=A066680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066680.Bytes);
public long this[int i]=>Value[i];

public static A066680Inst Instance=new A066680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066681
{
public static readonly long[] Value={ 8L,12L,18L,27L,30L,45L,50L,63L,70L,75L,80L,98L,105L,112L,125L,128L,147L,154L,165L,168L,175L,176L,182L,192L,195L,208L,220L,231L,242L,245L,260L,264L,273L,275L,286L,312L,325L,338L,340L,343L,357L,363L,374L,380L,385L,396L,399L,408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066681Inst : IEnumerable<long>
{
public static readonly long[] Value=A066681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066681.Bytes);
public long this[int i]=>Value[i];

public static A066681Inst Instance=new A066681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066682
{
public static readonly long[] Value={ 0L,1L,2L,0L,3L,0L,4L,5L,0L,0L,6L,7L,8L,0L,0L,0L,9L,10L,11L,0L,0L,0L,12L,0L,0L,0L,13L,0L,14L,15L,16L,0L,0L,0L,0L,0L,17L,0L,0L,0L,18L,0L,19L,0L,20L,0L,21L,0L,0L,22L,0L,0L,23L,0L,0L,0L,0L,0L,24L,0L,25L,0L,26L,0L,0L,0L,27L,0L,0L,28L,29L,0L,30L,0L,31L,0L,0L,0L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066682Inst : IEnumerable<long>
{
public static readonly long[] Value=A066682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066682.Bytes);
public long this[int i]=>Value[i];

public static A066682Inst Instance=new A066682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066683
{
public static readonly long[] Value={ 0L,1L,2L,2L,3L,3L,4L,5L,5L,5L,6L,7L,8L,8L,8L,8L,9L,10L,11L,11L,11L,11L,12L,12L,12L,12L,13L,13L,14L,15L,16L,16L,16L,16L,16L,16L,17L,17L,17L,17L,18L,18L,19L,19L,20L,20L,21L,21L,21L,22L,22L,22L,23L,23L,23L,23L,23L,23L,24L,24L,25L,25L,26L,26L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066683Inst : IEnumerable<long>
{
public static readonly long[] Value=A066683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066683.Bytes);
public long this[int i]=>Value[i];

public static A066683Inst Instance=new A066683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066684
{
public static readonly long[] Value={ 1L,2L,4L,5L,181L,324L,1253L,252649L,69789901L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066684Inst : IEnumerable<long>
{
public static readonly long[] Value=A066684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066684.Bytes);
public long this[int i]=>Value[i];

public static A066684Inst Instance=new A066684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066685
{
public static readonly long[] Value={ 1L,2L,3L,789L,40087L,238717L,251737L,7847315L,69673727L,2283427137L,2664260621L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066685Inst : IEnumerable<long>
{
public static readonly long[] Value=A066685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066685.Bytes);
public long this[int i]=>Value[i];

public static A066685Inst Instance=new A066685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066686
{
public static readonly long[] Value={ 11L,12L,21L,13L,22L,31L,14L,23L,32L,41L,15L,24L,33L,42L,51L,16L,25L,34L,43L,52L,61L,17L,26L,35L,44L,53L,62L,71L,18L,27L,36L,45L,54L,63L,72L,81L,19L,28L,37L,46L,55L,64L,73L,82L,91L,110L,29L,38L,47L,56L,65L,74L,83L,92L,101L,111L,210L,39L,48L,57L,66L,75L,84L,93L,102L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066686Inst : IEnumerable<long>
{
public static readonly long[] Value=A066686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066686.Bytes);
public long this[int i]=>Value[i];

public static A066686Inst Instance=new A066686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066687
{
public static readonly long[] Value={ 1L,2L,3L,11L,15L,67L,209L,439L,1285L,4393L,11513L,31037L,133361L,181411L,225209L,637337L,637339L,7351279L,10253001L,10553551L,339144639L,416538907L,639770919L,4631809783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066687Inst : IEnumerable<long>
{
public static readonly long[] Value=A066687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066687.Bytes);
public long this[int i]=>Value[i];

public static A066687Inst Instance=new A066687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066688
{
public static readonly long[] Value={ 1L,5L,13L,31L,299L,667L,3805L,15965L,74053L,274483L,10553437L,19329979L,71074261L,179992919L,264401891L,296059565L,8200981757L,22718360827L,24163572401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066688Inst : IEnumerable<long>
{
public static readonly long[] Value=A066688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066688.Bytes);
public long this[int i]=>Value[i];

public static A066688Inst Instance=new A066688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066689
{
public static readonly long[] Value={ 84L,36L,7L,7L,27L,18821L,18L,9L,18L,77L,9L,66L,66L,9L,15488L,55L,55L,62025L,9L,44L,9L,1547L,33L,11L,336L,96L,11L,11L,2667L,1462L,182L,11L,22L,246L,22L,11L,22L,143L,143L,11L,11L,11L,11L,48L,117L,3762L,11L,495L,117L,130L,11L,104L,832L,435L,11L,13L,91L,91L,405L,5445L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066689Inst : IEnumerable<long>
{
public static readonly long[] Value=A066689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066689.Bytes);
public long this[int i]=>Value[i];

public static A066689Inst Instance=new A066689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066690
{
public static readonly long[] Value={ 127251L,649375L,1274373L,1303047L,2206519L,2388123L,2775625L,3400623L,3585625L,3627909L,4193125L,4294375L,4311873L,5707177L,6319375L,6336873L,6926875L,7128567L,7939375L,7949581L,8101537L,11280625L,11298123L,11786875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066690Inst : IEnumerable<long>
{
public static readonly long[] Value=A066690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066690.Bytes);
public long this[int i]=>Value[i];

public static A066690Inst Instance=new A066690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066691
{
public static readonly long[] Value={ 2L,2L,2L,2L,2L,4L,2L,4L,2L,2L,4L,4L,4L,2L,2L,4L,2L,4L,4L,2L,4L,2L,4L,4L,2L,2L,4L,4L,4L,4L,4L,4L,2L,4L,2L,6L,4L,4L,2L,2L,4L,4L,4L,2L,4L,4L,4L,4L,4L,2L,4L,4L,4L,4L,4L,2L,6L,2L,4L,4L,2L,4L,4L,6L,4L,4L,2L,4L,4L,4L,4L,2L,4L,4L,4L,2L,6L,2L,4L,6L,2L,2L,8L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,4L,2L,4L,4L,2L,2L,6L,4L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066691Inst : IEnumerable<long>
{
public static readonly long[] Value=A066691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066691.Bytes);
public long this[int i]=>Value[i];

public static A066691Inst Instance=new A066691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066692
{
public static readonly long[] Value={ 3L,5L,11L,17L,29L,33L,41L,55L,59L,71L,85L,91L,93L,101L,107L,123L,137L,141L,143L,149L,159L,179L,183L,185L,191L,197L,201L,203L,213L,215L,217L,219L,227L,235L,239L,243L,247L,265L,269L,281L,299L,301L,303L,311L,319L,321L,327L,339L,341L,347L,391L,393L,411L,413L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066692Inst : IEnumerable<long>
{
public static readonly long[] Value=A066692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066692.Bytes);
public long this[int i]=>Value[i];

public static A066692Inst Instance=new A066692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066693
{
public static readonly long[] Value={ 1L,21952L,64000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066693Inst : IEnumerable<long>
{
public static readonly long[] Value=A066693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066693.Bytes);
public long this[int i]=>Value[i];

public static A066693Inst Instance=new A066693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066694
{
public static readonly long[] Value={ 4L,9L,16L,18L,25L,32L,36L,48L,50L,64L,72L,81L,84L,98L,100L,112L,144L,156L,162L,192L,196L,200L,225L,252L,256L,288L,289L,300L,324L,336L,338L,372L,392L,400L,432L,448L,450L,468L,484L,512L,576L,578L,624L,625L,648L,676L,700L,722L,729L,756L,768L,784L,800L,882L,900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066694Inst : IEnumerable<long>
{
public static readonly long[] Value=A066694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066694.Bytes);
public long this[int i]=>Value[i];

public static A066694Inst Instance=new A066694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066695
{
public static readonly long[] Value={ 252L,273L,315L,364L,399L,468L,481L,532L,546L,630L,651L,665L,684L,693L,741L,756L,777L,793L,798L,855L,868L,903L,945L,949L,962L,988L,1001L,1036L,1071L,1085L,1116L,1204L,1209L,1261L,1281L,1287L,1302L,1330L,1332L,1386L,1395L,1404L,1407L,1417L,1449L,1463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066695Inst : IEnumerable<long>
{
public static readonly long[] Value=A066695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066695.Bytes);
public long this[int i]=>Value[i];

public static A066695Inst Instance=new A066695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066696
{
public static readonly long[] Value={ 1247L,1421L,2059L,2494L,2842L,3053L,3479L,3683L,4118L,4859L,5537L,6106L,6119L,6L,931L,6958L,7366L,8023L,8471L,9017L,9653L,9718L,9947L,10277L,10991L,11074L,11711L,12083L,1223L,8L,13427L,13769L,13862L,13987L,14239L,14351L,15863L,16046L,16942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066696Inst : IEnumerable<long>
{
public static readonly long[] Value=A066696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066696.Bytes);
public long this[int i]=>Value[i];

public static A066696Inst Instance=new A066696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066697
{
public static readonly long[] Value={ 513L,703L,999L,1026L,1387L,1406L,1539L,1971L,1998L,2071L,2413L,2774L,2943L,2997L,3078L,3097L,3429L,3439L,3781L,3942L,4142L,4401L,4617L,4699L,4826L,4887L,5149L,5373L,5833L,5886L,5913L,5994L,6031L,6194L,6858L,6878L,7201L,7317L,7363L,7543L,7562L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066697Inst : IEnumerable<long>
{
public static readonly long[] Value=A066697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066697.Bytes);
public long this[int i]=>Value[i];

public static A066697Inst Instance=new A066697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066698
{
public static readonly long[] Value={ 14111L,24617L,28222L,29767L,32743L,42059L,45629L,49234L,59534L,60691L,65486L,66641L,69071L,73373L,84118L,88639L,88723L,91258L,97751L,98159L,105877L,121382L,125903L,128027L,129677L,133282L,136001L,138142L,140183L,146507L,146746L,153851L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066698Inst : IEnumerable<long>
{
public static readonly long[] Value=A066698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066698.Bytes);
public long this[int i]=>Value[i];

public static A066698Inst Instance=new A066698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066699
{
public static readonly long[] Value={ 1L,2L,4L,7L,12L,19L,22L,38L,46L,62L,68L,72L,84L,166L,184L,214L,340L,348L,445L,517L,692L,817L,1316L,1381L,2554L,2713L,5261L,6209L,6735L,7920L,8207L,8772L,9530L,13075L,13302L,13405L,15002L,16371L,19346L,24151L,26555L,28188L,29235L,33536L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066699Inst : IEnumerable<long>
{
public static readonly long[] Value=A066699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066699.Bytes);
public long this[int i]=>Value[i];

public static A066699Inst Instance=new A066699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066700
{
public static readonly BigInteger[] Value={ 1L,2L,12L,4L,34L,1L,22L,1L,4L,1L,1L,2L,1L,1L,17L,16L,3L,1L,1L,2L,1L,1L,1L,5L,1L,1L,3L,3L,14L,2L,107L,1L,1L,8L,5L,4L,7L,1L,4L,1L,6L,3L,19L,3L,1L,1L,2L,3L,5L,76L,1L,1L,2L,1L,1L,90L,2L,2L,48717L,1L,1L,1L,3L,1L,1L,2L,4L,1L,1L,1L,14L,2L,1L,1L,2L,4L,28L,2L,3L,46L,1L,1L,3L,1L,1L,1L,2L,1L,5L,12L,1L,1L,3L,3L,1L,2L,3L,1L,78L,1L,1L,1L,3L,2L,4L,1L,6L,1L,1L,1048L,1L,3L,1L,1L,2L,3L,4L,1L,2L,4L,3L,8L,1L,12L,5L,1L,1L,7L,1L,11L,11L,1L,118L,6L,1L,2L,1L,5L,3L,1L,1L,1L,2L,3L,1L,2L,1L,1L,2L,2L,3L,5L,4L,1L,12L,BigInteger.Parse("147838832589501802758390"),1L,10L,1L,1L,1L,2L,4L,6L,10L,2L,8L,1L,2L,1L,1L,7L,1L,1L,1L,3L,9L,1L,1L,1L,55L,1L,1L,1L,1L,2L };
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
public class A066700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066700Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066700.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066700.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066700Inst Instance=new A066700Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066701
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,5L,1L,6L,1L,1L,1L,1L,1L,77L,3L,2L,1L,1L,1L,1L,58L,1L,40L,1L,20L,1L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066701Inst : IEnumerable<long>
{
public static readonly long[] Value=A066701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066701.Bytes);
public long this[int i]=>Value[i];

public static A066701Inst Instance=new A066701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066702
{
public static readonly BigInteger[] Value={ 0L,1L,1306449L,1044000721L,12957041241L,1019072079081L,1174279984164L,6454272356676L,65036563475625L,67624587155889L,123826990849454025L,BigInteger.Parse("170448128872993657764"),BigInteger.Parse("19198191503444720114404") };
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
public class A066702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066702Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066702.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066702.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066702Inst Instance=new A066702Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066703
{
public static readonly BigInteger[] Value={ 0L,1L,9446031L,1270004401L,14214075921L,1809702709101L,4614899724711L,6766532724546L,52657436563056L,98855178542676L,520454948099628321L,BigInteger.Parse("467756399278821844071"),BigInteger.Parse("40441102744430519189191") };
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
public class A066703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066703Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066703.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066703.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066703Inst Instance=new A066703Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066704
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,3L,1L,6L,4L,4L,1L,10L,5L,5L,5L,1L,20L,15L,6L,6L,6L,1L,35L,21L,7L,7L,7L,7L,1L,70L,28L,28L,8L,8L,8L,8L,1L,126L,84L,36L,9L,9L,9L,9L,9L,1L,252L,120L,45L,45L,10L,10L,10L,10L,10L,1L,462L,165L,55L,55L,11L,11L,11L,11L,11L,11L,1L,924L,495L,220L,66L,66L,12L,12L,12L,12L,12L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066704Inst : IEnumerable<long>
{
public static readonly long[] Value=A066704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066704.Bytes);
public long this[int i]=>Value[i];

public static A066704Inst Instance=new A066704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066705
{
public static readonly long[] Value={ 0L,1L,0L,3L,0L,4L,0L,5L,7L,8L,0L,10L,0L,9L,0L,15L,0L,14L,0L,16L,13L,11L,0L,20L,0L,21L,19L,26L,0L,24L,0L,17L,25L,32L,0L,28L,0L,27L,35L,34L,0L,36L,0L,33L,39L,23L,0L,40L,43L,44L,0L,45L,0L,38L,41L,52L,37L,29L,0L,48L,0L,31L,57L,51L,0L,50L,0L,64L,0L,56L,0L,70L,0L,63L,55L,74L,61L,72L,0L,68L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066705Inst : IEnumerable<long>
{
public static readonly long[] Value=A066705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066705.Bytes);
public long this[int i]=>Value[i];

public static A066705Inst Instance=new A066705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066706
{
public static readonly long[] Value={ 2L,3L,10L,30L,182L,439L,1058L,40086L,40090L,40114L,40120L,100347L,251708L,637328L,637336L,637340L,4124468L,10553440L,10553445L,10553829L,27067138L,179992932L,179993008L,179993012L,179993017L,465769835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066706Inst : IEnumerable<long>
{
public static readonly long[] Value=A066706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066706.Bytes);
public long this[int i]=>Value[i];

public static A066706Inst Instance=new A066706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066707
{
public static readonly long[] Value={ 2L,8L,10L,32L,39L,5903L,135598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066707Inst : IEnumerable<long>
{
public static readonly long[] Value=A066707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066707.Bytes);
public long this[int i]=>Value[i];

public static A066707Inst Instance=new A066707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066708
{
public static readonly long[] Value={ 3L,6L,15L,28L,165L,30L,135L,48L,144L,192L,1755L,300L,1485L,270L,2079L,336L,6237L,1008L,9639L,1728L,1296L,3510L,28215L,1080L,16900L,2970L,10395L,7840L,12285L,4158L,41055L,4752L,40425L,12474L,48195L,3780L,220077L,19278L,51975L,10920L,356265L,9450L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066708Inst : IEnumerable<long>
{
public static readonly long[] Value=A066708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066708.Bytes);
public long this[int i]=>Value[i];

public static A066708Inst Instance=new A066708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066709
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,0L,2L,4L,1L,1L,5L,8L,5L,1L,0L,3L,14L,15L,6L,1L,1L,9L,25L,32L,21L,7L,1L,0L,4L,32L,62L,56L,28L,8L,1L,1L,14L,56L,109L,122L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066709Inst : IEnumerable<long>
{
public static readonly long[] Value=A066709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066709.Bytes);
public long this[int i]=>Value[i];

public static A066709Inst Instance=new A066709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066710
{
public static readonly long[] Value={ 3L,6L,12L,33L,66L,123L,444L,888L,1677L,3489L,12333L,44556L,111L,222L,444L,888L,1677L,3489L,12333L,44556L,111L,222L,444L,888L,1677L,3489L,12333L,44556L,111L,222L,444L,888L,1677L,3489L,12333L,44556L,111L,222L,444L,888L,1677L,3489L,12333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066710Inst : IEnumerable<long>
{
public static readonly long[] Value=A066710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066710.Bytes);
public long this[int i]=>Value[i];

public static A066710Inst Instance=new A066710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066711
{
public static readonly long[] Value={ 9L,18L,99L,189L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L,288L,117L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066711Inst : IEnumerable<long>
{
public static readonly long[] Value=A066711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066711.Bytes);
public long this[int i]=>Value[i];

public static A066711Inst Instance=new A066711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066712
{
public static readonly long[] Value={ 3L,1L,4L,15L,5L,9L,2L,6L,53L,35L,58L,8L,97L,7L,93L,32L,23L,38L,84L,46L,62L,264L,64L,43L,33L,383L,83L,327L,27L,795L,95L,50L,0L,28L,88L,841L,419L,19L,971L,71L,16L,69L,939L,39L,99L,937L,37L,75L,51L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066712Inst : IEnumerable<long>
{
public static readonly long[] Value=A066712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066712.Bytes);
public long this[int i]=>Value[i];

public static A066712Inst Instance=new A066712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066713
{
public static readonly long[] Value={ 2L,4L,8L,16L,77L,55L,11L,499L,89L,277L,2255L,145L,11L,1111L,44567L,111499L,12299L,1234L,3467L,113467L,677789L,144556L,1222889L,14445667L,4577789L,55669999L,1134899L,11356999L,12237899L,445557799L,1223555555L,11113366L,1122222266L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066713Inst : IEnumerable<long>
{
public static readonly long[] Value=A066713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066713.Bytes);
public long this[int i]=>Value[i];

public static A066713Inst Instance=new A066713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066714
{
public static readonly long[] Value={ 1L,6L,6L,30L,18L,78L,38L,150L,66L,246L,102L,366L,146L,510L,198L,678L,258L,870L,326L,1086L,402L,1326L,486L,1590L,578L,1878L,678L,2190L,786L,2526L,902L,2886L,1026L,3270L,1158L,3678L,1298L,4110L,1446L,4566L,1602L,5046L,1766L,5550L,1938L,6078L,2118L,6630L,2306L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066714Inst : IEnumerable<long>
{
public static readonly long[] Value=A066714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066714.Bytes);
public long this[int i]=>Value[i];

public static A066714Inst Instance=new A066714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066715
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,7L,1L,5L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,13L,1L,1L,3L,1L,1L,1L,1L,1L,15L,1L,1L,3L,1L,5L,3L,1L,1L,9L,1L,1L,3L,1L,1L,3L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,1L,1L,1L,3L,1L,1L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066715Inst : IEnumerable<long>
{
public static readonly long[] Value=A066715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066715.Bytes);
public long this[int i]=>Value[i];

public static A066715Inst Instance=new A066715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066716
{
public static readonly long[] Value={ 8L,6L,2L,2L,4L,0L,1L,2L,5L,8L,6L,8L,0L,5L,4L,5L,7L,1L,5L,5L,7L,7L,9L,0L,2L,8L,3L,2L,4L,9L,3L,9L,4L,5L,7L,8L,5L,6L,5L,7L,6L,4L,7L,4L,2L,7L,6L,8L,2L,9L,9L,0L,9L,4L,5L,1L,6L,0L,7L,1L,2L,1L,4L,5L,5L,7L,3L,0L,6L,7L,4L,0L,5L,9L,0L,5L,1L,6L,4L,5L,8L,0L,4L,2L,0L,3L,8L,4L,4L,1L,4L,3L,8L,6L,1L,8L,1L,3L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066716Inst : IEnumerable<long>
{
public static readonly long[] Value=A066716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066716.Bytes);
public long this[int i]=>Value[i];

public static A066716Inst Instance=new A066716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066717
{
public static readonly long[] Value={ 0L,1L,6L,3L,1L,6L,5L,3L,3L,1L,6L,4L,1L,3L,298L,1L,6L,1L,1L,3L,285L,7L,2L,4L,1L,2L,1L,2L,1L,1L,4534532L,1L,4L,5L,1L,2L,1L,7L,1L,16L,1L,4L,1L,5L,5L,1L,5L,1L,4L,1L,2L,1L,5L,3L,2L,38L,2L,12L,1L,15L,2L,6L,3L,30L,4682854730443938L,1L,1L,68L,1L,6L,5L,4L,4L,1L,2L,1L,1L,1L,1L,2L,22L,1L,2L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066717Inst : IEnumerable<long>
{
public static readonly long[] Value=A066717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066717.Bytes);
public long this[int i]=>Value[i];

public static A066717Inst Instance=new A066717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066718
{
public static readonly BigInteger[] Value={ 0L,1L,6L,298L,4534532L,4682854730443938L,BigInteger.Parse("21178658483534445867705807931242133"),BigInteger.Parse("1784182521628823878390282782427911592097785568614928986384139293902055110") };
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
public class A066718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066718Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066718.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066718.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066718Inst Instance=new A066718Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066719
{
public static readonly long[] Value={ 1L,2L,4L,6L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066719Inst : IEnumerable<long>
{
public static readonly long[] Value=A066719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066719.Bytes);
public long this[int i]=>Value[i];

public static A066719Inst Instance=new A066719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066720
{
public static readonly long[] Value={ 1L,2L,3L,5L,7L,8L,11L,13L,17L,18L,19L,23L,29L,31L,37L,41L,43L,47L,50L,53L,59L,60L,61L,67L,71L,73L,79L,81L,83L,89L,97L,98L,101L,103L,105L,107L,109L,113L,127L,128L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066720Inst : IEnumerable<long>
{
public static readonly long[] Value=A066720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066720.Bytes);
public long this[int i]=>Value[i];

public static A066720Inst Instance=new A066720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066721
{
public static readonly long[] Value={ 1L,8L,18L,50L,60L,81L,98L,105L,128L,242L,264L,308L,338L,416L,495L,520L,546L,560L,578L,625L,663L,675L,684L,864L,935L,952L,1029L,1058L,1083L,1224L,1242L,1254L,1425L,1430L,1682L,1729L,1748L,1771L,1827L,1922L,2436L,2691L,2697L,2720L,2738L,2755L,2790L,2975L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066721Inst : IEnumerable<long>
{
public static readonly long[] Value=A066721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066721.Bytes);
public long this[int i]=>Value[i];

public static A066721Inst Instance=new A066721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066722
{
public static readonly long[] Value={ 60L,66L,72L,100L,106L,110L,116L,118L,134L,146L,166L,172L,182L,212L,248L,332L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066722Inst : IEnumerable<long>
{
public static readonly long[] Value=A066722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066722.Bytes);
public long this[int i]=>Value[i];

public static A066722Inst Instance=new A066722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066723
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,36L,109L,340L,1116L,3744L,12981L,45722L,165247L,603242L,2242932L,8422438L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066723Inst : IEnumerable<long>
{
public static readonly long[] Value=A066723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066723.Bytes);
public long this[int i]=>Value[i];

public static A066723Inst Instance=new A066723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066724
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,7L,9L,11L,13L,16L,17L,19L,23L,25L,29L,30L,31L,37L,41L,43L,47L,49L,53L,59L,61L,67L,71L,73L,79L,81L,83L,84L,89L,97L,101L,103L,107L,109L,113L,121L,127L,128L,131L,137L,139L,149L,151L,154L,157L,163L,167L,169L,173L,179L,180L,181L,191L,193L,197L,199L,211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066724Inst : IEnumerable<long>
{
public static readonly long[] Value=A066724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066724.Bytes);
public long this[int i]=>Value[i];

public static A066724Inst Instance=new A066724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066725
{
public static readonly long[] Value={ 2L,11L,23L,29L,41L,43L,47L,61L,67L,89L,149L,163L,167L,211L,223L,227L,229L,233L,251L,257L,263L,269L,281L,349L,367L,383L,419L,431L,433L,439L,463L,491L,521L,523L,569L,587L,613L,617L,631L,643L,659L,661L,673L,761L,769L,821L,827L,857L,883L,887L,929L,941L,967L,1123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066725Inst : IEnumerable<long>
{
public static readonly long[] Value=A066725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066725.Bytes);
public long this[int i]=>Value[i];

public static A066725Inst Instance=new A066725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066726
{
public static readonly long[] Value={ 2L,3L,5L,9L,15L,29L,43L,51L,113L,184L,213L,222L,267L,279L,369L,402L,441L,603L,812L,839L,902L,1422L,1542L,1824L,2983L,3065L,3911L,3958L,4192L,4587L,4865L,5543L,5837L,7902L,9299L,9722L,10412L,10648L,11498L,12803L,14428L,15876L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066726Inst : IEnumerable<long>
{
public static readonly long[] Value=A066726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066726.Bytes);
public long this[int i]=>Value[i];

public static A066726Inst Instance=new A066726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066727
{
public static readonly long[] Value={ 0L,1L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,17L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,13L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066727Inst : IEnumerable<long>
{
public static readonly long[] Value=A066727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066727.Bytes);
public long this[int i]=>Value[i];

public static A066727Inst Instance=new A066727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066728
{
public static readonly long[] Value={ 0L,1L,1L,3L,1L,4L,2L,4L,2L,7L,1L,7L,3L,5L,3L,8L,1L,11L,3L,7L,3L,9L,2L,9L,5L,7L,3L,15L,1L,13L,3L,6L,7L,11L,3L,11L,3L,9L,3L,19L,1L,15L,5L,7L,5L,11L,2L,17L,5L,11L,3L,15L,3L,19L,7L,9L,3L,15L,1L,15L,5L,7L,11L,15L,3L,15L,3L,15L,3L,29L,1L,14L,5L,7L,11L,15L,3L,23L,4L,11L,4L,15L,3L,15L,7L,9L,3L,29L,3L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066728Inst : IEnumerable<long>
{
public static readonly long[] Value=A066728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066728.Bytes);
public long this[int i]=>Value[i];

public static A066728Inst Instance=new A066728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066729
{
public static readonly long[] Value={ 1L,2L,3L,2L,5L,6L,7L,8L,3L,10L,11L,144L,13L,14L,15L,64L,17L,324L,19L,400L,21L,22L,23L,13824L,5L,26L,27L,784L,29L,27000L,31L,1024L,33L,34L,35L,279936L,37L,38L,39L,64000L,41L,74088L,43L,1936L,2025L,46L,47L,5308416L,7L,2500L,51L,2704L,53L,157464L,55L,175616L,57L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066729Inst : IEnumerable<long>
{
public static readonly long[] Value=A066729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066729.Bytes);
public long this[int i]=>Value[i];

public static A066729Inst Instance=new A066729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066730
{
public static readonly long[] Value={ 2L,3L,12L,21L,60L,184L,280L,364L,1456L,3124L,5236L,17185L,25249L,49504L,233776L,364144L,775369L,3864169L,8794864L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066730Inst : IEnumerable<long>
{
public static readonly long[] Value=A066730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066730.Bytes);
public long this[int i]=>Value[i];

public static A066730Inst Instance=new A066730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066731
{
public static readonly long[] Value={ 4680L,60192L,179424L,1737000L,2578968L,3441888L,5604192L,6008184L,6331104L,302459850L,320457888L,477229032L,589459104L,731925000L,766073448L,928765600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066731Inst : IEnumerable<long>
{
public static readonly long[] Value=A066731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066731.Bytes);
public long this[int i]=>Value[i];

public static A066731Inst Instance=new A066731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066732
{
public static readonly long[] Value={ 3L,4L,6L,18L,150L,60L,30L,22440L,120360L,44880L,5610L,11730L,8160L,473280L,277440L,131070L,548760L,920040L,750720L,440130L,329970L,27030L,5689560L,522240L,1020L,3028890L,2639760L,6866130L,251430L,134130L,7481190L,2390880L,2664240L,9926130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066732Inst : IEnumerable<long>
{
public static readonly long[] Value=A066732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066732.Bytes);
public long this[int i]=>Value[i];

public static A066732Inst Instance=new A066732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066733
{
public static readonly long[] Value={ 1L,2L,3L,7L,12L,17L,21L,38L,88L,106L,107L,108L,109L,117L,122L,128L,129L,141L,146L,164L,168L,171L,173L,178L,191L,196L,204L,206L,207L,208L,209L,212L,221L,222L,236L,263L,276L,278L,288L,306L,342L,359L,364L,367L,372L,377L,394L,432L,463L,478L,479L,518L,537L,538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066733Inst : IEnumerable<long>
{
public static readonly long[] Value=A066733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066733.Bytes);
public long this[int i]=>Value[i];

public static A066733Inst Instance=new A066733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066734
{
public static readonly long[] Value={ 1L,118L,144L,211L,427L,739L,1836L,8958L,19638L,20528L,21454L,22359L,24533L,26022L,27378L,29648L,33038L,33204L,33648L,40226L,40262L,46416L,47181L,47198L,49314L,53133L,55273L,55792L,59559L,59754L,60924L,61292L,61763L,61933L,66408L,68302L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066734Inst : IEnumerable<long>
{
public static readonly long[] Value=A066734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066734.Bytes);
public long this[int i]=>Value[i];

public static A066734Inst Instance=new A066734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066735
{
public static readonly long[] Value={ 2L,3L,19L,1471L,3001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066735Inst : IEnumerable<long>
{
public static readonly long[] Value=A066735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066735.Bytes);
public long this[int i]=>Value[i];

public static A066735Inst Instance=new A066735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066736
{
public static readonly long[] Value={ 2L,2L,2L,118L,382L,580408L,178758L,12L,1254514L,53067715L,51773525L,314537797L,110242999L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066736Inst : IEnumerable<long>
{
public static readonly long[] Value=A066736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066736.Bytes);
public long this[int i]=>Value[i];

public static A066736Inst Instance=new A066736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066737
{
public static readonly long[] Value={ 22L,25L,27L,32L,33L,35L,52L,55L,57L,72L,75L,77L,112L,115L,117L,132L,133L,135L,172L,175L,177L,192L,195L,213L,217L,219L,222L,225L,231L,232L,235L,237L,243L,247L,252L,253L,255L,259L,261L,267L,272L,273L,275L,279L,289L,292L,295L,297L,312L,315L,319L,322L,323L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066737Inst : IEnumerable<long>
{
public static readonly long[] Value=A066737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066737.Bytes);
public long this[int i]=>Value[i];

public static A066737Inst Instance=new A066737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066738
{
public static readonly long[] Value={ 11L,19L,41L,61L,89L,101L,109L,127L,139L,149L,151L,157L,163L,181L,191L,193L,199L,211L,229L,241L,251L,269L,271L,281L,331L,349L,359L,389L,401L,409L,419L,421L,433L,439L,449L,457L,461L,463L,487L,491L,499L,509L,521L,541L,569L,571L,601L,619L,631L,641L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066738Inst : IEnumerable<long>
{
public static readonly long[] Value=A066738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066738.Bytes);
public long this[int i]=>Value[i];

public static A066738Inst Instance=new A066738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066739
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,8L,14L,19L,32L,44L,67L,91L,139L,186L,269L,362L,518L,687L,960L,1267L,1747L,2294L,3106L,4052L,5449L,7063L,9365L,12092L,15914L,20422L,26639L,34029L,44091L,56076L,72110L,91306L,116808L,147272L,187224L,235201L,297594L,372390L,468844L,584644L,732942L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066739Inst : IEnumerable<long>
{
public static readonly long[] Value=A066739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066739.Bytes);
public long this[int i]=>Value[i];

public static A066739Inst Instance=new A066739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066740
{
public static readonly long[] Value={ 1L,1L,2L,5L,13L,44L,151L,614L,2446L,11066L,53368L,253927L,1316375L,7213979L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066740Inst : IEnumerable<long>
{
public static readonly long[] Value=A066740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066740.Bytes);
public long this[int i]=>Value[i];

public static A066740Inst Instance=new A066740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066741
{
public static readonly BigInteger[] Value={ 0L,1L,925L,1426L,6112L,9801L,140301L,52244922262L,1445531162626L,5205252778462L,63253297234426L,BigInteger.Parse("9040940929621480310251") };
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
public class A066741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066741Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066741.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066741.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066741Inst Instance=new A066741Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066742
{
public static readonly BigInteger[] Value={ 0L,1L,529L,1089L,2116L,6241L,103041L,26222944225L,2648772525025L,6262611355441L,62443279235236L,BigInteger.Parse("1520130841269290490409") };
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
public class A066742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066742Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A066742.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A066742.Bytes);
public BigInteger this[int i]=>Value[i];

public static A066742Inst Instance=new A066742Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066743
{
public static readonly long[] Value={ 1L,1L,3L,1L,2L,1L,4L,2L,2L,1L,2L,2L,5L,1L,2L,1L,5L,3L,2L,1L,4L,2L,4L,1L,2L,1L,4L,2L,2L,2L,4L,2L,4L,1L,2L,1L,4L,3L,2L,1L,2L,2L,6L,1L,2L,1L,9L,2L,2L,1L,2L,2L,4L,1L,3L,1L,8L,2L,2L,1L,2L,2L,4L,2L,2L,1L,4L,3L,2L,1L,2L,3L,7L,1L,2L,1L,4L,2L,2L,2L,3L,2L,7L,1L,2L,1L,4L,2L,3L,1L,4L,2L,5L,1L,2L,1L,4L,3L,4L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066743Inst : IEnumerable<long>
{
public static readonly long[] Value=A066743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066743.Bytes);
public long this[int i]=>Value[i];

public static A066743Inst Instance=new A066743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A066744
{
public static readonly long[] Value={ 1L,7L,29L,117L,471L,1885L,7543L,30173L,120693L,482775L,1931101L,7724405L,30897623L,123590493L,494361975L,1977447901L,7909791605L,31639166423L,126556665693L,506226662775L,2024906651101L,8099626604405L,32398506417623L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A066744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A066744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A066744Inst : IEnumerable<long>
{
public static readonly long[] Value=A066744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A066744.Bytes);
public long this[int i]=>Value[i];

public static A066744Inst Instance=new A066744Inst();

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