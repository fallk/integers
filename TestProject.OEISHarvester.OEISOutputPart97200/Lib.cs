using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A116841
{
public static readonly long[] Value={ 1L,2L,6L,21L,75L,258L,842L,2614L,7787L,22466L,63273L,175044L,477897L,1291997L,3467411L,9254394L,24595834L,65158141L,172181087L,454099591L,1195773446L,3144999057L,8263735626L,21697177681L,56933687000L,149323655848L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116841Inst : IEnumerable<long>
{
public static readonly long[] Value=A116841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116841.Bytes);
public long this[int i]=>Value[i];

public static A116841Inst Instance=new A116841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116842
{
public static readonly long[] Value={ 1L,2L,6L,21L,69L,181L,375L,651L,1009L,1449L,1971L,2575L,3261L,4029L,4879L,5811L,6825L,7921L,9099L,10359L,11701L,13125L,14631L,16219L,17889L,19641L,21475L,23391L,25389L,27469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116842Inst : IEnumerable<long>
{
public static readonly long[] Value=A116842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116842.Bytes);
public long this[int i]=>Value[i];

public static A116842Inst Instance=new A116842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116843
{
public static readonly long[] Value={ 1L,2L,6L,21L,73L,241L,759L,2305L,6806L,19652L,55725L,155688L,429719L,1174344L,3183298L,8571979L,22958381L,61220351L,162668347L,430978487L,1139179386L,3005433282L,7916965441L,20829348046L,54747238203L,143781463846L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116843Inst : IEnumerable<long>
{
public static readonly long[] Value=A116843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116843.Bytes);
public long this[int i]=>Value[i];

public static A116843Inst Instance=new A116843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116844
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,116L,302L,715L,1549L,3106L,5831L,10352L,17525L,28484L,44696L,68021L,100777L,145810L,206569L,287186L,392561L,528452L,701570L,919679L,1191701L,1527826L,1939627L,2440180L,3044189L,3768116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116844Inst : IEnumerable<long>
{
public static readonly long[] Value=A116844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116844.Bytes);
public long this[int i]=>Value[i];

public static A116844Inst Instance=new A116844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116845
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,121L,355L,1032L,2973L,8496L,24111L,68017L,190885L,533294L,1484021L,4115186L,11375765L,31358377L,86223943L,236540916L,647556621L,1769374932L,4826148315L,13142564449L,35736448201L,97037995226L,263156279525L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116845Inst : IEnumerable<long>
{
public static readonly long[] Value=A116845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116845.Bytes);
public long this[int i]=>Value[i];

public static A116845Inst Instance=new A116845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116846
{
public static readonly long[] Value={ 1L,1L,2L,5L,14L,41L,113L,277L,607L,1212L,2245L,3913L,6488L,10319L,15845L,23609L,34273L,48634L,67641L,92413L,124258L,164693L,215465L,278573L,356291L,451192L,566173L,704481L,869740L,1065979L,1297661L,1569713L,1887557L,2257142L,2684977L,3178165L,3744438L,4392193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116846Inst : IEnumerable<long>
{
public static readonly long[] Value=A116846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116846.Bytes);
public long this[int i]=>Value[i];

public static A116846Inst Instance=new A116846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116847
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,119L,336L,924L,2492L,6636L,17536L,46137L,121095L,317434L,831571L,2177734L,5702191L,14929519L,39087182L,102332996L,267912946L,701407172L,1836310110L,4807524929L,12586266701L,32951277474L,86267568321L,225851430414L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116847Inst : IEnumerable<long>
{
public static readonly long[] Value=A116847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116847.Bytes);
public long this[int i]=>Value[i];

public static A116847Inst Instance=new A116847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116848
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,119L,336L,927L,2527L,6870L,18717L,51155L,140120L,384147L,1053147L,2886182L,7906953L,21657679L,59318944L,162475127L,445041287L,1219069014L,3339354501L,9147387195L,25057021032L,68637206987L,188013260835L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116848Inst : IEnumerable<long>
{
public static readonly long[] Value=A116848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116848.Bytes);
public long this[int i]=>Value[i];

public static A116848Inst Instance=new A116848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116849
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,121L,356L,1044L,3057L,8948L,26192L,76674L,224465L,657137L,1923817L,5632105L,16488346L,48270655L,141315320L,413709331L,1211159679L,3545745012L,10380388294L,30389230117L,88966354626L,260454516946L,762496740130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116849Inst : IEnumerable<long>
{
public static readonly long[] Value=A116849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116849.Bytes);
public long this[int i]=>Value[i];

public static A116849Inst Instance=new A116849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116850
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,119L,334L,902L,2351L,5945L,14660L,35408L,84061L,196715L,454778L,1040522L,2359451L,5308589L,11862208L,26345684L,58196201L,127926527L,279970070L,610271534L,1325400391L,2868904289L,6190793084L,13321109912L,28588376501L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116850Inst : IEnumerable<long>
{
public static readonly long[] Value=A116850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116850.Bytes);
public long this[int i]=>Value[i];

public static A116850Inst Instance=new A116850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116851
{
public static readonly long[] Value={ 1L,2L,5L,14L,41L,116L,307L,760L,1779L,3986L,8641L,18282L,38005L,78024L,158791L,321236L,647247L,1300630L,2609029L,5227766L,10467521L,20949692L,41917115L,83855504L,167736331L,335502586L,671040297L,1342121570L,2684290669L,5368636176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116851Inst : IEnumerable<long>
{
public static readonly long[] Value=A116851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116851.Bytes);
public long this[int i]=>Value[i];

public static A116851Inst Instance=new A116851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116852
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,0L,0L,2L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,2L,0L,1L,0L,1L,2L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,2L,1L,0L,0L,0L,0L,0L,2L,0L,1L,0L,2L,0L,1L,0L,1L,0L,2L,0L,0L,0L,0L,0L,0L,1L,0L,2L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116852Inst : IEnumerable<long>
{
public static readonly long[] Value=A116852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116852.Bytes);
public long this[int i]=>Value[i];

public static A116852Inst Instance=new A116852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116853
{
public static readonly long[] Value={ 1L,1L,2L,3L,4L,6L,11L,14L,18L,24L,53L,64L,78L,96L,120L,309L,362L,426L,504L,600L,720L,2119L,2428L,2790L,3216L,3720L,4320L,5040L,16687L,18806L,21234L,24024L,27240L,30960L,35280L,40320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116853Inst : IEnumerable<long>
{
public static readonly long[] Value=A116853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116853.Bytes);
public long this[int i]=>Value[i];

public static A116853Inst Instance=new A116853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116854
{
public static readonly long[] Value={ 1L,1L,1L,3L,1L,2L,11L,3L,4L,6L,53L,11L,14L,18L,24L,309L,53L,64L,78L,96L,120L,2119L,309L,362L,426L,504L,600L,720L,16687L,2119L,2428L,2790L,3216L,3720L,4320L,5040L,148329L,16687L,18806L,21234L,24024L,27240L,30960L,35280L,40320L,1468457L,148329L,165016L,183822L,205056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116854Inst : IEnumerable<long>
{
public static readonly long[] Value=A116854.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116854.Bytes);
public long this[int i]=>Value[i];

public static A116854Inst Instance=new A116854Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116855
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,2L,3L,1L,1L,2L,6L,4L,1L,1L,2L,6L,13L,5L,1L,1L,2L,6L,24L,23L,6L,1L,1L,2L,6L,24L,67L,36L,7L,1L,1L,2L,6L,24L,120L,146L,52L,8L,1L,1L,2L,6L,24L,120L,411L,272L,71L,9L,1L,1L,2L,6L,24L,120L,720L,1067L,456L,93L,10L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116855Inst : IEnumerable<long>
{
public static readonly long[] Value=A116855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116855.Bytes);
public long this[int i]=>Value[i];

public static A116855Inst Instance=new A116855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116856
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,2L,2L,0L,0L,0L,1L,3L,0L,1L,4L,0L,0L,0L,0L,0L,1L,5L,0L,1L,6L,0L,1L,0L,0L,0L,0L,0L,1L,8L,0L,1L,0L,1L,10L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,12L,0L,2L,0L,1L,15L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,18L,0L,2L,0L,1L,0L,1L,22L,0L,3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,27L,0L,3L,0L,1L,0L,1L,32L,0L,4L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116856Inst : IEnumerable<long>
{
public static readonly long[] Value=A116856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116856.Bytes);
public long this[int i]=>Value[i];

public static A116856Inst Instance=new A116856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116857
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116857Inst : IEnumerable<long>
{
public static readonly long[] Value=A116857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116857.Bytes);
public long this[int i]=>Value[i];

public static A116857Inst Instance=new A116857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116858
{
public static readonly long[] Value={ 1L,1L,2L,2L,2L,1L,2L,2L,2L,3L,2L,4L,2L,6L,2L,8L,2L,10L,2L,12L,1L,2L,14L,2L,2L,16L,4L,2L,18L,7L,2L,20L,10L,2L,22L,14L,2L,24L,20L,2L,26L,26L,2L,28L,34L,2L,30L,44L,2L,32L,54L,1L,2L,34L,66L,2L,2L,36L,80L,4L,2L,38L,94L,8L,2L,40L,110L,13L,2L,42L,128L,20L,2L,44L,146L,30L,2L,46L,166L,42L,2L,48L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116858Inst : IEnumerable<long>
{
public static readonly long[] Value=A116858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116858.Bytes);
public long this[int i]=>Value[i];

public static A116858Inst Instance=new A116858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116859
{
public static readonly long[] Value={ 1L,1L,2L,2L,4L,6L,8L,10L,14L,18L,22L,29L,36L,46L,59L,72L,88L,110L,132L,160L,194L,232L,276L,330L,392L,464L,550L,648L,760L,894L,1044L,1216L,1418L,1644L,1905L,2204L,2540L,2924L,3364L,3859L,4420L,5060L,5778L,6590L,7514L,8544L,9706L,11018L,12484L,14130L,15980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116859Inst : IEnumerable<long>
{
public static readonly long[] Value=A116859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116859.Bytes);
public long this[int i]=>Value[i];

public static A116859Inst Instance=new A116859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116860
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,2L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,2L,0L,1L,0L,1L,0L,1L,3L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116860Inst : IEnumerable<long>
{
public static readonly long[] Value=A116860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116860.Bytes);
public long this[int i]=>Value[i];

public static A116860Inst Instance=new A116860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116861
{
public static readonly long[] Value={ 1L,1L,1L,1L,0L,2L,1L,1L,1L,2L,1L,0L,2L,1L,3L,1L,1L,3L,1L,1L,4L,1L,0L,3L,2L,2L,2L,5L,1L,1L,3L,3L,2L,4L,2L,6L,1L,0L,5L,2L,3L,4L,4L,3L,8L,1L,1L,4L,3L,4L,7L,4L,5L,3L,10L,1L,0L,5L,3L,4L,7L,7L,6L,6L,5L,12L,1L,1L,6L,4L,3L,12L,6L,8L,7L,9L,5L,15L,1L,0L,6L,4L,5L,10L,10L,9L,10L,11L,10L,7L,18L,1L,1L,6L,4L,5L,15L,11L,13L,9L,16L,11L,13L,8L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116861Inst : IEnumerable<long>
{
public static readonly long[] Value=A116861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116861.Bytes);
public long this[int i]=>Value[i];

public static A116861Inst Instance=new A116861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116862
{
public static readonly long[] Value={ 1L,7L,55L,472L,4300L,40861L,400567L,4021720L,41147398L,427470430L,4497253054L,47817544348L,513029453530L,5547155801065L,60385754935495L,661267785740080L,7279524885630310L,80512572260496610L,894231158402339410L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116862Inst : IEnumerable<long>
{
public static readonly long[] Value=A116862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116862.Bytes);
public long this[int i]=>Value[i];

public static A116862Inst Instance=new A116862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116863
{
public static readonly long[] Value={ 1L,2L,2L,2L,2L,6L,6L,3L,4L,2L,4L,4L,3L,12L,16L,12L,4L,6L,4L,2L,6L,8L,4L,6L,6L,4L,20L,30L,30L,20L,5L,8L,6L,4L,2L,8L,12L,8L,4L,9L,12L,6L,8L,8L,5L,30L,48L,54L,48L,30L,6L,10L,8L,6L,4L,2L,10L,16L,12L,8L,4L,12L,18L,12L,6L,12L,16L,8L,10L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116863Inst : IEnumerable<long>
{
public static readonly long[] Value=A116863.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116863.Bytes);
public long this[int i]=>Value[i];

public static A116863Inst Instance=new A116863Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116864
{
public static readonly long[] Value={ 0L,2L,0L,3L,0L,0L,0L,0L,4L,0L,0L,5L,0L,6L,0L,0L,0L,0L,0L,0L,0L,9L,0L,0L,8L,0L,0L,0L,0L,7L,0L,10L,0L,0L,0L,0L,12L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,15L,0L,0L,0L,0L,0L,18L,0L,0L,0L,0L,16L,0L,0L,0L,0L,0L,0L,0L,0L,0L,14L,0L,0L,0L,0L,0L,0L,20L,0L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116864Inst : IEnumerable<long>
{
public static readonly long[] Value=A116864.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116864.Bytes);
public long this[int i]=>Value[i];

public static A116864Inst Instance=new A116864Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116865
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116865Inst : IEnumerable<long>
{
public static readonly long[] Value=A116865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116865.Bytes);
public long this[int i]=>Value[i];

public static A116865Inst Instance=new A116865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116866
{
public static readonly long[] Value={ 1L,1L,1L,4L,4L,1L,25L,25L,7L,1L,190L,190L,55L,10L,1L,1606L,1606L,472L,94L,13L,1L,14506L,14506L,4300L,898L,142L,16L,1L,137089L,137089L,40861L,8785L,1495L,199L,19L,1L,1338790L,1338790L,400567L,87826L,15655L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116866Inst : IEnumerable<long>
{
public static readonly long[] Value=A116866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116866.Bytes);
public long this[int i]=>Value[i];

public static A116866Inst Instance=new A116866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116867
{
public static readonly long[] Value={ 1L,2L,9L,58L,446L,3792L,34369L,325538L,3184206L,31917772L,326156474L,3385065348L,35585008816L,378116619692L,4054571715729L,43820012675698L,476830454211926L,5219833626494412L,57444768682580494L,635176593108262028L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116867Inst : IEnumerable<long>
{
public static readonly long[] Value=A116867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116867.Bytes);
public long this[int i]=>Value[i];

public static A116867Inst Instance=new A116867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116868
{
public static readonly long[] Value={ 1L,3L,4L,9L,21L,25L,27L,90L,165L,190L,81L,351L,846L,1416L,1606L,243L,1296L,3834L,8082L,12900L,14506L,729L,4617L,16119L,40365L,79065L,122583L,137089L,2187L,16038L,64395L,185490L,422685L,790434L,1201701L,1338790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116868Inst : IEnumerable<long>
{
public static readonly long[] Value=A116868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116868.Bytes);
public long this[int i]=>Value[i];

public static A116868Inst Instance=new A116868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116869
{
public static readonly long[] Value={ 132L,297L,869L,2739L,8986L,30275L,104006L,362738L,1280592L,4566642L,16423581L,59497075L,216901454L,795117015L,2929034130L,10837075830L,40253156520L,150045410430L,561097823490L,2104382963214L,7913603390196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116869Inst : IEnumerable<long>
{
public static readonly long[] Value=A116869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116869.Bytes);
public long this[int i]=>Value[i];

public static A116869Inst Instance=new A116869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116870
{
public static readonly long[] Value={ 429L,1001L,3003L,9646L,32123L,109550L,380162L,1337220L,4755402L,17065365L,61714147L,224661206L,822574599L,3027096930L,11190101910L,41532876060L,154712622870L,578210935770L,2167431271614L,8146882131276L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116870Inst : IEnumerable<long>
{
public static readonly long[] Value=A116870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116870.Bytes);
public long this[int i]=>Value[i];

public static A116870Inst Instance=new A116870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116871
{
public static readonly long[] Value={ 42L,174L,645L,2333L,8398L,30275L,109550L,398180L,1453908L,5332407L,19639521L,72616727L,269473750L,1003347975L,3747412770L,14036374680L,52714429260L,198459284400L,748867149234L,2831788492218L,10729442739596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116871Inst : IEnumerable<long>
{
public static readonly long[] Value=A116871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116871.Bytes);
public long this[int i]=>Value[i];

public static A116871Inst Instance=new A116871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116872
{
public static readonly long[] Value={ 1L,3L,7L,13L,29L,41L,67L,147L,195L,247L,381L,829L,1069L,1277L,1545L,2307L,4995L,6339L,7379L,8451L,9975L,14589L,31485L,39549L,45373L,50733L,56829L,66057L,95235L,205059L,255747L,290691L,320707L,351187L,388099L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116872Inst : IEnumerable<long>
{
public static readonly long[] Value=A116872.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116872.Bytes);
public long this[int i]=>Value[i];

public static A116872Inst Instance=new A116872Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116873
{
public static readonly long[] Value={ 1L,1L,5L,49L,653L,10201L,174965L,3188641L,60623645L,1189050025L,23884139525L,488869387249L,10159948737581L,213822249696121L,4547793322315157L,97600834975487809L,2110916340429978173L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116873Inst : IEnumerable<long>
{
public static readonly long[] Value=A116873.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116873.Bytes);
public long this[int i]=>Value[i];

public static A116873Inst Instance=new A116873Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116874
{
public static readonly BigInteger[] Value={ 1L,1L,6L,76L,1336L,27696L,631776L,15327936L,388158336L,10143429376L,271514492416L,7406771137536L,205171931723776L,5755684861259776L,163186022760308736L,4668631322653802496L,BigInteger.Parse("134608711249014521856") };
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
public class A116874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116874Inst Instance=new A116874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116875
{
public static readonly BigInteger[] Value={ 1L,1L,7L,109L,2383L,61621L,1755127L,53192749L,1683052063L,54960231781L,1838511095047L,62680788397789L,2170059386074543L,76086971405595541L,2696276508804038167L,BigInteger.Parse("96415261773063801229"),BigInteger.Parse("3474635368976138997823") };
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
public class A116875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116875Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116875.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116875.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116875Inst Instance=new A116875Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116876
{
public static readonly BigInteger[] Value={ 1L,1L,8L,148L,3872L,120016L,4099712L,149049664L,5657960960L,221678337280L,8897559799808L,363982704071680L,15120552582127616L,636153538316259328L,BigInteger.Parse("27050546920814968832"),BigInteger.Parse("1160701969453516668928"),BigInteger.Parse("50193802774799009841152") };
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
public class A116876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116876Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116876.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116876.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116876Inst Instance=new A116876Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116877
{
public static readonly BigInteger[] Value={ 1L,1L,9L,193L,5881L,212529L,8467113L,359065953L,15899869785L,726714474385L,34027390026505L,1623911649356481L,78700579447559353L,3862817734061600497L,BigInteger.Parse("191625298483691960169"),BigInteger.Parse("9592547730682848672801"),BigInteger.Parse("483950907590044260965145") };
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
public class A116877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116877Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116877.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116877.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116877Inst Instance=new A116877Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116878
{
public static readonly BigInteger[] Value={ 1L,1L,10L,244L,8488L,350416L,15951520L,772998976L,39116022400L,2043110206720L,109327631034880L,5962676777841664L,330245816572389376L,BigInteger.Parse("18524490234081366016"),BigInteger.Parse("1050217217793635295232"),BigInteger.Parse("60082184145887689129984") };
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
public class A116878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116878Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116878.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116878.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116878Inst Instance=new A116878Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116879
{
public static readonly long[] Value={ 1L,10L,83L,656L,5101L,39446L,304615L,2353180L,18198497L,140935202L,1093058523L,8489861160L,66033483733L,514279211054L,4010208001999L,31306199597108L,244654627880905L,1913827008446522L,14984671523766211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116879Inst : IEnumerable<long>
{
public static readonly long[] Value=A116879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116879.Bytes);
public long this[int i]=>Value[i];

public static A116879Inst Instance=new A116879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116880
{
public static readonly long[] Value={ 1L,1L,3L,3L,7L,13L,13L,29L,41L,67L,67L,147L,195L,247L,381L,381L,829L,1069L,1277L,1545L,2307L,2307L,4995L,6339L,7379L,8451L,9975L,14589L,14589L,31485L,39549L,45373L,50733L,56829L,66057L,95235L,95235L,205059L,255747L,290691L,320707L,351187L,388099L,446455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116880Inst : IEnumerable<long>
{
public static readonly long[] Value=A116880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116880.Bytes);
public long this[int i]=>Value[i];

public static A116880Inst Instance=new A116880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116881
{
public static readonly long[] Value={ 1L,4L,23L,150L,1037L,7408L,54035L,399850L,2990105L,22540260L,170991647L,1303789534L,9983164453L,76711854040L,591236890667L,4568611684306L,35382196437041L,274564234870732L,2134337640202295L,16617270658727878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116881Inst : IEnumerable<long>
{
public static readonly long[] Value=A116881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116881.Bytes);
public long this[int i]=>Value[i];

public static A116881Inst Instance=new A116881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116882
{
public static readonly long[] Value={ 1L,2L,4L,8L,12L,16L,24L,32L,40L,48L,56L,64L,80L,96L,112L,128L,144L,160L,176L,192L,208L,224L,240L,256L,288L,320L,352L,384L,416L,448L,480L,512L,544L,576L,608L,640L,672L,704L,736L,768L,800L,832L,864L,896L,928L,960L,992L,1024L,1088L,1152L,1216L,1280L,1344L,1408L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116882Inst : IEnumerable<long>
{
public static readonly long[] Value=A116882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116882.Bytes);
public long this[int i]=>Value[i];

public static A116882Inst Instance=new A116882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116883
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,9L,10L,11L,13L,14L,15L,17L,18L,19L,20L,21L,22L,23L,25L,26L,27L,28L,29L,30L,31L,33L,34L,35L,36L,37L,38L,39L,41L,42L,43L,44L,45L,46L,47L,49L,50L,51L,52L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,65L,66L,67L,68L,69L,70L,71L,72L,73L,74L,75L,76L,77L,78L,79L,81L,82L,83L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116883Inst : IEnumerable<long>
{
public static readonly long[] Value=A116883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116883.Bytes);
public long this[int i]=>Value[i];

public static A116883Inst Instance=new A116883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116884
{
public static readonly long[] Value={ 1L,5L,8L,23L,27L,55L,73L,76L,377L,396L,432L,18219L,18231L,747343L,748635L,5523608L,7626590L,32866452L,82251007L,1133553044L,1778903359L,3664408636L,7208605769L,26149894782L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116884Inst : IEnumerable<long>
{
public static readonly long[] Value=A116884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116884.Bytes);
public long this[int i]=>Value[i];

public static A116884Inst Instance=new A116884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116885
{
public static readonly long[] Value={ 1L,8L,55L,76L,377L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116885Inst : IEnumerable<long>
{
public static readonly long[] Value=A116885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116885.Bytes);
public long this[int i]=>Value[i];

public static A116885Inst Instance=new A116885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116886
{
public static readonly long[] Value={ 3L,17L,103L,137L,277L,313L,677L,743L,1117L,1627L,2003L,2143L,3407L,3677L,4483L,5087L,5903L,7177L,7333L,8087L,8093L,8147L,8537L,8573L,9293L,9473L,10177L,10477L,11173L,13807L,14897L,15107L,16657L,19753L,21563L,22307L,24113L,26113L,26417L,26633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116886Inst : IEnumerable<long>
{
public static readonly long[] Value=A116886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116886.Bytes);
public long this[int i]=>Value[i];

public static A116886Inst Instance=new A116886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116887
{
public static readonly long[] Value={ 5087L,11173L,16657L,47017L,54503L,185243L,207643L,300413L,306167L,341813L,391387L,849047L,1348577L,1438223L,1502923L,1857407L,1909267L,2121737L,2161163L,2288773L,2610133L,2725157L,2744723L,2779097L,2874463L,2881327L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116887Inst : IEnumerable<long>
{
public static readonly long[] Value=A116887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116887.Bytes);
public long this[int i]=>Value[i];

public static A116887Inst Instance=new A116887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116888
{
public static readonly long[] Value={ 306167L,48639197L,64695713L,68252687L,87788237L,87813293L,160486967L,255974437L,283032247L,324609913L,361705873L,417684523L,449364197L,451995587L,454052213L,466037563L,536504713L,574746467L,596095613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116888Inst : IEnumerable<long>
{
public static readonly long[] Value=A116888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116888.Bytes);
public long this[int i]=>Value[i];

public static A116888Inst Instance=new A116888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116889
{
public static readonly long[] Value={ 2L,3L,3L,5087L,306167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116889Inst : IEnumerable<long>
{
public static readonly long[] Value=A116889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116889.Bytes);
public long this[int i]=>Value[i];

public static A116889Inst Instance=new A116889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116890
{
public static readonly long[] Value={ 170471L,1740725L,10744475L,52521875L,582100992L,896914944L,906992640L,1010744168L,1334161125L,3368633184L,3673320192L,4251157632L,4437518596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116890Inst : IEnumerable<long>
{
public static readonly long[] Value=A116890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116890.Bytes);
public long this[int i]=>Value[i];

public static A116890Inst Instance=new A116890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116891
{
public static readonly long[] Value={ 2L,1L,7L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,47L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,79L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,103L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,127L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,191L,1L,1L,1L,199L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116891Inst : IEnumerable<long>
{
public static readonly long[] Value=A116891.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116891.Bytes);
public long this[int i]=>Value[i];

public static A116891Inst Instance=new A116891Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116892
{
public static readonly long[] Value={ 2L,7L,47L,79L,103L,127L,191L,199L,263L,367L,383L,431L,479L,503L,599L,607L,631L,727L,743L,823L,839L,863L,887L,991L,1087L,1151L,1319L,1367L,1423L,1487L,1511L,1583L,1663L,1783L,1823L,1871L,1951L,2039L,2063L,2111L,2143L,2287L,2311L,2383L,2423L,2447L,2503L,2551L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116892Inst : IEnumerable<long>
{
public static readonly long[] Value=A116892.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116892.Bytes);
public long this[int i]=>Value[i];

public static A116892Inst Instance=new A116892Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116893
{
public static readonly long[] Value={ 1L,3L,23L,39L,51L,63L,95L,99L,131L,183L,191L,215L,239L,251L,299L,303L,315L,363L,371L,411L,419L,431L,443L,495L,543L,575L,659L,683L,711L,743L,755L,791L,831L,891L,911L,935L,975L,1019L,1031L,1055L,1071L,1143L,1155L,1191L,1211L,1223L,1251L,1275L,1295L,1355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116893Inst : IEnumerable<long>
{
public static readonly long[] Value=A116893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116893.Bytes);
public long this[int i]=>Value[i];

public static A116893Inst Instance=new A116893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116894
{
public static readonly long[] Value={ 1L,5427L,41255L,43755L,208161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116894Inst : IEnumerable<long>
{
public static readonly long[] Value=A116894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116894.Bytes);
public long this[int i]=>Value[i];

public static A116894Inst Instance=new A116894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116895
{
public static readonly long[] Value={ 3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,13L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L,3L,2L,3L,2L,5L,2L,3L,2L,3L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116895Inst : IEnumerable<long>
{
public static readonly long[] Value=A116895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116895.Bytes);
public long this[int i]=>Value[i];

public static A116895Inst Instance=new A116895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116896
{
public static readonly long[] Value={ 0L,1L,2L,6L,42L,604L,1976L,5126L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116896Inst : IEnumerable<long>
{
public static readonly long[] Value=A116896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116896.Bytes);
public long this[int i]=>Value[i];

public static A116896Inst Instance=new A116896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116897
{
public static readonly long[] Value={ 4L,6L,8L,14L,18L,28L,64L,324L,778L,882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116897Inst : IEnumerable<long>
{
public static readonly long[] Value=A116897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116897.Bytes);
public long this[int i]=>Value[i];

public static A116897Inst Instance=new A116897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116898
{
public static readonly long[] Value={ 2L,10L,34L,499L,1746L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116898Inst : IEnumerable<long>
{
public static readonly long[] Value=A116898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116898.Bytes);
public long this[int i]=>Value[i];

public static A116898Inst Instance=new A116898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116899
{
public static readonly long[] Value={ 1L,2L,6L,3022L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116899Inst : IEnumerable<long>
{
public static readonly long[] Value=A116899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116899.Bytes);
public long this[int i]=>Value[i];

public static A116899Inst Instance=new A116899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116900
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,1L,0L,2L,0L,2L,1L,5L,0L,7L,0L,7L,4L,8L,0L,21L,1L,14L,13L,25L,0L,43L,0L,44L,31L,41L,2L,121L,0L,66L,73L,126L,0L,215L,0L,193L,179L,165L,0L,554L,1L,285L,346L,491L,0L,890L,65L,772L,704L,574L,0L,2330L,0L,847L,1392L,1828L,254L,3212L,0L,2754L,2649L,2282L,0L,7907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116900Inst : IEnumerable<long>
{
public static readonly long[] Value=A116900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116900.Bytes);
public long this[int i]=>Value[i];

public static A116900Inst Instance=new A116900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116901
{
public static readonly long[] Value={ 0L,0L,1L,2L,4L,5L,8L,12L,18L,25L,35L,47L,66L,87L,118L,155L,207L,264L,348L,443L,571L,725L,923L,1155L,1466L,1821L,2275L,2821L,3501L,4293L,5307L,6477L,7933L,9658L,11750L,14198L,17251L,20746L,24986L,30009L,36024L,42983L,51446L,61176L,72839L,86497L,102538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116901Inst : IEnumerable<long>
{
public static readonly long[] Value=A116901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116901.Bytes);
public long this[int i]=>Value[i];

public static A116901Inst Instance=new A116901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116902
{
public static readonly long[] Value={ 0L,0L,0L,0L,1L,2L,2L,3L,4L,6L,8L,10L,13L,16L,20L,23L,32L,36L,46L,55L,66L,78L,99L,108L,136L,160L,188L,216L,271L,296L,364L,415L,484L,559L,684L,725L,890L,1028L,1175L,1313L,1599L,1727L,2084L,2335L,2636L,3019L,3620L,3801L,4553L,5170L,5819L,6460L,7690L,8265L,9728L,10783L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116902Inst : IEnumerable<long>
{
public static readonly long[] Value=A116902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116902.Bytes);
public long this[int i]=>Value[i];

public static A116902Inst Instance=new A116902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116903
{
public static readonly long[] Value={ 1L,3L,7L,19L,49L,131L,339L,899L,2345L,6199L,16225L,42811L,112285L,296051L,777411L,2049025L,5384855L,14190509L,37313977L,98324565L,258654441L,681552747L,1793492411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116903Inst : IEnumerable<long>
{
public static readonly long[] Value=A116903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116903.Bytes);
public long this[int i]=>Value[i];

public static A116903Inst Instance=new A116903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116904
{
public static readonly long[] Value={ 1L,5L,21L,93L,409L,1853L,8333L,37965L,172265L,787557L,3593465L,16477845L,75481105L,346960613L,1593924045L,7341070889L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116904Inst : IEnumerable<long>
{
public static readonly long[] Value=A116904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116904.Bytes);
public long this[int i]=>Value[i];

public static A116904Inst Instance=new A116904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116905
{
public static readonly long[] Value={ 1L,0L,1L,1L,0L,0L,0L,0L,0L,1L,2L,1L,0L,0L,1L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L,0L,2L,2L,0L,0L,1L,1L,0L,1L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116905Inst : IEnumerable<long>
{
public static readonly long[] Value=A116905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116905.Bytes);
public long this[int i]=>Value[i];

public static A116905Inst Instance=new A116905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116906
{
public static readonly BigInteger[] Value={ 1L,1L,5L,50L,850L,22100L,806806L,40340300L,2584263500L,209609328500L,20993420690550L,2561197324247100L,368819285671473000L,BigInteger.Parse("62699278564150410000"),BigInteger.Parse("12294076739210974071000"),BigInteger.Parse("2766341857504878226501200") };
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
public class A116906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116906Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116906.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116906.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116906Inst Instance=new A116906Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116907
{
public static readonly long[] Value={ 0L,15L,6L,2L,13L,1L,3L,6L,2L,1L,1L,5L,1L,1L,1L,9L,4L,1L,1L,1L,6L,7L,1L,2L,4L,1L,2L,2L,24L,1L,2L,4L,56L,1L,1L,2L,4L,1L,75L,1L,5L,1L,2L,2L,1L,137L,2L,2L,97L,3L,16L,1L,1L,1L,1L,3L,5L,12L,1L,1L,2L,1L,53L,1L,2L,5L,3L,2L,4L,1L,2L,1L,39L,1L,2L,1L,4L,1L,11L,1L,5L,5L,1L,4L,1L,17L,12L,4L,82L,1L,4L,6L,25L,3L,2L,3L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116907Inst : IEnumerable<long>
{
public static readonly long[] Value=A116907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116907.Bytes);
public long this[int i]=>Value[i];

public static A116907Inst Instance=new A116907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116908
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,3L,3L,5L,1L,4L,5L,6L,8L,1L,5L,8L,9L,11L,14L,1L,6L,13L,14L,17L,20L,24L,1L,7L,19L,24L,37L,31L,37L,44L,1L,8L,26L,43L,44L,51L,58L,68L,81L,1L,9L,34L,69L,81L,87L,95L,109L,126L,149L,1L,10L,43L,103L,149L,150L,168L,182L,204L,235L,274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116908Inst : IEnumerable<long>
{
public static readonly long[] Value=A116908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116908.Bytes);
public long this[int i]=>Value[i];

public static A116908Inst Instance=new A116908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116909
{
public static readonly long[] Value={ 2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,3L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L,3L,2L,2L,2L,3L,2L,2L,2L,3L,2L,2L,3L,2L,2L,2L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116909Inst : IEnumerable<long>
{
public static readonly long[] Value=A116909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116909.Bytes);
public long this[int i]=>Value[i];

public static A116909Inst Instance=new A116909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116910
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,10L,12L,20L,21L,24L,30L,40L,44L,45L,48L,50L,54L,60L,64L,80L,84L,85L,88L,90L,92L,96L,100L,102L,110L,111L,112L,116L,120L,132L,133L,135L,150L,152L,156L,168L,174L,175L,180L,182L,189L,200L,201L,204L,210L,220L,222L,225L,230L,240L,245L,246L,248L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116910Inst : IEnumerable<long>
{
public static readonly long[] Value=A116910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116910.Bytes);
public long this[int i]=>Value[i];

public static A116910Inst Instance=new A116910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116911
{
public static readonly long[] Value={ 5L,17L,4957L,129277L,2826443L,3861083L,5126483L,9451573L,19811083L,53751743L,68136617L,98729003L,264616831L,388771421L,498157871L,608312141L,682548511L,779346653L,918754301L,1174179079L,1700023891L,2056298683L,2149703411L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116911Inst : IEnumerable<long>
{
public static readonly long[] Value=A116911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116911.Bytes);
public long this[int i]=>Value[i];

public static A116911Inst Instance=new A116911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116912
{
public static readonly long[] Value={ 1L,2L,3L,4L,1L,6L,11L,8L,9L,10L,7L,12L,17L,22L,3L,16L,13L,18L,23L,4L,33L,14L,19L,24L,1L,34L,27L,44L,25L,6L,35L,32L,21L,39L,3L,36L,41L,46L,51L,8L,37L,66L,47L,28L,6L,38L,43L,48L,121L,2L,39L,68L,49L,54L,7L,88L,69L,50L,55L,12L,65L,70L,66L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116912Inst : IEnumerable<long>
{
public static readonly long[] Value=A116912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116912.Bytes);
public long this[int i]=>Value[i];

public static A116912Inst Instance=new A116912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116913
{
public static readonly long[] Value={ 1L,6L,13L,28L,36L,69L,71L,120L,130L,186L,177L,301L,248L,363L,378L,496L,426L,663L,533L,798L,734L,897L,783L,1245L,961L,1254L,1210L,1547L,1248L,1914L,1427L,2016L,1806L,2148L,1926L,2821L,2036L,2685L,2522L,3270L,2502L,3702L,2753L,3801L,3510L,3939L,3291L,5053L,3648L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116913Inst : IEnumerable<long>
{
public static readonly long[] Value=A116913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116913.Bytes);
public long this[int i]=>Value[i];

public static A116913Inst Instance=new A116913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116914
{
public static readonly long[] Value={ 1L,1L,5L,16L,58L,211L,781L,2920L,11006L,41746L,159154L,609324L,2341060L,9021559L,34855741L,134972368L,523689718L,2035462990L,7923732118L,30889008112L,120566373676L,471134916286L,1842964183570L,7216096752496L,28279240308268L,110913181145716L,435333520075796L,1709861650762900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116914Inst : IEnumerable<long>
{
public static readonly long[] Value=A116914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116914.Bytes);
public long this[int i]=>Value[i];

public static A116914Inst Instance=new A116914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116915
{
public static readonly long[] Value={ 1L,-1L,1L,0L,-1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,1L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116915Inst : IEnumerable<long>
{
public static readonly long[] Value=A116915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116915.Bytes);
public long this[int i]=>Value[i];

public static A116915Inst Instance=new A116915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116916
{
public static readonly long[] Value={ 1L,5L,-7L,0L,0L,-11L,0L,13L,0L,0L,0L,0L,17L,0L,0L,-19L,0L,0L,0L,0L,0L,0L,-23L,0L,0L,0L,25L,0L,0L,0L,0L,0L,0L,0L,0L,29L,0L,0L,0L,0L,-31L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-35L,0L,0L,0L,0L,0L,37L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,41L,0L,0L,0L,0L,0L,0L,-43L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-47L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116916Inst : IEnumerable<long>
{
public static readonly long[] Value=A116916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116916.Bytes);
public long this[int i]=>Value[i];

public static A116916Inst Instance=new A116916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116917
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L,7L,9L,10L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116917Inst : IEnumerable<long>
{
public static readonly long[] Value=A116917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116917.Bytes);
public long this[int i]=>Value[i];

public static A116917Inst Instance=new A116917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116918
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L,7L,9L,10L,5L,10L,7L,12L,9L,6L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116918Inst : IEnumerable<long>
{
public static readonly long[] Value=A116918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116918.Bytes);
public long this[int i]=>Value[i];

public static A116918Inst Instance=new A116918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116919
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,8L,8L,9L,11L,20L,15L,16L,14L,20L,19L,34L,33L,28L,25L,24L,23L,44L,33L,34L,41L,66L,37L,64L,30L,34L,47L,78L,45L,38L,53L,88L,47L,84L,45L,44L,51L,58L,71L,114L,63L,52L,59L,106L,101L,150L,55L,62L,83L,136L,71L,126L,63L,64L,60L,64L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116919Inst : IEnumerable<long>
{
public static readonly long[] Value=A116919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116919.Bytes);
public long this[int i]=>Value[i];

public static A116919Inst Instance=new A116919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116920
{
public static readonly long[] Value={ 1L,2L,4L,5L,9L,8L,8L,9L,11L,20L,12L,13L,25L,18L,16L,17L,33L,20L,20L,21L,23L,44L,24L,25L,29L,54L,28L,29L,57L,32L,32L,33L,35L,38L,36L,37L,73L,110L,40L,41L,81L,44L,44L,45L,47L,92L,48L,49L,55L,54L,52L,53L,105L,56L,56L,57L,59L,116L,60L,61L,121L,72L,64L,65L,69L,68L,68L,69L,71L,140L,72L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116920Inst : IEnumerable<long>
{
public static readonly long[] Value=A116920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116920.Bytes);
public long this[int i]=>Value[i];

public static A116920Inst Instance=new A116920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116921
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,3L,3L,4L,3L,5L,5L,6L,5L,7L,7L,8L,7L,9L,9L,10L,9L,11L,11L,12L,11L,13L,13L,14L,13L,15L,15L,16L,15L,17L,17L,18L,17L,19L,19L,20L,19L,21L,21L,22L,21L,23L,23L,24L,23L,25L,25L,26L,25L,27L,27L,28L,27L,29L,29L,30L,29L,31L,31L,32L,31L,33L,33L,34L,33L,35L,35L,36L,35L,37L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116921Inst : IEnumerable<long>
{
public static readonly long[] Value=A116921.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116921.Bytes);
public long this[int i]=>Value[i];

public static A116921Inst Instance=new A116921Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116922
{
public static readonly long[] Value={ 1L,1L,2L,3L,3L,5L,4L,5L,5L,7L,6L,7L,7L,9L,8L,9L,9L,11L,10L,11L,11L,13L,12L,13L,13L,15L,14L,15L,15L,17L,16L,17L,17L,19L,18L,19L,19L,21L,20L,21L,21L,23L,22L,23L,23L,25L,24L,25L,25L,27L,26L,27L,27L,29L,28L,29L,29L,31L,30L,31L,31L,33L,32L,33L,33L,35L,34L,35L,35L,37L,36L,37L,37L,39L,38L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116922Inst : IEnumerable<long>
{
public static readonly long[] Value=A116922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116922.Bytes);
public long this[int i]=>Value[i];

public static A116922Inst Instance=new A116922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116923
{
public static readonly long[] Value={ 1L,5L,1L,12L,7L,2L,22L,26L,20L,6L,35L,74L,112L,84L,24L,51L,183L,484L,672L,456L,120L,70L,417L,1818L,4140L,4968L,3000L,720L,92L,904L,6288L,22014L,41400L,42840L,23040L,5040L,117L,1900L,20672L,106920L,295056L,464040L,418320L,201600L,40320L,145L,3917L,65816L,489696L,1902960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116923Inst : IEnumerable<long>
{
public static readonly long[] Value=A116923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116923.Bytes);
public long this[int i]=>Value[i];

public static A116923Inst Instance=new A116923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116924
{
public static readonly long[] Value={ 1L,1L,4L,1L,8L,7L,1L,12L,21L,10L,1L,16L,42L,40L,13L,1L,20L,70L,100L,65L,16L,1L,24L,105L,200L,195L,96L,19L,1L,28L,147L,350L,455L,336L,133L,22L,1L,32L,196L,560L,910L,896L,532L,176L,25L,1L,36L,252L,840L,1638L,2016L,1596L,792L,225L,28L,1L,40L,315L,1200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116924Inst : IEnumerable<long>
{
public static readonly long[] Value=A116924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116924.Bytes);
public long this[int i]=>Value[i];

public static A116924Inst Instance=new A116924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116925
{
public static readonly long[] Value={ 1L,1L,2L,1L,2L,3L,1L,2L,4L,4L,1L,2L,5L,8L,5L,1L,2L,6L,14L,16L,6L,1L,2L,7L,22L,42L,32L,7L,1L,2L,8L,32L,92L,132L,64L,8L,1L,2L,9L,44L,177L,422L,429L,128L,9L,1L,2L,10L,58L,310L,1122L,2074L,1430L,256L,10L,1L,2L,11L,74L,506L,2606L,7898L,10754L,4862L,512L,11L,1L,2L,12L,92L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116925Inst : IEnumerable<long>
{
public static readonly long[] Value=A116925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116925.Bytes);
public long this[int i]=>Value[i];

public static A116925Inst Instance=new A116925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116926
{
public static readonly long[] Value={ 6L,14L,15L,51L,62L,91L,95L,159L,254L,287L,473L,679L,703L,1139L,1199L,1339L,1717L,1891L,2051L,2147L,2495L,2651L,2701L,2869L,3151L,4313L,4381L,4607L,5017L,5267L,6245L,6683L,8441L,9809L,10063L,10637L,11051L,11183L,12403L,13119L,13169L,13207L,13423L,13427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116926Inst : IEnumerable<long>
{
public static readonly long[] Value=A116926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116926.Bytes);
public long this[int i]=>Value[i];

public static A116926Inst Instance=new A116926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116927
{
public static readonly long[] Value={ 0L,1L,0L,0L,1L,1L,0L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,0L,0L,0L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,2L,0L,1L,0L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,2L,0L,1L,0L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,2L,0L,2L,0L,1L,0L,1L,0L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116927Inst : IEnumerable<long>
{
public static readonly long[] Value=A116927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116927.Bytes);
public long this[int i]=>Value[i];

public static A116927Inst Instance=new A116927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116928
{
public static readonly long[] Value={ 1L,0L,1L,0L,2L,1L,3L,2L,4L,4L,6L,6L,8L,9L,11L,12L,15L,17L,20L,22L,26L,29L,34L,37L,43L,48L,55L,60L,69L,76L,86L,94L,106L,117L,131L,143L,160L,176L,195L,213L,236L,259L,285L,311L,342L,374L,410L,446L,488L,533L,581L,631L,688L,748L,813L,881L,957L,1038L,1125L,1216L,1317L,1425L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116928Inst : IEnumerable<long>
{
public static readonly long[] Value=A116928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116928.Bytes);
public long this[int i]=>Value[i];

public static A116928Inst Instance=new A116928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116929
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,1L,1L,0L,0L,2L,0L,1L,1L,1L,0L,0L,2L,0L,1L,0L,2L,1L,0L,1L,2L,0L,1L,0L,1L,2L,1L,0L,0L,3L,1L,1L,0L,1L,1L,2L,1L,0L,0L,3L,0L,2L,0L,2L,1L,1L,2L,1L,0L,1L,3L,0L,2L,0L,1L,2L,1L,1L,3L,1L,0L,0L,4L,0L,2L,0L,2L,2L,2L,1L,1L,3L,1L,0L,0L,4L,0L,2L,1L,2L,3L,1L,2L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116929Inst : IEnumerable<long>
{
public static readonly long[] Value=A116929.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116929.Bytes);
public long this[int i]=>Value[i];

public static A116929Inst Instance=new A116929Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116930
{
public static readonly long[] Value={ 1L,1L,4L,5L,10L,14L,22L,31L,44L,61L,82L,111L,145L,191L,245L,316L,399L,506L,631L,788L,973L,1200L,1468L,1792L,2174L,2630L,3167L,3802L,4547L,5422L,6445L,7638L,9029L,10642L,12515L,14679L,17181L,20061L,23379L,27185L,31554L,36551L,42268L,48787L,56224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116930Inst : IEnumerable<long>
{
public static readonly long[] Value=A116930.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116930.Bytes);
public long this[int i]=>Value[i];

public static A116930Inst Instance=new A116930Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116931
{
public static readonly long[] Value={ 1L,2L,2L,4L,4L,8L,8L,13L,15L,22L,24L,37L,40L,57L,64L,89L,98L,135L,149L,199L,224L,292L,325L,424L,472L,601L,676L,850L,950L,1191L,1329L,1643L,1845L,2258L,2524L,3082L,3442L,4158L,4659L,5591L,6246L,7472L,8338L,9903L,11072L,13077L,14586L,17184L,19150L,22431L,25019L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116931Inst : IEnumerable<long>
{
public static readonly long[] Value=A116931.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116931.Bytes);
public long this[int i]=>Value[i];

public static A116931Inst Instance=new A116931Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116932
{
public static readonly long[] Value={ 1L,2L,2L,3L,3L,6L,6L,9L,12L,14L,16L,24L,25L,32L,40L,49L,56L,73L,81L,102L,120L,142L,162L,202L,227L,270L,316L,367L,419L,506L,565L,663L,767L,879L,998L,1179L,1317L,1517L,1739L,1979L,2232L,2588L,2883L,3295L,3742L,4220L,4737L,5426L,6037L,6828L,7701L,8642L,9651L,10939L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116932Inst : IEnumerable<long>
{
public static readonly long[] Value=A116932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116932.Bytes);
public long this[int i]=>Value[i];

public static A116932Inst Instance=new A116932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116933
{
public static readonly long[] Value={ 2L,1L,2L,1L,2L,1L,4L,1L,2L,1L,2L,1L,2L,1L,4L,3L,6L,1L,2L,1L,2L,1L,2L,1L,2L,3L,10L,1L,8L,1L,2L,1L,2L,1L,2L,5L,4L,1L,8L,1L,2L,1L,4L,7L,2L,3L,8L,1L,2L,1L,2L,1L,2L,1L,4L,3L,4L,3L,2L,1L,4L,1L,2L,1L,2L,1L,8L,1L,2L,9L,6L,1L,2L,1L,2L,3L,8L,7L,2L,1L,10L,1L,6L,1L,4L,3L,4L,1L,2L,7L,2L,7L,2L,1L,6L,1L,6L,1L,4L,3L,2L,11L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116933Inst : IEnumerable<long>
{
public static readonly long[] Value=A116933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116933.Bytes);
public long this[int i]=>Value[i];

public static A116933Inst Instance=new A116933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116934
{
public static readonly long[] Value={ 7L,7L,13L,11L,19L,17L,43L,19L,31L,23L,37L,29L,43L,31L,83L,73L,131L,41L,61L,43L,67L,47L,73L,53L,79L,113L,317L,59L,277L,67L,97L,67L,103L,71L,109L,241L,193L,79L,367L,83L,127L,89L,223L,373L,139L,193L,439L,101L,151L,103L,157L,107L,163L,113L,283L,233L,293L,241L,181L,127L,313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116934Inst : IEnumerable<long>
{
public static readonly long[] Value=A116934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116934.Bytes);
public long this[int i]=>Value[i];

public static A116934Inst Instance=new A116934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116935
{
public static readonly BigInteger[] Value={ 123L,1234L,1234567L,BigInteger.Parse("12345678910111213141516171819202122232425262728293031323334") };
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
public class A116935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A116935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A116935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A116935Inst Instance=new A116935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116936
{
public static readonly long[] Value={ 417979L,5828779L,6778746L,9866895L,20250501L,20583048L,20688247L,26172783L,35972619L,60914800L,67162336L,78692065L,78798340L,101105398L,104627288L,126648015L,131916133L,138376385L,170592575L,172837628L,180756151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116936Inst : IEnumerable<long>
{
public static readonly long[] Value=A116936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116936.Bytes);
public long this[int i]=>Value[i];

public static A116936Inst Instance=new A116936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116937
{
public static readonly long[] Value={ 1L,0L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,1L,0L,0L,0L,1L,0L,1L,1L,1L,0L,1L,1L,1L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116937Inst : IEnumerable<long>
{
public static readonly long[] Value=A116937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116937.Bytes);
public long this[int i]=>Value[i];

public static A116937Inst Instance=new A116937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116938
{
public static readonly long[] Value={ 1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116938Inst : IEnumerable<long>
{
public static readonly long[] Value=A116938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116938.Bytes);
public long this[int i]=>Value[i];

public static A116938Inst Instance=new A116938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116939
{
public static readonly long[] Value={ 0L,1L,2L,1L,2L,3L,2L,3L,4L,3L,4L,3L,4L,5L,4L,5L,4L,5L,6L,5L,6L,5L,6L,5L,6L,7L,6L,7L,6L,7L,6L,7L,8L,7L,8L,7L,8L,7L,8L,7L,8L,9L,8L,9L,8L,9L,8L,9L,8L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,10L,11L,12L,11L,12L,11L,12L,11L,12L,11L,12L,11L,12L,11L,12L,13L,12L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116939Inst : IEnumerable<long>
{
public static readonly long[] Value=A116939.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116939.Bytes);
public long this[int i]=>Value[i];

public static A116939Inst Instance=new A116939Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A116940
{
public static readonly long[] Value={ 0L,3L,6L,11L,16L,23L,30L,39L,48L,59L,70L,83L,96L,111L,126L,143L,160L,179L,198L,219L,240L,263L,286L,311L,336L,363L,390L,419L,448L,479L,510L,543L,576L,611L,646L,683L,720L,759L,798L,839L,880L,923L,966L,1011L,1056L,1103L,1150L,1199L,1248L,1299L,1350L,1403L,1456L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A116940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A116940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A116940Inst : IEnumerable<long>
{
public static readonly long[] Value=A116940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A116940.Bytes);
public long this[int i]=>Value[i];

public static A116940Inst Instance=new A116940Inst();

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