using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A201457
{
public static readonly long[] Value={ 5L,11L,1L,11L,23L,29L,17L,31L,13L,37L,61L,11L,35L,149L,17L,151L,17L,17L,17L,13L,59L,17L,73L,47L,43L,13L,113L,77L,119L,97L,125L,83L,13L,421L,103L,103L,77L,23L,23L,79L,5L,107L,7L,37L,59L,113L,11L,1L,169L,887L,137L,41L,113L,71L,277L,413L,97L,91L,227L,337L,97L,353L,233L,953L,5L,139L,77L,473L,73L,167L,275L,67L,49L,97L,365L,73L,223L,241L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201457Inst : IEnumerable<long>
{
public static readonly long[] Value=A201457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201457.Bytes);
public long this[int i]=>Value[i];

public static A201457Inst Instance=new A201457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201458
{
public static readonly long[] Value={ 1L,9L,46L,175L,551L,1520L,3811L,8921L,19922L,43211L,92363L,196608L,419295L,897565L,1926458L,4135255L,8854359L,18875392L,40024059L,84417521L,177221602L,370688979L,773342163L,1610612736L,3350668423L,6964989333L,14466833194L,30021724351L,62233946303L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201458Inst : IEnumerable<long>
{
public static readonly long[] Value=A201458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201458.Bytes);
public long this[int i]=>Value[i];

public static A201458Inst Instance=new A201458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201459
{
public static readonly long[] Value={ 1L,1L,5L,7L,7L,11L,5L,29L,13L,29L,5L,1L,77L,1L,13L,101L,65L,77L,175L,29L,77L,121L,49L,23L,41L,31L,613L,101L,13L,37L,127L,47L,197L,31L,107L,97L,275L,17L,619L,47L,7L,199L,85L,31L,47L,17L,97L,253L,17L,37L,5L,103L,215L,119L,335L,257L,277L,121L,313L,89L,157L,187L,25L,7L,571L,11L,197L,53L,13L,101L,49L,199L,67L,389L,109L,13L,25L,41L,337L,647L,77L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201459Inst : IEnumerable<long>
{
public static readonly long[] Value=A201459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201459.Bytes);
public long this[int i]=>Value[i];

public static A201459Inst Instance=new A201459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201460
{
public static readonly long[] Value={ 1L,15L,1L,19L,51L,1L,49L,1L,1L,15L,51L,9L,21L,211L,79L,21L,7L,31L,129L,105L,87L,21L,21L,13L,7L,109L,57L,55L,159L,75L,231L,73L,33L,19L,57L,75L,3L,49L,207L,93L,463L,15L,141L,421L,151L,177L,237L,1L,99L,49L,129L,211L,79L,697L,49L,13L,237L,169L,439L,181L,201L,109L,159L,229L,271L,15L,31L,559L,57L,127L,183L,595L,43L,237L,3L,69L,463L,387L,141L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201460Inst : IEnumerable<long>
{
public static readonly long[] Value=A201460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201460.Bytes);
public long this[int i]=>Value[i];

public static A201460Inst Instance=new A201460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201461
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,28L,70L,28L,1L,1L,120L,1820L,8008L,12870L,8008L,1820L,120L,1L,1L,496L,35960L,906192L,10518300L,64512240L,225792840L,471435600L,601080390L,471435600L,225792840L,64512240L,10518300L,906192L,35960L,496L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201461Inst : IEnumerable<long>
{
public static readonly long[] Value=A201461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201461.Bytes);
public long this[int i]=>Value[i];

public static A201461Inst Instance=new A201461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201462
{
public static readonly long[] Value={ 3L,6L,9L,11L,12L,15L,18L,21L,22L,24L,27L,30L,33L,36L,39L,42L,44L,45L,48L,51L,54L,55L,57L,60L,63L,66L,69L,72L,75L,77L,78L,81L,84L,87L,88L,90L,93L,96L,99L,102L,105L,108L,111L,114L,117L,120L,123L,126L,129L,132L,135L,138L,141L,144L,147L,148L,150L,153L,156L,159L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201462Inst : IEnumerable<long>
{
public static readonly long[] Value=A201462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201462.Bytes);
public long this[int i]=>Value[i];

public static A201462Inst Instance=new A201462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201463
{
public static readonly long[] Value={ 6L,10L,12L,14L,15L,18L,21L,22L,24L,26L,28L,33L,35L,36L,39L,48L,52L,56L,65L,72L,88L,91L,99L,117L,144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201463Inst : IEnumerable<long>
{
public static readonly long[] Value=A201463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201463.Bytes);
public long this[int i]=>Value[i];

public static A201463Inst Instance=new A201463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201464
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,82L,91L,93L,95L,106L,118L,119L,122L,123L,133L,145L,155L,159L,161L,183L,187L,202L,213L,265L,287L,295L,299L,319L,355L,393L,413L,453L,497L,505L,583L,671L,835L,917L,1057L,1169L,1313L,1438L,1441L,1837L,1963L,3595L,5033L,7909L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201464Inst : IEnumerable<long>
{
public static readonly long[] Value=A201464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201464.Bytes);
public long this[int i]=>Value[i];

public static A201464Inst Instance=new A201464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201465
{
public static readonly BigInteger[] Value={ 1L,2L,14L,162L,2622L,54546L,1386702L,41660226L,1444071006L,56728401138L,2490626473326L,120858220146978L,6423145784929278L,371046277074303954L,BigInteger.Parse("23148851187463826958"),BigInteger.Parse("1551182540888019542274"),BigInteger.Parse("111111330526583477368734"),BigInteger.Parse("8472364399282482984295602"),BigInteger.Parse("685178683361064789536947374") };
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
public class A201465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201465Inst Instance=new A201465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201466
{
public static readonly BigInteger[] Value={ 1L,3L,30L,498L,11568L,345432L,12606240L,543678672L,27054328512L,1525746223488L,96167433279360L,6699404849841408L,511152613463843328L,BigInteger.Parse("42391161255859802112"),BigInteger.Parse("3796840836492517125120"),BigInteger.Parse("365260399012767192102912"),BigInteger.Parse("37561729737177160757133312"),BigInteger.Parse("4111876748834828077514170368") };
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
public class A201466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201466Inst Instance=new A201466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201467
{
public static readonly long[] Value={ 126L,448L,55476L,7482240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201467Inst : IEnumerable<long>
{
public static readonly long[] Value=A201467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201467.Bytes);
public long this[int i]=>Value[i];

public static A201467Inst Instance=new A201467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201468
{
public static readonly long[] Value={ 21L,105L,126L,4893L,168756L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201468Inst : IEnumerable<long>
{
public static readonly long[] Value=A201468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201468.Bytes);
public long this[int i]=>Value[i];

public static A201468Inst Instance=new A201468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201469
{
public static readonly long[] Value={ 28L,105L,448L,401928849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201469Inst : IEnumerable<long>
{
public static readonly long[] Value=A201469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201469.Bytes);
public long this[int i]=>Value[i];

public static A201469Inst Instance=new A201469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201470
{
public static readonly BigInteger[] Value={ 1L,2L,12L,126L,1928L,39050L,987852L,30028670L,1067161104L,43439950098L,1993658601620L,101873148358982L,5736946141694616L,353052289411248986L,BigInteger.Parse("23574446170669354716"),BigInteger.Parse("1697657229173802582030"),BigInteger.Parse("131156091046113794979872"),BigInteger.Parse("10821153944570302041170978"),BigInteger.Parse("949646768024669592457251108") };
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
public class A201470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201470Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201470.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201470.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201470Inst Instance=new A201470Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201471
{
public static readonly long[] Value={ 3L,4L,6L,7L,9L,11L,15L,17L,19L,21L,23L,25L,27L,29L,31L,33L,35L,37L,39L,41L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,65L,67L,69L,71L,73L,75L,77L,79L,81L,83L,85L,87L,89L,91L,93L,95L,97L,99L,101L,103L,105L,107L,109L,111L,113L,115L,117L,119L,121L,123L,125L,127L,129L,131L,133L,135L,137L,139L,141L,143L,145L,147L,149L,151L,153L,155L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201471Inst : IEnumerable<long>
{
public static readonly long[] Value=A201471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201471.Bytes);
public long this[int i]=>Value[i];

public static A201471Inst Instance=new A201471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201472
{
public static readonly long[] Value={ 5L,6L,7L,8L,10L,11L,12L,13L,15L,16L,17L,18L,20L,21L,22L,23L,26L,27L,28L,29L,31L,32L,33L,34L,36L,37L,38L,39L,41L,42L,43L,44L,47L,48L,49L,50L,52L,53L,54L,55L,57L,58L,59L,60L,62L,63L,64L,65L,68L,69L,70L,71L,73L,74L,75L,76L,78L,79L,80L,81L,83L,84L,85L,86L,90L,91L,92L,93L,95L,96L,97L,98L,100L,101L,102L,103L,105L,106L,107L,108L,111L,112L,113L,114L,116L,117L,118L,119L,121L,122L,123L,124L,126L,127L,128L,129L,132L,133L,134L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201472Inst : IEnumerable<long>
{
public static readonly long[] Value=A201472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201472.Bytes);
public long this[int i]=>Value[i];

public static A201472Inst Instance=new A201472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201473
{
public static readonly long[] Value={ 3L,5L,11L,53L,101L,131L,971L,1061L,1571L,2741L,3203L,3701L,4421L,5003L,6053L,7691L,9803L,13451L,13781L,16931L,19211L,21221L,22901L,24203L,25541L,27851L,31253L,32261L,32771L,35381L,51203L,57803L,61253L,69941L,77621L,81611L,82421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201473Inst : IEnumerable<long>
{
public static readonly long[] Value=A201473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201473.Bytes);
public long this[int i]=>Value[i];

public static A201473Inst Instance=new A201473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201474
{
public static readonly long[] Value={ 5L,7L,13L,23L,37L,103L,167L,293L,397L,653L,727L,887L,1063L,2053L,3533L,3877L,4423L,5413L,5623L,6277L,6733L,6967L,10663L,10957L,11863L,12487L,13127L,14797L,15493L,16567L,19213L,20407L,23333L,23767L,25997L,29287L,30757L,33287L,34327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201474Inst : IEnumerable<long>
{
public static readonly long[] Value=A201474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201474.Bytes);
public long this[int i]=>Value[i];

public static A201474Inst Instance=new A201474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201475
{
public static readonly long[] Value={ 7L,79L,457L,3049L,4057L,5209L,5839L,7207L,8719L,11257L,18439L,19609L,25999L,28807L,33289L,36457L,39769L,41479L,45007L,48679L,80809L,93319L,95929L,109519L,121039L,130057L,145807L,155689L,162457L,169369L,180007L,209959L,229849L,272329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201475Inst : IEnumerable<long>
{
public static readonly long[] Value=A201475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201475.Bytes);
public long this[int i]=>Value[i];

public static A201475Inst Instance=new A201475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201476
{
public static readonly long[] Value={ 11L,17L,41L,59L,107L,137L,251L,347L,401L,521L,587L,809L,977L,1259L,1361L,1931L,2459L,2897L,3209L,3371L,3881L,4241L,5009L,5417L,6737L,6971L,7451L,9257L,10091L,10667L,11867L,12491L,12809L,13457L,15497L,16937L,17681L,18059L,20411L,21227L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201476Inst : IEnumerable<long>
{
public static readonly long[] Value=A201476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201476.Bytes);
public long this[int i]=>Value[i];

public static A201476Inst Instance=new A201476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201477
{
public static readonly long[] Value={ 7L,31L,79L,151L,367L,1087L,1327L,1879L,2887L,3271L,4111L,4567L,6079L,7207L,8431L,15991L,16879L,17791L,19687L,23767L,24847L,25951L,34351L,39679L,42487L,49927L,51487L,54679L,56311L,63079L,73951L,102679L,104911L,111751L,123631L,126079L,128551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201477Inst : IEnumerable<long>
{
public static readonly long[] Value=A201477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201477.Bytes);
public long this[int i]=>Value[i];

public static A201477Inst Instance=new A201477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201478
{
public static readonly long[] Value={ 5L,17L,53L,113L,197L,593L,773L,977L,1733L,2357L,4337L,5297L,5813L,6353L,6917L,8117L,8753L,9413L,13877L,16433L,17333L,18257L,20177L,22193L,26513L,27653L,28817L,33713L,38993L,41777L,44657L,46133L,49157L,60497L,62213L,65717L,69317L,71153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201478Inst : IEnumerable<long>
{
public static readonly long[] Value=A201478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201478.Bytes);
public long this[int i]=>Value[i];

public static A201478Inst Instance=new A201478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201479
{
public static readonly long[] Value={ 7L,19L,199L,307L,439L,1459L,2707L,3079L,4339L,7507L,10099L,13879L,15559L,19207L,31219L,36307L,43207L,50707L,57139L,65719L,117619L,134839L,145207L,147859L,172807L,175699L,187507L,231859L,248839L,288307L,303379L,326707L,330679L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201479Inst : IEnumerable<long>
{
public static readonly long[] Value=A201479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201479.Bytes);
public long this[int i]=>Value[i];

public static A201479Inst Instance=new A201479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201480
{
public static readonly long[] Value={ 13L,37L,157L,373L,877L,1093L,1597L,5557L,6637L,7213L,10453L,11173L,13477L,14293L,22717L,23773L,36973L,38317L,41077L,43933L,48397L,53077L,57973L,61357L,70237L,75853L,77773L,89797L,93997L,104917L,109453L,116437L,123637L,141277L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201480Inst : IEnumerable<long>
{
public static readonly long[] Value=A201480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201480.Bytes);
public long this[int i]=>Value[i];

public static A201480Inst Instance=new A201480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201481
{
public static readonly long[] Value={ 2L,7L,47L,127L,607L,1447L,2207L,2647L,7607L,11047L,12007L,13007L,22447L,26647L,37847L,39607L,45127L,53047L,55127L,59407L,68447L,83207L,91127L,129607L,160207L,186247L,206047L,210127L,235447L,239807L,295247L,305047L,330247L,361807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201481Inst : IEnumerable<long>
{
public static readonly long[] Value=A201481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201481.Bytes);
public long this[int i]=>Value[i];

public static A201481Inst Instance=new A201481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201482
{
public static readonly long[] Value={ 3L,23L,83L,503L,983L,1283L,2003L,2423L,3923L,5783L,12503L,13523L,15683L,16823L,20483L,32003L,33623L,38723L,42323L,48023L,54083L,62723L,69623L,76883L,84503L,89783L,100823L,115523L,118583L,124823L,154883L,169283L,180503L,200003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201482Inst : IEnumerable<long>
{
public static readonly long[] Value=A201482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201482.Bytes);
public long this[int i]=>Value[i];

public static A201482Inst Instance=new A201482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201483
{
public static readonly long[] Value={ 409L,1129L,5449L,13009L,16249L,49009L,61609L,68449L,91129L,99409L,167449L,178609L,190129L,356449L,477409L,534649L,595129L,680809L,748849L,796009L,820129L,844609L,920209L,972409L,999049L,1225129L,1315849L,1378129L,1441849L,1607449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201483Inst : IEnumerable<long>
{
public static readonly long[] Value=A201483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201483.Bytes);
public long this[int i]=>Value[i];

public static A201483Inst Instance=new A201483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201484
{
public static readonly long[] Value={ 11L,131L,251L,1451L,1811L,4211L,6131L,12011L,14051L,15131L,36131L,41411L,45131L,47051L,53051L,57251L,80651L,93851L,102251L,132851L,142811L,163811L,171131L,174851L,206051L,210131L,231131L,271451L,285611L,315011L,335411L,383651L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201484Inst : IEnumerable<long>
{
public static readonly long[] Value=A201484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201484.Bytes);
public long this[int i]=>Value[i];

public static A201484Inst Instance=new A201484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201485
{
public static readonly long[] Value={ 7L,727L,1627L,2887L,4507L,11527L,21787L,30427L,40507L,52027L,103687L,112507L,121687L,162007L,172987L,273787L,288007L,302587L,348487L,468187L,648007L,669787L,737287L,784087L,832327L,959227L,1012507L,1180987L,1240027L,1393927L,1523527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201485Inst : IEnumerable<long>
{
public static readonly long[] Value=A201485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201485.Bytes);
public long this[int i]=>Value[i];

public static A201485Inst Instance=new A201485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201486
{
public static readonly long[] Value={ 13L,53L,613L,853L,1453L,2213L,4813L,6133L,10133L,16253L,19853L,22453L,23813L,37853L,41413L,61613L,63853L,75653L,102253L,114013L,117053L,136133L,146213L,153133L,178613L,186253L,198013L,222613L,253133L,285613L,315013L,320053L,325133L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201486Inst : IEnumerable<long>
{
public static readonly long[] Value=A201486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201486.Bytes);
public long this[int i]=>Value[i];

public static A201486Inst Instance=new A201486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201487
{
public static readonly long[] Value={ 29L,89L,509L,1289L,3389L,3929L,7229L,8009L,9689L,10589L,16829L,24509L,32009L,33629L,38729L,44189L,48029L,60509L,67289L,81929L,84509L,92489L,98009L,100829L,118589L,134489L,158429L,188189L,200009L,216329L,224729L,228989L,242009L,250889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201487Inst : IEnumerable<long>
{
public static readonly long[] Value=A201487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201487.Bytes);
public long this[int i]=>Value[i];

public static A201487Inst Instance=new A201487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201488
{
public static readonly long[] Value={ 8L,5L,3L,5L,5L,3L,3L,9L,0L,5L,9L,3L,2L,7L,3L,7L,6L,2L,2L,0L,0L,4L,2L,2L,1L,8L,1L,0L,5L,2L,4L,2L,4L,5L,1L,9L,6L,4L,2L,4L,1L,7L,9L,6L,8L,8L,4L,4L,2L,3L,7L,0L,1L,8L,2L,9L,4L,1L,6L,9L,9L,3L,4L,4L,9L,7L,6L,8L,3L,1L,1L,9L,6L,1L,5L,5L,2L,6L,7L,5L,9L,7L,1L,2L,5L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201488Inst : IEnumerable<long>
{
public static readonly long[] Value=A201488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201488.Bytes);
public long this[int i]=>Value[i];

public static A201488Inst Instance=new A201488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201489
{
public static readonly long[] Value={ 1L,29L,9331L,50432052L,4585552158911L,7383126698273869479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201489Inst : IEnumerable<long>
{
public static readonly long[] Value=A201489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201489.Bytes);
public long this[int i]=>Value[i];

public static A201489Inst Instance=new A201489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201490
{
public static readonly long[] Value={ 3L,29L,226L,1454L,7815L,36487L,151593L,571539L,1982705L,6399842L,19389074L,55531190L,151238480L,393631919L,983211316L,2365399764L,5498241469L,12382111994L,27080912704L,57644263473L,119645822176L,242563511707L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201490Inst : IEnumerable<long>
{
public static readonly long[] Value=A201490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201490.Bytes);
public long this[int i]=>Value[i];

public static A201490Inst Instance=new A201490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201491
{
public static readonly ulong[] Value={ 5L,226L,9331L,301432L,7798656L,168357815L,3127432827L,51118964623L,747555368709L,9907361072523L,120219907134113L,1346895312283777L,14030077787811997L,136685387878719346L,1251770455347161910L,10823892860244631974UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201491Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A201491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201491.Bytes);
public ulong this[int i]=>Value[i];

public static A201491Inst Instance=new A201491Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201492
{
public static readonly BigInteger[] Value={ 8L,1454L,301432L,50432052L,6697376240L,732383803600L,68110029402413L,5516712973977104L,396137884984421823L,BigInteger.Parse("25563298281912009949"),BigInteger.Parse("1498543207391775400633"),BigInteger.Parse("80501743778622446236710") };
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
public class A201492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201492Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201492.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201492.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201492Inst Instance=new A201492Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201493
{
public static readonly BigInteger[] Value={ 12L,7815L,7798656L,6697376240L,4585552158911L,2571822263246639L,1219998885223727883L,BigInteger.Parse("501770963443215883902"),BigInteger.Parse("182271590618268117246577"),BigInteger.Parse("59312881704712898493358018"),BigInteger.Parse("17484065266324835514539288191") };
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
public class A201493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201493Inst Instance=new A201493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201494
{
public static readonly long[] Value={ 18L,36487L,168357815L,732383803600L,2571822263246639L,7383126698273869479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201494Inst : IEnumerable<long>
{
public static readonly long[] Value=A201494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201494.Bytes);
public long this[int i]=>Value[i];

public static A201494Inst Instance=new A201494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201495
{
public static readonly long[] Value={ 24L,151593L,3127432827L,68110029402413L,1219998885223727883L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201495Inst : IEnumerable<long>
{
public static readonly long[] Value=A201495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201495.Bytes);
public long this[int i]=>Value[i];

public static A201495Inst Instance=new A201495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201496
{
public static readonly long[] Value={ 1L,3L,3L,5L,29L,5L,8L,226L,226L,8L,12L,1454L,9331L,1454L,12L,18L,7815L,301432L,301432L,7815L,18L,24L,36487L,7798656L,50432052L,7798656L,36487L,24L,33L,151593L,168357815L,6697376240L,6697376240L,168357815L,151593L,33L,43L,571539L,3127432827L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201496Inst : IEnumerable<long>
{
public static readonly long[] Value=A201496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201496.Bytes);
public long this[int i]=>Value[i];

public static A201496Inst Instance=new A201496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201497
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,43L,145L,538L,2194L,9790L,47491L,248706L,1396799L,8363711L,53121000L,356309314L,2514395528L,18606000547L,143956459002L,1161612656187L,9753494344997L,85044912003502L,768659919235828L,7189553986402426L,69486510911410279L,693003419860404514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201497Inst : IEnumerable<long>
{
public static readonly long[] Value=A201497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201497.Bytes);
public long this[int i]=>Value[i];

public static A201497Inst Instance=new A201497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201498
{
public static readonly long[] Value={ 4L,7L,15L,33L,63L,99L,147L,201L,311L,423L,543L,723L,843L,969L,1199L,1511L,1743L,1983L,2313L,2523L,2811L,3201L,3611L,4227L,4803L,5103L,5409L,5727L,6051L,7059L,8193L,8843L,9387L,10215L,11103L,11703L,12639L,13449L,14279L,15311L,16023L,17103L,18243L,18819L,19407L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201498Inst : IEnumerable<long>
{
public static readonly long[] Value=A201498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201498.Bytes);
public long this[int i]=>Value[i];

public static A201498Inst Instance=new A201498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201499
{
public static readonly long[] Value={ 2L,2L,6L,8L,40L,58L,338L,526L,3334L,5448L,36168L,61108L,417920L,723354L,5054148L,8908546L,63260780L,113093022L,813360930L,1470597342L,10685501398L,19499227828L,142885700222L,262754984020L,1939096937920L,3589093760726L,26647143177214L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201499Inst : IEnumerable<long>
{
public static readonly long[] Value=A201499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201499.Bytes);
public long this[int i]=>Value[i];

public static A201499Inst Instance=new A201499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201500
{
public static readonly long[] Value={ 2L,2L,6L,5L,12L,8L,20L,13L,30L,18L,42L,25L,56L,32L,72L,41L,90L,50L,110L,61L,132L,72L,156L,85L,182L,98L,210L,113L,240L,128L,272L,145L,306L,162L,342L,181L,380L,200L,420L,221L,462L,242L,506L,265L,552L,288L,600L,313L,650L,338L,702L,365L,756L,392L,812L,421L,870L,450L,930L,481L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201500Inst : IEnumerable<long>
{
public static readonly long[] Value=A201500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201500.Bytes);
public long this[int i]=>Value[i];

public static A201500Inst Instance=new A201500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201501
{
public static readonly long[] Value={ 2L,3L,12L,12L,40L,32L,98L,73L,204L,141L,380L,252L,650L,414L,1042L,649L,1590L,967L,2330L,1394L,3302L,1944L,4550L,2649L,6122L,3523L,8070L,4604L,10450L,5910L,13320L,7483L,16744L,9343L,20790L,11538L,25528L,14090L,31032L,17053L,37382L,20451L,44660L,24342L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201501Inst : IEnumerable<long>
{
public static readonly long[] Value=A201501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201501.Bytes);
public long this[int i]=>Value[i];

public static A201501Inst Instance=new A201501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201502
{
public static readonly long[] Value={ 2L,4L,20L,24L,98L,94L,338L,289L,936L,734L,2234L,1656L,4770L,3370L,9344L,6375L,17100L,11322L,29600L,19138L,48920L,30982L,77764L,48417L,119558L,73316L,178582L,108108L,260106L,155646L,370516L,219489L,517470L,303748L,710068L,413442L,959000L,554256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201502Inst : IEnumerable<long>
{
public static readonly long[] Value=A201502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201502.Bytes);
public long this[int i]=>Value[i];

public static A201502Inst Instance=new A201502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201503
{
public static readonly long[] Value={ 2L,1L,1L,2L,2L,2L,1L,2L,2L,1L,2L,3L,6L,3L,2L,1L,3L,5L,5L,3L,1L,2L,4L,12L,8L,12L,4L,2L,1L,4L,8L,12L,12L,8L,4L,1L,2L,5L,20L,18L,40L,18L,20L,5L,2L,1L,5L,13L,24L,32L,32L,24L,13L,5L,1L,2L,6L,30L,33L,98L,58L,98L,33L,30L,6L,2L,1L,6L,18L,43L,73L,94L,94L,73L,43L,18L,6L,1L,2L,7L,42L,55L,204L,151L,338L,151L,204L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201503Inst : IEnumerable<long>
{
public static readonly long[] Value=A201503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201503.Bytes);
public long this[int i]=>Value[i];

public static A201503Inst Instance=new A201503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201504
{
public static readonly long[] Value={ 4L,7L,9L,4L,2L,5L,5L,3L,8L,6L,0L,4L,2L,0L,3L,0L,0L,0L,2L,7L,3L,2L,8L,7L,9L,3L,5L,2L,1L,5L,5L,7L,1L,3L,8L,8L,0L,8L,1L,8L,0L,3L,3L,6L,7L,9L,4L,0L,6L,0L,0L,6L,7L,5L,1L,8L,8L,6L,1L,6L,6L,1L,3L,1L,2L,5L,5L,3L,5L,0L,0L,0L,2L,8L,7L,8L,1L,4L,8L,3L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201504Inst : IEnumerable<long>
{
public static readonly long[] Value=A201504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201504.Bytes);
public long this[int i]=>Value[i];

public static A201504Inst Instance=new A201504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201505
{
public static readonly long[] Value={ 8L,7L,7L,5L,8L,2L,5L,6L,1L,8L,9L,0L,3L,7L,2L,7L,1L,6L,1L,1L,6L,2L,8L,1L,5L,8L,2L,6L,0L,3L,8L,2L,9L,6L,5L,1L,9L,9L,1L,6L,4L,5L,1L,9L,7L,1L,0L,9L,7L,4L,4L,0L,5L,2L,9L,9L,7L,6L,1L,0L,8L,6L,8L,3L,1L,5L,9L,5L,0L,7L,6L,3L,2L,7L,4L,2L,1L,3L,9L,4L,7L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201505Inst : IEnumerable<long>
{
public static readonly long[] Value=A201505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201505.Bytes);
public long this[int i]=>Value[i];

public static A201505Inst Instance=new A201505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201506
{
public static readonly long[] Value={ 1L,0L,5L,7L,4L,7L,3L,5L,5L,3L,7L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201506Inst : IEnumerable<long>
{
public static readonly long[] Value=A201506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201506.Bytes);
public long this[int i]=>Value[i];

public static A201506Inst Instance=new A201506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201507
{
public static readonly long[] Value={ 0L,0L,0L,20L,12798L,763144L,15516804L,170842828L,1264750240L,7084450248L,32251861624L,125030824732L,426265242412L,1308045124808L,3675893768908L,9586626461484L,23445303141400L,54219244028296L,119372323892736L,251614892723068L,510130577706724L,998740710435208L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201507Inst : IEnumerable<long>
{
public static readonly long[] Value=A201507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201507.Bytes);
public long this[int i]=>Value[i];

public static A201507Inst Instance=new A201507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201508
{
public static readonly long[] Value={ 0L,0L,0L,2L,7157L,1143638L,44031035L,771464278L,8219304992L,62114308624L,364798895986L,1765597908290L,7329246973785L,26849172347850L,88645482921449L,268042562131202L,751635857876290L,1974215715426992L,4896315981217168L,11542835604897814L,26008912447737323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201508Inst : IEnumerable<long>
{
public static readonly long[] Value=A201508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201508.Bytes);
public long this[int i]=>Value[i];

public static A201508Inst Instance=new A201508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201509
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,5L,1L,8L,12L,4L,16L,28L,13L,1L,32L,64L,38L,6L,64L,144L,104L,25L,1L,128L,320L,272L,88L,8L,256L,704L,688L,280L,41L,1L,512L,1536L,1696L,832L,170L,10L,1024L,3328L,4096L,2352L,620L,61L,1L,2048L,7168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201509Inst : IEnumerable<long>
{
public static readonly long[] Value=A201509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201509.Bytes);
public long this[int i]=>Value[i];

public static A201509Inst Instance=new A201509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201510
{
public static readonly long[] Value={ 0L,0L,0L,0L,2578L,1247116L,97284860L,2817340064L,44218721793L,457851259868L,3506596268191L,21355746900992L,108582220087480L,477032549147428L,1857084405493128L,6529640029479296L,21044674478336823L,62903854631232636L,176034055470126073L,464793685059669728L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201510Inst : IEnumerable<long>
{
public static readonly long[] Value=A201510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201510.Bytes);
public long this[int i]=>Value[i];

public static A201510Inst Instance=new A201510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201511
{
public static readonly BigInteger[] Value={ 1L,2L,22L,405L,10741L,368868L,15516804L,771464278L,44218721793L,2868879752822L,207739939478618L,16602826428818482L,1451305771147909684L,BigInteger.Parse("137715836041691050398"),BigInteger.Parse("14096224186664736126206"),BigInteger.Parse("1547966111897855935957132"),BigInteger.Parse("181519663430661533452513680"),BigInteger.Parse("22636566614411901986006002896") };
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
public class A201511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201511Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201511.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201511.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201511Inst Instance=new A201511Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201512
{
public static readonly long[] Value={ 5L,6L,8L,9L,10L,11L,13L,14L,16L,17L,19L,20L,21L,22L,23L,24L,27L,28L,29L,30L,32L,33L,34L,35L,37L,38L,39L,40L,42L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201512Inst : IEnumerable<long>
{
public static readonly long[] Value=A201512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201512.Bytes);
public long this[int i]=>Value[i];

public static A201512Inst Instance=new A201512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201513
{
public static readonly BigInteger[] Value={ 1L,1L,0L,8L,79L,1974L,62266L,2484382L,119138166L,6655170642L,423677826986L,30242576462856L,2390359529372724L,207127434998494421L,BigInteger.Parse("19516867860507198208"),BigInteger.Parse("1986288643031862123264"),BigInteger.Parse("217094567491104327256049"),BigInteger.Parse("25357029929230564723578520"),BigInteger.Parse("3151672341378566296926684684") };
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
public class A201513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201513Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201513.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201513.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201513Inst Instance=new A201513Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201514
{
public static readonly long[] Value={ 6L,10L,14L,15L,21L,22L,26L,33L,34L,35L,38L,39L,46L,51L,55L,57L,58L,62L,65L,69L,77L,82L,87L,91L,93L,95L,106L,119L,122L,123L,133L,155L,159L,161L,183L,187L,202L,203L,213L,265L,287L,299L,319L,355L,453L,497L,505L,583L,671L,1057L,1313L,1963L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201514Inst : IEnumerable<long>
{
public static readonly long[] Value=A201514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201514.Bytes);
public long this[int i]=>Value[i];

public static A201514Inst Instance=new A201514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201515
{
public static readonly long[] Value={ 9L,5L,3L,5L,3L,9L,0L,9L,7L,5L,4L,9L,9L,1L,4L,6L,8L,9L,6L,6L,7L,2L,7L,0L,6L,9L,5L,3L,7L,2L,3L,7L,8L,2L,2L,7L,4L,3L,3L,6L,0L,9L,6L,5L,6L,0L,5L,1L,5L,1L,6L,0L,6L,8L,0L,6L,9L,6L,9L,6L,0L,1L,9L,7L,9L,7L,3L,5L,6L,7L,6L,1L,0L,2L,2L,9L,8L,0L,9L,1L,3L,6L,4L,7L,8L,7L,6L,9L,4L,7L,8L,2L,7L,9L,5L,7L,4L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201515Inst : IEnumerable<long>
{
public static readonly long[] Value=A201515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201515.Bytes);
public long this[int i]=>Value[i];

public static A201515Inst Instance=new A201515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201516
{
public static readonly long[] Value={ 1L,3L,4L,1L,4L,3L,0L,1L,6L,6L,2L,9L,1L,2L,5L,9L,7L,6L,4L,5L,7L,6L,0L,8L,0L,5L,0L,6L,7L,6L,3L,6L,1L,4L,1L,7L,1L,7L,7L,1L,4L,0L,8L,2L,9L,1L,7L,9L,4L,8L,3L,0L,1L,1L,3L,0L,7L,5L,1L,6L,4L,3L,7L,7L,1L,8L,0L,4L,9L,8L,8L,2L,4L,9L,6L,7L,8L,0L,0L,0L,6L,9L,8L,5L,4L,2L,0L,4L,6L,3L,0L,5L,8L,6L,0L,2L,4L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201516Inst : IEnumerable<long>
{
public static readonly long[] Value=A201516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201516.Bytes);
public long this[int i]=>Value[i];

public static A201516Inst Instance=new A201516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201517
{
public static readonly long[] Value={ 7L,7L,4L,4L,2L,7L,2L,5L,7L,0L,7L,9L,8L,9L,3L,6L,2L,3L,2L,5L,7L,0L,2L,9L,0L,0L,9L,0L,0L,0L,6L,2L,4L,5L,6L,3L,9L,8L,5L,9L,1L,3L,6L,7L,7L,8L,3L,5L,0L,7L,9L,2L,6L,8L,7L,8L,4L,2L,5L,9L,1L,6L,0L,5L,0L,5L,9L,2L,7L,3L,0L,3L,6L,8L,2L,5L,8L,1L,2L,4L,6L,4L,8L,7L,2L,7L,2L,4L,4L,6L,5L,7L,4L,2L,9L,1L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201517Inst : IEnumerable<long>
{
public static readonly long[] Value=A201517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201517.Bytes);
public long this[int i]=>Value[i];

public static A201517Inst Instance=new A201517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201518
{
public static readonly long[] Value={ 1L,4L,3L,1L,3L,6L,3L,5L,5L,0L,0L,6L,9L,0L,3L,9L,1L,3L,5L,7L,6L,4L,0L,4L,4L,9L,9L,3L,7L,8L,2L,7L,5L,4L,2L,1L,3L,0L,4L,1L,2L,3L,9L,5L,6L,8L,1L,7L,9L,9L,6L,4L,5L,3L,6L,5L,1L,5L,2L,4L,6L,6L,6L,2L,8L,0L,3L,0L,0L,3L,3L,6L,4L,7L,5L,9L,5L,6L,4L,3L,9L,0L,3L,8L,9L,5L,2L,1L,6L,2L,8L,8L,2L,5L,4L,7L,9L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201518Inst : IEnumerable<long>
{
public static readonly long[] Value=A201518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201518.Bytes);
public long this[int i]=>Value[i];

public static A201518Inst Instance=new A201518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201519
{
public static readonly long[] Value={ 6L,7L,5L,4L,8L,2L,9L,0L,8L,1L,1L,3L,7L,2L,4L,2L,2L,8L,0L,1L,5L,1L,7L,8L,8L,5L,8L,1L,9L,0L,8L,2L,7L,3L,1L,5L,9L,4L,1L,0L,7L,4L,0L,1L,2L,5L,4L,4L,0L,8L,8L,0L,7L,9L,6L,4L,4L,8L,5L,0L,8L,0L,4L,5L,2L,7L,2L,3L,7L,1L,5L,8L,0L,3L,2L,5L,1L,7L,3L,9L,1L,3L,5L,7L,5L,5L,1L,1L,7L,5L,3L,3L,0L,3L,5L,5L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201519Inst : IEnumerable<long>
{
public static readonly long[] Value=A201519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201519.Bytes);
public long this[int i]=>Value[i];

public static A201519Inst Instance=new A201519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201520
{
public static readonly long[] Value={ 1L,4L,6L,8L,3L,7L,4L,2L,9L,2L,0L,3L,3L,2L,8L,2L,9L,3L,7L,6L,5L,5L,4L,6L,8L,7L,8L,1L,5L,8L,0L,5L,4L,6L,6L,9L,4L,6L,9L,2L,0L,5L,9L,7L,4L,2L,8L,6L,1L,4L,1L,7L,5L,6L,0L,3L,2L,9L,3L,8L,4L,9L,7L,7L,5L,5L,7L,5L,6L,9L,6L,9L,3L,6L,9L,2L,3L,4L,0L,7L,1L,4L,5L,9L,7L,9L,0L,3L,1L,1L,3L,5L,3L,2L,8L,4L,7L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201520Inst : IEnumerable<long>
{
public static readonly long[] Value=A201520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201520.Bytes);
public long this[int i]=>Value[i];

public static A201520Inst Instance=new A201520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201521
{
public static readonly long[] Value={ 6L,0L,8L,0L,5L,4L,4L,7L,7L,9L,9L,7L,9L,1L,3L,0L,5L,3L,3L,2L,7L,9L,9L,5L,7L,2L,2L,5L,1L,0L,8L,9L,7L,6L,1L,7L,8L,8L,5L,3L,2L,9L,6L,8L,8L,0L,9L,3L,5L,3L,6L,0L,8L,7L,7L,7L,4L,5L,4L,0L,5L,6L,5L,6L,6L,4L,3L,4L,7L,5L,2L,1L,6L,4L,7L,2L,0L,8L,0L,8L,5L,1L,2L,1L,0L,0L,0L,3L,6L,7L,9L,4L,8L,7L,2L,9L,3L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201521Inst : IEnumerable<long>
{
public static readonly long[] Value=A201521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201521.Bytes);
public long this[int i]=>Value[i];

public static A201521Inst Instance=new A201521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201522
{
public static readonly long[] Value={ 1L,4L,8L,9L,4L,8L,0L,6L,5L,6L,7L,3L,1L,8L,3L,3L,3L,2L,0L,3L,9L,9L,1L,2L,6L,0L,1L,7L,6L,7L,7L,3L,1L,7L,5L,4L,4L,9L,4L,3L,3L,6L,9L,1L,4L,8L,0L,6L,1L,5L,0L,7L,0L,4L,7L,3L,0L,5L,6L,8L,8L,5L,1L,9L,2L,7L,5L,0L,4L,5L,7L,7L,5L,1L,2L,6L,7L,8L,1L,6L,2L,9L,7L,4L,3L,0L,6L,2L,3L,7L,3L,9L,0L,3L,5L,3L,3L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201522Inst : IEnumerable<long>
{
public static readonly long[] Value=A201522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201522.Bytes);
public long this[int i]=>Value[i];

public static A201522Inst Instance=new A201522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201523
{
public static readonly long[] Value={ 5L,5L,7L,8L,9L,5L,1L,7L,5L,7L,7L,9L,0L,3L,5L,2L,9L,9L,8L,3L,2L,8L,6L,9L,7L,3L,6L,3L,1L,3L,8L,7L,3L,7L,9L,8L,3L,9L,2L,7L,5L,7L,3L,9L,8L,4L,7L,4L,4L,1L,5L,3L,6L,3L,8L,0L,6L,8L,1L,1L,8L,6L,2L,6L,2L,0L,8L,9L,0L,3L,8L,8L,6L,4L,1L,1L,8L,6L,4L,3L,1L,4L,9L,8L,1L,9L,8L,7L,9L,0L,5L,1L,2L,7L,0L,9L,2L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201523Inst : IEnumerable<long>
{
public static readonly long[] Value=A201523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201523.Bytes);
public long this[int i]=>Value[i];

public static A201523Inst Instance=new A201523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201524
{
public static readonly long[] Value={ 1L,5L,0L,3L,2L,6L,2L,1L,5L,2L,1L,3L,1L,4L,9L,3L,0L,9L,9L,9L,1L,9L,0L,7L,9L,9L,0L,7L,5L,2L,0L,0L,8L,3L,0L,8L,2L,9L,0L,8L,3L,4L,3L,1L,7L,1L,5L,6L,2L,7L,8L,2L,9L,3L,8L,3L,2L,1L,0L,3L,3L,2L,1L,4L,8L,8L,7L,2L,7L,4L,9L,7L,2L,3L,3L,7L,5L,1L,4L,2L,4L,9L,8L,0L,0L,9L,9L,4L,8L,7L,2L,9L,9L,6L,6L,2L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201524Inst : IEnumerable<long>
{
public static readonly long[] Value=A201524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201524.Bytes);
public long this[int i]=>Value[i];

public static A201524Inst Instance=new A201524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201525
{
public static readonly long[] Value={ 5L,1L,8L,5L,7L,7L,0L,0L,2L,2L,0L,1L,7L,1L,1L,4L,5L,8L,2L,5L,3L,1L,0L,9L,8L,2L,0L,4L,1L,7L,2L,4L,4L,9L,9L,4L,8L,3L,1L,0L,4L,3L,3L,3L,7L,0L,3L,4L,8L,6L,2L,9L,7L,2L,7L,1L,9L,3L,3L,8L,9L,8L,0L,8L,1L,5L,4L,5L,0L,6L,9L,7L,3L,1L,1L,0L,2L,9L,7L,7L,7L,1L,8L,4L,3L,4L,8L,1L,3L,2L,6L,4L,1L,2L,8L,0L,7L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201525Inst : IEnumerable<long>
{
public static readonly long[] Value=A201525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201525.Bytes);
public long this[int i]=>Value[i];

public static A201525Inst Instance=new A201525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201526
{
public static readonly long[] Value={ 1L,5L,1L,3L,0L,0L,5L,7L,3L,7L,4L,4L,7L,7L,4L,9L,0L,9L,7L,7L,7L,4L,6L,9L,3L,0L,5L,4L,0L,1L,2L,0L,7L,0L,4L,4L,6L,0L,1L,9L,5L,5L,8L,8L,8L,6L,9L,4L,3L,2L,2L,3L,4L,2L,0L,4L,7L,3L,9L,1L,8L,7L,6L,1L,2L,1L,5L,8L,8L,2L,8L,9L,4L,5L,6L,1L,0L,7L,7L,4L,1L,4L,7L,8L,7L,3L,8L,0L,0L,8L,6L,2L,7L,8L,8L,7L,6L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201526Inst : IEnumerable<long>
{
public static readonly long[] Value=A201526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201526.Bytes);
public long this[int i]=>Value[i];

public static A201526Inst Instance=new A201526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201527
{
public static readonly long[] Value={ 4L,8L,6L,6L,3L,6L,5L,1L,3L,4L,4L,2L,8L,2L,8L,7L,9L,6L,4L,1L,5L,0L,1L,0L,6L,8L,8L,8L,7L,7L,4L,0L,5L,3L,0L,6L,1L,5L,3L,8L,3L,1L,1L,0L,2L,8L,3L,9L,7L,3L,3L,6L,9L,2L,6L,7L,4L,2L,5L,4L,7L,1L,3L,2L,8L,8L,0L,9L,9L,8L,8L,9L,2L,5L,7L,8L,6L,4L,7L,1L,9L,3L,7L,2L,7L,8L,9L,1L,4L,0L,6L,4L,1L,4L,5L,6L,3L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201527Inst : IEnumerable<long>
{
public static readonly long[] Value=A201527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201527.Bytes);
public long this[int i]=>Value[i];

public static A201527Inst Instance=new A201527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201528
{
public static readonly long[] Value={ 1L,5L,2L,0L,2L,7L,2L,4L,7L,6L,5L,0L,6L,1L,5L,0L,3L,4L,5L,9L,5L,9L,8L,4L,3L,5L,7L,6L,7L,9L,4L,3L,8L,3L,0L,6L,3L,0L,4L,2L,1L,6L,3L,8L,0L,6L,1L,0L,2L,5L,7L,5L,3L,9L,3L,3L,2L,7L,0L,7L,3L,2L,6L,4L,6L,0L,7L,6L,8L,0L,7L,7L,6L,2L,1L,2L,1L,3L,7L,2L,4L,4L,6L,1L,0L,5L,4L,5L,3L,5L,0L,0L,9L,2L,6L,7L,1L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201528Inst : IEnumerable<long>
{
public static readonly long[] Value=A201528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201528.Bytes);
public long this[int i]=>Value[i];

public static A201528Inst Instance=new A201528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201529
{
public static readonly long[] Value={ 4L,6L,0L,0L,0L,0L,6L,9L,8L,5L,7L,9L,4L,9L,0L,4L,2L,1L,6L,9L,6L,9L,3L,4L,9L,8L,3L,3L,8L,4L,4L,4L,6L,0L,9L,3L,8L,6L,3L,4L,3L,9L,0L,7L,3L,2L,8L,5L,4L,0L,9L,6L,9L,3L,7L,4L,6L,5L,6L,6L,4L,6L,5L,1L,7L,3L,7L,8L,8L,3L,8L,8L,1L,3L,6L,5L,3L,4L,4L,0L,4L,1L,1L,9L,1L,8L,0L,5L,1L,8L,6L,4L,6L,1L,1L,5L,4L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201529Inst : IEnumerable<long>
{
public static readonly long[] Value=A201529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201529.Bytes);
public long this[int i]=>Value[i];

public static A201529Inst Instance=new A201529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201530
{
public static readonly long[] Value={ 1L,5L,2L,5L,9L,0L,5L,7L,7L,1L,4L,1L,0L,5L,6L,6L,1L,4L,5L,4L,2L,9L,2L,6L,6L,2L,0L,6L,9L,5L,0L,6L,6L,9L,7L,5L,3L,1L,8L,6L,9L,3L,5L,1L,7L,0L,0L,5L,3L,9L,8L,0L,6L,7L,9L,9L,2L,9L,5L,0L,3L,0L,4L,6L,8L,3L,6L,6L,5L,7L,8L,0L,1L,2L,2L,6L,5L,6L,9L,5L,6L,2L,7L,3L,8L,9L,6L,2L,2L,4L,2L,2L,9L,3L,4L,5L,3L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201530Inst : IEnumerable<long>
{
public static readonly long[] Value=A201530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201530.Bytes);
public long this[int i]=>Value[i];

public static A201530Inst Instance=new A201530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201531
{
public static readonly long[] Value={ 1L,4L,2L,9L,1L,8L,2L,7L,3L,2L,5L,9L,7L,0L,1L,8L,3L,6L,7L,8L,2L,0L,2L,8L,8L,4L,2L,1L,5L,7L,3L,7L,9L,3L,6L,7L,4L,4L,7L,8L,9L,8L,1L,0L,4L,4L,9L,0L,6L,9L,1L,5L,7L,0L,5L,8L,8L,2L,4L,0L,5L,5L,3L,2L,6L,6L,7L,4L,1L,7L,8L,6L,3L,0L,7L,4L,4L,3L,1L,6L,8L,3L,5L,3L,2L,4L,0L,7L,4L,8L,1L,0L,3L,5L,6L,5L,8L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201531Inst : IEnumerable<long>
{
public static readonly long[] Value=A201531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201531.Bytes);
public long this[int i]=>Value[i];

public static A201531Inst Instance=new A201531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201532
{
public static readonly long[] Value={ 0L,9L,111L,7799L,2446147L,3762507339L,28456420346436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201532Inst : IEnumerable<long>
{
public static readonly long[] Value=A201532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201532.Bytes);
public long this[int i]=>Value[i];

public static A201532Inst Instance=new A201532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201533
{
public static readonly long[] Value={ 3L,9L,25L,69L,175L,410L,899L,1859L,3649L,6840L,12311L,21378L,35964L,58819L,93800L,146222L,223292L,334639L,492954L,714755L,1021293L,1439616L,2003809L,2756429L,3750155L,5049674L,6733825L,8898024L,11656994L,15147825L,19533390L,25006144L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201533Inst : IEnumerable<long>
{
public static readonly long[] Value=A201533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201533.Bytes);
public long this[int i]=>Value[i];

public static A201533Inst Instance=new A201533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201534
{
public static readonly long[] Value={ 3L,25L,111L,633L,3354L,16393L,72811L,293831L,1087857L,3735546L,12012530L,36466979L,105202136L,289996482L,767360174L,1956720113L,4824093641L,11531663892L,26793101230L,60636948110L,133921364986L,289121431541L,611037886807L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201534Inst : IEnumerable<long>
{
public static readonly long[] Value=A201534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201534.Bytes);
public long this[int i]=>Value[i];

public static A201534Inst Instance=new A201534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201535
{
public static readonly long[] Value={ 6L,69L,633L,7799L,91425L,983981L,9526987L,82847704L,652848538L,4712696751L,31480011434L,196280028176L,1150650039753L,6380377582098L,33631853768986L,169225758487160L,815686475352515L,3777731764480697L,16854911299206527L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201535Inst : IEnumerable<long>
{
public static readonly long[] Value=A201535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201535.Bytes);
public long this[int i]=>Value[i];

public static A201535Inst Instance=new A201535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201536
{
public static readonly BigInteger[] Value={ 9L,175L,3354L,91425L,2446147L,61807736L,1408677515L,28646055184L,523398227137L,8686880778087L,132361720458239L,1868645862989467L,24631940812325029L,305098771555173655L,3569810381726216867L,BigInteger.Parse("39630824798203404663") };
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
public class A201536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201536Inst Instance=new A201536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201537
{
public static readonly BigInteger[] Value={ 13L,410L,16393L,983981L,61807736L,3762507339L,208164634003L,10298954399450L,457194210355549L,18377434753379050L,675525914078702215L,BigInteger.Parse("22913890806174601101"),BigInteger.Parse("722808878339707158532"),BigInteger.Parse("21342091118575178714919") };
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
public class A201537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201537Inst Instance=new A201537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201538
{
public static readonly BigInteger[] Value={ 18L,899L,72811L,9526987L,1408677515L,208164634003L,28456420346436L,3505159734744220L,387870239576486118L,BigInteger.Parse("38812326822498760643"),BigInteger.Parse("3543738686502556683539"),BigInteger.Parse("297838575975499416278867") };
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
public class A201538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201538Inst Instance=new A201538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201539
{
public static readonly long[] Value={ 0L,3L,3L,3L,9L,3L,6L,25L,25L,6L,9L,69L,111L,69L,9L,13L,175L,633L,633L,175L,13L,18L,410L,3354L,7799L,3354L,410L,18L,24L,899L,16393L,91425L,91425L,16393L,899L,24L,31L,1859L,72811L,983981L,2446147L,983981L,72811L,1859L,31L,39L,3649L,293831L,9526987L,61807736L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201539Inst : IEnumerable<long>
{
public static readonly long[] Value=A201539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201539.Bytes);
public long this[int i]=>Value[i];

public static A201539Inst Instance=new A201539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201540
{
public static readonly BigInteger[] Value={ 1L,6L,36L,412L,9386L,257318L,8891854L,379978716L,19206532478L,1120204619108L,74113608972922L,5483225594409823L,448414229054798028L,BigInteger.Parse("40154319792412218900") };
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
public class A201540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201540Inst Instance=new A201540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201541
{
public static readonly long[] Value={ 0L,1L,2L,3L,8L,11L,12L,16L,22L,23L,38L,43L,47L,51L,53L,67L,68L,71L,73L,87L,88L,102L,106L,107L,108L,123L,141L,143L,156L,162L,166L,173L,177L,178L,186L,192L,198L,212L,221L,227L,232L,233L,247L,271L,277L,282L,288L,296L,298L,318L,326L,327L,333L,337L,346L,351L,352L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201541Inst : IEnumerable<long>
{
public static readonly long[] Value=A201541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201541.Bytes);
public long this[int i]=>Value[i];

public static A201541Inst Instance=new A201541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201542
{
public static readonly long[] Value={ 2L,2L,4L,6L,11L,18L,31L,54L,96L,171L,309L,562L,1029L,1896L,3514L,6545L,12247L,23005L,43371L,82029L,155598L,295927L,564164L,1077892L,2063545L,3957761L,7603593L,14630713L,28192867L,54399529L,105097590L,203280493L,393614506L,762937782L,1480207843L,2874399615L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201542Inst : IEnumerable<long>
{
public static readonly long[] Value=A201542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201542.Bytes);
public long this[int i]=>Value[i];

public static A201542Inst Instance=new A201542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201543
{
public static readonly long[] Value={ 1L,2L,3L,4L,7L,6L,5L,8L,9L,12L,11L,14L,16L,21L,10L,22L,13L,24L,15L,26L,19L,31L,18L,32L,20L,23L,25L,29L,30L,28L,33L,34L,38L,40L,17L,36L,42L,27L,35L,44L,37L,48L,39L,50L,46L,41L,43L,47L,49L,51L,52L,56L,58L,60L,45L,53L,62L,55L,66L,57L,68L,61L,65L,67L,71L,54L,70L,64L,75L,74L,76L,80L,59L,72L,84L,63L,77L,86L,69L,81L,73L,90L,78L,94L,82L,79L,96L,88L,83L,85L,89L,93L,92L,98L,102L,91L,104L,101L,106L,111L,112L,114L,116L,121L,122L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201543Inst : IEnumerable<long>
{
public static readonly long[] Value=A201543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201543.Bytes);
public long this[int i]=>Value[i];

public static A201543Inst Instance=new A201543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201544
{
public static readonly long[] Value={ 3L,9L,11L,17L,19L,27L,33L,41L,43L,51L,57L,59L,67L,73L,75L,81L,83L,89L,97L,99L,107L,113L,121L,123L,129L,131L,137L,139L,147L,153L,163L,171L,177L,179L,187L,193L,201L,209L,211L,219L,225L,227L,233L,241L,243L,249L,251L,257L,267L,275L,281L,283L,289L,291L,297L,307L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201544Inst : IEnumerable<long>
{
public static readonly long[] Value=A201544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201544.Bytes);
public long this[int i]=>Value[i];

public static A201544Inst Instance=new A201544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201545
{
public static readonly long[] Value={ 47L,281L,381L,399L,515L,648L,918L,928L,1303L,1538L,3746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201545Inst : IEnumerable<long>
{
public static readonly long[] Value=A201545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201545.Bytes);
public long this[int i]=>Value[i];

public static A201545Inst Instance=new A201545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201546
{
public static readonly BigInteger[] Value={ 1L,14L,444L,25584L,2342880L,312888960L,57424792320L,13869128448000L,4264876094976000L,1627055289796608000L,BigInteger.Parse("754132445894209536000"),BigInteger.Parse("417405110861381271552000"),BigInteger.Parse("271933770461631065948160000"),BigInteger.Parse("205985221930119691492392960000"),BigInteger.Parse("179512031423815845458883379200000") };
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
public class A201546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201546Inst Instance=new A201546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201547
{
public static readonly long[] Value={ 0L,0L,0L,0L,250L,480916L,54916456L,1962132800L,34690541994L,385983794500L,3095143575007L,19437996015280L,100963195651565L,450398154002132L,1773257833600750L,6288010190509312L,20398342362118678L,61282868654684052L,172190699515632837L,456120623076014000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201547Inst : IEnumerable<long>
{
public static readonly long[] Value=A201547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201547.Bytes);
public long this[int i]=>Value[i];

public static A201547Inst Instance=new A201547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201548
{
public static readonly ulong[] Value={ 0L,0L,0L,0L,10L,308574L,81442802L,5296005568L,146127335256L,2309813476870L,24738873315596L,198759048859008L,1279605298916568L,6906427308782106L,32277449304595350L,133788325435448576L,500896430870051174L,1718268150463137018L,5462521782760829320L,16243031089247644800UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201548Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A201548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201548.Bytes);
public ulong this[int i]=>Value[i];

public static A201548Inst Instance=new A201548Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201549
{
public static readonly long[] Value={ 1L,11L,91L,891L,8801L,88913L,908755L,9377467L,97464799L,1018872811L,10701243741L,112835748609L,1193692544825L,12663809507129L,134678108144591L,1435345208419771L,15326122342137035L,163920458145421109L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201549Inst : IEnumerable<long>
{
public static readonly long[] Value=A201549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201549.Bytes);
public long this[int i]=>Value[i];

public static A201549Inst Instance=new A201549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201550
{
public static readonly long[] Value={ 1L,13L,127L,1469L,17151L,204763L,2473325L,30162301L,370487485L,4577127763L,56813989827L,707972099627L,8851373201919L,110976634957761L,1394804756117877L,17567994350713469L,221690794842728445L,2802194053806820153L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201550Inst : IEnumerable<long>
{
public static readonly long[] Value=A201550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201550.Bytes);
public long this[int i]=>Value[i];

public static A201550Inst Instance=new A201550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201551
{
public static readonly long[] Value={ 1L,15L,169L,2255L,30381L,418503L,5832765L,82073295L,1163205475L,16581420835L,237481736823L,3414582082055L,49258226347903L,712601187601395L,10334165623697259L,150186639579545295L,2186774434431445455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201551Inst : IEnumerable<long>
{
public static readonly long[] Value=A201551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201551.Bytes);
public long this[int i]=>Value[i];

public static A201551Inst Instance=new A201551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201552
{
public static readonly long[] Value={ 1L,1L,3L,1L,5L,7L,1L,7L,19L,19L,1L,9L,37L,85L,51L,1L,11L,61L,231L,381L,141L,1L,13L,91L,489L,1451L,1751L,393L,1L,15L,127L,891L,3951L,9331L,8135L,1107L,1L,17L,169L,1469L,8801L,32661L,60691L,38165L,3139L,1L,19L,217L,2255L,17151L,88913L,273127L,398567L,180325L,8953L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201552Inst : IEnumerable<long>
{
public static readonly long[] Value=A201552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201552.Bytes);
public long this[int i]=>Value[i];

public static A201552Inst Instance=new A201552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201553
{
public static readonly long[] Value={ 141L,1751L,9331L,32661L,88913L,204763L,418503L,782153L,1363573L,2248575L,3543035L,5375005L,7896825L,11287235L,15753487L,21533457L,28897757L,38151847L,49638147L,63738149L,80874529L,101513259L,126165719L,155390809L,189797061L,230044751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201553Inst : IEnumerable<long>
{
public static readonly long[] Value=A201553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201553.Bytes);
public long this[int i]=>Value[i];

public static A201553Inst Instance=new A201553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201554
{
public static readonly long[] Value={ 393L,8135L,60691L,273127L,908755L,2473325L,5832765L,12354469L,24072133L,43874139L,75715487L,124853275L,198105727L,304134769L,453752153L,660249129L,939749665L,1311587215L,1798705035L,2428080047L,3231170251L,4244385685L,5509582933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A201554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201554Inst : IEnumerable<long>
{
public static readonly long[] Value=A201554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A201554.Bytes);
public long this[int i]=>Value[i];

public static A201554Inst Instance=new A201554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201555
{
public static readonly BigInteger[] Value={ 1L,2L,70L,48620L,601080390L,126410606437752L,BigInteger.Parse("442512540276836779204"),BigInteger.Parse("25477612258980856902730428600"),BigInteger.Parse("23951146041928082866135587776380551750"),BigInteger.Parse("365907784099042279561985786395502921046971688680"),BigInteger.Parse("90548514656103281165404177077484163874504589675413336841320") };
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
public class A201555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201555Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201555.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201555.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201555Inst Instance=new A201555Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A201556
{
public static readonly BigInteger[] Value={ 1L,2L,37L,16278L,150303194L,25282422428664L,BigInteger.Parse("73752140616074524401"),BigInteger.Parse("3639659041645240391812731402"),BigInteger.Parse("2993893262520330875797362908273443346"),BigInteger.Parse("40656420461436928818704580402413441308206341488"),BigInteger.Parse("9054851465691640957562090101797213977192016103053025996396") };
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
public class A201556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A201556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A201556Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A201556.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A201556.Bytes);
public BigInteger this[int i]=>Value[i];

public static A201556Inst Instance=new A201556Inst();

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